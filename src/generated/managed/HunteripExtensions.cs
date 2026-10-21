//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hunterip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HunteripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        public IBodyWorkflowAction<DomainResponse> Domain(Expression<Func<string>> domain = null, Expression<Func<string>> company = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<typeInput>> type = null, Expression<Func<string>> seniority = null, Expression<Func<string>> department = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: false);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_seniority = WorkflowExpression.Compile(seniority, nameof(seniority), required: false);
            var __workflow_department = WorkflowExpression.Compile(department, nameof(department), required: false);
            return new DeferredBodyAction<DomainResponse>(() =>
            {
                var apiCallPath = "/domain-search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(__workflow_domain);
                if (__workflow_company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_seniority != null)
                    callPayload.Queries["seniority"] = ExpressionConverter.Convert(__workflow_seniority);
                if (__workflow_department != null)
                    callPayload.Queries["department"] = ExpressionConverter.Convert(__workflow_department);
                return new ApiConnectionAction<DomainResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        public IBodyWorkflowAction<EmailResponse> Email(Expression<Func<string>> domain = null, Expression<Func<string>> company = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> fullName = null, Expression<Func<int>> maxDuration = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: false);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_fullName = WorkflowExpression.Compile(fullName, nameof(fullName), required: false);
            var __workflow_maxDuration = WorkflowExpression.Compile(maxDuration, nameof(maxDuration), required: false);
            return new DeferredBodyAction<EmailResponse>(() =>
            {
                var apiCallPath = "/email-finder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(__workflow_domain);
                if (__workflow_company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["last_name"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_fullName != null)
                    callPayload.Queries["full_name"] = ExpressionConverter.Convert(__workflow_fullName);
                if (__workflow_maxDuration != null)
                    callPayload.Queries["max_duration"] = ExpressionConverter.Convert(__workflow_maxDuration);
                return new ApiConnectionAction<EmailResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        public IBodyWorkflowAction<AuthorResponse> Author(Expression<Func<string>> url, Expression<Func<int>> maxDuration = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            var __workflow_maxDuration = WorkflowExpression.Compile(maxDuration, nameof(maxDuration), required: false);
            return new DeferredBodyAction<AuthorResponse>(() =>
            {
                var apiCallPath = "/author-finder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_maxDuration != null)
                    callPayload.Queries["max_duration"] = ExpressionConverter.Convert(__workflow_maxDuration);
                return new ApiConnectionAction<AuthorResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        public IBodyWorkflowAction<EmailVerifyResponse> EmailVerify(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<EmailVerifyResponse>(() =>
            {
                var apiCallPath = "/email-verifier";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<EmailVerifyResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        public IBodyWorkflowAction<EmailCountResponse> EmailCount(Expression<Func<string>> domain = null, Expression<Func<string>> company = null, Expression<Func<typeInput>> type = null)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: false);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<EmailCountResponse>(() =>
            {
                var apiCallPath = "/email-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(__workflow_domain);
                if (__workflow_company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<EmailCountResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class HunteripTriggers([ConnectionName] string connectionId)
    {
    }

    public class DomainResponse
    {
        [JsonProperty("data")]
        public DomainResponseDataType Data { get; set; }

        [JsonProperty("meta")]
        public DomainResponseMetaType Meta { get; set; }
    }

    public class DomainResponseDataType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("disposable")]
        public bool Disposable { get; set; }

        [JsonProperty("webmail")]
        public bool Webmail { get; set; }

        [JsonProperty("accept_all")]
        public bool AcceptAll { get; set; }

        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("emails")]
        public DomainResponseDataTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("linked_domains")]
        public JToken[] LinkedDomains { get; set; }
    }

    public class DomainResponseDataTypeEmailsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("sources")]
        public DomainResponseDataTypeEmailsTypeItemSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("seniority")]
        public string Seniority { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("verification")]
        public DomainResponseDataTypeEmailsTypeItemVerificationType Verification { get; set; }
    }

    public class DomainResponseDataTypeEmailsTypeItemSourcesTypeItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("extracted_on")]
        public string ExtractedOn { get; set; }

        [JsonProperty("last_seen_on")]
        public string LastSeenOn { get; set; }

        [JsonProperty("still_on_page")]
        public bool StillOnPage { get; set; }
    }

    public class DomainResponseDataTypeEmailsTypeItemVerificationType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DomainResponseMetaType
    {
        [JsonProperty("results")]
        public int Results { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("params")]
        public DomainResponseMetaTypeParamsType Params { get; set; }
    }

    public class DomainResponseMetaTypeParamsType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("seniority")]
        public string Seniority { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "generic")]
        Generic
    }

    public class EmailResponse
    {
        [JsonProperty("data")]
        public EmailResponseDataType Data { get; set; }

        [JsonProperty("meta")]
        public EmailResponseMetaType Meta { get; set; }
    }

    public class EmailResponseDataType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("accept_all")]
        public bool AcceptAll { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("sources")]
        public EmailResponseDataTypeSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("verification")]
        public EmailResponseDataTypeVerificationType Verification { get; set; }
    }

    public class EmailResponseDataTypeSourcesTypeItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("extracted_on")]
        public string ExtractedOn { get; set; }

        [JsonProperty("last_seen_on")]
        public string LastSeenOn { get; set; }

        [JsonProperty("still_on_page")]
        public bool StillOnPage { get; set; }
    }

    public class EmailResponseDataTypeVerificationType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class EmailResponseMetaType
    {
        [JsonProperty("params")]
        public EmailResponseMetaTypeParamsType Params { get; set; }
    }

    public class EmailResponseMetaTypeParamsType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("max_duration")]
        public string MaxDuration { get; set; }
    }

    public class AuthorResponse
    {
        [JsonProperty("data")]
        public AuthorResponseDataType Data { get; set; }

        [JsonProperty("meta")]
        public AuthorResponseMetaType Meta { get; set; }
    }

    public class AuthorResponseDataType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("accept_all")]
        public bool AcceptAll { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedin_url")]
        public string LinkedinUrl { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("sources")]
        public AuthorResponseDataTypeSourcesTypeItem[] Sources { get; set; }

        [JsonProperty("verification")]
        public AuthorResponseDataTypeVerificationType Verification { get; set; }
    }

    public class AuthorResponseDataTypeSourcesTypeItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("extracted_on")]
        public string ExtractedOn { get; set; }

        [JsonProperty("last_seen_on")]
        public string LastSeenOn { get; set; }

        [JsonProperty("still_on_page")]
        public bool StillOnPage { get; set; }
    }

    public class AuthorResponseDataTypeVerificationType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AuthorResponseMetaType
    {
        [JsonProperty("params")]
        public AuthorResponseMetaTypeParamsType Params { get; set; }
    }

    public class AuthorResponseMetaTypeParamsType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("max_duration")]
        public string MaxDuration { get; set; }
    }

    public class EmailVerifyResponse
    {
        [JsonProperty("data")]
        public EmailVerifyResponseDataType Data { get; set; }

        [JsonProperty("meta")]
        public EmailVerifyResponseMetaType Meta { get; set; }
    }

    public class EmailVerifyResponseDataType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("_deprecation_notice")]
        public string DeprecationNotice { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("regexp")]
        public bool Regexp { get; set; }

        [JsonProperty("gibberish")]
        public bool Gibberish { get; set; }

        [JsonProperty("disposable")]
        public bool Disposable { get; set; }

        [JsonProperty("webmail")]
        public bool Webmail { get; set; }

        [JsonProperty("mx_records")]
        public bool MxRecords { get; set; }

        [JsonProperty("smtp_server")]
        public bool SmtpServer { get; set; }

        [JsonProperty("smtp_check")]
        public bool SmtpCheck { get; set; }

        [JsonProperty("accept_all")]
        public bool AcceptAll { get; set; }

        [JsonProperty("block")]
        public bool Block { get; set; }

        [JsonProperty("sources")]
        public EmailVerifyResponseDataTypeSourcesTypeItem[] Sources { get; set; }
    }

    public class EmailVerifyResponseDataTypeSourcesTypeItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("extracted_on")]
        public string ExtractedOn { get; set; }

        [JsonProperty("last_seen_on")]
        public string LastSeenOn { get; set; }

        [JsonProperty("still_on_page")]
        public bool StillOnPage { get; set; }
    }

    public class EmailVerifyResponseMetaType
    {
        [JsonProperty("params")]
        public EmailVerifyResponseMetaTypeParamsType Params { get; set; }
    }

    public class EmailVerifyResponseMetaTypeParamsType
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class EmailCountResponse
    {
        [JsonProperty("data")]
        public EmailCountResponseDataType Data { get; set; }

        [JsonProperty("meta")]
        public EmailCountResponseMetaType Meta { get; set; }
    }

    public class EmailCountResponseDataType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("personal_emails")]
        public int PersonalEmails { get; set; }

        [JsonProperty("generic_emails")]
        public int GenericEmails { get; set; }

        [JsonProperty("department")]
        public EmailCountResponseDataTypeDepartmentType Department { get; set; }

        [JsonProperty("seniority")]
        public EmailCountResponseDataTypeSeniorityType Seniority { get; set; }
    }

    public class EmailCountResponseDataTypeDepartmentType
    {
        [JsonProperty("executive")]
        public int Executive { get; set; }

        [JsonProperty("it")]
        public int It { get; set; }

        [JsonProperty("finance")]
        public int Finance { get; set; }

        [JsonProperty("management")]
        public int Management { get; set; }

        [JsonProperty("sales")]
        public int Sales { get; set; }

        [JsonProperty("legal")]
        public int Legal { get; set; }

        [JsonProperty("support")]
        public int Support { get; set; }

        [JsonProperty("hr")]
        public int Hr { get; set; }

        [JsonProperty("marketing")]
        public int Marketing { get; set; }

        [JsonProperty("communication")]
        public int Communication { get; set; }
    }

    public class EmailCountResponseDataTypeSeniorityType
    {
        [JsonProperty("junior")]
        public int Junior { get; set; }

        [JsonProperty("senior")]
        public int Senior { get; set; }

        [JsonProperty("executive")]
        public int Executive { get; set; }
    }

    public class EmailCountResponseMetaType
    {
        [JsonProperty("params")]
        public EmailCountResponseMetaTypeParamsType Params { get; set; }
    }

    public class EmailCountResponseMetaTypeParamsType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hunterip;

    public partial class WorkflowManagedActions
    {
        public HunteripActions Hunterip(string connectionId) => new HunteripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HunteripTriggers Hunterip(string connectionId) => new HunteripTriggers(connectionId);
    }
}
