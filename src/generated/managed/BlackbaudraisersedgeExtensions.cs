//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudraisersedge
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudraisersedgeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentConsent, ApiConnectionActionConfiguration> CreateConstituentConsent(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodychannel, Expression<Func<bodyresponseInput>> bodyresponse, Expression<Func<string>> bodydate, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyconsentStatement = null, Expression<Func<string>> bodyprivacyNotice = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodychannel = WorkflowExpression.Compile(bodychannel, nameof(bodychannel), required: true);
            var __workflow_bodyresponse = WorkflowExpression.Compile(bodyresponse, nameof(bodyresponse), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodyconsentStatement = WorkflowExpression.Compile(bodyconsentStatement, nameof(bodyconsentStatement), required: false);
            var __workflow_bodyprivacyNotice = WorkflowExpression.Compile(bodyprivacyNotice, nameof(bodyprivacyNotice), required: false);
            return new DeferredBodyAction<CommPrefApiCreatedConstituentConsent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/commpref/v1/consent/consents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["channel"] = ExpressionConverter.ConvertO(__workflow_bodychannel);
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                bodypropCount++;
                body["constituent_consent_response"] = ExpressionConverter.ConvertO(__workflow_bodyresponse);
                bodypropCount++;
                body["consent_date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                if (__workflow_bodyconsentStatement != null)
                {
                    body["consent_statement"] = ExpressionConverter.ConvertO(__workflow_bodyconsentStatement);
                    bodypropCount++;
                }

                if (__workflow_bodyprivacyNotice != null)
                {
                    body["privacy_notice"] = ExpressionConverter.ConvertO(__workflow_bodyprivacyNotice);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CommPrefApiCreatedConstituentConsent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiConstituentConsentReadCollection, ApiConnectionActionConfiguration> ListConstituentConsents(Expression<Func<string>> constituentId, Expression<Func<bool>> mostRecentOnly = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_mostRecentOnly = WorkflowExpression.Compile(mostRecentOnly, nameof(mostRecentOnly), required: false);
            return new DeferredBodyAction<CommPrefApiConstituentConsentReadCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituents/{0}/consents", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(__workflow_mostRecentOnly);
                return new ApiConnectionAction<CommPrefApiConstituentConsentReadCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiConstituentSolicitCodeReadCollection, ApiConnectionActionConfiguration> ListConstituentSolicitCodes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<CommPrefApiConstituentSolicitCodeReadCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituents/{0}/constituentsolicitcodes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CommPrefApiConstituentSolicitCodeReadCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentSolicitCode, ApiConnectionActionConfiguration> CreateConstituentSolicitCode(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodysolicitCode, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodysolicitCode = WorkflowExpression.Compile(bodysolicitCode, nameof(bodysolicitCode), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredBodyAction<CommPrefApiCreatedConstituentSolicitCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/commpref/v1/constituentsolicitcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["solicit_code"] = ExpressionConverter.ConvertO(__workflow_bodysolicitCode);
                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CommPrefApiCreatedConstituentSolicitCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentSolicitCode(Expression<Func<string>> constituentSolicitCodeId, Expression<Func<string>> bodysolicitCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var __workflow_constituentSolicitCodeId = WorkflowExpression.Compile(constituentSolicitCodeId, nameof(constituentSolicitCodeId), required: true);
            var __workflow_bodysolicitCode = WorkflowExpression.Compile(bodysolicitCode, nameof(bodysolicitCode), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commpref/v1/constituentsolicitcodes/{0}", __workflow_constituentSolicitCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysolicitCode != null)
                {
                    body["solicit_code"] = ExpressionConverter.ConvertO(__workflow_bodysolicitCode);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead, ApiConnectionActionConfiguration> ListActions(Expression<Func<string>> listId = null, Expression<Func<string>> computedStatus = null, Expression<Func<string>> statusCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: false);
            var __workflow_computedStatus = WorkflowExpression.Compile(computedStatus, nameof(computedStatus), required: false);
            var __workflow_statusCode = WorkflowExpression.Compile(statusCode, nameof(statusCode), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(__workflow_listId);
                if (__workflow_computedStatus != null)
                    callPayload.Queries["computed_status"] = ExpressionConverter.Convert(__workflow_computedStatus);
                if (__workflow_statusCode != null)
                    callPayload.Queries["status_code"] = ExpressionConverter.Convert(__workflow_statusCode);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedAction, ApiConnectionActionConfiguration> CreateAction(Expression<Func<string>> bodyconstituentId, Expression<Func<bodycategoryInput>> bodycategory, Expression<Func<string>> bodydate, Expression<Func<bool>> bodycompleted = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodynote = null, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<string[]>> bodyfundraiserS = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyopportunityId = null, Expression<Func<bodyoutcomeInput>> bodyoutcome = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodytype = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodycompleted = WorkflowExpression.Compile(bodycompleted, nameof(bodycompleted), required: false);
            var __workflow_bodycompletedOn = WorkflowExpression.Compile(bodycompletedOn, nameof(bodycompletedOn), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodydirection = WorkflowExpression.Compile(bodydirection, nameof(bodydirection), required: false);
            var __workflow_bodyfundraiserS = WorkflowExpression.Compile(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyopportunityId = WorkflowExpression.Compile(bodyopportunityId, nameof(bodyopportunityId), required: false);
            var __workflow_bodyoutcome = WorkflowExpression.Compile(bodyoutcome, nameof(bodyoutcome), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedAction, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodycompleted != null)
                {
                    body["completed"] = ExpressionConverter.ConvertO(__workflow_bodycompleted);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedOn != null)
                {
                    body["completed_date"] = ExpressionConverter.ConvertO(__workflow_bodycompletedOn);
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                if (__workflow_bodynote != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodydirection != null)
                {
                    body["direction"] = ExpressionConverter.ConvertO(__workflow_bodydirection);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserS);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityId != null)
                {
                    body["opportunity_id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityId);
                    bodypropCount++;
                }

                if (__workflow_bodyoutcome != null)
                {
                    body["outcome"] = ExpressionConverter.ConvertO(__workflow_bodyoutcome);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiActionRead, ApiConnectionActionConfiguration> GetAction(Expression<Func<string>> actionId)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiActionRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/actions/{0}", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiActionRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditAction(Expression<Func<string>> actionId, Expression<Func<bodycategoryInput>> bodycategory = null, Expression<Func<bool>> bodycompleted = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodynote = null, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<string[]>> bodyfundraiserS = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyopportunityId = null, Expression<Func<bodyoutcomeInput>> bodyoutcome = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodytype = null)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodycompleted = WorkflowExpression.Compile(bodycompleted, nameof(bodycompleted), required: false);
            var __workflow_bodycompletedOn = WorkflowExpression.Compile(bodycompletedOn, nameof(bodycompletedOn), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodydirection = WorkflowExpression.Compile(bodydirection, nameof(bodydirection), required: false);
            var __workflow_bodyfundraiserS = WorkflowExpression.Compile(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyopportunityId = WorkflowExpression.Compile(bodyopportunityId, nameof(bodyopportunityId), required: false);
            var __workflow_bodyoutcome = WorkflowExpression.Compile(bodyoutcome, nameof(bodyoutcome), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/actions/{0}", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodycompleted != null)
                {
                    body["completed"] = ExpressionConverter.ConvertO(__workflow_bodycompleted);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedOn != null)
                {
                    body["completed_date"] = ExpressionConverter.ConvertO(__workflow_bodycompletedOn);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodydirection != null)
                {
                    body["direction"] = ExpressionConverter.ConvertO(__workflow_bodydirection);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserS);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityId != null)
                {
                    body["opportunity_id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityId);
                    bodypropCount++;
                }

                if (__workflow_bodyoutcome != null)
                {
                    body["outcome"] = ExpressionConverter.ConvertO(__workflow_bodyoutcome);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionAttachmentRead, ApiConnectionActionConfiguration> ListActionAttachments(Expression<Func<string>> actionId)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/actions/{0}/attachments", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionCustomFieldRead, ApiConnectionActionConfiguration> ListActionCustomFields(Expression<Func<string>> actionId)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/actions/{0}/customfields", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionAttachment, ApiConnectionActionConfiguration> CreateActionAttachment(Expression<Func<string>> bodyactionId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null)
        {
            var __workflow_bodyactionId = WorkflowExpression.Compile(bodyactionId, nameof(bodyactionId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedActionAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/actions/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyactionId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedActionAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditActionAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/actions/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionCustomField, ApiConnectionActionConfiguration> CreateActionCustomField(Expression<Func<string>> bodyactionId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodyactionId = WorkflowExpression.Compile(bodyactionId, nameof(bodyactionId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedActionCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/actions/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyactionId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedActionCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditActionCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/actions/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAddress, ApiConnectionActionConfiguration> CreateConstituentAddress(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyaddressType, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodysuburb = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodyvalidFrom = null, Expression<Func<string>> bodyvalidTo = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartyear = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndyear = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyaddressType = WorkflowExpression.Compile(bodyaddressType, nameof(bodyaddressType), required: true);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyaddressLines = WorkflowExpression.Compile(bodyaddressLines, nameof(bodyaddressLines), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodysuburb = WorkflowExpression.Compile(bodysuburb, nameof(bodysuburb), required: false);
            var __workflow_bodycounty = WorkflowExpression.Compile(bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodycART = WorkflowExpression.Compile(bodycART, nameof(bodycART), required: false);
            var __workflow_bodylOT = WorkflowExpression.Compile(bodylOT, nameof(bodylOT), required: false);
            var __workflow_bodydPC = WorkflowExpression.Compile(bodydPC, nameof(bodydPC), required: false);
            var __workflow_bodyvalidFrom = WorkflowExpression.Compile(bodyvalidFrom, nameof(bodyvalidFrom), required: false);
            var __workflow_bodyvalidTo = WorkflowExpression.Compile(bodyvalidTo, nameof(bodyvalidTo), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotMail = WorkflowExpression.Compile(bodydoNotMail, nameof(bodydoNotMail), required: false);
            var __workflow_bodyseasonalStartday = WorkflowExpression.Compile(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            var __workflow_bodyseasonalStartmonth = WorkflowExpression.Compile(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            var __workflow_bodyseasonalStartyear = WorkflowExpression.Compile(bodyseasonalStartyear, nameof(bodyseasonalStartyear), required: false);
            var __workflow_bodyseasonalEndday = WorkflowExpression.Compile(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            var __workflow_bodyseasonalEndmonth = WorkflowExpression.Compile(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            var __workflow_bodyseasonalEndyear = WorkflowExpression.Compile(bodyseasonalEndyear, nameof(bodyseasonalEndyear), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAddress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/addresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodyaddressType);
                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLines != null)
                {
                    body["address_lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLines);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodysuburb != null)
                {
                    body["suburb"] = ExpressionConverter.ConvertO(__workflow_bodysuburb);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["county"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["information_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodycART != null)
                {
                    body["cart"] = ExpressionConverter.ConvertO(__workflow_bodycART);
                    bodypropCount++;
                }

                if (__workflow_bodylOT != null)
                {
                    body["lot"] = ExpressionConverter.ConvertO(__workflow_bodylOT);
                    bodypropCount++;
                }

                if (__workflow_bodydPC != null)
                {
                    body["dpc"] = ExpressionConverter.ConvertO(__workflow_bodydPC);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidFrom != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodyvalidFrom);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidTo != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyvalidTo);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["preferred"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMail != null)
                {
                    body["do_not_mail"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMail);
                    bodypropCount++;
                }

                var seasonalStartObject = new JObject();
                var seasonalStartObjectpropCount = 0;
                if (__workflow_bodyseasonalStartday != null)
                {
                    seasonalStartObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartday);
                    seasonalStartObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartmonth != null)
                {
                    seasonalStartObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartmonth);
                    seasonalStartObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartyear != null)
                {
                    seasonalStartObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartyear);
                    seasonalStartObjectpropCount++;
                }

                if (seasonalStartObjectpropCount > 0)
                {
                    body["seasonal_start"] = seasonalStartObject;
                    bodypropCount++;
                }

                var seasonalEndObject = new JObject();
                var seasonalEndObjectpropCount = 0;
                if (__workflow_bodyseasonalEndday != null)
                {
                    seasonalEndObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndday);
                    seasonalEndObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndmonth != null)
                {
                    seasonalEndObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndmonth);
                    seasonalEndObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndyear != null)
                {
                    seasonalEndObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndyear);
                    seasonalEndObjectpropCount++;
                }

                if (seasonalEndObjectpropCount > 0)
                {
                    body["seasonal_end"] = seasonalEndObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAddress(Expression<Func<string>> addressId, Expression<Func<string>> bodyaddressType = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodysuburb = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodyinformationSource = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodycART = null, Expression<Func<string>> bodylOT = null, Expression<Func<string>> bodydPC = null, Expression<Func<string>> bodyvalidFrom = null, Expression<Func<string>> bodyvalidTo = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotMail = null, Expression<Func<int>> bodyseasonalStartday = null, Expression<Func<int>> bodyseasonalStartmonth = null, Expression<Func<int>> bodyseasonalStartyear = null, Expression<Func<int>> bodyseasonalEndday = null, Expression<Func<int>> bodyseasonalEndmonth = null, Expression<Func<int>> bodyseasonalEndyear = null)
        {
            var __workflow_addressId = WorkflowExpression.Compile(addressId, nameof(addressId), required: true);
            var __workflow_bodyaddressType = WorkflowExpression.Compile(bodyaddressType, nameof(bodyaddressType), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyaddressLines = WorkflowExpression.Compile(bodyaddressLines, nameof(bodyaddressLines), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodysuburb = WorkflowExpression.Compile(bodysuburb, nameof(bodysuburb), required: false);
            var __workflow_bodycounty = WorkflowExpression.Compile(bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodyinformationSource = WorkflowExpression.Compile(bodyinformationSource, nameof(bodyinformationSource), required: false);
            var __workflow_bodyregion = WorkflowExpression.Compile(bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodycART = WorkflowExpression.Compile(bodycART, nameof(bodycART), required: false);
            var __workflow_bodylOT = WorkflowExpression.Compile(bodylOT, nameof(bodylOT), required: false);
            var __workflow_bodydPC = WorkflowExpression.Compile(bodydPC, nameof(bodydPC), required: false);
            var __workflow_bodyvalidFrom = WorkflowExpression.Compile(bodyvalidFrom, nameof(bodyvalidFrom), required: false);
            var __workflow_bodyvalidTo = WorkflowExpression.Compile(bodyvalidTo, nameof(bodyvalidTo), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotMail = WorkflowExpression.Compile(bodydoNotMail, nameof(bodydoNotMail), required: false);
            var __workflow_bodyseasonalStartday = WorkflowExpression.Compile(bodyseasonalStartday, nameof(bodyseasonalStartday), required: false);
            var __workflow_bodyseasonalStartmonth = WorkflowExpression.Compile(bodyseasonalStartmonth, nameof(bodyseasonalStartmonth), required: false);
            var __workflow_bodyseasonalStartyear = WorkflowExpression.Compile(bodyseasonalStartyear, nameof(bodyseasonalStartyear), required: false);
            var __workflow_bodyseasonalEndday = WorkflowExpression.Compile(bodyseasonalEndday, nameof(bodyseasonalEndday), required: false);
            var __workflow_bodyseasonalEndmonth = WorkflowExpression.Compile(bodyseasonalEndmonth, nameof(bodyseasonalEndmonth), required: false);
            var __workflow_bodyseasonalEndyear = WorkflowExpression.Compile(bodyseasonalEndyear, nameof(bodyseasonalEndyear), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/addresses/{0}", __workflow_addressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddressType != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodyaddressType);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLines != null)
                {
                    body["address_lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLines);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodysuburb != null)
                {
                    body["suburb"] = ExpressionConverter.ConvertO(__workflow_bodysuburb);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["county"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodyinformationSource != null)
                {
                    body["information_source"] = ExpressionConverter.ConvertO(__workflow_bodyinformationSource);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodycART != null)
                {
                    body["cart"] = ExpressionConverter.ConvertO(__workflow_bodycART);
                    bodypropCount++;
                }

                if (__workflow_bodylOT != null)
                {
                    body["lot"] = ExpressionConverter.ConvertO(__workflow_bodylOT);
                    bodypropCount++;
                }

                if (__workflow_bodydPC != null)
                {
                    body["dpc"] = ExpressionConverter.ConvertO(__workflow_bodydPC);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidFrom != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodyvalidFrom);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidTo != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyvalidTo);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["preferred"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotMail != null)
                {
                    body["do_not_mail"] = ExpressionConverter.ConvertO(__workflow_bodydoNotMail);
                    bodypropCount++;
                }

                var seasonalStartObject = new JObject();
                var seasonalStartObjectpropCount = 0;
                if (__workflow_bodyseasonalStartday != null)
                {
                    seasonalStartObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartday);
                    seasonalStartObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartmonth != null)
                {
                    seasonalStartObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartmonth);
                    seasonalStartObjectpropCount++;
                }

                if (__workflow_bodyseasonalStartyear != null)
                {
                    seasonalStartObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalStartyear);
                    seasonalStartObjectpropCount++;
                }

                if (seasonalStartObjectpropCount > 0)
                {
                    body["seasonal_start"] = seasonalStartObject;
                    bodypropCount++;
                }

                var seasonalEndObject = new JObject();
                var seasonalEndObjectpropCount = 0;
                if (__workflow_bodyseasonalEndday != null)
                {
                    seasonalEndObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndday);
                    seasonalEndObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndmonth != null)
                {
                    seasonalEndObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndmonth);
                    seasonalEndObjectpropCount++;
                }

                if (__workflow_bodyseasonalEndyear != null)
                {
                    seasonalEndObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyseasonalEndyear);
                    seasonalEndObjectpropCount++;
                }

                if (seasonalEndObjectpropCount > 0)
                {
                    body["seasonal_end"] = seasonalEndObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAlias, ApiConnectionActionConfiguration> CreateConstituentAlias(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyalias, Expression<Func<string>> bodytype = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyalias = WorkflowExpression.Compile(bodyalias, nameof(bodyalias), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAlias, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/aliases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyalias);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentAlias>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAlias(Expression<Func<string>> aliasId, Expression<Func<string>> bodyalias = null, Expression<Func<string>> bodytype = null)
        {
            var __workflow_aliasId = WorkflowExpression.Compile(aliasId, nameof(aliasId), required: true);
            var __workflow_bodyalias = WorkflowExpression.Compile(bodyalias, nameof(bodyalias), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/aliases/{0}", __workflow_aliasId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyalias != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyalias);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCode, ApiConnectionActionConfiguration> CreateConstituentCode(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyconstituentCode, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodysequence = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyconstituentCode = WorkflowExpression.Compile(bodyconstituentCode, nameof(bodyconstituentCode), required: true);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentCode, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituentcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentCode);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentCode>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteConstituentCode(Expression<Func<string>> constituentCodeId)
        {
            var __workflow_constituentCodeId = WorkflowExpression.Compile(constituentCodeId, nameof(constituentCodeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituentcodes/{0}", __workflow_constituentCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentCode(Expression<Func<string>> constituentCodeId, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<int>> bodysequence = null)
        {
            var __workflow_constituentCodeId = WorkflowExpression.Compile(constituentCodeId, nameof(constituentCodeId), required: true);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituentcodes/{0}", __workflow_constituentCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentRead, ApiConnectionActionConfiguration> ListConstituents(Expression<Func<string>> listId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> constituentCode = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> customFieldCategory = null, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null, Expression<Func<string>> sort = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_constituentCode = WorkflowExpression.Compile(constituentCode, nameof(constituentCode), required: false);
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: false);
            var __workflow_customFieldCategory = WorkflowExpression.Compile(customFieldCategory, nameof(customFieldCategory), required: false);
            var __workflow_fundraiserStatus = WorkflowExpression.Compile(fundraiserStatus, nameof(fundraiserStatus), required: false);
            var __workflow_includeDeceased = WorkflowExpression.Compile(includeDeceased, nameof(includeDeceased), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(__workflow_listId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_constituentCode != null)
                    callPayload.Queries["constituent_code"] = ExpressionConverter.Convert(__workflow_constituentCode);
                if (__workflow_constituentId != null)
                    callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(__workflow_constituentId);
                if (__workflow_customFieldCategory != null)
                    callPayload.Queries["custom_field_category"] = ExpressionConverter.Convert(__workflow_customFieldCategory);
                if (__workflow_fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(__workflow_fundraiserStatus);
                if (__workflow_includeDeceased != null)
                    callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(__workflow_includeDeceased);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postal_code"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiConstituentRead, ApiConnectionActionConfiguration> GetConstituent(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiConstituentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiConstituentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituent(Expression<Func<string>> constituentId, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyorganizationName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyformerName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<bool>> bodyinactive = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<string>> bodybirthplace = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<string>> bodyincome = null, Expression<Func<string>> bodyreligion = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynumberOfEmployees = null, Expression<Func<bool>> bodymatchesGifts = null, Expression<Func<double>> bodymatchingGiftFactor = null, Expression<Func<double>> bodymatchingGiftPerGiftMinminMatchPerGift = null, Expression<Func<double>> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, Expression<Func<double>> bodymatchingGiftTotalMinminMatchPerConstit = null, Expression<Func<double>> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, Expression<Func<string>> bodymatchingGiftNotes = null, Expression<Func<bool>> bodydeceased = null, Expression<Func<int>> bodydeceasedDateday = null, Expression<Func<int>> bodydeceasedDatemonth = null, Expression<Func<int>> bodydeceasedDateyear = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyorganizationName = WorkflowExpression.Compile(bodyorganizationName, nameof(bodyorganizationName), required: false);
            var __workflow_bodysuffix = WorkflowExpression.Compile(bodysuffix, nameof(bodysuffix), required: false);
            var __workflow_bodypreferredName = WorkflowExpression.Compile(bodypreferredName, nameof(bodypreferredName), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyformerName = WorkflowExpression.Compile(bodyformerName, nameof(bodyformerName), required: false);
            var __workflow_bodytitle2 = WorkflowExpression.Compile(bodytitle2, nameof(bodytitle2), required: false);
            var __workflow_bodysuffix2 = WorkflowExpression.Compile(bodysuffix2, nameof(bodysuffix2), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodygivesAnonymously = WorkflowExpression.Compile(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            var __workflow_bodybirthdateday = WorkflowExpression.Compile(bodybirthdateday, nameof(bodybirthdateday), required: false);
            var __workflow_bodybirthdatemonth = WorkflowExpression.Compile(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            var __workflow_bodybirthdateyear = WorkflowExpression.Compile(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            var __workflow_bodybirthplace = WorkflowExpression.Compile(bodybirthplace, nameof(bodybirthplace), required: false);
            var __workflow_bodyethnicity = WorkflowExpression.Compile(bodyethnicity, nameof(bodyethnicity), required: false);
            var __workflow_bodyincome = WorkflowExpression.Compile(bodyincome, nameof(bodyincome), required: false);
            var __workflow_bodyreligion = WorkflowExpression.Compile(bodyreligion, nameof(bodyreligion), required: false);
            var __workflow_bodyindustry = WorkflowExpression.Compile(bodyindustry, nameof(bodyindustry), required: false);
            var __workflow_bodynumberOfEmployees = WorkflowExpression.Compile(bodynumberOfEmployees, nameof(bodynumberOfEmployees), required: false);
            var __workflow_bodymatchesGifts = WorkflowExpression.Compile(bodymatchesGifts, nameof(bodymatchesGifts), required: false);
            var __workflow_bodymatchingGiftFactor = WorkflowExpression.Compile(bodymatchingGiftFactor, nameof(bodymatchingGiftFactor), required: false);
            var __workflow_bodymatchingGiftPerGiftMinminMatchPerGift = WorkflowExpression.Compile(bodymatchingGiftPerGiftMinminMatchPerGift, nameof(bodymatchingGiftPerGiftMinminMatchPerGift), required: false);
            var __workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift = WorkflowExpression.Compile(bodymatchingGiftPerGiftMaxmaxMatchPerGift, nameof(bodymatchingGiftPerGiftMaxmaxMatchPerGift), required: false);
            var __workflow_bodymatchingGiftTotalMinminMatchPerConstit = WorkflowExpression.Compile(bodymatchingGiftTotalMinminMatchPerConstit, nameof(bodymatchingGiftTotalMinminMatchPerConstit), required: false);
            var __workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit = WorkflowExpression.Compile(bodymatchingGiftTotalMaxmaxMatchPerConstit, nameof(bodymatchingGiftTotalMaxmaxMatchPerConstit), required: false);
            var __workflow_bodymatchingGiftNotes = WorkflowExpression.Compile(bodymatchingGiftNotes, nameof(bodymatchingGiftNotes), required: false);
            var __workflow_bodydeceased = WorkflowExpression.Compile(bodydeceased, nameof(bodydeceased), required: false);
            var __workflow_bodydeceasedDateday = WorkflowExpression.Compile(bodydeceasedDateday, nameof(bodydeceasedDateday), required: false);
            var __workflow_bodydeceasedDatemonth = WorkflowExpression.Compile(bodydeceasedDatemonth, nameof(bodydeceasedDatemonth), required: false);
            var __workflow_bodydeceasedDateyear = WorkflowExpression.Compile(bodydeceasedDateyear, nameof(bodydeceasedDateyear), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["last"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationName);
                    bodypropCount++;
                }

                if (__workflow_bodysuffix != null)
                {
                    body["suffix"] = ExpressionConverter.ConvertO(__workflow_bodysuffix);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredName != null)
                {
                    body["preferred_name"] = ExpressionConverter.ConvertO(__workflow_bodypreferredName);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middle"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodyformerName != null)
                {
                    body["former_name"] = ExpressionConverter.ConvertO(__workflow_bodyformerName);
                    bodypropCount++;
                }

                if (__workflow_bodytitle2 != null)
                {
                    body["title_2"] = ExpressionConverter.ConvertO(__workflow_bodytitle2);
                    bodypropCount++;
                }

                if (__workflow_bodysuffix2 != null)
                {
                    body["suffix_2"] = ExpressionConverter.ConvertO(__workflow_bodysuffix2);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["marital_status"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                if (__workflow_bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = ExpressionConverter.ConvertO(__workflow_bodygivesAnonymously);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                var birthdateObject = new JObject();
                var birthdateObjectpropCount = 0;
                if (__workflow_bodybirthdateday != null)
                {
                    birthdateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateday);
                    birthdateObjectpropCount++;
                }

                if (__workflow_bodybirthdatemonth != null)
                {
                    birthdateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodybirthdatemonth);
                    birthdateObjectpropCount++;
                }

                if (__workflow_bodybirthdateyear != null)
                {
                    birthdateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateyear);
                    birthdateObjectpropCount++;
                }

                if (birthdateObjectpropCount > 0)
                {
                    body["birthdate"] = birthdateObject;
                    bodypropCount++;
                }

                if (__workflow_bodybirthplace != null)
                {
                    body["birthplace"] = ExpressionConverter.ConvertO(__workflow_bodybirthplace);
                    bodypropCount++;
                }

                if (__workflow_bodyethnicity != null)
                {
                    body["ethnicity"] = ExpressionConverter.ConvertO(__workflow_bodyethnicity);
                    bodypropCount++;
                }

                if (__workflow_bodyincome != null)
                {
                    body["income"] = ExpressionConverter.ConvertO(__workflow_bodyincome);
                    bodypropCount++;
                }

                if (__workflow_bodyreligion != null)
                {
                    body["religion"] = ExpressionConverter.ConvertO(__workflow_bodyreligion);
                    bodypropCount++;
                }

                if (__workflow_bodyindustry != null)
                {
                    body["industry"] = ExpressionConverter.ConvertO(__workflow_bodyindustry);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfEmployees != null)
                {
                    body["num_employees"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodymatchesGifts != null)
                {
                    body["matches_gifts"] = ExpressionConverter.ConvertO(__workflow_bodymatchesGifts);
                    bodypropCount++;
                }

                if (__workflow_bodymatchingGiftFactor != null)
                {
                    body["matching_gift_factor"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftFactor);
                    bodypropCount++;
                }

                var matchingGiftPerGiftMinObject = new JObject();
                var matchingGiftPerGiftMinObjectpropCount = 0;
                if (__workflow_bodymatchingGiftPerGiftMinminMatchPerGift != null)
                {
                    matchingGiftPerGiftMinObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftPerGiftMinminMatchPerGift);
                    matchingGiftPerGiftMinObjectpropCount++;
                }

                if (matchingGiftPerGiftMinObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_min"] = matchingGiftPerGiftMinObject;
                    bodypropCount++;
                }

                var matchingGiftPerGiftMaxObject = new JObject();
                var matchingGiftPerGiftMaxObjectpropCount = 0;
                if (__workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
                {
                    matchingGiftPerGiftMaxObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                    matchingGiftPerGiftMaxObjectpropCount++;
                }

                if (matchingGiftPerGiftMaxObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_max"] = matchingGiftPerGiftMaxObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMinObject = new JObject();
                var matchingGiftTotalMinObjectpropCount = 0;
                if (__workflow_bodymatchingGiftTotalMinminMatchPerConstit != null)
                {
                    matchingGiftTotalMinObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftTotalMinminMatchPerConstit);
                    matchingGiftTotalMinObjectpropCount++;
                }

                if (matchingGiftTotalMinObjectpropCount > 0)
                {
                    body["matching_gift_total_min"] = matchingGiftTotalMinObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMaxObject = new JObject();
                var matchingGiftTotalMaxObjectpropCount = 0;
                if (__workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
                {
                    matchingGiftTotalMaxObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit);
                    matchingGiftTotalMaxObjectpropCount++;
                }

                if (matchingGiftTotalMaxObjectpropCount > 0)
                {
                    body["matching_gift_total_max"] = matchingGiftTotalMaxObject;
                    bodypropCount++;
                }

                if (__workflow_bodymatchingGiftNotes != null)
                {
                    body["matching_gift_notes"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftNotes);
                    bodypropCount++;
                }

                if (__workflow_bodydeceased != null)
                {
                    body["deceased"] = ExpressionConverter.ConvertO(__workflow_bodydeceased);
                    bodypropCount++;
                }

                var deceasedDateObject = new JObject();
                var deceasedDateObjectpropCount = 0;
                if (__workflow_bodydeceasedDateday != null)
                {
                    deceasedDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDateday);
                    deceasedDateObjectpropCount++;
                }

                if (__workflow_bodydeceasedDatemonth != null)
                {
                    deceasedDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDatemonth);
                    deceasedDateObjectpropCount++;
                }

                if (__workflow_bodydeceasedDateyear != null)
                {
                    deceasedDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydeceasedDateyear);
                    deceasedDateObjectpropCount++;
                }

                if (deceasedDateObjectpropCount > 0)
                {
                    body["deceased_date"] = deceasedDateObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead, ApiConnectionActionConfiguration> ListConstituentActions(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/actions", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAddressRead, ApiConnectionActionConfiguration> ListConstituentAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/addresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAliasRead, ApiConnectionActionConfiguration> ListConstituentAliases(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfAliasRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/aliases", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfAliasRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAttachmentRead, ApiConnectionActionConfiguration> ListConstituentAttachments(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/attachments", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCodeRead, ApiConnectionActionConfiguration> ListConstituentCodes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentCodeRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/constituentcodes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCodeRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead, ApiConnectionActionConfiguration> ListConstituentCustomFields(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/customfields", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEducationRead, ApiConnectionActionConfiguration> ListConstituentEducations(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfEducationRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/educations", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfEducationRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEmailAddressRead, ApiConnectionActionConfiguration> ListConstituentEmailAddresses(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfEmailAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/emailaddresses", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfEmailAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration> ListConstituentFundraiserAssignments(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/fundraiserassignments", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration> GetConstituentFirstGift(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/givingsummary/first", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration> GetConstituentGreatestGift(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/givingsummary/greatest", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration> GetConstituentLatestGift(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/givingsummary/latest", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiLifetimeGivingRead, ApiConnectionActionConfiguration> GetConstituentLifetimeGiving(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiLifetimeGivingRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/givingsummary/lifetimegiving", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiLifetimeGivingRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfNoteRead, ApiConnectionActionConfiguration> ListConstituentNotes(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfNoteRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/notes", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfNoteRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfOnlinePresenceRead, ApiConnectionActionConfiguration> ListConstituentOnlinePresences(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfOnlinePresenceRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/onlinepresences", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfOnlinePresenceRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfPhoneRead, ApiConnectionActionConfiguration> ListConstituentPhones(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfPhoneRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/phones", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfPhoneRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiProfilePictureRead, ApiConnectionActionConfiguration> GetConstituentProfilePicture(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiProfilePictureRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/profilepicture", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiProfilePictureRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentProfilePicture(Expression<Func<string>> constituentId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodythumbnailId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: true);
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/profilepicture", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                bodypropCount++;
                body["document_id"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiProspectStatusRead, ApiConnectionActionConfiguration> GetConstituentProspectStatus(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiProspectStatusRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/prospectstatus", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiProspectStatusRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRatingRead, ApiConnectionActionConfiguration> ListConstituentRatings(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> mostRecentOnly = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_mostRecentOnly = WorkflowExpression.Compile(mostRecentOnly, nameof(mostRecentOnly), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfRatingRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/ratings", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = ExpressionConverter.Convert(__workflow_mostRecentOnly);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfRatingRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRelationshipRead, ApiConnectionActionConfiguration> ListConstituentRelationships(Expression<Func<string>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfRelationshipRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/relationships", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfRelationshipRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAttachment, ApiConnectionActionConfiguration> CreateConstituentAttachment(Expression<Func<string>> bodyconstituentId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCustomField, ApiConnectionActionConfiguration> CreateConstituentCustomField(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfSearchResultRead, ApiConnectionActionConfiguration> SearchConstituent(Expression<Func<string>> searchText, Expression<Func<string>> fundraiserStatus = null, Expression<Func<bool>> includeInactive = null, Expression<Func<searchFieldInput>> searchField = null, Expression<Func<bool>> strictSearch = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: true);
            var __workflow_fundraiserStatus = WorkflowExpression.Compile(fundraiserStatus, nameof(fundraiserStatus), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_searchField = WorkflowExpression.Compile(searchField, nameof(searchField), required: false);
            var __workflow_strictSearch = WorkflowExpression.Compile(strictSearch, nameof(strictSearch), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfSearchResultRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                if (__workflow_fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = ExpressionConverter.Convert(__workflow_fundraiserStatus);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_searchField != null)
                    callPayload.Queries["search_field"] = ExpressionConverter.Convert(__workflow_searchField);
                if (__workflow_strictSearch != null)
                    callPayload.Queries["strict_search"] = ExpressionConverter.Convert(__workflow_strictSearch);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfSearchResultRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiFileDefinition, ApiConnectionActionConfiguration> CreateDocument(Expression<Func<string>> bodyfileName = null, Expression<Func<bool>> bodyincludeThumbnail = null)
        {
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyincludeThumbnail = WorkflowExpression.Compile(bodyincludeThumbnail, nameof(bodyincludeThumbnail), required: false);
            return new DeferredBodyAction<ConstituentApiFileDefinition, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/documents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeThumbnail != null)
                {
                    body["upload_thumbnail"] = ExpressionConverter.ConvertO(__workflow_bodyincludeThumbnail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiFileDefinition>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEducation, ApiConnectionActionConfiguration> CreateConstituentEducation(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyschool, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyclassOf = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateEnteredday = null, Expression<Func<int>> bodydateEnteredmonth = null, Expression<Func<int>> bodydateEnteredyear = null, Expression<Func<int>> bodydateLeftday = null, Expression<Func<int>> bodydateLeftmonth = null, Expression<Func<int>> bodydateLeftyear = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<string>> bodydegree = null, Expression<Func<double>> bodygPA = null, Expression<Func<string>> bodysubjectOfStudy = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string[]>> bodymajors = null, Expression<Func<string[]>> bodyminors = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodysocialOrganization = null, Expression<Func<string>> bodyknownName = null, Expression<Func<string>> bodyclassOfDegree = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<string>> bodyregistrationNumber = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyschool = WorkflowExpression.Compile(bodyschool, nameof(bodyschool), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyclassOf = WorkflowExpression.Compile(bodyclassOf, nameof(bodyclassOf), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydateEnteredday = WorkflowExpression.Compile(bodydateEnteredday, nameof(bodydateEnteredday), required: false);
            var __workflow_bodydateEnteredmonth = WorkflowExpression.Compile(bodydateEnteredmonth, nameof(bodydateEnteredmonth), required: false);
            var __workflow_bodydateEnteredyear = WorkflowExpression.Compile(bodydateEnteredyear, nameof(bodydateEnteredyear), required: false);
            var __workflow_bodydateLeftday = WorkflowExpression.Compile(bodydateLeftday, nameof(bodydateLeftday), required: false);
            var __workflow_bodydateLeftmonth = WorkflowExpression.Compile(bodydateLeftmonth, nameof(bodydateLeftmonth), required: false);
            var __workflow_bodydateLeftyear = WorkflowExpression.Compile(bodydateLeftyear, nameof(bodydateLeftyear), required: false);
            var __workflow_bodydateGraduatedday = WorkflowExpression.Compile(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            var __workflow_bodydateGraduatedmonth = WorkflowExpression.Compile(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            var __workflow_bodydateGraduatedyear = WorkflowExpression.Compile(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            var __workflow_bodydegree = WorkflowExpression.Compile(bodydegree, nameof(bodydegree), required: false);
            var __workflow_bodygPA = WorkflowExpression.Compile(bodygPA, nameof(bodygPA), required: false);
            var __workflow_bodysubjectOfStudy = WorkflowExpression.Compile(bodysubjectOfStudy, nameof(bodysubjectOfStudy), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodymajors = WorkflowExpression.Compile(bodymajors, nameof(bodymajors), required: false);
            var __workflow_bodyminors = WorkflowExpression.Compile(bodyminors, nameof(bodyminors), required: false);
            var __workflow_bodycampus = WorkflowExpression.Compile(bodycampus, nameof(bodycampus), required: false);
            var __workflow_bodysocialOrganization = WorkflowExpression.Compile(bodysocialOrganization, nameof(bodysocialOrganization), required: false);
            var __workflow_bodyknownName = WorkflowExpression.Compile(bodyknownName, nameof(bodyknownName), required: false);
            var __workflow_bodyclassOfDegree = WorkflowExpression.Compile(bodyclassOfDegree, nameof(bodyclassOfDegree), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyfaculty = WorkflowExpression.Compile(bodyfaculty, nameof(bodyfaculty), required: false);
            var __workflow_bodyregistrationNumber = WorkflowExpression.Compile(bodyregistrationNumber, nameof(bodyregistrationNumber), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentEducation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/educations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["school"] = ExpressionConverter.ConvertO(__workflow_bodyschool);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyclassOf != null)
                {
                    body["class_of"] = ExpressionConverter.ConvertO(__workflow_bodyclassOf);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var dateEnteredObject = new JObject();
                var dateEnteredObjectpropCount = 0;
                if (__workflow_bodydateEnteredday != null)
                {
                    dateEnteredObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredday);
                    dateEnteredObjectpropCount++;
                }

                if (__workflow_bodydateEnteredmonth != null)
                {
                    dateEnteredObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredmonth);
                    dateEnteredObjectpropCount++;
                }

                if (__workflow_bodydateEnteredyear != null)
                {
                    dateEnteredObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredyear);
                    dateEnteredObjectpropCount++;
                }

                if (dateEnteredObjectpropCount > 0)
                {
                    body["date_entered"] = dateEnteredObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (__workflow_bodydateLeftday != null)
                {
                    dateLeftObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftday);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodydateLeftmonth != null)
                {
                    dateLeftObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftmonth);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodydateLeftyear != null)
                {
                    dateLeftObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftyear);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (__workflow_bodydateGraduatedday != null)
                {
                    dateGraduatedObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydegree != null)
                {
                    body["degree"] = ExpressionConverter.ConvertO(__workflow_bodydegree);
                    bodypropCount++;
                }

                if (__workflow_bodygPA != null)
                {
                    body["gpa"] = ExpressionConverter.ConvertO(__workflow_bodygPA);
                    bodypropCount++;
                }

                if (__workflow_bodysubjectOfStudy != null)
                {
                    body["subject_of_study"] = ExpressionConverter.ConvertO(__workflow_bodysubjectOfStudy);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodymajors != null)
                {
                    body["majors"] = ExpressionConverter.ConvertO(__workflow_bodymajors);
                    bodypropCount++;
                }

                if (__workflow_bodyminors != null)
                {
                    body["minors"] = ExpressionConverter.ConvertO(__workflow_bodyminors);
                    bodypropCount++;
                }

                if (__workflow_bodycampus != null)
                {
                    body["campus"] = ExpressionConverter.ConvertO(__workflow_bodycampus);
                    bodypropCount++;
                }

                if (__workflow_bodysocialOrganization != null)
                {
                    body["social_organization"] = ExpressionConverter.ConvertO(__workflow_bodysocialOrganization);
                    bodypropCount++;
                }

                if (__workflow_bodyknownName != null)
                {
                    body["known_name"] = ExpressionConverter.ConvertO(__workflow_bodyknownName);
                    bodypropCount++;
                }

                if (__workflow_bodyclassOfDegree != null)
                {
                    body["class_of_degree"] = ExpressionConverter.ConvertO(__workflow_bodyclassOfDegree);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyfaculty != null)
                {
                    body["faculty"] = ExpressionConverter.ConvertO(__workflow_bodyfaculty);
                    bodypropCount++;
                }

                if (__workflow_bodyregistrationNumber != null)
                {
                    body["registration_number"] = ExpressionConverter.ConvertO(__workflow_bodyregistrationNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentEducation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEducation(Expression<Func<string>> educationId, Expression<Func<string>> bodyschool = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyclassOf = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodydateEnteredday = null, Expression<Func<int>> bodydateEnteredmonth = null, Expression<Func<int>> bodydateEnteredyear = null, Expression<Func<int>> bodydateLeftday = null, Expression<Func<int>> bodydateLeftmonth = null, Expression<Func<int>> bodydateLeftyear = null, Expression<Func<int>> bodydateGraduatedday = null, Expression<Func<int>> bodydateGraduatedmonth = null, Expression<Func<int>> bodydateGraduatedyear = null, Expression<Func<string>> bodydegree = null, Expression<Func<double>> bodygPA = null, Expression<Func<string>> bodysubjectOfStudy = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string[]>> bodymajors = null, Expression<Func<string[]>> bodyminors = null, Expression<Func<string>> bodycampus = null, Expression<Func<string>> bodysocialOrganization = null, Expression<Func<string>> bodyknownName = null, Expression<Func<string>> bodyclassOfDegree = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyfaculty = null, Expression<Func<string>> bodyregistrationNumber = null)
        {
            var __workflow_educationId = WorkflowExpression.Compile(educationId, nameof(educationId), required: true);
            var __workflow_bodyschool = WorkflowExpression.Compile(bodyschool, nameof(bodyschool), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyclassOf = WorkflowExpression.Compile(bodyclassOf, nameof(bodyclassOf), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydateEnteredday = WorkflowExpression.Compile(bodydateEnteredday, nameof(bodydateEnteredday), required: false);
            var __workflow_bodydateEnteredmonth = WorkflowExpression.Compile(bodydateEnteredmonth, nameof(bodydateEnteredmonth), required: false);
            var __workflow_bodydateEnteredyear = WorkflowExpression.Compile(bodydateEnteredyear, nameof(bodydateEnteredyear), required: false);
            var __workflow_bodydateLeftday = WorkflowExpression.Compile(bodydateLeftday, nameof(bodydateLeftday), required: false);
            var __workflow_bodydateLeftmonth = WorkflowExpression.Compile(bodydateLeftmonth, nameof(bodydateLeftmonth), required: false);
            var __workflow_bodydateLeftyear = WorkflowExpression.Compile(bodydateLeftyear, nameof(bodydateLeftyear), required: false);
            var __workflow_bodydateGraduatedday = WorkflowExpression.Compile(bodydateGraduatedday, nameof(bodydateGraduatedday), required: false);
            var __workflow_bodydateGraduatedmonth = WorkflowExpression.Compile(bodydateGraduatedmonth, nameof(bodydateGraduatedmonth), required: false);
            var __workflow_bodydateGraduatedyear = WorkflowExpression.Compile(bodydateGraduatedyear, nameof(bodydateGraduatedyear), required: false);
            var __workflow_bodydegree = WorkflowExpression.Compile(bodydegree, nameof(bodydegree), required: false);
            var __workflow_bodygPA = WorkflowExpression.Compile(bodygPA, nameof(bodygPA), required: false);
            var __workflow_bodysubjectOfStudy = WorkflowExpression.Compile(bodysubjectOfStudy, nameof(bodysubjectOfStudy), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodymajors = WorkflowExpression.Compile(bodymajors, nameof(bodymajors), required: false);
            var __workflow_bodyminors = WorkflowExpression.Compile(bodyminors, nameof(bodyminors), required: false);
            var __workflow_bodycampus = WorkflowExpression.Compile(bodycampus, nameof(bodycampus), required: false);
            var __workflow_bodysocialOrganization = WorkflowExpression.Compile(bodysocialOrganization, nameof(bodysocialOrganization), required: false);
            var __workflow_bodyknownName = WorkflowExpression.Compile(bodyknownName, nameof(bodyknownName), required: false);
            var __workflow_bodyclassOfDegree = WorkflowExpression.Compile(bodyclassOfDegree, nameof(bodyclassOfDegree), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyfaculty = WorkflowExpression.Compile(bodyfaculty, nameof(bodyfaculty), required: false);
            var __workflow_bodyregistrationNumber = WorkflowExpression.Compile(bodyregistrationNumber, nameof(bodyregistrationNumber), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/educations/{0}", __workflow_educationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyschool != null)
                {
                    body["school"] = ExpressionConverter.ConvertO(__workflow_bodyschool);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyclassOf != null)
                {
                    body["class_of"] = ExpressionConverter.ConvertO(__workflow_bodyclassOf);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var dateEnteredObject = new JObject();
                var dateEnteredObjectpropCount = 0;
                if (__workflow_bodydateEnteredday != null)
                {
                    dateEnteredObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredday);
                    dateEnteredObjectpropCount++;
                }

                if (__workflow_bodydateEnteredmonth != null)
                {
                    dateEnteredObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredmonth);
                    dateEnteredObjectpropCount++;
                }

                if (__workflow_bodydateEnteredyear != null)
                {
                    dateEnteredObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateEnteredyear);
                    dateEnteredObjectpropCount++;
                }

                if (dateEnteredObjectpropCount > 0)
                {
                    body["date_entered"] = dateEnteredObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (__workflow_bodydateLeftday != null)
                {
                    dateLeftObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftday);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodydateLeftmonth != null)
                {
                    dateLeftObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftmonth);
                    dateLeftObjectpropCount++;
                }

                if (__workflow_bodydateLeftyear != null)
                {
                    dateLeftObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateLeftyear);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (__workflow_bodydateGraduatedday != null)
                {
                    dateGraduatedObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (__workflow_bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (__workflow_bodydegree != null)
                {
                    body["degree"] = ExpressionConverter.ConvertO(__workflow_bodydegree);
                    bodypropCount++;
                }

                if (__workflow_bodygPA != null)
                {
                    body["gpa"] = ExpressionConverter.ConvertO(__workflow_bodygPA);
                    bodypropCount++;
                }

                if (__workflow_bodysubjectOfStudy != null)
                {
                    body["subject_of_study"] = ExpressionConverter.ConvertO(__workflow_bodysubjectOfStudy);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodymajors != null)
                {
                    body["majors"] = ExpressionConverter.ConvertO(__workflow_bodymajors);
                    bodypropCount++;
                }

                if (__workflow_bodyminors != null)
                {
                    body["minors"] = ExpressionConverter.ConvertO(__workflow_bodyminors);
                    bodypropCount++;
                }

                if (__workflow_bodycampus != null)
                {
                    body["campus"] = ExpressionConverter.ConvertO(__workflow_bodycampus);
                    bodypropCount++;
                }

                if (__workflow_bodysocialOrganization != null)
                {
                    body["social_organization"] = ExpressionConverter.ConvertO(__workflow_bodysocialOrganization);
                    bodypropCount++;
                }

                if (__workflow_bodyknownName != null)
                {
                    body["known_name"] = ExpressionConverter.ConvertO(__workflow_bodyknownName);
                    bodypropCount++;
                }

                if (__workflow_bodyclassOfDegree != null)
                {
                    body["class_of_degree"] = ExpressionConverter.ConvertO(__workflow_bodyclassOfDegree);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyfaculty != null)
                {
                    body["faculty"] = ExpressionConverter.ConvertO(__workflow_bodyfaculty);
                    bodypropCount++;
                }

                if (__workflow_bodyregistrationNumber != null)
                {
                    body["registration_number"] = ExpressionConverter.ConvertO(__workflow_bodyregistrationNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEmailAddress, ApiConnectionActionConfiguration> CreateConstituentEmailAddress(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyemailType, Expression<Func<string>> bodyemailAddress, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyemailType = WorkflowExpression.Compile(bodyemailType, nameof(bodyemailType), required: true);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotEmail = WorkflowExpression.Compile(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentEmailAddress, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/emailaddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodyemailType);
                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotEmail != null)
                {
                    body["do_not_email"] = ExpressionConverter.ConvertO(__workflow_bodydoNotEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentEmailAddress>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentEmailAddress(Expression<Func<string>> emailAddressId, Expression<Func<string>> bodyemailType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotEmail = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_emailAddressId = WorkflowExpression.Compile(emailAddressId, nameof(emailAddressId), required: true);
            var __workflow_bodyemailType = WorkflowExpression.Compile(bodyemailType, nameof(bodyemailType), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotEmail = WorkflowExpression.Compile(bodydoNotEmail, nameof(bodydoNotEmail), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/emailaddresses/{0}", __workflow_emailAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemailType != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodyemailType);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotEmail != null)
                {
                    body["do_not_email"] = ExpressionConverter.ConvertO(__workflow_bodydoNotEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentNote, ApiConnectionActionConfiguration> CreateConstituentNote(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodytype, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodydateday = WorkflowExpression.Compile(bodydateday, nameof(bodydateday), required: false);
            var __workflow_bodydatemonth = WorkflowExpression.Compile(bodydatemonth, nameof(bodydatemonth), required: false);
            var __workflow_bodydateyear = WorkflowExpression.Compile(bodydateyear, nameof(bodydateyear), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentNote, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/notes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodydateday != null)
                {
                    dateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateday);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydatemonth != null)
                {
                    dateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydateyear != null)
                {
                    dateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentNote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentNote(Expression<Func<string>> noteId, Expression<Func<string>> bodytype = null, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_noteId = WorkflowExpression.Compile(noteId, nameof(noteId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodydateday = WorkflowExpression.Compile(bodydateday, nameof(bodydateday), required: false);
            var __workflow_bodydatemonth = WorkflowExpression.Compile(bodydatemonth, nameof(bodydatemonth), required: false);
            var __workflow_bodydateyear = WorkflowExpression.Compile(bodydateyear, nameof(bodydateyear), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/notes/{0}", __workflow_noteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodydateday != null)
                {
                    dateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateday);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydatemonth != null)
                {
                    dateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydateyear != null)
                {
                    dateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentOnlinePresence, ApiConnectionActionConfiguration> CreateConstituentOnlinePresence(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodytype, Expression<Func<string>> bodylink, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentOnlinePresence, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/onlinepresences";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["address"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentOnlinePresence>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentOnlinePresence(Expression<Func<string>> onlinePresenceId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodylink = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_onlinePresenceId = WorkflowExpression.Compile(onlinePresenceId, nameof(onlinePresenceId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/onlinepresences/{0}", __workflow_onlinePresenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodylink != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentPhone, ApiConnectionActionConfiguration> CreateConstituentPhone(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodytype, Expression<Func<string>> bodynumber, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotCall = WorkflowExpression.Compile(bodydoNotCall, nameof(bodydoNotCall), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentPhone, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/phones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotCall != null)
                {
                    body["do_not_call"] = ExpressionConverter.ConvertO(__workflow_bodydoNotCall);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentPhone>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentPhone(Expression<Func<string>> phoneId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodynumber = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodydoNotCall = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_phoneId = WorkflowExpression.Compile(phoneId, nameof(phoneId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodydoNotCall = WorkflowExpression.Compile(bodydoNotCall, nameof(bodydoNotCall), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/phones/{0}", __workflow_phoneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodynumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodydoNotCall != null)
                {
                    body["do_not_call"] = ExpressionConverter.ConvertO(__workflow_bodydoNotCall);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentRating, ApiConnectionActionConfiguration> CreateConstituentRating(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodysource, Expression<Func<string>> bodycategory, Expression<Func<string>> bodydate, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedConstituentRating, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/ratings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedConstituentRating>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditConstituentRelationship(Expression<Func<string>> relationshipId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisSpouse = null, Expression<Func<bool>> bodyisConstituentHeadOfHousehold = null, Expression<Func<bool>> bodyisSpouseHeadOfHousehold = null, Expression<Func<string>> bodynotes = null, Expression<Func<bool>> bodyisContact = null, Expression<Func<bool>> bodyisPrimaryBusiness = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodyposition = null)
        {
            var __workflow_relationshipId = WorkflowExpression.Compile(relationshipId, nameof(relationshipId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyreciprocalType = WorkflowExpression.Compile(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodyisSpouse = WorkflowExpression.Compile(bodyisSpouse, nameof(bodyisSpouse), required: false);
            var __workflow_bodyisConstituentHeadOfHousehold = WorkflowExpression.Compile(bodyisConstituentHeadOfHousehold, nameof(bodyisConstituentHeadOfHousehold), required: false);
            var __workflow_bodyisSpouseHeadOfHousehold = WorkflowExpression.Compile(bodyisSpouseHeadOfHousehold, nameof(bodyisSpouseHeadOfHousehold), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyisContact = WorkflowExpression.Compile(bodyisContact, nameof(bodyisContact), required: false);
            var __workflow_bodyisPrimaryBusiness = WorkflowExpression.Compile(bodyisPrimaryBusiness, nameof(bodyisPrimaryBusiness), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/relationships/{0}", __workflow_relationshipId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = ExpressionConverter.ConvertO(__workflow_bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisSpouse != null)
                {
                    body["is_spouse"] = ExpressionConverter.ConvertO(__workflow_bodyisSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodyisConstituentHeadOfHousehold != null)
                {
                    body["is_constituent_head_of_household"] = ExpressionConverter.ConvertO(__workflow_bodyisConstituentHeadOfHousehold);
                    bodypropCount++;
                }

                if (__workflow_bodyisSpouseHeadOfHousehold != null)
                {
                    body["is_spouse_head_of_household"] = ExpressionConverter.ConvertO(__workflow_bodyisSpouseHeadOfHousehold);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyisContact != null)
                {
                    body["is_organization_contact"] = ExpressionConverter.ConvertO(__workflow_bodyisContact);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrimaryBusiness != null)
                {
                    body["is_primary_business"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimaryBusiness);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["organization_contact_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualConstituent, ApiConnectionActionConfiguration> CreateIndividualConstituent(Expression<Func<string>> bodylastName, Expression<Func<string>> bodyaddresstype, Expression<Func<string>> bodyphonetype, Expression<Func<string>> bodyphonenumber, Expression<Func<string>> bodyemailtype, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyonlinePresencetype, Expression<Func<string>> bodyonlinePresenceaddress, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodysuffix = null, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresslines = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddresssuburb = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddressstart = null, Expression<Func<string>> bodyaddressend = null, Expression<Func<bool>> bodyphoneisPrimary = null, Expression<Func<bool>> bodyemailisPrimary = null, Expression<Func<bool>> bodyonlinePresenceisPrimary = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyformerName = null, Expression<Func<string>> bodytitle2 = null, Expression<Func<string>> bodysuffix2 = null, Expression<Func<string>> bodygender = null, Expression<Func<string>> bodymaritalStatus = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<int>> bodybirthdateday = null, Expression<Func<int>> bodybirthdatemonth = null, Expression<Func<int>> bodybirthdateyear = null, Expression<Func<string>> bodybirthplace = null, Expression<Func<string>> bodyethnicity = null, Expression<Func<string>> bodyincome = null, Expression<Func<string>> bodyreligion = null, Expression<Func<bool>> bodyprimaryAddresseecustomAddressee = null, Expression<Func<string>> bodyprimaryAddresseeaddresseeFormat = null, Expression<Func<string>> bodyprimaryAddresseeaddresseeCustomName = null, Expression<Func<bool>> bodyprimarySalutationcustomSalutation = null, Expression<Func<string>> bodyprimarySalutationsalutationFormat = null, Expression<Func<string>> bodyprimarySalutationsalutationCustomName = null)
        {
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodyaddresstype = WorkflowExpression.Compile(bodyaddresstype, nameof(bodyaddresstype), required: true);
            var __workflow_bodyphonetype = WorkflowExpression.Compile(bodyphonetype, nameof(bodyphonetype), required: true);
            var __workflow_bodyphonenumber = WorkflowExpression.Compile(bodyphonenumber, nameof(bodyphonenumber), required: true);
            var __workflow_bodyemailtype = WorkflowExpression.Compile(bodyemailtype, nameof(bodyemailtype), required: true);
            var __workflow_bodyemailaddress = WorkflowExpression.Compile(bodyemailaddress, nameof(bodyemailaddress), required: true);
            var __workflow_bodyonlinePresencetype = WorkflowExpression.Compile(bodyonlinePresencetype, nameof(bodyonlinePresencetype), required: true);
            var __workflow_bodyonlinePresenceaddress = WorkflowExpression.Compile(bodyonlinePresenceaddress, nameof(bodyonlinePresenceaddress), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodysuffix = WorkflowExpression.Compile(bodysuffix, nameof(bodysuffix), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresslines = WorkflowExpression.Compile(bodyaddresslines, nameof(bodyaddresslines), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodyaddresssuburb = WorkflowExpression.Compile(bodyaddresssuburb, nameof(bodyaddresssuburb), required: false);
            var __workflow_bodyaddresscounty = WorkflowExpression.Compile(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            var __workflow_bodyaddressstart = WorkflowExpression.Compile(bodyaddressstart, nameof(bodyaddressstart), required: false);
            var __workflow_bodyaddressend = WorkflowExpression.Compile(bodyaddressend, nameof(bodyaddressend), required: false);
            var __workflow_bodyphoneisPrimary = WorkflowExpression.Compile(bodyphoneisPrimary, nameof(bodyphoneisPrimary), required: false);
            var __workflow_bodyemailisPrimary = WorkflowExpression.Compile(bodyemailisPrimary, nameof(bodyemailisPrimary), required: false);
            var __workflow_bodyonlinePresenceisPrimary = WorkflowExpression.Compile(bodyonlinePresenceisPrimary, nameof(bodyonlinePresenceisPrimary), required: false);
            var __workflow_bodypreferredName = WorkflowExpression.Compile(bodypreferredName, nameof(bodypreferredName), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyformerName = WorkflowExpression.Compile(bodyformerName, nameof(bodyformerName), required: false);
            var __workflow_bodytitle2 = WorkflowExpression.Compile(bodytitle2, nameof(bodytitle2), required: false);
            var __workflow_bodysuffix2 = WorkflowExpression.Compile(bodysuffix2, nameof(bodysuffix2), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            var __workflow_bodymaritalStatus = WorkflowExpression.Compile(bodymaritalStatus, nameof(bodymaritalStatus), required: false);
            var __workflow_bodygivesAnonymously = WorkflowExpression.Compile(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            var __workflow_bodybirthdateday = WorkflowExpression.Compile(bodybirthdateday, nameof(bodybirthdateday), required: false);
            var __workflow_bodybirthdatemonth = WorkflowExpression.Compile(bodybirthdatemonth, nameof(bodybirthdatemonth), required: false);
            var __workflow_bodybirthdateyear = WorkflowExpression.Compile(bodybirthdateyear, nameof(bodybirthdateyear), required: false);
            var __workflow_bodybirthplace = WorkflowExpression.Compile(bodybirthplace, nameof(bodybirthplace), required: false);
            var __workflow_bodyethnicity = WorkflowExpression.Compile(bodyethnicity, nameof(bodyethnicity), required: false);
            var __workflow_bodyincome = WorkflowExpression.Compile(bodyincome, nameof(bodyincome), required: false);
            var __workflow_bodyreligion = WorkflowExpression.Compile(bodyreligion, nameof(bodyreligion), required: false);
            var __workflow_bodyprimaryAddresseecustomAddressee = WorkflowExpression.Compile(bodyprimaryAddresseecustomAddressee, nameof(bodyprimaryAddresseecustomAddressee), required: false);
            var __workflow_bodyprimaryAddresseeaddresseeFormat = WorkflowExpression.Compile(bodyprimaryAddresseeaddresseeFormat, nameof(bodyprimaryAddresseeaddresseeFormat), required: false);
            var __workflow_bodyprimaryAddresseeaddresseeCustomName = WorkflowExpression.Compile(bodyprimaryAddresseeaddresseeCustomName, nameof(bodyprimaryAddresseeaddresseeCustomName), required: false);
            var __workflow_bodyprimarySalutationcustomSalutation = WorkflowExpression.Compile(bodyprimarySalutationcustomSalutation, nameof(bodyprimarySalutationcustomSalutation), required: false);
            var __workflow_bodyprimarySalutationsalutationFormat = WorkflowExpression.Compile(bodyprimarySalutationsalutationFormat, nameof(bodyprimarySalutationsalutationFormat), required: false);
            var __workflow_bodyprimarySalutationsalutationCustomName = WorkflowExpression.Compile(bodyprimarySalutationsalutationCustomName, nameof(bodyprimarySalutationsalutationCustomName), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedIndividualConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "Individual";
                bodypropCount++;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["last"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                if (__workflow_bodysuffix != null)
                {
                    body["suffix"] = ExpressionConverter.ConvertO(__workflow_bodysuffix);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyaddresstype);
                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslines != null)
                {
                    addressObject["address_lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresssuburb != null)
                {
                    addressObject["suburb"] = ExpressionConverter.ConvertO(__workflow_bodyaddresssuburb);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstart != null)
                {
                    addressObject["start"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstart);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressend != null)
                {
                    addressObject["end"] = ExpressionConverter.ConvertO(__workflow_bodyaddressend);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var phoneObject = new JObject();
                var phoneObjectpropCount = 0;
                phoneObjectpropCount++;
                phoneObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype);
                phoneObjectpropCount++;
                phoneObject["number"] = ExpressionConverter.ConvertO(__workflow_bodyphonenumber);
                if (__workflow_bodyphoneisPrimary != null)
                {
                    phoneObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyphoneisPrimary);
                    phoneObjectpropCount++;
                }

                if (phoneObjectpropCount > 0)
                {
                    body["phone"] = phoneObject;
                    bodypropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                emailObjectpropCount++;
                emailObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyemailtype);
                emailObjectpropCount++;
                emailObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyemailaddress);
                if (__workflow_bodyemailisPrimary != null)
                {
                    emailObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyemailisPrimary);
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    body["email"] = emailObject;
                    bodypropCount++;
                }

                var onlinePresenceObject = new JObject();
                var onlinePresenceObjectpropCount = 0;
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresencetype);
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresenceaddress);
                if (__workflow_bodyonlinePresenceisPrimary != null)
                {
                    onlinePresenceObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresenceisPrimary);
                    onlinePresenceObjectpropCount++;
                }

                if (onlinePresenceObjectpropCount > 0)
                {
                    body["online_presence"] = onlinePresenceObject;
                    bodypropCount++;
                }

                if (__workflow_bodypreferredName != null)
                {
                    body["preferred_name"] = ExpressionConverter.ConvertO(__workflow_bodypreferredName);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middle"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodyformerName != null)
                {
                    body["former_name"] = ExpressionConverter.ConvertO(__workflow_bodyformerName);
                    bodypropCount++;
                }

                if (__workflow_bodytitle2 != null)
                {
                    body["title_2"] = ExpressionConverter.ConvertO(__workflow_bodytitle2);
                    bodypropCount++;
                }

                if (__workflow_bodysuffix2 != null)
                {
                    body["suffix_2"] = ExpressionConverter.ConvertO(__workflow_bodysuffix2);
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (__workflow_bodymaritalStatus != null)
                {
                    body["marital_status"] = ExpressionConverter.ConvertO(__workflow_bodymaritalStatus);
                    bodypropCount++;
                }

                if (__workflow_bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = ExpressionConverter.ConvertO(__workflow_bodygivesAnonymously);
                    bodypropCount++;
                }

                var birthdateObject = new JObject();
                var birthdateObjectpropCount = 0;
                if (__workflow_bodybirthdateday != null)
                {
                    birthdateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateday);
                    birthdateObjectpropCount++;
                }

                if (__workflow_bodybirthdatemonth != null)
                {
                    birthdateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodybirthdatemonth);
                    birthdateObjectpropCount++;
                }

                if (__workflow_bodybirthdateyear != null)
                {
                    birthdateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodybirthdateyear);
                    birthdateObjectpropCount++;
                }

                if (birthdateObjectpropCount > 0)
                {
                    body["birthdate"] = birthdateObject;
                    bodypropCount++;
                }

                if (__workflow_bodybirthplace != null)
                {
                    body["birthplace"] = ExpressionConverter.ConvertO(__workflow_bodybirthplace);
                    bodypropCount++;
                }

                if (__workflow_bodyethnicity != null)
                {
                    body["ethnicity"] = ExpressionConverter.ConvertO(__workflow_bodyethnicity);
                    bodypropCount++;
                }

                if (__workflow_bodyincome != null)
                {
                    body["income"] = ExpressionConverter.ConvertO(__workflow_bodyincome);
                    bodypropCount++;
                }

                if (__workflow_bodyreligion != null)
                {
                    body["religion"] = ExpressionConverter.ConvertO(__workflow_bodyreligion);
                    bodypropCount++;
                }

                var primaryAddresseeObject = new JObject();
                var primaryAddresseeObjectpropCount = 0;
                if (__workflow_bodyprimaryAddresseecustomAddressee != null)
                {
                    primaryAddresseeObject["custom_format"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryAddresseecustomAddressee);
                    primaryAddresseeObjectpropCount++;
                }

                if (__workflow_bodyprimaryAddresseeaddresseeFormat != null)
                {
                    primaryAddresseeObject["configuration_id"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryAddresseeaddresseeFormat);
                    primaryAddresseeObjectpropCount++;
                }

                if (__workflow_bodyprimaryAddresseeaddresseeCustomName != null)
                {
                    primaryAddresseeObject["formatted_name"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryAddresseeaddresseeCustomName);
                    primaryAddresseeObjectpropCount++;
                }

                if (primaryAddresseeObjectpropCount > 0)
                {
                    body["primary_addressee"] = primaryAddresseeObject;
                    bodypropCount++;
                }

                var primarySalutationObject = new JObject();
                var primarySalutationObjectpropCount = 0;
                if (__workflow_bodyprimarySalutationcustomSalutation != null)
                {
                    primarySalutationObject["custom_format"] = ExpressionConverter.ConvertO(__workflow_bodyprimarySalutationcustomSalutation);
                    primarySalutationObjectpropCount++;
                }

                if (__workflow_bodyprimarySalutationsalutationFormat != null)
                {
                    primarySalutationObject["configuration_id"] = ExpressionConverter.ConvertO(__workflow_bodyprimarySalutationsalutationFormat);
                    primarySalutationObjectpropCount++;
                }

                if (__workflow_bodyprimarySalutationsalutationCustomName != null)
                {
                    primarySalutationObject["formatted_name"] = ExpressionConverter.ConvertO(__workflow_bodyprimarySalutationsalutationCustomName);
                    primarySalutationObjectpropCount++;
                }

                if (primarySalutationObjectpropCount > 0)
                {
                    body["primary_salutation"] = primarySalutationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedIndividualConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualRelationship, ApiConnectionActionConfiguration> CreateIndividualRelationship(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyrelationId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisSpouse = null, Expression<Func<bool>> bodyisConstituentHeadOfHousehold = null, Expression<Func<bool>> bodyisSpouseHeadOfHousehold = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyrelationId = WorkflowExpression.Compile(bodyrelationId, nameof(bodyrelationId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyreciprocalType = WorkflowExpression.Compile(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodyisSpouse = WorkflowExpression.Compile(bodyisSpouse, nameof(bodyisSpouse), required: false);
            var __workflow_bodyisConstituentHeadOfHousehold = WorkflowExpression.Compile(bodyisConstituentHeadOfHousehold, nameof(bodyisConstituentHeadOfHousehold), required: false);
            var __workflow_bodyisSpouseHeadOfHousehold = WorkflowExpression.Compile(bodyisSpouseHeadOfHousehold, nameof(bodyisSpouseHeadOfHousehold), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedIndividualRelationship, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/individualrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["relation_id"] = ExpressionConverter.ConvertO(__workflow_bodyrelationId);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = ExpressionConverter.ConvertO(__workflow_bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisSpouse != null)
                {
                    body["is_spouse"] = ExpressionConverter.ConvertO(__workflow_bodyisSpouse);
                    bodypropCount++;
                }

                if (__workflow_bodyisConstituentHeadOfHousehold != null)
                {
                    body["is_constituent_head_of_household"] = ExpressionConverter.ConvertO(__workflow_bodyisConstituentHeadOfHousehold);
                    bodypropCount++;
                }

                if (__workflow_bodyisSpouseHeadOfHousehold != null)
                {
                    body["is_spouse_head_of_household"] = ExpressionConverter.ConvertO(__workflow_bodyisSpouseHeadOfHousehold);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedIndividualRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationConstituent, ApiConnectionActionConfiguration> CreateOrganizationConstituent(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddresstype, Expression<Func<string>> bodyphonetype, Expression<Func<string>> bodyphonenumber, Expression<Func<string>> bodyemailtype, Expression<Func<string>> bodyemailaddress, Expression<Func<string>> bodyonlinePresencetype, Expression<Func<string>> bodyonlinePresenceaddress, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresslines = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddresssuburb = null, Expression<Func<string>> bodyaddresscounty = null, Expression<Func<string>> bodyaddressstart = null, Expression<Func<string>> bodyaddressend = null, Expression<Func<bool>> bodyphoneisPrimary = null, Expression<Func<bool>> bodyemailisPrimary = null, Expression<Func<bool>> bodyonlinePresenceisPrimary = null, Expression<Func<bool>> bodygivesAnonymously = null, Expression<Func<string>> bodyindustry = null, Expression<Func<int>> bodynumberOfEmployees = null, Expression<Func<bool>> bodymatchesGifts = null, Expression<Func<double>> bodymatchingGiftFactor = null, Expression<Func<double>> bodymatchingGiftPerGiftMinminMatchPerGift = null, Expression<Func<double>> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, Expression<Func<double>> bodymatchingGiftTotalMinminMatchPerConstit = null, Expression<Func<double>> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, Expression<Func<string>> bodymatchingGiftNotes = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyaddresstype = WorkflowExpression.Compile(bodyaddresstype, nameof(bodyaddresstype), required: true);
            var __workflow_bodyphonetype = WorkflowExpression.Compile(bodyphonetype, nameof(bodyphonetype), required: true);
            var __workflow_bodyphonenumber = WorkflowExpression.Compile(bodyphonenumber, nameof(bodyphonenumber), required: true);
            var __workflow_bodyemailtype = WorkflowExpression.Compile(bodyemailtype, nameof(bodyemailtype), required: true);
            var __workflow_bodyemailaddress = WorkflowExpression.Compile(bodyemailaddress, nameof(bodyemailaddress), required: true);
            var __workflow_bodyonlinePresencetype = WorkflowExpression.Compile(bodyonlinePresencetype, nameof(bodyonlinePresencetype), required: true);
            var __workflow_bodyonlinePresenceaddress = WorkflowExpression.Compile(bodyonlinePresenceaddress, nameof(bodyonlinePresenceaddress), required: true);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresslines = WorkflowExpression.Compile(bodyaddresslines, nameof(bodyaddresslines), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodyaddresssuburb = WorkflowExpression.Compile(bodyaddresssuburb, nameof(bodyaddresssuburb), required: false);
            var __workflow_bodyaddresscounty = WorkflowExpression.Compile(bodyaddresscounty, nameof(bodyaddresscounty), required: false);
            var __workflow_bodyaddressstart = WorkflowExpression.Compile(bodyaddressstart, nameof(bodyaddressstart), required: false);
            var __workflow_bodyaddressend = WorkflowExpression.Compile(bodyaddressend, nameof(bodyaddressend), required: false);
            var __workflow_bodyphoneisPrimary = WorkflowExpression.Compile(bodyphoneisPrimary, nameof(bodyphoneisPrimary), required: false);
            var __workflow_bodyemailisPrimary = WorkflowExpression.Compile(bodyemailisPrimary, nameof(bodyemailisPrimary), required: false);
            var __workflow_bodyonlinePresenceisPrimary = WorkflowExpression.Compile(bodyonlinePresenceisPrimary, nameof(bodyonlinePresenceisPrimary), required: false);
            var __workflow_bodygivesAnonymously = WorkflowExpression.Compile(bodygivesAnonymously, nameof(bodygivesAnonymously), required: false);
            var __workflow_bodyindustry = WorkflowExpression.Compile(bodyindustry, nameof(bodyindustry), required: false);
            var __workflow_bodynumberOfEmployees = WorkflowExpression.Compile(bodynumberOfEmployees, nameof(bodynumberOfEmployees), required: false);
            var __workflow_bodymatchesGifts = WorkflowExpression.Compile(bodymatchesGifts, nameof(bodymatchesGifts), required: false);
            var __workflow_bodymatchingGiftFactor = WorkflowExpression.Compile(bodymatchingGiftFactor, nameof(bodymatchingGiftFactor), required: false);
            var __workflow_bodymatchingGiftPerGiftMinminMatchPerGift = WorkflowExpression.Compile(bodymatchingGiftPerGiftMinminMatchPerGift, nameof(bodymatchingGiftPerGiftMinminMatchPerGift), required: false);
            var __workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift = WorkflowExpression.Compile(bodymatchingGiftPerGiftMaxmaxMatchPerGift, nameof(bodymatchingGiftPerGiftMaxmaxMatchPerGift), required: false);
            var __workflow_bodymatchingGiftTotalMinminMatchPerConstit = WorkflowExpression.Compile(bodymatchingGiftTotalMinminMatchPerConstit, nameof(bodymatchingGiftTotalMinminMatchPerConstit), required: false);
            var __workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit = WorkflowExpression.Compile(bodymatchingGiftTotalMaxmaxMatchPerConstit, nameof(bodymatchingGiftTotalMaxmaxMatchPerConstit), required: false);
            var __workflow_bodymatchingGiftNotes = WorkflowExpression.Compile(bodymatchingGiftNotes, nameof(bodymatchingGiftNotes), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedOrganizationConstituent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "Organization";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyaddresstype);
                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslines != null)
                {
                    addressObject["address_lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresssuburb != null)
                {
                    addressObject["suburb"] = ExpressionConverter.ConvertO(__workflow_bodyaddresssuburb);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstart != null)
                {
                    addressObject["start"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstart);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressend != null)
                {
                    addressObject["end"] = ExpressionConverter.ConvertO(__workflow_bodyaddressend);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var phoneObject = new JObject();
                var phoneObjectpropCount = 0;
                phoneObjectpropCount++;
                phoneObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyphonetype);
                phoneObjectpropCount++;
                phoneObject["number"] = ExpressionConverter.ConvertO(__workflow_bodyphonenumber);
                if (__workflow_bodyphoneisPrimary != null)
                {
                    phoneObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyphoneisPrimary);
                    phoneObjectpropCount++;
                }

                if (phoneObjectpropCount > 0)
                {
                    body["phone"] = phoneObject;
                    bodypropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                emailObjectpropCount++;
                emailObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyemailtype);
                emailObjectpropCount++;
                emailObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyemailaddress);
                if (__workflow_bodyemailisPrimary != null)
                {
                    emailObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyemailisPrimary);
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    body["email"] = emailObject;
                    bodypropCount++;
                }

                var onlinePresenceObject = new JObject();
                var onlinePresenceObjectpropCount = 0;
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresencetype);
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresenceaddress);
                if (__workflow_bodyonlinePresenceisPrimary != null)
                {
                    onlinePresenceObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodyonlinePresenceisPrimary);
                    onlinePresenceObjectpropCount++;
                }

                if (onlinePresenceObjectpropCount > 0)
                {
                    body["online_presence"] = onlinePresenceObject;
                    bodypropCount++;
                }

                if (__workflow_bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = ExpressionConverter.ConvertO(__workflow_bodygivesAnonymously);
                    bodypropCount++;
                }

                if (__workflow_bodyindustry != null)
                {
                    body["industry"] = ExpressionConverter.ConvertO(__workflow_bodyindustry);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfEmployees != null)
                {
                    body["num_employees"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodymatchesGifts != null)
                {
                    body["matches_gifts"] = ExpressionConverter.ConvertO(__workflow_bodymatchesGifts);
                    bodypropCount++;
                }

                if (__workflow_bodymatchingGiftFactor != null)
                {
                    body["matching_gift_factor"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftFactor);
                    bodypropCount++;
                }

                var matchingGiftPerGiftMinObject = new JObject();
                var matchingGiftPerGiftMinObjectpropCount = 0;
                if (__workflow_bodymatchingGiftPerGiftMinminMatchPerGift != null)
                {
                    matchingGiftPerGiftMinObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftPerGiftMinminMatchPerGift);
                    matchingGiftPerGiftMinObjectpropCount++;
                }

                if (matchingGiftPerGiftMinObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_min"] = matchingGiftPerGiftMinObject;
                    bodypropCount++;
                }

                var matchingGiftPerGiftMaxObject = new JObject();
                var matchingGiftPerGiftMaxObjectpropCount = 0;
                if (__workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
                {
                    matchingGiftPerGiftMaxObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                    matchingGiftPerGiftMaxObjectpropCount++;
                }

                if (matchingGiftPerGiftMaxObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_max"] = matchingGiftPerGiftMaxObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMinObject = new JObject();
                var matchingGiftTotalMinObjectpropCount = 0;
                if (__workflow_bodymatchingGiftTotalMinminMatchPerConstit != null)
                {
                    matchingGiftTotalMinObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftTotalMinminMatchPerConstit);
                    matchingGiftTotalMinObjectpropCount++;
                }

                if (matchingGiftTotalMinObjectpropCount > 0)
                {
                    body["matching_gift_total_min"] = matchingGiftTotalMinObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMaxObject = new JObject();
                var matchingGiftTotalMaxObjectpropCount = 0;
                if (__workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
                {
                    matchingGiftTotalMaxObject["value"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftTotalMaxmaxMatchPerConstit);
                    matchingGiftTotalMaxObjectpropCount++;
                }

                if (matchingGiftTotalMaxObjectpropCount > 0)
                {
                    body["matching_gift_total_max"] = matchingGiftTotalMaxObject;
                    bodypropCount++;
                }

                if (__workflow_bodymatchingGiftNotes != null)
                {
                    body["matching_gift_notes"] = ExpressionConverter.ConvertO(__workflow_bodymatchingGiftNotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedOrganizationConstituent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationRelationship, ApiConnectionActionConfiguration> CreateOrganizationRelationship(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyrelationId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyreciprocalType = null, Expression<Func<int>> bodystartday = null, Expression<Func<int>> bodystartmonth = null, Expression<Func<int>> bodystartyear = null, Expression<Func<int>> bodyendday = null, Expression<Func<int>> bodyendmonth = null, Expression<Func<int>> bodyendyear = null, Expression<Func<bool>> bodyisContact = null, Expression<Func<string>> bodycontactType = null, Expression<Func<string>> bodyposition = null, Expression<Func<bool>> bodyisPrimaryBusiness = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyrelationId = WorkflowExpression.Compile(bodyrelationId, nameof(bodyrelationId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyreciprocalType = WorkflowExpression.Compile(bodyreciprocalType, nameof(bodyreciprocalType), required: false);
            var __workflow_bodystartday = WorkflowExpression.Compile(bodystartday, nameof(bodystartday), required: false);
            var __workflow_bodystartmonth = WorkflowExpression.Compile(bodystartmonth, nameof(bodystartmonth), required: false);
            var __workflow_bodystartyear = WorkflowExpression.Compile(bodystartyear, nameof(bodystartyear), required: false);
            var __workflow_bodyendday = WorkflowExpression.Compile(bodyendday, nameof(bodyendday), required: false);
            var __workflow_bodyendmonth = WorkflowExpression.Compile(bodyendmonth, nameof(bodyendmonth), required: false);
            var __workflow_bodyendyear = WorkflowExpression.Compile(bodyendyear, nameof(bodyendyear), required: false);
            var __workflow_bodyisContact = WorkflowExpression.Compile(bodyisContact, nameof(bodyisContact), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyisPrimaryBusiness = WorkflowExpression.Compile(bodyisPrimaryBusiness, nameof(bodyisPrimaryBusiness), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedOrganizationRelationship, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/constituent/v1/virtual/organizationrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["relation_id"] = ExpressionConverter.ConvertO(__workflow_bodyrelationId);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = ExpressionConverter.ConvertO(__workflow_bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (__workflow_bodystartday != null)
                {
                    startObject["d"] = ExpressionConverter.ConvertO(__workflow_bodystartday);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartmonth != null)
                {
                    startObject["m"] = ExpressionConverter.ConvertO(__workflow_bodystartmonth);
                    startObjectpropCount++;
                }

                if (__workflow_bodystartyear != null)
                {
                    startObject["y"] = ExpressionConverter.ConvertO(__workflow_bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (__workflow_bodyendday != null)
                {
                    endObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyendday);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendmonth != null)
                {
                    endObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyendmonth);
                    endObjectpropCount++;
                }

                if (__workflow_bodyendyear != null)
                {
                    endObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisContact != null)
                {
                    body["is_organization_contact"] = ExpressionConverter.ConvertO(__workflow_bodyisContact);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["organization_contact_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrimaryBusiness != null)
                {
                    body["is_primary_business"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimaryBusiness);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedOrganizationRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventListEntry, ApiConnectionActionConfiguration> ListEvents(Expression<Func<string>> category = null, Expression<Func<string>> startDateFrom = null, Expression<Func<string>> startDateTo = null, Expression<Func<bool>> includeInactive = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> eventId = null, Expression<Func<string>> name = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_startDateFrom = WorkflowExpression.Compile(startDateFrom, nameof(startDateFrom), required: false);
            var __workflow_startDateTo = WorkflowExpression.Compile(startDateTo, nameof(startDateTo), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfEventListEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/event/v1/eventlist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_startDateFrom != null)
                    callPayload.Queries["start_date_from"] = ExpressionConverter.Convert(__workflow_startDateFrom);
                if (__workflow_startDateTo != null)
                    callPayload.Queries["start_date_to"] = ExpressionConverter.Convert(__workflow_startDateTo);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_eventId != null)
                    callPayload.Queries["event_id"] = ExpressionConverter.Convert(__workflow_eventId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<EventApiApiCollectionOfEventListEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEvent, ApiConnectionActionConfiguration> CreateEvent(Expression<Func<string>> bodyeventName, Expression<Func<string>> bodycategorycategory, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodylookupId = null, Expression<Func<int>> bodycapacity = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodyfundId = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyeventName = WorkflowExpression.Compile(bodyeventName, nameof(bodyeventName), required: true);
            var __workflow_bodycategorycategory = WorkflowExpression.Compile(bodycategorycategory, nameof(bodycategorycategory), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodycapacity = WorkflowExpression.Compile(bodycapacity, nameof(bodycapacity), required: false);
            var __workflow_bodygoal = WorkflowExpression.Compile(bodygoal, nameof(bodygoal), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<EventApiCreatedEvent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/event/v1/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyeventName);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                categoryObjectpropCount++;
                categoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycategorycategory);
                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                if (__workflow_bodycapacity != null)
                {
                    body["capacity"] = ExpressionConverter.ConvertO(__workflow_bodycapacity);
                    bodypropCount++;
                }

                if (__workflow_bodygoal != null)
                {
                    body["goal"] = ExpressionConverter.ConvertO(__workflow_bodygoal);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundId != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiEvent, ApiConnectionActionConfiguration> GetEvent(Expression<Func<string>> eventId)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiEvent, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/events/{0}", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiEvent>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditEvent(Expression<Func<string>> eventId, Expression<Func<string>> bodycategorycategory, Expression<Func<string>> bodyeventName = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodylookupId = null, Expression<Func<int>> bodycapacity = null, Expression<Func<double>> bodygoal = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodyfundId = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_bodycategorycategory = WorkflowExpression.Compile(bodycategorycategory, nameof(bodycategorycategory), required: true);
            var __workflow_bodyeventName = WorkflowExpression.Compile(bodyeventName, nameof(bodyeventName), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodycapacity = WorkflowExpression.Compile(bodycapacity, nameof(bodycapacity), required: false);
            var __workflow_bodygoal = WorkflowExpression.Compile(bodygoal, nameof(bodygoal), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/events/{0}", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyeventName != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyeventName);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                categoryObjectpropCount++;
                categoryObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycategorycategory);
                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                if (__workflow_bodycapacity != null)
                {
                    body["capacity"] = ExpressionConverter.ConvertO(__workflow_bodycapacity);
                    bodypropCount++;
                }

                if (__workflow_bodygoal != null)
                {
                    body["goal"] = ExpressionConverter.ConvertO(__workflow_bodygoal);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundId != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventFee, ApiConnectionActionConfiguration> ListEventFees(Expression<Func<string>> eventId)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfEventFee, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/events/{0}/eventfees", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfEventFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEventFee, ApiConnectionActionConfiguration> CreateEventFee(Expression<Func<string>> eventId, Expression<Func<string>> bodyname, Expression<Func<double>> bodyfeeAmount, Expression<Func<double>> bodycontributionAmount)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyfeeAmount = WorkflowExpression.Compile(bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            var __workflow_bodycontributionAmount = WorkflowExpression.Compile(bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            return new DeferredBodyAction<EventApiCreatedEventFee, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/events/{0}/eventfees", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["cost"] = ExpressionConverter.ConvertO(__workflow_bodyfeeAmount);
                bodypropCount++;
                body["contribution_amount"] = ExpressionConverter.ConvertO(__workflow_bodycontributionAmount);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedEventFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfEventParticipantOption, ApiConnectionActionConfiguration> ListEventParticipantOptions(Expression<Func<string>> eventId)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfEventParticipantOption, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/events/{0}/eventparticipantoptions", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfEventParticipantOption>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedEventParticipantOption, ApiConnectionActionConfiguration> CreateEventParticipantOption(Expression<Func<string>> eventId, Expression<Func<string>> bodyname, Expression<Func<bodyinputTypeInput>> bodyinputType, Expression<Func<bool>> bodyallowMultiSelect = null, Expression<Func<EventApiCreateParticipantOptionListOption[]>> bodylistOptions = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyinputType = WorkflowExpression.Compile(bodyinputType, nameof(bodyinputType), required: true);
            var __workflow_bodyallowMultiSelect = WorkflowExpression.Compile(bodyallowMultiSelect, nameof(bodyallowMultiSelect), required: false);
            var __workflow_bodylistOptions = WorkflowExpression.Compile(bodylistOptions, nameof(bodylistOptions), required: false);
            return new DeferredBodyAction<EventApiCreatedEventParticipantOption, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/events/{0}/eventparticipantoptions", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["input_type"] = ExpressionConverter.ConvertO(__workflow_bodyinputType);
                if (__workflow_bodyallowMultiSelect != null)
                {
                    body["multi_select"] = ExpressionConverter.ConvertO(__workflow_bodyallowMultiSelect);
                    bodypropCount++;
                }

                if (__workflow_bodylistOptions != null)
                {
                    body["list_options"] = ExpressionConverter.ConvertO(__workflow_bodylistOptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedEventParticipantOption>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantListEntry, ApiConnectionActionConfiguration> ListEventParticipants(Expression<Func<string>> eventId, Expression<Func<rsvpStatusInput>> rsvpStatus = null, Expression<Func<invitationStatusInput>> invitationStatus = null, Expression<Func<string>> participationLevel = null, Expression<Func<bool>> attendedFilter = null, Expression<Func<bool>> feesPaidFilter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> isConstituentFilter = null, Expression<Func<bool>> emailEligibleFilter = null, Expression<Func<bool>> phoneCallEligibleFilter = null, Expression<Func<string>> name = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_rsvpStatus = WorkflowExpression.Compile(rsvpStatus, nameof(rsvpStatus), required: false);
            var __workflow_invitationStatus = WorkflowExpression.Compile(invitationStatus, nameof(invitationStatus), required: false);
            var __workflow_participationLevel = WorkflowExpression.Compile(participationLevel, nameof(participationLevel), required: false);
            var __workflow_attendedFilter = WorkflowExpression.Compile(attendedFilter, nameof(attendedFilter), required: false);
            var __workflow_feesPaidFilter = WorkflowExpression.Compile(feesPaidFilter, nameof(feesPaidFilter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_isConstituentFilter = WorkflowExpression.Compile(isConstituentFilter, nameof(isConstituentFilter), required: false);
            var __workflow_emailEligibleFilter = WorkflowExpression.Compile(emailEligibleFilter, nameof(emailEligibleFilter), required: false);
            var __workflow_phoneCallEligibleFilter = WorkflowExpression.Compile(phoneCallEligibleFilter, nameof(phoneCallEligibleFilter), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantListEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/events/{0}/participants", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_rsvpStatus != null)
                    callPayload.Queries["rsvp_status"] = ExpressionConverter.Convert(__workflow_rsvpStatus);
                if (__workflow_invitationStatus != null)
                    callPayload.Queries["invitation_status"] = ExpressionConverter.Convert(__workflow_invitationStatus);
                if (__workflow_participationLevel != null)
                    callPayload.Queries["participation_level"] = ExpressionConverter.Convert(__workflow_participationLevel);
                if (__workflow_attendedFilter != null)
                    callPayload.Queries["attended_filter"] = ExpressionConverter.Convert(__workflow_attendedFilter);
                if (__workflow_feesPaidFilter != null)
                    callPayload.Queries["fees_paid_filter"] = ExpressionConverter.Convert(__workflow_feesPaidFilter);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_isConstituentFilter != null)
                    callPayload.Queries["is_constituent_filter"] = ExpressionConverter.Convert(__workflow_isConstituentFilter);
                if (__workflow_emailEligibleFilter != null)
                    callPayload.Queries["email_eligible_filter"] = ExpressionConverter.Convert(__workflow_emailEligibleFilter);
                if (__workflow_phoneCallEligibleFilter != null)
                    callPayload.Queries["phone_call_eligible_filter"] = ExpressionConverter.Convert(__workflow_phoneCallEligibleFilter);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantListEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipant, ApiConnectionActionConfiguration> CreateParticipant(Expression<Func<string>> eventId, Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodyparticipationLevelparticipationLevel, Expression<Func<string>> bodyhostId = null, Expression<Func<bodyrSVPStatusInput>> bodyrSVPStatus = null, Expression<Func<bool>> bodyattended = null, Expression<Func<bodyinvitationStatusInput>> bodyinvitationStatus = null, Expression<Func<int>> bodyrSVPDateday = null, Expression<Func<int>> bodyrSVPDatemonth = null, Expression<Func<int>> bodyrSVPDateyear = null, Expression<Func<int>> bodyinvitationDateday = null, Expression<Func<int>> bodyinvitationDatemonth = null, Expression<Func<int>> bodyinvitationDateyear = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyparticipationLevelparticipationLevel = WorkflowExpression.Compile(bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            var __workflow_bodyhostId = WorkflowExpression.Compile(bodyhostId, nameof(bodyhostId), required: false);
            var __workflow_bodyrSVPStatus = WorkflowExpression.Compile(bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            var __workflow_bodyattended = WorkflowExpression.Compile(bodyattended, nameof(bodyattended), required: false);
            var __workflow_bodyinvitationStatus = WorkflowExpression.Compile(bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            var __workflow_bodyrSVPDateday = WorkflowExpression.Compile(bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            var __workflow_bodyrSVPDatemonth = WorkflowExpression.Compile(bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            var __workflow_bodyrSVPDateyear = WorkflowExpression.Compile(bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            var __workflow_bodyinvitationDateday = WorkflowExpression.Compile(bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            var __workflow_bodyinvitationDatemonth = WorkflowExpression.Compile(bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            var __workflow_bodyinvitationDateyear = WorkflowExpression.Compile(bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            return new DeferredBodyAction<EventApiCreatedParticipant, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/events/{0}/participants", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                if (__workflow_bodyhostId != null)
                {
                    body["host_id"] = ExpressionConverter.ConvertO(__workflow_bodyhostId);
                    bodypropCount++;
                }

                if (__workflow_bodyrSVPStatus != null)
                {
                    body["rsvp_status"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyattended != null)
                {
                    body["attended"] = ExpressionConverter.ConvertO(__workflow_bodyattended);
                    bodypropCount++;
                }

                if (__workflow_bodyinvitationStatus != null)
                {
                    body["invitation_status"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationStatus);
                    bodypropCount++;
                }

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (__workflow_bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (__workflow_bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (__workflow_bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDateyear);
                    rsvpDateObjectpropCount++;
                }

                if (rsvpDateObjectpropCount > 0)
                {
                    body["rsvp_date"] = rsvpDateObject;
                    bodypropCount++;
                }

                var invitationDateObject = new JObject();
                var invitationDateObjectpropCount = 0;
                if (__workflow_bodyinvitationDateday != null)
                {
                    invitationDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (__workflow_bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (__workflow_bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDateyear);
                    invitationDateObjectpropCount++;
                }

                if (invitationDateObjectpropCount > 0)
                {
                    body["invitation_date"] = invitationDateObject;
                    bodypropCount++;
                }

                var participationLevelObject = new JObject();
                var participationLevelObjectpropCount = 0;
                participationLevelObjectpropCount++;
                participationLevelObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedParticipant>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditParticipantOption(Expression<Func<string>> optionId, Expression<Func<string>> bodyvalue)
        {
            var __workflow_optionId = WorkflowExpression.Compile(optionId, nameof(optionId), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participantoptions/{0}", __workflow_optionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["option_value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiParticipant, ApiConnectionActionConfiguration> GetParticipant(Expression<Func<string>> participantId)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            return new DeferredBodyAction<EventApiParticipant, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiParticipant>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditParticipant(Expression<Func<string>> participantId, Expression<Func<string>> bodyparticipationLevelparticipationLevel, Expression<Func<string>> bodyconstituentId = null, Expression<Func<string>> bodyhostId = null, Expression<Func<bodyrSVPStatusInput>> bodyrSVPStatus = null, Expression<Func<bool>> bodyattended = null, Expression<Func<bodyinvitationStatusInput>> bodyinvitationStatus = null, Expression<Func<int>> bodyrSVPDateday = null, Expression<Func<int>> bodyrSVPDatemonth = null, Expression<Func<int>> bodyrSVPDateyear = null, Expression<Func<int>> bodyinvitationDateday = null, Expression<Func<int>> bodyinvitationDatemonth = null, Expression<Func<int>> bodyinvitationDateyear = null)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            var __workflow_bodyparticipationLevelparticipationLevel = WorkflowExpression.Compile(bodyparticipationLevelparticipationLevel, nameof(bodyparticipationLevelparticipationLevel), required: true);
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: false);
            var __workflow_bodyhostId = WorkflowExpression.Compile(bodyhostId, nameof(bodyhostId), required: false);
            var __workflow_bodyrSVPStatus = WorkflowExpression.Compile(bodyrSVPStatus, nameof(bodyrSVPStatus), required: false);
            var __workflow_bodyattended = WorkflowExpression.Compile(bodyattended, nameof(bodyattended), required: false);
            var __workflow_bodyinvitationStatus = WorkflowExpression.Compile(bodyinvitationStatus, nameof(bodyinvitationStatus), required: false);
            var __workflow_bodyrSVPDateday = WorkflowExpression.Compile(bodyrSVPDateday, nameof(bodyrSVPDateday), required: false);
            var __workflow_bodyrSVPDatemonth = WorkflowExpression.Compile(bodyrSVPDatemonth, nameof(bodyrSVPDatemonth), required: false);
            var __workflow_bodyrSVPDateyear = WorkflowExpression.Compile(bodyrSVPDateyear, nameof(bodyrSVPDateyear), required: false);
            var __workflow_bodyinvitationDateday = WorkflowExpression.Compile(bodyinvitationDateday, nameof(bodyinvitationDateday), required: false);
            var __workflow_bodyinvitationDatemonth = WorkflowExpression.Compile(bodyinvitationDatemonth, nameof(bodyinvitationDatemonth), required: false);
            var __workflow_bodyinvitationDateyear = WorkflowExpression.Compile(bodyinvitationDateyear, nameof(bodyinvitationDateyear), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyconstituentId != null)
                {
                    body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                    bodypropCount++;
                }

                if (__workflow_bodyhostId != null)
                {
                    body["host_id"] = ExpressionConverter.ConvertO(__workflow_bodyhostId);
                    bodypropCount++;
                }

                if (__workflow_bodyrSVPStatus != null)
                {
                    body["rsvp_status"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyattended != null)
                {
                    body["attended"] = ExpressionConverter.ConvertO(__workflow_bodyattended);
                    bodypropCount++;
                }

                if (__workflow_bodyinvitationStatus != null)
                {
                    body["invitation_status"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationStatus);
                    bodypropCount++;
                }

                var rsvpDateObject = new JObject();
                var rsvpDateObjectpropCount = 0;
                if (__workflow_bodyrSVPDateday != null)
                {
                    rsvpDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDateday);
                    rsvpDateObjectpropCount++;
                }

                if (__workflow_bodyrSVPDatemonth != null)
                {
                    rsvpDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDatemonth);
                    rsvpDateObjectpropCount++;
                }

                if (__workflow_bodyrSVPDateyear != null)
                {
                    rsvpDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyrSVPDateyear);
                    rsvpDateObjectpropCount++;
                }

                if (rsvpDateObjectpropCount > 0)
                {
                    body["rsvp_date"] = rsvpDateObject;
                    bodypropCount++;
                }

                var invitationDateObject = new JObject();
                var invitationDateObjectpropCount = 0;
                if (__workflow_bodyinvitationDateday != null)
                {
                    invitationDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDateday);
                    invitationDateObjectpropCount++;
                }

                if (__workflow_bodyinvitationDatemonth != null)
                {
                    invitationDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDatemonth);
                    invitationDateObjectpropCount++;
                }

                if (__workflow_bodyinvitationDateyear != null)
                {
                    invitationDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationDateyear);
                    invitationDateObjectpropCount++;
                }

                if (invitationDateObjectpropCount > 0)
                {
                    body["invitation_date"] = invitationDateObject;
                    bodypropCount++;
                }

                var participationLevelObject = new JObject();
                var participationLevelObjectpropCount = 0;
                participationLevelObjectpropCount++;
                participationLevelObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyparticipationLevelparticipationLevel);
                if (participationLevelObjectpropCount > 0)
                {
                    body["participation_level"] = participationLevelObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantDonation, ApiConnectionActionConfiguration> ListParticipantDonations(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantDonation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}/donations", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantDonation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantDonation, ApiConnectionActionConfiguration> CreateParticipantDonation(Expression<Func<string>> participantId, Expression<Func<string>> bodygiftId)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            var __workflow_bodygiftId = WorkflowExpression.Compile(bodygiftId, nameof(bodygiftId), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantDonation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}/donations", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedParticipantDonation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFeePayment, ApiConnectionActionConfiguration> ListParticipantFeePayments(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantFeePayment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}/feepayments", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantFeePayment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFeePayment, ApiConnectionActionConfiguration> CreateParticipantFeePayment(Expression<Func<string>> participantId, Expression<Func<string>> bodygiftId, Expression<Func<double>> bodyappliedAmount)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            var __workflow_bodygiftId = WorkflowExpression.Compile(bodygiftId, nameof(bodygiftId), required: true);
            var __workflow_bodyappliedAmount = WorkflowExpression.Compile(bodyappliedAmount, nameof(bodyappliedAmount), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantFeePayment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}/feepayments", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftId);
                bodypropCount++;
                body["applied_amount"] = ExpressionConverter.ConvertO(__workflow_bodyappliedAmount);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedParticipantFeePayment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantFee, ApiConnectionActionConfiguration> ListParticipantFees(Expression<Func<string>> participantId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantFee, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}/fees", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(500);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantFee, ApiConnectionActionConfiguration> CreateParticipantFee(Expression<Func<string>> participantId, Expression<Func<string>> bodyeventId, Expression<Func<string>> bodyfee, Expression<Func<int>> bodyquantity, Expression<Func<double>> bodyfeeAmount, Expression<Func<double>> bodycontributionAmount, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            var __workflow_bodyeventId = WorkflowExpression.Compile(bodyeventId, nameof(bodyeventId), required: true);
            var __workflow_bodyfee = WorkflowExpression.Compile(bodyfee, nameof(bodyfee), required: true);
            var __workflow_bodyquantity = WorkflowExpression.Compile(bodyquantity, nameof(bodyquantity), required: true);
            var __workflow_bodyfeeAmount = WorkflowExpression.Compile(bodyfeeAmount, nameof(bodyfeeAmount), required: true);
            var __workflow_bodycontributionAmount = WorkflowExpression.Compile(bodycontributionAmount, nameof(bodycontributionAmount), required: true);
            var __workflow_bodydateday = WorkflowExpression.Compile(bodydateday, nameof(bodydateday), required: false);
            var __workflow_bodydatemonth = WorkflowExpression.Compile(bodydatemonth, nameof(bodydatemonth), required: false);
            var __workflow_bodydateyear = WorkflowExpression.Compile(bodydateyear, nameof(bodydateyear), required: false);
            return new DeferredBodyAction<EventApiCreatedParticipantFee, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}/fees", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                bodypropCount++;
                body["event_fee_id"] = ExpressionConverter.ConvertO(__workflow_bodyfee);
                bodypropCount++;
                body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
                bodypropCount++;
                body["fee_amount"] = ExpressionConverter.ConvertO(__workflow_bodyfeeAmount);
                bodypropCount++;
                body["contribution_amount"] = ExpressionConverter.ConvertO(__workflow_bodycontributionAmount);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodydateday != null)
                {
                    dateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateday);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydatemonth != null)
                {
                    dateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydateyear != null)
                {
                    dateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedParticipantFee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiApiCollectionOfParticipantOption, ApiConnectionActionConfiguration> ListParticipantOptions(Expression<Func<string>> participantId)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            return new DeferredBodyAction<EventApiApiCollectionOfParticipantOption, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}/participantoptions", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventApiApiCollectionOfParticipantOption>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<EventApiCreatedParticipantOption, ApiConnectionActionConfiguration> CreateParticipantOption(Expression<Func<string>> participantId, Expression<Func<string>> bodyeventId, Expression<Func<string>> bodyoption, Expression<Func<object>> bodyoptionValue)
        {
            var __workflow_participantId = WorkflowExpression.Compile(participantId, nameof(participantId), required: true);
            var __workflow_bodyeventId = WorkflowExpression.Compile(bodyeventId, nameof(bodyeventId), required: true);
            var __workflow_bodyoption = WorkflowExpression.Compile(bodyoption, nameof(bodyoption), required: true);
            var __workflow_bodyoptionValue = WorkflowExpression.Compile(bodyoptionValue, nameof(bodyoptionValue), required: true);
            return new DeferredBodyAction<EventApiCreatedParticipantOption, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/v1/participants/{0}/participantoptions", __workflow_participantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                bodypropCount++;
                body["event_participant_option_id"] = ExpressionConverter.ConvertO(__workflow_bodyoption);
                bodypropCount++;
                body["option_value"] = ExpressionConverter.ConvertO(__workflow_bodyoptionValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EventApiCreatedParticipantOption>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealRead, ApiConnectionActionConfiguration> ListAppeals(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfAppealRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/appeals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiAppealRead, ApiConnectionActionConfiguration> GetAppeal(Expression<Func<string>> appealId)
        {
            var __workflow_appealId = WorkflowExpression.Compile(appealId, nameof(appealId), required: true);
            return new DeferredBodyAction<FundraisingApiAppealRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/appeals/{0}", __workflow_appealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiAppealRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealAttachmentRead, ApiConnectionActionConfiguration> ListAppealAttachments(Expression<Func<string>> appealId)
        {
            var __workflow_appealId = WorkflowExpression.Compile(appealId, nameof(appealId), required: true);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfAppealAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/appeals/{0}/attachments", __workflow_appealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfAppealCustomFieldRead, ApiConnectionActionConfiguration> ListAppealCustomFields(Expression<Func<string>> appealId)
        {
            var __workflow_appealId = WorkflowExpression.Compile(appealId, nameof(appealId), required: true);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfAppealCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/appeals/{0}/customfields", __workflow_appealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfAppealCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedAppealAttachment, ApiConnectionActionConfiguration> CreateAppealAttachment(Expression<Func<string>> bodyappealId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null)
        {
            var __workflow_bodyappealId = WorkflowExpression.Compile(bodyappealId, nameof(bodyappealId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            return new DeferredBodyAction<FundraisingApiCreatedAppealAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/appeals/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyappealId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FundraisingApiCreatedAppealAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditAppealAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/appeals/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedAppealCustomField, ApiConnectionActionConfiguration> CreateAppealCustomField(Expression<Func<string>> bodyappealId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodyappealId = WorkflowExpression.Compile(bodyappealId, nameof(bodyappealId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<FundraisingApiCreatedAppealCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/appeals/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyappealId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FundraisingApiCreatedAppealCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditAppealCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/appeals/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignRead, ApiConnectionActionConfiguration> ListCampaigns(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfCampaignRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/campaigns";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCampaignRead, ApiConnectionActionConfiguration> GetCampaign(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<FundraisingApiCampaignRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/campaigns/{0}", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiCampaignRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignAttachmentRead, ApiConnectionActionConfiguration> ListCampaignAttachments(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfCampaignAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/campaigns/{0}/attachments", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead, ApiConnectionActionConfiguration> ListCampaignCustomFields(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/campaigns/{0}/customfields", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfCampaignCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedCampaignAttachment, ApiConnectionActionConfiguration> CreateCampaignAttachment(Expression<Func<string>> bodycampaignId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null)
        {
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            return new DeferredBodyAction<FundraisingApiCreatedCampaignAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/campaigns/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FundraisingApiCreatedCampaignAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditCampaignAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/campaigns/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedCampaignCustomField, ApiConnectionActionConfiguration> CreateCampaignCustomField(Expression<Func<string>> bodycampaignId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<FundraisingApiCreatedCampaignCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/campaigns/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FundraisingApiCreatedCampaignCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditCampaignCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/campaigns/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundraiserAssignment, ApiConnectionActionConfiguration> CreateFundraiserAssignment(Expression<Func<string>> bodyfundraiserId, Expression<Func<string>> bodyconstituentId, Expression<Func<double>> bodyamountamount, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyassignmentStarts = null, Expression<Func<string>> bodyassignmentEnds = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodyfundId = null, Expression<Func<string>> bodyappealId = null)
        {
            var __workflow_bodyfundraiserId = WorkflowExpression.Compile(bodyfundraiserId, nameof(bodyfundraiserId), required: true);
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodyamountamount = WorkflowExpression.Compile(bodyamountamount, nameof(bodyamountamount), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyassignmentStarts = WorkflowExpression.Compile(bodyassignmentStarts, nameof(bodyassignmentStarts), required: false);
            var __workflow_bodyassignmentEnds = WorkflowExpression.Compile(bodyassignmentEnds, nameof(bodyassignmentEnds), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: false);
            var __workflow_bodyappealId = WorkflowExpression.Compile(bodyappealId, nameof(bodyappealId), required: false);
            return new DeferredBodyAction<FundraisingApiCreatedFundraiserAssignment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/fundraisers/assignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fundraiser_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserId);
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyassignmentStarts != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentStarts);
                    bodypropCount++;
                }

                if (__workflow_bodyassignmentEnds != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentEnds);
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                amountObjectpropCount++;
                amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountamount);
                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundId != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                    bodypropCount++;
                }

                if (__workflow_bodyappealId != null)
                {
                    body["appeal_id"] = ExpressionConverter.ConvertO(__workflow_bodyappealId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FundraisingApiCreatedFundraiserAssignment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration> ListFundraiserAssignments(Expression<Func<string>> fundraiserId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_fundraiserId = WorkflowExpression.Compile(fundraiserId, nameof(fundraiserId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/fundraisers/{0}/assignments", __workflow_fundraiserId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundRead, ApiConnectionActionConfiguration> ListFunds(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfFundRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/funds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfFundRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiFundRead, ApiConnectionActionConfiguration> GetFund(Expression<Func<string>> fundId)
        {
            var __workflow_fundId = WorkflowExpression.Compile(fundId, nameof(fundId), required: true);
            return new DeferredBodyAction<FundraisingApiFundRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/funds/{0}", __workflow_fundId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiFundRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundAttachmentRead, ApiConnectionActionConfiguration> ListFundAttachments(Expression<Func<string>> fundId)
        {
            var __workflow_fundId = WorkflowExpression.Compile(fundId, nameof(fundId), required: true);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfFundAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/funds/{0}/attachments", __workflow_fundId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfFundAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundCustomFieldRead, ApiConnectionActionConfiguration> ListFundCustomFields(Expression<Func<string>> fundId)
        {
            var __workflow_fundId = WorkflowExpression.Compile(fundId, nameof(fundId), required: true);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfFundCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/funds/{0}/customfields", __workflow_fundId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfFundCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundAttachment, ApiConnectionActionConfiguration> CreateFundAttachment(Expression<Func<string>> bodyfundId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null)
        {
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            return new DeferredBodyAction<FundraisingApiCreatedFundAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/funds/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FundraisingApiCreatedFundAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditFundAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/funds/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundCustomField, ApiConnectionActionConfiguration> CreateFundCustomField(Expression<Func<string>> bodyfundId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<FundraisingApiCreatedFundCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/funds/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FundraisingApiCreatedFundCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditFundCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/funds/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfPackageRead, ApiConnectionActionConfiguration> ListPackages(Expression<Func<string>> appealId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_appealId = WorkflowExpression.Compile(appealId, nameof(appealId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<FundraisingApiApiCollectionOfPackageRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fundraising/v1/packages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_appealId != null)
                    callPayload.Queries["appeal_id"] = ExpressionConverter.Convert(__workflow_appealId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<FundraisingApiApiCollectionOfPackageRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<FundraisingApiPackageRead, ApiConnectionActionConfiguration> GetPackage(Expression<Func<string>> packageId)
        {
            var __workflow_packageId = WorkflowExpression.Compile(packageId, nameof(packageId), required: true);
            return new DeferredBodyAction<FundraisingApiPackageRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/fundraising/v1/packages/{0}", __workflow_packageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FundraisingApiPackageRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftAcknowledgement(Expression<Func<string>> acknowledgementId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyletter = null)
        {
            var __workflow_acknowledgementId = WorkflowExpression.Compile(acknowledgementId, nameof(acknowledgementId), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyletter = WorkflowExpression.Compile(bodyletter, nameof(bodyletter), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/giftacknowledgements/{0}", __workflow_acknowledgementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyletter != null)
                {
                    body["letter"] = ExpressionConverter.ConvertO(__workflow_bodyletter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftReceipt(Expression<Func<string>> receiptId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<double>> bodyamountvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodynumber = null)
        {
            var __workflow_receiptId = WorkflowExpression.Compile(receiptId, nameof(receiptId), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyamountvalue = WorkflowExpression.Compile(bodyamountvalue, nameof(bodyamountvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/giftreceipts/{0}", __workflow_receiptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (__workflow_bodyamountvalue != null)
                {
                    amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountvalue);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodynumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftRead, ApiConnectionActionConfiguration> ListGifts(Expression<Func<string>> listId = null, Expression<Func<string>> giftType = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> campaignId = null, Expression<Func<string>> fundId = null, Expression<Func<string>> appealId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> startGiftDate = null, Expression<Func<string>> endGiftDate = null, Expression<Func<double>> startGiftAmount = null, Expression<Func<double>> endGiftAmount = null, Expression<Func<string>> postStatus = null, Expression<Func<string>> receiptStatus = null, Expression<Func<string>> acknowledgementStatus = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: false);
            var __workflow_giftType = WorkflowExpression.Compile(giftType, nameof(giftType), required: false);
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: false);
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: false);
            var __workflow_fundId = WorkflowExpression.Compile(fundId, nameof(fundId), required: false);
            var __workflow_appealId = WorkflowExpression.Compile(appealId, nameof(appealId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_startGiftDate = WorkflowExpression.Compile(startGiftDate, nameof(startGiftDate), required: false);
            var __workflow_endGiftDate = WorkflowExpression.Compile(endGiftDate, nameof(endGiftDate), required: false);
            var __workflow_startGiftAmount = WorkflowExpression.Compile(startGiftAmount, nameof(startGiftAmount), required: false);
            var __workflow_endGiftAmount = WorkflowExpression.Compile(endGiftAmount, nameof(endGiftAmount), required: false);
            var __workflow_postStatus = WorkflowExpression.Compile(postStatus, nameof(postStatus), required: false);
            var __workflow_receiptStatus = WorkflowExpression.Compile(receiptStatus, nameof(receiptStatus), required: false);
            var __workflow_acknowledgementStatus = WorkflowExpression.Compile(acknowledgementStatus, nameof(acknowledgementStatus), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<GiftApiApiCollectionOfGiftRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(__workflow_listId);
                if (__workflow_giftType != null)
                    callPayload.Queries["gift_type"] = ExpressionConverter.Convert(__workflow_giftType);
                if (__workflow_constituentId != null)
                    callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(__workflow_constituentId);
                if (__workflow_campaignId != null)
                    callPayload.Queries["campaign_id"] = ExpressionConverter.Convert(__workflow_campaignId);
                if (__workflow_fundId != null)
                    callPayload.Queries["fund_id"] = ExpressionConverter.Convert(__workflow_fundId);
                if (__workflow_appealId != null)
                    callPayload.Queries["appeal_id"] = ExpressionConverter.Convert(__workflow_appealId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_startGiftDate != null)
                    callPayload.Queries["start_gift_date"] = ExpressionConverter.Convert(__workflow_startGiftDate);
                if (__workflow_endGiftDate != null)
                    callPayload.Queries["end_gift_date"] = ExpressionConverter.Convert(__workflow_endGiftDate);
                if (__workflow_startGiftAmount != null)
                    callPayload.Queries["start_gift_amount"] = ExpressionConverter.Convert(__workflow_startGiftAmount);
                if (__workflow_endGiftAmount != null)
                    callPayload.Queries["end_gift_amount"] = ExpressionConverter.Convert(__workflow_endGiftAmount);
                if (__workflow_postStatus != null)
                    callPayload.Queries["post_status"] = ExpressionConverter.Convert(__workflow_postStatus);
                if (__workflow_receiptStatus != null)
                    callPayload.Queries["receipt_status"] = ExpressionConverter.Convert(__workflow_receiptStatus);
                if (__workflow_acknowledgementStatus != null)
                    callPayload.Queries["acknowledgement_status"] = ExpressionConverter.Convert(__workflow_acknowledgementStatus);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<GiftApiApiCollectionOfGiftRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreateGift(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodydate, Expression<Func<bodytypeInput>> bodytype, Expression<Func<GiftApiGiftSplitAdd[]>> bodysplits, Expression<Func<bodyreceiptsreceiptStatusInput>> bodyreceiptsreceiptStatus, Expression<Func<double>> bodyreceiptsamountreceiptAmount, Expression<Func<double>> bodyamountamount = null, Expression<Func<bodypaymentspaymentMethodInput>> bodypaymentspaymentMethod = null, Expression<Func<string>> bodypaymentscheckNumber = null, Expression<Func<int>> bodypaymentscheckDateday = null, Expression<Func<int>> bodypaymentscheckDatemonth = null, Expression<Func<int>> bodypaymentscheckDateyear = null, Expression<Func<string>> bodypaymentsreference = null, Expression<Func<int>> bodypaymentsreferenceDateday = null, Expression<Func<int>> bodypaymentsreferenceDatemonth = null, Expression<Func<int>> bodypaymentsreferenceDateyear = null, Expression<Func<bool>> bodyisAnonymous = null, Expression<Func<string>> bodysubtype = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodylookupId = null, Expression<Func<bool>> bodyuseFundraiserCredits = null, Expression<Func<bool>> bodyuseSoftCredits = null, Expression<Func<string>> bodyconstituency = null, Expression<Func<string>> bodybatchPrefix = null, Expression<Func<string>> bodybatchNumber = null, Expression<Func<bodypostStatusInput>> bodypostStatus = null, Expression<Func<string>> bodypostDate = null, Expression<Func<string>> bodyreceiptsreceiptDate = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodysplits = WorkflowExpression.Compile(bodysplits, nameof(bodysplits), required: true);
            var __workflow_bodyreceiptsreceiptStatus = WorkflowExpression.Compile(bodyreceiptsreceiptStatus, nameof(bodyreceiptsreceiptStatus), required: true);
            var __workflow_bodyreceiptsamountreceiptAmount = WorkflowExpression.Compile(bodyreceiptsamountreceiptAmount, nameof(bodyreceiptsamountreceiptAmount), required: true);
            var __workflow_bodyamountamount = WorkflowExpression.Compile(bodyamountamount, nameof(bodyamountamount), required: false);
            var __workflow_bodypaymentspaymentMethod = WorkflowExpression.Compile(bodypaymentspaymentMethod, nameof(bodypaymentspaymentMethod), required: false);
            var __workflow_bodypaymentscheckNumber = WorkflowExpression.Compile(bodypaymentscheckNumber, nameof(bodypaymentscheckNumber), required: false);
            var __workflow_bodypaymentscheckDateday = WorkflowExpression.Compile(bodypaymentscheckDateday, nameof(bodypaymentscheckDateday), required: false);
            var __workflow_bodypaymentscheckDatemonth = WorkflowExpression.Compile(bodypaymentscheckDatemonth, nameof(bodypaymentscheckDatemonth), required: false);
            var __workflow_bodypaymentscheckDateyear = WorkflowExpression.Compile(bodypaymentscheckDateyear, nameof(bodypaymentscheckDateyear), required: false);
            var __workflow_bodypaymentsreference = WorkflowExpression.Compile(bodypaymentsreference, nameof(bodypaymentsreference), required: false);
            var __workflow_bodypaymentsreferenceDateday = WorkflowExpression.Compile(bodypaymentsreferenceDateday, nameof(bodypaymentsreferenceDateday), required: false);
            var __workflow_bodypaymentsreferenceDatemonth = WorkflowExpression.Compile(bodypaymentsreferenceDatemonth, nameof(bodypaymentsreferenceDatemonth), required: false);
            var __workflow_bodypaymentsreferenceDateyear = WorkflowExpression.Compile(bodypaymentsreferenceDateyear, nameof(bodypaymentsreferenceDateyear), required: false);
            var __workflow_bodyisAnonymous = WorkflowExpression.Compile(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            var __workflow_bodysubtype = WorkflowExpression.Compile(bodysubtype, nameof(bodysubtype), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodyuseFundraiserCredits = WorkflowExpression.Compile(bodyuseFundraiserCredits, nameof(bodyuseFundraiserCredits), required: false);
            var __workflow_bodyuseSoftCredits = WorkflowExpression.Compile(bodyuseSoftCredits, nameof(bodyuseSoftCredits), required: false);
            var __workflow_bodyconstituency = WorkflowExpression.Compile(bodyconstituency, nameof(bodyconstituency), required: false);
            var __workflow_bodybatchPrefix = WorkflowExpression.Compile(bodybatchPrefix, nameof(bodybatchPrefix), required: false);
            var __workflow_bodybatchNumber = WorkflowExpression.Compile(bodybatchNumber, nameof(bodybatchNumber), required: false);
            var __workflow_bodypostStatus = WorkflowExpression.Compile(bodypostStatus, nameof(bodypostStatus), required: false);
            var __workflow_bodypostDate = WorkflowExpression.Compile(bodypostDate, nameof(bodypostDate), required: false);
            var __workflow_bodyreceiptsreceiptDate = WorkflowExpression.Compile(bodyreceiptsreceiptDate, nameof(bodyreceiptsreceiptDate), required: false);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (__workflow_bodyamountamount != null)
                {
                    amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["gift_splits"] = ExpressionConverter.ConvertO(__workflow_bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (__workflow_bodypaymentspaymentMethod != null)
                {
                    if (__workflow_bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["payment_method"] = ExpressionConverter.ConvertO(__workflow_bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["payment_method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                var checkDateObject = new JObject();
                var checkDateObjectpropCount = 0;
                if (__workflow_bodypaymentscheckDateday != null)
                {
                    checkDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckDateday);
                    checkDateObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckDatemonth != null)
                {
                    checkDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckDatemonth);
                    checkDateObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckDateyear != null)
                {
                    checkDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckDateyear);
                    checkDateObjectpropCount++;
                }

                if (checkDateObjectpropCount > 0)
                {
                    paymentsObject["check_date"] = checkDateObject;
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentsreference != null)
                {
                    paymentsObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                var referenceDateObject = new JObject();
                var referenceDateObjectpropCount = 0;
                if (__workflow_bodypaymentsreferenceDateday != null)
                {
                    referenceDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreferenceDateday);
                    referenceDateObjectpropCount++;
                }

                if (__workflow_bodypaymentsreferenceDatemonth != null)
                {
                    referenceDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreferenceDatemonth);
                    referenceDateObjectpropCount++;
                }

                if (__workflow_bodypaymentsreferenceDateyear != null)
                {
                    referenceDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreferenceDateyear);
                    referenceDateObjectpropCount++;
                }

                if (referenceDateObjectpropCount > 0)
                {
                    paymentsObject["reference_date"] = referenceDateObject;
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisAnonymous != null)
                {
                    body["is_anonymous"] = ExpressionConverter.ConvertO(__workflow_bodyisAnonymous);
                    bodypropCount++;
                }

                if (__workflow_bodysubtype != null)
                {
                    body["subtype"] = ExpressionConverter.ConvertO(__workflow_bodysubtype);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                if (__workflow_bodyuseFundraiserCredits != null)
                {
                    body["default_fundraiser_credits"] = ExpressionConverter.ConvertO(__workflow_bodyuseFundraiserCredits);
                    bodypropCount++;
                }

                if (__workflow_bodyuseSoftCredits != null)
                {
                    body["default_soft_credits"] = ExpressionConverter.ConvertO(__workflow_bodyuseSoftCredits);
                    bodypropCount++;
                }

                if (__workflow_bodyconstituency != null)
                {
                    body["constituency"] = ExpressionConverter.ConvertO(__workflow_bodyconstituency);
                    bodypropCount++;
                }

                if (__workflow_bodybatchPrefix != null)
                {
                    body["batch_prefix"] = ExpressionConverter.ConvertO(__workflow_bodybatchPrefix);
                    bodypropCount++;
                }

                if (__workflow_bodybatchNumber != null)
                {
                    body["batch_number"] = ExpressionConverter.ConvertO(__workflow_bodybatchNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypostStatus != null)
                {
                    body["post_status"] = ExpressionConverter.ConvertO(__workflow_bodypostStatus);
                    bodypropCount++;
                }

                if (__workflow_bodypostDate != null)
                {
                    body["post_date"] = ExpressionConverter.ConvertO(__workflow_bodypostDate);
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptStatus);
                var amountObject2 = new JObject();
                var amountObject2propCount = 0;
                amountObject2propCount++;
                amountObject2["value"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsamountreceiptAmount);
                if (amountObject2propCount > 0)
                {
                    receiptsObject["amount"] = amountObject2;
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["date"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    body["receipts"] = receiptsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiCreatedGift>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiGiftRead, ApiConnectionActionConfiguration> GetGift(Expression<Func<string>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<GiftApiGiftRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/{0}", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GiftApiGiftRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftAttachmentRead, ApiConnectionActionConfiguration> ListGiftAttachments(Expression<Func<string>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<GiftApiApiCollectionOfGiftAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/{0}/attachments", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GiftApiApiCollectionOfGiftAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftCustomFieldRead, ApiConnectionActionConfiguration> ListGiftCustomFields(Expression<Func<string>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<GiftApiApiCollectionOfGiftCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/{0}/customfields", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GiftApiApiCollectionOfGiftCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiCreatedGiftAttachment, ApiConnectionActionConfiguration> CreateGiftAttachment(Expression<Func<string>> bodygiftId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null)
        {
            var __workflow_bodygiftId = WorkflowExpression.Compile(bodygiftId, nameof(bodygiftId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            return new DeferredBodyAction<GiftApiCreatedGiftAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiCreatedGiftAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiCreatedGiftCustomField, ApiConnectionActionConfiguration> CreateGiftCustomField(Expression<Func<string>> bodygiftId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodygiftId = WorkflowExpression.Compile(bodygiftId, nameof(bodygiftId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<GiftApiCreatedGiftCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiCreatedGiftCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftApiBatchGiftAddResults, ApiConnectionActionConfiguration> AddGiftToBatch(Expression<Func<string>> batchId, Expression<Func<double>> bodygiftsamountamount, Expression<Func<bodygiftspaymentspaymentMethodInput>> bodygiftspaymentspaymentMethod, Expression<Func<bodygiftsreceiptsreceiptStatusInput>> bodygiftsreceiptsreceiptStatus, Expression<Func<double>> bodygiftsreceiptsamountreceiptAmount, Expression<Func<string>> bodygiftsconstituentId = null, Expression<Func<string>> bodygiftsdate = null, Expression<Func<bodygiftstypeInput>> bodygiftstype = null, Expression<Func<GiftApiVirtualBatchGiftSplitAdd[]>> bodygiftssplits = null, Expression<Func<string>> bodygiftspaymentscheckNumber = null, Expression<Func<int>> bodygiftspaymentscheckDateday = null, Expression<Func<int>> bodygiftspaymentscheckDatemonth = null, Expression<Func<int>> bodygiftspaymentscheckDateyear = null, Expression<Func<string>> bodygiftspaymentsreference = null, Expression<Func<int>> bodygiftspaymentsreferenceDateday = null, Expression<Func<int>> bodygiftspaymentsreferenceDatemonth = null, Expression<Func<int>> bodygiftspaymentsreferenceDateyear = null, Expression<Func<bool>> bodygiftsisAnonymous = null, Expression<Func<string>> bodygiftssubtype = null, Expression<Func<string>> bodygiftscomment = null, Expression<Func<string>> bodygiftslookupId = null, Expression<Func<bool>> bodygiftsuseFundraiserCredits = null, Expression<Func<bool>> bodygiftsuseSoftCredits = null, Expression<Func<string>> bodygiftsconstituency = null, Expression<Func<bodygiftspostStatusInput>> bodygiftspostStatus = null, Expression<Func<string>> bodygiftspostDate = null, Expression<Func<string>> bodygiftsreceiptsreceiptDate = null)
        {
            var __workflow_batchId = WorkflowExpression.Compile(batchId, nameof(batchId), required: true);
            var __workflow_bodygiftsamountamount = WorkflowExpression.Compile(bodygiftsamountamount, nameof(bodygiftsamountamount), required: true);
            var __workflow_bodygiftspaymentspaymentMethod = WorkflowExpression.Compile(bodygiftspaymentspaymentMethod, nameof(bodygiftspaymentspaymentMethod), required: true);
            var __workflow_bodygiftsreceiptsreceiptStatus = WorkflowExpression.Compile(bodygiftsreceiptsreceiptStatus, nameof(bodygiftsreceiptsreceiptStatus), required: true);
            var __workflow_bodygiftsreceiptsamountreceiptAmount = WorkflowExpression.Compile(bodygiftsreceiptsamountreceiptAmount, nameof(bodygiftsreceiptsamountreceiptAmount), required: true);
            var __workflow_bodygiftsconstituentId = WorkflowExpression.Compile(bodygiftsconstituentId, nameof(bodygiftsconstituentId), required: false);
            var __workflow_bodygiftsdate = WorkflowExpression.Compile(bodygiftsdate, nameof(bodygiftsdate), required: false);
            var __workflow_bodygiftstype = WorkflowExpression.Compile(bodygiftstype, nameof(bodygiftstype), required: false);
            var __workflow_bodygiftssplits = WorkflowExpression.Compile(bodygiftssplits, nameof(bodygiftssplits), required: false);
            var __workflow_bodygiftspaymentscheckNumber = WorkflowExpression.Compile(bodygiftspaymentscheckNumber, nameof(bodygiftspaymentscheckNumber), required: false);
            var __workflow_bodygiftspaymentscheckDateday = WorkflowExpression.Compile(bodygiftspaymentscheckDateday, nameof(bodygiftspaymentscheckDateday), required: false);
            var __workflow_bodygiftspaymentscheckDatemonth = WorkflowExpression.Compile(bodygiftspaymentscheckDatemonth, nameof(bodygiftspaymentscheckDatemonth), required: false);
            var __workflow_bodygiftspaymentscheckDateyear = WorkflowExpression.Compile(bodygiftspaymentscheckDateyear, nameof(bodygiftspaymentscheckDateyear), required: false);
            var __workflow_bodygiftspaymentsreference = WorkflowExpression.Compile(bodygiftspaymentsreference, nameof(bodygiftspaymentsreference), required: false);
            var __workflow_bodygiftspaymentsreferenceDateday = WorkflowExpression.Compile(bodygiftspaymentsreferenceDateday, nameof(bodygiftspaymentsreferenceDateday), required: false);
            var __workflow_bodygiftspaymentsreferenceDatemonth = WorkflowExpression.Compile(bodygiftspaymentsreferenceDatemonth, nameof(bodygiftspaymentsreferenceDatemonth), required: false);
            var __workflow_bodygiftspaymentsreferenceDateyear = WorkflowExpression.Compile(bodygiftspaymentsreferenceDateyear, nameof(bodygiftspaymentsreferenceDateyear), required: false);
            var __workflow_bodygiftsisAnonymous = WorkflowExpression.Compile(bodygiftsisAnonymous, nameof(bodygiftsisAnonymous), required: false);
            var __workflow_bodygiftssubtype = WorkflowExpression.Compile(bodygiftssubtype, nameof(bodygiftssubtype), required: false);
            var __workflow_bodygiftscomment = WorkflowExpression.Compile(bodygiftscomment, nameof(bodygiftscomment), required: false);
            var __workflow_bodygiftslookupId = WorkflowExpression.Compile(bodygiftslookupId, nameof(bodygiftslookupId), required: false);
            var __workflow_bodygiftsuseFundraiserCredits = WorkflowExpression.Compile(bodygiftsuseFundraiserCredits, nameof(bodygiftsuseFundraiserCredits), required: false);
            var __workflow_bodygiftsuseSoftCredits = WorkflowExpression.Compile(bodygiftsuseSoftCredits, nameof(bodygiftsuseSoftCredits), required: false);
            var __workflow_bodygiftsconstituency = WorkflowExpression.Compile(bodygiftsconstituency, nameof(bodygiftsconstituency), required: false);
            var __workflow_bodygiftspostStatus = WorkflowExpression.Compile(bodygiftspostStatus, nameof(bodygiftspostStatus), required: false);
            var __workflow_bodygiftspostDate = WorkflowExpression.Compile(bodygiftspostDate, nameof(bodygiftspostDate), required: false);
            var __workflow_bodygiftsreceiptsreceiptDate = WorkflowExpression.Compile(bodygiftsreceiptsreceiptDate, nameof(bodygiftsreceiptsreceiptDate), required: false);
            return new DeferredBodyAction<GiftApiBatchGiftAddResults, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/virtual/giftbatches/{0}/gifts", __workflow_batchId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var giftsObject = new JObject();
                var giftsObjectpropCount = 0;
                if (__workflow_bodygiftsconstituentId != null)
                {
                    giftsObject["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftsconstituentId);
                    giftsObjectpropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                amountObjectpropCount++;
                amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftsamountamount);
                if (amountObjectpropCount > 0)
                {
                    giftsObject["amount"] = amountObject;
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsdate != null)
                {
                    giftsObject["date"] = ExpressionConverter.ConvertO(__workflow_bodygiftsdate);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftstype != null)
                {
                    giftsObject["type"] = ExpressionConverter.ConvertO(__workflow_bodygiftstype);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftssplits != null)
                {
                    giftsObject["gift_splits"] = ExpressionConverter.ConvertO(__workflow_bodygiftssplits);
                    giftsObjectpropCount++;
                }

                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                paymentsObjectpropCount++;
                paymentsObject["payment_method"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentspaymentMethod);
                if (__workflow_bodygiftspaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                var checkDateObject = new JObject();
                var checkDateObjectpropCount = 0;
                if (__workflow_bodygiftspaymentscheckDateday != null)
                {
                    checkDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentscheckDateday);
                    checkDateObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentscheckDatemonth != null)
                {
                    checkDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentscheckDatemonth);
                    checkDateObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentscheckDateyear != null)
                {
                    checkDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentscheckDateyear);
                    checkDateObjectpropCount++;
                }

                if (checkDateObjectpropCount > 0)
                {
                    paymentsObject["check_date"] = checkDateObject;
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentsreference != null)
                {
                    paymentsObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentsreference);
                    paymentsObjectpropCount++;
                }

                var referenceDateObject = new JObject();
                var referenceDateObjectpropCount = 0;
                if (__workflow_bodygiftspaymentsreferenceDateday != null)
                {
                    referenceDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentsreferenceDateday);
                    referenceDateObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentsreferenceDatemonth != null)
                {
                    referenceDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentsreferenceDatemonth);
                    referenceDateObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentsreferenceDateyear != null)
                {
                    referenceDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentsreferenceDateyear);
                    referenceDateObjectpropCount++;
                }

                if (referenceDateObjectpropCount > 0)
                {
                    paymentsObject["reference_date"] = referenceDateObject;
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    giftsObject["payments"] = paymentsObject;
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsisAnonymous != null)
                {
                    giftsObject["is_anonymous"] = ExpressionConverter.ConvertO(__workflow_bodygiftsisAnonymous);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftssubtype != null)
                {
                    giftsObject["subtype"] = ExpressionConverter.ConvertO(__workflow_bodygiftssubtype);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftscomment != null)
                {
                    giftsObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodygiftscomment);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftslookupId != null)
                {
                    giftsObject["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftslookupId);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsuseFundraiserCredits != null)
                {
                    giftsObject["default_fundraiser_credits"] = ExpressionConverter.ConvertO(__workflow_bodygiftsuseFundraiserCredits);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsuseSoftCredits != null)
                {
                    giftsObject["default_soft_credits"] = ExpressionConverter.ConvertO(__workflow_bodygiftsuseSoftCredits);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsconstituency != null)
                {
                    giftsObject["constituency"] = ExpressionConverter.ConvertO(__workflow_bodygiftsconstituency);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftspostStatus != null)
                {
                    giftsObject["post_status"] = ExpressionConverter.ConvertO(__workflow_bodygiftspostStatus);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftspostDate != null)
                {
                    giftsObject["post_date"] = ExpressionConverter.ConvertO(__workflow_bodygiftspostDate);
                    giftsObjectpropCount++;
                }

                giftsObject["origin"] = "{ \"name\": \"Power Platform\" }";
                giftsObjectpropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["status"] = ExpressionConverter.ConvertO(__workflow_bodygiftsreceiptsreceiptStatus);
                var amountObject2 = new JObject();
                var amountObject2propCount = 0;
                amountObject2propCount++;
                amountObject2["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftsreceiptsamountreceiptAmount);
                if (amountObject2propCount > 0)
                {
                    receiptsObject["amount"] = amountObject2;
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodygiftsreceiptsreceiptDate != null)
                {
                    receiptsObject["date"] = ExpressionConverter.ConvertO(__workflow_bodygiftsreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    giftsObject["receipts"] = receiptsObject;
                    giftsObjectpropCount++;
                }

                if (giftsObjectpropCount > 0)
                {
                    body["gifts"] = giftsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiBatchGiftAddResults>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftBatchApiApiCollectionOfGiftBatch, ApiConnectionActionConfiguration> ListGiftBatches(Expression<Func<string>> batchNumber = null, Expression<Func<bool>> approved = null, Expression<Func<bool>> hasExceptions = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> searchText = null, Expression<Func<string>> createdBy = null)
        {
            var __workflow_batchNumber = WorkflowExpression.Compile(batchNumber, nameof(batchNumber), required: false);
            var __workflow_approved = WorkflowExpression.Compile(approved, nameof(approved), required: false);
            var __workflow_hasExceptions = WorkflowExpression.Compile(hasExceptions, nameof(hasExceptions), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            return new DeferredBodyAction<GiftBatchApiApiCollectionOfGiftBatch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_batchNumber != null)
                    callPayload.Queries["batch_number"] = ExpressionConverter.Convert(__workflow_batchNumber);
                if (__workflow_approved != null)
                    callPayload.Queries["approved"] = ExpressionConverter.Convert(__workflow_approved);
                if (__workflow_hasExceptions != null)
                    callPayload.Queries["has_exceptions"] = ExpressionConverter.Convert(__workflow_hasExceptions);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                if (__workflow_createdBy != null)
                    callPayload.Queries["created_by"] = ExpressionConverter.Convert(__workflow_createdBy);
                return new ApiConnectionAction<GiftBatchApiApiCollectionOfGiftBatch>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<GiftBatchApiCreatedBatch, ApiConnectionActionConfiguration> CreateGiftBatch(Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyexpectedNumber = null, Expression<Func<double>> bodyexpectedTotal = null, Expression<Func<string>> bodybatchNumber = null)
        {
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyexpectedNumber = WorkflowExpression.Compile(bodyexpectedNumber, nameof(bodyexpectedNumber), required: false);
            var __workflow_bodyexpectedTotal = WorkflowExpression.Compile(bodyexpectedTotal, nameof(bodyexpectedTotal), required: false);
            var __workflow_bodybatchNumber = WorkflowExpression.Compile(bodybatchNumber, nameof(bodybatchNumber), required: false);
            return new DeferredBodyAction<GiftBatchApiCreatedBatch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["batch_description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedNumber != null)
                {
                    body["expected_number"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedTotal != null)
                {
                    body["expected_batch_total"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedTotal);
                    bodypropCount++;
                }

                if (__workflow_bodybatchNumber != null)
                {
                    body["batch_number"] = ExpressionConverter.ConvertO(__workflow_bodybatchNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftBatchApiCreatedBatch>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AppendIDsToList(Expression<Func<bodylistTypeInput>> bodylistType, Expression<Func<string>> bodylist, Expression<Func<string[]>> bodyidS)
        {
            var __workflow_bodylistType = WorkflowExpression.Compile(bodylistType, nameof(bodylistType), required: true);
            var __workflow_bodylist = WorkflowExpression.Compile(bodylist, nameof(bodylist), required: true);
            var __workflow_bodyidS = WorkflowExpression.Compile(bodyidS, nameof(bodyidS), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/list/v1/appendidstolist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["list_type"] = ExpressionConverter.ConvertO(__workflow_bodylistType);
                bodypropCount++;
                body["list_id"] = ExpressionConverter.ConvertO(__workflow_bodylist);
                bodypropCount++;
                body["ids"] = ExpressionConverter.ConvertO(__workflow_bodyidS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<ListApiCreatedList, ApiConnectionActionConfiguration> CreateListFromIDs(Expression<Func<string>> bodyname, Expression<Func<string>> bodydescription, Expression<Func<bodylistTypeInput>> bodylistType, Expression<Func<bodypermissionsInput>> bodypermissions, Expression<Func<string[]>> bodyidS)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodylistType = WorkflowExpression.Compile(bodylistType, nameof(bodylistType), required: true);
            var __workflow_bodypermissions = WorkflowExpression.Compile(bodypermissions, nameof(bodypermissions), required: true);
            var __workflow_bodyidS = WorkflowExpression.Compile(bodyidS, nameof(bodyidS), required: true);
            return new DeferredBodyAction<ListApiCreatedList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/list/v1/createlistfromids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["list_type"] = ExpressionConverter.ConvertO(__workflow_bodylistType);
                bodypropCount++;
                body["list_permissions"] = ExpressionConverter.ConvertO(__workflow_bodypermissions);
                bodypropCount++;
                body["ids"] = ExpressionConverter.ConvertO(__workflow_bodyidS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ListApiCreatedList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityRead, ApiConnectionActionConfiguration> ListOpportunities(Expression<Func<string>> listId = null, Expression<Func<string>> constituentId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: false);
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunity/v1/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(__workflow_listId);
                if (__workflow_constituentId != null)
                    callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(__workflow_constituentId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunity, ApiConnectionActionConfiguration> CreateOpportunity(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodypurpose, Expression<Func<string>> bodyname, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydeadline = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyaskAmountvalue = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<double>> bodyexpectedAmountvalue = null, Expression<Func<string>> bodyfundedDate = null, Expression<Func<double>> bodyfundedAmountvalue = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodyfundId = null, Expression<Func<OpportunityApiFundraiser[]>> bodyfundraiserS = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodypurpose = WorkflowExpression.Compile(bodypurpose, nameof(bodypurpose), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydeadline = WorkflowExpression.Compile(bodydeadline, nameof(bodydeadline), required: false);
            var __workflow_bodyaskDate = WorkflowExpression.Compile(bodyaskDate, nameof(bodyaskDate), required: false);
            var __workflow_bodyaskAmountvalue = WorkflowExpression.Compile(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            var __workflow_bodyexpectedDate = WorkflowExpression.Compile(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            var __workflow_bodyexpectedAmountvalue = WorkflowExpression.Compile(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            var __workflow_bodyfundedDate = WorkflowExpression.Compile(bodyfundedDate, nameof(bodyfundedDate), required: false);
            var __workflow_bodyfundedAmountvalue = WorkflowExpression.Compile(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: false);
            var __workflow_bodyfundraiserS = WorkflowExpression.Compile(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunity/v1/opportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["purpose"] = ExpressionConverter.ConvertO(__workflow_bodypurpose);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodydeadline != null)
                {
                    body["deadline"] = ExpressionConverter.ConvertO(__workflow_bodydeadline);
                    bodypropCount++;
                }

                if (__workflow_bodyaskDate != null)
                {
                    body["ask_date"] = ExpressionConverter.ConvertO(__workflow_bodyaskDate);
                    bodypropCount++;
                }

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (__workflow_bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDate != null)
                {
                    body["expected_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (__workflow_bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfundedDate != null)
                {
                    body["funded_date"] = ExpressionConverter.ConvertO(__workflow_bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (__workflow_bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundId != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserS);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpportunityApiCreatedOpportunity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiOpportunityRead, ApiConnectionActionConfiguration> GetOpportunity(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiOpportunityRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiOpportunityRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditOpportunity(Expression<Func<string>> opportunityId, Expression<Func<string>> bodypurpose = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydeadline = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyaskAmountvalue = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<double>> bodyexpectedAmountvalue = null, Expression<Func<string>> bodyfundedDate = null, Expression<Func<double>> bodyfundedAmountvalue = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodyfundId = null, Expression<Func<OpportunityApiFundraiser[]>> bodyfundraiserS = null, Expression<Func<bool>> bodyinactive = null)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            var __workflow_bodypurpose = WorkflowExpression.Compile(bodypurpose, nameof(bodypurpose), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydeadline = WorkflowExpression.Compile(bodydeadline, nameof(bodydeadline), required: false);
            var __workflow_bodyaskDate = WorkflowExpression.Compile(bodyaskDate, nameof(bodyaskDate), required: false);
            var __workflow_bodyaskAmountvalue = WorkflowExpression.Compile(bodyaskAmountvalue, nameof(bodyaskAmountvalue), required: false);
            var __workflow_bodyexpectedDate = WorkflowExpression.Compile(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            var __workflow_bodyexpectedAmountvalue = WorkflowExpression.Compile(bodyexpectedAmountvalue, nameof(bodyexpectedAmountvalue), required: false);
            var __workflow_bodyfundedDate = WorkflowExpression.Compile(bodyfundedDate, nameof(bodyfundedDate), required: false);
            var __workflow_bodyfundedAmountvalue = WorkflowExpression.Compile(bodyfundedAmountvalue, nameof(bodyfundedAmountvalue), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodyfundId = WorkflowExpression.Compile(bodyfundId, nameof(bodyfundId), required: false);
            var __workflow_bodyfundraiserS = WorkflowExpression.Compile(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            var __workflow_bodyinactive = WorkflowExpression.Compile(bodyinactive, nameof(bodyinactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypurpose != null)
                {
                    body["purpose"] = ExpressionConverter.ConvertO(__workflow_bodypurpose);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodydeadline != null)
                {
                    body["deadline"] = ExpressionConverter.ConvertO(__workflow_bodydeadline);
                    bodypropCount++;
                }

                if (__workflow_bodyaskDate != null)
                {
                    body["ask_date"] = ExpressionConverter.ConvertO(__workflow_bodyaskDate);
                    bodypropCount++;
                }

                var askAmountObject = new JObject();
                var askAmountObjectpropCount = 0;
                if (__workflow_bodyaskAmountvalue != null)
                {
                    askAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyaskAmountvalue);
                    askAmountObjectpropCount++;
                }

                if (askAmountObjectpropCount > 0)
                {
                    body["ask_amount"] = askAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDate != null)
                {
                    body["expected_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDate);
                    bodypropCount++;
                }

                var expectedAmountObject = new JObject();
                var expectedAmountObjectpropCount = 0;
                if (__workflow_bodyexpectedAmountvalue != null)
                {
                    expectedAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAmountvalue);
                    expectedAmountObjectpropCount++;
                }

                if (expectedAmountObjectpropCount > 0)
                {
                    body["expected_amount"] = expectedAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfundedDate != null)
                {
                    body["funded_date"] = ExpressionConverter.ConvertO(__workflow_bodyfundedDate);
                    bodypropCount++;
                }

                var fundedAmountObject = new JObject();
                var fundedAmountObjectpropCount = 0;
                if (__workflow_bodyfundedAmountvalue != null)
                {
                    fundedAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfundedAmountvalue);
                    fundedAmountObjectpropCount++;
                }

                if (fundedAmountObjectpropCount > 0)
                {
                    body["funded_amount"] = fundedAmountObject;
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundId != null)
                {
                    body["fund_id"] = ExpressionConverter.ConvertO(__workflow_bodyfundId);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserS);
                    bodypropCount++;
                }

                if (__workflow_bodyinactive != null)
                {
                    body["inactive"] = ExpressionConverter.ConvertO(__workflow_bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead, ApiConnectionActionConfiguration> ListOpportunityAttachments(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/{0}/attachments", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead, ApiConnectionActionConfiguration> ListOpportunityCustomFields(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/{0}/customfields", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityAttachment, ApiConnectionActionConfiguration> CreateOpportunityAttachment(Expression<Func<string>> bodyopportunityId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null)
        {
            var __workflow_bodyopportunityId = WorkflowExpression.Compile(bodyopportunityId, nameof(bodyopportunityId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunityAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunity/v1/opportunities/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpportunityApiCreatedOpportunityAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditOpportunityAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityCustomField, ApiConnectionActionConfiguration> CreateOpportunityCustomField(Expression<Func<string>> bodyopportunityId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodyopportunityId = WorkflowExpression.Compile(bodyopportunityId, nameof(bodyopportunityId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<OpportunityApiCreatedOpportunityCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunity/v1/opportunities/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OpportunityApiCreatedOpportunityCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudraisersedge")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditOpportunityCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunity/v1/opportunities/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BlackbaudraisersedgeTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommPrefApiCreatedConstituentConsent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyresponseInput
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentConsentReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentConsentRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentConsentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("constituent_consent_response")]
        public CommPrefApiConstituentConsentReadResponseType Response { get; set; }

        [JsonProperty("consent_date")]
        public string Date { get; set; }

        [JsonProperty("consent_statement")]
        public string ConsentStatement { get; set; }

        [JsonProperty("privacy_notice")]
        public string PrivacyNotice { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("user_name")]
        public string AddedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommPrefApiConstituentConsentReadResponseType
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentSolicitCodeReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentSolicitCodeRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentSolicitCodeRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("solicit_code")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class CommPrefApiCreatedConstituentSolicitCode
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiApiCollectionOfActionRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionRead[] Value { get; set; }
    }

    public class ConstituentApiActionRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("completed_date")]
        public string CompletedOn { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Note { get; set; }

        [JsonProperty("direction")]
        public ConstituentApiActionReadDirectionType Direction { get; set; }

        [JsonProperty("fundraisers")]
        public string[] FundraiserS { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("opportunity_id")]
        public string OpportunityId { get; set; }

        [JsonProperty("outcome")]
        public ConstituentApiActionReadOutcomeType Outcome { get; set; }

        [JsonProperty("priority")]
        public ConstituentApiActionReadPriorityType Priority { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("computed_status")]
        public ConstituentApiActionReadComputedStatusType ComputedStatus { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiActionReadDirectionType
    {
        Inbound,
        Outbound
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiActionReadOutcomeType
    {
        Successful,
        Unsuccessful
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiActionReadPriorityType
    {
        Normal,
        High,
        Low
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiActionReadComputedStatusType
    {
        Open,
        Completed,
        PastDue
    }

    public class ConstituentApiCreatedAction
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycategoryInput
    {
        [EnumMember(Value = "Phone Call")]
        PhoneCall,
        Meeting,
        Mailing,
        Email,
        [EnumMember(Value = "Task/Other")]
        TaskOther
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydirectionInput
    {
        Inbound,
        Outbound
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutcomeInput
    {
        Successful,
        Unsuccessful
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypriorityInput
    {
        Normal,
        High,
        Low
    }

    public class ConstituentApiApiCollectionOfActionAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiActionAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ActionId { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiActionAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfActionCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiActionCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ActionId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiActionCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class ConstituentApiCreatedActionAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class ConstituentApiCreatedActionCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentAlias
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentCode
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentReadTypeType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("email")]
        public ConstituentApiConstituentReadPrimaryEmailType PrimaryEmail { get; set; }

        [JsonProperty("phone")]
        public ConstituentApiConstituentReadPrimaryPhoneType PrimaryPhone { get; set; }

        [JsonProperty("online_presence")]
        public ConstituentApiConstituentReadPrimaryOnlinePresenceType PrimaryOnlinePresence { get; set; }

        [JsonProperty("address")]
        public ConstituentApiConstituentReadPreferredAddressType PreferredAddress { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("middle")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStaus { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("birthdate")]
        public ConstituentApiConstituentReadBirthdateType Birthdate { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("matches_gifts")]
        public bool MatchesGifts { get; set; }

        [JsonProperty("matching_gift_factor")]
        public double MatchingGiftFactor { get; set; }

        [JsonProperty("matching_gift_per_gift_min")]
        public ConstituentApiConstituentReadMatchingGiftPerGiftMinType MatchingGiftPerGiftMin { get; set; }

        [JsonProperty("matching_gift_per_gift_max")]
        public ConstituentApiConstituentReadMatchingGiftPerGiftMaxType MatchingGiftPerGiftMax { get; set; }

        [JsonProperty("matching_gift_total_min")]
        public ConstituentApiConstituentReadMatchingGiftTotalMinType MatchingGiftTotalMin { get; set; }

        [JsonProperty("matching_gift_total_max")]
        public ConstituentApiConstituentReadMatchingGiftTotalMaxType MatchingGiftTotalMax { get; set; }

        [JsonProperty("matching_gift_notes")]
        public string MatchingGiftNotes { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("deceased_date")]
        public ConstituentApiConstituentReadDeceasedDateType DeceasedDate { get; set; }

        [JsonProperty("fundraiser_status")]
        public ConstituentApiConstituentReadFundraiserStatusType FundraiserStatus { get; set; }

        [JsonProperty("spouse")]
        public ConstituentApiConstituentReadSpouseType Spouse { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentReadTypeType
    {
        Individual,
        Organization
    }

    public class ConstituentApiConstituentReadPrimaryEmailType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryPhoneType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryOnlinePresenceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string Formatted { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftPerGiftMinType
    {
        [JsonProperty("value")]
        public double MinMatchPerGift { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftPerGiftMaxType
    {
        [JsonProperty("value")]
        public double MaxMatchPerGift { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftTotalMinType
    {
        [JsonProperty("value")]
        public double MinMatchPerConstit { get; set; }
    }

    public class ConstituentApiConstituentReadMatchingGiftTotalMaxType
    {
        [JsonProperty("value")]
        public double MaxMatchPerConstit { get; set; }
    }

    public class ConstituentApiConstituentReadDeceasedDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentReadFundraiserStatusType
    {
        Active,
        Inactive,
        None
    }

    public class ConstituentApiConstituentReadSpouseType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("is_head_of_household")]
        public bool IsHeadOfHousehold { get; set; }
    }

    public class ConstituentApiApiCollectionOfAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAddressRead[] Value { get; set; }
    }

    public class ConstituentApiAddressRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("information_source")]
        public string InformationSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("preferred")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiAddressReadSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiAddressReadSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfAliasRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAliasRead[] Value { get; set; }
    }

    public class ConstituentApiAliasRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfConstituentCodeRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCodeRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCodeRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("description")]
        public string ConstituentCode { get; set; }

        [JsonProperty("start")]
        public ConstituentApiConstituentCodeReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiConstituentCodeReadEndType End { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentCodeReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentCodeReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiConstituentCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class ConstituentApiApiCollectionOfEducationRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEducationRead[] Value { get; set; }
    }

    public class ConstituentApiEducationRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_entered")]
        public ConstituentApiEducationReadDateEnteredType DateEntered { get; set; }

        [JsonProperty("date_left")]
        public ConstituentApiEducationReadDateLeftType DateLeft { get; set; }

        [JsonProperty("date_graduated")]
        public ConstituentApiEducationReadDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("gpa")]
        public double GPA { get; set; }

        [JsonProperty("majors")]
        public string[] Majors { get; set; }

        [JsonProperty("minors")]
        public string[] Minors { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryEducation { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }

        [JsonProperty("social_organization")]
        public string SocialOrganization { get; set; }

        [JsonProperty("known_name")]
        public string KnownName { get; set; }

        [JsonProperty("class_of_degree")]
        public string ClassOfDegree { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("subject_of_study")]
        public string SubjectOfStudy { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiEducationReadDateEnteredType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateLeftType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateGraduatedType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEmailAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEmailAddressRead[] Value { get; set; }
    }

    public class ConstituentApiEmailAddressRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiGivingSummaryRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiGivingSummaryReadAmountType Amount { get; set; }

        [JsonProperty("appeals")]
        public ConstituentApiAppealRead[] Appeal { get; set; }

        [JsonProperty("campaigns")]
        public ConstituentApiCampaignRead[] Campaign { get; set; }

        [JsonProperty("funds")]
        public ConstituentApiFundRead[] Fund { get; set; }
    }

    public class ConstituentApiGivingSummaryReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiAppealRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiCampaignRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiFundRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiLifetimeGivingRead
    {
        [JsonProperty("consecutive_years_given")]
        public int ConsecutiveYearsGiven { get; set; }

        [JsonProperty("total_years_given")]
        public int TotalYearsGiven { get; set; }

        [JsonProperty("total_giving")]
        public ConstituentApiLifetimeGivingReadTotalGivingType TotalGiving { get; set; }

        [JsonProperty("total_pledge_balance")]
        public ConstituentApiLifetimeGivingReadTotalPledgeBalanceType TotalPledgeBalance { get; set; }

        [JsonProperty("total_received_giving")]
        public ConstituentApiLifetimeGivingReadTotalReceivedGivingType TotalReceivedGiving { get; set; }

        [JsonProperty("total_committed_matching_gifts")]
        public ConstituentApiLifetimeGivingReadTotalCommittedMatchingGiftsType TotalCommittedMatchingGifts { get; set; }

        [JsonProperty("total_received_matching_gifts")]
        public ConstituentApiLifetimeGivingReadTotalReceivedMatchingGiftsType TotalReceivedMatchingGifts { get; set; }

        [JsonProperty("total_soft_credits")]
        public ConstituentApiLifetimeGivingReadTotalSoftCreditsType TotalSoftCredits { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalGivingType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalPledgeBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalReceivedGivingType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalCommittedMatchingGiftsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalReceivedMatchingGiftsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalSoftCreditsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiApiCollectionOfNoteRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiNoteRead[] Value { get; set; }
    }

    public class ConstituentApiNoteRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public ConstituentApiNoteReadDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiNoteReadDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfOnlinePresenceRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiOnlinePresenceRead[] Value { get; set; }
    }

    public class ConstituentApiOnlinePresenceRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfPhoneRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiPhoneRead[] Value { get; set; }
    }

    public class ConstituentApiPhoneRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiProfilePictureRead
    {
        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }
    }

    public class ConstituentApiProspectStatusRead
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("days_elapsed")]
        public int DaysElapsed { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class ConstituentApiApiCollectionOfRatingRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRatingRead[] Value { get; set; }
    }

    public class ConstituentApiRatingRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public JToken Description { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("type")]
        public ConstituentApiRatingReadTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConstituentApiRatingReadTypeType
    {
        Text,
        Number,
        DateTime,
        Currency,
        Boolean,
        CodeTable,
        Unknown
    }

    public class ConstituentApiApiCollectionOfRelationshipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRelationshipRead[] Value { get; set; }
    }

    public class ConstituentApiRelationshipRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("relation_id")]
        public string RelationId { get; set; }

        [JsonProperty("reciprocal_relationship_id")]
        public string ReciprocalRelationshipId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public ConstituentApiRelationshipReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiRelationshipReadEndType End { get; set; }

        [JsonProperty("is_spouse")]
        public bool IsSpouse { get; set; }

        [JsonProperty("is_constituent_head_of_household")]
        public bool IsConstituentHeadOfHousehold { get; set; }

        [JsonProperty("is_spouse_head_of_household")]
        public bool IsSpouseHeadOfHousehold { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }

        [JsonProperty("is_organization_contact")]
        public bool IsContact { get; set; }

        [JsonProperty("is_primary_business")]
        public bool IsPrimaryBusiness { get; set; }

        [JsonProperty("organization_contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiRelationshipReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiRelationshipReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiCreatedConstituentAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiApiCollectionOfSearchResultRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiSearchResultRead[] Value { get; set; }
    }

    public class ConstituentApiSearchResultRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fundraiser_status")]
        public string FundraiserStatus { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchFieldInput
    {
        [EnumMember(Value = "lookup_id")]
        LookupId
    }

    public class ConstituentApiFileDefinition
    {
        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("file_upload_request")]
        public ConstituentApiFileDefinitionFileUploadType FileUpload { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_upload_request")]
        public ConstituentApiFileDefinitionThumbnailUploadType ThumbnailUpload { get; set; }
    }

    public class ConstituentApiFileDefinitionFileUploadType
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public ConstituentApiHeader[] Headers { get; set; }
    }

    public class ConstituentApiHeader
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ConstituentApiFileDefinitionThumbnailUploadType
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public ConstituentApiHeader[] Headers { get; set; }
    }

    public class ConstituentApiCreatedConstituentEducation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentNote
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentOnlinePresence
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedConstituentRating
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedIndividualRelationship
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ConstituentApiCreatedOrganizationRelationship
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventApiApiCollectionOfEventListEntry
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventListEntry[] Value { get; set; }
    }

    public class EventApiEventListEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("category")]
        public EventApiEventCategory Category { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("attending_count")]
        public int Attending { get; set; }

        [JsonProperty("attended_count")]
        public int Attended { get; set; }

        [JsonProperty("invited_count")]
        public int Invited { get; set; }

        [JsonProperty("revenue")]
        public double Revenue { get; set; }

        [JsonProperty("goal")]
        public double Goal { get; set; }

        [JsonProperty("percent_of_goal")]
        public int PercentOfGoal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class EventApiEventCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }
    }

    public class EventApiCreatedEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventApiEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("category")]
        public EventApiEventCategory Category { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("location")]
        public EventApiLocation Location { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("goal")]
        public double Goal { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class EventApiLocation
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("locality")]
        public EventApiLocality Locality { get; set; }

        [JsonProperty("administrative_area")]
        public EventApiAdministrativeArea AdministrativeArea { get; set; }

        [JsonProperty("sub_administrative_area")]
        public EventApiSubAdministrativeArea SubAdministrativeArea { get; set; }

        [JsonProperty("country")]
        public EventApiCountry Country { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }
    }

    public class EventApiLocality
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiAdministrativeArea
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }
    }

    public class EventApiSubAdministrativeArea
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiCountry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("iso_alpha2_code")]
        public string ISOCode { get; set; }
    }

    public class EventApiApiCollectionOfEventFee
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventFee[] Value { get; set; }
    }

    public class EventApiEventFee
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cost")]
        public double Amount { get; set; }

        [JsonProperty("contribution_amount")]
        public double ContributionAmount { get; set; }

        [JsonProperty("number_sold")]
        public int NumberSold { get; set; }
    }

    public class EventApiCreatedEventFee
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventApiApiCollectionOfEventParticipantOption
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiEventParticipantOption[] Value { get; set; }
    }

    public class EventApiEventParticipantOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("input_type")]
        public EventApiEventParticipantOptionInputTypeType InputType { get; set; }

        [JsonProperty("multi_select")]
        public bool AllowMultiSelect { get; set; }

        [JsonProperty("list_options")]
        public EventApiEventParticipantOptionListOption[] ListOptions { get; set; }

        [JsonProperty("added_by_user")]
        public string AddedByUser { get; set; }

        [JsonProperty("updated_by_user")]
        public string ModifiedByUser { get; set; }

        [JsonProperty("added_by_service")]
        public string AddedByService { get; set; }

        [JsonProperty("updated_by_service")]
        public string ModifiedByService { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_updated")]
        public string DateModified { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventApiEventParticipantOptionInputTypeType
    {
        Boolean,
        String,
        List
    }

    public class EventApiEventParticipantOptionListOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class EventApiCreatedEventParticipantOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyinputTypeInput
    {
        Boolean,
        String,
        List
    }

    public class EventApiCreateParticipantOptionListOption
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class EventApiApiCollectionOfParticipantListEntry
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantListEntry[] Value { get; set; }
    }

    public class EventApiParticipantListEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("rsvp_status")]
        public EventApiParticipantListEntryRSVPStatusType RSVPStatus { get; set; }

        [JsonProperty("attended")]
        public bool Attended { get; set; }

        [JsonProperty("invitation_status")]
        public EventApiParticipantListEntryInvitationStatusType InvitationStatus { get; set; }

        [JsonProperty("rsvp_date")]
        public EventApiParticipantListEntryRSVPDateType RSVPDate { get; set; }

        [JsonProperty("participation_level")]
        public EventApiParticipationLevel ParticipationLevel { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("total_registration_fees")]
        public double TotalRegistrationFees { get; set; }

        [JsonProperty("total_paid")]
        public double TotalPaid { get; set; }

        [JsonProperty("seat")]
        public string Seat { get; set; }

        [JsonProperty("name_tag")]
        public string NameTag { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("host")]
        public EventApiParticipantListEntryHostType Host { get; set; }

        [JsonProperty("guests")]
        public EventApiParticipantListParticipantSummary[] Guests { get; set; }

        [JsonProperty("memberships")]
        public EventApiMembership[] Memberships { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventApiParticipantListEntryRSVPStatusType
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventApiParticipantListEntryInvitationStatusType
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipantListEntryRSVPDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiParticipationLevel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_inactive")]
        public bool Inactive { get; set; }
    }

    public class EventApiParticipantListEntryHostType
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiParticipantListParticipantSummary
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EventApiMembership
    {
        [JsonProperty("category")]
        public EventApiMembershipCategory Category { get; set; }
    }

    public class EventApiMembershipCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum rsvpStatusInput
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum invitationStatusInput
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiCreatedParticipant
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrSVPStatusInput
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyinvitationStatusInput
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("host_id")]
        public string HostId { get; set; }

        [JsonProperty("rsvp_status")]
        public EventApiParticipantRSVPStatusType RSVPStatus { get; set; }

        [JsonProperty("attended")]
        public bool Attended { get; set; }

        [JsonProperty("invitation_status")]
        public EventApiParticipantInvitationStatusType InvitationStatus { get; set; }

        [JsonProperty("rsvp_date")]
        public EventApiParticipantRSVPDateType RSVPDate { get; set; }

        [JsonProperty("invitation_date")]
        public EventApiParticipantInvitationDateType InvitationDate { get; set; }

        [JsonProperty("participation_level")]
        public EventApiParticipationLevel ParticipationLevel { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventApiParticipantRSVPStatusType
    {
        NoResponse,
        Attending,
        Declined,
        Interested,
        Canceled,
        Waitlisted,
        NotApplicable
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventApiParticipantInvitationStatusType
    {
        NotApplicable,
        NotInvited,
        Invited
    }

    public class EventApiParticipantRSVPDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiParticipantInvitationDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiApiCollectionOfParticipantDonation
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantDonation[] Value { get; set; }
    }

    public class EventApiParticipantDonation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("gift_id")]
        public string GiftId { get; set; }
    }

    public class EventApiCreatedParticipantDonation
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventApiApiCollectionOfParticipantFeePayment
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantFeePayment[] Value { get; set; }
    }

    public class EventApiParticipantFeePayment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantId { get; set; }

        [JsonProperty("gift_id")]
        public string GiftId { get; set; }

        [JsonProperty("applied_amount")]
        public double AppliedAmount { get; set; }
    }

    public class EventApiCreatedParticipantFeePayment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventApiApiCollectionOfParticipantFee
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantFee[] Value { get; set; }
    }

    public class EventApiParticipantFee
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("fee_amount")]
        public double FeeAmount { get; set; }

        [JsonProperty("tax_receiptable_amount")]
        public double ContributionAmount { get; set; }

        [JsonProperty("date")]
        public EventApiParticipantFeeDateType Date { get; set; }

        [JsonProperty("event_fee")]
        public EventApiEventFee EventFee { get; set; }
    }

    public class EventApiParticipantFeeDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class EventApiCreatedParticipantFee
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class EventApiApiCollectionOfParticipantOption
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public EventApiParticipantOption[] Value { get; set; }
    }

    public class EventApiParticipantOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("participant_id")]
        public string ParticipantId { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("event_participant_option_id")]
        public string EventParticipantOptionId { get; set; }

        [JsonProperty("option_value")]
        public string Value { get; set; }

        [JsonProperty("added_by_user")]
        public string AddedByUser { get; set; }

        [JsonProperty("updated_by_user")]
        public string ModifiedByUser { get; set; }

        [JsonProperty("added_by_service")]
        public string AddedByService { get; set; }

        [JsonProperty("updated_by_service")]
        public string ModifiedByService { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_updated")]
        public string DateModified { get; set; }
    }

    public class EventApiCreatedParticipantOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiApiCollectionOfAppealRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealRead[] Value { get; set; }
    }

    public class FundraisingApiAppealRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiAppealReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiAppealReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfAppealAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiAppealAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string AppealId { get; set; }

        [JsonProperty("type")]
        public FundraisingApiAppealAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FundraisingApiAppealAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfAppealCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiAppealCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiAppealCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string AppealId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiAppealCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FundraisingApiAppealCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiCreatedAppealAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiCreatedAppealCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiApiCollectionOfCampaignRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiCampaignReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiCampaignReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfCampaignAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string CampaignId { get; set; }

        [JsonProperty("type")]
        public FundraisingApiCampaignAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FundraisingApiCampaignAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfCampaignCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiCampaignCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiCampaignCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string CampaignId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiCampaignCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FundraisingApiCampaignCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiCreatedCampaignAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiCreatedCampaignCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiCreatedFundraiserAssignment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start")]
        public string AssignmentStarts { get; set; }

        [JsonProperty("end")]
        public string AssignmentEnds { get; set; }

        [JsonProperty("amount")]
        public FundraisingApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundRead[] Value { get; set; }
    }

    public class FundraisingApiFundRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiFundReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class FundraisingApiFundReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundAttachmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string FundId { get; set; }

        [JsonProperty("type")]
        public FundraisingApiFundAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FundraisingApiFundAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class FundraisingApiApiCollectionOfFundCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundCustomFieldRead[] Value { get; set; }
    }

    public class FundraisingApiFundCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string FundId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public FundraisingApiFundCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FundraisingApiFundCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class FundraisingApiCreatedFundAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiCreatedFundCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FundraisingApiApiCollectionOfPackageRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiPackageRead[] Value { get; set; }
    }

    public class FundraisingApiPackageRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("default_gift_amount")]
        public FundraisingApiPackageReadDefaultGiftAmountType DefaultGiftAmount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }

        [JsonProperty("goal")]
        public FundraisingApiPackageReadGoalType Goal { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("recipient_count")]
        public int RecipientCount { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }
    }

    public class FundraisingApiPackageReadDefaultGiftAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FundraisingApiPackageReadGoalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public class GiftApiApiCollectionOfGiftRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftRead[] Value { get; set; }
    }

    public class GiftApiGiftRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftReadAmountType Amount { get; set; }

        [JsonProperty("balance")]
        public GiftApiGiftReadBalanceType Balance { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("gift_status")]
        public string Status { get; set; }

        [JsonProperty("is_anonymous")]
        public bool Anonymous { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("post_status")]
        public string PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("recurring_gift_status_date")]
        public GiftApiGiftReadRecurringGiftDateType RecurringGiftDate { get; set; }

        [JsonProperty("recurring_gift_schedule")]
        public GiftApiGiftReadRecurringGiftScheduleType RecurringGiftSchedule { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("gift_code")]
        public string GiftCode { get; set; }

        [JsonProperty("gift_splits")]
        public GiftApiGiftSplitRead[] GiftSplits { get; set; }

        [JsonProperty("fundraisers")]
        public GiftApiGiftFundraiserRead[] Fundraisers { get; set; }

        [JsonProperty("soft_credits")]
        public GiftApiSoftCreditRead[] SoftCredits { get; set; }

        [JsonProperty("receipts")]
        public GiftApiReceiptRead[] Receipts { get; set; }

        [JsonProperty("acknowledgements")]
        public GiftApiAcknowledgementRead[] Acknowledgements { get; set; }

        [JsonProperty("payments")]
        public GiftApiPaymentRead[] Payments { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class GiftApiGiftReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftReadBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftReadRecurringGiftDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiGiftReadRecurringGiftScheduleType
    {
        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("start_date")]
        public string Start { get; set; }

        [JsonProperty("end_date")]
        public string End { get; set; }
    }

    public class GiftApiGiftReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftSplitRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitReadAmountType Amount { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftSplitReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }
    }

    public class GiftApiGiftSplitReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftSplitReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftFundraiserRead
    {
        [JsonProperty("amount")]
        public GiftApiGiftFundraiserReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string FundraiserId { get; set; }
    }

    public class GiftApiGiftFundraiserReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiSoftCreditRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public GiftApiSoftCreditReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("gift_id")]
        public string GiftId { get; set; }
    }

    public class GiftApiSoftCreditReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiReceiptRead
    {
        [JsonProperty("amount")]
        public GiftApiReceiptReadAmountType Amount { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GiftApiReceiptReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiAcknowledgementRead
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GiftApiPaymentRead
    {
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        [JsonProperty("bbps_configuration_id")]
        public string BBPSConfigurationId { get; set; }

        [JsonProperty("bbps_transaction_id")]
        public string BBPSTransactionId { get; set; }

        [JsonProperty("check_date")]
        public GiftApiPaymentReadCheckDateType CheckDate { get; set; }

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("checkout_transaction_id")]
        public string CheckoutTransactionId { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("reference_date")]
        public GiftApiPaymentReadReferenceDateType ReferenceDate { get; set; }
    }

    public class GiftApiPaymentReadCheckDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiPaymentReadReferenceDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiCreatedGift
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GiftApiGiftSplitAdd
    {
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiGiftSplitAddAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreceiptsreceiptStatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypaymentspaymentMethodInput
    {
        Cash,
        CreditCard,
        PersonalCheck,
        DirectDebit,
        Other,
        PayPal,
        Venmo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypostStatusInput
    {
        Posted,
        NotPosted,
        DoNotPost
    }

    public class GiftApiApiCollectionOfGiftAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftAttachmentRead[] Value { get; set; }
    }

    public class GiftApiGiftAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string GiftId { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GiftApiGiftAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class GiftApiApiCollectionOfGiftCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftCustomFieldRead[] Value { get; set; }
    }

    public class GiftApiGiftCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string GiftId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GiftApiGiftCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class GiftApiCreatedGiftAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GiftApiCreatedGiftCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GiftApiBatchGiftAddResults
    {
        [JsonProperty("errors")]
        public GiftApiGiftBatchGiftError[] Errors { get; set; }

        [JsonProperty("gifts")]
        public GiftApiBatchGiftRead[] Gifts { get; set; }
    }

    public class GiftApiGiftBatchGiftError
    {
        [JsonProperty("affected_field")]
        public string AffectedField { get; set; }

        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        [JsonProperty("exception_error_code")]
        public int ExceptionErrorCode { get; set; }

        [JsonProperty("exception_error_message")]
        public string ExceptionErrorMessage { get; set; }

        [JsonProperty("exception_error_name")]
        public string ExceptionErrorName { get; set; }

        [JsonProperty("gift_id")]
        public string GiftId { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }
    }

    public class GiftApiBatchGiftRead
    {
        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        [JsonProperty("errors")]
        public GiftApiGiftBatchGiftError[] Errors { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public GiftApiBatchGiftReadAmountType Amount { get; set; }

        [JsonProperty("balance")]
        public GiftApiBatchGiftReadBalanceType Balance { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("gift_status")]
        public string Status { get; set; }

        [JsonProperty("is_anonymous")]
        public bool Anonymous { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("post_status")]
        public string PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("recurring_gift_status_date")]
        public GiftApiBatchGiftReadRecurringGiftDateType RecurringGiftDate { get; set; }

        [JsonProperty("recurring_gift_schedule")]
        public GiftApiBatchGiftReadRecurringGiftScheduleType RecurringGiftSchedule { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiBatchGiftReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("gift_code")]
        public string GiftCode { get; set; }

        [JsonProperty("gift_splits")]
        public GiftApiGiftSplitRead[] GiftSplits { get; set; }

        [JsonProperty("fundraisers")]
        public GiftApiGiftFundraiserRead[] Fundraisers { get; set; }

        [JsonProperty("soft_credits")]
        public GiftApiSoftCreditRead[] SoftCredits { get; set; }

        [JsonProperty("receipts")]
        public GiftApiReceiptRead[] Receipts { get; set; }

        [JsonProperty("acknowledgements")]
        public GiftApiAcknowledgementRead[] Acknowledgements { get; set; }

        [JsonProperty("payments")]
        public GiftApiPaymentRead[] Payments { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class GiftApiBatchGiftReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiBatchGiftReadBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiBatchGiftReadRecurringGiftDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiBatchGiftReadRecurringGiftScheduleType
    {
        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("start_date")]
        public string Start { get; set; }

        [JsonProperty("end_date")]
        public string End { get; set; }
    }

    public class GiftApiBatchGiftReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftspaymentspaymentMethodInput
    {
        Cash,
        CreditCard,
        PersonalCheck,
        DirectDebit,
        Other,
        PayPal,
        Venmo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftsreceiptsreceiptStatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftstypeInput
    {
        Donation,
        Other,
        GiftInKind
    }

    public class GiftApiVirtualBatchGiftSplitAdd
    {
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("amount")]
        public GiftApiVirtualBatchGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiVirtualBatchGiftSplitAddAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftspostStatusInput
    {
        Posted,
        NotPosted,
        DoNotPost
    }

    public class GiftBatchApiApiCollectionOfGiftBatch
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftBatchApiGiftBatch[] Value { get; set; }
    }

    public class GiftBatchApiGiftBatch
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("batch_description")]
        public string Description { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("projected_number_of_gifts")]
        public int ProjectedNumber { get; set; }

        [JsonProperty("number_of_gifts")]
        public int ActualNumber { get; set; }

        [JsonProperty("projected_amount")]
        public double ProjectedAmount { get; set; }

        [JsonProperty("actual_amount")]
        public double ActualAmount { get; set; }

        [JsonProperty("has_exceptions")]
        public bool HasExceptions { get; set; }

        [JsonProperty("is_approved")]
        public bool Approved { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
    }

    public class GiftBatchApiCreatedBatch
    {
        [JsonProperty("batch_id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylistTypeInput
    {
        Constituent,
        Gift,
        Action,
        Opportunity
    }

    public class ListApiCreatedList
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypermissionsInput
    {
        OnlyOwnerCanAccess,
        OthersCanView,
        OthersCanViewAndEdit
    }

    public class OpportunityApiApiCollectionOfOpportunityRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("ask_amount")]
        public OpportunityApiOpportunityReadAskAmountType AskAmount { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("expected_amount")]
        public OpportunityApiOpportunityReadExpectedAmountType ExpectedAmount { get; set; }

        [JsonProperty("funded_date")]
        public string FundedDate { get; set; }

        [JsonProperty("funded_amount")]
        public OpportunityApiOpportunityReadFundedAmountType FundedAmount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("fundraisers")]
        public OpportunityApiFundraiser[] FundraiserS { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class OpportunityApiOpportunityReadAskAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiOpportunityReadExpectedAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiOpportunityReadFundedAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiFundraiser
    {
        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("credit_amount")]
        public OpportunityApiFundraiserCreditAmountType CreditAmount { get; set; }
    }

    public class OpportunityApiFundraiserCreditAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiCreatedOpportunity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OpportunityApiApiCollectionOfOpportunityAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityAttachmentRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityId { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpportunityApiOpportunityAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class OpportunityApiApiCollectionOfOpportunityCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityCustomFieldRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpportunityApiOpportunityCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class OpportunityApiCreatedOpportunityAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class OpportunityApiCreatedOpportunityCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudraisersedge;

    public partial class WorkflowManagedActions
    {
        public BlackbaudraisersedgeActions Blackbaudraisersedge(string connectionId) => new BlackbaudraisersedgeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudraisersedgeTriggers Blackbaudraisersedge(string connectionId) => new BlackbaudraisersedgeTriggers(connectionId);
    }
}