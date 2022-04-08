using Problem2;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    //[TestClass] doesnt look test lib are installed, need to ask
    class UnitTestProblem2
    {
        //Not sure how to test in this pattern...or with this pattern...
        HardDrive hd = HardDrive.GetInstance();
        Motherboard mobo = Motherboard.GetInstance();
        Case computerCase = Case.GetInstance();

        Computer computer = Computer.GetInstance();
        // not sure how to create the computer... sorry if i had more time id figure this out
    }
}
