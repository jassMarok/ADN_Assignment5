using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// This is the HardDrive Class.
    /// It has a private static readonly instance, a private constructor, and 
    /// a public GetInstance method.  
    /// </summary>
    public class HardDrive
    {

        /// <summary>
        /// The private static instance for the HardDrive Class.To be used in GetInstance method.
        /// </summary>
        private static readonly HardDrive _instance = new HardDrive();

        /// <summary>
        /// The private constructor in accordance with the singleton pattern.
        /// Everything i found said it would violate the singleton pattern to put 
        /// paramaters in the constructor....not sure where to pass them.
        /// </summary>
        private HardDrive()
        {
        }

        /// <summary>
        /// The GetInstance method for the HardDive Class. It returns the instance 
        /// of the HardDrive.
        /// </summary>
        /// <returns></returns>
        public static HardDrive GetInstance()
        {
            return _instance;
        }
        /// <summary>
        /// This is to specify the types allowed.
        /// </summary>
        public enum DriveTypes
        {
            SSD,
            HDD   
        }
        /// <summary>
        /// This works with the above code to ensure that only 
        /// the strings "SSD" and "HDD" will be accepted, otherwise will throw an exception.
        /// </summary>
        /// <param name="types">The enum Drivetypes from above</param>
        /// <returns></returns>
        public string DriveType(DriveTypes types) =>
        types switch
        {
            DriveTypes.SSD => new String("SSD"),
            DriveTypes.HDD => new String("HDD"),
            _ => throw new ArgumentException(message: "invalid DriveType value(must be SSD or HDD)",
                paramName: nameof(types)),
        };
        /// <summary>
        /// Capacity in GB, int is reasonable since capacity usually a whole number.
        /// Minimum is 80GB(for a sata drive) and max is 20TB which is 20000GB(Seagate IronWolf Pro)
        /// </summary>
        [Range(80,20000)]
        public int Capacity
        {
            get
            {
                return Capacity;
            }
            set
            {
                if (Capacity < 0)
                {
                    throw new ArgumentException(message: "Unrealistic Hard Drive capacity provided, " +
                        "must be greater than 80GB, and less than or equal to 20000GB");
                }
            }
        }
        /// <summary>
        /// Read Speed in MB/s. Max speed was 
        /// determined by fastest SSD(Samsung 870 Evo)
        /// min speed was lowest average harddrive speed.
        /// </summary>
        [Range(50, 3940)]
        public int ReadSpeed
        {
            get
            {
                return ReadSpeed;
            }
            set
            {
                if (ReadSpeed < 50)
                {
                    throw new ArgumentException(message: "Unrealistic Read Speed provided, must" +
                        " be greater than 50MB/s, and less than or equal to 3940MB/s");
                }
            }
        }
        /// <summary>
        /// Write Speed in MB/s. Max speed was 
        /// determined by fastest SSD(Samsung 870 Evo)
        /// min speed was lowest harddrive write speed found.
        /// </summary>
        [Range(15, 3372)]
        public int WriteSpeed
        {
            get
            {
                return WriteSpeed;
            }
            set
            {
                if (WriteSpeed < 15)
                {
                    throw new ArgumentException(message: "Unrealistic WriteSpeed provided," +
                        " must be greater than 15MB/s, and less than or equal to 3372MB/s");
                }
            }
        }

    }
}
