//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aliru
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AliruActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNews([WorkflowExpression] Func<string> bodyheadline, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodypictureURL = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<int> bodytimeToLiveInDays = null, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            var apiCallPath = "/api/SendNews";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Headline"] = ExpressionConverter.ConvertO(bodyheadline);
            bodypropCount++;
            body["Text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodyuRL != null)
            {
                body["URL"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodypictureURL != null)
            {
                body["PictureURL"] = ExpressionConverter.ConvertO(bodypictureURL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["Tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodytimeToLiveInDays != null)
            {
                body["TimeToLiveInDays"] = ExpressionConverter.ConvertO(bodytimeToLiveInDays);
                bodypropCount++;
            }

            if (bodyuserId != null)
            {
                body["UserId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNotification([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            var apiCallPath = "/api/SendNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodyuserId != null)
            {
                body["UserId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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