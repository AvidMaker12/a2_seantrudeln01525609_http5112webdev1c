using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// J2: Roll the Dice
namespace a2_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Output total number of ways to roll sum value of 10 using 2 dice where the number of their faces are determined by user input
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>Output total number of ways to get sum of 10 as a string message</returns>

        //test: localhost/api/J2/DiceGame/6/8 should return "There are 5 total ways to get the sum 10."
        //test: localhost/api/J2/DiceGame/12/4 should return "There are 4 total ways to get the sum 10."
        //test: localhost/api/J2/DiceGame/3/3 should return "There are 0 total ways to get the sum 10."
        //test: localhost/api/J2/DiceGame/5/5 should return "There are 1 total ways to get the sum 10."

        // GET api/J2/DiceGame/{m}/{n}
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            // {m} - positive integer representing the number of sides on the first die
            // {n} - positive integer representing the number of sides on the second die

            // dice number of faces arrays
            int[] diceM = new int[m];
            int[] diceN = new int[n];

            // create dice numbers and place into dice arrays
            for (int i = 0; i < diceM.Length; i++)
            {
                diceM[i] = i + 1;
            }
            for (int i = 0; i < diceN.Length; i++)
            {
                diceN[i] = i + 1;
            }
            
            // variable that counts number of permutations for the dice faces to add up to 10
            int comboCounter = 0;

            // dice faces combination summation loops
            for (int i = 0; i < diceM.Length; i++)
            {
                for (int j = 0; j < diceN.Length; j++)
                {
                    int sum = diceM[i] + diceN[j];

                    if (sum == 10)
                    {
                        comboCounter += 1;
                    }
                }
            }

            return "There are " + comboCounter + " total ways to get the sum 10.";

        }


    }
}
