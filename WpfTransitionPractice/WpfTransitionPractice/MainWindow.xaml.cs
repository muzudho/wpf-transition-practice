namespace WpfTransitionPractice
{
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// ユーザーのアクションと、その処理を結びつけるもの
        /// </summary>
        public static RoutedCommand OpeningAlice = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpeningAlice_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var window = new AliceWindow();
            window.Show();
        }

        private void OpeningAlice_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
