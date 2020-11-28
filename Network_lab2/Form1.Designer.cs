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
            this.packets_list = new System.Windows.Forms.ListView();
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.src_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dst_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.tcp_checkBox = new System.Windows.Forms.CheckBox();
            this.udp_checkBox = new System.Windows.Forms.CheckBox();
            this.ip_checkBox = new System.Windows.Forms.CheckBox();
            this.icmp_checkBox = new System.Windows.Forms.CheckBox();
            this.SRC_IP_textBox = new System.Windows.Forms.TextBox();
            this.DST_IP_textBox = new System.Windows.Forms.TextBox();
            this.SRC_port_textBox = new System.Windows.Forms.TextBox();
            this.DST_port_textBox = new System.Windows.Forms.TextBox();
            this.Data_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // packets_list
            // 
            this.packets_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.time,
            this.src_ip,
            this.dst_ip});
            this.packets_list.HideSelection = false;
            this.packets_list.Location = new System.Drawing.Point(12, 12);
            this.packets_list.Name = "packets_list";
            this.packets_list.Size = new System.Drawing.Size(648, 426);
            this.packets_list.TabIndex = 0;
            this.packets_list.UseCompatibleStateImageBehavior = false;
            this.packets_list.View = System.Windows.Forms.View.Details;
            this.packets_list.ItemActivate += new System.EventHandler(this.packets_list_ItemActivate);
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 175;
            // 
            // src_ip
            // 
            this.src_ip.Text = "Source";
            this.src_ip.Width = 165;
            // 
            // dst_ip
            // 
            this.dst_ip.Text = "Destination";
            this.dst_ip.Width = 195;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(701, 12);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 1;
            this.Start_button.Text = "Listen";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(701, 139);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 2;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(990, 198);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 3;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // tcp_checkBox
            // 
            this.tcp_checkBox.AutoSize = true;
            this.tcp_checkBox.Location = new System.Drawing.Point(701, 42);
            this.tcp_checkBox.Name = "tcp_checkBox";
            this.tcp_checkBox.Size = new System.Drawing.Size(47, 17);
            this.tcp_checkBox.TabIndex = 4;
            this.tcp_checkBox.Text = "TCP";
            this.tcp_checkBox.UseVisualStyleBackColor = true;
            // 
            // udp_checkBox
            // 
            this.udp_checkBox.AutoSize = true;
            this.udp_checkBox.Location = new System.Drawing.Point(701, 66);
            this.udp_checkBox.Name = "udp_checkBox";
            this.udp_checkBox.Size = new System.Drawing.Size(49, 17);
            this.udp_checkBox.TabIndex = 5;
            this.udp_checkBox.Text = "UDP";
            this.udp_checkBox.UseVisualStyleBackColor = true;
            // 
            // ip_checkBox
            // 
            this.ip_checkBox.AutoSize = true;
            this.ip_checkBox.Location = new System.Drawing.Point(701, 90);
            this.ip_checkBox.Name = "ip_checkBox";
            this.ip_checkBox.Size = new System.Drawing.Size(36, 17);
            this.ip_checkBox.TabIndex = 6;
            this.ip_checkBox.Text = "IP";
            this.ip_checkBox.UseVisualStyleBackColor = true;
            // 
            // icmp_checkBox
            // 
            this.icmp_checkBox.AutoSize = true;
            this.icmp_checkBox.Location = new System.Drawing.Point(701, 114);
            this.icmp_checkBox.Name = "icmp_checkBox";
            this.icmp_checkBox.Size = new System.Drawing.Size(52, 17);
            this.icmp_checkBox.TabIndex = 7;
            this.icmp_checkBox.Text = "ICMP";
            this.icmp_checkBox.UseVisualStyleBackColor = true;
            // 
            // SRC_IP_textBox
            // 
            this.SRC_IP_textBox.Location = new System.Drawing.Point(900, 40);
            this.SRC_IP_textBox.Name = "SRC_IP_textBox";
            this.SRC_IP_textBox.Size = new System.Drawing.Size(100, 20);
            this.SRC_IP_textBox.TabIndex = 8;
            this.SRC_IP_textBox.Text = "127.0.0.1";
            // 
            // DST_IP_textBox
            // 
            this.DST_IP_textBox.Location = new System.Drawing.Point(1055, 40);
            this.DST_IP_textBox.Name = "DST_IP_textBox";
            this.DST_IP_textBox.Size = new System.Drawing.Size(100, 20);
            this.DST_IP_textBox.TabIndex = 9;
            this.DST_IP_textBox.Text = "127.0.0.1";
            // 
            // SRC_port_textBox
            // 
            this.SRC_port_textBox.Location = new System.Drawing.Point(900, 80);
            this.SRC_port_textBox.Name = "SRC_port_textBox";
            this.SRC_port_textBox.Size = new System.Drawing.Size(100, 20);
            this.SRC_port_textBox.TabIndex = 10;
            this.SRC_port_textBox.Text = "8000";
            // 
            // DST_port_textBox
            // 
            this.DST_port_textBox.Location = new System.Drawing.Point(1055, 80);
            this.DST_port_textBox.Name = "DST_port_textBox";
            this.DST_port_textBox.Size = new System.Drawing.Size(100, 20);
            this.DST_port_textBox.TabIndex = 11;
            this.DST_port_textBox.Text = "8001";
            // 
            // Data_textBox
            // 
            this.Data_textBox.Location = new System.Drawing.Point(900, 139);
            this.Data_textBox.Name = "Data_textBox";
            this.Data_textBox.Size = new System.Drawing.Size(255, 20);
            this.Data_textBox.TabIndex = 12;
            this.Data_textBox.Text = "I like dogs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(897, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "SRC IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1052, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "DST IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(897, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "SRC Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1052, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "DST Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(900, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_textBox);
            this.Controls.Add(this.DST_port_textBox);
            this.Controls.Add(this.SRC_port_textBox);
            this.Controls.Add(this.DST_IP_textBox);
            this.Controls.Add(this.SRC_IP_textBox);
            this.Controls.Add(this.icmp_checkBox);
            this.Controls.Add(this.ip_checkBox);
            this.Controls.Add(this.udp_checkBox);
            this.Controls.Add(this.tcp_checkBox);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.packets_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView packets_list;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader src_ip;
        private System.Windows.Forms.ColumnHeader dst_ip;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.CheckBox tcp_checkBox;
        private System.Windows.Forms.CheckBox udp_checkBox;
        private System.Windows.Forms.CheckBox ip_checkBox;
        private System.Windows.Forms.CheckBox icmp_checkBox;
        private System.Windows.Forms.TextBox SRC_IP_textBox;
        private System.Windows.Forms.TextBox DST_IP_textBox;
        private System.Windows.Forms.TextBox SRC_port_textBox;
        private System.Windows.Forms.TextBox DST_port_textBox;
        private System.Windows.Forms.TextBox Data_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

