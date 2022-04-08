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
    /// This is the class for the computer case.  It has a private static readonly instance, a private constructor, and 
    /// a public GetInstance method.  
    /// </summary>
    public class Case
    {
        /// <summary>
        /// The private static instance for the Case Class.To be used in GetInstance method.
        /// </summary>
        private static readonly Case _instance = new Case();

        /// <summary>
        /// The private constructor in accordance with the singleton pattern.
        /// </summary>
        private Case()
        {
        }

        /// <summary>
        /// The GetInstance method for the Case Class. It returns the instance 
        /// of the Case.
        /// </summary>
        /// <returns></returns>
        public static Case GetInstance()
        {
            return _instance;
        }
        /// <summary>
        /// Based on the researching specified max/min length of
        /// the different form factors range was determined. in inches
        /// (Most often referred to as depth in measurements)
        /// </summary>
        [Range(14,24)]
        public double Length { get; set; }
        /// <summary>
        /// Based on the researching specified max/min Width (in inches)
        /// of the different form factors range was determined.
        /// </summary>
        [Range(7.5, 12)]
        public double Width { get; set; }
        /// <summary>
        /// Based on the researching specified max/min length of
        /// the different form factors range was determined
        /// </summary>
        [Range(6, 24)]
        public double Height { get; set; }
        /// <summary>
        /// Int makes sense for number of fans, which range
        /// from as low as 3 to as many as 8(in my desktop can mount)
        /// case fans specifically.
        /// </summary>
        [Range(3, 8)]
        public int NumberOfFans { get; set; }
        /// <summary>
        /// Number of vents depend largely on the case and its purpose,
        /// whether good airflow is a priority or low noise. In pre builts 
        /// the lowest number i can imagine is 3: one behind PSU, one in front and 
        /// one in the back/top/bottom.
        /// </summary>
        [Range(3,12)]
        public int NumberOfVents { get; set; }

    }
}
