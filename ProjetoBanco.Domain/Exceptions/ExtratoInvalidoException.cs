using System;

public class ExtratoInvalidoException : ArgumentException
{
	public ExtratoInvalidoException(string message, string paramName) : base (message, paramName)
	{

	}
}
