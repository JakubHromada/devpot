//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
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
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin Content Type with alias "heroControls"
	/// <summary>Hero Controls</summary>
	public partial interface IHeroControls : IPublishedContent
	{
		/// <summary>Hero Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string HeroHeader { get; }

		/// <summary>Hero Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		Image HeroImage { get; }

		/// <summary>Hero Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string HeroSubtitle { get; }
	}

	/// <summary>Hero Controls</summary>
	[PublishedModel("heroControls")]
	public partial class HeroControls : PublishedContentModel, IHeroControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "heroControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HeroControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HeroControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Hero Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("heroHeader")]
		public string HeroHeader => GetHeroHeader(this);

		/// <summary>Static getter for Hero Header</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetHeroHeader(IHeroControls that) => that.Value<string>("heroHeader");

		///<summary>
		/// Hero Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("heroImage")]
		public Image HeroImage => GetHeroImage(this);

		/// <summary>Static getter for Hero Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static Image GetHeroImage(IHeroControls that) => that.Value<Image>("heroImage");

		///<summary>
		/// Hero Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("heroSubtitle")]
		public string HeroSubtitle => GetHeroSubtitle(this);

		/// <summary>Static getter for Hero Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetHeroSubtitle(IHeroControls that) => that.Value<string>("heroSubtitle");
	}
}