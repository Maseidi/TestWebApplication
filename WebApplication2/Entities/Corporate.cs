namespace WebApplication2.Entities
{
    public class Corporate
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string? Name { get; set; }

        public string? NationalIdentity { get; set; }

        public DateTime Timestamp{ get; set; }

        public string? ModifiedBy { get; set; }

        public int RowVersion { get; set; }

    }
}
