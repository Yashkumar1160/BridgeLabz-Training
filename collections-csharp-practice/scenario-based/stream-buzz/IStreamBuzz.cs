using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.stream_buzz
{
    internal interface IStreamBuzz
    {
        //method to register creator
        void RegisterCreator(CreatorStats record);

        //method to get top post counts
        Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold);

        //method to calculate average likes
        double CalculateAverageLikes();
    }
}
