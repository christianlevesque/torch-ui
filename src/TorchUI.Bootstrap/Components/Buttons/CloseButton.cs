using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

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

	/// <summary>
	/// The dismiss action of the button
	/// </summary>
	[Parameter]
	public Toggle? Dismiss { get; set; }

	public CloseButton() => Tag = "button";

	/// <inheritdoc />
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("btn-close");
		UserAttributes.TryAdd("aria-label", Label);

		if (Dismiss.HasValue)
		{
			UserAttributes.Add(
				"data-bs-dismiss",
				Dismiss.Value.ToString().ToLowerInvariant());
		}
	}
}