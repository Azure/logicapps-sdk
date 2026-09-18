//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linkedinv2
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Linkedinv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ShareResponseV2> PostCompanyUpdate([WorkflowExpression] Func<string> bodycompany, [WorkflowExpression] Func<string> bodycommentary, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility, [WorkflowExpression] Func<string> bodycontentarticleuRLOfTheArticle, [WorkflowExpression] Func<string> bodycontentarticletitle, [WorkflowExpression] Func<bool> bodyisReshareDisabledByAuthor = null, [WorkflowExpression] Func<string> bodycontentarticledescription = null, [WorkflowExpression] Func<string> bodycontentarticlethumbnailURL = null)
        {
            var apiCallPath = "/company/rest/posts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["author"] = ExpressionConverter.ConvertO(bodycompany);
            bodypropCount++;
            body["commentary"] = ExpressionConverter.ConvertO(bodycommentary);
            bodypropCount++;
            body["visibility"] = ExpressionConverter.ConvertO(bodyvisibility);
            body["lifecycleState"] = "PUBLISHED";
            bodypropCount++;
            if (bodyisReshareDisabledByAuthor != null)
            {
                if (bodyisReshareDisabledByAuthor != null)
                {
                    body["isReshareDisabledByAuthor"] = ExpressionConverter.ConvertO(bodyisReshareDisabledByAuthor);
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
                    articleObject["description"] = ExpressionConverter.ConvertO(bodycontentarticledescription);
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
            articleObject["source"] = ExpressionConverter.ConvertO(bodycontentarticleuRLOfTheArticle);
            articleObjectpropCount++;
            articleObject["title"] = ExpressionConverter.ConvertO(bodycontentarticletitle);
            if (bodycontentarticlethumbnailURL != null)
            {
                articleObject["thumbnail"] = ExpressionConverter.ConvertO(bodycontentarticlethumbnailURL);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ShareResponseV2> PostUpdate([WorkflowExpression] Func<string> bodycommentary, [WorkflowExpression] Func<bodyvisibilityInput> bodyvisibility, [WorkflowExpression] Func<string> bodycontentarticleuRLOfTheArticle, [WorkflowExpression] Func<string> bodycontentarticletitle, [WorkflowExpression] Func<bool> bodyisReshareDisabledByAuthor = null, [WorkflowExpression] Func<string> bodycontentarticledescription = null, [WorkflowExpression] Func<string> bodycontentarticlethumbnailURL = null)
        {
            var apiCallPath = "/people/rest/posts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["commentary"] = ExpressionConverter.ConvertO(bodycommentary);
            bodypropCount++;
            body["visibility"] = ExpressionConverter.ConvertO(bodyvisibility);
            body["lifecycleState"] = "PUBLISHED";
            bodypropCount++;
            if (bodyisReshareDisabledByAuthor != null)
            {
                if (bodyisReshareDisabledByAuthor != null)
                {
                    body["isReshareDisabledByAuthor"] = ExpressionConverter.ConvertO(bodyisReshareDisabledByAuthor);
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
                    articleObject["description"] = ExpressionConverter.ConvertO(bodycontentarticledescription);
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
            articleObject["source"] = ExpressionConverter.ConvertO(bodycontentarticleuRLOfTheArticle);
            articleObjectpropCount++;
            articleObject["title"] = ExpressionConverter.ConvertO(bodycontentarticletitle);
            if (bodycontentarticlethumbnailURL != null)
            {
                articleObject["thumbnail"] = ExpressionConverter.ConvertO(bodycontentarticlethumbnailURL);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkedinv2")]
        public IBodyWorkflowAction<ListCompaniesResponseV2Item[]> ListCompanies()
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