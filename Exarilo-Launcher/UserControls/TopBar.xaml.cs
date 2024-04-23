using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace Exarilo_Launcher
{
    /// <summary>
    /// Interaction logic for TopBar.xaml
    /// </summary>
    public partial class TopBar : UserControl
    {
        public TopBar() {InitializeComponent();}
        private void Window_OnMouseDown(object sender, MouseButtonEventArgs e) { if (e.LeftButton == MouseButtonState.Pressed) Application.Current.MainWindow.DragMove(); }
        private void CloseButton_Click(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }
        private void MaximizeButton_Click(object sender, RoutedEventArgs e) { AdjustWindowSize(); }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e) { Application.Current.MainWindow.WindowState = WindowState.Minimized; }
        private static void AdjustWindowSize() { Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized; }

        private void DragableArea_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            double currentOpacity = Application.Current.MainWindow.Opacity;
            double newOpacity = e.Delta > 0 ? (currentOpacity < 1.0 ? currentOpacity + 0.1 : currentOpacity) : (currentOpacity > 0.4 ? currentOpacity - 0.1 : currentOpacity);
            Application.Current.MainWindow.Opacity = newOpacity;
            e.Handled = true;
        }
    }
}
