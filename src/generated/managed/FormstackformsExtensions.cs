//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Formstackforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FormstackformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "formstackforms")]
        public IBodyWorkflowAction<GetAvailableFormsResponse> GetAvailableForms()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/form/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAvailableFormsResponse>(BuildSourceInput);
        }
    }

    public class FormstackformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<FormstackFormSubmittedResponse> FormstackFormSubmitted([WorkflowExpression] Func<int> formId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/form/{0}/webhook/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["content_type"] = "json";
                bodypropCount++;
                body["file_transfer_type"] = "base64encode";
                bodypropCount++;
                body["standardize_field_values"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<FormstackFormSubmittedResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class GetAvailableFormsResponse
    {
        [JsonProperty("forms")]
        public GetAvailableFormsResponseFormsTypeItem[] Forms { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetAvailableFormsResponseFormsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FormstackFormSubmittedResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Formstackforms;

    public partial class WorkflowManagedActions
    {
        public FormstackformsActions Formstackforms(string connectionId) => new FormstackformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FormstackformsTriggers Formstackforms(string connectionId) => new FormstackformsTriggers(connectionId);
    }
}