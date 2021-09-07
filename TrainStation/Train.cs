//*****************************************
// File: Train.cs
// Purpose:A train is one specific train run. 
//For example, the 7:12am train out of Huntington. 
//Each train on the LIRR has an id that uniquely identifies it.
// One instance of this class will store the list of stations that this train stops
// at in the form of StationArrival instances.
// Written by: Kenneth Ramos
// Compiler: Visual studio 2015
//***************************************************
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
   public class Train
    {
        #region'Member Variables'
        // private member variables
        private int trainId;
        private List<StationArrival> stationArrivals = new List<StationArrival>();
        #endregion

        #region 'Properties'
        [DataMember(Name = "id")]
        public int TrainId
        { // trainID property
            get
            {
                return trainId;
            }
            set
            {
                trainId = value;
            }
        } // end trainID property

        [DataMember(Name = "station_arrivals")]
        public List<StationArrival> StationArrivals
        { // begin property
            get
            {
                return stationArrivals;
            }
            set
            {
                stationArrivals = value;
            }
        }// end stationArrivals property
        #endregion

        #region 'Constructor & methods'
        // default constructor
        public Train()
        {
            trainId = 2;
            stationArrivals.Add(new StationArrival(54, new DateTime(2017, 8, 28, 9, 25, 0), 2));
            stationArrivals.Add(new StationArrival(22, new DateTime(2017, 8, 28, 10, 55, 00), 2));
        }
        //overloaded constructor
        public Train(int id, List<StationArrival> sa)
        {
            this.trainId = id;
            this.stationArrivals = sa;
        }
        // Method: ToString
        // return member info in a string format
        public override string ToString()
        {
            string combinedString = string.Join(",", stationArrivals);
            return "Train ID " + trainId+ " Station Arrivals: " + combinedString;
        }
        #endregion
    }
}
