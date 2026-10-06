//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Skribblesign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SkribblesignActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skribblesign")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSeal))]
        public IBodyWorkflowAction<ErrorResponse> CreateSeal([WorkflowExpression] Func<string> requestcontent, [WorkflowExpression] Func<string> requesttitle = null, [WorkflowExpression] Func<string> requestsealForSealing = null, [WorkflowExpression] Func<string> requestvisualSignatureformField = null, [WorkflowExpression] Func<string> requestvisualSignatureimagecontent = null, [WorkflowExpression] Func<string> requestvisualSignatureimagecontentType = null, [WorkflowExpression] Func<Position[]> requestvisualSignaturepositions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skribblesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ErrorResponse> __BuildCreateSeal(WorkflowExpression<string> requestcontent, WorkflowExpression<string> requesttitle = null, WorkflowExpression<string> requestsealForSealing = null, WorkflowExpression<string> requestvisualSignatureformField = null, WorkflowExpression<string> requestvisualSignatureimagecontent = null, WorkflowExpression<string> requestvisualSignatureimagecontentType = null, WorkflowExpression<Position[]> requestvisualSignaturepositions = null)
        {
            WorkflowExpression.Validate(requestcontent, nameof(requestcontent), required: true);
            WorkflowExpression.Validate(requesttitle, nameof(requesttitle), required: false);
            WorkflowExpression.Validate(requestsealForSealing, nameof(requestsealForSealing), required: false);
            WorkflowExpression.Validate(requestvisualSignatureformField, nameof(requestvisualSignatureformField), required: false);
            WorkflowExpression.Validate(requestvisualSignatureimagecontent, nameof(requestvisualSignatureimagecontent), required: false);
            WorkflowExpression.Validate(requestvisualSignatureimagecontentType, nameof(requestvisualSignatureimagecontentType), required: false);
            WorkflowExpression.Validate(requestvisualSignaturepositions, nameof(requestvisualSignaturepositions), required: false);
            return new DeferredBodyAction<ErrorResponse>(() =>
            {
                var apiCallPath = "/seal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requesttitle != null)
                {
                    request["title"] = ExpressionConverter.ConvertO(requesttitle);
                    requestpropCount++;
                }

                requestpropCount++;
                request["content"] = ExpressionConverter.ConvertO(requestcontent);
                if (requestsealForSealing != null)
                {
                    request["account_name"] = ExpressionConverter.ConvertO(requestsealForSealing);
                    requestpropCount++;
                }

                var visualSignatureObject = new JObject();
                var visualSignatureObjectpropCount = 0;
                if (requestvisualSignatureformField != null)
                {
                    visualSignatureObject["form_field"] = ExpressionConverter.ConvertO(requestvisualSignatureformField);
                    visualSignatureObjectpropCount++;
                }

                var imageObject = new JObject();
                var imageObjectpropCount = 0;
                if (requestvisualSignatureimagecontent != null)
                {
                    imageObject["content"] = ExpressionConverter.ConvertO(requestvisualSignatureimagecontent);
                    imageObjectpropCount++;
                }

                if (requestvisualSignatureimagecontentType != null)
                {
                    imageObject["content_type"] = ExpressionConverter.ConvertO(requestvisualSignatureimagecontentType);
                    imageObjectpropCount++;
                }

                if (imageObjectpropCount > 0)
                {
                    visualSignatureObject["image"] = imageObject;
                    visualSignatureObjectpropCount++;
                }

                if (requestvisualSignaturepositions != null)
                {
                    visualSignatureObject["positions"] = ExpressionConverter.ConvertO(requestvisualSignaturepositions);
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