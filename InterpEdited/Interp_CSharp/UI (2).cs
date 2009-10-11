using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Interp_CSharp
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowDialog();
            string selectedpath = folderBrowserDialog1.SelectedPath;
            textBox1.Text = selectedpath;
            string[] files=Directory.GetFiles(selectedpath);
            DirectoryInfo dir = new DirectoryInfo(selectedpath);
            FileInfo[] file = dir.GetFiles();
            IEnumerator ie=file.GetEnumerator();
            ie.MoveNext();
            int inc = 0;
            while ( inc < file.Length)
            {
                Files.Items.Add(ie.Current.ToString());
                inc++;
                ie.MoveNext();
            }     

        }

        public void communicate(bool b)
        {
            if (b.Equals(true))
                textBox2.Enabled = true;
            else
                textBox2.Enabled = false;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + Files.Text;
           button2.Enabled = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string progtext = textBox2.Text;


        }



    }
}
