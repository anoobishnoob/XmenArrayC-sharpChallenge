using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 6, 12, 15, 17, 13, 2, 9, 8, 13 };

            string result = "";

            int smallNumIn = 0;
            int largeNumIn = 0;



            for (int i = 0; i < names.Length; i++)
            {
                //this assigns the largeest number in array
                if (numbers[i] > numbers[largeNumIn])
                {
                    largeNumIn = i;
                }
               // this assigns the smallest number in array
                if (numbers[i] < numbers[smallNumIn])
                {
                    smallNumIn = i;
                }
            }
            
            result = String.Format("Most battles belong to: {0} (Value: {1})", names[largeNumIn], numbers[largeNumIn]);
            result += String.Format("<br />Least battles belong to: {0} (Value: {1})", names[smallNumIn], numbers[smallNumIn]);

            resultLabel.Text = result;


            /*if (names[i] == "Professor X")
            {
                result = String.Format("{0} is at index {1} in the list.", names[i], i);
                break;
            }*/
        }

        
    }
}