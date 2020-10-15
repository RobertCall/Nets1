namespace Network_lab2
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
            this.Send_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.src_port_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.src_ip_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dst_port_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dst_ip_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(24, 175);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(75, 23);
            this.Send_button.TabIndex = 0;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(223, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port";
            // 
            // src_port_textBox
            // 
            this.src_port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.src_port_textBox.Location = new System.Drawing.Point(227, 45);
            this.src_port_textBox.Name = "src_port_textBox";
            this.src_port_textBox.Size = new System.Drawing.Size(100, 26);
            this.src_port_textBox.TabIndex = 13;
            this.src_port_textBox.Text = "8888";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP Adress";
            // 
            // src_ip_textBox
            // 
            this.src_ip_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.src_ip_textBox.Location = new System.Drawing.Point(21, 45);
            this.src_ip_textBox.Name = "src_ip_textBox";
            this.src_ip_textBox.Size = new System.Drawing.Size(200, 26);
            this.src_ip_textBox.TabIndex = 11;
            this.src_ip_textBox.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(223, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Port";
            // 
            // dst_port_textBox
            // 
            this.dst_port_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dst_port_textBox.Location = new System.Drawing.Point(227, 111);
            this.dst_port_textBox.Name = "dst_port_textBox";
            this.dst_port_textBox.Size = new System.Drawing.Size(100, 26);
            this.dst_port_textBox.TabIndex = 17;
            this.dst_port_textBox.Text = "8888";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "IP Adress";
            // 
            // dst_ip_textBox
            // 
            this.dst_ip_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dst_ip_textBox.Location = new System.Drawing.Point(21, 111);
            this.dst_ip_textBox.Name = "dst_ip_textBox";
            this.dst_ip_textBox.Size = new System.Drawing.Size(200, 26);
            this.dst_ip_textBox.TabIndex = 15;
            this.dst_ip_textBox.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dst_port_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dst_ip_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.src_port_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.src_ip_textBox);
            this.Controls.Add(this.Send_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox src_port_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox src_ip_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dst_port_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dst_ip_textBox;
    }
}

