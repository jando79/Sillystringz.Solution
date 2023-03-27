using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "No machines have been added yet!")]
    public string MachineName { get; set; }
    public int LocationId { get; set; }
    
    public Location Location { get; set; }
    public Engineer Engineer { get; set; }
    public List<MachineLocation> JoinLocation { get; }
    public List<EngineerMachine> JoinEngineer { get; } 
  }
}
