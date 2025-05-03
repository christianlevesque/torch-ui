using System;
using Microsoft.AspNetCore.Components;
using TorchUI.Bootstrap.Extensions;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

public partial class Modal
{
	private string _id = string.Empty;
	private readonly string _fallbackId = Guid
		.NewGuid()
		.ToString();

	/// <summary>
	/// The modal size
	/// </summary>
	/// <remarks>
	/// This parameter supports the <see cref="Size.ExtraLarge"/> size.
	/// </remarks>
	[Parameter]
	public Size Size { get; set; } = Size.Medium;

	/// <summary>
	/// The breakpoint at which the modal should stop being fullscreen
	/// </summary>
	/// <remarks>
	/// If this is <see langword="null"/>, the modal will not be fullscreen. If this is <see cref="Breakpoint.Xs"/>, the modal will always be fullscreen. If this is any other non-<see langword="null"/> value, the modal will be fullscreen starting on mobile, <b>up to the specified breakpoint</b>.
	/// </remarks>
	[Parameter]
	public Breakpoint? FullscreenOn { get; set; }

	/// <summary>
	/// Whether the modal should be vertically centered
	/// </summary>
	[Parameter]
	public bool Centered { get; set; }

	/// <summary>
	/// Whether the modal should fade in and out on open/close
	/// </summary>
	[Parameter]
	public bool Fade { get; set; }

	/// <summary>
	/// Whether the modal should stay open when clicking the backdrop
	/// </summary>
	[Parameter]
	public bool Static { get; set; }

	/// <summary>
	/// Whether the modal should suppress closing when the ESC key is pressed
	/// </summary>
	[Parameter]
	public bool DisableKeyboard { get; set; }

	/// <inheritdoc/>
	protected override void SetupAttributes()
	{
		CssBuilder
			.AddClass("modal")
			.AddClass("fade", Fade);

		if (Size is not Size.Medium)
		{
			CssBuilder.AddClass(Size.GetSizeClass("modal"));
		}

		UserAttributes["tabindex"] = -1;
		UserAttributes["aria-hidden"] = "true";
		_id = GetOrSetAttribute("id", _fallbackId);

		if (Static)
		{
			UserAttributes["data-bs-backdrop"] = "static";
		}

		if (DisableKeyboard)
		{
			UserAttributes["data-bs-keyboard"] = "false";
		}
	}

	private string CreateDialogCssClasses()
	{
		var classes = "modal-dialog";

		if (Centered)
		{
			classes += " modal-dialog-centered";
		}

		if (FullscreenOn.HasValue)
		{
			var fullscreenClass = FullscreenOn.Value.GetBreakpointClass("modal-fullscreen");
			if (FullscreenOn.Value > Breakpoint.Xs)
			{
				fullscreenClass += "-down";
			}

			classes += $" {fullscreenClass}";
		}

		return classes;
	}
}

