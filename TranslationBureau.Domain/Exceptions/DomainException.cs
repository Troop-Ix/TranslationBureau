using System;
using System.Collections.Generic;
using System.Text;

namespace TranslationBureau.Domain.Exceptions;

/// <summary>Исключение, возбуждаемое при нарушении правила предметной области.</summary>
public class DomainException : Exception
{
    public DomainException(string message) : base(message)
    {
    }
}

