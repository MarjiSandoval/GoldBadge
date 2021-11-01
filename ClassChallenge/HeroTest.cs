using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassChallenge
{
    [TestClass]
    public class HeroTest
    {
        [TestMethod]
        public void HeroClassTest()
        {
            Hero supe = new Hero("Superman", "Clark Kent", "Smallville", true, 95,
                58, 60);

            Console.WriteLine(supe.Power);
            Console.WriteLine(supe.HeroStatus(true));
            Console.WriteLine(supe.AveragePower());

            Hero flash = new Hero("The Flash", "Wally West", "Central City", true, 120, 70, 80);
            Console.WriteLine($"{flash.HeroStatus(true)}. His average power is {flash.AveragePower()}.");

        } 
    }
}
