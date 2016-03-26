using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndreyTools.TimeClicker
{
    public partial class TimerClickerForm : Form
    {
        private Label _label;

        private NumericUpDown _hrsNumeric;
        private NumericUpDown _minNumeric;
        private NumericUpDown _secNumeric;
        private NumericUpDown _timeRepeater;

        private Timer _timer;

        private int _seconds;
        private int _startseconds;
        private bool _isStarted;
        private int _timeRepeaterCounter;

        private Button _startButton;


        public TimerClickerForm()
        {
            InitializeComponent();
            _label = time;
            _hrsNumeric = hrsNumeric;
            _minNumeric = minNumeric;
            _secNumeric = secNumeric;
            _timer = timer;
            _timer.Interval = 1000;
            _isStarted = false;
            _startButton = startButton;
            _timeRepeater = timeRepeater;
            _timeRepeaterCounter = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!_isStarted)
            {
                _timer.Start();
                _startButton.Text = "Stop";
                _isStarted = true;
            }
            else
            {
                _timer.Stop();
                _startButton.Text = "Start";
                _isStarted = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _seconds = TimeToSeconds((int)_hrsNumeric.Value, (int)_minNumeric.Value, (int)_secNumeric.Value);
            _startseconds = _seconds;
            _timeRepeaterCounter = 0;
            _label.Text = SecondsToTime(_seconds);
        }

        private static int TimeToSeconds(int hours, int minutes, int seconds)
        {
            return (hours * 60 + minutes) * 60 + seconds;
        }

        private static string SecondsToTime(int seconds)
        {
            int hrsCount = seconds / 3600;
            int minCount = (seconds - hrsCount * 3600) / 60;
            int secCount = seconds - hrsCount * 3600 - minCount * 60;
            string hrsString = hrsCount < 10 ? "0" + hrsCount : hrsCount.ToString();
            string minString = minCount < 10 ? "0" + minCount : minCount.ToString();
            string secString = secCount < 10 ? "0" + secCount : secCount.ToString();
            return String.Format("{0}:{1}:{2}", hrsString, minString, secString);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _seconds--;
            _label.Text = SecondsToTime(_seconds);
            if (_seconds <= 0)
            {
                _timeRepeaterCounter++;
                if (_timeRepeaterCounter >   (int)_timeRepeater.Value)
                {
                    _seconds = _startseconds;
                }
                else
                {
                    _timer.Stop();
                }
            }

        }
    }
}
