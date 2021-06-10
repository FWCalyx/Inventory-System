// OutsourcedPart.cs
// Defines the derived class OutsourcedPart.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosteC968Task
{
    class OutsourcedPart : Part
    {
        public string CompanyName { get; set; }

        // Constructor

        public OutsourcedPart(int partID, string name, decimal price, int inStock, int partMin, int partMax, string companyName) : base(partID, name, price, inStock, partMin, partMax)

        {
            CompanyName = companyName;
        }

    }
}
