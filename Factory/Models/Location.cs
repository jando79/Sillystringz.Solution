using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Location
  {
    public int LocationId { get; set; }
    [Required(ErrorMessage = "The machine's location can't be empty!")]
    public string LocationName { get; set; }
    public List<MachineLocation> JoinLocation { get; }
  }
}