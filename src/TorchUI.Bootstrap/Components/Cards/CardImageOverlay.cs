// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-img-overlay</c>
/// </summary>
public class CardImageOverlay : TorchComponentBase
{
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("card-img-overlay");
	}
}
