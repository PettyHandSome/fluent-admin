using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using FluentAdmin.UWP.Models;
using FluentAdmin.UWP.Services;

using Windows.UI.Xaml.Controls;

namespace FluentAdmin.UWP.Views
{
    public sealed partial class ChartPage : Page, INotifyPropertyChanged
    {
        // TODO: UWPTemplates: Change the chart as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/radchart/getting-started
        public ChartPage()
        {
            InitializeComponent();
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
