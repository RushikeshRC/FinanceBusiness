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
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, ICardComponent, ICarousal, ICompanyStats, IContentBase, IFormControl, IMainServices, IMembers, IOpenGraphTags, IPartnerContainer, ISEO, ITestimonialGallery
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Company Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("companyName")]
		public virtual string CompanyName => this.Value<string>("companyName");

		///<summary>
		/// Component Sub Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("componentSubtitle")]
		public virtual string ComponentSubtitle => this.Value<string>("componentSubtitle");

		///<summary>
		/// Component Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("componentTitle")]
		public virtual string ComponentTitle => this.Value<string>("componentTitle");

		///<summary>
		/// CTA Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("ctaLink")]
		public virtual global::Umbraco.Web.Models.Link CtaLink => this.Value<global::Umbraco.Web.Models.Link>("ctaLink");

		///<summary>
		/// CTA Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("ctaText")]
		public virtual string CtaText => this.Value<string>("ctaText");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("description")]
		public virtual string Description => this.Value<string>("description");

		///<summary>
		/// Social 3 Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("description2")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.LinkItems> Description2 => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.LinkItems>>("description2");

		///<summary>
		/// Section 3 Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("description3")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> Description3 => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("description3");

		///<summary>
		/// Mobile Number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("mobileNumber")]
		public virtual int MobileNumber => this.Value<int>("mobileNumber");

		///<summary>
		/// Nav Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("navLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> NavLinks => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("navLinks");

		///<summary>
		/// Req Container Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("reqContainerSubtitle")]
		public virtual string ReqContainerSubtitle => this.Value<string>("reqContainerSubtitle");

		///<summary>
		/// Req Container Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("reqContainerTitle")]
		public virtual string ReqContainerTitle => this.Value<string>("reqContainerTitle");

		///<summary>
		/// Section 1 Logos
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("section1Logos")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.LinkItems> Section1Logos => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.LinkItems>>("section1Logos");

		///<summary>
		/// Services Tiles
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("serviceTiles")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ServiceTile> ServiceTiles => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ServiceTile>>("serviceTiles");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("title")]
		public virtual string Title => this.Value<string>("title");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("title2")]
		public virtual string Title2 => this.Value<string>("title2");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("title3")]
		public virtual string Title3 => this.Value<string>("title3");

		///<summary>
		/// Working Hours
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("workingHours")]
		public virtual string WorkingHours => this.Value<string>("workingHours");

		///<summary>
		/// Card CTA Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("cardCTAButton")]
		public virtual string CardCtabutton => global::Umbraco.Web.PublishedModels.CardComponent.GetCardCtabutton(this);

		///<summary>
		/// Card CTA Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("cardCTALink")]
		public virtual global::Umbraco.Web.Models.Link CardCtalink => global::Umbraco.Web.PublishedModels.CardComponent.GetCardCtalink(this);

		///<summary>
		/// Card Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("cardDescription")]
		public virtual string CardDescription => global::Umbraco.Web.PublishedModels.CardComponent.GetCardDescription(this);

		///<summary>
		/// Card Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("cardImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops CardImage => global::Umbraco.Web.PublishedModels.CardComponent.GetCardImage(this);

		///<summary>
		/// Card Sub Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("cardSubTitle")]
		public virtual string CardSubTitle => global::Umbraco.Web.PublishedModels.CardComponent.GetCardSubTitle(this);

		///<summary>
		/// Card Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("cardTitle")]
		public virtual string CardTitle => global::Umbraco.Web.PublishedModels.CardComponent.GetCardTitle(this);

		///<summary>
		/// Image Position
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("imagePosition")]
		public virtual bool ImagePosition => global::Umbraco.Web.PublishedModels.CardComponent.GetImagePosition(this);

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
		/// Background Image: choose the background image here
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statBackgroundImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops StatBackgroundImage => global::Umbraco.Web.PublishedModels.CompanyStats.GetStatBackgroundImage(this);

		///<summary>
		/// Description: The Description about the company statistics
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statDescription")]
		public virtual global::System.Web.IHtmlString StatDescription => global::Umbraco.Web.PublishedModels.CompanyStats.GetStatDescription(this);

		///<summary>
		/// Statistics Tiles
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statisticsTiles")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.StatisticTile> StatisticsTiles => global::Umbraco.Web.PublishedModels.CompanyStats.GetStatisticsTiles(this);

		///<summary>
		/// Sub Title: Enter the Sub Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statSubTitle")]
		public virtual string StatSubTitle => global::Umbraco.Web.PublishedModels.CompanyStats.GetStatSubTitle(this);

		///<summary>
		/// Title: Enter the Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statTitle")]
		public virtual string StatTitle => global::Umbraco.Web.PublishedModels.CompanyStats.GetStatTitle(this);

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
		/// Partners Logos
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("partnersLogos")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.LogoElement> PartnersLogos => global::Umbraco.Web.PublishedModels.PartnerContainer.GetPartnersLogos(this);

		///<summary>
		/// Page description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("pageDescription")]
		public virtual global::System.Web.IHtmlString PageDescription => global::Umbraco.Web.PublishedModels.SEO.GetPageDescription(this);

		///<summary>
		/// Testimonials: Enter the number of slides
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("Tslides")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.Testimonial> Tslides => global::Umbraco.Web.PublishedModels.TestimonialGallery.GetTslides(this);

		///<summary>
		/// Sub Title: Enter the sub title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("TsubTitle")]
		public virtual string TsubTitle => global::Umbraco.Web.PublishedModels.TestimonialGallery.GetTsubTitle(this);

		///<summary>
		/// Title: Enter the Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("Ttitle")]
		public virtual string Ttitle => global::Umbraco.Web.PublishedModels.TestimonialGallery.GetTtitle(this);
	}
}
