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
            var apiCallPath = "/publicapi/channel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<SmarpRetrieveChannelListResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smarp")]
        public IWorkflowAction SmarpCreate(Expression<Func<string[]>> bodychannelList, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyimageUrl = null, Expression<Func<bool>> bodyproposed = null, Expression<Func<bool>> bodyshareable = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyurl = null)
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
                body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            bodypropCount++;
            body["channelList"] = CSharpExpressionConverter.ConvertToken(bodychannelList);
            if (bodyimageUrl != null)
            {
                body["imageUrl"] = CSharpExpressionConverter.ConvertToken(bodyimageUrl);
                bodypropCount++;
            }

            if (bodyproposed != null)
            {
                if (bodyproposed != null)
                {
                    body["proposed"] = CSharpExpressionConverter.ConvertToken(bodyproposed);
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
                    body["shareable"] = CSharpExpressionConverter.ConvertToken(bodyshareable);
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
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyurl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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