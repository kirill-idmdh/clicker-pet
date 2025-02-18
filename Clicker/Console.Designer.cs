
namespace Clicker
{
    partial class Console
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
            this.console_log = new System.Windows.Forms.TextBox();
            this.console_input = new System.Windows.Forms.TextBox();
            this.console_sumbit_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // console_log
            // 
            this.console_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.console_log.Location = new System.Drawing.Point(5, 54);
            this.console_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.console_log.Multiline = true;
            this.console_log.Name = "console_log";
            this.console_log.ReadOnly = true;
            this.console_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console_log.Size = new System.Drawing.Size(691, 400);
            this.console_log.TabIndex = 0;
            this.console_log.TabStop = false;
            this.console_log.Text = "console_screen";
            // 
            // console_input
            // 
            this.console_input.Location = new System.Drawing.Point(5, 474);
            this.console_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.console_input.Name = "console_input";
            this.console_input.Size = new System.Drawing.Size(577, 22);
            this.console_input.TabIndex = 1;
            this.console_input.TabStop = false;
            this.console_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumbitPressEnter);
            // 
            // console_sumbit_btn
            // 
            this.console_sumbit_btn.Location = new System.Drawing.Point(588, 469);
            this.console_sumbit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.console_sumbit_btn.Name = "console_sumbit_btn";
            this.console_sumbit_btn.Size = new System.Drawing.Size(108, 31);
            this.console_sumbit_btn.TabIndex = 2;
            this.console_sumbit_btn.TabStop = false;
            this.console_sumbit_btn.Text = "Sumbit";
            this.console_sumbit_btn.UseVisualStyleBackColor = true;
            this.console_sumbit_btn.Click += new System.EventHandler(this.Sumbit);
            this.console_sumbit_btn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumbitPressEnter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(656, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.FormCloseButton);
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.console_sumbit_btn);
            this.Controls.Add(this.console_input);
            this.Controls.Add(this.console_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Console";
            this.Text = "Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Console_FormClosing);
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox console_input;
        private System.Windows.Forms.Button console_sumbit_btn;
        private System.Windows.Forms.TextBox console_log;
        private System.Windows.Forms.Button button1;
    }
}