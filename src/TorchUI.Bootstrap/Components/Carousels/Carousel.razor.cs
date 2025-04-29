using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

public partial class Carousel
{
	private readonly List<CarouselItem> _carouselItems = [];
	private string _id = string.Empty;

	/// <summary>
	/// The autoplay interval for carousel slides, in milliseconds
	/// </summary>
	[Parameter]
	public int Interval { get; set; }

	/// <summary>
	/// Whether to suppress automatic rendering of slide indicators
	/// </summary>
	/// <remarks>
	/// If the <see cref="Indicators"/> <see cref="RenderFragment"/> is supplied, this parameter has no effect.
	/// </remarks>
	[Parameter]
	public bool DisableIndicators { get; set; }

	/// <summary>
	/// Whether to disable touch swiping
	/// </summary>
	[Parameter]
	public bool DisableTouchSwiping { get; set; }

	/// <summary>
	/// Whether to disable keyboard events
	/// </summary>
	[Parameter]
	public bool DisableKeyboard { get; set; }

	/// <summary>
	/// Whether to disable pausing autoplay on <c>mouseenter</c>
	/// </summary>
	[Parameter]
	public bool DisablePauseOnHover { get; set; }

	/// <summary>
	/// Whether to disable carousel wrapping
	/// </summary>
	[Parameter]
	public bool DisableWrap { get; set; }

	/// <summary>
	/// Whether to animate slide transitions with a crossfade
	/// </summary>
	[Parameter]
	public bool Fade { get; set; }

	/// <summary>
	/// Whether to autoplay the carousel
	/// </summary>
	[Parameter]
	public bool Autoplay { get; set; }

	/// <summary>
	/// Whether to autoplay the carousel after the first user interaction
	/// </summary>
	[Parameter]
	public bool AutoplayOnInteract { get; set; }

	/// <summary>
	/// Custom indicator content
	/// </summary>
	[Parameter]
	public RenderFragment? Indicators { get; set; }

	/// <summary>
	/// Custom control content
	/// </summary>
	[Parameter]
	public RenderFragment? Controls { get; set; }

	public void AddCarouselItem(CarouselItem item)
	{
		_carouselItems.Add(item);
		StateHasChanged();
	}

	/// <inheritdoc />
	protected override void OnInitialized()
	{
		_id = GetOrSetAttribute(
			"id",
			Guid.NewGuid().ToString());
		CssBuilder.AddClass("carousel slide");
		CssBuilder.AddClass("carousel-fade", Fade);

		if (Interval > 0)
		{
			UserAttributes["data-bs-interval"] = Interval;
		}

		if (Autoplay)
		{
			UserAttributes["data-bs-ride"] = "carousel";
		}
		else if (AutoplayOnInteract)
		{
			UserAttributes["data-bs-ride"] = "true";
		}

		if (DisableTouchSwiping)
		{
			UserAttributes["data-bs-touch"] = "false";
		}

		if (DisableKeyboard)
		{
			UserAttributes["data-bs-keyboard"] = "false";
		}

		if (DisablePauseOnHover)
		{
			UserAttributes["data-bs-pause"] = "false";
		}

		if (DisableWrap)
		{
			UserAttributes["data-bs-wrap"] = "false";
		}

		base.OnInitialized();
	}
}