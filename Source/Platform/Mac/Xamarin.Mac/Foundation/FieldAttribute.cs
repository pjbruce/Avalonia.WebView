using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class FieldAttribute : Attribute
{
	public string SymbolName { get; set; }

	public string LibraryName { get; set; }

	public FieldAttribute(string symbolName)
	{
		SymbolName = symbolName;
	}

	public FieldAttribute(string symbolName, string libraryName)
	{
		SymbolName = symbolName;
		LibraryName = libraryName;
	}
}
