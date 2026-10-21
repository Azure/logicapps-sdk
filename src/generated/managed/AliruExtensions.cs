//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aliru
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AliruActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNews(Expression<Func<string>> bodyheadline, Expression<Func<string>> bodytext, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodypictureURL = null, Expression<Func<string>> bodytags = null, Expression<Func<int>> bodytimeToLiveInDays = null, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_bodyheadline = WorkflowExpression.Compile(bodyheadline, nameof(bodyheadline), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodypictureURL = WorkflowExpression.Compile(bodypictureURL, nameof(bodypictureURL), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodytimeToLiveInDays = WorkflowExpression.Compile(bodytimeToLiveInDays, nameof(bodytimeToLiveInDays), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        public IWorkflowAction SendNotification(Expression<Func<string>> bodytext, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
