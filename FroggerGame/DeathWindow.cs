using FroggerGame.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FroggerGame
{
    public partial class DeathWindow : Form
    {
        public  DialogResult answer;
        private string name;
        private  DIFICULTY di;
        private int points;
        public DeathWindow(string name,DIFICULTY di,int points)
        {
            this.di = di;
            this.name = name;
            this.points = points;
            InitializeComponent();
            Debug.WriteLine("1");
            create();
            loadResults();
        }
        private void create()
        {
            string folder= Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specific = Path.Combine(folder, "APP_DATA");
            Directory.CreateDirectory(specific);
            if (!File.Exists(specific + @"\easy.txt"))
            {
               
               FileStream sf= File.Create(specific + @"\easy.txt");
               sf.Close();
            }
            if (!File.Exists(specific + @"\medium.txt"))
            {
                FileStream sf = File.Create(specific + @"\medium.txt");
                sf.Close();
            }
            if (!File.Exists(specific + @"\hard.txt"))
            {
                FileStream sf = File.Create(specific + @"\hard.txt");
                sf.Close();
            }
        }
        private void backtomenu(object sender, EventArgs e)
        {
            answer = DialogResult.No;
            Close();
        }

        private void newgame(object sender, EventArgs e)
        {
            answer = DialogResult.Yes;
            Close();
        }
        private void loadResults()
        {
            try
            {
                List<string> data = new List<string>();
                string path= Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string header = "Sorry you didn't make it.\r\nTry again, "+name;
                string person = name + " " + points;
                string tabelData = "";
                string title = "";
                PersonParser ps;
                Debug.WriteLine("2");
                switch (di)
                {
                    case DIFICULTY.TOURNAMENT_EASY:
                        title = "Highscore for easy mode: ";
                        path += @"\APP_DATA\easy.txt";
                        break;
                    case DIFICULTY.TOURNAMENT_MEDIUM:
                        title = "Highscore for medium mode: ";
                        path += @"\APP_DATA\medium.txt";
                        break;
                    case DIFICULTY.TOURNAMENT_HARD:
                        title = "Highscore for hard mode: ";
                        path += @"\APP_DATA\hard.txt";
                        break;
                    case DIFICULTY.NOVICE:
                        title = "Highscore for hard mode: ";
                        path += @"\APP_DATA\hard.txt";
                        break;
                }
                data = File.ReadAllLines(path).ToList();
                if (di!=DIFICULTY.NOVICE)
                ps = new PersonParser(data, person);
                else ps = new PersonParser(data, null);
                tabelData = ps.ToString();
                data = ps.forData();
                if (di == DIFICULTY.NOVICE)
                {
                    header = "Doing great, " + name + "\r\nTry the Tournament.";
                }
                else
                {
                    Debug.WriteLine("3");
                    if (data != null)
                    {
                        File.WriteAllLines(path, data);
                    }
                    }
                if (ps.flag) header = "Congradulations, " + name + ".\r\nYou are in the Top 5.";
                tabel.Text = tabelData;
                message.Text = header;
                titleLBL.Text = title;
            }
            catch(Exception e)
            {
                message.Text = name;
                tabel.Text = "AN ERROR HAS OCCURED";
                Debug.WriteLine(e);
            }
        }
    }
}
