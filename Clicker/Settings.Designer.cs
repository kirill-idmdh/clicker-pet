
namespace Clicker
{
    partial class Settings
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
            this.light_theme_radiobtn = new System.Windows.Forms.RadioButton();
            this.dark_theme_radiobtn = new System.Windows.Forms.RadioButton();
            this.language_lbl = new System.Windows.Forms.Label();
            this.theme_lbl = new System.Windows.Forms.Label();
            this.language_combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // light_theme_radiobtn
            // 
            this.light_theme_radiobtn.AutoSize = true;
            this.light_theme_radiobtn.Location = new System.Drawing.Point(120, 103);
            this.light_theme_radiobtn.Name = "light_theme_radiobtn";
            this.light_theme_radiobtn.Size = new System.Drawing.Size(67, 17);
            this.light_theme_radiobtn.TabIndex = 0;
            this.light_theme_radiobtn.Text = "Светлая";
            this.light_theme_radiobtn.UseVisualStyleBackColor = true;
            this.light_theme_radiobtn.CheckedChanged += new System.EventHandler(this.LightThemeRadioButtonSelected);
            // 
            // dark_theme_radiobtn
            // 
            this.dark_theme_radiobtn.AutoSize = true;
            this.dark_theme_radiobtn.Location = new System.Drawing.Point(120, 126);
            this.dark_theme_radiobtn.Name = "dark_theme_radiobtn";
            this.dark_theme_radiobtn.Size = new System.Drawing.Size(64, 17);
            this.dark_theme_radiobtn.TabIndex = 1;
            this.dark_theme_radiobtn.Text = "Темная";
            this.dark_theme_radiobtn.UseVisualStyleBackColor = true;
            this.dark_theme_radiobtn.CheckedChanged += new System.EventHandler(this.DarkThemeRadioButtonSelected);
            // 
            // language_lbl
            // 
            this.language_lbl.AutoSize = true;
            this.language_lbl.Location = new System.Drawing.Point(14, 66);
            this.language_lbl.Name = "language_lbl";
            this.language_lbl.Size = new System.Drawing.Size(35, 13);
            this.language_lbl.TabIndex = 2;
            this.language_lbl.Text = "Язык";
            // 
            // theme_lbl
            // 
            this.theme_lbl.AutoSize = true;
            this.theme_lbl.Location = new System.Drawing.Point(14, 105);
            this.theme_lbl.Name = "theme_lbl";
            this.theme_lbl.Size = new System.Drawing.Size(34, 13);
            this.theme_lbl.TabIndex = 3;
            this.theme_lbl.Text = "Тема";
            // 
            // language_combobox
            // 
            this.language_combobox.FormattingEnabled = true;
            this.language_combobox.Items.AddRange(new object[] {
            "Русский",
            "English",
            "中國人",
            "日本語"});
            this.language_combobox.Location = new System.Drawing.Point(120, 63);
            this.language_combobox.Name = "language_combobox";
            this.language_combobox.Size = new System.Drawing.Size(121, 21);
            this.language_combobox.TabIndex = 4;
            this.language_combobox.TabStop = false;
            this.language_combobox.SelectedIndexChanged += new System.EventHandler(this.LanguageSelected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(260, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Х";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.FormCloseButton);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.language_combobox);
            this.Controls.Add(this.theme_lbl);
            this.Controls.Add(this.language_lbl);
            this.Controls.Add(this.dark_theme_radiobtn);
            this.Controls.Add(this.light_theme_radiobtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton light_theme_radiobtn;
        private System.Windows.Forms.RadioButton dark_theme_radiobtn;
        private System.Windows.Forms.Label language_lbl;
        private System.Windows.Forms.Label theme_lbl;
        private System.Windows.Forms.ComboBox language_combobox;
        private System.Windows.Forms.Button button1;
    }
}