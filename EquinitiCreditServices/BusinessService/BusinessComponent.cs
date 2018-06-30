﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EquinitiCreditServices.Models;
using Newtonsoft.Json;

namespace EquinitiCreditServices.BusinessService
{
    public class BusinessComponent : IBusinessComponent
    {
        
        
        /// <summary>
        /// To reterive all the Credit Service List
        /// </summary>
        /// <returns></returns>
        public List<CreditServiceModel> GetCreditServiceModelList()
        {
            List<CreditServiceModel> creditServiceModel = null;

            string CreditJson = @"[{'Id': '3f2b12b8-2a06-45b4-b057-45949279b4e5','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 58.26,'PostingDate': '2016-07-01T00:00:00','IsCleared': true,'ClearedDate': '2016-07-02T00:00:00'},
                                   {'Id': 'd2032222-47a6-4048-9894-11ab8ebb9f69','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 50.09,'PostingDate': '2016-08-01T00:00:00','IsCleared': true,'ClearedDate': '2016-08-02T00:00:00'},
                                   {'Id': 'd8f156f3-bd57-49c3-9dcb-fcaaa52308f5','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 59.43,'PostingDate': '2016-09-01T00:00:00','IsCleared': true,'ClearedDate': '2016-09-02T00:00:00'},
                                   {'Id': '194f0d46-6b87-4b59-a73c-e543f035ae1a','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 58.39,'PostingDate': '2016-10-01T00:00:00','IsCleared': true,'ClearedDate': '2016-10-02T00:00:00'},
                                   {'Id': 'ba67f438-c016-473d-93f8-373ca5a80567','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 57.55,'PostingDate': '2016-11-01T00:00:00','IsCleared': true,'ClearedDate': '2016-11-02T00:00:00'},
                                   {'Id': 'f37dd903-f833-4bd2-9350-81b0e947d9ad','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 51.23,'PostingDate': '2016-12-01T00:00:00','IsCleared': true,'ClearedDate': '2016-12-02T00:00:00'},
                                   {'Id': 'fcd0ab16-9ccc-4a24-825b-d11c283c2d58','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 59.03,'PostingDate': '2017-01-01T00:00:00','IsCleared': true,'ClearedDate': '2017-01-02T00:00:00'},
                                   {'Id': 'b2874279-04e3-480e-9670-c4d4d3ed8a43','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 51.51,'PostingDate': '2016-07-01T00:00:00','IsCleared': true,'ClearedDate': '2016-07-02T00:00:00'},
                                   {'Id': 'fc099e30-6629-4015-a9e8-91edf442d69e','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 59.10,'PostingDate': '2016-08-01T00:00:00','IsCleared': true,'ClearedDate': '2016-08-02T00:00:00'},
                                   {'Id': '5f19429f-3ab8-41b1-b058-66b1ff0f46bc','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 53.73,'PostingDate': '2016-09-01T00:00:00','IsCleared': true,'ClearedDate': '2016-09-02T00:00:00'},
                                   {'Id': '53f931be-6f8e-44ea-913f-051aa2cc7b6e','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 52.07,'PostingDate': '2016-10-01T00:00:00','IsCleared': true,'ClearedDate': '2016-10-02T00:00:00'},
                                   {'Id': '66d28c93-3002-4816-b65c-f4777152faaa','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 52.86,'PostingDate': '2016-11-01T00:00:00','IsCleared': true,'ClearedDate': '2016-11-02T00:00:00'},
                                   {'Id': '7557e1e0-6a60-495e-9e4d-df9cf6cc4c00','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 53.82,'PostingDate': '2016-12-01T00:00:00','IsCleared': true,'ClearedDate': '2016-12-02T00:00:00'},
                                   {'Id': '0f6eb0a1-3e48-49b6-8990-705a962fb048','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 52.92,'PostingDate': '2017-01-01T00:00:00','IsCleared': true,'ClearedDate': '2017-01-02T00:00:00'},
                                   {'Id': '2ce5dfae-3e59-4074-9601-beace62af588','ApplicationId': 456299,'Type': 'Credit','Summary': 'Refund','Amount': 24.36,'PostingDate': '2017-01-19T00:00:00','IsCleared': true,'ClearedDate': '2017-01-20T00:00:00'},
                                   {'Id': '2b5192b3-61f6-4635-adba-69b1b3ff3718','ApplicationId': 456299,'Type': 'Credit','Summary': 'Refund','Amount': 8.62,'PostingDate': '2017-01-22T00:00:00','IsCleared': false,'ClearedDate': null},
                                   {'Id': '7a66f608-2979-4b79-ba2e-d9b4d573b294','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 95.11,'PostingDate': '2017-01-23T00:00:00','IsCleared': false,'ClearedDate': null}]";

            creditServiceModel = JsonConvert.DeserializeObject<List<CreditServiceModel>>(CreditJson);
            return creditServiceModel;
        }
        /// <summary>
        /// Get based on the ID 
        /// </summary>
        /// <param name="uniqueidentifier"></param>
        /// <returns></returns>
        public CreditServiceModel GetCreditServiceModelByID(Guid uniqueidentifier)
        {
            List<CreditServiceModel> creditServiceModel = null;

            string CreditJson = @"[{'Id': '3f2b12b8-2a06-45b4-b057-45949279b4e5','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 58.26,'PostingDate': '2016-07-01T00:00:00','IsCleared': true,'ClearedDate': '2016-07-02T00:00:00'},
                                   {'Id': 'd2032222-47a6-4048-9894-11ab8ebb9f69','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 50.09,'PostingDate': '2016-08-01T00:00:00','IsCleared': true,'ClearedDate': '2016-08-02T00:00:00'},
                                   {'Id': 'd8f156f3-bd57-49c3-9dcb-fcaaa52308f5','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 59.43,'PostingDate': '2016-09-01T00:00:00','IsCleared': true,'ClearedDate': '2016-09-02T00:00:00'},
                                   {'Id': '194f0d46-6b87-4b59-a73c-e543f035ae1a','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 58.39,'PostingDate': '2016-10-01T00:00:00','IsCleared': true,'ClearedDate': '2016-10-02T00:00:00'},
                                   {'Id': 'ba67f438-c016-473d-93f8-373ca5a80567','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 57.55,'PostingDate': '2016-11-01T00:00:00','IsCleared': true,'ClearedDate': '2016-11-02T00:00:00'},
                                   {'Id': 'f37dd903-f833-4bd2-9350-81b0e947d9ad','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 51.23,'PostingDate': '2016-12-01T00:00:00','IsCleared': true,'ClearedDate': '2016-12-02T00:00:00'},
                                   {'Id': 'fcd0ab16-9ccc-4a24-825b-d11c283c2d58','ApplicationId': 197104,'Type': 'Debit','Summary': 'Payment','Amount': 59.03,'PostingDate': '2017-01-01T00:00:00','IsCleared': true,'ClearedDate': '2017-01-02T00:00:00'},
                                   {'Id': 'b2874279-04e3-480e-9670-c4d4d3ed8a43','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 51.51,'PostingDate': '2016-07-01T00:00:00','IsCleared': true,'ClearedDate': '2016-07-02T00:00:00'},
                                   {'Id': 'fc099e30-6629-4015-a9e8-91edf442d69e','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 59.10,'PostingDate': '2016-08-01T00:00:00','IsCleared': true,'ClearedDate': '2016-08-02T00:00:00'},
                                   {'Id': '5f19429f-3ab8-41b1-b058-66b1ff0f46bc','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 53.73,'PostingDate': '2016-09-01T00:00:00','IsCleared': true,'ClearedDate': '2016-09-02T00:00:00'},
                                   {'Id': '53f931be-6f8e-44ea-913f-051aa2cc7b6e','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 52.07,'PostingDate': '2016-10-01T00:00:00','IsCleared': true,'ClearedDate': '2016-10-02T00:00:00'},
                                   {'Id': '66d28c93-3002-4816-b65c-f4777152faaa','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 52.86,'PostingDate': '2016-11-01T00:00:00','IsCleared': true,'ClearedDate': '2016-11-02T00:00:00'},
                                   {'Id': '7557e1e0-6a60-495e-9e4d-df9cf6cc4c00','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 53.82,'PostingDate': '2016-12-01T00:00:00','IsCleared': true,'ClearedDate': '2016-12-02T00:00:00'},
                                   {'Id': '0f6eb0a1-3e48-49b6-8990-705a962fb048','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 52.92,'PostingDate': '2017-01-01T00:00:00','IsCleared': true,'ClearedDate': '2017-01-02T00:00:00'},
                                   {'Id': '2ce5dfae-3e59-4074-9601-beace62af588','ApplicationId': 456299,'Type': 'Credit','Summary': 'Refund','Amount': 24.36,'PostingDate': '2017-01-19T00:00:00','IsCleared': true,'ClearedDate': '2017-01-20T00:00:00'},
                                   {'Id': '2b5192b3-61f6-4635-adba-69b1b3ff3718','ApplicationId': 456299,'Type': 'Credit','Summary': 'Refund','Amount': 8.62,'PostingDate': '2017-01-22T00:00:00','IsCleared': false,'ClearedDate': null},
                                   {'Id': '7a66f608-2979-4b79-ba2e-d9b4d573b294','ApplicationId': 456299,'Type': 'Debit','Summary': 'Payment','Amount': 95.11,'PostingDate': '2017-01-23T00:00:00','IsCleared': false,'ClearedDate': null}]";

            creditServiceModel = JsonConvert.DeserializeObject<List<CreditServiceModel>>(CreditJson);
            CreditServiceModel model = creditServiceModel.Where(n => n.Id == uniqueidentifier).FirstOrDefault<CreditServiceModel>();
            return model;
        }
        /// <summary>
        /// Update or save the Credit Service Model to database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool updateCreditServiceModel(CreditServiceModel model)
        {
            // Call the data access layer or edmx ORM model to save the model to the database
            return true;
        }

        /// <summary>
        /// delete the Credit Service Model to database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool deleteCreditServiceModel(Guid id)
        {
            // Call the data access layer or edmx ORM model to delete the data from the database
            return true;
        }

    }
}