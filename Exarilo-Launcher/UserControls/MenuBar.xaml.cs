using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace Exarilo_Launcher
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        public delegate void MenuItemClickedEventHandler(object sender, RoutedEventArgs e);
        public event MenuItemClickedEventHandler MenuItemClicked;

        public MenuBar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Background = (button != BtAdd) ? (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF2D2D30")) : button.Background;
                MenuItemClicked?.Invoke(sender, e);
            }
        }
    }
}
