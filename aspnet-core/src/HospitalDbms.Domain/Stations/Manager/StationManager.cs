using System;
using System.Threading.Tasks;
using HospitalDbms.Stations.Exceptions;
using HospitalDbms.Stations.Interface;
using HospitalDbms.Stations.Model;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace HospitalDbms.Stations.Manager;

public class StationManager: DomainService{
  private readonly IStationRepository _stationRepository;
  public StationManager(IStationRepository stationRepository)
  {
    _stationRepository = stationRepository;
  }

  public async Task<Station> CreateAsync([NotNull] string stationName){
    Check.NotNullOrEmpty(stationName, nameof(stationName));
    var existingStation = await _stationRepository.FindByNameAsync(stationName);
    if (existingStation != null)
    {
        throw new SationAlreadyExistsException(stationName);
    }
    return new Station(
      GuidGenerator.Create(),
      stationName
    );
  }

  public async Task ChangeName(
    [NotNull] Station station,
    [NotNull] string newName
  ){
    Check.NotNull(station, nameof(station));
    Check.NotNullOrEmpty(newName, nameof(newName));

    var existingStationName = await _stationRepository.FindByNameAsync(newName);
    if(existingStationName !=null){
      throw new SationAlreadyExistsException(newName);
    }
    station.ChangeStationName(newName);
  }
}