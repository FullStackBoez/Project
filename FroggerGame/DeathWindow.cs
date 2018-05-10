using FroggerGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            create();
            loadResults();
        }
        private void create()
        {
            string folder= Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specific = Path.Combine(folder, "APP_DATA");
            Directory.CreateDirectory(specific);
            if (!File.Exists(specific + @"/easy.txt"))
            {
                File.Create(specific + @"/easy.txt");
            }
            if (!File.Exists(specific + @"/medium.txt"))
            {
                File.Create(specific + @"/medium.txt");
            }
            if (!File.Exists(specific + @"/hard.txt"))
            {
                File.Create(specific + @"/hard.txt");
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
                string s = "Sorry you didn't make it.\r\nTry again, "+name;
                string person = name + " " + points;
                string s1 = "";
                PersonParser ps;
                switch (di)
                {
                    case DIFICULTY.TOURNAMENT_EASY:
                        path += @"\APP_DATA\easy.txt";
                        data = File.ReadAllLines(path).ToList();
                        break;
                    case DIFICULTY.TOURNAMENT_MEDIUM:
                        path += @"\APP_DATA\medium.txt";
                        data = File.ReadAllLines(path).ToList();
                        break;
                    case DIFICULTY.TOURNAMENT_HARD:
                        path += @"\APP_DATA\hard.txt";
                        data = File.ReadAllLines(path).ToList();
                        break;
                    case DIFICULTY.NOVICE:
                        path += @"\APP_DATA\hard.txt";
                        data = File.ReadAllLines(path).ToList();
                        break;
                }
                if(di!=DIFICULTY.NOVICE)
                ps = new PersonParser(data, person);
                else ps = new PersonParser(data, null);
                s1 = ps.ToString();
                data = ps.forData();
                if (di == DIFICULTY.NOVICE)
                {
                    s = "Doing great, " + name + "\r\nTry the Tournament.";
                }
                else
                {
                    if(data!=null)
                    File.WriteAllLines(path, data);
                }
                if (ps.flag) s = "Congradulations, " + name + ".\r\nYou are in the Top 5.";

                Debug.WriteLine(path);
                tabel.Text = s1;
                message.Text = s;
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
