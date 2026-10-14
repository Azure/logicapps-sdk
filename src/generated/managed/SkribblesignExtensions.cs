//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Skribblesign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SkribblesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skribblesign")]
        public IBodyWorkflowAction<ErrorResponse> CreateSeal(Expression<Func<string>> requestcontent, Expression<Func<string>> requesttitle = null, Expression<Func<string>> requestsealForSealing = null, Expression<Func<string>> requestvisualSignatureformField = null, Expression<Func<string>> requestvisualSignatureimagecontent = null, Expression<Func<string>> requestvisualSignatureimagecontentType = null, Expression<Func<Position[]>> requestvisualSignaturepositions = null)
        {
            var __workflow_requestcontent = requestcontent == null ? null : WorkflowExpression.Compile(requestcontent);
            WorkflowExpression.Validate(__workflow_requestcontent, nameof(requestcontent), required: true);
            var __workflow_requesttitle = requesttitle == null ? null : WorkflowExpression.Compile(requesttitle);
            WorkflowExpression.Validate(__workflow_requesttitle, nameof(requesttitle), required: false);
            var __workflow_requestsealForSealing = requestsealForSealing == null ? null : WorkflowExpression.Compile(requestsealForSealing);
            WorkflowExpression.Validate(__workflow_requestsealForSealing, nameof(requestsealForSealing), required: false);
            var __workflow_requestvisualSignatureformField = requestvisualSignatureformField == null ? null : WorkflowExpression.Compile(requestvisualSignatureformField);
            WorkflowExpression.Validate(__workflow_requestvisualSignatureformField, nameof(requestvisualSignatureformField), required: false);
            var __workflow_requestvisualSignatureimagecontent = requestvisualSignatureimagecontent == null ? null : WorkflowExpression.Compile(requestvisualSignatureimagecontent);
            WorkflowExpression.Validate(__workflow_requestvisualSignatureimagecontent, nameof(requestvisualSignatureimagecontent), required: false);
            var __workflow_requestvisualSignatureimagecontentType = requestvisualSignatureimagecontentType == null ? null : WorkflowExpression.Compile(requestvisualSignatureimagecontentType);
            WorkflowExpression.Validate(__workflow_requestvisualSignatureimagecontentType, nameof(requestvisualSignatureimagecontentType), required: false);
            var __workflow_requestvisualSignaturepositions = requestvisualSignaturepositions == null ? null : WorkflowExpression.Compile(requestvisualSignaturepositions);
            WorkflowExpression.Validate(__workflow_requestvisualSignaturepositions, nameof(requestvisualSignaturepositions), required: false);
            return new DeferredBodyAction<ErrorResponse>(() =>
            {
                var apiCallPath = "/seal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requesttitle != null)
                {
                    request["title"] = ExpressionConverter.ConvertO(__workflow_requesttitle);
                    requestpropCount++;
                }

                requestpropCount++;
                request["content"] = ExpressionConverter.ConvertO(__workflow_requestcontent);
                if (__workflow_requestsealForSealing != null)
                {
                    request["account_name"] = ExpressionConverter.ConvertO(__workflow_requestsealForSealing);
                    requestpropCount++;
                }

                var visualSignatureObject = new JObject();
                var visualSignatureObjectpropCount = 0;
                if (__workflow_requestvisualSignatureformField != null)
                {
                    visualSignatureObject["form_field"] = ExpressionConverter.ConvertO(__workflow_requestvisualSignatureformField);
                    visualSignatureObjectpropCount++;
                }

                var imageObject = new JObject();
                var imageObjectpropCount = 0;
                if (__workflow_requestvisualSignatureimagecontent != null)
                {
                    imageObject["content"] = ExpressionConverter.ConvertO(__workflow_requestvisualSignatureimagecontent);
                    imageObjectpropCount++;
                }

                if (__workflow_requestvisualSignatureimagecontentType != null)
                {
                    imageObject["content_type"] = ExpressionConverter.ConvertO(__workflow_requestvisualSignatureimagecontentType);
                    imageObjectpropCount++;
                }

                if (imageObjectpropCount > 0)
                {
                    visualSignatureObject["image"] = imageObject;
                    visualSignatureObjectpropCount++;
                }

                if (__workflow_requestvisualSignaturepositions != null)
                {
                    visualSignatureObject["positions"] = ExpressionConverter.ConvertO(__workflow_requestvisualSignaturepositions);
                    visualSignatureObjectpropCount++;
                }

                if (visualSignatureObjectpropCount > 0)
                {
                    request["visual_signature"] = visualSignatureObject;
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ErrorResponse>(callPayload);
            });
        }
    }

    public class SkribblesignTriggers([ConnectionName] string connectionId)
    {
    }

    public class ErrorResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("method")]
        public ErrorResponseMethodType Method { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ErrorResponseMethodType
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class Position
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("rotation")]
        public int Rotation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Skribblesign;

    public partial class WorkflowManagedActions
    {
        public SkribblesignActions Skribblesign(string connectionId) => new SkribblesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SkribblesignTriggers Skribblesign(string connectionId) => new SkribblesignTriggers(connectionId);
    }
}
