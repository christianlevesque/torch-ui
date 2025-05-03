using System.ComponentModel;

namespace TorchUI.Bootstrap;

/// <summary>
/// Represents the available sizes in Bootstrap
/// </summary>
public enum Size
{
	/// <summary>
	/// Represents the small size in Bootstrap
	/// </summary>
	[Description("sm")]
	Small,

	/// <summary>
	/// Represents the default size in Bootstrap
	/// </summary>
	Medium,

	/// <summary>
	/// Represents the large size in Bootstrap
	/// </summary>
	[Description("lg")]
	Large,

	/// <summary>
	/// Represents the extra-large size in Bootstrap
	/// </summary>
	/// <remarks>
	/// NOTE: Most Bootstrap components don't support the XL size. If a component parameter accepts a <see cref="Size"/> value, only use the XL size if the parameter's XMLDoc explicitly states that it supports the XL size.
	/// </remarks>
	[Description("xl")]
	ExtraLarge
}
