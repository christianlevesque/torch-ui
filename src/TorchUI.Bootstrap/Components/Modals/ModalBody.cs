// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.modal-body</c>
/// </summary>
public class ModalBody : TorchComponentBase
{
	/// <inheritdoc/>
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("modal-body");
	}
}
