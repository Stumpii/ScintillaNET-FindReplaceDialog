#region Using Directives

using ScintillaNET;
using System;
using System.Windows.Forms;

#endregion Using Directives

namespace ScintillaNET_FindReplaceDialog
{
	public class GoTo : IDisposable
	{
		private Scintilla _scintilla;
		private GoToDialog _window;
		private int _startingLineIndex = 0;

		#region Methods

		public void Dispose()
		{
			_window.Dispose();
		}

		public void Line(int number)
		{
			Line line = _scintilla.Lines[number];
			line.EnsureVisible();
			line.Goto();
		}

		public void Position(int pos)
		{
			_scintilla.GotoPosition(pos);
		}

		public void ShowGoToDialog()
		{
			//GoToDialog gd = new GoToDialog();
			GoToDialog gd = _window;

			gd.CurrentLineNumber = _scintilla.CurrentLine + _startingLineIndex; 
			gd.MaximumLineNumber = _scintilla.Lines.Count + _startingLineIndex; 
			gd.Scintilla = _scintilla;

			if (!_window.Visible)
				_window.ShowDialog(_scintilla.FindForm());

			//_window.ShowDialog(_scintilla.FindForm());
			//_window.Show(_scintilla.FindForm());

			//if (gd.ShowDialog() == DialogResult.OK)
			//Line(gd.GotoLineNumber);

			//gd.ShowDialog();
			//gd.Show();

			_scintilla.Focus();
		}

		#endregion Methods

		#region Constructors

		protected virtual GoToDialog CreateWindowInstance()
		{
			return new GoToDialog(_startingLineIndex);
		}

		public GoTo(Scintilla scintilla)
		{
			_scintilla = scintilla;

			// Is the number margin setup?
			if (!string.IsNullOrEmpty(_scintilla.Lines[0].MarginText))
			{
				// Get the first line number's margin text
				// and set the starting index. Note the LineIndex starts at 0 not 1
				_startingLineIndex = int.Parse(_scintilla.Lines[0].MarginText);
				_startingLineIndex--;
			}

			_window = CreateWindowInstance();
			_window.Scintilla = scintilla;
		}

		#endregion Constructors
	}
}