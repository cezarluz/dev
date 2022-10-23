using CastTask.Commands;
using CastTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CastTask.ViewModels
{
    public class ViewModelControls : ViewModelBase
    {
        public CastAppModel _castApp;

        private string _isConnected;
        public string IsConnected
        {
            get { return _castApp.IsConnected.ToString(); }
            set { _castApp.IsConnected = bool.Parse(value) ; OnPropertyChanged(nameof(IsConnected)); }
        }

        private int _speed;
        public int Speed
        {
            get { return _castApp.Speed; }
            set { _castApp.Speed = value; OnPropertyChanged(nameof(Speed)); }
        }

        public ICommand ConnectCommand { get; }
        public ICommand UpCommand { get; }
        public ICommand DownCommand { get; }
        public ICommand LeftCommand { get; }
        public ICommand RightCommand { get; }

        public ViewModelControls(CastAppModel castApp)
        {
            _castApp = castApp;
            ConnectCommand = new CommandConnect(this, castApp);
            UpCommand = new CommandDirection(this, castApp, Direction.UP);
            DownCommand = new CommandDirection(this, castApp, Direction.DOWN);
            LeftCommand = new CommandDirection(this, castApp, Direction.LEFT);
            RightCommand = new CommandDirection(this, castApp, Direction.RIGHT);
        }

    }
}
