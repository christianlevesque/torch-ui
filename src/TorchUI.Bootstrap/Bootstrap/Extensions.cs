namespace TorchUI.Bootstrap;

/// <summary>
/// Contains extension methods used within the TorchUI.Bootstrap assembly
/// </summary>
public static class Extensions
{
	/// <summary>
	/// Returns the lowercase string value of the given <see cref="ThemeColor"/>
	/// </summary>
	/// <param name="self">The theme color</param>
	/// <returns>the theme color name as a lowercase string</returns>
	public static string GetThemeColor(this ThemeColor self)
		=> self.ToString().ToLowerInvariant();
}
