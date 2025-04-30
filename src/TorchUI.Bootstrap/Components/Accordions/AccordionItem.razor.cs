using System;
using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.accordion-item</c>
/// </summary>
public partial class AccordionItem
{
	private string _id = string.Empty;
	private readonly string _fallbackId = Guid
		.NewGuid()
		.ToString();

	/// <summary>
	/// The content to render in place of the <c>.accordion-header</c> content
	/// </summary>
	/// <remarks>
	/// If the <see cref="Header"/> is provided, you must also provide the <c>.accordion-header</c> wrapper!
	/// </remarks>
	[Parameter]
	public RenderFragment<(string Id, bool Show)>? Header { get; set; }

	/// <summary>
	/// The content to render in place of the <c>.accordion-collapse</c> content
	/// </summary>
	/// <remarks>
	/// <para>
	/// If the <see cref="Content"/> is provided, you must also provide the <c>.accordion-collapse</c> wrapper and <c>.accordion-body</c> content!
	/// </para>
	/// <para>
	/// If the parent accordion has its <c>AlwaysShow</c> parameter set to <see langword="true"/>, the <c>ParentId</c> tuple member will be <see langword="null"/>.
	/// </para>
	/// </remarks>
	[Parameter]
	public RenderFragment<(string Id, string? ParentId, bool Show)>? Content { get; set; }

	/// <summary>
	/// The title of the accordion item
	/// </summary>
	[Parameter]
	public string? Title { get; set; }

	/// <summary>
	/// Whether this accordion item should show its content by default
	/// </summary>
	[Parameter]
	public bool Show { get; set; }

	/// <summary>
	/// The ID of the parent accordion
	/// </summary>
	[CascadingParameter(Name = "AccordionId")]
	public string? AccordionId { get; set; }

	/// <inheritdoc/>
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("accordion-item");
		_id = UserAttributes.TryGetValue("id", out var id)
			? id.ToString()!
			: _fallbackId;

		// The ID should be removed so it isn't added to the accordion wrapper
		UserAttributes.Remove("id");
	}

	private string CreateToggleButtonClasses()
	{
		const string baseClasses = "accordion-button";

		return Show
			? baseClasses
			: $"{baseClasses} collapsed";
	}

	private string CreateAccordionCollapseClasses()
	{
		const string baseClasses = "accordion-collapse collapse";
		return Show
			? $"{baseClasses} show"
			: baseClasses;
	}
}
