using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using TorchUI.Bootstrap.Extensions;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap;

/// <summary>
/// Represents a Bootstrap <c>.badge</c>
/// </summary>
public class Badge : TorchComponentBase
{
	/// <summary>
	/// The Bootstrap theme color of the badge
	/// </summary>
	[Parameter]
	public ThemeColor Color { get; set; }

	/// <summary>
	/// Whether the badge should be a pill 
	/// </summary>
	[Parameter]
	public bool Pill { get; set; }

	public Badge()
	{
		Tag = "span";
	}

	/// <inheritdoc />
	protected override void OnInitialized()
	{
		CssBuilder.AddClass("badge");

		base.OnInitialized();
	}

	/// <inheritdoc />
	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		CssBuilder.AddClass(Color.GetThemeColorClass("text-bg"));

		if (Pill)
		{
			CssBuilder.AddClass("rounded-pill");
		}

		BuildHtml(builder);
	}
}