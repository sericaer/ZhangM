using System;
using System.Linq;

namespace ZhangM
{
    public class Facade
    {
        public static IPerson player { get; private set; }

        public static IDate date { get; private set; }
        private static RunData runData { get; set; }

        public static void BuildRunData()
        {
            runData = new RunData();

            player = runData.personMgr.First();

            date = runData.date;
        }
    }
}
