using Microsoft.AspNetCore.Components.Rendering;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-img-overlay</c>
/// </summary>
public class CardImageOverlay : TorchComponentBase
{
	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		CssBuilder.AddClass("card-img-overlay");

		BuildHtml(builder);
	}
}
