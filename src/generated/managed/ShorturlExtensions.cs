//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shorturl
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
            callPayload.Queries["longUrl"] = CSharpExpressionConverter.ConvertO(longUrl);
            callPayload.Queries["baseDomain"] = CSharpExpressionConverter.Convert(baseDomain);
            callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
            callPayload.Queries["licenseKey"] = CSharpExpressionConverter.ConvertO(licenseKey);
            if (shortUrl != null)
                callPayload.Queries["shortUrl"] = CSharpExpressionConverter.ConvertO(shortUrl);
            if (generatedBy != null)
                callPayload.Queries["generatedBy"] = CSharpExpressionConverter.ConvertO(generatedBy);
            if (maxUses != null)
                callPayload.Queries["maxUses"] = CSharpExpressionConverter.ConvertO(maxUses);
            if (password != null)
                callPayload.Queries["password"] = CSharpExpressionConverter.ConvertO(password);
            if (expiryDate != null)
                callPayload.Queries["expiryDate"] = CSharpExpressionConverter.ConvertO(expiryDate);
            callPayload.Queries["redirectionCode"] = Convert.ToString("301 - Moved Permanently");
            if (redirectionCode != null)
                callPayload.Queries["redirectionCode"] = CSharpExpressionConverter.Convert(redirectionCode);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlDeleteShortUrl(Expression<Func<string>> shortUrl, Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey)
        {
            var apiCallPath = "/api/shorturl/delete";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["shortUrl"] = CSharpExpressionConverter.ConvertO(shortUrl);
            callPayload.Queries["baseDomain"] = CSharpExpressionConverter.Convert(baseDomain);
            callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
            callPayload.Queries["licenseKey"] = CSharpExpressionConverter.ConvertO(licenseKey);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlGetAllShortUrls(Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey, Expression<Func<string>> generatedBy = null)
        {
            var apiCallPath = "/api/shorturl/getall";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["baseDomain"] = CSharpExpressionConverter.Convert(baseDomain);
            callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
            callPayload.Queries["licenseKey"] = CSharpExpressionConverter.ConvertO(licenseKey);
            if (generatedBy != null)
                callPayload.Queries["generatedBy"] = CSharpExpressionConverter.ConvertO(generatedBy);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlModifyShortUrl(Expression<Func<string>> shortUrl, Expression<Func<baseDomainInput>> baseDomain, Expression<Func<string>> username, Expression<Func<string>> licenseKey, Expression<Func<string>> newLongUrl = null, Expression<Func<string>> password = null, Expression<Func<int>> maxUses = null, Expression<Func<string>> expiryDate = null, Expression<Func<redirectionCodeInput>> redirectionCode = null)
        {
            var apiCallPath = "/api/shorturl/modify";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["shortUrl"] = CSharpExpressionConverter.ConvertO(shortUrl);
            callPayload.Queries["baseDomain"] = CSharpExpressionConverter.Convert(baseDomain);
            callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
            callPayload.Queries["licenseKey"] = CSharpExpressionConverter.ConvertO(licenseKey);
            if (newLongUrl != null)
                callPayload.Queries["newLongUrl"] = CSharpExpressionConverter.ConvertO(newLongUrl);
            if (password != null)
                callPayload.Queries["password"] = CSharpExpressionConverter.ConvertO(password);
            if (maxUses != null)
                callPayload.Queries["maxUses"] = CSharpExpressionConverter.ConvertO(maxUses);
            if (expiryDate != null)
                callPayload.Queries["expiryDate"] = CSharpExpressionConverter.ConvertO(expiryDate);
            callPayload.Queries["redirectionCode"] = Convert.ToString("301 - Moved Permanently");
            if (redirectionCode != null)
                callPayload.Queries["redirectionCode"] = CSharpExpressionConverter.Convert(redirectionCode);
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