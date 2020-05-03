using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoogleTap
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string DashDots = "";

        public MainPage()
        {
            InitializeComponent();
        }
        void Btn_Dash(object sender, System.EventArgs e)
        {
            DashDots += "-";
            DotsAndDashsLabel.Text = DashDots;
        }
        void Btn_Dot(object sender, System.EventArgs e)
        {
            DashDots += ".";
            DotsAndDashsLabel.Text = DashDots;
        }
        void Btn_Space(object sender, System.EventArgs e)
        {

            string result = "?";
            for (int i = 0; i < Morse.codes.Length; i++)
            {
                if (Morse.codes[i].Equals(DashDots))
                {
                    result = Morse.letters[i];
                    break;
                }
            }
            FullMessageLabel.Text += result;
            DashDots = "";
            DotsAndDashsLabel.Text = DashDots;
        }
    }
    public class Morse
    {
        public static string[] codes = new string[] { ".-", "-...", "-.-.", "-..",
            ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "" };
        public static string[] letters = new string[] { "A", "B", "C", "D", "E", "F",
            "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "R", "U", "V",
            "W", "X", "Y", "Z", " "};
    }
}
