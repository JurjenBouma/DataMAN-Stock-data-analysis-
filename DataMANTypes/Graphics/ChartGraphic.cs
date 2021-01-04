using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using FinancialData.AlphaVantage;
using System.Windows.Forms;

namespace DataMAN
{
    public class ChartGraphic
    {
        public Color GridColor = Color.FromArgb(42,42,42);
        public Color BackGroundColor = Color.FromArgb(27, 27, 27);
        public Color[] GraphColors;

        public int GridDivisions
        {
            get { return _gridDivisions; }
            set { if (value > 0) _gridDivisions = value; }
        }

        private int _renderWidth;
        private int _renderHeight;
        private SolidBrush _posCandleBrush = new SolidBrush(Color.FromArgb(0, 220, 60));
        private SolidBrush _negCandleBrush = new SolidBrush(Color.FromArgb(220, 0, 60));
        private Pen _posCandlePen;
        private Pen _negCandlePen;
        private int _gridDivisions = 10;
        private int _candleMargin = 3;
        private int _candleWidth;
        private Bitmap _renderMap;
        private Bitmap _cursorMap;
        private Graphics _graphGraphics;
        private Graphics _cursorGraphics;
        private double _priceHighest;
        private double _priceLowest;

        public ChartGraphic()
        {
            _posCandlePen = new Pen(_posCandleBrush.Color);
            _negCandlePen = new Pen(_negCandleBrush.Color);
            GraphColors = new Color[5]
            {
                Color.Pink,Color.WhiteSmoke, Color.Yellow,Color.SteelBlue,Color.Purple
            };
        }

        public void DrawChart(PictureBox renderbox)
        {
            if (_graphGraphics != null && _renderMap != null)
            {
                renderbox.Refresh();
            }
        }

        public void RenderChart(PictureBox renderbox, StockData stockData, int startIndex, int count)
        {
            _renderWidth = renderbox.Width;
            _renderHeight = renderbox.Height;
            _renderMap = new Bitmap(_renderWidth,_renderHeight);
            _cursorMap = new Bitmap(_renderWidth, _renderHeight);

            _graphGraphics = Graphics.FromImage(_renderMap);

            _cursorGraphics = Graphics.FromImage(_cursorMap);
            renderbox.BackgroundImage = _renderMap;
            renderbox.Image = _cursorMap;

            DrawGrid();
            if (stockData.TimeSeries.DataPoints.Count > 0)
            {    
                _priceHighest = stockData.TimeSeries.DataPoints[startIndex].High;
                _priceLowest = stockData.TimeSeries.DataPoints[startIndex].Low;

                foreach (StockDataPoint point in stockData.TimeSeries.DataPoints.GetRange(startIndex, count))
                {
                    if (point.Low < _priceLowest)
                        _priceLowest = point.Low;

                    if (point.High > _priceHighest)
                        _priceHighest = point.High;
                }
                    
                DrawCandles(stockData, startIndex, count);

                DrawStockInfo(stockData);
            }
        }

        public void RenderChart(PictureBox renderbox, StockData stockData, int startIndex, int count , GraphData[] additionalGraphs)
        {
            RenderChart(renderbox, stockData, startIndex, count);

            if(additionalGraphs.Length > 0)
            {
                for (int i = 0; i < additionalGraphs.Length; i++)
                {
                    if (count >= 2 && stockData.TimeSeries.DataPoints.Count >= startIndex + count)
                    {
                        DateTime startDate = stockData.TimeSeries.DataPoints[startIndex].DateTime;
                        DateTime endDate = stockData.TimeSeries.DataPoints[startIndex + count -1].DateTime;
                        int graphDataStartIndex = additionalGraphs[i].FindDateIndex(startDate);
                        int graphCount = additionalGraphs[i].DataPoints.Count - graphDataStartIndex >= count ? count : additionalGraphs[i].DataPoints.Count - graphDataStartIndex;
                        DateTime graphStartDate = additionalGraphs[i].DataPoints[graphDataStartIndex].DateTime;
                        int graphStockDataIndex = stockData.FindDateIndex(graphStartDate);
                        int rightShift = graphStockDataIndex - startIndex;
                        Color graphColor = GraphColors[i%4];

                        if (additionalGraphs[i].DataPoints[graphDataStartIndex].DateTime >= startDate && additionalGraphs[i].DataPoints[graphDataStartIndex].DateTime <= endDate)
                            DrawGraphData(additionalGraphs[i], graphDataStartIndex, graphCount , rightShift, graphColor);
                    }
                }
            }

        }

