namespace ping
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
            this.First_Octet = new System.Windows.Forms.TextBox();
            this.Fourth_Octet = new System.Windows.Forms.TextBox();
            this.Third_Octet = new System.Windows.Forms.TextBox();
            this.Second_Octet = new System.Windows.Forms.TextBox();
            this.First_Dot = new System.Windows.Forms.Label();
            this.Third_Dot = new System.Windows.Forms.Label();
            this.Second_Dot = new System.Windows.Forms.Label();
            this.Ping_button = new System.Windows.Forms.Button();
            this.IP_label = new System.Windows.Forms.Label();
            this.IPConfig_Button = new System.Windows.Forms.Button();
            this.Parameters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // First_Octet
            // 
            this.First_Octet.Location = new System.Drawing.Point(31, 38);
            this.First_Octet.Name = "First_Octet";
            this.First_Octet.Size = new System.Drawing.Size(29, 20);
            this.First_Octet.TabIndex = 1;
            this.First_Octet.TextChanged += new System.EventHandler(this.First_Octet_TextChanged);
            // 
            // Fourth_Octet
            // 
            this.Fourth_Octet.Location = new System.Drawing.Point(176, 38);
            this.Fourth_Octet.Name = "Fourth_Octet";
            this.Fourth_Octet.Size = new System.Drawing.Size(29, 20);
            this.Fourth_Octet.TabIndex = 4;
            this.Fourth_Octet.TextChanged += new System.EventHandler(this.Fourth_Octet_TextChanged);
            // 
            // Third_Octet
            // 
            this.Third_Octet.Location = new System.Drawing.Point(127, 38);
            this.Third_Octet.Name = "Third_Octet";
            this.Third_Octet.Size = new System.Drawing.Size(29, 20);
            this.Third_Octet.TabIndex = 3;
            this.Third_Octet.TextChanged += new System.EventHandler(this.Third_Octet_TextChanged);
            // 
            // Second_Octet
            // 
            this.Second_Octet.Location = new System.Drawing.Point(78, 38);
            this.Second_Octet.Name = "Second_Octet";
            this.Second_Octet.Size = new System.Drawing.Size(29, 20);
            this.Second_Octet.TabIndex = 2;
            this.Second_Octet.TextChanged += new System.EventHandler(this.Second_Octet_TextChanged);
            // 
            // First_Dot
            // 
            this.First_Dot.AutoSize = true;
            this.First_Dot.Location = new System.Drawing.Point(62, 45);
            this.First_Dot.Name = "First_Dot";
            this.First_Dot.Size = new System.Drawing.Size(10, 13);
            this.First_Dot.TabIndex = 4;
            this.First_Dot.Text = ".";
            // 
            // Third_Dot
            // 
            this.Third_Dot.AutoSize = true;
            this.Third_Dot.Location = new System.Drawing.Point(162, 45);
            this.Third_Dot.Name = "Third_Dot";
            this.Third_Dot.Size = new System.Drawing.Size(10, 13);
            this.Third_Dot.TabIndex = 5;
            this.Third_Dot.Text = ".";
            // 
            // Second_Dot
            // 
            this.Second_Dot.AutoSize = true;
            this.Second_Dot.Location = new System.Drawing.Point(111, 45);
            this.Second_Dot.Name = "Second_Dot";
            this.Second_Dot.Size = new System.Drawing.Size(10, 13);
            this.Second_Dot.TabIndex = 6;
            this.Second_Dot.Text = ".";
            // 
            // Ping_button
            // 
            this.Ping_button.Location = new System.Drawing.Point(302, 35);
            this.Ping_button.Name = "Ping_button";
            this.Ping_button.Size = new System.Drawing.Size(75, 23);
            this.Ping_button.TabIndex = 5;
            this.Ping_button.Text = "Ping";
            this.Ping_button.UseVisualStyleBackColor = true;
            this.Ping_button.Click += new System.EventHandler(this.Ping_button_Click);
            // 
            // IP_label
            // 
            this.IP_label.AutoSize = true;
            this.IP_label.Location = new System.Drawing.Point(28, 9);
            this.IP_label.Name = "IP_label";
            this.IP_label.Size = new System.Drawing.Size(86, 13);
            this.IP_label.TabIndex = 0;
            this.IP_label.Text = "Enter IP Address";
            // 
            // IPConfig_Button
            // 
            this.IPConfig_Button.Location = new System.Drawing.Point(198, 157);
            this.IPConfig_Button.Name = "IPConfig_Button";
            this.IPConfig_Button.Size = new System.Drawing.Size(152, 50);
            this.IPConfig_Button.TabIndex = 7;
            this.IPConfig_Button.Text = "IPconfig";
            this.IPConfig_Button.UseVisualStyleBackColor = true;
            this.IPConfig_Button.Click += new System.EventHandler(this.IPConfig_Button_Click);
            // 
            // Parameters
            // 
            this.Parameters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parameters.FormattingEnabled = true;
            this.Parameters.Location = new System.Drawing.Point(31, 173);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(90, 21);
            this.Parameters.TabIndex = 6;
            this.Parameters.SelectedIndexChanged += new System.EventHandler(this.Parameters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Parameter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(389, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.IPConfig_Button);
            this.Controls.Add(this.IP_label);
            this.Controls.Add(this.Ping_button);
            this.Controls.Add(this.Second_Dot);
            this.Controls.Add(this.Third_Dot);
            this.Controls.Add(this.First_Dot);
            this.Controls.Add(this.Second_Octet);
            this.Controls.Add(this.Third_Octet);
            this.Controls.Add(this.Fourth_Octet);
            this.Controls.Add(this.First_Octet);
            this.Name = "Form1";
            this.Text = "Ping Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox First_Octet;
        private System.Windows.Forms.TextBox Fourth_Octet;
        private System.Windows.Forms.TextBox Third_Octet;
        private System.Windows.Forms.TextBox Second_Octet;
        private System.Windows.Forms.Label First_Dot;
        private System.Windows.Forms.Label Third_Dot;
        private System.Windows.Forms.Label Second_Dot;
        private System.Windows.Forms.Button Ping_button;
        private System.Windows.Forms.Label IP_label;
        private System.Windows.Forms.Button IPConfig_Button;
        private System.Windows.Forms.ComboBox Parameters;
        private System.Windows.Forms.Label label1;
    }
}

