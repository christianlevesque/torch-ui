using Microsoft.AspNetCore.Components.Rendering;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-group</c>
/// </summary>
public class CardGroup : TorchComponentBase
{
	/// <inheritdoc/>
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("card-group");
	}
}
