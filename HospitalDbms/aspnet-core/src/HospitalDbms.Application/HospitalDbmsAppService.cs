using System;
using System.Collections.Generic;
using System.Text;
using HospitalDbms.Localization;
using Volo.Abp.Application.Services;

namespace HospitalDbms;

/* Inherit your application services from this class.
 */
public abstract class HospitalDbmsAppService : ApplicationService
{
    protected HospitalDbmsAppService()
    {
        LocalizationResource = typeof(HospitalDbmsResource);
    }
}
