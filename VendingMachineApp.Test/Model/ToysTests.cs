using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineApp.Model;
using System.Diagnostics;

namespace VendingMachineApp.Test.Model
{
    public class ToysTests
    {
        [Fact]
        public void ExamineAndUse()
        {
            Toys rubicscube = new Toys(5, "Rubic's cube", 0, false, "Rubik's Cube is a 3D combination puzzle invented in 1974 by Hungarian sculptor and professor of architecture Ernő Rubik", "Twist and turn in enternity", 40);
            Debug.Print(rubicscube.Use());
            Debug.Print(rubicscube.Examine());

            Toys woodenblocks = new Toys(5, "Wooden blocks", 0, false, "They’re nothing but natural wood, which means our babies can drool on them as much as they want with no concern for toxins", "Play with these daily, the creative potential is near endless", 40);

            Assert.NotEqual(rubicscube.Use().Length, rubicscube.Examine().Length);
            Assert.NotEqual(woodenblocks.Use().Length, woodenblocks.Examine().Length);
        }
    }
}