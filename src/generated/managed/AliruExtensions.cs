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
        public IWorkflowAction SendNews(Expression<Func<string>> bodyHeadline, Expression<Func<string>> bodyText, Expression<Func<string>> bodyURL = null, Expression<Func<string>> bodyPictureURL = null, Expression<Func<string>> bodyTags = null, Expression<Func<int>> bodyTimeToLiveInDays = null, Expression<Func<string>> bodyUserId = null)
        {
            var apiCallPath = "/api/SendNews";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Headline"] = ExpressionConverter.ConvertO(bodyHeadline);
            bodypropCount++;
            body["Text"] = ExpressionConverter.ConvertO(bodyText);
            if (bodyURL != null)
            {
                body["URL"] = ExpressionConverter.ConvertO(bodyURL);
                bodypropCount++;
            }

            if (bodyPictureURL != null)
            {
                body["PictureURL"] = ExpressionConverter.ConvertO(bodyPictureURL);
                bodypropCount++;
            }

            if (bodyTags != null)
            {
                body["Tags"] = ExpressionConverter.ConvertO(bodyTags);
                bodypropCount++;
            }

            if (bodyTimeToLiveInDays != null)
            {
                body["TimeToLiveInDays"] = ExpressionConverter.ConvertO(bodyTimeToLiveInDays);
                bodypropCount++;
            }

            if (bodyUserId != null)
            {
                body["UserId"] = ExpressionConverter.ConvertO(bodyUserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNotification(Expression<Func<string>> bodyText, Expression<Func<string>> bodyUserId = null)
        {
            var apiCallPath = "/api/SendNotification";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Text"] = ExpressionConverter.ConvertO(bodyText);
            if (bodyUserId != null)
            {
                body["UserId"] = ExpressionConverter.ConvertO(bodyUserId);
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