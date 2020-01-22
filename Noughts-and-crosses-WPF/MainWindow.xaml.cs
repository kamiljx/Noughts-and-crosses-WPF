using System;
using System.Windows;

namespace Noughts_and_crosses_WPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        /// <summary>
        /// sprawdzanie wygranej, przypisanie zawartości przycisków do stringów t1-t25 i porównywanie ich ze sobą, 5 takich samych obok siebie =>
        /// lub na skos i wygrywa jeden gracz
        /// </summary>
        /// <returns>Pokazuje wynik gry, napis kto wygrał</returns>
        string sprawdz()
        {

            ///zawartość przycisków przypisuje to stringów t1-t25
            string t1 = btn1.Content.ToString();
            string t2 = btn2.Content.ToString();
            string t3 = btn3.Content.ToString();
            string t4 = btn4.Content.ToString();
            string t5 = btn5.Content.ToString();
            string t6 = btn6.Content.ToString();
            string t7 = btn7.Content.ToString();
            string t8 = btn8.Content.ToString();
            string t9 = btn9.Content.ToString();
            string t10 = btn10.Content.ToString();
            string t11 = btn11.Content.ToString();
            string t12 = btn12.Content.ToString();
            string t13 = btn13.Content.ToString();
            string t14 = btn14.Content.ToString();
            string t15 = btn15.Content.ToString();
            string t16 = btn16.Content.ToString();
            string t17 = btn17.Content.ToString();
            string t18 = btn18.Content.ToString();
            string t19 = btn19.Content.ToString();
            string t20 = btn20.Content.ToString();
            string t21 = btn21.Content.ToString();
            string t22 = btn22.Content.ToString();
            string t23 = btn23.Content.ToString();
            string t24 = btn24.Content.ToString();
            string t25 = btn25.Content.ToString();

            //PION

            ///poniżej program sprawdza czy
            

            //1 k
            if (t1 == "O" && t6 == "O" && t11 == "O" && t16 == "O" && t21 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t1 == "X" && t6 == "X" && t11 == "X" && t16 == "X" && t21 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            //2 k
            if (t2 == "O" && t7 == "O" && t12 == "O" && t17 == "O" && t22 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t2 == "X" && t7 == "X" && t12 == "X" && t17 == "X" && t22 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            //3 k
            if (t3 == "O" && t8 == "O" && t13 == "O" && t18 == "O" && t23 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t3 == "X" && t8 == "X" && t13 == "X" && t18 == "X" && t23 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            //4 k
            if (t4 == "O" && t9 == "O" && t14 == "O" && t19 == "O" && t24 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t4 == "X" && t9 == "X" && t14 == "X" && t19 == "X" && t24 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            //5 k
            if (t5 == "O" && t10 == "O" && t15 == "O" && t20 == "O" && t25 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t5 == "X" && t10 == "X" && t15 == "X" && t20 == "X" && t25 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            // POZIOM

            // 1 w
            if (t1 == "O" && t2 == "O" && t3 == "O" && t4 == "O" && t5 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t1 == "X" && t2 == "X" && t3 == "X" && t4 == "X" && t5 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            // 2 w
            if (t6 == "O" && t7 == "O" && t8 == "O" && t9 == "O" && t10 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t6 == "X" && t7 == "X" && t8 == "X" && t9 == "X" && t10 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            // 3 w
            if (t11 == "O" && t12 == "O" && t13 == "O" && t14 == "O" && t15 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t11 == "X" && t12 == "X" && t13 == "X" && t14 == "X" && t15 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            // 4 w
            if (t16 == "O" && t17 == "O" && t18 == "O" && t19 == "O" && t20 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t16 == "X" && t17 == "X" && t18 == "X" && t19 == "X" && t20 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            // 5 w
            if (t21 == "O" && t22 == "O" && t23 == "O" && t24 == "O" && t25 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t21 == "X" && t22 == "X" && t23 == "X" && t24 == "X" && t25 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            // SKOS

            // 1 S
            if (t1 == "O" && t7 == "O" && t13 == "O" && t19 == "O" && t25 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t1 == "X" && t7 == "X" && t13 == "X" && t19 == "X" && t25 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            // 2 w
            if (t5 == "O" && t9 == "O" && t13 == "O" && t17 == "O" && t21 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t5 == "X" && t9 == "X" && t13 == "X" && t17 == "X" && t21 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            //niedokończona gra
            else
            {

            }
            return "";
        }
        /// <summary>
        /// resetuje gre
        /// </summary>
        /// <param name="sender">wciśnięty przycisk</param>
        /// <param name="e">zdarzenie po wciśnięciu</param>
        private void reset_Click_1(object sender, EventArgs e)
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn13.IsEnabled = true;
            btn14.IsEnabled = true;
            btn15.IsEnabled = true;
            btn16.IsEnabled = true;
            btn17.IsEnabled = true;
            btn18.IsEnabled = true;
            btn19.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn23.IsEnabled = true;
            btn24.IsEnabled = true;
            btn25.IsEnabled = true;
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
            btn10.Content = "";
            btn11.Content = "";
            btn12.Content = "";
            btn13.Content = "";
            btn14.Content = "";
            btn15.Content = "";
            btn16.Content = "";
            btn17.Content = "";
            btn18.Content = "";
            btn19.Content = "";
            btn20.Content = "";
            btn21.Content = "";
            btn22.Content = "";
            btn23.Content = "";
            btn24.Content = "";
            btn25.Content = "";
            if (player.Content.ToString() == "Wygrał gracz O")
            {
                player.Content = "Kolej gracza: X";
            }
            else if (player.Content.ToString() == "Wygrał gracz X")
            {
                player.Content = "Kolej gracza: O";
            }
        }
        public void btn1_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn1.Content = "X";
                player.Content = "Kolej gracza: O";
                btn1.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn1.Content = "O";
                player.Content = "Kolej gracza: X";
                btn1.IsEnabled = false;
            }
            sprawdz();
        }


        public void btn2_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn2.Content = "X";
                player.Content = "Kolej gracza: O";
                btn2.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn2.Content = "O";
                player.Content = "Kolej gracza: X";
                btn2.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn3_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn3.Content = "X";
                player.Content = "Kolej gracza: O";
                btn3.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn3.Content = "O";
                player.Content = "Kolej gracza: X";
                btn3.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn4_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn4.Content = "X";
                player.Content = "Kolej gracza: O";
                btn4.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn4.Content = "O";
                player.Content = "Kolej gracza: X";
                btn4.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn5_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn5.Content = "X";
                player.Content = "Kolej gracza: O";
                btn5.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn5.Content = "O";
                player.Content = "Kolej gracza: X";
                btn5.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn10_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn10.Content = "X";
                player.Content = "Kolej gracza: O";
                btn10.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn10.Content = "O";
                player.Content = "Kolej gracza: X";
                btn10.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn9_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn9.Content = "X";
                player.Content = "Kolej gracza: O";
                btn9.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn9.Content = "O";
                player.Content = "Kolej gracza: X";
                btn9.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn8_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn8.Content = "X";
                player.Content = "Kolej gracza: O";
                btn8.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn8.Content = "O";
                player.Content = "Kolej gracza: X";
                btn8.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn7_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn7.Content = "X";
                player.Content = "Kolej gracza: O";
                btn7.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn7.Content = "O";
                player.Content = "Kolej gracza: X";
                btn7.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn6_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn6.Content = "X";
                player.Content = "Kolej gracza: O";
                btn6.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn6.Content = "O";
                player.Content = "Kolej gracza: X";
                btn6.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn11_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn11.Content = "X";
                player.Content = "Kolej gracza: O";
                btn11.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn11.Content = "O";
                player.Content = "Kolej gracza: X";
                btn11.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn12_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn12.Content = "X";
                player.Content = "Kolej gracza: O";
                btn12.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn12.Content = "O";
                player.Content = "Kolej gracza: X";
                btn12.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn13_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn13.Content = "X";
                player.Content = "Kolej gracza: O";
                btn13.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn13.Content = "O";
                player.Content = "Kolej gracza: X";
                btn13.IsEnabled = false;
            }
            sprawdz();

        }

        public void btn14_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn14.Content = "X";
                player.Content = "Kolej gracza: O";
                btn14.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn14.Content = "O";
                player.Content = "Kolej gracza: X";
                btn14.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn15_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn15.Content = "X";
                player.Content = "Kolej gracza: O";
                btn15.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn15.Content = "O";
                player.Content = "Kolej gracza: X";
                btn15.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn16_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn16.Content = "X";
                player.Content = "Kolej gracza: O";
                btn16.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn16.Content = "O";
                player.Content = "Kolej gracza: X";
                btn16.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn17_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn17.Content = "X";
                player.Content = "Kolej gracza: O";
                btn17.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn17.Content = "O";
                player.Content = "Kolej gracza: X";
                btn17.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn18_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn18.Content = "X";
                player.Content = "Kolej gracza: O";
                btn18.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn18.Content = "O";
                player.Content = "Kolej gracza: X";
                btn18.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn19_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn19.Content = "X";
                player.Content = "Kolej gracza: O";
                btn19.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn19.Content = "O";
                player.Content = "Kolej gracza: X";
                btn19.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn20_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn20.Content = "X";
                player.Content = "Kolej gracza: O";
                btn20.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn20.Content = "O";
                player.Content = "Kolej gracza: X";
                btn20.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn21_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn21.Content = "X";
                player.Content = "Kolej gracza: O";
                btn21.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn21.Content = "O";
                player.Content = "Kolej gracza: X";
                btn21.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn22_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn22.Content = "X";
                player.Content = "Kolej gracza: O";
                btn22.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn22.Content = "O";
                player.Content = "Kolej gracza: X";
                btn22.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn23_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn23.Content = "X";
                player.Content = "Kolej gracza: O";
                btn23.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn23.Content = "O";
                player.Content = "Kolej gracza: X";
                btn23.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn24_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn24.Content = "X";
                player.Content = "Kolej gracza: O";
                btn24.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn24.Content = "O";
                player.Content = "Kolej gracza: X";
                btn24.IsEnabled = false;
            }
            sprawdz();
        }

        public void btn25_Click(object sender, EventArgs e)
        {
            if (player.Content.ToString() == "Kolej gracza: X")
            {
                btn25.Content = "X";
                player.Content = "Kolej gracza: O";
                btn25.IsEnabled = false;
            }
            else if (player.Content.ToString() == "Kolej gracza: O")
            {
                btn25.Content = "O";
                player.Content = "Kolej gracza: X";
                btn25.IsEnabled = false;
            }
            sprawdz();
        }
    }
}
