using System;
///-------------Statement of authorship--------------------
/// I, Matt Beattie, 000308498 certify that this material is my original work.
/// No other person's work has been used without due
/// acknowledgement.
///
namespace Problem2
{
    
    /// <summary>
    /// 
    /// </summary>
    public class Computer
    {
        private static readonly Computer _instance = new Computer();

        private Computer()
        {
        }

        public static Computer GetInstance()
        {
            return _instance;
        }
        public HardDrive HardDrive { get; set; }
    }
}
