using System.Windows;
using Task2.ViewModel;

namespace Task2;

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

        _viewModel.ShowVoiceMessage += ShowVoiceMessage;
    }

    private void MoveDog_Click(object sender, RoutedEventArgs e)
    {
        _viewModel.DogMove();
    }

    private void DogOnVoice(object sender, RoutedEventArgs e)
    {
        _viewModel.Dog.OnVocalize();
    }

    private void PantherOnVoice(object sender, RoutedEventArgs e)
    {
        _viewModel.Panther.OnVocalize();
    }
    
    private void PantherOnClimb(object sender, RoutedEventArgs e)
    {
        _viewModel.Panther.OnClimbTree();
    }

    private void ShowVoiceMessage(object sender, string message)
    {
        MessageBox.Show(message);
    }

    private void StandDog_Click(object sender, RoutedEventArgs e)
    {
        _viewModel.DogStand();
    }

    private void MovePanther_Click(object sender, RoutedEventArgs e)
    {
        _viewModel.PantherMove();
    }

    private void MoveTurtle_Click(object sender, RoutedEventArgs e)
    {
        _viewModel.TurtleMove();
    }

    private void StandPanther_Click(object sender, RoutedEventArgs e)
    {
        _viewModel.PantherStand();
    }

    private void StandTurtle_Click(object sender, RoutedEventArgs e)
    {
        _viewModel.TurtleStand();
    }

}