using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MaterialColorWheelDemo
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            TimeText = DateTime.Now.ToShortTimeString();
            var statusTimer = new DispatcherTimer();
            statusTimer.Tick += DispatcherTimer_Tick;
            statusTimer.Interval = new TimeSpan(0, 0, 1);
            statusTimer.Start();
            SetStatusBarText("");
        }

        private void DispatcherTimer_Tick(object sender, EventArgs eventArgs)
        {
            TimeText = DateTime.Now.ToShortTimeString();
        }

        private void SetStatusBarText(string text)
        {
            StatusBarText = text;
        }

        private string _statusBarText;

        /// <summary>
        ///     Gets or sets the status bar text.
        /// </summary>
        /// <value>The status bar text.</value>
        public string StatusBarText
        {
            get { return _statusBarText; }
            set
            {
                if (_statusBarText != value)
                {
                    _statusBarText = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _timeText;

        /// <summary>
        ///     Gets or sets the time text.
        /// </summary>
        /// <value>The time text.</value>
        public string TimeText
        {
            get { return _timeText; }
            set
            {
                if (_timeText != value)
                {
                    _timeText = value;
                    OnPropertyChanged();
                }
            }
        }

        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
