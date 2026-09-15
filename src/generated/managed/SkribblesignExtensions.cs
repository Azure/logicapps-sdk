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
        public IBodyWorkflowAction<ErrorResponse> CreateSeal(Expression<Func<string>> requestcontent, Expression<Func<string>> requesttitle = null, Expression<Func<string>> requestsealForSealing = null, Expression<Func<string>> requestvisualSignatureformField = null, Expression<Func<string>> requestvisualSignatureimagecontent = null, Expression<Func<string>> requestvisualSignatureimagecontentType = null, Expression<Func<Position[]>> requestvisualSignaturepositions = null)
        {
            var apiCallPath = "/seal";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requesttitle != null)
            {
                request["title"] = CSharpExpressionConverter.ConvertToken(requesttitle);
                requestpropCount++;
            }

            requestpropCount++;
            request["content"] = CSharpExpressionConverter.ConvertToken(requestcontent);
            if (requestsealForSealing != null)
            {
                request["account_name"] = CSharpExpressionConverter.ConvertToken(requestsealForSealing);
                requestpropCount++;
            }

            var visualSignatureObject = new JObject();
            var visualSignatureObjectpropCount = 0;
            if (requestvisualSignatureformField != null)
            {
                visualSignatureObject["form_field"] = CSharpExpressionConverter.ConvertToken(requestvisualSignatureformField);
                visualSignatureObjectpropCount++;
            }

            var imageObject = new JObject();
            var imageObjectpropCount = 0;
            if (requestvisualSignatureimagecontent != null)
            {
                imageObject["content"] = CSharpExpressionConverter.ConvertToken(requestvisualSignatureimagecontent);
                imageObjectpropCount++;
            }

            if (requestvisualSignatureimagecontentType != null)
            {
                imageObject["content_type"] = CSharpExpressionConverter.ConvertToken(requestvisualSignatureimagecontentType);
                imageObjectpropCount++;
            }

            if (imageObjectpropCount > 0)
            {
                visualSignatureObject["image"] = imageObject;
                visualSignatureObjectpropCount++;
            }

            if (requestvisualSignaturepositions != null)
            {
                visualSignatureObject["positions"] = CSharpExpressionConverter.ConvertToken(requestvisualSignaturepositions);
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