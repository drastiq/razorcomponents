using Microsoft.EntityFrameworkCore.Internal;
using sandbox.core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace sandbox.dataaccess
{
    public static class DbInitializer
    {
        public static void Initialize(SandboxContext context)
        {
            if (context.Cards.Any())
            {
                return;
            }

            var cards = new Card[]
            {
                new Card {CardValue=1},
                new Card {CardValue=2},
                new Card {CardValue=3},
                new Card {CardValue=5},
                new Card {CardValue=8},
                new Card {CardValue=13},
                new Card {CardValue=99},
            };

            cards.ToList().ForEach(x => context.Cards.Add(x));
            context.SaveChanges();
        }
    }
}
