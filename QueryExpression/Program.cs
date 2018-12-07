using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpression
{
    class Program
    {
        static void Main()
        {
            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Query Expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
                where score > 80 // optional
                orderby score descending // optional
                 select score; //must end with select or group

            //examples are not query variables because they store results

            //int highestScore =
            //                (from score in scores
            //                 select score)
            //                .Max();

            //// or split the expression
            //IEnumerable<int> scoreQuery =
            //    from score in scores
            //    select score;

            //int highScore = scoreQuery.Max();
            //// the following returns the same result
            //int highScore = scores.Max();

            //List<City> largeCitiesList =
            //    (from country in countries
            //     from city in country.Cities
            //     where city.Population > 10000
            //     select city)
            //       .ToList();

            //// or split the expression
            //IEnumerable<City> largeCitiesQuery =
            //    from country in countries
            //    from city in country.Cities
            //    where city.Population > 10000
            //    select city;

            //List<City> largeCitiesList2 = largeCitiesQuery.ToList();

            // Execute the query to produce the results
            foreach (int testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }
        }
    }
}
