//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Autentiesignaturewor
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AutentiesignatureworActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<ListDocumentsResponseItem[]> ListDocuments([WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> modifiedAfter = null, [WorkflowExpression] Func<string> modifiedBefore = null)
        {
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(modifiedAfter, nameof(modifiedAfter), required: false);
            SourceExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document-processes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (modifiedAfter != null)
                    callPayload.Queries["modifiedAfter"] = SourceExpressionConverter.ConvertO(modifiedAfter);
                if (modifiedBefore != null)
                    callPayload.Queries["modifiedBefore"] = SourceExpressionConverter.ConvertO(modifiedBefore);
                return callPayload;
            }

            return new ApiConnectionAction<ListDocumentsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<DocumentProcessParticipantsResponse> DocumentProcessParticipants([WorkflowExpression] Func<string> documentProcessId, [WorkflowExpression] Func<bodyparticipantTypeInput> bodyparticipantType, [WorkflowExpression] Func<bodyroleTypeInput> bodyroleType = null, [WorkflowExpression] Func<string> bodysignatureType = null, [WorkflowExpression] Func<object> bodyparticipantData = null)
        {
            SourceExpression.Validate(documentProcessId, nameof(documentProcessId), required: true);
            SourceExpression.Validate(bodyparticipantType, nameof(bodyparticipantType), required: true);
            SourceExpression.Validate(bodyroleType, nameof(bodyroleType), required: false);
            SourceExpression.Validate(bodysignatureType, nameof(bodysignatureType), required: false);
            SourceExpression.Validate(bodyparticipantData, nameof(bodyparticipantData), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document-processes/{0}/parties", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentProcessId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["participantType"] = SourceExpressionConverter.Convert(bodyparticipantType);
                if (bodyroleType != null)
                {
                    body["roleType"] = SourceExpressionConverter.Convert(bodyroleType);
                    bodypropCount++;
                }

                if (bodysignatureType != null)
                {
                    body["signatureType"] = SourceExpressionConverter.ConvertToken(bodysignatureType);
                    bodypropCount++;
                }

                if (bodyparticipantData != null)
                {
                    body["participantData"] = SourceExpressionConverter.ConvertToken(bodyparticipantData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentProcessParticipantsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<AddFileResponse> AddFile([WorkflowExpression] Func<string> documentProcessId, [WorkflowExpression] Func<object> file)
        {
            SourceExpression.Validate(documentProcessId, nameof(documentProcessId), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document-processes/{0}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentProcessId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AddFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<GetFilesInfoResponse> GetFilesInfo([WorkflowExpression] Func<string> documentProcessId, [WorkflowExpression] Func<filePurposeInput> filePurpose = null)
        {
            SourceExpression.Validate(documentProcessId, nameof(documentProcessId), required: true);
            SourceExpression.Validate(filePurpose, nameof(filePurpose), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document-processes/{0}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentProcessId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filePurpose != null)
                    callPayload.Queries["filePurpose"] = SourceExpressionConverter.Convert(filePurpose);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetFilesInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<ActionsAvailabilityResponse> ActionsAvailability([WorkflowExpression] Func<string> documentProcessId, [WorkflowExpression] Func<bodyeventTypeInput> bodyeventType)
        {
            SourceExpression.Validate(documentProcessId, nameof(documentProcessId), required: true);
            SourceExpression.Validate(bodyeventType, nameof(bodyeventType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document-processes/{0}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentProcessId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_type"] = SourceExpressionConverter.Convert(bodyeventType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActionsAvailabilityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<GetByIdResponse> GetById([WorkflowExpression] Func<string> documentProcessId)
        {
            SourceExpression.Validate(documentProcessId, nameof(documentProcessId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document-processes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentProcessId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IWorkflowAction DownloadFile([WorkflowExpression] Func<string> documentProcessId, [WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(documentProcessId, nameof(documentProcessId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document-processes/{0}/files/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentProcessId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IWorkflowAction AddTag([WorkflowExpression] Func<string> documentProcessId, [WorkflowExpression] Func<string> bodyid = null)
        {
            SourceExpression.Validate(documentProcessId, nameof(documentProcessId), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document-processes/{0}/tags", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentProcessId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
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

    public class AutentiesignatureworTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger DocumentChange([WorkflowExpression] Func<string> bodycallbackAdapterId, [WorkflowExpression] Func<string> responseVariant = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodycallbackAdapterId, nameof(bodycallbackAdapterId), required: true);
            SourceExpression.Validate(responseVariant, nameof(responseVariant), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/applications/callbacks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["responseVariant"] = Convert.ToString("microsoft_power_automate");
                if (responseVariant != null)
                    callPayload.Queries["responseVariant"] = SourceExpressionConverter.ConvertO(responseVariant);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["callbackAdapterId"] = SourceExpressionConverter.ConvertToken(bodycallbackAdapterId);
                var callbackParametersObject = new JObject();
                var callbackParametersObjectpropCount = 0;
                callbackParametersObject["callbackUrl"] = "#{listCallbackUrl()}";
                callbackParametersObjectpropCount++;
                if (callbackParametersObjectpropCount > 0)
                {
                    body["callbackParameters"] = callbackParametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class ListDocumentsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("modificationTime")]
        public string ModificationTime { get; set; }

        [JsonProperty("filePurpose")]
        public string FilePurpose { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("mimeTypeBeforeConversion")]
        public string MimeTypeBeforeConversion { get; set; }

        [JsonProperty("conversionStatus")]
        public string ConversionStatus { get; set; }

        [JsonProperty("relationships")]
        public string Relationships { get; set; }

        [JsonProperty("processes")]
        public string Processes { get; set; }
    }

    public enum statusInput
    {
        DRAFT,
        [EnumMember(Value = "DOCUMENT_PROCESS")]
        DOCUMENTPROCESS,
        EVERYTHING
    }

    public enum sortInput
    {
        ASCENDING,
        DESCENDING
    }

    public class DocumentProcessParticipantsResponse
    {
        [JsonProperty("party")]
        public DocumentProcessParticipantsResponsePartyType Party { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("participationStatus")]
        public string ParticipationStatus { get; set; }

        [JsonProperty("constraints")]
        public DocumentProcessParticipantsResponseConstraintsTypeItem[] Constraints { get; set; }

        [JsonProperty("currentUser")]
        public bool CurrentUser { get; set; }

        [JsonProperty("events")]
        public JToken[] Events { get; set; }
    }

    public class DocumentProcessParticipantsResponsePartyType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contacts")]
        public DocumentProcessParticipantsResponsePartyTypeContactsTypeItem[] Contacts { get; set; }

        [JsonProperty("extIds")]
        public JToken[] ExtIds { get; set; }

        [JsonProperty("relationships")]
        public DocumentProcessParticipantsResponsePartyTypeRelationshipsTypeItem[] Relationships { get; set; }
    }

    public class DocumentProcessParticipantsResponsePartyTypeContactsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public DocumentProcessParticipantsResponsePartyTypeContactsTypeItemAttributesType Attributes { get; set; }
    }

    public class DocumentProcessParticipantsResponsePartyTypeContactsTypeItemAttributesType
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class DocumentProcessParticipantsResponsePartyTypeRelationshipsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("party")]
        public DocumentProcessParticipantsResponsePartyTypeRelationshipsTypeItemPartyType Party { get; set; }

        [JsonProperty("attributes")]
        public DocumentProcessParticipantsResponsePartyTypeRelationshipsTypeItemAttributesType Attributes { get; set; }
    }

    public class DocumentProcessParticipantsResponsePartyTypeRelationshipsTypeItemPartyType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contacts")]
        public JToken[] Contacts { get; set; }

        [JsonProperty("extIds")]
        public DocumentProcessParticipantsResponsePartyTypeRelationshipsTypeItemPartyTypeExtIdsTypeItem[] ExtIds { get; set; }

        [JsonProperty("relationships")]
        public JToken[] Relationships { get; set; }
    }

    public class DocumentProcessParticipantsResponsePartyTypeRelationshipsTypeItemPartyTypeExtIdsTypeItem
    {
        [JsonProperty("identificationSpace")]
        public string IdentificationSpace { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }

    public class DocumentProcessParticipantsResponsePartyTypeRelationshipsTypeItemAttributesType
    {
        [JsonProperty("relationshipDescription")]
        public string RelationshipDescription { get; set; }
    }

    public class DocumentProcessParticipantsResponseConstraintsTypeItem
    {
        [JsonProperty("constrainedActions")]
        public string[] ConstrainedActions { get; set; }

        [JsonProperty("classifiers")]
        public string[] Classifiers { get; set; }

        [JsonProperty("attributes")]
        public DocumentProcessParticipantsResponseConstraintsTypeItemAttributesType Attributes { get; set; }
    }

    public class DocumentProcessParticipantsResponseConstraintsTypeItemAttributesType
    {
        [JsonProperty("requiredClassifiers")]
        public string[] RequiredClassifiers { get; set; }
    }

    public enum bodyparticipantTypeInput
    {
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "private")]
        Private
    }

    public enum bodyroleTypeInput
    {
        VIEWER,
        SIGNER,
        APPROVER,
        REVIEWER
    }

    public class AddFileResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("filePurpose")]
        public string FilePurpose { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public class GetFilesInfoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("filePurpose")]
        public string FilePurpose { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public enum filePurposeInput
    {
        [EnumMember(Value = "SOURCE_FILE")]
        SOURCEFILE,
        [EnumMember(Value = "SIGNED_CONTENT_FILE")]
        SIGNEDCONTENTFILE,
        [EnumMember(Value = "CONTENT_ARCHIVE")]
        CONTENTARCHIVE
    }

    public class ActionsAvailabilityResponse
    {
        [JsonProperty("classifiers")]
        public string[] Classifiers { get; set; }

        [JsonProperty("attributes")]
        public ActionsAvailabilityResponseAttributesType Attributes { get; set; }
    }

    public class ActionsAvailabilityResponseAttributesType
    {
        [JsonProperty("options")]
        public ActionsAvailabilityResponseAttributesTypeOptionsTypeItem[] Options { get; set; }
    }

    public class ActionsAvailabilityResponseAttributesTypeOptionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("meta")]
        public string Meta { get; set; }
    }

    public enum bodyeventTypeInput
    {
        [EnumMember(Value = "Start document signing process")]
        StartDocumentSigningProcess,
        [EnumMember(Value = "Withdraw (stop) document process")]
        WithdrawStopDocumentProcess
    }

    public class GetByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("processLanguage")]
        public string ProcessLanguage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("parties")]
        public GetByIdResponsePartiesTypeItem[] Parties { get; set; }

        [JsonProperty("files")]
        public GetByIdResponseFilesTypeItem[] Files { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("constraints")]
        public GetByIdResponseConstraintsTypeItem[] Constraints { get; set; }

        [JsonProperty("flags")]
        public JToken[] Flags { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }
    }

    public class GetByIdResponsePartiesTypeItem
    {
        [JsonProperty("party")]
        public GetByIdResponsePartiesTypeItemPartyType Party { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("participationStatus")]
        public string ParticipationStatus { get; set; }

        [JsonProperty("constraints")]
        public GetByIdResponsePartiesTypeItemConstraintsTypeItem[] Constraints { get; set; }

        [JsonProperty("currentUser")]
        public bool CurrentUser { get; set; }

        [JsonProperty("events")]
        public JToken[] Events { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemPartyType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contacts")]
        public GetByIdResponsePartiesTypeItemPartyTypeContactsTypeItem[] Contacts { get; set; }

        [JsonProperty("extIds")]
        public JToken[] ExtIds { get; set; }

        [JsonProperty("relationships")]
        public GetByIdResponsePartiesTypeItemPartyTypeRelationshipsTypeItem[] Relationships { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemPartyTypeContactsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public GetByIdResponsePartiesTypeItemPartyTypeContactsTypeItemAttributesType Attributes { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemPartyTypeContactsTypeItemAttributesType
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemPartyTypeRelationshipsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("party")]
        public GetByIdResponsePartiesTypeItemPartyTypeRelationshipsTypeItemPartyType Party { get; set; }

        [JsonProperty("attributes")]
        public GetByIdResponsePartiesTypeItemPartyTypeRelationshipsTypeItemAttributesType Attributes { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemPartyTypeRelationshipsTypeItemPartyType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contacts")]
        public JToken[] Contacts { get; set; }

        [JsonProperty("extIds")]
        public GetByIdResponsePartiesTypeItemPartyTypeRelationshipsTypeItemPartyTypeExtIdsTypeItem[] ExtIds { get; set; }

        [JsonProperty("relationships")]
        public JToken[] Relationships { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemPartyTypeRelationshipsTypeItemPartyTypeExtIdsTypeItem
    {
        [JsonProperty("identificationSpace")]
        public string IdentificationSpace { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemPartyTypeRelationshipsTypeItemAttributesType
    {
        [JsonProperty("relationshipDescription")]
        public string RelationshipDescription { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemConstraintsTypeItem
    {
        [JsonProperty("constrainedActions")]
        public string[] ConstrainedActions { get; set; }

        [JsonProperty("classifiers")]
        public string[] Classifiers { get; set; }

        [JsonProperty("attributes")]
        public GetByIdResponsePartiesTypeItemConstraintsTypeItemAttributesType Attributes { get; set; }
    }

    public class GetByIdResponsePartiesTypeItemConstraintsTypeItemAttributesType
    {
        [JsonProperty("requiredClassifiers")]
        public string[] RequiredClassifiers { get; set; }
    }

    public class GetByIdResponseFilesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("modificationTime")]
        public string ModificationTime { get; set; }

        [JsonProperty("filePurpose")]
        public string FilePurpose { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("mimeTypeBeforeConversion")]
        public string MimeTypeBeforeConversion { get; set; }

        [JsonProperty("conversionStatus")]
        public string ConversionStatus { get; set; }

        [JsonProperty("processes")]
        public string Processes { get; set; }
    }

    public class GetByIdResponseConstraintsTypeItem
    {
        [JsonProperty("constrainedActions")]
        public string[] ConstrainedActions { get; set; }

        [JsonProperty("classifiers")]
        public string[] Classifiers { get; set; }

        [JsonProperty("attributes")]
        public GetByIdResponseConstraintsTypeItemAttributesType Attributes { get; set; }
    }

    public class GetByIdResponseConstraintsTypeItemAttributesType
    {
        [JsonProperty("requiredClassifiers")]
        public string[] RequiredClassifiers { get; set; }

        [JsonProperty("visualisationId")]
        public string VisualisationId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Autentiesignaturewor;

    public partial class WorkflowManagedActions
    {
        public AutentiesignatureworActions Autentiesignaturewor(string connectionId) => new AutentiesignatureworActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AutentiesignatureworTriggers Autentiesignaturewor(string connectionId) => new AutentiesignatureworTriggers(connectionId);
    }
}