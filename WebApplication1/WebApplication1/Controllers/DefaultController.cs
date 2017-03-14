using BusinessLogic.Services;
using BusinessLogic.Services.Base;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Default;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        ISchemeService _schemeService;

        public DefaultController()
        {
            _schemeService = new SchemeService();
        }
       
        public ActionResult Index()
        {

            ViewBag.SchemeListInJSON = _schemeService.GetSchemeListInJSON();
            ViewBag.SchemePartsListInJSON = _schemeService.GetSchemePartListInJSON();

            return View();
        }

        public ActionResult Get()
        {
            return Json(_schemeService.GetSchemeList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult EditPart(EditPartCountModel model)
        {
            _schemeService.EditPartCount(model.schemePartId, model.newCount);

            return Json(_schemeService.GetSchemePartList());
        }
    }
}