//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fhirclinical
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FhirclinicalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETAdverseEventResponse, ApiConnectionActionConfiguration> GETAdverseEvent(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETAdverseEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AdverseEvent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETAdverseEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTAdverseEventResponse, ApiConnectionActionConfiguration> POSTAdverseEvent(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyidentifiersystem = null, Expression<Func<string>> bodyidentifiervalue = null, Expression<Func<string>> bodyactuality = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodyEventcodingInputItem[]>> bodyEventcoding = null, Expression<Func<string>> bodyEventtext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodydate = null, Expression<Func<bodyseriousnesscodingInputItem[]>> bodyseriousnesscoding = null, Expression<Func<bodyseveritycodingInputItem[]>> bodyseveritycoding = null, Expression<Func<string>> bodyrecorderreference = null, Expression<Func<bodysuspectEntityInputItem[]>> bodysuspectEntity = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyidentifiersystem = WorkflowExpression.Compile(bodyidentifiersystem, nameof(bodyidentifiersystem), required: false);
            var __workflow_bodyidentifiervalue = WorkflowExpression.Compile(bodyidentifiervalue, nameof(bodyidentifiervalue), required: false);
            var __workflow_bodyactuality = WorkflowExpression.Compile(bodyactuality, nameof(bodyactuality), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyEventcoding = WorkflowExpression.Compile(bodyEventcoding, nameof(bodyEventcoding), required: false);
            var __workflow_bodyEventtext = WorkflowExpression.Compile(bodyEventtext, nameof(bodyEventtext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyseriousnesscoding = WorkflowExpression.Compile(bodyseriousnesscoding, nameof(bodyseriousnesscoding), required: false);
            var __workflow_bodyseveritycoding = WorkflowExpression.Compile(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            var __workflow_bodyrecorderreference = WorkflowExpression.Compile(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            var __workflow_bodysuspectEntity = WorkflowExpression.Compile(bodysuspectEntity, nameof(bodysuspectEntity), required: false);
            return new DeferredBodyAction<POSTAdverseEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AdverseEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var identifierObject = new JObject();
                var identifierObjectpropCount = 0;
                if (__workflow_bodyidentifiersystem != null)
                {
                    identifierObject["system"] = ExpressionConverter.ConvertO(__workflow_bodyidentifiersystem);
                    identifierObjectpropCount++;
                }

                if (__workflow_bodyidentifiervalue != null)
                {
                    identifierObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyidentifiervalue);
                    identifierObjectpropCount++;
                }

                if (identifierObjectpropCount > 0)
                {
                    body["identifier"] = identifierObject;
                    bodypropCount++;
                }

                if (__workflow_bodyactuality != null)
                {
                    body["actuality"] = ExpressionConverter.ConvertO(__workflow_bodyactuality);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (__workflow_bodyEventcoding != null)
                {
                    @eventObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyEventcoding);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodyEventtext != null)
                {
                    @eventObject["text"] = ExpressionConverter.ConvertO(__workflow_bodyEventtext);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    body["event"] = @eventObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                var seriousnessObject = new JObject();
                var seriousnessObjectpropCount = 0;
                if (__workflow_bodyseriousnesscoding != null)
                {
                    seriousnessObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseriousnesscoding);
                    seriousnessObjectpropCount++;
                }

                if (seriousnessObjectpropCount > 0)
                {
                    body["seriousness"] = seriousnessObject;
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (__workflow_bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (__workflow_bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                if (__workflow_bodysuspectEntity != null)
                {
                    body["suspectEntity"] = ExpressionConverter.ConvertO(__workflow_bodysuspectEntity);
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
        public IBodyWorkflowAction<GETAdverseEventIdResponse, ApiConnectionActionConfiguration> GETAdverseEventId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETAdverseEventIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AdverseEvent/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETAdverseEventIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETEAdverseEventIdResponse, ApiConnectionActionConfiguration> DELETEAdverseEventId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodyidentifiersystem = null, Expression<Func<string>> bodyidentifiervalue = null, Expression<Func<string>> bodyactuality = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodyEventcodingInputItem[]>> bodyEventcoding = null, Expression<Func<string>> bodyEventtext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodydate = null, Expression<Func<bodyseriousnesscodingInputItem[]>> bodyseriousnesscoding = null, Expression<Func<bodyseveritycodingInputItem[]>> bodyseveritycoding = null, Expression<Func<string>> bodyrecorderreference = null, Expression<Func<bodysuspectEntityInputItem[]>> bodysuspectEntity = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodyidentifiersystem = WorkflowExpression.Compile(bodyidentifiersystem, nameof(bodyidentifiersystem), required: false);
            var __workflow_bodyidentifiervalue = WorkflowExpression.Compile(bodyidentifiervalue, nameof(bodyidentifiervalue), required: false);
            var __workflow_bodyactuality = WorkflowExpression.Compile(bodyactuality, nameof(bodyactuality), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyEventcoding = WorkflowExpression.Compile(bodyEventcoding, nameof(bodyEventcoding), required: false);
            var __workflow_bodyEventtext = WorkflowExpression.Compile(bodyEventtext, nameof(bodyEventtext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyseriousnesscoding = WorkflowExpression.Compile(bodyseriousnesscoding, nameof(bodyseriousnesscoding), required: false);
            var __workflow_bodyseveritycoding = WorkflowExpression.Compile(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            var __workflow_bodyrecorderreference = WorkflowExpression.Compile(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            var __workflow_bodysuspectEntity = WorkflowExpression.Compile(bodysuspectEntity, nameof(bodysuspectEntity), required: false);
            return new DeferredBodyAction<DELETEAdverseEventIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AdverseEvent/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var identifierObject = new JObject();
                var identifierObjectpropCount = 0;
                if (__workflow_bodyidentifiersystem != null)
                {
                    identifierObject["system"] = ExpressionConverter.ConvertO(__workflow_bodyidentifiersystem);
                    identifierObjectpropCount++;
                }

                if (__workflow_bodyidentifiervalue != null)
                {
                    identifierObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyidentifiervalue);
                    identifierObjectpropCount++;
                }

                if (identifierObjectpropCount > 0)
                {
                    body["identifier"] = identifierObject;
                    bodypropCount++;
                }

                if (__workflow_bodyactuality != null)
                {
                    body["actuality"] = ExpressionConverter.ConvertO(__workflow_bodyactuality);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (__workflow_bodyEventcoding != null)
                {
                    @eventObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyEventcoding);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodyEventtext != null)
                {
                    @eventObject["text"] = ExpressionConverter.ConvertO(__workflow_bodyEventtext);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    body["event"] = @eventObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                var seriousnessObject = new JObject();
                var seriousnessObjectpropCount = 0;
                if (__workflow_bodyseriousnesscoding != null)
                {
                    seriousnessObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseriousnesscoding);
                    seriousnessObjectpropCount++;
                }

                if (seriousnessObjectpropCount > 0)
                {
                    body["seriousness"] = seriousnessObject;
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (__workflow_bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (__workflow_bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                if (__workflow_bodysuspectEntity != null)
                {
                    body["suspectEntity"] = ExpressionConverter.ConvertO(__workflow_bodysuspectEntity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEAdverseEventIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTAdverseEventIdResponse, ApiConnectionActionConfiguration> PUTAdverseEventId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodyidentifiersystem = null, Expression<Func<string>> bodyidentifiervalue = null, Expression<Func<string>> bodyactuality = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodyEventcodingInputItem[]>> bodyEventcoding = null, Expression<Func<string>> bodyEventtext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodydate = null, Expression<Func<bodyseriousnesscodingInputItem[]>> bodyseriousnesscoding = null, Expression<Func<bodyseveritycodingInputItem[]>> bodyseveritycoding = null, Expression<Func<string>> bodyrecorderreference = null, Expression<Func<bodysuspectEntityInputItem[]>> bodysuspectEntity = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodyidentifiersystem = WorkflowExpression.Compile(bodyidentifiersystem, nameof(bodyidentifiersystem), required: false);
            var __workflow_bodyidentifiervalue = WorkflowExpression.Compile(bodyidentifiervalue, nameof(bodyidentifiervalue), required: false);
            var __workflow_bodyactuality = WorkflowExpression.Compile(bodyactuality, nameof(bodyactuality), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyEventcoding = WorkflowExpression.Compile(bodyEventcoding, nameof(bodyEventcoding), required: false);
            var __workflow_bodyEventtext = WorkflowExpression.Compile(bodyEventtext, nameof(bodyEventtext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyseriousnesscoding = WorkflowExpression.Compile(bodyseriousnesscoding, nameof(bodyseriousnesscoding), required: false);
            var __workflow_bodyseveritycoding = WorkflowExpression.Compile(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            var __workflow_bodyrecorderreference = WorkflowExpression.Compile(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            var __workflow_bodysuspectEntity = WorkflowExpression.Compile(bodysuspectEntity, nameof(bodysuspectEntity), required: false);
            return new DeferredBodyAction<PUTAdverseEventIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AdverseEvent/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var identifierObject = new JObject();
                var identifierObjectpropCount = 0;
                if (__workflow_bodyidentifiersystem != null)
                {
                    identifierObject["system"] = ExpressionConverter.ConvertO(__workflow_bodyidentifiersystem);
                    identifierObjectpropCount++;
                }

                if (__workflow_bodyidentifiervalue != null)
                {
                    identifierObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyidentifiervalue);
                    identifierObjectpropCount++;
                }

                if (identifierObjectpropCount > 0)
                {
                    body["identifier"] = identifierObject;
                    bodypropCount++;
                }

                if (__workflow_bodyactuality != null)
                {
                    body["actuality"] = ExpressionConverter.ConvertO(__workflow_bodyactuality);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var @eventObject = new JObject();
                var @eventObjectpropCount = 0;
                if (__workflow_bodyEventcoding != null)
                {
                    @eventObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyEventcoding);
                    @eventObjectpropCount++;
                }

                if (__workflow_bodyEventtext != null)
                {
                    @eventObject["text"] = ExpressionConverter.ConvertO(__workflow_bodyEventtext);
                    @eventObjectpropCount++;
                }

                if (@eventObjectpropCount > 0)
                {
                    body["event"] = @eventObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                var seriousnessObject = new JObject();
                var seriousnessObjectpropCount = 0;
                if (__workflow_bodyseriousnesscoding != null)
                {
                    seriousnessObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseriousnesscoding);
                    seriousnessObjectpropCount++;
                }

                if (seriousnessObjectpropCount > 0)
                {
                    body["seriousness"] = seriousnessObject;
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (__workflow_bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (__workflow_bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                if (__workflow_bodysuspectEntity != null)
                {
                    body["suspectEntity"] = ExpressionConverter.ConvertO(__workflow_bodysuspectEntity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTAdverseEventIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETAllergyIntoleranceResponse, ApiConnectionActionConfiguration> GETAllergyIntolerance(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETAllergyIntoleranceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AllergyIntolerance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETAllergyIntoleranceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTAllergyIntoleranceResponse, ApiConnectionActionConfiguration> POSTAllergyIntolerance(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodyclinicalStatuscodingInputItem[]>> bodyclinicalStatuscoding = null, Expression<Func<bodyverificationStatuscodingInputItem[]>> bodyverificationStatuscoding = null, Expression<Func<string>> bodytype = null, Expression<Func<string[]>> bodycategory = null, Expression<Func<string>> bodycriticality = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodypatientreference = null, Expression<Func<string>> bodyrecordedDate = null, Expression<Func<string>> bodyrecorderreference = null, Expression<Func<bodyreactionInputItem[]>> bodyreaction = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodyclinicalStatuscoding = WorkflowExpression.Compile(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            var __workflow_bodyverificationStatuscoding = WorkflowExpression.Compile(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycriticality = WorkflowExpression.Compile(bodycriticality, nameof(bodycriticality), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodypatientreference = WorkflowExpression.Compile(bodypatientreference, nameof(bodypatientreference), required: false);
            var __workflow_bodyrecordedDate = WorkflowExpression.Compile(bodyrecordedDate, nameof(bodyrecordedDate), required: false);
            var __workflow_bodyrecorderreference = WorkflowExpression.Compile(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            var __workflow_bodyreaction = WorkflowExpression.Compile(bodyreaction, nameof(bodyreaction), required: false);
            return new DeferredBodyAction<POSTAllergyIntoleranceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AllergyIntolerance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (__workflow_bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (__workflow_bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodycriticality != null)
                {
                    body["criticality"] = ExpressionConverter.ConvertO(__workflow_bodycriticality);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var patientObject = new JObject();
                var patientObjectpropCount = 0;
                if (__workflow_bodypatientreference != null)
                {
                    patientObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodypatientreference);
                    patientObjectpropCount++;
                }

                if (patientObjectpropCount > 0)
                {
                    body["patient"] = patientObject;
                    bodypropCount++;
                }

                if (__workflow_bodyrecordedDate != null)
                {
                    body["recordedDate"] = ExpressionConverter.ConvertO(__workflow_bodyrecordedDate);
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (__workflow_bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreaction != null)
                {
                    body["reaction"] = ExpressionConverter.ConvertO(__workflow_bodyreaction);
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
        public IBodyWorkflowAction<GETAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration> GETAllergyIntoleranceId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AllergyIntolerance/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETAllergyIntoleranceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETEAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration> DELETEAllergyIntoleranceId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<bodyclinicalStatuscodingInputItem2[]>> bodyclinicalStatuscoding = null, Expression<Func<bodyverificationStatuscodingInputItem2[]>> bodyverificationStatuscoding = null, Expression<Func<string>> bodytype = null, Expression<Func<string[]>> bodycategory = null, Expression<Func<string>> bodycriticality = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodypatientreference = null, Expression<Func<string>> bodyrecordedDate = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodyclinicalStatuscoding = WorkflowExpression.Compile(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            var __workflow_bodyverificationStatuscoding = WorkflowExpression.Compile(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycriticality = WorkflowExpression.Compile(bodycriticality, nameof(bodycriticality), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodypatientreference = WorkflowExpression.Compile(bodypatientreference, nameof(bodypatientreference), required: false);
            var __workflow_bodyrecordedDate = WorkflowExpression.Compile(bodyrecordedDate, nameof(bodyrecordedDate), required: false);
            return new DeferredBodyAction<DELETEAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AllergyIntolerance/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (__workflow_bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (__workflow_bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodycriticality != null)
                {
                    body["criticality"] = ExpressionConverter.ConvertO(__workflow_bodycriticality);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var patientObject = new JObject();
                var patientObjectpropCount = 0;
                if (__workflow_bodypatientreference != null)
                {
                    patientObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodypatientreference);
                    patientObjectpropCount++;
                }

                if (patientObjectpropCount > 0)
                {
                    body["patient"] = patientObject;
                    bodypropCount++;
                }

                if (__workflow_bodyrecordedDate != null)
                {
                    body["recordedDate"] = ExpressionConverter.ConvertO(__workflow_bodyrecordedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEAllergyIntoleranceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration> PUTAllergyIntoleranceId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<bodyclinicalStatuscodingInputItem2[]>> bodyclinicalStatuscoding = null, Expression<Func<bodyverificationStatuscodingInputItem2[]>> bodyverificationStatuscoding = null, Expression<Func<string>> bodytype = null, Expression<Func<string[]>> bodycategory = null, Expression<Func<string>> bodycriticality = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodypatientreference = null, Expression<Func<string>> bodyrecordedDate = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodyclinicalStatuscoding = WorkflowExpression.Compile(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            var __workflow_bodyverificationStatuscoding = WorkflowExpression.Compile(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycriticality = WorkflowExpression.Compile(bodycriticality, nameof(bodycriticality), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodypatientreference = WorkflowExpression.Compile(bodypatientreference, nameof(bodypatientreference), required: false);
            var __workflow_bodyrecordedDate = WorkflowExpression.Compile(bodyrecordedDate, nameof(bodyrecordedDate), required: false);
            return new DeferredBodyAction<PUTAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AllergyIntolerance/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (__workflow_bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (__workflow_bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodycriticality != null)
                {
                    body["criticality"] = ExpressionConverter.ConvertO(__workflow_bodycriticality);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var patientObject = new JObject();
                var patientObjectpropCount = 0;
                if (__workflow_bodypatientreference != null)
                {
                    patientObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodypatientreference);
                    patientObjectpropCount++;
                }

                if (patientObjectpropCount > 0)
                {
                    body["patient"] = patientObject;
                    bodypropCount++;
                }

                if (__workflow_bodyrecordedDate != null)
                {
                    body["recordedDate"] = ExpressionConverter.ConvertO(__workflow_bodyrecordedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTAllergyIntoleranceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETCarePlanResponse, ApiConnectionActionConfiguration> GETCarePlan(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETCarePlanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CarePlan";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETCarePlanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTCarePlanResponse, ApiConnectionActionConfiguration> POSTCarePlan(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyintent = null, Expression<Func<bodycategoryInputItem2[]>> bodycategory = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyencounterreference = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<string>> bodyperiodend = null, Expression<Func<bodycareTeamInputItem[]>> bodycareTeam = null, Expression<Func<bodyaddressesInputItem[]>> bodyaddresses = null, Expression<Func<bodyactivityInputItem[]>> bodyactivity = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyintent = WorkflowExpression.Compile(bodyintent, nameof(bodyintent), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyencounterreference = WorkflowExpression.Compile(bodyencounterreference, nameof(bodyencounterreference), required: false);
            var __workflow_bodyperiodstart = WorkflowExpression.Compile(bodyperiodstart, nameof(bodyperiodstart), required: false);
            var __workflow_bodyperiodend = WorkflowExpression.Compile(bodyperiodend, nameof(bodyperiodend), required: false);
            var __workflow_bodycareTeam = WorkflowExpression.Compile(bodycareTeam, nameof(bodycareTeam), required: false);
            var __workflow_bodyaddresses = WorkflowExpression.Compile(bodyaddresses, nameof(bodyaddresses), required: false);
            var __workflow_bodyactivity = WorkflowExpression.Compile(bodyactivity, nameof(bodyactivity), required: false);
            return new DeferredBodyAction<POSTCarePlanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CarePlan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(__workflow_bodyintent);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (__workflow_bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (__workflow_bodyperiodstart != null)
                {
                    periodObject["start"] = ExpressionConverter.ConvertO(__workflow_bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (__workflow_bodyperiodend != null)
                {
                    periodObject["end"] = ExpressionConverter.ConvertO(__workflow_bodyperiodend);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                if (__workflow_bodycareTeam != null)
                {
                    body["careTeam"] = ExpressionConverter.ConvertO(__workflow_bodycareTeam);
                    bodypropCount++;
                }

                if (__workflow_bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(__workflow_bodyaddresses);
                    bodypropCount++;
                }

                if (__workflow_bodyactivity != null)
                {
                    body["activity"] = ExpressionConverter.ConvertO(__workflow_bodyactivity);
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
        public IBodyWorkflowAction<GETCarePlanIdResponse, ApiConnectionActionConfiguration> GETCarePlanId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETCarePlanIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/CarePlan/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETCarePlanIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETECarePlanIdResponse, ApiConnectionActionConfiguration> DELETECarePlanId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodycontainedInputItem[]>> bodycontained = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyintent = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<bodycareTeamInputItem[]>> bodycareTeam = null, Expression<Func<bodyaddressesInputItem2[]>> bodyaddresses = null, Expression<Func<bodygoalInputItem[]>> bodygoal = null, Expression<Func<bodyactivityInputItem2[]>> bodyactivity = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodycontained = WorkflowExpression.Compile(bodycontained, nameof(bodycontained), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyintent = WorkflowExpression.Compile(bodyintent, nameof(bodyintent), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyperiodstart = WorkflowExpression.Compile(bodyperiodstart, nameof(bodyperiodstart), required: false);
            var __workflow_bodycareTeam = WorkflowExpression.Compile(bodycareTeam, nameof(bodycareTeam), required: false);
            var __workflow_bodyaddresses = WorkflowExpression.Compile(bodyaddresses, nameof(bodyaddresses), required: false);
            var __workflow_bodygoal = WorkflowExpression.Compile(bodygoal, nameof(bodygoal), required: false);
            var __workflow_bodyactivity = WorkflowExpression.Compile(bodyactivity, nameof(bodyactivity), required: false);
            return new DeferredBodyAction<DELETECarePlanIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/CarePlan/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(__workflow_bodycontained);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(__workflow_bodyintent);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (__workflow_bodyperiodstart != null)
                {
                    periodObject["start"] = ExpressionConverter.ConvertO(__workflow_bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                if (__workflow_bodycareTeam != null)
                {
                    body["careTeam"] = ExpressionConverter.ConvertO(__workflow_bodycareTeam);
                    bodypropCount++;
                }

                if (__workflow_bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(__workflow_bodyaddresses);
                    bodypropCount++;
                }

                if (__workflow_bodygoal != null)
                {
                    body["goal"] = ExpressionConverter.ConvertO(__workflow_bodygoal);
                    bodypropCount++;
                }

                if (__workflow_bodyactivity != null)
                {
                    body["activity"] = ExpressionConverter.ConvertO(__workflow_bodyactivity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETECarePlanIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTCarePlanIdResponse, ApiConnectionActionConfiguration> PUTCarePlanId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodycontainedInputItem[]>> bodycontained = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyintent = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyperiodstart = null, Expression<Func<bodycareTeamInputItem[]>> bodycareTeam = null, Expression<Func<bodyaddressesInputItem2[]>> bodyaddresses = null, Expression<Func<bodygoalInputItem[]>> bodygoal = null, Expression<Func<bodyactivityInputItem2[]>> bodyactivity = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodycontained = WorkflowExpression.Compile(bodycontained, nameof(bodycontained), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyintent = WorkflowExpression.Compile(bodyintent, nameof(bodyintent), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyperiodstart = WorkflowExpression.Compile(bodyperiodstart, nameof(bodyperiodstart), required: false);
            var __workflow_bodycareTeam = WorkflowExpression.Compile(bodycareTeam, nameof(bodycareTeam), required: false);
            var __workflow_bodyaddresses = WorkflowExpression.Compile(bodyaddresses, nameof(bodyaddresses), required: false);
            var __workflow_bodygoal = WorkflowExpression.Compile(bodygoal, nameof(bodygoal), required: false);
            var __workflow_bodyactivity = WorkflowExpression.Compile(bodyactivity, nameof(bodyactivity), required: false);
            return new DeferredBodyAction<PUTCarePlanIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/CarePlan/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(__workflow_bodycontained);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(__workflow_bodyintent);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var periodObject = new JObject();
                var periodObjectpropCount = 0;
                if (__workflow_bodyperiodstart != null)
                {
                    periodObject["start"] = ExpressionConverter.ConvertO(__workflow_bodyperiodstart);
                    periodObjectpropCount++;
                }

                if (periodObjectpropCount > 0)
                {
                    body["period"] = periodObject;
                    bodypropCount++;
                }

                if (__workflow_bodycareTeam != null)
                {
                    body["careTeam"] = ExpressionConverter.ConvertO(__workflow_bodycareTeam);
                    bodypropCount++;
                }

                if (__workflow_bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(__workflow_bodyaddresses);
                    bodypropCount++;
                }

                if (__workflow_bodygoal != null)
                {
                    body["goal"] = ExpressionConverter.ConvertO(__workflow_bodygoal);
                    bodypropCount++;
                }

                if (__workflow_bodyactivity != null)
                {
                    body["activity"] = ExpressionConverter.ConvertO(__workflow_bodyactivity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTCarePlanIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETConditionResponse, ApiConnectionActionConfiguration> GETCondition(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETConditionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Condition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETConditionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTConditionResponse, ApiConnectionActionConfiguration> POSTCondition(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodyclinicalStatuscodingInputItem2[]>> bodyclinicalStatuscoding = null, Expression<Func<bodyverificationStatuscodingInputItem2[]>> bodyverificationStatuscoding = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodyseveritycodingInputItem[]>> bodyseveritycoding = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<bodybodySiteInputItem[]>> bodybodySite = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyonsetDateTime = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodyclinicalStatuscoding = WorkflowExpression.Compile(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            var __workflow_bodyverificationStatuscoding = WorkflowExpression.Compile(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyseveritycoding = WorkflowExpression.Compile(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodybodySite = WorkflowExpression.Compile(bodybodySite, nameof(bodybodySite), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyonsetDateTime = WorkflowExpression.Compile(bodyonsetDateTime, nameof(bodyonsetDateTime), required: false);
            return new DeferredBodyAction<POSTConditionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Condition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (__workflow_bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (__workflow_bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (__workflow_bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (__workflow_bodybodySite != null)
                {
                    body["bodySite"] = ExpressionConverter.ConvertO(__workflow_bodybodySite);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyonsetDateTime != null)
                {
                    body["onsetDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyonsetDateTime);
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
        public IBodyWorkflowAction<GETConditionIdResponse, ApiConnectionActionConfiguration> GETConditionId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETConditionIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Condition/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETConditionIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETEConditionIdResponse, ApiConnectionActionConfiguration> DELETEConditionId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodyclinicalStatuscodingInputItem2[]>> bodyclinicalStatuscoding = null, Expression<Func<bodyverificationStatuscodingInputItem2[]>> bodyverificationStatuscoding = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodyseveritycodingInputItem[]>> bodyseveritycoding = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<bodybodySiteInputItem[]>> bodybodySite = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyonsetDateTime = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodyclinicalStatuscoding = WorkflowExpression.Compile(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            var __workflow_bodyverificationStatuscoding = WorkflowExpression.Compile(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyseveritycoding = WorkflowExpression.Compile(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodybodySite = WorkflowExpression.Compile(bodybodySite, nameof(bodybodySite), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyonsetDateTime = WorkflowExpression.Compile(bodyonsetDateTime, nameof(bodyonsetDateTime), required: false);
            return new DeferredBodyAction<DELETEConditionIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Condition/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (__workflow_bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (__workflow_bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (__workflow_bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (__workflow_bodybodySite != null)
                {
                    body["bodySite"] = ExpressionConverter.ConvertO(__workflow_bodybodySite);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyonsetDateTime != null)
                {
                    body["onsetDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyonsetDateTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEConditionIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTConditionIdResponse, ApiConnectionActionConfiguration> PUTConditionId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodyclinicalStatuscodingInputItem2[]>> bodyclinicalStatuscoding = null, Expression<Func<bodyverificationStatuscodingInputItem2[]>> bodyverificationStatuscoding = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodyseveritycodingInputItem[]>> bodyseveritycoding = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<bodybodySiteInputItem[]>> bodybodySite = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyonsetDateTime = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodyclinicalStatuscoding = WorkflowExpression.Compile(bodyclinicalStatuscoding, nameof(bodyclinicalStatuscoding), required: false);
            var __workflow_bodyverificationStatuscoding = WorkflowExpression.Compile(bodyverificationStatuscoding, nameof(bodyverificationStatuscoding), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyseveritycoding = WorkflowExpression.Compile(bodyseveritycoding, nameof(bodyseveritycoding), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodybodySite = WorkflowExpression.Compile(bodybodySite, nameof(bodybodySite), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyonsetDateTime = WorkflowExpression.Compile(bodyonsetDateTime, nameof(bodyonsetDateTime), required: false);
            return new DeferredBodyAction<PUTConditionIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Condition/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                var clinicalStatusObject = new JObject();
                var clinicalStatusObjectpropCount = 0;
                if (__workflow_bodyclinicalStatuscoding != null)
                {
                    clinicalStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyclinicalStatuscoding);
                    clinicalStatusObjectpropCount++;
                }

                if (clinicalStatusObjectpropCount > 0)
                {
                    body["clinicalStatus"] = clinicalStatusObject;
                    bodypropCount++;
                }

                var verificationStatusObject = new JObject();
                var verificationStatusObjectpropCount = 0;
                if (__workflow_bodyverificationStatuscoding != null)
                {
                    verificationStatusObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyverificationStatuscoding);
                    verificationStatusObjectpropCount++;
                }

                if (verificationStatusObjectpropCount > 0)
                {
                    body["verificationStatus"] = verificationStatusObject;
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (__workflow_bodyseveritycoding != null)
                {
                    severityObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyseveritycoding);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["severity"] = severityObject;
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (__workflow_bodybodySite != null)
                {
                    body["bodySite"] = ExpressionConverter.ConvertO(__workflow_bodybodySite);
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyonsetDateTime != null)
                {
                    body["onsetDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyonsetDateTime);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTConditionIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETDiagnosticReportResponse, ApiConnectionActionConfiguration> GETDiagnosticReport(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETDiagnosticReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DiagnosticReport";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETDiagnosticReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTDiagnosticReportResponse, ApiConnectionActionConfiguration> POSTDiagnosticReport(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<bodybasedOnInputItem[]>> bodybasedOn = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyissued = null, Expression<Func<bodyperformerInputItem[]>> bodyperformer = null, Expression<Func<bodyresultInputItem[]>> bodyresult = null, Expression<Func<string>> bodyconclusion = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodyidentifier = WorkflowExpression.Compile(bodyidentifier, nameof(bodyidentifier), required: false);
            var __workflow_bodybasedOn = WorkflowExpression.Compile(bodybasedOn, nameof(bodybasedOn), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyissued = WorkflowExpression.Compile(bodyissued, nameof(bodyissued), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyresult = WorkflowExpression.Compile(bodyresult, nameof(bodyresult), required: false);
            var __workflow_bodyconclusion = WorkflowExpression.Compile(bodyconclusion, nameof(bodyconclusion), required: false);
            return new DeferredBodyAction<POSTDiagnosticReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DiagnosticReport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(__workflow_bodyidentifier);
                    bodypropCount++;
                }

                if (__workflow_bodybasedOn != null)
                {
                    body["basedOn"] = ExpressionConverter.ConvertO(__workflow_bodybasedOn);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(__workflow_bodyissued);
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                if (__workflow_bodyresult != null)
                {
                    body["result"] = ExpressionConverter.ConvertO(__workflow_bodyresult);
                    bodypropCount++;
                }

                if (__workflow_bodyconclusion != null)
                {
                    body["conclusion"] = ExpressionConverter.ConvertO(__workflow_bodyconclusion);
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
        public IBodyWorkflowAction<GETDiagnosticReportIdResponse, ApiConnectionActionConfiguration> GETDiagnosticReportId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETDiagnosticReportIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DiagnosticReport/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETDiagnosticReportIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETEDiagnosticReportIdResponse, ApiConnectionActionConfiguration> DELETEDiagnosticReportId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<bodybasedOnInputItem[]>> bodybasedOn = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyissued = null, Expression<Func<bodyperformerInputItem[]>> bodyperformer = null, Expression<Func<bodyresultInputItem[]>> bodyresult = null, Expression<Func<string>> bodyconclusion = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodyidentifier = WorkflowExpression.Compile(bodyidentifier, nameof(bodyidentifier), required: false);
            var __workflow_bodybasedOn = WorkflowExpression.Compile(bodybasedOn, nameof(bodybasedOn), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyissued = WorkflowExpression.Compile(bodyissued, nameof(bodyissued), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyresult = WorkflowExpression.Compile(bodyresult, nameof(bodyresult), required: false);
            var __workflow_bodyconclusion = WorkflowExpression.Compile(bodyconclusion, nameof(bodyconclusion), required: false);
            return new DeferredBodyAction<DELETEDiagnosticReportIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DiagnosticReport/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(__workflow_bodyidentifier);
                    bodypropCount++;
                }

                if (__workflow_bodybasedOn != null)
                {
                    body["basedOn"] = ExpressionConverter.ConvertO(__workflow_bodybasedOn);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(__workflow_bodyissued);
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                if (__workflow_bodyresult != null)
                {
                    body["result"] = ExpressionConverter.ConvertO(__workflow_bodyresult);
                    bodypropCount++;
                }

                if (__workflow_bodyconclusion != null)
                {
                    body["conclusion"] = ExpressionConverter.ConvertO(__workflow_bodyconclusion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEDiagnosticReportIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTDiagnosticReportIdResponse, ApiConnectionActionConfiguration> PUTDiagnosticReportId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<bodybasedOnInputItem[]>> bodybasedOn = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyissued = null, Expression<Func<bodyperformerInputItem[]>> bodyperformer = null, Expression<Func<bodyresultInputItem[]>> bodyresult = null, Expression<Func<string>> bodyconclusion = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodyidentifier = WorkflowExpression.Compile(bodyidentifier, nameof(bodyidentifier), required: false);
            var __workflow_bodybasedOn = WorkflowExpression.Compile(bodybasedOn, nameof(bodybasedOn), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyissued = WorkflowExpression.Compile(bodyissued, nameof(bodyissued), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyresult = WorkflowExpression.Compile(bodyresult, nameof(bodyresult), required: false);
            var __workflow_bodyconclusion = WorkflowExpression.Compile(bodyconclusion, nameof(bodyconclusion), required: false);
            return new DeferredBodyAction<PUTDiagnosticReportIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DiagnosticReport/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(__workflow_bodyidentifier);
                    bodypropCount++;
                }

                if (__workflow_bodybasedOn != null)
                {
                    body["basedOn"] = ExpressionConverter.ConvertO(__workflow_bodybasedOn);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(__workflow_bodyissued);
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                if (__workflow_bodyresult != null)
                {
                    body["result"] = ExpressionConverter.ConvertO(__workflow_bodyresult);
                    bodypropCount++;
                }

                if (__workflow_bodyconclusion != null)
                {
                    body["conclusion"] = ExpressionConverter.ConvertO(__workflow_bodyconclusion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTDiagnosticReportIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETMedicationResponse, ApiConnectionActionConfiguration> GETMedication(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETMedicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Medication";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETMedicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTMedicationResponse, ApiConnectionActionConfiguration> POSTMedication(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodycontainedInputItem2[]>> bodycontained = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymanufacturerreference = null, Expression<Func<bodyformcodingInputItem[]>> bodyformcoding = null, Expression<Func<bodyingredientInputItem[]>> bodyingredient = null, Expression<Func<string>> bodybatchlotNumber = null, Expression<Func<string>> bodybatchexpirationDate = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodycontained = WorkflowExpression.Compile(bodycontained, nameof(bodycontained), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymanufacturerreference = WorkflowExpression.Compile(bodymanufacturerreference, nameof(bodymanufacturerreference), required: false);
            var __workflow_bodyformcoding = WorkflowExpression.Compile(bodyformcoding, nameof(bodyformcoding), required: false);
            var __workflow_bodyingredient = WorkflowExpression.Compile(bodyingredient, nameof(bodyingredient), required: false);
            var __workflow_bodybatchlotNumber = WorkflowExpression.Compile(bodybatchlotNumber, nameof(bodybatchlotNumber), required: false);
            var __workflow_bodybatchexpirationDate = WorkflowExpression.Compile(bodybatchexpirationDate, nameof(bodybatchexpirationDate), required: false);
            return new DeferredBodyAction<POSTMedicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Medication";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(__workflow_bodycontained);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (__workflow_bodymanufacturerreference != null)
                {
                    manufacturerObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodymanufacturerreference);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    body["manufacturer"] = manufacturerObject;
                    bodypropCount++;
                }

                var formObject = new JObject();
                var formObjectpropCount = 0;
                if (__workflow_bodyformcoding != null)
                {
                    formObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyformcoding);
                    formObjectpropCount++;
                }

                if (formObjectpropCount > 0)
                {
                    body["form"] = formObject;
                    bodypropCount++;
                }

                if (__workflow_bodyingredient != null)
                {
                    body["ingredient"] = ExpressionConverter.ConvertO(__workflow_bodyingredient);
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (__workflow_bodybatchlotNumber != null)
                {
                    batchObject["lotNumber"] = ExpressionConverter.ConvertO(__workflow_bodybatchlotNumber);
                    batchObjectpropCount++;
                }

                if (__workflow_bodybatchexpirationDate != null)
                {
                    batchObject["expirationDate"] = ExpressionConverter.ConvertO(__workflow_bodybatchexpirationDate);
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
        public IBodyWorkflowAction<GETMedicationIdResponse, ApiConnectionActionConfiguration> GETMedicationId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETMedicationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Medication/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETMedicationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETEMedicationIdResponse, ApiConnectionActionConfiguration> DELETEMedicationId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodycontainedInputItem2[]>> bodycontained = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymanufacturerreference = null, Expression<Func<bodyformcodingInputItem[]>> bodyformcoding = null, Expression<Func<bodyingredientInputItem[]>> bodyingredient = null, Expression<Func<string>> bodybatchlotNumber = null, Expression<Func<string>> bodybatchexpirationDate = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodycontained = WorkflowExpression.Compile(bodycontained, nameof(bodycontained), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymanufacturerreference = WorkflowExpression.Compile(bodymanufacturerreference, nameof(bodymanufacturerreference), required: false);
            var __workflow_bodyformcoding = WorkflowExpression.Compile(bodyformcoding, nameof(bodyformcoding), required: false);
            var __workflow_bodyingredient = WorkflowExpression.Compile(bodyingredient, nameof(bodyingredient), required: false);
            var __workflow_bodybatchlotNumber = WorkflowExpression.Compile(bodybatchlotNumber, nameof(bodybatchlotNumber), required: false);
            var __workflow_bodybatchexpirationDate = WorkflowExpression.Compile(bodybatchexpirationDate, nameof(bodybatchexpirationDate), required: false);
            return new DeferredBodyAction<DELETEMedicationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Medication/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(__workflow_bodycontained);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (__workflow_bodymanufacturerreference != null)
                {
                    manufacturerObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodymanufacturerreference);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    body["manufacturer"] = manufacturerObject;
                    bodypropCount++;
                }

                var formObject = new JObject();
                var formObjectpropCount = 0;
                if (__workflow_bodyformcoding != null)
                {
                    formObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyformcoding);
                    formObjectpropCount++;
                }

                if (formObjectpropCount > 0)
                {
                    body["form"] = formObject;
                    bodypropCount++;
                }

                if (__workflow_bodyingredient != null)
                {
                    body["ingredient"] = ExpressionConverter.ConvertO(__workflow_bodyingredient);
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (__workflow_bodybatchlotNumber != null)
                {
                    batchObject["lotNumber"] = ExpressionConverter.ConvertO(__workflow_bodybatchlotNumber);
                    batchObjectpropCount++;
                }

                if (__workflow_bodybatchexpirationDate != null)
                {
                    batchObject["expirationDate"] = ExpressionConverter.ConvertO(__workflow_bodybatchexpirationDate);
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

                return new ApiConnectionAction<DELETEMedicationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTMedicationIdResponse, ApiConnectionActionConfiguration> PUTMedicationId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodytextdiv = null, Expression<Func<bodycontainedInputItem2[]>> bodycontained = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymanufacturerreference = null, Expression<Func<bodyformcodingInputItem[]>> bodyformcoding = null, Expression<Func<bodyingredientInputItem[]>> bodyingredient = null, Expression<Func<string>> bodybatchlotNumber = null, Expression<Func<string>> bodybatchexpirationDate = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodytextdiv = WorkflowExpression.Compile(bodytextdiv, nameof(bodytextdiv), required: false);
            var __workflow_bodycontained = WorkflowExpression.Compile(bodycontained, nameof(bodycontained), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymanufacturerreference = WorkflowExpression.Compile(bodymanufacturerreference, nameof(bodymanufacturerreference), required: false);
            var __workflow_bodyformcoding = WorkflowExpression.Compile(bodyformcoding, nameof(bodyformcoding), required: false);
            var __workflow_bodyingredient = WorkflowExpression.Compile(bodyingredient, nameof(bodyingredient), required: false);
            var __workflow_bodybatchlotNumber = WorkflowExpression.Compile(bodybatchlotNumber, nameof(bodybatchlotNumber), required: false);
            var __workflow_bodybatchexpirationDate = WorkflowExpression.Compile(bodybatchexpirationDate, nameof(bodybatchexpirationDate), required: false);
            return new DeferredBodyAction<PUTMedicationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Medication/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (__workflow_bodytextdiv != null)
                {
                    textObject["div"] = ExpressionConverter.ConvertO(__workflow_bodytextdiv);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(__workflow_bodycontained);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var manufacturerObject = new JObject();
                var manufacturerObjectpropCount = 0;
                if (__workflow_bodymanufacturerreference != null)
                {
                    manufacturerObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodymanufacturerreference);
                    manufacturerObjectpropCount++;
                }

                if (manufacturerObjectpropCount > 0)
                {
                    body["manufacturer"] = manufacturerObject;
                    bodypropCount++;
                }

                var formObject = new JObject();
                var formObjectpropCount = 0;
                if (__workflow_bodyformcoding != null)
                {
                    formObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodyformcoding);
                    formObjectpropCount++;
                }

                if (formObjectpropCount > 0)
                {
                    body["form"] = formObject;
                    bodypropCount++;
                }

                if (__workflow_bodyingredient != null)
                {
                    body["ingredient"] = ExpressionConverter.ConvertO(__workflow_bodyingredient);
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (__workflow_bodybatchlotNumber != null)
                {
                    batchObject["lotNumber"] = ExpressionConverter.ConvertO(__workflow_bodybatchlotNumber);
                    batchObjectpropCount++;
                }

                if (__workflow_bodybatchexpirationDate != null)
                {
                    batchObject["expirationDate"] = ExpressionConverter.ConvertO(__workflow_bodybatchexpirationDate);
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

                return new ApiConnectionAction<PUTMedicationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETMedicationRequestResponse, ApiConnectionActionConfiguration> GETMedicationRequest(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETMedicationRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MedicationRequest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETMedicationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTMedicationRequestResponse, ApiConnectionActionConfiguration> POSTMedicationRequest(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodycontainedInputItem22[]>> bodycontained = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyintent = null, Expression<Func<bodymedicationCodeableConceptcodingInputItem[]>> bodymedicationCodeableConceptcoding = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyencounterreference = null, Expression<Func<string>> bodyencounterdisplay = null, Expression<Func<bodysupportingInformationInputItem[]>> bodysupportingInformation = null, Expression<Func<string>> bodyauthoredOn = null, Expression<Func<string>> bodyrequesterreference = null, Expression<Func<string>> bodyrequesterdisplay = null, Expression<Func<bodyreasonCodeInputItem[]>> bodyreasonCode = null, Expression<Func<bodynoteInputItem[]>> bodynote = null, Expression<Func<bodydosageInstructionInputItem[]>> bodydosageInstruction = null, Expression<Func<string>> bodydispenseRequestvalidityPeriodstart = null, Expression<Func<string>> bodydispenseRequestvalidityPeriodend = null, Expression<Func<int>> bodydispenseRequestnumberOfRepeatsAllowed = null, Expression<Func<int>> bodydispenseRequestquantityvalue = null, Expression<Func<string>> bodydispenseRequestquantityunit = null, Expression<Func<string>> bodydispenseRequestquantitysystem = null, Expression<Func<string>> bodydispenseRequestquantitycode = null, Expression<Func<int>> bodydispenseRequestexpectedSupplyDurationvalue = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationunit = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationsystem = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationcode = null, Expression<Func<bool>> bodysubstitutionallowedBoolean = null, Expression<Func<bodysubstitutionreasoncodingInputItem[]>> bodysubstitutionreasoncoding = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodycontained = WorkflowExpression.Compile(bodycontained, nameof(bodycontained), required: false);
            var __workflow_bodyidentifier = WorkflowExpression.Compile(bodyidentifier, nameof(bodyidentifier), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyintent = WorkflowExpression.Compile(bodyintent, nameof(bodyintent), required: false);
            var __workflow_bodymedicationCodeableConceptcoding = WorkflowExpression.Compile(bodymedicationCodeableConceptcoding, nameof(bodymedicationCodeableConceptcoding), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyencounterreference = WorkflowExpression.Compile(bodyencounterreference, nameof(bodyencounterreference), required: false);
            var __workflow_bodyencounterdisplay = WorkflowExpression.Compile(bodyencounterdisplay, nameof(bodyencounterdisplay), required: false);
            var __workflow_bodysupportingInformation = WorkflowExpression.Compile(bodysupportingInformation, nameof(bodysupportingInformation), required: false);
            var __workflow_bodyauthoredOn = WorkflowExpression.Compile(bodyauthoredOn, nameof(bodyauthoredOn), required: false);
            var __workflow_bodyrequesterreference = WorkflowExpression.Compile(bodyrequesterreference, nameof(bodyrequesterreference), required: false);
            var __workflow_bodyrequesterdisplay = WorkflowExpression.Compile(bodyrequesterdisplay, nameof(bodyrequesterdisplay), required: false);
            var __workflow_bodyreasonCode = WorkflowExpression.Compile(bodyreasonCode, nameof(bodyreasonCode), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodydosageInstruction = WorkflowExpression.Compile(bodydosageInstruction, nameof(bodydosageInstruction), required: false);
            var __workflow_bodydispenseRequestvalidityPeriodstart = WorkflowExpression.Compile(bodydispenseRequestvalidityPeriodstart, nameof(bodydispenseRequestvalidityPeriodstart), required: false);
            var __workflow_bodydispenseRequestvalidityPeriodend = WorkflowExpression.Compile(bodydispenseRequestvalidityPeriodend, nameof(bodydispenseRequestvalidityPeriodend), required: false);
            var __workflow_bodydispenseRequestnumberOfRepeatsAllowed = WorkflowExpression.Compile(bodydispenseRequestnumberOfRepeatsAllowed, nameof(bodydispenseRequestnumberOfRepeatsAllowed), required: false);
            var __workflow_bodydispenseRequestquantityvalue = WorkflowExpression.Compile(bodydispenseRequestquantityvalue, nameof(bodydispenseRequestquantityvalue), required: false);
            var __workflow_bodydispenseRequestquantityunit = WorkflowExpression.Compile(bodydispenseRequestquantityunit, nameof(bodydispenseRequestquantityunit), required: false);
            var __workflow_bodydispenseRequestquantitysystem = WorkflowExpression.Compile(bodydispenseRequestquantitysystem, nameof(bodydispenseRequestquantitysystem), required: false);
            var __workflow_bodydispenseRequestquantitycode = WorkflowExpression.Compile(bodydispenseRequestquantitycode, nameof(bodydispenseRequestquantitycode), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationvalue = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationvalue, nameof(bodydispenseRequestexpectedSupplyDurationvalue), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationunit = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationunit, nameof(bodydispenseRequestexpectedSupplyDurationunit), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationsystem = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationsystem, nameof(bodydispenseRequestexpectedSupplyDurationsystem), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationcode = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationcode, nameof(bodydispenseRequestexpectedSupplyDurationcode), required: false);
            var __workflow_bodysubstitutionallowedBoolean = WorkflowExpression.Compile(bodysubstitutionallowedBoolean, nameof(bodysubstitutionallowedBoolean), required: false);
            var __workflow_bodysubstitutionreasoncoding = WorkflowExpression.Compile(bodysubstitutionreasoncoding, nameof(bodysubstitutionreasoncoding), required: false);
            return new DeferredBodyAction<POSTMedicationRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MedicationRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(__workflow_bodycontained);
                    bodypropCount++;
                }

                if (__workflow_bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(__workflow_bodyidentifier);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(__workflow_bodyintent);
                    bodypropCount++;
                }

                var medicationCodeableConceptObject = new JObject();
                var medicationCodeableConceptObjectpropCount = 0;
                if (__workflow_bodymedicationCodeableConceptcoding != null)
                {
                    medicationCodeableConceptObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodymedicationCodeableConceptcoding);
                    medicationCodeableConceptObjectpropCount++;
                }

                if (medicationCodeableConceptObjectpropCount > 0)
                {
                    body["medicationCodeableConcept"] = medicationCodeableConceptObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (__workflow_bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (__workflow_bodyencounterdisplay != null)
                {
                    encounterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyencounterdisplay);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                if (__workflow_bodysupportingInformation != null)
                {
                    body["supportingInformation"] = ExpressionConverter.ConvertO(__workflow_bodysupportingInformation);
                    bodypropCount++;
                }

                if (__workflow_bodyauthoredOn != null)
                {
                    body["authoredOn"] = ExpressionConverter.ConvertO(__workflow_bodyauthoredOn);
                    bodypropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (__workflow_bodyrequesterreference != null)
                {
                    requesterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterreference);
                    requesterObjectpropCount++;
                }

                if (__workflow_bodyrequesterdisplay != null)
                {
                    requesterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterdisplay);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    body["requester"] = requesterObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(__workflow_bodyreasonCode);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodydosageInstruction != null)
                {
                    body["dosageInstruction"] = ExpressionConverter.ConvertO(__workflow_bodydosageInstruction);
                    bodypropCount++;
                }

                var dispenseRequestObject = new JObject();
                var dispenseRequestObjectpropCount = 0;
                var validityPeriodObject = new JObject();
                var validityPeriodObjectpropCount = 0;
                if (__workflow_bodydispenseRequestvalidityPeriodstart != null)
                {
                    validityPeriodObject["start"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestvalidityPeriodstart);
                    validityPeriodObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestvalidityPeriodend != null)
                {
                    validityPeriodObject["end"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestvalidityPeriodend);
                    validityPeriodObjectpropCount++;
                }

                if (validityPeriodObjectpropCount > 0)
                {
                    dispenseRequestObject["validityPeriod"] = validityPeriodObject;
                    dispenseRequestObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestnumberOfRepeatsAllowed != null)
                {
                    dispenseRequestObject["numberOfRepeatsAllowed"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestnumberOfRepeatsAllowed);
                    dispenseRequestObjectpropCount++;
                }

                var quantityObject = new JObject();
                var quantityObjectpropCount = 0;
                if (__workflow_bodydispenseRequestquantityvalue != null)
                {
                    quantityObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantityvalue);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantityunit != null)
                {
                    quantityObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantityunit);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantitysystem != null)
                {
                    quantityObject["system"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantitysystem);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantitycode != null)
                {
                    quantityObject["code"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantitycode);
                    quantityObjectpropCount++;
                }

                if (quantityObjectpropCount > 0)
                {
                    dispenseRequestObject["quantity"] = quantityObject;
                    dispenseRequestObjectpropCount++;
                }

                var expectedSupplyDurationObject = new JObject();
                var expectedSupplyDurationObjectpropCount = 0;
                if (__workflow_bodydispenseRequestexpectedSupplyDurationvalue != null)
                {
                    expectedSupplyDurationObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationvalue);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationunit != null)
                {
                    expectedSupplyDurationObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationunit);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationsystem != null)
                {
                    expectedSupplyDurationObject["system"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationsystem);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationcode != null)
                {
                    expectedSupplyDurationObject["code"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationcode);
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
                if (__workflow_bodysubstitutionallowedBoolean != null)
                {
                    substitutionObject["allowedBoolean"] = ExpressionConverter.ConvertO(__workflow_bodysubstitutionallowedBoolean);
                    substitutionObjectpropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (__workflow_bodysubstitutionreasoncoding != null)
                {
                    reasonObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodysubstitutionreasoncoding);
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
        public IBodyWorkflowAction<GETMedicationRequestIdResponse, ApiConnectionActionConfiguration> GETMedicationRequestId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETMedicationRequestIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationRequest/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETMedicationRequestIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETEMedicationRequestIdResponse, ApiConnectionActionConfiguration> DELETEMedicationRequestId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodycontainedInputItem22[]>> bodycontained = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyintent = null, Expression<Func<string>> bodymedicationReferencereference = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyencounterreference = null, Expression<Func<string>> bodyencounterdisplay = null, Expression<Func<bodysupportingInformationInputItem[]>> bodysupportingInformation = null, Expression<Func<string>> bodyauthoredOn = null, Expression<Func<string>> bodyrequesterreference = null, Expression<Func<string>> bodyrequesterdisplay = null, Expression<Func<bodyreasonCodeInputItem[]>> bodyreasonCode = null, Expression<Func<bodynoteInputItem[]>> bodynote = null, Expression<Func<bodydosageInstructionInputItem[]>> bodydosageInstruction = null, Expression<Func<string>> bodydispenseRequestvalidityPeriodstart = null, Expression<Func<string>> bodydispenseRequestvalidityPeriodend = null, Expression<Func<int>> bodydispenseRequestnumberOfRepeatsAllowed = null, Expression<Func<int>> bodydispenseRequestquantityvalue = null, Expression<Func<string>> bodydispenseRequestquantityunit = null, Expression<Func<string>> bodydispenseRequestquantitysystem = null, Expression<Func<string>> bodydispenseRequestquantitycode = null, Expression<Func<int>> bodydispenseRequestexpectedSupplyDurationvalue = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationunit = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationsystem = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationcode = null, Expression<Func<bool>> bodysubstitutionallowedBoolean = null, Expression<Func<bodysubstitutionreasoncodingInputItem[]>> bodysubstitutionreasoncoding = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodycontained = WorkflowExpression.Compile(bodycontained, nameof(bodycontained), required: false);
            var __workflow_bodyidentifier = WorkflowExpression.Compile(bodyidentifier, nameof(bodyidentifier), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyintent = WorkflowExpression.Compile(bodyintent, nameof(bodyintent), required: false);
            var __workflow_bodymedicationReferencereference = WorkflowExpression.Compile(bodymedicationReferencereference, nameof(bodymedicationReferencereference), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyencounterreference = WorkflowExpression.Compile(bodyencounterreference, nameof(bodyencounterreference), required: false);
            var __workflow_bodyencounterdisplay = WorkflowExpression.Compile(bodyencounterdisplay, nameof(bodyencounterdisplay), required: false);
            var __workflow_bodysupportingInformation = WorkflowExpression.Compile(bodysupportingInformation, nameof(bodysupportingInformation), required: false);
            var __workflow_bodyauthoredOn = WorkflowExpression.Compile(bodyauthoredOn, nameof(bodyauthoredOn), required: false);
            var __workflow_bodyrequesterreference = WorkflowExpression.Compile(bodyrequesterreference, nameof(bodyrequesterreference), required: false);
            var __workflow_bodyrequesterdisplay = WorkflowExpression.Compile(bodyrequesterdisplay, nameof(bodyrequesterdisplay), required: false);
            var __workflow_bodyreasonCode = WorkflowExpression.Compile(bodyreasonCode, nameof(bodyreasonCode), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodydosageInstruction = WorkflowExpression.Compile(bodydosageInstruction, nameof(bodydosageInstruction), required: false);
            var __workflow_bodydispenseRequestvalidityPeriodstart = WorkflowExpression.Compile(bodydispenseRequestvalidityPeriodstart, nameof(bodydispenseRequestvalidityPeriodstart), required: false);
            var __workflow_bodydispenseRequestvalidityPeriodend = WorkflowExpression.Compile(bodydispenseRequestvalidityPeriodend, nameof(bodydispenseRequestvalidityPeriodend), required: false);
            var __workflow_bodydispenseRequestnumberOfRepeatsAllowed = WorkflowExpression.Compile(bodydispenseRequestnumberOfRepeatsAllowed, nameof(bodydispenseRequestnumberOfRepeatsAllowed), required: false);
            var __workflow_bodydispenseRequestquantityvalue = WorkflowExpression.Compile(bodydispenseRequestquantityvalue, nameof(bodydispenseRequestquantityvalue), required: false);
            var __workflow_bodydispenseRequestquantityunit = WorkflowExpression.Compile(bodydispenseRequestquantityunit, nameof(bodydispenseRequestquantityunit), required: false);
            var __workflow_bodydispenseRequestquantitysystem = WorkflowExpression.Compile(bodydispenseRequestquantitysystem, nameof(bodydispenseRequestquantitysystem), required: false);
            var __workflow_bodydispenseRequestquantitycode = WorkflowExpression.Compile(bodydispenseRequestquantitycode, nameof(bodydispenseRequestquantitycode), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationvalue = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationvalue, nameof(bodydispenseRequestexpectedSupplyDurationvalue), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationunit = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationunit, nameof(bodydispenseRequestexpectedSupplyDurationunit), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationsystem = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationsystem, nameof(bodydispenseRequestexpectedSupplyDurationsystem), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationcode = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationcode, nameof(bodydispenseRequestexpectedSupplyDurationcode), required: false);
            var __workflow_bodysubstitutionallowedBoolean = WorkflowExpression.Compile(bodysubstitutionallowedBoolean, nameof(bodysubstitutionallowedBoolean), required: false);
            var __workflow_bodysubstitutionreasoncoding = WorkflowExpression.Compile(bodysubstitutionreasoncoding, nameof(bodysubstitutionreasoncoding), required: false);
            return new DeferredBodyAction<DELETEMedicationRequestIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationRequest/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(__workflow_bodycontained);
                    bodypropCount++;
                }

                if (__workflow_bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(__workflow_bodyidentifier);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(__workflow_bodyintent);
                    bodypropCount++;
                }

                var medicationReferenceObject = new JObject();
                var medicationReferenceObjectpropCount = 0;
                if (__workflow_bodymedicationReferencereference != null)
                {
                    medicationReferenceObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodymedicationReferencereference);
                    medicationReferenceObjectpropCount++;
                }

                if (medicationReferenceObjectpropCount > 0)
                {
                    body["medicationReference"] = medicationReferenceObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (__workflow_bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (__workflow_bodyencounterdisplay != null)
                {
                    encounterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyencounterdisplay);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                if (__workflow_bodysupportingInformation != null)
                {
                    body["supportingInformation"] = ExpressionConverter.ConvertO(__workflow_bodysupportingInformation);
                    bodypropCount++;
                }

                if (__workflow_bodyauthoredOn != null)
                {
                    body["authoredOn"] = ExpressionConverter.ConvertO(__workflow_bodyauthoredOn);
                    bodypropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (__workflow_bodyrequesterreference != null)
                {
                    requesterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterreference);
                    requesterObjectpropCount++;
                }

                if (__workflow_bodyrequesterdisplay != null)
                {
                    requesterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterdisplay);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    body["requester"] = requesterObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(__workflow_bodyreasonCode);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodydosageInstruction != null)
                {
                    body["dosageInstruction"] = ExpressionConverter.ConvertO(__workflow_bodydosageInstruction);
                    bodypropCount++;
                }

                var dispenseRequestObject = new JObject();
                var dispenseRequestObjectpropCount = 0;
                var validityPeriodObject = new JObject();
                var validityPeriodObjectpropCount = 0;
                if (__workflow_bodydispenseRequestvalidityPeriodstart != null)
                {
                    validityPeriodObject["start"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestvalidityPeriodstart);
                    validityPeriodObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestvalidityPeriodend != null)
                {
                    validityPeriodObject["end"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestvalidityPeriodend);
                    validityPeriodObjectpropCount++;
                }

                if (validityPeriodObjectpropCount > 0)
                {
                    dispenseRequestObject["validityPeriod"] = validityPeriodObject;
                    dispenseRequestObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestnumberOfRepeatsAllowed != null)
                {
                    dispenseRequestObject["numberOfRepeatsAllowed"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestnumberOfRepeatsAllowed);
                    dispenseRequestObjectpropCount++;
                }

                var quantityObject = new JObject();
                var quantityObjectpropCount = 0;
                if (__workflow_bodydispenseRequestquantityvalue != null)
                {
                    quantityObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantityvalue);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantityunit != null)
                {
                    quantityObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantityunit);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantitysystem != null)
                {
                    quantityObject["system"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantitysystem);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantitycode != null)
                {
                    quantityObject["code"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantitycode);
                    quantityObjectpropCount++;
                }

                if (quantityObjectpropCount > 0)
                {
                    dispenseRequestObject["quantity"] = quantityObject;
                    dispenseRequestObjectpropCount++;
                }

                var expectedSupplyDurationObject = new JObject();
                var expectedSupplyDurationObjectpropCount = 0;
                if (__workflow_bodydispenseRequestexpectedSupplyDurationvalue != null)
                {
                    expectedSupplyDurationObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationvalue);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationunit != null)
                {
                    expectedSupplyDurationObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationunit);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationsystem != null)
                {
                    expectedSupplyDurationObject["system"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationsystem);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationcode != null)
                {
                    expectedSupplyDurationObject["code"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationcode);
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
                if (__workflow_bodysubstitutionallowedBoolean != null)
                {
                    substitutionObject["allowedBoolean"] = ExpressionConverter.ConvertO(__workflow_bodysubstitutionallowedBoolean);
                    substitutionObjectpropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (__workflow_bodysubstitutionreasoncoding != null)
                {
                    reasonObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodysubstitutionreasoncoding);
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

                return new ApiConnectionAction<DELETEMedicationRequestIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTMedicationRequestIdResponse, ApiConnectionActionConfiguration> PUTMedicationRequestId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<bodycontainedInputItem22[]>> bodycontained = null, Expression<Func<bodyidentifierInputItem[]>> bodyidentifier = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyintent = null, Expression<Func<string>> bodymedicationReferencereference = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyencounterreference = null, Expression<Func<string>> bodyencounterdisplay = null, Expression<Func<bodysupportingInformationInputItem[]>> bodysupportingInformation = null, Expression<Func<string>> bodyauthoredOn = null, Expression<Func<string>> bodyrequesterreference = null, Expression<Func<string>> bodyrequesterdisplay = null, Expression<Func<bodyreasonCodeInputItem[]>> bodyreasonCode = null, Expression<Func<bodynoteInputItem[]>> bodynote = null, Expression<Func<bodydosageInstructionInputItem[]>> bodydosageInstruction = null, Expression<Func<string>> bodydispenseRequestvalidityPeriodstart = null, Expression<Func<string>> bodydispenseRequestvalidityPeriodend = null, Expression<Func<int>> bodydispenseRequestnumberOfRepeatsAllowed = null, Expression<Func<int>> bodydispenseRequestquantityvalue = null, Expression<Func<string>> bodydispenseRequestquantityunit = null, Expression<Func<string>> bodydispenseRequestquantitysystem = null, Expression<Func<string>> bodydispenseRequestquantitycode = null, Expression<Func<int>> bodydispenseRequestexpectedSupplyDurationvalue = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationunit = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationsystem = null, Expression<Func<string>> bodydispenseRequestexpectedSupplyDurationcode = null, Expression<Func<bool>> bodysubstitutionallowedBoolean = null, Expression<Func<bodysubstitutionreasoncodingInputItem[]>> bodysubstitutionreasoncoding = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodycontained = WorkflowExpression.Compile(bodycontained, nameof(bodycontained), required: false);
            var __workflow_bodyidentifier = WorkflowExpression.Compile(bodyidentifier, nameof(bodyidentifier), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyintent = WorkflowExpression.Compile(bodyintent, nameof(bodyintent), required: false);
            var __workflow_bodymedicationReferencereference = WorkflowExpression.Compile(bodymedicationReferencereference, nameof(bodymedicationReferencereference), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyencounterreference = WorkflowExpression.Compile(bodyencounterreference, nameof(bodyencounterreference), required: false);
            var __workflow_bodyencounterdisplay = WorkflowExpression.Compile(bodyencounterdisplay, nameof(bodyencounterdisplay), required: false);
            var __workflow_bodysupportingInformation = WorkflowExpression.Compile(bodysupportingInformation, nameof(bodysupportingInformation), required: false);
            var __workflow_bodyauthoredOn = WorkflowExpression.Compile(bodyauthoredOn, nameof(bodyauthoredOn), required: false);
            var __workflow_bodyrequesterreference = WorkflowExpression.Compile(bodyrequesterreference, nameof(bodyrequesterreference), required: false);
            var __workflow_bodyrequesterdisplay = WorkflowExpression.Compile(bodyrequesterdisplay, nameof(bodyrequesterdisplay), required: false);
            var __workflow_bodyreasonCode = WorkflowExpression.Compile(bodyreasonCode, nameof(bodyreasonCode), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodydosageInstruction = WorkflowExpression.Compile(bodydosageInstruction, nameof(bodydosageInstruction), required: false);
            var __workflow_bodydispenseRequestvalidityPeriodstart = WorkflowExpression.Compile(bodydispenseRequestvalidityPeriodstart, nameof(bodydispenseRequestvalidityPeriodstart), required: false);
            var __workflow_bodydispenseRequestvalidityPeriodend = WorkflowExpression.Compile(bodydispenseRequestvalidityPeriodend, nameof(bodydispenseRequestvalidityPeriodend), required: false);
            var __workflow_bodydispenseRequestnumberOfRepeatsAllowed = WorkflowExpression.Compile(bodydispenseRequestnumberOfRepeatsAllowed, nameof(bodydispenseRequestnumberOfRepeatsAllowed), required: false);
            var __workflow_bodydispenseRequestquantityvalue = WorkflowExpression.Compile(bodydispenseRequestquantityvalue, nameof(bodydispenseRequestquantityvalue), required: false);
            var __workflow_bodydispenseRequestquantityunit = WorkflowExpression.Compile(bodydispenseRequestquantityunit, nameof(bodydispenseRequestquantityunit), required: false);
            var __workflow_bodydispenseRequestquantitysystem = WorkflowExpression.Compile(bodydispenseRequestquantitysystem, nameof(bodydispenseRequestquantitysystem), required: false);
            var __workflow_bodydispenseRequestquantitycode = WorkflowExpression.Compile(bodydispenseRequestquantitycode, nameof(bodydispenseRequestquantitycode), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationvalue = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationvalue, nameof(bodydispenseRequestexpectedSupplyDurationvalue), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationunit = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationunit, nameof(bodydispenseRequestexpectedSupplyDurationunit), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationsystem = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationsystem, nameof(bodydispenseRequestexpectedSupplyDurationsystem), required: false);
            var __workflow_bodydispenseRequestexpectedSupplyDurationcode = WorkflowExpression.Compile(bodydispenseRequestexpectedSupplyDurationcode, nameof(bodydispenseRequestexpectedSupplyDurationcode), required: false);
            var __workflow_bodysubstitutionallowedBoolean = WorkflowExpression.Compile(bodysubstitutionallowedBoolean, nameof(bodysubstitutionallowedBoolean), required: false);
            var __workflow_bodysubstitutionreasoncoding = WorkflowExpression.Compile(bodysubstitutionreasoncoding, nameof(bodysubstitutionreasoncoding), required: false);
            return new DeferredBodyAction<PUTMedicationRequestIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationRequest/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontained != null)
                {
                    body["contained"] = ExpressionConverter.ConvertO(__workflow_bodycontained);
                    bodypropCount++;
                }

                if (__workflow_bodyidentifier != null)
                {
                    body["identifier"] = ExpressionConverter.ConvertO(__workflow_bodyidentifier);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyintent != null)
                {
                    body["intent"] = ExpressionConverter.ConvertO(__workflow_bodyintent);
                    bodypropCount++;
                }

                var medicationReferenceObject = new JObject();
                var medicationReferenceObjectpropCount = 0;
                if (__workflow_bodymedicationReferencereference != null)
                {
                    medicationReferenceObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodymedicationReferencereference);
                    medicationReferenceObjectpropCount++;
                }

                if (medicationReferenceObjectpropCount > 0)
                {
                    body["medicationReference"] = medicationReferenceObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (__workflow_bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (__workflow_bodyencounterdisplay != null)
                {
                    encounterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyencounterdisplay);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                if (__workflow_bodysupportingInformation != null)
                {
                    body["supportingInformation"] = ExpressionConverter.ConvertO(__workflow_bodysupportingInformation);
                    bodypropCount++;
                }

                if (__workflow_bodyauthoredOn != null)
                {
                    body["authoredOn"] = ExpressionConverter.ConvertO(__workflow_bodyauthoredOn);
                    bodypropCount++;
                }

                var requesterObject = new JObject();
                var requesterObjectpropCount = 0;
                if (__workflow_bodyrequesterreference != null)
                {
                    requesterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterreference);
                    requesterObjectpropCount++;
                }

                if (__workflow_bodyrequesterdisplay != null)
                {
                    requesterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyrequesterdisplay);
                    requesterObjectpropCount++;
                }

                if (requesterObjectpropCount > 0)
                {
                    body["requester"] = requesterObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(__workflow_bodyreasonCode);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodydosageInstruction != null)
                {
                    body["dosageInstruction"] = ExpressionConverter.ConvertO(__workflow_bodydosageInstruction);
                    bodypropCount++;
                }

                var dispenseRequestObject = new JObject();
                var dispenseRequestObjectpropCount = 0;
                var validityPeriodObject = new JObject();
                var validityPeriodObjectpropCount = 0;
                if (__workflow_bodydispenseRequestvalidityPeriodstart != null)
                {
                    validityPeriodObject["start"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestvalidityPeriodstart);
                    validityPeriodObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestvalidityPeriodend != null)
                {
                    validityPeriodObject["end"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestvalidityPeriodend);
                    validityPeriodObjectpropCount++;
                }

                if (validityPeriodObjectpropCount > 0)
                {
                    dispenseRequestObject["validityPeriod"] = validityPeriodObject;
                    dispenseRequestObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestnumberOfRepeatsAllowed != null)
                {
                    dispenseRequestObject["numberOfRepeatsAllowed"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestnumberOfRepeatsAllowed);
                    dispenseRequestObjectpropCount++;
                }

                var quantityObject = new JObject();
                var quantityObjectpropCount = 0;
                if (__workflow_bodydispenseRequestquantityvalue != null)
                {
                    quantityObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantityvalue);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantityunit != null)
                {
                    quantityObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantityunit);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantitysystem != null)
                {
                    quantityObject["system"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantitysystem);
                    quantityObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestquantitycode != null)
                {
                    quantityObject["code"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestquantitycode);
                    quantityObjectpropCount++;
                }

                if (quantityObjectpropCount > 0)
                {
                    dispenseRequestObject["quantity"] = quantityObject;
                    dispenseRequestObjectpropCount++;
                }

                var expectedSupplyDurationObject = new JObject();
                var expectedSupplyDurationObjectpropCount = 0;
                if (__workflow_bodydispenseRequestexpectedSupplyDurationvalue != null)
                {
                    expectedSupplyDurationObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationvalue);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationunit != null)
                {
                    expectedSupplyDurationObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationunit);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationsystem != null)
                {
                    expectedSupplyDurationObject["system"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationsystem);
                    expectedSupplyDurationObjectpropCount++;
                }

                if (__workflow_bodydispenseRequestexpectedSupplyDurationcode != null)
                {
                    expectedSupplyDurationObject["code"] = ExpressionConverter.ConvertO(__workflow_bodydispenseRequestexpectedSupplyDurationcode);
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
                if (__workflow_bodysubstitutionallowedBoolean != null)
                {
                    substitutionObject["allowedBoolean"] = ExpressionConverter.ConvertO(__workflow_bodysubstitutionallowedBoolean);
                    substitutionObjectpropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (__workflow_bodysubstitutionreasoncoding != null)
                {
                    reasonObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodysubstitutionreasoncoding);
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

                return new ApiConnectionAction<PUTMedicationRequestIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETMedicationStatementResponse, ApiConnectionActionConfiguration> GETMedicationStatement(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETMedicationStatementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MedicationStatement";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETMedicationStatementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTMedicationStatementResponse, ApiConnectionActionConfiguration> POSTMedicationStatement(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymedicationCodeableConcepttext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyeffectiveDateTime = null, Expression<Func<string>> bodydateAsserted = null, Expression<Func<string>> bodyinformationSourcereference = null, Expression<Func<string>> bodyinformationSourcedisplay = null, Expression<Func<bodyreasonReferenceInputItem[]>> bodyreasonReference = null, Expression<Func<bodynoteInputItem[]>> bodynote = null, Expression<Func<bodydosageInputItem[]>> bodydosage = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymedicationCodeableConcepttext = WorkflowExpression.Compile(bodymedicationCodeableConcepttext, nameof(bodymedicationCodeableConcepttext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyeffectiveDateTime = WorkflowExpression.Compile(bodyeffectiveDateTime, nameof(bodyeffectiveDateTime), required: false);
            var __workflow_bodydateAsserted = WorkflowExpression.Compile(bodydateAsserted, nameof(bodydateAsserted), required: false);
            var __workflow_bodyinformationSourcereference = WorkflowExpression.Compile(bodyinformationSourcereference, nameof(bodyinformationSourcereference), required: false);
            var __workflow_bodyinformationSourcedisplay = WorkflowExpression.Compile(bodyinformationSourcedisplay, nameof(bodyinformationSourcedisplay), required: false);
            var __workflow_bodyreasonReference = WorkflowExpression.Compile(bodyreasonReference, nameof(bodyreasonReference), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodydosage = WorkflowExpression.Compile(bodydosage, nameof(bodydosage), required: false);
            return new DeferredBodyAction<POSTMedicationStatementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MedicationStatement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var medicationCodeableConceptObject = new JObject();
                var medicationCodeableConceptObjectpropCount = 0;
                if (__workflow_bodymedicationCodeableConcepttext != null)
                {
                    medicationCodeableConceptObject["text"] = ExpressionConverter.ConvertO(__workflow_bodymedicationCodeableConcepttext);
                    medicationCodeableConceptObjectpropCount++;
                }

                if (medicationCodeableConceptObjectpropCount > 0)
                {
                    body["medicationCodeableConcept"] = medicationCodeableConceptObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyeffectiveDateTime != null)
                {
                    body["effectiveDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyeffectiveDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodydateAsserted != null)
                {
                    body["dateAsserted"] = ExpressionConverter.ConvertO(__workflow_bodydateAsserted);
                    bodypropCount++;
                }

                var informationSourceObject = new JObject();
                var informationSourceObjectpropCount = 0;
                if (__workflow_bodyinformationSourcereference != null)
                {
                    informationSourceObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSourcereference);
                    informationSourceObjectpropCount++;
                }

                if (__workflow_bodyinformationSourcedisplay != null)
                {
                    informationSourceObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSourcedisplay);
                    informationSourceObjectpropCount++;
                }

                if (informationSourceObjectpropCount > 0)
                {
                    body["informationSource"] = informationSourceObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreasonReference != null)
                {
                    body["reasonReference"] = ExpressionConverter.ConvertO(__workflow_bodyreasonReference);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodydosage != null)
                {
                    body["dosage"] = ExpressionConverter.ConvertO(__workflow_bodydosage);
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
        public IBodyWorkflowAction<GETMedicationStatementIdResponse, ApiConnectionActionConfiguration> GETMedicationStatementId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETMedicationStatementIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationStatement/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETMedicationStatementIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DELETEMedicationStatementId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymedicationCodeableConcepttext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyeffectiveDateTime = null, Expression<Func<string>> bodydateAsserted = null, Expression<Func<string>> bodyinformationSourcereference = null, Expression<Func<string>> bodyinformationSourcedisplay = null, Expression<Func<bodyreasonReferenceInputItem[]>> bodyreasonReference = null, Expression<Func<bodynoteInputItem[]>> bodynote = null, Expression<Func<bodydosageInputItem[]>> bodydosage = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymedicationCodeableConcepttext = WorkflowExpression.Compile(bodymedicationCodeableConcepttext, nameof(bodymedicationCodeableConcepttext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyeffectiveDateTime = WorkflowExpression.Compile(bodyeffectiveDateTime, nameof(bodyeffectiveDateTime), required: false);
            var __workflow_bodydateAsserted = WorkflowExpression.Compile(bodydateAsserted, nameof(bodydateAsserted), required: false);
            var __workflow_bodyinformationSourcereference = WorkflowExpression.Compile(bodyinformationSourcereference, nameof(bodyinformationSourcereference), required: false);
            var __workflow_bodyinformationSourcedisplay = WorkflowExpression.Compile(bodyinformationSourcedisplay, nameof(bodyinformationSourcedisplay), required: false);
            var __workflow_bodyreasonReference = WorkflowExpression.Compile(bodyreasonReference, nameof(bodyreasonReference), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodydosage = WorkflowExpression.Compile(bodydosage, nameof(bodydosage), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationStatement/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var medicationCodeableConceptObject = new JObject();
                var medicationCodeableConceptObjectpropCount = 0;
                if (__workflow_bodymedicationCodeableConcepttext != null)
                {
                    medicationCodeableConceptObject["text"] = ExpressionConverter.ConvertO(__workflow_bodymedicationCodeableConcepttext);
                    medicationCodeableConceptObjectpropCount++;
                }

                if (medicationCodeableConceptObjectpropCount > 0)
                {
                    body["medicationCodeableConcept"] = medicationCodeableConceptObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyeffectiveDateTime != null)
                {
                    body["effectiveDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyeffectiveDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodydateAsserted != null)
                {
                    body["dateAsserted"] = ExpressionConverter.ConvertO(__workflow_bodydateAsserted);
                    bodypropCount++;
                }

                var informationSourceObject = new JObject();
                var informationSourceObjectpropCount = 0;
                if (__workflow_bodyinformationSourcereference != null)
                {
                    informationSourceObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSourcereference);
                    informationSourceObjectpropCount++;
                }

                if (__workflow_bodyinformationSourcedisplay != null)
                {
                    informationSourceObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSourcedisplay);
                    informationSourceObjectpropCount++;
                }

                if (informationSourceObjectpropCount > 0)
                {
                    body["informationSource"] = informationSourceObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreasonReference != null)
                {
                    body["reasonReference"] = ExpressionConverter.ConvertO(__workflow_bodyreasonReference);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodydosage != null)
                {
                    body["dosage"] = ExpressionConverter.ConvertO(__workflow_bodydosage);
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
        public IBodyWorkflowAction<PUTMedicationStatementIdResponse, ApiConnectionActionConfiguration> PUTMedicationStatementId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodymedicationCodeableConcepttext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyeffectiveDateTime = null, Expression<Func<string>> bodydateAsserted = null, Expression<Func<string>> bodyinformationSourcereference = null, Expression<Func<string>> bodyinformationSourcedisplay = null, Expression<Func<bodyreasonReferenceInputItem[]>> bodyreasonReference = null, Expression<Func<bodynoteInputItem[]>> bodynote = null, Expression<Func<bodydosageInputItem[]>> bodydosage = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymedicationCodeableConcepttext = WorkflowExpression.Compile(bodymedicationCodeableConcepttext, nameof(bodymedicationCodeableConcepttext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyeffectiveDateTime = WorkflowExpression.Compile(bodyeffectiveDateTime, nameof(bodyeffectiveDateTime), required: false);
            var __workflow_bodydateAsserted = WorkflowExpression.Compile(bodydateAsserted, nameof(bodydateAsserted), required: false);
            var __workflow_bodyinformationSourcereference = WorkflowExpression.Compile(bodyinformationSourcereference, nameof(bodyinformationSourcereference), required: false);
            var __workflow_bodyinformationSourcedisplay = WorkflowExpression.Compile(bodyinformationSourcedisplay, nameof(bodyinformationSourcedisplay), required: false);
            var __workflow_bodyreasonReference = WorkflowExpression.Compile(bodyreasonReference, nameof(bodyreasonReference), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodydosage = WorkflowExpression.Compile(bodydosage, nameof(bodydosage), required: false);
            return new DeferredBodyAction<PUTMedicationStatementIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationStatement/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var medicationCodeableConceptObject = new JObject();
                var medicationCodeableConceptObjectpropCount = 0;
                if (__workflow_bodymedicationCodeableConcepttext != null)
                {
                    medicationCodeableConceptObject["text"] = ExpressionConverter.ConvertO(__workflow_bodymedicationCodeableConcepttext);
                    medicationCodeableConceptObjectpropCount++;
                }

                if (medicationCodeableConceptObjectpropCount > 0)
                {
                    body["medicationCodeableConcept"] = medicationCodeableConceptObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyeffectiveDateTime != null)
                {
                    body["effectiveDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyeffectiveDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodydateAsserted != null)
                {
                    body["dateAsserted"] = ExpressionConverter.ConvertO(__workflow_bodydateAsserted);
                    bodypropCount++;
                }

                var informationSourceObject = new JObject();
                var informationSourceObjectpropCount = 0;
                if (__workflow_bodyinformationSourcereference != null)
                {
                    informationSourceObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSourcereference);
                    informationSourceObjectpropCount++;
                }

                if (__workflow_bodyinformationSourcedisplay != null)
                {
                    informationSourceObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSourcedisplay);
                    informationSourceObjectpropCount++;
                }

                if (informationSourceObjectpropCount > 0)
                {
                    body["informationSource"] = informationSourceObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreasonReference != null)
                {
                    body["reasonReference"] = ExpressionConverter.ConvertO(__workflow_bodyreasonReference);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodydosage != null)
                {
                    body["dosage"] = ExpressionConverter.ConvertO(__workflow_bodydosage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTMedicationStatementIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETObservationResponse, ApiConnectionActionConfiguration> GETObservation(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null, Expression<Func<string>> encounter = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            var __workflow_encounter = WorkflowExpression.Compile(encounter, nameof(encounter), required: false);
            return new DeferredBodyAction<GETObservationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Observation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                if (__workflow_encounter != null)
                    callPayload.Queries["encounter"] = ExpressionConverter.Convert(__workflow_encounter);
                return new ApiConnectionAction<GETObservationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTObservationResponse, ApiConnectionActionConfiguration> POSTObservation(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyencounterreference = null, Expression<Func<string>> bodyissued = null, Expression<Func<bodyperformerInputItem2[]>> bodyperformer = null, Expression<Func<int>> bodyvalueQuantityvalue = null, Expression<Func<string>> bodyvalueQuantityunit = null, Expression<Func<string>> bodyvalueQuantitysystem = null, Expression<Func<string>> bodyvalueQuantitycode = null, Expression<Func<bodyinterpretationInputItem[]>> bodyinterpretation = null, Expression<Func<bodybodySitecodingInputItem[]>> bodybodySitecoding = null, Expression<Func<bodymethodcodingInputItem[]>> bodymethodcoding = null, Expression<Func<bodyreferenceRangeInputItem[]>> bodyreferenceRange = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyencounterreference = WorkflowExpression.Compile(bodyencounterreference, nameof(bodyencounterreference), required: false);
            var __workflow_bodyissued = WorkflowExpression.Compile(bodyissued, nameof(bodyissued), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyvalueQuantityvalue = WorkflowExpression.Compile(bodyvalueQuantityvalue, nameof(bodyvalueQuantityvalue), required: false);
            var __workflow_bodyvalueQuantityunit = WorkflowExpression.Compile(bodyvalueQuantityunit, nameof(bodyvalueQuantityunit), required: false);
            var __workflow_bodyvalueQuantitysystem = WorkflowExpression.Compile(bodyvalueQuantitysystem, nameof(bodyvalueQuantitysystem), required: false);
            var __workflow_bodyvalueQuantitycode = WorkflowExpression.Compile(bodyvalueQuantitycode, nameof(bodyvalueQuantitycode), required: false);
            var __workflow_bodyinterpretation = WorkflowExpression.Compile(bodyinterpretation, nameof(bodyinterpretation), required: false);
            var __workflow_bodybodySitecoding = WorkflowExpression.Compile(bodybodySitecoding, nameof(bodybodySitecoding), required: false);
            var __workflow_bodymethodcoding = WorkflowExpression.Compile(bodymethodcoding, nameof(bodymethodcoding), required: false);
            var __workflow_bodyreferenceRange = WorkflowExpression.Compile(bodyreferenceRange, nameof(bodyreferenceRange), required: false);
            return new DeferredBodyAction<POSTObservationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Observation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                var encounterObject = new JObject();
                var encounterObjectpropCount = 0;
                if (__workflow_bodyencounterreference != null)
                {
                    encounterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyencounterreference);
                    encounterObjectpropCount++;
                }

                if (encounterObjectpropCount > 0)
                {
                    body["encounter"] = encounterObject;
                    bodypropCount++;
                }

                if (__workflow_bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(__workflow_bodyissued);
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                var valueQuantityObject = new JObject();
                var valueQuantityObjectpropCount = 0;
                if (__workflow_bodyvalueQuantityvalue != null)
                {
                    valueQuantityObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantityvalue);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantityunit != null)
                {
                    valueQuantityObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantityunit);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantitysystem != null)
                {
                    valueQuantityObject["system"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantitysystem);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantitycode != null)
                {
                    valueQuantityObject["code"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantitycode);
                    valueQuantityObjectpropCount++;
                }

                if (valueQuantityObjectpropCount > 0)
                {
                    body["valueQuantity"] = valueQuantityObject;
                    bodypropCount++;
                }

                if (__workflow_bodyinterpretation != null)
                {
                    body["interpretation"] = ExpressionConverter.ConvertO(__workflow_bodyinterpretation);
                    bodypropCount++;
                }

                var bodySiteObject = new JObject();
                var bodySiteObjectpropCount = 0;
                if (__workflow_bodybodySitecoding != null)
                {
                    bodySiteObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodybodySitecoding);
                    bodySiteObjectpropCount++;
                }

                if (bodySiteObjectpropCount > 0)
                {
                    body["bodySite"] = bodySiteObject;
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (__workflow_bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceRange != null)
                {
                    body["referenceRange"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceRange);
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
        public IBodyWorkflowAction<GETObservationIdResponse, ApiConnectionActionConfiguration> GETObservationId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETObservationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Observation/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETObservationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETEObservationIdResponse, ApiConnectionActionConfiguration> DELETEObservationId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyissued = null, Expression<Func<bodyperformerInputItem2[]>> bodyperformer = null, Expression<Func<int>> bodyvalueQuantityvalue = null, Expression<Func<string>> bodyvalueQuantityunit = null, Expression<Func<string>> bodyvalueQuantitysystem = null, Expression<Func<string>> bodyvalueQuantitycode = null, Expression<Func<bodyinterpretationInputItem[]>> bodyinterpretation = null, Expression<Func<bodybodySitecodingInputItem[]>> bodybodySitecoding = null, Expression<Func<bodymethodcodingInputItem[]>> bodymethodcoding = null, Expression<Func<bodyreferenceRangeInputItem[]>> bodyreferenceRange = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyissued = WorkflowExpression.Compile(bodyissued, nameof(bodyissued), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyvalueQuantityvalue = WorkflowExpression.Compile(bodyvalueQuantityvalue, nameof(bodyvalueQuantityvalue), required: false);
            var __workflow_bodyvalueQuantityunit = WorkflowExpression.Compile(bodyvalueQuantityunit, nameof(bodyvalueQuantityunit), required: false);
            var __workflow_bodyvalueQuantitysystem = WorkflowExpression.Compile(bodyvalueQuantitysystem, nameof(bodyvalueQuantitysystem), required: false);
            var __workflow_bodyvalueQuantitycode = WorkflowExpression.Compile(bodyvalueQuantitycode, nameof(bodyvalueQuantitycode), required: false);
            var __workflow_bodyinterpretation = WorkflowExpression.Compile(bodyinterpretation, nameof(bodyinterpretation), required: false);
            var __workflow_bodybodySitecoding = WorkflowExpression.Compile(bodybodySitecoding, nameof(bodybodySitecoding), required: false);
            var __workflow_bodymethodcoding = WorkflowExpression.Compile(bodymethodcoding, nameof(bodymethodcoding), required: false);
            var __workflow_bodyreferenceRange = WorkflowExpression.Compile(bodyreferenceRange, nameof(bodyreferenceRange), required: false);
            return new DeferredBodyAction<DELETEObservationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Observation/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(__workflow_bodyissued);
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                var valueQuantityObject = new JObject();
                var valueQuantityObjectpropCount = 0;
                if (__workflow_bodyvalueQuantityvalue != null)
                {
                    valueQuantityObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantityvalue);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantityunit != null)
                {
                    valueQuantityObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantityunit);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantitysystem != null)
                {
                    valueQuantityObject["system"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantitysystem);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantitycode != null)
                {
                    valueQuantityObject["code"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantitycode);
                    valueQuantityObjectpropCount++;
                }

                if (valueQuantityObjectpropCount > 0)
                {
                    body["valueQuantity"] = valueQuantityObject;
                    bodypropCount++;
                }

                if (__workflow_bodyinterpretation != null)
                {
                    body["interpretation"] = ExpressionConverter.ConvertO(__workflow_bodyinterpretation);
                    bodypropCount++;
                }

                var bodySiteObject = new JObject();
                var bodySiteObjectpropCount = 0;
                if (__workflow_bodybodySitecoding != null)
                {
                    bodySiteObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodybodySitecoding);
                    bodySiteObjectpropCount++;
                }

                if (bodySiteObjectpropCount > 0)
                {
                    body["bodySite"] = bodySiteObject;
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (__workflow_bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceRange != null)
                {
                    body["referenceRange"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceRange);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEObservationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTObservationIdResponse, ApiConnectionActionConfiguration> PUTObservationId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycategoryInputItem[]>> bodycategory = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodysubjectdisplay = null, Expression<Func<string>> bodyissued = null, Expression<Func<bodyperformerInputItem2[]>> bodyperformer = null, Expression<Func<int>> bodyvalueQuantityvalue = null, Expression<Func<string>> bodyvalueQuantityunit = null, Expression<Func<string>> bodyvalueQuantitysystem = null, Expression<Func<string>> bodyvalueQuantitycode = null, Expression<Func<bodyinterpretationInputItem[]>> bodyinterpretation = null, Expression<Func<bodybodySitecodingInputItem[]>> bodybodySitecoding = null, Expression<Func<bodymethodcodingInputItem[]>> bodymethodcoding = null, Expression<Func<bodyreferenceRangeInputItem[]>> bodyreferenceRange = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodysubjectdisplay = WorkflowExpression.Compile(bodysubjectdisplay, nameof(bodysubjectdisplay), required: false);
            var __workflow_bodyissued = WorkflowExpression.Compile(bodyissued, nameof(bodyissued), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyvalueQuantityvalue = WorkflowExpression.Compile(bodyvalueQuantityvalue, nameof(bodyvalueQuantityvalue), required: false);
            var __workflow_bodyvalueQuantityunit = WorkflowExpression.Compile(bodyvalueQuantityunit, nameof(bodyvalueQuantityunit), required: false);
            var __workflow_bodyvalueQuantitysystem = WorkflowExpression.Compile(bodyvalueQuantitysystem, nameof(bodyvalueQuantitysystem), required: false);
            var __workflow_bodyvalueQuantitycode = WorkflowExpression.Compile(bodyvalueQuantitycode, nameof(bodyvalueQuantitycode), required: false);
            var __workflow_bodyinterpretation = WorkflowExpression.Compile(bodyinterpretation, nameof(bodyinterpretation), required: false);
            var __workflow_bodybodySitecoding = WorkflowExpression.Compile(bodybodySitecoding, nameof(bodybodySitecoding), required: false);
            var __workflow_bodymethodcoding = WorkflowExpression.Compile(bodymethodcoding, nameof(bodymethodcoding), required: false);
            var __workflow_bodyreferenceRange = WorkflowExpression.Compile(bodyreferenceRange, nameof(bodyreferenceRange), required: false);
            return new DeferredBodyAction<PUTObservationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Observation/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (__workflow_bodysubjectdisplay != null)
                {
                    subjectObject["display"] = ExpressionConverter.ConvertO(__workflow_bodysubjectdisplay);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyissued != null)
                {
                    body["issued"] = ExpressionConverter.ConvertO(__workflow_bodyissued);
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                var valueQuantityObject = new JObject();
                var valueQuantityObjectpropCount = 0;
                if (__workflow_bodyvalueQuantityvalue != null)
                {
                    valueQuantityObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantityvalue);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantityunit != null)
                {
                    valueQuantityObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantityunit);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantitysystem != null)
                {
                    valueQuantityObject["system"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantitysystem);
                    valueQuantityObjectpropCount++;
                }

                if (__workflow_bodyvalueQuantitycode != null)
                {
                    valueQuantityObject["code"] = ExpressionConverter.ConvertO(__workflow_bodyvalueQuantitycode);
                    valueQuantityObjectpropCount++;
                }

                if (valueQuantityObjectpropCount > 0)
                {
                    body["valueQuantity"] = valueQuantityObject;
                    bodypropCount++;
                }

                if (__workflow_bodyinterpretation != null)
                {
                    body["interpretation"] = ExpressionConverter.ConvertO(__workflow_bodyinterpretation);
                    bodypropCount++;
                }

                var bodySiteObject = new JObject();
                var bodySiteObjectpropCount = 0;
                if (__workflow_bodybodySitecoding != null)
                {
                    bodySiteObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodybodySitecoding);
                    bodySiteObjectpropCount++;
                }

                if (bodySiteObjectpropCount > 0)
                {
                    body["bodySite"] = bodySiteObject;
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (__workflow_bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceRange != null)
                {
                    body["referenceRange"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceRange);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTObservationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETProcedureResponse, ApiConnectionActionConfiguration> GETProcedure(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETProcedureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Procedure";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETProcedureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTProcedureResponse, ApiConnectionActionConfiguration> POSTProcedure(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyperformedDateTime = null, Expression<Func<string>> bodyrecorderreference = null, Expression<Func<string>> bodyrecorderdisplay = null, Expression<Func<string>> bodyasserterreference = null, Expression<Func<string>> bodyasserterdisplay = null, Expression<Func<bodyperformerInputItem22[]>> bodyperformer = null, Expression<Func<bodyreasonCodeInputItem2[]>> bodyreasonCode = null, Expression<Func<bodyfollowUpInputItem[]>> bodyfollowUp = null, Expression<Func<bodynoteInputItem[]>> bodynote = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyperformedDateTime = WorkflowExpression.Compile(bodyperformedDateTime, nameof(bodyperformedDateTime), required: false);
            var __workflow_bodyrecorderreference = WorkflowExpression.Compile(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            var __workflow_bodyrecorderdisplay = WorkflowExpression.Compile(bodyrecorderdisplay, nameof(bodyrecorderdisplay), required: false);
            var __workflow_bodyasserterreference = WorkflowExpression.Compile(bodyasserterreference, nameof(bodyasserterreference), required: false);
            var __workflow_bodyasserterdisplay = WorkflowExpression.Compile(bodyasserterdisplay, nameof(bodyasserterdisplay), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyreasonCode = WorkflowExpression.Compile(bodyreasonCode, nameof(bodyreasonCode), required: false);
            var __workflow_bodyfollowUp = WorkflowExpression.Compile(bodyfollowUp, nameof(bodyfollowUp), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<POSTProcedureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Procedure";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyperformedDateTime != null)
                {
                    body["performedDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyperformedDateTime);
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (__workflow_bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (__workflow_bodyrecorderdisplay != null)
                {
                    recorderObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderdisplay);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                var asserterObject = new JObject();
                var asserterObjectpropCount = 0;
                if (__workflow_bodyasserterreference != null)
                {
                    asserterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyasserterreference);
                    asserterObjectpropCount++;
                }

                if (__workflow_bodyasserterdisplay != null)
                {
                    asserterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyasserterdisplay);
                    asserterObjectpropCount++;
                }

                if (asserterObjectpropCount > 0)
                {
                    body["asserter"] = asserterObject;
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                if (__workflow_bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(__workflow_bodyreasonCode);
                    bodypropCount++;
                }

                if (__workflow_bodyfollowUp != null)
                {
                    body["followUp"] = ExpressionConverter.ConvertO(__workflow_bodyfollowUp);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
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
        public IBodyWorkflowAction<GETProcedureIdResponse, ApiConnectionActionConfiguration> GETProcedureId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETProcedureIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Procedure/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETProcedureIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETEProcedureIdResponse, ApiConnectionActionConfiguration> DELETEProcedureId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyperformedDateTime = null, Expression<Func<string>> bodyrecorderreference = null, Expression<Func<string>> bodyrecorderdisplay = null, Expression<Func<string>> bodyasserterreference = null, Expression<Func<string>> bodyasserterdisplay = null, Expression<Func<bodyperformerInputItem22[]>> bodyperformer = null, Expression<Func<bodyreasonCodeInputItem2[]>> bodyreasonCode = null, Expression<Func<bodyfollowUpInputItem[]>> bodyfollowUp = null, Expression<Func<bodynoteInputItem[]>> bodynote = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyperformedDateTime = WorkflowExpression.Compile(bodyperformedDateTime, nameof(bodyperformedDateTime), required: false);
            var __workflow_bodyrecorderreference = WorkflowExpression.Compile(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            var __workflow_bodyrecorderdisplay = WorkflowExpression.Compile(bodyrecorderdisplay, nameof(bodyrecorderdisplay), required: false);
            var __workflow_bodyasserterreference = WorkflowExpression.Compile(bodyasserterreference, nameof(bodyasserterreference), required: false);
            var __workflow_bodyasserterdisplay = WorkflowExpression.Compile(bodyasserterdisplay, nameof(bodyasserterdisplay), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyreasonCode = WorkflowExpression.Compile(bodyreasonCode, nameof(bodyreasonCode), required: false);
            var __workflow_bodyfollowUp = WorkflowExpression.Compile(bodyfollowUp, nameof(bodyfollowUp), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<DELETEProcedureIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Procedure/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyperformedDateTime != null)
                {
                    body["performedDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyperformedDateTime);
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (__workflow_bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (__workflow_bodyrecorderdisplay != null)
                {
                    recorderObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderdisplay);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                var asserterObject = new JObject();
                var asserterObjectpropCount = 0;
                if (__workflow_bodyasserterreference != null)
                {
                    asserterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyasserterreference);
                    asserterObjectpropCount++;
                }

                if (__workflow_bodyasserterdisplay != null)
                {
                    asserterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyasserterdisplay);
                    asserterObjectpropCount++;
                }

                if (asserterObjectpropCount > 0)
                {
                    body["asserter"] = asserterObject;
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                if (__workflow_bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(__workflow_bodyreasonCode);
                    bodypropCount++;
                }

                if (__workflow_bodyfollowUp != null)
                {
                    body["followUp"] = ExpressionConverter.ConvertO(__workflow_bodyfollowUp);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETEProcedureIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTProcedureIdResponse, ApiConnectionActionConfiguration> PUTProcedureId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodymetaversionId = null, Expression<Func<string>> bodymetalastUpdated = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodycodecodingInputItem[]>> bodycodecoding = null, Expression<Func<string>> bodycodetext = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyperformedDateTime = null, Expression<Func<string>> bodyrecorderreference = null, Expression<Func<string>> bodyrecorderdisplay = null, Expression<Func<string>> bodyasserterreference = null, Expression<Func<string>> bodyasserterdisplay = null, Expression<Func<bodyperformerInputItem22[]>> bodyperformer = null, Expression<Func<bodyreasonCodeInputItem2[]>> bodyreasonCode = null, Expression<Func<bodyfollowUpInputItem[]>> bodyfollowUp = null, Expression<Func<bodynoteInputItem[]>> bodynote = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodymetaversionId = WorkflowExpression.Compile(bodymetaversionId, nameof(bodymetaversionId), required: false);
            var __workflow_bodymetalastUpdated = WorkflowExpression.Compile(bodymetalastUpdated, nameof(bodymetalastUpdated), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycodecoding = WorkflowExpression.Compile(bodycodecoding, nameof(bodycodecoding), required: false);
            var __workflow_bodycodetext = WorkflowExpression.Compile(bodycodetext, nameof(bodycodetext), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyperformedDateTime = WorkflowExpression.Compile(bodyperformedDateTime, nameof(bodyperformedDateTime), required: false);
            var __workflow_bodyrecorderreference = WorkflowExpression.Compile(bodyrecorderreference, nameof(bodyrecorderreference), required: false);
            var __workflow_bodyrecorderdisplay = WorkflowExpression.Compile(bodyrecorderdisplay, nameof(bodyrecorderdisplay), required: false);
            var __workflow_bodyasserterreference = WorkflowExpression.Compile(bodyasserterreference, nameof(bodyasserterreference), required: false);
            var __workflow_bodyasserterdisplay = WorkflowExpression.Compile(bodyasserterdisplay, nameof(bodyasserterdisplay), required: false);
            var __workflow_bodyperformer = WorkflowExpression.Compile(bodyperformer, nameof(bodyperformer), required: false);
            var __workflow_bodyreasonCode = WorkflowExpression.Compile(bodyreasonCode, nameof(bodyreasonCode), required: false);
            var __workflow_bodyfollowUp = WorkflowExpression.Compile(bodyfollowUp, nameof(bodyfollowUp), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<PUTProcedureIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Procedure/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetaversionId != null)
                {
                    metaObject["versionId"] = ExpressionConverter.ConvertO(__workflow_bodymetaversionId);
                    metaObjectpropCount++;
                }

                if (__workflow_bodymetalastUpdated != null)
                {
                    metaObject["lastUpdated"] = ExpressionConverter.ConvertO(__workflow_bodymetalastUpdated);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var codeObject = new JObject();
                var codeObjectpropCount = 0;
                if (__workflow_bodycodecoding != null)
                {
                    codeObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodycodecoding);
                    codeObjectpropCount++;
                }

                if (__workflow_bodycodetext != null)
                {
                    codeObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycodetext);
                    codeObjectpropCount++;
                }

                if (codeObjectpropCount > 0)
                {
                    body["code"] = codeObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyperformedDateTime != null)
                {
                    body["performedDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyperformedDateTime);
                    bodypropCount++;
                }

                var recorderObject = new JObject();
                var recorderObjectpropCount = 0;
                if (__workflow_bodyrecorderreference != null)
                {
                    recorderObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderreference);
                    recorderObjectpropCount++;
                }

                if (__workflow_bodyrecorderdisplay != null)
                {
                    recorderObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyrecorderdisplay);
                    recorderObjectpropCount++;
                }

                if (recorderObjectpropCount > 0)
                {
                    body["recorder"] = recorderObject;
                    bodypropCount++;
                }

                var asserterObject = new JObject();
                var asserterObjectpropCount = 0;
                if (__workflow_bodyasserterreference != null)
                {
                    asserterObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodyasserterreference);
                    asserterObjectpropCount++;
                }

                if (__workflow_bodyasserterdisplay != null)
                {
                    asserterObject["display"] = ExpressionConverter.ConvertO(__workflow_bodyasserterdisplay);
                    asserterObjectpropCount++;
                }

                if (asserterObjectpropCount > 0)
                {
                    body["asserter"] = asserterObject;
                    bodypropCount++;
                }

                if (__workflow_bodyperformer != null)
                {
                    body["performer"] = ExpressionConverter.ConvertO(__workflow_bodyperformer);
                    bodypropCount++;
                }

                if (__workflow_bodyreasonCode != null)
                {
                    body["reasonCode"] = ExpressionConverter.ConvertO(__workflow_bodyreasonCode);
                    bodypropCount++;
                }

                if (__workflow_bodyfollowUp != null)
                {
                    body["followUp"] = ExpressionConverter.ConvertO(__workflow_bodyfollowUp);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTProcedureIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETRiskAssessmentResponse, ApiConnectionActionConfiguration> GETRiskAssessment(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETRiskAssessmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RiskAssessment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETRiskAssessmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<POSTRiskAssessmentResponse, ApiConnectionActionConfiguration> POSTRiskAssessment(Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodymethodcodingInputItem2[]>> bodymethodcoding = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyoccurrenceDateTime = null, Expression<Func<bodybasisInputItem[]>> bodybasis = null, Expression<Func<bodypredictionInputItem[]>> bodyprediction = null, Expression<Func<bodynoteInputItem[]>> bodynote = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymethodcoding = WorkflowExpression.Compile(bodymethodcoding, nameof(bodymethodcoding), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyoccurrenceDateTime = WorkflowExpression.Compile(bodyoccurrenceDateTime, nameof(bodyoccurrenceDateTime), required: false);
            var __workflow_bodybasis = WorkflowExpression.Compile(bodybasis, nameof(bodybasis), required: false);
            var __workflow_bodyprediction = WorkflowExpression.Compile(bodyprediction, nameof(bodyprediction), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<POSTRiskAssessmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RiskAssessment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (__workflow_bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyoccurrenceDateTime != null)
                {
                    body["occurrenceDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyoccurrenceDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodybasis != null)
                {
                    body["basis"] = ExpressionConverter.ConvertO(__workflow_bodybasis);
                    bodypropCount++;
                }

                if (__workflow_bodyprediction != null)
                {
                    body["prediction"] = ExpressionConverter.ConvertO(__workflow_bodyprediction);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
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
        public IBodyWorkflowAction<GETRiskAssessmentIdResponse, ApiConnectionActionConfiguration> GETRiskAssessmentId(Expression<Func<string>> id, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETRiskAssessmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RiskAssessment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETRiskAssessmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DELETERiskAssessmentIdResponse, ApiConnectionActionConfiguration> DELETERiskAssessmentId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodymethodcodingInputItem2[]>> bodymethodcoding = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyoccurrenceDateTime = null, Expression<Func<bodybasisInputItem[]>> bodybasis = null, Expression<Func<bodypredictionInputItem[]>> bodyprediction = null, Expression<Func<bodynoteInputItem[]>> bodynote = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymethodcoding = WorkflowExpression.Compile(bodymethodcoding, nameof(bodymethodcoding), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyoccurrenceDateTime = WorkflowExpression.Compile(bodyoccurrenceDateTime, nameof(bodyoccurrenceDateTime), required: false);
            var __workflow_bodybasis = WorkflowExpression.Compile(bodybasis, nameof(bodybasis), required: false);
            var __workflow_bodyprediction = WorkflowExpression.Compile(bodyprediction, nameof(bodyprediction), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<DELETERiskAssessmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RiskAssessment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (__workflow_bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyoccurrenceDateTime != null)
                {
                    body["occurrenceDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyoccurrenceDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodybasis != null)
                {
                    body["basis"] = ExpressionConverter.ConvertO(__workflow_bodybasis);
                    bodypropCount++;
                }

                if (__workflow_bodyprediction != null)
                {
                    body["prediction"] = ExpressionConverter.ConvertO(__workflow_bodyprediction);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DELETERiskAssessmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PUTRiskAssessmentIdResponse, ApiConnectionActionConfiguration> PUTRiskAssessmentId(Expression<Func<string>> id, Expression<Func<string>> bodyresourceType = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytextstatus = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodymethodcodingInputItem2[]>> bodymethodcoding = null, Expression<Func<string>> bodysubjectreference = null, Expression<Func<string>> bodyoccurrenceDateTime = null, Expression<Func<bodybasisInputItem[]>> bodybasis = null, Expression<Func<bodypredictionInputItem[]>> bodyprediction = null, Expression<Func<bodynoteInputItem[]>> bodynote = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytextstatus = WorkflowExpression.Compile(bodytextstatus, nameof(bodytextstatus), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodymethodcoding = WorkflowExpression.Compile(bodymethodcoding, nameof(bodymethodcoding), required: false);
            var __workflow_bodysubjectreference = WorkflowExpression.Compile(bodysubjectreference, nameof(bodysubjectreference), required: false);
            var __workflow_bodyoccurrenceDateTime = WorkflowExpression.Compile(bodyoccurrenceDateTime, nameof(bodyoccurrenceDateTime), required: false);
            var __workflow_bodybasis = WorkflowExpression.Compile(bodybasis, nameof(bodybasis), required: false);
            var __workflow_bodyprediction = WorkflowExpression.Compile(bodyprediction, nameof(bodyprediction), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<PUTRiskAssessmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RiskAssessment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyresourceType != null)
                {
                    body["resourceType"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                var textObject = new JObject();
                var textObjectpropCount = 0;
                if (__workflow_bodytextstatus != null)
                {
                    textObject["status"] = ExpressionConverter.ConvertO(__workflow_bodytextstatus);
                    textObjectpropCount++;
                }

                if (textObjectpropCount > 0)
                {
                    body["text"] = textObject;
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var methodObject = new JObject();
                var methodObjectpropCount = 0;
                if (__workflow_bodymethodcoding != null)
                {
                    methodObject["coding"] = ExpressionConverter.ConvertO(__workflow_bodymethodcoding);
                    methodObjectpropCount++;
                }

                if (methodObjectpropCount > 0)
                {
                    body["method"] = methodObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectreference != null)
                {
                    subjectObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodysubjectreference);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["subject"] = subjectObject;
                    bodypropCount++;
                }

                if (__workflow_bodyoccurrenceDateTime != null)
                {
                    body["occurrenceDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyoccurrenceDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodybasis != null)
                {
                    body["basis"] = ExpressionConverter.ConvertO(__workflow_bodybasis);
                    bodypropCount++;
                }

                if (__workflow_bodyprediction != null)
                {
                    body["prediction"] = ExpressionConverter.ConvertO(__workflow_bodyprediction);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PUTRiskAssessmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETCareTeamResponse, ApiConnectionActionConfiguration> GETCareTeam(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETCareTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CareTeam";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETCareTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GETCareTeamIdResponse, ApiConnectionActionConfiguration> GETCareTeamId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETCareTeamIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/CareTeam/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETCareTeamIdResponse>(callPayload);
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

    public class GETAdverseEventIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAdverseEventIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETAdverseEventIdResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public GETAdverseEventIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public GETAdverseEventIdResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public GETAdverseEventIdResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public GETAdverseEventIdResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public GETAdverseEventIdResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public GETAdverseEventIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public GETAdverseEventIdResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class GETAdverseEventIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAdverseEventIdResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETAdverseEventIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETAdverseEventIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventIdResponseEventType
    {
        [JsonProperty("coding")]
        public GETAdverseEventIdResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETAdverseEventIdResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAdverseEventIdResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public GETAdverseEventIdResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventIdResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public GETAdverseEventIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAdverseEventIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAdverseEventIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAdverseEventIdResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public GETAdverseEventIdResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class GETAdverseEventIdResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEAdverseEventIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAdverseEventIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public DELETEAdverseEventIdResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public DELETEAdverseEventIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public DELETEAdverseEventIdResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public DELETEAdverseEventIdResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public DELETEAdverseEventIdResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public DELETEAdverseEventIdResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public DELETEAdverseEventIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public DELETEAdverseEventIdResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class DELETEAdverseEventIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAdverseEventIdResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEAdverseEventIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEAdverseEventIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAdverseEventIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAdverseEventIdResponseEventType
    {
        [JsonProperty("coding")]
        public DELETEAdverseEventIdResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEAdverseEventIdResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAdverseEventIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEAdverseEventIdResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public DELETEAdverseEventIdResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAdverseEventIdResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAdverseEventIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public DELETEAdverseEventIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAdverseEventIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAdverseEventIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEAdverseEventIdResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public DELETEAdverseEventIdResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class DELETEAdverseEventIdResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTAdverseEventIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAdverseEventIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PUTAdverseEventIdResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public PUTAdverseEventIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public PUTAdverseEventIdResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public PUTAdverseEventIdResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public PUTAdverseEventIdResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public PUTAdverseEventIdResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public PUTAdverseEventIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public PUTAdverseEventIdResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class PUTAdverseEventIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAdverseEventIdResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTAdverseEventIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTAdverseEventIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAdverseEventIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAdverseEventIdResponseEventType
    {
        [JsonProperty("coding")]
        public PUTAdverseEventIdResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTAdverseEventIdResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAdverseEventIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTAdverseEventIdResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public PUTAdverseEventIdResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAdverseEventIdResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAdverseEventIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public PUTAdverseEventIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAdverseEventIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAdverseEventIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTAdverseEventIdResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public PUTAdverseEventIdResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class PUTAdverseEventIdResponseSuspectEntityTypeItemInstanceType
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

    public class GETAllergyIntoleranceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAllergyIntoleranceIdResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public GETAllergyIntoleranceIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GETAllergyIntoleranceIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public GETAllergyIntoleranceIdResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public GETAllergyIntoleranceIdResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class GETAllergyIntoleranceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAllergyIntoleranceIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAllergyIntoleranceIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAllergyIntoleranceIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GETAllergyIntoleranceIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETAllergyIntoleranceIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAllergyIntoleranceIdResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAllergyIntoleranceIdResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public DELETEAllergyIntoleranceIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DELETEAllergyIntoleranceIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public DELETEAllergyIntoleranceIdResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public DELETEAllergyIntoleranceIdResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public DELETEAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public DELETEAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEAllergyIntoleranceIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAllergyIntoleranceIdResponsePatientType
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

    public class PUTAllergyIntoleranceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAllergyIntoleranceIdResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public PUTAllergyIntoleranceIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PUTAllergyIntoleranceIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public PUTAllergyIntoleranceIdResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public PUTAllergyIntoleranceIdResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class PUTAllergyIntoleranceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAllergyIntoleranceIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public PUTAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTAllergyIntoleranceIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public PUTAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTAllergyIntoleranceIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTAllergyIntoleranceIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTAllergyIntoleranceIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAllergyIntoleranceIdResponsePatientType
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

    public class GETCarePlanIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETCarePlanIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETCarePlanIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("category")]
        public GETCarePlanIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subject")]
        public GETCarePlanIdResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETCarePlanIdResponseEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GETCarePlanIdResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public GETCarePlanIdResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public GETCarePlanIdResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("activity")]
        public GETCarePlanIdResponseActivityTypeItem[] Activity { get; set; }
    }

    public class GETCarePlanIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETCarePlanIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETCarePlanIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETCarePlanIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCarePlanIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCarePlanIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanIdResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETCarePlanIdResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanIdResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCarePlanIdResponseActivityTypeItem
    {
        [JsonProperty("detail")]
        public GETCarePlanIdResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class GETCarePlanIdResponseActivityTypeItemDetailType
    {
        [JsonProperty("code")]
        public GETCarePlanIdResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("location")]
        public GETCarePlanIdResponseActivityTypeItemDetailTypeLocationType Location { get; set; }
    }

    public class GETCarePlanIdResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public GETCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCarePlanIdResponseActivityTypeItemDetailTypeLocationType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETECarePlanIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETECarePlanIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public DELETECarePlanIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public DELETECarePlanIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public DELETECarePlanIdResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public DELETECarePlanIdResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public DELETECarePlanIdResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public DELETECarePlanIdResponseGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public DELETECarePlanIdResponseActivityTypeItem[] Activity { get; set; }
    }

    public class DELETECarePlanIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETECarePlanIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public DELETECarePlanIdResponseContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DELETECarePlanIdResponseContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public DELETECarePlanIdResponseContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETECarePlanIdResponseContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public DELETECarePlanIdResponseContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public DELETECarePlanIdResponseContainedTypeItemDescriptionType Description { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public DELETECarePlanIdResponseContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public DELETECarePlanIdResponseContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public DELETECarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public DELETECarePlanIdResponseContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public DELETECarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIdResponseContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETECarePlanIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DELETECarePlanIdResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETECarePlanIdResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETECarePlanIdResponseGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETECarePlanIdResponseActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public DELETECarePlanIdResponseActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public DELETECarePlanIdResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class DELETECarePlanIdResponseActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETECarePlanIdResponseActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public DELETECarePlanIdResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public DELETECarePlanIdResponseActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public DELETECarePlanIdResponseActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class DELETECarePlanIdResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public DELETECarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETECarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETECarePlanIdResponseActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETECarePlanIdResponseActivityTypeItemDetailTypePerformerTypeItem
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

    public class PUTCarePlanIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTCarePlanIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTCarePlanIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PUTCarePlanIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public PUTCarePlanIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PUTCarePlanIdResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public PUTCarePlanIdResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public PUTCarePlanIdResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public PUTCarePlanIdResponseGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public PUTCarePlanIdResponseActivityTypeItem[] Activity { get; set; }
    }

    public class PUTCarePlanIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTCarePlanIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public PUTCarePlanIdResponseContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PUTCarePlanIdResponseContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public PUTCarePlanIdResponseContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTCarePlanIdResponseContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PUTCarePlanIdResponseContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public PUTCarePlanIdResponseContainedTypeItemDescriptionType Description { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public PUTCarePlanIdResponseContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public PUTCarePlanIdResponseContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public PUTCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public PUTCarePlanIdResponseContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public PUTCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIdResponseContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTCarePlanIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class PUTCarePlanIdResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTCarePlanIdResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTCarePlanIdResponseGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTCarePlanIdResponseActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public PUTCarePlanIdResponseActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public PUTCarePlanIdResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class PUTCarePlanIdResponseActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTCarePlanIdResponseActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public PUTCarePlanIdResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public PUTCarePlanIdResponseActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public PUTCarePlanIdResponseActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class PUTCarePlanIdResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public PUTCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTCarePlanIdResponseActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PUTCarePlanIdResponseActivityTypeItemDetailTypePerformerTypeItem
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

    public class GETConditionIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETConditionIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETConditionIdResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public GETConditionIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GETConditionIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public GETConditionIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public GETConditionIdResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public GETConditionIdResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public GETConditionIdResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public GETConditionIdResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class GETConditionIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETConditionIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETConditionIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public GETConditionIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETConditionIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public GETConditionIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETConditionIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETConditionIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public GETConditionIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETConditionIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GETConditionIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETConditionIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIdResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public GETConditionIdResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETConditionIdResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETConditionIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEConditionIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEConditionIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEConditionIdResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public DELETEConditionIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DELETEConditionIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public DELETEConditionIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public DELETEConditionIdResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public DELETEConditionIdResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public DELETEConditionIdResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public DELETEConditionIdResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class DELETEConditionIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEConditionIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEConditionIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public DELETEConditionIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEConditionIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEConditionIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public DELETEConditionIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEConditionIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEConditionIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEConditionIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEConditionIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEConditionIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public DELETEConditionIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEConditionIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEConditionIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEConditionIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEConditionIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEConditionIdResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public DELETEConditionIdResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEConditionIdResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEConditionIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTConditionIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTConditionIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTConditionIdResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public PUTConditionIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PUTConditionIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public PUTConditionIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public PUTConditionIdResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public PUTConditionIdResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public PUTConditionIdResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public PUTConditionIdResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class PUTConditionIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTConditionIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTConditionIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public PUTConditionIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTConditionIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTConditionIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public PUTConditionIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTConditionIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTConditionIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTConditionIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTConditionIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTConditionIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public PUTConditionIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTConditionIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTConditionIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTConditionIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTConditionIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTConditionIdResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public PUTConditionIdResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTConditionIdResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTConditionIdResponseSubjectType
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

    public class GETDiagnosticReportIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDiagnosticReportIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDiagnosticReportIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDiagnosticReportIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public GETDiagnosticReportIdResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETDiagnosticReportIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETDiagnosticReportIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETDiagnosticReportIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public GETDiagnosticReportIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public GETDiagnosticReportIdResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class GETDiagnosticReportIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDiagnosticReportIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETDiagnosticReportIdResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDiagnosticReportIdResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETDiagnosticReportIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GETDiagnosticReportIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETDiagnosticReportIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDiagnosticReportIdResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEDiagnosticReportIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEDiagnosticReportIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEDiagnosticReportIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEDiagnosticReportIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public DELETEDiagnosticReportIdResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DELETEDiagnosticReportIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DELETEDiagnosticReportIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEDiagnosticReportIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DELETEDiagnosticReportIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public DELETEDiagnosticReportIdResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEDiagnosticReportIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEDiagnosticReportIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEDiagnosticReportIdResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTDiagnosticReportIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTDiagnosticReportIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTDiagnosticReportIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PUTDiagnosticReportIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public PUTDiagnosticReportIdResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTDiagnosticReportIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PUTDiagnosticReportIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTDiagnosticReportIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public PUTDiagnosticReportIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public PUTDiagnosticReportIdResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class PUTDiagnosticReportIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTDiagnosticReportIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTDiagnosticReportIdResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTDiagnosticReportIdResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTDiagnosticReportIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTDiagnosticReportIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTDiagnosticReportIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTDiagnosticReportIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTDiagnosticReportIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTDiagnosticReportIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTDiagnosticReportIdResponseResultTypeItem
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

    public class GETMedicationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETMedicationIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public GETMedicationIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public GETMedicationIdResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public GETMedicationIdResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public GETMedicationIdResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GETMedicationIdResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public GETMedicationIdResponseBatchType Batch { get; set; }
    }

    public class GETMedicationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETMedicationIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GETMedicationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GETMedicationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationIdResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationIdResponseFormType
    {
        [JsonProperty("coding")]
        public GETMedicationIdResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationIdResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationIdResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GETMedicationIdResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public GETMedicationIdResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GETMedicationIdResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationIdResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GETMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationIdResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class DELETEMedicationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEMedicationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEMedicationIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public DELETEMedicationIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public DELETEMedicationIdResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public DELETEMedicationIdResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public DELETEMedicationIdResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public DELETEMedicationIdResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public DELETEMedicationIdResponseBatchType Batch { get; set; }
    }

    public class DELETEMedicationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEMedicationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEMedicationIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DELETEMedicationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEMedicationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEMedicationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationIdResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEMedicationIdResponseFormType
    {
        [JsonProperty("coding")]
        public DELETEMedicationIdResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEMedicationIdResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationIdResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public DELETEMedicationIdResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public DELETEMedicationIdResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class DELETEMedicationIdResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public DELETEMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationIdResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public DELETEMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public DELETEMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class DELETEMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEMedicationIdResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class PUTMedicationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTMedicationIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PUTMedicationIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public PUTMedicationIdResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public PUTMedicationIdResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public PUTMedicationIdResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public PUTMedicationIdResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public PUTMedicationIdResponseBatchType Batch { get; set; }
    }

    public class PUTMedicationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTMedicationIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PUTMedicationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTMedicationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationIdResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationIdResponseFormType
    {
        [JsonProperty("coding")]
        public PUTMedicationIdResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationIdResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationIdResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public PUTMedicationIdResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public PUTMedicationIdResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class PUTMedicationIdResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public PUTMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationIdResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public PUTMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PUTMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class PUTMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationIdResponseBatchType
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

    public class GETMedicationRequestIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationRequestIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETMedicationRequestIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETMedicationRequestIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETMedicationRequestIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationRequestIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETMedicationRequestIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationRequestIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DELETEMedicationRequestIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEMedicationRequestIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public DELETEMedicationRequestIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public DELETEMedicationRequestIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class DELETEMedicationRequestIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEMedicationRequestIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public DELETEMedicationRequestIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEMedicationRequestIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PUTMedicationRequestIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationRequestIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public PUTMedicationRequestIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public PUTMedicationRequestIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class PUTMedicationRequestIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationRequestIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public PUTMedicationRequestIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationRequestIdResponseEntryTypeItemSearchType
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

    public class GETMedicationStatementIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationStatementIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETMedicationStatementIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETMedicationStatementIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETMedicationStatementIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationStatementIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETMedicationStatementIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
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

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
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

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
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

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETMedicationStatementIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PUTMedicationStatementIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationStatementIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public PUTMedicationStatementIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public PUTMedicationStatementIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class PUTMedicationStatementIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationStatementIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public PUTMedicationStatementIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
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

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
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

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
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

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTMedicationStatementIdResponseEntryTypeItemSearchType
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

    public class GETObservationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETObservationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETObservationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETObservationIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETObservationIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETObservationIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public GETObservationIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public GETObservationIdResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public GETObservationIdResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public GETObservationIdResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public GETObservationIdResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public GETObservationIdResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class GETObservationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETObservationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETObservationIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETObservationIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GETObservationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETObservationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETObservationIdResponseValueQuantityType
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

    public class GETObservationIdResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public GETObservationIdResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationIdResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETObservationIdResponseBodySiteType
    {
        [JsonProperty("coding")]
        public GETObservationIdResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationIdResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIdResponseMethodType
    {
        [JsonProperty("coding")]
        public GETObservationIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETObservationIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETObservationIdResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public GETObservationIdResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class GETObservationIdResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class DELETEObservationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEObservationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEObservationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DELETEObservationIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DELETEObservationIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEObservationIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DELETEObservationIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public DELETEObservationIdResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public DELETEObservationIdResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public DELETEObservationIdResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public DELETEObservationIdResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public DELETEObservationIdResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class DELETEObservationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEObservationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEObservationIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEObservationIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEObservationIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEObservationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEObservationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEObservationIdResponseValueQuantityType
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

    public class DELETEObservationIdResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public DELETEObservationIdResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEObservationIdResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEObservationIdResponseBodySiteType
    {
        [JsonProperty("coding")]
        public DELETEObservationIdResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEObservationIdResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIdResponseMethodType
    {
        [JsonProperty("coding")]
        public DELETEObservationIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEObservationIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEObservationIdResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public DELETEObservationIdResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class DELETEObservationIdResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class PUTObservationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTObservationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTObservationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTObservationIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PUTObservationIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTObservationIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public PUTObservationIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public PUTObservationIdResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public PUTObservationIdResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public PUTObservationIdResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public PUTObservationIdResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public PUTObservationIdResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class PUTObservationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTObservationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTObservationIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTObservationIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTObservationIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTObservationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTObservationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTObservationIdResponseValueQuantityType
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

    public class PUTObservationIdResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public PUTObservationIdResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTObservationIdResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTObservationIdResponseBodySiteType
    {
        [JsonProperty("coding")]
        public PUTObservationIdResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTObservationIdResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIdResponseMethodType
    {
        [JsonProperty("coding")]
        public PUTObservationIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTObservationIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTObservationIdResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public PUTObservationIdResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class PUTObservationIdResponseReferenceRangeTypeItemHighType
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

    public class GETProcedureIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETProcedureIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public GETProcedureIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETProcedureIdResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETProcedureIdResponseEncounterType Encounter { get; set; }

        [JsonProperty("performedPeriod")]
        public GETProcedureIdResponsePerformedPeriodType PerformedPeriod { get; set; }
    }

    public class GETProcedureIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETProcedureIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GETProcedureIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETProcedureIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETProcedureIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETProcedureIdResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETProcedureIdResponsePerformedPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETEProcedureIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEProcedureIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEProcedureIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public DELETEProcedureIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEProcedureIdResponseSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public DELETEProcedureIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public DELETEProcedureIdResponseAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public DELETEProcedureIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public DELETEProcedureIdResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public DELETEProcedureIdResponseFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public DELETEProcedureIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class DELETEProcedureIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEProcedureIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETEProcedureIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEProcedureIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEProcedureIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEProcedureIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEProcedureIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEProcedureIdResponseAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEProcedureIdResponsePerformerTypeItem
    {
        [JsonProperty("actor")]
        public DELETEProcedureIdResponsePerformerTypeItemActorType Actor { get; set; }
    }

    public class DELETEProcedureIdResponsePerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEProcedureIdResponseReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEProcedureIdResponseFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEProcedureIdResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTProcedureIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTProcedureIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTProcedureIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public PUTProcedureIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTProcedureIdResponseSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public PUTProcedureIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public PUTProcedureIdResponseAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public PUTProcedureIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public PUTProcedureIdResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public PUTProcedureIdResponseFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public PUTProcedureIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class PUTProcedureIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTProcedureIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTProcedureIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTProcedureIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTProcedureIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTProcedureIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTProcedureIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTProcedureIdResponseAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTProcedureIdResponsePerformerTypeItem
    {
        [JsonProperty("actor")]
        public PUTProcedureIdResponsePerformerTypeItemActorType Actor { get; set; }
    }

    public class PUTProcedureIdResponsePerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTProcedureIdResponseReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTProcedureIdResponseFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTProcedureIdResponseNoteTypeItem
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

    public class GETRiskAssessmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETRiskAssessmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETRiskAssessmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public GETRiskAssessmentIdResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public GETRiskAssessmentIdResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public GETRiskAssessmentIdResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public GETRiskAssessmentIdResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public GETRiskAssessmentIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class GETRiskAssessmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETRiskAssessmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GETRiskAssessmentIdResponseMethodType
    {
        [JsonProperty("coding")]
        public GETRiskAssessmentIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETRiskAssessmentIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETRiskAssessmentIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETRiskAssessmentIdResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETRiskAssessmentIdResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public GETRiskAssessmentIdResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public GETRiskAssessmentIdResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class GETRiskAssessmentIdResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETRiskAssessmentIdResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public GETRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public GETRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class GETRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType
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

    public class GETRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType
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

    public class GETRiskAssessmentIdResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETERiskAssessmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETERiskAssessmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETERiskAssessmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public DELETERiskAssessmentIdResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public DELETERiskAssessmentIdResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public DELETERiskAssessmentIdResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public DELETERiskAssessmentIdResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public DELETERiskAssessmentIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class DELETERiskAssessmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETERiskAssessmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DELETERiskAssessmentIdResponseMethodType
    {
        [JsonProperty("coding")]
        public DELETERiskAssessmentIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DELETERiskAssessmentIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETERiskAssessmentIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETERiskAssessmentIdResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETERiskAssessmentIdResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public DELETERiskAssessmentIdResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public DELETERiskAssessmentIdResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class DELETERiskAssessmentIdResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETERiskAssessmentIdResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public DELETERiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public DELETERiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class DELETERiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType
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

    public class DELETERiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType
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

    public class DELETERiskAssessmentIdResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTRiskAssessmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTRiskAssessmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTRiskAssessmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public PUTRiskAssessmentIdResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public PUTRiskAssessmentIdResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public PUTRiskAssessmentIdResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public PUTRiskAssessmentIdResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public PUTRiskAssessmentIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class PUTRiskAssessmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTRiskAssessmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PUTRiskAssessmentIdResponseMethodType
    {
        [JsonProperty("coding")]
        public PUTRiskAssessmentIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PUTRiskAssessmentIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTRiskAssessmentIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTRiskAssessmentIdResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PUTRiskAssessmentIdResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public PUTRiskAssessmentIdResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public PUTRiskAssessmentIdResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class PUTRiskAssessmentIdResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTRiskAssessmentIdResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public PUTRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public PUTRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class PUTRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType
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

    public class PUTRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType
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

    public class PUTRiskAssessmentIdResponseNoteTypeItem
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

    public class GETCareTeamIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETCareTeamIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public GETCareTeamIdResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GETCareTeamIdResponseEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GETCareTeamIdResponsePeriodType Period { get; set; }

        [JsonProperty("participant")]
        public GETCareTeamIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("reasonCode")]
        public GETCareTeamIdResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("managingOrganization")]
        public GETCareTeamIdResponseManagingOrganizationTypeItem[] ManagingOrganization { get; set; }
    }

    public class GETCareTeamIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETCareTeamIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCareTeamIdResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETCareTeamIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GETCareTeamIdResponseParticipantTypeItem
    {
        [JsonProperty("role")]
        public GETCareTeamIdResponseParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public GETCareTeamIdResponseParticipantTypeItemMemberType Member { get; set; }
    }

    public class GETCareTeamIdResponseParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public GETCareTeamIdResponseParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCareTeamIdResponseParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamIdResponseParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamIdResponseReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GETCareTeamIdResponseReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETCareTeamIdResponseReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETCareTeamIdResponseManagingOrganizationTypeItem
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