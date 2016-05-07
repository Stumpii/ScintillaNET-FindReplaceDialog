# ScintillaNET-FindReplaceDialog
A ScintillaNET v3 Find &amp; Replace Dialog + Goto Dialog + Incremental Search
# ScintillaNET

[ScintillaNET v3](https://github.com/jacobslusser/ScintillaNET) is a Windows Forms control, wrapper, and bindings for the versatile [Scintilla](http://www.scintilla.org/) source code editing component. It does not contain a Find & Replace dialog often seen in Scintilla based editors (Notepad++, SciTE, etc.).

ScintillaNET v2.5 contained Find & Replace, Goto and Incremental Search dialogs which were not included in the v3 branch. The project ports those v2.5 features into a library that will function with v3 ScintillaNET.

Find/Replace Dialog:
![Find Dialog](https://github.com/Stumpii/ScintillaNET-FindReplaceDialog/wiki/images/Find-Dialog.png)

Incremental Search:
![Incremental Search](http://github.com/Stumpii/ScintillaNET-FindReplaceDialog/wiki/images/Incremental-Search.png)

Go To Dialog:
![Go To Dialog](http://github.com/Stumpii/ScintillaNET-FindReplaceDialog/wiki/images/Go-To-Line-Dialog.png)

## Background

I have been using ScintillaNet v2.5 for a number of years. The reasons are the conversion to v3 are well [documented](https://github.com/jacobslusser/ScintillaNET#background), however some features were sorely missed. I started to work these features in a personal clone of ScintillaNET v3, copying chunks of v2.5 code I needed and fixing/converting along the way. All credit goes to [Jacob Slusser](https://github.com/jacobslusser) for writing and maintaining ScintillaNET v2.5 and v3.

## Usage
Here are some examples how to integrate with ScintillaNET. For all steps, you will need to:
1. Add a reference to the binary output of this project (the .dll).
2. Add the following to the top of the file in which you will be using the library:
```
using ScintillaNET_FindReplaceDialog;
```

###Find & Replace Dialog

The following declares an instance of FindReplace globablly with reference to a ScintillaNET control.

```
    public partial class Form1 : Form
    {
    	// Declare variable for FindReplace dialog
        FindReplace MyFindReplace;

        public Form1()
        {
            InitializeComponent();

            // Create instance of FindReplace with reference to a ScintillaNET control.
            MyFindReplace = new FindReplace(scintilla1);
        }
	}
```

###Go To Dialog
The following creates and shows a Go To dialog. Once the user enters a line number, the referenced ScintillaNET control will go to that location, the form will close. The Go To instance is no longer required. 

```
	private void GotoButton_Click(object sender, EventArgs e)
	{
		GoTo MyGoTo = new GoTo(scintilla1);
		MyGoTo.ShowGoToDialog();
	}
```

###Incremental Search
The Incremental Search control is a component of the FindReplace class and as such, creating an instance of the FindReplace class gives the ability to show the Incremental Search control within the ScintillaNET control (actually infront of it). All that is required is to call the specific method to show the control as below.

```
	MyFindReplace.ShowIncrementalSearch();
```

Optionally the control can be dropped onto a form (in this case named 'incrementalSearcher1' and hooked directly to a FindReplace instance as shown below. In this case, the control is always visible.

```
    public partial class Form1 : Form
    {
    	// Declare variable for FindReplace dialog
        FindReplace MyFindReplace;

		public Form1()
        {
            InitializeComponent();

			MyFindReplace = new FindReplace(scintilla1);
			incrementalSearcher1.FindReplace = MyFindReplace;
        }
	}
```