//***********************************************************
// File: BranchCollection.cs
// Purpose:  A collection of branches contains the definition
//      For FindBranch methods and the branches member variable
// Written by: Kenneth Ramos
// Compiler: Visual studio 2015
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
   public class BranchCollection
    {
        #region 'Member Variables'
        private List<Branch> branches = new List<Branch>();
        #endregion

        #region 'Properties'
        [DataMember(Name = "branches")]
        public List<Branch> Branches
        {
            get
            {
                return branches;
            }
            set
            {
                branches = value;
            }
        }// end branches property
        #endregion

        #region'Constructor & Methods'
        // default constructor
        public BranchCollection()
        {
            // create a list of ints add the values then pass the list as variable
            // then pass it as a parameter when creating a new branch to add to the
            // branches list
            List<int> SI = new List<int>();
            SI.Add(94);
            SI.Add(54);
            SI.Add(86);
            Branches.Add(new Branch(2, "Port Jefferson", SI));

            List<int> SI2 = new List<int>();
            SI2.Add(101);
            SI2.Add(20);
            SI2.Add(22);
            Branches.Add(new Branch(3, "Ronkonkoma", SI2));

        }

        // Method: ToString
        // Will return branches data in a string format
        public override string ToString()
        {
            string combinedString = string.Join("\n", branches);
            return "Branches " + combinedString;
        }// end ToString method

        //Method: FindBranch
        // will return the branch object w/ the given branch id.
        // if it isn't found return null
        public Branch FindBranch(int branchId)
        {
            Branch b = new Branch();
            foreach (Branch s in branches)
            {
                if (s.Id == branchId)
                {
                    b = s;
                    break;
                }
                else
                {
                    b = null;
                }
            }
           // Console.WriteLine("Branch(s) found:\n" + b);
            return b;
        }// end findbranch method

        //Method:FindBranch
        //// will return the branch object w/ the given branch name.
        // if it isn't found return null
        public Branch FindBranch(String name)
        {
            Branch b = new Branch();
            foreach (Branch s in branches)
            {
                if (s.Name == name)
                {
                    b = s;
                    break;
                }
                else
                {
                    b = null;
                }
            }
          //  Console.WriteLine("Branch(s) found:\n" + b);
            return b;
        } // end find branch

        #endregion
    }
}
