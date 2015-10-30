using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzhee3
{
    public class TeerlingController
    {
        
        TeerlingView view;
        public TeerlingModel model;
        static Random random = new Random();

        public TeerlingController()
        {
            view = new TeerlingView(this);
            model = new TeerlingModel();
        }


        public TeerlingView getView()
        {
            return view;

        }
        
        public void Werp()
        {     
            int randomNummer = random.Next(1, 7);
            model.AantalOgen = randomNummer;          
        }

        public void ZetVast()
        {   
            if (model.ColorIsRed)
            {
                 model.ColorIsRed = false;
            }
            else
            {
                 model.ColorIsRed = true;
            }
        }

        public void UpdateUI()
        {
            int nieuwAantalOgen = model.AantalOgen;
            model.TeerlingLabelText = nieuwAantalOgen.ToString();
            view.UpdateUI();
        }
    }
}
