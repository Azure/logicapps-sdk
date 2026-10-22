//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linkedinv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Linkedinv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ShareResponseV2, ApiConnectionActionConfiguration> PostCompanyUpdate(Expression<Func<string>> bodycompany, Expression<Func<string>> bodycommentary, Expression<Func<bodyvisibilityInput>> bodyvisibility, Expression<Func<string>> bodycontentarticleuRLOfTheArticle, Expression<Func<string>> bodycontentarticletitle, Expression<Func<bool>> bodyisReshareDisabledByAuthor = null, Expression<Func<string>> bodycontentarticledescription = null, Expression<Func<string>> bodycontentarticlethumbnailURL = null)
        {
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: true);
            var __workflow_bodycommentary = WorkflowExpression.Compile(bodycommentary, nameof(bodycommentary), required: true);
            var __workflow_bodyvisibility = WorkflowExpression.Compile(bodyvisibility, nameof(bodyvisibility), required: true);
            var __workflow_bodycontentarticleuRLOfTheArticle = WorkflowExpression.Compile(bodycontentarticleuRLOfTheArticle, nameof(bodycontentarticleuRLOfTheArticle), required: true);
            var __workflow_bodycontentarticletitle = WorkflowExpression.Compile(bodycontentarticletitle, nameof(bodycontentarticletitle), required: true);
            var __workflow_bodyisReshareDisabledByAuthor = WorkflowExpression.Compile(bodyisReshareDisabledByAuthor, nameof(bodyisReshareDisabledByAuthor), required: false);
            var __workflow_bodycontentarticledescription = WorkflowExpression.Compile(bodycontentarticledescription, nameof(bodycontentarticledescription), required: false);
            var __workflow_bodycontentarticlethumbnailURL = WorkflowExpression.Compile(bodycontentarticlethumbnailURL, nameof(bodycontentarticlethumbnailURL), required: false);
            return new DeferredBodyAction<ShareResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/company/rest/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["author"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                bodypropCount++;
                body["commentary"] = ExpressionConverter.ConvertO(__workflow_bodycommentary);
                bodypropCount++;
                body["visibility"] = ExpressionConverter.ConvertO(__workflow_bodyvisibility);
                body["lifecycleState"] = "PUBLISHED";
                bodypropCount++;
                if (__workflow_bodyisReshareDisabledByAuthor != null)
                {
                    if (__workflow_bodyisReshareDisabledByAuthor != null)
                    {
                        body["isReshareDisabledByAuthor"] = ExpressionConverter.ConvertO(__workflow_bodyisReshareDisabledByAuthor);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isReshareDisabledByAuthor"] = false;
                    bodypropCount++;
                }

                var distributionObject = new JObject();
                var distributionObjectpropCount = 0;
                distributionObject["feedDistribution"] = "MAIN_FEED";
                distributionObjectpropCount++;
                if (distributionObjectpropCount > 0)
                {
                    body["distribution"] = distributionObject;
                    bodypropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                var articleObject = new JObject();
                var articleObjectpropCount = 0;
                if (__workflow_bodycontentarticledescription != null)
                {
                    if (__workflow_bodycontentarticledescription != null)
                    {
                        articleObject["description"] = ExpressionConverter.ConvertO(__workflow_bodycontentarticledescription);
                        articleObjectpropCount++;
                    }

                    articleObjectpropCount++;
                }
                else
                {
                    articleObject["description"] = "";
                    articleObjectpropCount++;
                }

                articleObjectpropCount++;
                articleObject["source"] = ExpressionConverter.ConvertO(__workflow_bodycontentarticleuRLOfTheArticle);
                articleObjectpropCount++;
                articleObject["title"] = ExpressionConverter.ConvertO(__workflow_bodycontentarticletitle);
                if (__workflow_bodycontentarticlethumbnailURL != null)
                {
                    articleObject["thumbnail"] = ExpressionConverter.ConvertO(__workflow_bodycontentarticlethumbnailURL);
                    articleObjectpropCount++;
                }

                if (articleObjectpropCount > 0)
                {
                    contentObject["article"] = articleObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ShareResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ShareResponseV2, ApiConnectionActionConfiguration> PostUpdate(Expression<Func<string>> bodycommentary, Expression<Func<bodyvisibilityInput>> bodyvisibility, Expression<Func<string>> bodycontentarticleuRLOfTheArticle, Expression<Func<string>> bodycontentarticletitle, Expression<Func<bool>> bodyisReshareDisabledByAuthor = null, Expression<Func<string>> bodycontentarticledescription = null, Expression<Func<string>> bodycontentarticlethumbnailURL = null)
        {
            var __workflow_bodycommentary = WorkflowExpression.Compile(bodycommentary, nameof(bodycommentary), required: true);
            var __workflow_bodyvisibility = WorkflowExpression.Compile(bodyvisibility, nameof(bodyvisibility), required: true);
            var __workflow_bodycontentarticleuRLOfTheArticle = WorkflowExpression.Compile(bodycontentarticleuRLOfTheArticle, nameof(bodycontentarticleuRLOfTheArticle), required: true);
            var __workflow_bodycontentarticletitle = WorkflowExpression.Compile(bodycontentarticletitle, nameof(bodycontentarticletitle), required: true);
            var __workflow_bodyisReshareDisabledByAuthor = WorkflowExpression.Compile(bodyisReshareDisabledByAuthor, nameof(bodyisReshareDisabledByAuthor), required: false);
            var __workflow_bodycontentarticledescription = WorkflowExpression.Compile(bodycontentarticledescription, nameof(bodycontentarticledescription), required: false);
            var __workflow_bodycontentarticlethumbnailURL = WorkflowExpression.Compile(bodycontentarticlethumbnailURL, nameof(bodycontentarticlethumbnailURL), required: false);
            return new DeferredBodyAction<ShareResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/people/rest/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["commentary"] = ExpressionConverter.ConvertO(__workflow_bodycommentary);
                bodypropCount++;
                body["visibility"] = ExpressionConverter.ConvertO(__workflow_bodyvisibility);
                body["lifecycleState"] = "PUBLISHED";
                bodypropCount++;
                if (__workflow_bodyisReshareDisabledByAuthor != null)
                {
                    if (__workflow_bodyisReshareDisabledByAuthor != null)
                    {
                        body["isReshareDisabledByAuthor"] = ExpressionConverter.ConvertO(__workflow_bodyisReshareDisabledByAuthor);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isReshareDisabledByAuthor"] = false;
                    bodypropCount++;
                }

                var distributionObject = new JObject();
                var distributionObjectpropCount = 0;
                distributionObject["feedDistribution"] = "MAIN_FEED";
                distributionObjectpropCount++;
                if (distributionObjectpropCount > 0)
                {
                    body["distribution"] = distributionObject;
                    bodypropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                var articleObject = new JObject();
                var articleObjectpropCount = 0;
                if (__workflow_bodycontentarticledescription != null)
                {
                    if (__workflow_bodycontentarticledescription != null)
                    {
                        articleObject["description"] = ExpressionConverter.ConvertO(__workflow_bodycontentarticledescription);
                        articleObjectpropCount++;
                    }

                    articleObjectpropCount++;
                }
                else
                {
                    articleObject["description"] = "";
                    articleObjectpropCount++;
                }

                articleObjectpropCount++;
                articleObject["source"] = ExpressionConverter.ConvertO(__workflow_bodycontentarticleuRLOfTheArticle);
                articleObjectpropCount++;
                articleObject["title"] = ExpressionConverter.ConvertO(__workflow_bodycontentarticletitle);
                if (__workflow_bodycontentarticlethumbnailURL != null)
                {
                    articleObject["thumbnail"] = ExpressionConverter.ConvertO(__workflow_bodycontentarticlethumbnailURL);
                    articleObjectpropCount++;
                }

                if (articleObjectpropCount > 0)
                {
                    contentObject["article"] = articleObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ShareResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ListCompaniesResponseV2Item[], ApiConnectionActionConfiguration> ListCompanies()
        {
            var apiCallPath = "/v2/organizationalEntityAcls";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListCompaniesResponseV2Item[]>(callPayload);
        }
    }

    public class Linkedinv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class ShareResponseV2
    {
        [JsonProperty("id")]
        public string UpdateID { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvisibilityInput
    {
        Public,
        [EnumMember(Value = "Connections Only")]
        ConnectionsOnly,
        [EnumMember(Value = "Logged in members only")]
        LoggedInMembersOnly
    }

    public class ListCompaniesResponseV2Item
    {
        [JsonProperty("companyUrn")]
        public string CompanyUrn { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Linkedinv2;

    public partial class WorkflowManagedActions
    {
        public Linkedinv2Actions Linkedinv2(string connectionId) => new Linkedinv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Linkedinv2Triggers Linkedinv2(string connectionId) => new Linkedinv2Triggers(connectionId);
    }
}
