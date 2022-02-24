using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// J3: Returning Home
namespace a2_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Output string sentences where user input used to create walking directions from school to home
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="street1"></param>
        /// <param name="d2"></param>
        /// <param name="street2"></param>
        /// <param name="d3"></param>
        /// <returns>Output string sentences</returns>

        // sample input: localhost/api/J3/ReturnHome/r/queen/r/fourth/r should return "Turn LEFT onto FOURTH street. Turn LEFT onto QUEEN street. Turn LEFT into your HOME."

        // GET api/J3/ReturnHome/{d}/{street}/{d}/{street}/{d}
        [HttpGet]
        [Route("api/J3/ReturnHome/{d1}/{street1}/{d2}/{street2}/{d3}")]
        public string ReturnHome(string d1, string street1, string d2, string street2, string d3)
        {
            // variables
            string direction;
            int directionCounter = 0;
            string string1 = Global1.string1;
            string string2 = Global1.string1;
            string string3 = Global1.string1;

            // Global1.string1 = "";

            if (d1 == "l" && directionCounter == 0)
            {
                direction = "LEFT";
                directionCounter++;
                Global1.string1 = "Turn " + direction + " onto " + street1.ToUpper() + " street. ";
            }
            else if (d1 == "r" && directionCounter == 0)
            {
                direction = "RIGHT";
                directionCounter++;
                Global1.string1 = "Turn " + direction + " onto " + street1.ToUpper() + " street. ";
            }
            if (d2 == "l" && directionCounter == 1)
            {
                direction = "LEFT";
                directionCounter++;
                Global1.string2 = "Turn " + direction + " onto " + street2.ToUpper() + " street. ";
            }
            else if (d2 == "r" && directionCounter == 1)
            {
                direction = "RIGHT";
                directionCounter++;
                Global1.string2 = "Turn " + direction + " onto " + street2.ToUpper() + " street. ";
            }
            if (d3 == "l" && directionCounter == 2)
            {
                direction = "LEFT";
                Global1.string3 = "Turn " + direction + " into your HOME. ";
            }
            else if (d3 == "r" && directionCounter == 2)
            {
                direction = "RIGHT";
                Global1.string3 = "Turn " + direction + " into your HOME. ";
            }
            return Global1.string1 + " " + Global1.string2 + " " + Global1.string3;
        }

        // sample input: localhost/api/J3/ReturnHome/l/main/r should return "Turn LEFT onto MAIN street. Turn RIGHT into your HOME."

        // GET api/J3/ReturnHome/{d1}/{street1}/{d2}
        [HttpGet]
        [Route("api/J3/ReturnHome/{d1}/{street1}/{d2}")]
        public string ReturnHome(string d1, string street1, string d2)
        {
            // variables
            string direction;
            int directionCounter = 0;
            string string1 = Global1.string1;
            string string2 = Global1.string1;

            if (d1 == "l" && directionCounter == 0)
            {
                direction = "LEFT";
                directionCounter++;
                Global1.string1 = "Turn " + direction + " onto " + street1.ToUpper() + " street.";
            }
            else if (d1 == "r" && directionCounter == 0)
            {
                direction = "RIGHT";
                directionCounter++;
                Global1.string1 = "Turn " + direction + " onto " + street1.ToUpper() + " street.";
            }
            if (d2 == "l" && directionCounter == 1)
            {
                direction = "LEFT";
                directionCounter++;
                Global1.string2 = "Turn " + direction + " into your HOME.";
            }
            else if (d2 == "r" && directionCounter == 1)
            {
                direction = "RIGHT";
                directionCounter++;
                Global1.string2 = "Turn " + direction + " into your HOME.";
            }
            return Global1.string1 + " " + Global1.string2;
        }
    }
}
