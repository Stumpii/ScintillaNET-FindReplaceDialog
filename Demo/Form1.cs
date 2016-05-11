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
        List<ScintillaNET_FindReplaceDialog.CharacterRange> FindAllResultsStore;

        public Form1()
        {
            InitializeComponent();

            MyFindReplace = new FindReplace(scintilla1);
            MyFindReplace.FindAllResults += MyFindReplace_FindAllResults;

            incrementalSearcher1.FindReplace = MyFindReplace;

            FindResultsScintilla.Styles[Style.Default].Font = "Consolas";
            FindResultsScintilla.Styles[Style.Default].Size = 10;
        }

        private void MyFindReplace_FindAllResults(object sender, List<ScintillaNET_FindReplaceDialog.CharacterRange> FindAllResults)
        {
            // Keep copy of found data
            FindAllResultsStore = new List<ScintillaNET_FindReplaceDialog.CharacterRange>(FindAllResults);

            FindResultsScintilla.ClearAll();

            foreach (var item in FindAllResultsStore)
            {
                int startLine = scintilla1.LineFromPosition(item.cpMin);
                int endLine = scintilla1.LineFromPosition(item.cpMax);

                if (startLine == endLine)
                    FindResultsScintilla.AppendText(string.Format("Line {0}: {1}", startLine, scintilla1.Lines[startLine].Text));
            }
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

        private void FindResultsScintilla_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int pos = FindResultsScintilla.CharPositionFromPointClose((e.Location).X, (e.Location).Y);
            int selectedLine = FindResultsScintilla.LineFromPosition(pos);

            ScintillaNET_FindReplaceDialog.CharacterRange CharRange = FindAllResultsStore[selectedLine];
            scintilla1.SetSelection(CharRange.cpMin, CharRange.cpMax);
            scintilla1.ScrollCaret();
        }
    }
}
