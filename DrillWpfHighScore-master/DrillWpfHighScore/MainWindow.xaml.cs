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

namespace DrillWpfHighScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // lista med poäng
        private List<Result> scores = new List<Result>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveScore_Click(object sender, RoutedEventArgs e)
        {
            scores.Add(new Result(PlayerName.Text, Convert.ToInt32(Score.Text)));
            // spara resultat i listan scores

            // sortera listan
            scores.Sort();

            for (int i = 0; i < scores.Count(); i++)
            {
                HighScores.Text += Environment.NewLine + scores[i].Name + " " + scores[i].Score + Environment.NewLine;
                if (i > 4)
                {
                    return;
                }
            }

            // skriv ut top 5 som 
            // 1. Ada 1060
            // 2. Beda 980
            // ...
            // 5. ...

        }
    }
}
