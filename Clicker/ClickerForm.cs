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
    public partial class ClickerForm : Form
    {
        private Console consoleForm;
        private Settings settingsForm;

        public ClickerForm()
        {
            InitializeComponent();
            this.consoleForm = null;
            this.settingsForm = null;
        }

        public static long points;
        public static long imps = 1;
        public static long s_i_p = 10;
        public static long a_i_p = 50;
        public static long b_i_p = 100;
        public static long s_i_c = 0;
        public static long a_i_c = 0;
        public static long b_i_c = 0;

        public void ImpsPriceVerif()
        {
            if (Convert.ToInt64(clicks_count_text.Text) >= Convert.ToInt64(s_i_p_t.Text))
            {
                small_imp_price_btn.Enabled = true;
            }
            else
            {
                small_imp_price_btn.Enabled = false;
            }

            if (Convert.ToInt64(clicks_count_text.Text) >= Convert.ToInt64(a_i_p_t.Text))
            {
                middle_imp_price_btn.Enabled = true;
            }
            else
            {
                middle_imp_price_btn.Enabled = false;
            }

            if (Convert.ToInt64(clicks_count_text.Text) >= Convert.ToInt64(b_i_p_t.Text))
            {
                big_imp_price_btn.Enabled = true;
            }
            else
            {
                big_imp_price_btn.Enabled = false;
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            clicks_count_text.Text = Convert.ToString(points);
            clicks_cps_text.Text = Convert.ToString(imps) + " О/К";
            s_i_p_t.Text = Convert.ToString(s_i_p);
            a_i_p_t.Text = Convert.ToString(a_i_p);
            b_i_p_t.Text = Convert.ToString(b_i_p);
            s_i_c_t.Text = Convert.ToString(s_i_c);
            a_i_c_t.Text = Convert.ToString(a_i_c);
            b_i_c_t.Text = Convert.ToString(b_i_c);
        }

        private void ClicksBtn(object sender, EventArgs e)
        {
            if (points >= 9223372036854775807)
            {
                DialogResult result = MessageBox.Show("Вы прошли игру. Начать заново?", "Поздравляю!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    points = 0;
                    imps = 1;
                }
                else
                {
                    points = 9223372036854775807;
                    endToolStripMenuItem.Visible = true;
                    clicks_btn.Enabled = false;
                    small_imp_price_btn.Enabled = false;
                    middle_imp_price_btn.Enabled = false;
                    big_imp_price_btn.Enabled = false;
                }
            } 
            else if (points < 9223372036854775807)
            {
                clicks_count_text.Text = Convert.ToString(points + imps);
                points += imps;

                ImpsPriceVerif();
            }
        }

        private void SmallImpPriceBtn(object sender, EventArgs e)
        {
            imps++;
            clicks_cps_text.Text = Convert.ToString(imps) + " О/К";
            clicks_count_text.Text = Convert.ToString(points - s_i_p);
            points = Convert.ToInt64(clicks_count_text.Text);
            s_i_p_t.Text = Convert.ToString(s_i_p + 10);
            s_i_p = Convert.ToInt64(s_i_p_t.Text);
            s_i_c += 1;
            s_i_c_t.Text = Convert.ToString(s_i_c);
            ImpsPriceVerif();
        }

        private void AverageImpPriceBtn(object sender, EventArgs e)
        {
            imps += 10;
            clicks_cps_text.Text = Convert.ToString(imps) + " О/К";
            clicks_count_text.Text = Convert.ToString(points - a_i_p);
            points = Convert.ToInt64(clicks_count_text.Text);
            a_i_p_t.Text = Convert.ToString(a_i_p + 50);
            a_i_p = Convert.ToInt64(a_i_p_t.Text);
            a_i_c += 1;
            a_i_c_t.Text = Convert.ToString(a_i_c);
            ImpsPriceVerif();
        }

        private void BigImpPriceBtn(object sender, EventArgs e)
        {
            imps += 100;
            clicks_cps_text.Text = Convert.ToString(imps) + " О/К";
            clicks_count_text.Text = Convert.ToString(points - b_i_p);
            points = Convert.ToInt64(clicks_count_text.Text);
            b_i_p_t.Text = Convert.ToString(b_i_p + 200);
            b_i_p = Convert.ToInt64(b_i_p_t.Text);
            b_i_c += 1;
            b_i_c_t.Text = Convert.ToString(b_i_c);
            ImpsPriceVerif();
        }

        private void ConsoleOpen(object sender, EventArgs e)
        {
            if (this.consoleForm == null)
            {
                this.consoleForm = new Console(this);
            }
            this.consoleForm.Show();
        }

        private void RetryGame(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы прошли игру. Начать заново?", "Поздравляю!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                points = 0;
                clicks_count_text.Text = Convert.ToString(points);
                imps = 1;
                clicks_cps_text.Text = Convert.ToString(imps) + " O/K";
                clicks_btn.Enabled = true;
                endToolStripMenuItem.Visible = false;
            }
        }

        private void SettingsOpen(object sender, EventArgs e)
        {
            if (this.settingsForm == null)
            {
                this.settingsForm = new Settings(this);
            }
            this.settingsForm.Show();
        }
    }
}