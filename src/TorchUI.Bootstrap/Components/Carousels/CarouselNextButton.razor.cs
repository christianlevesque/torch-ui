using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.carousel-control-next</c>
/// </summary>
public partial class CarouselNextButton
{
	[CascadingParameter(Name = "CarouselId")]
	private string ParentId { get; set; } = string.Empty;

	/// <inheritdoc />
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("carousel-control-next");
	}
}

