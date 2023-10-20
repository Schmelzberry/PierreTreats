using System.Collections.Generic;

namespace TreatTracker.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public List <FlavorTreat> FlavorTreats { get; set; }
  }
}