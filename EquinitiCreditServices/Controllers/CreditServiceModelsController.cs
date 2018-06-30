using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using EquinitiCreditServices.Models;
using Microsoft.Data.OData;

namespace EquinitiCreditServices.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using EquinitiCreditServices.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<CreditServiceModel>("CreditServiceModels");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class CreditServiceModelsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/CreditServiceModels
        public IHttpActionResult GetCreditServiceModels(ODataQueryOptions<CreditServiceModel> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<IEnumerable<CreditServiceModel>>(creditServiceModels);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/CreditServiceModels(5)
        public IHttpActionResult GetCreditServiceModel([FromODataUri] System.Guid key, ODataQueryOptions<CreditServiceModel> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<CreditServiceModel>(creditServiceModel);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/CreditServiceModels(5)
        public IHttpActionResult Put([FromODataUri] System.Guid key, Delta<CreditServiceModel> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(creditServiceModel);

            // TODO: Save the patched entity.

            // return Updated(creditServiceModel);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/CreditServiceModels
        public IHttpActionResult Post(CreditServiceModel creditServiceModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(creditServiceModel);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/CreditServiceModels(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] System.Guid key, Delta<CreditServiceModel> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(creditServiceModel);

            // TODO: Save the patched entity.

            // return Updated(creditServiceModel);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/CreditServiceModels(5)
        public IHttpActionResult Delete([FromODataUri] System.Guid key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
