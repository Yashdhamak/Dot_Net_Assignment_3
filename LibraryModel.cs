using LibraryApi.Entities;

namespace LibraryApi.Models
{
    public class LibraryModel
    {
        public Book Book { get; set; }
        public Member Member { get; set; }
        public Issue Issue { get; set; }
    }
}
