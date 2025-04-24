using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.breadcrumb-item</c>
/// </summary>
public partial class BreadcrumbItem
{
	/// <summary>
	/// Whether the current item is active
	/// </summary>
	/// <remarks>
	/// If this value is <see langword="true"/>, the breadcrumb item is rendered without a link to the provided <see cref="Href"/>.
	/// </remarks>
	[Parameter]
	public bool Active { get; set; }

	/// <summary>
	/// The target of the breadcrumb link
	/// </summary>
	/// <remarks>
	/// If the <see cref="Active"/> parameter is <see langword="true"/>, this parameter is unused because the breadcrumb item is rendered without a link.
	/// </remarks>
	[Parameter]
	public string? Href { get; set; }

	/// <inheritdoc />
	protected override void OnInitialized()
	{
		CssBuilder.AddClass("breadcrumb-item");
		CssBuilder.AddClass("active", Active);

		if (Active)
		{
			UserAttributes["aria-current"] = "page";
		}

		base.OnInitialized();
	}
}