using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Drake_Boswell
{
    internal class Car
    {
        // This is a backing field for the Model property.
        private string model;
        // This is a property with a backing field. It allows us to control how the model is accessed and modified.
        public string Model { get { return model; } set { model = value; } }
        // This is an auto-implemented property. It does not require a backing field.
        public string Make { get; set; }
    }
}