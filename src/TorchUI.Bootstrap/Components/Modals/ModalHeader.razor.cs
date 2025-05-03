using Microsoft.AspNetCore.Components;
using TorchUI.Bootstrap.Extensions;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap .modal-header
/// </summary>
public partial class ModalHeader
{
	/// <summary>
	/// The modal title
	/// </summary>
	[Parameter]
	public string? Title { get; set; }

	/// <summary>
	/// The visual heading level of the modal title
	/// </summary>
	[Parameter]
	public int TitleSize { get; set; } = 5;

	/// <summary>
	/// The theme color of the modal header
	/// </summary>
	[Parameter]
	public ThemeColor? Color { get; set; }

	public ModalHeader() => Tag = "header";

	/// <inheritdoc/>
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("modal-header");

		if (Color.HasValue)
		{
			CssBuilder.AddClass(Color.Value.GetTextBgColorClass());
		}
	}
}

