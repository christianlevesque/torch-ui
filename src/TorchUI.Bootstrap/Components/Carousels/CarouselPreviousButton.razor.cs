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

	protected override void OnInitialized()
	{
		CssBuilder.AddClass("carousel-control-prev");
		base.OnInitialized();
	}
}

