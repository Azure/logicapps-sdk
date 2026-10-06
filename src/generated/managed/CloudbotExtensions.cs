//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudbot
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudbotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile([WorkflowExpression] Func<xCbotContentLanguageInput> xCbotContentLanguage, [WorkflowExpression] Func<string> publicId, [WorkflowExpression] Func<string> xCbotFilename, [WorkflowExpression] Func<string> fileContents = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/services/files/temp", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(publicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = SourceExpressionConverter.Convert(xCbotContentLanguage);
                callPayload.Headers["x-cbot-filename"] = SourceExpressionConverter.ConvertO(xCbotFilename);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fileContents);
                return callPayload;
            }

            return new ApiConnectionAction<UploadFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<string> DownloadFile([WorkflowExpression] Func<xCbotContentLanguageInput> xCbotContentLanguage, [WorkflowExpression] Func<string> publicId, [WorkflowExpression] Func<string> @ref)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/services/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(publicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@ref, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = SourceExpressionConverter.Convert(xCbotContentLanguage);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<ExecuteBotResponse> ExecuteBot([WorkflowExpression] Func<xCbotContentLanguageInput> xCbotContentLanguage, [WorkflowExpression] Func<string> publicId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<bool> bodyasync, [WorkflowExpression] Func<string> bodydata1 = null, [WorkflowExpression] Func<string> bodydata2 = null, [WorkflowExpression] Func<string> bodydata3 = null, [WorkflowExpression] Func<string> bodydata4 = null, [WorkflowExpression] Func<string> bodydata5 = null, [WorkflowExpression] Func<string> bodydata6 = null, [WorkflowExpression] Func<string> bodydata7 = null, [WorkflowExpression] Func<string> bodydata8 = null, [WorkflowExpression] Func<string> bodydata9 = null, [WorkflowExpression] Func<string> bodydata10 = null, [WorkflowExpression] Func<string> bodyaPIParameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/bots/{1}/jobs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(publicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = SourceExpressionConverter.Convert(xCbotContentLanguage);
                callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["async"] = SourceExpressionConverter.ConvertToken(bodyasync);
                if (bodydata1 != null)
                {
                    body["data1"] = SourceExpressionConverter.ConvertToken(bodydata1);
                    bodypropCount++;
                }

                if (bodydata2 != null)
                {
                    body["data2"] = SourceExpressionConverter.ConvertToken(bodydata2);
                    bodypropCount++;
                }

                if (bodydata3 != null)
                {
                    body["data3"] = SourceExpressionConverter.ConvertToken(bodydata3);
                    bodypropCount++;
                }

                if (bodydata4 != null)
                {
                    body["data4"] = SourceExpressionConverter.ConvertToken(bodydata4);
                    bodypropCount++;
                }

                if (bodydata5 != null)
                {
                    body["data5"] = SourceExpressionConverter.ConvertToken(bodydata5);
                    bodypropCount++;
                }

                if (bodydata6 != null)
                {
                    body["data6"] = SourceExpressionConverter.ConvertToken(bodydata6);
                    bodypropCount++;
                }

                if (bodydata7 != null)
                {
                    body["data7"] = SourceExpressionConverter.ConvertToken(bodydata7);
                    bodypropCount++;
                }

                if (bodydata8 != null)
                {
                    body["data8"] = SourceExpressionConverter.ConvertToken(bodydata8);
                    bodypropCount++;
                }

                if (bodydata9 != null)
                {
                    body["data9"] = SourceExpressionConverter.ConvertToken(bodydata9);
                    bodypropCount++;
                }

                if (bodydata10 != null)
                {
                    body["data10"] = SourceExpressionConverter.ConvertToken(bodydata10);
                    bodypropCount++;
                }

                if (bodyaPIParameters != null)
                {
                    body["api_parameters"] = SourceExpressionConverter.ConvertToken(bodyaPIParameters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExecuteBotResponse>(BuildSourceInput);
        }
    }

    public class CloudbotTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BotDoneResponse> BotDone([WorkflowExpression] Func<xCbotContentLanguageInput> xCbotContentLanguage, [WorkflowExpression] Func<string> publicId, [WorkflowExpression] Func<string> botId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/bots/{1}/subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(publicId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = SourceExpressionConverter.Convert(xCbotContentLanguage);
                callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["event"] = "onended";
                bodypropCount++;
                body["callback_endpoint"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<BotDoneResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class UploadFileResponse
    {
        [JsonProperty("ref")]
        public string FileRef { get; set; }
    }

    public enum xCbotContentLanguageInput
    {
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "en")]
        En
    }

    public class ExecuteBotResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("job_id")]
        public string JobID { get; set; }

        [JsonProperty("bot_id")]
        public string BOTID { get; set; }

        [JsonProperty("bot_name")]
        public string BOTName { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("elapsed_time")]
        public int ElapsedTime { get; set; }

        [JsonProperty("output")]
        public ExecuteBotResponseOutputType Output { get; set; }

        [JsonProperty("cast_url")]
        public string CastURL { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ExecuteBotResponseOutputType
    {
        [JsonProperty("data1")]
        public string Data1 { get; set; }

        [JsonProperty("data2")]
        public string Data2 { get; set; }

        [JsonProperty("data3")]
        public string Data3 { get; set; }

        [JsonProperty("data4")]
        public string Data4 { get; set; }

        [JsonProperty("data5")]
        public string Data5 { get; set; }

        [JsonProperty("data6")]
        public string Data6 { get; set; }

        [JsonProperty("data7")]
        public string Data7 { get; set; }

        [JsonProperty("data8")]
        public string Data8 { get; set; }

        [JsonProperty("data9")]
        public string Data9 { get; set; }

        [JsonProperty("data10")]
        public string Data10 { get; set; }

        [JsonProperty("output_json")]
        public string OutputJSON { get; set; }
    }

    public class BotDoneResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("subscribe_id")]
        public int SubscribeId { get; set; }

        [JsonProperty("unsubscribe_endpoint")]
        public string UnsubscribeEndpoint { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudbot;

    public partial class WorkflowManagedActions
    {
        public CloudbotActions Cloudbot(string connectionId) => new CloudbotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudbotTriggers Cloudbot(string connectionId) => new CloudbotTriggers(connectionId);
    }
}