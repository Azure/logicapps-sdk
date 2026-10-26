//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Resendip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ResendipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<EmailPostResponse, ApiConnectionActionConfiguration> Email(Expression<Func<EmailPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EmailPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmailPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<RetrieveGetResponse, ApiConnectionActionConfiguration> RetrieveGet(Expression<Func<string>> emailId)
        {
            var __workflow_emailId = WorkflowExpression.Compile(emailId, nameof(emailId), required: true);
            return new DeferredBodyAction<RetrieveGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/emails/{0}", __workflow_emailId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RetrieveGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<ListGetResponse, ApiConnectionActionConfiguration> ListGet()
        {
            return new DeferredBodyAction<ListGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<DomainPostResponse, ApiConnectionActionConfiguration> Domain(Expression<Func<DomainPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DomainPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DomainPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DomainDelete(Expression<Func<string>> domainId)
        {
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}", __workflow_domainId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Verify(Expression<Func<string>> domainId)
        {
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/domains/{0}", __workflow_domainId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
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

    public class EmailPostInput
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("cc")]
        public string Cc { get; set; }

        [JsonProperty("bcc")]
        public string Bcc { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("attachments")]
        public EmailPostInputAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("reply_to")]
        public string ReplyTo { get; set; }
    }

    public class EmailPostInputAttachmentsTypeItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class RetrieveGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

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

    public class DomainPostInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("region", DefaultValueHandling = DefaultValueHandling.Include)]
        public DomainPostInputRegionType? Region { get; set; } = DomainPostInputRegionType.UsEast1;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DomainPostInputRegionType
    {
        [EnumMember(Value = "us-east-1")]
        UsEast1,
        [EnumMember(Value = "eu-west-1")]
        EuWest1,
        [EnumMember(Value = "sa-east-1")]
        SaEast1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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