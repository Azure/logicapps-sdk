//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shorturl
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ShorturlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlCreateShortUrl(Expression<Func<string>> longUrl, Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey, Expression<Func<string>> shortUrl = null, Expression<Func<string>> generatedBy = null, Expression<Func<int>> maxUses = null, Expression<Func<string>> password = null, Expression<Func<string>> expiryDate = null, Expression<Func<redirectionCodeInput>> redirectionCode = null)
        {
            var __workflow_longUrl = longUrl == null ? null : WorkflowExpression.Compile(longUrl);
            WorkflowExpression.Validate(__workflow_longUrl, nameof(longUrl), required: true);
            var __workflow_baseDomain = baseDomain == null ? null : WorkflowExpression.Compile(baseDomain);
            WorkflowExpression.Validate(__workflow_baseDomain, nameof(baseDomain), required: true);
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            var __workflow_licenseKey = licenseKey == null ? null : WorkflowExpression.Compile(licenseKey);
            WorkflowExpression.Validate(__workflow_licenseKey, nameof(licenseKey), required: true);
            var __workflow_shortUrl = shortUrl == null ? null : WorkflowExpression.Compile(shortUrl);
            WorkflowExpression.Validate(__workflow_shortUrl, nameof(shortUrl), required: false);
            var __workflow_generatedBy = generatedBy == null ? null : WorkflowExpression.Compile(generatedBy);
            WorkflowExpression.Validate(__workflow_generatedBy, nameof(generatedBy), required: false);
            var __workflow_maxUses = maxUses == null ? null : WorkflowExpression.Compile(maxUses);
            WorkflowExpression.Validate(__workflow_maxUses, nameof(maxUses), required: false);
            var __workflow_password = password == null ? null : WorkflowExpression.Compile(password);
            WorkflowExpression.Validate(__workflow_password, nameof(password), required: false);
            var __workflow_expiryDate = expiryDate == null ? null : WorkflowExpression.Compile(expiryDate);
            WorkflowExpression.Validate(__workflow_expiryDate, nameof(expiryDate), required: false);
            var __workflow_redirectionCode = redirectionCode == null ? null : WorkflowExpression.Compile(redirectionCode);
            WorkflowExpression.Validate(__workflow_redirectionCode, nameof(redirectionCode), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/shorturl/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["longUrl"] = ExpressionConverter.Convert(__workflow_longUrl);
                callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(__workflow_baseDomain);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(__workflow_licenseKey);
                if (__workflow_shortUrl != null)
                    callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(__workflow_shortUrl);
                if (__workflow_generatedBy != null)
                    callPayload.Queries["generatedBy"] = ExpressionConverter.Convert(__workflow_generatedBy);
                if (__workflow_maxUses != null)
                    callPayload.Queries["maxUses"] = ExpressionConverter.Convert(__workflow_maxUses);
                if (__workflow_password != null)
                    callPayload.Queries["password"] = ExpressionConverter.Convert(__workflow_password);
                if (__workflow_expiryDate != null)
                    callPayload.Queries["expiryDate"] = ExpressionConverter.Convert(__workflow_expiryDate);
                callPayload.Queries["redirectionCode"] = Convert.ToString("301 - Moved Permanently");
                if (__workflow_redirectionCode != null)
                    callPayload.Queries["redirectionCode"] = ExpressionConverter.Convert(__workflow_redirectionCode);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlDeleteShortUrl(Expression<Func<string>> shortUrl, Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey)
        {
            var __workflow_shortUrl = shortUrl == null ? null : WorkflowExpression.Compile(shortUrl);
            WorkflowExpression.Validate(__workflow_shortUrl, nameof(shortUrl), required: true);
            var __workflow_baseDomain = baseDomain == null ? null : WorkflowExpression.Compile(baseDomain);
            WorkflowExpression.Validate(__workflow_baseDomain, nameof(baseDomain), required: true);
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            var __workflow_licenseKey = licenseKey == null ? null : WorkflowExpression.Compile(licenseKey);
            WorkflowExpression.Validate(__workflow_licenseKey, nameof(licenseKey), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/shorturl/delete";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(__workflow_shortUrl);
                callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(__workflow_baseDomain);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(__workflow_licenseKey);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlGetAllShortUrls(Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey, Expression<Func<string>> generatedBy = null)
        {
            var __workflow_baseDomain = baseDomain == null ? null : WorkflowExpression.Compile(baseDomain);
            WorkflowExpression.Validate(__workflow_baseDomain, nameof(baseDomain), required: true);
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            var __workflow_licenseKey = licenseKey == null ? null : WorkflowExpression.Compile(licenseKey);
            WorkflowExpression.Validate(__workflow_licenseKey, nameof(licenseKey), required: true);
            var __workflow_generatedBy = generatedBy == null ? null : WorkflowExpression.Compile(generatedBy);
            WorkflowExpression.Validate(__workflow_generatedBy, nameof(generatedBy), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/shorturl/getall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(__workflow_baseDomain);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(__workflow_licenseKey);
                if (__workflow_generatedBy != null)
                    callPayload.Queries["generatedBy"] = ExpressionConverter.Convert(__workflow_generatedBy);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlModifyShortUrl(Expression<Func<string>> shortUrl, Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey, Expression<Func<string>> newLongUrl = null, Expression<Func<string>> password = null, Expression<Func<int>> maxUses = null, Expression<Func<string>> expiryDate = null, Expression<Func<redirectionCodeInput>> redirectionCode = null)
        {
            var __workflow_shortUrl = shortUrl == null ? null : WorkflowExpression.Compile(shortUrl);
            WorkflowExpression.Validate(__workflow_shortUrl, nameof(shortUrl), required: true);
            var __workflow_baseDomain = baseDomain == null ? null : WorkflowExpression.Compile(baseDomain);
            WorkflowExpression.Validate(__workflow_baseDomain, nameof(baseDomain), required: true);
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            var __workflow_licenseKey = licenseKey == null ? null : WorkflowExpression.Compile(licenseKey);
            WorkflowExpression.Validate(__workflow_licenseKey, nameof(licenseKey), required: true);
            var __workflow_newLongUrl = newLongUrl == null ? null : WorkflowExpression.Compile(newLongUrl);
            WorkflowExpression.Validate(__workflow_newLongUrl, nameof(newLongUrl), required: false);
            var __workflow_password = password == null ? null : WorkflowExpression.Compile(password);
            WorkflowExpression.Validate(__workflow_password, nameof(password), required: false);
            var __workflow_maxUses = maxUses == null ? null : WorkflowExpression.Compile(maxUses);
            WorkflowExpression.Validate(__workflow_maxUses, nameof(maxUses), required: false);
            var __workflow_expiryDate = expiryDate == null ? null : WorkflowExpression.Compile(expiryDate);
            WorkflowExpression.Validate(__workflow_expiryDate, nameof(expiryDate), required: false);
            var __workflow_redirectionCode = redirectionCode == null ? null : WorkflowExpression.Compile(redirectionCode);
            WorkflowExpression.Validate(__workflow_redirectionCode, nameof(redirectionCode), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/shorturl/modify";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(__workflow_shortUrl);
                callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(__workflow_baseDomain);
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(__workflow_licenseKey);
                if (__workflow_newLongUrl != null)
                    callPayload.Queries["newLongUrl"] = ExpressionConverter.Convert(__workflow_newLongUrl);
                if (__workflow_password != null)
                    callPayload.Queries["password"] = ExpressionConverter.Convert(__workflow_password);
                if (__workflow_maxUses != null)
                    callPayload.Queries["maxUses"] = ExpressionConverter.Convert(__workflow_maxUses);
                if (__workflow_expiryDate != null)
                    callPayload.Queries["expiryDate"] = ExpressionConverter.Convert(__workflow_expiryDate);
                callPayload.Queries["redirectionCode"] = Convert.ToString("301 - Moved Permanently");
                if (__workflow_redirectionCode != null)
                    callPayload.Queries["redirectionCode"] = ExpressionConverter.Convert(__workflow_redirectionCode);
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
