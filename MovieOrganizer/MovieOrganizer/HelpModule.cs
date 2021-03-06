﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MovieOrganizer
{
    /* TODO: Help Module
    - Write Text Files corresponding to help topics. Find all help topics
    */
    public partial class HelpModule : MovieOrganizerForm
    {
        Dictionary<String, String> descriptions;
        public HelpModule()
        {
            InitializeComponent();
            descriptions = new Dictionary<String, String>();

            // Load Descriptions
            loadDescriptions(descriptions);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change Label Text to be Description of given index changed
            Description.Text = descriptions[Topics.SelectedItem.ToString()];
        }

        private void loadDescriptions(Dictionary<String, String> descriptions)
        {
            string readText = "";
            foreach(String name in Topics.Items)
            {
                string path = name + ".txt";

                // This text is added only once to the file.
                if (File.Exists(path))
                {
                    // Create a file to write to.
                   readText = File.ReadAllText(path);
                }
                descriptions[name] = readText;
            }
        }
    }
}
