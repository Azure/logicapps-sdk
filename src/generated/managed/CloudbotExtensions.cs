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
        public IBodyWorkflowAction<UploadFileResponse> UploadFile(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> xCbotFilename, Expression<Func<string>> fileContents = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/services/files/temp", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(publicId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-cbot-content-language"] = CSharpExpressionConverter.Convert(xCbotContentLanguage);
            callPayload.Headers["x-cbot-filename"] = CSharpExpressionConverter.ConvertO(xCbotFilename);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fileContents);
            return new ApiConnectionAction<UploadFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<string> DownloadFile(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> @ref)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/services/files/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(publicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(@ref, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-cbot-content-language"] = CSharpExpressionConverter.Convert(xCbotContentLanguage);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<ExecuteBotResponse> ExecuteBot(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> botId, Expression<Func<bool>> bodyasync, Expression<Func<string>> bodydata1 = null, Expression<Func<string>> bodydata2 = null, Expression<Func<string>> bodydata3 = null, Expression<Func<string>> bodydata4 = null, Expression<Func<string>> bodydata5 = null, Expression<Func<string>> bodydata6 = null, Expression<Func<string>> bodydata7 = null, Expression<Func<string>> bodydata8 = null, Expression<Func<string>> bodydata9 = null, Expression<Func<string>> bodydata10 = null, Expression<Func<string>> bodyaPIParameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/bots/{1}/jobs", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(publicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-cbot-content-language"] = CSharpExpressionConverter.Convert(xCbotContentLanguage);
            callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["async"] = CSharpExpressionConverter.ConvertToken(bodyasync);
            if (bodydata1 != null)
            {
                body["data1"] = CSharpExpressionConverter.ConvertToken(bodydata1);
                bodypropCount++;
            }

            if (bodydata2 != null)
            {
                body["data2"] = CSharpExpressionConverter.ConvertToken(bodydata2);
                bodypropCount++;
            }

            if (bodydata3 != null)
            {
                body["data3"] = CSharpExpressionConverter.ConvertToken(bodydata3);
                bodypropCount++;
            }

            if (bodydata4 != null)
            {
                body["data4"] = CSharpExpressionConverter.ConvertToken(bodydata4);
                bodypropCount++;
            }

            if (bodydata5 != null)
            {
                body["data5"] = CSharpExpressionConverter.ConvertToken(bodydata5);
                bodypropCount++;
            }

            if (bodydata6 != null)
            {
                body["data6"] = CSharpExpressionConverter.ConvertToken(bodydata6);
                bodypropCount++;
            }

            if (bodydata7 != null)
            {
                body["data7"] = CSharpExpressionConverter.ConvertToken(bodydata7);
                bodypropCount++;
            }

            if (bodydata8 != null)
            {
                body["data8"] = CSharpExpressionConverter.ConvertToken(bodydata8);
                bodypropCount++;
            }

            if (bodydata9 != null)
            {
                body["data9"] = CSharpExpressionConverter.ConvertToken(bodydata9);
                bodypropCount++;
            }

            if (bodydata10 != null)
            {
                body["data10"] = CSharpExpressionConverter.ConvertToken(bodydata10);
                bodypropCount++;
            }

            if (bodyaPIParameters != null)
            {
                body["api_parameters"] = CSharpExpressionConverter.ConvertToken(bodyaPIParameters);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExecuteBotResponse>(callPayload);
        }
    }

    public class CloudbotTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<BotDoneResponse> BotDone(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> botId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/bots/{1}/subscriptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(publicId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(botId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-cbot-content-language"] = CSharpExpressionConverter.Convert(xCbotContentLanguage);
            callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["event"] = "onended";
            bodypropCount++;
            body["callback_endpoint"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<BotDoneResponse>(callPayload, triggerName, recurrence);
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