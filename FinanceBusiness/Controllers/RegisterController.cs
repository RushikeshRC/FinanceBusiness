using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using System.Web.Mvc;
using FinanceBusiness.Models;
using Umbraco.Web.Mvc;
using FinanceBusiness.ViewModels;
using System.Web.Security;
using Umbraco.Web.PublishedModels;

namespace FinanceBusiness.Controllers
{
    public class RegisterController : SurfaceController
    {
       private IMemberService _memberServices ;

       public RegisterController() 
       {
            _memberServices = Services.MemberService;
       }

        public ActionResult MemberRegistration()
        {
            return PartialView("MemberRegistration", new RegisterViewModel());
        }

        // POST: Register/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitRegistration(RegisterViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                //var member = new CustomMember();

                IMember newMember = _memberServices
                    .CreateMember(model.Email, model.Email, model.Name, Register.ModelTypeAlias);

                //sets the value in custom member
                newMember.SetValue("customAddress", model.Address);

                //saves the member in umbraco
                _memberServices.Save(newMember);
                //saves the password
                _memberServices.SavePassword(newMember, model.Password);

                //assign role to member(Member ID, Role Name)
                _memberServices.AssignRole(newMember.Id, model.SelectedRole);

                Roles.GetAllRoles();
                
            }
            return CurrentUmbracoPage();
        }



        public ActionResult MemberLogin()
        {
            return PartialView("~/Views/Partials/_Login.cshtml", new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLogin(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username,false);
                    UrlHelper urlhelper = new UrlHelper(HttpContext.Request.RequestContext);

                    if (urlhelper.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    else
                        return Redirect("/");
                }
                else
                {
                    ModelState.AddModelError("", "The username or password is invalid.");
                }
            }
            return CurrentUmbracoPage();
        }

        public ActionResult MemberLogout()
        {
            return PartialView("_Logout", null);
        }

        public ActionResult SubmitLogout()
        {
            TempData.Clear();
            Session.Clear();
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }     
}