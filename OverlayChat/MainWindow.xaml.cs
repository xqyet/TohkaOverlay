using System.Windows;

namespace OverlayChat
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PositionWindowBottomLeft();
        }

        private void PositionWindowBottomLeft()
        {
            // Set the window position to the bottom-left corner
            this.Left = 0; // Align to the left of the screen
            this.Top = SystemParameters.WorkArea.Height - this.Height; // Align to the bottom
        }
    }
}
