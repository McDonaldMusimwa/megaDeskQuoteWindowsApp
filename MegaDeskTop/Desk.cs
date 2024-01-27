using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskTop
{
    public class Desk
    {
        public string CustomerName { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public int DrawersNumber { get; set; }
        public string SurfaceMaterial { get; set; }
        public string RushOrder { get; set; }

        public Desk()
        {
            // Initializing default values
            CustomerName = string.Empty;
            Width = 0.0;
            Depth = 0.0;
            DrawersNumber = 0;
            SurfaceMaterial = string.Empty;
            RushOrder = "";
        }
    }
}
