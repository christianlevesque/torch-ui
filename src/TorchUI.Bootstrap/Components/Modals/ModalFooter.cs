// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.modal-footer</c>
/// </summary>
public class ModalFooter : TorchComponentBase
{
	/// <inheritdoc/>
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("modal-footer");
	}
}
