// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Reflection;
    using System.Threading.Tasks;
    using Microsoft.Azure.Functions.Worker.Core.FunctionMetadata;

    /// <summary>  
    /// Agent function provider.  
    /// </summary>  
    public class DummyFunctionProvider : IFunctionMetadataProvider
    {
        /// <summary>
        /// Gets the function metadata errors.
        /// </summary>
        public ImmutableDictionary<string, ImmutableArray<string>> FunctionErrors
        {
            // ToDo (psrivas): collect all errors and throw it to the users
            get
            {
                return new Dictionary<string, ImmutableArray<string>>().ToImmutableDictionary();
            }
        }

        /// <summary>
        /// The agent function name.
        /// </summary>
        private const string TestHttpFunctionName = "HttpFromWorker";

        /// <summary>  
        /// Retrieves the metadata for all functions.  
        /// </summary>  
        public Task<ImmutableArray<IFunctionMetadata>> GetFunctionMetadataAsync(string directory)
        {
            Console.WriteLine("Apseth loading agent endpoint functions from worker.");

            var metadataList = new List<IFunctionMetadata>();
            var agentFunctionRawBindings = new List<string>
            {
                @"{""name"":""req"",""type"":""httpTrigger"",""direction"":""In"",""authLevel"":""anonymous"",""methods"":[""POST"", ""GET""], ""route"": ""workerfunction/{flowName}""}",
                @"{""name"":""$return"",""type"":""http"",""direction"":""Out""}"
            };

            metadataList.Add(new DefaultFunctionMetadata
            {
                Name = DummyFunctionProvider.TestHttpFunctionName,
                ScriptFile = DummyFunctionProvider.GetScriptFile(),
                EntryPoint = DummyFunctionProvider.GetAgentEntryPoint(),
                Language = "dotnet",
                RawBindings = agentFunctionRawBindings,
            });

            // Fix: Use ToImmutableArray() instead of ToImmutable()
            return Task.FromResult(metadataList.ToImmutableArray());
        }

        /// <summary>
        /// Gets the entry point for agent API requests.
        /// </summary>
        private static string GetAgentEntryPoint()
        {
            return $"{typeof(DummyFunctionProvider).FullName}.{nameof(DummyFunctionProvider.Callback)}";
        }
        /// <summary>
        /// Gets the script file.
        /// </summary>
        private static string GetScriptFile()
        {
            return $"{Assembly.GetExecutingAssembly().GetName().Name}.dll";
        }

        /// <summary>
        /// The callback for the HTTP request to the agent API.
        /// </summary>
        public static void Callback()
        {
            Console.WriteLine("Dummy Callback called.");
        }
    }
}
