using System;
using Microsoft.AspNetCore.Components;
using TorchUI.Bootstrap.Extensions;

// ReSharper disable once CheckNamespace
namespace TorchUI.Bootstrap.Components;

/// <summary>
/// Represents a Bootstrap .card-img
/// </summary>
public class CardImage : TorchComponentBase
{
	private Position? _position;

#pragma warning disable BL0007 // Component parameter should be auto property

	/// <summary>
	/// The position of the image
	/// </summary>
	/// <exception cref="ArgumentOutOfRangeException">
	/// Thrown when the value provided is not <see cref="Position.Top"/> or <see cref="Position.Bottom"/>
	/// </exception>
	[Parameter]
	public Position? Position
	{
		get => _position;
		set
		{
			if (value is null)
			{
				_position = value;
				return;
			}

			if (value.Value is not (Bootstrap.Position.Top or Bootstrap.Position.Bottom))
			{
				throw new ArgumentOutOfRangeException($"The {nameof(CardImage)} component only supports {Bootstrap.Position.Top} and {Bootstrap.Position.Bottom} positions");
			}

			_position = value;
		}
	}

#pragma warning restore BL0007

	public CardImage()
	{
		Tag = "img";
	}

	protected override void SetupAttributes()
	{
		if (_position is not null)
		{
			CssBuilder.AddClass(_position.Value.GetPositionClass("card-img"));
		}
		else
		{
			CssBuilder.AddClass("card-img");
		}
	}
}
