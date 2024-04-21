using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.Filters;

public class CheckboxRequired : ValidationAttribute
{
    public override bool IsValid(object? value) => value is bool b && b;
}
