// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using AzureMobile.Samples.FieldEngineer.Service.Models;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Security;

namespace AzureMobile.Samples.FieldEngineer.Service.Controllers
{
    [AuthorizeLevel(AuthorizationLevel.User)]
    public class EquipmentSpecificationController : TableController<EquipmentSpecification>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            var context = new MobileServiceContext();
            this.DomainManager = new EntityDomainManager<EquipmentSpecification>(context, Request, Services);
        }

        public IQueryable<EquipmentSpecification> GetAllEquipmentSpecification()
        {
            return this.Query();
        }

        public SingleResult<EquipmentSpecification> GetEquipmentSpecification(string id)
        {
            return this.Lookup(id);
        }
    }
}