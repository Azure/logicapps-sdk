//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Profisee
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProfiseeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IBodyWorkflowAction<JToken> GetRecordsByEntityName(Expression<Func<string>> entityName, Expression<Func<string>> attributes = null, Expression<Func<bool>> countsOnly = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> recordCodes = null)
        {
            var apiCallPath = String.Format("/Records/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (attributes != null)
                callPayload.Queries["Attributes"] = ExpressionConverter.Convert(attributes);
            if (countsOnly != null)
                callPayload.Queries["CountsOnly"] = ExpressionConverter.Convert(countsOnly);
            if (filter != null)
                callPayload.Queries["Filter"] = ExpressionConverter.Convert(filter);
            if (orderBy != null)
                callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(orderBy);
            if (pageNumber != null)
                callPayload.Queries["PageNumber"] = ExpressionConverter.Convert(pageNumber);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
            if (recordCodes != null)
                callPayload.Queries["RecordCodes"] = ExpressionConverter.Convert(recordCodes);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction UpdateRecordsByEntityName(Expression<Func<string>> entityName, Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = String.Format("/Records/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction DeleteRecordByEntityNameAndRecordCode(Expression<Func<string>> entityName, Expression<Func<string>> recordCode)
        {
            var apiCallPath = String.Format("/Records/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1), ExpressionConverter.ConvertWithUrlEncoding(recordCode, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction GetEntityMetadata(Expression<Func<string>> entityName)
        {
            var apiCallPath = String.Format("/Entities/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction GetAttributesMetadata(Expression<Func<string>> entityName)
        {
            var apiCallPath = String.Format("/Entities/{0}/attributes", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IWorkflowAction UpdateTheme(Expression<Func<string>> name, Expression<Func<string>> bodybannerPrimary = null, Expression<Func<string>> bodybannerFi = null, Expression<Func<string>> bodybannerSecondary = null, Expression<Func<string>> bodycontentPrimaryBg = null, Expression<Func<string>> bodycontentPrimaryFi = null, Expression<Func<string>> bodycontentSecondaryBg = null, Expression<Func<string>> bodycontentSecondaryFi = null, Expression<Func<string>> bodyaccentBg = null, Expression<Func<string>> bodyaccentFi = null, Expression<Func<string>> bodyselectedBg = null, Expression<Func<string>> bodyhyperlink = null)
        {
            var apiCallPath = String.Format("/Themes/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybannerPrimary != null)
            {
                body["bannerPrimary"] = ExpressionConverter.ConvertO(bodybannerPrimary);
                bodypropCount++;
            }

            if (bodybannerFi != null)
            {
                body["bannerFi"] = ExpressionConverter.ConvertO(bodybannerFi);
                bodypropCount++;
            }

            if (bodybannerSecondary != null)
            {
                body["bannerSecondary"] = ExpressionConverter.ConvertO(bodybannerSecondary);
                bodypropCount++;
            }

            if (bodycontentPrimaryBg != null)
            {
                body["contentPrimaryBg"] = ExpressionConverter.ConvertO(bodycontentPrimaryBg);
                bodypropCount++;
            }

            if (bodycontentPrimaryFi != null)
            {
                body["contentPrimaryFi"] = ExpressionConverter.ConvertO(bodycontentPrimaryFi);
                bodypropCount++;
            }

            if (bodycontentSecondaryBg != null)
            {
                body["contentSecondaryBg"] = ExpressionConverter.ConvertO(bodycontentSecondaryBg);
                bodypropCount++;
            }

            if (bodycontentSecondaryFi != null)
            {
                body["contentSecondaryFi"] = ExpressionConverter.ConvertO(bodycontentSecondaryFi);
                bodypropCount++;
            }

            if (bodyaccentBg != null)
            {
                body["accentBg"] = ExpressionConverter.ConvertO(bodyaccentBg);
                bodypropCount++;
            }

            if (bodyaccentFi != null)
            {
                body["accentFi"] = ExpressionConverter.ConvertO(bodyaccentFi);
                bodypropCount++;
            }

            if (bodyselectedBg != null)
            {
                body["selectedBg"] = ExpressionConverter.ConvertO(bodyselectedBg);
                bodypropCount++;
            }

            if (bodyhyperlink != null)
            {
                body["hyperlink"] = ExpressionConverter.ConvertO(bodyhyperlink);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "profisee")]
        public IBodyWorkflowAction<JToken> GetDataQualityIssuesByEntityName(Expression<Func<string>> entityName, Expression<Func<int>> pageNumber = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> recordCodes = null)
        {
            var apiCallPath = String.Format("/DataQualityIssues/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pageNumber != null)
                callPayload.Queries["PageNumber"] = ExpressionConverter.Convert(pageNumber);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
            if (recordCodes != null)
                callPayload.Queries["RecordCodes"] = ExpressionConverter.Convert(recordCodes);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ProfiseeTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodyInputItem
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Profisee;

    public partial class WorkflowManagedActions
    {
        public ProfiseeActions Profisee(string connectionId) => new ProfiseeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProfiseeTriggers Profisee(string connectionId) => new ProfiseeTriggers(connectionId);
    }
}