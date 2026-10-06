namespace Microsoft.Azure.Workflows.Sdk;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class WorkflowExpressionAttribute : Attribute { }

public static class SourceExpression
{
    internal static void Validate(Delegate expression, string parameterName, bool required = false)
    {
        if (required && expression == null) throw new ArgumentNullException(parameterName);
    }
}

internal static class Program
{
    public static void Main()
    {
        foreach (var type in new[] { typeof(FixtureActions), typeof(FixtureTriggers) })
        {
            try
            {
                var method = type.GetMethod("Call")!;
                method.Invoke(Activator.CreateInstance(type), new object[method.GetParameters().Length]);
                throw new InvalidOperationException("Required connector validation was not injected.");
            }
            catch (System.Reflection.TargetInvocationException error)
                when (error.InnerException is ArgumentNullException { ParamName: "value" }) { }
        }
        if (new FixtureActions().Call(() => throw new InvalidOperationException("Delegate executed")) != "unchanged body")
            throw new InvalidOperationException("Connector body changed.");
        Console.WriteLine("SDK-build injection fixture passed.");
    }
}
