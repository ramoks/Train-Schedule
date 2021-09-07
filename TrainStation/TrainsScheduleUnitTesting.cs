//**********************************************
// File: TrainsSheduleUnitTesting.cs
// Purpose: The trainsScheduleUnitesting class
//          will test the data from the Station,
//          and StationArrival class to make sure the 
//          data is actually being passed in 
// Written By: Kenneth Ramos
//Compiler: Visual Studio 2015
//******************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
   public class TrainsScheduleUnitTesting
    {
        #region 'Methods'
        // This method will do unit testing on the properties of Station class
        public void unitTestStation()
        {
            // create instance of station and test the properties
            // if the test is a success a Pass message will be printed
            // if not a fail message will be printed
            Station s1 = new Station();
            int testID = 111;
            s1.Id =testID;
            // Test ID property
            if (s1.Id == testID)
            {
                Console.WriteLine("Station ID property: Pass");
            }
            else
            {
                Console.WriteLine("Station ID property: Fail");
            }
            // test Name property
            string testName = "Huntington";
            s1.Name = testName;
            if(s1.Name == testName)
            {
                Console.WriteLine("Station Name property: Pass");
            }
            else
            {
                Console.WriteLine("Station Name property: Fail");
            }
            // test location property
            string testLocation = "New York Avenue (Route 110) and Broadway, 2 miles North of Jericho Turnpike";
            s1.Location = testLocation;
            if(s1.Location == testLocation)
            {
                Console.WriteLine("Station Location property: Pass");
            }
            else
            {
                Console.WriteLine("Station Location property: Fail");
            }
            //Test fareZone property
            int testFareZone = 9;
            s1.FareZone = testFareZone;
            if (s1.FareZone == testFareZone)
            {
                Console.WriteLine("Station farezone property: Pass");
            }
            else
            {
                Console.WriteLine("Station farezone property: Fail");
            }
            // test mileageToPenn property
            double testMileageToPenn = 34.7;
            s1.MileageToPenn = testMileageToPenn;
            if(s1.MileageToPenn == testMileageToPenn)
            {
                Console.WriteLine("Station mileageToPenn property: Pass");
            }
            else
            {
                Console.WriteLine("Station mileageToPenn property: Fail");
            }
            // Test picFile Name property
            string testPicFile = "huntington.jpg";
            s1.PicFileName = testPicFile;
            if(s1.PicFileName == testPicFile)
            {
                Console.WriteLine("Station picFileName property: Pass");
            }
            else
            {
                Console.WriteLine("Station picFileName property: Fail");
            }
        }

        // This method will do unit testing on the properties of StationArrival class
        public void unitTestStationArrival()
        {
            StationArrival SA1 = new StationArrival();
            // test stationID property
            int testStationID = 2;
            SA1.StationId = testStationID;
            if (SA1.StationId == testStationID)
            {
                Console.WriteLine("Station_ID property: Pass");
            }
            else
            {
                Console.WriteLine("Station_ID property: Fail");
            }
            // test DateTime property
            DateTime testTime = new DateTime(2017, 8, 28, 9, 25,0);
            SA1.Time = testTime;
            if (SA1.Time == testTime)
            {
                Console.WriteLine("Station Arrival Time property: Pass");
            }
            else
            {
                Console.WriteLine("Station Arrival Time property: Fail");
            }
           /* // test TransferRequired property
            bool testTransferRequired = true;
            SA1.TransferRequired = testTransferRequired;
            if(SA1.TransferRequired == testTransferRequired)
            {
                Console.WriteLine("Station Arrival TransferRequired property: Pass");
            }
            else
            {
                Console.WriteLine("Station Arrival TransferRequired property: Fail");
            }*/
        }
        #endregion
    }
}
