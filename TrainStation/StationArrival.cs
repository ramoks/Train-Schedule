//**************************************************
// File: StationArrival.cs
// Purpose: Contains the class definition for StationArrival
//          StationArrival will hold the information for
//          the date/time train arrived and whether or not
//          a you need to transfer to another train
// Written By: Kenneth Ramos
//Compiler: Visual Studio 2015
// ****************************************************
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
   public class StationArrival
    {
        #region'MemberVariables'
        private int stationId;
        private DateTime time;
        //private bool transferRequired; //HW1
        private int trainId; // HW 2 create train ID
        #endregion

        #region'Constructor&Methods'
        // default constructor
        public StationArrival()
        {
            stationId = 2;
            time = new DateTime(2017, 8, 28, 9, 25, 0);
            //transferRequired = true;
            trainId = 1;
        }
        //overloaded Constructor
        public StationArrival(int stationID, DateTime time, int trainID)
        {
            this.stationId = stationID;
            this.time = time;
            this.trainId = trainID; 
        }

        //ToString method will return info 
        public override string ToString()
        {
            return "Station ID:" + stationId + " Time: " + time +
                " Train ID: " + trainId;// Transfer Required " + transferRequired;
        }
        #endregion

        #region 'StationArrival properties'
        // Properties will have their a datamember attribute for serialization
        [DataMember(Name ="station_id")]
        public int StationId
        { // begin stationID property
            get
            {
                return stationId;
            }
            set
            {
                stationId = value;
            }
        }// end stationID property

        [DataMember(Name="time")]
        public DateTime Time
        { // begin Time property
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }// end time property

      /* [DataMember(Name ="transfer_required")]
        public bool TransferRequired
        { // begin transferRequired property
            get
            {
                return transferRequired;
            }
            set
            {
                transferRequired = value;
            }

        }// end transferRequired property*/
        [DataMember(Name = "trainID")]
        public int TrainID
        {   // begin trainID property
            get
            {
                return trainId;
            }
            set
            {
                trainId = value;
            }
        }   // end trainID property
        #endregion
    }
}
