﻿using System;
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
        }

        string sprawdz()
        {
            string t1 = button1.Text;
            string t2 = button2.Text;
            string t3 = button3.Text;
            string t4 = button4.Text;
            string t5 = button5.Text;
            string t6 = button6.Text;
            string t7 = button7.Text;
            string t8 = button8.Text;
            string t9 = button9.Text;
            string t10 = button10.Text;
            string t11 = button11.Text;
            string t12 = button12.Text;
            string t13 = button13.Text;
            string t14 = button14.Text;
            string t15 = button15.Text;
            string t16 = button16.Text;
            string t17 = button17.Text;
            string t18 = button18.Text;
            string t19 = button19.Text;
            string t20 = button20.Text;
            string t21 = button21.Text;
            string t22 = button22.Text;
            string t23 = button23.Text;
            string t24 = button24.Text;
            string t25 = button25.Text;
            
            //PION
            
            //1 k
            if (t1 == "O" && t2 == "O" && t3 == "O" && t4 == "O" && t5 == "O")
            {
                label1.Text = "Wygrał gracz O";
                
            }
            if (t1 == "X" && t2 == "X" && t3 == "X" && t4 == "X" && t5 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }

            //2 k
            if (t6 == "O" && t7 == "O" && t8 == "O" && t9 == "O" && t10 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t6 == "X" && t7 == "X" && t8 == "X" && t9 == "X" && t10 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }

            //3 k
            if (t11 == "O" && t12 == "O" && t13 == "O" && t14 == "O" && t15 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t11 == "X" && t12 == "X" && t13 == "X" && t14 == "X" && t15 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }
        }
    }
}
