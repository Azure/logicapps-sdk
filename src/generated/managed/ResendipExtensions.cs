//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Resendip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ResendipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        [WorkflowExpressionFactory(nameof(__BuildEmail))]
        public IBodyWorkflowAction<EmailPostResponse> Email([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodycc = null, [WorkflowExpression] Func<string> bodybcc = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyhtml = null, [WorkflowExpression] Func<bodyattachmentsInputItem[]> bodyattachments = null, [WorkflowExpression] Func<string> bodyreplyTo = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmailPostResponse> __BuildEmail(WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodyto, WorkflowExpression<string> bodysubject, WorkflowExpression<string> bodycc = null, WorkflowExpression<string> bodybcc = null, WorkflowExpression<string> bodytext = null, WorkflowExpression<string> bodyhtml = null, WorkflowExpression<bodyattachmentsInputItem[]> bodyattachments = null, WorkflowExpression<string> bodyreplyTo = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            WorkflowExpression.Validate(bodycc, nameof(bodycc), required: false);
            WorkflowExpression.Validate(bodybcc, nameof(bodybcc), required: false);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowExpression.Validate(bodyhtml, nameof(bodyhtml), required: false);
            WorkflowExpression.Validate(bodyattachments, nameof(bodyattachments), required: false);
            WorkflowExpression.Validate(bodyreplyTo, nameof(bodyreplyTo), required: false);
            return new DeferredBodyAction<EmailPostResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveGet))]
        public IBodyWorkflowAction<RetrieveGetResponse> RetrieveGet([WorkflowExpression] Func<string> emailId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveGetResponse> __BuildRetrieveGet(WorkflowExpression<string> emailId)
        {
            WorkflowExpression.Validate(emailId, nameof(emailId), required: true);
            return new DeferredBodyAction<RetrieveGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailId, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildDomain))]
        public IBodyWorkflowAction<DomainPostResponse> Domain([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyregionInput> bodyregion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DomainPostResponse> __BuildDomain(WorkflowExpression<string> bodyname, WorkflowExpression<bodyregionInput> bodyregion = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            return new DeferredBodyAction<DomainPostResponse>(() =>
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
                    if (bodyregion != null)
                    {
                        body["region"] = ExpressionConverter.ConvertO(bodyregion);
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
        [WorkflowExpressionFactory(nameof(__BuildDomainDelete))]
        public IBodyWorkflowAction<string> DomainDelete([WorkflowExpression] Func<string> domainId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDomainDelete(WorkflowExpression<string> domainId)
        {
            WorkflowExpression.Validate(domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}", ExpressionConverter.ConvertWithUrlEncoding(domainId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        [WorkflowExpressionFactory(nameof(__BuildVerify))]
        public IBodyWorkflowAction<string> Verify([WorkflowExpression] Func<string> domainId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVerify(WorkflowExpression<string> domainId)
        {
            WorkflowExpression.Validate(domainId, nameof(domainId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/domains/{0}", ExpressionConverter.ConvertWithUrlEncoding(domainId, 1));
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