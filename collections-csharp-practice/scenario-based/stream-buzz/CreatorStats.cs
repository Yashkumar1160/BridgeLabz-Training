using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.stream_buzz
{
    internal class CreatorStats
    {
        //property to store creator name
        public string CreatorName { get; set; }

        //property to store weekly likes
        public double[] WeeklyLikes { get; set; }

        //list to store all creators
        public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();
    }
}
