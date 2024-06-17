using MachinePark.Components.Pages;
using Microsoft.AspNetCore.Hosting.Server;

namespace MachinePark.Models
{
    public  static class MachinesRepository 
    {
        private static List<Machine> machines = new List<Machine>()
        {
            new Machine {MachineId = 1, Name = "Machine1", City = "London", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 2, Name = "Machine2", City = "London", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 3, Name = "Machine3", City = "London", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 4, Name = "Machine4", City = "London", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 5, Name = "Machine5", City = "NewYork", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 6, Name = "Machine6", City = "NewYork", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 7, Name = "Machine7", City = "NewYork", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 8, Name = "Machine8", City = "Rom", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 9, Name = "Machine9", City = "Rom", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 10, Name = "Machine10", City = "Paris", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 11, Name = "Machine11", City = "Paris", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 12, Name = "Machine12", City = "Stockholm", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 13, Name = "Machine13", City = "Stockholm", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 14, Name = "Machine14", City = "Stockholm", Description = "Drill machine", Data = "Drilling now"},
            new Machine {MachineId = 15, Name = "Machine15", City = "Stockholm", Description = "Drill machine", Data = "Drilling now"},

        };
        

        public static void AddMachine(Machine machine)
        {
            var maxId = machines.Max(x => x.MachineId);
            machine.MachineId = maxId ;
            machines.Add(machine);
        }


        public static List<Machine> GetMachines() => machines;

        public static List<Machine> GetMachineByCity(string cityName)
        {
            return machines.Where(s => s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static Machine? GetMachineById(int machineId)
        {
            var machine = machines.FirstOrDefault(s => s.MachineId == machineId);
            if (machine != null)
            {
                return new Machine
                {
                    MachineId = machine.MachineId,
                    Name = machine.Name,
                    City = machine.City,
                    Description = machine.Description,
                    Data = machine.Data,
                    IsOnline = machine.IsOnline,
                };
            }
            return null;
        }

        public static void UpdateMachine(int machineId, Machine machine)
        {
            if (machineId != machine.MachineId) return;
            var machineToUpdate = machines.FirstOrDefault(s => s.MachineId == machineId);
            if (machineToUpdate != null)
            {
                machineToUpdate.IsOnline = machine.IsOnline;
                machineToUpdate.Name = machine.Name;
                machineToUpdate.City = machine.City;
            }
        }

        public static void DeleteMachine(int machineId)
        {
            var machine = machines.FirstOrDefault(s => s.MachineId == machineId);
            if (machine != null)
            {
                machines.Remove(machine);
            }
        }
         
        public static List<Machine> SearchMachines(string machineFilter)
        {
            return machines.Where(s => s.Name.Contains(machineFilter, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        
    }
}
