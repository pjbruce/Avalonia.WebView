using System;

namespace CoreText;

internal static class ConstructorError
{
	public static Exception ArgumentNull(object self, string argument)
	{
		GC.SuppressFinalize(self);
		return new ArgumentNullException(argument);
	}

	public static Exception Unknown(object self)
	{
		GC.SuppressFinalize(self);
		string message = $"Unable to create {self.GetType().Name} instance.";
		return new ArgumentException(message);
	}
}
