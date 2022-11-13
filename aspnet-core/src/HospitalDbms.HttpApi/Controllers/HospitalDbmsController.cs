using HospitalDbms.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HospitalDbms.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HospitalDbmsController : AbpControllerBase
{
    protected HospitalDbmsController()
    {
        LocalizationResource = typeof(HospitalDbmsResource);
    }
}
