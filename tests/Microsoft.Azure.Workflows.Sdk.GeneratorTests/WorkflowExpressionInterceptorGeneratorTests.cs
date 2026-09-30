// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.GeneratorTests;

using Microsoft.Azure.Workflows.Sdk.Generators;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

public class WorkflowExpressionInterceptorGeneratorTests
{
    [Fact]
    public void Generator_RewritesWorkflowReferencesAndPreservesSwitchExpression()
    {
        const string source =
            """
            using System;
            using Microsoft.Azure.Workflows.Sdk;

            public static class Workflow
            {
                public static void Build()
                {
                    var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
                    WorkflowActions.BuiltIn.Compose(
                        () => trigger.TriggerOutput.Body == null
                            ? DateTime.UtcNow.DayOfWeek switch
                            {
                                DayOfWeek.Saturday or DayOfWeek.Sunday => "weekend",
                                _ => "weekday",
                            }
                            : "body");
                }
            }
            """;

        var result = RunGenerator(source);
        var generated = Assert.Single(result.Results).GeneratedSources.Single().SourceText.ToString();
        Assert.Contains("triggerOutputs()?[\\\"Body\\\"]", generated);
        Assert.Contains("DayOfWeek.Saturday or DayOfWeek.Sunday", generated);
        Assert.DoesNotContain("trigger.TriggerOutput", generated);
    }

    [Fact]
    public void Generator_ReportsIndirectWorkflowExpression()
    {
        const string source =
            """
            using System;
            using Microsoft.Azure.Workflows.Sdk;

            public static class Workflow
            {
                private static Func<string> GetExpression() => () => "value";

                public static void Build()
                {
                    WorkflowActions.BuiltIn.Compose(GetExpression());
                }
            }
            """;

        var result = RunGenerator(source);
        var diagnostic = Assert.Single(
            result.Diagnostics.Where(candidate => candidate.Id == "LAEXP001"));

        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
    }

    [Fact]
    public void Generator_AllowsCSharpInlineTemplateExpression()
    {
        const string source =
            """
            using System;
            using Microsoft.Azure.Workflows.Sdk;

            public static class Workflow
            {
                public static void Build()
                {
                    WorkflowActions.Managed.Sharepointonline("sharepoint").GetItems(
                        dataset: () => DateTime.UtcNow.DayOfWeek switch
                        {
                            DayOfWeek.Saturday => "weekend",
                            _ => "weekday",
                        },
                        table: () => "items");
                }
            }
            """;

        var result = RunGenerator(source);
        Assert.DoesNotContain(
            result.Diagnostics,
            candidate => candidate.Id == "LAEXP002");
    }

    [Fact]
    public void Generator_RejectsCustomerDefinedHelperMethods()
    {
        const string source =
            """
            using Microsoft.Azure.Workflows.Sdk;

            public static class CustomerHelper
            {
                public static string Format(string value) => value.ToUpperInvariant();
            }

            public static class Workflow
            {
                public static void Build()
                {
                    WorkflowActions.BuiltIn.Compose(
                        () => CustomerHelper.Format("value"));
                }
            }
            """;

        var result = RunGenerator(source);
        var diagnostic = Assert.Single(
            result.Diagnostics.Where(candidate => candidate.Id == "LAEXP003"));

        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("CustomerHelper.Format", diagnostic.GetMessage());
    }

    [Fact]
    public void Generator_RejectsCustomerDefinedTypeIdentity()
    {
        const string source =
            """
            using Microsoft.Azure.Workflows.Sdk;

            public sealed class CustomerValue
            {
                public CustomerValue(string value) => Value = value;
                public string Value { get; }
            }

            public static class Workflow
            {
                public static void Build()
                {
                    WorkflowActions.BuiltIn.Compose(
                        () => new CustomerValue("value"));
                }
            }
            """;

        var result = RunGenerator(source);
        var diagnostic = Assert.Single(
            result.Diagnostics.Where(candidate => candidate.Id == "LAEXP003"));

        Assert.Equal(DiagnosticSeverity.Error, diagnostic.Severity);
        Assert.Contains("CustomerValue", diagnostic.GetMessage());
    }

    [Fact]
    public void Generator_LowersGeneratedDtoCollectionsAndWorkflowFunctions()
    {
        const string source =
            """
            using System.Linq;
            using Microsoft.Azure.Workflows.Sdk;

            public static class Workflow
            {
                public static void Build()
                {
                    var categories = WorkflowActions.Managed
                        .Office365("office365")
                        .GetOutlookCategoryNames();
                    WorkflowActions.BuiltIn.Compose(
                        () => categories.Body
                            .Where(category => category.DisplayName != null)
                            .Select(category => category.DisplayName.ToUpper())
                            .ToArray());
                    WorkflowActions.BuiltIn.Compose(
                        () => WorkflowFunctions.AppSetting("Setting"));
                    var message = WorkflowActions.Managed
                        .Office365("office365")
                        .DraftEmail(
                            draftMessageto: () => "user@example.com",
                            draftMessagesubject: () => "subject",
                            draftMessagebody: () => "body");
                    WorkflowActions.BuiltIn.Compose(
                        () => message.Body.Importance ==
                            Microsoft.Azure.Workflows.Sdk.Connectors.Office365.OutlookReceiveMessageImportanceType.High);
                }
            }
            """;

        var result = RunGenerator(source);
        var generated = Assert.Single(result.Results).GeneratedSources.Single().SourceText.ToString();
        Assert.Contains(".Children().Where(category => category?[\\\"displayName\\\"].ToObject<string>() != null)", generated);
        Assert.Contains(".Select(category => category?[\\\"displayName\\\"].ToObject<string>().ToUpper())", generated);
        Assert.Contains("appsetting(\\\"Setting\\\")", generated);
        Assert.Contains("?[\\\"Importance\\\"].ToObject<string>() == \\\"High\\\"", generated);
        Assert.DoesNotContain("WorkflowFunctions.AppSetting", generated);
    }

    internal static GeneratorDriverRunResult RunGenerator(string source)
    {
        var parseOptions = new CSharpParseOptions(LanguageVersion.Latest);
        var syntaxTree = CSharpSyntaxTree.ParseText(source, parseOptions);
        var references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator)
            .Select(path => MetadataReference.CreateFromFile(path))
            .Append(MetadataReference.CreateFromFile(typeof(WorkflowActions).Assembly.Location));
        var compilation = CSharpCompilation.Create(
            "GeneratorTest",
            [syntaxTree],
            references,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            [new WorkflowExpressionInterceptorGenerator().AsSourceGenerator()],
            parseOptions: parseOptions);

        driver = driver.RunGenerators(compilation);
        return driver.GetRunResult();
    }
}
