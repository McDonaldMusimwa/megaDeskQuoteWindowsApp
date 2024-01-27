using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskTop
{
    internal class DeskQuote
    {
        public Desk Desk { get; set; }
        public double RushDaysCost { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public double BasePrice { get; set; } = 200.00;
        public double SurfaceArea { get; set; }
        public double SurfaceAreaCost { get; set; }
        public double SurfaceMaterialCost { get; set; }
        public double TotalCost { get; set; }
        public double drawertotalCost {get;set; }

        public DeskQuote(Desk desk)
        {
            Desk = desk;
     
            CalculateTotalCost(); // Calculate the total cost when creating the instance
        }

        private double CalculateSurfaceMaterialCost(string surfaceMaterial)
        {
            // Implement the logic to calculate surface material cost based on the surfaceMaterial parameter
            // For example, you might have a lookup table or switch statement
            // that assigns different costs for different surface materials.
            // This will depend on your application's requirements.
            // For now, let's assume a basic implementation.
            double materialCost = 0;
            surfaceMaterial = Desk.SurfaceMaterial;
            switch (surfaceMaterial)
            {
                case "oak":
                    materialCost = 200.0;
                    break;
                case "laminate":
                    materialCost = 100.0;
                    break;
                case "pine":
                    materialCost = 50.0;
                    break;
                case "rosewood":
                    materialCost = 300.0;
                    break;
                case "veneer":
                    materialCost = 125.0;
                    break;

                default:
                    materialCost = 200.0;
                    break;
            }

            return SurfaceMaterialCost = materialCost;
        }

        private double calculaterushDays(string rushdays)
        {
            SurfaceArea = Desk.Width * Desk.Depth;

            double rushdayscost = 0;
            switch (rushdays)
            {
                case "3":
                    if (SurfaceArea < 1000)
                    {
                        rushdayscost = 60.0;
                        break;
                    }else if (SurfaceArea > 1000 || SurfaceArea < 2000)
                    {
                        rushdayscost = 70.0;
                            break;
                    }else if(SurfaceArea > 2000)
                    {
                        rushdayscost = 80.0;
                        break;
                    }
                    break;
                case "5":
                    if (SurfaceArea < 1000)
                    {
                        rushdayscost = 40.0;
                        break;
                    }
                    else if (SurfaceArea > 1000 || SurfaceArea < 2000)
                    {
                        rushdayscost = 50.0;
                        break;
                    }
                    else if (SurfaceArea > 2000)
                    {
                        rushdayscost = 60.0;
                        break;
                    }
                    break;

                case "7":
                    if (SurfaceArea < 1000)
                    {
                        rushdayscost = 30.0;
                        break;
                    }
                    else if (SurfaceArea > 1000 || SurfaceArea < 2000)
                    {
                        rushdayscost = 35.0;
                        break;
                    }
                    else if (SurfaceArea > 2000)
                    {
                        rushdayscost = 40.0;
                        break;
                    }

                    break;
                default:
                    rushdayscost = 40.0;
                    break;


                    
            }
            return rushdayscost;
        }

        private double CalculateTotalCost()
        {
            // Calculate surface area based on Desk width and depth
            SurfaceArea = Desk.Width * Desk.Depth;

            // Calculate surface material cost based on Desk surface material
            SurfaceMaterialCost = CalculateSurfaceMaterialCost(Desk.SurfaceMaterial);
            RushDaysCost = calculaterushDays(Desk.RushOrder);
            drawertotalCost = CalculateDrawerCost();
            SurfaceAreaCost = CalculateSurfaceCost();
            CustomerName = setCustomerName();
            // Calculate total cost
            
             return TotalCost = BasePrice + SurfaceAreaCost + SurfaceMaterialCost + RushDaysCost+ drawertotalCost;
        }

        private double CalculateDrawerCost()
        {
            return  (Desk.DrawersNumber * 50);
        }

        private double CalculateSurfaceCost()
        {
            return SurfaceArea * 1;
        }

        private string setCustomerName()
        {
           return  Desk.CustomerName;
        }

    }
}
