//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smarp
{
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
        [WorkflowExpressionFactory(nameof(__BuildSmarpCreate))]
        public IWorkflowAction SmarpCreate([WorkflowExpression] Func<string[]> bodychannelList, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyimageUrl = null, [WorkflowExpression] Func<bool> bodyproposed = null, [WorkflowExpression] Func<bool> bodyshareable = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyurl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSmarpCreate(WorkflowValue<string[]> bodychannelList, WorkflowValue<string> bodybody = null, WorkflowValue<string> bodyimageUrl = null, WorkflowValue<bool> bodyproposed = null, WorkflowValue<bool> bodyshareable = null, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodyurl = null)
        {
            WorkflowValue.Validate(bodychannelList, nameof(bodychannelList), required: true);
            WorkflowValue.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowValue.Validate(bodyimageUrl, nameof(bodyimageUrl), required: false);
            WorkflowValue.Validate(bodyproposed, nameof(bodyproposed), required: false);
            WorkflowValue.Validate(bodyshareable, nameof(bodyshareable), required: false);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: false);
            return new DeferredWorkflowAction(() =>
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
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                bodypropCount++;
                body["channelList"] = ExpressionConverter.ConvertO(bodychannelList);
                if (bodyimageUrl != null)
                {
                    body["imageUrl"] = ExpressionConverter.ConvertO(bodyimageUrl);
                    bodypropCount++;
                }

                if (bodyproposed != null)
                {
                    if (bodyproposed != null)
                    {
                        body["proposed"] = ExpressionConverter.ConvertO(bodyproposed);
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
                        body["shareable"] = ExpressionConverter.ConvertO(bodyshareable);
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
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyurl);
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
