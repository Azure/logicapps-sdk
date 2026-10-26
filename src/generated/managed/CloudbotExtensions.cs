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
        public IBodyWorkflowAction<UploadFileResponse, ApiConnectionActionConfiguration> UploadFile(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> xCbotFilename, Expression<Func<string>> fileContents)
        {
            var __workflow_xCbotContentLanguage = WorkflowExpression.Compile(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: true);
            var __workflow_xCbotFilename = WorkflowExpression.Compile(xCbotFilename, nameof(xCbotFilename), required: true);
            var __workflow_fileContents = WorkflowExpression.Compile(fileContents, nameof(fileContents), required: true);
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
        public IBodyWorkflowAction<ExecuteBotResponse, ApiConnectionActionConfiguration> ExecuteBot(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> botId, Expression<Func<ExecuteBotInput>> body)
        {
            var __workflow_xCbotContentLanguage = WorkflowExpression.Compile(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExecuteBotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bots/{1}/jobs", __workflow_publicId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(__workflow_xCbotContentLanguage);
                callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExecuteBotResponse>(callPayload);
            });
        }
    }

    public class CloudbotTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BotDoneResponse, ApiConnectionTriggerConfiguration> BotDone(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> botId, Expression<Func<BotDoneInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_xCbotContentLanguage = WorkflowExpression.Compile(xCbotContentLanguage, nameof(xCbotContentLanguage), required: true);
            var __workflow_publicId = WorkflowExpression.Compile(publicId, nameof(publicId), required: true);
            var __workflow_botId = WorkflowExpression.Compile(botId, nameof(botId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<BotDoneResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/bots/{1}/subscriptions", __workflow_publicId.WithUrlEncoding(1), __workflow_botId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(__workflow_xCbotContentLanguage);
                callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public string JobId { get; set; }

        [JsonProperty("bot_id")]
        public string BOTId { get; set; }

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

    public class ExecuteBotInput
    {
        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Async { get; set; }

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

        [JsonProperty("api_parameters")]
        public string APIParameters { get; set; }
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

    public class BotDoneInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Event { get; set; } = "onended";

        [JsonProperty("callback_endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackEndpoint { get; set; } = "#{listCallbackUrl()}";
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