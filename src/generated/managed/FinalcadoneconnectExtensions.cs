//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finalcadoneconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinalcadoneconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<GetOrganizationsResponseItem[]> GetOrganizations([WorkflowExpression] Func<string> acceptLanguage = null, [WorkflowExpression] Func<string> xTimeZone = null)
        {
            SourceExpression.Validate(acceptLanguage, nameof(acceptLanguage), required: false);
            SourceExpression.Validate(xTimeZone, nameof(xTimeZone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en");
                if (acceptLanguage != null)
                    callPayload.Headers["Accept-Language"] = SourceExpressionConverter.ConvertO(acceptLanguage);
                callPayload.Headers["X-TimeZone"] = Convert.ToString("");
                if (xTimeZone != null)
                    callPayload.Headers["X-TimeZone"] = SourceExpressionConverter.ConvertO(xTimeZone);
                return callPayload;
            }

            return new ApiConnectionAction<GetOrganizationsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitParametersResponse> InitParameters([WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodytheUserSTimeZoneInIANAFormat = null)
        {
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodytheUserSTimeZoneInIANAFormat, nameof(bodytheUserSTimeZoneInIANAFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
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
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytheUserSTimeZoneInIANAFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InitParametersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitResponse> Init([WorkflowExpression] Func<string> bodyorganizationId = null, [WorkflowExpression] Func<string> bodyprojectId = null)
        {
            SourceExpression.Validate(bodyorganizationId, nameof(bodyorganizationId), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/init";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorganizationId != null)
                {
                    body["business_organization_id"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InitResponse>(BuildSourceInput);
        }
    }

    public class FinalcadoneconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ThenObsCreated([WorkflowExpression] Func<string> bodyorganizationId, [WorkflowExpression] Func<string> bodyprojectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyorganizationId, nameof(bodyorganizationId), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/ev/201";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                bodypropCount++;
                body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ThenObsUpdated([WorkflowExpression] Func<string> bodyorganizationId, [WorkflowExpression] Func<string> bodyprojectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyorganizationId, nameof(bodyorganizationId), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/ev/202";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                bodypropCount++;
                body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ThenFormCreated([WorkflowExpression] Func<string> bodyorganizationId, [WorkflowExpression] Func<string> bodyprojectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyorganizationId, nameof(bodyorganizationId), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/ev/301";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                bodypropCount++;
                body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ThenFormUpdated([WorkflowExpression] Func<string> bodyorganizationId, [WorkflowExpression] Func<string> bodyprojectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyorganizationId, nameof(bodyorganizationId), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/ev/302";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                bodypropCount++;
                body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ThenDocumentCreated([WorkflowExpression] Func<string> bodyorganizationId, [WorkflowExpression] Func<string> bodyprojectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyorganizationId, nameof(bodyorganizationId), required: true);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/ev/401";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["business_organization_id"] = SourceExpressionConverter.ConvertToken(bodyorganizationId);
                bodypropCount++;
                body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                body["client_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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