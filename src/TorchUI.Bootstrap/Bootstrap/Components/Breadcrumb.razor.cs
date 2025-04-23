using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap;

/// <summary>
/// Represents a Bootstrap <c>.breadcrumb</c>
/// </summary>
public partial class Breadcrumb
{
	/// <summary>
	/// The ARIA label of the breadcrumb list to provide for screen readers
	/// </summary>
	[Parameter]
	public string Label { get; set; } = "breadcrumb";
}