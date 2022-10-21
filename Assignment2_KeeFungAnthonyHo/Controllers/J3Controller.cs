using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Mvc.Html;

namespace Assignment2_KeeFungAnthonyHo.Controllers
{
    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/AreWeThereYet/{dis1}/{dis2}/{dis3}/{dis4}")]
        public string AreWeThereYet(int dis1, int dis2, int dis3, int dis4)
        {
            int[] leftOfStartingCity = new int[5];
            int[] rightOfStartingCity = new int[5];

            // City 1 - City 2 - City 3 - City 4 - City 5

            //represents 5 different cities/starting points for distance calculation;
            for (int i = 0; i < 5; i++) // ensures we iterate through the 5 points/cities we start measuring distances left and right of.
            {
                for (int j = i; j > 0; j--)// EAST or movement/distance towards the left;
                {
                    //check how many cities to the left of starting city;
                    switch (j)
                    {
                        case 0:// [City 1] - City 2 - City 3 - City 4 - City 5
                            leftOfStartingCity = new int[] { 0 }; //assign to the left-of-array all cities to the left
                            break;
                        case 1:// City 1 - [City 2] - City 3 - City 4 - City 5
                            leftOfStartingCity = new int[] {dis1, 0};
                            break;
                        case 2:// City 1 - City 2 - [City 3] - City 4 - City 5
                            leftOfStartingCity = new int[] {dis1, (dis1+dis2), 0};
                            break;
                        case 3:// City 1 - City 2 - City 3 - [City 4] - City 5
                            leftOfStartingCity = new int[] { dis1, (dis1+dis2), (dis1+dis2+dis3), 0 };
                            break;
                        case 4:// City 1 - City 2 - City 3 - City 4 - [City 5]
                            leftOfStartingCity = new int[] { dis1, (dis1 + dis2), (dis1 + dis2 + dis3), (dis1+dis2+dis3+dis4), 0 };
                            break;
                        default:
                            leftOfStartingCity = new int[] { 0 };
                            break;
                    }
                }
                for (int k = i; k < 5; k++)// WEST or movement/distance towards the right;
                {
                    //check how many cities to the right of starting city;
                    switch (k)
                    {
                        case 0:// [City 1] - City 2 - City 3 - City 4 - City 5
                            rightOfStartingCity = new int[] { 0 }; //assign to the right-of-array all cities to the left
                            break;
                        case 1:// City 1 - [City 2] - City 3 - City 4 - City 5
                            rightOfStartingCity = new int[] { 0, dis1 }; break;
                        case 2:// City 1 - City 2 - [City 3] - City 4 - City 5
                            rightOfStartingCity = new int[] { 0, dis1, (dis1+dis2) }; break;
                        case 3:// City 1 - City 2 - City 3 - [City 4] - City 5
                            rightOfStartingCity = new int[] { 0, dis1, (dis1+dis2), (dis1+dis2+dis3) }; break;
                        case 4:// City 1 - City 2 - City 3 - City 4 - [City 5]
                            rightOfStartingCity = new int[] { 0, dis1, (dis1+dis2), (dis1+dis2+dis3), (dis1+dis2+dis3+dis4) }; break;
                        default:
                            rightOfStartingCity = new int[] { 0 }; break;
                    }
                }

            }
            return "testing";
        }
    }
}
