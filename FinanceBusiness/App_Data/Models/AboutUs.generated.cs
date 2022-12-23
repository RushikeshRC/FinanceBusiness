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
	/// <summary>About Us</summary>
	[PublishedModel("aboutUs")]
	public partial class AboutUs : PublishedContentModel, ICardComponent, ICarousal, ICompanyStats, IContentBase, IOpenGraphTags, ISEO, ITestimonialGallery
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const string ModelTypeAlias = "aboutUs";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AboutUs, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public AboutUs(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Team Component Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("teamComponentHeading")]
		public virtual global::System.Web.IHtmlString TeamComponentHeading => this.Value<global::System.Web.IHtmlString>("teamComponentHeading");

		///<summary>
		/// Team Component SubHeading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("teamComponentSubHeading")]
		public virtual string TeamComponentSubHeading => this.Value<string>("teamComponentSubHeading");

		///<summary>
		/// Team Members
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("teamMembers")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent> TeamMembers => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>>("teamMembers");

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
