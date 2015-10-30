using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
    public class ScoreboardController
    {
        ScoreboardView view;
        public ScoreboardModel model;

        public ScoreboardView getView()
        {
            return view;

        }

        public ScoreboardController()
        {       
            model = new ScoreboardModel();
            view = new ScoreboardView(this);
        }

        public void UpdateScore()
        {

        }

        public void UpdateAantalWorpen()
        {
            model.Score += 1;
            
            view.UpdateScoreboard();
        }


    }
}
