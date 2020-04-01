using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SimpleSample
{
    public class ViewModel
    {
        public ObservableCollection<SeriesModel> SeriesItems { get; set; }

        public ViewModel()
        {
            SeriesItems = new ObservableCollection<SeriesModel>();
            SeriesModel model = new SeriesModel();

            SeriesItems.Add(new SeriesModel()
            {
                ChartTitle = "ColumnChart",
                Series = new ChartSeriesCollection(){ new ColumnSeries(){
                        ItemsSource=model.Data2
                    } },
            });

            SeriesItems.Add(new SeriesModel()
            {
                ChartTitle = "LineChart",
                Series = new ChartSeriesCollection(){ new LineSeries(){
                        ItemsSource=model.Data3
                    } },
            });

            SeriesItems.Add(new SeriesModel()
            {
                ChartTitle = "BarChart",
                Series = new ChartSeriesCollection(){ new BarSeries(){
                        ItemsSource=model.Data1
                    } },
            });

            SeriesItems.Add(new SeriesModel()
            {
                ChartTitle = "PieChart",
                Series = new ChartSeriesCollection(){ new PieSeries(){
                        ItemsSource=model.Data1
                    } },
            });
        }
    }

    public class SeriesModel
    {
        public SeriesModel()
        {
            Data1 = new ObservableCollection<Model>();
            Data2 = new ObservableCollection<Model>();
            Data3 = new ObservableCollection<Model>();

            Data1.Add(new Model("Jan", 10));
            Data1.Add(new Model("Feb", 15));
            Data1.Add(new Model("Mar", 20));
            Data1.Add(new Model("Apr", 15));
            Data1.Add(new Model("May", 10));

            Data2.Add(new Model("EEE", 20));
            Data2.Add(new Model("CSE", 35));
            Data2.Add(new Model("ECE", 10));
            Data2.Add(new Model("Civil", 25));
            Data2.Add(new Model("IT", 14));

            Data3.Add(new Model("Benz", 13));
            Data3.Add(new Model("Audi", 18));
            Data3.Add(new Model("Volvo", 29));
            Data3.Add(new Model("BMW", 17));
            Data3.Add(new Model("Jaguar", 19));
        }

        public ObservableCollection<Model> Data1 { get; set; }

        public ObservableCollection<Model> Data2 { get; set; }

        public ObservableCollection<Model> Data3 { get; set; }

        public string ChartTitle { get; set; }

        public ChartSeriesCollection Series { get; set; }
    }

    public class Model
    {
        public Model(string x, double y)
        {
            XValue = x;
            YValue = y;
        }

        public string XValue { get; set; }

        public double YValue { get; set; }
    }
}