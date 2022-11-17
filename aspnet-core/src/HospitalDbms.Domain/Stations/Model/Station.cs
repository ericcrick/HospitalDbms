using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalDbms.Stations.Model;

public class Station: AuditedAggregateRoot<Guid>{
  public string StationName { get; set; }
}