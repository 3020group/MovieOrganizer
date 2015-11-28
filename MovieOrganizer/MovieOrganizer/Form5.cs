using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatTmdb.V3;

namespace MovieOrganizer
{
    public partial class TestForm : Form
    {
        private string key = "d637d50db401e9af35c47fd0bcda4a4d";
        public TestForm()
        {
            InitializeComponent();
            WatTmdb.V3.Tmdb api = new Tmdb(key, "en");
            var result = api.SearchMovie("A Bridge Too Far", 1);

            var image = api.GetMovieImages(result.results[0].id);
            // MessageBox.Show(image.posters[0].file_path);
            Console.WriteLine(image.posters[0].file_path);

            string path = @"https://image.tmdb.org/t/p/w185";
            path += image.posters[0].file_path;




            TestBox.Load(path);

        }

        private void TestBox_Click(object sender, EventArgs e)
        {

        }
    }
}
