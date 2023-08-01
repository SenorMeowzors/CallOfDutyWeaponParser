using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CallOfDutyWeaponParser
{
    public partial class WeaponParser : Form
    {
        OpenFileDialog openFileDialog;
        private static WeaponParser _form;
        public static bool FileOpen
        {
            get
            {
                return _form.BothFilesOpen();
            }
        }

        public WeaponParser()
        {
            _form = this;

            InitializeComponent();

            openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
        }

        void PopulateValues(CustomFlowLayoutPanel panel, Label fileNameLabel)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                panel.Controls.Clear();
                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                panel.currentFileName = openFileDialog.FileName;

                fileNameLabel.Text = panel.currentFileName;

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    var text = reader.ReadToEnd();

                    var dict = WeaponFileUtilities.GetWeaponDictionary(text);

                    int startY = 3;
                    int size = 30;
                    int index = 0;
                    DoubleBuffered = true;
                    foreach (var key in dict.Keys)
                    {
                        var value = dict[key];

                        var display = WeaponFileUtilities.CreateKVDisplay(key, value, startY + index * size);
                        display.index = index;
                        panel.Controls.Add(display);
                        index++;
                    }
                }
            }
        }

        private void LoadFileIntoPanel(CustomFlowLayoutPanel panel, Label filenameLabel)
        {
            PopulateValues(panel, filenameLabel);
            CheckIfBothOpen();
        }

        public void CheckIfBothOpen()
        {
            if (BothFilesOpen())
            {
                CreateDiff();
                ShowTransferPanel(true);
            }
            else
            {
                ShowTransferPanel(false);
            }
        }

        private void ShowTransferPanel(bool visible)
        {
            TransferPanel.Visible = visible;
        }

        private bool BothFilesOpen()
        {
            return flowLayoutPanel1.Controls.Count > 1 && flowLayoutPanel2.Controls.Count > 1;
        }

        private void CreateDiff()
        {
            foreach (var control in flowLayoutPanel1.Controls)
            {
                KeyValueDisplay display = (KeyValueDisplay)control;
                display.MakeColor(Color.White);

                var valueToDiff = FindControlValue(flowLayoutPanel2, display.Key);
                if (valueToDiff != null)
                {
                    if (display.Value != valueToDiff.Value)
                    {
                        valueToDiff.MakeColor(Color.Red);
                        display.MakeColor(Color.Green);
                    }
                }
            }
        }

        public KeyValueDisplay FindControlValue(FlowLayoutPanel panel, string key)
        {

            foreach(var control in panel.Controls)
            {
                KeyValueDisplay display = (KeyValueDisplay)control;

                if (display != null)
                {
                    if(display.Key == key)
                    {
                        return display;
                    }
                }
            }

            return null;
        }

        public string[] GetFilters()
        {
            return filtersTextBox.Text.Split(' ');
        }

        public bool HasWord(string word)
        {
            foreach (var filter in GetFilters())
            {
                if (word.ToLower().Contains(filter.ToLower().Trim()))
                {
                    return true;
                }
            }

            return false;
        }
        private void TransferButton_Click(object sender, EventArgs e)
        {
            foreach(var control in flowLayoutPanel2.Controls)
            {
                var display = (KeyValueDisplay)control;

                if(display != null)
                {
                    if (display.IsDifferent)
                    {
                        if(HasWord(display.Key))
                        {
                            continue;
                        }

                        var valueToChange = FindControlValue(flowLayoutPanel1, display.Key);

                        float result;
                        var isNumber = float.TryParse(valueToChange.Value, out result);
                        if (isNumber)
                        {
                            valueToChange.Value = display.Value;

                            valueToChange.MakeColor(Color.Yellow);
                            display.MakeColor(Color.White);
                        }
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFirstFile_Click(object sender, EventArgs e)
        {
            LoadFileIntoPanel(flowLayoutPanel1, Panel1Name);
        }

        private void OpenSecondFile_Click(object sender, EventArgs e)
        {
            LoadFileIntoPanel(flowLayoutPanel2, Panel2Name);
        }

        private void SaveFirstFile_Click(object sender, EventArgs e)
        {
            WeaponFileUtilities.WriteToPath(flowLayoutPanel1);

        }

        private void SaveSecondFile_Click(object sender, EventArgs e)
        {
            WeaponFileUtilities.WriteToPath(flowLayoutPanel2);
        }

        public int Clamp(int value, int min, int max)
        {
            int num = value;
            if(value < min)
            {
                num = min;
            }
            else if(value > max)
            {
                num = max;
            }

            return num;
        }

        private void FlowLayoutPanel1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            MatchScroll(flowLayoutPanel1, flowLayoutPanel2);
        }
        private void FlowLayoutPanel1_ScrollWheel(object sender, MouseEventArgs e)
        {
            MatchScroll(flowLayoutPanel1, flowLayoutPanel2);
        }

        private void FlowLayoutPanel2_ScrollWheel(object sender, MouseEventArgs e)
        {
            MatchScroll(flowLayoutPanel2, flowLayoutPanel1);
        }

        private void FlowLayoutPanel2_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            MatchScroll(flowLayoutPanel2, flowLayoutPanel1);
        }

        private void MatchScroll(FlowLayoutPanel source, FlowLayoutPanel destination)
        {
            var scroll1 = source.VerticalScroll;
            var scroll2 = destination.VerticalScroll;
            destination.VerticalScroll.Value = Clamp(scroll1.Value, scroll2.Minimum, scroll2.Maximum);
        }
    }
}
