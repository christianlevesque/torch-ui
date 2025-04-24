// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-body</c>
/// </summary>
/// <remarks>
/// The default HTML tag for this component is <c>&lt;footer&gt;</c>, since this component is used to display the footer information of the parent <c>&lt;article&gt;</c>. The tag can still be overridden with the <see cref="TorchComponentBase.Tag"/> parameter.
/// </remarks>
public class CardFooter : CardBlockBase
{
	public CardFooter() : base("card-footer")
	{
		Tag = "footer";
	}
}
