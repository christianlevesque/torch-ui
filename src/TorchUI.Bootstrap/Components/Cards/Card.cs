// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card</c>
/// </summary>
/// <remarks>
/// The default HTML tag for this component is <c>&lt;article&gt;</c>, since the standard use case for a card is the display of an individual piece of related content, such as a blog post blurb, a musical album, a book, etc. The tag can still be overridden with the <see cref="TorchComponentBase.Tag"/> parameter.
/// </remarks>
public class Card : CardBlockBase
{
	public Card() : base("card")
	{
		Tag = "article";
	}
}
