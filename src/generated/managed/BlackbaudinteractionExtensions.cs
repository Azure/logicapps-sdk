//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudinteraction
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BlackbaudinteractionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListActions(Expression<Func<string>> listId = null, Expression<Func<string>> computedStatus = null, Expression<Func<string>> statusCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: false);
            var __workflow_computedStatus = computedStatus == null ? null : WorkflowExpression.Compile(computedStatus);
            WorkflowExpression.Validate(__workflow_computedStatus, nameof(computedStatus), required: false);
            var __workflow_statusCode = statusCode == null ? null : WorkflowExpression.Compile(statusCode);
            WorkflowExpression.Validate(__workflow_statusCode, nameof(statusCode), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            var __workflow_dateAdded = dateAdded == null ? null : WorkflowExpression.Compile(dateAdded);
            WorkflowExpression.Validate(__workflow_dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = lastModified == null ? null : WorkflowExpression.Compile(lastModified);
            WorkflowExpression.Validate(__workflow_lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionRead>(() =>
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedAction> CreateAction(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodydate, Expression<Func<bodycategoryInput>> bodycategory, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null, Expression<Func<bool>> bodycompleted = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyopportunityID = null, Expression<Func<bodyoutcomeInput>> bodyoutcome = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodyauthor = null, Expression<Func<string[]>> bodyfundraiserS = null)
        {
            var __workflow_bodyconstituentID = bodyconstituentID == null ? null : WorkflowExpression.Compile(bodyconstituentID);
            WorkflowExpression.Validate(__workflow_bodyconstituentID, nameof(bodyconstituentID), required: true);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: true);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: false);
            var __workflow_bodysummary = bodysummary == null ? null : WorkflowExpression.Compile(bodysummary);
            WorkflowExpression.Validate(__workflow_bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodynote = bodynote == null ? null : WorkflowExpression.Compile(bodynote);
            WorkflowExpression.Validate(__workflow_bodynote, nameof(bodynote), required: false);
            var __workflow_bodycompleted = bodycompleted == null ? null : WorkflowExpression.Compile(bodycompleted);
            WorkflowExpression.Validate(__workflow_bodycompleted, nameof(bodycompleted), required: false);
            var __workflow_bodycompletedOn = bodycompletedOn == null ? null : WorkflowExpression.Compile(bodycompletedOn);
            WorkflowExpression.Validate(__workflow_bodycompletedOn, nameof(bodycompletedOn), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydirection = bodydirection == null ? null : WorkflowExpression.Compile(bodydirection);
            WorkflowExpression.Validate(__workflow_bodydirection, nameof(bodydirection), required: false);
            var __workflow_bodylocation = bodylocation == null ? null : WorkflowExpression.Compile(bodylocation);
            WorkflowExpression.Validate(__workflow_bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyopportunityID = bodyopportunityID == null ? null : WorkflowExpression.Compile(bodyopportunityID);
            WorkflowExpression.Validate(__workflow_bodyopportunityID, nameof(bodyopportunityID), required: false);
            var __workflow_bodyoutcome = bodyoutcome == null ? null : WorkflowExpression.Compile(bodyoutcome);
            WorkflowExpression.Validate(__workflow_bodyoutcome, nameof(bodyoutcome), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystartTime = bodystartTime == null ? null : WorkflowExpression.Compile(bodystartTime);
            WorkflowExpression.Validate(__workflow_bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = bodyendTime == null ? null : WorkflowExpression.Compile(bodyendTime);
            WorkflowExpression.Validate(__workflow_bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodyauthor = bodyauthor == null ? null : WorkflowExpression.Compile(bodyauthor);
            WorkflowExpression.Validate(__workflow_bodyauthor, nameof(bodyauthor), required: false);
            var __workflow_bodyfundraiserS = bodyfundraiserS == null ? null : WorkflowExpression.Compile(bodyfundraiserS);
            WorkflowExpression.Validate(__workflow_bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedAction>(() =>
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentID);
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodynote);
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

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodydirection != null)
                {
                    body["direction"] = ExpressionConverter.ConvertO(__workflow_bodydirection);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityID != null)
                {
                    body["opportunity_id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityID);
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

                if (__workflow_bodyauthor != null)
                {
                    body["author"] = ExpressionConverter.ConvertO(__workflow_bodyauthor);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedAction>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiActionRead> GetAction(Expression<Func<string>> actionId)
        {
            var __workflow_actionId = actionId == null ? null : WorkflowExpression.Compile(actionId);
            WorkflowExpression.Validate(__workflow_actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiActionRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiActionRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditAction(Expression<Func<string>> actionId, Expression<Func<string>> bodydate = null, Expression<Func<bodycategoryInput>> bodycategory = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null, Expression<Func<bool>> bodycompleted = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyopportunityID = null, Expression<Func<bodyoutcomeInput>> bodyoutcome = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string[]>> bodyfundraiserS = null)
        {
            var __workflow_actionId = actionId == null ? null : WorkflowExpression.Compile(actionId);
            WorkflowExpression.Validate(__workflow_actionId, nameof(actionId), required: true);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: false);
            var __workflow_bodysummary = bodysummary == null ? null : WorkflowExpression.Compile(bodysummary);
            WorkflowExpression.Validate(__workflow_bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodynote = bodynote == null ? null : WorkflowExpression.Compile(bodynote);
            WorkflowExpression.Validate(__workflow_bodynote, nameof(bodynote), required: false);
            var __workflow_bodycompleted = bodycompleted == null ? null : WorkflowExpression.Compile(bodycompleted);
            WorkflowExpression.Validate(__workflow_bodycompleted, nameof(bodycompleted), required: false);
            var __workflow_bodycompletedOn = bodycompletedOn == null ? null : WorkflowExpression.Compile(bodycompletedOn);
            WorkflowExpression.Validate(__workflow_bodycompletedOn, nameof(bodycompletedOn), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydirection = bodydirection == null ? null : WorkflowExpression.Compile(bodydirection);
            WorkflowExpression.Validate(__workflow_bodydirection, nameof(bodydirection), required: false);
            var __workflow_bodylocation = bodylocation == null ? null : WorkflowExpression.Compile(bodylocation);
            WorkflowExpression.Validate(__workflow_bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyopportunityID = bodyopportunityID == null ? null : WorkflowExpression.Compile(bodyopportunityID);
            WorkflowExpression.Validate(__workflow_bodyopportunityID, nameof(bodyopportunityID), required: false);
            var __workflow_bodyoutcome = bodyoutcome == null ? null : WorkflowExpression.Compile(bodyoutcome);
            WorkflowExpression.Validate(__workflow_bodyoutcome, nameof(bodyoutcome), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystartTime = bodystartTime == null ? null : WorkflowExpression.Compile(bodystartTime);
            WorkflowExpression.Validate(__workflow_bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = bodyendTime == null ? null : WorkflowExpression.Compile(bodyendTime);
            WorkflowExpression.Validate(__workflow_bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodyfundraiserS = bodyfundraiserS == null ? null : WorkflowExpression.Compile(bodyfundraiserS);
            WorkflowExpression.Validate(__workflow_bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_actionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodynote);
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

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodydirection != null)
                {
                    body["direction"] = ExpressionConverter.ConvertO(__workflow_bodydirection);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityID != null)
                {
                    body["opportunity_id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityID);
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

                if (__workflow_bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionAttachmentRead> ListActionAttachments(Expression<Func<string>> actionId)
        {
            var __workflow_actionId = actionId == null ? null : WorkflowExpression.Compile(actionId);
            WorkflowExpression.Validate(__workflow_actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionAttachmentRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionCustomFieldRead> ListActionCustomFields(Expression<Func<string>> actionId)
        {
            var __workflow_actionId = actionId == null ? null : WorkflowExpression.Compile(actionId);
            WorkflowExpression.Validate(__workflow_actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(__workflow_actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionAttachment> CreateActionAttachment(Expression<Func<string>> bodyactionID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_bodyactionID = bodyactionID == null ? null : WorkflowExpression.Compile(bodyactionID);
            WorkflowExpression.Validate(__workflow_bodyactionID, nameof(bodyactionID), required: true);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = bodyuRL == null ? null : WorkflowExpression.Compile(bodyuRL);
            WorkflowExpression.Validate(__workflow_bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = bodyfileName == null ? null : WorkflowExpression.Compile(bodyfileName);
            WorkflowExpression.Validate(__workflow_bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileID = bodyfileID == null ? null : WorkflowExpression.Compile(bodyfileID);
            WorkflowExpression.Validate(__workflow_bodyfileID, nameof(bodyfileID), required: false);
            var __workflow_bodythumbnailID = bodythumbnailID == null ? null : WorkflowExpression.Compile(bodythumbnailID);
            WorkflowExpression.Validate(__workflow_bodythumbnailID, nameof(bodythumbnailID), required: false);
            var __workflow_bodytags = bodytags == null ? null : WorkflowExpression.Compile(bodytags);
            WorkflowExpression.Validate(__workflow_bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedActionAttachment>(() =>
            {
                var apiCallPath = "/constituent/v1/actions/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyactionID);
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

                if (__workflow_bodyfileID != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileID);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailID != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailID);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConstituentApiCreatedActionAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditActionAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_attachmentId = attachmentId == null ? null : WorkflowExpression.Compile(attachmentId);
            WorkflowExpression.Validate(__workflow_attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = bodyuRL == null ? null : WorkflowExpression.Compile(bodyuRL);
            WorkflowExpression.Validate(__workflow_bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodytags = bodytags == null ? null : WorkflowExpression.Compile(bodytags);
            WorkflowExpression.Validate(__workflow_bodytags, nameof(bodytags), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_attachmentId, 1));
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

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionCustomField> CreateActionCustomField(Expression<Func<string>> bodyactionID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodyactionID = bodyactionID == null ? null : WorkflowExpression.Compile(bodyactionID);
            WorkflowExpression.Validate(__workflow_bodyactionID, nameof(bodyactionID), required: true);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = bodyvalue == null ? null : WorkflowExpression.Compile(bodyvalue);
            WorkflowExpression.Validate(__workflow_bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedActionCustomField>(() =>
            {
                var apiCallPath = "/constituent/v1/actions/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyactionID);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditActionCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = customFieldId == null ? null : WorkflowExpression.Compile(customFieldId);
            WorkflowExpression.Validate(__workflow_customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = bodyvalue == null ? null : WorkflowExpression.Compile(bodyvalue);
            WorkflowExpression.Validate(__workflow_bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_customFieldId, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListConstituentActions(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = constituentId == null ? null : WorkflowExpression.Compile(constituentId);
            WorkflowExpression.Validate(__workflow_constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(callPayload);
            });
        }
    }

    public class BlackbaudinteractionTriggers([ConnectionName] string connectionId)
    {
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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string OpportunityID { get; set; }

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
        public string ID { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ActionID { get; set; }

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
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ActionID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public ConstituentApiActionCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

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

    public class ConstituentApiActionCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiCreatedActionAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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
        public string ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudinteraction;

    public partial class WorkflowManagedActions
    {
        public BlackbaudinteractionActions Blackbaudinteraction(string connectionId) => new BlackbaudinteractionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudinteractionTriggers Blackbaudinteraction(string connectionId) => new BlackbaudinteractionTriggers(connectionId);
    }
}
