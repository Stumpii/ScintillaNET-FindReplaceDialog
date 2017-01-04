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

            MyFindReplace = new FindReplace();
            MyFindReplace.Scintilla = scintilla1;
            MyFindReplace.FindAllResults += MyFindReplace_FindAllResults;
            MyFindReplace.KeyPressed += MyFindReplace_KeyPressed; ;

            incrementalSearcher1.FindReplace = MyFindReplace;

            findAllResultsPanel1.Scintilla = scintilla1;
        }

        private void MyFindReplace_KeyPressed(object sender, KeyEventArgs e)
        {
            genericScintilla_KeyDown(sender, e);
        }

        private void MyFindReplace_FindAllResults(object sender, FindResultsEventArgs FindAllResults)
        {
            // Pass on find results
            findAllResultsPanel1.UpdateFindAllResults(FindAllResults.FindReplace, FindAllResults.FindAllResults);
        }

        private void GotoButton_Click(object sender, EventArgs e)
        {
            // Use the FindReplace Scintilla as this will change based on focus
            GoTo MyGoTo = new GoTo(MyFindReplace.Scintilla);
            MyGoTo.ShowGoToDialog();
        }

        /// <summary>
        /// Key down event for each Scintilla. Tie each Scintilla to this event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genericScintilla_KeyDown(object sender, KeyEventArgs e)
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
                GoTo MyGoTo = new GoTo((Scintilla)sender);
                MyGoTo.ShowGoToDialog();
                e.SuppressKeyPress = true;
            }

        }

        /// <summary>
        /// Enter event tied to each Scintilla that will share a FindReplace dialog.
        /// Tie each Scintilla to this event.
        /// </summary>
        /// <param name="sender">The Scintilla receiving focus</param>
        /// <param name="e"></param>
        private void genericScintilla1_Enter(object sender, EventArgs e)
        {
            MyFindReplace.Scintilla = (Scintilla)sender;
        }
    }
}
