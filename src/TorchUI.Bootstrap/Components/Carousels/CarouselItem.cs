using Microsoft.AspNetCore.Components;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

public class CarouselItem : TorchComponentBase
{
	/// <summary>
	/// The label to pass to the carousel indicator
	/// </summary>
	[Parameter]
	public string? Label { get; set; }

	/// <summary>
	/// The autoplay interval for this carousel item, in milliseconds
	/// </summary>
	[Parameter]
	public int Interval { get; set; }

	/// <summary>
	/// Whether the carousel item should be active
	/// </summary>
	[Parameter]
	public bool Active { get; set; }

	[CascadingParameter]
	private Carousel Parent { get; set; } = null!;

	/// <inheritdoc />
	protected override void OnInitialized()
	{
		Parent.AddCarouselItem(this);
	}

	protected override void SetupAttributes()
	{
		CssBuilder
			.AddClass("carousel-item")
			.AddClass("active", Active);

		if (Interval > 0)
		{
			UserAttributes["data-bs-interval"] = Interval;
		}
	}
}