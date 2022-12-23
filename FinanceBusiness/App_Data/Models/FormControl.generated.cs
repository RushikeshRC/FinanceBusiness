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
	// Mixin Content Type with alias "formControl"
	/// <summary>Form Control</summary>
	public partial interface IFormControl : IPublishedContent
	{
		/// <summary>Form Picker</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		object FormPicker { get; }

		/// <summary>Form Sub Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		string FormSubTitle { get; }

		/// <summary>Form Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		string FormTitle { get; }
	}

	/// <summary>Form Control</summary>
	[PublishedModel("formControl")]
	public partial class FormControl : PublishedContentModel, IFormControl
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const string ModelTypeAlias = "formControl";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<FormControl, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public FormControl(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Form Picker
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("formPicker")]
		public virtual object FormPicker => GetFormPicker(this);

		/// <summary>Static getter for Form Picker</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static object GetFormPicker(IFormControl that) => that.Value("formPicker");

		///<summary>
		/// Form Sub Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("formSubTitle")]
		public virtual string FormSubTitle => GetFormSubTitle(this);

		/// <summary>Static getter for Form Sub Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static string GetFormSubTitle(IFormControl that) => that.Value<string>("formSubTitle");

		///<summary>
		/// Form Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		[ImplementPropertyType("formTitle")]
		public virtual string FormTitle => GetFormTitle(this);

		/// <summary>Static getter for Form Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.5")]
		public static string GetFormTitle(IFormControl that) => that.Value<string>("formTitle");
	}
}