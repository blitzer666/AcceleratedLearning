using System;
using System.Collections.Generic;

namespace Tomtenissar
{
    class Program
    {
      
        private static TomteContext context = new TomteContext();
        static void Main(string[] args)
        {
            ClearDatabase();

            AddTomte();

            AddSomeTomtar();

            AddSomeBattles();
        }

        private static void AddSomeBattles()
        {
            var SkogsStriden = new Battle { Name = "SkogsStriden" };
            using (var context = new TomteContext())
            {
                context.Battle.AddRange(Battle1, Battle2);
                context.SaveChanges();
            }
        }
        private static Battle Battle1
        {
            get
            {
                return new Battle
                {
                    Name = "TomteBattle 1",
                    Description = "Alla paket blev förstörda",
                    IsBrutal = true,
                    StartDate = new DateTime(2018,12,24),
                    EndDate = new DateTime(2018,12,24),
                    BattleLog = new BattleLog
                    {
                        Name = "Battlelog for TomteBattle 1",
                        BattleEvents = new List<BattleEvents>
                    {
                            new BattleEvents{Summary = "Summary of event (order1, battle1)",Description="Description of event (order1, battle1)",Order =1},
                            new BattleEvents{Summary = "Summary of event (order2, battle1)",Description="Description of event (order1, battle1)",Order =2},
                            new BattleEvents{Summary = "Summary of event (order3, battle1)",Description="Description of event (order1, battle1)",Order =3},
                    }
                    }

                };
            }
        }
        private static Battle Battle2
        {
            get
            {
                return new Battle
                {
                    Name = "TomteBattle 2",
                    Description = "Alla blev jätte sura",
                    IsBrutal = true,
                    StartDate = new DateTime(2018,12,23,10,13,51),
                    EndDate = new DateTime(2018,12,24,13,55,00),
                    BattleLog = new BattleLog
                    {
                        Name = "Battlelog for TomteBattle 1",
                        BattleEvents = new List<BattleEvents>
                    {
                            new BattleEvents{Summary = "Summary of event (order1, battle1)",Description="Description of event (order1, battle1)",Order =1},
                            new BattleEvents{Summary = "Summary of event (order2, battle1)",Description="Description of event (order1, battle1)",Order =2},
                            new BattleEvents{Summary = "Summary of event (order3, battle1)",Description="Description of event (order1, battle1)",Order =3},
                    }
                    }

                };
            }
        }


        private static void ClearDatabase()
        {
            context.RemoveRange(context.Tomte);
            context.RemoveRange(context.Battle);
            context.SaveChanges();
        }

        private static void AddSomeTomtar()
        {
            var tomteJohan = new Tomtar { Name = "Johan" };
            var tomteRobban = new Tomtar { Name = "Robban" };
            var tomteGunnar = new Tomtar { Name = "Gunnar" };

            using (var context = new TomteContext())
            {
                context.Tomte.AddRange(tomteJohan, tomteRobban, tomteGunnar);
                context.SaveChanges();
            }
        }


                private static void AddTomte()
        {
            var x = new Tomtar
            {
                Name = "Groguul",
            };
            using (var context = new TomteContext())
            {
                context.Tomte.Add(x);
                context.SaveChanges();


            }
        }
    }
}
