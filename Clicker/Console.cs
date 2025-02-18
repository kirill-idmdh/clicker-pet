using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/////////////////////////////////////////////////////////////////
//
//                         Задачи:
//
// 1. Конец игры исходя из лимита Int64 ( 9,223,372,036,854,775,807 ) [ ГОТОВО ]
// 2. Исключить возможность писать в параметры, которые принимают ТОЛЬКО числа, разного рода символы [ ГОТОВО ]
// 3. Почистить код [ ГОТОВО ]
// 4. Автоматическое изменение значений после команд add_imp и add_point [ ГОТОВО ]
// 5. Добавить дополнительные разделы с покупками (придумать)
// 6. Продумать экономику
// 7. Список ошибок [ ГОТОВО ]
// 8. "Настройки"
// 9. Возможность переключения светлой/темной темы
// 10. Локализация (ru, en) [ В ПРОЦЕССЕ ]
// 11. Аккаунт
// 12. База данных
//
/////////////////////////////////////////////////////////////////

namespace Clicker
{
    public partial class Console : Form
    {
        private ClickerForm clickerForm;
        private Settings settingsForm;

        public Console(ClickerForm _clickerForm)
        {
            InitializeComponent();
            this.clickerForm = _clickerForm;
            this.settingsForm = null;
            this.MouseDown += new MouseEventHandler((o, e) =>
            {
                base.Capture = false;
                Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref message);
            });
        }

        public static string logs;
        public static string logs_history = "] Clicker ver 0.2 alpha";
        public static long click_count_log;
        public static long click_imp_log;
        public static string console_logs;
        public static string output_version = "] Clicker ver 0.2 alpha";
        public static string test_commands = "This is a testing environment for developing commands";

