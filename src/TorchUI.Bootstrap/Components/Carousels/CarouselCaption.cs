using Microsoft.AspNetCore.Components;
using TorchUI.Bootstrap.Extensions;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.carousel-caption</c>
/// </summary>
public class CarouselCaption : TorchComponentBase
{
	/// <summary>
	/// The breakpoint on which to hide the caption
	/// </summary>
	[Parameter]
	public Breakpoint? HideOn { get; set; }

	/// <summary>
	/// The breakpoint on which to show the caption
	/// </summary>
	[Parameter]
	public Breakpoint? ShowOn { get; set; }

	/// <inheritdoc/>
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("carousel-caption");

		if (HideOn is not null)
		{
			CssBuilder.AddClass(HideOn.Value.GetBreakpointDisplayClass("none"));
		}

		if (ShowOn is not null)
		{
			CssBuilder.AddClass(ShowOn.Value.GetBreakpointDisplayClass("block"));
		}
	}
}
