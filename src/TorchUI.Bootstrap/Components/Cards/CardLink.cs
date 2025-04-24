// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap <c>.card-link</c>
/// </summary>
public class CardLink : CardTextBase
{
	public CardLink() : base("card-link")
	{
		Tag = "a";
	}
}
