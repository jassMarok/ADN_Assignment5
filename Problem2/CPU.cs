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
    /// This is the CPU class. It has a private static readonly instance, a private constructor, and 
    /// a public GetInstance method.  
    /// </summary>
    public class CPU
    {
        /// <summary>
        /// The private static instance for the CPU Class.To be used in GetInstance method.
        /// </summary>
        private static readonly CPU _instance = new CPU();

        /// <summary>
        /// The private constructor in accordance with the singleton pattern.
        /// </summary>
        private CPU()
        {
        }

        /// <summary>
        /// The GetInstance method for the CPU Class. It returns the instance 
        /// of the CPU.
        /// </summary>
        /// <returns></returns>
        public static CPU GetInstance()
        {
            return _instance;
        }
        /// <summary>
        /// CPU clock speed in GHz. Minimum that i found nowadays was around 1.6Ghz,
        /// Max that i found was 5.2 boost clock(without overclocking).
        /// </summary>
        [Range(1.6, 5.2)]
        public double Speed
        {
            get
            {
                return Speed;
            }
            set
            {
                if (Speed < 0)
                {
                    throw new ArgumentException(message: "Unrealistic CPU speed, must be greater than 1.6, and less than 5.2");
                }
            }
        }
        /// <summary>
        /// enum for manufaturers, to make sure the user only can enter Intel or AMD
        /// </summary>
        public enum Manufacturers
        {
            AMD,
            INTEL
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public string Manufacturer(Manufacturers types) =>
        types switch
        {
            Manufacturers.AMD => new String("AMD"),
            Manufacturers.INTEL => new String("Intel"),
            _ => throw new ArgumentException(message: "invalid DriveType value(must be AMD or Intel)", paramName: nameof(types)),
        };

        /// <summary>
        /// Socket types vary often, and there are very many in exstance.
        /// eg.(AM4, LGA 1151,etc.)
        /// </summary>
        public string SocketType { get; set; }
        /// <summary>
        /// The cache size can vary greatly, but its size is typically between 256KB to 8MB.
        /// This will then be measured in MB, so a decimal datatype will be used.
        /// </summary>
        [Range(0.256, 8)]
        public decimal CacheSize {
            get
            {
                return CacheSize;
            }
            set
            {
                if (CacheSize < 0)
                {
                    throw new ArgumentException(message: "Unrealistic Cache size, must be greater than 0.256MB, and less than 8MB");
                }
            }
            /// <summary>
            /// The number of cores is dependent on the fact that this is a desktop CPU,
            /// not one from a supercomputer(which can have many more cores).  Most modern 
            /// CPUS have at least 2, max 64(at this point), but there may still be some 
            /// single core CPUs in existance.
            /// </summary>
            [Range(1, 64)]
        public int NumberOfCores
        {
            get
            {
                return NumberOfCores;
            }
            set
            {
                if (NumberOfCores < 1)
                {
                    throw new ArgumentException(message: "Unrealistic Number of  CPU Cores, must be greater than 1, and less than 64");
                }
            }
        }
    }
}
