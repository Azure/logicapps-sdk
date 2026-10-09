//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shorturl
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShorturlActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        [WorkflowExpressionFactory(nameof(__BuildShortUrlCreateShortUrl))]
        public IBodyWorkflowAction<JToken> ShortUrlCreateShortUrl([WorkflowExpression] Func<string> longUrl, [WorkflowExpression] Func<baseDomainInput> baseDomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> licenseKey, [WorkflowExpression] Func<string> shortUrl = null, [WorkflowExpression] Func<string> generatedBy = null, [WorkflowExpression] Func<int> maxUses = null, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<string> expiryDate = null, [WorkflowExpression] Func<redirectionCodeInput> redirectionCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildShortUrlCreateShortUrl(WorkflowExpression<string> longUrl, WorkflowExpression<baseDomainInput> baseDomain, WorkflowExpression<string> username, WorkflowExpression<string> licenseKey, WorkflowExpression<string> shortUrl = null, WorkflowExpression<string> generatedBy = null, WorkflowExpression<int> maxUses = null, WorkflowExpression<string> password = null, WorkflowExpression<string> expiryDate = null, WorkflowExpression<redirectionCodeInput> redirectionCode = null)
        {
            WorkflowExpression.Validate(longUrl, nameof(longUrl), required: true);
            WorkflowExpression.Validate(baseDomain, nameof(baseDomain), required: true);
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(licenseKey, nameof(licenseKey), required: true);
            WorkflowExpression.Validate(shortUrl, nameof(shortUrl), required: false);
            WorkflowExpression.Validate(generatedBy, nameof(generatedBy), required: false);
            WorkflowExpression.Validate(maxUses, nameof(maxUses), required: false);
            WorkflowExpression.Validate(password, nameof(password), required: false);
            WorkflowExpression.Validate(expiryDate, nameof(expiryDate), required: false);
            WorkflowExpression.Validate(redirectionCode, nameof(redirectionCode), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/shorturl/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["longUrl"] = ExpressionConverter.Convert(longUrl);
                callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(baseDomain);
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(licenseKey);
                if (shortUrl != null)
                    callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(shortUrl);
                if (generatedBy != null)
                    callPayload.Queries["generatedBy"] = ExpressionConverter.Convert(generatedBy);
                if (maxUses != null)
                    callPayload.Queries["maxUses"] = ExpressionConverter.Convert(maxUses);
                if (password != null)
                    callPayload.Queries["password"] = ExpressionConverter.Convert(password);
                if (expiryDate != null)
                    callPayload.Queries["expiryDate"] = ExpressionConverter.Convert(expiryDate);
                callPayload.Queries["redirectionCode"] = Convert.ToString("301 - Moved Permanently");
                if (redirectionCode != null)
                    callPayload.Queries["redirectionCode"] = ExpressionConverter.Convert(redirectionCode);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        [WorkflowExpressionFactory(nameof(__BuildShortUrlDeleteShortUrl))]
        public IBodyWorkflowAction<JToken> ShortUrlDeleteShortUrl([WorkflowExpression] Func<string> shortUrl, [WorkflowExpression] Func<baseDomainInput> baseDomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> licenseKey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildShortUrlDeleteShortUrl(WorkflowExpression<string> shortUrl, WorkflowExpression<baseDomainInput> baseDomain, WorkflowExpression<string> username, WorkflowExpression<string> licenseKey)
        {
            WorkflowExpression.Validate(shortUrl, nameof(shortUrl), required: true);
            WorkflowExpression.Validate(baseDomain, nameof(baseDomain), required: true);
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(licenseKey, nameof(licenseKey), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/shorturl/delete";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(shortUrl);
                callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(baseDomain);
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(licenseKey);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        [WorkflowExpressionFactory(nameof(__BuildShortUrlGetAllShortUrls))]
        public IBodyWorkflowAction<JToken> ShortUrlGetAllShortUrls([WorkflowExpression] Func<baseDomainInput> baseDomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> licenseKey, [WorkflowExpression] Func<string> generatedBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildShortUrlGetAllShortUrls(WorkflowExpression<baseDomainInput> baseDomain, WorkflowExpression<string> username, WorkflowExpression<string> licenseKey, WorkflowExpression<string> generatedBy = null)
        {
            WorkflowExpression.Validate(baseDomain, nameof(baseDomain), required: true);
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(licenseKey, nameof(licenseKey), required: true);
            WorkflowExpression.Validate(generatedBy, nameof(generatedBy), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/shorturl/getall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(baseDomain);
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(licenseKey);
                if (generatedBy != null)
                    callPayload.Queries["generatedBy"] = ExpressionConverter.Convert(generatedBy);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        [WorkflowExpressionFactory(nameof(__BuildShortUrlModifyShortUrl))]
        public IBodyWorkflowAction<JToken> ShortUrlModifyShortUrl([WorkflowExpression] Func<string> shortUrl, [WorkflowExpression] Func<baseDomainInput> baseDomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> licenseKey, [WorkflowExpression] Func<string> newLongUrl = null, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<int> maxUses = null, [WorkflowExpression] Func<string> expiryDate = null, [WorkflowExpression] Func<redirectionCodeInput> redirectionCode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildShortUrlModifyShortUrl(WorkflowExpression<string> shortUrl, WorkflowExpression<baseDomainInput> baseDomain, WorkflowExpression<string> username, WorkflowExpression<string> licenseKey, WorkflowExpression<string> newLongUrl = null, WorkflowExpression<string> password = null, WorkflowExpression<int> maxUses = null, WorkflowExpression<string> expiryDate = null, WorkflowExpression<redirectionCodeInput> redirectionCode = null)
        {
            WorkflowExpression.Validate(shortUrl, nameof(shortUrl), required: true);
            WorkflowExpression.Validate(baseDomain, nameof(baseDomain), required: true);
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(licenseKey, nameof(licenseKey), required: true);
            WorkflowExpression.Validate(newLongUrl, nameof(newLongUrl), required: false);
            WorkflowExpression.Validate(password, nameof(password), required: false);
            WorkflowExpression.Validate(maxUses, nameof(maxUses), required: false);
            WorkflowExpression.Validate(expiryDate, nameof(expiryDate), required: false);
            WorkflowExpression.Validate(redirectionCode, nameof(redirectionCode), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/shorturl/modify";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(shortUrl);
                callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(baseDomain);
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(licenseKey);
                if (newLongUrl != null)
                    callPayload.Queries["newLongUrl"] = ExpressionConverter.Convert(newLongUrl);
                if (password != null)
                    callPayload.Queries["password"] = ExpressionConverter.Convert(password);
                if (maxUses != null)
                    callPayload.Queries["maxUses"] = ExpressionConverter.Convert(maxUses);
                if (expiryDate != null)
                    callPayload.Queries["expiryDate"] = ExpressionConverter.Convert(expiryDate);
                callPayload.Queries["redirectionCode"] = Convert.ToString("301 - Moved Permanently");
                if (redirectionCode != null)
                    callPayload.Queries["redirectionCode"] = ExpressionConverter.Convert(redirectionCode);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ShorturlTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum baseDomainInput
    {
        [EnumMember(Value = "surl.link")]
        SurlLink,
        [EnumMember(Value = "surl.ms")]
        SurlMs,
        [EnumMember(Value = "sharepointurl.com")]
        SharepointurlCom,
        [EnumMember(Value = "officeurl.com")]
        OfficeurlCom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum redirectionCodeInput
    {
        [EnumMember(Value = "301 - Moved Permanently")]
        _301MovedPermanently,
        [EnumMember(Value = "307 - Temporary Redirect")]
        _307TemporaryRedirect
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shorturl;

    public partial class WorkflowManagedActions
    {
        public ShorturlActions Shorturl(string connectionId) => new ShorturlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShorturlTriggers Shorturl(string connectionId) => new ShorturlTriggers(connectionId);
    }
}