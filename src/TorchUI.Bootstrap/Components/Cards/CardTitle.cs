// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-title</c>
/// </summary>
/// <remarks>
/// <para>
/// The default HTML tag for this component is <c>&lt;h1&gt;</c> because there is no meaningful way for us to decide which <c>&lt;h*&gt;</c> is appropriate for your use case.
/// </para>
/// <para>
/// Besides this, the HTML spec does not explicitly disallow multiple <c>&lt;h1&gt;</c> on a single page as long as only one is not nested inside a semantic sectioning element (such as <c>&lt;article&gt;</c>, which is the default tag for the <see cref="Card"/> component). For that reason, we default to <c>&lt;h1&gt;</c> and allow developers to override this as they see fit. There is a lively debate in the developer community as to whether having multiple <c>&lt;h1&gt;</c>s is appropriate or not, and we won't be taking sides here - we just empower you to build your app however you want.    
/// </para>
/// </remarks>
public class CardTitle : CardTextBase
{
	public CardTitle() : base("card-title")
	{
		Tag = "h1";
	}
}
