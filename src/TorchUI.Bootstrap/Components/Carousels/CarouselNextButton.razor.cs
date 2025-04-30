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

	protected override void OnInitialized()
	{
		CssBuilder.AddClass("carousel-control-next");
		base.OnInitialized();
	}
}

