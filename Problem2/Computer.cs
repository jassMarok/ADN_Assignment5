using System;
///-------------Statement of authorship--------------------
/// I, Matt Beattie, 000308498 certify that this material is my original work.
/// No other person's work has been used without due
/// acknowledgement.
///
namespace Problem2
{

    /// <summary>
    /// This is the Computer Class.
    /// It has a private static readonly instance, a private constructor, and 
    /// a public GetInstance method.  It has 6 properties: HarDrive, MotherBoard(which contains 
    /// the CPU, Memory and GraphicsCard), and Case.  
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// The private static instance varible for the Computer Class.To be used in GetInstance method.
        /// </summary>
        private static readonly Computer _instance = new Computer();

        /// <summary>
        /// The private constructor in accordance with the singleton pattern.
        /// My instinct is to stick the properties in but in my research everything 
        /// said it would violate the design pattern.
        /// </summary>
        private Computer()
        {
        }

        /// <summary>
        /// The GetInstance method for the Computer Class. It returns the instance 
        /// of the Computer.
        /// </summary>
        /// <returns></returns>
        public static Computer GetInstance()
        {
            return _instance;
        }
        
        public HardDrive HardDrive { get; set; }
        /// <summary>
        /// Motherboard contains CPU, memory and graphics card
        /// </summary>
        public Motherboard Motherboard { get; set; }
        /// <summary>
        /// A computer has a Case.
        /// </summary>
        public Case Case { get; set; }
    }
}
