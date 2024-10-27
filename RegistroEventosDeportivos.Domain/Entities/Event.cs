
namespace RegistroEventosDeportivos.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        
        public List<Athlete> Athletes { get; set; } = new List<Athlete>();
    }
}

