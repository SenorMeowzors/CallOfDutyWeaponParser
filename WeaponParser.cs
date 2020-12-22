using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CallOfDutyWeaponParser
{
    public partial class WeaponParser : Form
    {
        public WeaponParser()
        {
            InitializeComponent();


        }

        string openFile;
        void PopulateValues(FlowLayoutPanel panel, bool activeFile = false)
        {

            var openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                panel.Controls.Clear();
                if(activeFile)
                {
                    //Get the path of specified file
                    openFile = openFileDialog.FileName;
                }
                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    var text = reader.ReadToEnd();

                    var dict = WeaponFileUtilities.GetWeaponDictionary(text);

                    int startY = 3;
                    int size = 30;
                    int index = 0;
                    DrawingControl.SuspendDrawing(this);
                    foreach (var key in dict.Keys)
                    {
                        var value = dict[key];

                        var display = WeaponFileUtilities.CreateKVDisplay(key, value, startY + index * size);
                        display.index = index;
                        panel.Controls.Add(display);
                        index++;
                    }

                    DrawingControl.ResumeDrawing(this);
                }
            }
        }

        private void WeaponParser_Load(object sender, System.EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateValues(flowLayoutPanel1, true);
        }

        private void keyValueDisplay1_Load(object sender, EventArgs e)
        {

        }
        
        private void openSecondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateValues(flowLayoutPanel2);

            if(flowLayoutPanel1.Controls.Count > 1)
            {
                foreach (var control in flowLayoutPanel1.Controls)
                {
                    KeyValueDisplay display = (KeyValueDisplay)control;
                    display.MakeColor(Color.White);

                    var valueToDiff = FindControlValue(flowLayoutPanel2, display.Key);
                    if (valueToDiff != null)
                    {
                        if(display.Value != valueToDiff.Value)
                        {
                            valueToDiff.MakeColor(Color.Red);
                            display.MakeColor(Color.Green);
                        }
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeaponFileUtilities.WriteToPath(flowLayoutPanel1, openFile);
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
    }
}
