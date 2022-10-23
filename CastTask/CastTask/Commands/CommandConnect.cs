using CastTask.Models;
using CastTask.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CastTask.Commands
{
    public class CommandConnect : CommandBase
    {
        private CastAppModel _app;
        private ViewModelControls _controls;

        public CommandConnect(ViewModelControls controls, CastAppModel app)
        {
            _controls = controls;
            _app = app;
        }

        public override void Execute(object? parameter)
        {
            if(_app.ConnectToTcpServer()) 
                _controls.IsConnected = true.ToString();
        }

    }
}
