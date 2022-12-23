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
	// Mixin Content Type with alias "companyStats"
	/// <summary>Company Stats</summary>
	public partial interface ICompanyStats : IPublishedContent
	{
		/// <summary>Background Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		global::Umbraco.Core.Models.MediaWithCrops StatBackgroundImage { get; }

		/// <summary>Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		global::System.Web.IHtmlString StatDescription { get; }

		/// <summary>Statistics Tiles</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.StatisticTile> StatisticsTiles { get; }

		/// <summary>Sub Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		string StatSubTitle { get; }

		/// <summary>Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		string StatTitle { get; }
	}

	/// <summary>Company Stats</summary>
	[PublishedModel("companyStats")]
	public partial class CompanyStats : PublishedContentModel, ICompanyStats
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const string ModelTypeAlias = "companyStats";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CompanyStats, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public CompanyStats(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Background Image: choose the background image here
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statBackgroundImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops StatBackgroundImage => GetStatBackgroundImage(this);

		/// <summary>Static getter for Background Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static global::Umbraco.Core.Models.MediaWithCrops GetStatBackgroundImage(ICompanyStats that) => that.Value<global::Umbraco.Core.Models.MediaWithCrops>("statBackgroundImage");

		///<summary>
		/// Description: The Description about the company statistics
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statDescription")]
		public virtual global::System.Web.IHtmlString StatDescription => GetStatDescription(this);

		/// <summary>Static getter for Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static global::System.Web.IHtmlString GetStatDescription(ICompanyStats that) => that.Value<global::System.Web.IHtmlString>("statDescription");

		///<summary>
		/// Statistics Tiles
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statisticsTiles")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.StatisticTile> StatisticsTiles => GetStatisticsTiles(this);

		/// <summary>Static getter for Statistics Tiles</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.StatisticTile> GetStatisticsTiles(ICompanyStats that) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.StatisticTile>>("statisticsTiles");

		///<summary>
		/// Sub Title: Enter the Sub Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statSubTitle")]
		public virtual string StatSubTitle => GetStatSubTitle(this);

		/// <summary>Static getter for Sub Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static string GetStatSubTitle(ICompanyStats that) => that.Value<string>("statSubTitle");

		///<summary>
		/// Title: Enter the Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("statTitle")]
		public virtual string StatTitle => GetStatTitle(this);

		/// <summary>Static getter for Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static string GetStatTitle(ICompanyStats that) => that.Value<string>("statTitle");
	}
}
