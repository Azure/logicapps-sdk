using Microsoft.Azure.Workflows.Sdk;
using Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip;
using Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid;
using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob;
using System.Reflection;

var actions = new AbbreviationsipActions("connection");
Expect<ArgumentNullException>(() => actions.AbbrGet(null), "term");
Expect<ArgumentException>(() => actions.AbbrGet(SourceExpression.Literal<string>(1, null)), "term");
Expect<ArgumentNullException>(() => new AzureeventgridTriggers("connection").CreateSubscription(null, null), "subscriptionId");
Expect<ArgumentNullException>(() => new AzureBlobActions("connection").UploadBlob(
    SourceExpression.Literal(1, "container"), SourceExpression.Literal(1, "blob"), null), "content");
var calls = 0;
Func<string> raw = () => { calls++; return "unsafe"; };
Expect<NotSupportedException>(() => actions.AbbrGet(raw));
Expect<NotSupportedException>(() => actions.AbbrGet(SourceExpression.Literal(1, "term"), categoryid: raw));
if (calls != 0) throw new InvalidOperationException("Authoring delegates were executed.");
try
{
    typeof(AbbreviationsipActions).GetMethod("AbbrGet")!.Invoke(actions, new object[4]);
    throw new InvalidOperationException("Reflective caller bypassed required-argument validation.");
}
catch (TargetInvocationException error) when (error.InnerException is ArgumentNullException { ParamName: "term" }) { }
actions.AbbrGet(SourceExpression.Literal(1, "term")).GetActionDefinition("valid");
if (typeof(SourceExpression).Assembly.GetReferencedAssemblies().Any(a => a.Name!.StartsWith("Microsoft.CodeAnalysis")))
    throw new InvalidOperationException("Roslyn leaked into runtime references.");
Console.WriteLine("Packaged connector validation passed without consumer build assets or rewriting.");

static void Expect<T>(Func<object> call, string parameter = null) where T : Exception
{
    try { call(); }
    catch (Exception error) when (error.GetType() == typeof(T))
    {
        if (parameter != null && (error as ArgumentException)?.ParamName != parameter)
            throw new InvalidOperationException("Wrong connector parameter name.", error);
        return;
    }
    throw new InvalidOperationException($"Expected immediate {typeof(T).Name}.");
}
