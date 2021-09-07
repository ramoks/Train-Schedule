//*****************************************
// File: Branch.cs
// Purpose: A branch is one set of stations that make up a line on the LIRR.
//         Examples of branches are the Port Jefferson branch and the Montauk branch.
//         This class will hold the station id's
// Written by: Kenneth Ramos
// Compiler: Visual Studio 2015
//*******************************************************************
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
   public class Branch
    {
        #region 'Member Variables'
        private int id;
        private string name;
        private List<int> stationIds = new List<int>();
        #endregion
       
        #region 'Properties'
        [DataMember(Name= "id")]
        // id property
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }// end id property

        [DataMember(Name = "Name")]
        public string Name
        {  // name property
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        } // end name property
        
        [DataMember(Name = "Station_ids")]
        public List<int> StationIDs
        {
            get
            {
                return stationIds;
            }
            set
            {
                stationIds = value;
            }
        }
        #endregion
        
        #region 'Constructor & Methods'
        // default constructor
        public Branch()
        {
            id = 2;
            name = "Port Jefferson";
            stationIds.Add(10);
            stationIds.Add(11);
            stationIds.Add(12);
            stationIds.Add(13);
            stationIds.Add(14);
        }
        // constructor w/parameters
       public Branch(int id, string name, List<int> SIDs)
        {
            this.id = id;
            this.name = name;
            this.stationIds = SIDs;
        }
      

        // Method: ToString
        // will return descriptive text and data for all member variables
        public override string ToString()
        {
            string combinedString = string.Join(",", stationIds);
            return "Id " + id + " Name " + name +" StationIDs:" + combinedString; 
            

        }

        // Method: bool isBranchStation
        // returns true if the given station id is a station on the branch and false otherwise.
        public bool isBranchStation(int stationID)
        {
            bool result = false;
            foreach(int id in stationIds)
            {
                if(id == stationID)
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }   // end isBranchStation method
        #endregion
    }
}
