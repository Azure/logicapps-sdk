//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Convertkitip
{
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
        [WorkflowExpressionFactory(nameof(__BuildFormSubAdd))]
        public IBodyWorkflowAction<FormSubAddResponse> FormSubAdd([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<int[]> bodytags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FormSubAddResponse> __BuildFormSubAdd(WorkflowExpression<string> formId, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<int[]> bodytags = null)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<FormSubAddResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/forms/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                if (fieldsObjectpropCount > 0)
                {
                    body["fields"] = fieldsObject;
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

                return new ApiConnectionAction<FormSubAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildFormSubList))]
        public IBodyWorkflowAction<FormSubListResponse> FormSubList([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<subscriberStateInput> subscriberState = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FormSubListResponse> __BuildFormSubList(WorkflowExpression<string> formId, WorkflowExpression<sortOrderInput> sortOrder = null, WorkflowExpression<subscriberStateInput> subscriberState = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(subscriberState, nameof(subscriberState), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<FormSubListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/forms/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(subscriberState);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
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
        [WorkflowExpressionFactory(nameof(__BuildSequenceSubAdd))]
        public IBodyWorkflowAction<SequenceSubAddResponse> SequenceSubAdd([WorkflowExpression] Func<string> sequenceId, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<int[]> bodytags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SequenceSubAddResponse> __BuildSequenceSubAdd(WorkflowExpression<string> sequenceId, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<int[]> bodytags = null)
        {
            WorkflowExpression.Validate(sequenceId, nameof(sequenceId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<SequenceSubAddResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sequences/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(sequenceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                if (fieldsObjectpropCount > 0)
                {
                    body["fields"] = fieldsObject;
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

                return new ApiConnectionAction<SequenceSubAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildSequenceSubList))]
        public IBodyWorkflowAction<SequenceSubListResponse> SequenceSubList([WorkflowExpression] Func<string> sequenceId, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<subscriberStateInput> subscriberState = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SequenceSubListResponse> __BuildSequenceSubList(WorkflowExpression<string> sequenceId, WorkflowExpression<sortOrderInput> sortOrder = null, WorkflowExpression<subscriberStateInput> subscriberState = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(sequenceId, nameof(sequenceId), required: true);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(subscriberState, nameof(subscriberState), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<SequenceSubListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sequences/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(sequenceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(subscriberState);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
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
        [WorkflowExpressionFactory(nameof(__BuildTagAdd))]
        public IBodyWorkflowAction<TagAddResponse> TagAdd([WorkflowExpression] Func<string> bodytagname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagAddResponse> __BuildTagAdd(WorkflowExpression<string> bodytagname = null)
        {
            WorkflowExpression.Validate(bodytagname, nameof(bodytagname), required: false);
            return new DeferredBodyAction<TagAddResponse>(() =>
            {
                var apiCallPath = "/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var tagObject = new JObject();
                var tagObjectpropCount = 0;
                if (bodytagname != null)
                {
                    tagObject["name"] = ExpressionConverter.ConvertO(bodytagname);
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
        [WorkflowExpressionFactory(nameof(__BuildTagSub))]
        public IBodyWorkflowAction<TagSubResponse> TagSub([WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<int[]> bodytags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagSubResponse> __BuildTagSub(WorkflowExpression<string> tagId, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<int[]> bodytags = null)
        {
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<TagSubResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tags/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                if (fieldsObjectpropCount > 0)
                {
                    body["fields"] = fieldsObject;
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

                return new ApiConnectionAction<TagSubResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildTagSubRemove))]
        public IBodyWorkflowAction<TagSubRemoveResponse> TagSubRemove([WorkflowExpression] Func<string> subscriberId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagSubRemoveResponse> __BuildTagSubRemove(WorkflowExpression<string> subscriberId, WorkflowExpression<string> tagId)
        {
            WorkflowExpression.Validate(subscriberId, nameof(subscriberId), required: true);
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<TagSubRemoveResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagSubRemoveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildTagSubRemoveEmail))]
        public IBodyWorkflowAction<TagSubRemoveEmailResponse> TagSubRemoveEmail([WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodyemail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagSubRemoveEmailResponse> __BuildTagSubRemoveEmail(WorkflowExpression<string> tagId, WorkflowExpression<string> bodyemail)
        {
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<TagSubRemoveEmailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tags/{0}/unsubscribe", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TagSubRemoveEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildTagSubList))]
        public IBodyWorkflowAction<TagSubListResponse> TagSubList([WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<subscriberStateInput> subscriberState = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagSubListResponse> __BuildTagSubList(WorkflowExpression<string> tagId, WorkflowExpression<sortOrderInput> sortOrder = null, WorkflowExpression<subscriberStateInput> subscriberState = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(tagId, nameof(tagId), required: true);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(subscriberState, nameof(subscriberState), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<TagSubListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tags/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["subscriber_state"] = Convert.ToString("active");
                if (subscriberState != null)
                    callPayload.Queries["subscriber_state"] = ExpressionConverter.Convert(subscriberState);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<TagSubListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildSubscriberList))]
        public IBodyWorkflowAction<SubscriberListResponse> SubscriberList([WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> updatedFrom = null, [WorkflowExpression] Func<string> updatedTo = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<string> emailAddress = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriberListResponse> __BuildSubscriberList(WorkflowExpression<string> from = null, WorkflowExpression<string> to = null, WorkflowExpression<string> updatedFrom = null, WorkflowExpression<string> updatedTo = null, WorkflowExpression<sortOrderInput> sortOrder = null, WorkflowExpression<sortFieldInput> sortField = null, WorkflowExpression<string> emailAddress = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            WorkflowExpression.Validate(updatedFrom, nameof(updatedFrom), required: false);
            WorkflowExpression.Validate(updatedTo, nameof(updatedTo), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(sortField, nameof(sortField), required: false);
            WorkflowExpression.Validate(emailAddress, nameof(emailAddress), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<SubscriberListResponse>(() =>
            {
                var apiCallPath = "/subscribers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                if (updatedFrom != null)
                    callPayload.Queries["updated_from"] = ExpressionConverter.Convert(updatedFrom);
                if (updatedTo != null)
                    callPayload.Queries["updated_to"] = ExpressionConverter.Convert(updatedTo);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["sort_field"] = Convert.ToString("");
                if (sortField != null)
                    callPayload.Queries["sort_field"] = ExpressionConverter.Convert(sortField);
                if (emailAddress != null)
                    callPayload.Queries["email_address"] = ExpressionConverter.Convert(emailAddress);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<SubscriberListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildSubscriberGet))]
        public IBodyWorkflowAction<SubscriberGetResponse> SubscriberGet([WorkflowExpression] Func<string> subscriberId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriberGetResponse> __BuildSubscriberGet(WorkflowExpression<string> subscriberId)
        {
            WorkflowExpression.Validate(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<SubscriberGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscribers/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriberGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildSubscriberUpdate))]
        public IBodyWorkflowAction<SubscriberUpdateResponse> SubscriberUpdate([WorkflowExpression] Func<string> subscriberId, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodyemailAddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriberUpdateResponse> __BuildSubscriberUpdate(WorkflowExpression<string> subscriberId, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodyemailAddress = null)
        {
            WorkflowExpression.Validate(subscriberId, nameof(subscriberId), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            return new DeferredBodyAction<SubscriberUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscribers/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(bodyemailAddress);
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
        [WorkflowExpressionFactory(nameof(__BuildSubscriberUnsub))]
        public IBodyWorkflowAction<SubscriberUnsubResponse> SubscriberUnsub([WorkflowExpression] Func<string> bodyemail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriberUnsubResponse> __BuildSubscriberUnsub(WorkflowExpression<string> bodyemail)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<SubscriberUnsubResponse>(() =>
            {
                var apiCallPath = "/unsubscribe";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SubscriberUnsubResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildSubscriberTags))]
        public IBodyWorkflowAction<SubscriberTagsResponse> SubscriberTags([WorkflowExpression] Func<string> subscriberId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriberTagsResponse> __BuildSubscriberTags(WorkflowExpression<string> subscriberId)
        {
            WorkflowExpression.Validate(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<SubscriberTagsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildBroadcastAdd))]
        public IBodyWorkflowAction<BroadcastAddResponse> BroadcastAdd([WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyemailLayoutTemplate = null, [WorkflowExpression] Func<bool> bodyPublic = null, [WorkflowExpression] Func<string> bodypublishedAt = null, [WorkflowExpression] Func<string> bodysendAt = null, [WorkflowExpression] Func<string> bodythumbnailAlt = null, [WorkflowExpression] Func<string> bodythumbnailUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BroadcastAddResponse> __BuildBroadcastAdd(WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodycontent = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodyemailLayoutTemplate = null, WorkflowExpression<bool> bodyPublic = null, WorkflowExpression<string> bodypublishedAt = null, WorkflowExpression<string> bodysendAt = null, WorkflowExpression<string> bodythumbnailAlt = null, WorkflowExpression<string> bodythumbnailUrl = null)
        {
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyemailLayoutTemplate, nameof(bodyemailLayoutTemplate), required: false);
            WorkflowExpression.Validate(bodyPublic, nameof(bodyPublic), required: false);
            WorkflowExpression.Validate(bodypublishedAt, nameof(bodypublishedAt), required: false);
            WorkflowExpression.Validate(bodysendAt, nameof(bodysendAt), required: false);
            WorkflowExpression.Validate(bodythumbnailAlt, nameof(bodythumbnailAlt), required: false);
            WorkflowExpression.Validate(bodythumbnailUrl, nameof(bodythumbnailUrl), required: false);
            return new DeferredBodyAction<BroadcastAddResponse>(() =>
            {
                var apiCallPath = "/broadcasts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyemailLayoutTemplate != null)
                {
                    body["email_layout_template"] = ExpressionConverter.ConvertO(bodyemailLayoutTemplate);
                    bodypropCount++;
                }

                if (bodyPublic != null)
                {
                    body["public"] = ExpressionConverter.ConvertO(bodyPublic);
                    bodypropCount++;
                }

                if (bodypublishedAt != null)
                {
                    body["published_at"] = ExpressionConverter.ConvertO(bodypublishedAt);
                    bodypropCount++;
                }

                if (bodysendAt != null)
                {
                    body["send_at"] = ExpressionConverter.ConvertO(bodysendAt);
                    bodypropCount++;
                }

                if (bodythumbnailAlt != null)
                {
                    body["thumbnail_alt"] = ExpressionConverter.ConvertO(bodythumbnailAlt);
                    bodypropCount++;
                }

                if (bodythumbnailUrl != null)
                {
                    body["thumbnail_url"] = ExpressionConverter.ConvertO(bodythumbnailUrl);
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
        [WorkflowExpressionFactory(nameof(__BuildBroadcastGet))]
        public IBodyWorkflowAction<BroadcastGetResponse> BroadcastGet([WorkflowExpression] Func<string> broadcastId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BroadcastGetResponse> __BuildBroadcastGet(WorkflowExpression<string> broadcastId)
        {
            WorkflowExpression.Validate(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<BroadcastGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/broadcasts/{0}", ExpressionConverter.ConvertWithUrlEncoding(broadcastId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BroadcastGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildBroadcastUpdate))]
        public IBodyWorkflowAction<BroadcastUpdateResponse> BroadcastUpdate([WorkflowExpression] Func<string> broadcastId, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyemailLayoutTemplate = null, [WorkflowExpression] Func<bool> bodyPublic = null, [WorkflowExpression] Func<string> bodypublishedAt = null, [WorkflowExpression] Func<string> bodysendAt = null, [WorkflowExpression] Func<string> bodythumbnailAlt = null, [WorkflowExpression] Func<string> bodythumbnailUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BroadcastUpdateResponse> __BuildBroadcastUpdate(WorkflowExpression<string> broadcastId, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodycontent = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodyemailLayoutTemplate = null, WorkflowExpression<bool> bodyPublic = null, WorkflowExpression<string> bodypublishedAt = null, WorkflowExpression<string> bodysendAt = null, WorkflowExpression<string> bodythumbnailAlt = null, WorkflowExpression<string> bodythumbnailUrl = null)
        {
            WorkflowExpression.Validate(broadcastId, nameof(broadcastId), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyemailLayoutTemplate, nameof(bodyemailLayoutTemplate), required: false);
            WorkflowExpression.Validate(bodyPublic, nameof(bodyPublic), required: false);
            WorkflowExpression.Validate(bodypublishedAt, nameof(bodypublishedAt), required: false);
            WorkflowExpression.Validate(bodysendAt, nameof(bodysendAt), required: false);
            WorkflowExpression.Validate(bodythumbnailAlt, nameof(bodythumbnailAlt), required: false);
            WorkflowExpression.Validate(bodythumbnailUrl, nameof(bodythumbnailUrl), required: false);
            return new DeferredBodyAction<BroadcastUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/broadcasts/{0}", ExpressionConverter.ConvertWithUrlEncoding(broadcastId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyemailLayoutTemplate != null)
                {
                    body["email_layout_template"] = ExpressionConverter.ConvertO(bodyemailLayoutTemplate);
                    bodypropCount++;
                }

                if (bodyPublic != null)
                {
                    body["public"] = ExpressionConverter.ConvertO(bodyPublic);
                    bodypropCount++;
                }

                if (bodypublishedAt != null)
                {
                    body["published_at"] = ExpressionConverter.ConvertO(bodypublishedAt);
                    bodypropCount++;
                }

                if (bodysendAt != null)
                {
                    body["send_at"] = ExpressionConverter.ConvertO(bodysendAt);
                    bodypropCount++;
                }

                if (bodythumbnailAlt != null)
                {
                    body["thumbnail_alt"] = ExpressionConverter.ConvertO(bodythumbnailAlt);
                    bodypropCount++;
                }

                if (bodythumbnailUrl != null)
                {
                    body["thumbnail_url"] = ExpressionConverter.ConvertO(bodythumbnailUrl);
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
        [WorkflowExpressionFactory(nameof(__BuildBroadcastDelete))]
        public IBodyWorkflowAction<string> BroadcastDelete([WorkflowExpression] Func<string> broadcastId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildBroadcastDelete(WorkflowExpression<string> broadcastId)
        {
            WorkflowExpression.Validate(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/broadcasts/{0}", ExpressionConverter.ConvertWithUrlEncoding(broadcastId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildBroadcastGetStat))]
        public IBodyWorkflowAction<BroadcastGetStatResponse> BroadcastGetStat([WorkflowExpression] Func<string> broadcastId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BroadcastGetStatResponse> __BuildBroadcastGetStat(WorkflowExpression<string> broadcastId)
        {
            WorkflowExpression.Validate(broadcastId, nameof(broadcastId), required: true);
            return new DeferredBodyAction<BroadcastGetStatResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/broadcasts/{0}/stats", ExpressionConverter.ConvertWithUrlEncoding(broadcastId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BroadcastGetStatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildPurchaseList))]
        public IBodyWorkflowAction<PurchaseListResponse> PurchaseList([WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PurchaseListResponse> __BuildPurchaseList(WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<PurchaseListResponse>(() =>
            {
                var apiCallPath = "/purchases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<PurchaseListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [WorkflowExpressionFactory(nameof(__BuildPurchaseAdd))]
        public IBodyWorkflowAction<PurchaseAddResponse> PurchaseAdd([WorkflowExpression] Func<string> bodypurchasetransactionId = null, [WorkflowExpression] Func<string> bodypurchaseemailAddress = null, [WorkflowExpression] Func<string> bodypurchasefirstName = null, [WorkflowExpression] Func<string> bodypurchasecurrency = null, [WorkflowExpression] Func<string> bodypurchasetransactionTime = null, [WorkflowExpression] Func<int> bodypurchasesubtotal = null, [WorkflowExpression] Func<int> bodypurchasetax = null, [WorkflowExpression] Func<int> bodypurchaseshipping = null, [WorkflowExpression] Func<int> bodypurchasediscount = null, [WorkflowExpression] Func<int> bodypurchasetotal = null, [WorkflowExpression] Func<string> bodypurchasestatus = null, [WorkflowExpression] Func<bodypurchaseproductsInputItem[]> bodypurchaseproducts = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PurchaseAddResponse> __BuildPurchaseAdd(WorkflowExpression<string> bodypurchasetransactionId = null, WorkflowExpression<string> bodypurchaseemailAddress = null, WorkflowExpression<string> bodypurchasefirstName = null, WorkflowExpression<string> bodypurchasecurrency = null, WorkflowExpression<string> bodypurchasetransactionTime = null, WorkflowExpression<int> bodypurchasesubtotal = null, WorkflowExpression<int> bodypurchasetax = null, WorkflowExpression<int> bodypurchaseshipping = null, WorkflowExpression<int> bodypurchasediscount = null, WorkflowExpression<int> bodypurchasetotal = null, WorkflowExpression<string> bodypurchasestatus = null, WorkflowExpression<bodypurchaseproductsInputItem[]> bodypurchaseproducts = null)
        {
            WorkflowExpression.Validate(bodypurchasetransactionId, nameof(bodypurchasetransactionId), required: false);
            WorkflowExpression.Validate(bodypurchaseemailAddress, nameof(bodypurchaseemailAddress), required: false);
            WorkflowExpression.Validate(bodypurchasefirstName, nameof(bodypurchasefirstName), required: false);
            WorkflowExpression.Validate(bodypurchasecurrency, nameof(bodypurchasecurrency), required: false);
            WorkflowExpression.Validate(bodypurchasetransactionTime, nameof(bodypurchasetransactionTime), required: false);
            WorkflowExpression.Validate(bodypurchasesubtotal, nameof(bodypurchasesubtotal), required: false);
            WorkflowExpression.Validate(bodypurchasetax, nameof(bodypurchasetax), required: false);
            WorkflowExpression.Validate(bodypurchaseshipping, nameof(bodypurchaseshipping), required: false);
            WorkflowExpression.Validate(bodypurchasediscount, nameof(bodypurchasediscount), required: false);
            WorkflowExpression.Validate(bodypurchasetotal, nameof(bodypurchasetotal), required: false);
            WorkflowExpression.Validate(bodypurchasestatus, nameof(bodypurchasestatus), required: false);
            WorkflowExpression.Validate(bodypurchaseproducts, nameof(bodypurchaseproducts), required: false);
            return new DeferredBodyAction<PurchaseAddResponse>(() =>
            {
                var apiCallPath = "/purchases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var purchaseObject = new JObject();
                var purchaseObjectpropCount = 0;
                if (bodypurchasetransactionId != null)
                {
                    purchaseObject["transaction_id"] = ExpressionConverter.ConvertO(bodypurchasetransactionId);
                    purchaseObjectpropCount++;
                }

                if (bodypurchaseemailAddress != null)
                {
                    purchaseObject["email_address"] = ExpressionConverter.ConvertO(bodypurchaseemailAddress);
                    purchaseObjectpropCount++;
                }

                if (bodypurchasefirstName != null)
                {
                    purchaseObject["first_name"] = ExpressionConverter.ConvertO(bodypurchasefirstName);
                    purchaseObjectpropCount++;
                }

                if (bodypurchasecurrency != null)
                {
                    purchaseObject["currency"] = ExpressionConverter.ConvertO(bodypurchasecurrency);
                    purchaseObjectpropCount++;
                }

                if (bodypurchasetransactionTime != null)
                {
                    purchaseObject["transaction_time"] = ExpressionConverter.ConvertO(bodypurchasetransactionTime);
                    purchaseObjectpropCount++;
                }

                if (bodypurchasesubtotal != null)
                {
                    purchaseObject["subtotal"] = ExpressionConverter.ConvertO(bodypurchasesubtotal);
                    purchaseObjectpropCount++;
                }

                if (bodypurchasetax != null)
                {
                    purchaseObject["tax"] = ExpressionConverter.ConvertO(bodypurchasetax);
                    purchaseObjectpropCount++;
                }

                if (bodypurchaseshipping != null)
                {
                    purchaseObject["shipping"] = ExpressionConverter.ConvertO(bodypurchaseshipping);
                    purchaseObjectpropCount++;
                }

                if (bodypurchasediscount != null)
                {
                    purchaseObject["discount"] = ExpressionConverter.ConvertO(bodypurchasediscount);
                    purchaseObjectpropCount++;
                }

                if (bodypurchasetotal != null)
                {
                    purchaseObject["total"] = ExpressionConverter.ConvertO(bodypurchasetotal);
                    purchaseObjectpropCount++;
                }

                if (bodypurchasestatus != null)
                {
                    purchaseObject["status"] = ExpressionConverter.ConvertO(bodypurchasestatus);
                    purchaseObjectpropCount++;
                }

                if (bodypurchaseproducts != null)
                {
                    purchaseObject["products"] = ExpressionConverter.ConvertO(bodypurchaseproducts);
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
        [WorkflowExpressionFactory(nameof(__BuildPurchaseGet))]
        public IBodyWorkflowAction<PurchaseGetResponse> PurchaseGet([WorkflowExpression] Func<string> purchaseId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PurchaseGetResponse> __BuildPurchaseGet(WorkflowExpression<string> purchaseId)
        {
            WorkflowExpression.Validate(purchaseId, nameof(purchaseId), required: true);
            return new DeferredBodyAction<PurchaseGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/purchases/{0}", ExpressionConverter.ConvertWithUrlEncoding(purchaseId, 1));
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

    public enum sortOrderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

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