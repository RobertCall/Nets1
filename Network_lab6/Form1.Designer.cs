namespace Network_lab6
{
    partial class Form1
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
            this.file_tree = new System.Windows.Forms.ListView();
            this.server_name = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // file_tree
            // 
            this.file_tree.HideSelection = false;
            this.file_tree.Location = new System.Drawing.Point(12, 54);
            this.file_tree.Name = "file_tree";
            this.file_tree.Size = new System.Drawing.Size(452, 363);
            this.file_tree.TabIndex = 0;
            this.file_tree.UseCompatibleStateImageBehavior = false;
            this.file_tree.View = System.Windows.Forms.View.List;
            this.file_tree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.file_tree_MouseDoubleClick);
            // 
            // server_name
            // 
            this.server_name.Location = new System.Drawing.Point(518, 34);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(270, 20);
            this.server_name.TabIndex = 1;
            this.server_name.Text = "ftp1.at.proftpd.org";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(518, 74);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(270, 20);
            this.user_name.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(518, 121);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(270, 20);
            this.password.TabIndex = 3;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(518, 178);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 4;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 423);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(452, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.server_name);
            this.Controls.Add(this.file_tree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView file_tree;
        private System.Windows.Forms.TextBox server_name;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

