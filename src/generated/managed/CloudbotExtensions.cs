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
            var apiCallPath = String.Format("/{0}/services/files/temp", ExpressionConverter.ConvertWithUrlEncoding(publicId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(xCbotContentLanguage);
            callPayload.Headers["x-cbot-filename"] = ExpressionConverter.Convert(xCbotFilename);
            callPayload.Body = ExpressionConverter.ConvertO(fileContents);
            return new ApiConnectionAction<UploadFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<string> DownloadFile(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> @ref)
        {
            var apiCallPath = String.Format("/{0}/services/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(publicId, 1), ExpressionConverter.ConvertWithUrlEncoding(@ref, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(xCbotContentLanguage);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudbot")]
        public IBodyWorkflowAction<ExecuteBotResponse> ExecuteBot(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> botId, Expression<Func<bool>> bodyasync, Expression<Func<string>> bodydata1 = null, Expression<Func<string>> bodydata2 = null, Expression<Func<string>> bodydata3 = null, Expression<Func<string>> bodydata4 = null, Expression<Func<string>> bodydata5 = null, Expression<Func<string>> bodydata6 = null, Expression<Func<string>> bodydata7 = null, Expression<Func<string>> bodydata8 = null, Expression<Func<string>> bodydata9 = null, Expression<Func<string>> bodydata10 = null, Expression<Func<string>> bodyaPIParameters = null)
        {
            var apiCallPath = String.Format("/{0}/bots/{1}/jobs", ExpressionConverter.ConvertWithUrlEncoding(publicId, 1), ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
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
        }
    }

    public class CloudbotTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<BotDoneResponse> BotDone(Expression<Func<xCbotContentLanguageInput>> xCbotContentLanguage, Expression<Func<string>> publicId, Expression<Func<string>> botId, string triggerName = null)
        {
            var apiCallPath = String.Format("/{0}/bots/{1}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(publicId, 1), ExpressionConverter.ConvertWithUrlEncoding(botId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-cbot-content-language"] = ExpressionConverter.Convert(xCbotContentLanguage);
            callPayload.Headers["x-cbot-content-type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["event"] = "onended";
            bodypropCount++;
            body["callback_endpoint"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<BotDoneResponse>(callPayload);
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