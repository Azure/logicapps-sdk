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
        public IWorkflowAction SendNews(Expression<Func<string>> bodyheadline, Expression<Func<string>> bodytext, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodypictureURL = null, Expression<Func<string>> bodytags = null, Expression<Func<int>> bodytimeToLiveInDays = null, Expression<Func<string>> bodyuserId = null)
        {
            var apiCallPath = "/api/SendNews";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Headline"] = CSharpExpressionConverter.ConvertToken(bodyheadline);
            bodypropCount++;
            body["Text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            if (bodyuRL != null)
            {
                body["URL"] = CSharpExpressionConverter.ConvertToken(bodyuRL);
                bodypropCount++;
            }

            if (bodypictureURL != null)
            {
                body["PictureURL"] = CSharpExpressionConverter.ConvertToken(bodypictureURL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["Tags"] = CSharpExpressionConverter.ConvertToken(bodytags);
                bodypropCount++;
            }

            if (bodytimeToLiveInDays != null)
            {
                body["TimeToLiveInDays"] = CSharpExpressionConverter.ConvertToken(bodytimeToLiveInDays);
                bodypropCount++;
            }

            if (bodyuserId != null)
            {
                body["UserId"] = CSharpExpressionConverter.ConvertToken(bodyuserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNotification(Expression<Func<string>> bodytext, Expression<Func<string>> bodyuserId = null)
        {
            var apiCallPath = "/api/SendNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Text"] = CSharpExpressionConverter.ConvertToken(bodytext);
            if (bodyuserId != null)
            {
                body["UserId"] = CSharpExpressionConverter.ConvertToken(bodyuserId);
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