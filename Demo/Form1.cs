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
		private FindReplace MyFindReplace;
		private int maxLineNumberCharLength;
		private int customStartingLineNumber;

		public Form1()
		{
			InitializeComponent();
			scintilla1.Styles[Style.Default].Size = 10;

			MyFindReplace = new FindReplace();
			MyFindReplace.Scintilla = scintilla1;
			MyFindReplace.FindAllResults += MyFindReplace_FindAllResults;
			MyFindReplace.KeyPressed += MyFindReplace_KeyPressed;

			incrementalSearcher1.FindReplace = MyFindReplace;

			findAllResultsPanel1.Scintilla = scintilla1;
			
			// The default line number is 1, anything else is a custom line number
			customStartingLineNumber = 8;
			InitNumberMargin();
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

		#region Line Numbers
		private void SetupNumberMargin()
		{
			// Line numbers can only customised by using a text margin rather than the default number margin
			scintilla1.Margins[0].Type = MarginType.Text;

			// Handle the Insert and Delete events so the line numbers can be customised
			scintilla1.Insert += Scintilla_Insert;
			scintilla1.Delete += Scintilla_Delete;
		}

		private void Scintilla_Insert(object sender, ModificationEventArgs e)
		{
			// Only update line numbers if the number of lines changed
			if (e.LinesAdded != 0)
				UpdateMarginLineNumbers(scintilla1.LineFromPosition(e.Position));
		}

		private void Scintilla_Delete(object sender, ModificationEventArgs e)
		{
			// Only update line numbers if the number of lines changed
			if (e.LinesAdded != 0)
				UpdateMarginLineNumbers(scintilla1.LineFromPosition(e.Position));
		}
		private void UpdateMarginLineNumbers(int startingAtIndex)
		{
			// Starting at the specified line index, update each
			// subsequent line margin text with the offset.
			for (int i = startingAtIndex; i < scintilla1.Lines.Count; i++)
			{
				scintilla1.Lines[i].MarginStyle = Style.LineNumber;
				scintilla1.Lines[i].MarginText = (i + customStartingLineNumber).ToString();
			}
		}

		private void Scintilla_TextChanged(object sender, EventArgs e)
		{
			// Adjust the width of the number margin to allow the line numbers to fit in the number margin

			int lineCount = customStartingLineNumber + scintilla1.Lines.Count;

			// Did the number of characters in the line number display change?
			// i.e. nnn VS nn, or nnnn VS nn, etc...

			// First find the number of digits\characters in the line count
			int lineNumberCharLength = (int)Math.Floor(Math.Log10(lineCount) + 1);

			// Set the NumberMargin width? 
			if (lineNumberCharLength == this.maxLineNumberCharLength)
				return;

			// Calculate the width required to display the last line number
			// and include some padding for good measure.
			const int padding = 2;
			scintilla1.Margins[0].Width = scintilla1.TextWidth(Style.LineNumber, new string('9', lineNumberCharLength + 1)) + padding;
			this.maxLineNumberCharLength = lineNumberCharLength;
		}
		#endregion

		private void InitNumberMargin()
		{
			// Handle the text changed event to ensure the line numbers can fit in the number margin
			this.scintilla1.TextChanged += Scintilla_TextChanged;

			// Set the defaults	for the number margin			
			scintilla1.Margins[0].Width = 30;
			scintilla1.Margins[0].Type = MarginType.Number;
			scintilla1.Margins[0].Sensitive = true;
			scintilla1.Margins[0].Mask = 0;

			SetupNumberMargin();
			UpdateMarginLineNumbers(0);

			// Light Theme - use defaults by not setting anything
			scintilla1.Styles[Style.LineNumber].ForeColor = Color.CadetBlue;
		}
	}
}