//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudbot
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudbotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<UploadFileResponse, ApiConnectionActionConfiguration> UploadFile(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> xCbotFilename, Expression<Func<string>> fileContents = null)
        {
            var __workflow_xCbotContentLanguage = WorkflowExpression.Compile(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: true);
            var __workflow_xCbotFilename = WorkflowExpression.Compile(xCbotFilename, nameof(xCbotFilename), required: true);
            var __workflow_fileContents = WorkflowExpression.Compile(fileContents, nameof(fileContents), required: false);
            return new DeferredBodyAction<UploadFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/services/files/temp", __workflow_publicId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(__workflow_xCbotContentLanguage);
                callPayload.Headers["x-cbot-filename"] = ExpressionConverter.Convert(__workflow_xCbotFilename);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileContents);
                return new ApiConnectionAction<UploadFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadFile(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> @ref)
        {
            var __workflow_xCbotContentLanguage = WorkflowExpression.Compile(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: true);
            var __workflow_ref = WorkflowExpression.Compile(@ref, nameof(@ref), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/services/files/{1}", __workflow_publicId.WithUrlEncoding(1), __workflow_ref.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(__workflow_xCbotContentLanguage);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<ExecuteBotResponse, ApiConnectionActionConfiguration> ExecuteBot(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> botId, Expression<Func<bool>> bodyasync, Expression<Func<string>> bodydata1 = null, Expression<Func<string>> bodydata2 = null, Expression<Func<string>> bodydata3 = null, Expression<Func<string>> bodydata4 = null, Expression<Func<string>> bodydata5 = null, Expression<Func<string>> bodydata6 = null, Expression<Func<string>> bodydata7 = null, Expression<Func<string>> bodydata8 = null, Expression<Func<string>> bodydata9 = null, Expression<Func<string>> bodydata10 = null, Expression<Func<string>> bodyaPIParameters = null)
        {
            var __workflow_xCbotContentLanguage = WorkflowExpression.Compile(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_bodyasync = WorkflowExpression.Compile(bodyasync, nameof(bodyasync), required: true);
            var __workflow_bodydata1 = WorkflowExpression.Compile(bodydata1, nameof(bodydata1), required: false);
            var __workflow_bodydata2 = WorkflowExpression.Compile(bodydata2, nameof(bodydata2), required: false);
            var __workflow_bodydata3 = WorkflowExpression.Compile(bodydata3, nameof(bodydata3), required: false);
            var __workflow_bodydata4 = WorkflowExpression.Compile(bodydata4, nameof(bodydata4), required: false);
            var __workflow_bodydata5 = WorkflowExpression.Compile(bodydata5, nameof(bodydata5), required: false);
            var __workflow_bodydata6 = WorkflowExpression.Compile(bodydata6, nameof(bodydata6), required: false);
            var __workflow_bodydata7 = WorkflowExpression.Compile(bodydata7, nameof(bodydata7), required: false);
            var __workflow_bodydata8 = WorkflowExpression.Compile(bodydata8, nameof(bodydata8), required: false);
            var __workflow_bodydata9 = WorkflowExpression.Compile(bodydata9, nameof(bodydata9), required: false);
            var __workflow_bodydata10 = WorkflowExpression.Compile(bodydata10, nameof(bodydata10), required: false);
            var __workflow_bodyaPIParameters = WorkflowExpression.Compile(bodyaPIParameters, nameof(bodyaPIParameters), required: false);
            return new DeferredBodyAction<ExecuteBotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bots/{1}/jobs", __workflow_publicId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(__workflow_xCbotContentLanguage);
                callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["async"] = ExpressionConverter.ConvertO(__workflow_bodyasync);
                if (__workflow_bodydata1 != null)
                {
                    body["data1"] = ExpressionConverter.ConvertO(__workflow_bodydata1);
                    bodypropCount++;
                }

                if (__workflow_bodydata2 != null)
                {
                    body["data2"] = ExpressionConverter.ConvertO(__workflow_bodydata2);
                    bodypropCount++;
                }

                if (__workflow_bodydata3 != null)
                {
                    body["data3"] = ExpressionConverter.ConvertO(__workflow_bodydata3);
                    bodypropCount++;
                }

                if (__workflow_bodydata4 != null)
                {
                    body["data4"] = ExpressionConverter.ConvertO(__workflow_bodydata4);
                    bodypropCount++;
                }

                if (__workflow_bodydata5 != null)
                {
                    body["data5"] = ExpressionConverter.ConvertO(__workflow_bodydata5);
                    bodypropCount++;
                }

                if (__workflow_bodydata6 != null)
                {
                    body["data6"] = ExpressionConverter.ConvertO(__workflow_bodydata6);
                    bodypropCount++;
                }

                if (__workflow_bodydata7 != null)
                {
                    body["data7"] = ExpressionConverter.ConvertO(__workflow_bodydata7);
                    bodypropCount++;
                }

                if (__workflow_bodydata8 != null)
                {
                    body["data8"] = ExpressionConverter.ConvertO(__workflow_bodydata8);
                    bodypropCount++;
                }

                if (__workflow_bodydata9 != null)
                {
                    body["data9"] = ExpressionConverter.ConvertO(__workflow_bodydata9);
                    bodypropCount++;
                }

                if (__workflow_bodydata10 != null)
                {
                    body["data10"] = ExpressionConverter.ConvertO(__workflow_bodydata10);
                    bodypropCount++;
                }

                if (__workflow_bodyaPIParameters != null)
                {
                    body["api_parameters"] = ExpressionConverter.ConvertO(__workflow_bodyaPIParameters);
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
        public IBodyWorkflowTrigger<BotDoneResponse, ApiConnectionTriggerConfiguration> BotDone(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> botId, FlowRecurrence recurrence = null)
        {
            var __workflow_xCbotContentLanguage = WorkflowExpression.Compile(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            return new DeferredBodyTrigger<BotDoneResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bots/{1}/subscriptions", __workflow_publicId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(__workflow_xCbotContentLanguage);
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
