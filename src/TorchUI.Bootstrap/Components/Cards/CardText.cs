// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-text</c>
/// </summary>
/// <remarks>
/// The default HTML tag for this component is <c>&lt;p&gt;</c> because text content is best described by the paragraph tag. The tag can still be overridden with the <see cref="TorchComponentBase.Tag"/> parameter.
/// </remarks>
public class CardText : CardTextBase
{
	public CardText() : base("card-text")
	{
		Tag = "p";
	}
}
