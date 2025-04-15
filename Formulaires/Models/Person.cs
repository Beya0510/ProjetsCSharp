namespace Formulaires.Models
{
    public class Personne
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public bool IsSubscribed { get; set; }
    }
}