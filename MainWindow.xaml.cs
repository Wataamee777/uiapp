using System.Windows;

namespace uiApp
{
    public partial class MainWindow : Window
    {
        private VideoWindow videoWindow;

        public MainWindow()
        {
            InitializeComponent();
            videoWindow = new VideoWindow();
            videoWindow.Show(); // 起動時に表示
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (videoWindow.IsVisible)
            {
                videoWindow.Hide();
                ToggleButton.Content = "非表示";
            }
            else
            {
                videoWindow.Show();
                ToggleButton.Content = "表示中";
            }
        }
    }
}
