// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-header</c>
/// </summary>
/// <remarks>
/// The default HTML tag for this component is <c>&lt;header&gt;</c>, since this component is used to display the header information of the parent <c>&lt;article&gt;</c>. The tag can still be overridden with the <see cref="TorchComponentBase.Tag"/> parameter.
/// </remarks>
public class CardHeader : CardBlockBase
{
	public CardHeader() : base("card-header")
	{
		Tag = "header";
	}
}
