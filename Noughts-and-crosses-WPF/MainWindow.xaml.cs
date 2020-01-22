using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            
            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                // do stuff
            }
            
        }

        string sprawdz()
        {
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

            //1 k
            if (t1 == "O" && t2 == "O" && t3 == "O" && t4 == "O" && t5 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t1 == "X" && t2 == "X" && t3 == "X" && t4 == "X" && t5 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            //2 k
            if (t6 == "O" && t7 == "O" && t8 == "O" && t9 == "O" && t10 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t6 == "X" && t7 == "X" && t8 == "X" && t9 == "X" && t10 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            //3 k
            if (t11 == "O" && t12 == "O" && t13 == "O" && t14 == "O" && t15 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t11 == "X" && t12 == "X" && t13 == "X" && t14 == "X" && t15 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            //4 k
            if (t16 == "O" && t17 == "O" && t18 == "O" && t19 == "O" && t20 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t16 == "X" && t17 == "X" && t18 == "X" && t19 == "X" && t20 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            //5 k
            if (t21 == "O" && t22 == "O" && t23 == "O" && t24 == "O" && t25 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t21 == "X" && t22 == "X" && t23 == "X" && t24 == "X" && t25 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            // POZIOM

            // 1 w
            if (t1 == "O" && t10 == "O" && t11 == "O" && t16 == "O" && t21 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t1 == "X" && t10 == "X" && t11 == "X" && t16 == "X" && t21 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            // 2 w
            if (t2 == "O" && t9 == "O" && t12 == "O" && t17 == "O" && t22 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t2 == "X" && t9 == "X" && t12 == "X" && t17 == "X" && t22 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            // 3 w
            if (t3 == "O" && t8 == "O" && t13 == "O" && t18 == "O" && t23 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t3 == "X" && t8 == "X" && t13 == "X" && t18 == "X" && t23 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            // 4 w
            if (t4 == "O" && t7 == "O" && t14 == "O" && t19 == "O" && t24 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t4 == "X" && t7 == "X" && t14 == "X" && t19 == "X" && t24 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            // 5 w
            if (t5 == "O" && t6 == "O" && t15 == "O" && t20 == "O" && t25 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t5 == "X" && t6 == "X" && t15 == "X" && t20 == "X" && t25 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            // SKOS

            // 1 S
            if (t1 == "O" && t9 == "O" && t13 == "O" && t19 == "O" && t25 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t1 == "X" && t9 == "X" && t13 == "X" && t19 == "X" && t25 == "X")
            {
                player.Content = "Wygrał gracz X";

            }
            // 2 w
            if (t5 == "O" && t7 == "O" && t13 == "O" && t17 == "O" && t21 == "O")
            {
                player.Content = "Wygrał gracz O";

            }
            if (t5 == "X" && t7 == "X" && t13 == "X" && t17 == "X" && t21 == "X")
            {
                player.Content = "Wygrał gracz X";

            }

            //niedokończona gra
            else
            {

            }
            return "";
        }
    }
}
