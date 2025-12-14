// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Utility class for saving workflow artifacts to disk.
    /// </summary>
    public static class WorkflowArtifactWriter
    {
        /// <summary>
        /// Saves workflow artifacts in Azure Logic Apps Standard structure.
        /// </summary>
        /// <param name="artifacts">The workflow artifacts to save</param>
        /// <param name="outputPath">Root directory path where the Logic App structure will be created</param>
        /// <remarks>
        /// This method creates the following directory structure:
        /// <code>
        /// outputPath/
        /// ├── WorkflowName1/
        /// │   └── workflow.json
        /// ├── WorkflowName2/
        /// │   └── workflow.json
        /// └── connections.json
        /// </code>
        /// This structure matches the expected format for Azure Logic Apps (Standard).
        /// </remarks>
        public static void SaveAsLogicAppStandard(CodefulWorkflowsArtifacts artifacts, string outputPath)
        {
            if (artifacts == null)
            {
                throw new ArgumentNullException(nameof(artifacts));
            }

            if (string.IsNullOrWhiteSpace(outputPath))
            {
                throw new ArgumentException("Output path cannot be null or empty", nameof(outputPath));
            }

            // Create root directory
            Directory.CreateDirectory(outputPath);

            // Save each workflow in its own folder with workflow.json
            if (artifacts.Flows != null)
            {
                foreach (var flow in artifacts.Flows)
                {
                    var workflowDir = Path.Combine(outputPath, flow.Key);
                    Directory.CreateDirectory(workflowDir);

                    var workflowPath = Path.Combine(workflowDir, "workflow.json");
                    var json = JsonConvert.SerializeObject(flow.Value, Formatting.Indented);
                    File.WriteAllText(workflowPath, json);
                }
            }

            // Save connections.json at root level if there are any connections
            if (artifacts.Connections?.ManagedApiConnections?.Count > 0)
            {
                var connectionsPath = Path.Combine(outputPath, "connections.json");
                var connectionsJson = JsonConvert.SerializeObject(
                    artifacts.Connections,
                    Formatting.Indented);
                File.WriteAllText(connectionsPath, connectionsJson);
            }
        }

        /// <summary>
        /// Saves workflow artifacts in a flat structure (legacy format).
        /// </summary>
        /// <param name="artifacts">The workflow artifacts to save</param>
        /// <param name="outputPath">Directory path where all JSON files will be created</param>
        /// <remarks>
        /// This method creates the following structure:
        /// <code>
        /// outputPath/
        /// ├── WorkflowName1.json
        /// ├── WorkflowName2.json
        /// └── connections.json
        /// </code>
        /// </remarks>
        public static void SaveFlat(CodefulWorkflowsArtifacts artifacts, string outputPath)
        {
            if (artifacts == null)
            {
                throw new ArgumentNullException(nameof(artifacts));
            }

            if (string.IsNullOrWhiteSpace(outputPath))
            {
                throw new ArgumentException("Output path cannot be null or empty", nameof(outputPath));
            }

            // Create output directory
            Directory.CreateDirectory(outputPath);

            // Save each workflow as a separate JSON file
            if (artifacts.Flows != null)
            {
                foreach (var flow in artifacts.Flows)
                {
                    var fileName = $"{flow.Key}.json";
                    var filePath = Path.Combine(outputPath, fileName);
                    var json = JsonConvert.SerializeObject(flow.Value, Formatting.Indented);
                    File.WriteAllText(filePath, json);
                }
            }

            // Save connections.json if there are any connections
            if (artifacts.Connections?.ManagedApiConnections?.Count > 0)
            {
                var connectionsPath = Path.Combine(outputPath, "connections.json");
                var connectionsJson = JsonConvert.SerializeObject(
                    artifacts.Connections,
                    Formatting.Indented);
                File.WriteAllText(connectionsPath, connectionsJson);
            }
        }
    }
}
