namespace FileSearch
	{
	partial class FormFileSearch
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowsePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.contextMenuStripListBoxResults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFileNameToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxCaseInsensitive = new System.Windows.Forms.CheckBox();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModifyDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStripListBoxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(98, 85);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(393, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // buttonBrowsePath
            // 
            this.buttonBrowsePath.Location = new System.Drawing.Point(533, 81);
            this.buttonBrowsePath.Name = "buttonBrowsePath";
            this.buttonBrowsePath.Size = new System.Drawing.Size(75, 53);
            this.buttonBrowsePath.TabIndex = 4;
            this.buttonBrowsePath.Text = "Browse";
            this.buttonBrowsePath.UseVisualStyleBackColor = true;
            this.buttonBrowsePath.Click += new System.EventHandler(this.buttonBrowsePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Name";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(98, 120);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(217, 20);
            this.textBoxFileName.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(152, 168);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 40);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // contextMenuStripListBoxResults
            // 
            this.contextMenuStripListBoxResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemExport,
            this.copyFileNameToClipboardToolStripMenuItem,
            this.openPathToolStripMenuItem});
            this.contextMenuStripListBoxResults.Name = "contextMenuStripListBoxResults";
            this.contextMenuStripListBoxResults.Size = new System.Drawing.Size(228, 92);
            this.contextMenuStripListBoxResults.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripListBoxResults_Opening);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(227, 22);
            this.toolStripMenuItemOpen.Text = "Open this File";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemExport
            // 
            this.toolStripMenuItemExport.Name = "toolStripMenuItemExport";
            this.toolStripMenuItemExport.Size = new System.Drawing.Size(227, 22);
            this.toolStripMenuItemExport.Text = "Export List";
            this.toolStripMenuItemExport.Click += new System.EventHandler(this.toolStripMenuItemExport_Click);
            // 
            // copyFileNameToClipboardToolStripMenuItem
            // 
            this.copyFileNameToClipboardToolStripMenuItem.Name = "copyFileNameToClipboardToolStripMenuItem";
            this.copyFileNameToClipboardToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.copyFileNameToClipboardToolStripMenuItem.Text = "Copy File Name to Clipboard";
            this.copyFileNameToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyFileNameToClipboardToolStripMenuItem_Click);
            // 
            // openPathToolStripMenuItem
            // 
            this.openPathToolStripMenuItem.Name = "openPathToolStripMenuItem";
            this.openPathToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openPathToolStripMenuItem.Text = "Open Path";
            this.openPathToolStripMenuItem.Click += new System.EventHandler(this.openPathToolStripMenuItem_Click);
            // 
            // checkBoxCaseInsensitive
            // 
            this.checkBoxCaseInsensitive.AutoSize = true;
            this.checkBoxCaseInsensitive.Checked = true;
            this.checkBoxCaseInsensitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCaseInsensitive.Location = new System.Drawing.Point(31, 180);
            this.checkBoxCaseInsensitive.Name = "checkBoxCaseInsensitive";
            this.checkBoxCaseInsensitive.Size = new System.Drawing.Size(103, 17);
            this.checkBoxCaseInsensitive.TabIndex = 10;
            this.checkBoxCaseInsensitive.Text = "Case Insensitive";
            this.checkBoxCaseInsensitive.UseVisualStyleBackColor = true;
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSize,
            this.columnHeaderCreateDate,
            this.columnHeaderModifyDate,
            this.columnHeaderType});
            this.listViewResults.ContextMenuStrip = this.contextMenuStripListBoxResults;
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.Location = new System.Drawing.Point(23, 237);
            this.listViewResults.MultiSelect = false;
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(874, 225);
            this.listViewResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewResults.TabIndex = 11;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            this.listViewResults.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewResults_ColumnClick);
            this.listViewResults.DoubleClick += new System.EventHandler(this.listViewResults_DoubleClick);
            this.listViewResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewResults_MouseDown);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "File Name";
            this.columnHeaderName.Width = 412;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 93;
            // 
            // columnHeaderCreateDate
            // 
            this.columnHeaderCreateDate.Text = "Create Date";
            this.columnHeaderCreateDate.Width = 141;
            // 
            // columnHeaderModifyDate
            // 
            this.columnHeaderModifyDate.Text = "Modify Date";
            this.columnHeaderModifyDate.Width = 149;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 74;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileSearch.Properties.Resources.file_search;
            this.pictureBox1.Location = new System.Drawing.Point(686, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 79);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "https://www.linkedin.com/in/ozmencelik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ozzy Ozmen Celik";
            // 
            // FormFileSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.checkBoxCaseInsensitive);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBrowsePath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 440);
            this.Name = "FormFileSearch";
            this.Text = "FileSearch";
            this.Load += new System.EventHandler(this.FormFileSearch_Load);
            this.contextMenuStripListBoxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonBrowsePath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripListBoxResults;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExport;
		private System.Windows.Forms.ToolStripMenuItem copyFileNameToClipboardToolStripMenuItem;
		private System.Windows.Forms.CheckBox checkBoxCaseInsensitive;
		private System.Windows.Forms.ToolStripMenuItem openPathToolStripMenuItem;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderCreateDate;
        private System.Windows.Forms.ColumnHeader columnHeaderModifyDate;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
	}

