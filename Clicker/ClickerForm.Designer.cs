
namespace Clicker
{
    partial class ClickerForm
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
            this.clicks_btn = new System.Windows.Forms.Button();
            this.click_label_text = new System.Windows.Forms.Label();
            this.clicks_count_text = new System.Windows.Forms.Label();
            this.clicks_cps_text = new System.Windows.Forms.Label();
            this.shop_label_text = new System.Windows.Forms.Label();
            this.small_imp_price_btn = new System.Windows.Forms.Button();
            this.middle_imp_price_btn = new System.Windows.Forms.Button();
            this.big_imp_price_btn = new System.Windows.Forms.Button();
            this.s_i_p_t = new System.Windows.Forms.Label();
            this.a_i_p_t = new System.Windows.Forms.Label();
            this.b_i_p_t = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AdditionallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s_i_c_t = new System.Windows.Forms.Label();
            this.a_i_c_t = new System.Windows.Forms.Label();
            this.b_i_c_t = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clicks_btn
            // 
            this.clicks_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clicks_btn.Location = new System.Drawing.Point(40, 172);
            this.clicks_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clicks_btn.Name = "clicks_btn";
            this.clicks_btn.Size = new System.Drawing.Size(112, 29);
            this.clicks_btn.TabIndex = 0;
            this.clicks_btn.TabStop = false;
            this.clicks_btn.Text = "Клик";
            this.clicks_btn.UseVisualStyleBackColor = true;
            this.clicks_btn.Click += new System.EventHandler(this.ClicksBtn);
            // 
            // click_label_text
            // 
            this.click_label_text.AutoSize = true;
            this.click_label_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.click_label_text.Location = new System.Drawing.Point(38, 118);
            this.click_label_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.click_label_text.Name = "click_label_text";
            this.click_label_text.Size = new System.Drawing.Size(75, 26);
            this.click_label_text.TabIndex = 1;
            this.click_label_text.Text = "Очки:";
            // 
            // clicks_count_text
            // 
            this.clicks_count_text.AutoSize = true;
            this.clicks_count_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clicks_count_text.Location = new System.Drawing.Point(38, 144);
            this.clicks_count_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clicks_count_text.Name = "clicks_count_text";
            this.clicks_count_text.Size = new System.Drawing.Size(143, 26);
            this.clicks_count_text.TabIndex = 2;
            this.clicks_count_text.Text = "clicks_count";
            // 
            // clicks_cps_text
            // 
            this.clicks_cps_text.AutoSize = true;
            this.clicks_cps_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clicks_cps_text.Location = new System.Drawing.Point(39, 203);
            this.clicks_cps_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clicks_cps_text.Name = "clicks_cps_text";
            this.clicks_cps_text.Size = new System.Drawing.Size(81, 20);
            this.clicks_cps_text.TabIndex = 3;
            this.clicks_cps_text.Text = "clicks_cps";
            // 
            // shop_label_text
            // 
            this.shop_label_text.AutoSize = true;
            this.shop_label_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shop_label_text.Location = new System.Drawing.Point(509, 44);
            this.shop_label_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shop_label_text.Name = "shop_label_text";
            this.shop_label_text.Size = new System.Drawing.Size(104, 26);
            this.shop_label_text.TabIndex = 4;
            this.shop_label_text.Text = "Магазин";
            // 
            // small_imp_price_btn
            // 
            this.small_imp_price_btn.Enabled = false;
            this.small_imp_price_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.small_imp_price_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.small_imp_price_btn.Location = new System.Drawing.Point(514, 85);
            this.small_imp_price_btn.Margin = new System.Windows.Forms.Padding(2);
            this.small_imp_price_btn.Name = "small_imp_price_btn";
            this.small_imp_price_btn.Size = new System.Drawing.Size(167, 65);
            this.small_imp_price_btn.TabIndex = 5;
            this.small_imp_price_btn.TabStop = false;
            this.small_imp_price_btn.Text = "Малое улучшение (+1)";
            this.small_imp_price_btn.UseVisualStyleBackColor = true;
            this.small_imp_price_btn.Click += new System.EventHandler(this.SmallImpPriceBtn);
            // 
            // middle_imp_price_btn
            // 
            this.middle_imp_price_btn.Enabled = false;
            this.middle_imp_price_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middle_imp_price_btn.Location = new System.Drawing.Point(514, 154);
            this.middle_imp_price_btn.Margin = new System.Windows.Forms.Padding(2);
            this.middle_imp_price_btn.Name = "middle_imp_price_btn";
            this.middle_imp_price_btn.Size = new System.Drawing.Size(167, 65);
            this.middle_imp_price_btn.TabIndex = 6;
            this.middle_imp_price_btn.TabStop = false;
            this.middle_imp_price_btn.Text = "Среднее улучшение (+10)";
            this.middle_imp_price_btn.UseVisualStyleBackColor = true;
            this.middle_imp_price_btn.Click += new System.EventHandler(this.AverageImpPriceBtn);
            // 
            // big_imp_price_btn
            // 
            this.big_imp_price_btn.Enabled = false;
            this.big_imp_price_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.big_imp_price_btn.Location = new System.Drawing.Point(514, 223);
            this.big_imp_price_btn.Margin = new System.Windows.Forms.Padding(2);
            this.big_imp_price_btn.Name = "big_imp_price_btn";
            this.big_imp_price_btn.Size = new System.Drawing.Size(167, 65);
            this.big_imp_price_btn.TabIndex = 7;
            this.big_imp_price_btn.TabStop = false;
            this.big_imp_price_btn.Text = "Большое улучшение (+100)";
            this.big_imp_price_btn.UseVisualStyleBackColor = true;
            this.big_imp_price_btn.Click += new System.EventHandler(this.BigImpPriceBtn);
            // 
            // s_i_p_t
            // 
            this.s_i_p_t.AutoSize = true;
            this.s_i_p_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s_i_p_t.Location = new System.Drawing.Point(684, 85);
            this.s_i_p_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.s_i_p_t.Name = "s_i_p_t";
            this.s_i_p_t.Size = new System.Drawing.Size(68, 20);
            this.s_i_p_t.TabIndex = 8;
            this.s_i_p_t.Text = "s_i_p_t";
            // 
            // a_i_p_t
            // 
            this.a_i_p_t.AutoSize = true;
            this.a_i_p_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_i_p_t.Location = new System.Drawing.Point(684, 154);
            this.a_i_p_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.a_i_p_t.Name = "a_i_p_t";
            this.a_i_p_t.Size = new System.Drawing.Size(69, 20);
            this.a_i_p_t.TabIndex = 9;
            this.a_i_p_t.Text = "a_i_p_t";
            // 
            // b_i_p_t
            // 
            this.b_i_p_t.AutoSize = true;
            this.b_i_p_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_i_p_t.Location = new System.Drawing.Point(684, 223);
            this.b_i_p_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.b_i_p_t.Name = "b_i_p_t";
            this.b_i_p_t.Size = new System.Drawing.Size(69, 20);
            this.b_i_p_t.TabIndex = 10;
            this.b_i_p_t.Text = "b_i_p_t";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdditionallyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdditionallyToolStripMenuItem
            // 
            this.AdditionallyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.endToolStripMenuItem});
            this.AdditionallyToolStripMenuItem.Name = "AdditionallyToolStripMenuItem";
            this.AdditionallyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AdditionallyToolStripMenuItem.Text = "Дополнительно";
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.ConsoleOpen);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsOpen);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.endToolStripMenuItem.Text = "End";
            this.endToolStripMenuItem.Visible = false;
            this.endToolStripMenuItem.Click += new System.EventHandler(this.RetryGame);
            // 
            // s_i_c_t
            // 
            this.s_i_c_t.AutoSize = true;
            this.s_i_c_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s_i_c_t.Location = new System.Drawing.Point(684, 130);
            this.s_i_c_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.s_i_c_t.Name = "s_i_c_t";
            this.s_i_c_t.Size = new System.Drawing.Size(67, 20);
            this.s_i_c_t.TabIndex = 12;
            this.s_i_c_t.Text = "s_i_c_t";
            // 
            // a_i_c_t
            // 
            this.a_i_c_t.AutoSize = true;
            this.a_i_c_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_i_c_t.Location = new System.Drawing.Point(684, 199);
            this.a_i_c_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.a_i_c_t.Name = "a_i_c_t";
            this.a_i_c_t.Size = new System.Drawing.Size(68, 20);
            this.a_i_c_t.TabIndex = 13;
            this.a_i_c_t.Text = "a_i_c_t";
            // 
            // b_i_c_t
            // 
            this.b_i_c_t.AutoSize = true;
            this.b_i_c_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_i_c_t.Location = new System.Drawing.Point(684, 268);
            this.b_i_c_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.b_i_c_t.Name = "b_i_c_t";
            this.b_i_c_t.Size = new System.Drawing.Size(68, 20);
            this.b_i_c_t.TabIndex = 14;
            this.b_i_c_t.Text = "b_i_c_t";
            // 
            // ClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 343);
            this.Controls.Add(this.b_i_c_t);
            this.Controls.Add(this.a_i_c_t);
            this.Controls.Add(this.s_i_c_t);
            this.Controls.Add(this.b_i_p_t);
            this.Controls.Add(this.a_i_p_t);
            this.Controls.Add(this.s_i_p_t);
            this.Controls.Add(this.big_imp_price_btn);
            this.Controls.Add(this.middle_imp_price_btn);
            this.Controls.Add(this.small_imp_price_btn);
            this.Controls.Add(this.shop_label_text);
            this.Controls.Add(this.clicks_cps_text);
            this.Controls.Add(this.clicks_count_text);
            this.Controls.Add(this.click_label_text);
            this.Controls.Add(this.clicks_btn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clicker";
            this.Load += new System.EventHandler(this.FormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Label clicks_count_text;
        public System.Windows.Forms.Label clicks_cps_text;
        public System.Windows.Forms.Label click_label_text;
        public System.Windows.Forms.Label shop_label_text;
        public System.Windows.Forms.Button small_imp_price_btn;
        public System.Windows.Forms.Button middle_imp_price_btn;
        public System.Windows.Forms.Button big_imp_price_btn;
        public System.Windows.Forms.ToolStripMenuItem AdditionallyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.Button clicks_btn;
        public System.Windows.Forms.Label s_i_p_t;
        public System.Windows.Forms.Label a_i_p_t;
        public System.Windows.Forms.Label b_i_p_t;
        public System.Windows.Forms.Label s_i_c_t;
        public System.Windows.Forms.Label a_i_c_t;
        public System.Windows.Forms.Label b_i_c_t;
    }
}

