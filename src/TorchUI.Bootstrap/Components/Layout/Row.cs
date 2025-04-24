using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.row</c>
/// </summary>
public class Row : TorchComponentBase
{

#region Auto-layout columns

	/// <summary>
	/// The number of auto-layout columns on the default breakpoint
	/// </summary>
	[Parameter]
	public int? Xs { get; set; }

	/// <summary>
	/// The number of auto-layout columns on the small breakpoint
	/// </summary>
	[Parameter]
	public int? Sm { get; set; }

	/// <summary>
	/// The number of auto-layout columns on the medium breakpoint
	/// </summary>
	[Parameter]
	public int? Md { get; set; }

	/// <summary>
	/// The number of auto-layout columns on the large breakpoint
	/// </summary>
	[Parameter]
	public int? Lg { get; set; }

	/// <summary>
	/// The number of auto-layout columns on the extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? Xl { get; set; }

	/// <summary>
	/// The number of auto-layout columns on the extra-extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? Xxl { get; set; }

	private void AddBreakpointCols(string? infix, int? cols)
	{
		if (cols is null)
		{
			return;
		}

		if (cols is >6 or <0)
		{
			throw new ArgumentOutOfRangeException(
				nameof(cols),
				$"Bootstrap Grid supports a maximum of 6 auto-columns, {cols} provided");
		}

		var className = string.IsNullOrEmpty(infix)
			? "row-cols"
			: $"row-cols-{infix}";

		if (cols == 0)
		{
			className = $"{className}-auto";
		}
		else
		{
			className = $"{className}-{cols}";
		}

		CssBuilder.AddClass(className);
	}

#endregion

#region Gutters

	/// <summary>
	/// The x-axis gutter on the default breakpoint
	/// </summary>
	[Parameter]
	public int? XsGutterX { get; set; }

	/// <summary>
	/// The x-axis gutter on the small breakpoint
	/// </summary>
	[Parameter]
	public int? SmGutterX { get; set; }

	/// <summary>
	/// The x-axis gutter on the medium breakpoint
	/// </summary>
	[Parameter]
	public int? MdGutterX { get; set; }

	/// <summary>
	/// The x-axis gutter on the large breakpoint
	/// </summary>
	[Parameter]
	public int? LgGutterX { get; set; }

	/// <summary>
	/// The x-axis gutter on the extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? XlGutterX { get; set; }

	/// <summary>
	/// The x-axis gutter on the extra-extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? XxlGutterX { get; set; }

	/// <summary>
	/// The y-axis gutter on the default breakpoint
	/// </summary>
	[Parameter]
	public int? XsGutterY { get; set; }

	/// <summary>
	/// The y-axis gutter on the small breakpoint
	/// </summary>
	[Parameter]
	public int? SmGutterY { get; set; }

	/// <summary>
	/// The y-axis gutter on the medium breakpoint
	/// </summary>
	[Parameter]
	public int? MdGutterY { get; set; }

	/// <summary>
	/// The y-axis gutter on the large breakpoint
	/// </summary>
	[Parameter]
	public int? LgGutterY { get; set; }

	/// <summary>
	/// The y-axis gutter on the extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? XlGutterY { get; set; }

	/// <summary>
	/// The y-axis gutter on the extra-extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? XxlGutterY { get; set; }

	/// <summary>
	/// The uniform gutter on the default breakpoint
	/// </summary>
	[Parameter]
	public int? XsGutter { get; set; }

	/// <summary>
	/// The uniform gutter on the small breakpoint
	/// </summary>
	[Parameter]
	public int? SmGutter { get; set; }

	/// <summary>
	/// The uniform gutter on the medium breakpoint
	/// </summary>
	[Parameter]
	public int? MdGutter { get; set; }

	/// <summary>
	/// The uniform gutter on the large breakpoint
	/// </summary>
	[Parameter]
	public int? LgGutter { get; set; }

	/// <summary>
	/// The uniform gutter on the extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? XlGutter { get; set; }

	/// <summary>
	/// The uniform gutter on the extra-extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? XxlGutter { get; set; }

	private void AddGutters(string? infix, int? gutter)
	{
		if (gutter is null)
		{
			return;
		}

		if (gutter is <0 or >5)
		{
			throw new ArgumentOutOfRangeException(
				nameof(gutter),
				$"Bootstrap Grid supports a maximum of 5 gutter levels, {gutter} provided");
		}

		var className = string.IsNullOrEmpty(infix)
			? $"g-{gutter}"
			: $"g{infix}-{gutter}";

		CssBuilder.AddClass(className);
	}

#endregion

	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		CssBuilder.AddClass("row");

		AddBreakpointCols(null, Xs);
		AddBreakpointCols("sm", Sm);
		AddBreakpointCols("md", Md);
		AddBreakpointCols("lg", Lg);
		AddBreakpointCols("xl", Xl);
		AddBreakpointCols("xxl", Xxl);

		// Uniform gutters
		AddGutters(null, XsGutter);
		AddGutters("-sm", SmGutter);
		AddGutters("-md", MdGutter);
		AddGutters("-lg", LgGutter);
		AddGutters("-xl", XlGutter);
		AddGutters("-xxl", XxlGutter);

		// X-axis gutters
		AddGutters("x", XsGutterX);
		AddGutters("x-sm", SmGutterX);
		AddGutters("x-md", MdGutterX);
		AddGutters("x-lg", LgGutterX);
		AddGutters("x-xl", XlGutterX);
		AddGutters("x-xxl", XxlGutterX);

		// Y-axis gutters
		AddGutters("y", XsGutterY);
		AddGutters("y-sm", SmGutterY);
		AddGutters("y-md", MdGutterY);
		AddGutters("y-lg", LgGutterY);
		AddGutters("y-xl", XlGutterY);
		AddGutters("y-xxl", XxlGutterY);

		BuildHtml(builder);
	}
}