        public void CommandsOldVer()
        {
            string command_and_value = console_input.Text;
            string[] command_and_value_split = command_and_value.Split(' ');

            if (command_and_value_split[0] == "add_imp")
            {
                if (1 >= 0 && 1 < command_and_value_split.Length)
                {
                    if (ContainsOnlyDigits(command_and_value_split[1])) 
                    {
                        if (Convert.ToInt64(command_and_value_split[1]) == 0)
                        {
                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2003. The number of points per click cannot be lower than 0.";
                            console_input.Text = "";
                        }
                        else
                        {
                            long add_imps = Convert.ToInt64(command_and_value_split[1]);
                            ClickerForm.imps += add_imps;
                            this.clickerForm.clicks_cps_text.Text = Convert.ToString(ClickerForm.imps) + " О/К";
                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + add_imps + " improvings added. IRT: " + ClickerForm.imps + " S/C";
                            console_input.Text = "";
                        }
                    } 
                    else
                    {
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2002. The command parameter only accepts numbers.";
                        console_input.Text = "";
                    }    
                }
                else if (command_and_value_split.Length == 1)
                {
                    console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                    console_input.Text = "";
                }
            }
            else if (command_and_value_split[0] == "add_point")
            {
                if (1 >= 0 && 1 < command_and_value_split.Length)
                {
                    if (ContainsOnlyDigits(command_and_value_split[1]))
                    {
                        if (Convert.ToInt64(command_and_value_split[1]) == 0)
                        {
                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2003. The total points cannot be lower than 0.";
                            console_input.Text = "";
                        }
                        else
                        {
                            long add_points = Convert.ToInt64(command_and_value_split[1]);
                            ClickerForm.points += add_points;
                            this.clickerForm.clicks_count_text.Text = Convert.ToString(ClickerForm.points);
                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + add_points + " points added. PRT: " + ClickerForm.points + " S/C";
                            console_input.Text = "";
                        }
                    }
                    else
                    {
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2002. The command parameter only accepts numbers.";
                        console_input.Text = "";
                    } 
                }
                else if (command_and_value_split.Length == 1)
                {
                    console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                    console_input.Text = "";
                }
            }
            else
            {
                switch (console_input.Text)
                {
                    case "":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 101. Enter the command.";
                        break;

                    case "help":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Commands:" + Environment.NewLine +
                            "   clct         --  Displaying the number of points per click at the current time." + Environment.NewLine +
                            "   logs         --  Output of program action logs." + Environment.NewLine +
                            "   clear        --  Clearing the console." + Environment.NewLine +
                            "   upd_changes  --  Show update changes list.";
                        console_input.Text = "";
                        break;

                    case "hello":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Hi, User!";
                        console_input.Text = "";
                        break;

                    case "logs":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Logs not recorded.";
                        console_input.Text = "";
                        break;

                    case "clct":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Points: " + ClickerForm.points + ", " + "improvings: " + ClickerForm.imps + " S/C";
                        console_input.Text = "";
                        break;

                    case "clear":
                        console_log.Text = output_version;
                        console_input.Text = "";
                        break;

                    case "exit":
                        console_log.Text = "";
                        console_input.Text = "";
                        logs_history = output_version;
                        this.Hide();
                        break;

                    case "upd_changes":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Список изменений в 0.2 Alpha:" + Environment.NewLine +
                            "   1.   -   Увеличено количество суммарных очков и очков за клик ( Int32 > Int64 )" + Environment.NewLine +
                            "   2.   -   Администраторам добавлена возможность вручную вводить значения на добавление суммарных очков и очков за клик ( add_imp и add_point )" + Environment.NewLine +
                            "   3.   - ";
                        console_input.Text = "";
                        break;

                    case "err_list":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Errors list:" + Environment.NewLine +
                            "   1XXX Errors - Errors in commands:" + Environment.NewLine +
                            "   1001   -   This command does not exist. Check that you entered the commands correctly. List of commands - 'help'." + Environment.NewLine +
                            " " + Environment.NewLine +
                            "   2XXX Errors - Errors in command parameters:" + Environment.NewLine +
                            "   2001   -   No values entered." + Environment.NewLine +
                            "   2002   -   Invalid values ​​entered." + Environment.NewLine +
                            "   2003   -   Values ​​entered that cause the final value to be less than 0." + Environment.NewLine +
                            "   2004   -   Unknown or empty parameter for method" + Environment.NewLine +
                            "   2005   -   No method selected for command" + Environment.NewLine +
                            " " + Environment.NewLine +
                            "   1XX Errors  -  Common errors in using the console:" + Environment.NewLine +
                            "   101    -   Empty field sent to console.";
                        console_input.Text = "";
                        break;

                    default:
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 1001. Unknown command. Write 'help'";
                        console_input.Text = "";
                        break;
                }
            }
        }

