// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Xunit;

    public class GeneratedSdkContractTests
    {
        [Fact]
        public void AllFactoriesHaveDescriptorEntriesAndNoDelegateTransport()
        {
            var methods = typeof(WorkflowActions).Assembly.GetTypes().SelectMany(type => type.GetMethods())
                .Where(method => method.GetCustomAttribute<WorkflowExpressionFactoryAttribute>() != null).ToArray();
            Assert.True(methods.Length > 10000);
            foreach (var method in methods)
            {
                var entry = method.GetCustomAttribute<WorkflowExpressionFactoryAttribute>().EntryPoint;
                var descriptors = method.DeclaringType.GetMethods()
                    .Where(candidate => candidate.Name == entry &&
                        candidate.GetParameters().Length == method.GetParameters().Length)
                    .ToArray();
                Assert.NotEmpty(descriptors);
                Assert.All(descriptors, descriptor => Assert.Null(descriptor.GetCustomAttribute<ConnectorOperationAttribute>()));
            }
        }

        [Fact]
        public void SdkEnumsDeclareTheirWireRepresentation()
        {
            var missing = typeof(WorkflowActions).Assembly.GetTypes()
                .Where(type => type.IsEnum &&
                    type.GetCustomAttribute<JsonConverterAttribute>()?.ConverterType != typeof(StringEnumConverter) &&
                    !IsGeneratedIntegerEnum(type))
                .Select(type => type.FullName)
                .OrderBy(name => name)
                .ToArray();

            Assert.True(missing.Length == 0, string.Join(Environment.NewLine, missing));
        }

        [Fact]
        public void GeneratedTriggersUseUniqueDefaultsAndWithNameOnly()
        {
            var managedMethod = typeof(Microsoft.Azure.Workflows.Sdk.Connectors.Office365.Office365Triggers)
                .GetMethod("OnNewEmail");
            Assert.DoesNotContain(managedMethod.GetParameters(), parameter => parameter.Name == "triggerName");
            var first = WorkflowTriggers.Managed.Office365("office").OnNewEmail();
            var second = WorkflowTriggers.Managed.Office365("office").OnNewEmail();
            Assert.NotEqual(first.Name, second.Name);
            Assert.DoesNotContain(first.Name, new[] { "ApiConnectionTrigger", "ServiceProviderTrigger" });
            first.WithName("Managed").Then(WorkflowActions.BuiltIn.Compose(() => "yes").WithName("Action"));
            var managedDefinition = WorkflowFactory.CreateStatefulWorkflow("ManagedFlow", first);
            Assert.Contains("Managed", managedDefinition.Definition.Triggers.Keys);

            var serviceFirst = WorkflowTriggers.ServiceProviders.ServiceBus("service").ReceiveQueueMessages(() => "queue");
            var serviceSecond = WorkflowTriggers.ServiceProviders.ServiceBus("service").ReceiveQueueMessages(() => "queue");
            Assert.NotEqual(serviceFirst.Name, serviceSecond.Name);
            serviceFirst.WithName("Service").Then(WorkflowActions.BuiltIn.Compose(() => "yes").WithName("Action"));
            var serviceDefinition = WorkflowFactory.CreateStatefulWorkflow("ServiceFlow", serviceFirst);
            Assert.Contains("Service", serviceDefinition.Definition.Triggers.Keys);
        }

        private static bool IsGeneratedIntegerEnum(Type type)
        {
            var names = Enum.GetNames(type);
            if (names.Length == 0) return false;
            var values = Enum.GetValues(type).Cast<object>().Select(value => Convert.ToInt64(value)).ToArray();
            for (var index = 0; index < names.Length; index++)
            {
                var name = names[index];
                if (name.StartsWith("_", StringComparison.Ordinal) &&
                    long.TryParse(name.Substring(1), out var positive) &&
                    values[index] == positive)
                {
                    continue;
                }
                if (name.StartsWith("Negative", StringComparison.Ordinal) &&
                    long.TryParse(name.Substring("Negative".Length), out var negative) &&
                    values[index] == -negative)
                {
                    continue;
                }
                return false;
            }
            return true;
        }
    }
}
