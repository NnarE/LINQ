using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverview
{
    class Program
    {
        static void Main()
        {

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;


            //IEnumerable<int> highScoresQuery =
            //              from score in scores
            //              where score > 80
            //              orderby score descending
            //              select score;

            //        IEnumerable<string> highScoresQuery2 =
            //from score in scores
            //where score > 80
            //orderby score descending
            ////select $"The score is {score}";

            //int highScoreCount =
            //               (from score in scores
            //                where score > 80
            //               select score)
            //               .Count();


         //   IEnumerable<int> highScoresQuery3 =
         //            from score in scores
         //                where score > 80
         //                select score;

         //int scoreCount = highScoresQuery3.Count();


            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }


    }
}

