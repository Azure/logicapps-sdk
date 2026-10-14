//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smarp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SmarpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smarp")]
        public IBodyWorkflowAction<SmarpRetrieveChannelListResponseItem[]> SmarpRetrieveChannelList()
        {
            var apiCallPath = "/publicapi/channel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<SmarpRetrieveChannelListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smarp")]
        public IWorkflowAction SmarpCreate(Expression<Func<string[]>> bodychannelList, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<bool>> bodyproposed = null, Expression<Func<bool>> bodyshareable = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyurl = null)
        {
            var __workflow_bodychannelList = bodychannelList == null ? null : WorkflowExpression.Compile(bodychannelList);
            WorkflowExpression.Validate(__workflow_bodychannelList, nameof(bodychannelList), required: true);
            var __workflow_bodybody = bodybody == null ? null : WorkflowExpression.Compile(bodybody);
            WorkflowExpression.Validate(__workflow_bodybody, nameof(bodybody), required: false);
            var __workflow_bodyimageUrl = bodyimageUrl == null ? null : WorkflowExpression.Compile(bodyimageUrl);
            WorkflowExpression.Validate(__workflow_bodyimageUrl, nameof(bodyimageUrl), required: false);
            var __workflow_bodyproposed = bodyproposed == null ? null : WorkflowExpression.Compile(bodyproposed);
            WorkflowExpression.Validate(__workflow_bodyproposed, nameof(bodyproposed), required: false);
            var __workflow_bodyshareable = bodyshareable == null ? null : WorkflowExpression.Compile(bodyshareable);
            WorkflowExpression.Validate(__workflow_bodyshareable, nameof(bodyshareable), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyurl = bodyurl == null ? null : WorkflowExpression.Compile(bodyurl);
            WorkflowExpression.Validate(__workflow_bodyurl, nameof(bodyurl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/publicapi/post";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                bodypropCount++;
                body["channelList"] = ExpressionConverter.ConvertO(__workflow_bodychannelList);
                if (__workflow_bodyimageUrl != null)
                {
                    body["imageUrl"] = ExpressionConverter.ConvertO(__workflow_bodyimageUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyproposed != null)
                {
                    if (__workflow_bodyproposed != null)
                    {
                        body["proposed"] = ExpressionConverter.ConvertO(__workflow_bodyproposed);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["proposed"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyshareable != null)
                {
                    if (__workflow_bodyshareable != null)
                    {
                        body["shareable"] = ExpressionConverter.ConvertO(__workflow_bodyshareable);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["shareable"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
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

    public class SmarpTriggers([ConnectionName] string connectionId)
    {
    }

    public class SmarpRetrieveChannelListResponseItem
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smarp;

    public partial class WorkflowManagedActions
    {
        public SmarpActions Smarp(string connectionId) => new SmarpActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmarpTriggers Smarp(string connectionId) => new SmarpTriggers(connectionId);
    }
}
