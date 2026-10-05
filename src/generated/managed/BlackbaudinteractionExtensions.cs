//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudinteraction
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudinteractionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        [WorkflowExpressionFactory(nameof(__BuildListActions))]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListActions([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<string> computedStatus = null, [WorkflowExpression] Func<string> statusCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> __BuildListActions(WorkflowValue<string> listId = null, WorkflowValue<string> computedStatus = null, WorkflowValue<string> statusCode = null, WorkflowValue<int> limit = null, WorkflowValue<int> offset = null, WorkflowValue<string> dateAdded = null, WorkflowValue<string> lastModified = null)
        {
            WorkflowValue.Validate(listId, nameof(listId), required: false);
            WorkflowValue.Validate(computedStatus, nameof(computedStatus), required: false);
            WorkflowValue.Validate(statusCode, nameof(statusCode), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            WorkflowValue.Validate(dateAdded, nameof(dateAdded), required: false);
            WorkflowValue.Validate(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionRead>(() =>
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(listId);
                if (computedStatus != null)
                    callPayload.Queries["computed_status"] = ExpressionConverter.Convert(computedStatus);
                if (statusCode != null)
                    callPayload.Queries["status_code"] = ExpressionConverter.Convert(statusCode);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAction))]
        public IBodyWorkflowAction<ConstituentApiCreatedAction> CreateAction([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<bodycategoryInput> bodycategory, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<bool> bodycompleted = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodydirectionInput> bodydirection = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyopportunityID = null, [WorkflowExpression] Func<bodyoutcomeInput> bodyoutcome = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodyauthor = null, [WorkflowExpression] Func<string[]> bodyfundraiserS = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiCreatedAction> __BuildCreateAction(WorkflowValue<string> bodyconstituentID, WorkflowValue<string> bodydate, WorkflowValue<bodycategoryInput> bodycategory, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodysummary = null, WorkflowValue<string> bodynote = null, WorkflowValue<bool> bodycompleted = null, WorkflowValue<string> bodycompletedOn = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bodydirectionInput> bodydirection = null, WorkflowValue<string> bodylocation = null, WorkflowValue<string> bodyopportunityID = null, WorkflowValue<bodyoutcomeInput> bodyoutcome = null, WorkflowValue<bodypriorityInput> bodypriority = null, WorkflowValue<string> bodystartTime = null, WorkflowValue<string> bodyendTime = null, WorkflowValue<string> bodyauthor = null, WorkflowValue<string[]> bodyfundraiserS = null)
        {
            WorkflowValue.Validate(bodyconstituentID, nameof(bodyconstituentID), required: true);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: true);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodysummary, nameof(bodysummary), required: false);
            WorkflowValue.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowValue.Validate(bodycompleted, nameof(bodycompleted), required: false);
            WorkflowValue.Validate(bodycompletedOn, nameof(bodycompletedOn), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodydirection, nameof(bodydirection), required: false);
            WorkflowValue.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowValue.Validate(bodyopportunityID, nameof(bodyopportunityID), required: false);
            WorkflowValue.Validate(bodyoutcome, nameof(bodyoutcome), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowValue.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowValue.Validate(bodyauthor, nameof(bodyauthor), required: false);
            WorkflowValue.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedAction>(() =>
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodycompleted != null)
                {
                    body["completed"] = ExpressionConverter.ConvertO(bodycompleted);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["completed_date"] = ExpressionConverter.ConvertO(bodycompletedOn);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodydirection != null)
                {
                    body["direction"] = ExpressionConverter.ConvertO(bodydirection);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                if (bodyopportunityID != null)
                {
                    body["opportunity_id"] = ExpressionConverter.ConvertO(bodyopportunityID);
                    bodypropCount++;
                }

                if (bodyoutcome != null)
                {
                    body["outcome"] = ExpressionConverter.ConvertO(bodyoutcome);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                    bodypropCount++;
                }

                if (bodyauthor != null)
                {
                    body["author"] = ExpressionConverter.ConvertO(bodyauthor);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(bodyfundraiserS);
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
        [WorkflowExpressionFactory(nameof(__BuildGetAction))]
        public IBodyWorkflowAction<ConstituentApiActionRead> GetAction([WorkflowExpression] Func<string> actionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiActionRead> __BuildGetAction(WorkflowValue<string> actionId)
        {
            WorkflowValue.Validate(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiActionRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiActionRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        [WorkflowExpressionFactory(nameof(__BuildEditAction))]
        public IWorkflowAction EditAction([WorkflowExpression] Func<string> actionId, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bodycategoryInput> bodycategory = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<bool> bodycompleted = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodydirectionInput> bodydirection = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyopportunityID = null, [WorkflowExpression] Func<bodyoutcomeInput> bodyoutcome = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string[]> bodyfundraiserS = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditAction(WorkflowValue<string> actionId, WorkflowValue<string> bodydate = null, WorkflowValue<bodycategoryInput> bodycategory = null, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodysummary = null, WorkflowValue<string> bodynote = null, WorkflowValue<bool> bodycompleted = null, WorkflowValue<string> bodycompletedOn = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bodydirectionInput> bodydirection = null, WorkflowValue<string> bodylocation = null, WorkflowValue<string> bodyopportunityID = null, WorkflowValue<bodyoutcomeInput> bodyoutcome = null, WorkflowValue<bodypriorityInput> bodypriority = null, WorkflowValue<string> bodystartTime = null, WorkflowValue<string> bodyendTime = null, WorkflowValue<string[]> bodyfundraiserS = null)
        {
            WorkflowValue.Validate(actionId, nameof(actionId), required: true);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodysummary, nameof(bodysummary), required: false);
            WorkflowValue.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowValue.Validate(bodycompleted, nameof(bodycompleted), required: false);
            WorkflowValue.Validate(bodycompletedOn, nameof(bodycompletedOn), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodydirection, nameof(bodydirection), required: false);
            WorkflowValue.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowValue.Validate(bodyopportunityID, nameof(bodyopportunityID), required: false);
            WorkflowValue.Validate(bodyoutcome, nameof(bodyoutcome), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowValue.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowValue.Validate(bodyfundraiserS, nameof(bodyfundraiserS), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodynote);
                    bodypropCount++;
                }

                if (bodycompleted != null)
                {
                    body["completed"] = ExpressionConverter.ConvertO(bodycompleted);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["completed_date"] = ExpressionConverter.ConvertO(bodycompletedOn);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodydirection != null)
                {
                    body["direction"] = ExpressionConverter.ConvertO(bodydirection);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                if (bodyopportunityID != null)
                {
                    body["opportunity_id"] = ExpressionConverter.ConvertO(bodyopportunityID);
                    bodypropCount++;
                }

                if (bodyoutcome != null)
                {
                    body["outcome"] = ExpressionConverter.ConvertO(bodyoutcome);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = ExpressionConverter.ConvertO(bodyfundraiserS);
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
        [WorkflowExpressionFactory(nameof(__BuildListActionAttachments))]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionAttachmentRead> ListActionAttachments([WorkflowExpression] Func<string> actionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionAttachmentRead> __BuildListActionAttachments(WorkflowValue<string> actionId)
        {
            WorkflowValue.Validate(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionAttachmentRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        [WorkflowExpressionFactory(nameof(__BuildListActionCustomFields))]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionCustomFieldRead> ListActionCustomFields([WorkflowExpression] Func<string> actionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionCustomFieldRead> __BuildListActionCustomFields(WorkflowValue<string> actionId)
        {
            WorkflowValue.Validate(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        [WorkflowExpressionFactory(nameof(__BuildCreateActionAttachment))]
        public IBodyWorkflowAction<ConstituentApiCreatedActionAttachment> CreateActionAttachment([WorkflowExpression] Func<string> bodyactionID, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileID = null, [WorkflowExpression] Func<string> bodythumbnailID = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiCreatedActionAttachment> __BuildCreateActionAttachment(WorkflowValue<string> bodyactionID, WorkflowValue<bodytypeInput> bodytype, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodyuRL = null, WorkflowValue<string> bodyfileName = null, WorkflowValue<string> bodyfileID = null, WorkflowValue<string> bodythumbnailID = null, WorkflowValue<string[]> bodytags = null)
        {
            WorkflowValue.Validate(bodyactionID, nameof(bodyactionID), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodyuRL, nameof(bodyuRL), required: false);
            WorkflowValue.Validate(bodyfileName, nameof(bodyfileName), required: false);
            WorkflowValue.Validate(bodyfileID, nameof(bodyfileID), required: false);
            WorkflowValue.Validate(bodythumbnailID, nameof(bodythumbnailID), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedActionAttachment>(() =>
            {
                var apiCallPath = "/constituent/v1/actions/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(bodyactionID);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileID != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(bodyfileID);
                    bodypropCount++;
                }

                if (bodythumbnailID != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(bodythumbnailID);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
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
        [WorkflowExpressionFactory(nameof(__BuildEditActionAttachment))]
        public IWorkflowAction EditActionAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditActionAttachment(WorkflowValue<string> attachmentId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodyuRL = null, WorkflowValue<string[]> bodytags = null)
        {
            WorkflowValue.Validate(attachmentId, nameof(attachmentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodyuRL, nameof(bodyuRL), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateActionCustomField))]
        public IBodyWorkflowAction<ConstituentApiCreatedActionCustomField> CreateActionCustomField([WorkflowExpression] Func<string> bodyactionID, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiCreatedActionCustomField> __BuildCreateActionCustomField(WorkflowValue<string> bodyactionID, WorkflowValue<string> bodycategory, WorkflowValue<object> bodyvalue = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodycomment = null)
        {
            WorkflowValue.Validate(bodyactionID, nameof(bodyactionID), required: true);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: true);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<ConstituentApiCreatedActionCustomField>(() =>
            {
                var apiCallPath = "/constituent/v1/actions/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(bodyactionID);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(bodycomment);
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
        [WorkflowExpressionFactory(nameof(__BuildEditActionCustomField))]
        public IWorkflowAction EditActionCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEditActionCustomField(WorkflowValue<string> customFieldId, WorkflowValue<string> bodycategory = null, WorkflowValue<object> bodyvalue = null, WorkflowValue<string> bodydate = null, WorkflowValue<string> bodycomment = null)
        {
            WorkflowValue.Validate(customFieldId, nameof(customFieldId), required: true);
            WorkflowValue.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(bodycomment);
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
        [WorkflowExpressionFactory(nameof(__BuildListConstituentActions))]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListConstituentActions([WorkflowExpression] Func<string> constituentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> __BuildListConstituentActions(WorkflowValue<string> constituentId)
        {
            WorkflowValue.Validate(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiApiCollectionOfActionRead>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
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

    public enum ConstituentApiActionReadDirectionType
    {
        Inbound,
        Outbound
    }

    public enum ConstituentApiActionReadOutcomeType
    {
        Successful,
        Unsuccessful
    }

    public enum ConstituentApiActionReadPriorityType
    {
        Normal,
        High,
        Low
    }

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

    public enum bodydirectionInput
    {
        Inbound,
        Outbound
    }

    public enum bodyoutcomeInput
    {
        Successful,
        Unsuccessful
    }

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
