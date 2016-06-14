using ScintillaNET;
using ScintillaNET_FindReplaceDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        FindReplace MyFindReplace;

        public Form1()
        {
            InitializeComponent();
            scintilla1.Styles[Style.Default].Size = 10;

            MyFindReplace = new FindReplace(scintilla1);
            MyFindReplace.FindAllResults += MyFindReplace_FindAllResults;
            MyFindReplace.KeyPressed += MyFindReplace_KeyPressed; ;

            incrementalSearcher1.FindReplace = MyFindReplace;

            findAllResultsPanel1.Scintilla = scintilla1;
        }

        private void MyFindReplace_KeyPressed(object sender, KeyEventArgs e)
        {
            scintilla1_KeyDown(sender, e);
        }

        private void MyFindReplace_FindAllResults(object sender, FindResultsEventArgs FindAllResults)
        {
            // Pass on find results
            findAllResultsPanel1.UpdateFindAllResults(FindAllResults.FindReplace, FindAllResults.FindAllResults);
        }

        private void GotoButton_Click(object sender, EventArgs e)
        {
            GoTo MyGoTo = new GoTo(scintilla1);
            MyGoTo.ShowGoToDialog();
        }

        private void scintilla1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                MyFindReplace.ShowFind();
                e.SuppressKeyPress = true;
            }
            else if (e.Shift && e.KeyCode == Keys.F3)
            {
                MyFindReplace.Window.FindPrevious();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                MyFindReplace.Window.FindNext();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                MyFindReplace.ShowReplace();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                MyFindReplace.ShowIncrementalSearch();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                GoTo MyGoTo = new GoTo(scintilla1);
                MyGoTo.ShowGoToDialog();
                e.SuppressKeyPress = true;
            }

        }
    }
}
