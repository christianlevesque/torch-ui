using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap carousel indicator button
/// </summary>
public class CarouselIndicator : TorchComponentBase
{
	/// <summary>
	/// The ARIA label
	/// </summary>
	/// <remarks>
	/// This falls back to <c>"Slide {Index}"</c> if not supplied.
	/// </remarks>
	[Parameter]
	public string? Label { get; set; }

	/// <summary>
	/// The index of the slide which this indicator activates
	/// </summary>
	[Parameter]
	public int Index { get; set; }

	/// <summary>
	/// Whether the linked slide is currently active
	/// </summary>
	[Parameter]
	public bool Active { get; set; }

	[CascadingParameter(Name = "CarouselId")]
	private string ParentId { get; set; } = string.Empty;

	public CarouselIndicator() => Tag = "button";

	/// <inheritdoc />
	protected override void SetupAttributes()
	{
		UserAttributes["data-bs-target"] = $"#{ParentId}";
		UserAttributes["data-bs-slide-to"] = Index;
		UserAttributes["aria-label"] = string.IsNullOrEmpty(Label)
			? $"Slide {Index}"
			: Label;

		if (Active)
		{
			CssBuilder.AddClass("active");
			UserAttributes["aria-current"] = "true";
		}
	}
}