using Microsoft.AspNetCore.Components;
using TorchUI.Bootstrap.Extensions;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

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

	/// <summary>
	/// The Bootstrap size of the button group
	/// </summary>
	[Parameter]
	public Size Size { get; set; } = Size.Medium;

	/// <inheritdoc />
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("btn-group");
		GetOrSetAttribute("role", "group");

		if (Size is not Size.Medium)
		{
			CssBuilder.AddClass(Size.GetSizeClass("btn-group"));
		}

		if (!string.IsNullOrEmpty(Label))
		{
			GetOrSetAttribute("aria-label", Label);
		}
	}
}