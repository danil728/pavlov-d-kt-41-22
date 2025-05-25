using pavlov_d_kt_41_22.Models;

namespace pavlov_d_kt_41_22.Models
{
    public class Load
    {
        public int Id { get; set; }
        public int Hours { get; set; } // Часы нагрузки

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public int DisciplineId { get; set; }
        public Discipline? Discipline { get; set; }

    }
}
