using Statistici.service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistici
{
    class DataChart
    {
        private Chart chart;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private ServiceValidari serviceValidari;
        private ServiceTemperaturi serviceTemperaturi;
        private Series seriesValidariZi;
        private Series seriesTemperaturaZi;
        public DataChart(ServiceTemperaturi serviceTemperaturi, ServiceValidari serviceValidari, Chart chart, DateTimePicker dateTimePickerStart, DateTimePicker dateTimePickerEnd)
        {
            this.serviceTemperaturi = serviceTemperaturi;
            this.serviceValidari = serviceValidari;
            this.chart = chart;
            this.dateTimePickerStart = dateTimePickerStart;
            this.dateTimePickerEnd = dateTimePickerEnd;
        }

        public Chart get_chart()
        {
            return this.chart;
        }

        public Series get_series_validari()
        {
            return this.seriesValidariZi;
        }

        public Series get_series_temperatura()
        {
            return this.seriesTemperaturaZi;
        }
        
        public void load()
        {
            chart.Series.Clear();

            chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            chart.ChartAreas["ChartArea1"].AxisY2.MajorGrid.LineColor = Color.Gainsboro;

            chart.ChartAreas["ChartArea1"].AxisY.Interval = 100;
            chart.ChartAreas["ChartArea1"].AxisY2.Interval = 2;
            chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            seriesValidariZi = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Validari/Zi",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                YAxisType = AxisType.Primary,
                ChartType = SeriesChartType.Line,
            };

            this.chart.Series.Add(seriesValidariZi);

            this.chart.ChartAreas["ChartArea1"].AxisY2.Enabled = AxisEnabled.True;

            seriesTemperaturaZi = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Temperatura/Zi",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                YAxisType = AxisType.Secondary,
                ChartType = SeriesChartType.Line
            };

            this.chart.Series.Add(seriesTemperaturaZi);

            

            DateTime begin = this.dateTimePickerStart.Value;
            DateTime end = this.dateTimePickerEnd.Value;

            while (begin < end)
            {
                int day = Int32.Parse(begin.Date.Day.ToString());
                int month = Int32.Parse(begin.Date.Month.ToString());
                int year = Int32.Parse(begin.Date.Year.ToString());
                seriesValidariZi.Points.AddXY(begin, serviceValidari.get_nr_validari(day, month, year));
                seriesTemperaturaZi.Points.AddXY(begin, serviceTemperaturi.get_temp_min(day, month, year));
                begin = begin.AddDays(1);
            }

            chart.Invalidate();
        }
    }

}
