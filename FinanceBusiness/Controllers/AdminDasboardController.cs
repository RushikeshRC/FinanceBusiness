using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Core.Services;
using System.Web.Security;
using Umbraco.Core.Models;
using FinanceBusiness.ViewModels;


//using Umbraco.Web.PublishedModels;

namespace FinanceBusiness.Controllers
{
    public class AdminDashboardController : SurfaceController
    {
        [HttpPost]
        public ActionResult DisplayMember(AdminModel adminModel)
        {

            IEnumerable<IMember> list = Services.MemberService.GetAllMembers().
            Where(member =>
                 Roles.GetRolesForUser(member.Username).Any()
            );

            //Any(role => role.Equals(adminModel.Role))

            ViewBag.memberList = list;
            
            return CurrentUmbracoPage();
        }
    }
}