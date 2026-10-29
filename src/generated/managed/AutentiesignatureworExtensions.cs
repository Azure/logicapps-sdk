//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Autentiesignaturewor
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AutentiesignatureworActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<ListDocumentsResponseItem[], ApiConnectionActionConfiguration> ListDocuments(Expression<Func<statusInput>> status = null, Expression<Func<sortInput>> sort = null, Expression<Func<string>> limit = null, Expression<Func<string>> modifiedAfter = null, Expression<Func<string>> modifiedBefore = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_modifiedAfter = WorkflowExpression.Compile(modifiedAfter, nameof(modifiedAfter), required: false);
            var __workflow_modifiedBefore = WorkflowExpression.Compile(modifiedBefore, nameof(modifiedBefore), required: false);
            return new DeferredBodyAction<ListDocumentsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document-processes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_modifiedAfter != null)
                    callPayload.Queries["modifiedAfter"] = ExpressionConverter.Convert(__workflow_modifiedAfter);
                if (__workflow_modifiedBefore != null)
                    callPayload.Queries["modifiedBefore"] = ExpressionConverter.Convert(__workflow_modifiedBefore);
                return new ApiConnectionAction<ListDocumentsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<DocumentProcessParticipantsResponse, ApiConnectionActionConfiguration> DocumentProcessParticipants(Expression<Func<string>> documentProcessId, Expression<Func<bodyparticipantTypeInput>> bodyparticipantType, Expression<Func<bodyroleTypeInput>> bodyroleType = null, Expression<Func<string>> bodysignatureType = null, Expression<Func<object>> bodyparticipantData = null)
        {
            var __workflow_documentProcessId = WorkflowExpression.Compile(documentProcessId, nameof(documentProcessId), required: true);
            var __workflow_bodyparticipantType = WorkflowExpression.Compile(bodyparticipantType, nameof(bodyparticipantType), required: true);
            var __workflow_bodyroleType = WorkflowExpression.Compile(bodyroleType, nameof(bodyroleType), required: false);
            var __workflow_bodysignatureType = WorkflowExpression.Compile(bodysignatureType, nameof(bodysignatureType), required: false);
            var __workflow_bodyparticipantData = WorkflowExpression.Compile(bodyparticipantData, nameof(bodyparticipantData), required: false);
            return new DeferredBodyAction<DocumentProcessParticipantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document-processes/{0}/parties", __workflow_documentProcessId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["participantType"] = ExpressionConverter.ConvertO(__workflow_bodyparticipantType);
                if (__workflow_bodyroleType != null)
                {
                    body["roleType"] = ExpressionConverter.ConvertO(__workflow_bodyroleType);
                    bodypropCount++;
                }

                if (__workflow_bodysignatureType != null)
                {
                    body["signatureType"] = ExpressionConverter.ConvertO(__workflow_bodysignatureType);
                    bodypropCount++;
                }

                if (__workflow_bodyparticipantData != null)
                {
                    body["participantData"] = ExpressionConverter.ConvertO(__workflow_bodyparticipantData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DocumentProcessParticipantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<GetFilesInfoResponse, ApiConnectionActionConfiguration> GetFilesInfo(Expression<Func<string>> documentProcessId, Expression<Func<filePurposeInput>> filePurpose = null)
        {
            var __workflow_documentProcessId = WorkflowExpression.Compile(documentProcessId, nameof(documentProcessId), required: true);
            var __workflow_filePurpose = WorkflowExpression.Compile(filePurpose, nameof(filePurpose), required: false);
            return new DeferredBodyAction<GetFilesInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document-processes/{0}/files", __workflow_documentProcessId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filePurpose != null)
                    callPayload.Queries["filePurpose"] = ExpressionConverter.Convert(__workflow_filePurpose);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetFilesInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<ActionsAvailabilityResponse, ApiConnectionActionConfiguration> ActionsAvailability(Expression<Func<string>> documentProcessId, Expression<Func<bodyeventTypeInput>> bodyeventType)
        {
            var __workflow_documentProcessId = WorkflowExpression.Compile(documentProcessId, nameof(documentProcessId), required: true);
            var __workflow_bodyeventType = WorkflowExpression.Compile(bodyeventType, nameof(bodyeventType), required: true);
            return new DeferredBodyAction<ActionsAvailabilityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document-processes/{0}/actions", __workflow_documentProcessId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_type"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ActionsAvailabilityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IBodyWorkflowAction<GetByIdResponse, ApiConnectionActionConfiguration> GetById(Expression<Func<string>> documentProcessId)
        {
            var __workflow_documentProcessId = WorkflowExpression.Compile(documentProcessId, nameof(documentProcessId), required: true);
            return new DeferredBodyAction<GetByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document-processes/{0}", __workflow_documentProcessId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadFile(Expression<Func<string>> documentProcessId, Expression<Func<string>> fileId)
        {
            var __workflow_documentProcessId = WorkflowExpression.Compile(documentProcessId, nameof(documentProcessId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document-processes/{0}/files/{1}/content", __workflow_documentProcessId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autentiesignaturewor")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddTag(Expression<Func<string>> documentProcessId, Expression<Func<string>> bodyid = null)
        {
            var __workflow_documentProcessId = WorkflowExpression.Compile(documentProcessId, nameof(documentProcessId), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document-processes/{0}/tags", __workflow_documentProcessId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
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

    public class AutentiesignatureworTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> DocumentChange(Expression<Func<string>> bodycallbackAdapterId, Expression<Func<string>> responseVariant = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycallbackAdapterId = WorkflowExpression.Compile(bodycallbackAdapterId, nameof(bodycallbackAdapterId), required: true);
            var __workflow_responseVariant = WorkflowExpression.Compile(responseVariant, nameof(responseVariant), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/applications/callbacks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["responseVariant"] = Convert.ToString("microsoft_power_automate");
                if (__workflow_responseVariant != null)
                    callPayload.Queries["responseVariant"] = ExpressionConverter.Convert(__workflow_responseVariant);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["callbackAdapterId"] = ExpressionConverter.ConvertO(__workflow_bodycallbackAdapterId);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        DRAFT,
        [EnumMember(Value = "DOCUMENT_PROCESS")]
        DOCUMENTPROCESS,
        EVERYTHING
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyparticipantTypeInput
    {
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "private")]
        Private
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyroleTypeInput
    {
        VIEWER,
        SIGNER,
        APPROVER,
        REVIEWER
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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