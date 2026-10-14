//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Resendip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ResendipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<EmailPostResponse> Email(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodysubject, Expression<Func<string>> bodycc = null, Expression<Func<string>> bodybcc = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyhtml = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null, Expression<Func<string>> bodyreplyTo = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodycc = bodycc == null ? null : WorkflowExpression.Compile(bodycc);
            WorkflowExpression.Validate(__workflow_bodycc, nameof(bodycc), required: false);
            var __workflow_bodybcc = bodybcc == null ? null : WorkflowExpression.Compile(bodybcc);
            WorkflowExpression.Validate(__workflow_bodybcc, nameof(bodybcc), required: false);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: false);
            var __workflow_bodyhtml = bodyhtml == null ? null : WorkflowExpression.Compile(bodyhtml);
            WorkflowExpression.Validate(__workflow_bodyhtml, nameof(bodyhtml), required: false);
            var __workflow_bodyattachments = bodyattachments == null ? null : WorkflowExpression.Compile(bodyattachments);
            WorkflowExpression.Validate(__workflow_bodyattachments, nameof(bodyattachments), required: false);
            var __workflow_bodyreplyTo = bodyreplyTo == null ? null : WorkflowExpression.Compile(bodyreplyTo);
            WorkflowExpression.Validate(__workflow_bodyreplyTo, nameof(bodyreplyTo), required: false);
            return new DeferredBodyAction<EmailPostResponse>(() =>
            {
                var apiCallPath = "/emails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                if (__workflow_bodycc != null)
                {
                    body["cc"] = ExpressionConverter.ConvertO(__workflow_bodycc);
                    bodypropCount++;
                }

                if (__workflow_bodybcc != null)
                {
                    body["bcc"] = ExpressionConverter.ConvertO(__workflow_bodybcc);
                    bodypropCount++;
                }

                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyhtml != null)
                {
                    body["html"] = ExpressionConverter.ConvertO(__workflow_bodyhtml);
                    bodypropCount++;
                }

                if (__workflow_bodyattachments != null)
                {
                    body["attachments"] = ExpressionConverter.ConvertO(__workflow_bodyattachments);
                    bodypropCount++;
                }

                if (__workflow_bodyreplyTo != null)
                {
                    body["reply_to"] = ExpressionConverter.ConvertO(__workflow_bodyreplyTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EmailPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<RetrieveGetResponse> RetrieveGet(Expression<Func<string>> emailId)
        {
            var __workflow_emailId = emailId == null ? null : WorkflowExpression.Compile(emailId);
            WorkflowExpression.Validate(__workflow_emailId, nameof(emailId), required: true);
            return new DeferredBodyAction<RetrieveGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_emailId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RetrieveGetResponse>(callPayload);
            });
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
        public IBodyWorkflowAction<DomainPostResponse> Domain(Expression<Func<string>> bodyname, Expression<Func<bodyregionInput>> bodyregion = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyregion = bodyregion == null ? null : WorkflowExpression.Compile(bodyregion);
            WorkflowExpression.Validate(__workflow_bodyregion, nameof(bodyregion), required: false);
            return new DeferredBodyAction<DomainPostResponse>(() =>
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyregion != null)
                {
                    if (__workflow_bodyregion != null)
                    {
                        body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["region"] = "us-east-1";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DomainPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<string> DomainDelete(Expression<Func<string>> domainId)
        {
            var __workflow_domainId = domainId == null ? null : WorkflowExpression.Compile(domainId);
            WorkflowExpression.Validate(__workflow_domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domainId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<string> Verify(Expression<Func<string>> domainId)
        {
            var __workflow_domainId = domainId == null ? null : WorkflowExpression.Compile(domainId);
            WorkflowExpression.Validate(__workflow_domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_domainId, 1));
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
