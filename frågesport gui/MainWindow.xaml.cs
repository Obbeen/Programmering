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
using System.IO;
using Path = System.IO.Path;

namespace frågesport_gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int CurrentQ = 0;
        List<questioncards> fragor = new List<questioncards>();
        questioncards q;
        private string fileName = "frågor.txt";
        private string pathAndFileName;

        public MainWindow()

        {

        InitializeComponent();

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathAndFileName = Path.Combine(docPath, fileName);

            fragor.Add(new questioncards("Vad heter Norges hvudstad?", "Oslo"));
            fragor.Add(new questioncards("Vad heter Danmarks huvudstad?", "Köpenhamn"));
            fragor.Add(new questioncards("vad heter Finlands huvudstad?", "Helsingfors"));
            q = fragor[CurrentQ]; 
            textblock2.Text = q.question;

        }
 

        private void buttonrätta_Click(object sender, RoutedEventArgs e)
        {

            String uans = textboxsvar.Text;
            if (uans.ToLower() == fragor[CurrentQ].answer.ToLower())
            {
                textblockfeedback.Text = "Rätt";
            }
            else
            {
                textblockfeedback.Text = "Fel";
            }
    
        }

        private void buttonnästa_Click(object sender, RoutedEventArgs e)
        {
            CurrentQ = CurrentQ + 1;
            textblock2.Text = fragor[CurrentQ].question;
            textboxsvar.Text = "";
            textblockfeedback.Text = "";
        }

        private void ReadFile()
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(pathAndFileName))

                {
                    string q;
                    string ans;
                    
                    q = sr.ReadLine();
                    ans = sr.ReadLine();
                    while (q != null)
                    {
                        fragor.Add(new questioncards(q, ans ));

                        q = sr.ReadLine();
                        ans = sr.ReadLine();

                    }
                }
            }
            catch (IOException e)
            {
                textblock2.Text = "The file could not be read:" + e.Message;
            }

        }
       }
}
