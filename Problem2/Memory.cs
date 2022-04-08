using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
/// <summary>
/// Statement of Authorship in the Computer.cs file
/// </summary>
namespace Problem2
{
    /// <summary>
    /// This is the Memory(RAM) Class.  It has a private static readonly instance,
    /// a private constructor, and a public GetInstance method.  
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// The private static instance for the Memory Class.To be used in GetInstance method.
        /// </summary>
        private static readonly Memory _instance = new Memory();

        /// <summary>
        /// The private constructor in accordance with the singleton pattern.
        /// </summary>
        private Memory()
        {
        }

        /// <summary>
        /// The GetInstance method for the Memory Class. It returns the instance 
        /// of the Memory.
        /// </summary>
        /// <returns></returns>
        public static Memory GetInstance()
        {
            return _instance;
        }
        /// <summary>
        /// Measured in MHz. Slowest for DDR1 found was 266MHz,
        /// fastest (to my understanding without overclocking) is 3200MHz atp.
        /// </summary>
        [Range(266,3200)]
        public double ReadSpeed
        {
            get
            {
                return ReadSpeed;
            }
            set
            {
                if (ReadSpeed < 0)
                {
                    throw new ArgumentException(message: "Unrealistic Read Speed of Memory(RAM) provided," +
                        "  must be at least 266Mhz , and less than or equal to 3200Mhz(without overlocking)");
                }
            }
        }
        /// <summary>
        /// Measured in MHz. Slowest for DDR1 found was 266MHz,
        /// fastest (to my understanding without overclocking) is 3200MHz atp.
        /// Couldnt find a difference of speeds with RAM in terms of read speed vs write speed 
        /// it would just give overall speed.
        /// </summary>
        [Range(266, 3200)]
        public double WriteSpeed
        {
            get
            {
                return WriteSpeed;
            }
            set
            {
                if (WriteSpeed < 0)
                {
                    throw new ArgumentException(message: "Unrealistic Write Speed of Memory(RAM) provided," +
                        "  must be at least 266Mhz , and less than or equal to 3200Mhz(without overlocking)");
                }
            }
        }
        /// <summary>
        /// For the Form factors while there are many in existance, most
        /// are obsolete and there are three main ones: ATX, miniATX and microATX
        /// </summary>
        public enum DDRType
        {
            DDR1,
            DDR2,
            DDR3,
            DDR4

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public string Type(DDRType types) =>
        types switch
        {
            DDRType.DDR1 => new String("DDR1"),
            DDRType.DDR2 => new String("DDR2"),
            DDRType.DDR3 => new String("DDR3"),
            DDRType.DDR4 => new String("DDR4"),
            _ => throw new ArgumentException(message: "invalid Memory Type value, must be " +
                "(DDR1, DDR2,DDR3, or DDR4)", paramName: nameof(types)),
        };
        /// <summary>
        /// The amount of RAM in GB.  Since DDR1 was included with the types 
        /// ill reach back to that point for the min amount(which is the max amount for DDR1: 512MB,
        /// the max amount ive researched has been 64GB(per module) so in theory with the best possible
        /// motherboard one could have ~256GB of ram..which i havent heard of being used or supported yet, 
        /// so I set the max to 128GB. The imergance of DDR5 will probably break that bottleneck.
        /// </summary>
        [Range(0.512, 128)]
        public decimal AmountInGB

        {
            get
            {
                return AmountInGB;
            }
            set
            {
                if (AmountInGB < 0)
                {
                    throw new ArgumentException(message: "Unrealistic Amount of Memory(RAM) provided," +
                        "  must be at least 0.512GB , and less than or equal to 128GB");
                }
            }
        }
        
    }
   
}
