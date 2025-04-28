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
	/// Returns the specified breakpoint name formatted as a Bootstrap display class (<c>d-{breakpoint}</c>) with the given suffix
	/// </summary>
	/// <param name="self">The breakpoint</param>
	/// <param name="suffix">The CSS class suffix</param>
	/// <returns>The formatted CSS classes</returns>
	public static string GetBreakpointDisplayClass(
		this Breakpoint self,
		string suffix)
	{
		return self is Breakpoint.Xs
			? $"d-{suffix}"
			: $"d-{self.ToString().ToLowerInvariant()}-{suffix}";
	}

	/// <summary>
	/// Returns the specified position name concatenated to the provided CSS class prefix
	/// </summary>
	/// <param name="self">The position</param>
	/// <param name="prefix">The CSS class prefix</param>
	/// <returns>The formatted CSS class</returns>
	public static string GetPositionClass(
		this Position self,
		string prefix)
		=> $"{prefix}-{self.ToString().ToLowerInvariant()}";

	/// <summary>
	/// Returns the specified theme color name contcatenated to the provided CSS class prefix
	/// </summary>
	/// <param name="self">The theme color</param>
	/// <param name="prefix">The CSS class prefix</param>
	/// <returns>the theme color name as a lowercase string</returns>
	public static string GetThemeColorClass(this ThemeColor self, string prefix)
		=> $"{prefix}-{self.ToString().ToLowerInvariant()}";

	/// <summary>
	/// Returns the <c>bg-*</c> class for the provided Bootstrap theme color
	/// </summary>
	/// <param name="self">The theme color</param>
	/// <returns>The formatted CSS class</returns>
	public static string GetBgColorClass(this ThemeColor self)
		=> GetThemeColorClass(self, "bg");

	/// <summary>
	/// Returns the <c>text-*</c> class for the provided Bootstrap theme color
	/// </summary>
	/// <param name="self">The theme color</param>
	/// <returns>The formatted CSS class</returns>
	public static string GetTextColorClass(this ThemeColor self)
		=> GetThemeColorClass(self, "text");

	/// <summary>
	/// Returns the <c>text-bg-*</c> class for the provided Bootstrap theme color
	/// </summary>
	/// <param name="self">The theme color</param>
	/// <returns>The formatted CSS class</returns>
	public static string GetTextBgColorClass(this ThemeColor self)
		=> GetThemeColorClass(self, "text-bg");

	/// <summary>
	/// Returns the <c>border-*</c> class for the provided Bootstrap theme color
	/// </summary>
	/// <param name="self">The theme color</param>
	/// <returns>The formatted CSS class</returns>
	public static string GetBorderColorClass(this ThemeColor self)
		=> GetThemeColorClass(self, "border");

	/// <summary>
	/// Returns the specified size concatenated to the provided CSS class prefix
	/// </summary>
	/// <param name="self">The size</param>
	/// <param name="prefix">The CSS class prefix</param>
	/// <returns>the size name converted to a CSS class</returns>
	public static string GetSizeClass(this Size self, string prefix)
		=> $"{prefix}-{self.GetDescription()}";
}
