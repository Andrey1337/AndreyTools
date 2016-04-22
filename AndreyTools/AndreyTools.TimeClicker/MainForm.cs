using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace AndreyTools.TimeClicker
{
    public partial class MainForm : Form
    {
        private delegate void controller();

        List<TimePoint> _timePoints;

        private DateTime _time;
        string _path;

        private bool _isStarted;

        private GlobalHotkey _ghtAddPoint;
        private enum HotKeys { AddPoint }
        private enum Tabs { TimeClicker }

        private long _milliseconds;

        public MainForm()
        {
            InitializeComponent();

            _ghtAddPoint = new GlobalHotkey((int)HotKeys.AddPoint, Constants.ALT + Constants.SHIFT, Keys.A, this);

            _path = ConfigurationSettings.AppSettings["Path"];
            _timePoints = DeserializeFromJson(_path);

            _isStarted = false;
            _milliseconds = 0;
            UpdateListbox();
        }

        public static void SerializeToJson(IEnumerable<TimePoint> timePoints, string path)
        {
            List<string> allTimePointJSons = new List<string>();

            allTimePointJSons.Add(JsonConvert.SerializeObject(timePoints.ToList()));

            File.WriteAllLines(path, allTimePointJSons);
        }

        public static List<TimePoint> DeserializeFromJson(string path)
        {
            List<TimePoint> timePoints = new List<TimePoint>();
            try
            {
                timePoints = JsonConvert.DeserializeObject<List<TimePoint>>(File.ReadAllLines(path)[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant read the file: {0}", path);
            }
            return timePoints;
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
                timer.Start();
                startButton.Text = "Stop";
                _isStarted = true;
                _timePoints.Sort();
                UpdateListbox();
                panel1.Enabled = false;
            }
            else
            {
                timer.Stop();
                startButton.Text = "Start";
                _isStarted = false;
                panel1.Enabled = true;
            }
        }

        private static long TimeToSeconds(int hours, int minutes, int seconds)
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
            _milliseconds += 10;
        }

        public void UpdateListbox()
        {
            listBox.DataSource = null;
            listBox.DataSource = _timePoints;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text.Trim();
            if (description == "")
                description = "Without Description";

            long timeToSeconds = TimeToSeconds((int)hrsNumeric.Value, (int)minNumeric.Value, (int)secNumeric.Value);
            Point point = new Point((int)xNumeric.Value, (int)yNumeric.Value);

            _timePoints.Add(new TimePoint(new DateTime().AddSeconds(timeToSeconds), point, description));

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
                _timePoints.RemoveAt(listBox.SelectedIndex);
                if (listBox.SelectedIndex > _timePoints.Count)
                {
                    listBox.SelectedIndex--;
                }
            }
            UpdateListbox();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > 0)
            {
                TimePoint timePoint = _timePoints[listBox.SelectedIndex];
                _timePoints[listBox.SelectedIndex] = _timePoints[listBox.SelectedIndex - 1];
                _timePoints[listBox.SelectedIndex - 1] = timePoint;
                UpdateListbox();
                listBox.SelectedIndex--;
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < _timePoints.Count - 1)
            {
                TimePoint timePoint = _timePoints[listBox.SelectedIndex];
                _timePoints[listBox.SelectedIndex] = _timePoints[listBox.SelectedIndex + 1];
                _timePoints[listBox.SelectedIndex + 1] = timePoint;
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

                long timeToSeconds = TimeToSeconds((int)hrsNumeric.Value, (int)minNumeric.Value, (int)secNumeric.Value);
                Point point = new Point((int)xNumeric.Value, (int)yNumeric.Value);

                _timePoints[listBox.SelectedIndex] = new TimePoint(new DateTime().AddSeconds(timeToSeconds), point, description);
                UpdateListbox();
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToJson(_timePoints, _path);
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
