# How to display a list of chart in Xamarin.Forms
This example explains how to load Chat inside a ListView.Please refer KB links for more details,

[How to display a list of chart in Xamarin.Forms](https://www.syncfusion.com/kb/11341/?utm_medium=listing&utm_source=github-examples)

SfChart provides support to add chart in ListView control. You can add the chart in ListView with the help of ItemTemplate, by using the DataTemplate for the customized ViewCell.

The following code illustrates how to add the chart in ListView.

**[XAML]**
```
<ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    
    <ListView x:Name="listView" ItemsSource="{Binding SeriesItems}" RowHeight="200" >
        <ListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <StackLayout >
                        <chart:SfChart  VerticalOptions="FillAndExpand" Series="{Binding Series}" >
                            <chart:SfChart.Title>
                                <chart:ChartTitle Text="{Binding ChartTitle}"  FontAttributes="Bold"  TextColor="Aqua"/>
                            </chart:SfChart.Title>
                            <chart:SfChart.PrimaryAxis>
                                <chart:CategoryAxis/>
                            </chart:SfChart.PrimaryAxis>
                            <chart:SfChart.SecondaryAxis>
                                <chart:NumericalAxis  />
                            </chart:SfChart.SecondaryAxis>
                        </chart:SfChart>
                    </StackLayout>
                </ViewCell>
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
```
**C#**
```
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
```
**C#**
```
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
```

**C#**
```
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
```
## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

