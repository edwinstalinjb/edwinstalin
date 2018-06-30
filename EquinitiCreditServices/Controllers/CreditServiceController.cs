using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using EquinitiCreditServices.Models;
using EquinitiCreditServices.Providers;
using EquinitiCreditServices.Results;
using EquinitiCreditServices.BusinessService;

namespace EquinitiCreditServices.Controllers
{
    [Authorize]
    [RoutePrefix("api/Service")]
    public class CreditServiceController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private IBusinessComponent _businessComponent;
        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }
        public CreditServiceController()
        {
            
        }
        public CreditServiceController(BusinessComponent businessComponent)
        {
            _businessComponent = businessComponent;
        }

        public CreditServiceController(ApplicationUserManager userManager,
            ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
            UserManager = userManager;
            AccessTokenFormat = accessTokenFormat;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        #region
        [AllowAnonymous]
        [HttpGet]
        [Route("GetCreditCardServiceInfo")]
        public List<CreditServiceModel> GetCreditCardInfo()
        {
            BusinessComponent _businessComp = new BusinessComponent();
            return _businessComp.GetCreditServiceModelList();
            //return _businessComponent.GetCreditServiceModelList();
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("GetCreditCardServiceInfoByID")]
        public CreditServiceModel GetCreditCardInfoByID(Guid Id)
        {
            BusinessComponent _businessComp = new BusinessComponent();
            return _businessComp.GetCreditServiceModelByID(Id);
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("SaveCreditCardServiceInfo")]
        public bool UpdateCreditCardInfo(CreditServiceModel model)
        {
            BusinessComponent _businessComp = new BusinessComponent();
            return _businessComp.updateCreditServiceModel(model);
            //return _businessComponent.updateCreditServiceModel(model);
        }
        /// <summary>
        /// We can allow authorssie to delete the data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpDelete]
        [Route("DeleteCreditCardServiceInfo")]
        public bool DeleteCreditCardServiceInfo(Guid Id)
        {
            BusinessComponent _businessComp = new BusinessComponent();
            return _businessComp.deleteCreditServiceModel(Id);
            //return _businessComponent.deleteCreditServiceModel(Id);
        }
        #endregion
    }
}
