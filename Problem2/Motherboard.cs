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
    /// This is the Motherboard Class.It has a private static readonly instance, a private constructor, and 
    /// a public GetInstance method.  
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        /// The private static instance for the Motherboard Class.To be used in GetInstance method.
        /// </summary>
        private static readonly Motherboard _instance = new Motherboard();

        /// <summary>
        /// The private constructor in accordance with the singleton pattern.
        /// </summary>
        private Motherboard()
        {
        }

        /// <summary>
        /// The GetInstance method for the Motherboard Class. It returns the instance 
        /// of the Motherboard.
        /// </summary>
        /// <returns></returns>
        public static Motherboard GetInstance()
        {
            return _instance;
        }
        /// <summary>
        /// 
        /// </summary>
        [Range(2,4)]
        public int NumberOfMemorySlots { get; set; }
        /// <summary>
        /// Power Consumption in Watts, makes sense to be an int
        /// </summary>
        public int PowerConsumption { get; set; }
        /// <summary>
        /// Number of PCI slots, again only int makes sense.
        /// A smaller form factor may only have ~3 pci slots total(pciexpx4,x8,x16),
        /// while an ATX mobo can have as many as 7 at the most.
        /// </summary>
        /// 
        [Range(2, 4)]
        public int NumberOfPCISlots { get; set; }
        /// <summary>
        /// For the Form factors while there are many in existance, most
        /// are obsolete and there are three main ones: ATX, miniATX and microATX
        /// </summary>
        public enum FormFactors
        {
            ATX,
            miniATX,
            microATX
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public string DriveType(FormFactors types) =>
        types switch
        {
            FormFactors.ATX => new String("ATX"),
            FormFactors.miniATX => new String("miniATX"),
            FormFactors.microATX => new String("microATX"),
            _ => throw new ArgumentException(message: "invalid FormFactor value(ATX, miniATX,or microATX)", paramName: nameof(types)),
        };
        /// <summary>
        /// 
        /// </summary>
        public string FormFactor { get; set; }
        /// <summary>
        /// Hard drive limit shjould be an int, and the range is based on
        /// my experience with computers and the oldest ones can still support 
        /// at least two harddrives, most having many sata ports so with newer
        /// better boards the number could be much higher.
        /// </summary>
        [Range(2,12)]
        public int HardDriveLimit { get; set; }
        /// <summary>
        /// Th CPU object that is in the Motherboard
        /// </summary>
        public CPU CPU { get; set; }
        /// <summary>
        /// The Memory object that is in the Motherboard
        /// </summary>
        public Memory Memory { get; set; }
        /// <summary>
        /// The GraphicsCard object that is in the Motherboard
        /// </summary>
        public GraphicsCard GraphicsCard { get; set; }
    }
}
