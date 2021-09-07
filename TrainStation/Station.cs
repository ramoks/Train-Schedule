//************************************************************
// File: Station.cs
// Purpose: Contains the class definition for Station.
// Station class will hold train station details, that include
//  like Station name, location and station ID.
//
// Written by: Kenneth Ramos
// Compiler: Visual Studio 2015
//************************************************************

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
    public class Station
    {
        #region'MemberVariables'
        
        private int id;
        private string name;
        private string location;
        private int fareZone;
        private double mileageToPenn;
        private string picFileName;
       
        #endregion

        #region'Constructor&Methods
        public Station()   // station constructor with default values, Values will be changed in main
        {
            id = 1;
            name = " ";
            location = " ";
            fareZone = 0;
            mileageToPenn = 0.0;
            picFileName = " ";
        }
        // overloaded constructor w/parameters
        public Station(int v1, string v2, string v3, int v4, double v5, string v6)
        {
            this.id = v1;
            this.name = v2;
            this.location = v3;
            this.fareZone = v4;
            this.mileageToPenn= v5;
            this.picFileName = v6;
        }

        // ToString method will return member variables in string format
        public override string ToString()
        {
            return "Station ID: "+id +" Name: "+ name +
                " Location: "+ location +" Farezone "+ fareZone +
                " Mileage to Penn: "+ mileageToPenn + " Pic file name: "+ picFileName;
            
        }

        #endregion

        #region 'Station Properties'
        /* Properties will have their own attributes for serialization
         * */
        [DataMember(Name = "id" )]
        public int Id
        { // begin id property
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }   // end id property*/
        public string IdAsString 
        { // begin id property
            get
            {
                return id.ToString() ;
            }
        }   // end id property
        [DataMember(Name ="name")]
        public string Name
        { // begin name property
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        } // end name property

        [DataMember(Name="location")]
        public string Location
        { // begin location property
            get
            {
                return location;
            }
            set
            {
                location = value;
            }

        }// end location property

        [DataMember(Name="fare_zone")]
        public int FareZone
        {// begin fareZone property
            get
            {
                return fareZone;
            }
            set
            {
                fareZone = value;
            }
        } // end fareZone property

        [DataMember(Name= "mileage_to_penn")]
        public double MileageToPenn
        { // begin mileageToPenn property
            get
            {
                return mileageToPenn;
            }
            set
            {
                mileageToPenn = value;
            }
        } // end mileageToPenn property

        [DataMember(Name="pic_filename")]
        public string PicFileName
        { // begin picFileName property
            get
            {
                return picFileName;
            }
            set
            {
                picFileName = value;
            }
        }// end picFileName property
        #endregion
    }
}
