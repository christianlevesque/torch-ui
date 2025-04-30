using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.btn-toolbar</c>
/// </summary>
public class ButtonToolbar : TorchComponentBase
{
	/// <summary>
	/// The ARIA label to describe the button toolbar
	/// </summary>
	/// <remarks>
	/// This value will not override an existing <c>aria-label</c> attribute.
	/// </remarks>
	[Parameter]
	public string? Label { get; set; }

	/// <inheritdoc />
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("btn-toolbar");
		GetOrSetAttribute("role", "toolbar");

		if (!string.IsNullOrEmpty(Label))
		{
			GetOrSetAttribute("aria-label", Label);
		}
	}
}