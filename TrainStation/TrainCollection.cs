//***************************************
// File: TrainCollection
// Purpose: Collection of trains, will store all trains on the LIRR
// Other classes will refer to objects in this collection using the train id.
// Written by: Kenneth Ramos
// Compiler: Visual Studio 2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace TrainStation
{
    [DataContract]
   public class TrainCollection
    {
        #region'Member variables'
        // member variables
        private List<Train> trains = new List<Train>();
        #endregion

        #region 'Properties'
        [DataMember(Name = "trains")]
        public List<Train> Trains
        {
            get
            {
                return trains;
            }
            set
            {
                trains = value;
            }
        }// end property
        #endregion

        #region 'Constructor & Methods'
        public TrainCollection()
        {
            // will have 2 items in list by default
            List<StationArrival> sa = new List<StationArrival>();
            sa.Add(new StationArrival(54, new DateTime(2017, 10, 13, 7, 30, 00), 1623));
            sa.Add((new StationArrival(22, new DateTime(2017, 10, 13, 12, 30, 00), 1623)));
            trains.Add(new Train(1623, sa));
        }

        //Method: ToString
        // will return data in string format
        public override string ToString()
        {
            string combinedString = string.Join("\n", trains);
            return "Trains: " + combinedString;
        }

        //Method: FindTrain
        //Returns the Train object with the given train id.
        //If it is not found return null;
        public Train FindTrain(int trainId)
        {
            Train t = new Train();
            foreach(Train s in trains)
            {
                if(s.TrainId == trainId)
                {
                    t = s;
                    break;
                }
                else
                {
                    //Console.WriteLine("Train not found");
                    t = null;
                }
            }
            //Console.WriteLine("Train(s) found:\n" + t);
            return t;
        }   // end method
        #endregion
    }
}
