using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreatTracker.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat's name can't be empty!")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "The flavor's name must be between 1 and 50 characters.")]
    public string Name { get; set; }
    public List <FlavorTreat> FlavorTreats { get; set; }
  }
}