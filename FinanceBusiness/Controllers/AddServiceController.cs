using FinanceBusiness.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Services;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;


namespace FinanceBusiness.Controllers
{
    public class AddServiceController : Controller
    {
        private IContentService _contentService { get; set; }
        private readonly IMediaService _mediaService;

        public AddServiceController(IContentService contentService, IMediaService mediaService){
            _contentService = contentService;
            _mediaService = mediaService;
        }

        // GET: AddService
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(AddServiceViewModel model)
        {
            

            Guid allServicesNodeGuid = Guid.Parse("96d15757-6e4d-4ef1-ab6b-5b31b014d2d9");
            var newService = _contentService.Create(model.ServiceName, allServicesNodeGuid, Services.ModelTypeAlias);

            newService.SetValue("serviceName", model.ServiceName);
            newService.SetValue("serviceDescriptionShort", model.ShortServiceDesc);
            newService.SetValue("serviceDescriptionLong", model.LongServiceDesc);

            Image imageMedia = SaveImageMedia(model.ServiceImg);
        }

        private Image SaveImageMedia(HttpPostedFileBase xyz)
        {
            

            throw new NotImplementedException();
        }
    }
}