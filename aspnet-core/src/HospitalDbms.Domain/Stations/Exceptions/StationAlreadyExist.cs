using Volo.Abp;

namespace HospitalDbms.Stations.Exceptions;

public class SationAlreadyExistsException : BusinessException
{
  public SationAlreadyExistsException(string name)
    : base(StationConstants.StationAlreadyExist)
  {
      WithData("name", name);
  }
}