namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataGrid.DataGridLoaded += DataGrid_DataGridLoaded;
        }

        private void DataGrid_DataGridLoaded(object? sender, EventArgs e)
        {
            dataGrid.HeightRequest = dataGrid.GetVisualContainer().ExtendedHeight;
            dataGrid.WidthRequest = dataGrid.GetVisualContainer().ExtendedWidth;
        }
    }
}
