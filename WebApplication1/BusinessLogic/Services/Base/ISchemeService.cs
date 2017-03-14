using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Base
{
    public interface ISchemeService
    {
        string GetSchemeListInJSON();
        IEnumerable<SchemeDTO> GetSchemeList();
        string GetSchemePartListInJSON();
        IEnumerable<SchemePartsDTO> GetSchemePartList();
        void EditPartCount(int schemePartId, int newCount);
    }
}
