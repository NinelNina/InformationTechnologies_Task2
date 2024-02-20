using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task2.ViewModel;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AnimalsViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new AnimalsViewModel();
            DataContext = _viewModel;
        }

        private void MoveDog_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.DogMove();
        }

        private void MovePanther_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.PantherMove();
        }

        private void MoveTurtle_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.TurtleMove();
        }
    }
}