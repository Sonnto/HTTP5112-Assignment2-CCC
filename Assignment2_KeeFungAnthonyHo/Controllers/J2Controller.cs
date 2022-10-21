using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_KeeFungAnthonyHo.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Determines how many ways one can roll the value of 10.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        /// <example>
        /// GET: /api/J2/DiceGame/6/8 -> "There are 5 total ways to get the sum of 10"
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int tenCounter = 0;

            //How many ways to roll 10?
            //m + n === 10
            //m and n can have any number side

            for (int sideOfDiceM = 1; sideOfDiceM <= m; sideOfDiceM++) // increments the m value and jumps to second for loop.
            {
                for (int sideOfDiceN = 1; sideOfDiceN <= n; sideOfDiceN++) // increments the n value and jumps to the if statement.
                {
                    if (sideOfDiceM + sideOfDiceN == 10) // if m + n = 10, increment the tenCounter by 1. If not, fall back to the first for loop.
                    {
                        tenCounter++;
                    }
                }
            }
            return "There are " + tenCounter + " total ways to get the sum of 10";
        }
    }
}
