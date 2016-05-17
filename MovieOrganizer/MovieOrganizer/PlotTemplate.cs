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
    public partial class TestForm : MovieOrganizerForm
    {
        public TestForm()
        {
            InitializeComponent();

            scatterPlot1.changeYearRange(1920, 1980);
            scatterPlot1.changeRatingRange(3, 7);

        }
    }
}
