namespace SalesCRMApp.Models
{
    public class SalesLeadEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Phone { get; set; }

        public string Email { get; set; }

        public string Source { get; set; }

    }
}
