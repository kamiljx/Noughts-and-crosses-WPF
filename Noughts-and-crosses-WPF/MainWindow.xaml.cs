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
            //4 k
            if (t16 == "O" && t17 == "O" && t18 == "O" && t19 == "O" && t20 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t16 == "X" && t17 == "X" && t18 == "X" && t19 == "X" && t20 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }
            //5 k
            if (t21 == "O" && t22 == "O" && t23 == "O" && t24 == "O" && t25 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t21 == "X" && t22 == "X" && t23 == "X" && t24 == "X" && t25 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }
            // POZIOM

            // 1 w
            if (t1 == "O" && t10 == "O" && t11 == "O" && t16 == "O" && t21 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t1 == "X" && t10 == "X" && t11 == "X" && t16 == "X" && t21 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }

            // 2 w
            if (t2 == "O" && t9 == "O" && t12 == "O" && t17 == "O" && t22 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t2 == "X" && t9 == "X" && t12 == "X" && t17 == "X" && t22 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }
            // 3 w
            if (t3 == "O" && t8 == "O" && t13 == "O" && t18 == "O" && t23 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t3 == "X" && t8 == "X" && t13 == "X" && t18 == "X" && t23 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }

            // 4 w
            if (t4 == "O" && t7 == "O" && t14 == "O" && t19 == "O" && t24 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t4 == "X" && t7 == "X" && t14 == "X" && t19 == "X" && t24 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }

            // 5 w
            if (t5 == "O" && t6 == "O" && t15 == "O" && t20 == "O" && t25 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t5 == "X" && t6 == "X" && t15 == "X" && t20 == "X" && t25 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }

            // SKOS

            // 1 S
            if (t1 == "O" && t9 == "O" && t13 == "O" && t19 == "O" && t25 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t1 == "X" && t9 == "X" && t13 == "X" && t19 == "X" && t25 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }
            // 2 w
            if (t5 == "O" && t7 == "O" && t13 == "O" && t17 == "O" && t21 == "O")
            {
                label1.Text = "Wygrał gracz O";

            }
            if (t5 == "X" && t7 == "X" && t13 == "X" && t17 == "X" && t21 == "X")
            {
                label1.Text = "Wygrał gracz X";

            }
            
            //niedokończona gra
            else
            {

            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
        }
    }
}
