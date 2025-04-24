// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-body</c>
/// </summary>
/// <remarks>
/// The default HTML tag for this component is <c>&lt;section&gt;</c>, since this component is used to display one or more sections of the parent <c>&lt;article&gt;</c>. The tag can still be overridden with the <see cref="TorchComponentBase.Tag"/> parameter.
/// </remarks>
public class CardBody : CardBlockBase
{
	public CardBody() : base("card-body")
	{
		Tag = "section";
	}
}
