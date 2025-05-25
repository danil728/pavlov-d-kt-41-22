using pavlov_d_kt_41_22.Models;

namespace pavlov_d_kt_41_22.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

    }
}
