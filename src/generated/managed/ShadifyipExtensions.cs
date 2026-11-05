//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shadifyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShadifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shadifyip")]
        public IBodyWorkflowAction<SudokuCheckResponse, ApiConnectionActionConfiguration> SudokuCheck(Expression<Func<string>> task)
        {
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            return new DeferredBodyAction<SudokuCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sudoku/verifier";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["task"] = ExpressionConverter.Convert(__workflow_task);
                return new ApiConnectionAction<SudokuCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shadifyip")]
        public IBodyWorkflowAction<SudokuGetResponse, ApiConnectionActionConfiguration> SudokuGet(Expression<Func<int>> fill = null)
        {
            var __workflow_fill = WorkflowExpression.Compile(fill, nameof(fill), required: false);
            return new DeferredBodyAction<SudokuGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sudoku/generator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fill != null)
                    callPayload.Queries["fill"] = ExpressionConverter.Convert(__workflow_fill);
                return new ApiConnectionAction<SudokuGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shadifyip")]
        public IBodyWorkflowAction<TakuzuGetResponse, ApiConnectionActionConfiguration> TakuzuGet(Expression<Func<int>> size = null, Expression<Func<int>> fill = null)
        {
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_fill = WorkflowExpression.Compile(fill, nameof(fill), required: false);
            return new DeferredBodyAction<TakuzuGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/takuzu/generator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["size"] = Convert.ToString(8);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Queries["fill"] = Convert.ToString(33);
                if (__workflow_fill != null)
                    callPayload.Queries["fill"] = ExpressionConverter.Convert(__workflow_fill);
                return new ApiConnectionAction<TakuzuGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shadifyip")]
        public IBodyWorkflowAction<TakuzuCheckResponse, ApiConnectionActionConfiguration> TakuzuCheck(Expression<Func<string>> task)
        {
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            return new DeferredBodyAction<TakuzuCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/takuzu/verifier";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["task"] = ExpressionConverter.Convert(__workflow_task);
                return new ApiConnectionAction<TakuzuCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shadifyip")]
        public IBodyWorkflowAction<MinesweeperGetResponse, ApiConnectionActionConfiguration> MinesweeperGet(Expression<Func<int>> width = null, Expression<Func<int>> height = null, Expression<Func<string>> start = null, Expression<Func<int>> mines = null)
        {
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: false);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_mines = WorkflowExpression.Compile(mines, nameof(mines), required: false);
            return new DeferredBodyAction<MinesweeperGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/minesweeper/generator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["width"] = Convert.ToString(9);
                if (__workflow_width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(__workflow_width);
                callPayload.Queries["height"] = Convert.ToString(9);
                if (__workflow_height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(__workflow_height);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["mines"] = Convert.ToString(12);
                if (__workflow_mines != null)
                    callPayload.Queries["mines"] = ExpressionConverter.Convert(__workflow_mines);
                return new ApiConnectionAction<MinesweeperGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shadifyip")]
        public IBodyWorkflowAction<AnagramGetResponse, ApiConnectionActionConfiguration> AnagramGet()
        {
            return new DeferredBodyAction<AnagramGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/anagram/generator";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AnagramGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shadifyip")]
        public IBodyWorkflowAction<QuadraticGetResponse, ApiConnectionActionConfiguration> QuadraticGet(Expression<Func<int>> minA = null, Expression<Func<int>> maxA = null, Expression<Func<int>> minB = null, Expression<Func<int>> maxB = null, Expression<Func<int>> minC = null, Expression<Func<int>> maxC = null)
        {
            var __workflow_minA = WorkflowExpression.Compile(minA, nameof(minA), required: false);
            var __workflow_maxA = WorkflowExpression.Compile(maxA, nameof(maxA), required: false);
            var __workflow_minB = WorkflowExpression.Compile(minB, nameof(minB), required: false);
            var __workflow_maxB = WorkflowExpression.Compile(maxB, nameof(maxB), required: false);
            var __workflow_minC = WorkflowExpression.Compile(minC, nameof(minC), required: false);
            var __workflow_maxC = WorkflowExpression.Compile(maxC, nameof(maxC), required: false);
            return new DeferredBodyAction<QuadraticGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/math/quad";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["minA"] = Convert.ToString(1);
                if (__workflow_minA != null)
                    callPayload.Queries["minA"] = ExpressionConverter.Convert(__workflow_minA);
                callPayload.Queries["maxA"] = Convert.ToString(20);
                if (__workflow_maxA != null)
                    callPayload.Queries["maxA"] = ExpressionConverter.Convert(__workflow_maxA);
                callPayload.Queries["minB"] = Convert.ToString(1);
                if (__workflow_minB != null)
                    callPayload.Queries["minB"] = ExpressionConverter.Convert(__workflow_minB);
                callPayload.Queries["maxB"] = Convert.ToString(40);
                if (__workflow_maxB != null)
                    callPayload.Queries["maxB"] = ExpressionConverter.Convert(__workflow_maxB);
                callPayload.Queries["minC"] = Convert.ToString(1);
                if (__workflow_minC != null)
                    callPayload.Queries["minC"] = ExpressionConverter.Convert(__workflow_minC);
                callPayload.Queries["maxC"] = Convert.ToString(20);
                if (__workflow_maxC != null)
                    callPayload.Queries["maxC"] = ExpressionConverter.Convert(__workflow_maxC);
                return new ApiConnectionAction<QuadraticGetResponse>(callPayload);
            });
        }
    }

    public class ShadifyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SudokuCheckResponse
    {
        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public class SudokuGetResponse
    {
        [JsonProperty("grid")]
        public int[][] Grid { get; set; }

        [JsonProperty("task")]
        public int[][] TaskObject { get; set; }
    }

    public class TakuzuGetResponse
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("field")]
        public string[][] Field { get; set; }

        [JsonProperty("task")]
        public string[][] TaskObject { get; set; }
    }

    public class TakuzuCheckResponse
    {
        [JsonProperty("isError")]
        public bool IsError { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("position")]
        public string[] Position { get; set; }
    }

    public class MinesweeperGetResponse
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("board")]
        public string[][] Board { get; set; }

        [JsonProperty("mines")]
        public int Mines { get; set; }
    }

    public class AnagramGetResponse
    {
        [JsonProperty("Task")]
        public string TaskObject { get; set; }
        public string[] Words { get; set; }
    }

    public class QuadraticGetResponse
    {
        [JsonProperty("equation")]
        public string Equation { get; set; }

        [JsonProperty("a")]
        public int A { get; set; }

        [JsonProperty("b")]
        public int B { get; set; }

        [JsonProperty("c")]
        public int C { get; set; }

        [JsonProperty("discriminant")]
        public int Discriminant { get; set; }

        [JsonProperty("x1")]
        public string X1 { get; set; }

        [JsonProperty("x2")]
        public string X2 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shadifyip;

    public partial class WorkflowManagedActions
    {
        public ShadifyipActions Shadifyip(string connectionId) => new ShadifyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShadifyipTriggers Shadifyip(string connectionId) => new ShadifyipTriggers(connectionId);
    }
}