        private void DrawGraphData(GraphData graphData, int startIndex, int count , int rightShift, Color color)
        {
            if (graphData.DataPoints.Count >= 2)
            {
                double highest = graphData.DataPoints[startIndex].GraphData;
                double lowest = graphData.DataPoints[startIndex].GraphData;        

                foreach (GraphDataPoint point in graphData.DataPoints.GetRange(startIndex, count))
                {
                    if (point.GraphData < lowest)
                        lowest = point.GraphData;

                    if (point.GraphData > highest)
                        highest = point.GraphData;
                }

                double relativeRange = highest - lowest;
                Pen brush = new Pen(color);

                if (count >= 2 && graphData.DataPoints.Count >= startIndex + count)
                {
                    if (relativeRange > 0 && _candleWidth > 0)
                    {
                        int drawBottom = _renderHeight - _candleMargin * 2;
                        int drawSpace = _renderHeight - _candleMargin * 4;
                        double pixelsPerPoint = drawSpace / relativeRange;

                        for (int i = 1; i < count; i++)
                        {
                            double relativeGraphData = graphData.DataPoints[startIndex + i].GraphData - lowest;
                            double prevRelativeGraphData = graphData.DataPoints[startIndex + (i-1)].GraphData - lowest;

                            float x1 = _candleMargin + (i + rightShift -1) * (_candleWidth + _candleMargin);
                            float x2 = _candleMargin + (i + rightShift) * (_candleWidth + _candleMargin);
                            float y1 = (float)(drawBottom - prevRelativeGraphData * pixelsPerPoint);
                            float y2 = (float)(drawBottom - relativeGraphData * pixelsPerPoint);

                            //Draw line
                            _graphGraphics.DrawLine(brush, x1, y1, x2, y2);
                        }
                    }
                }
            }
        }


        private void DrawCandles(StockData stockData, int startIndex, int count)
        {
            if (count > 0 && stockData.TimeSeries.DataPoints.Count >= startIndex + count)
            {
                double relativeRange = _priceHighest - _priceLowest;
                _candleWidth = (int)(_renderWidth - _candleMargin * 2f) / count - _candleMargin;
                if (_candleWidth < 0)
                    _candleWidth = 0;

                if (relativeRange > 0 && _candleWidth > 0)
                {
                    int drawBottom = _renderHeight - _candleMargin * 2;
                    int drawSpace = _renderHeight - _candleMargin * 4;
                    double pixelsPerPoint = drawSpace / relativeRange;       

                    for (int i = 0; i < count; i++)
                    {
                        double change = stockData.TimeSeries.DataPoints[startIndex + i].Close - stockData.TimeSeries.DataPoints[startIndex + i].Open;
                        double relativeOpen = stockData.TimeSeries.DataPoints[startIndex + i].Open - _priceLowest;
                        double relativeHigh = stockData.TimeSeries.DataPoints[startIndex + i].High - _priceLowest;
                        double relativeClose = stockData.TimeSeries.DataPoints[startIndex + i].Close - _priceLowest;
                        double relativeLow = stockData.TimeSeries.DataPoints[startIndex + i].Low - _priceLowest;

                        if (change < 0)
                        {
                            float x = _candleMargin + i * (_candleWidth + _candleMargin);
                            float y = (float)(drawBottom - relativeOpen * pixelsPerPoint);
                            float height = (float)(change * -1 * pixelsPerPoint);
                            if (height < 1)
                                height = 1;
                            float wickLength = (float)((relativeHigh - relativeOpen) * pixelsPerPoint);
                            float tailLenght = (float)((relativeClose - relativeLow) * pixelsPerPoint);

                            //Draw the candle base
                            _graphGraphics.FillRectangle(_negCandleBrush, x, y, _candleWidth, height);
                            //Draw wick
                            _graphGraphics.DrawLine(_negCandlePen, x + _candleWidth * 0.5f, y - wickLength, x + _candleWidth * 0.5f, y);
                            //Draw tail
                            _graphGraphics.DrawLine(_negCandlePen, x + _candleWidth * 0.5f, y + height, x + _candleWidth * 0.5f, y + height + tailLenght);
                        }
                        else
                        {
                            float x = _candleMargin + i * (_candleWidth + _candleMargin);
                            float y = (float)(drawBottom - relativeClose * pixelsPerPoint);
                            float height = (float)(change * pixelsPerPoint);
                            if (height < 1)
                                height = 1;
                            float wickHeight = (float)((relativeHigh - relativeClose) * pixelsPerPoint);
                            float tailLenght = (float)((relativeOpen - relativeLow) * pixelsPerPoint);

                            //Draw the candle base
                            _graphGraphics.FillRectangle(_posCandleBrush, x, y, _candleWidth, height);
                            //Draw wick
                            _graphGraphics.DrawLine(_posCandlePen, x + _candleWidth * 0.5f, y - wickHeight, x + _candleWidth * 0.5f, y);
                            //Draw tail
                            _graphGraphics.DrawLine(_posCandlePen, x + _candleWidth * 0.5f, y + height, x + _candleWidth * 0.5f, y + height + tailLenght);
                        }
                    }
                }
            }
        }

