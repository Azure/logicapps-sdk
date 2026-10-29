//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Icm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IcmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmIncidentResponse, ApiConnectionActionConfiguration> GetIncident(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<IcmIncidentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IcmIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmRetrospectiveResponse, ApiConnectionActionConfiguration> GetRetrospectiveById(Expression<Func<string>> retrospectiveId)
        {
            var __workflow_retrospectiveId = WorkflowExpression.Compile(retrospectiveId, nameof(retrospectiveId), required: true);
            return new DeferredBodyAction<IcmRetrospectiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/retrospectives/{0}", __workflow_retrospectiveId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IcmRetrospectiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmRetrospectiveResponse, ApiConnectionActionConfiguration> GetRetrospectiveByIncidentId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<IcmRetrospectiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/retrospective", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IcmRetrospectiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmBridgesResponse, ApiConnectionActionConfiguration> GetBridgesForAnIncident(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<IcmBridgesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/bridges", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IcmBridgesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddNewIcMDiscussionEntry(Expression<Func<string>> id, Expression<Func<string>> bodydiscussionText = null, Expression<Func<bodyrenderTypeInput>> bodyrenderType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydiscussionText = WorkflowExpression.Compile(bodydiscussionText, nameof(bodydiscussionText), required: false);
            var __workflow_bodyrenderType = WorkflowExpression.Compile(bodyrenderType, nameof(bodyrenderType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/addDiscussionEntry", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydiscussionText != null)
                {
                    body["discussionText"] = ExpressionConverter.ConvertO(__workflow_bodydiscussionText);
                    bodypropCount++;
                }

                if (__workflow_bodyrenderType != null)
                {
                    body["renderType"] = ExpressionConverter.ConvertO(__workflow_bodyrenderType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmDescriptionEntriesResponse, ApiConnectionActionConfiguration> GetDescriptionEntries(Expression<Func<string>> id, Expression<Func<int>> count = null, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredBodyAction<IcmDescriptionEntriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/descriptionEntries", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(5);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                return new ApiConnectionAction<IcmDescriptionEntriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateIncidentSeverity(Expression<Func<string>> id, Expression<Func<bodyseverityInput>> bodyseverity, Expression<Func<string>> bodydescriptionEntry = null, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyseverity = WorkflowExpression.Compile(bodyseverity, nameof(bodyseverity), required: true);
            var __workflow_bodydescriptionEntry = WorkflowExpression.Compile(bodydescriptionEntry, nameof(bodydescriptionEntry), required: false);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/updateSeverity", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["severity"] = ExpressionConverter.ConvertO(__workflow_bodyseverity);
                if (__workflow_bodydescriptionEntry != null)
                {
                    body["descriptionEntry"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionEntry);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateIncidentTitle(Expression<Func<string>> id, Expression<Func<string>> bodytitle, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/updateTitle", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateIncidentOwner(Expression<Func<string>> id, Expression<Func<string>> bodyowningContactAlias, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyowningContactAlias = WorkflowExpression.Compile(bodyowningContactAlias, nameof(bodyowningContactAlias), required: true);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/updateOwner", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["owningContactAlias"] = ExpressionConverter.ConvertO(__workflow_bodyowningContactAlias);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateIncidentCustomFields(Expression<Func<string>> id, Expression<Func<string>> bodygroupType, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields, Expression<Func<string>> bodypublicId = null, Expression<Func<string>> bodycontainerId = null, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodygroupType = WorkflowExpression.Compile(bodygroupType, nameof(bodygroupType), required: true);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: true);
            var __workflow_bodypublicId = WorkflowExpression.Compile(bodypublicId, nameof(bodypublicId), required: false);
            var __workflow_bodycontainerId = WorkflowExpression.Compile(bodycontainerId, nameof(bodycontainerId), required: false);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/updateCustomFields", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupType"] = ExpressionConverter.ConvertO(__workflow_bodygroupType);
                if (__workflow_bodypublicId != null)
                {
                    body["publicId"] = ExpressionConverter.ConvertO(__workflow_bodypublicId);
                    bodypropCount++;
                }

                if (__workflow_bodycontainerId != null)
                {
                    body["containerId"] = ExpressionConverter.ConvertO(__workflow_bodycontainerId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["customFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateIncidentSingleCustomField(Expression<Func<string>> id, Expression<Func<string>> bodycustomField, Expression<Func<string>> bodyvalue, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycustomField = WorkflowExpression.Compile(bodycustomField, nameof(bodycustomField), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/updateSingleCustomField", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["field"] = ExpressionConverter.ConvertO(__workflow_bodycustomField);
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateIncidentTags(Expression<Func<string>> id, Expression<Func<string[]>> bodytags, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: true);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/updateTags", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<TagUserInDiscussionResponse, ApiConnectionActionConfiguration> TagUserInDiscussion(Expression<Func<string>> id, Expression<Func<string>> bodyrecipientEmail, Expression<Func<string>> bodydiscussionText, Expression<Func<string>> bodyrecipientDisplayName = null, Expression<Func<string>> bodymentionerDisplayName = null, Expression<Func<string>> bodymentionerAlias = null, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyrecipientEmail = WorkflowExpression.Compile(bodyrecipientEmail, nameof(bodyrecipientEmail), required: true);
            var __workflow_bodydiscussionText = WorkflowExpression.Compile(bodydiscussionText, nameof(bodydiscussionText), required: true);
            var __workflow_bodyrecipientDisplayName = WorkflowExpression.Compile(bodyrecipientDisplayName, nameof(bodyrecipientDisplayName), required: false);
            var __workflow_bodymentionerDisplayName = WorkflowExpression.Compile(bodymentionerDisplayName, nameof(bodymentionerDisplayName), required: false);
            var __workflow_bodymentionerAlias = WorkflowExpression.Compile(bodymentionerAlias, nameof(bodymentionerAlias), required: false);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredBodyAction<TagUserInDiscussionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/tagUser", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipient"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientEmail);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodydiscussionText);
                if (__workflow_bodyrecipientDisplayName != null)
                {
                    body["recipientDisplayName"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientDisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodymentionerDisplayName != null)
                {
                    body["mentionerDisplayName"] = ExpressionConverter.ConvertO(__workflow_bodymentionerDisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodymentionerAlias != null)
                {
                    body["mentionerAlias"] = ExpressionConverter.ConvertO(__workflow_bodymentionerAlias);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TagUserInDiscussionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IncidentAddUpdateResult, ApiConnectionActionConfiguration> CreateIcMIncident(Expression<Func<string>> bodyconnectorId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyowningTeam = null, Expression<Func<string>> bodycorrelationId = null, Expression<Func<string>> bodyroutingId = null, Expression<Func<bodyhowFoundInput>> bodyhowFound = null, Expression<Func<bodyseverityInput>> bodyseverity = null, Expression<Func<string>> bodydiscussionEntrydiscussionText = null, Expression<Func<bodydiscussionEntryrenderTypeInput>> bodydiscussionEntryrenderType = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodytags = null, Expression<Func<bodycloudInstanceInput>> bodycloudInstance = null, Expression<Func<string>> bodyoccurringLocationenvironment = null, Expression<Func<string>> bodyoccurringLocationdcRegion = null, Expression<Func<string>> bodyoccurringLocationinstanceCluster = null, Expression<Func<string>> bodyoccurringLocationrole = null, Expression<Func<string>> bodyoccurringLocationslice = null, Expression<Func<bool>> bodyisRestrictedIncident = null, Expression<Func<bool>> bodyisSecurityRisk = null, Expression<Func<IcmAccessClaim[]>> bodyaccessRestrictedToClaims = null)
        {
            var __workflow_bodyconnectorId = WorkflowExpression.Compile(bodyconnectorId, nameof(bodyconnectorId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyowningTeam = WorkflowExpression.Compile(bodyowningTeam, nameof(bodyowningTeam), required: false);
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: false);
            var __workflow_bodyroutingId = WorkflowExpression.Compile(bodyroutingId, nameof(bodyroutingId), required: false);
            var __workflow_bodyhowFound = WorkflowExpression.Compile(bodyhowFound, nameof(bodyhowFound), required: false);
            var __workflow_bodyseverity = WorkflowExpression.Compile(bodyseverity, nameof(bodyseverity), required: false);
            var __workflow_bodydiscussionEntrydiscussionText = WorkflowExpression.Compile(bodydiscussionEntrydiscussionText, nameof(bodydiscussionEntrydiscussionText), required: false);
            var __workflow_bodydiscussionEntryrenderType = WorkflowExpression.Compile(bodydiscussionEntryrenderType, nameof(bodydiscussionEntryrenderType), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodycloudInstance = WorkflowExpression.Compile(bodycloudInstance, nameof(bodycloudInstance), required: false);
            var __workflow_bodyoccurringLocationenvironment = WorkflowExpression.Compile(bodyoccurringLocationenvironment, nameof(bodyoccurringLocationenvironment), required: false);
            var __workflow_bodyoccurringLocationdcRegion = WorkflowExpression.Compile(bodyoccurringLocationdcRegion, nameof(bodyoccurringLocationdcRegion), required: false);
            var __workflow_bodyoccurringLocationinstanceCluster = WorkflowExpression.Compile(bodyoccurringLocationinstanceCluster, nameof(bodyoccurringLocationinstanceCluster), required: false);
            var __workflow_bodyoccurringLocationrole = WorkflowExpression.Compile(bodyoccurringLocationrole, nameof(bodyoccurringLocationrole), required: false);
            var __workflow_bodyoccurringLocationslice = WorkflowExpression.Compile(bodyoccurringLocationslice, nameof(bodyoccurringLocationslice), required: false);
            var __workflow_bodyisRestrictedIncident = WorkflowExpression.Compile(bodyisRestrictedIncident, nameof(bodyisRestrictedIncident), required: false);
            var __workflow_bodyisSecurityRisk = WorkflowExpression.Compile(bodyisSecurityRisk, nameof(bodyisSecurityRisk), required: false);
            var __workflow_bodyaccessRestrictedToClaims = WorkflowExpression.Compile(bodyaccessRestrictedToClaims, nameof(bodyaccessRestrictedToClaims), required: false);
            return new DeferredBodyAction<IncidentAddUpdateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/icm/incidents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyowningTeam != null)
                {
                    body["owningTeam"] = ExpressionConverter.ConvertO(__workflow_bodyowningTeam);
                    bodypropCount++;
                }

                bodypropCount++;
                body["connectorId"] = ExpressionConverter.ConvertO(__workflow_bodyconnectorId);
                if (__workflow_bodycorrelationId != null)
                {
                    body["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                    bodypropCount++;
                }

                if (__workflow_bodyroutingId != null)
                {
                    body["routingId"] = ExpressionConverter.ConvertO(__workflow_bodyroutingId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodyhowFound != null)
                {
                    body["howFound"] = ExpressionConverter.ConvertO(__workflow_bodyhowFound);
                    bodypropCount++;
                }

                if (__workflow_bodyseverity != null)
                {
                    body["severity"] = ExpressionConverter.ConvertO(__workflow_bodyseverity);
                    bodypropCount++;
                }

                var discussionEntryObject = new JObject();
                var discussionEntryObjectpropCount = 0;
                if (__workflow_bodydiscussionEntrydiscussionText != null)
                {
                    discussionEntryObject["discussionText"] = ExpressionConverter.ConvertO(__workflow_bodydiscussionEntrydiscussionText);
                    discussionEntryObjectpropCount++;
                }

                if (__workflow_bodydiscussionEntryrenderType != null)
                {
                    discussionEntryObject["renderType"] = ExpressionConverter.ConvertO(__workflow_bodydiscussionEntryrenderType);
                    discussionEntryObjectpropCount++;
                }

                if (discussionEntryObjectpropCount > 0)
                {
                    body["discussionEntry"] = discussionEntryObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodycloudInstance != null)
                {
                    body["cloudInstance"] = ExpressionConverter.ConvertO(__workflow_bodycloudInstance);
                    bodypropCount++;
                }

                var occurringLocationObject = new JObject();
                var occurringLocationObjectpropCount = 0;
                if (__workflow_bodyoccurringLocationenvironment != null)
                {
                    occurringLocationObject["environment"] = ExpressionConverter.ConvertO(__workflow_bodyoccurringLocationenvironment);
                    occurringLocationObjectpropCount++;
                }

                if (__workflow_bodyoccurringLocationdcRegion != null)
                {
                    occurringLocationObject["dcRegion"] = ExpressionConverter.ConvertO(__workflow_bodyoccurringLocationdcRegion);
                    occurringLocationObjectpropCount++;
                }

                if (__workflow_bodyoccurringLocationinstanceCluster != null)
                {
                    occurringLocationObject["instanceCluster"] = ExpressionConverter.ConvertO(__workflow_bodyoccurringLocationinstanceCluster);
                    occurringLocationObjectpropCount++;
                }

                if (__workflow_bodyoccurringLocationrole != null)
                {
                    occurringLocationObject["role"] = ExpressionConverter.ConvertO(__workflow_bodyoccurringLocationrole);
                    occurringLocationObjectpropCount++;
                }

                if (__workflow_bodyoccurringLocationslice != null)
                {
                    occurringLocationObject["slice"] = ExpressionConverter.ConvertO(__workflow_bodyoccurringLocationslice);
                    occurringLocationObjectpropCount++;
                }

                if (occurringLocationObjectpropCount > 0)
                {
                    body["occurringLocation"] = occurringLocationObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisRestrictedIncident != null)
                {
                    body["isRestrictedIncident"] = ExpressionConverter.ConvertO(__workflow_bodyisRestrictedIncident);
                    bodypropCount++;
                }

                if (__workflow_bodyisSecurityRisk != null)
                {
                    body["isSecurityRisk"] = ExpressionConverter.ConvertO(__workflow_bodyisSecurityRisk);
                    bodypropCount++;
                }

                if (__workflow_bodyaccessRestrictedToClaims != null)
                {
                    body["accessRestrictedToClaims"] = ExpressionConverter.ConvertO(__workflow_bodyaccessRestrictedToClaims);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IncidentAddUpdateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmIncidentSearchResponse, ApiConnectionActionConfiguration> SearchIncidents(Expression<Func<string>> filter, Expression<Func<string>> select = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<searchEndpointInput>> searchEndpoint = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_searchEndpoint = WorkflowExpression.Compile(searchEndpoint, nameof(searchEndpoint), required: false);
            return new DeferredBodyAction<IcmIncidentSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/icm/incidents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["searchEndpoint"] = Convert.ToString("Public");
                if (__workflow_searchEndpoint != null)
                    callPayload.Queries["searchEndpoint"] = ExpressionConverter.Convert(__workflow_searchEndpoint);
                return new ApiConnectionAction<IcmIncidentSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<OmnisearchIncidentsResponse, ApiConnectionActionConfiguration> SearchIncidentsOmnisearch(Expression<Func<string>> bodysearchString, Expression<Func<bool>> bodyincludeCorrelated = null, Expression<Func<string>> bodyorderColumn = null, Expression<Func<bodyorderDirectionInput>> bodyorderDirection = null, Expression<Func<int>> bodyskip = null, Expression<Func<int>> bodytop = null, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_bodysearchString = WorkflowExpression.Compile(bodysearchString, nameof(bodysearchString), required: true);
            var __workflow_bodyincludeCorrelated = WorkflowExpression.Compile(bodyincludeCorrelated, nameof(bodyincludeCorrelated), required: false);
            var __workflow_bodyorderColumn = WorkflowExpression.Compile(bodyorderColumn, nameof(bodyorderColumn), required: false);
            var __workflow_bodyorderDirection = WorkflowExpression.Compile(bodyorderDirection, nameof(bodyorderDirection), required: false);
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: false);
            var __workflow_bodytop = WorkflowExpression.Compile(bodytop, nameof(bodytop), required: false);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredBodyAction<OmnisearchIncidentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/icm/incidents/omnisearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["searchString"] = ExpressionConverter.ConvertO(__workflow_bodysearchString);
                if (__workflow_bodyincludeCorrelated != null)
                {
                    if (__workflow_bodyincludeCorrelated != null)
                    {
                        body["includeCorrelated"] = ExpressionConverter.ConvertO(__workflow_bodyincludeCorrelated);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeCorrelated"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyorderColumn != null)
                {
                    if (__workflow_bodyorderColumn != null)
                    {
                        body["orderColumn"] = ExpressionConverter.ConvertO(__workflow_bodyorderColumn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["orderColumn"] = "CreateDate";
                    bodypropCount++;
                }

                if (__workflow_bodyorderDirection != null)
                {
                    if (__workflow_bodyorderDirection != null)
                    {
                        body["orderDir"] = ExpressionConverter.ConvertO(__workflow_bodyorderDirection);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["orderDir"] = "desc";
                    bodypropCount++;
                }

                if (__workflow_bodyskip != null)
                {
                    if (__workflow_bodyskip != null)
                    {
                        body["skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["skip"] = 0;
                    bodypropCount++;
                }

                if (__workflow_bodytop != null)
                {
                    if (__workflow_bodytop != null)
                    {
                        body["top"] = ExpressionConverter.ConvertO(__workflow_bodytop);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["top"] = 100;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OmnisearchIncidentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> CheckUserAccess(Expression<Func<string>> id, Expression<Func<string>> upn, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_upn = WorkflowExpression.Compile(upn, nameof(upn), required: true);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/checkuseraccess", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["upn"] = ExpressionConverter.Convert(__workflow_upn);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmTeamSearchResponse, ApiConnectionActionConfiguration> SearchIcMTeams(Expression<Func<string>> publicId = null, Expression<Func<string>> name = null, Expression<Func<bool>> includeMembers = null, Expression<Func<int>> skip = null)
        {
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_includeMembers = WorkflowExpression.Compile(includeMembers, nameof(includeMembers), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<IcmTeamSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/icm/teams/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_publicId != null)
                    callPayload.Queries["publicId"] = ExpressionConverter.Convert(__workflow_publicId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["includeMembers"] = Convert.ToString(false);
                if (__workflow_includeMembers != null)
                    callPayload.Queries["includeMembers"] = ExpressionConverter.Convert(__workflow_includeMembers);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<IcmTeamSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmCurrentOnCallResponse, ApiConnectionActionConfiguration> GetCurrentOncallContactList(Expression<Func<string>> teamId = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: false);
            return new DeferredBodyAction<IcmCurrentOnCallResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/icm/currentOnCall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_teamId != null)
                    callPayload.Queries["teamId"] = ExpressionConverter.Convert(__workflow_teamId);
                return new ApiConnectionAction<IcmCurrentOnCallResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TransferIncident(Expression<Func<string>> id, Expression<Func<string>> bodyowningTenantPublicId, Expression<Func<string>> bodyowningTeamPublicId, Expression<Func<string>> bodydescription, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyowningTenantPublicId = WorkflowExpression.Compile(bodyowningTenantPublicId, nameof(bodyowningTenantPublicId), required: true);
            var __workflow_bodyowningTeamPublicId = WorkflowExpression.Compile(bodyowningTeamPublicId, nameof(bodyowningTeamPublicId), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/transfer", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["owningTenantPublicId"] = ExpressionConverter.ConvertO(__workflow_bodyowningTenantPublicId);
                bodypropCount++;
                body["owningTeamPublicId"] = ExpressionConverter.ConvertO(__workflow_bodyowningTeamPublicId);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MitigateIncident(Expression<Func<string>> id, Expression<Func<string>> bodymitigation, Expression<Func<bool>> bodyisCustomerImpacting = null, Expression<Func<bool>> bodyisNoise = null, Expression<Func<string>> bodyhowFixed = null, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodymitigation = WorkflowExpression.Compile(bodymitigation, nameof(bodymitigation), required: true);
            var __workflow_bodyisCustomerImpacting = WorkflowExpression.Compile(bodyisCustomerImpacting, nameof(bodyisCustomerImpacting), required: false);
            var __workflow_bodyisNoise = WorkflowExpression.Compile(bodyisNoise, nameof(bodyisNoise), required: false);
            var __workflow_bodyhowFixed = WorkflowExpression.Compile(bodyhowFixed, nameof(bodyhowFixed), required: false);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/mitigate", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisCustomerImpacting != null)
                {
                    body["isCustomerImpacting"] = ExpressionConverter.ConvertO(__workflow_bodyisCustomerImpacting);
                    bodypropCount++;
                }

                if (__workflow_bodyisNoise != null)
                {
                    body["isNoise"] = ExpressionConverter.ConvertO(__workflow_bodyisNoise);
                    bodypropCount++;
                }

                bodypropCount++;
                body["mitigation"] = ExpressionConverter.ConvertO(__workflow_bodymitigation);
                if (__workflow_bodyhowFixed != null)
                {
                    body["howFixed"] = ExpressionConverter.ConvertO(__workflow_bodyhowFixed);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReactivateIncident(Expression<Func<string>> id, Expression<Func<string>> bodydescription, Expression<Func<bool>> bodydisableVoiceNotifications = null, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodydisableVoiceNotifications = WorkflowExpression.Compile(bodydisableVoiceNotifications, nameof(bodydisableVoiceNotifications), required: false);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/activate", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydisableVoiceNotifications != null)
                {
                    body["disableVoiceNotifications"] = ExpressionConverter.ConvertO(__workflow_bodydisableVoiceNotifications);
                    bodypropCount++;
                }

                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResolveIncident(Expression<Func<string>> id, Expression<Func<string>> bodydescription, Expression<Func<bool>> bodyisCustomerImpacting = null, Expression<Func<bool>> bodyisNoise = null, Expression<Func<icmEndpointInput>> icmEndpoint = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodyisCustomerImpacting = WorkflowExpression.Compile(bodyisCustomerImpacting, nameof(bodyisCustomerImpacting), required: false);
            var __workflow_bodyisNoise = WorkflowExpression.Compile(bodyisNoise, nameof(bodyisNoise), required: false);
            var __workflow_icmEndpoint = WorkflowExpression.Compile(icmEndpoint, nameof(icmEndpoint), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icm/incidents/{0}/resolve", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (__workflow_icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = ExpressionConverter.Convert(__workflow_icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisCustomerImpacting != null)
                {
                    body["isCustomerImpacting"] = ExpressionConverter.ConvertO(__workflow_bodyisCustomerImpacting);
                    bodypropCount++;
                }

                if (__workflow_bodyisNoise != null)
                {
                    body["isNoise"] = ExpressionConverter.ConvertO(__workflow_bodyisNoise);
                    bodypropCount++;
                }

                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> HttpRequest(Expression<Func<string>> uri, Expression<Func<methodInput>> method, Expression<Func<string>> contentType = null)
        {
            var __workflow_uri = WorkflowExpression.Compile(uri, nameof(uri), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = ExpressionConverter.Convert(__workflow_uri);
                callPayload.Headers["Method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["ContentType"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class IcmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<IcmIncidentResponseTriggerBatchResponse, ApiConnectionTriggerConfiguration> WhenAnIcMIncidentIsCreated(Expression<Func<string>> filter, Expression<Func<string>> select = null, Expression<Func<searchEndpointInput>> searchEndpoint = null, FlowRecurrence recurrence = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_searchEndpoint = WorkflowExpression.Compile(searchEndpoint, nameof(searchEndpoint), required: false);
            return new DeferredBodyTrigger<IcmIncidentResponseTriggerBatchResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/icm/triggers/onIncidentCreated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["searchEndpoint"] = Convert.ToString("Public");
                if (__workflow_searchEndpoint != null)
                    callPayload.Queries["searchEndpoint"] = ExpressionConverter.Convert(__workflow_searchEndpoint);
                return new ApiConnectionTrigger<IcmIncidentResponseTriggerBatchResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IcmIncidentResponseTriggerBatchResponse, ApiConnectionTriggerConfiguration> WhenAnIcMIncidentIsModified(Expression<Func<string>> filter, Expression<Func<string>> select = null, Expression<Func<searchEndpointInput>> searchEndpoint = null, FlowRecurrence recurrence = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_searchEndpoint = WorkflowExpression.Compile(searchEndpoint, nameof(searchEndpoint), required: false);
            return new DeferredBodyTrigger<IcmIncidentResponseTriggerBatchResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/icm/triggers/onIncidentModified";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["searchEndpoint"] = Convert.ToString("Public");
                if (__workflow_searchEndpoint != null)
                    callPayload.Queries["searchEndpoint"] = ExpressionConverter.Convert(__workflow_searchEndpoint);
                return new ApiConnectionTrigger<IcmIncidentResponseTriggerBatchResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class IcmIncidentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("severity")]
        public int Severity { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("source")]
        public IcmIncidentSource Source { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("routingId")]
        public string RoutingId { get; set; }

        [JsonProperty("raisingLocation")]
        public IcmIncidentLocation RaisingLocation { get; set; }

        [JsonProperty("incidentLocation")]
        public IcmIncidentLocation IncidentLocation { get; set; }

        [JsonProperty("parentIncidentId")]
        public string ParentIncidentId { get; set; }

        [JsonProperty("relatedLinksCount")]
        public int RelatedLinksCount { get; set; }

        [JsonProperty("externalLinksCount")]
        public int ExternalLinksCount { get; set; }

        [JsonProperty("lastCorrelationDate")]
        public string LastCorrelationDate { get; set; }

        [JsonProperty("hitCount")]
        public int HitCount { get; set; }

        [JsonProperty("childCount")]
        public int ChildCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("reproSteps")]
        public string ReproSteps { get; set; }

        [JsonProperty("owningContactAlias")]
        public string OwningContactAlias { get; set; }

        [JsonProperty("owningTenantId")]
        public string OwningTenantId { get; set; }

        [JsonProperty("owningTeamId")]
        public string OwningTeamId { get; set; }

        [JsonProperty("mitigationData")]
        public IcmIncidentMitigationData MitigationData { get; set; }

        [JsonProperty("resolutionData")]
        public IcmIncidentResolutionData ResolutionData { get; set; }

        [JsonProperty("isCustomerImpacting")]
        public bool IsCustomerImpacting { get; set; }

        [JsonProperty("isNoise")]
        public bool IsNoise { get; set; }

        [JsonProperty("isSecurityRisk")]
        public bool IsSecurityRisk { get; set; }

        [JsonProperty("tsgId")]
        public string TsgId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("commitDate")]
        public string CommitDate { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("component")]
        public string Component { get; set; }

        [JsonProperty("incidentType")]
        public string IncidentType { get; set; }

        [JsonProperty("impactStartDate")]
        public string ImpactStartDate { get; set; }

        [JsonProperty("originatingTenantId")]
        public string OriginatingTenantId { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("supportTicketId")]
        public string SupportTicketId { get; set; }

        [JsonProperty("monitorId")]
        public string MonitorId { get; set; }

        [JsonProperty("incidentSubType")]
        public string IncidentSubType { get; set; }

        [JsonProperty("howFixed")]
        public string HowFixed { get; set; }

        [JsonProperty("tsgOutput")]
        public string TsgOutput { get; set; }

        [JsonProperty("sourceOrigin")]
        public string SourceOrigin { get; set; }

        [JsonProperty("responsibleTenantId")]
        public string ResponsibleTenantId { get; set; }

        [JsonProperty("responsibleTeamId")]
        public string ResponsibleTeamId { get; set; }

        [JsonProperty("impactedServicesIds")]
        public string[] ImpactedServicesIds { get; set; }

        [JsonProperty("impactedTeamsPublicIds")]
        public string[] ImpactedTeamsPublicIds { get; set; }

        [JsonProperty("impactedComponents")]
        public IcmIncidentResponseImpactedComponentsTypeItem[] ImpactedComponents { get; set; }

        [JsonProperty("newDescriptionEntry")]
        public string NewDescriptionEntry { get; set; }

        [JsonProperty("acknowledgementData")]
        public IcmIncidentAcknowledgementData AcknowledgementData { get; set; }

        [JsonProperty("reactivationData")]
        public JToken ReactivationData { get; set; }

        [JsonProperty("customFieldGroups")]
        public IcmIncidentCustomFieldGroup[] CustomFieldGroups { get; set; }

        [JsonProperty("externalIncidents")]
        public JToken[] ExternalIncidents { get; set; }

        [JsonProperty("siloId")]
        public string SiloId { get; set; }

        [JsonProperty("incidentManagerContactId")]
        public string IncidentManagerContactId { get; set; }

        [JsonProperty("executiveIncidentManagerContactId")]
        public string ExecutiveIncidentManagerContactId { get; set; }

        [JsonProperty("communicationsManagerContactId")]
        public string CommunicationsManagerContactId { get; set; }

        [JsonProperty("siteReliabilityContactId")]
        public string SiteReliabilityContactId { get; set; }

        [JsonProperty("healthResourceId")]
        public string HealthResourceId { get; set; }

        [JsonProperty("diagnosticsLink")]
        public string DiagnosticsLink { get; set; }

        [JsonProperty("changeList")]
        public JToken ChangeList { get; set; }

        [JsonProperty("isOutage")]
        public bool IsOutage { get; set; }

        [JsonProperty("outageImpactLevel")]
        public string OutageImpactLevel { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("isCustomerSupportEngagement")]
        public bool IsCustomerSupportEngagement { get; set; }

        [JsonProperty("descriptionEntries")]
        public IcmIncidentDescriptionEntry[] DescriptionEntries { get; set; }

        [JsonProperty("retrospectiveId")]
        public string RetrospectiveId { get; set; }

        [JsonProperty("bridges")]
        public IcmBridge[] Bridges { get; set; }
    }

    public class IcmIncidentSource
    {
        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("incidentId")]
        public string IncidentId { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("revision")]
        public string Revision { get; set; }
    }

    public class IcmIncidentLocation
    {
        [JsonProperty("environment")]
        public string Environment { get; set; }

        [JsonProperty("dataCenter")]
        public string DataCenter { get; set; }

        [JsonProperty("deviceGroup")]
        public string DeviceGroup { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("serviceInstanceId")]
        public string ServiceInstanceId { get; set; }
    }

    public class IcmIncidentMitigationData
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("mitigation")]
        public string Mitigation { get; set; }
    }

    public class IcmIncidentResolutionData
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("createPostmortem")]
        public bool CreatePostmortem { get; set; }
    }

    public class IcmIncidentResponseImpactedComponentsTypeItem
    {
        [JsonProperty("tenantPublicId")]
        public string TenantPublicId { get; set; }

        [JsonProperty("componentName")]
        public string ComponentName { get; set; }
    }

    public class IcmIncidentAcknowledgementData
    {
        [JsonProperty("isAcknowledged")]
        public bool IsAcknowledged { get; set; }

        [JsonProperty("acknowledgeDate")]
        public string AcknowledgeDate { get; set; }

        [JsonProperty("acknowledgeContactAlias")]
        public string AcknowledgeContactAlias { get; set; }

        [JsonProperty("notificationId")]
        public string NotificationId { get; set; }

        [JsonProperty("notificationToken")]
        public string NotificationToken { get; set; }

        [JsonProperty("acknowledgeSource")]
        public string AcknowledgeSource { get; set; }
    }

    public class IcmIncidentCustomFieldGroup
    {
        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("containerId")]
        public string ContainerId { get; set; }

        [JsonProperty("groupType")]
        public string GroupType { get; set; }

        [JsonProperty("customFields")]
        public IcmIncidentCustomField[] CustomFields { get; set; }
    }

    public class IcmIncidentCustomField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class IcmIncidentDescriptionEntry
    {
        [JsonProperty("descriptionEntryId")]
        public string DescriptionEntryId { get; set; }

        [JsonProperty("incidentId")]
        public string IncidentId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("submittedBy")]
        public string SubmittedBy { get; set; }

        [JsonProperty("submitDate")]
        public string SubmitDate { get; set; }

        [JsonProperty("isFromConnector")]
        public bool IsFromConnector { get; set; }

        [JsonProperty("historyId")]
        public string HistoryId { get; set; }

        [JsonProperty("isHtml")]
        public bool IsHtml { get; set; }

        [JsonProperty("renderType")]
        public string RenderType { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("submittedByDisplayName")]
        public string SubmittedByDisplayName { get; set; }

        [JsonProperty("changedByDisplayName")]
        public string ChangedByDisplayName { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class IcmBridge
    {
        [JsonProperty("bridgeURI")]
        public string BridgeURI { get; set; }

        [JsonProperty("bridgeNumber")]
        public string BridgeNumber { get; set; }

        [JsonProperty("bridgeConfId")]
        public string BridgeConfId { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("bridgeName")]
        public string BridgeName { get; set; }

        [JsonProperty("bridgeType")]
        public string BridgeType { get; set; }
    }

    public class IcmRetrospectiveResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("communicationManagerId")]
        public int CommunicationManagerId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creationIncidentId")]
        public int CreationIncidentId { get; set; }

        [JsonProperty("customerImpact")]
        public string CustomerImpact { get; set; }

        [JsonProperty("findings")]
        public string Findings { get; set; }

        [JsonProperty("howFixed")]
        public string HowFixed { get; set; }

        [JsonProperty("detection")]
        public IcmRetrospectiveDetection Detection { get; set; }

        [JsonProperty("impactDuration")]
        public string ImpactDuration { get; set; }

        [JsonProperty("impactStart")]
        public string ImpactStart { get; set; }

        [JsonProperty("impactStartDescription")]
        public string ImpactStartDescription { get; set; }

        [JsonProperty("incidentManagerId")]
        public int IncidentManagerId { get; set; }

        [JsonProperty("executiveIncidentManagerId")]
        public int ExecutiveIncidentManagerId { get; set; }

        [JsonProperty("incidentRaisedDate")]
        public string IncidentRaisedDate { get; set; }

        [JsonProperty("isCausedByChange")]
        public bool IsCausedByChange { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("owningTeamId")]
        public int OwningTeamId { get; set; }

        [JsonProperty("owningTeam")]
        public IcmOwningTeam OwningTeam { get; set; }

        [JsonProperty("owningTenantId")]
        public int OwningTenantId { get; set; }

        [JsonProperty("owningTenant")]
        public IcmOwningTeam OwningTenant { get; set; }

        [JsonProperty("owningFrontEndCategoryId")]
        public int OwningFrontEndCategoryId { get; set; }

        [JsonProperty("owningServiceCategory")]
        public IcmOwningTeam OwningServiceCategory { get; set; }

        [JsonProperty("postmortemOwnerId")]
        public int PostmortemOwnerId { get; set; }

        [JsonProperty("postmortemOwner")]
        public IcmContact PostmortemOwner { get; set; }

        [JsonProperty("qosImpact")]
        public string QosImpact { get; set; }

        [JsonProperty("receivedImpact")]
        public string ReceivedImpact { get; set; }

        [JsonProperty("repeatOutage")]
        public bool RepeatOutage { get; set; }

        [JsonProperty("repeatOutageDetail")]
        public string RepeatOutageDetail { get; set; }

        [JsonProperty("rootCauseDetails")]
        public string RootCauseDetails { get; set; }

        [JsonProperty("rootCauseCategory")]
        public string RootCauseCategory { get; set; }

        [JsonProperty("rootCauseSubCategory")]
        public string RootCauseSubCategory { get; set; }

        [JsonProperty("rootCauseMitigation")]
        public string RootCauseMitigation { get; set; }

        [JsonProperty("rootCauseTitle")]
        public string RootCauseTitle { get; set; }

        [JsonProperty("serviceImpacted")]
        public string ServiceImpacted { get; set; }

        [JsonProperty("serviceResponsible")]
        public string ServiceResponsible { get; set; }

        [JsonProperty("serviceRestoreDate")]
        public string ServiceRestoreDate { get; set; }

        [JsonProperty("severity")]
        public int Severity { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("timeline")]
        public IcmRetrospectiveTimeline Timeline { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("isReadonly")]
        public bool IsReadonly { get; set; }

        [JsonProperty("rootCauseId")]
        public int RootCauseId { get; set; }

        [JsonProperty("customFields")]
        public IcmRetrospectiveCustomField[] CustomFields { get; set; }

        [JsonProperty("attachments")]
        public IcmRetrospectiveFileAttachment[] Attachments { get; set; }

        [JsonProperty("links")]
        public IcmRetrospectiveLink[] Links { get; set; }

        [JsonProperty("repairItems")]
        public IcmRetrospectiveRepairItem[] RepairItems { get; set; }

        [JsonProperty("whyItems")]
        public IcmRetrospectiveWhyItem[] WhyItems { get; set; }
    }

    public class IcmRetrospectiveDetection
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }

    public class IcmOwningTeam
    {
        [JsonProperty("entityId")]
        public int EntityId { get; set; }

        [JsonProperty("entityName")]
        public string EntityName { get; set; }
    }

    public class IcmContact
    {
        [JsonProperty("contactId")]
        public int ContactId { get; set; }

        [JsonProperty("contactAlias")]
        public string ContactAlias { get; set; }

        [JsonProperty("contactFullName")]
        public string ContactFullName { get; set; }
    }

    public class IcmRetrospectiveTimeline
    {
        [JsonProperty("commsEngaged")]
        public IcmRetrospectiveTimelineEntry CommsEngaged { get; set; }

        [JsonProperty("dashboard")]
        public IcmRetrospectiveTimelineEntry Dashboard { get; set; }

        [JsonProperty("detailedCustomerAdvisory")]
        public IcmRetrospectiveTimelineEntry DetailedCustomerAdvisory { get; set; }

        [JsonProperty("detection")]
        public IcmRetrospectiveTimelineEntry Detection { get; set; }

        [JsonProperty("diagnosis")]
        public IcmRetrospectiveTimelineEntry Diagnosis { get; set; }

        [JsonProperty("engineerEngaged")]
        public IcmRetrospectiveTimelineEntry EngineerEngaged { get; set; }

        [JsonProperty("firstCustomerAdvisory")]
        public IcmRetrospectiveTimelineEntry FirstCustomerAdvisory { get; set; }

        [JsonProperty("mitigation")]
        public IcmRetrospectiveTimelineEntry Mitigation { get; set; }

        [JsonProperty("other1")]
        public IcmRetrospectiveTimelineEntry Other1 { get; set; }

        [JsonProperty("other2")]
        public IcmRetrospectiveTimelineEntry Other2 { get; set; }

        [JsonProperty("other3")]
        public IcmRetrospectiveTimelineEntry Other3 { get; set; }

        [JsonProperty("recovery")]
        public IcmRetrospectiveTimelineEntry Recovery { get; set; }

        [JsonProperty("triage")]
        public IcmRetrospectiveTimelineEntry Triage { get; set; }

        [JsonProperty("outageDeclared")]
        public IcmRetrospectiveTimelineEntry OutageDeclared { get; set; }
    }

    public class IcmRetrospectiveTimelineEntry
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class IcmRetrospectiveCustomField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("customFieldId")]
        public int CustomFieldId { get; set; }

        [JsonProperty("stringValue")]
        public string StringValue { get; set; }

        [JsonProperty("numberValue")]
        public double NumberValue { get; set; }

        [JsonProperty("booleanValue")]
        public bool BooleanValue { get; set; }

        [JsonProperty("enumValueId")]
        public int EnumValueId { get; set; }

        [JsonProperty("enumValue")]
        public string EnumValue { get; set; }

        [JsonProperty("dateTimeOffsetValue")]
        public string DateTimeOffsetValue { get; set; }

        [JsonProperty("modifiedTime")]
        public string ModifiedTime { get; set; }

        [JsonProperty("additionalData")]
        public string AdditionalData { get; set; }

        [JsonProperty("customFieldDataType")]
        public string CustomFieldDataType { get; set; }
    }

    public class IcmRetrospectiveFileAttachment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileUrl")]
        public string FileUrl { get; set; }

        [JsonProperty("contentBase64")]
        public string ContentBase64 { get; set; }

        [JsonProperty("incidentId")]
        public int IncidentId { get; set; }

        [JsonProperty("uploadedBy")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploadedDate")]
        public string UploadedDate { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("allowAnonymousAccess")]
        public bool AllowAnonymousAccess { get; set; }
    }

    public class IcmRetrospectiveLink
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class IcmRetrospectiveRepairItem
    {
        [JsonProperty("adoWorkItemId")]
        public string AdoWorkItemId { get; set; }

        [JsonProperty("additionalData")]
        public IcmRetrospectiveRepairItemAdditionalData AdditionalData { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("changedDate")]
        public string ChangedDate { get; set; }
    }

    public class IcmRetrospectiveRepairItemAdditionalData
    {
        [JsonProperty("repairItemType")]
        public IcmRetrospectiveRepairItemAdditionalDataRepairItemTypeType RepairItemType { get; set; }

        [JsonProperty("repairItemDeliveryType")]
        public IcmRetrospectiveRepairItemAdditionalDataRepairItemDeliveryTypeType RepairItemDeliveryType { get; set; }

        [JsonProperty("workItemType")]
        public string WorkItemType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("areapath")]
        public string Areapath { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("vstsCreatedDate")]
        public string VstsCreatedDate { get; set; }

        [JsonProperty("vstsClosedDate")]
        public string VstsClosedDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IcmRetrospectiveRepairItemAdditionalDataRepairItemTypeType
    {
        Fix,
        Detection,
        Mitigation,
        Other,
        Repair,
        Diagnose,
        Notification,
        Engagement,
        TestRelease,
        Process,
        Resiliency,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IcmRetrospectiveRepairItemAdditionalDataRepairItemDeliveryTypeType
    {
        ShortTerm,
        LongTerm,
        MediumTerm,
        Unknown
    }

    public class IcmRetrospectiveWhyItem
    {
        [JsonProperty("questionId")]
        public string QuestionId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class IcmBridgesResponse
    {
        [JsonProperty("value")]
        public IcmBridge[] Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrenderTypeInput
    {
        Html,
        Plaintext
    }

    public class IcmDescriptionEntriesResponse
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum icmEndpointInput
    {
        Public,
        Eudb
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyseverityInput
    {
        Sev0,
        Sev1,
        Sev2,
        Sev3,
        Sev4,
        Sev25
    }

    public class bodycustomFieldsInputItem
    {
        [JsonProperty("name")]
        public string FieldName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string FieldValue { get; set; }

        [JsonProperty("type")]
        public string FieldType { get; set; }
    }

    public class TagUserInDiscussionResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("incidentId")]
        public string IncidentId { get; set; }

        [JsonProperty("discussionAdded")]
        public bool DiscussionAdded { get; set; }

        [JsonProperty("emailSent")]
        public bool EmailSent { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class IncidentAddUpdateResult
    {
        [JsonProperty("incidentId")]
        public int IncidentId { get; set; }

        [JsonProperty("status")]
        public IncidentAddUpdateStatus Status { get; set; }

        [JsonProperty("subStatus")]
        public IncidentAddUpdateSubStatus SubStatus { get; set; }

        [JsonProperty("updateProcessTime")]
        public string UpdateProcessTime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IncidentAddUpdateStatus
    {
        Invalid,
        AddedNew,
        UpdatedExisting,
        DidNotChangeExisting,
        AlertSourceUpdatesPending,
        UpdateToHoldingNotAllowed,
        Discarded
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IncidentAddUpdateSubStatus
    {
        None,
        Resolved,
        Activated,
        ConnectorChanged,
        Transferred,
        Suppressed,
        Mitigated,
        Unresolved
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyhowFoundInput
    {
        Other,
        Monitor,
        Customer,
        Manual,
        Partner,
        Runner,
        Deployment,
        Workflow,
        Email
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydiscussionEntryrenderTypeInput
    {
        Html,
        Plaintext
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycloudInstanceInput
    {
        Public,
        ChinaGallatin,
        FairfaxItar,
        USNat,
        USSec
    }

    public class IcmAccessClaim
    {
        [JsonProperty("claimType")]
        public IcmAccessClaimClaimTypeType ClaimType { get; set; }

        [JsonProperty("claim")]
        public string Claim { get; set; }

        [JsonProperty("role")]
        public IcmAccessClaimRoleType Role { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IcmAccessClaimClaimTypeType
    {
        IcmContactAlias,
        MemberOfIcmTeamPublicId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IcmAccessClaimRoleType
    {
        Owners,
        Contributors,
        Readers
    }

    public class IcmIncidentSearchResponse
    {
        [JsonProperty("value")]
        public IcmIncidentResponse[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchEndpointInput
    {
        Public,
        Eudb
    }

    public class OmnisearchIncidentsResponse
    {
        [JsonProperty("value")]
        public OmnisearchIncident[] Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class OmnisearchIncident
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string State { get; set; }
        public int Severity { get; set; }
        public string CreatedDate { get; set; }
        public string LastModifiedDate { get; set; }
        public bool IsSecurityRisk { get; set; }
        public bool IsCustomerImpacting { get; set; }
        public int OwningTeamId { get; set; }
        public string OwningTeamName { get; set; }
        public string OwningTenantName { get; set; }
        public int OwningServiceId { get; set; }
        public string ResponsibleServiceName { get; set; }
        public string RoutingId { get; set; }
        public string CorrelationId { get; set; }
        public string ContactAlias { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyorderDirectionInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class IcmTeamSearchResponse
    {
        [JsonProperty("value")]
        public IcmTeam[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class IcmTeam
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("syncId")]
        public string SyncId { get; set; }

        [JsonProperty("rotationTransitionTime")]
        public string RotationTransitionTime { get; set; }

        [JsonProperty("firstRotationPeriodDate")]
        public string FirstRotationPeriodDate { get; set; }

        [JsonProperty("rotationPeriodLength")]
        public string RotationPeriodLength { get; set; }

        [JsonProperty("timeZoneId")]
        public string TimeZoneId { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("isTombstoned")]
        public bool IsTombstoned { get; set; }

        [JsonProperty("isAssignable")]
        public bool IsAssignable { get; set; }

        [JsonProperty("isVirtual")]
        public bool IsVirtual { get; set; }

        [JsonProperty("rotationMemberCount")]
        public int RotationMemberCount { get; set; }

        [JsonProperty("highSeverityThreshold")]
        public int HighSeverityThreshold { get; set; }

        [JsonProperty("arePhoneCallHoursRestricted")]
        public bool ArePhoneCallHoursRestricted { get; set; }

        [JsonProperty("tenant")]
        public IcmTenant Tenant { get; set; }

        [JsonProperty("members")]
        public IcmTeamMember[] Members { get; set; }
    }

    public class IcmTenant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicId")]
        public string PublicId { get; set; }

        [JsonProperty("tenantGuid")]
        public string TenantGuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("siloId")]
        public string SiloId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("highSeverityThreshold")]
        public int HighSeverityThreshold { get; set; }

        [JsonProperty("emailSeverityThreshold")]
        public int EmailSeverityThreshold { get; set; }

        [JsonProperty("accessRequestAddress")]
        public string AccessRequestAddress { get; set; }

        [JsonProperty("accessRequestFriendlyName")]
        public string AccessRequestFriendlyName { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("frontEndCategoryId")]
        public string FrontEndCategoryId { get; set; }

        [JsonProperty("frontEndCategoryName")]
        public string FrontEndCategoryName { get; set; }

        [JsonProperty("incidentManagerTeamId")]
        public string IncidentManagerTeamId { get; set; }

        [JsonProperty("communicationsManagerTeamId")]
        public string CommunicationsManagerTeamId { get; set; }

        [JsonProperty("securityTeamId")]
        public string SecurityTeamId { get; set; }

        [JsonProperty("incidentManagerTeamName")]
        public string IncidentManagerTeamName { get; set; }

        [JsonProperty("communicationsManagerTeamName")]
        public string CommunicationsManagerTeamName { get; set; }

        [JsonProperty("securityTeamName")]
        public string SecurityTeamName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IcmTeamMember
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("timeZoneId")]
        public string TimeZoneId { get; set; }

        [JsonProperty("upn")]
        public string Upn { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("optOutCommunication")]
        public bool OptOutCommunication { get; set; }
    }

    public class IcmCurrentOnCallResponse
    {
        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("currentOnCalls")]
        public IcmOnCallContact[] CurrentOnCalls { get; set; }
    }

    public class IcmOnCallContact
    {
        [JsonProperty("contactId")]
        public int ContactId { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    public class IcmIncidentResponseTriggerBatchResponse
    {
        [JsonProperty("value")]
        public IcmIncidentResponse[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Icm;

    public partial class WorkflowManagedActions
    {
        public IcmActions Icm(string connectionId) => new IcmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IcmTriggers Icm(string connectionId) => new IcmTriggers(connectionId);
    }
}