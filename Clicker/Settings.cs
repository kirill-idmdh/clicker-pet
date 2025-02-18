using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Settings : Form
    {
        private ClickerForm clickerForm;

        public Settings(ClickerForm _clickerForm)
        {
            InitializeComponent();
            this.clickerForm = _clickerForm;
            this.MouseDown += new MouseEventHandler((o, e) =>
            {
                base.Capture = false;
                Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref message);
            });
        }

        private void FormLoad(object sender, EventArgs e)
        {
            language_combobox.Text = "Русский";
            light_theme_radiobtn.Checked = true;
        }

        private void FormCloseButton(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LanguageSelected(object sender, EventArgs e)
        {
            switch (language_combobox.Text)
            {
                case "Русский":
                    this.clickerForm.click_label_text.Text = "Очки:";
                    this.clickerForm.shop_label_text.Text = "Магазин";
                    this.clickerForm.clicks_btn.Text = "Клик";
                    this.clickerForm.small_imp_price_btn.Text = "Малое улучшение (+1)";
                    this.clickerForm.middle_imp_price_btn.Text = "Среднее улучшение (+10)";
                    this.clickerForm.big_imp_price_btn.Text = "Большое улучшение (+100)";
                    this.clickerForm.AdditionallyToolStripMenuItem.Text = "Дополнительно";
                    this.clickerForm.consoleToolStripMenuItem.Text = "Консоль";
                    this.clickerForm.settingsToolStripMenuItem.Text = "Настройки";
                    this.clickerForm.endToolStripMenuItem.Text = "Закончить игру";
                    break;

                case "English":
                    this.clickerForm.click_label_text.Text = "Points:";
                    this.clickerForm.shop_label_text.Text = "Shop";
                    this.clickerForm.clicks_btn.Text = "Click";
                    this.clickerForm.small_imp_price_btn.Text = "Minor improvement (+1)";
                    this.clickerForm.middle_imp_price_btn.Text = "Average improvement (+10)";
                    this.clickerForm.big_imp_price_btn.Text = "Big improvement (+100)";
                    this.clickerForm.AdditionallyToolStripMenuItem.Text = "Additionally";
                    this.clickerForm.consoleToolStripMenuItem.Text = "Console";
                    this.clickerForm.settingsToolStripMenuItem.Text = "Settings";
                    this.clickerForm.endToolStripMenuItem.Text = "End the game";
                    break;

                case "中國人":
                    this.clickerForm.click_label_text.Text = "眼鏡:";
                    this.clickerForm.shop_label_text.Text = "店鋪";
                    this.clickerForm.clicks_btn.Text = "點選";
                    this.clickerForm.small_imp_price_btn.Text = "小改進 (+1)";
                    this.clickerForm.middle_imp_price_btn.Text = "平均改善 (+10)";
                    this.clickerForm.big_imp_price_btn.Text = "很大的進步 (+100)";
                    this.clickerForm.AdditionallyToolStripMenuItem.Text = "另外";
                    this.clickerForm.consoleToolStripMenuItem.Text = "安慰";
                    this.clickerForm.settingsToolStripMenuItem.Text = "設定";
                    this.clickerForm.endToolStripMenuItem.Text = "完成遊戲";
                    break;

                case "日本語":
                    this.clickerForm.click_label_text.Text = "ポイント:";
                    this.clickerForm.shop_label_text.Text = "購入品";
                    this.clickerForm.clicks_btn.Text = "クリック";
                    this.clickerForm.small_imp_price_btn.Text = "軽微な改善 (+1)";
                    this.clickerForm.middle_imp_price_btn.Text = "平均的な改善 (+10)";
                    this.clickerForm.big_imp_price_btn.Text = "大幅な改善 (+100)";
                    this.clickerForm.AdditionallyToolStripMenuItem.Text = "さらに";
                    this.clickerForm.consoleToolStripMenuItem.Text = "コンソール";
                    this.clickerForm.settingsToolStripMenuItem.Text = "プログラム設定";
                    this.clickerForm.endToolStripMenuItem.Text = "ゲームを終了する";
                    break;
            }
        }

        private void LightThemeRadioButtonSelected(object sender, EventArgs e)
        {
            this.clickerForm.BackColor = Color.White;
        }

        private void DarkThemeRadioButtonSelected(object sender, EventArgs e)
        {
            //Buttons
            this.clickerForm.BackColor = Color.DimGray;
            this.clickerForm.small_imp_price_btn.BackColor = Color.Gray;
            this.clickerForm.middle_imp_price_btn.BackColor = Color.Gray;
            this.clickerForm.big_imp_price_btn.BackColor = Color.Gray;
            this.clickerForm.clicks_btn.BackColor = Color.Gray;
            this.clickerForm.small_imp_price_btn.ForeColor = Color.Silver;
            this.clickerForm.middle_imp_price_btn.ForeColor = Color.Silver;
            this.clickerForm.big_imp_price_btn.ForeColor = Color.Silver;
            this.clickerForm.clicks_btn.ForeColor = Color.Silver;

            //Labels
            this.clickerForm.click_label_text.ForeColor = Color.Silver;
            this.clickerForm.clicks_count_text.ForeColor = Color.Silver;
            this.clickerForm.clicks_cps_text.ForeColor = Color.Silver;
            this.clickerForm.shop_label_text.ForeColor = Color.Silver;
            this.clickerForm.s_i_p_t.ForeColor = Color.Silver;
            this.clickerForm.s_i_c_t.ForeColor = Color.Silver;
            this.clickerForm.a_i_p_t.ForeColor = Color.Silver;
            this.clickerForm.a_i_c_t.ForeColor = Color.Silver;
            this.clickerForm.b_i_p_t.ForeColor = Color.Silver;
            this.clickerForm.b_i_c_t.ForeColor = Color.Silver;
        }
    }
}
