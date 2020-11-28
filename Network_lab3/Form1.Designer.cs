namespace Network_lab3
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
            this.Status_label = new System.Windows.Forms.Label();
            this.OutputView = new System.Windows.Forms.TextBox();
            this.Get_button = new System.Windows.Forms.Button();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Status_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status_label.Location = new System.Drawing.Point(12, 43);
            this.Status_label.MaximumSize = new System.Drawing.Size(631, 19);
            this.Status_label.MinimumSize = new System.Drawing.Size(631, 0);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(631, 19);
            this.Status_label.TabIndex = 0;
            // 
            // OutputView
            // 
            this.OutputView.BackColor = System.Drawing.SystemColors.HighlightText;
            this.OutputView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputView.Location = new System.Drawing.Point(12, 68);
            this.OutputView.Multiline = true;
            this.OutputView.Name = "OutputView";
            this.OutputView.ReadOnly = true;
            this.OutputView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputView.Size = new System.Drawing.Size(631, 370);
            this.OutputView.TabIndex = 1;
            // 
            // Get_button
            // 
            this.Get_button.Location = new System.Drawing.Point(676, 12);
            this.Get_button.Name = "Get_button";
            this.Get_button.Size = new System.Drawing.Size(75, 23);
            this.Get_button.TabIndex = 2;
            this.Get_button.Text = "get";
            this.Get_button.UseVisualStyleBackColor = true;
            this.Get_button.Click += new System.EventHandler(this.Get_button_Click);
            // 
            // InputAddress
            // 
            this.InputAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputAddress.Location = new System.Drawing.Point(12, 12);
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(631, 26);
            this.InputAddress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputAddress);
            this.Controls.Add(this.Get_button);
            this.Controls.Add(this.OutputView);
            this.Controls.Add(this.Status_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.TextBox OutputView;
        private System.Windows.Forms.Button Get_button;
        private System.Windows.Forms.TextBox InputAddress;
    }
}

