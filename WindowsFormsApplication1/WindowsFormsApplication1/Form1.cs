using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int delta = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          //  if(e.KeyChar == 9)
            {
            //    MessageBox.Show("hello");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9')
            {
            //    MessageBox.Show(Int32.Parse("aab6a").ToString());

            }
                    
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("[0-9]+");
            if(r.IsMatch(textBox1.Text))
            {
                MessageBox.Show(textBox1.Name);
                e.Cancel = true;
            }

            ErrorProvider errorProvider1 = new ErrorProvider();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please fill the required field");
                e.Cancel = true;
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("yes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.textBox1, "Hello");

            delta = this.Width - textBox1.Width;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            textBox1.Width = this.Width - delta;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.F1)
            {
                MessageBox.Show("help");
                return false;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DragLeave(object sender, EventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Copy;
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            button1.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.DoDragDrop(textBox2.Text, DragDropEffects.Copy);
        }

        // textbox drag leave
    }
}
