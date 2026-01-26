//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rspacexip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RspacexipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllCapsulesResponseItem[]> GetAllCapsules()
        {
            var apiCallPath = "/v4/capsules";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllCapsulesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetACapsuleResponse> GetACapsule(Expression<Func<string>> capsuleID)
        {
            var apiCallPath = String.Format("/v4/capsules/{0}", ExpressionConverter.ConvertWithUrlEncoding(capsuleID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetACapsuleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryCapsulesResponse> QueryCapsules(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/capsules/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryCapsulesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetCompanyInfoResponse> GetCompanyInfo()
        {
            var apiCallPath = "/v4/company";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCompanyInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllCoresResponse> GetAllCores()
        {
            var apiCallPath = "/v4/cores";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllCoresResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetACoreResponse> GetACore(Expression<Func<string>> coreID)
        {
            var apiCallPath = String.Format("/v4/cores/{0}", ExpressionConverter.ConvertWithUrlEncoding(coreID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetACoreResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryCoresResponse> QueryCores(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/cores/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryCoresResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllCrewResponseItem[]> GetAllCrew()
        {
            var apiCallPath = "/v4/crew";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllCrewResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetACrewMemberResponse> GetACrewMember(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/crew/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetACrewMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryCrewMembersResponse> QueryCrewMembers(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/crew/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryCrewMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllDragonsResponseItem[]> GetAllDragons()
        {
            var apiCallPath = "/v4/dragons";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllDragonsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetADragonResponse> GetADragon(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/dragons/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetADragonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryDragonsResponse> QueryDragons(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/dragons/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryDragonsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllHistoryResponseItem[]> GetAllHistory()
        {
            var apiCallPath = "/v4/history";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllHistoryResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAHistoryResponse> GetAHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/history/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryHistoryResponse> QueryHistory(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/history/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllLandpadsResponseItem[]> GetAllLandpads()
        {
            var apiCallPath = "/v4/landpads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllLandpadsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetALandpadResponse> GetALandpad(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/landpads/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetALandpadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryLandpadsResponse> QueryLandpads(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/landpads/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryLandpadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllLaunchesResponseItem[]> GetAllLaunches()
        {
            var apiCallPath = "/v4/launches";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllLaunchesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetALaunchResponse> GetALaunch(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/launches/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetALaunchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryLaunchesResponse> QueryLaunches(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/launches/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryLaunchesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetPastLaunchesResponseItem[]> GetPastLaunches()
        {
            var apiCallPath = "/v4/launches/past";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPastLaunchesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetUpcomingLaunchesResponseItem[]> GetUpcomingLaunches()
        {
            var apiCallPath = "/v4/launches/upcoming";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUpcomingLaunchesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetLatestLaunchResponse> GetLatestLaunch()
        {
            var apiCallPath = "/v4/launches/latest";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetLatestLaunchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetNextLaunchResponse> GetNextLaunch()
        {
            var apiCallPath = "/v4/launches/next";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetNextLaunchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllLaunchpadsResponseItem[]> GetAllLaunchpads()
        {
            var apiCallPath = "/v4/launchpads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllLaunchpadsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetALaunchpadResponse> GetALaunchpad(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/launchpads/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetALaunchpadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryLaunchpadsResponse> QueryLaunchpads(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/launchpads/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryLaunchpadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllPayloadsResponseItem[]> GetAllPayloads()
        {
            var apiCallPath = "/v4/payloads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllPayloadsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAPayloadResponse> GetAPayload(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/payloads/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAPayloadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryPayloadsResponse> QueryPayloads(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/payloads/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryPayloadsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetRoadsterInfoResponse> GetRoadsterInfo()
        {
            var apiCallPath = "/v4/roadster";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRoadsterInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllRocketsResponseItem[]> GetAllRockets()
        {
            var apiCallPath = "/v4/rockets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllRocketsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetARocketResponse> GetARocket(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/rockets/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetARocketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryRocketsResponse> QueryRockets(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/rockets/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryRocketsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllShipsResponseItem[]> GetAllShips()
        {
            var apiCallPath = "/v4/ships";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllShipsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAShipResponse> GetAShip(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/ships/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAShipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryShipsResponse> QueryShips(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/ships/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryShipsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAllStarlinkSatsResponseItem[]> GetAllStarlinkSats()
        {
            var apiCallPath = "/v4/starlink";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllStarlinkSatsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<GetAStarlinkSatResponse> GetAStarlinkSat(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v4/starlink/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAStarlinkSatResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rspacexip")]
        public IBodyWorkflowAction<QueryStarlinkSatsResponse> QueryStarlinkSats(Expression<Func<string>> bodyoptionsselect = null, Expression<Func<string>> bodyoptionssort = null, Expression<Func<JToken[]>> bodyoptionspopulate = null, Expression<Func<string>> bodyoptionsprojection = null, Expression<Func<bool>> bodyoptionslean = null, Expression<Func<bool>> bodyoptionsleanWithId = null, Expression<Func<int>> bodyoptionsoffset = null, Expression<Func<int>> bodyoptionspage = null, Expression<Func<int>> bodyoptionslimit = null, Expression<Func<bool>> bodyoptionspagination = null, Expression<Func<bool>> bodyoptionsuseEstimatedCount = null, Expression<Func<bool>> bodyoptionsuseCustomCountFn = null, Expression<Func<bool>> bodyoptionsforceCountFn = null, Expression<Func<bool>> bodyoptionsallowDiskUse = null, Expression<Func<string>> bodyoptionsoptionspref = null, Expression<Func<string>> bodyoptionsoptionstags = null)
        {
            var apiCallPath = "/v4/starlink/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var queryObject = new JObject();
            var queryObjectpropCount = 0;
            if (queryObjectpropCount > 0)
            {
                body["query"] = queryObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsselect != null)
            {
                optionsObject["select"] = ExpressionConverter.ConvertO(bodyoptionsselect);
                optionsObjectpropCount++;
            }

            var collationObject = new JObject();
            var collationObjectpropCount = 0;
            if (collationObjectpropCount > 0)
            {
                optionsObject["collation"] = collationObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionssort != null)
            {
                optionsObject["sort"] = ExpressionConverter.ConvertO(bodyoptionssort);
                optionsObjectpropCount++;
            }

            if (bodyoptionspopulate != null)
            {
                optionsObject["populate"] = ExpressionConverter.ConvertO(bodyoptionspopulate);
                optionsObjectpropCount++;
            }

            if (bodyoptionsprojection != null)
            {
                optionsObject["projection"] = ExpressionConverter.ConvertO(bodyoptionsprojection);
                optionsObjectpropCount++;
            }

            if (bodyoptionslean != null)
            {
                optionsObject["lean"] = ExpressionConverter.ConvertO(bodyoptionslean);
                optionsObjectpropCount++;
            }

            if (bodyoptionsleanWithId != null)
            {
                optionsObject["leanWithId"] = ExpressionConverter.ConvertO(bodyoptionsleanWithId);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoffset != null)
            {
                optionsObject["offset"] = ExpressionConverter.ConvertO(bodyoptionsoffset);
                optionsObjectpropCount++;
            }

            if (bodyoptionspage != null)
            {
                optionsObject["page"] = ExpressionConverter.ConvertO(bodyoptionspage);
                optionsObjectpropCount++;
            }

            if (bodyoptionslimit != null)
            {
                optionsObject["limit"] = ExpressionConverter.ConvertO(bodyoptionslimit);
                optionsObjectpropCount++;
            }

            var customLabelsObject = new JObject();
            var customLabelsObjectpropCount = 0;
            if (customLabelsObjectpropCount > 0)
            {
                optionsObject["customLabels"] = customLabelsObject;
                optionsObjectpropCount++;
            }

            if (bodyoptionspagination != null)
            {
                optionsObject["pagination"] = ExpressionConverter.ConvertO(bodyoptionspagination);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseEstimatedCount != null)
            {
                optionsObject["useEstimatedCount"] = ExpressionConverter.ConvertO(bodyoptionsuseEstimatedCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseCustomCountFn != null)
            {
                optionsObject["useCustomCountFn"] = ExpressionConverter.ConvertO(bodyoptionsuseCustomCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsforceCountFn != null)
            {
                optionsObject["forceCountFn"] = ExpressionConverter.ConvertO(bodyoptionsforceCountFn);
                optionsObjectpropCount++;
            }

            if (bodyoptionsallowDiskUse != null)
            {
                optionsObject["allowDiskUse"] = ExpressionConverter.ConvertO(bodyoptionsallowDiskUse);
                optionsObjectpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsoptionspref != null)
            {
                optionsObject["pref"] = ExpressionConverter.ConvertO(bodyoptionsoptionspref);
                optionsObjectpropCount++;
            }

            if (bodyoptionsoptionstags != null)
            {
                optionsObject["tags"] = ExpressionConverter.ConvertO(bodyoptionsoptionstags);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                optionsObject["options"] = optionsObject;
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryStarlinkSatsResponse>(callPayload);
        }
    }

    public class RspacexipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAllCapsulesResponseItem
    {
        [JsonProperty("reuse_count")]
        public int ReuseCount { get; set; }

        [JsonProperty("water_landings")]
        public int WaterLandings { get; set; }

        [JsonProperty("land_landings")]
        public int LandLandings { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetACapsuleResponse
    {
        [JsonProperty("reuse_count")]
        public int ReuseCount { get; set; }

        [JsonProperty("water_landings")]
        public int WaterLandings { get; set; }

        [JsonProperty("land_landings")]
        public int LandLandings { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryCapsulesResponse
    {
        [JsonProperty("docs")]
        public QueryCapsulesResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }

    public class QueryCapsulesResponseDocsTypeItem
    {
        [JsonProperty("reuse_count")]
        public int ReuseCount { get; set; }

        [JsonProperty("water_landings")]
        public int WaterLandings { get; set; }

        [JsonProperty("land_landings")]
        public int LandLandings { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetCompanyInfoResponse
    {
        [JsonProperty("headquarters")]
        public GetCompanyInfoResponseHeadquartersType Headquarters { get; set; }

        [JsonProperty("links")]
        public GetCompanyInfoResponseLinksType Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("founder")]
        public string Founder { get; set; }

        [JsonProperty("founded")]
        public int Founded { get; set; }

        [JsonProperty("employees")]
        public int Employees { get; set; }

        [JsonProperty("vehicles")]
        public int Vehicles { get; set; }

        [JsonProperty("launch_sites")]
        public int LaunchSites { get; set; }

        [JsonProperty("test_sites")]
        public int TestSites { get; set; }

        [JsonProperty("ceo")]
        public string Ceo { get; set; }

        [JsonProperty("cto")]
        public string Cto { get; set; }

        [JsonProperty("coo")]
        public string Coo { get; set; }

        [JsonProperty("cto_propulsion")]
        public string CtoPropulsion { get; set; }

        [JsonProperty("valuation")]
        public int Valuation { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetCompanyInfoResponseHeadquartersType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetCompanyInfoResponseLinksType
    {
        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("flickr")]
        public string Flickr { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("elon_twitter")]
        public string ElonTwitter { get; set; }
    }

    public class GetAllCoresResponse
    {
        [JsonProperty("headquarters")]
        public GetAllCoresResponseHeadquartersType Headquarters { get; set; }

        [JsonProperty("links")]
        public GetAllCoresResponseLinksType Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("founder")]
        public string Founder { get; set; }

        [JsonProperty("founded")]
        public int Founded { get; set; }

        [JsonProperty("employees")]
        public int Employees { get; set; }

        [JsonProperty("vehicles")]
        public int Vehicles { get; set; }

        [JsonProperty("launch_sites")]
        public int LaunchSites { get; set; }

        [JsonProperty("test_sites")]
        public int TestSites { get; set; }

        [JsonProperty("ceo")]
        public string Ceo { get; set; }

        [JsonProperty("cto")]
        public string Cto { get; set; }

        [JsonProperty("coo")]
        public string Coo { get; set; }

        [JsonProperty("cto_propulsion")]
        public string CtoPropulsion { get; set; }

        [JsonProperty("valuation")]
        public int Valuation { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllCoresResponseHeadquartersType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetAllCoresResponseLinksType
    {
        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("flickr")]
        public string Flickr { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("elon_twitter")]
        public string ElonTwitter { get; set; }
    }

    public class GetACoreResponse
    {
        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("reuse_count")]
        public int ReuseCount { get; set; }

        [JsonProperty("rtls_attempts")]
        public int RtlsAttempts { get; set; }

        [JsonProperty("rtls_landings")]
        public int RtlsLandings { get; set; }

        [JsonProperty("asds_attempts")]
        public int AsdsAttempts { get; set; }

        [JsonProperty("asds_landings")]
        public int AsdsLandings { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryCoresResponse
    {
        [JsonProperty("docs")]
        public QueryCoresResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }

    public class QueryCoresResponseDocsTypeItem
    {
        [JsonProperty("block")]
        public int Block { get; set; }

        [JsonProperty("reuse_count")]
        public int ReuseCount { get; set; }

        [JsonProperty("rtls_attempts")]
        public int RtlsAttempts { get; set; }

        [JsonProperty("rtls_landings")]
        public int RtlsLandings { get; set; }

        [JsonProperty("asds_attempts")]
        public int AsdsAttempts { get; set; }

        [JsonProperty("asds_landings")]
        public int AsdsLandings { get; set; }

        [JsonProperty("last_update")]
        public string LastUpdate { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllCrewResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetACrewMemberResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("launches")]
        public JToken[] Launches { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryCrewMembersResponse
    {
        [JsonProperty("docs")]
        public QueryCrewMembersResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }

    public class QueryCrewMembersResponseDocsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("agency")]
        public string Agency { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllDragonsResponseItem
    {
        [JsonProperty("heat_shield")]
        public GetAllDragonsResponseItemHeatShieldType HeatShield { get; set; }

        [JsonProperty("launch_payload_mass")]
        public GetAllDragonsResponseItemLaunchPayloadMassType LaunchPayloadMass { get; set; }

        [JsonProperty("launch_payload_vol")]
        public GetAllDragonsResponseItemLaunchPayloadVolType LaunchPayloadVol { get; set; }

        [JsonProperty("return_payload_mass")]
        public GetAllDragonsResponseItemReturnPayloadMassType ReturnPayloadMass { get; set; }

        [JsonProperty("return_payload_vol")]
        public GetAllDragonsResponseItemReturnPayloadVolType ReturnPayloadVol { get; set; }

        [JsonProperty("pressurized_capsule")]
        public GetAllDragonsResponseItemPressurizedCapsuleType PressurizedCapsule { get; set; }

        [JsonProperty("trunk")]
        public GetAllDragonsResponseItemTrunkType Trunk { get; set; }

        [JsonProperty("height_w_trunk")]
        public GetAllDragonsResponseItemHeightWTrunkType HeightWTrunk { get; set; }

        [JsonProperty("diameter")]
        public GetAllDragonsResponseItemDiameterType Diameter { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }

        [JsonProperty("flickr_images")]
        public string[] FlickrImages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("crew_capacity")]
        public int CrewCapacity { get; set; }

        [JsonProperty("sidewall_angle_deg")]
        public int SidewallAngleDeg { get; set; }

        [JsonProperty("orbit_duration_yr")]
        public int OrbitDurationYr { get; set; }

        [JsonProperty("dry_mass_kg")]
        public int DryMassKg { get; set; }

        [JsonProperty("dry_mass_lb")]
        public int DryMassLb { get; set; }

        [JsonProperty("thrusters")]
        public GetAllDragonsResponseItemThrustersTypeItem[] Thrusters { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllDragonsResponseItemHeatShieldType
    {
        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("size_meters")]
        public double SizeMeters { get; set; }

        [JsonProperty("temp_degrees")]
        public int TempDegrees { get; set; }

        [JsonProperty("dev_partner")]
        public string DevPartner { get; set; }
    }

    public class GetAllDragonsResponseItemLaunchPayloadMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class GetAllDragonsResponseItemLaunchPayloadVolType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class GetAllDragonsResponseItemReturnPayloadMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class GetAllDragonsResponseItemReturnPayloadVolType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class GetAllDragonsResponseItemPressurizedCapsuleType
    {
        [JsonProperty("payload_volume")]
        public GetAllDragonsResponseItemPressurizedCapsuleTypePayloadVolumeType PayloadVolume { get; set; }
    }

    public class GetAllDragonsResponseItemPressurizedCapsuleTypePayloadVolumeType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class GetAllDragonsResponseItemTrunkType
    {
        [JsonProperty("trunk_volume")]
        public GetAllDragonsResponseItemTrunkTypeTrunkVolumeType TrunkVolume { get; set; }

        [JsonProperty("cargo")]
        public GetAllDragonsResponseItemTrunkTypeCargoType Cargo { get; set; }
    }

    public class GetAllDragonsResponseItemTrunkTypeTrunkVolumeType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class GetAllDragonsResponseItemTrunkTypeCargoType
    {
        [JsonProperty("solar_array")]
        public int SolarArray { get; set; }

        [JsonProperty("unpressurized_cargo")]
        public bool UnpressurizedCargo { get; set; }
    }

    public class GetAllDragonsResponseItemHeightWTrunkType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public double Feet { get; set; }
    }

    public class GetAllDragonsResponseItemDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public int Feet { get; set; }
    }

    public class GetAllDragonsResponseItemThrustersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("pods")]
        public int Pods { get; set; }

        [JsonProperty("fuel_1")]
        public string Fuel1 { get; set; }

        [JsonProperty("fuel_2")]
        public string Fuel2 { get; set; }

        [JsonProperty("isp")]
        public int Isp { get; set; }

        [JsonProperty("thrust")]
        public GetAllDragonsResponseItemThrustersTypeItemThrustType Thrust { get; set; }
    }

    public class GetAllDragonsResponseItemThrustersTypeItemThrustType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetADragonResponse
    {
        [JsonProperty("heat_shield")]
        public GetADragonResponseHeatShieldType HeatShield { get; set; }

        [JsonProperty("launch_payload_mass")]
        public GetADragonResponseLaunchPayloadMassType LaunchPayloadMass { get; set; }

        [JsonProperty("launch_payload_vol")]
        public GetADragonResponseLaunchPayloadVolType LaunchPayloadVol { get; set; }

        [JsonProperty("return_payload_mass")]
        public GetADragonResponseReturnPayloadMassType ReturnPayloadMass { get; set; }

        [JsonProperty("return_payload_vol")]
        public GetADragonResponseReturnPayloadVolType ReturnPayloadVol { get; set; }

        [JsonProperty("pressurized_capsule")]
        public GetADragonResponsePressurizedCapsuleType PressurizedCapsule { get; set; }

        [JsonProperty("trunk")]
        public GetADragonResponseTrunkType Trunk { get; set; }

        [JsonProperty("height_w_trunk")]
        public GetADragonResponseHeightWTrunkType HeightWTrunk { get; set; }

        [JsonProperty("diameter")]
        public GetADragonResponseDiameterType Diameter { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }

        [JsonProperty("flickr_images")]
        public string[] FlickrImages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("crew_capacity")]
        public int CrewCapacity { get; set; }

        [JsonProperty("sidewall_angle_deg")]
        public int SidewallAngleDeg { get; set; }

        [JsonProperty("orbit_duration_yr")]
        public int OrbitDurationYr { get; set; }

        [JsonProperty("dry_mass_kg")]
        public int DryMassKg { get; set; }

        [JsonProperty("dry_mass_lb")]
        public int DryMassLb { get; set; }

        [JsonProperty("thrusters")]
        public GetADragonResponseThrustersTypeItem[] Thrusters { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetADragonResponseHeatShieldType
    {
        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("size_meters")]
        public double SizeMeters { get; set; }

        [JsonProperty("temp_degrees")]
        public int TempDegrees { get; set; }

        [JsonProperty("dev_partner")]
        public string DevPartner { get; set; }
    }

    public class GetADragonResponseLaunchPayloadMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class GetADragonResponseLaunchPayloadVolType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class GetADragonResponseReturnPayloadMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class GetADragonResponseReturnPayloadVolType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class GetADragonResponsePressurizedCapsuleType
    {
        [JsonProperty("payload_volume")]
        public GetADragonResponsePressurizedCapsuleTypePayloadVolumeType PayloadVolume { get; set; }
    }

    public class GetADragonResponsePressurizedCapsuleTypePayloadVolumeType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class GetADragonResponseTrunkType
    {
        [JsonProperty("trunk_volume")]
        public GetADragonResponseTrunkTypeTrunkVolumeType TrunkVolume { get; set; }

        [JsonProperty("cargo")]
        public GetADragonResponseTrunkTypeCargoType Cargo { get; set; }
    }

    public class GetADragonResponseTrunkTypeTrunkVolumeType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class GetADragonResponseTrunkTypeCargoType
    {
        [JsonProperty("solar_array")]
        public int SolarArray { get; set; }

        [JsonProperty("unpressurized_cargo")]
        public bool UnpressurizedCargo { get; set; }
    }

    public class GetADragonResponseHeightWTrunkType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public double Feet { get; set; }
    }

    public class GetADragonResponseDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public int Feet { get; set; }
    }

    public class GetADragonResponseThrustersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("pods")]
        public int Pods { get; set; }

        [JsonProperty("fuel_1")]
        public string Fuel1 { get; set; }

        [JsonProperty("fuel_2")]
        public string Fuel2 { get; set; }

        [JsonProperty("isp")]
        public int Isp { get; set; }

        [JsonProperty("thrust")]
        public GetADragonResponseThrustersTypeItemThrustType Thrust { get; set; }
    }

    public class GetADragonResponseThrustersTypeItemThrustType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class QueryDragonsResponse
    {
        [JsonProperty("docs")]
        public QueryDragonsResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItem
    {
        [JsonProperty("heat_shield")]
        public QueryDragonsResponseDocsTypeItemHeatShieldType HeatShield { get; set; }

        [JsonProperty("launch_payload_mass")]
        public QueryDragonsResponseDocsTypeItemLaunchPayloadMassType LaunchPayloadMass { get; set; }

        [JsonProperty("launch_payload_vol")]
        public QueryDragonsResponseDocsTypeItemLaunchPayloadVolType LaunchPayloadVol { get; set; }

        [JsonProperty("return_payload_mass")]
        public QueryDragonsResponseDocsTypeItemReturnPayloadMassType ReturnPayloadMass { get; set; }

        [JsonProperty("return_payload_vol")]
        public QueryDragonsResponseDocsTypeItemReturnPayloadVolType ReturnPayloadVol { get; set; }

        [JsonProperty("pressurized_capsule")]
        public QueryDragonsResponseDocsTypeItemPressurizedCapsuleType PressurizedCapsule { get; set; }

        [JsonProperty("trunk")]
        public QueryDragonsResponseDocsTypeItemTrunkType Trunk { get; set; }

        [JsonProperty("height_w_trunk")]
        public QueryDragonsResponseDocsTypeItemHeightWTrunkType HeightWTrunk { get; set; }

        [JsonProperty("diameter")]
        public QueryDragonsResponseDocsTypeItemDiameterType Diameter { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }

        [JsonProperty("flickr_images")]
        public string[] FlickrImages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("crew_capacity")]
        public int CrewCapacity { get; set; }

        [JsonProperty("sidewall_angle_deg")]
        public int SidewallAngleDeg { get; set; }

        [JsonProperty("orbit_duration_yr")]
        public int OrbitDurationYr { get; set; }

        [JsonProperty("dry_mass_kg")]
        public int DryMassKg { get; set; }

        [JsonProperty("dry_mass_lb")]
        public int DryMassLb { get; set; }

        [JsonProperty("thrusters")]
        public QueryDragonsResponseDocsTypeItemThrustersTypeItem[] Thrusters { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemHeatShieldType
    {
        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("size_meters")]
        public double SizeMeters { get; set; }

        [JsonProperty("temp_degrees")]
        public int TempDegrees { get; set; }

        [JsonProperty("dev_partner")]
        public string DevPartner { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemLaunchPayloadMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemLaunchPayloadVolType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemReturnPayloadMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemReturnPayloadVolType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemPressurizedCapsuleType
    {
        [JsonProperty("payload_volume")]
        public QueryDragonsResponseDocsTypeItemPressurizedCapsuleTypePayloadVolumeType PayloadVolume { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemPressurizedCapsuleTypePayloadVolumeType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemTrunkType
    {
        [JsonProperty("trunk_volume")]
        public QueryDragonsResponseDocsTypeItemTrunkTypeTrunkVolumeType TrunkVolume { get; set; }

        [JsonProperty("cargo")]
        public QueryDragonsResponseDocsTypeItemTrunkTypeCargoType Cargo { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemTrunkTypeTrunkVolumeType
    {
        [JsonProperty("cubic_meters")]
        public int CubicMeters { get; set; }

        [JsonProperty("cubic_feet")]
        public int CubicFeet { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemTrunkTypeCargoType
    {
        [JsonProperty("solar_array")]
        public int SolarArray { get; set; }

        [JsonProperty("unpressurized_cargo")]
        public bool UnpressurizedCargo { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemHeightWTrunkType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public double Feet { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public int Feet { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemThrustersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("pods")]
        public int Pods { get; set; }

        [JsonProperty("fuel_1")]
        public string Fuel1 { get; set; }

        [JsonProperty("fuel_2")]
        public string Fuel2 { get; set; }

        [JsonProperty("isp")]
        public int Isp { get; set; }

        [JsonProperty("thrust")]
        public QueryDragonsResponseDocsTypeItemThrustersTypeItemThrustType Thrust { get; set; }
    }

    public class QueryDragonsResponseDocsTypeItemThrustersTypeItemThrustType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetAllHistoryResponseItem
    {
        [JsonProperty("links")]
        public GetAllHistoryResponseItemLinksType Links { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("event_date_utc")]
        public string EventDateUtc { get; set; }

        [JsonProperty("event_date_unix")]
        public int EventDateUnix { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllHistoryResponseItemLinksType
    {
        [JsonProperty("article")]
        public string Article { get; set; }
    }

    public class GetAHistoryResponse
    {
        [JsonProperty("links")]
        public GetAHistoryResponseLinksType Links { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("event_date_utc")]
        public string EventDateUtc { get; set; }

        [JsonProperty("event_date_unix")]
        public int EventDateUnix { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAHistoryResponseLinksType
    {
        [JsonProperty("article")]
        public string Article { get; set; }
    }

    public class QueryHistoryResponse
    {
        [JsonProperty("docs")]
        public QueryHistoryResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }

    public class QueryHistoryResponseDocsTypeItem
    {
        [JsonProperty("links")]
        public QueryHistoryResponseDocsTypeItemLinksType Links { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("event_date_utc")]
        public string EventDateUtc { get; set; }

        [JsonProperty("event_date_unix")]
        public int EventDateUnix { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryHistoryResponseDocsTypeItemLinksType
    {
        [JsonProperty("article")]
        public string Article { get; set; }
    }

    public class GetAllLandpadsResponseItem
    {
        [JsonProperty("images")]
        public GetAllLandpadsResponseItemImagesType Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("landing_attempts")]
        public int LandingAttempts { get; set; }

        [JsonProperty("landing_successes")]
        public int LandingSuccesses { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllLandpadsResponseItemImagesType
    {
        [JsonProperty("large")]
        public string[] Large { get; set; }
    }

    public class GetALandpadResponse
    {
        [JsonProperty("images")]
        public GetALandpadResponseImagesType Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("landing_attempts")]
        public int LandingAttempts { get; set; }

        [JsonProperty("landing_successes")]
        public int LandingSuccesses { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetALandpadResponseImagesType
    {
        [JsonProperty("large")]
        public string[] Large { get; set; }
    }

    public class QueryLandpadsResponse
    {
        [JsonProperty("docs")]
        public QueryLandpadsResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }
    }

    public class QueryLandpadsResponseDocsTypeItem
    {
        [JsonProperty("images")]
        public QueryLandpadsResponseDocsTypeItemImagesType Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("landing_attempts")]
        public int LandingAttempts { get; set; }

        [JsonProperty("landing_successes")]
        public int LandingSuccesses { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryLandpadsResponseDocsTypeItemImagesType
    {
        [JsonProperty("large")]
        public string[] Large { get; set; }
    }

    public class GetAllLaunchesResponseItem
    {
        [JsonProperty("fairings")]
        public GetAllLaunchesResponseItemFairingsType Fairings { get; set; }

        [JsonProperty("links")]
        public GetAllLaunchesResponseItemLinksType Links { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public string StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public int StaticFireDateUnix { get; set; }

        [JsonProperty("net")]
        public bool Net { get; set; }

        [JsonProperty("window")]
        public int Window { get; set; }

        [JsonProperty("rocket")]
        public string Rocket { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failures")]
        public GetAllLaunchesResponseItemFailuresTypeItem[] Failures { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("crew")]
        public string[] Crew { get; set; }

        [JsonProperty("ships")]
        public string[] Ships { get; set; }

        [JsonProperty("capsules")]
        public string[] Capsules { get; set; }

        [JsonProperty("payloads")]
        public string[] Payloads { get; set; }

        [JsonProperty("launchpad")]
        public string Launchpad { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_utc")]
        public string DateUtc { get; set; }

        [JsonProperty("date_unix")]
        public int DateUnix { get; set; }

        [JsonProperty("date_local")]
        public string DateLocal { get; set; }

        [JsonProperty("date_precision")]
        public string DatePrecision { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("cores")]
        public GetAllLaunchesResponseItemCoresTypeItem[] Cores { get; set; }

        [JsonProperty("auto_update")]
        public bool AutoUpdate { get; set; }

        [JsonProperty("tbd")]
        public bool Tbd { get; set; }

        [JsonProperty("launch_library_id")]
        public string LaunchLibraryId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllLaunchesResponseItemFairingsType
    {
        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("recovery_attempt")]
        public bool RecoveryAttempt { get; set; }

        [JsonProperty("recovered")]
        public bool Recovered { get; set; }

        [JsonProperty("ships")]
        public JToken[] Ships { get; set; }
    }

    public class GetAllLaunchesResponseItemLinksType
    {
        [JsonProperty("patch")]
        public GetAllLaunchesResponseItemLinksTypePatchType Patch { get; set; }

        [JsonProperty("reddit")]
        public GetAllLaunchesResponseItemLinksTypeRedditType Reddit { get; set; }

        [JsonProperty("flickr")]
        public GetAllLaunchesResponseItemLinksTypeFlickrType Flickr { get; set; }

        [JsonProperty("presskit")]
        public string Presskit { get; set; }

        [JsonProperty("webcast")]
        public string Webcast { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }

    public class GetAllLaunchesResponseItemLinksTypePatchType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class GetAllLaunchesResponseItemLinksTypeRedditType
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }

    public class GetAllLaunchesResponseItemLinksTypeFlickrType
    {
        [JsonProperty("small")]
        public JToken[] Small { get; set; }

        [JsonProperty("original")]
        public string[] Original { get; set; }
    }

    public class GetAllLaunchesResponseItemFailuresTypeItem
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("altitude")]
        public int Altitude { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class GetAllLaunchesResponseItemCoresTypeItem
    {
        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("flight")]
        public int Flight { get; set; }

        [JsonProperty("gridfins")]
        public bool Gridfins { get; set; }

        [JsonProperty("legs")]
        public bool Legs { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("landing_attempt")]
        public bool LandingAttempt { get; set; }

        [JsonProperty("landing_success")]
        public bool LandingSuccess { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landpad")]
        public string Landpad { get; set; }
    }

    public class GetALaunchResponse
    {
        [JsonProperty("fairings")]
        public GetALaunchResponseFairingsType Fairings { get; set; }

        [JsonProperty("links")]
        public GetALaunchResponseLinksType Links { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public string StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public int StaticFireDateUnix { get; set; }

        [JsonProperty("net")]
        public bool Net { get; set; }

        [JsonProperty("window")]
        public int Window { get; set; }

        [JsonProperty("rocket")]
        public string Rocket { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failures")]
        public JToken[] Failures { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("crew")]
        public JToken[] Crew { get; set; }

        [JsonProperty("ships")]
        public JToken[] Ships { get; set; }

        [JsonProperty("capsules")]
        public JToken[] Capsules { get; set; }

        [JsonProperty("payloads")]
        public string[] Payloads { get; set; }

        [JsonProperty("launchpad")]
        public string Launchpad { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_utc")]
        public string DateUtc { get; set; }

        [JsonProperty("date_unix")]
        public int DateUnix { get; set; }

        [JsonProperty("date_local")]
        public string DateLocal { get; set; }

        [JsonProperty("date_precision")]
        public string DatePrecision { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("cores")]
        public GetALaunchResponseCoresTypeItem[] Cores { get; set; }

        [JsonProperty("auto_update")]
        public bool AutoUpdate { get; set; }

        [JsonProperty("tbd")]
        public bool Tbd { get; set; }

        [JsonProperty("launch_library_id")]
        public string LaunchLibraryId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetALaunchResponseFairingsType
    {
        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("recovery_attempt")]
        public bool RecoveryAttempt { get; set; }

        [JsonProperty("recovered")]
        public bool Recovered { get; set; }

        [JsonProperty("ships")]
        public JToken[] Ships { get; set; }
    }

    public class GetALaunchResponseLinksType
    {
        [JsonProperty("patch")]
        public GetALaunchResponseLinksTypePatchType Patch { get; set; }

        [JsonProperty("reddit")]
        public GetALaunchResponseLinksTypeRedditType Reddit { get; set; }

        [JsonProperty("flickr")]
        public GetALaunchResponseLinksTypeFlickrType Flickr { get; set; }

        [JsonProperty("presskit")]
        public string Presskit { get; set; }

        [JsonProperty("webcast")]
        public string Webcast { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }

    public class GetALaunchResponseLinksTypePatchType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class GetALaunchResponseLinksTypeRedditType
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }

    public class GetALaunchResponseLinksTypeFlickrType
    {
        [JsonProperty("small")]
        public JToken[] Small { get; set; }

        [JsonProperty("original")]
        public JToken[] Original { get; set; }
    }

    public class GetALaunchResponseCoresTypeItem
    {
        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("flight")]
        public string Flight { get; set; }

        [JsonProperty("gridfins")]
        public string Gridfins { get; set; }

        [JsonProperty("legs")]
        public string Legs { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("landing_attempt")]
        public string LandingAttempt { get; set; }

        [JsonProperty("landing_success")]
        public bool LandingSuccess { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landpad")]
        public string Landpad { get; set; }
    }

    public class QueryLaunchesResponse
    {
        [JsonProperty("docs")]
        public QueryLaunchesResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }

    public class QueryLaunchesResponseDocsTypeItem
    {
        [JsonProperty("fairings")]
        public string Fairings { get; set; }

        [JsonProperty("links")]
        public QueryLaunchesResponseDocsTypeItemLinksType Links { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public string StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public int StaticFireDateUnix { get; set; }

        [JsonProperty("net")]
        public bool Net { get; set; }

        [JsonProperty("window")]
        public int Window { get; set; }

        [JsonProperty("rocket")]
        public string Rocket { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failures")]
        public QueryLaunchesResponseDocsTypeItemFailuresTypeItem[] Failures { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("crew")]
        public JToken[] Crew { get; set; }

        [JsonProperty("ships")]
        public string[] Ships { get; set; }

        [JsonProperty("capsules")]
        public string[] Capsules { get; set; }

        [JsonProperty("payloads")]
        public string[] Payloads { get; set; }

        [JsonProperty("launchpad")]
        public string Launchpad { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_utc")]
        public string DateUtc { get; set; }

        [JsonProperty("date_unix")]
        public int DateUnix { get; set; }

        [JsonProperty("date_local")]
        public string DateLocal { get; set; }

        [JsonProperty("date_precision")]
        public string DatePrecision { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("cores")]
        public QueryLaunchesResponseDocsTypeItemCoresTypeItem[] Cores { get; set; }

        [JsonProperty("auto_update")]
        public bool AutoUpdate { get; set; }

        [JsonProperty("tbd")]
        public bool Tbd { get; set; }

        [JsonProperty("launch_library_id")]
        public string LaunchLibraryId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryLaunchesResponseDocsTypeItemLinksType
    {
        [JsonProperty("patch")]
        public QueryLaunchesResponseDocsTypeItemLinksTypePatchType Patch { get; set; }

        [JsonProperty("reddit")]
        public QueryLaunchesResponseDocsTypeItemLinksTypeRedditType Reddit { get; set; }

        [JsonProperty("flickr")]
        public QueryLaunchesResponseDocsTypeItemLinksTypeFlickrType Flickr { get; set; }

        [JsonProperty("presskit")]
        public string Presskit { get; set; }

        [JsonProperty("webcast")]
        public string Webcast { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }

    public class QueryLaunchesResponseDocsTypeItemLinksTypePatchType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class QueryLaunchesResponseDocsTypeItemLinksTypeRedditType
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }

    public class QueryLaunchesResponseDocsTypeItemLinksTypeFlickrType
    {
        [JsonProperty("small")]
        public JToken[] Small { get; set; }

        [JsonProperty("original")]
        public JToken[] Original { get; set; }
    }

    public class QueryLaunchesResponseDocsTypeItemFailuresTypeItem
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("altitude")]
        public int Altitude { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class QueryLaunchesResponseDocsTypeItemCoresTypeItem
    {
        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("flight")]
        public int Flight { get; set; }

        [JsonProperty("gridfins")]
        public bool Gridfins { get; set; }

        [JsonProperty("legs")]
        public bool Legs { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("landing_attempt")]
        public bool LandingAttempt { get; set; }

        [JsonProperty("landing_success")]
        public bool LandingSuccess { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landpad")]
        public string Landpad { get; set; }
    }

    public class GetPastLaunchesResponseItem
    {
        [JsonProperty("fairings")]
        public string Fairings { get; set; }

        [JsonProperty("links")]
        public GetPastLaunchesResponseItemLinksType Links { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public string StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public int StaticFireDateUnix { get; set; }

        [JsonProperty("net")]
        public bool Net { get; set; }

        [JsonProperty("window")]
        public int Window { get; set; }

        [JsonProperty("rocket")]
        public string Rocket { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failures")]
        public GetPastLaunchesResponseItemFailuresTypeItem[] Failures { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("crew")]
        public string[] Crew { get; set; }

        [JsonProperty("ships")]
        public string[] Ships { get; set; }

        [JsonProperty("capsules")]
        public string[] Capsules { get; set; }

        [JsonProperty("payloads")]
        public string[] Payloads { get; set; }

        [JsonProperty("launchpad")]
        public string Launchpad { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_utc")]
        public string DateUtc { get; set; }

        [JsonProperty("date_unix")]
        public int DateUnix { get; set; }

        [JsonProperty("date_local")]
        public string DateLocal { get; set; }

        [JsonProperty("date_precision")]
        public string DatePrecision { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("cores")]
        public GetPastLaunchesResponseItemCoresTypeItem[] Cores { get; set; }

        [JsonProperty("auto_update")]
        public bool AutoUpdate { get; set; }

        [JsonProperty("tbd")]
        public bool Tbd { get; set; }

        [JsonProperty("launch_library_id")]
        public string LaunchLibraryId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetPastLaunchesResponseItemLinksType
    {
        [JsonProperty("patch")]
        public GetPastLaunchesResponseItemLinksTypePatchType Patch { get; set; }

        [JsonProperty("reddit")]
        public GetPastLaunchesResponseItemLinksTypeRedditType Reddit { get; set; }

        [JsonProperty("flickr")]
        public GetPastLaunchesResponseItemLinksTypeFlickrType Flickr { get; set; }

        [JsonProperty("presskit")]
        public string Presskit { get; set; }

        [JsonProperty("webcast")]
        public string Webcast { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }

    public class GetPastLaunchesResponseItemLinksTypePatchType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class GetPastLaunchesResponseItemLinksTypeRedditType
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }

    public class GetPastLaunchesResponseItemLinksTypeFlickrType
    {
        [JsonProperty("small")]
        public JToken[] Small { get; set; }

        [JsonProperty("original")]
        public string[] Original { get; set; }
    }

    public class GetPastLaunchesResponseItemFailuresTypeItem
    {
        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("altitude")]
        public int Altitude { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class GetPastLaunchesResponseItemCoresTypeItem
    {
        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("flight")]
        public int Flight { get; set; }

        [JsonProperty("gridfins")]
        public bool Gridfins { get; set; }

        [JsonProperty("legs")]
        public bool Legs { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("landing_attempt")]
        public bool LandingAttempt { get; set; }

        [JsonProperty("landing_success")]
        public bool LandingSuccess { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landpad")]
        public string Landpad { get; set; }
    }

    public class GetUpcomingLaunchesResponseItem
    {
        [JsonProperty("fairings")]
        public GetUpcomingLaunchesResponseItemFairingsType Fairings { get; set; }

        [JsonProperty("links")]
        public GetUpcomingLaunchesResponseItemLinksType Links { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public string StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public int StaticFireDateUnix { get; set; }

        [JsonProperty("net")]
        public bool Net { get; set; }

        [JsonProperty("window")]
        public int Window { get; set; }

        [JsonProperty("rocket")]
        public string Rocket { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failures")]
        public JToken[] Failures { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("crew")]
        public string[] Crew { get; set; }

        [JsonProperty("ships")]
        public JToken[] Ships { get; set; }

        [JsonProperty("capsules")]
        public JToken[] Capsules { get; set; }

        [JsonProperty("payloads")]
        public string[] Payloads { get; set; }

        [JsonProperty("launchpad")]
        public string Launchpad { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_utc")]
        public string DateUtc { get; set; }

        [JsonProperty("date_unix")]
        public int DateUnix { get; set; }

        [JsonProperty("date_local")]
        public string DateLocal { get; set; }

        [JsonProperty("date_precision")]
        public string DatePrecision { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("cores")]
        public GetUpcomingLaunchesResponseItemCoresTypeItem[] Cores { get; set; }

        [JsonProperty("auto_update")]
        public bool AutoUpdate { get; set; }

        [JsonProperty("tbd")]
        public bool Tbd { get; set; }

        [JsonProperty("launch_library_id")]
        public string LaunchLibraryId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetUpcomingLaunchesResponseItemFairingsType
    {
        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("recovery_attempt")]
        public bool RecoveryAttempt { get; set; }

        [JsonProperty("recovered")]
        public bool Recovered { get; set; }

        [JsonProperty("ships")]
        public JToken[] Ships { get; set; }
    }

    public class GetUpcomingLaunchesResponseItemLinksType
    {
        [JsonProperty("patch")]
        public GetUpcomingLaunchesResponseItemLinksTypePatchType Patch { get; set; }

        [JsonProperty("reddit")]
        public GetUpcomingLaunchesResponseItemLinksTypeRedditType Reddit { get; set; }

        [JsonProperty("flickr")]
        public GetUpcomingLaunchesResponseItemLinksTypeFlickrType Flickr { get; set; }

        [JsonProperty("presskit")]
        public string Presskit { get; set; }

        [JsonProperty("webcast")]
        public string Webcast { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }

    public class GetUpcomingLaunchesResponseItemLinksTypePatchType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class GetUpcomingLaunchesResponseItemLinksTypeRedditType
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }

    public class GetUpcomingLaunchesResponseItemLinksTypeFlickrType
    {
        [JsonProperty("small")]
        public JToken[] Small { get; set; }

        [JsonProperty("original")]
        public JToken[] Original { get; set; }
    }

    public class GetUpcomingLaunchesResponseItemCoresTypeItem
    {
        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("flight")]
        public int Flight { get; set; }

        [JsonProperty("gridfins")]
        public bool Gridfins { get; set; }

        [JsonProperty("legs")]
        public bool Legs { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("landing_attempt")]
        public bool LandingAttempt { get; set; }

        [JsonProperty("landing_success")]
        public bool LandingSuccess { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landpad")]
        public string Landpad { get; set; }
    }

    public class GetLatestLaunchResponse
    {
        [JsonProperty("fairings")]
        public string Fairings { get; set; }

        [JsonProperty("links")]
        public GetLatestLaunchResponseLinksType Links { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public string StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public int StaticFireDateUnix { get; set; }

        [JsonProperty("net")]
        public bool Net { get; set; }

        [JsonProperty("window")]
        public int Window { get; set; }

        [JsonProperty("rocket")]
        public string Rocket { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failures")]
        public JToken[] Failures { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("crew")]
        public string[] Crew { get; set; }

        [JsonProperty("ships")]
        public string[] Ships { get; set; }

        [JsonProperty("capsules")]
        public string[] Capsules { get; set; }

        [JsonProperty("payloads")]
        public string[] Payloads { get; set; }

        [JsonProperty("launchpad")]
        public string Launchpad { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_utc")]
        public string DateUtc { get; set; }

        [JsonProperty("date_unix")]
        public int DateUnix { get; set; }

        [JsonProperty("date_local")]
        public string DateLocal { get; set; }

        [JsonProperty("date_precision")]
        public string DatePrecision { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("cores")]
        public GetLatestLaunchResponseCoresTypeItem[] Cores { get; set; }

        [JsonProperty("auto_update")]
        public bool AutoUpdate { get; set; }

        [JsonProperty("tbd")]
        public bool Tbd { get; set; }

        [JsonProperty("launch_library_id")]
        public string LaunchLibraryId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetLatestLaunchResponseLinksType
    {
        [JsonProperty("patch")]
        public GetLatestLaunchResponseLinksTypePatchType Patch { get; set; }

        [JsonProperty("reddit")]
        public GetLatestLaunchResponseLinksTypeRedditType Reddit { get; set; }

        [JsonProperty("flickr")]
        public GetLatestLaunchResponseLinksTypeFlickrType Flickr { get; set; }

        [JsonProperty("presskit")]
        public string Presskit { get; set; }

        [JsonProperty("webcast")]
        public string Webcast { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }

    public class GetLatestLaunchResponseLinksTypePatchType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class GetLatestLaunchResponseLinksTypeRedditType
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }

    public class GetLatestLaunchResponseLinksTypeFlickrType
    {
        [JsonProperty("small")]
        public JToken[] Small { get; set; }

        [JsonProperty("original")]
        public JToken[] Original { get; set; }
    }

    public class GetLatestLaunchResponseCoresTypeItem
    {
        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("flight")]
        public int Flight { get; set; }

        [JsonProperty("gridfins")]
        public bool Gridfins { get; set; }

        [JsonProperty("legs")]
        public bool Legs { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("landing_attempt")]
        public bool LandingAttempt { get; set; }

        [JsonProperty("landing_success")]
        public bool LandingSuccess { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landpad")]
        public string Landpad { get; set; }
    }

    public class GetNextLaunchResponse
    {
        [JsonProperty("fairings")]
        public GetNextLaunchResponseFairingsType Fairings { get; set; }

        [JsonProperty("links")]
        public GetNextLaunchResponseLinksType Links { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public string StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public string StaticFireDateUnix { get; set; }

        [JsonProperty("net")]
        public bool Net { get; set; }

        [JsonProperty("window")]
        public int Window { get; set; }

        [JsonProperty("rocket")]
        public string Rocket { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("failures")]
        public JToken[] Failures { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("crew")]
        public JToken[] Crew { get; set; }

        [JsonProperty("ships")]
        public JToken[] Ships { get; set; }

        [JsonProperty("capsules")]
        public JToken[] Capsules { get; set; }

        [JsonProperty("payloads")]
        public string[] Payloads { get; set; }

        [JsonProperty("launchpad")]
        public string Launchpad { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_utc")]
        public string DateUtc { get; set; }

        [JsonProperty("date_unix")]
        public int DateUnix { get; set; }

        [JsonProperty("date_local")]
        public string DateLocal { get; set; }

        [JsonProperty("date_precision")]
        public string DatePrecision { get; set; }

        [JsonProperty("upcoming")]
        public bool Upcoming { get; set; }

        [JsonProperty("cores")]
        public GetNextLaunchResponseCoresTypeItem[] Cores { get; set; }

        [JsonProperty("auto_update")]
        public bool AutoUpdate { get; set; }

        [JsonProperty("tbd")]
        public bool Tbd { get; set; }

        [JsonProperty("launch_library_id")]
        public string LaunchLibraryId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetNextLaunchResponseFairingsType
    {
        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("recovery_attempt")]
        public bool RecoveryAttempt { get; set; }

        [JsonProperty("recovered")]
        public bool Recovered { get; set; }

        [JsonProperty("ships")]
        public JToken[] Ships { get; set; }
    }

    public class GetNextLaunchResponseLinksType
    {
        [JsonProperty("patch")]
        public GetNextLaunchResponseLinksTypePatchType Patch { get; set; }

        [JsonProperty("reddit")]
        public GetNextLaunchResponseLinksTypeRedditType Reddit { get; set; }

        [JsonProperty("flickr")]
        public GetNextLaunchResponseLinksTypeFlickrType Flickr { get; set; }

        [JsonProperty("presskit")]
        public string Presskit { get; set; }

        [JsonProperty("webcast")]
        public string Webcast { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }
    }

    public class GetNextLaunchResponseLinksTypePatchType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class GetNextLaunchResponseLinksTypeRedditType
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("recovery")]
        public string Recovery { get; set; }
    }

    public class GetNextLaunchResponseLinksTypeFlickrType
    {
        [JsonProperty("small")]
        public JToken[] Small { get; set; }

        [JsonProperty("original")]
        public JToken[] Original { get; set; }
    }

    public class GetNextLaunchResponseCoresTypeItem
    {
        [JsonProperty("core")]
        public string Core { get; set; }

        [JsonProperty("flight")]
        public string Flight { get; set; }

        [JsonProperty("gridfins")]
        public bool Gridfins { get; set; }

        [JsonProperty("legs")]
        public bool Legs { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("landing_attempt")]
        public bool LandingAttempt { get; set; }

        [JsonProperty("landing_success")]
        public bool LandingSuccess { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landpad")]
        public string Landpad { get; set; }
    }

    public class GetAllLaunchpadsResponseItem
    {
        [JsonProperty("images")]
        public GetAllLaunchpadsResponseItemImagesType Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("launch_attempts")]
        public int LaunchAttempts { get; set; }

        [JsonProperty("launch_successes")]
        public int LaunchSuccesses { get; set; }

        [JsonProperty("rockets")]
        public string[] Rockets { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllLaunchpadsResponseItemImagesType
    {
        [JsonProperty("large")]
        public string[] Large { get; set; }
    }

    public class GetALaunchpadResponse
    {
        [JsonProperty("images")]
        public GetALaunchpadResponseImagesType Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("launch_attempts")]
        public int LaunchAttempts { get; set; }

        [JsonProperty("launch_successes")]
        public int LaunchSuccesses { get; set; }

        [JsonProperty("rockets")]
        public string[] Rockets { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetALaunchpadResponseImagesType
    {
        [JsonProperty("large")]
        public string[] Large { get; set; }
    }

    public class QueryLaunchpadsResponse
    {
        [JsonProperty("docs")]
        public QueryLaunchpadsResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }
    }

    public class QueryLaunchpadsResponseDocsTypeItem
    {
        [JsonProperty("images")]
        public QueryLaunchpadsResponseDocsTypeItemImagesType Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("launch_attempts")]
        public int LaunchAttempts { get; set; }

        [JsonProperty("launch_successes")]
        public int LaunchSuccesses { get; set; }

        [JsonProperty("rockets")]
        public string[] Rockets { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryLaunchpadsResponseDocsTypeItemImagesType
    {
        [JsonProperty("large")]
        public string[] Large { get; set; }
    }

    public class GetAllPayloadsResponseItem
    {
        [JsonProperty("dragon")]
        public GetAllPayloadsResponseItemDragonType Dragon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("customers")]
        public string[] Customers { get; set; }

        [JsonProperty("norad_ids")]
        public int[] NoradIds { get; set; }

        [JsonProperty("nationalities")]
        public string[] Nationalities { get; set; }

        [JsonProperty("manufacturers")]
        public string[] Manufacturers { get; set; }

        [JsonProperty("mass_kg")]
        public int MassKg { get; set; }

        [JsonProperty("mass_lbs")]
        public int MassLbs { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonProperty("regime")]
        public string Regime { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("semi_major_axis_km")]
        public string SemiMajorAxisKm { get; set; }

        [JsonProperty("eccentricity")]
        public string Eccentricity { get; set; }

        [JsonProperty("periapsis_km")]
        public string PeriapsisKm { get; set; }

        [JsonProperty("apoapsis_km")]
        public string ApoapsisKm { get; set; }

        [JsonProperty("inclination_deg")]
        public string InclinationDeg { get; set; }

        [JsonProperty("period_min")]
        public string PeriodMin { get; set; }

        [JsonProperty("lifespan_years")]
        public string LifespanYears { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("mean_motion")]
        public string MeanMotion { get; set; }

        [JsonProperty("raan")]
        public string Raan { get; set; }

        [JsonProperty("arg_of_pericenter")]
        public string ArgOfPericenter { get; set; }

        [JsonProperty("mean_anomaly")]
        public string MeanAnomaly { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllPayloadsResponseItemDragonType
    {
        [JsonProperty("capsule")]
        public string Capsule { get; set; }

        [JsonProperty("mass_returned_kg")]
        public string MassReturnedKg { get; set; }

        [JsonProperty("mass_returned_lbs")]
        public string MassReturnedLbs { get; set; }

        [JsonProperty("flight_time_sec")]
        public string FlightTimeSec { get; set; }

        [JsonProperty("manifest")]
        public string Manifest { get; set; }

        [JsonProperty("water_landing")]
        public string WaterLanding { get; set; }

        [JsonProperty("land_landing")]
        public string LandLanding { get; set; }
    }

    public class GetAPayloadResponse
    {
        [JsonProperty("dragon")]
        public GetAPayloadResponseDragonType Dragon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("customers")]
        public string[] Customers { get; set; }

        [JsonProperty("norad_ids")]
        public JToken[] NoradIds { get; set; }

        [JsonProperty("nationalities")]
        public string[] Nationalities { get; set; }

        [JsonProperty("manufacturers")]
        public string[] Manufacturers { get; set; }

        [JsonProperty("mass_kg")]
        public int MassKg { get; set; }

        [JsonProperty("mass_lbs")]
        public int MassLbs { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonProperty("regime")]
        public string Regime { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("semi_major_axis_km")]
        public string SemiMajorAxisKm { get; set; }

        [JsonProperty("eccentricity")]
        public string Eccentricity { get; set; }

        [JsonProperty("periapsis_km")]
        public string PeriapsisKm { get; set; }

        [JsonProperty("apoapsis_km")]
        public string ApoapsisKm { get; set; }

        [JsonProperty("inclination_deg")]
        public string InclinationDeg { get; set; }

        [JsonProperty("period_min")]
        public string PeriodMin { get; set; }

        [JsonProperty("lifespan_years")]
        public string LifespanYears { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("mean_motion")]
        public string MeanMotion { get; set; }

        [JsonProperty("raan")]
        public string Raan { get; set; }

        [JsonProperty("arg_of_pericenter")]
        public string ArgOfPericenter { get; set; }

        [JsonProperty("mean_anomaly")]
        public string MeanAnomaly { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAPayloadResponseDragonType
    {
        [JsonProperty("capsule")]
        public string Capsule { get; set; }

        [JsonProperty("mass_returned_kg")]
        public string MassReturnedKg { get; set; }

        [JsonProperty("mass_returned_lbs")]
        public string MassReturnedLbs { get; set; }

        [JsonProperty("flight_time_sec")]
        public string FlightTimeSec { get; set; }

        [JsonProperty("manifest")]
        public string Manifest { get; set; }

        [JsonProperty("water_landing")]
        public string WaterLanding { get; set; }

        [JsonProperty("land_landing")]
        public string LandLanding { get; set; }
    }

    public class QueryPayloadsResponse
    {
        [JsonProperty("docs")]
        public QueryPayloadsResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }

    public class QueryPayloadsResponseDocsTypeItem
    {
        [JsonProperty("dragon")]
        public QueryPayloadsResponseDocsTypeItemDragonType Dragon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("customers")]
        public string[] Customers { get; set; }

        [JsonProperty("norad_ids")]
        public int[] NoradIds { get; set; }

        [JsonProperty("nationalities")]
        public string[] Nationalities { get; set; }

        [JsonProperty("manufacturers")]
        public string[] Manufacturers { get; set; }

        [JsonProperty("mass_kg")]
        public int MassKg { get; set; }

        [JsonProperty("mass_lbs")]
        public int MassLbs { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonProperty("regime")]
        public string Regime { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("semi_major_axis_km")]
        public double SemiMajorAxisKm { get; set; }

        [JsonProperty("eccentricity")]
        public double Eccentricity { get; set; }

        [JsonProperty("periapsis_km")]
        public double PeriapsisKm { get; set; }

        [JsonProperty("apoapsis_km")]
        public double ApoapsisKm { get; set; }

        [JsonProperty("inclination_deg")]
        public double InclinationDeg { get; set; }

        [JsonProperty("period_min")]
        public double PeriodMin { get; set; }

        [JsonProperty("lifespan_years")]
        public string LifespanYears { get; set; }

        [JsonProperty("epoch")]
        public string Epoch { get; set; }

        [JsonProperty("mean_motion")]
        public double MeanMotion { get; set; }

        [JsonProperty("raan")]
        public double Raan { get; set; }

        [JsonProperty("arg_of_pericenter")]
        public double ArgOfPericenter { get; set; }

        [JsonProperty("mean_anomaly")]
        public double MeanAnomaly { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryPayloadsResponseDocsTypeItemDragonType
    {
        [JsonProperty("capsule")]
        public string Capsule { get; set; }

        [JsonProperty("mass_returned_kg")]
        public string MassReturnedKg { get; set; }

        [JsonProperty("mass_returned_lbs")]
        public string MassReturnedLbs { get; set; }

        [JsonProperty("flight_time_sec")]
        public int FlightTimeSec { get; set; }

        [JsonProperty("manifest")]
        public string Manifest { get; set; }

        [JsonProperty("water_landing")]
        public bool WaterLanding { get; set; }

        [JsonProperty("land_landing")]
        public bool LandLanding { get; set; }
    }

    public class GetRoadsterInfoResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("launch_date_utc")]
        public string LaunchDateUtc { get; set; }

        [JsonProperty("launch_date_unix")]
        public int LaunchDateUnix { get; set; }

        [JsonProperty("launch_mass_kg")]
        public int LaunchMassKg { get; set; }

        [JsonProperty("launch_mass_lbs")]
        public int LaunchMassLbs { get; set; }

        [JsonProperty("norad_id")]
        public int NoradId { get; set; }

        [JsonProperty("epoch_jd")]
        public double EpochJd { get; set; }

        [JsonProperty("orbit_type")]
        public string OrbitType { get; set; }

        [JsonProperty("apoapsis_au")]
        public double ApoapsisAu { get; set; }

        [JsonProperty("periapsis_au")]
        public double PeriapsisAu { get; set; }

        [JsonProperty("semi_major_axis_au")]
        public double SemiMajorAxisAu { get; set; }

        [JsonProperty("eccentricity")]
        public double Eccentricity { get; set; }

        [JsonProperty("inclination")]
        public double Inclination { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("periapsis_arg")]
        public double PeriapsisArg { get; set; }

        [JsonProperty("period_days")]
        public double PeriodDays { get; set; }

        [JsonProperty("speed_kph")]
        public double SpeedKph { get; set; }

        [JsonProperty("speed_mph")]
        public double SpeedMph { get; set; }

        [JsonProperty("earth_distance_km")]
        public double EarthDistanceKm { get; set; }

        [JsonProperty("earth_distance_mi")]
        public double EarthDistanceMi { get; set; }

        [JsonProperty("mars_distance_km")]
        public double MarsDistanceKm { get; set; }

        [JsonProperty("mars_distance_mi")]
        public double MarsDistanceMi { get; set; }

        [JsonProperty("flickr_images")]
        public string[] FlickrImages { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("video")]
        public string Video { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllRocketsResponseItem
    {
        [JsonProperty("height")]
        public GetAllRocketsResponseItemHeightType Height { get; set; }

        [JsonProperty("diameter")]
        public GetAllRocketsResponseItemDiameterType Diameter { get; set; }

        [JsonProperty("mass")]
        public GetAllRocketsResponseItemMassType Mass { get; set; }

        [JsonProperty("first_stage")]
        public GetAllRocketsResponseItemFirstStageType FirstStage { get; set; }

        [JsonProperty("second_stage")]
        public GetAllRocketsResponseItemSecondStageType SecondStage { get; set; }

        [JsonProperty("engines")]
        public GetAllRocketsResponseItemEnginesType Engines { get; set; }

        [JsonProperty("landing_legs")]
        public GetAllRocketsResponseItemLandingLegsType LandingLegs { get; set; }

        [JsonProperty("payload_weights")]
        public GetAllRocketsResponseItemPayloadWeightsTypeItem[] PayloadWeights { get; set; }

        [JsonProperty("flickr_images")]
        public string[] FlickrImages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("stages")]
        public int Stages { get; set; }

        [JsonProperty("boosters")]
        public int Boosters { get; set; }

        [JsonProperty("cost_per_launch")]
        public int CostPerLaunch { get; set; }

        [JsonProperty("success_rate_pct")]
        public int SuccessRatePct { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllRocketsResponseItemHeightType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public int Feet { get; set; }
    }

    public class GetAllRocketsResponseItemDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public int Feet { get; set; }
    }

    public class GetAllRocketsResponseItemMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class GetAllRocketsResponseItemFirstStageType
    {
        [JsonProperty("thrust_sea_level")]
        public GetAllRocketsResponseItemFirstStageTypeThrustSeaLevelType ThrustSeaLevel { get; set; }

        [JsonProperty("thrust_vacuum")]
        public GetAllRocketsResponseItemFirstStageTypeThrustVacuumType ThrustVacuum { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("engines")]
        public int Engines { get; set; }

        [JsonProperty("fuel_amount_tons")]
        public double FuelAmountTons { get; set; }

        [JsonProperty("burn_time_sec")]
        public int BurnTimeSec { get; set; }
    }

    public class GetAllRocketsResponseItemFirstStageTypeThrustSeaLevelType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetAllRocketsResponseItemFirstStageTypeThrustVacuumType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetAllRocketsResponseItemSecondStageType
    {
        [JsonProperty("thrust")]
        public GetAllRocketsResponseItemSecondStageTypeThrustType Thrust { get; set; }

        [JsonProperty("payloads")]
        public GetAllRocketsResponseItemSecondStageTypePayloadsType Payloads { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("engines")]
        public int Engines { get; set; }

        [JsonProperty("fuel_amount_tons")]
        public double FuelAmountTons { get; set; }

        [JsonProperty("burn_time_sec")]
        public int BurnTimeSec { get; set; }
    }

    public class GetAllRocketsResponseItemSecondStageTypeThrustType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetAllRocketsResponseItemSecondStageTypePayloadsType
    {
        [JsonProperty("composite_fairing")]
        public GetAllRocketsResponseItemSecondStageTypePayloadsTypeCompositeFairingType CompositeFairing { get; set; }

        [JsonProperty("option_1")]
        public string Option1 { get; set; }
    }

    public class GetAllRocketsResponseItemSecondStageTypePayloadsTypeCompositeFairingType
    {
        [JsonProperty("height")]
        public GetAllRocketsResponseItemSecondStageTypePayloadsTypeCompositeFairingTypeHeightType Height { get; set; }

        [JsonProperty("diameter")]
        public GetAllRocketsResponseItemSecondStageTypePayloadsTypeCompositeFairingTypeDiameterType Diameter { get; set; }
    }

    public class GetAllRocketsResponseItemSecondStageTypePayloadsTypeCompositeFairingTypeHeightType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public string Feet { get; set; }
    }

    public class GetAllRocketsResponseItemSecondStageTypePayloadsTypeCompositeFairingTypeDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public string Feet { get; set; }
    }

    public class GetAllRocketsResponseItemEnginesType
    {
        [JsonProperty("isp")]
        public GetAllRocketsResponseItemEnginesTypeIspType Isp { get; set; }

        [JsonProperty("thrust_sea_level")]
        public GetAllRocketsResponseItemEnginesTypeThrustSeaLevelType ThrustSeaLevel { get; set; }

        [JsonProperty("thrust_vacuum")]
        public GetAllRocketsResponseItemEnginesTypeThrustVacuumType ThrustVacuum { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("engine_loss_max")]
        public int EngineLossMax { get; set; }

        [JsonProperty("propellant_1")]
        public string Propellant1 { get; set; }

        [JsonProperty("propellant_2")]
        public string Propellant2 { get; set; }

        [JsonProperty("thrust_to_weight")]
        public int ThrustToWeight { get; set; }
    }

    public class GetAllRocketsResponseItemEnginesTypeIspType
    {
        [JsonProperty("sea_level")]
        public int SeaLevel { get; set; }

        [JsonProperty("vacuum")]
        public int Vacuum { get; set; }
    }

    public class GetAllRocketsResponseItemEnginesTypeThrustSeaLevelType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetAllRocketsResponseItemEnginesTypeThrustVacuumType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetAllRocketsResponseItemLandingLegsType
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }
    }

    public class GetAllRocketsResponseItemPayloadWeightsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class GetARocketResponse
    {
        [JsonProperty("height")]
        public GetARocketResponseHeightType Height { get; set; }

        [JsonProperty("diameter")]
        public GetARocketResponseDiameterType Diameter { get; set; }

        [JsonProperty("mass")]
        public GetARocketResponseMassType Mass { get; set; }

        [JsonProperty("first_stage")]
        public GetARocketResponseFirstStageType FirstStage { get; set; }

        [JsonProperty("second_stage")]
        public GetARocketResponseSecondStageType SecondStage { get; set; }

        [JsonProperty("engines")]
        public GetARocketResponseEnginesType Engines { get; set; }

        [JsonProperty("landing_legs")]
        public GetARocketResponseLandingLegsType LandingLegs { get; set; }

        [JsonProperty("payload_weights")]
        public GetARocketResponsePayloadWeightsTypeItem[] PayloadWeights { get; set; }

        [JsonProperty("flickr_images")]
        public string[] FlickrImages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("stages")]
        public int Stages { get; set; }

        [JsonProperty("boosters")]
        public int Boosters { get; set; }

        [JsonProperty("cost_per_launch")]
        public int CostPerLaunch { get; set; }

        [JsonProperty("success_rate_pct")]
        public int SuccessRatePct { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetARocketResponseHeightType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public int Feet { get; set; }
    }

    public class GetARocketResponseDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public int Feet { get; set; }
    }

    public class GetARocketResponseMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class GetARocketResponseFirstStageType
    {
        [JsonProperty("thrust_sea_level")]
        public GetARocketResponseFirstStageTypeThrustSeaLevelType ThrustSeaLevel { get; set; }

        [JsonProperty("thrust_vacuum")]
        public GetARocketResponseFirstStageTypeThrustVacuumType ThrustVacuum { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("engines")]
        public int Engines { get; set; }

        [JsonProperty("fuel_amount_tons")]
        public double FuelAmountTons { get; set; }

        [JsonProperty("burn_time_sec")]
        public int BurnTimeSec { get; set; }
    }

    public class GetARocketResponseFirstStageTypeThrustSeaLevelType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetARocketResponseFirstStageTypeThrustVacuumType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetARocketResponseSecondStageType
    {
        [JsonProperty("thrust")]
        public GetARocketResponseSecondStageTypeThrustType Thrust { get; set; }

        [JsonProperty("payloads")]
        public GetARocketResponseSecondStageTypePayloadsType Payloads { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("engines")]
        public int Engines { get; set; }

        [JsonProperty("fuel_amount_tons")]
        public double FuelAmountTons { get; set; }

        [JsonProperty("burn_time_sec")]
        public int BurnTimeSec { get; set; }
    }

    public class GetARocketResponseSecondStageTypeThrustType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetARocketResponseSecondStageTypePayloadsType
    {
        [JsonProperty("composite_fairing")]
        public GetARocketResponseSecondStageTypePayloadsTypeCompositeFairingType CompositeFairing { get; set; }

        [JsonProperty("option_1")]
        public string Option1 { get; set; }
    }

    public class GetARocketResponseSecondStageTypePayloadsTypeCompositeFairingType
    {
        [JsonProperty("height")]
        public GetARocketResponseSecondStageTypePayloadsTypeCompositeFairingTypeHeightType Height { get; set; }

        [JsonProperty("diameter")]
        public GetARocketResponseSecondStageTypePayloadsTypeCompositeFairingTypeDiameterType Diameter { get; set; }
    }

    public class GetARocketResponseSecondStageTypePayloadsTypeCompositeFairingTypeHeightType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public string Feet { get; set; }
    }

    public class GetARocketResponseSecondStageTypePayloadsTypeCompositeFairingTypeDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public string Feet { get; set; }
    }

    public class GetARocketResponseEnginesType
    {
        [JsonProperty("isp")]
        public GetARocketResponseEnginesTypeIspType Isp { get; set; }

        [JsonProperty("thrust_sea_level")]
        public GetARocketResponseEnginesTypeThrustSeaLevelType ThrustSeaLevel { get; set; }

        [JsonProperty("thrust_vacuum")]
        public GetARocketResponseEnginesTypeThrustVacuumType ThrustVacuum { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("engine_loss_max")]
        public int EngineLossMax { get; set; }

        [JsonProperty("propellant_1")]
        public string Propellant1 { get; set; }

        [JsonProperty("propellant_2")]
        public string Propellant2 { get; set; }

        [JsonProperty("thrust_to_weight")]
        public int ThrustToWeight { get; set; }
    }

    public class GetARocketResponseEnginesTypeIspType
    {
        [JsonProperty("sea_level")]
        public int SeaLevel { get; set; }

        [JsonProperty("vacuum")]
        public int Vacuum { get; set; }
    }

    public class GetARocketResponseEnginesTypeThrustSeaLevelType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetARocketResponseEnginesTypeThrustVacuumType
    {
        [JsonProperty("kN")]
        public int KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class GetARocketResponseLandingLegsType
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }
    }

    public class GetARocketResponsePayloadWeightsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class QueryRocketsResponse
    {
        [JsonProperty("docs")]
        public QueryRocketsResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public string NextPage { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItem
    {
        [JsonProperty("height")]
        public QueryRocketsResponseDocsTypeItemHeightType Height { get; set; }

        [JsonProperty("diameter")]
        public QueryRocketsResponseDocsTypeItemDiameterType Diameter { get; set; }

        [JsonProperty("mass")]
        public QueryRocketsResponseDocsTypeItemMassType Mass { get; set; }

        [JsonProperty("first_stage")]
        public QueryRocketsResponseDocsTypeItemFirstStageType FirstStage { get; set; }

        [JsonProperty("second_stage")]
        public QueryRocketsResponseDocsTypeItemSecondStageType SecondStage { get; set; }

        [JsonProperty("engines")]
        public QueryRocketsResponseDocsTypeItemEnginesType Engines { get; set; }

        [JsonProperty("landing_legs")]
        public QueryRocketsResponseDocsTypeItemLandingLegsType LandingLegs { get; set; }

        [JsonProperty("payload_weights")]
        public QueryRocketsResponseDocsTypeItemPayloadWeightsTypeItem[] PayloadWeights { get; set; }

        [JsonProperty("flickr_images")]
        public string[] FlickrImages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("stages")]
        public int Stages { get; set; }

        [JsonProperty("boosters")]
        public int Boosters { get; set; }

        [JsonProperty("cost_per_launch")]
        public int CostPerLaunch { get; set; }

        [JsonProperty("success_rate_pct")]
        public int SuccessRatePct { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemHeightType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public int Feet { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public double Feet { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemMassType
    {
        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemFirstStageType
    {
        [JsonProperty("thrust_sea_level")]
        public QueryRocketsResponseDocsTypeItemFirstStageTypeThrustSeaLevelType ThrustSeaLevel { get; set; }

        [JsonProperty("thrust_vacuum")]
        public QueryRocketsResponseDocsTypeItemFirstStageTypeThrustVacuumType ThrustVacuum { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("engines")]
        public int Engines { get; set; }

        [JsonProperty("fuel_amount_tons")]
        public double FuelAmountTons { get; set; }

        [JsonProperty("burn_time_sec")]
        public int BurnTimeSec { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemFirstStageTypeThrustSeaLevelType
    {
        [JsonProperty("kN")]
        public double KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemFirstStageTypeThrustVacuumType
    {
        [JsonProperty("kN")]
        public double KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemSecondStageType
    {
        [JsonProperty("thrust")]
        public QueryRocketsResponseDocsTypeItemSecondStageTypeThrustType Thrust { get; set; }

        [JsonProperty("payloads")]
        public QueryRocketsResponseDocsTypeItemSecondStageTypePayloadsType Payloads { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("engines")]
        public int Engines { get; set; }

        [JsonProperty("fuel_amount_tons")]
        public double FuelAmountTons { get; set; }

        [JsonProperty("burn_time_sec")]
        public int BurnTimeSec { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemSecondStageTypeThrustType
    {
        [JsonProperty("kN")]
        public double KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemSecondStageTypePayloadsType
    {
        [JsonProperty("composite_fairing")]
        public QueryRocketsResponseDocsTypeItemSecondStageTypePayloadsTypeCompositeFairingType CompositeFairing { get; set; }

        [JsonProperty("option_1")]
        public string Option1 { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemSecondStageTypePayloadsTypeCompositeFairingType
    {
        [JsonProperty("height")]
        public QueryRocketsResponseDocsTypeItemSecondStageTypePayloadsTypeCompositeFairingTypeHeightType Height { get; set; }

        [JsonProperty("diameter")]
        public QueryRocketsResponseDocsTypeItemSecondStageTypePayloadsTypeCompositeFairingTypeDiameterType Diameter { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemSecondStageTypePayloadsTypeCompositeFairingTypeHeightType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public string Feet { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemSecondStageTypePayloadsTypeCompositeFairingTypeDiameterType
    {
        [JsonProperty("meters")]
        public double Meters { get; set; }

        [JsonProperty("feet")]
        public string Feet { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemEnginesType
    {
        [JsonProperty("isp")]
        public QueryRocketsResponseDocsTypeItemEnginesTypeIspType Isp { get; set; }

        [JsonProperty("thrust_sea_level")]
        public QueryRocketsResponseDocsTypeItemEnginesTypeThrustSeaLevelType ThrustSeaLevel { get; set; }

        [JsonProperty("thrust_vacuum")]
        public QueryRocketsResponseDocsTypeItemEnginesTypeThrustVacuumType ThrustVacuum { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("engine_loss_max")]
        public int EngineLossMax { get; set; }

        [JsonProperty("propellant_1")]
        public string Propellant1 { get; set; }

        [JsonProperty("propellant_2")]
        public string Propellant2 { get; set; }

        [JsonProperty("thrust_to_weight")]
        public int ThrustToWeight { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemEnginesTypeIspType
    {
        [JsonProperty("sea_level")]
        public int SeaLevel { get; set; }

        [JsonProperty("vacuum")]
        public int Vacuum { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemEnginesTypeThrustSeaLevelType
    {
        [JsonProperty("kN")]
        public double KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemEnginesTypeThrustVacuumType
    {
        [JsonProperty("kN")]
        public double KN { get; set; }

        [JsonProperty("lbf")]
        public int Lbf { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemLandingLegsType
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }
    }

    public class QueryRocketsResponseDocsTypeItemPayloadWeightsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("kg")]
        public int Kg { get; set; }

        [JsonProperty("lb")]
        public int Lb { get; set; }
    }

    public class GetAllShipsResponseItem
    {
        [JsonProperty("last_ais_update")]
        public string LastAisUpdate { get; set; }

        [JsonProperty("legacy_id")]
        public string LegacyId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("imo")]
        public int Imo { get; set; }

        [JsonProperty("mmsi")]
        public int Mmsi { get; set; }

        [JsonProperty("abs")]
        public int Abs { get; set; }

        [JsonProperty("class")]
        public int Class { get; set; }

        [JsonProperty("mass_kg")]
        public int MassKg { get; set; }

        [JsonProperty("mass_lbs")]
        public int MassLbs { get; set; }

        [JsonProperty("year_built")]
        public int YearBuilt { get; set; }

        [JsonProperty("home_port")]
        public string HomePort { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("speed_kn")]
        public string SpeedKn { get; set; }

        [JsonProperty("course_deg")]
        public string CourseDeg { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAShipResponse
    {
        [JsonProperty("last_ais_update")]
        public string LastAisUpdate { get; set; }

        [JsonProperty("legacy_id")]
        public string LegacyId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("imo")]
        public int Imo { get; set; }

        [JsonProperty("mmsi")]
        public int Mmsi { get; set; }

        [JsonProperty("abs")]
        public string Abs { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("mass_kg")]
        public int MassKg { get; set; }

        [JsonProperty("mass_lbs")]
        public int MassLbs { get; set; }

        [JsonProperty("year_built")]
        public int YearBuilt { get; set; }

        [JsonProperty("home_port")]
        public string HomePort { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("speed_kn")]
        public string SpeedKn { get; set; }

        [JsonProperty("course_deg")]
        public string CourseDeg { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryShipsResponse
    {
        [JsonProperty("docs")]
        public QueryShipsResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }

    public class QueryShipsResponseDocsTypeItem
    {
        [JsonProperty("last_ais_update")]
        public string LastAisUpdate { get; set; }

        [JsonProperty("legacy_id")]
        public string LegacyId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("imo")]
        public int Imo { get; set; }

        [JsonProperty("mmsi")]
        public int Mmsi { get; set; }

        [JsonProperty("abs")]
        public int Abs { get; set; }

        [JsonProperty("class")]
        public int Class { get; set; }

        [JsonProperty("mass_kg")]
        public int MassKg { get; set; }

        [JsonProperty("mass_lbs")]
        public int MassLbs { get; set; }

        [JsonProperty("year_built")]
        public int YearBuilt { get; set; }

        [JsonProperty("home_port")]
        public string HomePort { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("speed_kn")]
        public string SpeedKn { get; set; }

        [JsonProperty("course_deg")]
        public string CourseDeg { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("launches")]
        public string[] Launches { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllStarlinkSatsResponseItem
    {
        [JsonProperty("spaceTrack")]
        public GetAllStarlinkSatsResponseItemSpaceTrackType SpaceTrack { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("height_km")]
        public double HeightKm { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("velocity_kms")]
        public double VelocityKms { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAllStarlinkSatsResponseItemSpaceTrackType
    {
        [JsonProperty("CCSDS_OMM_VERS")]
        public string CCSDSOMMVERS { get; set; }
        public string COMMENT { get; set; }

        [JsonProperty("CREATION_DATE")]
        public string CREATIONDATE { get; set; }
        public string ORIGINATOR { get; set; }

        [JsonProperty("OBJECT_NAME")]
        public string OBJECTNAME { get; set; }

        [JsonProperty("OBJECT_ID")]
        public string OBJECTID { get; set; }

        [JsonProperty("CENTER_NAME")]
        public string CENTERNAME { get; set; }

        [JsonProperty("REF_FRAME")]
        public string REFFRAME { get; set; }

        [JsonProperty("TIME_SYSTEM")]
        public string TIMESYSTEM { get; set; }

        [JsonProperty("MEAN_ELEMENT_THEORY")]
        public string MEANELEMENTTHEORY { get; set; }
        public string EPOCH { get; set; }

        [JsonProperty("MEAN_MOTION")]
        public double MEANMOTION { get; set; }
        public double ECCENTRICITY { get; set; }
        public double INCLINATION { get; set; }

        [JsonProperty("RA_OF_ASC_NODE")]
        public double RAOFASCNODE { get; set; }

        [JsonProperty("ARG_OF_PERICENTER")]
        public double ARGOFPERICENTER { get; set; }

        [JsonProperty("MEAN_ANOMALY")]
        public double MEANANOMALY { get; set; }

        [JsonProperty("EPHEMERIS_TYPE")]
        public int EPHEMERISTYPE { get; set; }

        [JsonProperty("CLASSIFICATION_TYPE")]
        public string CLASSIFICATIONTYPE { get; set; }

        [JsonProperty("NORAD_CAT_ID")]
        public int NORADCATID { get; set; }

        [JsonProperty("ELEMENT_SET_NO")]
        public int ELEMENTSETNO { get; set; }

        [JsonProperty("REV_AT_EPOCH")]
        public int REVATEPOCH { get; set; }
        public double BSTAR { get; set; }

        [JsonProperty("MEAN_MOTION_DOT")]
        public double MEANMOTIONDOT { get; set; }

        [JsonProperty("MEAN_MOTION_DDOT")]
        public int MEANMOTIONDDOT { get; set; }

        [JsonProperty("SEMIMAJOR_AXIS")]
        public double SEMIMAJORAXIS { get; set; }
        public double PERIOD { get; set; }
        public double APOAPSIS { get; set; }
        public double PERIAPSIS { get; set; }

        [JsonProperty("OBJECT_TYPE")]
        public string OBJECTTYPE { get; set; }

        [JsonProperty("RCS_SIZE")]
        public string RCSSIZE { get; set; }

        [JsonProperty("COUNTRY_CODE")]
        public string COUNTRYCODE { get; set; }

        [JsonProperty("LAUNCH_DATE")]
        public string LAUNCHDATE { get; set; }
        public string SITE { get; set; }

        [JsonProperty("DECAY_DATE")]
        public string DECAYDATE { get; set; }
        public int DECAYED { get; set; }
        public int FILE { get; set; }

        [JsonProperty("GP_ID")]
        public int GPID { get; set; }

        [JsonProperty("TLE_LINE0")]
        public string TLELINE0 { get; set; }

        [JsonProperty("TLE_LINE1")]
        public string TLELINE1 { get; set; }

        [JsonProperty("TLE_LINE2")]
        public string TLELINE2 { get; set; }
    }

    public class GetAStarlinkSatResponse
    {
        [JsonProperty("spaceTrack")]
        public GetAStarlinkSatResponseSpaceTrackType SpaceTrack { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("height_km")]
        public double HeightKm { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("velocity_kms")]
        public double VelocityKms { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetAStarlinkSatResponseSpaceTrackType
    {
        [JsonProperty("CCSDS_OMM_VERS")]
        public string CCSDSOMMVERS { get; set; }
        public string COMMENT { get; set; }

        [JsonProperty("CREATION_DATE")]
        public string CREATIONDATE { get; set; }
        public string ORIGINATOR { get; set; }

        [JsonProperty("OBJECT_NAME")]
        public string OBJECTNAME { get; set; }

        [JsonProperty("OBJECT_ID")]
        public string OBJECTID { get; set; }

        [JsonProperty("CENTER_NAME")]
        public string CENTERNAME { get; set; }

        [JsonProperty("REF_FRAME")]
        public string REFFRAME { get; set; }

        [JsonProperty("TIME_SYSTEM")]
        public string TIMESYSTEM { get; set; }

        [JsonProperty("MEAN_ELEMENT_THEORY")]
        public string MEANELEMENTTHEORY { get; set; }
        public string EPOCH { get; set; }

        [JsonProperty("MEAN_MOTION")]
        public double MEANMOTION { get; set; }
        public double ECCENTRICITY { get; set; }
        public double INCLINATION { get; set; }

        [JsonProperty("RA_OF_ASC_NODE")]
        public double RAOFASCNODE { get; set; }

        [JsonProperty("ARG_OF_PERICENTER")]
        public double ARGOFPERICENTER { get; set; }

        [JsonProperty("MEAN_ANOMALY")]
        public double MEANANOMALY { get; set; }

        [JsonProperty("EPHEMERIS_TYPE")]
        public int EPHEMERISTYPE { get; set; }

        [JsonProperty("CLASSIFICATION_TYPE")]
        public string CLASSIFICATIONTYPE { get; set; }

        [JsonProperty("NORAD_CAT_ID")]
        public int NORADCATID { get; set; }

        [JsonProperty("ELEMENT_SET_NO")]
        public int ELEMENTSETNO { get; set; }

        [JsonProperty("REV_AT_EPOCH")]
        public int REVATEPOCH { get; set; }
        public double BSTAR { get; set; }

        [JsonProperty("MEAN_MOTION_DOT")]
        public double MEANMOTIONDOT { get; set; }

        [JsonProperty("MEAN_MOTION_DDOT")]
        public int MEANMOTIONDDOT { get; set; }

        [JsonProperty("SEMIMAJOR_AXIS")]
        public double SEMIMAJORAXIS { get; set; }
        public double PERIOD { get; set; }
        public double APOAPSIS { get; set; }
        public double PERIAPSIS { get; set; }

        [JsonProperty("OBJECT_TYPE")]
        public string OBJECTTYPE { get; set; }

        [JsonProperty("RCS_SIZE")]
        public string RCSSIZE { get; set; }

        [JsonProperty("COUNTRY_CODE")]
        public string COUNTRYCODE { get; set; }

        [JsonProperty("LAUNCH_DATE")]
        public string LAUNCHDATE { get; set; }
        public string SITE { get; set; }

        [JsonProperty("DECAY_DATE")]
        public string DECAYDATE { get; set; }
        public int DECAYED { get; set; }
        public int FILE { get; set; }

        [JsonProperty("GP_ID")]
        public int GPID { get; set; }

        [JsonProperty("TLE_LINE0")]
        public string TLELINE0 { get; set; }

        [JsonProperty("TLE_LINE1")]
        public string TLELINE1 { get; set; }

        [JsonProperty("TLE_LINE2")]
        public string TLELINE2 { get; set; }
    }

    public class QueryStarlinkSatsResponse
    {
        [JsonProperty("docs")]
        public QueryStarlinkSatsResponseDocsTypeItem[] Docs { get; set; }

        [JsonProperty("totalDocs")]
        public int TotalDocs { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pagingCounter")]
        public int PagingCounter { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("prevPage")]
        public string PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public int NextPage { get; set; }
    }

    public class QueryStarlinkSatsResponseDocsTypeItem
    {
        [JsonProperty("spaceTrack")]
        public QueryStarlinkSatsResponseDocsTypeItemSpaceTrackType SpaceTrack { get; set; }

        [JsonProperty("launch")]
        public string Launch { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("height_km")]
        public string HeightKm { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("velocity_kms")]
        public string VelocityKms { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class QueryStarlinkSatsResponseDocsTypeItemSpaceTrackType
    {
        [JsonProperty("CCSDS_OMM_VERS")]
        public string CCSDSOMMVERS { get; set; }
        public string COMMENT { get; set; }

        [JsonProperty("CREATION_DATE")]
        public string CREATIONDATE { get; set; }
        public string ORIGINATOR { get; set; }

        [JsonProperty("OBJECT_NAME")]
        public string OBJECTNAME { get; set; }

        [JsonProperty("OBJECT_ID")]
        public string OBJECTID { get; set; }

        [JsonProperty("CENTER_NAME")]
        public string CENTERNAME { get; set; }

        [JsonProperty("REF_FRAME")]
        public string REFFRAME { get; set; }

        [JsonProperty("TIME_SYSTEM")]
        public string TIMESYSTEM { get; set; }

        [JsonProperty("MEAN_ELEMENT_THEORY")]
        public string MEANELEMENTTHEORY { get; set; }
        public string EPOCH { get; set; }

        [JsonProperty("MEAN_MOTION")]
        public double MEANMOTION { get; set; }
        public double ECCENTRICITY { get; set; }
        public double INCLINATION { get; set; }

        [JsonProperty("RA_OF_ASC_NODE")]
        public double RAOFASCNODE { get; set; }

        [JsonProperty("ARG_OF_PERICENTER")]
        public double ARGOFPERICENTER { get; set; }

        [JsonProperty("MEAN_ANOMALY")]
        public double MEANANOMALY { get; set; }

        [JsonProperty("EPHEMERIS_TYPE")]
        public int EPHEMERISTYPE { get; set; }

        [JsonProperty("CLASSIFICATION_TYPE")]
        public string CLASSIFICATIONTYPE { get; set; }

        [JsonProperty("NORAD_CAT_ID")]
        public int NORADCATID { get; set; }

        [JsonProperty("ELEMENT_SET_NO")]
        public int ELEMENTSETNO { get; set; }

        [JsonProperty("REV_AT_EPOCH")]
        public int REVATEPOCH { get; set; }
        public double BSTAR { get; set; }

        [JsonProperty("MEAN_MOTION_DOT")]
        public double MEANMOTIONDOT { get; set; }

        [JsonProperty("MEAN_MOTION_DDOT")]
        public double MEANMOTIONDDOT { get; set; }

        [JsonProperty("SEMIMAJOR_AXIS")]
        public double SEMIMAJORAXIS { get; set; }
        public double PERIOD { get; set; }
        public double APOAPSIS { get; set; }
        public double PERIAPSIS { get; set; }

        [JsonProperty("OBJECT_TYPE")]
        public string OBJECTTYPE { get; set; }

        [JsonProperty("RCS_SIZE")]
        public string RCSSIZE { get; set; }

        [JsonProperty("COUNTRY_CODE")]
        public string COUNTRYCODE { get; set; }

        [JsonProperty("LAUNCH_DATE")]
        public string LAUNCHDATE { get; set; }
        public string SITE { get; set; }

        [JsonProperty("DECAY_DATE")]
        public string DECAYDATE { get; set; }
        public int DECAYED { get; set; }
        public int FILE { get; set; }

        [JsonProperty("GP_ID")]
        public int GPID { get; set; }

        [JsonProperty("TLE_LINE0")]
        public string TLELINE0 { get; set; }

        [JsonProperty("TLE_LINE1")]
        public string TLELINE1 { get; set; }

        [JsonProperty("TLE_LINE2")]
        public string TLELINE2 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rspacexip;

    public partial class WorkflowManagedActions
    {
        public RspacexipActions Rspacexip(string connectionId) => new RspacexipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RspacexipTriggers Rspacexip(string connectionId) => new RspacexipTriggers(connectionId);
    }
}