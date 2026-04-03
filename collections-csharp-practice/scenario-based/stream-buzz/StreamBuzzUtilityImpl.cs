    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.stream_buzz
{
    internal class StreamBuzzUtilityImpl : IStreamBuzz 
    {
        //method to register creator
        public void RegisterCreator(CreatorStats record)
        {
            //add record to list
            CreatorStats.EngagementBoard.Add(record);
        }

        //method to get top post counts
        public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
        {
            //dictionary to store result
            Dictionary<string, int> result = new Dictionary<string, int>();

            //loop through creators
            foreach (CreatorStats creator in records)
            {
                int count = 0;

                //loop through weekly likes
                foreach (double likes in creator.WeeklyLikes)
                {
                    //check threshold
                    if (likes >= likeThreshold)
                    {
                        count++;
                    }
                }

                //add to result if count > 0
                if (count > 0)
                {
                    result.Add(creator.CreatorName, count);
                }
            }

            return result;
        }

        //method to calculate average likes
        public double CalculateAverageLikes()
        {
            double totalLikes = 0;
            int totalWeeks = 0;

            //loop through creators
            foreach (CreatorStats creator in CreatorStats.EngagementBoard)
            {
                //loop through weekly likes
                foreach (double likes in creator.WeeklyLikes)
                {
                    totalLikes += likes;
                    totalWeeks++;
                }
            }

            //return average
            return totalLikes / totalWeeks;
        }
    }
}
