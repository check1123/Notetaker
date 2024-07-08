using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notetaker
{
    
    public partial class Form1 : Form
    {
        public int  xPose= 30;
        List<string> notes = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = true;
            
        }

        private void newnote_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
            panel2.Visible = false;
            textBox1.Text = "";
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                notes.Add(textBox1.Text);
                textBox1.Text = "";
                panel1.Visible = false;
                panel2.Visible = true;

                //    listBox1.Items.Add(items);
                CreatePanel(notes[notes.Count - 1]); 
            }
            else
            {
              var result =  MessageBox.Show("Would you like to cancel?","EMPTY FIELD",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) 
                {
                    panel1.Visible = false; 
                    panel2.Visible = true;

                  //  CreatePanel(notes[notes.Count-1]);

                   }
                else if(result == DialogResult.No)
                {
                    panel1.Visible = true;
                    panel2.Visible = false;  

                }
            }
          
           // listBox1.Items.Clear();
          


        }
        void CreatePanel(string h)
        {
            Panel panel3 = new Panel();
            panel3.Size = new Size(200, 81);
            panel3.BackColor = Color.BlueViolet;
            panel3.Location = new Point(30, xPose);
            xPose += 70;
            panel2.Controls.Add(panel3);
            Button edit = new Button();
            Button del = new Button();
            Label note= new Label();
            edit.Text = "Edit";
            del.Text = "Delete";

            note.Text = h;
            note.Location = new Point(10, 25);
            edit.Location = new Point(115, 10);
            del.Location = new Point(115, 50);

            panel3.Controls.Add(note);
            panel3.Controls.Add(edit);
            panel3.Controls.Add(del);
        }

        private void canbut_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        { 

        }
    }
}
