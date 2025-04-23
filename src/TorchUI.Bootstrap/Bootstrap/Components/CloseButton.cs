using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap;

/// <summary>
/// Represents a Bootstrap <c>.btn-close</c>
/// </summary>
public class CloseButton : TorchComponentBase
{
	/// <summary>
	/// The ARIA label to describe the button. Defaults to "Close".
	/// </summary>
	/// <remarks>
	/// This value will not override an existing <c>aria-label</c> attribute.
	/// </remarks>
	[Parameter]
	public string Label { get; set; } = "Close";

	/// <inheritdoc />
	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		Tag = "button";
		CssBuilder.AddClass("btn-close");
		UserAttributes.TryAdd("aria-label", Label);

		BuildHtml(builder);
	}
}