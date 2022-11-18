using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalDbms.Stations.Model;
using Volo.Abp.Domain.Repositories;

namespace HospitalDbms.Stations.Interface;

public interface IStationRepository: IRepository<Station,Guid>{

  Task<Station> FindByNameAsync(string stationName);

  Task<List<Station>> GetListAsync(
    int skipCount,
    int maxResultCount,
    string sorting,
    string filter = null
  );
}