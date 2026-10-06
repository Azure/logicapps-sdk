//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Skribblesign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SkribblesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skribblesign")]
        public IBodyWorkflowAction<ErrorResponse> CreateSeal([WorkflowExpression] Func<string> requestcontent, [WorkflowExpression] Func<string> requesttitle = null, [WorkflowExpression] Func<string> requestsealForSealing = null, [WorkflowExpression] Func<string> requestvisualSignatureformField = null, [WorkflowExpression] Func<string> requestvisualSignatureimagecontent = null, [WorkflowExpression] Func<string> requestvisualSignatureimagecontentType = null, [WorkflowExpression] Func<Position[]> requestvisualSignaturepositions = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/seal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttitle != null)
                {
                    request["title"] = SourceExpressionConverter.ConvertToken(requesttitle);
                    requestpropCount++;
                }

                requestpropCount++;
                request["content"] = SourceExpressionConverter.ConvertToken(requestcontent);
                if (requestsealForSealing != null)
                {
                    request["account_name"] = SourceExpressionConverter.ConvertToken(requestsealForSealing);
                    requestpropCount++;
                }

                var visualSignatureObject = new JObject();
                var visualSignatureObjectpropCount = 0;
                if (requestvisualSignatureformField != null)
                {
                    visualSignatureObject["form_field"] = SourceExpressionConverter.ConvertToken(requestvisualSignatureformField);
                    visualSignatureObjectpropCount++;
                }

                var imageObject = new JObject();
                var imageObjectpropCount = 0;
                if (requestvisualSignatureimagecontent != null)
                {
                    imageObject["content"] = SourceExpressionConverter.ConvertToken(requestvisualSignatureimagecontent);
                    imageObjectpropCount++;
                }

                if (requestvisualSignatureimagecontentType != null)
                {
                    imageObject["content_type"] = SourceExpressionConverter.ConvertToken(requestvisualSignatureimagecontentType);
                    imageObjectpropCount++;
                }

                if (imageObjectpropCount > 0)
                {
                    visualSignatureObject["image"] = imageObject;
                    visualSignatureObjectpropCount++;
                }

                if (requestvisualSignaturepositions != null)
                {
                    visualSignatureObject["positions"] = SourceExpressionConverter.ConvertToken(requestvisualSignaturepositions);
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
                return callPayload;
            }

            return new ApiConnectionAction<ErrorResponse>(BuildSourceInput);
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