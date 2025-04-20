using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace TorchUI;

/// <summary>
/// A base component for all TorchUI components
/// </summary>
public class TorchComponentBase : ComponentBase
{
	/// <summary>
	/// Captures additional HTML attributes supplied by the developer
	/// </summary>
	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object?> UserAttributes { get; set; } = new();
}
