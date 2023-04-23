namespace PARCIAL-MARTIN-TABORDA.Models;

public Class ClimbingRoute {

    public int Id { get; set;}
    public string LocationName {get;set;}
    public string SectorName {get;set;}
    public string RouteName {get; set;}
    public int Bolts {get; set;}
    public ClimbingRouteStatus Status {get; set;} 

}
