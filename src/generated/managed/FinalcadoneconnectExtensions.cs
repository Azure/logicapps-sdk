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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOrganizationsResponseItem[]> __BuildGetOrganizations(WorkflowExpression<string> acceptLanguage = null, WorkflowExpression<string> xTimeZone = null)
        {
            WorkflowExpression.Validate(acceptLanguage, nameof(acceptLanguage), required: false);
            WorkflowExpression.Validate(xTimeZone, nameof(xTimeZone), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InitParametersResponse> __BuildInitParameters(WorkflowExpression<string> bodylanguage = null, WorkflowExpression<string> bodytheUserSTimeZoneInIANAFormat = null)
        {
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowExpression.Validate(bodytheUserSTimeZoneInIANAFormat, nameof(bodytheUserSTimeZoneInIANAFormat), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InitResponse> __BuildInit(WorkflowExpression<string> bodyorganizationID = null, WorkflowExpression<string> bodyprojectID = null)
        {
            WorkflowExpression.Validate(bodyorganizationID, nameof(bodyorganizationID), required: false);
            WorkflowExpression.Validate(bodyprojectID, nameof(bodyprojectID), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenObsCreated(WorkflowExpression<string> bodyorganizationID, WorkflowExpression<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowExpression.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenObsUpdated(WorkflowExpression<string> bodyorganizationID, WorkflowExpression<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowExpression.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenFormCreated(WorkflowExpression<string> bodyorganizationID, WorkflowExpression<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowExpression.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenFormUpdated(WorkflowExpression<string> bodyorganizationID, WorkflowExpression<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowExpression.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildThenDocumentCreated(WorkflowExpression<string> bodyorganizationID, WorkflowExpression<string> bodyprojectID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyorganizationID, nameof(bodyorganizationID), required: true);
            WorkflowExpression.Validate(bodyprojectID, nameof(bodyprojectID), required: true);
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