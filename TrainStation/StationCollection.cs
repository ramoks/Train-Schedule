//***********************************************************
// File: StationCollection.cs
// Purpose: The collection of stations. The main use of this will
//          be to store all stations on the LIRR. Other classes
//          will refer to objects in this collection using the 
//          the station id.
// Written by: Kenneth Ramos
// Compiler: Visual Studion 2015
//***********************************************************
 
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
   public class StationCollection
    {
        #region 'Member Variables'
        private List<Station> stations = new List<Station>();


        #endregion

        #region 'Properties'
        //stations property
        [DataMember(Name = "stations")]
        public List<Station> Stations
        {
            get
            {
                return stations;
            }
            set
            {
                stations = value;
            }
        } // end stations property
        #endregion

        #region 'Constructor & methods'
        // default constructor
        public StationCollection()
        {
            stations.Add(new Station(0, "Albertson", "I.U.Willets Road and Albertson Avenue,between …", 7, 20.8, "albertson.jpg"));
        }
               
      

        // Method: ToString
        // will show descriptive text of data for all member variables
        public override string ToString()
        {
            string combinedString = string.Join("\n", stations);
            return "Stations: " + combinedString;
            
        }

        //Method: FindStation
        // Will return the station object w/ the given station id.
        // If it isn't found return null.
        public Station FindStation(int stationId)
        {
            Station a =  new Station();
            foreach(Station s in stations)
            {
                if(s.Id == stationId)
                {
                    a= s;
                    break;
                }
                else
                {
   
                    a= null;
            
                }
            }
           // Console.WriteLine("Station(s) found:\n"+a);
            return a;
        }// end find station method

        //Method:FindStation
        // Will return the station object w/ the given name 
        // if it not found return null
        public Station FindStation(string name)
        {
            Station b= new Station();
           
            foreach(Station s in stations)
            {
                if(s.Name == name)
                {
                    b = s;
                    break;
                }
                else
                {
                
                    b = null; 
                }
            }
            // Console.WriteLine("Station(s) found:\n" + b);
            return b;
           
        } // end FindStation method
        #endregion
      
    }
}

