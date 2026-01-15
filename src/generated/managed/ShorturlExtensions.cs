//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Shorturl
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShorturlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlCreateShortUrl(Expression<Func<string>> longUrl, Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey, Expression<Func<string>> shortUrl = null, Expression<Func<string>> generatedBy = null, Expression<Func<int>> maxUses = null, Expression<Func<string>> password = null, Expression<Func<string>> expiryDate = null, Expression<Func<redirectionCodeInput>> redirectionCode = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlDeleteShortUrl(Expression<Func<string>> shortUrl, Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey)
        {
            var apiCallPath = "/api/shorturl/delete";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(shortUrl);
            callPayload.Queries["baseDomain"] = ExpressionConverter.Convert(baseDomain);
            callPayload.Queries["username"] = ExpressionConverter.Convert(username);
            callPayload.Queries["licenseKey"] = ExpressionConverter.Convert(licenseKey);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlGetAllShortUrls(Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey, Expression<Func<string>> generatedBy = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlModifyShortUrl(Expression<Func<string>> shortUrl, Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey, Expression<Func<string>> newLongUrl = null, Expression<Func<string>> password = null, Expression<Func<int>> maxUses = null, Expression<Func<string>> expiryDate = null, Expression<Func<redirectionCodeInput>> redirectionCode = null)
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
        }
    }

    public class ShorturlTriggers([ConnectionName] string connectionId)
    {
    }

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
    using Microsoft.Azure.Workflows.Sdk.Shorturl;

    public partial class WorkflowManagedActions
    {
        public ShorturlActions Shorturl(string connectionId) => new ShorturlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShorturlTriggers Shorturl(string connectionId) => new ShorturlTriggers(connectionId);
    }
}