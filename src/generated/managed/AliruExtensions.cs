//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aliru
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AliruActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNews(Expression<Func<string>> bodyheadline, Expression<Func<string>> bodytext, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodypictureURL = null, Expression<Func<string>> bodytags = null, Expression<Func<int>> bodytimeToLiveInDays = null, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_bodyheadline = bodyheadline == null ? null : WorkflowExpression.Compile(bodyheadline);
            WorkflowExpression.Validate(__workflow_bodyheadline, nameof(bodyheadline), required: true);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: true);
            var __workflow_bodyuRL = bodyuRL == null ? null : WorkflowExpression.Compile(bodyuRL);
            WorkflowExpression.Validate(__workflow_bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodypictureURL = bodypictureURL == null ? null : WorkflowExpression.Compile(bodypictureURL);
            WorkflowExpression.Validate(__workflow_bodypictureURL, nameof(bodypictureURL), required: false);
            var __workflow_bodytags = bodytags == null ? null : WorkflowExpression.Compile(bodytags);
            WorkflowExpression.Validate(__workflow_bodytags, nameof(bodytags), required: false);
            var __workflow_bodytimeToLiveInDays = bodytimeToLiveInDays == null ? null : WorkflowExpression.Compile(bodytimeToLiveInDays);
            WorkflowExpression.Validate(__workflow_bodytimeToLiveInDays, nameof(bodytimeToLiveInDays), required: false);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/SendNews";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Headline"] = ExpressionConverter.ConvertO(__workflow_bodyheadline);
                bodypropCount++;
                body["Text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyuRL != null)
                {
                    body["URL"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodypictureURL != null)
                {
                    body["PictureURL"] = ExpressionConverter.ConvertO(__workflow_bodypictureURL);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["Tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodytimeToLiveInDays != null)
                {
                    body["TimeToLiveInDays"] = ExpressionConverter.ConvertO(__workflow_bodytimeToLiveInDays);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["UserId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNotification(Expression<Func<string>> bodytext, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: true);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/SendNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyuserId != null)
                {
                    body["UserId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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
