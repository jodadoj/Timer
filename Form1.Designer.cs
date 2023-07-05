namespace Timer
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
            this.lbl_current_time = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_time_01 = new System.Windows.Forms.Label();
            this.lbl_time_02 = new System.Windows.Forms.Label();
            this.lbl_time_03 = new System.Windows.Forms.Label();
            this.lbl_time_04 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_current_time
            // 
            this.lbl_current_time.AutoSize = true;
            this.lbl_current_time.Font = new System.Drawing.Font("BankGothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_current_time.Location = new System.Drawing.Point(75, 33);
            this.lbl_current_time.Name = "lbl_current_time";
            this.lbl_current_time.Size = new System.Drawing.Size(365, 48);
            this.lbl_current_time.TabIndex = 0;
            this.lbl_current_time.Text = "00:00:00:00";
            this.lbl_current_time.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.LightGreen;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Location = new System.Drawing.Point(56, 108);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(110, 50);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.DarkRed;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_stop.Location = new System.Drawing.Point(198, 108);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(110, 50);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Gold;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(338, 108);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(110, 50);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(95, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Previous sessions:";
            // 
            // lbl_time_01
            // 
            this.lbl_time_01.AutoSize = true;
            this.lbl_time_01.Font = new System.Drawing.Font("BankGothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_01.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time_01.Location = new System.Drawing.Point(75, 239);
            this.lbl_time_01.Name = "lbl_time_01";
            this.lbl_time_01.Size = new System.Drawing.Size(365, 48);
            this.lbl_time_01.TabIndex = 5;
            this.lbl_time_01.Text = "00:00:00:00";
            // 
            // lbl_time_02
            // 
            this.lbl_time_02.AutoSize = true;
            this.lbl_time_02.Font = new System.Drawing.Font("BankGothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_02.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time_02.Location = new System.Drawing.Point(75, 301);
            this.lbl_time_02.Name = "lbl_time_02";
            this.lbl_time_02.Size = new System.Drawing.Size(365, 48);
            this.lbl_time_02.TabIndex = 6;
            this.lbl_time_02.Text = "00:00:00:00";
            // 
            // lbl_time_03
            // 
            this.lbl_time_03.AutoSize = true;
            this.lbl_time_03.Font = new System.Drawing.Font("BankGothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_03.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time_03.Location = new System.Drawing.Point(75, 361);
            this.lbl_time_03.Name = "lbl_time_03";
            this.lbl_time_03.Size = new System.Drawing.Size(365, 48);
            this.lbl_time_03.TabIndex = 7;
            this.lbl_time_03.Text = "00:00:00:00";
            // 
            // lbl_time_04
            // 
            this.lbl_time_04.AutoSize = true;
            this.lbl_time_04.Font = new System.Drawing.Font("BankGothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_04.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_time_04.Location = new System.Drawing.Point(75, 422);
            this.lbl_time_04.Name = "lbl_time_04";
            this.lbl_time_04.Size = new System.Drawing.Size(365, 48);
            this.lbl_time_04.TabIndex = 8;
            this.lbl_time_04.Text = "00:00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(499, 493);
            this.Controls.Add(this.lbl_time_04);
            this.Controls.Add(this.lbl_time_03);
            this.Controls.Add(this.lbl_time_02);
            this.Controls.Add(this.lbl_time_01);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_current_time);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "Gambette senpai!!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_current_time;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_time_01;
        private System.Windows.Forms.Label lbl_time_02;
        private System.Windows.Forms.Label lbl_time_03;
        private System.Windows.Forms.Label lbl_time_04;
    }
}

