﻿using System;
using System.Collections.Generic;
using System.Linq;

using CodePhile;

namespace SpaceBeans {
    public abstract class ConsolePlayer : CodePhile.Games.IDecisionMaker {
        private readonly Trader trader;

        protected ConsolePlayer() {}

        protected ConsolePlayer(int position) {
            trader = new Trader("Trader " + position);
        }

        public Trader Trader {
            get { return trader; }
        }

        public abstract void MakeDecision(ISpaceBeansDecision decision);

        public static void ForEachUntil<T>(IEnumerable<T> decisionMakers, Func<T, bool> predicate) {
            // TODO: improve this
            decisionMakers.TakeUntil(predicate).ToArray();
        }
    }
}