namespace Project1.Models
{
    public class Products
    {
        public int Id { get; set; }

        //Customer Information
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;

        public DateTime DOB { get; set; }
        public string Address { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public string ZipCode { get; set; } = String.Empty;


        //Create a drop down list for brands
        public string Brand { get; set; }

        //Information for contacts Right Eye
        public string Sphere { get; set; } = String.Empty;
        public string Cylinder { get; set; } = String.Empty;
        public double Axis { get; set; }

        public double BaseCurve { get; set; }
        public double Dia { get; set; }

        //Left Eye Contacts lens information change the name to so an error will not appear
        public string Sph { get; set; } = String.Empty;
        public string Cyl { get; set; } = String.Empty;
        public double axis1 { get; set; }
        public double BC { get; set; }
        public double Diameter { get; set; }
        public int Qty { get; set; }
        public Products()
        {

        }
    }
}
