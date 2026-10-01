//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aliru
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AliruActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNews([WorkflowExpression] Func<string> bodyheadline, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodypictureURL = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<int> bodytimeToLiveInDays = null, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/SendNews";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Headline"] = SourceExpressionConverter.ConvertToken(bodyheadline);
                bodypropCount++;
                body["Text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyuRL != null)
                {
                    body["URL"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodypictureURL != null)
                {
                    body["PictureURL"] = SourceExpressionConverter.ConvertToken(bodypictureURL);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["Tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodytimeToLiveInDays != null)
                {
                    body["TimeToLiveInDays"] = SourceExpressionConverter.ConvertToken(bodytimeToLiveInDays);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["UserId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNotification([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/SendNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyuserId != null)
                {
                    body["UserId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class AliruTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aliru;

    public partial class WorkflowManagedActions
    {
        public AliruActions Aliru(string connectionId) => new AliruActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AliruTriggers Aliru(string connectionId) => new AliruTriggers(connectionId);
    }
}