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

namespace курсовая
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
           
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.button1_Click(this, null);

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
           
             ListViewItem lvi = new ListViewItem();
             lvi.SubItems[0].Text = textBox1.Text;
             lvi.SubItems.Add(textBox2.Text);
             lvi.SubItems.Add(textBox3.Text);
             lvi.SubItems.Add(textBox4.Text);
             lvi.SubItems.Add(textBox5.Text);
             listView1.Items.Add(lvi);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listView1.FocusedItem.Index;
            listView1.Items[i].Remove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*ListView list = new ListView();
            ListViewItem lvi = new ListViewItem();*/
            int i = listView1.FocusedItem.Index;
            listView1.Items[i].SubItems[0].Text = textBox1.Text;
            listView1.Items[i].SubItems[1].Text = textBox2.Text;
            listView1.Items[i].SubItems[2].Text = textBox3.Text;
            listView1.Items[i].SubItems[3].Text = textBox4.Text;
            listView1.Items[i].SubItems[4].Text = textBox5.Text;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems.Clear();
            /* ListViewItem lvi2 = new ListViewItem();
             ListView lvi = new ListView();*/
            if (radioButton1.Checked)
            {
                for(int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[0].Text == textBox6.Text)
                    {
                        listView1.Items[i].Selected = true;
                        break;
                    }
                }
            }
            if (radioButton2.Checked)
            {
                for(int i = 0; i < listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].SubItems[1].Text == textBox2.Text)
                    {
                        listView1.Items[i].Selected = true;
                        break;
                    }
                }
            }
            if (radioButton3.Checked)
            {
                for(int i = 0; i < listView1.Items.Count;i++)
                {
                    if(listView1.Items[i].SubItems[2].Text == textBox3.Text)
                    {
                        listView1.Items[i].Selected = true;
                        break;
                    }
                }
            }
            if (radioButton4.Checked)
            {
                for(int i = 0; i < listView1.Items.Count; i++)
                {
                    if(listView1.Items[i].SubItems[3].Text == textBox4.Text)
                    {
                        listView1.Items[i].Selected = true;
                        break;
                    }
                }
            }
            if (radioButton5.Checked)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[4].Text == textBox5.Text)
                    {
                        listView1.Items[i].Selected = true;
                        break;
                    }
                }
            }
        }
    }
}
