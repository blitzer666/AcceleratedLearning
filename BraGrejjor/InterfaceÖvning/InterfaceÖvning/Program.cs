using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceÖvning
{
    class Program
    {
        interface IItem
        {
            string Name { get; set; }
            int GoldValue { get; set; }

            void Equip();
            void Sell();
        }
        interface IDamagable
        {
            int Durability { get; set; }

            void TakeDamage(int amount);
        }
        class Sword : IItem, IDamagable
        {
            public string Name { get; set; }
            public int GoldValue { get; set; }

            public int Durability { get; set; }

            public Sword(string _name)
            {
                Name = _name;
                GoldValue = 100;
                Durability = 30;
            }
            class Axe : IItem, IDamagable
            {
                public string Name { get; set; }
                public int GoldValue { get; set; }

                public int Durability { get; set; }

                public Axe(string _name)
                {
                    Name = _name;
                    GoldValue = 70;
                    Durability = 50;
                }

                public void Equip()
                {
                    Console.WriteLine(Name + " equipped.");
                }
                public void Sell()
                {
                    Console.WriteLine(Name + " sold for " + GoldValue + " imaginary dollars!");
                }

                void TakeDamage(int _dmg)
                {
                    Durability -= _dmg;
                    Console.WriteLine(Name + " damage by " + _dmg + " . It now has a durability of " + Durability);
                }


                static void Main(string[] args)
                {
                    Sword sword = new Sword("Sword of Destiny");
                    sword.Equip();
                    sword.TakeDamage(20);
                    sword.Sell();

                    Axe axe = new Axe("Axe of fury");
                    axe.Equip();
                    axe.TakeDamage(20);
                    axe.Sell();
                }

                void IDamagable.TakeDamage(int amount)
                {
                    throw new NotImplementedException();
                }
            }
        }

    }


