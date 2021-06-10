// InHousePart.cs
// Definites the derived InHousePart class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosteC968Task
{
    // Derived class InHousePart
    public class InHousePart : Part
    {
        public int MachineID { get; set; }

        // Constructor

        public InHousePart(int partID, string name, decimal price, int inStock, int partMin, int partMax, int machineID) : base (partID, name, price, inStock, partMin, partMax)

        {
            MachineID = machineID;
        }
    }
}
