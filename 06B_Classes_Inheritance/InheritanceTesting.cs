
using _06B_Classes_Inheritance.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06B_Classes_Inheritance
{
    [TestClass]
    public class InheritanceTesting
    {
        //Arrange line 
        private Cat _cat;
        private TabbyCat _tabbyCat;
        private Liger _liger;
        private Sloth _sloth;
        private Megatherium _mSloth;
        private Dragon _dragon;

        [TestInitialize]
        public void Init()
        {
            _cat = new Cat();
            _tabbyCat = new TabbyCat();
            _liger = new Liger();
            _sloth = new Sloth();
            _mSloth = new Megatherium();
            _dragon = new Dragon();
        }

        [TestMethod]
        public void PlayGround_Cat()
        {
            //Methods trickle down
            _cat.MakeSound();
            _cat.Move();

            //So do properties:
            _cat.ClawLength = 22.2d;

            //I got this from Animal
            _cat.IsMammal = true;
            _cat.DietType = DietType.Herbivore;
        }

        [TestMethod]
        public void Playground_TabbyCat()
        {
            _tabbyCat.MakeSound();
        }

        [TestMethod]
        public void Playground_Liger()
        {
            _liger.Move();
            _liger.MakeSound();
        }

        [TestMethod]
        public void Playground_Sloth()
        {
            _sloth.MakeSound();
            _sloth.Move();

            _mSloth.Move();
            _mSloth.MakeSound();
        }

        [TestMethod]
        public void Playground_Dragon()
        {
            _dragon.DietType = DietType.Herbivore;
            _dragon.Eat(_liger);

            Dragon drag = new Dragon(false, false, true, DietType.Herbivore);
            Console.WriteLine(drag.HasFur);
            Console.WriteLine(drag.IsKiller);
            Console.WriteLine(drag.DietType);
        }
    }
}
