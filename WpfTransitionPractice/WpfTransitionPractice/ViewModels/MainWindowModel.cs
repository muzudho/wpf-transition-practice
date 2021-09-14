namespace WpfTransitionPractice.ViewModels
{
    using Livet;
    using Livet.Commands;
    using System.Windows.Input;

    public class MainWindowModel : ViewModel
    {
        /*
        /// <summary>
        /// ユーザーのアクションと、その処理を結びつけるもの
        /// </summary>
        public static RoutedCommand OpeningAlice = new RoutedCommand();

        private void OpeningAlice_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var window = new AliceWindow();
            window.Show();
        }

        private void OpeningAlice_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        */

        /// <summary>
        /// https://unity-memo.hatenablog.com/entry/2015/01/24/090328
        /// </summary>
        private ViewModelCommand _openingAlice;

        public ViewModelCommand OpeningAlice
        {
            get
            {
                if (_openingAlice == null)
                {
                    _openingAlice = new ViewModelCommand(OpenAlice);
                }
                return _openingAlice;
            }
        }

        public void OpenAlice()
        {
            var window = new AliceWindow();
            window.Show();
        }
    }
}
