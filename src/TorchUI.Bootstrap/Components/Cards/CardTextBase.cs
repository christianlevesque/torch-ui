using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using TorchUI.Bootstrap.Extensions;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// A base card component which provides common rendering logic for the text-based parts of Bootstrap cards
/// </summary>
public abstract class CardTextBase : TorchComponentBase
{
	private readonly string _baseCssClass;

	/// <summary>
	/// The bootstrap color of the card text
	/// </summary>
	[Parameter]
	public ThemeColor? TextColor { get; set; }

	protected CardTextBase(string baseCssClass)
	{
		_baseCssClass = baseCssClass;
	}

	/// <inheritdoc/>
	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		CssBuilder.AddClass(_baseCssClass);

		if (TextColor is not null)
		{
			CssBuilder.AddClass(TextColor.Value.GetTextColorClass());
		}

		BuildHtml(builder);
	}
}
