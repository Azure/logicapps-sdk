//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zforms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ZformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zforms")]
        public IBodyWorkflowAction<GetAvailableFormsResponse> GetAvailableForms()
        {
            var apiCallPath = "/api/zforms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["zf_service"] = Convert.ToString("MSPowerAutomate");
            return new ApiConnectionAction<GetAvailableFormsResponse>(callPayload);
        }
    }

    public class ZformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<FormSubmittedResponse> FormSubmitted(Expression<Func<string>> formlinkname, FlowRecurrence recurrence = null)
        {
            var __workflow_formlinkname = formlinkname == null ? null : WorkflowExpression.Compile(formlinkname);
            WorkflowExpression.Validate(__workflow_formlinkname, nameof(formlinkname), required: true);
            return new DeferredBodyTrigger<FormSubmittedResponse>(() =>
            {
                var apiCallPath = "/api/resthooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["formlinkname"] = ExpressionConverter.Convert(__workflow_formlinkname);
                callPayload.Headers["zf_service"] = Convert.ToString("MSPowerAutomate");
                callPayload.Headers["zf_version"] = Convert.ToString(2);
                callPayload.Headers["webhooks_url"] = Convert.ToString("#{listCallbackUrl()}");
                return new ApiConnectionTrigger<FormSubmittedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetAvailableFormsResponse
    {
        [JsonProperty("forms")]
        public GetAvailableFormsResponseFormsTypeItem[] Forms { get; set; }
    }

    public class GetAvailableFormsResponseFormsTypeItem
    {
        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("link_name")]
        public string LinkName { get; set; }
    }

    public class FormSubmittedResponse
    {
        [JsonProperty("response")]
        public FormSubmittedResponseResponseType Response { get; set; }
    }

    public class FormSubmittedResponseResponseType
    {
        [JsonProperty("link_name")]
        public string LinkName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("field_type")]
        public string FieldType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zforms;

    public partial class WorkflowManagedActions
    {
        public ZformsActions Zforms(string connectionId) => new ZformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZformsTriggers Zforms(string connectionId) => new ZformsTriggers(connectionId);
    }
}
