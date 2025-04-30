using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.carousel-control-previous</c>
/// </summary>
public partial class CarouselPreviousButton
{
	[CascadingParameter(Name = "CarouselId")]
	private string ParentId { get; set; } = string.Empty;

	/// <inheritdoc />
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("carousel-control-prev");
	}
}

