using EquinitiCreditServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquinitiCreditServices.BusinessService
{
    public interface IBusinessComponent
    {
        List<CreditServiceModel> GetCreditServiceModelList();
        CreditServiceModel GetCreditServiceModelByID(Guid uniqueidentifier);

        bool updateCreditServiceModel(CreditServiceModel model);
        bool deleteCreditServiceModel(Guid id);

    }
}
