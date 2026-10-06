namespace Microsoft.Azure.Workflows.Sdk;

public class FixtureActions
{
    public string Call([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<int> optional = null)
    {
        return "unchanged body";
    }
}

public class FixtureTriggers
{
    public string Call([WorkflowExpression] Func<string> value)
    {
        return "unchanged trigger";
    }
}
