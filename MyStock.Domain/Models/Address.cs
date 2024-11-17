namespace MyStock.Domain.Models
{
    public class Address
    {
        public int CompanyId { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public int PostalCode { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