        private void DrawGrid()
        {
            _graphGraphics.FillRectangle(new SolidBrush(BackGroundColor),0,0, _renderWidth, _renderHeight);

            Pen dashedPen = new Pen(GridColor);
            dashedPen.DashStyle = DashStyle.Dash;

            int lineSpace = (_renderHeight - _candleMargin * 4) / (_gridDivisions-1);
            for (int i=0; i< _gridDivisions; i++)
            {
                int lineHeight = (_renderHeight - _candleMargin * 2) - lineSpace * i;

                _graphGraphics.DrawLine(dashedPen, 0, lineHeight, _renderWidth, lineHeight);
            }  
        }

        private void DrawStockInfo(StockData stockData)
        {
            _graphGraphics.DrawString(stockData.MetaData.Symbol, new Font(FontFamily.GenericSansSerif, 8), Brushes.White, 10, 10);
        }

        public void DrawCursor(int mouseX, int mouseY)
        {
            Pen brush = new Pen(Color.WhiteSmoke);
            _cursorGraphics.Clear(Color.Transparent);

            int x1 = 0;
            int y1 = mouseY;
            int x2 = _renderWidth;
            int y2 = mouseY;
            _cursorGraphics.DrawLine(brush, x1, y1, x2, y2);

            x1 = mouseX;
            y1 = 0;
            x2 = mouseX;
            y2 = _renderHeight;
            _cursorGraphics.DrawLine(brush, x1, y1, x2, y2);

            double relativeRange = _priceHighest - _priceLowest;
            int drawSpace = _renderHeight - _candleMargin * 4;
            double pricePerPixel = relativeRange / drawSpace;
            double cursorPoints = _priceHighest - pricePerPixel * (mouseY - _candleMargin * 2);
            
            string pointString = cursorPoints.ToString("0.00");
            _cursorGraphics.DrawString(pointString, new Font(FontFamily.GenericSansSerif, 8), Brushes.White, _renderWidth - 50 , mouseY - 12);


        }

        public StockDataPoint PickStockData(StockData stockData , int mouseX ,int startIndex , int candleCount)
        {
            int i = (mouseX - _candleMargin) / (_candleWidth + _candleMargin);
            if (stockData.TimeSeries.DataPoints.Count > startIndex + i && startIndex + i >= 0) 
            {
                return stockData.TimeSeries.DataPoints[startIndex + i];
            }
            return new StockDataPoint();
        }
    }
}
