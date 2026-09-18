//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linkedinv2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Linkedinv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ShareResponseV2> PostCompanyUpdate([WorkflowExpression] Func<string> bodycompany, [WorkflowExpression] Func<string> bodycommentary, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility, [WorkflowExpression] Func<string> bodycontentarticleuRLOfTheArticle, [WorkflowExpression] Func<string> bodycontentarticletitle, [WorkflowExpression] Func<bool> bodyisReshareDisabledByAuthor = null, [WorkflowExpression] Func<string> bodycontentarticledescription = null, [WorkflowExpression] Func<string> bodycontentarticlethumbnailURL = null)
        {
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: true);
            SourceExpression.Validate(bodycommentary, nameof(bodycommentary), required: true);
            SourceExpression.Validate(bodyvisibility, nameof(bodyvisibility), required: true);
            SourceExpression.Validate(bodycontentarticleuRLOfTheArticle, nameof(bodycontentarticleuRLOfTheArticle), required: true);
            SourceExpression.Validate(bodycontentarticletitle, nameof(bodycontentarticletitle), required: true);
            SourceExpression.Validate(bodyisReshareDisabledByAuthor, nameof(bodyisReshareDisabledByAuthor), required: false);
            SourceExpression.Validate(bodycontentarticledescription, nameof(bodycontentarticledescription), required: false);
            SourceExpression.Validate(bodycontentarticlethumbnailURL, nameof(bodycontentarticlethumbnailURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/company/rest/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["author"] = SourceExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
                body["commentary"] = SourceExpressionConverter.ConvertToken(bodycommentary);
                bodypropCount++;
                body["visibility"] = SourceExpressionConverter.Convert(bodyvisibility);
                body["lifecycleState"] = "PUBLISHED";
                bodypropCount++;
                if (bodyisReshareDisabledByAuthor != null)
                {
                    if (bodyisReshareDisabledByAuthor != null)
                    {
                        body["isReshareDisabledByAuthor"] = SourceExpressionConverter.ConvertToken(bodyisReshareDisabledByAuthor);
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
                if (bodycontentarticledescription != null)
                {
                    if (bodycontentarticledescription != null)
                    {
                        articleObject["description"] = SourceExpressionConverter.ConvertToken(bodycontentarticledescription);
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
                articleObject["source"] = SourceExpressionConverter.ConvertToken(bodycontentarticleuRLOfTheArticle);
                articleObjectpropCount++;
                articleObject["title"] = SourceExpressionConverter.ConvertToken(bodycontentarticletitle);
                if (bodycontentarticlethumbnailURL != null)
                {
                    articleObject["thumbnail"] = SourceExpressionConverter.ConvertToken(bodycontentarticlethumbnailURL);
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
                return callPayload;
            }

            return new ApiConnectionAction<ShareResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ShareResponseV2> PostUpdate([WorkflowExpression] Func<string> bodycommentary, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility, [WorkflowExpression] Func<string> bodycontentarticleuRLOfTheArticle, [WorkflowExpression] Func<string> bodycontentarticletitle, [WorkflowExpression] Func<bool> bodyisReshareDisabledByAuthor = null, [WorkflowExpression] Func<string> bodycontentarticledescription = null, [WorkflowExpression] Func<string> bodycontentarticlethumbnailURL = null)
        {
            SourceExpression.Validate(bodycommentary, nameof(bodycommentary), required: true);
            SourceExpression.Validate(bodyvisibility, nameof(bodyvisibility), required: true);
            SourceExpression.Validate(bodycontentarticleuRLOfTheArticle, nameof(bodycontentarticleuRLOfTheArticle), required: true);
            SourceExpression.Validate(bodycontentarticletitle, nameof(bodycontentarticletitle), required: true);
            SourceExpression.Validate(bodyisReshareDisabledByAuthor, nameof(bodyisReshareDisabledByAuthor), required: false);
            SourceExpression.Validate(bodycontentarticledescription, nameof(bodycontentarticledescription), required: false);
            SourceExpression.Validate(bodycontentarticlethumbnailURL, nameof(bodycontentarticlethumbnailURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/people/rest/posts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["commentary"] = SourceExpressionConverter.ConvertToken(bodycommentary);
                bodypropCount++;
                body["visibility"] = SourceExpressionConverter.Convert(bodyvisibility);
                body["lifecycleState"] = "PUBLISHED";
                bodypropCount++;
                if (bodyisReshareDisabledByAuthor != null)
                {
                    if (bodyisReshareDisabledByAuthor != null)
                    {
                        body["isReshareDisabledByAuthor"] = SourceExpressionConverter.ConvertToken(bodyisReshareDisabledByAuthor);
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
                if (bodycontentarticledescription != null)
                {
                    if (bodycontentarticledescription != null)
                    {
                        articleObject["description"] = SourceExpressionConverter.ConvertToken(bodycontentarticledescription);
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
                articleObject["source"] = SourceExpressionConverter.ConvertToken(bodycontentarticleuRLOfTheArticle);
                articleObjectpropCount++;
                articleObject["title"] = SourceExpressionConverter.ConvertToken(bodycontentarticletitle);
                if (bodycontentarticlethumbnailURL != null)
                {
                    articleObject["thumbnail"] = SourceExpressionConverter.ConvertToken(bodycontentarticlethumbnailURL);
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
                return callPayload;
            }

            return new ApiConnectionAction<ShareResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ListCompaniesResponseV2Item[]> ListCompanies()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/organizationalEntityAcls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListCompaniesResponseV2Item[]>(BuildSourceInput);
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