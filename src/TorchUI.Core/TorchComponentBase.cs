using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace TorchUI;

/// <summary>
/// A base component for all TorchUI components
/// </summary>
public class TorchComponentBase : ComponentBase
{
	/// <summary>
	/// The component's <see cref="CssBuilder"/>
	/// </summary>
	protected readonly CssBuilder CssBuilder = new();

	/// <summary>
	/// Represents the HTML tag with which the component should render
	/// </summary>
	[Parameter]
	public string Tag { get; set; } = "div";

	/// <summary>
	/// Represents the child content of the component
	/// </summary>
	[Parameter]
	public RenderFragment? ChildContent { get; set; }

	/// <summary>
	/// Captures additional HTML attributes supplied by the developer
	/// </summary>
	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object> UserAttributes { get; set; } = new();

	/// <inheritdoc/>
	protected override void OnInitialized()
	{
		if (UserAttributes.TryGetValue("class", out var userClasses))
		{
			CssBuilder.AddClass(userClasses.ToString());
			UserAttributes.Remove("class");
		}
	}

	/// <summary>
	/// Builds the render tree using the provided <see cref="Tag"/> and <see cref="ChildContent"/>
	/// </summary>
	/// <param name="rtb"></param>
	protected void BuildHtml(RenderTreeBuilder rtb)
	{
		var classes = CssBuilder.Build();

		rtb.OpenElement(0, Tag);
		rtb.AddMultipleAttributes(1, UserAttributes);

		if (!string.IsNullOrEmpty(classes))
		{
			rtb.AddAttribute(2, "class", classes);
		}

		rtb.AddContent(3, ChildContent);
		rtb.CloseElement();
	}

	/// <summary>
	/// Wraps around the <see cref="BuildHtml(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder)"/> method so it can be used as a <see cref="RenderFragment"/>
	/// </summary>
	protected RenderFragment BuildHtml() => BuildHtml;

	/// <summary>
	/// Accesses the <see cref="UserAttributes"/> dictionary and retrieves the value of the specified key if it exists. If it does not, it sets the provided default and returns it
	/// </summary>
	/// <param name="key">The key of the value to retrieve</param>
	/// <param name="defaultValue">The default value to use if the key is not set</param>
	/// <typeparam name="T">The type of the value</typeparam>
	/// <returns>The value if it exists, else <paramref name="defaultValue"/></returns>
	protected T GetOrSetAttribute<T>(string key, T defaultValue)
	{
		if (UserAttributes.TryGetValue(key, out var item))
		{
			return (T)item;
		}

		UserAttributes[key] = defaultValue!;
		return defaultValue;
	}
}
