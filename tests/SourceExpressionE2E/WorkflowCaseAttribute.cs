namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

[AttributeUsage(AttributeTargets.Method)]
public sealed class WorkflowCaseAttribute : Attribute
{
    public WorkflowCaseAttribute(string id, string expectedResponseBody)
    {
        this.Id = id;
        this.ExpectedResponseBody = expectedResponseBody;
    }

    public string Id { get; }
    public string ExpectedResponseBody { get; }
    public string[] FailureIds { get; set; } = [];
    public string ExpectedGenerationError { get; set; }
    public string ExpectedActionError { get; set; }
    public string ExpectedFailedAction { get; set; }
    public string ExpectedActionErrorCode { get; set; }
    public string ExpectedRunStatus { get; set; } = "Succeeded";
    public string ResponseContract { get; set; } = "Exact";
    public int ExpectedHttpStatus { get; set; } = 200;
    public string InputJson { get; set; } = "{}";
    public string Description { get; set; } = "";
}
