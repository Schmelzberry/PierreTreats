namespace TreatTracker.Models
{
  public class FlavorTreat
  {
    public int FlavorTreatId { get; set; }
    // FK #1 & Reference Property
    public int FlavorId { get; set; }
    public Flavor Flavor { get; set; }
    // FK #2 & Reference Property
    public int TreatId { get; set; }
    public Treat Treat { get; set; }
  }
}