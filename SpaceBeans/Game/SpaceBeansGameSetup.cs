﻿using System.Collections.Generic;
using System.Linq;

namespace SpaceBeans {
    public class SpaceBeansGameSetup {
        private readonly IList<Trader> traders = new List<Trader>();

        public int TraderCount {
            get { return traders.Count; }
        }

        public void Validate() {
        }

        public Trader[] GetTraders() {
            return traders.ToArray();
        }

        public void AddTrader(Trader trader) {
            traders.Add(trader);
        }
    }
}