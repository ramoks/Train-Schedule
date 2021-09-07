//***********************************************************
//File: BranchSchedule.cs
//Purpose: Stores all trainIDs in a branch
//      This class stores only the train ids.
//      To get more information about the individual train you would need 
//      to look up information about the train in the TrainCollection.
//Written by: Kenneth Ramos
//Compiler: Visual Studio 2015
//****************************************************************
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
    public class BranchSchedule
    {
        #region'Member Variables'
        private int branchId;
        private List<int> trainIds = new List<int>();
        #endregion

        #region'Properties'
        [DataMember(Name ="id")]
        public int BranchId
        { // branchID property
            get
            {
                return branchId;
            }
            set
            {
                branchId = value;
            }
        }// end property

        [DataMember(Name = "train_ids")]
        public List<int> TrainIds
        {
            get
            {
                return trainIds;
            }
            set
            {
                trainIds = value;
            }
        }// end property
        #endregion

        #region'Constructor & Methods'
        public BranchSchedule()
        {
            branchId = 2;
            trainIds.Add(1623);
            trainIds.Add(1205);
        }

        //Method: ToString 
        // Will return member data in a string format
        public override string ToString()
        {
            string combinedString = string.Join(",", trainIds);
            return "Branch ID " + branchId + "TrainIDs " + combinedString;
           // return TrainIds.ToString();
        }
        #endregion
    }
}
