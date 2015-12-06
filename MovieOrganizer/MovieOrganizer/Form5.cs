using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer
{
    public partial class TestForm : Form
    {
        private string key = "d637d50db401e9af35c47fd0bcda4a4d";
        public TestForm()
        {
            InitializeComponent();



            string path = "";
            TestBox.Load(path);

        }

        private void TestBox_Click(object sender, EventArgs e)
        {

        }
    }
}
