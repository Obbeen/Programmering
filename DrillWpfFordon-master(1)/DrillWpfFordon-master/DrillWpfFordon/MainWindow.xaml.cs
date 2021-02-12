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

namespace DrillWpfFordon
{ 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // lista med alla fordon
        private List<Player> players = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int abc = Convert.ToInt32(NumberOfGoals.Text);
            // skriv kod här för att spara fordon i lista
            players.Add(new Player(FootBallPlayer.Text, abc));
            Players.Text = "";
            foreach (Player player in players)
            {
                Players.Text += Environment.NewLine + "antal mål: " + player.Goals + Environment.NewLine + "spelare: " +  player.Ballplayer + Environment.NewLine;
            }

        }
        
    }
}
