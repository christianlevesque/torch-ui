using System;
using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap;

/// <summary>
/// Represents a Bootstrap <c>.accordion</c>
/// </summary>
public partial class Accordion
{
	private string? _id;

	/// <summary>
	/// Whether to remove some borders and rounded corners. Corresponds to the Bootstrap <c>.accordion-flush</c> class
	/// </summary>
	[Parameter]
	public bool Flush { get; set; }

	/// <summary>
	/// Whether child accordion items should stay open even when another accordion item opens
	/// </summary>
	[Parameter]
	public bool AlwaysOpen { get; set; }

	/// <inheritdoc/>
	protected override void OnInitialized()
	{
		if (!AlwaysOpen)
		{
			_id = GetAttributeWithDefault(
				"id",
				Guid.NewGuid().ToString());
		}

		CssBuilder.AddClass("accordion");
		CssBuilder.AddClass("accordion-flush", Flush);

		base.OnInitialized();
	}
}
