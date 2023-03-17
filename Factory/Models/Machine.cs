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
    public bool IsComplete { get; set; } = false;
    public Location Location { get; set; }
    public Engineer Engineer { get; set; }
    public List<MachineLocation> JoinDepartment { get; }
    public List<EngineerMachine> JoinStudent { get; }
   
  }
}