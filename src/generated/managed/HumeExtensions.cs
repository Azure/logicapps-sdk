//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hume
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HumeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hume")]
        public IBodyWorkflowAction<JobsGetResponseItem[]> JobsGet(Expression<Func<int>> limit = null, Expression<Func<statusInput>> status = null, Expression<Func<whenInput>> when = null, Expression<Func<string>> timestampMs = null, Expression<Func<sortByInput>> sortBy = null, Expression<Func<directionInput>> direction = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_when = WorkflowExpression.Compile(when, nameof(when), required: false);
            var __workflow_timestampMs = WorkflowExpression.Compile(timestampMs, nameof(timestampMs), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            return new DeferredBodyAction<JobsGetResponseItem[]>(() =>
            {
                var apiCallPath = "/batch/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_when != null)
                    callPayload.Queries["when"] = ExpressionConverter.Convert(__workflow_when);
                if (__workflow_timestampMs != null)
                    callPayload.Queries["timestamp_ms"] = ExpressionConverter.Convert(__workflow_timestampMs);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                return new ApiConnectionAction<JobsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hume")]
        public IBodyWorkflowAction<JobPostResponse> Job(Expression<Func<double>> bodymodelsfacefpsPred = null, Expression<Func<double>> bodymodelsfaceprobThreshold = null, Expression<Func<bool>> bodymodelsfaceidentifyFaces = null, Expression<Func<int>> bodymodelsfaceminFaceSize = null, Expression<Func<bool>> bodymodelsfacesaveFaces = null, Expression<Func<string>> bodymodelsprosodygranularity = null, Expression<Func<bool>> bodymodelsprosodyidentifySpeakers = null, Expression<Func<int>> bodymodelsprosodywindowlength = null, Expression<Func<int>> bodymodelsprosodywindowstep = null, Expression<Func<string>> bodymodelslanguagegranularity = null, Expression<Func<bool>> bodymodelslanguageidentifySpeakers = null, Expression<Func<bool>> bodymodelsneridentifySpeakers = null, Expression<Func<string>> bodytranscriptionlanguage = null, Expression<Func<string[]>> bodyurls = null, Expression<Func<string>> bodycallbackUrl = null, Expression<Func<bool>> bodynotify = null)
        {
            var __workflow_bodymodelsfacefpsPred = WorkflowExpression.Compile(bodymodelsfacefpsPred, nameof(bodymodelsfacefpsPred), required: false);
            var __workflow_bodymodelsfaceprobThreshold = WorkflowExpression.Compile(bodymodelsfaceprobThreshold, nameof(bodymodelsfaceprobThreshold), required: false);
            var __workflow_bodymodelsfaceidentifyFaces = WorkflowExpression.Compile(bodymodelsfaceidentifyFaces, nameof(bodymodelsfaceidentifyFaces), required: false);
            var __workflow_bodymodelsfaceminFaceSize = WorkflowExpression.Compile(bodymodelsfaceminFaceSize, nameof(bodymodelsfaceminFaceSize), required: false);
            var __workflow_bodymodelsfacesaveFaces = WorkflowExpression.Compile(bodymodelsfacesaveFaces, nameof(bodymodelsfacesaveFaces), required: false);
            var __workflow_bodymodelsprosodygranularity = WorkflowExpression.Compile(bodymodelsprosodygranularity, nameof(bodymodelsprosodygranularity), required: false);
            var __workflow_bodymodelsprosodyidentifySpeakers = WorkflowExpression.Compile(bodymodelsprosodyidentifySpeakers, nameof(bodymodelsprosodyidentifySpeakers), required: false);
            var __workflow_bodymodelsprosodywindowlength = WorkflowExpression.Compile(bodymodelsprosodywindowlength, nameof(bodymodelsprosodywindowlength), required: false);
            var __workflow_bodymodelsprosodywindowstep = WorkflowExpression.Compile(bodymodelsprosodywindowstep, nameof(bodymodelsprosodywindowstep), required: false);
            var __workflow_bodymodelslanguagegranularity = WorkflowExpression.Compile(bodymodelslanguagegranularity, nameof(bodymodelslanguagegranularity), required: false);
            var __workflow_bodymodelslanguageidentifySpeakers = WorkflowExpression.Compile(bodymodelslanguageidentifySpeakers, nameof(bodymodelslanguageidentifySpeakers), required: false);
            var __workflow_bodymodelsneridentifySpeakers = WorkflowExpression.Compile(bodymodelsneridentifySpeakers, nameof(bodymodelsneridentifySpeakers), required: false);
            var __workflow_bodytranscriptionlanguage = WorkflowExpression.Compile(bodytranscriptionlanguage, nameof(bodytranscriptionlanguage), required: false);
            var __workflow_bodyurls = WorkflowExpression.Compile(bodyurls, nameof(bodyurls), required: false);
            var __workflow_bodycallbackUrl = WorkflowExpression.Compile(bodycallbackUrl, nameof(bodycallbackUrl), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            return new DeferredBodyAction<JobPostResponse>(() =>
            {
                var apiCallPath = "/batch/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var modelsObject = new JObject();
                var modelsObjectpropCount = 0;
                var faceObject = new JObject();
                var faceObjectpropCount = 0;
                if (__workflow_bodymodelsfacefpsPred != null)
                {
                    faceObject["fps_pred"] = ExpressionConverter.ConvertO(__workflow_bodymodelsfacefpsPred);
                    faceObjectpropCount++;
                }

                if (__workflow_bodymodelsfaceprobThreshold != null)
                {
                    faceObject["prob_threshold"] = ExpressionConverter.ConvertO(__workflow_bodymodelsfaceprobThreshold);
                    faceObjectpropCount++;
                }

                if (__workflow_bodymodelsfaceidentifyFaces != null)
                {
                    faceObject["identify_faces"] = ExpressionConverter.ConvertO(__workflow_bodymodelsfaceidentifyFaces);
                    faceObjectpropCount++;
                }

                if (__workflow_bodymodelsfaceminFaceSize != null)
                {
                    faceObject["min_face_size"] = ExpressionConverter.ConvertO(__workflow_bodymodelsfaceminFaceSize);
                    faceObjectpropCount++;
                }

                if (__workflow_bodymodelsfacesaveFaces != null)
                {
                    faceObject["save_faces"] = ExpressionConverter.ConvertO(__workflow_bodymodelsfacesaveFaces);
                    faceObjectpropCount++;
                }

                if (faceObjectpropCount > 0)
                {
                    modelsObject["face"] = faceObject;
                    modelsObjectpropCount++;
                }

                var prosodyObject = new JObject();
                var prosodyObjectpropCount = 0;
                if (__workflow_bodymodelsprosodygranularity != null)
                {
                    prosodyObject["granularity"] = ExpressionConverter.ConvertO(__workflow_bodymodelsprosodygranularity);
                    prosodyObjectpropCount++;
                }

                if (__workflow_bodymodelsprosodyidentifySpeakers != null)
                {
                    prosodyObject["identify_speakers"] = ExpressionConverter.ConvertO(__workflow_bodymodelsprosodyidentifySpeakers);
                    prosodyObjectpropCount++;
                }

                var windowObject = new JObject();
                var windowObjectpropCount = 0;
                if (__workflow_bodymodelsprosodywindowlength != null)
                {
                    windowObject["length"] = ExpressionConverter.ConvertO(__workflow_bodymodelsprosodywindowlength);
                    windowObjectpropCount++;
                }

                if (__workflow_bodymodelsprosodywindowstep != null)
                {
                    windowObject["step"] = ExpressionConverter.ConvertO(__workflow_bodymodelsprosodywindowstep);
                    windowObjectpropCount++;
                }

                if (windowObjectpropCount > 0)
                {
                    prosodyObject["window"] = windowObject;
                    prosodyObjectpropCount++;
                }

                if (prosodyObjectpropCount > 0)
                {
                    modelsObject["prosody"] = prosodyObject;
                    modelsObjectpropCount++;
                }

                var languageObject = new JObject();
                var languageObjectpropCount = 0;
                if (__workflow_bodymodelslanguagegranularity != null)
                {
                    languageObject["granularity"] = ExpressionConverter.ConvertO(__workflow_bodymodelslanguagegranularity);
                    languageObjectpropCount++;
                }

                if (__workflow_bodymodelslanguageidentifySpeakers != null)
                {
                    languageObject["identify_speakers"] = ExpressionConverter.ConvertO(__workflow_bodymodelslanguageidentifySpeakers);
                    languageObjectpropCount++;
                }

                if (languageObjectpropCount > 0)
                {
                    modelsObject["language"] = languageObject;
                    modelsObjectpropCount++;
                }

                var nerObject = new JObject();
                var nerObjectpropCount = 0;
                if (__workflow_bodymodelsneridentifySpeakers != null)
                {
                    nerObject["identify_speakers"] = ExpressionConverter.ConvertO(__workflow_bodymodelsneridentifySpeakers);
                    nerObjectpropCount++;
                }

                if (nerObjectpropCount > 0)
                {
                    modelsObject["ner"] = nerObject;
                    modelsObjectpropCount++;
                }

                if (modelsObjectpropCount > 0)
                {
                    body["models"] = modelsObject;
                    bodypropCount++;
                }

                var transcriptionObject = new JObject();
                var transcriptionObjectpropCount = 0;
                if (__workflow_bodytranscriptionlanguage != null)
                {
                    transcriptionObject["language"] = ExpressionConverter.ConvertO(__workflow_bodytranscriptionlanguage);
                    transcriptionObjectpropCount++;
                }

                if (transcriptionObjectpropCount > 0)
                {
                    body["transcription"] = transcriptionObject;
                    bodypropCount++;
                }

                if (__workflow_bodyurls != null)
                {
                    body["urls"] = ExpressionConverter.ConvertO(__workflow_bodyurls);
                    bodypropCount++;
                }

                if (__workflow_bodycallbackUrl != null)
                {
                    body["callback_url"] = ExpressionConverter.ConvertO(__workflow_bodycallbackUrl);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JobPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hume")]
        public IBodyWorkflowAction<JobPredictionsGetResponseItem[]> JobPredictionsGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JobPredictionsGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/batch/jobs/{0}/predictions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobPredictionsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hume")]
        public IBodyWorkflowAction<string> JobArtifactsGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/batch/jobs/{0}/artifacts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hume")]
        public IBodyWorkflowAction<JobDetailsGetResponse> JobDetailsGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JobDetailsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/batch/jobs/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobDetailsGetResponse>(callPayload);
            });
        }
    }

    public class HumeTriggers([ConnectionName] string connectionId)
    {
    }

    public class JobsGetResponseItem
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("job_id")]
        public string JobId { get; set; }

        [JsonProperty("request")]
        public JobsGetResponseItemRequestType Request { get; set; }

        [JsonProperty("state")]
        public JobsGetResponseItemStateType State { get; set; }
    }

    public class JobsGetResponseItemRequestType
    {
        [JsonProperty("models")]
        public JobsGetResponseItemRequestTypeModelsType Models { get; set; }

        [JsonProperty("transcription")]
        public JobsGetResponseItemRequestTypeTranscriptionType Transcription { get; set; }

        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("files")]
        public JobsGetResponseItemRequestTypeFilesTypeItem[] Files { get; set; }
    }

    public class JobsGetResponseItemRequestTypeModelsType
    {
        [JsonProperty("face")]
        public JobsGetResponseItemRequestTypeModelsTypeFaceType Face { get; set; }

        [JsonProperty("prosody")]
        public JobsGetResponseItemRequestTypeModelsTypeProsodyType Prosody { get; set; }

        [JsonProperty("language")]
        public JobsGetResponseItemRequestTypeModelsTypeLanguageType Language { get; set; }

        [JsonProperty("ner")]
        public JobsGetResponseItemRequestTypeModelsTypeNerType Ner { get; set; }

        [JsonProperty("facemesh")]
        public JToken Facemesh { get; set; }
    }

    public class JobsGetResponseItemRequestTypeModelsTypeFaceType
    {
        [JsonProperty("fps_pred")]
        public double FpsPred { get; set; }

        [JsonProperty("prob_threshold")]
        public double ProbThreshold { get; set; }

        [JsonProperty("identify_faces")]
        public bool IdentifyFaces { get; set; }

        [JsonProperty("min_face_size")]
        public int MinFaceSize { get; set; }

        [JsonProperty("facs")]
        public JToken Facs { get; set; }

        [JsonProperty("descriptions")]
        public JToken Descriptions { get; set; }

        [JsonProperty("save_faces")]
        public bool SaveFaces { get; set; }
    }

    public class JobsGetResponseItemRequestTypeModelsTypeProsodyType
    {
        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("identify_speakers")]
        public bool IdentifySpeakers { get; set; }

        [JsonProperty("window")]
        public JobsGetResponseItemRequestTypeModelsTypeProsodyTypeWindowType Window { get; set; }
    }

    public class JobsGetResponseItemRequestTypeModelsTypeProsodyTypeWindowType
    {
        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("step")]
        public int Step { get; set; }
    }

    public class JobsGetResponseItemRequestTypeModelsTypeLanguageType
    {
        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("identify_speakers")]
        public bool IdentifySpeakers { get; set; }

        [JsonProperty("sentiment")]
        public JToken Sentiment { get; set; }

        [JsonProperty("toxicity")]
        public JToken Toxicity { get; set; }
    }

    public class JobsGetResponseItemRequestTypeModelsTypeNerType
    {
        [JsonProperty("identify_speakers")]
        public bool IdentifySpeakers { get; set; }
    }

    public class JobsGetResponseItemRequestTypeTranscriptionType
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class JobsGetResponseItemRequestTypeFilesTypeItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("md5sum")]
        public string Md5sum { get; set; }
    }

    public class JobsGetResponseItemStateType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_timestamp_ms")]
        public int CreatedTimestampMs { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        COMPLETED,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        QUEUED,
        FAILED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum whenInput
    {
        [EnumMember(Value = "created_before")]
        CreatedBefore,
        [EnumMember(Value = "created_after")]
        CreatedAfter
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortByInput
    {
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "started")]
        Started,
        [EnumMember(Value = "ended")]
        Ended
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum directionInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class JobPostResponse
    {
        [JsonProperty("job_id")]
        public string JobId { get; set; }
    }

    public class JobPredictionsGetResponseItem
    {
        [JsonProperty("source")]
        public JobPredictionsGetResponseItemSourceType Source { get; set; }

        [JsonProperty("results")]
        public JobPredictionsGetResponseItemResultsType Results { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class JobPredictionsGetResponseItemSourceType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsType
    {
        [JsonProperty("predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItem[] Predictions { get; set; }

        [JsonProperty("errors")]
        public JobPredictionsGetResponseItemResultsTypeErrorsTypeItem[] Errors { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItem
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("models")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsType Models { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsType
    {
        [JsonProperty("face")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceType Face { get; set; }

        [JsonProperty("burst")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstType Burst { get; set; }

        [JsonProperty("prosody")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyType Prosody { get; set; }

        [JsonProperty("language")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageType Language { get; set; }

        [JsonProperty("ner")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerType Ner { get; set; }

        [JsonProperty("facemesh")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFacemeshType Facemesh { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceType
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("grouped_predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItem[] GroupedPredictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItem[] Predictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItem
    {
        [JsonProperty("frame")]
        public int Frame { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("prob")]
        public int Prob { get; set; }

        [JsonProperty("box")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItemBoxType Box { get; set; }

        [JsonProperty("emotions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem[] Emotions { get; set; }

        [JsonProperty("facs")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItemFacsTypeItem[] Facs { get; set; }

        [JsonProperty("descriptions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItemDescriptionsTypeItem[] Descriptions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItemBoxType
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("w")]
        public int W { get; set; }

        [JsonProperty("h")]
        public int H { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItemFacsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFaceTypeGroupedPredictionsTypeItemPredictionsTypeItemDescriptionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstType
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("grouped_predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItem[] GroupedPredictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItemPredictionsTypeItem[] Predictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItemPredictionsTypeItem
    {
        [JsonProperty("time")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItemPredictionsTypeItemTimeType Time { get; set; }

        [JsonProperty("emotions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem[] Emotions { get; set; }

        [JsonProperty("descriptions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItemPredictionsTypeItemDescriptionsTypeItem[] Descriptions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItemPredictionsTypeItemTimeType
    {
        [JsonProperty("begin")]
        public int Begin { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeBurstTypeGroupedPredictionsTypeItemPredictionsTypeItemDescriptionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyType
    {
        [JsonProperty("metadata")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeMetadataType Metadata { get; set; }

        [JsonProperty("grouped_predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeGroupedPredictionsTypeItem[] GroupedPredictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeMetadataType
    {
        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("detected_language")]
        public string DetectedLanguage { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeGroupedPredictionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeGroupedPredictionsTypeItemPredictionsTypeItem[] Predictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeGroupedPredictionsTypeItemPredictionsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("time")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeGroupedPredictionsTypeItemPredictionsTypeItemTimeType Time { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("speaker_confidence")]
        public int SpeakerConfidence { get; set; }

        [JsonProperty("emotions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem[] Emotions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeGroupedPredictionsTypeItemPredictionsTypeItemTimeType
    {
        [JsonProperty("begin")]
        public int Begin { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeProsodyTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageType
    {
        [JsonProperty("metadata")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeMetadataType Metadata { get; set; }

        [JsonProperty("grouped_predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItem[] GroupedPredictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeMetadataType
    {
        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("detected_language")]
        public string DetectedLanguage { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItem[] Predictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("position")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemPositionType Position { get; set; }

        [JsonProperty("time")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemTimeType Time { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("speaker_confidence")]
        public int SpeakerConfidence { get; set; }

        [JsonProperty("emotions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem[] Emotions { get; set; }

        [JsonProperty("sentiment")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemSentimentTypeItem[] Sentiment { get; set; }

        [JsonProperty("toxicity")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemToxicityTypeItem[] Toxicity { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemPositionType
    {
        [JsonProperty("begin")]
        public int Begin { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemTimeType
    {
        [JsonProperty("begin")]
        public int Begin { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemSentimentTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeLanguageTypeGroupedPredictionsTypeItemPredictionsTypeItemToxicityTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerType
    {
        [JsonProperty("metadata")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeMetadataType Metadata { get; set; }

        [JsonProperty("grouped_predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItem[] GroupedPredictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeMetadataType
    {
        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("detected_language")]
        public string DetectedLanguage { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItemPredictionsTypeItem[] Predictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItemPredictionsTypeItem
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("position")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItemPredictionsTypeItemPositionType Position { get; set; }

        [JsonProperty("entity_confidence")]
        public int EntityConfidence { get; set; }

        [JsonProperty("support")]
        public int Support { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("link_word")]
        public string LinkWord { get; set; }

        [JsonProperty("time")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItemPredictionsTypeItemTimeType Time { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("speaker_confidence")]
        public int SpeakerConfidence { get; set; }

        [JsonProperty("emotions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem[] Emotions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItemPredictionsTypeItemPositionType
    {
        [JsonProperty("begin")]
        public int Begin { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItemPredictionsTypeItemTimeType
    {
        [JsonProperty("begin")]
        public int Begin { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeNerTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFacemeshType
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("grouped_predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFacemeshTypeGroupedPredictionsTypeItem[] GroupedPredictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFacemeshTypeGroupedPredictionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("predictions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFacemeshTypeGroupedPredictionsTypeItemPredictionsTypeItem[] Predictions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFacemeshTypeGroupedPredictionsTypeItemPredictionsTypeItem
    {
        [JsonProperty("emotions")]
        public JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFacemeshTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem[] Emotions { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypePredictionsTypeItemModelsTypeFacemeshTypeGroupedPredictionsTypeItemPredictionsTypeItemEmotionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class JobPredictionsGetResponseItemResultsTypeErrorsTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class JobDetailsGetResponse
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("job_id")]
        public string JobId { get; set; }

        [JsonProperty("request")]
        public JobDetailsGetResponseRequestType Request { get; set; }

        [JsonProperty("state")]
        public JobDetailsGetResponseStateType State { get; set; }
    }

    public class JobDetailsGetResponseRequestType
    {
        [JsonProperty("models")]
        public JobDetailsGetResponseRequestTypeModelsType Models { get; set; }

        [JsonProperty("transcription")]
        public JobDetailsGetResponseRequestTypeTranscriptionType Transcription { get; set; }

        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("files")]
        public JobDetailsGetResponseRequestTypeFilesTypeItem[] Files { get; set; }
    }

    public class JobDetailsGetResponseRequestTypeModelsType
    {
        [JsonProperty("face")]
        public JobDetailsGetResponseRequestTypeModelsTypeFaceType Face { get; set; }

        [JsonProperty("burst")]
        public JToken Burst { get; set; }

        [JsonProperty("prosody")]
        public JobDetailsGetResponseRequestTypeModelsTypeProsodyType Prosody { get; set; }

        [JsonProperty("language")]
        public JobDetailsGetResponseRequestTypeModelsTypeLanguageType Language { get; set; }

        [JsonProperty("ner")]
        public JobDetailsGetResponseRequestTypeModelsTypeNerType Ner { get; set; }

        [JsonProperty("facemesh")]
        public JToken Facemesh { get; set; }
    }

    public class JobDetailsGetResponseRequestTypeModelsTypeFaceType
    {
        [JsonProperty("fps_pred")]
        public double FpsPred { get; set; }

        [JsonProperty("prob_threshold")]
        public double ProbThreshold { get; set; }

        [JsonProperty("identify_faces")]
        public bool IdentifyFaces { get; set; }

        [JsonProperty("min_face_size")]
        public int MinFaceSize { get; set; }

        [JsonProperty("facs")]
        public JToken Facs { get; set; }

        [JsonProperty("descriptions")]
        public JToken Descriptions { get; set; }

        [JsonProperty("save_faces")]
        public bool SaveFaces { get; set; }
    }

    public class JobDetailsGetResponseRequestTypeModelsTypeProsodyType
    {
        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("identify_speakers")]
        public bool IdentifySpeakers { get; set; }

        [JsonProperty("window")]
        public JobDetailsGetResponseRequestTypeModelsTypeProsodyTypeWindowType Window { get; set; }
    }

    public class JobDetailsGetResponseRequestTypeModelsTypeProsodyTypeWindowType
    {
        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("step")]
        public int Step { get; set; }
    }

    public class JobDetailsGetResponseRequestTypeModelsTypeLanguageType
    {
        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        [JsonProperty("identify_speakers")]
        public bool IdentifySpeakers { get; set; }

        [JsonProperty("sentiment")]
        public JToken Sentiment { get; set; }

        [JsonProperty("toxicity")]
        public JToken Toxicity { get; set; }
    }

    public class JobDetailsGetResponseRequestTypeModelsTypeNerType
    {
        [JsonProperty("identify_speakers")]
        public bool IdentifySpeakers { get; set; }
    }

    public class JobDetailsGetResponseRequestTypeTranscriptionType
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class JobDetailsGetResponseRequestTypeFilesTypeItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("md5sum")]
        public string Md5sum { get; set; }
    }

    public class JobDetailsGetResponseStateType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_timestamp_ms")]
        public int CreatedTimestampMs { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hume;

    public partial class WorkflowManagedActions
    {
        public HumeActions Hume(string connectionId) => new HumeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HumeTriggers Hume(string connectionId) => new HumeTriggers(connectionId);
    }
}
