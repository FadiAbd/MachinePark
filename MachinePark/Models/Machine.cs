using System.ComponentModel.DataAnnotations;

namespace MachinePark.Models
{
    public class Machine
    {
        public Machine()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            IsOnline = randomNumber == 0 ? false : true;
        }
        public int MachineId { get; set; }
        public bool IsOnline { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        public string? Description { get; set; }
        public string? Data { get; set; }
    }
}
