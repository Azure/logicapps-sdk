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
        public IBodyWorkflowAction<EmailPostResponse> Email([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<string> bodycc = null, [WorkflowExpression] Func<string> bodybcc = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyhtml = null, [WorkflowExpression] Func<bodyattachmentsInputItem[]> bodyattachments = null, [WorkflowExpression] Func<string> bodyreplyTo = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(bodycc, nameof(bodycc), required: false);
            SourceExpression.Validate(bodybcc, nameof(bodybcc), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyhtml, nameof(bodyhtml), required: false);
            SourceExpression.Validate(bodyattachments, nameof(bodyattachments), required: false);
            SourceExpression.Validate(bodyreplyTo, nameof(bodyreplyTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/emails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                if (bodycc != null)
                {
                    body["cc"] = SourceExpressionConverter.ConvertToken(bodycc);
                    bodypropCount++;
                }

                if (bodybcc != null)
                {
                    body["bcc"] = SourceExpressionConverter.ConvertToken(bodybcc);
                    bodypropCount++;
                }

                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyhtml != null)
                {
                    body["html"] = SourceExpressionConverter.ConvertToken(bodyhtml);
                    bodypropCount++;
                }

                if (bodyattachments != null)
                {
                    body["attachments"] = SourceExpressionConverter.ConvertToken(bodyattachments);
                    bodypropCount++;
                }

                if (bodyreplyTo != null)
                {
                    body["reply_to"] = SourceExpressionConverter.ConvertToken(bodyreplyTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmailPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<RetrieveGetResponse> RetrieveGet([WorkflowExpression] Func<string> emailId)
        {
            SourceExpression.Validate(emailId, nameof(emailId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/emails/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<ListGetResponse> ListGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<DomainPostResponse> Domain([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyregionInput> bodyregion = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyregion, nameof(bodyregion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/domains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyregion != null)
                {
                    if (bodyregion != null)
                    {
                        body["region"] = SourceExpressionConverter.Convert(bodyregion);
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
                return callPayload;
            }

            return new ApiConnectionAction<DomainPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<string> DomainDelete([WorkflowExpression] Func<string> domainId)
        {
            SourceExpression.Validate(domainId, nameof(domainId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "resendip")]
        public IBodyWorkflowAction<string> Verify([WorkflowExpression] Func<string> domainId)
        {
            SourceExpression.Validate(domainId, nameof(domainId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/domains/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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