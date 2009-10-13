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
using System.Threading;

namespace Interp_CSharp
{
    public partial class UI : Form
    {
        private string selectedpath;
        private string progcon;
        private Program theprogram;
        
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
            selectedpath = folderBrowserDialog1.SelectedPath;
            textBox1.Text = selectedpath;
            string[] files=Directory.GetFiles(selectedpath);
            DirectoryInfo dir = new DirectoryInfo(selectedpath);
            FileInfo[] file = dir.GetFiles();
            IEnumerator ie=file.GetEnumerator();
            ie.MoveNext();
            int inc = 0;
            Files.Items.Clear();
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
            {
                textBox2.Enabled = false;
                Save.Enabled = false;
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Files.Text.EndsWith(".spina"))
            {
                textBox1.Text = textBox1.Text + "\\" + Files.Text;
                selectedpath = textBox1.Text;
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Cannot Proceed because not a spina file");

            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            theprogram = new Program();
            if(progcon!=null)
            theprogram.RunEvalLoop(progcon);
            Thread.Sleep(1000);
            textBox3.Text = theprogram.resultMessage;
            theprogram.resultMessage = "";
            progcon = "";
        }

        

        private void Save_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {

                StreamReader sr = File.OpenText(selectedpath);
               
                if (sr == null)
                    MessageBox.Show("Not Open");
                else
                {
                    textBox3.Text+="Trying To Open File"+string.Format("{0}",selectedpath); 
                    progcon = sr.ReadToEnd();
                    textBox2.Text = progcon;
                    
                }
                //FileStream fs = new FileStream(@selectedpath, FileMode.Open, FileAccess.Read);
                //FileStream fs =File.OpenRead(selectedpath);
                //StreamReader sr = new StreamReader(selectedpath);
                //if( sr.
                //string prog = sr.ReadToEnd();
                //textBox2.Text = prog;
                //sr.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
           /* Program theprogram = new Program();
            theprogram.VisitLine("myvar = 1+3; a[][] [10,20,30][20,30,40]; parallel_for(myvar 0..2){ a[i] = myvar + a[i];}; ");
            theprogram.VisitLine("myvariable = 1 + 2; var = myvariable + 3; print var; a[][] [10,2][10,3]; b[][] [10,30][40,50]; c[][] = a[][] * b[][];");
            theprogram.RunEvalLoop(); */

        }

       

    }
}
