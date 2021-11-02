using _06B_Classes_Inheritance.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static _06B_Classes_Inheritance.Animals.TabbyCat;

namespace _06B_Classes_Inheritance
{
    [TestClass]
    public class InheritanceTesting
    {
        //Arrange line
        private Cat _cat;
        private TabbyCat _tabbyCat;
        private Liger _liger;
        
        [TestInitialize]
        public void Init()
        {
            _cat = new Cat();
            _tabbyCat = new TabbyCat();
            _liger = new Liger();
        }
        [TestMethod]
        public void PlayGround_Cat()
        {
            //Methods trickle down
            _cat.MakeSound();
            _cat.Move();

            //So do Properties:
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
            _liger.MakeSound();
            _liger.Move();
        }
    }
}
