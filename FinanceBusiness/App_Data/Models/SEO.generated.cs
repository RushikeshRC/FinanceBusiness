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
	// Mixin Content Type with alias "sEO"
	/// <summary>SEO</summary>
	public partial interface ISEO : IPublishedContent
	{
		/// <summary>Page description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		global::System.Web.IHtmlString PageDescription { get; }
	}

	/// <summary>SEO</summary>
	[PublishedModel("sEO")]
	public partial class SEO : PublishedContentModel, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const string ModelTypeAlias = "sEO";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SEO, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SEO(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Page description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("pageDescription")]
		public virtual global::System.Web.IHtmlString PageDescription => GetPageDescription(this);

		/// <summary>Static getter for Page description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static global::System.Web.IHtmlString GetPageDescription(ISEO that) => that.Value<global::System.Web.IHtmlString>("pageDescription");
	}
}
