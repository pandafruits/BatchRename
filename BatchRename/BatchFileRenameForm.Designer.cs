namespace BatchRename
{
    partial class BatchFileRenameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchFileRenameForm));
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.textBoxFileEntries = new System.Windows.Forms.TextBox();
            this.labelReplace = new System.Windows.Forms.Label();
            this.textBoxOldName = new System.Windows.Forms.TextBox();
            this.labelWith = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.buttonRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Location = new System.Drawing.Point(93, 17);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(0, 13);
            this.labelFolderPath.TabIndex = 1;
            // 
            // textBoxFileEntries
            // 
            this.textBoxFileEntries.Location = new System.Drawing.Point(12, 164);
            this.textBoxFileEntries.Multiline = true;
            this.textBoxFileEntries.Name = "textBoxFileEntries";
            this.textBoxFileEntries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFileEntries.Size = new System.Drawing.Size(575, 243);
            this.textBoxFileEntries.TabIndex = 2;
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(12, 53);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(50, 13);
            this.labelReplace.TabIndex = 3;
            this.labelReplace.Text = "Replace:";
            // 
            // textBoxOldName
            // 
            this.textBoxOldName.Location = new System.Drawing.Point(68, 50);
            this.textBoxOldName.Name = "textBoxOldName";
            this.textBoxOldName.Size = new System.Drawing.Size(519, 20);
            this.textBoxOldName.TabIndex = 4;
            // 
            // labelWith
            // 
            this.labelWith.AutoSize = true;
            this.labelWith.Location = new System.Drawing.Point(12, 90);
            this.labelWith.Name = "labelWith";
            this.labelWith.Size = new System.Drawing.Size(32, 13);
            this.labelWith.TabIndex = 5;
            this.labelWith.Text = "With:";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(68, 87);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(519, 20);
            this.textBoxNewName.TabIndex = 6;
            // 
            // buttonRename
            // 
            this.buttonRename.Enabled = false;
            this.buttonRename.Location = new System.Drawing.Point(12, 123);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(75, 23);
            this.buttonRename.TabIndex = 7;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // BatchFileRenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 419);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelWith);
            this.Controls.Add(this.textBoxOldName);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.textBoxFileEntries);
            this.Controls.Add(this.labelFolderPath);
            this.Controls.Add(this.buttonBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(615, 458);
            this.MinimumSize = new System.Drawing.Size(615, 458);
            this.Name = "BatchFileRenameForm";
            this.Text = "BatchRename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.TextBox textBoxFileEntries;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.TextBox textBoxOldName;
        private System.Windows.Forms.Label labelWith;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Button buttonRename;
    }
}

