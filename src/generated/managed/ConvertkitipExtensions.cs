//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Convertkitip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConvertkitipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<AccountResponse> Account()
        {
            var apiCallPath = "/account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<FormListResponse> FormList()
        {
            var apiCallPath = "/forms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FormListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<FormSubAddResponse> FormSubAdd(Expression<Func<string>> formId, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfirstName = null, Expression<Func<int[]>> bodytags = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<FormSubAddResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/forms/{0}/subscribe", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                if (fieldsObjectpropCount > 0)
                {
                    body["fields"] = fieldsObject;
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

                return new ApiConnectionAction<FormSubAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<FormSubListResponse> FormSubList(Expression<Func<string>> formId, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<subscriberStateInput>> subscriberState = null, Expression<Func<int>> page = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_subscriberState = WorkflowExpression.Compile(subscriberState, nameof(subscriberState), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<FormSubListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/forms/{0}/subscriptions", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (__workflow_subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(__workflow_subscriberState);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<FormSubListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SequenceListResponse> SequenceList()
        {
            var apiCallPath = "/sequences";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SequenceListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SequenceSubAddResponse> SequenceSubAdd(Expression<Func<string>> sequenceId, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfirstName = null, Expression<Func<int[]>> bodytags = null)
        {
            var __workflow_sequenceId = WorkflowExpression.Compile(sequenceId, nameof(sequenceId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<SequenceSubAddResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sequences/{0}/subscribe", __workflow_sequenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                if (fieldsObjectpropCount > 0)
                {
                    body["fields"] = fieldsObject;
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

                return new ApiConnectionAction<SequenceSubAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SequenceSubListResponse> SequenceSubList(Expression<Func<string>> sequenceId, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<subscriberStateInput>> subscriberState = null, Expression<Func<int>> page = null)
        {
            var __workflow_sequenceId = WorkflowExpression.Compile(sequenceId, nameof(sequenceId), required: true);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_subscriberState = WorkflowExpression.Compile(subscriberState, nameof(subscriberState), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<SequenceSubListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sequences/{0}/subscriptions", __workflow_sequenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (__workflow_subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(__workflow_subscriberState);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<SequenceSubListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagListResponse> TagList()
        {
            var apiCallPath = "/tags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagAddResponse> TagAdd(Expression<Func<string>> bodytagname = null)
        {
            var __workflow_bodytagname = WorkflowExpression.Compile(bodytagname, nameof(bodytagname), required: false);
            return new DeferredBodyAction<TagAddResponse>(() =>
            {
                var apiCallPath = "/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var tagObject = new JObject();
                var tagObjectpropCount = 0;
                if (__workflow_bodytagname != null)
                {
                    tagObject["name"] = ExpressionConverter.ConvertO(__workflow_bodytagname);
                    tagObjectpropCount++;
                }

                if (tagObjectpropCount > 0)
                {
                    body["tag"] = tagObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TagAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubResponse> TagSub(Expression<Func<string>> tagId, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<int[]>> bodytags = null)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<TagSubResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tags/{0}/subscribe", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                if (fieldsObjectpropCount > 0)
                {
                    body["fields"] = fieldsObject;
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

                return new ApiConnectionAction<TagSubResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubRemoveResponse> TagSubRemove(Expression<Func<string>> subscriberId, Expression<Func<string>> tagId)
        {
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<TagSubRemoveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/tags/{1}", __workflow_subscriberId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagSubRemoveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubRemoveEmailResponse> TagSubRemoveEmail(Expression<Func<string>> tagId, Expression<Func<string>> bodyemail)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<TagSubRemoveEmailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tags/{0}/unsubscribe", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TagSubRemoveEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubListResponse> TagSubList(Expression<Func<string>> tagId, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<subscriberStateInput>> subscriberState = null, Expression<Func<int>> page = null)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_subscriberState = WorkflowExpression.Compile(subscriberState, nameof(subscriberState), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<TagSubListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tags/{0}/subscriptions", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (__workflow_subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(__workflow_subscriberState);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<TagSubListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberListResponse> SubscriberList(Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> updatedFrom = null, Expression<Func<string>> updatedTo = null, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<string>> emailAddress = null, Expression<Func<int>> page = null)
        {
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_updatedFrom = WorkflowExpression.Compile(updatedFrom, nameof(updatedFrom), required: false);
            var __workflow_updatedTo = WorkflowExpression.Compile(updatedTo, nameof(updatedTo), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: false);
            var __workflow_emailAddress = WorkflowExpression.Compile(emailAddress, nameof(emailAddress), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<SubscriberListResponse>(() =>
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_updatedFrom != null)
                    callPayload.Queries["updated_from"] = ExpressionConverter.Convert(__workflow_updatedFrom);
                if (__workflow_updatedTo != null)
                    callPayload.Queries["updated_to"] = ExpressionConverter.Convert(__workflow_updatedTo);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["sort_field"] = Convert.ToString("");
                if (__workflow_sortField != null)
                    callPayload.Queries["sort_field"] = ExpressionConverter.Convert(__workflow_sortField);
                if (__workflow_emailAddress != null)
                    callPayload.Queries["email_address"] = ExpressionConverter.Convert(__workflow_emailAddress);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<SubscriberListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberGetResponse> SubscriberGet(Expression<Func<string>> subscriberId)
        {
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<SubscriberGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}", __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriberGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberUpdateResponse> SubscriberUpdate(Expression<Func<string>> subscriberId, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodyemailAddress = null)
        {
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            return new DeferredBodyAction<SubscriberUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}", __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                if (fieldsObjectpropCount > 0)
                {
                    body["fields"] = fieldsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SubscriberUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberUnsubResponse> SubscriberUnsub(Expression<Func<string>> bodyemail)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<SubscriberUnsubResponse>(() =>
            {
                var apiCallPath = "/unsubscribe";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SubscriberUnsubResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberTagsResponse> SubscriberTags(Expression<Func<string>> subscriberId)
        {
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<SubscriberTagsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/tags", __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriberTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastListResponse> BroadcastList()
        {
            var apiCallPath = "/broadcasts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BroadcastListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastAddResponse> BroadcastAdd(Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyemailLayoutTemplate = null, Expression<Func<bool>> bodyPublic = null, Expression<Func<string>> bodypublishedAt = null, Expression<Func<string>> bodysendAt = null, Expression<Func<string>> bodythumbnailAlt = null, Expression<Func<string>> bodythumbnailUrl = null)
        {
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyemailLayoutTemplate = WorkflowExpression.Compile(bodyemailLayoutTemplate, nameof(bodyemailLayoutTemplate), required: false);
            var __workflow_bodyPublic = WorkflowExpression.Compile(bodyPublic, nameof(bodyPublic), required: false);
            var __workflow_bodypublishedAt = WorkflowExpression.Compile(bodypublishedAt, nameof(bodypublishedAt), required: false);
            var __workflow_bodysendAt = WorkflowExpression.Compile(bodysendAt, nameof(bodysendAt), required: false);
            var __workflow_bodythumbnailAlt = WorkflowExpression.Compile(bodythumbnailAlt, nameof(bodythumbnailAlt), required: false);
            var __workflow_bodythumbnailUrl = WorkflowExpression.Compile(bodythumbnailUrl, nameof(bodythumbnailUrl), required: false);
            return new DeferredBodyAction<BroadcastAddResponse>(() =>
            {
                var apiCallPath = "/broadcasts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyemailLayoutTemplate != null)
                {
                    body["email_layout_template"] = ExpressionConverter.ConvertO(__workflow_bodyemailLayoutTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodyPublic != null)
                {
                    body["public"] = ExpressionConverter.ConvertO(__workflow_bodyPublic);
                    bodypropCount++;
                }

                if (__workflow_bodypublishedAt != null)
                {
                    body["published_at"] = ExpressionConverter.ConvertO(__workflow_bodypublishedAt);
                    bodypropCount++;
                }

                if (__workflow_bodysendAt != null)
                {
                    body["send_at"] = ExpressionConverter.ConvertO(__workflow_bodysendAt);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailAlt != null)
                {
                    body["thumbnail_alt"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailAlt);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailUrl != null)
                {
                    body["thumbnail_url"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BroadcastAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastGetResponse> BroadcastGet(Expression<Func<string>> broadcastId)
        {
            var __workflow_broadcastId = WorkflowExpression.Compile(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<BroadcastGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/broadcasts/{0}", __workflow_broadcastId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BroadcastGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastUpdateResponse> BroadcastUpdate(Expression<Func<string>> broadcastId, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyemailLayoutTemplate = null, Expression<Func<bool>> bodyPublic = null, Expression<Func<string>> bodypublishedAt = null, Expression<Func<string>> bodysendAt = null, Expression<Func<string>> bodythumbnailAlt = null, Expression<Func<string>> bodythumbnailUrl = null)
        {
            var __workflow_broadcastId = WorkflowExpression.Compile(broadcastId, nameof(broadcastId), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyemailAddress = WorkflowExpression.Compile(bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyemailLayoutTemplate = WorkflowExpression.Compile(bodyemailLayoutTemplate, nameof(bodyemailLayoutTemplate), required: false);
            var __workflow_bodyPublic = WorkflowExpression.Compile(bodyPublic, nameof(bodyPublic), required: false);
            var __workflow_bodypublishedAt = WorkflowExpression.Compile(bodypublishedAt, nameof(bodypublishedAt), required: false);
            var __workflow_bodysendAt = WorkflowExpression.Compile(bodysendAt, nameof(bodysendAt), required: false);
            var __workflow_bodythumbnailAlt = WorkflowExpression.Compile(bodythumbnailAlt, nameof(bodythumbnailAlt), required: false);
            var __workflow_bodythumbnailUrl = WorkflowExpression.Compile(bodythumbnailUrl, nameof(bodythumbnailUrl), required: false);
            return new DeferredBodyAction<BroadcastUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/broadcasts/{0}", __workflow_broadcastId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyemailLayoutTemplate != null)
                {
                    body["email_layout_template"] = ExpressionConverter.ConvertO(__workflow_bodyemailLayoutTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodyPublic != null)
                {
                    body["public"] = ExpressionConverter.ConvertO(__workflow_bodyPublic);
                    bodypropCount++;
                }

                if (__workflow_bodypublishedAt != null)
                {
                    body["published_at"] = ExpressionConverter.ConvertO(__workflow_bodypublishedAt);
                    bodypropCount++;
                }

                if (__workflow_bodysendAt != null)
                {
                    body["send_at"] = ExpressionConverter.ConvertO(__workflow_bodysendAt);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailAlt != null)
                {
                    body["thumbnail_alt"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailAlt);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailUrl != null)
                {
                    body["thumbnail_url"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BroadcastUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<string> BroadcastDelete(Expression<Func<string>> broadcastId)
        {
            var __workflow_broadcastId = WorkflowExpression.Compile(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/broadcasts/{0}", __workflow_broadcastId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastGetStatResponse> BroadcastGetStat(Expression<Func<string>> broadcastId)
        {
            var __workflow_broadcastId = WorkflowExpression.Compile(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<BroadcastGetStatResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/broadcasts/{0}/stats", __workflow_broadcastId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BroadcastGetStatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseListResponse> PurchaseList(Expression<Func<int>> page = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<PurchaseListResponse>(() =>
            {
                var apiCallPath = "/purchases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<PurchaseListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseAddResponse> PurchaseAdd(Expression<Func<string>> bodypurchasetransactionId = null, Expression<Func<string>> bodypurchaseemailAddress = null, Expression<Func<string>> bodypurchasefirstName = null, Expression<Func<string>> bodypurchasecurrency = null, Expression<Func<string>> bodypurchasetransactionTime = null, Expression<Func<int>> bodypurchasesubtotal = null, Expression<Func<int>> bodypurchasetax = null, Expression<Func<int>> bodypurchaseshipping = null, Expression<Func<int>> bodypurchasediscount = null, Expression<Func<int>> bodypurchasetotal = null, Expression<Func<string>> bodypurchasestatus = null, Expression<Func<bodypurchaseproductsInputItem[]>> bodypurchaseproducts = null)
        {
            var __workflow_bodypurchasetransactionId = WorkflowExpression.Compile(bodypurchasetransactionId, nameof(bodypurchasetransactionId), required: false);
            var __workflow_bodypurchaseemailAddress = WorkflowExpression.Compile(bodypurchaseemailAddress, nameof(bodypurchaseemailAddress), required: false);
            var __workflow_bodypurchasefirstName = WorkflowExpression.Compile(bodypurchasefirstName, nameof(bodypurchasefirstName), required: false);
            var __workflow_bodypurchasecurrency = WorkflowExpression.Compile(bodypurchasecurrency, nameof(bodypurchasecurrency), required: false);
            var __workflow_bodypurchasetransactionTime = WorkflowExpression.Compile(bodypurchasetransactionTime, nameof(bodypurchasetransactionTime), required: false);
            var __workflow_bodypurchasesubtotal = WorkflowExpression.Compile(bodypurchasesubtotal, nameof(bodypurchasesubtotal), required: false);
            var __workflow_bodypurchasetax = WorkflowExpression.Compile(bodypurchasetax, nameof(bodypurchasetax), required: false);
            var __workflow_bodypurchaseshipping = WorkflowExpression.Compile(bodypurchaseshipping, nameof(bodypurchaseshipping), required: false);
            var __workflow_bodypurchasediscount = WorkflowExpression.Compile(bodypurchasediscount, nameof(bodypurchasediscount), required: false);
            var __workflow_bodypurchasetotal = WorkflowExpression.Compile(bodypurchasetotal, nameof(bodypurchasetotal), required: false);
            var __workflow_bodypurchasestatus = WorkflowExpression.Compile(bodypurchasestatus, nameof(bodypurchasestatus), required: false);
            var __workflow_bodypurchaseproducts = WorkflowExpression.Compile(bodypurchaseproducts, nameof(bodypurchaseproducts), required: false);
            return new DeferredBodyAction<PurchaseAddResponse>(() =>
            {
                var apiCallPath = "/purchases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var purchaseObject = new JObject();
                var purchaseObjectpropCount = 0;
                if (__workflow_bodypurchasetransactionId != null)
                {
                    purchaseObject["transaction_id"] = ExpressionConverter.ConvertO(__workflow_bodypurchasetransactionId);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchaseemailAddress != null)
                {
                    purchaseObject["email_address"] = ExpressionConverter.ConvertO(__workflow_bodypurchaseemailAddress);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchasefirstName != null)
                {
                    purchaseObject["first_name"] = ExpressionConverter.ConvertO(__workflow_bodypurchasefirstName);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchasecurrency != null)
                {
                    purchaseObject["currency"] = ExpressionConverter.ConvertO(__workflow_bodypurchasecurrency);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchasetransactionTime != null)
                {
                    purchaseObject["transaction_time"] = ExpressionConverter.ConvertO(__workflow_bodypurchasetransactionTime);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchasesubtotal != null)
                {
                    purchaseObject["subtotal"] = ExpressionConverter.ConvertO(__workflow_bodypurchasesubtotal);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchasetax != null)
                {
                    purchaseObject["tax"] = ExpressionConverter.ConvertO(__workflow_bodypurchasetax);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchaseshipping != null)
                {
                    purchaseObject["shipping"] = ExpressionConverter.ConvertO(__workflow_bodypurchaseshipping);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchasediscount != null)
                {
                    purchaseObject["discount"] = ExpressionConverter.ConvertO(__workflow_bodypurchasediscount);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchasetotal != null)
                {
                    purchaseObject["total"] = ExpressionConverter.ConvertO(__workflow_bodypurchasetotal);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchasestatus != null)
                {
                    purchaseObject["status"] = ExpressionConverter.ConvertO(__workflow_bodypurchasestatus);
                    purchaseObjectpropCount++;
                }

                if (__workflow_bodypurchaseproducts != null)
                {
                    purchaseObject["products"] = ExpressionConverter.ConvertO(__workflow_bodypurchaseproducts);
                    purchaseObjectpropCount++;
                }

                if (purchaseObjectpropCount > 0)
                {
                    body["purchase"] = purchaseObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PurchaseAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseGetResponse> PurchaseGet(Expression<Func<string>> purchaseId)
        {
            var __workflow_purchaseId = WorkflowExpression.Compile(purchaseId, nameof(purchaseId), required: true);
            return new DeferredBodyAction<PurchaseGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/purchases/{0}", __workflow_purchaseId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PurchaseGetResponse>(callPayload);
            });
        }
    }

    public class ConvertkitipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccountResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plan_type")]
        public string PlanType { get; set; }

        [JsonProperty("primary_email_address")]
        public string PrimaryEmailAddress { get; set; }
    }

    public class FormListResponse
    {
        [JsonProperty("forms")]
        public FormListResponseFormsTypeItem[] Forms { get; set; }
    }

    public class FormListResponseFormsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("embed_js")]
        public string EmbedJs { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sign_up_button_text")]
        public string SignUpButtonText { get; set; }

        [JsonProperty("success_message")]
        public string SuccessMessage { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class FormSubAddResponse
    {
        [JsonProperty("subscription")]
        public FormSubAddResponseSubscriptionType Subscription { get; set; }
    }

    public class FormSubAddResponseSubscriptionType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public FormSubAddResponseSubscriptionTypeSubscriberType Subscriber { get; set; }
    }

    public class FormSubAddResponseSubscriptionTypeSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class FormSubListResponse
    {
        [JsonProperty("total_subscriptions")]
        public int TotalSubscriptions { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("subscriptions")]
        public FormSubListResponseSubscriptionsTypeItem[] Subscriptions { get; set; }
    }

    public class FormSubListResponseSubscriptionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public FormSubListResponseSubscriptionsTypeItemSubscriberType Subscriber { get; set; }
    }

    public class FormSubListResponseSubscriptionsTypeItemSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public FormSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType Fields { get; set; }
    }

    public class FormSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortOrderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum subscriberStateInput
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class SequenceListResponse
    {
        [JsonProperty("courses")]
        public SequenceListResponseCoursesTypeItem[] Courses { get; set; }
    }

    public class SequenceListResponseCoursesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class SequenceSubAddResponse
    {
        [JsonProperty("subscription")]
        public SequenceSubAddResponseSubscriptionType Subscription { get; set; }
    }

    public class SequenceSubAddResponseSubscriptionType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public SequenceSubAddResponseSubscriptionTypeSubscriberType Subscriber { get; set; }
    }

    public class SequenceSubAddResponseSubscriptionTypeSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class SequenceSubListResponse
    {
        [JsonProperty("total_subscriptions")]
        public int TotalSubscriptions { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("subscriptions")]
        public SequenceSubListResponseSubscriptionsTypeItem[] Subscriptions { get; set; }
    }

    public class SequenceSubListResponseSubscriptionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public SequenceSubListResponseSubscriptionsTypeItemSubscriberType Subscriber { get; set; }
    }

    public class SequenceSubListResponseSubscriptionsTypeItemSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public SequenceSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType Fields { get; set; }
    }

    public class SequenceSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class TagListResponse
    {
        [JsonProperty("tags")]
        public TagListResponseTagsTypeItem[] Tags { get; set; }
    }

    public class TagListResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TagAddResponse
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TagSubResponse
    {
        [JsonProperty("subscription")]
        public TagSubResponseSubscriptionType Subscription { get; set; }
    }

    public class TagSubResponseSubscriptionType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public TagSubResponseSubscriptionTypeSubscriberType Subscriber { get; set; }
    }

    public class TagSubResponseSubscriptionTypeSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class TagSubRemoveResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TagSubRemoveEmailResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TagSubListResponse
    {
        [JsonProperty("total_subscriptions")]
        public int TotalSubscriptions { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("subscriptions")]
        public TagSubListResponseSubscriptionsTypeItem[] Subscriptions { get; set; }
    }

    public class TagSubListResponseSubscriptionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("subscribable_id")]
        public int SubscribableId { get; set; }

        [JsonProperty("subscribable_type")]
        public string SubscribableType { get; set; }

        [JsonProperty("subscriber")]
        public TagSubListResponseSubscriptionsTypeItemSubscriberType Subscriber { get; set; }
    }

    public class TagSubListResponseSubscriptionsTypeItemSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public TagSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType Fields { get; set; }
    }

    public class TagSubListResponseSubscriptionsTypeItemSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class SubscriberListResponse
    {
        [JsonProperty("total_subscribers")]
        public int TotalSubscribers { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("subscribers")]
        public SubscriberListResponseSubscribersTypeItem[] Subscribers { get; set; }
    }

    public class SubscriberListResponseSubscribersTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public SubscriberListResponseSubscribersTypeItemFieldsType Fields { get; set; }
    }

    public class SubscriberListResponseSubscribersTypeItemFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortFieldInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "cancelled_at")]
        CancelledAt
    }

    public class SubscriberGetResponse
    {
        [JsonProperty("subscriber")]
        public SubscriberGetResponseSubscriberType Subscriber { get; set; }
    }

    public class SubscriberGetResponseSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public SubscriberGetResponseSubscriberTypeFieldsType Fields { get; set; }
    }

    public class SubscriberGetResponseSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class SubscriberUpdateResponse
    {
        [JsonProperty("subscriber")]
        public SubscriberUpdateResponseSubscriberType Subscriber { get; set; }
    }

    public class SubscriberUpdateResponseSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class SubscriberUnsubResponse
    {
        [JsonProperty("subscriber")]
        public SubscriberUnsubResponseSubscriberType Subscriber { get; set; }
    }

    public class SubscriberUnsubResponseSubscriberType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("fields")]
        public SubscriberUnsubResponseSubscriberTypeFieldsType Fields { get; set; }
    }

    public class SubscriberUnsubResponseSubscriberTypeFieldsType
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class SubscriberTagsResponse
    {
        [JsonProperty("tags")]
        public SubscriberTagsResponseTagsTypeItem[] Tags { get; set; }
    }

    public class SubscriberTagsResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class BroadcastListResponse
    {
        [JsonProperty("broadcasts")]
        public BroadcastListResponseBroadcastsTypeItem[] Broadcasts { get; set; }
    }

    public class BroadcastListResponseBroadcastsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class BroadcastAddResponse
    {
        [JsonProperty("broadcast")]
        public BroadcastAddResponseBroadcastType Broadcast { get; set; }
    }

    public class BroadcastAddResponseBroadcastType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("thumbnail_alt")]
        public string ThumbnailAlt { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_layout_template")]
        public string EmailLayoutTemplate { get; set; }
    }

    public class BroadcastGetResponse
    {
        [JsonProperty("broadcast")]
        public BroadcastGetResponseBroadcastType Broadcast { get; set; }
    }

    public class BroadcastGetResponseBroadcastType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("thumbnail_alt")]
        public string ThumbnailAlt { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_layout_template")]
        public string EmailLayoutTemplate { get; set; }
    }

    public class BroadcastUpdateResponse
    {
        [JsonProperty("broadcast")]
        public BroadcastUpdateResponseBroadcastType Broadcast { get; set; }
    }

    public class BroadcastUpdateResponseBroadcastType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("send_at")]
        public string SendAt { get; set; }

        [JsonProperty("thumbnail_alt")]
        public string ThumbnailAlt { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_layout_template")]
        public string EmailLayoutTemplate { get; set; }
    }

    public class BroadcastGetStatResponse
    {
        [JsonProperty("broadcast")]
        public BroadcastGetStatResponseBroadcastTypeItem[] Broadcast { get; set; }
    }

    public class BroadcastGetStatResponseBroadcastTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stats")]
        public BroadcastGetStatResponseBroadcastTypeItemStatsType Stats { get; set; }
    }

    public class BroadcastGetStatResponseBroadcastTypeItemStatsType
    {
        [JsonProperty("recipients")]
        public int Recipients { get; set; }

        [JsonProperty("open_rate")]
        public double OpenRate { get; set; }

        [JsonProperty("click_rate")]
        public double ClickRate { get; set; }

        [JsonProperty("unsubscribes")]
        public int Unsubscribes { get; set; }

        [JsonProperty("total_clicks")]
        public int TotalClicks { get; set; }

        [JsonProperty("show_total_clicks")]
        public bool ShowTotalClicks { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }
    }

    public class PurchaseListResponse
    {
        [JsonProperty("total_purchases")]
        public int TotalPurchases { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("purchases")]
        public PurchaseListResponsePurchasesTypeItem[] Purchases { get; set; }
    }

    public class PurchaseListResponsePurchasesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("transaction_time")]
        public string TransactionTime { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("shipping")]
        public int Shipping { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("tax")]
        public int Tax { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("products")]
        public PurchaseListResponsePurchasesTypeItemProductsTypeItem[] Products { get; set; }
    }

    public class PurchaseListResponsePurchasesTypeItemProductsTypeItem
    {
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PurchaseAddResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("transaction_time")]
        public string TransactionTime { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("tax")]
        public int Tax { get; set; }

        [JsonProperty("shipping")]
        public int Shipping { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("products")]
        public PurchaseAddResponseProductsTypeItem[] Products { get; set; }
    }

    public class PurchaseAddResponseProductsTypeItem
    {
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodypurchaseproductsInputItem
    {
        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("lid")]
        public int Lid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class PurchaseGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("transaction_time")]
        public string TransactionTime { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("shipping")]
        public int Shipping { get; set; }

        [JsonProperty("discount")]
        public int Discount { get; set; }

        [JsonProperty("tax")]
        public int Tax { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("products")]
        public PurchaseGetResponseProductsTypeItem[] Products { get; set; }
    }

    public class PurchaseGetResponseProductsTypeItem
    {
        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Convertkitip;

    public partial class WorkflowManagedActions
    {
        public ConvertkitipActions Convertkitip(string connectionId) => new ConvertkitipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConvertkitipTriggers Convertkitip(string connectionId) => new ConvertkitipTriggers(connectionId);
    }
}
