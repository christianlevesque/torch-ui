using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap;

/// <summary>
/// Represents a Bootstrap <c>.col</c>
/// </summary>
public class Column : TorchComponentBase
{

#region Columns

	/// <summary>
	/// The width of this column on the default breakpoint
	/// </summary>
	[Parameter]
	public int? Xs { get; set; } = -1;

	/// <summary>
	/// The width of this column on the small breakpoint
	/// </summary>
	[Parameter]
	public int? Sm { get; set; }

	/// <summary>
	/// The width of this column on the medium breakpoint
	/// </summary>
	[Parameter]
	public int? Md { get; set; }

	/// <summary>
	/// The width of this column on the large breakpoint
	/// </summary>
	[Parameter]
	public int? Lg { get; set; }

	/// <summary>
	/// The width of this column on the extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? Xl { get; set; }

	/// <summary>
	/// The width of this column on the extra-extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? Xxl { get; set; }

	private void AddBreakpointCols(string? infix, int? cols)
	{
		if (cols is null)
		{
			return;
		}

		if (cols is >12 or <-1)
		{
			throw new ArgumentOutOfRangeException(
				nameof(cols),
				$"Bootstrap Grid supports a maximum of 12 columns, {cols} provided");
		}

		// Covers cols == -1 by default
		var className = string.IsNullOrEmpty(infix)
			? "col"
			: $"col-{infix}";

		if (cols == 0)
		{
			className = $"{className}-auto";
		}
		else if (cols > 0)
		{
			className = $"{className}-{cols}";
		}

		CssBuilder.AddClass(className);
	}

#endregion

#region Offsets

	/// <summary>
	/// The offset of this column on the default breakpoint
	/// </summary>
	[Parameter]
	public int? XsOffset { get; set; }

	/// <summary>
	/// The offset of this column on the small breakpoint
	/// </summary>
	[Parameter]
	public int? SmOffset { get; set; }

	/// <summary>
	/// The offset of this column on the medium breakpoint
	/// </summary>
	[Parameter]
	public int? MdOffset { get; set; }

	/// <summary>
	/// The offset of this column on the large breakpoint
	/// </summary>
	[Parameter]
	public int? LgOffset { get; set; }

	/// <summary>
	/// The offset of this column on the extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? XlOffset { get; set; }

	/// <summary>
	/// The offset of this column on the extra-extra-large breakpoint
	/// </summary>
	[Parameter]
	public int? XxlOffset { get; set; }

	private void AddBreakpointOffsets(string? infix, int? offset)
	{
		if (offset is null)
		{
			return;
		}

		if (offset is >11 or <1)
		{
			throw new ArgumentOutOfRangeException(
				nameof(offset),
				$"Bootstrap Grid supports column offsets of 1-11, {offset} provided");
		}

		var className = string.IsNullOrEmpty(infix)
			? $"offset-{offset}"
			: $"offset-{infix}-{offset}";

		CssBuilder.AddClass(className);
	}

#endregion

	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		AddBreakpointCols(null, Xs);
		AddBreakpointCols("sm", Sm);
		AddBreakpointCols("md", Md);
		AddBreakpointCols("lg", Lg);
		AddBreakpointCols("xl", Xl);
		AddBreakpointCols("xxl", Xxl);

		AddBreakpointOffsets(null, XsOffset);
		AddBreakpointOffsets("sm", SmOffset);
		AddBreakpointOffsets("md", MdOffset);
		AddBreakpointOffsets("lg", LgOffset);
		AddBreakpointOffsets("xl", XlOffset);
		AddBreakpointOffsets("xxl", XxlOffset);

		BuildHtml(builder);
	}
}
