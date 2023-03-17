using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The engineers name can't be empty!")]
    public string EngineerName { get; set; }
    public DateTime? Appointment { get; set; }
    public List<Machine> Machine { get; set; }
    public List<EngineerMachine> JoinEngineer { get; }
  }
}