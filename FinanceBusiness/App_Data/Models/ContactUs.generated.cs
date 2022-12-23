//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.18.5
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Contact Us</summary>
	[PublishedModel("contactUs")]
	public partial class ContactUs : PublishedContentModel, ICarousal, IContentBase, IFormControl, IOpenGraphTags, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const string ModelTypeAlias = "contactUs";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactUs, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContactUs(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("email")]
		public virtual string Email => this.Value<string>("email");

		///<summary>
		/// Email Info
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("emailInfo")]
		public virtual global::System.Web.IHtmlString EmailInfo => this.Value<global::System.Web.IHtmlString>("emailInfo");

		///<summary>
		/// Google Map
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("googleMap")]
		public virtual global::Umbraco.Web.Models.Link GoogleMap => this.Value<global::Umbraco.Web.Models.Link>("googleMap");

		///<summary>
		/// Location
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("location")]
		public virtual global::Umbraco.Web.Models.Link Location => this.Value<global::Umbraco.Web.Models.Link>("location");

		///<summary>
		/// Location Info
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("locationInfo")]
		public virtual global::System.Web.IHtmlString LocationInfo => this.Value<global::System.Web.IHtmlString>("locationInfo");

		///<summary>
		/// Ph Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("phDescription")]
		public virtual global::System.Web.IHtmlString PhDescription => this.Value<global::System.Web.IHtmlString>("phDescription");

		///<summary>
		/// Phone Numbar
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("phoneNumbar")]
		public virtual string PhoneNumbar => this.Value<string>("phoneNumbar");

		///<summary>
		/// Interval: Set the time interval for the slides in carousal
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("interval")]
		public virtual int Interval => global::Umbraco.Web.PublishedModels.Carousal.GetInterval(this);

		///<summary>
		/// Slides: Number of slides in the carousal
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("slides")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.Banner> Slides => global::Umbraco.Web.PublishedModels.Carousal.GetSlides(this);

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("content")]
		public virtual global::Newtonsoft.Json.Linq.JToken Content => global::Umbraco.Web.PublishedModels.ContentBase.GetContent(this);

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::Umbraco.Web.PublishedModels.ContentBase.GetPageTitle(this);

		///<summary>
		/// Form Picker
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("formPicker")]
		public virtual object FormPicker => global::Umbraco.Web.PublishedModels.FormControl.GetFormPicker(this);

		///<summary>
		/// Form Sub Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("formSubTitle")]
		public virtual string FormSubTitle => global::Umbraco.Web.PublishedModels.FormControl.GetFormSubTitle(this);

		///<summary>
		/// Form Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("formTitle")]
		public virtual string FormTitle => global::Umbraco.Web.PublishedModels.FormControl.GetFormTitle(this);

		///<summary>
		/// OG Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("oGDescription")]
		public virtual string OGdescription => global::Umbraco.Web.PublishedModels.OpenGraphTags.GetOGdescription(this);

		///<summary>
		/// OG Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("oGLink")]
		public virtual global::Umbraco.Web.Models.Link OGlink => global::Umbraco.Web.PublishedModels.OpenGraphTags.GetOGlink(this);

		///<summary>
		/// OG Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("oGTitle")]
		public virtual string OGtitle => global::Umbraco.Web.PublishedModels.OpenGraphTags.GetOGtitle(this);

		///<summary>
		/// Page description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("pageDescription")]
		public virtual global::System.Web.IHtmlString PageDescription => global::Umbraco.Web.PublishedModels.SEO.GetPageDescription(this);
	}
}