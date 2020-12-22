using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CallOfDutyWeaponParser
{
    public partial class KeyValueDisplay : UserControl
    {
        private string key;
        private string value;
        public int index;

        public string Key { get => textBox1.Text; set => this.textBox1.Text = value; }
        public string Value { get => textBox2.Text; set => this.textBox2.Text = value; }

        public bool IsDifferent
        {
            get
            {
                return textBox2.BackColor.ToArgb() != Color.White.ToArgb();
            }
        }

        public KeyValueDisplay()
        {
            InitializeComponent();

            textBox1.Text = Key;
            textBox2.Text = Value;
        }

        public KeyValueDisplay(string key, string value)
        {
            InitializeComponent();

            this.Key = key;
            this.Value = value;
            textBox1.Text = key;
            textBox2.Text = value;
        }

        public void SetKeyValue(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public string GetString()
        {
            return Key + "\\" + Value + "\\";
        }

        public void MakeColor(Color color)
        {
            textBox1.BackColor = color;
            textBox2.BackColor = color;
        }
        public void ResetColor()
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
        }
    }
}
