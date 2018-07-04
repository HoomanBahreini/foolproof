﻿
namespace Foolproof.Core
{
  public class GreaterThanAttribute : IsAttribute
  {
    public GreaterThanAttribute(string dependentProperty) : base(Operator.GreaterThan, dependentProperty) { }
  }
}
