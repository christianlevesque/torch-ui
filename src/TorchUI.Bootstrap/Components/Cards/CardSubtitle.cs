// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-title</c>
/// </summary>
/// <remarks>
/// The default HTML tag for this component is <c>&lt;h1&gt;</c> because there is no meaningful way for us to decide which <c>&lt;h*&gt;</c> is appropriate for your use case. It stands to reason, however, that if you have a subtitle, you probably already have a title - so the highest appropriate level is <c>&lt;h2&gt;</c>.
/// </remarks>
public class CardSubtitle : CardTextBase
{
	public CardSubtitle() : base("card-subtitle")
	{
		Tag = "h2";
	}
}
