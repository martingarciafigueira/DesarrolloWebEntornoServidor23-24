namespace Ejemplo.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }

}
