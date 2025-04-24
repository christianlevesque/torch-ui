using System;
using System.ComponentModel;
using System.Reflection;

namespace TorchUI.Bootstrap.Extensions;

/// <summary>
/// Contains extension methods used within the TorchUI.Bootstrap assembly
/// </summary>
public static class EnumExtensions
{
	/// <summary>
	/// Gets the value of the <see cref="DescriptionAttribute"/> if defined, or else the name of the enum member as a string
	/// </summary>
	/// <param name="self">The enum member</param>
	/// <returns>the description</returns>
	public static string GetDescription(this Enum self)
	{
		var stringified = self.ToString();
		var description = self
			.GetType()
			.GetField(stringified)
			?.GetCustomAttribute<DescriptionAttribute>();
		return description?.Description ?? stringified;
	}

	/// <summary>
	/// Returns the specified theme color name contcatenated to the provided CSS class prefix
	/// </summary>
	/// <param name="self">The theme color</param>
	/// <param name="prefix">The CSS class prefix</param>
	/// <returns>the theme color name as a lowercase string</returns>
	public static string GetThemeColorClass(this ThemeColor self, string prefix)
		=> $"{prefix}-{self.ToString().ToLowerInvariant()}";

	/// <summary>
	/// Returns the specified size concatenated to the provided CSS class prefix
	/// </summary>
	/// <param name="self">The size</param>
	/// <param name="prefix">The CSS class prefix</param>
	/// <returns>the size name converted to a CSS class</returns>
	public static string GetSizeClass(this Size self, string prefix)
		=> $"{prefix}-{self.GetDescription()}";
}
