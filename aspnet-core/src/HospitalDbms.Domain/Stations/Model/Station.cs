using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace HospitalDbms.Stations.Model;

public class Station: AuditedAggregateRoot<Guid>{
  public string StationName { get; private set; }

  internal Station(Guid id, string stationName): base(id)
  {
    SetStationName(stationName);
  }

  internal Station ChangeStationName([NotNull] string stationName){
    SetStationName(stationName);
    return this;
  }

  private void SetStationName([NotNull] string name){
    StationName = Check.NotNullOrEmpty(
      name,
      nameof(name),
      maxLength: StationConstants.MaximumNameLength
    );
  }
}