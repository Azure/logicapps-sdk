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
        public IBodyWorkflowAction<JToken> ShortUrlCreateShortUrl([WorkflowExpression] Func<string> longUrl, [WorkflowExpression] Func<baseDomainInput> baseDomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> licenseKey, [WorkflowExpression] Func<string> shortUrl = null, [WorkflowExpression] Func<string> generatedBy = null, [WorkflowExpression] Func<int> maxUses = null, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<string> expiryDate = null, [WorkflowExpression] Func<redirectionCodeInput> redirectionCode = null)
        {
            SourceExpression.Validate(longUrl, nameof(longUrl), required: true);
            SourceExpression.Validate(baseDomain, nameof(baseDomain), required: true);
            SourceExpression.Validate(username, nameof(username), required: true);
            SourceExpression.Validate(licenseKey, nameof(licenseKey), required: true);
            SourceExpression.Validate(shortUrl, nameof(shortUrl), required: false);
            SourceExpression.Validate(generatedBy, nameof(generatedBy), required: false);
            SourceExpression.Validate(maxUses, nameof(maxUses), required: false);
            SourceExpression.Validate(password, nameof(password), required: false);
            SourceExpression.Validate(expiryDate, nameof(expiryDate), required: false);
            SourceExpression.Validate(redirectionCode, nameof(redirectionCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/shorturl/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["longUrl"] = SourceExpressionConverter.ConvertO(longUrl);
                callPayload.Queries["baseDomain"] = SourceExpressionConverter.Convert(baseDomain);
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                callPayload.Queries["licenseKey"] = SourceExpressionConverter.ConvertO(licenseKey);
                if (shortUrl != null)
                    callPayload.Queries["shortUrl"] = SourceExpressionConverter.ConvertO(shortUrl);
                if (generatedBy != null)
                    callPayload.Queries["generatedBy"] = SourceExpressionConverter.ConvertO(generatedBy);
                if (maxUses != null)
                    callPayload.Queries["maxUses"] = SourceExpressionConverter.ConvertO(maxUses);
                if (password != null)
                    callPayload.Queries["password"] = SourceExpressionConverter.ConvertO(password);
                if (expiryDate != null)
                    callPayload.Queries["expiryDate"] = SourceExpressionConverter.ConvertO(expiryDate);
                callPayload.Queries["redirectionCode"] = Convert.ToString("301 - Moved Permanently");
                if (redirectionCode != null)
                    callPayload.Queries["redirectionCode"] = SourceExpressionConverter.Convert(redirectionCode);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlDeleteShortUrl([WorkflowExpression] Func<string> shortUrl, [WorkflowExpression] Func<baseDomainInput> baseDomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> licenseKey)
        {
            SourceExpression.Validate(shortUrl, nameof(shortUrl), required: true);
            SourceExpression.Validate(baseDomain, nameof(baseDomain), required: true);
            SourceExpression.Validate(username, nameof(username), required: true);
            SourceExpression.Validate(licenseKey, nameof(licenseKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/shorturl/delete";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shortUrl"] = SourceExpressionConverter.ConvertO(shortUrl);
                callPayload.Queries["baseDomain"] = SourceExpressionConverter.Convert(baseDomain);
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                callPayload.Queries["licenseKey"] = SourceExpressionConverter.ConvertO(licenseKey);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlGetAllShortUrls([WorkflowExpression] Func<baseDomainInput> baseDomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> licenseKey, [WorkflowExpression] Func<string> generatedBy = null)
        {
            SourceExpression.Validate(baseDomain, nameof(baseDomain), required: true);
            SourceExpression.Validate(username, nameof(username), required: true);
            SourceExpression.Validate(licenseKey, nameof(licenseKey), required: true);
            SourceExpression.Validate(generatedBy, nameof(generatedBy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/shorturl/getall";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["baseDomain"] = SourceExpressionConverter.Convert(baseDomain);
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                callPayload.Queries["licenseKey"] = SourceExpressionConverter.ConvertO(licenseKey);
                if (generatedBy != null)
                    callPayload.Queries["generatedBy"] = SourceExpressionConverter.ConvertO(generatedBy);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shorturl")]
        public IBodyWorkflowAction<JToken> ShortUrlModifyShortUrl([WorkflowExpression] Func<string> shortUrl, [WorkflowExpression] Func<baseDomainInput> baseDomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> licenseKey, [WorkflowExpression] Func<string> newLongUrl = null, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<int> maxUses = null, [WorkflowExpression] Func<string> expiryDate = null, [WorkflowExpression] Func<redirectionCodeInput> redirectionCode = null)
        {
            SourceExpression.Validate(shortUrl, nameof(shortUrl), required: true);
            SourceExpression.Validate(baseDomain, nameof(baseDomain), required: true);
            SourceExpression.Validate(username, nameof(username), required: true);
            SourceExpression.Validate(licenseKey, nameof(licenseKey), required: true);
            SourceExpression.Validate(newLongUrl, nameof(newLongUrl), required: false);
            SourceExpression.Validate(password, nameof(password), required: false);
            SourceExpression.Validate(maxUses, nameof(maxUses), required: false);
            SourceExpression.Validate(expiryDate, nameof(expiryDate), required: false);
            SourceExpression.Validate(redirectionCode, nameof(redirectionCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/shorturl/modify";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["shortUrl"] = SourceExpressionConverter.ConvertO(shortUrl);
                callPayload.Queries["baseDomain"] = SourceExpressionConverter.Convert(baseDomain);
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                callPayload.Queries["licenseKey"] = SourceExpressionConverter.ConvertO(licenseKey);
                if (newLongUrl != null)
                    callPayload.Queries["newLongUrl"] = SourceExpressionConverter.ConvertO(newLongUrl);
                if (password != null)
                    callPayload.Queries["password"] = SourceExpressionConverter.ConvertO(password);
                if (maxUses != null)
                    callPayload.Queries["maxUses"] = SourceExpressionConverter.ConvertO(maxUses);
                if (expiryDate != null)
                    callPayload.Queries["expiryDate"] = SourceExpressionConverter.ConvertO(expiryDate);
                callPayload.Queries["redirectionCode"] = Convert.ToString("301 - Moved Permanently");
                if (redirectionCode != null)
                    callPayload.Queries["redirectionCode"] = SourceExpressionConverter.Convert(redirectionCode);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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