//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudbot
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudbotActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFile))]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile([WorkflowExpression] Func<xCbotContentLanguageInput> xCbotContentLanguage, [WorkflowExpression] Func<string> publicId, [WorkflowExpression] Func<string> xCbotFilename, [WorkflowExpression] Func<string> fileContents = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadFileResponse> __BuildUploadFile(WorkflowExpression<xCbotContentLanguageInput> xCbotContentLanguage, WorkflowExpression<string> publicId, WorkflowExpression<string> xCbotFilename, WorkflowExpression<string> fileContents = null)
        {
            WorkflowExpression.Validate(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            WorkflowExpression.Validate(publicId, nameof(publicId), required: true);
            WorkflowExpression.Validate(xCbotFilename, nameof(xCbotFilename), required: true);
            WorkflowExpression.Validate(fileContents, nameof(fileContents), required: false);
            return new DeferredBodyAction<UploadFileResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/services/files/temp", ExpressionConverter.ConvertWithUrlEncoding(publicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(xCbotContentLanguage);
                callPayload.Headers["x-cbot-filename"] = ExpressionConverter.Convert(xCbotFilename);
                callPayload.Body = ExpressionConverter.ConvertO(fileContents);
                return new ApiConnectionAction<UploadFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadFile))]
        public IBodyWorkflowAction<string> DownloadFile([WorkflowExpression] Func<xCbotContentLanguageInput> xCbotContentLanguage, [WorkflowExpression] Func<string> publicId, [WorkflowExpression] Func<string> @ref)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDownloadFile(WorkflowExpression<xCbotContentLanguageInput> xCbotContentLanguage, WorkflowExpression<string> publicId, WorkflowExpression<string> @ref)
        {
            WorkflowExpression.Validate(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            WorkflowExpression.Validate(publicId, nameof(publicId), required: true);
            WorkflowExpression.Validate(@ref, nameof(@ref), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/services/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(publicId, 1), ExpressionConverter.ConvertWithUrlEncoding(@ref, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(xCbotContentLanguage);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteBot))]
        public IBodyWorkflowAction<ExecuteBotResponse> ExecuteBot([WorkflowExpression] Func<xCbotContentLanguageInput> xCbotContentLanguage, [WorkflowExpression] Func<string> publicId, [WorkflowExpression] Func<string> botId, [WorkflowExpression] Func<bool> bodyasync, [WorkflowExpression] Func<string> bodydata1 = null, [WorkflowExpression] Func<string> bodydata2 = null, [WorkflowExpression] Func<string> bodydata3 = null, [WorkflowExpression] Func<string> bodydata4 = null, [WorkflowExpression] Func<string> bodydata5 = null, [WorkflowExpression] Func<string> bodydata6 = null, [WorkflowExpression] Func<string> bodydata7 = null, [WorkflowExpression] Func<string> bodydata8 = null, [WorkflowExpression] Func<string> bodydata9 = null, [WorkflowExpression] Func<string> bodydata10 = null, [WorkflowExpression] Func<string> bodyaPIParameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExecuteBotResponse> __BuildExecuteBot(WorkflowExpression<xCbotContentLanguageInput> xCbotContentLanguage, WorkflowExpression<string> publicId, WorkflowExpression<string> botId, WorkflowExpression<bool> bodyasync, WorkflowExpression<string> bodydata1 = null, WorkflowExpression<string> bodydata2 = null, WorkflowExpression<string> bodydata3 = null, WorkflowExpression<string> bodydata4 = null, WorkflowExpression<string> bodydata5 = null, WorkflowExpression<string> bodydata6 = null, WorkflowExpression<string> bodydata7 = null, WorkflowExpression<string> bodydata8 = null, WorkflowExpression<string> bodydata9 = null, WorkflowExpression<string> bodydata10 = null, WorkflowExpression<string> bodyaPIParameters = null)
        {
            WorkflowExpression.Validate(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            WorkflowExpression.Validate(publicId, nameof(publicId), required: true);
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            WorkflowExpression.Validate(bodyasync, nameof(bodyasync), required: true);
            WorkflowExpression.Validate(bodydata1, nameof(bodydata1), required: false);
            WorkflowExpression.Validate(bodydata2, nameof(bodydata2), required: false);
            WorkflowExpression.Validate(bodydata3, nameof(bodydata3), required: false);
            WorkflowExpression.Validate(bodydata4, nameof(bodydata4), required: false);
            WorkflowExpression.Validate(bodydata5, nameof(bodydata5), required: false);
            WorkflowExpression.Validate(bodydata6, nameof(bodydata6), required: false);
            WorkflowExpression.Validate(bodydata7, nameof(bodydata7), required: false);
            WorkflowExpression.Validate(bodydata8, nameof(bodydata8), required: false);
            WorkflowExpression.Validate(bodydata9, nameof(bodydata9), required: false);
            WorkflowExpression.Validate(bodydata10, nameof(bodydata10), required: false);
            WorkflowExpression.Validate(bodyaPIParameters, nameof(bodyaPIParameters), required: false);
            return new DeferredBodyAction<ExecuteBotResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/bots/{1}/jobs", ExpressionConverter.ConvertWithUrlEncoding(publicId, 1), ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(xCbotContentLanguage);
                callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                if (bodydata1 != null)
                {
                    body["data1"] = ExpressionConverter.ConvertO(bodydata1);
                    bodypropCount++;
                }

                if (bodydata2 != null)
                {
                    body["data2"] = ExpressionConverter.ConvertO(bodydata2);
                    bodypropCount++;
                }

                if (bodydata3 != null)
                {
                    body["data3"] = ExpressionConverter.ConvertO(bodydata3);
                    bodypropCount++;
                }

                if (bodydata4 != null)
                {
                    body["data4"] = ExpressionConverter.ConvertO(bodydata4);
                    bodypropCount++;
                }

                if (bodydata5 != null)
                {
                    body["data5"] = ExpressionConverter.ConvertO(bodydata5);
                    bodypropCount++;
                }

                if (bodydata6 != null)
                {
                    body["data6"] = ExpressionConverter.ConvertO(bodydata6);
                    bodypropCount++;
                }

                if (bodydata7 != null)
                {
                    body["data7"] = ExpressionConverter.ConvertO(bodydata7);
                    bodypropCount++;
                }

                if (bodydata8 != null)
                {
                    body["data8"] = ExpressionConverter.ConvertO(bodydata8);
                    bodypropCount++;
                }

                if (bodydata9 != null)
                {
                    body["data9"] = ExpressionConverter.ConvertO(bodydata9);
                    bodypropCount++;
                }

                if (bodydata10 != null)
                {
                    body["data10"] = ExpressionConverter.ConvertO(bodydata10);
                    bodypropCount++;
                }

                if (bodyaPIParameters != null)
                {
                    body["api_parameters"] = ExpressionConverter.ConvertO(bodyaPIParameters);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExecuteBotResponse>(callPayload);
            });
        }
    }

    public class CloudbotTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildBotDone))]
        public IBodyWorkflowTrigger<BotDoneResponse> BotDone([WorkflowExpression] Func<xCbotContentLanguageInput> xCbotContentLanguage,[WorkflowExpression] Func<string> publicId,[WorkflowExpression] Func<string> botId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<BotDoneResponse> __BuildBotDone(WorkflowExpression<xCbotContentLanguageInput> xCbotContentLanguage,WorkflowExpression<string> publicId,WorkflowExpression<string> botId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            WorkflowExpression.Validate(publicId, nameof(publicId), required: true);
            WorkflowExpression.Validate(botId, nameof(botId), required: true);
            return new DeferredBodyTrigger<BotDoneResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/bots/{1}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(publicId, 1), ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(xCbotContentLanguage);
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

                return new ApiConnectionTrigger<BotDoneResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class UploadFileResponse
    {
        [JsonProperty("ref")]
        public string FileRef { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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