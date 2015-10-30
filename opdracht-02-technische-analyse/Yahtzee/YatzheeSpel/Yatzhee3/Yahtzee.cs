using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yatzhee3
{
    public partial class Yahtzee : Form
    {
        public Yahtzee()
        {
            InitializeComponent();
        }

        int aantalTeerlingen = 5;
        int aantalSoortenScores = 1;
        List<TeerlingController> teerlingen = new List<TeerlingController>();
        ScoreboardController scoreboard = new ScoreboardController();
        
        

        private void Yahtzee_Load(object sender, EventArgs e)
        {              
            ScoreboardController tijdelijkeScore = new ScoreboardController();
            scoreboard = tijdelijkeScore;
            

            for (int i = 0; i < aantalTeerlingen; i++)  //maakt 5 teerlingen aan
            {
                
                TeerlingController Teerling = new TeerlingController();
                teerlingen.Add(Teerling);
            }

            
            for (int i = 0; i < aantalTeerlingen; i++) //zet de teerlingen op hun plaats
            {
                TeerlingView teerlingView = teerlingen[i].getView();
                int horizontalPosition;
                horizontalPosition = i * teerlingView.Width;
                
                teerlingView.Location = new System.Drawing.Point(horizontalPosition, 0);

                Controls.Add(teerlingView);
            }

            
            ScoreboardView scoreboardView = scoreboard.getView();   //zet het "aantal worpen" op hun plaats
            scoreboardView.Location = new System.Drawing.Point(200, 160);
            Controls.Add(scoreboardView);
            
        }


        private void button1_Click(object sender, EventArgs e) //Gooi button handler
        {
            if (scoreboard.model.Score < 3)
            {
                for (int i = 0; i < aantalTeerlingen; i++)
                {
                    if (!teerlingen[i].model.ColorIsRed)
                    {
                        teerlingen[i].Werp();

                        teerlingen[i].UpdateUI();
                    }
                }
            
                scoreboard.UpdateAantalWorpen();
            }
            

        }
    }
}
