using Parcial_Martin_Taborda.Utils;
namespace Parcial_Martin_Taborda.Models;

public class ClimbingRoute
{
    public int Id { get; set;}
    
    public string? LocationName {get;set;}
    
    public string? SectorName {get;set;}
    
    public string? RouteName {get; set;}
    
    public string? Grade {get; set;}
    
    public int Bolts {get; set;}
    
    public RouteStatus Type {get; set;}
}
