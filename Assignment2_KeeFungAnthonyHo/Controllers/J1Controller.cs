using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace Assignment2_KeeFungAnthonyHo.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Computes total calories of a meal.
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="dessert"></param>
        /// <returns></returns>
        /// <example>
        /// GET : /api/J1/Menu/1/1/1/1 -> "Your total calorie count is 858"
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {   //arrays for the list of options for each of the menu items

            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sideCalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 167, 266, 75, 0 };

            int totalCalories = (int)burgerCalories.GetValue(burger - 1) + (int)drinkCalories.GetValue(drink - 1) +
                (int)sideCalories.GetValue(side - 1) + (int)dessertCalories.GetValue(dessert - 1);
            //get position of array element; because the method Array.GetValue returns object, must change it to (int) to add
            //values together for total calories.
            
            return "Your total calorie count is " + totalCalories;
        }
    }
}
