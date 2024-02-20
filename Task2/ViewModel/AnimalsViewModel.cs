using System.ComponentModel;
using System.Runtime.CompilerServices;
using Task2.Model;

namespace Task2.ViewModel
{
    public class AnimalsViewModel : INotifyPropertyChanged
    {
        public Panther Panther { get; set; }
        public Dog Dog { get; set; }
        public Turtle Turtle { get; set; }
        private double _dogSpeed;
        private double _pantherSpeed;
        private double _turtleSpeed;
        private string _message;

        public event PropertyChangedEventHandler PropertyChanged;

        public event Action PantherOnVoiceCommand;
        public event Action DogOnVoiceCommand;

        public event EventHandler<string> ShowVoiceMessage;

        public void PantherOnVoice() 
        { 
            Panther.OnVocalize();
        }
        
        public void DogOnVoice() 
        { 
            Dog.OnVocalize();
        }

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
            Dog = new Dog();
            Panther = new Panther();
            Turtle = new Turtle();

            DogSpeed = 0;
            PantherSpeed = 0;
            TurtleSpeed = 0;

            DogOnVoiceCommand += DogOnVoice; 
            PantherOnVoiceCommand += PantherOnVoice;
            
            Dog.Voice += Voice;
            Panther.Voice += Voice;
        }

        private void Voice(string message)
        {
            Message = message;
        }

        private void OnShowVoiceMessage(string message)
        {
            ShowVoiceMessage?.Invoke(this, message);
        }

        public void DogMove()
        {
            if (Dog.Move())
            {
                DogSpeed = Dog.Speed;
            }
        }

        public void DogStand()
        {
            if (Dog.Stand())
            {
                DogSpeed = Dog.Speed;
            }
        }

        public void PantherMove()
        {
            if (Panther.Move())
            {
                PantherSpeed = Panther.Speed;
            }
        }


        public void PantherStand()
        {
            if (Panther.Stand())
            {
                PantherSpeed = Panther.Speed;
            }
        }

        public void TurtleMove()
        {
            if (Turtle.Move())
            {
                TurtleSpeed = Turtle.Speed;
            }
        }

        public void TurtleStand()
        {
            if (Turtle.Stand())
            {
                TurtleSpeed = Turtle.Speed;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}