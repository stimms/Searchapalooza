using System;

namespace searchapalooza
{
    public class BuildingPermit
    {

        public string PermitNum { get; set; }
        public string StatusCurrent { get; set; }
        public DateTime? AppliedDate { get; set; }

        public DateTime? IssuedDate { get; set; }

        public DateTime? CompletedDate { get; set; }

        public string PermitType { get; set; }
        public string PermitTypeMapped { get; set; }
        public string PermitClass { get; set; }
        public string PermitClassGroup { get; set; }
        public string PermitClassMapped { get; set; }
        public string WorkClass { get; set; }
        public string WorkClassGroup { get; set; }
        public string WorkClassMapped { get; set; }
        public string Description { get; set; }
        public string ContractorName { get; set; }
        public string HousingUnits { get; set; }
        public int? EstProjectCost { get; set; }
        public int? TotalSqFt { get; set; }
        public string OriginalAddress { get; set; }
        public string CommunityCode { get; set; }
        public string CommunityName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Location { get; set; }
        public int? LocationCount { get; set; }
        public string LocationTypes { get; set; }
        public string LocationAddresses { get; set; }
        public string LocationsWKT { get; set; }
        public string LocationsGeoJSON { get; set; }
    }
}
