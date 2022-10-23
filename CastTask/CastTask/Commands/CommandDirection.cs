using CastTask.Models;
using CastTask.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CastTask.Commands
{
    public class CommandDirection : CommandBase
    {

        private CastAppModel _app;
        private ViewModelControls _controls;
        private Direction _direction;

        public CommandDirection(ViewModelControls controls, CastAppModel app, Direction direction)
        {
            _controls = controls;
            _app = app;
            _direction = direction;
        }

        public override void Execute(object? parameter)
        {
            if (_app.IsConnected) 
            {
                _app.SendMessage(_direction.ToString().Substring(0,1)+_app.Speed.ToString());    
            }
            else MessageBox.Show("NotConnected.");
        }
    }
}
