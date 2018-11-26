using System.Windows;
using Engine.ViewModels;

namespace MainApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AccountCreationView : Window
    {
        private readonly AccountCreationViewModel _viewModel = new AccountCreationViewModel();

        public AccountCreationView()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }

        private void OnClick_ValidatePassword(object sender, RoutedEventArgs e)
        {
            _viewModel.ValidatePassword();
        }
    }
}
