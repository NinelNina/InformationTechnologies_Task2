using System.ComponentModel;
using Task2.Model;

namespace Task2.ViewModel
{
    public class AnimalsViewModel : INotifyPropertyChanged
    {
        private double _dogSpeed;
        private double _pantherSpeed;
        private double _turtleSpeed;
        private string _message;

        public event PropertyChangedEventHandler PropertyChanged;

        public double DogSpeed
        {
            get { return _dogSpeed; }
            set
            {
                _dogSpeed = value;
                OnPropertyChanged(nameof(DogSpeed));
            }
        }

        public double PantherSpeed
        {
            get { return _pantherSpeed; }
            set
            {
                _pantherSpeed = value;
                OnPropertyChanged(nameof(PantherSpeed));
            }
        }

        public double TurtleSpeed
        {
            get { return _turtleSpeed; }
            set
            {
                _turtleSpeed = value;
                OnPropertyChanged(nameof(TurtleSpeed));
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }

        public AnimalsViewModel()
        {
            // Инициализация скоростей
            DogSpeed = 0;
            PantherSpeed = 0;
            TurtleSpeed = 0;
        }

        public void DogMove()
        {
            var dog = new Dog();
            dog.Move();
            DogSpeed = dog.Speed;
        }

        public void PantherMove()
        {
            var panther = new Panther();
            panther.Move();
            PantherSpeed = panther.Speed;
        }

        public void TurtleMove()
        {
            var turtle = new Turtle();
            turtle.Move();
            TurtleSpeed = turtle.Speed;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}