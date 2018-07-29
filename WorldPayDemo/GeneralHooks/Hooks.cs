using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WorldPayDemo.GeneralHooks
{
    public class Hooks
    {   [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("BeforeTestRun");
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("BeforeFeature");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("AfterFeature");
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("AfterScenario");
        }
        
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("AfterTestRun");
        }
    }
}
