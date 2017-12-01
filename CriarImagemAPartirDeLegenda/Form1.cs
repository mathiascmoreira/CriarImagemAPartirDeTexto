using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CriarImagemAPartirDeLegenda
{
    public partial class Form1 : Form
    {
        private Subtitle Subtitle1;
        private Subtitle Subtitle2;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtLoadSubtitle1_Click(object sender, EventArgs e)
        {         
            try
            {
                Subtitle1 = LoadSubtitle();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error trying to load the subtitle! "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Subtitle LoadSubtitle()
        {
            var openFileResult = openSubtitle.ShowDialog();

            if (openFileResult != DialogResult.OK)
                return null;

            var subtitle = new Subtitle();

            var subtitleLines = File.ReadLines(openSubtitle.FileName);

            var sectionLines = new List<string>();

            foreach(var line in subtitleLines)
            {
                if(IsSectionNumber(line) && sectionLines.Any())
                {
                    var section = GetSectionFromLines(sectionLines);

                    subtitle.Sections.Add(section);

                    sectionLines.Clear();
                }

                sectionLines.Add(line);
            }

            return subtitle;
        }

        private Section GetSectionFromLines(List<string> sectionLines)
        {
            throw new NotImplementedException();
        }

        private bool IsSectionNumber(string line)
        {
            throw new NotImplementedException();
        }

        private void txtLoadSubtitle2_Click(object sender, EventArgs e)
        {

        }
    }
}
