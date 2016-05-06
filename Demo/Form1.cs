using ScintillaNET;
using ScintillaNET_FindReplaceDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            MyFindReplace = new FindReplace(scintilla1);

            incrementalSearcher1.FindReplace = MyFindReplace;
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
    }
}
