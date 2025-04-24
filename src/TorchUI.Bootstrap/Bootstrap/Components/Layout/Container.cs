using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap;

/// <summary>
/// Represents a Bootstrap <c>.container</c>
/// </summary>
public class Container : TorchComponentBase
{
	/// <summary>
	/// The max-width of the Bootstrap container. Corresponds to <c>.container-sm</c>, <c>.container-md</c>, etc.
	/// </summary>
	/// <remarks>
	/// If <see cref="Fluid"/> is <see langword="true"/>, this parameter has no effect.
	/// </remarks>
	[Parameter]
	public Breakpoint MaxWidth { get; set; } = Breakpoint.Xs;

	/// <summary>
	/// Whether the Bootstrap container should be fluid. Corresponds to <c>.container-fluid</c>
	/// </summary>
	/// <remarks>
	/// If <see cref="Fluid"/> is <see langword="true"/>, the <see cref="MaxWidth"/> parameter has no effect.
	/// </remarks>
	[Parameter]
	public bool Fluid { get; set; }

	protected override void BuildRenderTree(RenderTreeBuilder builder)
	{
		// If XS, only add "container"
		CssBuilder.AddClass(
			"container",
			!Fluid && MaxWidth == Breakpoint.Xs);

		// If >XS, only add "container-{breakpoint}"
		CssBuilder.AddClass(
			$"container-{MaxWidth.ToString().ToLowerInvariant()}",
			!Fluid && MaxWidth > Breakpoint.Xs);

		// If fluid, only add "container-fluid"
		CssBuilder.AddClass("container-fluid", Fluid);

		BuildHtml(builder);
	}
}
