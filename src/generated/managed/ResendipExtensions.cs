//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Resendip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ResendipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<EmailPostResponse> EmailPost(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodysubject, Expression<Func<string>> bodycc = null, Expression<Func<string>> bodybcc = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyhtml = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null, Expression<Func<string>> bodyreplyTo = null)
        {
            var apiCallPath = "/emails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodyfrom);
            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodyto);
            if (bodycc != null)
            {
                body["cc"] = ExpressionConverter.ConvertO(bodycc);
                bodypropCount++;
            }

            if (bodybcc != null)
            {
                body["bcc"] = ExpressionConverter.ConvertO(bodybcc);
                bodypropCount++;
            }

            bodypropCount++;
            body["subject"] = ExpressionConverter.ConvertO(bodysubject);
            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodyhtml != null)
            {
                body["html"] = ExpressionConverter.ConvertO(bodyhtml);
                bodypropCount++;
            }

            if (bodyattachments != null)
            {
                body["attachments"] = ExpressionConverter.ConvertO(bodyattachments);
                bodypropCount++;
            }

            if (bodyreplyTo != null)
            {
                body["reply_to"] = ExpressionConverter.ConvertO(bodyreplyTo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EmailPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<RetrieveGetResponse> RetrieveGet(Expression<Func<string>> emailId)
        {
            var apiCallPath = String.Format("/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RetrieveGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<ListGetResponse> ListGet()
        {
            var apiCallPath = "/domains";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<DomainPostResponse> DomainPost(Expression<Func<string>> bodyname, Expression<Func<bodyregionInput>> bodyregion = null)
        {
            var apiCallPath = "/domains";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DomainPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<string> DomainDelete(Expression<Func<string>> domainId)
        {
            var apiCallPath = String.Format("/domains/{0}", ExpressionConverter.ConvertWithUrlEncoding(domainId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<string> VerifyPost(Expression<Func<string>> domainId)
        {
            var apiCallPath = String.Format("/domains/{0}", ExpressionConverter.ConvertWithUrlEncoding(domainId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class ResendipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EmailPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class bodyattachmentsInputItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class RetrieveGetResponse
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("to")]
        public string[] To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("bcc")]
        public string Bcc { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("reply_to")]
        public string ReplyTo { get; set; }

        [JsonProperty("last_event")]
        public string LastEvent { get; set; }
    }

    public class ListGetResponse
    {
        [JsonProperty("data")]
        public ListGetResponseDataTypeItem[] Data { get; set; }
    }

    public class ListGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }
    }

    public class DomainPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("records")]
        public DomainPostResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("dnsProvider")]
        public string DnsProvider { get; set; }
    }

    public class DomainPostResponseRecordsTypeItem
    {
        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("ttl")]
        public string Ttl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }
    }

    public enum bodyregionInput
    {
        [EnumMember(Value = "us-east-1")]
        UsEast1,
        [EnumMember(Value = "eu-west-1")]
        EuWest1,
        [EnumMember(Value = "sa-east-1")]
        SaEast1
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Resendip;

    public partial class WorkflowManagedActions
    {
        public ResendipActions Resendip(string connectionId) => new ResendipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ResendipTriggers Resendip(string connectionId) => new ResendipTriggers(connectionId);
    }
}