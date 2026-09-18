//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Icm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IcmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmIncidentResponse> GetIncident([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IcmIncidentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmRetrospectiveResponse> GetRetrospectiveById([WorkflowExpression] Func<string> retrospectiveId)
        {
            SourceExpression.Validate(retrospectiveId, nameof(retrospectiveId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/retrospectives/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(retrospectiveId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IcmRetrospectiveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmRetrospectiveResponse> GetRetrospectiveByIncidentId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/retrospective", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IcmRetrospectiveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmBridgesResponse> GetBridgesForAnIncident([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/bridges", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IcmBridgesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction AddNewIcMDiscussionEntry([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydiscussionText = null, [WorkflowExpression] Func<bodyrenderTypeInput> bodyrenderType = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydiscussionText, nameof(bodydiscussionText), required: false);
            SourceExpression.Validate(bodyrenderType, nameof(bodyrenderType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/addDiscussionEntry", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydiscussionText != null)
                {
                    body["discussionText"] = SourceExpressionConverter.ConvertToken(bodydiscussionText);
                    bodypropCount++;
                }

                if (bodyrenderType != null)
                {
                    body["renderType"] = SourceExpressionConverter.Convert(bodyrenderType);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmDescriptionEntriesResponse> GetDescriptionEntries([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(count, nameof(count), required: false);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/descriptionEntries", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["count"] = Convert.ToString(5);
                if (count != null)
                    callPayload.Queries["count"] = SourceExpressionConverter.ConvertO(count);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                return callPayload;
            }

            return new ApiConnectionAction<IcmDescriptionEntriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction UpdateIncidentSeverity([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyseverityInput> bodyseverity, [WorkflowExpression] Func<string> bodydescriptionEntry = null, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyseverity, nameof(bodyseverity), required: true);
            SourceExpression.Validate(bodydescriptionEntry, nameof(bodydescriptionEntry), required: false);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/updateSeverity", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["severity"] = SourceExpressionConverter.Convert(bodyseverity);
                if (bodydescriptionEntry != null)
                {
                    body["descriptionEntry"] = SourceExpressionConverter.ConvertToken(bodydescriptionEntry);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction UpdateIncidentTitle([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/updateTitle", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction UpdateIncidentOwner([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyowningContactAlias, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyowningContactAlias, nameof(bodyowningContactAlias), required: true);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/updateOwner", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["owningContactAlias"] = SourceExpressionConverter.ConvertToken(bodyowningContactAlias);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction UpdateIncidentCustomFields([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodygroupType, [WorkflowExpression] Func<bodycustomFieldsInputItem[]> bodycustomFields, [WorkflowExpression] Func<string> bodypublicID = null, [WorkflowExpression] Func<string> bodycontainerID = null, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodygroupType, nameof(bodygroupType), required: true);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: true);
            SourceExpression.Validate(bodypublicID, nameof(bodypublicID), required: false);
            SourceExpression.Validate(bodycontainerID, nameof(bodycontainerID), required: false);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/updateCustomFields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupType"] = SourceExpressionConverter.ConvertToken(bodygroupType);
                if (bodypublicID != null)
                {
                    body["publicId"] = SourceExpressionConverter.ConvertToken(bodypublicID);
                    bodypropCount++;
                }

                if (bodycontainerID != null)
                {
                    body["containerId"] = SourceExpressionConverter.ConvertToken(bodycontainerID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["customFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction UpdateIncidentSingleCustomField([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycustomField, [WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycustomField, nameof(bodycustomField), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/updateSingleCustomField", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["field"] = SourceExpressionConverter.ConvertToken(bodycustomField);
                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction UpdateIncidentTags([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string[]> bodytags, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: true);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/updateTags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<TagUserInDiscussionResponse> TagUserInDiscussion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyrecipientEmail, [WorkflowExpression] Func<string> bodydiscussionText, [WorkflowExpression] Func<string> bodyrecipientDisplayName = null, [WorkflowExpression] Func<string> bodymentionerDisplayName = null, [WorkflowExpression] Func<string> bodymentionerAlias = null, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyrecipientEmail, nameof(bodyrecipientEmail), required: true);
            SourceExpression.Validate(bodydiscussionText, nameof(bodydiscussionText), required: true);
            SourceExpression.Validate(bodyrecipientDisplayName, nameof(bodyrecipientDisplayName), required: false);
            SourceExpression.Validate(bodymentionerDisplayName, nameof(bodymentionerDisplayName), required: false);
            SourceExpression.Validate(bodymentionerAlias, nameof(bodymentionerAlias), required: false);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/tagUser", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipient"] = SourceExpressionConverter.ConvertToken(bodyrecipientEmail);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodydiscussionText);
                if (bodyrecipientDisplayName != null)
                {
                    body["recipientDisplayName"] = SourceExpressionConverter.ConvertToken(bodyrecipientDisplayName);
                    bodypropCount++;
                }

                if (bodymentionerDisplayName != null)
                {
                    body["mentionerDisplayName"] = SourceExpressionConverter.ConvertToken(bodymentionerDisplayName);
                    bodypropCount++;
                }

                if (bodymentionerAlias != null)
                {
                    body["mentionerAlias"] = SourceExpressionConverter.ConvertToken(bodymentionerAlias);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TagUserInDiscussionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IncidentAddUpdateResult> CreateIcMIncident([WorkflowExpression] Func<string> bodyconnectorId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyowningTeam = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodyroutingId = null, [WorkflowExpression] Func<bodyhowFoundInput> bodyhowFound = null, [WorkflowExpression] Func<bodyseverityInput> bodyseverity = null, [WorkflowExpression] Func<string> bodydiscussionEntrydiscussionText = null, [WorkflowExpression] Func<bodydiscussionEntryrenderTypeInput> bodydiscussionEntryrenderType = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<bodycloudInstanceInput> bodycloudInstance = null, [WorkflowExpression] Func<string> bodyoccurringLocationenvironment = null, [WorkflowExpression] Func<string> bodyoccurringLocationdcRegion = null, [WorkflowExpression] Func<string> bodyoccurringLocationinstanceCluster = null, [WorkflowExpression] Func<string> bodyoccurringLocationrole = null, [WorkflowExpression] Func<string> bodyoccurringLocationslice = null, [WorkflowExpression] Func<bool> bodyisRestrictedIncident = null, [WorkflowExpression] Func<bool> bodyisSecurityRisk = null, [WorkflowExpression] Func<IcmAccessClaim[]> bodyaccessRestrictedToClaims = null)
        {
            SourceExpression.Validate(bodyconnectorId, nameof(bodyconnectorId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodyowningTeam, nameof(bodyowningTeam), required: false);
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: false);
            SourceExpression.Validate(bodyroutingId, nameof(bodyroutingId), required: false);
            SourceExpression.Validate(bodyhowFound, nameof(bodyhowFound), required: false);
            SourceExpression.Validate(bodyseverity, nameof(bodyseverity), required: false);
            SourceExpression.Validate(bodydiscussionEntrydiscussionText, nameof(bodydiscussionEntrydiscussionText), required: false);
            SourceExpression.Validate(bodydiscussionEntryrenderType, nameof(bodydiscussionEntryrenderType), required: false);
            SourceExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodycloudInstance, nameof(bodycloudInstance), required: false);
            SourceExpression.Validate(bodyoccurringLocationenvironment, nameof(bodyoccurringLocationenvironment), required: false);
            SourceExpression.Validate(bodyoccurringLocationdcRegion, nameof(bodyoccurringLocationdcRegion), required: false);
            SourceExpression.Validate(bodyoccurringLocationinstanceCluster, nameof(bodyoccurringLocationinstanceCluster), required: false);
            SourceExpression.Validate(bodyoccurringLocationrole, nameof(bodyoccurringLocationrole), required: false);
            SourceExpression.Validate(bodyoccurringLocationslice, nameof(bodyoccurringLocationslice), required: false);
            SourceExpression.Validate(bodyisRestrictedIncident, nameof(bodyisRestrictedIncident), required: false);
            SourceExpression.Validate(bodyisSecurityRisk, nameof(bodyisSecurityRisk), required: false);
            SourceExpression.Validate(bodyaccessRestrictedToClaims, nameof(bodyaccessRestrictedToClaims), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/icm/incidents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyowningTeam != null)
                {
                    body["owningTeam"] = SourceExpressionConverter.ConvertToken(bodyowningTeam);
                    bodypropCount++;
                }

                bodypropCount++;
                body["connectorId"] = SourceExpressionConverter.ConvertToken(bodyconnectorId);
                if (bodycorrelationId != null)
                {
                    body["correlationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                    bodypropCount++;
                }

                if (bodyroutingId != null)
                {
                    body["routingId"] = SourceExpressionConverter.ConvertToken(bodyroutingId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodyhowFound != null)
                {
                    body["howFound"] = SourceExpressionConverter.Convert(bodyhowFound);
                    bodypropCount++;
                }

                if (bodyseverity != null)
                {
                    body["severity"] = SourceExpressionConverter.Convert(bodyseverity);
                    bodypropCount++;
                }

                var discussionEntryObject = new JObject();
                var discussionEntryObjectpropCount = 0;
                if (bodydiscussionEntrydiscussionText != null)
                {
                    discussionEntryObject["discussionText"] = SourceExpressionConverter.ConvertToken(bodydiscussionEntrydiscussionText);
                    discussionEntryObjectpropCount++;
                }

                if (bodydiscussionEntryrenderType != null)
                {
                    discussionEntryObject["renderType"] = SourceExpressionConverter.Convert(bodydiscussionEntryrenderType);
                    discussionEntryObjectpropCount++;
                }

                if (discussionEntryObjectpropCount > 0)
                {
                    body["discussionEntry"] = discussionEntryObject;
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodycloudInstance != null)
                {
                    body["cloudInstance"] = SourceExpressionConverter.Convert(bodycloudInstance);
                    bodypropCount++;
                }

                var occurringLocationObject = new JObject();
                var occurringLocationObjectpropCount = 0;
                if (bodyoccurringLocationenvironment != null)
                {
                    occurringLocationObject["environment"] = SourceExpressionConverter.ConvertToken(bodyoccurringLocationenvironment);
                    occurringLocationObjectpropCount++;
                }

                if (bodyoccurringLocationdcRegion != null)
                {
                    occurringLocationObject["dcRegion"] = SourceExpressionConverter.ConvertToken(bodyoccurringLocationdcRegion);
                    occurringLocationObjectpropCount++;
                }

                if (bodyoccurringLocationinstanceCluster != null)
                {
                    occurringLocationObject["instanceCluster"] = SourceExpressionConverter.ConvertToken(bodyoccurringLocationinstanceCluster);
                    occurringLocationObjectpropCount++;
                }

                if (bodyoccurringLocationrole != null)
                {
                    occurringLocationObject["role"] = SourceExpressionConverter.ConvertToken(bodyoccurringLocationrole);
                    occurringLocationObjectpropCount++;
                }

                if (bodyoccurringLocationslice != null)
                {
                    occurringLocationObject["slice"] = SourceExpressionConverter.ConvertToken(bodyoccurringLocationslice);
                    occurringLocationObjectpropCount++;
                }

                if (occurringLocationObjectpropCount > 0)
                {
                    body["occurringLocation"] = occurringLocationObject;
                    bodypropCount++;
                }

                if (bodyisRestrictedIncident != null)
                {
                    body["isRestrictedIncident"] = SourceExpressionConverter.ConvertToken(bodyisRestrictedIncident);
                    bodypropCount++;
                }

                if (bodyisSecurityRisk != null)
                {
                    body["isSecurityRisk"] = SourceExpressionConverter.ConvertToken(bodyisSecurityRisk);
                    bodypropCount++;
                }

                if (bodyaccessRestrictedToClaims != null)
                {
                    body["accessRestrictedToClaims"] = SourceExpressionConverter.ConvertToken(bodyaccessRestrictedToClaims);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IncidentAddUpdateResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmIncidentSearchResponse> SearchIncidents([WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<searchEndpointInput> searchEndpoint = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: true);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(searchEndpoint, nameof(searchEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/icm/incidents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["searchEndpoint"] = Convert.ToString("Public");
                if (searchEndpoint != null)
                    callPayload.Queries["searchEndpoint"] = SourceExpressionConverter.Convert(searchEndpoint);
                return callPayload;
            }

            return new ApiConnectionAction<IcmIncidentSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmTeamSearchResponse> SearchIcMTeams([WorkflowExpression] Func<string> publicId = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<bool> includeMembers = null, [WorkflowExpression] Func<int> skip = null)
        {
            SourceExpression.Validate(publicId, nameof(publicId), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(includeMembers, nameof(includeMembers), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/icm/teams/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (publicId != null)
                    callPayload.Queries["publicId"] = SourceExpressionConverter.ConvertO(publicId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["includeMembers"] = Convert.ToString(false);
                if (includeMembers != null)
                    callPayload.Queries["includeMembers"] = SourceExpressionConverter.ConvertO(includeMembers);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<IcmTeamSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<IcmCurrentOnCallResponse> GetCurrentOncallContactList([WorkflowExpression] Func<string> teamId = null)
        {
            SourceExpression.Validate(teamId, nameof(teamId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/icm/currentOnCall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (teamId != null)
                    callPayload.Queries["teamId"] = SourceExpressionConverter.ConvertO(teamId);
                return callPayload;
            }

            return new ApiConnectionAction<IcmCurrentOnCallResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction TransferIncident([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyowningTenantPublicId, [WorkflowExpression] Func<string> bodyowningTeamPublicId, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyowningTenantPublicId, nameof(bodyowningTenantPublicId), required: true);
            SourceExpression.Validate(bodyowningTeamPublicId, nameof(bodyowningTeamPublicId), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/transfer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["owningTenantPublicId"] = SourceExpressionConverter.ConvertToken(bodyowningTenantPublicId);
                bodypropCount++;
                body["owningTeamPublicId"] = SourceExpressionConverter.ConvertToken(bodyowningTeamPublicId);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction MitigateIncident([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodymitigation, [WorkflowExpression] Func<bool> bodyisCustomerImpacting = null, [WorkflowExpression] Func<bool> bodyisNoise = null, [WorkflowExpression] Func<string> bodyhowFixed = null, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodymitigation, nameof(bodymitigation), required: true);
            SourceExpression.Validate(bodyisCustomerImpacting, nameof(bodyisCustomerImpacting), required: false);
            SourceExpression.Validate(bodyisNoise, nameof(bodyisNoise), required: false);
            SourceExpression.Validate(bodyhowFixed, nameof(bodyhowFixed), required: false);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/mitigate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisCustomerImpacting != null)
                {
                    body["isCustomerImpacting"] = SourceExpressionConverter.ConvertToken(bodyisCustomerImpacting);
                    bodypropCount++;
                }

                if (bodyisNoise != null)
                {
                    body["isNoise"] = SourceExpressionConverter.ConvertToken(bodyisNoise);
                    bodypropCount++;
                }

                bodypropCount++;
                body["mitigation"] = SourceExpressionConverter.ConvertToken(bodymitigation);
                if (bodyhowFixed != null)
                {
                    body["howFixed"] = SourceExpressionConverter.ConvertToken(bodyhowFixed);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction ReactivateIncident([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bool> bodydisableVoiceNotifications = null, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodydisableVoiceNotifications, nameof(bodydisableVoiceNotifications), required: false);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/activate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydisableVoiceNotifications != null)
                {
                    body["disableVoiceNotifications"] = SourceExpressionConverter.ConvertToken(bodydisableVoiceNotifications);
                    bodypropCount++;
                }

                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IWorkflowAction ResolveIncident([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bool> bodyisCustomerImpacting = null, [WorkflowExpression] Func<bool> bodyisNoise = null, [WorkflowExpression] Func<icmEndpointInput> icmEndpoint = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodyisCustomerImpacting, nameof(bodyisCustomerImpacting), required: false);
            SourceExpression.Validate(bodyisNoise, nameof(bodyisNoise), required: false);
            SourceExpression.Validate(icmEndpoint, nameof(icmEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/icm/incidents/{0}/resolve", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["icmEndpoint"] = Convert.ToString("Public");
                if (icmEndpoint != null)
                    callPayload.Queries["icmEndpoint"] = SourceExpressionConverter.Convert(icmEndpoint);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisCustomerImpacting != null)
                {
                    body["isCustomerImpacting"] = SourceExpressionConverter.ConvertToken(bodyisCustomerImpacting);
                    bodypropCount++;
                }

                if (bodyisNoise != null)
                {
                    body["isNoise"] = SourceExpressionConverter.ConvertToken(bodyisNoise);
                    bodypropCount++;
                }

                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "icm")]
        public IBodyWorkflowAction<JToken> HttpRequest([WorkflowExpression] Func<string> uri, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(uri, nameof(uri), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Uri"] = SourceExpressionConverter.ConvertO(uri);
                callPayload.Headers["Method"] = SourceExpressionConverter.Convert(method);
                callPayload.Headers["ContentType"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["ContentType"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class IcmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<IcmIncidentResponseTriggerBatchResponse> WhenAnIcMIncidentIsCreated([WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<searchEndpointInput> searchEndpoint = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(filter, nameof(filter), required: true);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(searchEndpoint, nameof(searchEndpoint), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/icm/triggers/onIncidentCreated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                callPayload.Queries["searchEndpoint"] = Convert.ToString("Public");
                if (searchEndpoint != null)
                    callPayload.Queries["searchEndpoint"] = SourceExpressionConverter.Convert(searchEndpoint);
                return callPayload;
            }

            return new ApiConnectionTrigger<IcmIncidentResponseTriggerBatchResponse>(BuildSourceInput, triggerName, recurrence);
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

    public enum icmEndpointInput
    {
        Public,
        Eudb
    }

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

    public enum bodydiscussionEntryrenderTypeInput
    {
        Html,
        Plaintext
    }

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

    public enum IcmAccessClaimClaimTypeType
    {
        IcmContactAlias,
        MemberOfIcmTeamPublicId
    }

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

    public enum searchEndpointInput
    {
        Public,
        Eudb
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