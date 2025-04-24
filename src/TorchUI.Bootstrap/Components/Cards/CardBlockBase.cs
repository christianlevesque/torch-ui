using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using TorchUI.Bootstrap.Extensions;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// A base card component which provides common rendering logic for the major block parts of Bootstrap cards
/// </summary>
public abstract class CardBlockBase : TorchComponentBase
{
	private readonly string _baseCssClass;

	/// <summary>
	/// The combined background and text Bootstrap color theme of the card
	/// </summary>
	[Parameter]
	public ThemeColor? ThemeColor { get; set; }

	/// <summary>
	/// The Bootstrap color of the card text
	/// </summary>
	[Parameter]
	public ThemeColor? TextColor { get; set; }

	/// <summary>
	/// The Bootstrap color of the background
	/// </summary>
	[Parameter]
	public ThemeColor? BackgroundColor { get; set; }

	/// <summary>
	/// The Bootstrap color of the border
	/// </summary>
	[Parameter]
	public ThemeColor? BorderColor { get; set; }

	protected CardBlockBase(string baseCssClass)
	{
		_baseCssClass = baseCssClass;
	}

	/// <inheritdoc/>
	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		CssBuilder.AddClass(_baseCssClass);

		if (ThemeColor is not null)
		{
			CssBuilder.AddClass(ThemeColor.Value.GetTextBgColorClass());
		}
		else
		{
			if (TextColor is not null)
			{
				CssBuilder.AddClass(TextColor.Value.GetTextColorClass());
			}

			if (BackgroundColor is not null)
			{
				CssBuilder.AddClass(BackgroundColor.Value.GetBgColorClass());
			}
		}

		if (BorderColor is not null)
		{
			CssBuilder.AddClass(BorderColor.Value.GetBorderColorClass());
		}

		BuildHtml(builder);
	}
}
