using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

/*
 a simple file searching utility to replace the broken windows 7 search
 supports normal search (like from a command prompt) and regex searches.
 does file contains text and file name searches.
 
 copyright Fujitsu 2013
  
 * */

namespace FileSearch
	{
	public partial class FormFileSearch : MetroFramework.Forms.MetroForm		{
		private string exportPath = "";
        private ListViewColumnSorter lvwColumnSorter;

		public FormFileSearch()
			{
			InitializeComponent();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewResults.ListViewItemSorter = lvwColumnSorter;
			}

		private void FormFileSearch_Load(object sender, EventArgs e)
			{
            textBoxPath.Text = "";
            FormBorderStyle = FormBorderStyle.FixedDialog;


        }

        private void AddListItemDetails(FileInfo info)
            {
            ListViewItem item = new ListViewItem(info.FullName);
            item.SubItems.Add(info.Length.ToString());
            item.SubItems.Add(info.CreationTime.ToString());
            item.SubItems.Add(info.LastWriteTime.ToString());
            item.SubItems.Add(info.Extension);

            listViewResults.Items.Add(item);
            }

		// get the path to search
		private void buttonBrowsePath_Click(object sender, EventArgs e)
			{
			FolderBrowserDialog dlg = new FolderBrowserDialog();

			dlg.ShowNewFolderButton = false;
			dlg.SelectedPath = textBoxPath.Text;
			if (dlg.ShowDialog() == DialogResult.OK)
				{
				textBoxPath.Text = dlg.SelectedPath;
				}
			}

		// does the file called fName contain the string contains
		private Boolean FileContains(string fName, string contains)
			{
			string text = File.ReadAllText(fName);

			if (checkBoxCaseInsensitive.Checked)
				{
				return text.IndexOf(contains, StringComparison.OrdinalIgnoreCase) >= 0;
				}
			else
				return text.Contains(contains);  // contains is always case sensitive
			}

		// recurse the path and add found files to the listbox, normal mode
		private void RecursePath(string fileName, string path, string contains)
			{
			try
				{
                DirectoryInfo dir = new DirectoryInfo(path);

				foreach (FileInfo info in dir.GetFiles(fileName) )
					{
                    if (contains.Length < 1)
                        AddListItemDetails(info);
                    else
                        {
                        if (FileContains(info.FullName, contains))
                            AddListItemDetails(info);
                        }
                     
					}

                foreach (DirectoryInfo info in dir.GetDirectories())
                    {
                    RecursePath(fileName, info.FullName, contains);
                    }
				}
			catch (Exception ex)
				{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		// does the file called fName contian text matching the regex
		private Boolean FileContainsRegEX(string fName, Regex regExContains)
			{
            Match m;

            try
                {
                string text = File.ReadAllText(fName);

                m = regExContains.Match(text);
                return m.Success;
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            return false;
			}

		// recurse the start path, adding matching file to the listbox, regex mode
		private void RecursePathRegEx(Regex regExFileName, string path, Regex regExContains, Boolean checkContains)
			{
			try
				{
                DirectoryInfo dir = new DirectoryInfo(path);
				Match m;
				// getfile doesn't support regex, get all files and test the filename in the loop


                foreach (FileInfo info in dir.GetFiles())
					{
					// 
					m = regExFileName.Match(Path.GetFileName(info.FullName));
					if (m.Success)
						{
						// passed the file name test, check the contains
						if (checkContains)
							{
							if (FileContainsRegEX(info.FullName, regExContains))
                                AddListItemDetails(info);
							}
						else
                            AddListItemDetails(info);
						}
					}

                foreach (DirectoryInfo info in dir.GetDirectories())
					RecursePathRegEx(regExFileName, info.FullName, regExContains, checkContains);
				}

			catch (UnauthorizedAccessException exPath)
				{
				listViewResults.Items.Add(exPath.Message);
				}
			catch (Exception ex)
				{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		private void buttonSearch_Click(object sender, EventArgs e)
			{
			string fileName="";
			string contains="";

			listViewResults.Items.Clear();
			string path=textBoxPath.Text;
			Cursor.Current = Cursors.WaitCursor;
			
				// must be RegEx
				Regex regExContains=null;
				Boolean checkContains = false;
				Regex regExfileName;

				try
					{
					if (contains.Length > 0)
						{
						if (checkBoxCaseInsensitive.Checked)
							regExContains = new Regex(contains, RegexOptions.IgnoreCase);
						else
							regExContains = new Regex(contains);
						checkContains = true;
						}
					if (textBoxFileName.Text.Length > 0)
						fileName = textBoxFileName.Text;
					else
						fileName = ".*";
					regExfileName = new Regex(fileName, RegexOptions.IgnoreCase); // always ignore case for filenames
					RecursePathRegEx(regExfileName, path, regExContains, checkContains);
					}
				catch (Exception ex)
					{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
			
			Cursor.Current = Cursors.Default;
			}

		private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
			{
            if ( listViewResults.SelectedItems.Count > 0 )
				{
                string runMe = listViewResults.SelectedItems[0].Text;

				try
					{
					Process.Start(runMe);
					}
				catch (Exception ex)
					{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

			}

		private void contextMenuStripListBoxResults_Opening(object sender, CancelEventArgs e)
			{
			// don't do anything if the list is empty
			if ( listViewResults.Items.Count < 1 )
				e.Cancel = true;
			}

		private void toolStripMenuItemExport_Click(object sender, EventArgs e)
			{
			// export the list to a text file
			SaveFileDialog dlg = new SaveFileDialog();
			if (exportPath.Length > 0)
				dlg.InitialDirectory = exportPath;
			dlg.RestoreDirectory = true;
			dlg.ValidateNames = true;
			dlg.Filter = "txt files|*.txt|all files|*.*";
			dlg.CheckFileExists = false;
			dlg.CheckPathExists = true;
			dlg.OverwritePrompt = true;

			if (dlg.ShowDialog() == DialogResult.OK)
				{
                try
                    {
                    StreamWriter savefile = new StreamWriter(dlg.FileName, false);

                    if (savefile != null)
                        {
                        foreach (ColumnHeader h in listViewResults.Columns)
                            savefile.Write(h.Text + "; ");
                        savefile.WriteLine("");
                        foreach (ListViewItem item in listViewResults.Items)
                            {
                            savefile.WriteLine(item.SubItems[0].Text + "; " + item.SubItems[1].Text + "; " + item.SubItems[2].Text + "; " + item.SubItems[3].Text + "; " + item.SubItems[4].Text);
                            }
                        savefile.Close();
                        }
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
				}
			}

		private void copyFileNameToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
			{
            if (listViewResults.SelectedItems.Count > 0)
				{
                string copyMe = listViewResults.SelectedItems[0].Text;

                try
                    {
                    Clipboard.SetDataObject(copyMe);
                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
				}
			}

		private void openPathToolStripMenuItem_Click(object sender, EventArgs e)
			{
			if (listViewResults.SelectedItems.Count > 0 )
				{
				string openMe = listViewResults.SelectedItems[0].Text;
				string path = Path.GetDirectoryName(openMe);

				try
					{
					Process.Start(path);
					}
				catch (Exception ex)
					{
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
			}

        private void listViewResults_MouseDown(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Right)
                {
                ListViewItem item = listViewResults.GetItemAt(e.X, e.Y);
                if ( item != null )
                    {
                    item.Selected = true;
                    contextMenuStripListBoxResults.Show();
                    }
                }
            }

        private void listViewResults_DoubleClick(object sender, EventArgs e)
            {
            string runMe = listViewResults.SelectedItems[0].Text;
            try
                {
                Process.Start(runMe);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void listViewResults_ColumnClick(object sender, ColumnClickEventArgs e)
            {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
                {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                    lvwColumnSorter.Order = SortOrder.Descending;
                    }
                else
                    {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
            else
                {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
                }

            // Perform the sort with these new sort options.
            this.listViewResults.Sort();
            }

        private void button1_Click(object sender, EventArgs e)
        {
          
            textBoxFileName.Clear();
            textBoxPath.Clear();
            listViewResults.Clear();
        }

        
    }
	}
