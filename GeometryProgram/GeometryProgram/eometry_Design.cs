using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GeometryProgram
{
    public partial class eometry_Design : Form
    {
        public eometry_Design()
        {
            InitializeComponent();
        }

        private void eometry_Design_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            run.TabStop = false;
            run.FlatStyle = FlatStyle.Flat;
            run.FlatAppearance.BorderSize = 0;
            run.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            pause.Visible = true;
            run.Visible = false;
            
        }

        private void pause_Click(object sender, EventArgs e)
        {
            pause.TabStop = false;
            pause.FlatStyle = FlatStyle.Flat;
            pause.FlatAppearance.BorderSize = 0;
            pause.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            pause.Visible = false;
            run.Visible = true;
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();//creating a instance of a dialog box
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //creting text form
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)//if choose data is fine then enter todialog box
            {
                try
                {
                    
                        using (StreamWriter write = new StreamWriter(sfd.FileName)) //dispose is done automatically
                        {
                            await write.WriteLineAsync(edit.Text);//loading text file in textbox
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;//instantiating null value for stra
            OpenFileDialog openFileDialog1 = new OpenFileDialog();//creating a instance of a dialog box
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //creting text form
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)//if choose data is fine then enter todialog box
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null) //if the choosen file is not empty then the file is read
                    {
                        using (myStream) //dispose is done automatically
                        {
                            edit.Text = File.ReadAllText(openFileDialog1.FileName);//loading text file in textbox
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
