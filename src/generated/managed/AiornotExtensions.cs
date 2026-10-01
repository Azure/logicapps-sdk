//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aiornot
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AiornotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiornot")]
        public IBodyWorkflowAction<IsLiveResponse> IsLive()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/system/live";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IsLiveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiornot")]
        public IBodyWorkflowAction<ImageReportResponse> ImageReport([WorkflowExpression] Func<string> bodyObject)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/reports/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["object"] = SourceExpressionConverter.ConvertToken(bodyObject);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImageReportResponse>(BuildSourceInput);
        }
    }

    public class AiornotTriggers([ConnectionName] string connectionId)
    {
    }

    public class IsLiveResponse
    {
        [JsonProperty("is_live")]
        public bool IsLive { get; set; }
    }

    public class ImageReportResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("report")]
        public ImageReportResponseReportType Report { get; set; }

        [JsonProperty("facets")]
        public ImageReportResponseFacetsType Facets { get; set; }
    }

    public class ImageReportResponseReportType
    {
        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("ai")]
        public ImageReportResponseReportTypeAiType Ai { get; set; }

        [JsonProperty("human")]
        public ImageReportResponseReportTypeHumanType Human { get; set; }

        [JsonProperty("generator")]
        public ImageReportResponseReportTypeGeneratorType Generator { get; set; }
    }

    public class ImageReportResponseReportTypeAiType
    {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("is_detected")]
        public bool IsDetected { get; set; }
    }

    public class ImageReportResponseReportTypeHumanType
    {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("is_detected")]
        public bool IsDetected { get; set; }
    }

    public class ImageReportResponseReportTypeGeneratorType
    {
        [JsonProperty("midjourney")]
        public AiGenerator Midjourney { get; set; }

        [JsonProperty("dall_e")]
        public AiGenerator DallE { get; set; }

        [JsonProperty("stable_diffusion")]
        public AiGenerator StableDiffusion { get; set; }

        [JsonProperty("this_person_does_not_exist")]
        public AiGenerator ThisPersonDoesNotExist { get; set; }
    }

    public class AiGenerator
    {
        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("is_detected")]
        public bool IsDetected { get; set; }
    }

    public class ImageReportResponseFacetsType
    {
        [JsonProperty("quality")]
        public ImageReportResponseFacetsTypeQualityType Quality { get; set; }

        [JsonProperty("nsfw")]
        public ImageReportResponseFacetsTypeNsfwType Nsfw { get; set; }
    }

    public class ImageReportResponseFacetsTypeQualityType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_detected")]
        public bool IsDetected { get; set; }
    }

    public class ImageReportResponseFacetsTypeNsfwType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("is_detected")]
        public bool IsDetected { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aiornot;

    public partial class WorkflowManagedActions
    {
        public AiornotActions Aiornot(string connectionId) => new AiornotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AiornotTriggers Aiornot(string connectionId) => new AiornotTriggers(connectionId);
    }
}