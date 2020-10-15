namespace Network_lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Server_Start_Button = new System.Windows.Forms.Button();
            this.Server_Status_Label = new System.Windows.Forms.Label();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Server_Stop_Button = new System.Windows.Forms.Button();
            this.Server_progressBar = new System.Windows.Forms.ProgressBar();
            this.time_label1 = new System.Windows.Forms.Label();
            this.time_label2 = new System.Windows.Forms.Label();
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Port_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Server_Port_textBox = new System.Windows.Forms.TextBox();
            this.Client_progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Server_Start_Button
            // 
            this.Server_Start_Button.Location = new System.Drawing.Point(446, 12);
            this.Server_Start_Button.Name = "Server_Start_Button";
            this.Server_Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Server_Start_Button.TabIndex = 0;
            this.Server_Start_Button.Text = "Start";
            this.Server_Start_Button.UseVisualStyleBackColor = true;
            this.Server_Start_Button.Click += new System.EventHandler(this.Server_Button_Click);
            // 
            // Server_Status_Label
            // 
            this.Server_Status_Label.AutoSize = true;
            this.Server_Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Server_Status_Label.Location = new System.Drawing.Point(12, 92);
            this.Server_Status_Label.Name = "Server_Status_Label";
            this.Server_Status_Label.Size = new System.Drawing.Size(131, 20);
            this.Server_Status_Label.TabIndex = 1;
            this.Server_Status_Label.Text = "Server not listen";
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(446, 282);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 2;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Server_Stop_Button
            // 
            this.Server_Stop_Button.Location = new System.Drawing.Point(538, 12);
            this.Server_Stop_Button.Name = "Server_Stop_Button";
            this.Server_Stop_Button.Size = new System.Drawing.Size(75, 23);
            this.Server_Stop_Button.TabIndex = 3;
            this.Server_Stop_Button.Text = "Stop";
            this.Server_Stop_Button.UseVisualStyleBackColor = true;
            this.Server_Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Server_progressBar
            // 
            this.Server_progressBar.Location = new System.Drawing.Point(16, 133);
            this.Server_progressBar.Name = "Server_progressBar";
            this.Server_progressBar.Size = new System.Drawing.Size(758, 23);
            this.Server_progressBar.TabIndex = 4;
            // 
            // time_label1
            // 
            this.time_label1.AutoSize = true;
            this.time_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_label1.Location = new System.Drawing.Point(263, 92);
            this.time_label1.Name = "time_label1";
            this.time_label1.Size = new System.Drawing.Size(96, 20);
            this.time_label1.TabIndex = 5;
            this.time_label1.Text = "Time spend";
            // 
            // time_label2
            // 
            this.time_label2.AutoSize = true;
            this.time_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_label2.Location = new System.Drawing.Point(505, 92);
            this.time_label2.Name = "time_label2";
            this.time_label2.Size = new System.Drawing.Size(74, 20);
            this.time_label2.TabIndex = 6;
            this.time_label2.Text = "Time left";
            // 
            // IP_textBox
            // 
            this.IP_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IP_textBox.Location = new System.Drawing.Point(32, 282);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(200, 26);
            this.IP_textBox.TabIndex = 7;
            this.IP_textBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP Adress";
            // 
            // Port_textBox
            // 
            this.Port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Port_textBox.Location = new System.Drawing.Point(238, 282);
            this.Port_textBox.Name = "Port_textBox";
            this.Port_textBox.Size = new System.Drawing.Size(100, 26);
            this.Port_textBox.TabIndex = 9;
            this.Port_textBox.Text = "8888";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(234, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "c:\\Users\\rober\\OneDrive\\Рабочий стол\\Институт\\Nets\\";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port";
            // 
            // Server_Port_textBox
            // 
            this.Server_Port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Server_Port_textBox.Location = new System.Drawing.Point(43, 30);
            this.Server_Port_textBox.Name = "Server_Port_textBox";
            this.Server_Port_textBox.Size = new System.Drawing.Size(100, 26);
            this.Server_Port_textBox.TabIndex = 11;
            this.Server_Port_textBox.Text = "8888";
            // 
            // Client_progressBar
            // 
            this.Client_progressBar.Location = new System.Drawing.Point(16, 337);
            this.Client_progressBar.Name = "Client_progressBar";
            this.Client_progressBar.Size = new System.Drawing.Size(758, 23);
            this.Client_progressBar.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Client_progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Server_Port_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Port_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP_textBox);
            this.Controls.Add(this.time_label2);
            this.Controls.Add(this.time_label1);
            this.Controls.Add(this.Server_progressBar);
            this.Controls.Add(this.Server_Stop_Button);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Server_Status_Label);
            this.Controls.Add(this.Server_Start_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Server_Start_Button;
        public System.Windows.Forms.Label Server_Status_Label;
        public System.Windows.Forms.Button Server_Stop_Button;
        public System.Windows.Forms.ProgressBar Server_progressBar;
        public System.Windows.Forms.Label time_label1;
        public System.Windows.Forms.Label time_label2;

        public System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Server_Port_textBox;
        public System.Windows.Forms.ProgressBar Client_progressBar;
    }
}

