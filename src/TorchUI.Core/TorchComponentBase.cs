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

	/// <summary>
	/// Builds the render tree using the provided <see cref="Tag"/> and <see cref="ChildContent"/>
	/// </summary>
	/// <param name="rtb"></param>
	protected void BuildHtml(RenderTreeBuilder rtb)
	{
		if (UserAttributes.TryGetValue("class", out var userClasses))
		{
			CssBuilder.AddClass(userClasses.ToString());
		}

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
}
