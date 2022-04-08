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
    /// This is the GraphicsCard Class. It has a private static readonly
    /// instance, a private constructor, and 
    /// a public GetInstance method.  
    /// </summary>
    public class GraphicsCard
    {
        /// <summary>
        /// The private static instance for the GraphicsCard Class.To be used in GetInstance method.
        /// </summary>
        private static readonly GraphicsCard _instance = new GraphicsCard();

        /// <summary>
        /// The private constructor in accordance with the singleton pattern. 
        /// </summary>
        private GraphicsCard()
        {
        }

        /// <summary>
        /// The GetInstance method for the GraphicsCard Class. It returns the instance 
        /// of the GraphicsCard.
        /// </summary>
        /// <returns></returns>
        public static GraphicsCard GetInstance()
        {
            return _instance;
        }
        /// <summary>
        /// Fans on graphics cards range from 1 to 3
        /// </summary>
        [Range(1, 3)]
        public int FanCount
        {
            get
            {
                return FanCount;
            }
            set
            {
                if (FanCount < 1)
                {
                    throw new ArgumentException(message: "Unrealistic Graphics Card Fan Count, must be at least 1, and less than or equal to 3");
                }
            }
        }
        /// <summary>
        /// Clock speed in MHz, ranges from 800-1860
        /// </summary>
        [Range(800, 1860)]
        public int Speed
        {
            get
            {
                return Speed;
            }
            set
            {
                if (Speed < 0)
                {
                    throw new ArgumentException(message: "Unrealistic GPU speed, must be greater than 800MHz, and less than or equal to 1860MHz");
                }
            }
        }
        /// <summary>
        /// Memory measured in GB.  Minimum is 512MB 
        /// max is 24GB(ex. 3090Ti).
        /// </summary>
        [Range(0.512,24)]
        public decimal VideoMemory
        {
            get
            {
                return VideoMemory;
            }
            set
            {
                if (VideoMemory < 0)
                {
                    throw new ArgumentException(message: "Unrealistic Video Memory, must be greater than 0.512GB, and less than or equal to 24GB");
                }
            }
        }
        /// <summary>
        /// The number of Cuda cores on card. Min value found to be
        /// 8(GeForce 205), and max being(at this point) the RTX 3090 
        /// having a whopping 10496 cuda cores.
        /// </summary>
        [Range(8,10496)]
        public int NumberOfCudaCores
        {
            get
            {
                return NumberOfCudaCores;
            }
            set
            {
                if (NumberOfCudaCores < 8)
                {
                    throw new ArgumentException(message: "Unrealistic Number of Cuda Cores provided, must be at least 8, and at the most 10469");
                }
            }
        }

    }
}
