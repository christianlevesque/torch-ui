// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.modal-footer</c>
/// </summary>
public class ModalFooter : TorchComponentBase
{
	public ModalFooter() => Tag = "footer";

	/// <inheritdoc/>
	protected override void SetupAttributes()
	{
		CssBuilder.AddClass("modal-footer");
	}
}
