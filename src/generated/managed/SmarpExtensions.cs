//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smarp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmarpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smarp")]
        public IBodyWorkflowAction<SmarpRetrieveChannelListResponseItem[]> SmarpRetrieveChannelList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/channel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<SmarpRetrieveChannelListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smarp")]
        public IWorkflowAction SmarpCreate([WorkflowExpression] Func<string[]> bodychannelList, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<bool> bodyproposed = null, [WorkflowExpression] Func<bool> bodyshareable = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyurl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/post";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                bodypropCount++;
                body["channelList"] = SourceExpressionConverter.ConvertToken(bodychannelList);
                if (bodyimageUrl != null)
                {
                    body["imageUrl"] = SourceExpressionConverter.ConvertToken(bodyimageUrl);
                    bodypropCount++;
                }

                if (bodyproposed != null)
                {
                    if (bodyproposed != null)
                    {
                        body["proposed"] = SourceExpressionConverter.ConvertToken(bodyproposed);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["proposed"] = true;
                    bodypropCount++;
                }

                if (bodyshareable != null)
                {
                    if (bodyshareable != null)
                    {
                        body["shareable"] = SourceExpressionConverter.ConvertToken(bodyshareable);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["shareable"] = true;
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
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