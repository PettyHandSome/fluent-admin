using FluentAdmin.UWP.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FluentAdmin.UWP.Views
{
    public sealed partial class MasterDetailDetailControl : UserControl
    {
        public Order MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as Order; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem",typeof(Order),typeof(MasterDetailDetailControl),new PropertyMetadata(null));

        public MasterDetailDetailControl()
        {
            InitializeComponent();
        }
    }
}