        public void Commands()
        {
            string command_and_value = console_input.Text;
            string[] command_and_value_split = command_and_value.Split(' ');

            if (command_and_value_split[0] == "imp")
            {
                if (command_and_value_split.Length == 1)
                {
                    console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2005. No method selected for command.";
                    console_input.Text = "";
                }
                else
                {
                    if (1 >= 0 && 1 < command_and_value_split.Length)
                    {
                        if (command_and_value_split[1] == "add")
                        {
                            if (command_and_value_split.Length == 2)
                            {
                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                                console_input.Text = "";
                            }
                            else
                            {
                                if (2 >= 1 && 2 < command_and_value_split.Length)
                                {
                                    if (ContainsOnlyDigits(command_and_value_split[2]))
                                    {
                                        if (Convert.ToInt64(command_and_value_split[2]) == 0)
                                        {
                                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                                            console_input.Text = "";
                                        }
                                        else
                                        {
                                            long add_imps = Convert.ToInt64(command_and_value_split[2]);
                                            ClickerForm.imps += add_imps;
                                            this.clickerForm.clicks_cps_text.Text = Convert.ToString(ClickerForm.imps) + " О/К";
                                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + add_imps + " improvings added. IRT: " + ClickerForm.imps + " S/C";
                                            console_input.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2002. The command parameter only accepts numbers.";
                                        console_input.Text = "";
                                    }
                                }
                            }
                        }
                        else if (command_and_value_split[1] == "remove")
                        {
                            if (command_and_value_split.Length == 2)
                            {
                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                                console_input.Text = "";
                            }
                            else
                            {
                                if (2 >= 1 && 2 < command_and_value_split.Length)
                                {
                                    if (ContainsOnlyDigits(command_and_value_split[2]))
                                    {
                                        if (Convert.ToInt64(command_and_value_split[2]) == 0)
                                        {
                                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                                            console_input.Text = "";
                                        }
                                        else
                                        {
                                            long remove_imps = Convert.ToInt64(command_and_value_split[2]);
                                            ClickerForm.imps -= remove_imps;

                                            if (ClickerForm.imps < 0)
                                            {
                                                ClickerForm.imps = 0;
                                                this.clickerForm.clicks_cps_text.Text = Convert.ToString(ClickerForm.imps) + " О/К";
                                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Warning! Actions that produce a value less than zero will automatically be zero.";
                                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + remove_imps + " improvings removed. IRT: " + ClickerForm.imps + " S/C";
                                                console_input.Text = "";
                                            }
                                            else
                                            {
                                                this.clickerForm.clicks_cps_text.Text = Convert.ToString(ClickerForm.imps) + " О/К";
                                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + remove_imps + " improvings removed. IRT: " + ClickerForm.imps + " S/C";
                                                console_input.Text = "";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2002. The command parameter only accepts numbers.";
                                        console_input.Text = "";
                                    }
                                }
                            }   
                        }
                        else
                        {
                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2004. Unknown or empty parameter for method.";
                            console_input.Text = "";
                        }
                    }
                    else if (command_and_value_split.Length == 2)
                    {
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                        console_input.Text = "";
                    }
                }
            }
            else if (command_and_value_split[0] == "point")
            {
                if (command_and_value_split.Length == 1)
                {
                    console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2005. No method selected for command.";
                    console_input.Text = "";
                }
                else
                {
                    if (1 >= 0 && 1 < command_and_value_split.Length)
                    {
                        if (command_and_value_split[1] == "add")
                        {
                            if (command_and_value_split.Length == 2)
                            {
                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                                console_input.Text = "";
                            }
                            else
                            {
                                if (2 >= 1 && 2 < command_and_value_split.Length)
                                {
                                    if (ContainsOnlyDigits(command_and_value_split[2]))
                                    {
                                        if (Convert.ToInt64(command_and_value_split[2]) == 0)
                                        {
                                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                                            console_input.Text = "";
                                        }
                                        else
                                        {
                                            long add_points = Convert.ToInt64(command_and_value_split[2]);
                                            ClickerForm.points += add_points;
                                            this.clickerForm.clicks_count_text.Text = Convert.ToString(ClickerForm.points);
                                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + add_points + " points added. PRT: " + ClickerForm.points + " S/C";
                                            console_input.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2002. The command parameter only accepts numbers.";
                                        console_input.Text = "";
                                    }
                                }
                            }   
                        }
                        else if (command_and_value_split[1] == "remove")
                        {
                            if (command_and_value_split.Length == 2)
                            {
                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                                console_input.Text = "";
                            }
                            else
                            {
                                if (2 >= 1 && 2 < command_and_value_split.Length)
                                {
                                    if (ContainsOnlyDigits(command_and_value_split[2]))
                                    {
                                        if (Convert.ToInt64(command_and_value_split[2]) == 0)
                                        {
                                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                                            console_input.Text = "";
                                        }
                                        else
                                        {
                                            long remove_points = Convert.ToInt64(command_and_value_split[2]);
                                            ClickerForm.points -= remove_points;

                                            if (ClickerForm.points < 0)
                                            {
                                                ClickerForm.points = 0;
                                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Warning! Actions that produce a value less than zero will automatically be zero.";
                                                this.clickerForm.clicks_count_text.Text = Convert.ToString(ClickerForm.points);
                                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + remove_points + " points removed. PRT: " + ClickerForm.points + " S/C";
                                                console_input.Text = "";
                                            }
                                            else
                                            {
                                                this.clickerForm.clicks_cps_text.Text = Convert.ToString(ClickerForm.imps) + " О/К";
                                                console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + remove_points + " points removed. IRT: " + ClickerForm.imps + " S/C";
                                                console_input.Text = "";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2002. The command parameter only accepts numbers.";
                                        console_input.Text = "";
                                    }
                                }
                            }    
                        }
                        else
                        {
                            console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2004. Unknown or empty parameter for method.";
                            console_input.Text = "";
                        }
                    }
                    else if (command_and_value_split.Length == 2)
                    {
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 2001. Enter value.";
                        console_input.Text = "";
                    }
                }
            }
            else
            {
                switch (console_input.Text)
                {
                    case "":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 101. Enter the command.";
                        break;

                    case "help":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Commands:" + Environment.NewLine +
                            "   clct         --  Displaying the number of points per click at the current time." + Environment.NewLine +
                            "   logs         --  Output of program action logs." + Environment.NewLine +
                            "   clear        --  Clearing the console." + Environment.NewLine +
                            "   upd_changes  --  Show update changes list.";
                        console_input.Text = "";
                        break;

                    case "hello":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Hi, User!";
                        console_input.Text = "";
                        break;

                    case "logs":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Logs not recorded.";
                        console_input.Text = "";
                        break;

                    case "clct":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Points: " + ClickerForm.points + ", " + "improvings: " + ClickerForm.imps + " S/C";
                        console_input.Text = "";
                        break;

                    case "clear":
                        console_log.Text = output_version;
                        console_input.Text = "";
                        break;

                    case "exit":
                        console_log.Text = "";
                        console_input.Text = "";
                        logs_history = output_version;
                        this.Hide();
                        break;

                    case "upd_changes":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Список изменений в 0.2 Alpha:" + Environment.NewLine +
                            "   1.   -   Увеличено количество суммарных очков и очков за клик ( Int32 > Int64 )" + Environment.NewLine +
                            "   2.   -   Администраторам добавлена возможность вручную вводить значения на добавление суммарных очков и очков за клик ( add_imp и add_point )" + Environment.NewLine +
                            "   3.   - ";
                        console_input.Text = "";
                        break;

                    case "err_list":
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Errors list:" + Environment.NewLine +
                            "   1XXX Errors - Errors in commands:" + Environment.NewLine +
                            "   1001   -   This command does not exist. Check that you entered the commands correctly. List of commands - 'help'." + Environment.NewLine +
                            " " + Environment.NewLine +
                            "   2XXX Errors - Errors in command parameters:" + Environment.NewLine +
                            "   2001   -   No values entered." + Environment.NewLine +
                            "   2002   -   Invalid values ​​entered." + Environment.NewLine +
                            "   2003   -   Values ​​entered that cause the final value to be less than 0." + Environment.NewLine +
                            "   2004   -   Unknown or empty parameter for method" + Environment.NewLine +
                            "   2005   -   No method selected for command" + Environment.NewLine +
                            " " + Environment.NewLine +
                            "   1XX Errors  -  Common errors in using the console:" + Environment.NewLine +
                            "   101    -   Empty field sent to console.";
                        console_input.Text = "";
                        break;

                    default:
                        console_log.Text = console_log.Text + logs + Environment.NewLine + "] " + "[" + DateTime.Now + "] " + "Error: 1001. Unknown command. Write 'help'";
                        console_input.Text = "";
                        break;
                }
            }
        }

        static bool ContainsOnlyDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void SumbitConsole()
        {
            Commands();
            console_logs = console_log.Text;
        }

        private void Sumbit(object sender, EventArgs e)
        {
            SumbitConsole();
        }
       
        private void FormLoad(object sender, EventArgs e)
        {
            console_log.Text = output_version;
        }

        public void SumbitPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SumbitConsole();
            }
        }

        private void Console_FormClosing(object sender, FormClosingEventArgs e)
        {
            logs_history = console_log.Text;
        }

        private void FormCloseButton(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
