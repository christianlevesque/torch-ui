using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap;

/// <summary>
/// Represents a Bootstrap <c>.btn-group</c>
/// </summary>
public class ButtonGroup : TorchComponentBase
{
	/// <summary>
	/// The ARIA label to describe the button group
	/// </summary>
	/// <remarks>
	/// This value will not override an existing <c>aria-label</c> attribute.
	/// </remarks>
	[Parameter]
	public string? Label { get; set; }

	/// <inheritdoc />
	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		CssBuilder.AddClass("btn-group");
		GetOrSetAttribute("role", "group");

		if (!string.IsNullOrEmpty(Label))
		{
			GetOrSetAttribute("aria-label", Label);
		}

		BuildHtml(builder);
	}
}