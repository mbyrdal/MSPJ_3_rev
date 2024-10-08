using System;
using System.Collections.Generic;
using Exercise_DelegatesAndSortGUI.Model;

namespace DelegatesSortGui.Data
{
    public class GamerData {

        List<Gamer> gamers;

        public GamerData() {
            this.gamers = new List<Gamer>();
        }

        public List<Gamer> FetchGamers() {

            gamers.Add(new Gamer(1, "SuperHero", 759120));
            gamers.Add(new Gamer(2, "Xyp9x", 3947630));
            gamers.Add(new Gamer(3, "dupreeh", 9959570));

            return gamers;
        }

    }
}
