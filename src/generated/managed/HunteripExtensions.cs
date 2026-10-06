//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hunterip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HunteripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [WorkflowExpressionFactory(nameof(__BuildDomain))]
        public IBodyWorkflowAction<DomainResponse> Domain([WorkflowExpression] Func<string> domain = null, [WorkflowExpression] Func<string> company = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> seniority = null, [WorkflowExpression] Func<string> department = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DomainResponse> __BuildDomain(WorkflowExpression<string> domain = null, WorkflowExpression<string> company = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<typeInput> type = null, WorkflowExpression<string> seniority = null, WorkflowExpression<string> department = null)
        {
            WorkflowExpression.Validate(domain, nameof(domain), required: false);
            WorkflowExpression.Validate(company, nameof(company), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(seniority, nameof(seniority), required: false);
            WorkflowExpression.Validate(department, nameof(department), required: false);
            return new DeferredBodyAction<DomainResponse>(() =>
            {
                var apiCallPath = "/domain-search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
                if (company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (seniority != null)
                    callPayload.Queries["seniority"] = ExpressionConverter.Convert(seniority);
                if (department != null)
                    callPayload.Queries["department"] = ExpressionConverter.Convert(department);
                return new ApiConnectionAction<DomainResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [WorkflowExpressionFactory(nameof(__BuildEmail))]
        public IBodyWorkflowAction<EmailResponse> Email([WorkflowExpression] Func<string> domain = null, [WorkflowExpression] Func<string> company = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> fullName = null, [WorkflowExpression] Func<int> maxDuration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmailResponse> __BuildEmail(WorkflowExpression<string> domain = null, WorkflowExpression<string> company = null, WorkflowExpression<string> firstName = null, WorkflowExpression<string> lastName = null, WorkflowExpression<string> fullName = null, WorkflowExpression<int> maxDuration = null)
        {
            WorkflowExpression.Validate(domain, nameof(domain), required: false);
            WorkflowExpression.Validate(company, nameof(company), required: false);
            WorkflowExpression.Validate(firstName, nameof(firstName), required: false);
            WorkflowExpression.Validate(lastName, nameof(lastName), required: false);
            WorkflowExpression.Validate(fullName, nameof(fullName), required: false);
            WorkflowExpression.Validate(maxDuration, nameof(maxDuration), required: false);
            return new DeferredBodyAction<EmailResponse>(() =>
            {
                var apiCallPath = "/email-finder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
                if (company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                if (firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
                if (lastName != null)
                    callPayload.Queries["last_name"] = ExpressionConverter.Convert(lastName);
                if (fullName != null)
                    callPayload.Queries["full_name"] = ExpressionConverter.Convert(fullName);
                if (maxDuration != null)
                    callPayload.Queries["max_duration"] = ExpressionConverter.Convert(maxDuration);
                return new ApiConnectionAction<EmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [WorkflowExpressionFactory(nameof(__BuildAuthor))]
        public IBodyWorkflowAction<AuthorResponse> Author([WorkflowExpression] Func<string> url, [WorkflowExpression] Func<int> maxDuration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AuthorResponse> __BuildAuthor(WorkflowExpression<string> url, WorkflowExpression<int> maxDuration = null)
        {
            WorkflowExpression.Validate(url, nameof(url), required: true);
            WorkflowExpression.Validate(maxDuration, nameof(maxDuration), required: false);
            return new DeferredBodyAction<AuthorResponse>(() =>
            {
                var apiCallPath = "/author-finder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (maxDuration != null)
                    callPayload.Queries["max_duration"] = ExpressionConverter.Convert(maxDuration);
                return new ApiConnectionAction<AuthorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [WorkflowExpressionFactory(nameof(__BuildEmailVerify))]
        public IBodyWorkflowAction<EmailVerifyResponse> EmailVerify([WorkflowExpression] Func<string> email)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmailVerifyResponse> __BuildEmailVerify(WorkflowExpression<string> email)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            return new DeferredBodyAction<EmailVerifyResponse>(() =>
            {
                var apiCallPath = "/email-verifier";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                return new ApiConnectionAction<EmailVerifyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [WorkflowExpressionFactory(nameof(__BuildEmailCount))]
        public IBodyWorkflowAction<EmailCountResponse> EmailCount([WorkflowExpression] Func<string> domain = null, [WorkflowExpression] Func<string> company = null, [WorkflowExpression] Func<typeInput> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hunterip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmailCountResponse> __BuildEmailCount(WorkflowExpression<string> domain = null, WorkflowExpression<string> company = null, WorkflowExpression<typeInput> type = null)
        {
            WorkflowExpression.Validate(domain, nameof(domain), required: false);
            WorkflowExpression.Validate(company, nameof(company), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<EmailCountResponse>(() =>
            {
                var apiCallPath = "/email-count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
                if (company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(company);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<EmailCountResponse>(callPayload);
            });
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