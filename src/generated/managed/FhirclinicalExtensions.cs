//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fhirclinical
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FhirclinicalActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETAdverseEvent))]
        public IBodyWorkflowAction<GETAdverseEventResponse> GETAdverseEvent([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETAdverseEventResponse> __BuildGETAdverseEvent(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETAdverseEventResponse>(() =>
            {
                var apiCallPath = "/AdverseEvent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETAdverseEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTAdverseEvent))]
        public IBodyWorkflowAction<POSTAdverseEventResponse> POSTAdverseEvent([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyidentifiersystem = null, [WorkflowExpression] Func<string> bodyidentifiervalue = null, [WorkflowExpression] Func<string> bodyactuality = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodyEventcodingInputItem[]> bodyEventcoding = null, [WorkflowExpression] Func<string> bodyEventtext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bodyseriousnesscodingInputItem[]> bodyseriousnesscoding = null, [WorkflowExpression] Func<bodyseveritycodingInputItem[]> bodyseveritycoding = null, [WorkflowExpression] Func<string> bodyrecorderreference = null, [WorkflowExpression] Func<bodysuspectEntityInputItem[]> bodysuspectEntity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTAdverseEventResponse> __BuildPOSTAdverseEvent(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodyidentifiersystem = null, WorkflowExpression<string> bodyidentifiervalue = null, WorkflowExpression<string> bodyactuality = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodyEventcodingInputItem[]> bodyEventcoding = null, WorkflowExpression<string> bodyEventtext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodydate = null, WorkflowExpression<bodyseriousnesscodingInputItem[]> bodyseriousnesscoding = null, WorkflowExpression<bodyseveritycodingInputItem[]> bodyseveritycoding = null, WorkflowExpression<string> bodyrecorderreference = null, WorkflowExpression<bodysuspectEntityInputItem[]> bodysuspectEntity = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodyidentifiersystem, nameof(bodyidentifiersystem), required: false);
            WorkflowExpression.Validate(bodyidentifiervalue, nameof(bodyidentifiervalue), required: false);
            WorkflowExpression.Validate(bodyactuality, nameof(bodyactuality), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyEventcoding, nameof(bodyEventcoding), required: false);
            WorkflowExpression.Validate(bodyEventtext, nameof(bodyEventtext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodyseriousnesscoding, nameof(bodyseriousnesscoding), required: false);
            WorkflowExpression.Validate(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            WorkflowExpression.Validate(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            WorkflowExpression.Validate(bodysuspectEntity, nameof(bodysuspectEntity), required: false);
            return new DeferredBodyAction<POSTAdverseEventResponse>(() =>
            {
                var apiCallPath = "/AdverseEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var identifierObject = new JObject();
                var identifierObjectpropCount = 0;
                if (bodyidentifiersystem != null)
                {
                    identifierObject["system"] = ExpressionConverter.ConvertO(bodyidentifiersystem);
                    identifierObjectpropCount++;
                }

                if (bodyidentifiervalue != null)
                {
                    identifierObject["value"] = ExpressionConverter.ConvertO(bodyidentifiervalue);
                    identifierObjectpropCount++;
                }

                if (identifierObjectpropCount > 0)
                {
                    body["identifier"] = identifierObject;
                    bodypropCount++;
                }

                if (bodyactuality != null)
                {
                    body["actuality"] = ExpressionConverter.ConvertO(bodyactuality);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (bodyEventcoding != null)
                {
                    @eventObject["coding"] = ExpressionConverter.ConvertO(bodyEventcoding);
                    @eventObjectpropCount++;
                }

                if (bodyEventtext != null)
                {
                    @eventObject["text"] = ExpressionConverter.ConvertO(bodyEventtext);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    body["event"] = @eventObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                var seriousnessObject = new JObject();
                var seriousnessObjectpropCount = 0;
                if (bodyseriousnesscoding != null)
                {
                    seriousnessObject["coding"] = ExpressionConverter.ConvertO(bodyseriousnesscoding);
                    seriousnessObjectpropCount++;
                }

                if (seriousnessObjectpropCount > 0)
                {
                    body["seriousness"] = seriousnessObject;
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                if (bodysuspectEntity != null)
                {
                    body["suspectEntity"] = ExpressionConverter.ConvertO(bodysuspectEntity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTAdverseEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETAdverseEventID))]
        public IBodyWorkflowAction<GETAdverseEventIDResponse> GETAdverseEventID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETAdverseEventIDResponse> __BuildGETAdverseEventID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETAdverseEventIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/AdverseEvent/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETAdverseEventIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEAdverseEventID))]
        public IBodyWorkflowAction<DELETEAdverseEventIDResponse> DELETEAdverseEventID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodyidentifiersystem = null, [WorkflowExpression] Func<string> bodyidentifiervalue = null, [WorkflowExpression] Func<string> bodyactuality = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodyEventcodingInputItem[]> bodyEventcoding = null, [WorkflowExpression] Func<string> bodyEventtext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bodyseriousnesscodingInputItem[]> bodyseriousnesscoding = null, [WorkflowExpression] Func<bodyseveritycodingInputItem[]> bodyseveritycoding = null, [WorkflowExpression] Func<string> bodyrecorderreference = null, [WorkflowExpression] Func<bodysuspectEntityInputItem[]> bodysuspectEntity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETEAdverseEventIDResponse> __BuildDELETEAdverseEventID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodyidentifiersystem = null, WorkflowExpression<string> bodyidentifiervalue = null, WorkflowExpression<string> bodyactuality = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodyEventcodingInputItem[]> bodyEventcoding = null, WorkflowExpression<string> bodyEventtext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodydate = null, WorkflowExpression<bodyseriousnesscodingInputItem[]> bodyseriousnesscoding = null, WorkflowExpression<bodyseveritycodingInputItem[]> bodyseveritycoding = null, WorkflowExpression<string> bodyrecorderreference = null, WorkflowExpression<bodysuspectEntityInputItem[]> bodysuspectEntity = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodyidentifiersystem, nameof(bodyidentifiersystem), required: false);
            WorkflowExpression.Validate(bodyidentifiervalue, nameof(bodyidentifiervalue), required: false);
            WorkflowExpression.Validate(bodyactuality, nameof(bodyactuality), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyEventcoding, nameof(bodyEventcoding), required: false);
            WorkflowExpression.Validate(bodyEventtext, nameof(bodyEventtext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodyseriousnesscoding, nameof(bodyseriousnesscoding), required: false);
            WorkflowExpression.Validate(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            WorkflowExpression.Validate(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            WorkflowExpression.Validate(bodysuspectEntity, nameof(bodysuspectEntity), required: false);
            return new DeferredBodyAction<DELETEAdverseEventIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/AdverseEvent/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var identifierObject = new JObject();
                var identifierObjectpropCount = 0;
                if (bodyidentifiersystem != null)
                {
                    identifierObject["system"] = ExpressionConverter.ConvertO(bodyidentifiersystem);
                    identifierObjectpropCount++;
                }

                if (bodyidentifiervalue != null)
                {
                    identifierObject["value"] = ExpressionConverter.ConvertO(bodyidentifiervalue);
                    identifierObjectpropCount++;
                }

                if (identifierObjectpropCount > 0)
                {
                    body["identifier"] = identifierObject;
                    bodypropCount++;
                }

                if (bodyactuality != null)
                {
                    body["actuality"] = ExpressionConverter.ConvertO(bodyactuality);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (bodyEventcoding != null)
                {
                    @eventObject["coding"] = ExpressionConverter.ConvertO(bodyEventcoding);
                    @eventObjectpropCount++;
                }

                if (bodyEventtext != null)
                {
                    @eventObject["text"] = ExpressionConverter.ConvertO(bodyEventtext);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    body["event"] = @eventObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                var seriousnessObject = new JObject();
                var seriousnessObjectpropCount = 0;
                if (bodyseriousnesscoding != null)
                {
                    seriousnessObject["coding"] = ExpressionConverter.ConvertO(bodyseriousnesscoding);
                    seriousnessObjectpropCount++;
                }

                if (seriousnessObjectpropCount > 0)
                {
                    body["seriousness"] = seriousnessObject;
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                if (bodysuspectEntity != null)
                {
                    body["suspectEntity"] = ExpressionConverter.ConvertO(bodysuspectEntity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEAdverseEventIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTAdverseEventID))]
        public IBodyWorkflowAction<PUTAdverseEventIDResponse> PUTAdverseEventID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodyidentifiersystem = null, [WorkflowExpression] Func<string> bodyidentifiervalue = null, [WorkflowExpression] Func<string> bodyactuality = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodyEventcodingInputItem[]> bodyEventcoding = null, [WorkflowExpression] Func<string> bodyEventtext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bodyseriousnesscodingInputItem[]> bodyseriousnesscoding = null, [WorkflowExpression] Func<bodyseveritycodingInputItem[]> bodyseveritycoding = null, [WorkflowExpression] Func<string> bodyrecorderreference = null, [WorkflowExpression] Func<bodysuspectEntityInputItem[]> bodysuspectEntity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTAdverseEventIDResponse> __BuildPUTAdverseEventID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodyidentifiersystem = null, WorkflowExpression<string> bodyidentifiervalue = null, WorkflowExpression<string> bodyactuality = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodyEventcodingInputItem[]> bodyEventcoding = null, WorkflowExpression<string> bodyEventtext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodydate = null, WorkflowExpression<bodyseriousnesscodingInputItem[]> bodyseriousnesscoding = null, WorkflowExpression<bodyseveritycodingInputItem[]> bodyseveritycoding = null, WorkflowExpression<string> bodyrecorderreference = null, WorkflowExpression<bodysuspectEntityInputItem[]> bodysuspectEntity = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodyidentifiersystem, nameof(bodyidentifiersystem), required: false);
            WorkflowExpression.Validate(bodyidentifiervalue, nameof(bodyidentifiervalue), required: false);
            WorkflowExpression.Validate(bodyactuality, nameof(bodyactuality), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyEventcoding, nameof(bodyEventcoding), required: false);
            WorkflowExpression.Validate(bodyEventtext, nameof(bodyEventtext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodyseriousnesscoding, nameof(bodyseriousnesscoding), required: false);
            WorkflowExpression.Validate(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            WorkflowExpression.Validate(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            WorkflowExpression.Validate(bodysuspectEntity, nameof(bodysuspectEntity), required: false);
            return new DeferredBodyAction<PUTAdverseEventIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/AdverseEvent/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var identifierObject = new JObject();
                var identifierObjectpropCount = 0;
                if (bodyidentifiersystem != null)
                {
                    identifierObject["system"] = ExpressionConverter.ConvertO(bodyidentifiersystem);
                    identifierObjectpropCount++;
                }

                if (bodyidentifiervalue != null)
                {
                    identifierObject["value"] = ExpressionConverter.ConvertO(bodyidentifiervalue);
                    identifierObjectpropCount++;
                }

                if (identifierObjectpropCount > 0)
                {
                    body["identifier"] = identifierObject;
                    bodypropCount++;
                }

                if (bodyactuality != null)
                {
                    body["actuality"] = ExpressionConverter.ConvertO(bodyactuality);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (bodyEventcoding != null)
                {
                    @eventObject["coding"] = ExpressionConverter.ConvertO(bodyEventcoding);
                    @eventObjectpropCount++;
                }

                if (bodyEventtext != null)
                {
                    @eventObject["text"] = ExpressionConverter.ConvertO(bodyEventtext);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    body["event"] = @eventObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                var seriousnessObject = new JObject();
                var seriousnessObjectpropCount = 0;
                if (bodyseriousnesscoding != null)
                {
                    seriousnessObject["coding"] = ExpressionConverter.ConvertO(bodyseriousnesscoding);
                    seriousnessObjectpropCount++;
                }

                if (seriousnessObjectpropCount > 0)
                {
                    body["seriousness"] = seriousnessObject;
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                if (bodysuspectEntity != null)
                {
                    body["suspectEntity"] = ExpressionConverter.ConvertO(bodysuspectEntity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTAdverseEventIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETAllergyIntolerance))]
        public IBodyWorkflowAction<GETAllergyIntoleranceResponse> GETAllergyIntolerance([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETAllergyIntoleranceResponse> __BuildGETAllergyIntolerance(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETAllergyIntoleranceResponse>(() =>
            {
                var apiCallPath = "/AllergyIntolerance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETAllergyIntoleranceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTAllergyIntolerance))]
        public IBodyWorkflowAction<POSTAllergyIntoleranceResponse> POSTAllergyIntolerance([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodyclinicalStatuscodingInputItem[]> bodyclinicalStatuscoding = null, [WorkflowExpression] Func<bodyverificationStatuscodingInputItem[]> bodyverificationStatuscoding = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string[]> bodycategory = null, [WorkflowExpression] Func<string> bodycriticality = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodypatientreference = null, [WorkflowExpression] Func<string> bodyrecordedDate = null, [WorkflowExpression] Func<string> bodyrecorderreference = null, [WorkflowExpression] Func<bodyreactionInputItem[]> bodyreaction = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTAllergyIntoleranceResponse> __BuildPOSTAllergyIntolerance(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodyclinicalStatuscodingInputItem[]> bodyclinicalStatuscoding = null, WorkflowExpression<bodyverificationStatuscodingInputItem[]> bodyverificationStatuscoding = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string[]> bodycategory = null, WorkflowExpression<string> bodycriticality = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodypatientreference = null, WorkflowExpression<string> bodyrecordedDate = null, WorkflowExpression<string> bodyrecorderreference = null, WorkflowExpression<bodyreactionInputItem[]> bodyreaction = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            WorkflowExpression.Validate(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycriticality, nameof(bodycriticality), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodypatientreference, nameof(bodypatientreference), required: false);
            WorkflowExpression.Validate(bodyrecordedDate, nameof(bodyrecordedDate), required: false);
            WorkflowExpression.Validate(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            WorkflowExpression.Validate(bodyreaction, nameof(bodyreaction), required: false);
            return new DeferredBodyAction<POSTAllergyIntoleranceResponse>(() =>
            {
                var apiCallPath = "/AllergyIntolerance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodycriticality != null)
                {
                    body["criticality"] = ExpressionConverter.ConvertO(bodycriticality);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var patientObject = new JObject();
                var patientObjectpropCount = 0;
                if (bodypatientreference != null)
                {
                    patientObject["reference"] = ExpressionConverter.ConvertO(bodypatientreference);
                    patientObjectpropCount++;
                }

                if (patientObjectpropCount > 0)
                {
                    body["patient"] = patientObject;
                    bodypropCount++;
                }

                if (bodyrecordedDate != null)
                {
                    body["recordedDate"] = ExpressionConverter.ConvertO(bodyrecordedDate);
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                if (bodyreaction != null)
                {
                    body["reaction"] = ExpressionConverter.ConvertO(bodyreaction);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTAllergyIntoleranceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETAllergyIntoleranceID))]
        public IBodyWorkflowAction<GETAllergyIntoleranceIDResponse> GETAllergyIntoleranceID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETAllergyIntoleranceIDResponse> __BuildGETAllergyIntoleranceID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETAllergyIntoleranceIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/AllergyIntolerance/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETAllergyIntoleranceIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEAllergyIntoleranceID))]
        public IBodyWorkflowAction<DELETEAllergyIntoleranceIDResponse> DELETEAllergyIntoleranceID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, [WorkflowExpression] Func<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string[]> bodycategory = null, [WorkflowExpression] Func<string> bodycriticality = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodypatientreference = null, [WorkflowExpression] Func<string> bodyrecordedDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETEAllergyIntoleranceIDResponse> __BuildDELETEAllergyIntoleranceID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, WorkflowExpression<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string[]> bodycategory = null, WorkflowExpression<string> bodycriticality = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<string> bodypatientreference = null, WorkflowExpression<string> bodyrecordedDate = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            WorkflowExpression.Validate(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycriticality, nameof(bodycriticality), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodypatientreference, nameof(bodypatientreference), required: false);
            WorkflowExpression.Validate(bodyrecordedDate, nameof(bodyrecordedDate), required: false);
            return new DeferredBodyAction<DELETEAllergyIntoleranceIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/AllergyIntolerance/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodycriticality != null)
                {
                    body["criticality"] = ExpressionConverter.ConvertO(bodycriticality);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var patientObject = new JObject();
                var patientObjectpropCount = 0;
                if (bodypatientreference != null)
                {
                    patientObject["reference"] = ExpressionConverter.ConvertO(bodypatientreference);
                    patientObjectpropCount++;
                }

                if (patientObjectpropCount > 0)
                {
                    body["patient"] = patientObject;
                    bodypropCount++;
                }

                if (bodyrecordedDate != null)
                {
                    body["recordedDate"] = ExpressionConverter.ConvertO(bodyrecordedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEAllergyIntoleranceIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTAllergyIntoleranceID))]
        public IBodyWorkflowAction<PUTAllergyIntoleranceIDResponse> PUTAllergyIntoleranceID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, [WorkflowExpression] Func<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string[]> bodycategory = null, [WorkflowExpression] Func<string> bodycriticality = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodypatientreference = null, [WorkflowExpression] Func<string> bodyrecordedDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTAllergyIntoleranceIDResponse> __BuildPUTAllergyIntoleranceID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, WorkflowExpression<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string[]> bodycategory = null, WorkflowExpression<string> bodycriticality = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<string> bodypatientreference = null, WorkflowExpression<string> bodyrecordedDate = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            WorkflowExpression.Validate(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycriticality, nameof(bodycriticality), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodypatientreference, nameof(bodypatientreference), required: false);
            WorkflowExpression.Validate(bodyrecordedDate, nameof(bodyrecordedDate), required: false);
            return new DeferredBodyAction<PUTAllergyIntoleranceIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/AllergyIntolerance/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodycriticality != null)
                {
                    body["criticality"] = ExpressionConverter.ConvertO(bodycriticality);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var patientObject = new JObject();
                var patientObjectpropCount = 0;
                if (bodypatientreference != null)
                {
                    patientObject["reference"] = ExpressionConverter.ConvertO(bodypatientreference);
                    patientObjectpropCount++;
                }

                if (patientObjectpropCount > 0)
                {
                    body["patient"] = patientObject;
                    bodypropCount++;
                }

                if (bodyrecordedDate != null)
                {
                    body["recordedDate"] = ExpressionConverter.ConvertO(bodyrecordedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTAllergyIntoleranceIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETCarePlan))]
        public IBodyWorkflowAction<GETCarePlanResponse> GETCarePlan([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETCarePlanResponse> __BuildGETCarePlan(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETCarePlanResponse>(() =>
            {
                var apiCallPath = "/CarePlan";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETCarePlanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTCarePlan))]
        public IBodyWorkflowAction<POSTCarePlanResponse> POSTCarePlan([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyintent = null, [WorkflowExpression] Func<bodycategoryInputItem2[]> bodycategory = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyencounterreference = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<string> bodyperiodend = null, [WorkflowExpression] Func<bodycareTeamInputItem[]> bodycareTeam = null, [WorkflowExpression] Func<bodyaddressesInputItem[]> bodyaddresses = null, [WorkflowExpression] Func<bodyactivityInputItem[]> bodyactivity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTCarePlanResponse> __BuildPOSTCarePlan(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyintent = null, WorkflowExpression<bodycategoryInputItem2[]> bodycategory = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyencounterreference = null, WorkflowExpression<string> bodyperiodstart = null, WorkflowExpression<string> bodyperiodend = null, WorkflowExpression<bodycareTeamInputItem[]> bodycareTeam = null, WorkflowExpression<bodyaddressesInputItem[]> bodyaddresses = null, WorkflowExpression<bodyactivityInputItem[]> bodyactivity = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyintent, nameof(bodyintent), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyencounterreference, nameof(bodyencounterreference), required: false);
            WorkflowExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            WorkflowExpression.Validate(bodyperiodend, nameof(bodyperiodend), required: false);
            WorkflowExpression.Validate(bodycareTeam, nameof(bodycareTeam), required: false);
            WorkflowExpression.Validate(bodyaddresses, nameof(bodyaddresses), required: false);
            WorkflowExpression.Validate(bodyactivity, nameof(bodyactivity), required: false);
            return new DeferredBodyAction<POSTCarePlanResponse>(() =>
            {
                var apiCallPath = "/CarePlan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(bodyintent);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (bodyperiodend != null)
                {
                    periodObject["end"] = ExpressionConverter.ConvertO(bodyperiodend);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                if (bodycareTeam != null)
                {
                    body["careTeam"] = ExpressionConverter.ConvertO(bodycareTeam);
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(bodyaddresses);
                    bodypropCount++;
                }

                if (bodyactivity != null)
                {
                    body["activity"] = ExpressionConverter.ConvertO(bodyactivity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTCarePlanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETCarePlanID))]
        public IBodyWorkflowAction<GETCarePlanIDResponse> GETCarePlanID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETCarePlanIDResponse> __BuildGETCarePlanID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETCarePlanIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/CarePlan/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETCarePlanIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETECarePlanID))]
        public IBodyWorkflowAction<DELETECarePlanIDResponse> DELETECarePlanID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodycontainedInputItem[]> bodycontained = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyintent = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<bodycareTeamInputItem[]> bodycareTeam = null, [WorkflowExpression] Func<bodyaddressesInputItem2[]> bodyaddresses = null, [WorkflowExpression] Func<bodygoalInputItem[]> bodygoal = null, [WorkflowExpression] Func<bodyactivityInputItem2[]> bodyactivity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETECarePlanIDResponse> __BuildDELETECarePlanID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodycontainedInputItem[]> bodycontained = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyintent = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyperiodstart = null, WorkflowExpression<bodycareTeamInputItem[]> bodycareTeam = null, WorkflowExpression<bodyaddressesInputItem2[]> bodyaddresses = null, WorkflowExpression<bodygoalInputItem[]> bodygoal = null, WorkflowExpression<bodyactivityInputItem2[]> bodyactivity = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodycontained, nameof(bodycontained), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyintent, nameof(bodyintent), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            WorkflowExpression.Validate(bodycareTeam, nameof(bodycareTeam), required: false);
            WorkflowExpression.Validate(bodyaddresses, nameof(bodyaddresses), required: false);
            WorkflowExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            WorkflowExpression.Validate(bodyactivity, nameof(bodyactivity), required: false);
            return new DeferredBodyAction<DELETECarePlanIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/CarePlan/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(bodycontained);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(bodyintent);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                if (bodycareTeam != null)
                {
                    body["careTeam"] = ExpressionConverter.ConvertO(bodycareTeam);
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(bodyaddresses);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                    bodypropCount++;
                }

                if (bodyactivity != null)
                {
                    body["activity"] = ExpressionConverter.ConvertO(bodyactivity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETECarePlanIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTCarePlanID))]
        public IBodyWorkflowAction<PUTCarePlanIDResponse> PUTCarePlanID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodycontainedInputItem[]> bodycontained = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyintent = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyperiodstart = null, [WorkflowExpression] Func<bodycareTeamInputItem[]> bodycareTeam = null, [WorkflowExpression] Func<bodyaddressesInputItem2[]> bodyaddresses = null, [WorkflowExpression] Func<bodygoalInputItem[]> bodygoal = null, [WorkflowExpression] Func<bodyactivityInputItem2[]> bodyactivity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTCarePlanIDResponse> __BuildPUTCarePlanID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodycontainedInputItem[]> bodycontained = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyintent = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyperiodstart = null, WorkflowExpression<bodycareTeamInputItem[]> bodycareTeam = null, WorkflowExpression<bodyaddressesInputItem2[]> bodyaddresses = null, WorkflowExpression<bodygoalInputItem[]> bodygoal = null, WorkflowExpression<bodyactivityInputItem2[]> bodyactivity = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodycontained, nameof(bodycontained), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyintent, nameof(bodyintent), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyperiodstart, nameof(bodyperiodstart), required: false);
            WorkflowExpression.Validate(bodycareTeam, nameof(bodycareTeam), required: false);
            WorkflowExpression.Validate(bodyaddresses, nameof(bodyaddresses), required: false);
            WorkflowExpression.Validate(bodygoal, nameof(bodygoal), required: false);
            WorkflowExpression.Validate(bodyactivity, nameof(bodyactivity), required: false);
            return new DeferredBodyAction<PUTCarePlanIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/CarePlan/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(bodycontained);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(bodyintent);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (bodyperiodstart != null)
                {
                    periodObject["start"] = ExpressionConverter.ConvertO(bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                if (bodycareTeam != null)
                {
                    body["careTeam"] = ExpressionConverter.ConvertO(bodycareTeam);
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(bodyaddresses);
                    bodypropCount++;
                }

                if (bodygoal != null)
                {
                    body["goal"] = ExpressionConverter.ConvertO(bodygoal);
                    bodypropCount++;
                }

                if (bodyactivity != null)
                {
                    body["activity"] = ExpressionConverter.ConvertO(bodyactivity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTCarePlanIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETCondition))]
        public IBodyWorkflowAction<GETConditionResponse> GETCondition([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETConditionResponse> __BuildGETCondition(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETConditionResponse>(() =>
            {
                var apiCallPath = "/Condition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETConditionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTCondition))]
        public IBodyWorkflowAction<POSTConditionResponse> POSTCondition([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, [WorkflowExpression] Func<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodyseveritycodingInputItem[]> bodyseveritycoding = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<bodybodySiteInputItem[]> bodybodySite = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyonsetDateTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTConditionResponse> __BuildPOSTCondition(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, WorkflowExpression<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodyseveritycodingInputItem[]> bodyseveritycoding = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<bodybodySiteInputItem[]> bodybodySite = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyonsetDateTime = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            WorkflowExpression.Validate(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodybodySite, nameof(bodybodySite), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyonsetDateTime, nameof(bodyonsetDateTime), required: false);
            return new DeferredBodyAction<POSTConditionResponse>(() =>
            {
                var apiCallPath = "/Condition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (bodybodySite != null)
                {
                    body["bodySite"] = ExpressionConverter.ConvertO(bodybodySite);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyonsetDateTime != null)
                {
                    body["onsetDateTime"] = ExpressionConverter.ConvertO(bodyonsetDateTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTConditionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETConditionID))]
        public IBodyWorkflowAction<GETConditionIDResponse> GETConditionID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETConditionIDResponse> __BuildGETConditionID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETConditionIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Condition/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETConditionIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEConditionID))]
        public IBodyWorkflowAction<DELETEConditionIDResponse> DELETEConditionID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, [WorkflowExpression] Func<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodyseveritycodingInputItem[]> bodyseveritycoding = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<bodybodySiteInputItem[]> bodybodySite = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyonsetDateTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETEConditionIDResponse> __BuildDELETEConditionID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, WorkflowExpression<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodyseveritycodingInputItem[]> bodyseveritycoding = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<bodybodySiteInputItem[]> bodybodySite = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyonsetDateTime = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            WorkflowExpression.Validate(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodybodySite, nameof(bodybodySite), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyonsetDateTime, nameof(bodyonsetDateTime), required: false);
            return new DeferredBodyAction<DELETEConditionIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Condition/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (bodybodySite != null)
                {
                    body["bodySite"] = ExpressionConverter.ConvertO(bodybodySite);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyonsetDateTime != null)
                {
                    body["onsetDateTime"] = ExpressionConverter.ConvertO(bodyonsetDateTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEConditionIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTConditionID))]
        public IBodyWorkflowAction<PUTConditionIDResponse> PUTConditionID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, [WorkflowExpression] Func<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodyseveritycodingInputItem[]> bodyseveritycoding = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<bodybodySiteInputItem[]> bodybodySite = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyonsetDateTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTConditionIDResponse> __BuildPUTConditionID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodyclinicalStatuscodingInputItem2[]> bodyclinicalStatuscoding = null, WorkflowExpression<bodyverificationStatuscodingInputItem2[]> bodyverificationStatuscoding = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodyseveritycodingInputItem[]> bodyseveritycoding = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<bodybodySiteInputItem[]> bodybodySite = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyonsetDateTime = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            WorkflowExpression.Validate(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodybodySite, nameof(bodybodySite), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyonsetDateTime, nameof(bodyonsetDateTime), required: false);
            return new DeferredBodyAction<PUTConditionIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Condition/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (bodybodySite != null)
                {
                    body["bodySite"] = ExpressionConverter.ConvertO(bodybodySite);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyonsetDateTime != null)
                {
                    body["onsetDateTime"] = ExpressionConverter.ConvertO(bodyonsetDateTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTConditionIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETDiagnosticReport))]
        public IBodyWorkflowAction<GETDiagnosticReportResponse> GETDiagnosticReport([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETDiagnosticReportResponse> __BuildGETDiagnosticReport(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETDiagnosticReportResponse>(() =>
            {
                var apiCallPath = "/DiagnosticReport";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETDiagnosticReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTDiagnosticReport))]
        public IBodyWorkflowAction<POSTDiagnosticReportResponse> POSTDiagnosticReport([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<bodybasedOnInputItem[]> bodybasedOn = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyissued = null, [WorkflowExpression] Func<bodyperformerInputItem[]> bodyperformer = null, [WorkflowExpression] Func<bodyresultInputItem[]> bodyresult = null, [WorkflowExpression] Func<string> bodyconclusion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTDiagnosticReportResponse> __BuildPOSTDiagnosticReport(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodyidentifierInputItem[]> bodyidentifier = null, WorkflowExpression<bodybasedOnInputItem[]> bodybasedOn = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyissued = null, WorkflowExpression<bodyperformerInputItem[]> bodyperformer = null, WorkflowExpression<bodyresultInputItem[]> bodyresult = null, WorkflowExpression<string> bodyconclusion = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            WorkflowExpression.Validate(bodybasedOn, nameof(bodybasedOn), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyissued, nameof(bodyissued), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyresult, nameof(bodyresult), required: false);
            WorkflowExpression.Validate(bodyconclusion, nameof(bodyconclusion), required: false);
            return new DeferredBodyAction<POSTDiagnosticReportResponse>(() =>
            {
                var apiCallPath = "/DiagnosticReport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                    bodypropCount++;
                }

                if (bodybasedOn != null)
                {
                    body["basedOn"] = ExpressionConverter.ConvertO(bodybasedOn);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(bodyissued);
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                if (bodyresult != null)
                {
                    body["result"] = ExpressionConverter.ConvertO(bodyresult);
                    bodypropCount++;
                }

                if (bodyconclusion != null)
                {
                    body["conclusion"] = ExpressionConverter.ConvertO(bodyconclusion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTDiagnosticReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETDiagnosticReportID))]
        public IBodyWorkflowAction<GETDiagnosticReportIDResponse> GETDiagnosticReportID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETDiagnosticReportIDResponse> __BuildGETDiagnosticReportID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETDiagnosticReportIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/DiagnosticReport/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETDiagnosticReportIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEDiagnosticReportID))]
        public IBodyWorkflowAction<DELETEDiagnosticReportIDResponse> DELETEDiagnosticReportID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<bodybasedOnInputItem[]> bodybasedOn = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyissued = null, [WorkflowExpression] Func<bodyperformerInputItem[]> bodyperformer = null, [WorkflowExpression] Func<bodyresultInputItem[]> bodyresult = null, [WorkflowExpression] Func<string> bodyconclusion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETEDiagnosticReportIDResponse> __BuildDELETEDiagnosticReportID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodyidentifierInputItem[]> bodyidentifier = null, WorkflowExpression<bodybasedOnInputItem[]> bodybasedOn = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyissued = null, WorkflowExpression<bodyperformerInputItem[]> bodyperformer = null, WorkflowExpression<bodyresultInputItem[]> bodyresult = null, WorkflowExpression<string> bodyconclusion = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            WorkflowExpression.Validate(bodybasedOn, nameof(bodybasedOn), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyissued, nameof(bodyissued), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyresult, nameof(bodyresult), required: false);
            WorkflowExpression.Validate(bodyconclusion, nameof(bodyconclusion), required: false);
            return new DeferredBodyAction<DELETEDiagnosticReportIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/DiagnosticReport/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                    bodypropCount++;
                }

                if (bodybasedOn != null)
                {
                    body["basedOn"] = ExpressionConverter.ConvertO(bodybasedOn);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(bodyissued);
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                if (bodyresult != null)
                {
                    body["result"] = ExpressionConverter.ConvertO(bodyresult);
                    bodypropCount++;
                }

                if (bodyconclusion != null)
                {
                    body["conclusion"] = ExpressionConverter.ConvertO(bodyconclusion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEDiagnosticReportIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTDiagnosticReportID))]
        public IBodyWorkflowAction<PUTDiagnosticReportIDResponse> PUTDiagnosticReportID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<bodybasedOnInputItem[]> bodybasedOn = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyissued = null, [WorkflowExpression] Func<bodyperformerInputItem[]> bodyperformer = null, [WorkflowExpression] Func<bodyresultInputItem[]> bodyresult = null, [WorkflowExpression] Func<string> bodyconclusion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTDiagnosticReportIDResponse> __BuildPUTDiagnosticReportID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodyidentifierInputItem[]> bodyidentifier = null, WorkflowExpression<bodybasedOnInputItem[]> bodybasedOn = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyissued = null, WorkflowExpression<bodyperformerInputItem[]> bodyperformer = null, WorkflowExpression<bodyresultInputItem[]> bodyresult = null, WorkflowExpression<string> bodyconclusion = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            WorkflowExpression.Validate(bodybasedOn, nameof(bodybasedOn), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyissued, nameof(bodyissued), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyresult, nameof(bodyresult), required: false);
            WorkflowExpression.Validate(bodyconclusion, nameof(bodyconclusion), required: false);
            return new DeferredBodyAction<PUTDiagnosticReportIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/DiagnosticReport/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                    bodypropCount++;
                }

                if (bodybasedOn != null)
                {
                    body["basedOn"] = ExpressionConverter.ConvertO(bodybasedOn);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(bodyissued);
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                if (bodyresult != null)
                {
                    body["result"] = ExpressionConverter.ConvertO(bodyresult);
                    bodypropCount++;
                }

                if (bodyconclusion != null)
                {
                    body["conclusion"] = ExpressionConverter.ConvertO(bodyconclusion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTDiagnosticReportIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETMedication))]
        public IBodyWorkflowAction<GETMedicationResponse> GETMedication([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETMedicationResponse> __BuildGETMedication(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETMedicationResponse>(() =>
            {
                var apiCallPath = "/Medication";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETMedicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTMedication))]
        public IBodyWorkflowAction<POSTMedicationResponse> POSTMedication([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodycontainedInputItem2[]> bodycontained = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymanufacturerreference = null, [WorkflowExpression] Func<bodyformcodingInputItem[]> bodyformcoding = null, [WorkflowExpression] Func<bodyingredientInputItem[]> bodyingredient = null, [WorkflowExpression] Func<string> bodybatchlotNumber = null, [WorkflowExpression] Func<string> bodybatchexpirationDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTMedicationResponse> __BuildPOSTMedication(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodycontainedInputItem2[]> bodycontained = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodymanufacturerreference = null, WorkflowExpression<bodyformcodingInputItem[]> bodyformcoding = null, WorkflowExpression<bodyingredientInputItem[]> bodyingredient = null, WorkflowExpression<string> bodybatchlotNumber = null, WorkflowExpression<string> bodybatchexpirationDate = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodycontained, nameof(bodycontained), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymanufacturerreference, nameof(bodymanufacturerreference), required: false);
            WorkflowExpression.Validate(bodyformcoding, nameof(bodyformcoding), required: false);
            WorkflowExpression.Validate(bodyingredient, nameof(bodyingredient), required: false);
            WorkflowExpression.Validate(bodybatchlotNumber, nameof(bodybatchlotNumber), required: false);
            WorkflowExpression.Validate(bodybatchexpirationDate, nameof(bodybatchexpirationDate), required: false);
            return new DeferredBodyAction<POSTMedicationResponse>(() =>
            {
                var apiCallPath = "/Medication";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(bodycontained);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (bodymanufacturerreference != null)
                {
                    manufacturerObject["reference"] = ExpressionConverter.ConvertO(bodymanufacturerreference);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    body["manufacturer"] = manufacturerObject;
                    bodypropCount++;
                }

                var formObject = new JObject();
                var formObjectpropCount = 0;
                if (bodyformcoding != null)
                {
                    formObject["coding"] = ExpressionConverter.ConvertO(bodyformcoding);
                    formObjectpropCount++;
                }

                if (formObjectpropCount > 0)
                {
                    body["form"] = formObject;
                    bodypropCount++;
                }

                if (bodyingredient != null)
                {
                    body["ingredient"] = ExpressionConverter.ConvertO(bodyingredient);
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (bodybatchlotNumber != null)
                {
                    batchObject["lotNumber"] = ExpressionConverter.ConvertO(bodybatchlotNumber);
                    batchObjectpropCount++;
                }

                if (bodybatchexpirationDate != null)
                {
                    batchObject["expirationDate"] = ExpressionConverter.ConvertO(bodybatchexpirationDate);
                    batchObjectpropCount++;
                }

                if (batchObjectpropCount > 0)
                {
                    body["batch"] = batchObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTMedicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETMedicationID))]
        public IBodyWorkflowAction<GETMedicationIDResponse> GETMedicationID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETMedicationIDResponse> __BuildGETMedicationID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETMedicationIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Medication/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETMedicationIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEMedicationID))]
        public IBodyWorkflowAction<DELETEMedicationIDResponse> DELETEMedicationID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodycontainedInputItem2[]> bodycontained = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymanufacturerreference = null, [WorkflowExpression] Func<bodyformcodingInputItem[]> bodyformcoding = null, [WorkflowExpression] Func<bodyingredientInputItem[]> bodyingredient = null, [WorkflowExpression] Func<string> bodybatchlotNumber = null, [WorkflowExpression] Func<string> bodybatchexpirationDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETEMedicationIDResponse> __BuildDELETEMedicationID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodycontainedInputItem2[]> bodycontained = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodymanufacturerreference = null, WorkflowExpression<bodyformcodingInputItem[]> bodyformcoding = null, WorkflowExpression<bodyingredientInputItem[]> bodyingredient = null, WorkflowExpression<string> bodybatchlotNumber = null, WorkflowExpression<string> bodybatchexpirationDate = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodycontained, nameof(bodycontained), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymanufacturerreference, nameof(bodymanufacturerreference), required: false);
            WorkflowExpression.Validate(bodyformcoding, nameof(bodyformcoding), required: false);
            WorkflowExpression.Validate(bodyingredient, nameof(bodyingredient), required: false);
            WorkflowExpression.Validate(bodybatchlotNumber, nameof(bodybatchlotNumber), required: false);
            WorkflowExpression.Validate(bodybatchexpirationDate, nameof(bodybatchexpirationDate), required: false);
            return new DeferredBodyAction<DELETEMedicationIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Medication/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(bodycontained);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (bodymanufacturerreference != null)
                {
                    manufacturerObject["reference"] = ExpressionConverter.ConvertO(bodymanufacturerreference);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    body["manufacturer"] = manufacturerObject;
                    bodypropCount++;
                }

                var formObject = new JObject();
                var formObjectpropCount = 0;
                if (bodyformcoding != null)
                {
                    formObject["coding"] = ExpressionConverter.ConvertO(bodyformcoding);
                    formObjectpropCount++;
                }

                if (formObjectpropCount > 0)
                {
                    body["form"] = formObject;
                    bodypropCount++;
                }

                if (bodyingredient != null)
                {
                    body["ingredient"] = ExpressionConverter.ConvertO(bodyingredient);
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (bodybatchlotNumber != null)
                {
                    batchObject["lotNumber"] = ExpressionConverter.ConvertO(bodybatchlotNumber);
                    batchObjectpropCount++;
                }

                if (bodybatchexpirationDate != null)
                {
                    batchObject["expirationDate"] = ExpressionConverter.ConvertO(bodybatchexpirationDate);
                    batchObjectpropCount++;
                }

                if (batchObjectpropCount > 0)
                {
                    body["batch"] = batchObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEMedicationIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTMedicationID))]
        public IBodyWorkflowAction<PUTMedicationIDResponse> PUTMedicationID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodytextdiv = null, [WorkflowExpression] Func<bodycontainedInputItem2[]> bodycontained = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymanufacturerreference = null, [WorkflowExpression] Func<bodyformcodingInputItem[]> bodyformcoding = null, [WorkflowExpression] Func<bodyingredientInputItem[]> bodyingredient = null, [WorkflowExpression] Func<string> bodybatchlotNumber = null, [WorkflowExpression] Func<string> bodybatchexpirationDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTMedicationIDResponse> __BuildPUTMedicationID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodytextdiv = null, WorkflowExpression<bodycontainedInputItem2[]> bodycontained = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodymanufacturerreference = null, WorkflowExpression<bodyformcodingInputItem[]> bodyformcoding = null, WorkflowExpression<bodyingredientInputItem[]> bodyingredient = null, WorkflowExpression<string> bodybatchlotNumber = null, WorkflowExpression<string> bodybatchexpirationDate = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodytextdiv, nameof(bodytextdiv), required: false);
            WorkflowExpression.Validate(bodycontained, nameof(bodycontained), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymanufacturerreference, nameof(bodymanufacturerreference), required: false);
            WorkflowExpression.Validate(bodyformcoding, nameof(bodyformcoding), required: false);
            WorkflowExpression.Validate(bodyingredient, nameof(bodyingredient), required: false);
            WorkflowExpression.Validate(bodybatchlotNumber, nameof(bodybatchlotNumber), required: false);
            WorkflowExpression.Validate(bodybatchexpirationDate, nameof(bodybatchexpirationDate), required: false);
            return new DeferredBodyAction<PUTMedicationIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Medication/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (bodytextdiv != null)
                {
                    textObject["div"] = ExpressionConverter.ConvertO(bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(bodycontained);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (bodymanufacturerreference != null)
                {
                    manufacturerObject["reference"] = ExpressionConverter.ConvertO(bodymanufacturerreference);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    body["manufacturer"] = manufacturerObject;
                    bodypropCount++;
                }

                var formObject = new JObject();
                var formObjectpropCount = 0;
                if (bodyformcoding != null)
                {
                    formObject["coding"] = ExpressionConverter.ConvertO(bodyformcoding);
                    formObjectpropCount++;
                }

                if (formObjectpropCount > 0)
                {
                    body["form"] = formObject;
                    bodypropCount++;
                }

                if (bodyingredient != null)
                {
                    body["ingredient"] = ExpressionConverter.ConvertO(bodyingredient);
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (bodybatchlotNumber != null)
                {
                    batchObject["lotNumber"] = ExpressionConverter.ConvertO(bodybatchlotNumber);
                    batchObjectpropCount++;
                }

                if (bodybatchexpirationDate != null)
                {
                    batchObject["expirationDate"] = ExpressionConverter.ConvertO(bodybatchexpirationDate);
                    batchObjectpropCount++;
                }

                if (batchObjectpropCount > 0)
                {
                    body["batch"] = batchObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTMedicationIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETMedicationRequest))]
        public IBodyWorkflowAction<GETMedicationRequestResponse> GETMedicationRequest([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETMedicationRequestResponse> __BuildGETMedicationRequest(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETMedicationRequestResponse>(() =>
            {
                var apiCallPath = "/MedicationRequest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETMedicationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTMedicationRequest))]
        public IBodyWorkflowAction<POSTMedicationRequestResponse> POSTMedicationRequest([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodycontainedInputItem22[]> bodycontained = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyintent = null, [WorkflowExpression] Func<bodymedicationCodeableConceptcodingInputItem[]> bodymedicationCodeableConceptcoding = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyencounterreference = null, [WorkflowExpression] Func<string> bodyencounterdisplay = null, [WorkflowExpression] Func<bodysupportingInformationInputItem[]> bodysupportingInformation = null, [WorkflowExpression] Func<string> bodyauthoredOn = null, [WorkflowExpression] Func<string> bodyrequesterreference = null, [WorkflowExpression] Func<string> bodyrequesterdisplay = null, [WorkflowExpression] Func<bodyreasonCodeInputItem[]> bodyreasonCode = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null, [WorkflowExpression] Func<bodydosageInstructionInputItem[]> bodydosageInstruction = null, [WorkflowExpression] Func<string> bodydispenseRequestvalidityPeriodstart = null, [WorkflowExpression] Func<string> bodydispenseRequestvalidityPeriodend = null, [WorkflowExpression] Func<int> bodydispenseRequestnumberOfRepeatsAllowed = null, [WorkflowExpression] Func<int> bodydispenseRequestquantityvalue = null, [WorkflowExpression] Func<string> bodydispenseRequestquantityunit = null, [WorkflowExpression] Func<string> bodydispenseRequestquantitysystem = null, [WorkflowExpression] Func<string> bodydispenseRequestquantitycode = null, [WorkflowExpression] Func<int> bodydispenseRequestexpectedSupplyDurationvalue = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationunit = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationsystem = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationcode = null, [WorkflowExpression] Func<bool> bodysubstitutionallowedBoolean = null, [WorkflowExpression] Func<bodysubstitutionreasoncodingInputItem[]> bodysubstitutionreasoncoding = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTMedicationRequestResponse> __BuildPOSTMedicationRequest(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodycontainedInputItem22[]> bodycontained = null, WorkflowExpression<bodyidentifierInputItem[]> bodyidentifier = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyintent = null, WorkflowExpression<bodymedicationCodeableConceptcodingInputItem[]> bodymedicationCodeableConceptcoding = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyencounterreference = null, WorkflowExpression<string> bodyencounterdisplay = null, WorkflowExpression<bodysupportingInformationInputItem[]> bodysupportingInformation = null, WorkflowExpression<string> bodyauthoredOn = null, WorkflowExpression<string> bodyrequesterreference = null, WorkflowExpression<string> bodyrequesterdisplay = null, WorkflowExpression<bodyreasonCodeInputItem[]> bodyreasonCode = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null, WorkflowExpression<bodydosageInstructionInputItem[]> bodydosageInstruction = null, WorkflowExpression<string> bodydispenseRequestvalidityPeriodstart = null, WorkflowExpression<string> bodydispenseRequestvalidityPeriodend = null, WorkflowExpression<int> bodydispenseRequestnumberOfRepeatsAllowed = null, WorkflowExpression<int> bodydispenseRequestquantityvalue = null, WorkflowExpression<string> bodydispenseRequestquantityunit = null, WorkflowExpression<string> bodydispenseRequestquantitysystem = null, WorkflowExpression<string> bodydispenseRequestquantitycode = null, WorkflowExpression<int> bodydispenseRequestexpectedSupplyDurationvalue = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationunit = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationsystem = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationcode = null, WorkflowExpression<bool> bodysubstitutionallowedBoolean = null, WorkflowExpression<bodysubstitutionreasoncodingInputItem[]> bodysubstitutionreasoncoding = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodycontained, nameof(bodycontained), required: false);
            WorkflowExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyintent, nameof(bodyintent), required: false);
            WorkflowExpression.Validate(bodymedicationCodeableConceptcoding, nameof(bodymedicationCodeableConceptcoding), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyencounterreference, nameof(bodyencounterreference), required: false);
            WorkflowExpression.Validate(bodyencounterdisplay, nameof(bodyencounterdisplay), required: false);
            WorkflowExpression.Validate(bodysupportingInformation, nameof(bodysupportingInformation), required: false);
            WorkflowExpression.Validate(bodyauthoredOn, nameof(bodyauthoredOn), required: false);
            WorkflowExpression.Validate(bodyrequesterreference, nameof(bodyrequesterreference), required: false);
            WorkflowExpression.Validate(bodyrequesterdisplay, nameof(bodyrequesterdisplay), required: false);
            WorkflowExpression.Validate(bodyreasonCode, nameof(bodyreasonCode), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodydosageInstruction, nameof(bodydosageInstruction), required: false);
            WorkflowExpression.Validate(bodydispenseRequestvalidityPeriodstart, nameof(bodydispenseRequestvalidityPeriodstart), required: false);
            WorkflowExpression.Validate(bodydispenseRequestvalidityPeriodend, nameof(bodydispenseRequestvalidityPeriodend), required: false);
            WorkflowExpression.Validate(bodydispenseRequestnumberOfRepeatsAllowed, nameof(bodydispenseRequestnumberOfRepeatsAllowed), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantityvalue, nameof(bodydispenseRequestquantityvalue), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantityunit, nameof(bodydispenseRequestquantityunit), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantitysystem, nameof(bodydispenseRequestquantitysystem), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantitycode, nameof(bodydispenseRequestquantitycode), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationvalue, nameof(bodydispenseRequestexpectedSupplyDurationvalue), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationunit, nameof(bodydispenseRequestexpectedSupplyDurationunit), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationsystem, nameof(bodydispenseRequestexpectedSupplyDurationsystem), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationcode, nameof(bodydispenseRequestexpectedSupplyDurationcode), required: false);
            WorkflowExpression.Validate(bodysubstitutionallowedBoolean, nameof(bodysubstitutionallowedBoolean), required: false);
            WorkflowExpression.Validate(bodysubstitutionreasoncoding, nameof(bodysubstitutionreasoncoding), required: false);
            return new DeferredBodyAction<POSTMedicationRequestResponse>(() =>
            {
                var apiCallPath = "/MedicationRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(bodycontained);
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(bodyintent);
                    bodypropCount++;
                }

                var medicationCodeableConceptObject = new JObject();
                var medicationCodeableConceptObjectpropCount = 0;
                if (bodymedicationCodeableConceptcoding != null)
                {
                    medicationCodeableConceptObject["coding"] = ExpressionConverter.ConvertO(bodymedicationCodeableConceptcoding);
                    medicationCodeableConceptObjectpropCount++;
                }

                if (medicationCodeableConceptObjectpropCount > 0)
                {
                    body["medicationCodeableConcept"] = medicationCodeableConceptObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (bodyencounterdisplay != null)
                {
                    encounterObject["display"] = ExpressionConverter.ConvertO(bodyencounterdisplay);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                if (bodysupportingInformation != null)
                {
                    body["supportingInformation"] = ExpressionConverter.ConvertO(bodysupportingInformation);
                    bodypropCount++;
                }

                if (bodyauthoredOn != null)
                {
                    body["authoredOn"] = ExpressionConverter.ConvertO(bodyauthoredOn);
                    bodypropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (bodyrequesterreference != null)
                {
                    requesterObject["reference"] = ExpressionConverter.ConvertO(bodyrequesterreference);
                    requesterObjectpropCount++;
                }

                if (bodyrequesterdisplay != null)
                {
                    requesterObject["display"] = ExpressionConverter.ConvertO(bodyrequesterdisplay);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    body["requester"] = requesterObject;
                    bodypropCount++;
                }

                if (bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(bodyreasonCode);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodydosageInstruction != null)
                {
                    body["dosageInstruction"] = ExpressionConverter.ConvertO(bodydosageInstruction);
                    bodypropCount++;
                }

                var dispenseRequestObject = new JObject();
                var dispenseRequestObjectpropCount = 0;
                var validityPeriodObject = new JObject();
                var validityPeriodObjectpropCount = 0;
                if (bodydispenseRequestvalidityPeriodstart != null)
                {
                    validityPeriodObject["start"] = ExpressionConverter.ConvertO(bodydispenseRequestvalidityPeriodstart);
                    validityPeriodObjectpropCount++;
                }

                if (bodydispenseRequestvalidityPeriodend != null)
                {
                    validityPeriodObject["end"] = ExpressionConverter.ConvertO(bodydispenseRequestvalidityPeriodend);
                    validityPeriodObjectpropCount++;
                }

                if (validityPeriodObjectpropCount > 0)
                {
                    dispenseRequestObject["validityPeriod"] = validityPeriodObject;
                    dispenseRequestObjectpropCount++;
                }

                if (bodydispenseRequestnumberOfRepeatsAllowed != null)
                {
                    dispenseRequestObject["numberOfRepeatsAllowed"] = ExpressionConverter.ConvertO(bodydispenseRequestnumberOfRepeatsAllowed);
                    dispenseRequestObjectpropCount++;
                }

                var quantityObject = new JObject();
                var quantityObjectpropCount = 0;
                if (bodydispenseRequestquantityvalue != null)
                {
                    quantityObject["value"] = ExpressionConverter.ConvertO(bodydispenseRequestquantityvalue);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantityunit != null)
                {
                    quantityObject["unit"] = ExpressionConverter.ConvertO(bodydispenseRequestquantityunit);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantitysystem != null)
                {
                    quantityObject["system"] = ExpressionConverter.ConvertO(bodydispenseRequestquantitysystem);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantitycode != null)
                {
                    quantityObject["code"] = ExpressionConverter.ConvertO(bodydispenseRequestquantitycode);
                    quantityObjectpropCount++;
                }

                if (quantityObjectpropCount > 0)
                {
                    dispenseRequestObject["quantity"] = quantityObject;
                    dispenseRequestObjectpropCount++;
                }

                var expectedSupplyDurationObject = new JObject();
                var expectedSupplyDurationObjectpropCount = 0;
                if (bodydispenseRequestexpectedSupplyDurationvalue != null)
                {
                    expectedSupplyDurationObject["value"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationvalue);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationunit != null)
                {
                    expectedSupplyDurationObject["unit"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationunit);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationsystem != null)
                {
                    expectedSupplyDurationObject["system"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationsystem);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationcode != null)
                {
                    expectedSupplyDurationObject["code"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationcode);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (expectedSupplyDurationObjectpropCount > 0)
                {
                    dispenseRequestObject["expectedSupplyDuration"] = expectedSupplyDurationObject;
                    dispenseRequestObjectpropCount++;
                }

                if (dispenseRequestObjectpropCount > 0)
                {
                    body["dispenseRequest"] = dispenseRequestObject;
                    bodypropCount++;
                }

                var substitutionObject = new JObject();
                var substitutionObjectpropCount = 0;
                if (bodysubstitutionallowedBoolean != null)
                {
                    substitutionObject["allowedBoolean"] = ExpressionConverter.ConvertO(bodysubstitutionallowedBoolean);
                    substitutionObjectpropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (bodysubstitutionreasoncoding != null)
                {
                    reasonObject["coding"] = ExpressionConverter.ConvertO(bodysubstitutionreasoncoding);
                    reasonObjectpropCount++;
                }

                if (reasonObjectpropCount > 0)
                {
                    substitutionObject["reason"] = reasonObject;
                    substitutionObjectpropCount++;
                }

                if (substitutionObjectpropCount > 0)
                {
                    body["substitution"] = substitutionObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTMedicationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETMedicationRequestID))]
        public IBodyWorkflowAction<GETMedicationRequestIDResponse> GETMedicationRequestID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETMedicationRequestIDResponse> __BuildGETMedicationRequestID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETMedicationRequestIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/MedicationRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETMedicationRequestIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEMedicationRequestID))]
        public IBodyWorkflowAction<DELETEMedicationRequestIDResponse> DELETEMedicationRequestID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodycontainedInputItem22[]> bodycontained = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyintent = null, [WorkflowExpression] Func<string> bodymedicationReferencereference = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyencounterreference = null, [WorkflowExpression] Func<string> bodyencounterdisplay = null, [WorkflowExpression] Func<bodysupportingInformationInputItem[]> bodysupportingInformation = null, [WorkflowExpression] Func<string> bodyauthoredOn = null, [WorkflowExpression] Func<string> bodyrequesterreference = null, [WorkflowExpression] Func<string> bodyrequesterdisplay = null, [WorkflowExpression] Func<bodyreasonCodeInputItem[]> bodyreasonCode = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null, [WorkflowExpression] Func<bodydosageInstructionInputItem[]> bodydosageInstruction = null, [WorkflowExpression] Func<string> bodydispenseRequestvalidityPeriodstart = null, [WorkflowExpression] Func<string> bodydispenseRequestvalidityPeriodend = null, [WorkflowExpression] Func<int> bodydispenseRequestnumberOfRepeatsAllowed = null, [WorkflowExpression] Func<int> bodydispenseRequestquantityvalue = null, [WorkflowExpression] Func<string> bodydispenseRequestquantityunit = null, [WorkflowExpression] Func<string> bodydispenseRequestquantitysystem = null, [WorkflowExpression] Func<string> bodydispenseRequestquantitycode = null, [WorkflowExpression] Func<int> bodydispenseRequestexpectedSupplyDurationvalue = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationunit = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationsystem = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationcode = null, [WorkflowExpression] Func<bool> bodysubstitutionallowedBoolean = null, [WorkflowExpression] Func<bodysubstitutionreasoncodingInputItem[]> bodysubstitutionreasoncoding = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETEMedicationRequestIDResponse> __BuildDELETEMedicationRequestID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodycontainedInputItem22[]> bodycontained = null, WorkflowExpression<bodyidentifierInputItem[]> bodyidentifier = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyintent = null, WorkflowExpression<string> bodymedicationReferencereference = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyencounterreference = null, WorkflowExpression<string> bodyencounterdisplay = null, WorkflowExpression<bodysupportingInformationInputItem[]> bodysupportingInformation = null, WorkflowExpression<string> bodyauthoredOn = null, WorkflowExpression<string> bodyrequesterreference = null, WorkflowExpression<string> bodyrequesterdisplay = null, WorkflowExpression<bodyreasonCodeInputItem[]> bodyreasonCode = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null, WorkflowExpression<bodydosageInstructionInputItem[]> bodydosageInstruction = null, WorkflowExpression<string> bodydispenseRequestvalidityPeriodstart = null, WorkflowExpression<string> bodydispenseRequestvalidityPeriodend = null, WorkflowExpression<int> bodydispenseRequestnumberOfRepeatsAllowed = null, WorkflowExpression<int> bodydispenseRequestquantityvalue = null, WorkflowExpression<string> bodydispenseRequestquantityunit = null, WorkflowExpression<string> bodydispenseRequestquantitysystem = null, WorkflowExpression<string> bodydispenseRequestquantitycode = null, WorkflowExpression<int> bodydispenseRequestexpectedSupplyDurationvalue = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationunit = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationsystem = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationcode = null, WorkflowExpression<bool> bodysubstitutionallowedBoolean = null, WorkflowExpression<bodysubstitutionreasoncodingInputItem[]> bodysubstitutionreasoncoding = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodycontained, nameof(bodycontained), required: false);
            WorkflowExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyintent, nameof(bodyintent), required: false);
            WorkflowExpression.Validate(bodymedicationReferencereference, nameof(bodymedicationReferencereference), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyencounterreference, nameof(bodyencounterreference), required: false);
            WorkflowExpression.Validate(bodyencounterdisplay, nameof(bodyencounterdisplay), required: false);
            WorkflowExpression.Validate(bodysupportingInformation, nameof(bodysupportingInformation), required: false);
            WorkflowExpression.Validate(bodyauthoredOn, nameof(bodyauthoredOn), required: false);
            WorkflowExpression.Validate(bodyrequesterreference, nameof(bodyrequesterreference), required: false);
            WorkflowExpression.Validate(bodyrequesterdisplay, nameof(bodyrequesterdisplay), required: false);
            WorkflowExpression.Validate(bodyreasonCode, nameof(bodyreasonCode), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodydosageInstruction, nameof(bodydosageInstruction), required: false);
            WorkflowExpression.Validate(bodydispenseRequestvalidityPeriodstart, nameof(bodydispenseRequestvalidityPeriodstart), required: false);
            WorkflowExpression.Validate(bodydispenseRequestvalidityPeriodend, nameof(bodydispenseRequestvalidityPeriodend), required: false);
            WorkflowExpression.Validate(bodydispenseRequestnumberOfRepeatsAllowed, nameof(bodydispenseRequestnumberOfRepeatsAllowed), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantityvalue, nameof(bodydispenseRequestquantityvalue), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantityunit, nameof(bodydispenseRequestquantityunit), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantitysystem, nameof(bodydispenseRequestquantitysystem), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantitycode, nameof(bodydispenseRequestquantitycode), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationvalue, nameof(bodydispenseRequestexpectedSupplyDurationvalue), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationunit, nameof(bodydispenseRequestexpectedSupplyDurationunit), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationsystem, nameof(bodydispenseRequestexpectedSupplyDurationsystem), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationcode, nameof(bodydispenseRequestexpectedSupplyDurationcode), required: false);
            WorkflowExpression.Validate(bodysubstitutionallowedBoolean, nameof(bodysubstitutionallowedBoolean), required: false);
            WorkflowExpression.Validate(bodysubstitutionreasoncoding, nameof(bodysubstitutionreasoncoding), required: false);
            return new DeferredBodyAction<DELETEMedicationRequestIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/MedicationRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(bodycontained);
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(bodyintent);
                    bodypropCount++;
                }

                var medicationReferenceObject = new JObject();
                var medicationReferenceObjectpropCount = 0;
                if (bodymedicationReferencereference != null)
                {
                    medicationReferenceObject["reference"] = ExpressionConverter.ConvertO(bodymedicationReferencereference);
                    medicationReferenceObjectpropCount++;
                }

                if (medicationReferenceObjectpropCount > 0)
                {
                    body["medicationReference"] = medicationReferenceObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (bodyencounterdisplay != null)
                {
                    encounterObject["display"] = ExpressionConverter.ConvertO(bodyencounterdisplay);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                if (bodysupportingInformation != null)
                {
                    body["supportingInformation"] = ExpressionConverter.ConvertO(bodysupportingInformation);
                    bodypropCount++;
                }

                if (bodyauthoredOn != null)
                {
                    body["authoredOn"] = ExpressionConverter.ConvertO(bodyauthoredOn);
                    bodypropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (bodyrequesterreference != null)
                {
                    requesterObject["reference"] = ExpressionConverter.ConvertO(bodyrequesterreference);
                    requesterObjectpropCount++;
                }

                if (bodyrequesterdisplay != null)
                {
                    requesterObject["display"] = ExpressionConverter.ConvertO(bodyrequesterdisplay);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    body["requester"] = requesterObject;
                    bodypropCount++;
                }

                if (bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(bodyreasonCode);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodydosageInstruction != null)
                {
                    body["dosageInstruction"] = ExpressionConverter.ConvertO(bodydosageInstruction);
                    bodypropCount++;
                }

                var dispenseRequestObject = new JObject();
                var dispenseRequestObjectpropCount = 0;
                var validityPeriodObject = new JObject();
                var validityPeriodObjectpropCount = 0;
                if (bodydispenseRequestvalidityPeriodstart != null)
                {
                    validityPeriodObject["start"] = ExpressionConverter.ConvertO(bodydispenseRequestvalidityPeriodstart);
                    validityPeriodObjectpropCount++;
                }

                if (bodydispenseRequestvalidityPeriodend != null)
                {
                    validityPeriodObject["end"] = ExpressionConverter.ConvertO(bodydispenseRequestvalidityPeriodend);
                    validityPeriodObjectpropCount++;
                }

                if (validityPeriodObjectpropCount > 0)
                {
                    dispenseRequestObject["validityPeriod"] = validityPeriodObject;
                    dispenseRequestObjectpropCount++;
                }

                if (bodydispenseRequestnumberOfRepeatsAllowed != null)
                {
                    dispenseRequestObject["numberOfRepeatsAllowed"] = ExpressionConverter.ConvertO(bodydispenseRequestnumberOfRepeatsAllowed);
                    dispenseRequestObjectpropCount++;
                }

                var quantityObject = new JObject();
                var quantityObjectpropCount = 0;
                if (bodydispenseRequestquantityvalue != null)
                {
                    quantityObject["value"] = ExpressionConverter.ConvertO(bodydispenseRequestquantityvalue);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantityunit != null)
                {
                    quantityObject["unit"] = ExpressionConverter.ConvertO(bodydispenseRequestquantityunit);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantitysystem != null)
                {
                    quantityObject["system"] = ExpressionConverter.ConvertO(bodydispenseRequestquantitysystem);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantitycode != null)
                {
                    quantityObject["code"] = ExpressionConverter.ConvertO(bodydispenseRequestquantitycode);
                    quantityObjectpropCount++;
                }

                if (quantityObjectpropCount > 0)
                {
                    dispenseRequestObject["quantity"] = quantityObject;
                    dispenseRequestObjectpropCount++;
                }

                var expectedSupplyDurationObject = new JObject();
                var expectedSupplyDurationObjectpropCount = 0;
                if (bodydispenseRequestexpectedSupplyDurationvalue != null)
                {
                    expectedSupplyDurationObject["value"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationvalue);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationunit != null)
                {
                    expectedSupplyDurationObject["unit"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationunit);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationsystem != null)
                {
                    expectedSupplyDurationObject["system"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationsystem);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationcode != null)
                {
                    expectedSupplyDurationObject["code"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationcode);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (expectedSupplyDurationObjectpropCount > 0)
                {
                    dispenseRequestObject["expectedSupplyDuration"] = expectedSupplyDurationObject;
                    dispenseRequestObjectpropCount++;
                }

                if (dispenseRequestObjectpropCount > 0)
                {
                    body["dispenseRequest"] = dispenseRequestObject;
                    bodypropCount++;
                }

                var substitutionObject = new JObject();
                var substitutionObjectpropCount = 0;
                if (bodysubstitutionallowedBoolean != null)
                {
                    substitutionObject["allowedBoolean"] = ExpressionConverter.ConvertO(bodysubstitutionallowedBoolean);
                    substitutionObjectpropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (bodysubstitutionreasoncoding != null)
                {
                    reasonObject["coding"] = ExpressionConverter.ConvertO(bodysubstitutionreasoncoding);
                    reasonObjectpropCount++;
                }

                if (reasonObjectpropCount > 0)
                {
                    substitutionObject["reason"] = reasonObject;
                    substitutionObjectpropCount++;
                }

                if (substitutionObjectpropCount > 0)
                {
                    body["substitution"] = substitutionObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEMedicationRequestIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTMedicationRequestID))]
        public IBodyWorkflowAction<PUTMedicationRequestIDResponse> PUTMedicationRequestID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<bodycontainedInputItem22[]> bodycontained = null, [WorkflowExpression] Func<bodyidentifierInputItem[]> bodyidentifier = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyintent = null, [WorkflowExpression] Func<string> bodymedicationReferencereference = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyencounterreference = null, [WorkflowExpression] Func<string> bodyencounterdisplay = null, [WorkflowExpression] Func<bodysupportingInformationInputItem[]> bodysupportingInformation = null, [WorkflowExpression] Func<string> bodyauthoredOn = null, [WorkflowExpression] Func<string> bodyrequesterreference = null, [WorkflowExpression] Func<string> bodyrequesterdisplay = null, [WorkflowExpression] Func<bodyreasonCodeInputItem[]> bodyreasonCode = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null, [WorkflowExpression] Func<bodydosageInstructionInputItem[]> bodydosageInstruction = null, [WorkflowExpression] Func<string> bodydispenseRequestvalidityPeriodstart = null, [WorkflowExpression] Func<string> bodydispenseRequestvalidityPeriodend = null, [WorkflowExpression] Func<int> bodydispenseRequestnumberOfRepeatsAllowed = null, [WorkflowExpression] Func<int> bodydispenseRequestquantityvalue = null, [WorkflowExpression] Func<string> bodydispenseRequestquantityunit = null, [WorkflowExpression] Func<string> bodydispenseRequestquantitysystem = null, [WorkflowExpression] Func<string> bodydispenseRequestquantitycode = null, [WorkflowExpression] Func<int> bodydispenseRequestexpectedSupplyDurationvalue = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationunit = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationsystem = null, [WorkflowExpression] Func<string> bodydispenseRequestexpectedSupplyDurationcode = null, [WorkflowExpression] Func<bool> bodysubstitutionallowedBoolean = null, [WorkflowExpression] Func<bodysubstitutionreasoncodingInputItem[]> bodysubstitutionreasoncoding = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTMedicationRequestIDResponse> __BuildPUTMedicationRequestID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<bodycontainedInputItem22[]> bodycontained = null, WorkflowExpression<bodyidentifierInputItem[]> bodyidentifier = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyintent = null, WorkflowExpression<string> bodymedicationReferencereference = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyencounterreference = null, WorkflowExpression<string> bodyencounterdisplay = null, WorkflowExpression<bodysupportingInformationInputItem[]> bodysupportingInformation = null, WorkflowExpression<string> bodyauthoredOn = null, WorkflowExpression<string> bodyrequesterreference = null, WorkflowExpression<string> bodyrequesterdisplay = null, WorkflowExpression<bodyreasonCodeInputItem[]> bodyreasonCode = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null, WorkflowExpression<bodydosageInstructionInputItem[]> bodydosageInstruction = null, WorkflowExpression<string> bodydispenseRequestvalidityPeriodstart = null, WorkflowExpression<string> bodydispenseRequestvalidityPeriodend = null, WorkflowExpression<int> bodydispenseRequestnumberOfRepeatsAllowed = null, WorkflowExpression<int> bodydispenseRequestquantityvalue = null, WorkflowExpression<string> bodydispenseRequestquantityunit = null, WorkflowExpression<string> bodydispenseRequestquantitysystem = null, WorkflowExpression<string> bodydispenseRequestquantitycode = null, WorkflowExpression<int> bodydispenseRequestexpectedSupplyDurationvalue = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationunit = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationsystem = null, WorkflowExpression<string> bodydispenseRequestexpectedSupplyDurationcode = null, WorkflowExpression<bool> bodysubstitutionallowedBoolean = null, WorkflowExpression<bodysubstitutionreasoncodingInputItem[]> bodysubstitutionreasoncoding = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodycontained, nameof(bodycontained), required: false);
            WorkflowExpression.Validate(bodyidentifier, nameof(bodyidentifier), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyintent, nameof(bodyintent), required: false);
            WorkflowExpression.Validate(bodymedicationReferencereference, nameof(bodymedicationReferencereference), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyencounterreference, nameof(bodyencounterreference), required: false);
            WorkflowExpression.Validate(bodyencounterdisplay, nameof(bodyencounterdisplay), required: false);
            WorkflowExpression.Validate(bodysupportingInformation, nameof(bodysupportingInformation), required: false);
            WorkflowExpression.Validate(bodyauthoredOn, nameof(bodyauthoredOn), required: false);
            WorkflowExpression.Validate(bodyrequesterreference, nameof(bodyrequesterreference), required: false);
            WorkflowExpression.Validate(bodyrequesterdisplay, nameof(bodyrequesterdisplay), required: false);
            WorkflowExpression.Validate(bodyreasonCode, nameof(bodyreasonCode), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodydosageInstruction, nameof(bodydosageInstruction), required: false);
            WorkflowExpression.Validate(bodydispenseRequestvalidityPeriodstart, nameof(bodydispenseRequestvalidityPeriodstart), required: false);
            WorkflowExpression.Validate(bodydispenseRequestvalidityPeriodend, nameof(bodydispenseRequestvalidityPeriodend), required: false);
            WorkflowExpression.Validate(bodydispenseRequestnumberOfRepeatsAllowed, nameof(bodydispenseRequestnumberOfRepeatsAllowed), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantityvalue, nameof(bodydispenseRequestquantityvalue), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantityunit, nameof(bodydispenseRequestquantityunit), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantitysystem, nameof(bodydispenseRequestquantitysystem), required: false);
            WorkflowExpression.Validate(bodydispenseRequestquantitycode, nameof(bodydispenseRequestquantitycode), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationvalue, nameof(bodydispenseRequestexpectedSupplyDurationvalue), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationunit, nameof(bodydispenseRequestexpectedSupplyDurationunit), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationsystem, nameof(bodydispenseRequestexpectedSupplyDurationsystem), required: false);
            WorkflowExpression.Validate(bodydispenseRequestexpectedSupplyDurationcode, nameof(bodydispenseRequestexpectedSupplyDurationcode), required: false);
            WorkflowExpression.Validate(bodysubstitutionallowedBoolean, nameof(bodysubstitutionallowedBoolean), required: false);
            WorkflowExpression.Validate(bodysubstitutionreasoncoding, nameof(bodysubstitutionreasoncoding), required: false);
            return new DeferredBodyAction<PUTMedicationRequestIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/MedicationRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(bodycontained);
                    bodypropCount++;
                }

                if (bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(bodyidentifier);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(bodyintent);
                    bodypropCount++;
                }

                var medicationReferenceObject = new JObject();
                var medicationReferenceObjectpropCount = 0;
                if (bodymedicationReferencereference != null)
                {
                    medicationReferenceObject["reference"] = ExpressionConverter.ConvertO(bodymedicationReferencereference);
                    medicationReferenceObjectpropCount++;
                }

                if (medicationReferenceObjectpropCount > 0)
                {
                    body["medicationReference"] = medicationReferenceObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (bodyencounterdisplay != null)
                {
                    encounterObject["display"] = ExpressionConverter.ConvertO(bodyencounterdisplay);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                if (bodysupportingInformation != null)
                {
                    body["supportingInformation"] = ExpressionConverter.ConvertO(bodysupportingInformation);
                    bodypropCount++;
                }

                if (bodyauthoredOn != null)
                {
                    body["authoredOn"] = ExpressionConverter.ConvertO(bodyauthoredOn);
                    bodypropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (bodyrequesterreference != null)
                {
                    requesterObject["reference"] = ExpressionConverter.ConvertO(bodyrequesterreference);
                    requesterObjectpropCount++;
                }

                if (bodyrequesterdisplay != null)
                {
                    requesterObject["display"] = ExpressionConverter.ConvertO(bodyrequesterdisplay);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    body["requester"] = requesterObject;
                    bodypropCount++;
                }

                if (bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(bodyreasonCode);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodydosageInstruction != null)
                {
                    body["dosageInstruction"] = ExpressionConverter.ConvertO(bodydosageInstruction);
                    bodypropCount++;
                }

                var dispenseRequestObject = new JObject();
                var dispenseRequestObjectpropCount = 0;
                var validityPeriodObject = new JObject();
                var validityPeriodObjectpropCount = 0;
                if (bodydispenseRequestvalidityPeriodstart != null)
                {
                    validityPeriodObject["start"] = ExpressionConverter.ConvertO(bodydispenseRequestvalidityPeriodstart);
                    validityPeriodObjectpropCount++;
                }

                if (bodydispenseRequestvalidityPeriodend != null)
                {
                    validityPeriodObject["end"] = ExpressionConverter.ConvertO(bodydispenseRequestvalidityPeriodend);
                    validityPeriodObjectpropCount++;
                }

                if (validityPeriodObjectpropCount > 0)
                {
                    dispenseRequestObject["validityPeriod"] = validityPeriodObject;
                    dispenseRequestObjectpropCount++;
                }

                if (bodydispenseRequestnumberOfRepeatsAllowed != null)
                {
                    dispenseRequestObject["numberOfRepeatsAllowed"] = ExpressionConverter.ConvertO(bodydispenseRequestnumberOfRepeatsAllowed);
                    dispenseRequestObjectpropCount++;
                }

                var quantityObject = new JObject();
                var quantityObjectpropCount = 0;
                if (bodydispenseRequestquantityvalue != null)
                {
                    quantityObject["value"] = ExpressionConverter.ConvertO(bodydispenseRequestquantityvalue);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantityunit != null)
                {
                    quantityObject["unit"] = ExpressionConverter.ConvertO(bodydispenseRequestquantityunit);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantitysystem != null)
                {
                    quantityObject["system"] = ExpressionConverter.ConvertO(bodydispenseRequestquantitysystem);
                    quantityObjectpropCount++;
                }

                if (bodydispenseRequestquantitycode != null)
                {
                    quantityObject["code"] = ExpressionConverter.ConvertO(bodydispenseRequestquantitycode);
                    quantityObjectpropCount++;
                }

                if (quantityObjectpropCount > 0)
                {
                    dispenseRequestObject["quantity"] = quantityObject;
                    dispenseRequestObjectpropCount++;
                }

                var expectedSupplyDurationObject = new JObject();
                var expectedSupplyDurationObjectpropCount = 0;
                if (bodydispenseRequestexpectedSupplyDurationvalue != null)
                {
                    expectedSupplyDurationObject["value"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationvalue);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationunit != null)
                {
                    expectedSupplyDurationObject["unit"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationunit);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationsystem != null)
                {
                    expectedSupplyDurationObject["system"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationsystem);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (bodydispenseRequestexpectedSupplyDurationcode != null)
                {
                    expectedSupplyDurationObject["code"] = ExpressionConverter.ConvertO(bodydispenseRequestexpectedSupplyDurationcode);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (expectedSupplyDurationObjectpropCount > 0)
                {
                    dispenseRequestObject["expectedSupplyDuration"] = expectedSupplyDurationObject;
                    dispenseRequestObjectpropCount++;
                }

                if (dispenseRequestObjectpropCount > 0)
                {
                    body["dispenseRequest"] = dispenseRequestObject;
                    bodypropCount++;
                }

                var substitutionObject = new JObject();
                var substitutionObjectpropCount = 0;
                if (bodysubstitutionallowedBoolean != null)
                {
                    substitutionObject["allowedBoolean"] = ExpressionConverter.ConvertO(bodysubstitutionallowedBoolean);
                    substitutionObjectpropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (bodysubstitutionreasoncoding != null)
                {
                    reasonObject["coding"] = ExpressionConverter.ConvertO(bodysubstitutionreasoncoding);
                    reasonObjectpropCount++;
                }

                if (reasonObjectpropCount > 0)
                {
                    substitutionObject["reason"] = reasonObject;
                    substitutionObjectpropCount++;
                }

                if (substitutionObjectpropCount > 0)
                {
                    body["substitution"] = substitutionObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTMedicationRequestIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETMedicationStatement))]
        public IBodyWorkflowAction<GETMedicationStatementResponse> GETMedicationStatement([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETMedicationStatementResponse> __BuildGETMedicationStatement(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETMedicationStatementResponse>(() =>
            {
                var apiCallPath = "/MedicationStatement";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETMedicationStatementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTMedicationStatement))]
        public IBodyWorkflowAction<POSTMedicationStatementResponse> POSTMedicationStatement([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymedicationCodeableConcepttext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyeffectiveDateTime = null, [WorkflowExpression] Func<string> bodydateAsserted = null, [WorkflowExpression] Func<string> bodyinformationSourcereference = null, [WorkflowExpression] Func<string> bodyinformationSourcedisplay = null, [WorkflowExpression] Func<bodyreasonReferenceInputItem[]> bodyreasonReference = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null, [WorkflowExpression] Func<bodydosageInputItem[]> bodydosage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTMedicationStatementResponse> __BuildPOSTMedicationStatement(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodymedicationCodeableConcepttext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyeffectiveDateTime = null, WorkflowExpression<string> bodydateAsserted = null, WorkflowExpression<string> bodyinformationSourcereference = null, WorkflowExpression<string> bodyinformationSourcedisplay = null, WorkflowExpression<bodyreasonReferenceInputItem[]> bodyreasonReference = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null, WorkflowExpression<bodydosageInputItem[]> bodydosage = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymedicationCodeableConcepttext, nameof(bodymedicationCodeableConcepttext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyeffectiveDateTime, nameof(bodyeffectiveDateTime), required: false);
            WorkflowExpression.Validate(bodydateAsserted, nameof(bodydateAsserted), required: false);
            WorkflowExpression.Validate(bodyinformationSourcereference, nameof(bodyinformationSourcereference), required: false);
            WorkflowExpression.Validate(bodyinformationSourcedisplay, nameof(bodyinformationSourcedisplay), required: false);
            WorkflowExpression.Validate(bodyreasonReference, nameof(bodyreasonReference), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodydosage, nameof(bodydosage), required: false);
            return new DeferredBodyAction<POSTMedicationStatementResponse>(() =>
            {
                var apiCallPath = "/MedicationStatement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var medicationCodeableConceptObject = new JObject();
                var medicationCodeableConceptObjectpropCount = 0;
                if (bodymedicationCodeableConcepttext != null)
                {
                    medicationCodeableConceptObject["text"] = ExpressionConverter.ConvertO(bodymedicationCodeableConcepttext);
                    medicationCodeableConceptObjectpropCount++;
                }

                if (medicationCodeableConceptObjectpropCount > 0)
                {
                    body["medicationCodeableConcept"] = medicationCodeableConceptObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyeffectiveDateTime != null)
                {
                    body["effectiveDateTime"] = ExpressionConverter.ConvertO(bodyeffectiveDateTime);
                    bodypropCount++;
                }

                if (bodydateAsserted != null)
                {
                    body["dateAsserted"] = ExpressionConverter.ConvertO(bodydateAsserted);
                    bodypropCount++;
                }

                var informationSourceObject = new JObject();
                var informationSourceObjectpropCount = 0;
                if (bodyinformationSourcereference != null)
                {
                    informationSourceObject["reference"] = ExpressionConverter.ConvertO(bodyinformationSourcereference);
                    informationSourceObjectpropCount++;
                }

                if (bodyinformationSourcedisplay != null)
                {
                    informationSourceObject["display"] = ExpressionConverter.ConvertO(bodyinformationSourcedisplay);
                    informationSourceObjectpropCount++;
                }

                if (informationSourceObjectpropCount > 0)
                {
                    body["informationSource"] = informationSourceObject;
                    bodypropCount++;
                }

                if (bodyreasonReference != null)
                {
                    body["reasonReference"] = ExpressionConverter.ConvertO(bodyreasonReference);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodydosage != null)
                {
                    body["dosage"] = ExpressionConverter.ConvertO(bodydosage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTMedicationStatementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETMedicationStatementID))]
        public IBodyWorkflowAction<GETMedicationStatementIDResponse> GETMedicationStatementID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETMedicationStatementIDResponse> __BuildGETMedicationStatementID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETMedicationStatementIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/MedicationStatement/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETMedicationStatementIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEMedicationStatementID))]
        public IWorkflowAction DELETEMedicationStatementID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymedicationCodeableConcepttext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyeffectiveDateTime = null, [WorkflowExpression] Func<string> bodydateAsserted = null, [WorkflowExpression] Func<string> bodyinformationSourcereference = null, [WorkflowExpression] Func<string> bodyinformationSourcedisplay = null, [WorkflowExpression] Func<bodyreasonReferenceInputItem[]> bodyreasonReference = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null, [WorkflowExpression] Func<bodydosageInputItem[]> bodydosage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDELETEMedicationStatementID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodymedicationCodeableConcepttext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyeffectiveDateTime = null, WorkflowExpression<string> bodydateAsserted = null, WorkflowExpression<string> bodyinformationSourcereference = null, WorkflowExpression<string> bodyinformationSourcedisplay = null, WorkflowExpression<bodyreasonReferenceInputItem[]> bodyreasonReference = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null, WorkflowExpression<bodydosageInputItem[]> bodydosage = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymedicationCodeableConcepttext, nameof(bodymedicationCodeableConcepttext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyeffectiveDateTime, nameof(bodyeffectiveDateTime), required: false);
            WorkflowExpression.Validate(bodydateAsserted, nameof(bodydateAsserted), required: false);
            WorkflowExpression.Validate(bodyinformationSourcereference, nameof(bodyinformationSourcereference), required: false);
            WorkflowExpression.Validate(bodyinformationSourcedisplay, nameof(bodyinformationSourcedisplay), required: false);
            WorkflowExpression.Validate(bodyreasonReference, nameof(bodyreasonReference), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodydosage, nameof(bodydosage), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/MedicationStatement/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var medicationCodeableConceptObject = new JObject();
                var medicationCodeableConceptObjectpropCount = 0;
                if (bodymedicationCodeableConcepttext != null)
                {
                    medicationCodeableConceptObject["text"] = ExpressionConverter.ConvertO(bodymedicationCodeableConcepttext);
                    medicationCodeableConceptObjectpropCount++;
                }

                if (medicationCodeableConceptObjectpropCount > 0)
                {
                    body["medicationCodeableConcept"] = medicationCodeableConceptObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyeffectiveDateTime != null)
                {
                    body["effectiveDateTime"] = ExpressionConverter.ConvertO(bodyeffectiveDateTime);
                    bodypropCount++;
                }

                if (bodydateAsserted != null)
                {
                    body["dateAsserted"] = ExpressionConverter.ConvertO(bodydateAsserted);
                    bodypropCount++;
                }

                var informationSourceObject = new JObject();
                var informationSourceObjectpropCount = 0;
                if (bodyinformationSourcereference != null)
                {
                    informationSourceObject["reference"] = ExpressionConverter.ConvertO(bodyinformationSourcereference);
                    informationSourceObjectpropCount++;
                }

                if (bodyinformationSourcedisplay != null)
                {
                    informationSourceObject["display"] = ExpressionConverter.ConvertO(bodyinformationSourcedisplay);
                    informationSourceObjectpropCount++;
                }

                if (informationSourceObjectpropCount > 0)
                {
                    body["informationSource"] = informationSourceObject;
                    bodypropCount++;
                }

                if (bodyreasonReference != null)
                {
                    body["reasonReference"] = ExpressionConverter.ConvertO(bodyreasonReference);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodydosage != null)
                {
                    body["dosage"] = ExpressionConverter.ConvertO(bodydosage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTMedicationStatementID))]
        public IBodyWorkflowAction<PUTMedicationStatementIDResponse> PUTMedicationStatementID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodymedicationCodeableConcepttext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyeffectiveDateTime = null, [WorkflowExpression] Func<string> bodydateAsserted = null, [WorkflowExpression] Func<string> bodyinformationSourcereference = null, [WorkflowExpression] Func<string> bodyinformationSourcedisplay = null, [WorkflowExpression] Func<bodyreasonReferenceInputItem[]> bodyreasonReference = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null, [WorkflowExpression] Func<bodydosageInputItem[]> bodydosage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTMedicationStatementIDResponse> __BuildPUTMedicationStatementID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodymedicationCodeableConcepttext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyeffectiveDateTime = null, WorkflowExpression<string> bodydateAsserted = null, WorkflowExpression<string> bodyinformationSourcereference = null, WorkflowExpression<string> bodyinformationSourcedisplay = null, WorkflowExpression<bodyreasonReferenceInputItem[]> bodyreasonReference = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null, WorkflowExpression<bodydosageInputItem[]> bodydosage = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymedicationCodeableConcepttext, nameof(bodymedicationCodeableConcepttext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyeffectiveDateTime, nameof(bodyeffectiveDateTime), required: false);
            WorkflowExpression.Validate(bodydateAsserted, nameof(bodydateAsserted), required: false);
            WorkflowExpression.Validate(bodyinformationSourcereference, nameof(bodyinformationSourcereference), required: false);
            WorkflowExpression.Validate(bodyinformationSourcedisplay, nameof(bodyinformationSourcedisplay), required: false);
            WorkflowExpression.Validate(bodyreasonReference, nameof(bodyreasonReference), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodydosage, nameof(bodydosage), required: false);
            return new DeferredBodyAction<PUTMedicationStatementIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/MedicationStatement/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var medicationCodeableConceptObject = new JObject();
                var medicationCodeableConceptObjectpropCount = 0;
                if (bodymedicationCodeableConcepttext != null)
                {
                    medicationCodeableConceptObject["text"] = ExpressionConverter.ConvertO(bodymedicationCodeableConcepttext);
                    medicationCodeableConceptObjectpropCount++;
                }

                if (medicationCodeableConceptObjectpropCount > 0)
                {
                    body["medicationCodeableConcept"] = medicationCodeableConceptObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyeffectiveDateTime != null)
                {
                    body["effectiveDateTime"] = ExpressionConverter.ConvertO(bodyeffectiveDateTime);
                    bodypropCount++;
                }

                if (bodydateAsserted != null)
                {
                    body["dateAsserted"] = ExpressionConverter.ConvertO(bodydateAsserted);
                    bodypropCount++;
                }

                var informationSourceObject = new JObject();
                var informationSourceObjectpropCount = 0;
                if (bodyinformationSourcereference != null)
                {
                    informationSourceObject["reference"] = ExpressionConverter.ConvertO(bodyinformationSourcereference);
                    informationSourceObjectpropCount++;
                }

                if (bodyinformationSourcedisplay != null)
                {
                    informationSourceObject["display"] = ExpressionConverter.ConvertO(bodyinformationSourcedisplay);
                    informationSourceObjectpropCount++;
                }

                if (informationSourceObjectpropCount > 0)
                {
                    body["informationSource"] = informationSourceObject;
                    bodypropCount++;
                }

                if (bodyreasonReference != null)
                {
                    body["reasonReference"] = ExpressionConverter.ConvertO(bodyreasonReference);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodydosage != null)
                {
                    body["dosage"] = ExpressionConverter.ConvertO(bodydosage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTMedicationStatementIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETObservation))]
        public IBodyWorkflowAction<GETObservationResponse> GETObservation([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null, [WorkflowExpression] Func<string> encounter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETObservationResponse> __BuildGETObservation(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null, WorkflowExpression<string> encounter = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            WorkflowExpression.Validate(encounter, nameof(encounter), required: false);
            return new DeferredBodyAction<GETObservationResponse>(() =>
            {
                var apiCallPath = "/Observation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                if (encounter != null)
                    callPayload.Queries["encounter"] = ExpressionConverter.Convert(encounter);
                return new ApiConnectionAction<GETObservationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTObservation))]
        public IBodyWorkflowAction<POSTObservationResponse> POSTObservation([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyencounterreference = null, [WorkflowExpression] Func<string> bodyissued = null, [WorkflowExpression] Func<bodyperformerInputItem2[]> bodyperformer = null, [WorkflowExpression] Func<int> bodyvalueQuantityvalue = null, [WorkflowExpression] Func<string> bodyvalueQuantityunit = null, [WorkflowExpression] Func<string> bodyvalueQuantitysystem = null, [WorkflowExpression] Func<string> bodyvalueQuantitycode = null, [WorkflowExpression] Func<bodyinterpretationInputItem[]> bodyinterpretation = null, [WorkflowExpression] Func<bodybodySitecodingInputItem[]> bodybodySitecoding = null, [WorkflowExpression] Func<bodymethodcodingInputItem[]> bodymethodcoding = null, [WorkflowExpression] Func<bodyreferenceRangeInputItem[]> bodyreferenceRange = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTObservationResponse> __BuildPOSTObservation(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyencounterreference = null, WorkflowExpression<string> bodyissued = null, WorkflowExpression<bodyperformerInputItem2[]> bodyperformer = null, WorkflowExpression<int> bodyvalueQuantityvalue = null, WorkflowExpression<string> bodyvalueQuantityunit = null, WorkflowExpression<string> bodyvalueQuantitysystem = null, WorkflowExpression<string> bodyvalueQuantitycode = null, WorkflowExpression<bodyinterpretationInputItem[]> bodyinterpretation = null, WorkflowExpression<bodybodySitecodingInputItem[]> bodybodySitecoding = null, WorkflowExpression<bodymethodcodingInputItem[]> bodymethodcoding = null, WorkflowExpression<bodyreferenceRangeInputItem[]> bodyreferenceRange = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyencounterreference, nameof(bodyencounterreference), required: false);
            WorkflowExpression.Validate(bodyissued, nameof(bodyissued), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyvalueQuantityvalue, nameof(bodyvalueQuantityvalue), required: false);
            WorkflowExpression.Validate(bodyvalueQuantityunit, nameof(bodyvalueQuantityunit), required: false);
            WorkflowExpression.Validate(bodyvalueQuantitysystem, nameof(bodyvalueQuantitysystem), required: false);
            WorkflowExpression.Validate(bodyvalueQuantitycode, nameof(bodyvalueQuantitycode), required: false);
            WorkflowExpression.Validate(bodyinterpretation, nameof(bodyinterpretation), required: false);
            WorkflowExpression.Validate(bodybodySitecoding, nameof(bodybodySitecoding), required: false);
            WorkflowExpression.Validate(bodymethodcoding, nameof(bodymethodcoding), required: false);
            WorkflowExpression.Validate(bodyreferenceRange, nameof(bodyreferenceRange), required: false);
            return new DeferredBodyAction<POSTObservationResponse>(() =>
            {
                var apiCallPath = "/Observation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                if (bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(bodyissued);
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                var valueQuantityObject = new JObject();
                var valueQuantityObjectpropCount = 0;
                if (bodyvalueQuantityvalue != null)
                {
                    valueQuantityObject["value"] = ExpressionConverter.ConvertO(bodyvalueQuantityvalue);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantityunit != null)
                {
                    valueQuantityObject["unit"] = ExpressionConverter.ConvertO(bodyvalueQuantityunit);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantitysystem != null)
                {
                    valueQuantityObject["system"] = ExpressionConverter.ConvertO(bodyvalueQuantitysystem);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantitycode != null)
                {
                    valueQuantityObject["code"] = ExpressionConverter.ConvertO(bodyvalueQuantitycode);
                    valueQuantityObjectpropCount++;
                }

                if (valueQuantityObjectpropCount > 0)
                {
                    body["valueQuantity"] = valueQuantityObject;
                    bodypropCount++;
                }

                if (bodyinterpretation != null)
                {
                    body["interpretation"] = ExpressionConverter.ConvertO(bodyinterpretation);
                    bodypropCount++;
                }

                var bodySiteObject = new JObject();
                var bodySiteObjectpropCount = 0;
                if (bodybodySitecoding != null)
                {
                    bodySiteObject["coding"] = ExpressionConverter.ConvertO(bodybodySitecoding);
                    bodySiteObjectpropCount++;
                }

                if (bodySiteObjectpropCount > 0)
                {
                    body["bodySite"] = bodySiteObject;
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                if (bodyreferenceRange != null)
                {
                    body["referenceRange"] = ExpressionConverter.ConvertO(bodyreferenceRange);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTObservationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETObservationID))]
        public IBodyWorkflowAction<GETObservationIDResponse> GETObservationID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETObservationIDResponse> __BuildGETObservationID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETObservationIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Observation/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETObservationIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEObservationID))]
        public IBodyWorkflowAction<DELETEObservationIDResponse> DELETEObservationID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyissued = null, [WorkflowExpression] Func<bodyperformerInputItem2[]> bodyperformer = null, [WorkflowExpression] Func<int> bodyvalueQuantityvalue = null, [WorkflowExpression] Func<string> bodyvalueQuantityunit = null, [WorkflowExpression] Func<string> bodyvalueQuantitysystem = null, [WorkflowExpression] Func<string> bodyvalueQuantitycode = null, [WorkflowExpression] Func<bodyinterpretationInputItem[]> bodyinterpretation = null, [WorkflowExpression] Func<bodybodySitecodingInputItem[]> bodybodySitecoding = null, [WorkflowExpression] Func<bodymethodcodingInputItem[]> bodymethodcoding = null, [WorkflowExpression] Func<bodyreferenceRangeInputItem[]> bodyreferenceRange = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETEObservationIDResponse> __BuildDELETEObservationID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyissued = null, WorkflowExpression<bodyperformerInputItem2[]> bodyperformer = null, WorkflowExpression<int> bodyvalueQuantityvalue = null, WorkflowExpression<string> bodyvalueQuantityunit = null, WorkflowExpression<string> bodyvalueQuantitysystem = null, WorkflowExpression<string> bodyvalueQuantitycode = null, WorkflowExpression<bodyinterpretationInputItem[]> bodyinterpretation = null, WorkflowExpression<bodybodySitecodingInputItem[]> bodybodySitecoding = null, WorkflowExpression<bodymethodcodingInputItem[]> bodymethodcoding = null, WorkflowExpression<bodyreferenceRangeInputItem[]> bodyreferenceRange = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyissued, nameof(bodyissued), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyvalueQuantityvalue, nameof(bodyvalueQuantityvalue), required: false);
            WorkflowExpression.Validate(bodyvalueQuantityunit, nameof(bodyvalueQuantityunit), required: false);
            WorkflowExpression.Validate(bodyvalueQuantitysystem, nameof(bodyvalueQuantitysystem), required: false);
            WorkflowExpression.Validate(bodyvalueQuantitycode, nameof(bodyvalueQuantitycode), required: false);
            WorkflowExpression.Validate(bodyinterpretation, nameof(bodyinterpretation), required: false);
            WorkflowExpression.Validate(bodybodySitecoding, nameof(bodybodySitecoding), required: false);
            WorkflowExpression.Validate(bodymethodcoding, nameof(bodymethodcoding), required: false);
            WorkflowExpression.Validate(bodyreferenceRange, nameof(bodyreferenceRange), required: false);
            return new DeferredBodyAction<DELETEObservationIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Observation/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(bodyissued);
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                var valueQuantityObject = new JObject();
                var valueQuantityObjectpropCount = 0;
                if (bodyvalueQuantityvalue != null)
                {
                    valueQuantityObject["value"] = ExpressionConverter.ConvertO(bodyvalueQuantityvalue);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantityunit != null)
                {
                    valueQuantityObject["unit"] = ExpressionConverter.ConvertO(bodyvalueQuantityunit);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantitysystem != null)
                {
                    valueQuantityObject["system"] = ExpressionConverter.ConvertO(bodyvalueQuantitysystem);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantitycode != null)
                {
                    valueQuantityObject["code"] = ExpressionConverter.ConvertO(bodyvalueQuantitycode);
                    valueQuantityObjectpropCount++;
                }

                if (valueQuantityObjectpropCount > 0)
                {
                    body["valueQuantity"] = valueQuantityObject;
                    bodypropCount++;
                }

                if (bodyinterpretation != null)
                {
                    body["interpretation"] = ExpressionConverter.ConvertO(bodyinterpretation);
                    bodypropCount++;
                }

                var bodySiteObject = new JObject();
                var bodySiteObjectpropCount = 0;
                if (bodybodySitecoding != null)
                {
                    bodySiteObject["coding"] = ExpressionConverter.ConvertO(bodybodySitecoding);
                    bodySiteObjectpropCount++;
                }

                if (bodySiteObjectpropCount > 0)
                {
                    body["bodySite"] = bodySiteObject;
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                if (bodyreferenceRange != null)
                {
                    body["referenceRange"] = ExpressionConverter.ConvertO(bodyreferenceRange);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEObservationIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTObservationID))]
        public IBodyWorkflowAction<PUTObservationIDResponse> PUTObservationID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycategoryInputItem[]> bodycategory = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodysubjectdisplay = null, [WorkflowExpression] Func<string> bodyissued = null, [WorkflowExpression] Func<bodyperformerInputItem2[]> bodyperformer = null, [WorkflowExpression] Func<int> bodyvalueQuantityvalue = null, [WorkflowExpression] Func<string> bodyvalueQuantityunit = null, [WorkflowExpression] Func<string> bodyvalueQuantitysystem = null, [WorkflowExpression] Func<string> bodyvalueQuantitycode = null, [WorkflowExpression] Func<bodyinterpretationInputItem[]> bodyinterpretation = null, [WorkflowExpression] Func<bodybodySitecodingInputItem[]> bodybodySitecoding = null, [WorkflowExpression] Func<bodymethodcodingInputItem[]> bodymethodcoding = null, [WorkflowExpression] Func<bodyreferenceRangeInputItem[]> bodyreferenceRange = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTObservationIDResponse> __BuildPUTObservationID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycategoryInputItem[]> bodycategory = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodysubjectdisplay = null, WorkflowExpression<string> bodyissued = null, WorkflowExpression<bodyperformerInputItem2[]> bodyperformer = null, WorkflowExpression<int> bodyvalueQuantityvalue = null, WorkflowExpression<string> bodyvalueQuantityunit = null, WorkflowExpression<string> bodyvalueQuantitysystem = null, WorkflowExpression<string> bodyvalueQuantitycode = null, WorkflowExpression<bodyinterpretationInputItem[]> bodyinterpretation = null, WorkflowExpression<bodybodySitecodingInputItem[]> bodybodySitecoding = null, WorkflowExpression<bodymethodcodingInputItem[]> bodymethodcoding = null, WorkflowExpression<bodyreferenceRangeInputItem[]> bodyreferenceRange = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            WorkflowExpression.Validate(bodyissued, nameof(bodyissued), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyvalueQuantityvalue, nameof(bodyvalueQuantityvalue), required: false);
            WorkflowExpression.Validate(bodyvalueQuantityunit, nameof(bodyvalueQuantityunit), required: false);
            WorkflowExpression.Validate(bodyvalueQuantitysystem, nameof(bodyvalueQuantitysystem), required: false);
            WorkflowExpression.Validate(bodyvalueQuantitycode, nameof(bodyvalueQuantitycode), required: false);
            WorkflowExpression.Validate(bodyinterpretation, nameof(bodyinterpretation), required: false);
            WorkflowExpression.Validate(bodybodySitecoding, nameof(bodybodySitecoding), required: false);
            WorkflowExpression.Validate(bodymethodcoding, nameof(bodymethodcoding), required: false);
            WorkflowExpression.Validate(bodyreferenceRange, nameof(bodyreferenceRange), required: false);
            return new DeferredBodyAction<PUTObservationIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Observation/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(bodyissued);
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                var valueQuantityObject = new JObject();
                var valueQuantityObjectpropCount = 0;
                if (bodyvalueQuantityvalue != null)
                {
                    valueQuantityObject["value"] = ExpressionConverter.ConvertO(bodyvalueQuantityvalue);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantityunit != null)
                {
                    valueQuantityObject["unit"] = ExpressionConverter.ConvertO(bodyvalueQuantityunit);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantitysystem != null)
                {
                    valueQuantityObject["system"] = ExpressionConverter.ConvertO(bodyvalueQuantitysystem);
                    valueQuantityObjectpropCount++;
                }

                if (bodyvalueQuantitycode != null)
                {
                    valueQuantityObject["code"] = ExpressionConverter.ConvertO(bodyvalueQuantitycode);
                    valueQuantityObjectpropCount++;
                }

                if (valueQuantityObjectpropCount > 0)
                {
                    body["valueQuantity"] = valueQuantityObject;
                    bodypropCount++;
                }

                if (bodyinterpretation != null)
                {
                    body["interpretation"] = ExpressionConverter.ConvertO(bodyinterpretation);
                    bodypropCount++;
                }

                var bodySiteObject = new JObject();
                var bodySiteObjectpropCount = 0;
                if (bodybodySitecoding != null)
                {
                    bodySiteObject["coding"] = ExpressionConverter.ConvertO(bodybodySitecoding);
                    bodySiteObjectpropCount++;
                }

                if (bodySiteObjectpropCount > 0)
                {
                    body["bodySite"] = bodySiteObject;
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                if (bodyreferenceRange != null)
                {
                    body["referenceRange"] = ExpressionConverter.ConvertO(bodyreferenceRange);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTObservationIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETProcedure))]
        public IBodyWorkflowAction<GETProcedureResponse> GETProcedure([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETProcedureResponse> __BuildGETProcedure(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETProcedureResponse>(() =>
            {
                var apiCallPath = "/Procedure";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETProcedureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTProcedure))]
        public IBodyWorkflowAction<POSTProcedureResponse> POSTProcedure([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyperformedDateTime = null, [WorkflowExpression] Func<string> bodyrecorderreference = null, [WorkflowExpression] Func<string> bodyrecorderdisplay = null, [WorkflowExpression] Func<string> bodyasserterreference = null, [WorkflowExpression] Func<string> bodyasserterdisplay = null, [WorkflowExpression] Func<bodyperformerInputItem22[]> bodyperformer = null, [WorkflowExpression] Func<bodyreasonCodeInputItem2[]> bodyreasonCode = null, [WorkflowExpression] Func<bodyfollowUpInputItem[]> bodyfollowUp = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTProcedureResponse> __BuildPOSTProcedure(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyperformedDateTime = null, WorkflowExpression<string> bodyrecorderreference = null, WorkflowExpression<string> bodyrecorderdisplay = null, WorkflowExpression<string> bodyasserterreference = null, WorkflowExpression<string> bodyasserterdisplay = null, WorkflowExpression<bodyperformerInputItem22[]> bodyperformer = null, WorkflowExpression<bodyreasonCodeInputItem2[]> bodyreasonCode = null, WorkflowExpression<bodyfollowUpInputItem[]> bodyfollowUp = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyperformedDateTime, nameof(bodyperformedDateTime), required: false);
            WorkflowExpression.Validate(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            WorkflowExpression.Validate(bodyrecorderdisplay, nameof(bodyrecorderdisplay), required: false);
            WorkflowExpression.Validate(bodyasserterreference, nameof(bodyasserterreference), required: false);
            WorkflowExpression.Validate(bodyasserterdisplay, nameof(bodyasserterdisplay), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyreasonCode, nameof(bodyreasonCode), required: false);
            WorkflowExpression.Validate(bodyfollowUp, nameof(bodyfollowUp), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<POSTProcedureResponse>(() =>
            {
                var apiCallPath = "/Procedure";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyperformedDateTime != null)
                {
                    body["performedDateTime"] = ExpressionConverter.ConvertO(bodyperformedDateTime);
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (bodyrecorderdisplay != null)
                {
                    recorderObject["display"] = ExpressionConverter.ConvertO(bodyrecorderdisplay);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                var asserterObject = new JObject();
                var asserterObjectpropCount = 0;
                if (bodyasserterreference != null)
                {
                    asserterObject["reference"] = ExpressionConverter.ConvertO(bodyasserterreference);
                    asserterObjectpropCount++;
                }

                if (bodyasserterdisplay != null)
                {
                    asserterObject["display"] = ExpressionConverter.ConvertO(bodyasserterdisplay);
                    asserterObjectpropCount++;
                }

                if (asserterObjectpropCount > 0)
                {
                    body["asserter"] = asserterObject;
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                if (bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(bodyreasonCode);
                    bodypropCount++;
                }

                if (bodyfollowUp != null)
                {
                    body["followUp"] = ExpressionConverter.ConvertO(bodyfollowUp);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTProcedureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETProcedureID))]
        public IBodyWorkflowAction<GETProcedureIDResponse> GETProcedureID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETProcedureIDResponse> __BuildGETProcedureID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETProcedureIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Procedure/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETProcedureIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETEProcedureID))]
        public IBodyWorkflowAction<DELETEProcedureIDResponse> DELETEProcedureID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyperformedDateTime = null, [WorkflowExpression] Func<string> bodyrecorderreference = null, [WorkflowExpression] Func<string> bodyrecorderdisplay = null, [WorkflowExpression] Func<string> bodyasserterreference = null, [WorkflowExpression] Func<string> bodyasserterdisplay = null, [WorkflowExpression] Func<bodyperformerInputItem22[]> bodyperformer = null, [WorkflowExpression] Func<bodyreasonCodeInputItem2[]> bodyreasonCode = null, [WorkflowExpression] Func<bodyfollowUpInputItem[]> bodyfollowUp = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETEProcedureIDResponse> __BuildDELETEProcedureID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyperformedDateTime = null, WorkflowExpression<string> bodyrecorderreference = null, WorkflowExpression<string> bodyrecorderdisplay = null, WorkflowExpression<string> bodyasserterreference = null, WorkflowExpression<string> bodyasserterdisplay = null, WorkflowExpression<bodyperformerInputItem22[]> bodyperformer = null, WorkflowExpression<bodyreasonCodeInputItem2[]> bodyreasonCode = null, WorkflowExpression<bodyfollowUpInputItem[]> bodyfollowUp = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyperformedDateTime, nameof(bodyperformedDateTime), required: false);
            WorkflowExpression.Validate(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            WorkflowExpression.Validate(bodyrecorderdisplay, nameof(bodyrecorderdisplay), required: false);
            WorkflowExpression.Validate(bodyasserterreference, nameof(bodyasserterreference), required: false);
            WorkflowExpression.Validate(bodyasserterdisplay, nameof(bodyasserterdisplay), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyreasonCode, nameof(bodyreasonCode), required: false);
            WorkflowExpression.Validate(bodyfollowUp, nameof(bodyfollowUp), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<DELETEProcedureIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Procedure/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyperformedDateTime != null)
                {
                    body["performedDateTime"] = ExpressionConverter.ConvertO(bodyperformedDateTime);
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (bodyrecorderdisplay != null)
                {
                    recorderObject["display"] = ExpressionConverter.ConvertO(bodyrecorderdisplay);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                var asserterObject = new JObject();
                var asserterObjectpropCount = 0;
                if (bodyasserterreference != null)
                {
                    asserterObject["reference"] = ExpressionConverter.ConvertO(bodyasserterreference);
                    asserterObjectpropCount++;
                }

                if (bodyasserterdisplay != null)
                {
                    asserterObject["display"] = ExpressionConverter.ConvertO(bodyasserterdisplay);
                    asserterObjectpropCount++;
                }

                if (asserterObjectpropCount > 0)
                {
                    body["asserter"] = asserterObject;
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                if (bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(bodyreasonCode);
                    bodypropCount++;
                }

                if (bodyfollowUp != null)
                {
                    body["followUp"] = ExpressionConverter.ConvertO(bodyfollowUp);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEProcedureIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTProcedureID))]
        public IBodyWorkflowAction<PUTProcedureIDResponse> PUTProcedureID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodymetaversionId = null, [WorkflowExpression] Func<string> bodymetalastUpdated = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodycodecodingInputItem[]> bodycodecoding = null, [WorkflowExpression] Func<string> bodycodetext = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyperformedDateTime = null, [WorkflowExpression] Func<string> bodyrecorderreference = null, [WorkflowExpression] Func<string> bodyrecorderdisplay = null, [WorkflowExpression] Func<string> bodyasserterreference = null, [WorkflowExpression] Func<string> bodyasserterdisplay = null, [WorkflowExpression] Func<bodyperformerInputItem22[]> bodyperformer = null, [WorkflowExpression] Func<bodyreasonCodeInputItem2[]> bodyreasonCode = null, [WorkflowExpression] Func<bodyfollowUpInputItem[]> bodyfollowUp = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTProcedureIDResponse> __BuildPUTProcedureID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodymetaversionId = null, WorkflowExpression<string> bodymetalastUpdated = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodycodecodingInputItem[]> bodycodecoding = null, WorkflowExpression<string> bodycodetext = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyperformedDateTime = null, WorkflowExpression<string> bodyrecorderreference = null, WorkflowExpression<string> bodyrecorderdisplay = null, WorkflowExpression<string> bodyasserterreference = null, WorkflowExpression<string> bodyasserterdisplay = null, WorkflowExpression<bodyperformerInputItem22[]> bodyperformer = null, WorkflowExpression<bodyreasonCodeInputItem2[]> bodyreasonCode = null, WorkflowExpression<bodyfollowUpInputItem[]> bodyfollowUp = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodymetaversionId, nameof(bodymetaversionId), required: false);
            WorkflowExpression.Validate(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycodecoding, nameof(bodycodecoding), required: false);
            WorkflowExpression.Validate(bodycodetext, nameof(bodycodetext), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyperformedDateTime, nameof(bodyperformedDateTime), required: false);
            WorkflowExpression.Validate(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            WorkflowExpression.Validate(bodyrecorderdisplay, nameof(bodyrecorderdisplay), required: false);
            WorkflowExpression.Validate(bodyasserterreference, nameof(bodyasserterreference), required: false);
            WorkflowExpression.Validate(bodyasserterdisplay, nameof(bodyasserterdisplay), required: false);
            WorkflowExpression.Validate(bodyperformer, nameof(bodyperformer), required: false);
            WorkflowExpression.Validate(bodyreasonCode, nameof(bodyreasonCode), required: false);
            WorkflowExpression.Validate(bodyfollowUp, nameof(bodyfollowUp), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<PUTProcedureIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Procedure/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(bodycodecoding);
                    codeObjectpropCount++;
                }

                if (bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyperformedDateTime != null)
                {
                    body["performedDateTime"] = ExpressionConverter.ConvertO(bodyperformedDateTime);
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (bodyrecorderdisplay != null)
                {
                    recorderObject["display"] = ExpressionConverter.ConvertO(bodyrecorderdisplay);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                var asserterObject = new JObject();
                var asserterObjectpropCount = 0;
                if (bodyasserterreference != null)
                {
                    asserterObject["reference"] = ExpressionConverter.ConvertO(bodyasserterreference);
                    asserterObjectpropCount++;
                }

                if (bodyasserterdisplay != null)
                {
                    asserterObject["display"] = ExpressionConverter.ConvertO(bodyasserterdisplay);
                    asserterObjectpropCount++;
                }

                if (asserterObjectpropCount > 0)
                {
                    body["asserter"] = asserterObject;
                    bodypropCount++;
                }

                if (bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(bodyperformer);
                    bodypropCount++;
                }

                if (bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(bodyreasonCode);
                    bodypropCount++;
                }

                if (bodyfollowUp != null)
                {
                    body["followUp"] = ExpressionConverter.ConvertO(bodyfollowUp);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTProcedureIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETRiskAssessment))]
        public IBodyWorkflowAction<GETRiskAssessmentResponse> GETRiskAssessment([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETRiskAssessmentResponse> __BuildGETRiskAssessment(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETRiskAssessmentResponse>(() =>
            {
                var apiCallPath = "/RiskAssessment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETRiskAssessmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTRiskAssessment))]
        public IBodyWorkflowAction<POSTRiskAssessmentResponse> POSTRiskAssessment([WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodymethodcodingInputItem2[]> bodymethodcoding = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyoccurrenceDateTime = null, [WorkflowExpression] Func<bodybasisInputItem[]> bodybasis = null, [WorkflowExpression] Func<bodypredictionInputItem[]> bodyprediction = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<POSTRiskAssessmentResponse> __BuildPOSTRiskAssessment(WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodymethodcodingInputItem2[]> bodymethodcoding = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyoccurrenceDateTime = null, WorkflowExpression<bodybasisInputItem[]> bodybasis = null, WorkflowExpression<bodypredictionInputItem[]> bodyprediction = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null)
        {
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymethodcoding, nameof(bodymethodcoding), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyoccurrenceDateTime, nameof(bodyoccurrenceDateTime), required: false);
            WorkflowExpression.Validate(bodybasis, nameof(bodybasis), required: false);
            WorkflowExpression.Validate(bodyprediction, nameof(bodyprediction), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<POSTRiskAssessmentResponse>(() =>
            {
                var apiCallPath = "/RiskAssessment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyoccurrenceDateTime != null)
                {
                    body["occurrenceDateTime"] = ExpressionConverter.ConvertO(bodyoccurrenceDateTime);
                    bodypropCount++;
                }

                if (bodybasis != null)
                {
                    body["basis"] = ExpressionConverter.ConvertO(bodybasis);
                    bodypropCount++;
                }

                if (bodyprediction != null)
                {
                    body["prediction"] = ExpressionConverter.ConvertO(bodyprediction);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<POSTRiskAssessmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETRiskAssessmentID))]
        public IBodyWorkflowAction<GETRiskAssessmentIDResponse> GETRiskAssessmentID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETRiskAssessmentIDResponse> __BuildGETRiskAssessmentID(WorkflowExpression<string> id, WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETRiskAssessmentIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/RiskAssessment/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                return new ApiConnectionAction<GETRiskAssessmentIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildDELETERiskAssessmentID))]
        public IBodyWorkflowAction<DELETERiskAssessmentIDResponse> DELETERiskAssessmentID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodymethodcodingInputItem2[]> bodymethodcoding = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyoccurrenceDateTime = null, [WorkflowExpression] Func<bodybasisInputItem[]> bodybasis = null, [WorkflowExpression] Func<bodypredictionInputItem[]> bodyprediction = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DELETERiskAssessmentIDResponse> __BuildDELETERiskAssessmentID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodymethodcodingInputItem2[]> bodymethodcoding = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyoccurrenceDateTime = null, WorkflowExpression<bodybasisInputItem[]> bodybasis = null, WorkflowExpression<bodypredictionInputItem[]> bodyprediction = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymethodcoding, nameof(bodymethodcoding), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyoccurrenceDateTime, nameof(bodyoccurrenceDateTime), required: false);
            WorkflowExpression.Validate(bodybasis, nameof(bodybasis), required: false);
            WorkflowExpression.Validate(bodyprediction, nameof(bodyprediction), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<DELETERiskAssessmentIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/RiskAssessment/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyoccurrenceDateTime != null)
                {
                    body["occurrenceDateTime"] = ExpressionConverter.ConvertO(bodyoccurrenceDateTime);
                    bodypropCount++;
                }

                if (bodybasis != null)
                {
                    body["basis"] = ExpressionConverter.ConvertO(bodybasis);
                    bodypropCount++;
                }

                if (bodyprediction != null)
                {
                    body["prediction"] = ExpressionConverter.ConvertO(bodyprediction);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETERiskAssessmentIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildPUTRiskAssessmentID))]
        public IBodyWorkflowAction<PUTRiskAssessmentIDResponse> PUTRiskAssessmentID([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyresourceType = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytextstatus = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodymethodcodingInputItem2[]> bodymethodcoding = null, [WorkflowExpression] Func<string> bodysubjectreference = null, [WorkflowExpression] Func<string> bodyoccurrenceDateTime = null, [WorkflowExpression] Func<bodybasisInputItem[]> bodybasis = null, [WorkflowExpression] Func<bodypredictionInputItem[]> bodyprediction = null, [WorkflowExpression] Func<bodynoteInputItem[]> bodynote = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PUTRiskAssessmentIDResponse> __BuildPUTRiskAssessmentID(WorkflowExpression<string> id, WorkflowExpression<string> bodyresourceType = null, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodytextstatus = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<bodymethodcodingInputItem2[]> bodymethodcoding = null, WorkflowExpression<string> bodysubjectreference = null, WorkflowExpression<string> bodyoccurrenceDateTime = null, WorkflowExpression<bodybasisInputItem[]> bodybasis = null, WorkflowExpression<bodypredictionInputItem[]> bodyprediction = null, WorkflowExpression<bodynoteInputItem[]> bodynote = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: false);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodytextstatus, nameof(bodytextstatus), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodymethodcoding, nameof(bodymethodcoding), required: false);
            WorkflowExpression.Validate(bodysubjectreference, nameof(bodysubjectreference), required: false);
            WorkflowExpression.Validate(bodyoccurrenceDateTime, nameof(bodyoccurrenceDateTime), required: false);
            WorkflowExpression.Validate(bodybasis, nameof(bodybasis), required: false);
            WorkflowExpression.Validate(bodyprediction, nameof(bodyprediction), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<PUTRiskAssessmentIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/RiskAssessment/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(bodyresourceType);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (bodyoccurrenceDateTime != null)
                {
                    body["occurrenceDateTime"] = ExpressionConverter.ConvertO(bodyoccurrenceDateTime);
                    bodypropCount++;
                }

                if (bodybasis != null)
                {
                    body["basis"] = ExpressionConverter.ConvertO(bodybasis);
                    bodypropCount++;
                }

                if (bodyprediction != null)
                {
                    body["prediction"] = ExpressionConverter.ConvertO(bodyprediction);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTRiskAssessmentIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETCareTeam))]
        public IBodyWorkflowAction<GETCareTeamResponse> GETCareTeam([WorkflowExpression] Func<string> Count = null, [WorkflowExpression] Func<string> Sort = null, [WorkflowExpression] Func<string> patient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETCareTeamResponse> __BuildGETCareTeam(WorkflowExpression<string> Count = null, WorkflowExpression<string> Sort = null, WorkflowExpression<string> patient = null)
        {
            WorkflowExpression.Validate(Count, nameof(Count), required: false);
            WorkflowExpression.Validate(Sort, nameof(Sort), required: false);
            WorkflowExpression.Validate(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETCareTeamResponse>(() =>
            {
                var apiCallPath = "/CareTeam";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(Count);
                if (Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(Sort);
                if (patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(patient);
                return new ApiConnectionAction<GETCareTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        [WorkflowExpressionFactory(nameof(__BuildGETCareTeamID))]
        public IBodyWorkflowAction<GETCareTeamIDResponse> GETCareTeamID([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GETCareTeamIDResponse> __BuildGETCareTeamID(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GETCareTeamIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/CareTeam/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETCareTeamIDResponse>(callPayload);
            });
        }
    }

    public class FhirclinicalTriggers([ConnectionName] string connectionId)
    {
    }

    public class GETAdverseEventResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAdverseEventResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETAdverseEventResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETAdverseEventResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETAdverseEventResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAdverseEventResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETAdverseEventResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETAdverseEventResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeEventType Event { get; set; }

        [JsonProperty("subject")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeEventType
    {
        [JsonProperty("coding")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeSeriousnessType
    {
        [JsonProperty("coding")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeSeverityType
    {
        [JsonProperty("coding")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public GETAdverseEventResponseEntryTypeItemResourceTypeSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemResourceTypeSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAdverseEventResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTAdverseEventResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTAdverseEventResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public POSTAdverseEventResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public POSTAdverseEventResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public POSTAdverseEventResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public POSTAdverseEventResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public POSTAdverseEventResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public POSTAdverseEventResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public POSTAdverseEventResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public POSTAdverseEventResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class POSTAdverseEventResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTAdverseEventResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class POSTAdverseEventResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public POSTAdverseEventResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAdverseEventResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAdverseEventResponseEventType
    {
        [JsonProperty("coding")]
        public POSTAdverseEventResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTAdverseEventResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAdverseEventResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTAdverseEventResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public POSTAdverseEventResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAdverseEventResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAdverseEventResponseSeverityType
    {
        [JsonProperty("coding")]
        public POSTAdverseEventResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAdverseEventResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAdverseEventResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTAdverseEventResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public POSTAdverseEventResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class POSTAdverseEventResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodycategoryInputItem
    {
        [JsonProperty("coding")]
        public bodycategoryInputItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodycategoryInputItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyEventcodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyseriousnesscodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyseveritycodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodysuspectEntityInputItem
    {
        [JsonProperty("instance")]
        public bodysuspectEntityInputItemInstanceType Instance { get; set; }
    }

    public class bodysuspectEntityInputItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAdverseEventIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAdverseEventIDResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETAdverseEventIDResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public GETAdverseEventIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public GETAdverseEventIDResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public GETAdverseEventIDResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public GETAdverseEventIDResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public GETAdverseEventIDResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public GETAdverseEventIDResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public GETAdverseEventIDResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class GETAdverseEventIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAdverseEventIDResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETAdverseEventIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETAdverseEventIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventIDResponseEventType
    {
        [JsonProperty("coding")]
        public GETAdverseEventIDResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETAdverseEventIDResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAdverseEventIDResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public GETAdverseEventIDResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventIDResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventIDResponseSeverityType
    {
        [JsonProperty("coding")]
        public GETAdverseEventIDResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventIDResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventIDResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAdverseEventIDResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public GETAdverseEventIDResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class GETAdverseEventIDResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEAdverseEventIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAdverseEventIDResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public DELETEAdverseEventIDResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public DELETEAdverseEventIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public DELETEAdverseEventIDResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public DELETEAdverseEventIDResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public DELETEAdverseEventIDResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public DELETEAdverseEventIDResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public DELETEAdverseEventIDResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public DELETEAdverseEventIDResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class DELETEAdverseEventIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAdverseEventIDResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEAdverseEventIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEAdverseEventIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAdverseEventIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAdverseEventIDResponseEventType
    {
        [JsonProperty("coding")]
        public DELETEAdverseEventIDResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEAdverseEventIDResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAdverseEventIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEAdverseEventIDResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public DELETEAdverseEventIDResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAdverseEventIDResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAdverseEventIDResponseSeverityType
    {
        [JsonProperty("coding")]
        public DELETEAdverseEventIDResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAdverseEventIDResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAdverseEventIDResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEAdverseEventIDResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public DELETEAdverseEventIDResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class DELETEAdverseEventIDResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTAdverseEventIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAdverseEventIDResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PUTAdverseEventIDResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public PUTAdverseEventIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public PUTAdverseEventIDResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public PUTAdverseEventIDResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public PUTAdverseEventIDResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public PUTAdverseEventIDResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public PUTAdverseEventIDResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public PUTAdverseEventIDResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class PUTAdverseEventIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAdverseEventIDResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTAdverseEventIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTAdverseEventIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAdverseEventIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAdverseEventIDResponseEventType
    {
        [JsonProperty("coding")]
        public PUTAdverseEventIDResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTAdverseEventIDResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAdverseEventIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTAdverseEventIDResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public PUTAdverseEventIDResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAdverseEventIDResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAdverseEventIDResponseSeverityType
    {
        [JsonProperty("coding")]
        public PUTAdverseEventIDResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAdverseEventIDResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAdverseEventIDResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTAdverseEventIDResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public PUTAdverseEventIDResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class PUTAdverseEventIDResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAllergyIntoleranceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAllergyIntoleranceResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETAllergyIntoleranceResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETAllergyIntoleranceResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETAllergyIntoleranceResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAllergyIntoleranceResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETAllergyIntoleranceResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceTypeClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceTypeVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("patient")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceTypePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceTypeClinicalStatusType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceTypeClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceTypeClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceTypeVerificationStatusType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceTypeVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceTypeVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemResourceTypePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAllergyIntoleranceResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTAllergyIntoleranceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTAllergyIntoleranceResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTAllergyIntoleranceResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public POSTAllergyIntoleranceResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public POSTAllergyIntoleranceResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public POSTAllergyIntoleranceResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public POSTAllergyIntoleranceResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }

        [JsonProperty("recorder")]
        public POSTAllergyIntoleranceResponseRecorderType Recorder { get; set; }

        [JsonProperty("reaction")]
        public POSTAllergyIntoleranceResponseReactionTypeItem[] Reaction { get; set; }
    }

    public class POSTAllergyIntoleranceResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTAllergyIntoleranceResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTAllergyIntoleranceResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public POSTAllergyIntoleranceResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAllergyIntoleranceResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAllergyIntoleranceResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public POSTAllergyIntoleranceResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAllergyIntoleranceResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAllergyIntoleranceResponseCodeType
    {
        [JsonProperty("coding")]
        public POSTAllergyIntoleranceResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAllergyIntoleranceResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAllergyIntoleranceResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTAllergyIntoleranceResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTAllergyIntoleranceResponseReactionTypeItem
    {
        [JsonProperty("manifestation")]
        public POSTAllergyIntoleranceResponseReactionTypeItemManifestationTypeItem[] Manifestation { get; set; }
    }

    public class POSTAllergyIntoleranceResponseReactionTypeItemManifestationTypeItem
    {
        [JsonProperty("coding")]
        public POSTAllergyIntoleranceResponseReactionTypeItemManifestationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAllergyIntoleranceResponseReactionTypeItemManifestationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyclinicalStatuscodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyverificationStatuscodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodycodecodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyreactionInputItem
    {
        [JsonProperty("manifestation")]
        public bodyreactionInputItemManifestationTypeItem[] Manifestation { get; set; }
    }

    public class bodyreactionInputItemManifestationTypeItem
    {
        [JsonProperty("coding")]
        public bodyreactionInputItemManifestationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodyreactionInputItemManifestationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAllergyIntoleranceIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAllergyIntoleranceIDResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public GETAllergyIntoleranceIDResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GETAllergyIntoleranceIDResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public GETAllergyIntoleranceIDResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public GETAllergyIntoleranceIDResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class GETAllergyIntoleranceIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAllergyIntoleranceIDResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceIDResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAllergyIntoleranceIDResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAllergyIntoleranceIDResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceIDResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAllergyIntoleranceIDResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAllergyIntoleranceIDResponseCodeType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETAllergyIntoleranceIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAllergyIntoleranceIDResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAllergyIntoleranceIDResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public DELETEAllergyIntoleranceIDResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DELETEAllergyIntoleranceIDResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public DELETEAllergyIntoleranceIDResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public DELETEAllergyIntoleranceIDResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public DELETEAllergyIntoleranceIDResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public DELETEAllergyIntoleranceIDResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEAllergyIntoleranceIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAllergyIntoleranceIDResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyclinicalStatuscodingInputItem2
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodyverificationStatuscodingInputItem2
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAllergyIntoleranceIDResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public PUTAllergyIntoleranceIDResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PUTAllergyIntoleranceIDResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public PUTAllergyIntoleranceIDResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public PUTAllergyIntoleranceIDResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public PUTAllergyIntoleranceIDResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public PUTAllergyIntoleranceIDResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTAllergyIntoleranceIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAllergyIntoleranceIDResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETCarePlanResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETCarePlanResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETCarePlanResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETCarePlanResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETCarePlanResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETCarePlanResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETCarePlanResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETCarePlanResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETCarePlanResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("category")]
        public GETCarePlanResponseEntryTypeItemResourceTypeCategoryTypeItem[] Category { get; set; }

        [JsonProperty("subject")]
        public GETCarePlanResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETCarePlanResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GETCarePlanResponseEntryTypeItemResourceTypePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public GETCarePlanResponseEntryTypeItemResourceTypeCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public GETCarePlanResponseEntryTypeItemResourceTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public GETCarePlanResponseEntryTypeItemResourceTypeGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItem[] Activity { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETCarePlanResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItem
    {
        [JsonProperty("detail")]
        public GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailType Detail { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailType
    {
        [JsonProperty("code")]
        public GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("location")]
        public GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeLocationType Location { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeLocationType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCarePlanResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTCarePlanResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTCarePlanResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTCarePlanResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public POSTCarePlanResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public POSTCarePlanResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public POSTCarePlanResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public POSTCarePlanResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public POSTCarePlanResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public POSTCarePlanResponseGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public POSTCarePlanResponseActivityTypeItem[] Activity { get; set; }
    }

    public class POSTCarePlanResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTCarePlanResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public POSTCarePlanResponseContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public POSTCarePlanResponseContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public POSTCarePlanResponseContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public POSTCarePlanResponseContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public POSTCarePlanResponseContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public POSTCarePlanResponseContainedTypeItemDescriptionType Description { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public POSTCarePlanResponseContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public POSTCarePlanResponseContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public POSTCarePlanResponseContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public POSTCarePlanResponseContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public POSTCarePlanResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTCarePlanResponseContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTCarePlanResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTCarePlanResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class POSTCarePlanResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTCarePlanResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTCarePlanResponseGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTCarePlanResponseActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public POSTCarePlanResponseActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public POSTCarePlanResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class POSTCarePlanResponseActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTCarePlanResponseActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public POSTCarePlanResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public POSTCarePlanResponseActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public POSTCarePlanResponseActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class POSTCarePlanResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public POSTCarePlanResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTCarePlanResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTCarePlanResponseActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class POSTCarePlanResponseActivityTypeItemDetailTypePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodycategoryInputItem2
    {
        [JsonProperty("coding")]
        public bodycategoryInputItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodycareTeamInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyaddressesInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyactivityInputItem
    {
        [JsonProperty("detail")]
        public bodyactivityInputItemDetailType Detail { get; set; }
    }

    public class bodyactivityInputItemDetailType
    {
        [JsonProperty("code")]
        public bodyactivityInputItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("location")]
        public bodyactivityInputItemDetailTypeLocationType Location { get; set; }
    }

    public class bodyactivityInputItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public bodyactivityInputItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodyactivityInputItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyactivityInputItemDetailTypeLocationType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCarePlanIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETCarePlanIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETCarePlanIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("category")]
        public GETCarePlanIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subject")]
        public GETCarePlanIDResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETCarePlanIDResponseEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GETCarePlanIDResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public GETCarePlanIDResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public GETCarePlanIDResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("activity")]
        public GETCarePlanIDResponseActivityTypeItem[] Activity { get; set; }
    }

    public class GETCarePlanIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETCarePlanIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETCarePlanIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETCarePlanIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCarePlanIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCarePlanIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanIDResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETCarePlanIDResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanIDResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanIDResponseActivityTypeItem
    {
        [JsonProperty("detail")]
        public GETCarePlanIDResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class GETCarePlanIDResponseActivityTypeItemDetailType
    {
        [JsonProperty("code")]
        public GETCarePlanIDResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("location")]
        public GETCarePlanIDResponseActivityTypeItemDetailTypeLocationType Location { get; set; }
    }

    public class GETCarePlanIDResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public GETCarePlanIDResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCarePlanIDResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCarePlanIDResponseActivityTypeItemDetailTypeLocationType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETECarePlanIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETECarePlanIDResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public DELETECarePlanIDResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public DELETECarePlanIDResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public DELETECarePlanIDResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public DELETECarePlanIDResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public DELETECarePlanIDResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public DELETECarePlanIDResponseGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public DELETECarePlanIDResponseActivityTypeItem[] Activity { get; set; }
    }

    public class DELETECarePlanIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETECarePlanIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public DELETECarePlanIDResponseContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DELETECarePlanIDResponseContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public DELETECarePlanIDResponseContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETECarePlanIDResponseContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public DELETECarePlanIDResponseContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public DELETECarePlanIDResponseContainedTypeItemDescriptionType Description { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public DELETECarePlanIDResponseContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public DELETECarePlanIDResponseContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public DELETECarePlanIDResponseContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public DELETECarePlanIDResponseContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public DELETECarePlanIDResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIDResponseContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETECarePlanIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DELETECarePlanIDResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETECarePlanIDResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIDResponseGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETECarePlanIDResponseActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public DELETECarePlanIDResponseActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public DELETECarePlanIDResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class DELETECarePlanIDResponseActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETECarePlanIDResponseActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public DELETECarePlanIDResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public DELETECarePlanIDResponseActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public DELETECarePlanIDResponseActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class DELETECarePlanIDResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public DELETECarePlanIDResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETECarePlanIDResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETECarePlanIDResponseActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETECarePlanIDResponseActivityTypeItemDetailTypePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodycontainedInputItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public bodycontainedInputItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public bodycontainedInputItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public bodycontainedInputItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public bodycontainedInputItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public bodycontainedInputItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public bodycontainedInputItemDescriptionType Description { get; set; }
    }

    public class bodycontainedInputItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public bodycontainedInputItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodycontainedInputItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodycontainedInputItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public bodycontainedInputItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodycontainedInputItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodycontainedInputItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodycontainedInputItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodycontainedInputItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public bodycontainedInputItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public bodycontainedInputItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class bodycontainedInputItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public bodycontainedInputItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodycontainedInputItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodycontainedInputItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodycontainedInputItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodyaddressesInputItem2
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodygoalInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyactivityInputItem2
    {
        [JsonProperty("outcomeReference")]
        public bodyactivityInputItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public bodyactivityInputItemDetailType2 Detail { get; set; }
    }

    public class bodyactivityInputItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyactivityInputItemDetailType2
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public bodyactivityInputItemDetailTypeCodeType2 Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public bodyactivityInputItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public bodyactivityInputItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class bodyactivityInputItemDetailTypeCodeType2
    {
        [JsonProperty("coding")]
        public bodyactivityInputItemDetailTypeCodeTypeCodingTypeItem2[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodyactivityInputItemDetailTypeCodeTypeCodingTypeItem2
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodyactivityInputItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class bodyactivityInputItemDetailTypePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTCarePlanIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTCarePlanIDResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PUTCarePlanIDResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public PUTCarePlanIDResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PUTCarePlanIDResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public PUTCarePlanIDResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public PUTCarePlanIDResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public PUTCarePlanIDResponseGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public PUTCarePlanIDResponseActivityTypeItem[] Activity { get; set; }
    }

    public class PUTCarePlanIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTCarePlanIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public PUTCarePlanIDResponseContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PUTCarePlanIDResponseContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public PUTCarePlanIDResponseContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTCarePlanIDResponseContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PUTCarePlanIDResponseContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public PUTCarePlanIDResponseContainedTypeItemDescriptionType Description { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public PUTCarePlanIDResponseContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public PUTCarePlanIDResponseContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public PUTCarePlanIDResponseContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public PUTCarePlanIDResponseContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public PUTCarePlanIDResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIDResponseContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTCarePlanIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class PUTCarePlanIDResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTCarePlanIDResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIDResponseGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTCarePlanIDResponseActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public PUTCarePlanIDResponseActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public PUTCarePlanIDResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class PUTCarePlanIDResponseActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTCarePlanIDResponseActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public PUTCarePlanIDResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public PUTCarePlanIDResponseActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public PUTCarePlanIDResponseActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class PUTCarePlanIDResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public PUTCarePlanIDResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTCarePlanIDResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTCarePlanIDResponseActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PUTCarePlanIDResponseActivityTypeItemDetailTypePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETConditionResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETConditionResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETConditionResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETConditionResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETConditionResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETConditionResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETConditionResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETConditionResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETConditionResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public GETConditionResponseEntryTypeItemResourceTypeClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GETConditionResponseEntryTypeItemResourceTypeVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public GETConditionResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETConditionResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETConditionResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }

        [JsonProperty("abatementDateTime")]
        public string AbatementDateTime { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeClinicalStatusType
    {
        [JsonProperty("coding")]
        public GETConditionResponseEntryTypeItemResourceTypeClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeVerificationStatusType
    {
        [JsonProperty("coding")]
        public GETConditionResponseEntryTypeItemResourceTypeVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GETConditionResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETConditionResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETConditionResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTConditionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTConditionResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTConditionResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public POSTConditionResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public POSTConditionResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public POSTConditionResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public POSTConditionResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public POSTConditionResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public POSTConditionResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public POSTConditionResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class POSTConditionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTConditionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTConditionResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public POSTConditionResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTConditionResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTConditionResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public POSTConditionResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTConditionResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTConditionResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public POSTConditionResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTConditionResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTConditionResponseSeverityType
    {
        [JsonProperty("coding")]
        public POSTConditionResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTConditionResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTConditionResponseCodeType
    {
        [JsonProperty("coding")]
        public POSTConditionResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTConditionResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTConditionResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public POSTConditionResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTConditionResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTConditionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodybodySiteInputItem
    {
        [JsonProperty("coding")]
        public bodybodySiteInputItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodybodySiteInputItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETConditionIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETConditionIDResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public GETConditionIDResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GETConditionIDResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public GETConditionIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public GETConditionIDResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public GETConditionIDResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public GETConditionIDResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public GETConditionIDResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class GETConditionIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETConditionIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETConditionIDResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public GETConditionIDResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionIDResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETConditionIDResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public GETConditionIDResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionIDResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETConditionIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETConditionIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIDResponseSeverityType
    {
        [JsonProperty("coding")]
        public GETConditionIDResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionIDResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIDResponseCodeType
    {
        [JsonProperty("coding")]
        public GETConditionIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETConditionIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIDResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public GETConditionIDResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETConditionIDResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEConditionIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEConditionIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEConditionIDResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public DELETEConditionIDResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DELETEConditionIDResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public DELETEConditionIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public DELETEConditionIDResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public DELETEConditionIDResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public DELETEConditionIDResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public DELETEConditionIDResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class DELETEConditionIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEConditionIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEConditionIDResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public DELETEConditionIDResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEConditionIDResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEConditionIDResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public DELETEConditionIDResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEConditionIDResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEConditionIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEConditionIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEConditionIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEConditionIDResponseSeverityType
    {
        [JsonProperty("coding")]
        public DELETEConditionIDResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEConditionIDResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEConditionIDResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEConditionIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEConditionIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEConditionIDResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public DELETEConditionIDResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEConditionIDResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEConditionIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTConditionIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTConditionIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTConditionIDResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public PUTConditionIDResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PUTConditionIDResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public PUTConditionIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public PUTConditionIDResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public PUTConditionIDResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public PUTConditionIDResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public PUTConditionIDResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class PUTConditionIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTConditionIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTConditionIDResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public PUTConditionIDResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTConditionIDResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTConditionIDResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public PUTConditionIDResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTConditionIDResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTConditionIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTConditionIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTConditionIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTConditionIDResponseSeverityType
    {
        [JsonProperty("coding")]
        public PUTConditionIDResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTConditionIDResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTConditionIDResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTConditionIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTConditionIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTConditionIDResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public PUTConditionIDResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTConditionIDResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTConditionIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETDiagnosticReportResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDiagnosticReportResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETDiagnosticReportResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETDiagnosticReportResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETDiagnosticReportResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDiagnosticReportResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETDiagnosticReportResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETDiagnosticReportResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDiagnosticReportResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETDiagnosticReportResponseEntryTypeItemResourceTypeCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETDiagnosticReportResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETDiagnosticReportResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETDiagnosticReportResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("result")]
        public GETDiagnosticReportResponseEntryTypeItemResourceTypeResultTypeItem[] Result { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceTypeCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETDiagnosticReportResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GETDiagnosticReportResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemResourceTypeResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTDiagnosticReportResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTDiagnosticReportResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTDiagnosticReportResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public POSTDiagnosticReportResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public POSTDiagnosticReportResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public POSTDiagnosticReportResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public POSTDiagnosticReportResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public POSTDiagnosticReportResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public POSTDiagnosticReportResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public POSTDiagnosticReportResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class POSTDiagnosticReportResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTDiagnosticReportResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTDiagnosticReportResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class POSTDiagnosticReportResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTDiagnosticReportResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public POSTDiagnosticReportResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTDiagnosticReportResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTDiagnosticReportResponseCodeType
    {
        [JsonProperty("coding")]
        public POSTDiagnosticReportResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTDiagnosticReportResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTDiagnosticReportResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTDiagnosticReportResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTDiagnosticReportResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyidentifierInputItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodybasedOnInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyperformerInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyresultInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETDiagnosticReportIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDiagnosticReportIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDiagnosticReportIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDiagnosticReportIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public GETDiagnosticReportIDResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETDiagnosticReportIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETDiagnosticReportIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETDiagnosticReportIDResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public GETDiagnosticReportIDResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public GETDiagnosticReportIDResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class GETDiagnosticReportIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDiagnosticReportIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETDiagnosticReportIDResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDiagnosticReportIDResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETDiagnosticReportIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETDiagnosticReportIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETDiagnosticReportIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportIDResponseCodeType
    {
        [JsonProperty("coding")]
        public GETDiagnosticReportIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETDiagnosticReportIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportIDResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportIDResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEDiagnosticReportIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEDiagnosticReportIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEDiagnosticReportIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEDiagnosticReportIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public DELETEDiagnosticReportIDResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DELETEDiagnosticReportIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DELETEDiagnosticReportIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEDiagnosticReportIDResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DELETEDiagnosticReportIDResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public DELETEDiagnosticReportIDResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEDiagnosticReportIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEDiagnosticReportIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEDiagnosticReportIDResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEDiagnosticReportIDResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTDiagnosticReportIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTDiagnosticReportIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTDiagnosticReportIDResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PUTDiagnosticReportIDResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public PUTDiagnosticReportIDResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTDiagnosticReportIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PUTDiagnosticReportIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTDiagnosticReportIDResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public PUTDiagnosticReportIDResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public PUTDiagnosticReportIDResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class PUTDiagnosticReportIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTDiagnosticReportIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTDiagnosticReportIDResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTDiagnosticReportIDResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTDiagnosticReportIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTDiagnosticReportIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTDiagnosticReportIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTDiagnosticReportIDResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTDiagnosticReportIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTDiagnosticReportIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTDiagnosticReportIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTDiagnosticReportIDResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTDiagnosticReportIDResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETMedicationResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETMedicationResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETMedicationResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETMedicationResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETMedicationResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETMedicationResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETMedicationResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("code")]
        public GETMedicationResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("form")]
        public GETMedicationResponseEntryTypeItemResourceTypeFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItem[] Ingredient { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeFormType
    {
        [JsonProperty("coding")]
        public GETMedicationResponseEntryTypeItemResourceTypeFormTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTMedicationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTMedicationResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTMedicationResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public POSTMedicationResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public POSTMedicationResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public POSTMedicationResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public POSTMedicationResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public POSTMedicationResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public POSTMedicationResponseBatchType Batch { get; set; }
    }

    public class POSTMedicationResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTMedicationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTMedicationResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class POSTMedicationResponseCodeType
    {
        [JsonProperty("coding")]
        public POSTMedicationResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTMedicationResponseFormType
    {
        [JsonProperty("coding")]
        public POSTMedicationResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public POSTMedicationResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public POSTMedicationResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class POSTMedicationResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public POSTMedicationResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public POSTMedicationResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public POSTMedicationResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class POSTMedicationResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class bodycontainedInputItem2
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyformcodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyingredientInputItem
    {
        [JsonProperty("itemCodeableConcept")]
        public bodyingredientInputItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public bodyingredientInputItemStrengthType Strength { get; set; }
    }

    public class bodyingredientInputItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public bodyingredientInputItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodyingredientInputItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyingredientInputItemStrengthType
    {
        [JsonProperty("numerator")]
        public bodyingredientInputItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public bodyingredientInputItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class bodyingredientInputItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodyingredientInputItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETMedicationIDResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public GETMedicationIDResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public GETMedicationIDResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public GETMedicationIDResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public GETMedicationIDResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GETMedicationIDResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public GETMedicationIDResponseBatchType Batch { get; set; }
    }

    public class GETMedicationIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETMedicationIDResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GETMedicationIDResponseCodeType
    {
        [JsonProperty("coding")]
        public GETMedicationIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationIDResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationIDResponseFormType
    {
        [JsonProperty("coding")]
        public GETMedicationIDResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationIDResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationIDResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GETMedicationIDResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public GETMedicationIDResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GETMedicationIDResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationIDResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationIDResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationIDResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GETMedicationIDResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationIDResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationIDResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationIDResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationIDResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class DELETEMedicationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEMedicationIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEMedicationIDResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public DELETEMedicationIDResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public DELETEMedicationIDResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public DELETEMedicationIDResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public DELETEMedicationIDResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public DELETEMedicationIDResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public DELETEMedicationIDResponseBatchType Batch { get; set; }
    }

    public class DELETEMedicationIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEMedicationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEMedicationIDResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DELETEMedicationIDResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEMedicationIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEMedicationIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationIDResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEMedicationIDResponseFormType
    {
        [JsonProperty("coding")]
        public DELETEMedicationIDResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEMedicationIDResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationIDResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public DELETEMedicationIDResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public DELETEMedicationIDResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class DELETEMedicationIDResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public DELETEMedicationIDResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEMedicationIDResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationIDResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public DELETEMedicationIDResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public DELETEMedicationIDResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class DELETEMedicationIDResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEMedicationIDResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEMedicationIDResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class PUTMedicationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTMedicationIDResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PUTMedicationIDResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public PUTMedicationIDResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public PUTMedicationIDResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public PUTMedicationIDResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public PUTMedicationIDResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public PUTMedicationIDResponseBatchType Batch { get; set; }
    }

    public class PUTMedicationIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTMedicationIDResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PUTMedicationIDResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTMedicationIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationIDResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationIDResponseFormType
    {
        [JsonProperty("coding")]
        public PUTMedicationIDResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationIDResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationIDResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public PUTMedicationIDResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public PUTMedicationIDResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class PUTMedicationIDResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public PUTMedicationIDResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationIDResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationIDResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public PUTMedicationIDResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PUTMedicationIDResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class PUTMedicationIDResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationIDResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationIDResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class GETMedicationRequestResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationRequestResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETMedicationRequestResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETMedicationRequestResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETMedicationRequestResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationRequestResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETMedicationRequestResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETMedicationRequestResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTMedicationRequestResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTMedicationRequestResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTMedicationRequestResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public POSTMedicationRequestResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public POSTMedicationRequestResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public POSTMedicationRequestResponseMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public POSTMedicationRequestResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public POSTMedicationRequestResponseEncounterType Encounter { get; set; }

        [JsonProperty("supportingInformation")]
        public POSTMedicationRequestResponseSupportingInformationTypeItem[] SupportingInformation { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public POSTMedicationRequestResponseRequesterType Requester { get; set; }

        [JsonProperty("reasonCode")]
        public POSTMedicationRequestResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public POSTMedicationRequestResponseNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosageInstruction")]
        public POSTMedicationRequestResponseDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("dispenseRequest")]
        public POSTMedicationRequestResponseDispenseRequestType DispenseRequest { get; set; }

        [JsonProperty("substitution")]
        public POSTMedicationRequestResponseSubstitutionType Substitution { get; set; }
    }

    public class POSTMedicationRequestResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTMedicationRequestResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTMedicationRequestResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public POSTMedicationRequestResponseContainedTypeItemCodeType Code { get; set; }
    }

    public class POSTMedicationRequestResponseContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public POSTMedicationRequestResponseContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationRequestResponseContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class POSTMedicationRequestResponseMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public POSTMedicationRequestResponseMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationRequestResponseMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseSupportingInformationTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTMedicationRequestResponseRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public POSTMedicationRequestResponseReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationRequestResponseReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("route")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemRouteType Route { get; set; }

        [JsonProperty("method")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemMethodType Method { get; set; }

        [JsonProperty("doseAndRate")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("coding")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemAdditionalInstructionTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemAdditionalInstructionTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemRouteType
    {
        [JsonProperty("coding")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemMethodType
    {
        [JsonProperty("coding")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public POSTMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationRequestResponseDispenseRequestType
    {
        [JsonProperty("validityPeriod")]
        public POSTMedicationRequestResponseDispenseRequestTypeValidityPeriodType ValidityPeriod { get; set; }

        [JsonProperty("numberOfRepeatsAllowed")]
        public int NumberOfRepeatsAllowed { get; set; }

        [JsonProperty("quantity")]
        public POSTMedicationRequestResponseDispenseRequestTypeQuantityType Quantity { get; set; }

        [JsonProperty("expectedSupplyDuration")]
        public POSTMedicationRequestResponseDispenseRequestTypeExpectedSupplyDurationType ExpectedSupplyDuration { get; set; }
    }

    public class POSTMedicationRequestResponseDispenseRequestTypeValidityPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class POSTMedicationRequestResponseDispenseRequestTypeQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationRequestResponseDispenseRequestTypeExpectedSupplyDurationType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationRequestResponseSubstitutionType
    {
        [JsonProperty("allowedBoolean")]
        public bool AllowedBoolean { get; set; }

        [JsonProperty("reason")]
        public POSTMedicationRequestResponseSubstitutionTypeReasonType Reason { get; set; }
    }

    public class POSTMedicationRequestResponseSubstitutionTypeReasonType
    {
        [JsonProperty("coding")]
        public POSTMedicationRequestResponseSubstitutionTypeReasonTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationRequestResponseSubstitutionTypeReasonTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodycontainedInputItem22
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public bodycontainedInputItemCodeType2 Code { get; set; }
    }

    public class bodycontainedInputItemCodeType2
    {
        [JsonProperty("coding")]
        public bodycontainedInputItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodycontainedInputItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodymedicationCodeableConceptcodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodysupportingInformationInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyreasonCodeInputItem
    {
        [JsonProperty("coding")]
        public bodyreasonCodeInputItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodyreasonCodeInputItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodynoteInputItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodydosageInstructionInputItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public bodydosageInstructionInputItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public bodydosageInstructionInputItemTimingType Timing { get; set; }

        [JsonProperty("route")]
        public bodydosageInstructionInputItemRouteType Route { get; set; }

        [JsonProperty("method")]
        public bodydosageInstructionInputItemMethodType Method { get; set; }

        [JsonProperty("doseAndRate")]
        public bodydosageInstructionInputItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class bodydosageInstructionInputItemAdditionalInstructionTypeItem
    {
        [JsonProperty("coding")]
        public bodydosageInstructionInputItemAdditionalInstructionTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodydosageInstructionInputItemAdditionalInstructionTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodydosageInstructionInputItemTimingType
    {
        [JsonProperty("repeat")]
        public bodydosageInstructionInputItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class bodydosageInstructionInputItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class bodydosageInstructionInputItemRouteType
    {
        [JsonProperty("coding")]
        public bodydosageInstructionInputItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodydosageInstructionInputItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodydosageInstructionInputItemMethodType
    {
        [JsonProperty("coding")]
        public bodydosageInstructionInputItemMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodydosageInstructionInputItemMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodydosageInstructionInputItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public bodydosageInstructionInputItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public bodydosageInstructionInputItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class bodydosageInstructionInputItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public bodydosageInstructionInputItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodydosageInstructionInputItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodydosageInstructionInputItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodysubstitutionreasoncodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationRequestIDResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETMedicationRequestIDResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETMedicationRequestIDResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETMedicationRequestIDResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationRequestIDResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETMedicationRequestIDResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestIDResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DELETEMedicationRequestIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEMedicationRequestIDResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public DELETEMedicationRequestIDResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public DELETEMedicationRequestIDResponseEntryTypeItem[] Entry { get; set; }
    }

    public class DELETEMedicationRequestIDResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEMedicationRequestIDResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public DELETEMedicationRequestIDResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEMedicationRequestIDResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PUTMedicationRequestIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationRequestIDResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public PUTMedicationRequestIDResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public PUTMedicationRequestIDResponseEntryTypeItem[] Entry { get; set; }
    }

    public class PUTMedicationRequestIDResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationRequestIDResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public PUTMedicationRequestIDResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationRequestIDResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETMedicationStatementResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationStatementResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETMedicationStatementResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETMedicationStatementResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETMedicationStatementResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationStatementResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETMedicationStatementResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETMedicationStatementResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTMedicationStatementResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTMedicationStatementResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public POSTMedicationStatementResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public POSTMedicationStatementResponseEntryTypeItem[] Entry { get; set; }
    }

    public class POSTMedicationStatementResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTMedicationStatementResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public POSTMedicationStatementResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public POSTMedicationStatementResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public POSTMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTMedicationStatementResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class bodyreasonReferenceInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodydosageInputItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("route")]
        public bodydosageInputItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public bodydosageInputItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public bodydosageInputItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class bodydosageInputItemRouteType
    {
        [JsonProperty("coding")]
        public bodydosageInputItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodydosageInputItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodydosageInputItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public bodydosageInputItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public bodydosageInputItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class bodydosageInputItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public bodydosageInputItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class bodydosageInputItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodydosageInputItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodydosageInputItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public bodydosageInputItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public bodydosageInputItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class bodydosageInputItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class bodydosageInputItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationStatementIDResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETMedicationStatementIDResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETMedicationStatementIDResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETMedicationStatementIDResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationStatementIDResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETMedicationStatementIDResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementIDResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PUTMedicationStatementIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationStatementIDResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public PUTMedicationStatementIDResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public PUTMedicationStatementIDResponseEntryTypeItem[] Entry { get; set; }
    }

    public class PUTMedicationStatementIDResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationStatementIDResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public PUTMedicationStatementIDResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationStatementIDResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETObservationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETObservationResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETObservationResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETObservationResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETObservationResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETObservationResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETObservationResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETObservationResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETObservationResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETObservationResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETObservationResponseEntryTypeItemResourceTypeCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETObservationResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETObservationResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETObservationResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("valueQuantity")]
        public GETObservationResponseEntryTypeItemResourceTypeValueQuantityType ValueQuantity { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceTypeCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETObservationResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GETObservationResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETObservationResponseEntryTypeItemResourceTypeValueQuantityType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETObservationResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTObservationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTObservationResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTObservationResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public POSTObservationResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public POSTObservationResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public POSTObservationResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public POSTObservationResponseEncounterType Encounter { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public POSTObservationResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public POSTObservationResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public POSTObservationResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public POSTObservationResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public POSTObservationResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public POSTObservationResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class POSTObservationResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTObservationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTObservationResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public POSTObservationResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTObservationResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTObservationResponseCodeType
    {
        [JsonProperty("coding")]
        public POSTObservationResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTObservationResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTObservationResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTObservationResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTObservationResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTObservationResponseValueQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTObservationResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public POSTObservationResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTObservationResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTObservationResponseBodySiteType
    {
        [JsonProperty("coding")]
        public POSTObservationResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTObservationResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTObservationResponseMethodType
    {
        [JsonProperty("coding")]
        public POSTObservationResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTObservationResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTObservationResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public POSTObservationResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class POSTObservationResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class bodyperformerInputItem2
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodyinterpretationInputItem
    {
        [JsonProperty("coding")]
        public bodyinterpretationInputItemCodingTypeItem[] Coding { get; set; }
    }

    public class bodyinterpretationInputItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodybodySitecodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodymethodcodingInputItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyreferenceRangeInputItem
    {
        [JsonProperty("high")]
        public bodyreferenceRangeInputItemHighType High { get; set; }
    }

    public class bodyreferenceRangeInputItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class GETObservationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETObservationIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETObservationIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETObservationIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETObservationIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETObservationIDResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public GETObservationIDResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public GETObservationIDResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public GETObservationIDResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public GETObservationIDResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public GETObservationIDResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public GETObservationIDResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class GETObservationIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETObservationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETObservationIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETObservationIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIDResponseCodeType
    {
        [JsonProperty("coding")]
        public GETObservationIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETObservationIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIDResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETObservationIDResponseValueQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETObservationIDResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public GETObservationIDResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationIDResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETObservationIDResponseBodySiteType
    {
        [JsonProperty("coding")]
        public GETObservationIDResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationIDResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIDResponseMethodType
    {
        [JsonProperty("coding")]
        public GETObservationIDResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationIDResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIDResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public GETObservationIDResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class GETObservationIDResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class DELETEObservationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEObservationIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEObservationIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DELETEObservationIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DELETEObservationIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEObservationIDResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DELETEObservationIDResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public DELETEObservationIDResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public DELETEObservationIDResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public DELETEObservationIDResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public DELETEObservationIDResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public DELETEObservationIDResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class DELETEObservationIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEObservationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEObservationIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEObservationIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEObservationIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIDResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEObservationIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEObservationIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIDResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEObservationIDResponseValueQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEObservationIDResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public DELETEObservationIDResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEObservationIDResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEObservationIDResponseBodySiteType
    {
        [JsonProperty("coding")]
        public DELETEObservationIDResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEObservationIDResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIDResponseMethodType
    {
        [JsonProperty("coding")]
        public DELETEObservationIDResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEObservationIDResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIDResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public DELETEObservationIDResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class DELETEObservationIDResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class PUTObservationIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTObservationIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTObservationIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTObservationIDResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PUTObservationIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTObservationIDResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public PUTObservationIDResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public PUTObservationIDResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public PUTObservationIDResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public PUTObservationIDResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public PUTObservationIDResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public PUTObservationIDResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class PUTObservationIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTObservationIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTObservationIDResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTObservationIDResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTObservationIDResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIDResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTObservationIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTObservationIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIDResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTObservationIDResponseValueQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTObservationIDResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public PUTObservationIDResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTObservationIDResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTObservationIDResponseBodySiteType
    {
        [JsonProperty("coding")]
        public PUTObservationIDResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTObservationIDResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIDResponseMethodType
    {
        [JsonProperty("coding")]
        public PUTObservationIDResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTObservationIDResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIDResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public PUTObservationIDResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class PUTObservationIDResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class GETProcedureResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETProcedureResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETProcedureResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETProcedureResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETProcedureResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETProcedureResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETProcedureResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETProcedureResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETProcedureResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETProcedureResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public GETProcedureResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETProcedureResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETProcedureResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("performedPeriod")]
        public GETProcedureResponseEntryTypeItemResourceTypePerformedPeriodType PerformedPeriod { get; set; }

        [JsonProperty("reasonReference")]
        public GETProcedureResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GETProcedureResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemResourceTypePerformedPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETProcedureResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTProcedureResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTProcedureResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTProcedureResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public POSTProcedureResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public POSTProcedureResponseSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public POSTProcedureResponseRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public POSTProcedureResponseAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public POSTProcedureResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public POSTProcedureResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public POSTProcedureResponseFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public POSTProcedureResponseNoteTypeItem[] Note { get; set; }
    }

    public class POSTProcedureResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTProcedureResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTProcedureResponseCodeType
    {
        [JsonProperty("coding")]
        public POSTProcedureResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTProcedureResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTProcedureResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTProcedureResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTProcedureResponseAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTProcedureResponsePerformerTypeItem
    {
        [JsonProperty("actor")]
        public POSTProcedureResponsePerformerTypeItemActorType Actor { get; set; }
    }

    public class POSTProcedureResponsePerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTProcedureResponseReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTProcedureResponseFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTProcedureResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodyperformerInputItem22
    {
        [JsonProperty("actor")]
        public bodyperformerInputItemActorType Actor { get; set; }
    }

    public class bodyperformerInputItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodyreasonCodeInputItem2
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodyfollowUpInputItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETProcedureIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETProcedureIDResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public GETProcedureIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETProcedureIDResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETProcedureIDResponseEncounterType Encounter { get; set; }

        [JsonProperty("performedPeriod")]
        public GETProcedureIDResponsePerformedPeriodType PerformedPeriod { get; set; }
    }

    public class GETProcedureIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETProcedureIDResponseCodeType
    {
        [JsonProperty("coding")]
        public GETProcedureIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETProcedureIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETProcedureIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETProcedureIDResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETProcedureIDResponsePerformedPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETEProcedureIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEProcedureIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEProcedureIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public DELETEProcedureIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEProcedureIDResponseSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public DELETEProcedureIDResponseRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public DELETEProcedureIDResponseAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public DELETEProcedureIDResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public DELETEProcedureIDResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public DELETEProcedureIDResponseFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public DELETEProcedureIDResponseNoteTypeItem[] Note { get; set; }
    }

    public class DELETEProcedureIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEProcedureIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEProcedureIDResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEProcedureIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEProcedureIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEProcedureIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEProcedureIDResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEProcedureIDResponseAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEProcedureIDResponsePerformerTypeItem
    {
        [JsonProperty("actor")]
        public DELETEProcedureIDResponsePerformerTypeItemActorType Actor { get; set; }
    }

    public class DELETEProcedureIDResponsePerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEProcedureIDResponseReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEProcedureIDResponseFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEProcedureIDResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTProcedureIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTProcedureIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTProcedureIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public PUTProcedureIDResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTProcedureIDResponseSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public PUTProcedureIDResponseRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public PUTProcedureIDResponseAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public PUTProcedureIDResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public PUTProcedureIDResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public PUTProcedureIDResponseFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public PUTProcedureIDResponseNoteTypeItem[] Note { get; set; }
    }

    public class PUTProcedureIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTProcedureIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTProcedureIDResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTProcedureIDResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTProcedureIDResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTProcedureIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTProcedureIDResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTProcedureIDResponseAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTProcedureIDResponsePerformerTypeItem
    {
        [JsonProperty("actor")]
        public PUTProcedureIDResponsePerformerTypeItemActorType Actor { get; set; }
    }

    public class PUTProcedureIDResponsePerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTProcedureIDResponseReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTProcedureIDResponseFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTProcedureIDResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETRiskAssessmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETRiskAssessmentResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETRiskAssessmentResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public GETRiskAssessmentResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public GETRiskAssessmentResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public GETRiskAssessmentResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public GETRiskAssessmentResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public GETRiskAssessmentResponseNoteTypeItem[] Note { get; set; }
    }

    public class GETRiskAssessmentResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETRiskAssessmentResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETRiskAssessmentResponseMethodType
    {
        [JsonProperty("coding")]
        public GETRiskAssessmentResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETRiskAssessmentResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETRiskAssessmentResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETRiskAssessmentResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETRiskAssessmentResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public GETRiskAssessmentResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public GETRiskAssessmentResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class GETRiskAssessmentResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETRiskAssessmentResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public GETRiskAssessmentResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public GETRiskAssessmentResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class GETRiskAssessmentResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETRiskAssessmentResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETRiskAssessmentResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTRiskAssessmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTRiskAssessmentResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTRiskAssessmentResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public POSTRiskAssessmentResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public POSTRiskAssessmentResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public POSTRiskAssessmentResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public POSTRiskAssessmentResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public POSTRiskAssessmentResponseNoteTypeItem[] Note { get; set; }
    }

    public class POSTRiskAssessmentResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTRiskAssessmentResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class POSTRiskAssessmentResponseMethodType
    {
        [JsonProperty("coding")]
        public POSTRiskAssessmentResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class POSTRiskAssessmentResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTRiskAssessmentResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTRiskAssessmentResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTRiskAssessmentResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public POSTRiskAssessmentResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public POSTRiskAssessmentResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class POSTRiskAssessmentResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTRiskAssessmentResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public POSTRiskAssessmentResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public POSTRiskAssessmentResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class POSTRiskAssessmentResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTRiskAssessmentResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTRiskAssessmentResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodymethodcodingInputItem2
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodybasisInputItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class bodypredictionInputItem
    {
        [JsonProperty("outcome")]
        public bodypredictionInputItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public bodypredictionInputItemWhenRangeType WhenRange { get; set; }
    }

    public class bodypredictionInputItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodypredictionInputItemWhenRangeType
    {
        [JsonProperty("high")]
        public bodypredictionInputItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public bodypredictionInputItemWhenRangeTypeLowType Low { get; set; }
    }

    public class bodypredictionInputItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class bodypredictionInputItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETRiskAssessmentIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETRiskAssessmentIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETRiskAssessmentIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public GETRiskAssessmentIDResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public GETRiskAssessmentIDResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public GETRiskAssessmentIDResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public GETRiskAssessmentIDResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public GETRiskAssessmentIDResponseNoteTypeItem[] Note { get; set; }
    }

    public class GETRiskAssessmentIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETRiskAssessmentIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETRiskAssessmentIDResponseMethodType
    {
        [JsonProperty("coding")]
        public GETRiskAssessmentIDResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETRiskAssessmentIDResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETRiskAssessmentIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETRiskAssessmentIDResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETRiskAssessmentIDResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public GETRiskAssessmentIDResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public GETRiskAssessmentIDResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class GETRiskAssessmentIDResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETRiskAssessmentIDResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public GETRiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public GETRiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class GETRiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETRiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETRiskAssessmentIDResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETERiskAssessmentIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETERiskAssessmentIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETERiskAssessmentIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public DELETERiskAssessmentIDResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public DELETERiskAssessmentIDResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public DELETERiskAssessmentIDResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public DELETERiskAssessmentIDResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public DELETERiskAssessmentIDResponseNoteTypeItem[] Note { get; set; }
    }

    public class DELETERiskAssessmentIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETERiskAssessmentIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETERiskAssessmentIDResponseMethodType
    {
        [JsonProperty("coding")]
        public DELETERiskAssessmentIDResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETERiskAssessmentIDResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETERiskAssessmentIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETERiskAssessmentIDResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETERiskAssessmentIDResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public DELETERiskAssessmentIDResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public DELETERiskAssessmentIDResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class DELETERiskAssessmentIDResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETERiskAssessmentIDResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public DELETERiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public DELETERiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class DELETERiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETERiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETERiskAssessmentIDResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTRiskAssessmentIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTRiskAssessmentIDResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTRiskAssessmentIDResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public PUTRiskAssessmentIDResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public PUTRiskAssessmentIDResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public PUTRiskAssessmentIDResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public PUTRiskAssessmentIDResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public PUTRiskAssessmentIDResponseNoteTypeItem[] Note { get; set; }
    }

    public class PUTRiskAssessmentIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTRiskAssessmentIDResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTRiskAssessmentIDResponseMethodType
    {
        [JsonProperty("coding")]
        public PUTRiskAssessmentIDResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTRiskAssessmentIDResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTRiskAssessmentIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTRiskAssessmentIDResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTRiskAssessmentIDResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public PUTRiskAssessmentIDResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public PUTRiskAssessmentIDResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class PUTRiskAssessmentIDResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTRiskAssessmentIDResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public PUTRiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public PUTRiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class PUTRiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTRiskAssessmentIDResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTRiskAssessmentIDResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCareTeamResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETCareTeamResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETCareTeamResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETCareTeamResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETCareTeamResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETCareTeamResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETCareTeamResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETCareTeamResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETCareTeamResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public GETCareTeamResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETCareTeamResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GETCareTeamResponseEntryTypeItemResourceTypePeriodType Period { get; set; }

        [JsonProperty("participant")]
        public GETCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("reasonCode")]
        public GETCareTeamResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("managingOrganization")]
        public GETCareTeamResponseEntryTypeItemResourceTypeManagingOrganizationTypeItem[] ManagingOrganization { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItem
    {
        [JsonProperty("role")]
        public GETCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public GETCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemMemberType Member { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public GETCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GETCareTeamResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemResourceTypeManagingOrganizationTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETCareTeamIDResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETCareTeamIDResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public GETCareTeamIDResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETCareTeamIDResponseEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GETCareTeamIDResponsePeriodType Period { get; set; }

        [JsonProperty("participant")]
        public GETCareTeamIDResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("reasonCode")]
        public GETCareTeamIDResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("managingOrganization")]
        public GETCareTeamIDResponseManagingOrganizationTypeItem[] ManagingOrganization { get; set; }
    }

    public class GETCareTeamIDResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETCareTeamIDResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCareTeamIDResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCareTeamIDResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GETCareTeamIDResponseParticipantTypeItem
    {
        [JsonProperty("role")]
        public GETCareTeamIDResponseParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public GETCareTeamIDResponseParticipantTypeItemMemberType Member { get; set; }
    }

    public class GETCareTeamIDResponseParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public GETCareTeamIDResponseParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCareTeamIDResponseParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamIDResponseParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamIDResponseReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GETCareTeamIDResponseReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCareTeamIDResponseReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamIDResponseManagingOrganizationTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fhirclinical;

    public partial class WorkflowManagedActions
    {
        public FhirclinicalActions Fhirclinical(string connectionId) => new FhirclinicalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FhirclinicalTriggers Fhirclinical(string connectionId) => new FhirclinicalTriggers(connectionId);
    }
}