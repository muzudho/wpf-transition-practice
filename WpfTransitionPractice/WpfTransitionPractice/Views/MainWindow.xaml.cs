namespace WpfTransitionPractice
{
    using Livet.Commands;
    using System.Windows;
    using System.Windows.Input;
    using WpfTransitionPractice.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // public ICommand OpeningAlice { get; }

        public MainWindow()
        {
            InitializeComponent();

            // this.OpeningAlice = new ViewModelCommand(() => ((MainWindowModel)this.DataContext).OpenAlice());
        }
    }
}
