using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData;
using FinancialData.AlphaVantage;
using FinancialData.HistoricalOptionData;
using DataMAN.Options;

namespace DataMAN
{
    public enum WindowMode { Chart , Trade , Positions}

    public partial class TrainerWindow : Form
    {
        private TrainerSimulation _sim;

        public TrainerWindow()
        {
            InitializeComponent();
        }

        public void Show(double cash , DateTime simDate , Stock stock)
        {
            _sim = new TrainerSimulation();
            _sim.Start(cash, simDate, stock);
            _sim.NextDaySimulated += new EventHandler(NextDaySimulated);
            _sim.TradeMade += new EventHandler(TradeMade);

            FillPortfolioUI();

            FillStockInfoUI(stock);

            chartPanel1.Initialize(_sim.StockData);

            chainPanel1.Initialize(cash, simDate, stock);
            chainPanel1.OrderPlaced += new ChainPanel.OrderPlacedClickedHandler(PlaceOrder);

            positionsPanel1.Initialize(_sim.Positions , simDate);
            positionsPanel1.SellPositionEvent += new PositionsPanel.SellPositionHandler(PlaceOrder);
            positionsPanel1.SymbolClicked += new PositionsPanel.SymbolClickedHandler(LoadStock);

            watchListUI1.Link(chartPanel1._trainerChart);
            watchListUI1.LoadStockEvent += new WatchListUI.LoadStockHandler(LoadStock);

            SwitchWindowMode(WindowMode.Chart);

            this.Show();
            
        }

        private void FillStockInfoUI(Stock stock)
        {
            stockInfoUI1.SetStock(stock, _sim.SimulationDate);
        }

        private async void FillPortfolioUI()
        {
            double totalBalance = await _sim.TotalBalance();
            portofolioUI1.SetValues(_sim.Cash, totalBalance);
        }

        private void NextDaySimulated(object sender , EventArgs e)
        {
            chainPanel1.Clear();
            FillPortfolioUI();
            chartPanel1.LoadStockData(_sim.StockData);
            chainPanel1.LoadStock(_sim.Stock, _sim.SimulationDate);
            positionsPanel1.Fill(_sim.Positions, _sim.SimulationDate);
            FillStockInfoUI(_sim.Stock);
        }

        private void TrainerWindow_SizeChanged(object sender, EventArgs e)
        {
            chainPanel1.RelocateChainUI();
            chartPanel1.Render();
            chartPanel1.Draw();
        }

        private void TrainerWindow_Activated(object sender, EventArgs e)
        {
            chartPanel1.Draw();
        }

        private void LoadStockChart(Stock stock, Api.Interval interval)
        {
            LoadStock(stock);
        }

        private void LoadStock(Stock stock)
        {
            if (stock.StockSymbol.Length > 0)
            {
                if (OptionChain.DataAvailible(stock, _sim.SimulationDate))
                {
                    _sim.ChangeStock(stock);
                    chartPanel1.LoadStockData(_sim.StockData);
                    chainPanel1.LoadStock(stock, _sim.SimulationDate);
                    FillStockInfoUI(stock);
                }
            }
        }

        private void SwitchWindowMode(WindowMode mode)
        {
            if(mode == WindowMode.Chart)
            {
                panelChart.Visible = true;
                panelOptionTrade.Visible = false;
                panelPositions.Visible = false;
                chartPanel1.Render();
                chartPanel1.Draw();
            }
            if (mode == WindowMode.Trade)
            {
                panelChart.Visible = false;
                panelOptionTrade.Visible = true;
                panelPositions.Visible = false;
            }
            if (mode == WindowMode.Positions)
            {
                panelChart.Visible = false;
                panelOptionTrade.Visible = false;
                panelPositions.Visible = true;
            }
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            SwitchWindowMode(WindowMode.Chart);
        }

        private void buttonChain_Click(object sender, EventArgs e)
        {
            SwitchWindowMode(WindowMode.Trade);
        }

        private void buttonPositions_Click(object sender, EventArgs e)
        {
            SwitchWindowMode(WindowMode.Positions);
        }

        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            _sim.NextTradeDay();
        }

        private void buttonPrevDay_Click(object sender, EventArgs e)
        {
            _sim.RollBackOneDay();
        }

        private void PlaceOrder(OptionTrade trade)
        {
            _sim.MakeTrade(trade);
        }

        private void TradeMade(object sender, EventArgs e)
        {
            FillPortfolioUI();
            positionsPanel1.Fill(_sim.Positions, _sim.SimulationDate);
        }
    }
}
