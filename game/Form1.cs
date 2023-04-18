using System;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace game
{
    public partial class Form1 : Form
    {
        int count = 4, count_nums = 1, count_click = 0, count_max = 0;
        public Form1()
        {
            InitializeComponent();
        }
        int count_miss = 0;
        private void bt_start_Click(object sender, EventArgs e)
        {
            count = 4;
            count_nums = 1;
            count_click = 0;
            count_miss = 0;
            white_back();
        }

        void vis_false_bt()
        {
            for (int i = 1; i < 41; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            button1.Text = "";
                            button1.Visible = false;
                            break;
                        }
                    case 2:
                        {
                            button2.Text = "";
                            button2.Visible = false;
                            break;
                        }
                    case 3:
                        {
                            button3.Text = "";
                            button3.Visible = false;
                            break;
                        }
                    case 4:
                        {
                            button4.Text = "";
                            button4.Visible = false;
                            break;
                        }
                    case 5:
                        {
                            button5.Text = "";
                            button5.Visible = false;
                            break;
                        }
                    case 6:
                        {
                            button6.Text = "";
                            button6.Visible = false;
                            break;
                        }
                    case 7:
                        {
                            button7.Text = "";
                            button7.Visible = false;
                            break;
                        }
                    case 8:
                        {
                            button8.Text = "";
                            button8.Visible = false;
                            break;
                        }
                    case 9:
                        {
                            button9.Text = "";
                            button9.Visible = false;
                            break;
                        }
                    case 10:
                        {
                            button10.Text = "";
                            button10.Visible = false;
                            break;
                        }
                    case 11:
                        {
                            button11.Text = "";
                            button11.Visible = false;
                            break;
                        }
                    case 12:
                        {
                            button12.Text = "";
                            button12.Visible = false;
                            break;
                        }
                    case 13:
                        {
                            button13.Text = "";
                            button13.Visible = false;
                            break;
                        }
                    case 14:
                        {
                            button14.Text = "";
                            button14.Visible = false;
                            break;
                        }
                    case 15:
                        {
                            button15.Text = "";
                            button15.Visible = false;
                            break;
                        }
                    case 16:
                        {
                            button16.Text = "";
                            button16.Visible = false;
                            break;
                        }
                    case 17:
                        {
                            button17.Text = "";
                            button17.Visible = false;
                            break;
                        }
                    case 18:
                        {
                            button18.Text = "";
                            button18.Visible = false;
                            break;
                        }
                    case 19:
                        {
                            button19.Text = "";
                            button19.Visible = false;
                            break;
                        }
                    case 20:
                        {
                            button20.Text = "";
                            button20.Visible = false;
                            break;
                        }
                    case 21:
                        {
                            button21.Text = "";
                            button21.Visible = false;
                            break;
                        }
                    case 22:
                        {
                            button22.Text = "";
                            button22.Visible = false;
                            break;
                        }
                    case 23:
                        {
                            button23.Text = "";
                            button23.Visible = false;
                            break;
                        }
                    case 24:
                        {
                            button24.Text = "";
                            button24.Visible = false;
                            break;
                        }
                    case 25:
                        {
                            button25.Text = "";
                            button25.Visible = false;
                            break;
                        }
                    case 26:
                        {
                            button26.Text = "";
                            button26.Visible = false;
                            break;
                        }
                    case 27:
                        {
                            button27.Text = "";
                            button27.Visible = false;
                            break;
                        }
                    case 28:
                        {
                            button28.Text = "";
                            button28.Visible = false;
                            break;
                        }
                    case 29:
                        {
                            button29.Text = "";
                            button29.Visible = false;
                            break;
                        }
                    case 30:
                        {
                            button30.Text = "";
                            button30.Visible = false;
                            break;
                        }
                    case 31:
                        {
                            button31.Text = "";
                            button31.Visible = false;
                            break;
                        }
                    case 32:
                        {
                            button32.Text = "";
                            button32.Visible = false;
                            break;
                        }
                    case 33:
                        {
                            button33.Text = "";
                            button33.Visible = false;
                            break;
                        }
                    case 34:
                        {
                            button34.Text = "";
                            button34.Visible = false;
                            break;
                        }
                    case 35:
                        {
                            button35.Text = "";
                            button35.Visible = false;
                            break;
                        }
                    case 36:
                        {
                            button36.Text = "";
                            button36.Visible = false;
                            break;
                        }
                    case 37:
                        {
                            button37.Text = "";
                            button37.Visible = false;
                            break;
                        }
                    case 38:
                        {
                            button38.Text = "";
                            button38.Visible = false;
                            break;
                        }
                    case 39:
                        {
                            button39.Text = "";
                            button39.Visible = false;
                            break;
                        }
                    case 40:
                        {
                            button40.Text = "";
                            button40.Visible = false;
                            break;
                        }
                }

            }
        }

        bool check_vis_false_bt()
        {
            for (int i = 1; i < 41; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            if (button1.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 2:
                        {
                            if (button2.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 3:
                        {
                            if (button3.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 4:
                        {
                            if (button4.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 5:
                        {
                            if (button5.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 6:
                        {
                            if (button6.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 7:
                        {
                            if (button7.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 8:
                        {
                            if (button8.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 9:
                        {
                            if (button9.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 10:
                        {
                            if (button10.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 11:
                        {
                            if (button11.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 12:
                        {
                            if (button12.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 13:
                        {
                            if (button13.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 14:
                        {
                            if (button14.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 15:
                        {
                            if (button15.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 16:
                        {
                            if (button16.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 17:
                        {
                            if (button17.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 18:
                        {
                            if (button18.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 19:
                        {
                            if (button19.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 20:
                        {
                            if (button20.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 21:
                        {
                            if (button21.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 22:
                        {
                            if (button22.Visible != false)
                            {
                                return false;
                            };
                            break;
                        }
                    case 23:
                        {
                            if (button23.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 24:
                        {
                            if (button24.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 25:
                        {
                            if (button25.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 26:
                        {
                            if (button26.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 27:
                        {
                            if (button27.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 28:
                        {
                            if (button28.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 29:
                        {
                            if (button29.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 30:
                        {
                            if (button30.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 31:
                        {
                            if (button31.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 32:
                        {
                            if (button32.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 33:
                        {
                            if (button33.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 34:
                        {
                            if (button34.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 35:
                        {
                            if (button35.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 36:
                        {
                            if (button36.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 37:
                        {
                            if (button37.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 38:
                        {
                            if (button38.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 39:
                        {

                            if (button39.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                    case 40:
                        {
                            if (button40.Visible != false)
                            {
                                return false;
                            }; break;
                        }
                }
            }
            return true;
        }

        void black_back()
        {
            for (int i = 1; i < 41; i++)
                switch (i)
                {
                    case 1:
                        {
                            button1.BackColor = Color.Black;
                            break;
                        }
                    case 2:
                        {
                            button2.BackColor = Color.Black;
                            break;
                        }
                    case 3:
                        {
                            button3.BackColor = Color.Black;
                            break;
                        }
                    case 4:
                        {
                            button4.BackColor = Color.Black; ;
                            break;
                        }
                    case 5:
                        {
                            button5.BackColor = Color.Black;
                            break;
                        }
                    case 6:
                        {
                            button6.BackColor = Color.Black;
                            break;
                        }
                    case 7:
                        {
                            button7.BackColor = Color.Black;
                            break;
                        }
                    case 8:
                        {
                            button8.BackColor = Color.Black;
                            break;
                        }
                    case 9:
                        {
                            button9.BackColor = Color.Black;
                            break;
                        }
                    case 10:
                        {
                            button10.BackColor = Color.Black;
                            break;
                        }
                    case 11:
                        {
                            button11.BackColor = Color.Black;
                            break;
                        }
                    case 12:
                        {
                            button12.BackColor = Color.Black;
                            break;
                        }
                    case 13:
                        {
                            button13.BackColor = Color.Black;
                            break;
                        }
                    case 14:
                        {
                            button14.BackColor = Color.Black;
                            break;
                        }
                    case 15:
                        {
                            button15.BackColor = Color.Black;
                            break;
                        }
                    case 16:
                        {
                            button16.BackColor = Color.Black;
                            break;
                        }
                    case 17:
                        {
                            button17.BackColor = Color.Black;
                            break;
                        }
                    case 18:
                        {
                            button18.BackColor = Color.Black;
                            break;
                        }
                    case 19:
                        {
                            button19.BackColor = Color.Black;
                            break;
                        }
                    case 20:
                        {
                            button20.BackColor = Color.Black;
                            break;
                        }
                    case 21:
                        {
                            button21.BackColor = Color.Black;
                            break;
                        }
                    case 22:
                        {
                            button22.BackColor = Color.Black;
                            break;
                        }
                    case 23:
                        {
                            button23.BackColor = Color.Black;
                            break;
                        }
                    case 24:
                        {
                            button24.BackColor = Color.Black;
                            break;
                        }
                    case 25:
                        {
                            button25.BackColor = Color.Black;
                            break;
                        }
                    case 26:
                        {
                            button26.BackColor = Color.Black;
                            break;
                        }
                    case 27:
                        {
                            button27.BackColor = Color.Black;
                            break;
                        }
                    case 28:
                        {
                            button28.BackColor = Color.Black;
                            break;
                        }
                    case 29:
                        {
                            button29.BackColor = Color.Black;
                            break;
                        }
                    case 30:
                        {
                            button30.BackColor = Color.Black;
                            break;
                        }
                    case 31:
                        {
                            button31.BackColor = Color.Black;
                            break;
                        }
                    case 32:
                        {
                            button32.BackColor = Color.Black;
                            break;
                        }
                    case 33:
                        {
                            button33.BackColor = Color.Black;
                            break;
                        }
                    case 34:
                        {
                            button34.BackColor = Color.Black;
                            break;
                        }
                    case 35:
                        {
                            button35.BackColor = Color.Black;
                            break;
                        }
                    case 36:
                        {
                            button36.BackColor = Color.Black;
                            break;
                        }
                    case 37:
                        {
                            button37.BackColor = Color.Black;
                            break;
                        }
                    case 38:
                        {
                            button38.BackColor = Color.Black;
                            break;
                        }
                    case 39:
                        {
                            button39.BackColor = Color.Black;
                            break;
                        }
                    case 40:
                        {
                            button40.BackColor = Color.Black;
                            break;
                        }
                }
        }

        void white_back()
        {
            for (int i = 1; i < 41; i++)
                switch (i)
                {
                    case 1:
                        {
                            button1.BackColor = Color.White;
                            break;
                        }
                    case 2:
                        {
                            button2.BackColor = Color.White;
                            break;
                        }
                    case 3:
                        {
                            button3.BackColor = Color.White;
                            break;
                        }
                    case 4:
                        {
                            button4.BackColor = Color.White;
                            break;
                        }
                    case 5:
                        {
                            button5.BackColor = Color.White;
                            break;
                        }
                    case 6:
                        {
                            button6.BackColor = Color.White;
                            break;
                        }
                    case 7:
                        {
                            button7.BackColor = Color.White;
                            break;
                        }
                    case 8:
                        {
                            button8.BackColor = Color.White;
                            break;
                        }
                    case 9:
                        {
                            button9.BackColor = Color.White;
                            break;
                        }
                    case 10:
                        {
                            button10.BackColor = Color.White;
                            break;
                        }
                    case 11:
                        {
                            button11.BackColor = Color.White;
                            break;
                        }
                    case 12:
                        {
                            button12.BackColor = Color.White;
                            break;
                        }
                    case 13:
                        {
                            button13.BackColor = Color.White;
                            break;
                        }
                    case 14:
                        {
                            button14.BackColor = Color.White;
                            break;
                        }
                    case 15:
                        {
                            button15.BackColor = Color.White;
                            break;
                        }
                    case 16:
                        {
                            button16.BackColor = Color.White;
                            break;
                        }
                    case 17:
                        {
                            button17.BackColor = Color.White;
                            break;
                        }
                    case 18:
                        {
                            button18.BackColor = Color.White;
                            break;
                        }
                    case 19:
                        {
                            button19.BackColor = Color.White;
                            break;
                        }
                    case 20:
                        {
                            button20.BackColor = Color.White;
                            break;
                        }
                    case 21:
                        {
                            button21.BackColor = Color.White;
                            break;
                        }
                    case 22:
                        {
                            button22.BackColor = Color.White;
                            break;
                        }
                    case 23:
                        {
                            button23.BackColor = Color.White;
                            break;
                        }
                    case 24:
                        {
                            button24.BackColor = Color.White;
                            break;
                        }
                    case 25:
                        {
                            button25.BackColor = Color.White;
                            break;
                        }
                    case 26:
                        {
                            button26.BackColor = Color.White;
                            break;
                        }
                    case 27:
                        {
                            button27.BackColor = Color.White;
                            break;
                        }
                    case 28:
                        {
                            button28.BackColor = Color.White;
                            break;
                        }
                    case 29:
                        {
                            button29.BackColor = Color.White;
                            break;
                        }
                    case 30:
                        {
                            button30.BackColor = Color.White;
                            break;
                        }
                    case 31:
                        {
                            button31.BackColor = Color.White;
                            break;
                        }
                    case 32:
                        {
                            button32.BackColor = Color.White;
                            break;
                        }
                    case 33:
                        {
                            button33.BackColor = Color.White;
                            break;
                        }
                    case 34:
                        {
                            button34.BackColor = Color.White;
                            break;
                        }
                    case 35:
                        {
                            button35.BackColor = Color.White;
                            break;
                        }
                    case 36:
                        {
                            button36.BackColor = Color.White;
                            break;
                        }
                    case 37:
                        {
                            button37.BackColor = Color.White;
                            break;
                        }
                    case 38:
                        {
                            button38.BackColor = Color.White;
                            break;
                        }
                    case 39:
                        {
                            button39.BackColor = Color.White;
                            break;
                        }
                    case 40:
                        {
                            button40.BackColor = Color.White;
                            break;
                        }
                }
        }

        void vis_new_lv()
        {
            if (count > count_max)
            {
                //label2.Text = count.ToString();
                count_max = count;
            }
            count_click = 0;
            vis_false_bt();
            white_back();
            Random rnd = new Random();
            Random chk = new Random();
            white_back();
            do
            {
                int rand = rnd.Next(1, 41);
                bool placed = false;
                do
                {
                    if (chk.Next(1, 20) > 15)
                    {
                        placed = true;
                        switch (rand)
                        {
                            case 1:
                                {
                                    if (button1.Visible != true)
                                    {
                                        button1.Text = count_nums.ToString();
                                        button1.Visible = true;
                                        count_nums += 1;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (button2.Visible != true)
                                    {
                                        button2.Text = count_nums.ToString();
                                        button2.Visible = true;
                                        count_nums += 1;
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    if (button3.Visible != true)
                                    {
                                        button3.Text = count_nums.ToString();
                                        button3.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    if (button4.Visible != true)
                                    {
                                        button4.Text = count_nums.ToString();
                                        button4.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    if (button5.Visible != true)
                                    {
                                        button5.Text = count_nums.ToString();
                                        button5.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 6:
                                {
                                    if (button6.Visible != true)
                                    {
                                        button6.Text = count_nums.ToString();
                                        button6.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 7:
                                {
                                    if (button7.Visible != true)
                                    {
                                        button7.Text = count_nums.ToString();
                                        button7.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 8:
                                {
                                    if (button8.Visible != true)
                                    {
                                        button8.Text = count_nums.ToString();
                                        button8.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 9:
                                {
                                    if (button9.Visible != true)
                                    {
                                        button9.Text = count_nums.ToString();
                                        button9.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 10:
                                {
                                    if (button10.Visible != true)
                                    {
                                        button10.Text = count_nums.ToString();
                                        button10.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 11:
                                {
                                    if (button11.Visible != true)
                                    {
                                        button11.Text = count_nums.ToString();
                                        button11.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 12:
                                {
                                    if (button12.Visible != true)
                                    {
                                        button12.Text = count_nums.ToString();
                                        button12.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 13:
                                {
                                    if (button13.Visible != true)
                                    {
                                        button13.Text = count_nums.ToString();
                                        button13.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 14:
                                {
                                    if (button14.Visible != true)
                                    {
                                        button14.Text = count_nums.ToString();
                                        button14.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 15:
                                {
                                    if (button15.Visible != true)
                                    {
                                        button15.Text = count_nums.ToString();
                                        button15.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 16:
                                {
                                    if (button16.Visible != true)
                                    {
                                        button16.Text = count_nums.ToString();
                                        button16.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 17:
                                {
                                    if (button17.Visible != true)
                                    {
                                        button17.Text = count_nums.ToString();
                                        button17.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 18:
                                {
                                    if (button18.Visible != true)
                                    {
                                        button18.Text = count_nums.ToString();
                                        button18.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 19:
                                {
                                    if (button19.Visible != true)
                                    {
                                        button19.Text = count_nums.ToString();
                                        button19.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 20:
                                {
                                    if (button20.Visible != true)
                                    {
                                        button20.Text = count_nums.ToString();
                                        button20.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 21:
                                {
                                    if (button21.Visible != true)
                                    {
                                        button21.Text = count_nums.ToString();
                                        button21.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 22:
                                {
                                    if (button22.Visible != true)
                                    {
                                        button22.Text = count_nums.ToString();
                                        button22.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 23:
                                {
                                    if (button23.Visible != true)
                                    {
                                        button23.Text = count_nums.ToString();
                                        button23.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 24:
                                {
                                    if (button24.Visible != true)
                                    {
                                        button24.Text = count_nums.ToString();
                                        button24.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 25:
                                {
                                    if (button25.Visible != true)
                                    {
                                        button25.Text = count_nums.ToString();
                                        button25.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 26:
                                {
                                    if (button26.Visible != true)
                                    {
                                        button26.Text = count_nums.ToString();
                                        button26.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 27:
                                {
                                    if (button27.Visible != true)
                                    {
                                        button27.Text = count_nums.ToString();
                                        button27.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 28:
                                {
                                    if (button28.Visible != true)
                                    {
                                        button28.Text = count_nums.ToString();
                                        button28.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 29:
                                {
                                    if (button29.Visible != true)
                                    {
                                        button29.Text = count_nums.ToString();
                                        button29.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 30:
                                {
                                    if (button30.Visible != true)
                                    {
                                        button30.Text = count_nums.ToString();
                                        button30.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 31:
                                {
                                    if (button31.Visible != true)
                                    {
                                        button31.Text = count_nums.ToString();
                                        button31.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 32:
                                {
                                    if (button32.Visible != true)
                                    {
                                        button32.Text = count_nums.ToString();
                                        button32.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 33:
                                {
                                    if (button33.Visible != true)
                                    {
                                        button33.Text = count_nums.ToString();
                                        button33.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 34:
                                {
                                    if (button34.Visible != true)
                                    {
                                        button34.Text = count_nums.ToString();
                                        button34.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 35:
                                {
                                    if (button35.Visible != true)
                                    {
                                        button35.Text = count_nums.ToString();
                                        button35.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 36:
                                {
                                    if (button36.Visible != true)
                                    {
                                        button36.Text = count_nums.ToString();
                                        button36.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 37:
                                {
                                    if (button37.Visible != true)
                                    {
                                        button37.Text = count_nums.ToString();
                                        button37.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 38:
                                {
                                    if (button38.Visible != true)
                                    {
                                        button38.Text = count_nums.ToString();
                                        button38.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 39:
                                {
                                    if (button39.Visible != true)
                                    {
                                        button39.Text = count_nums.ToString();
                                        button39.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                            case 40:
                                {
                                    if (button40.Visible != true)
                                    {
                                        button40.Text = count_nums.ToString();
                                        button40.Visible = true; count_nums += 1;
                                    }
                                    break;
                                }
                        }
                    }
                } while (placed != true);
                //}
            } while (count_nums < count + 1);
            count += 1;
            count_nums = 1;
        }

        void end_game()
        {
            label2.Text = $"Игра окончана! Ваш результат {count_max}.";
            label2.Visible = true;
            bt_start.Visible = true;
        }

        // Попытка создать функцию провалилась крахом, принято решение использовать switch
        //public void setName(int i, int n)
        //{
        //    var buttonsOnForm = Controls.OfType<Button>();
        //    foreach (var btn in buttonsOnForm)
        //    {
        //        if (btn.Name == $"button{n}")
        //        {
        //            btn.Text = i.ToString();
        //            btn.Visible = true;
        //        }
        //    }
        //}


        private void bt_start_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            vis_false_bt();
        }

        private void button_num_Click(object sender, EventArgs e)
        {
            count_click += 1;
            //label2.Text = count_click.ToString();
            if (count_click == 1)
            {
                black_back();
            }
            if ((sender as Button).Text == count_click.ToString()) (sender as Button).Visible = false;
            else
            {
                count_click = 0;
                count_miss += 1;
                if (count != 1) count -= 1;
                label1.Text = $"Ошибок: {count_miss} из 3";
                if (count_miss == 3)
                {
                    end_game();
                    vis_false_bt();
                }
                else vis_new_lv();
            }
            if ((sender as Button).Text == (count - 1).ToString()) vis_new_lv();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void bt_start_Click_2(object sender, EventArgs e)
        {
            count = 4;
            count_nums = 1;
            count_click = 0;
            count_miss = 0;
            bt_start.Visible = false;
            white_back();
            vis_new_lv();
        }

        private void bt_clear_Click_1(object sender, EventArgs e)
        {
            count = 4;
            vis_new_lv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button31_Click_2(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            button_num_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}