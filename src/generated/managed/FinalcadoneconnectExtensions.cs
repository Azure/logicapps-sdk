//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finalcadoneconnect
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinalcadoneconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        [WorkflowExpressionFactory(nameof(__BuildGetOrganizations))]
        public IBodyWorkflowAction<GetOrganizationsResponseItem[]> GetOrganizations([WorkflowExpression] Func<string> acceptLanguage = null, [WorkflowExpression] Func<string> xTimeZone = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOrganizationsResponseItem[]> __BuildGetOrganizations(WorkflowValue<string> acceptLanguage = null, WorkflowValue<string> xTimeZone = null)
        {
            WorkflowValue.Validate(acceptLanguage, nameof(acceptLanguage), required: false);
            WorkflowValue.Validate(xTimeZone, nameof(xTimeZone), required: false);
            return new DeferredBodyAction<GetOrganizationsResponseItem[]>(() =>
            {
                var apiCallPath = "/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en");
                if (acceptLanguage != null)
                    callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(acceptLanguage);
                callPayload.Headers["X-TimeZone"] = Convert.ToString("");
                if (xTimeZone != null)
                    callPayload.Headers["X-TimeZone"] = ExpressionConverter.Convert(xTimeZone);
                return new ApiConnectionAction<GetOrganizationsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        [WorkflowExpressionFactory(nameof(__BuildInitParameters))]
        public IBodyWorkflowAction<InitParametersResponse> InitParameters([WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytheUserSTimeZoneInIANAFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InitParametersResponse> __BuildInitParameters(WorkflowValue<string> bodylanguage = null, WorkflowValue<string> bodytheUserSTimeZoneInIANAFormat = null)
        {
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodytheUserSTimeZoneInIANAFormat, nameof(bodytheUserSTimeZoneInIANAFormat), required: false);
            return new DeferredBodyAction<InitParametersResponse>(() =>
            {
                var apiCallPath = "/InitParameters";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "fr";
                    bodypropCount++;
                }

                if (bodytheUserSTimeZoneInIANAFormat != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(bodytheUserSTimeZoneInIANAFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InitParametersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        [WorkflowExpressionFactory(nameof(__BuildInit))]
        public IBodyWorkflowAction<InitResponse> Init([WorkflowExpression] Func<string> bodyorganizationID = null, [WorkflowExpression] Func<string> bodyprojectID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InitResponse> __BuildInit(WorkflowValue<string> bodyorganizationID = null, WorkflowValue<string> bodyprojectID = null)
        {
            WorkflowValue.Validate(bodyorganizationID, nameof(bodyorganizationID), required: false);
            WorkflowValue.Validate(bodyprojectID, nameof(bodyprojectID), required: false);
            return new DeferredBodyAction<InitResponse>(() =>
            {
                var apiCallPath = "/init";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorganizationID != null)
                {
                    body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
                    bodypropCount++;
                }

                if (bodyprojectID != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InitResponse>(callPayload);
            });
        }
    }

    public class FinalcadoneconnectTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildThenObsCreated))]
        public IWorkflowTrigger ThenObsCreated([WorkflowExpression] Func<string> bodyorganizationID, [WorkflowExpression] Func<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenObsCreated(WorkflowValue<string> bodyorganizationID, WorkflowValue<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowValue.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/201";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildThenObsUpdated))]
        public IWorkflowTrigger ThenObsUpdated([WorkflowExpression] Func<string> bodyorganizationID, [WorkflowExpression] Func<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenObsUpdated(WorkflowValue<string> bodyorganizationID, WorkflowValue<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowValue.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/202";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildThenFormCreated))]
        public IWorkflowTrigger ThenFormCreated([WorkflowExpression] Func<string> bodyorganizationID, [WorkflowExpression] Func<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenFormCreated(WorkflowValue<string> bodyorganizationID, WorkflowValue<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowValue.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/301";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildThenFormUpdated))]
        public IWorkflowTrigger ThenFormUpdated([WorkflowExpression] Func<string> bodyorganizationID, [WorkflowExpression] Func<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenFormUpdated(WorkflowValue<string> bodyorganizationID, WorkflowValue<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowValue.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/302";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildThenDocumentCreated))]
        public IWorkflowTrigger ThenDocumentCreated([WorkflowExpression] Func<string> bodyorganizationID, [WorkflowExpression] Func<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenDocumentCreated(WorkflowValue<string> bodyorganizationID, WorkflowValue<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowValue.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhooks/ev/401";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
                bodypropCount++;
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class GetOrganizationsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InitParametersResponse
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class InitResponse
    {
        [JsonProperty("business_organization_id")]
        public string BusinessOrganizationId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Finalcadoneconnect;

    public partial class WorkflowManagedActions
    {
        public FinalcadoneconnectActions Finalcadoneconnect(string connectionId) => new FinalcadoneconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinalcadoneconnectTriggers Finalcadoneconnect(string connectionId) => new FinalcadoneconnectTriggers(connectionId);
    }
}
