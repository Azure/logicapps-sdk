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
        [WorkflowExpressionFactory(nameof(__BuildSendNews))]
        public IWorkflowAction SendNews([WorkflowExpression] Func<string> bodyheadline, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodypictureURL = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<int> bodytimeToLiveInDays = null, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendNews(WorkflowExpression<string> bodyheadline, WorkflowExpression<string> bodytext, WorkflowExpression<string> bodyuRL = null, WorkflowExpression<string> bodypictureURL = null, WorkflowExpression<string> bodytags = null, WorkflowExpression<int> bodytimeToLiveInDays = null, WorkflowExpression<string> bodyuserId = null)
        {
            WorkflowExpression.Validate(bodyheadline, nameof(bodyheadline), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodyuRL, nameof(bodyuRL), required: false);
            WorkflowExpression.Validate(bodypictureURL, nameof(bodypictureURL), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowExpression.Validate(bodytimeToLiveInDays, nameof(bodytimeToLiveInDays), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        [WorkflowExpressionFactory(nameof(__BuildSendNotification))]
        public IWorkflowAction SendNotification([WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aliru")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendNotification(WorkflowExpression<string> bodytext, WorkflowExpression<string> bodyuserId = null)
        {
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
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