using System.Windows;

namespace Exercise3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GrowButton_Click(object sender, RoutedEventArgs e)
        {
            theRectangle.Width = Math.Min(theRectangle.Width + 10, paperCanvas.Width - theRectangle.Margin.Left);
        }

        private void ShrinkButton_Click(object sender, RoutedEventArgs e)
        {
            theRectangle.Width = Math.Max(theRectangle.Width - 10, 0);
        }
    }

}