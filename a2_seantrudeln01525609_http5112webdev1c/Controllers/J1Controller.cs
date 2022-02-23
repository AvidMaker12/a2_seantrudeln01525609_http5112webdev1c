using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// J1: The New CCC (Canadian Calorie Counting)
namespace a2_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Output total calorie sum using GET inputs for menu items
        /// </summary>
        /// <param name="burger"></param>
        /// <returns>Output total calorie sum as string message</returns>


        //test: localhost/api/J1/Menu/1/1/1/1 should return "Your total calorie count is 858"
        //test: localhost/api/J1/Menu/4/4/4/4 should return "Your total calorie count is 0"
        //test: localhost/api/J1/Menu/1/2/3/4 should return "Your total calorie count is 691"

        // GET api/J1/Menu/{burger}/{drink}/{side}/{dessert}
        [HttpGet]
        [Route("api/J1/Menu/{burgerChoice}/{drinkChoice}/{sideChoice}/{dessertChoice}")]
        public string Menu(int burgerChoice, int drinkChoice, int sideChoice, int dessertChoice)
        {
            // menu options array
            int[] burger = { 461, 431, 420, 0 };
            int[] drink = { 130, 160, 118, 0 };
            int[] side = { 100, 57, 70, 0 };
            int[] dessert = { 167, 266, 75, 0 };

            // convert user input into array accessible integers (ex. user input 1 becomes 0 in array, the first array value)
            int a = burgerChoice - 1;
            int b = drinkChoice - 1;
            int c = sideChoice - 1;
            int d = dessertChoice - 1;

            // sums calories of user selected array values
            int calorieTotal = burger[a] + drink[b] + side[c] + dessert[d];

            return "Your total calorie count is " + calorieTotal;
        }
    }
}