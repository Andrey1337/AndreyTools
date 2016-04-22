using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Configuration;
using System.IO;

namespace AndreyTools.TimeClicker
{
    public partial class MainForm : Form
    {
        private Label _label;

        List<string> _points;

        private int[] _secArray;
        private Point[] _pointsArray;

        private NumericUpDown _hrsNumeric;
        private NumericUpDown _minNumeric;
        private NumericUpDown _secNumeric;

        private delegate void controller();

        private Timer _timer;
        string _path;

        private int _seconds;
        private bool _isStarted;

        private Button _startButton;

        private GlobalHotkey _ghtAddPoint;
        private enum HotKeys { AddPoint }
        private enum Tabs { TimeClicker }

        public MainForm()
        {
            InitializeComponent();
            _points = new List<string>();
            _path = ConfigurationSettings.AppSettings["Path"];
            _ghtAddPoint = new GlobalHotkey((int)HotKeys.AddPoint, Constants.ALT + Constants.SHIFT, Keys.A, this);
            LoadFromFile(_path);
            _label = time;
            _hrsNumeric = hrsNumeric;
            _minNumeric = minNumeric;
            _secNumeric = secNumeric;
            _timer = timer;
            _timer.Interval = 1000;
            _isStarted = false;
            _startButton = startButton;
            UpdateListbox();
        }

        public void LoadFromFile(string path)
        {
            if (File.Exists(path))
            {
                _points = File.ReadAllLines(path).ToList();
            }
        }

        public void SaveToFile(string path)
        {
            File.WriteAllLines(path, _points);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                switch (m.WParam.ToInt32())
                {
                    case (int)HotKeys.AddPoint:
                        Controller((int)Tabs.TimeClicker, AddPoint);
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private bool Controller(int tabId, controller c)
        {
            if (tabId == tabControl1.SelectedIndex)
            {
                c();
                return true;
            }
            return false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!_isStarted)
            {
                _secArray = new int [_points.Count];
                _pointsArray = new Point[_points.Count];

                foreach(string text in _points)
                {
                    int xIndex = text.LastIndexOf("X:");
                    int yIndex = text.IndexOf("Y:");
                    string x ="";
                    for (int i = xIndex; xIndex < yIndex; i++)
                        x += text[i];
                }

                _timer.Start();
                _startButton.Text = "Stop";
                _isStarted = true;
                _points.Sort();
                UpdateListbox();
                panel1.Enabled = false;
            }
            else
            {
                _timer.Stop();
                _startButton.Text = "Start";
                _isStarted = false;
                panel1.Enabled = true;
            }
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
            _seconds++;
        }

        public void UpdateListbox()
        {
            listBox.DataSource = null;
            listBox.DataSource = _points;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text.Trim();
            if (description == "")
                description = "Without Description";
            _points.Add(CreatePointString((int)_hrsNumeric.Value, (int)_minNumeric.Value, (int)_secNumeric.Value, (int)xNumeric.Value, (int)yNumeric.Value, description));
            UpdateListbox();
        }

        private void AddPoint()
        {
            if (!_isStarted)
            {
                if (Cursor.Current != null)
                {
                    Cursor = new Cursor(Cursor.Current.Handle);
                    xNumeric.Value = Cursor.Position.X;
                    yNumeric.Value = Cursor.Position.Y;
                }
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > -1)
            {
                _points.RemoveAt(listBox.SelectedIndex);
                /*if(listBox.SelectedIndex > points.Count)
                {
                    listBox.SelectedIndex--;
                }*/
            }
            UpdateListbox();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > 0)
            {
                string text = _points[listBox.SelectedIndex];
                _points[listBox.SelectedIndex] = _points[listBox.SelectedIndex - 1];
                _points[listBox.SelectedIndex - 1] = text;
                UpdateListbox();
                listBox.SelectedIndex--;
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < _points.Count - 1)
            {
                string text = _points[listBox.SelectedIndex];
                _points[listBox.SelectedIndex] = _points[listBox.SelectedIndex + 1];
                _points[listBox.SelectedIndex + 1] = text;
                UpdateListbox();
                listBox.SelectedIndex++;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                string description = descriptionTextBox.Text.Trim();
                if (description == "")
                    description = "Without Description";
                _points[listBox.SelectedIndex] = CreatePointString((int)_hrsNumeric.Value, (int)_minNumeric.Value, (int)_secNumeric.Value, (int)xNumeric.Value, (int)yNumeric.Value, description);
                UpdateListbox();
            }
        }

        private string CreatePointString(int hours, int minutes, int seconds, int x, int y, string description)
        {
            return String.Format("{0}:{1}:{2} | X:{3}, Y:{4} | {5}", hours, minutes, seconds, x, y, description);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile(_path);
            if (!_ghtAddPoint.Unregiser())
                MessageBox.Show("Some Hotkey failed to unregister!");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!_ghtAddPoint.Register())
                MessageBox.Show("Add point Hotkey: failed to register");
        }

    }
}
