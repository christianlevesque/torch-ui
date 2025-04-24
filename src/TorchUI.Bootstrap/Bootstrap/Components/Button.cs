using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap;

/// <summary>
/// Represents a Bootstrap <c>.btn</c>
/// </summary>
/// <remarks>
/// <para>
/// Because Bootstrap button classes are valid on different types of markup, this component attempts to infer which type of markup should be rendered based on the supplied attributes. If an <c>href</c> is supplied, the component renders as an <c>&lt;a&gt;</c> tag. If a <c>value</c> is supplied, the component renders as an <c>&lt;input type="button"&gt;</c>. If neither value is supplied, the component renders as a <c>&lt;button&gt;</c>.
/// </para>
/// <para>
/// If the component receives <c>href="#"</c>, it not only renders as an <c>&lt;a&gt;</c>, but it also adds <c>role="button"</c> because an anchor tag with <c>href="#"</c> is probably being used as a trigger for in-page content.
/// </para> 
/// </remarks>
public class Button : TorchComponentBase
{
	/// <summary>
	/// The Bootstrap theme color of the button
	/// </summary>
	[Parameter]
	public ThemeColor? Color { get; set; }

	/// <summary>
	/// The Bootstrap size of the button
	/// </summary>
	[Parameter]
	public Size Size { get; set; } = Size.Medium;

	/// <summary>
	/// Whether the button should be outlined
	/// </summary>
	/// <remarks>
	/// Only has an effect if the <see cref="Color"/> parameter has a value because Bootstrap doesn't define a <c>.btn-outline</c> class
	/// </remarks>
	[Parameter]
	public bool Outlined { get; set; }

	/// <summary>
	/// The active state of the button
	/// </summary>
	/// <remarks>
	/// Because this parameter is a <c>bool?</c>, it has no effect if not explicitly supplied. If an explicit <see langword="true"/> value is passed, the button will be an active toggle button. If an explicit <see langword="false"/> value is passed, the button will be an inactive toggle button. If no explicit value is passed, the button will not be a toggle button at all.
	/// </remarks>
	[Parameter]
	public bool? Toggle { get; set; }

	/// <inheritdoc />
	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		// Anchor tags don't need a type attribute
		var omitType = false;

		if (UserAttributes.TryGetValue("href", out var href))
		{
			// If there's an href, this should be a link
			Tag = "a";
			omitType = true;

			// If the href equals "#", the anchor is a trigger for in-page functionality
			if (href.ToString() == "#")
			{
				UserAttributes.Add("role", "button");
			}
		}
		else if (UserAttributes.ContainsKey("value"))
		{
			Tag = "input";
		}
		else
		{
			Tag = "button";
		}

		if (!omitType && !UserAttributes.TryGetValue("type", out _))
		{
			UserAttributes.Add("type", "button");
		}

		CssBuilder.AddClass("btn");

		if (Color is not null)
		{
			var outlinedInfix = Outlined ? "-outline" : string.Empty;
			CssBuilder.AddClass($"btn{outlinedInfix}-{Color.Value.GetThemeColor()}");
		}

		if (Size is not Size.Medium)
		{
			CssBuilder.AddClass(Size.GetSizeClass("btn"));
		}

		if (Toggle.HasValue)
		{
			UserAttributes.Add("data-bs-toggle", "button");
			UserAttributes.Add("aria-pressed", Toggle.Value.ToString().ToLowerInvariant());
			CssBuilder.AddClass("active", Toggle.Value);
		}

		BuildHtml(builder);
	}
}