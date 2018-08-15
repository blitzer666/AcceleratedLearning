using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Domain
{
    class Elevator
    {

        public string ID { get; set; }
        public int GroundFloor { get; set; }
        public int TopFloor { get; set; }
        public int CurrentFloor { get; set; }
        public int TimeToMaintainence = 10;


        public bool OnOrOff
        {
            get
            {
                if (TimeToMaintainence > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            }
        }
        public string Status()
        {
            if (OnOrOff == true)
                return "på";
            else
                return "av";
        }

        public Elevator(string id, int lowestLevel, int highestLevel, int startingLevel, int timeToMaint) //Konstruktor
        {
            ID = id;
            GroundFloor = lowestLevel;
            TopFloor = highestLevel;
            CurrentFloor = startingLevel;
            TimeToMaintainence = timeToMaint;
        }
        public Elevator(string id, int lowestLevel, int highestLevel)
        {
            ID = id;
            GroundFloor = lowestLevel;
            TopFloor = highestLevel;
            CurrentFloor = lowestLevel;
        }

        public string Report()
        {
            string reportMessage = ("Hissen " + ID + " är på våning " + CurrentFloor + ". Hissen är " + Status() + ". Tills underhåll: " + TimeToMaintainence);

            return reportMessage;
        }
        public void GoUp()
        {
            if (CurrentFloor != TopFloor && TimeToMaintainence != 0)
            {
                CurrentFloor++;
                TimeToMaintainence--;
            }
        }
        public void GoDown()
        {
            if (CurrentFloor != GroundFloor && TimeToMaintainence != 0)
            {
                CurrentFloor--;
                TimeToMaintainence--;
            }
        }
    }
}

