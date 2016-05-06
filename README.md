# ScintillaNET-FindReplaceDialog
A ScintillaNET v3 Find &amp; Replace Dialog + Goto Dialog + Incremental Search
# ScintillaNET

[ScintillaNET v3](https://github.com/jacobslusser/ScintillaNET) is a Windows Forms control, wrapper, and bindings for the versatile [Scintilla](http://www.scintilla.org/) source code editing component. It does not contain a Find & Replace dialog often seen in Scintilla based editors (Notepad++, SciTE, etc.).

ScintillaNET v2.5 contained Find & Replace, Goto and Incremental Search dialogs which were not included in the v3 branch. The project ports those v2.5 features into a library that will function with v3 ScintillaNET.

![Find Dialog](https://github.com/Stumpii/ScintillaNET-FindReplaceDialog/wiki/images/Find-Dialog.png)

## Background

I have been using ScintillaNet v2.5 for a number of years. The reasons are the conversion to v3 are well [documented](https://github.com/jacobslusser/ScintillaNET#background), however some features were sorely missed. I started to work these features in a personal clone of ScintillaNET v3, copying chunks of v2.5 code I needed and fixing/converting along the way. All credit goes to [Jacob Slusser](https://github.com/jacobslusser) for writing and maintaining ScintillaNET v2.5 and v3.

## Usage

To use the Find & Replace Dialog:

1. Add a reference to the binary output of this project (the .dll):

```
using ScintillaNET_FindReplaceDialog;
```

2. Add an instance of FindReplace with reference to a ScintillaNET control:

```
    public partial class Form1 : Form
    {
        FindReplace MyFindReplace;

        public Form1()
        {
            InitializeComponent();
            MyFindReplace = new FindReplace(scintilla1);
        }
	}
```
