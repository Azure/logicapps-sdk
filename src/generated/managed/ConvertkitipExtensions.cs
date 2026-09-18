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
        public IBodyWorkflowAction<FormSubAddResponse> FormSubAdd([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> formId, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<int[]> bodytags = null)
        {
            var apiCallPath = String.Format("/forms/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<FormSubListResponse> FormSubList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> formId, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<subscriberStateInput> subscriberState = null, [WorkflowExpression] Func<int> page = null)
        {
            var apiCallPath = String.Format("/forms/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
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
        public IBodyWorkflowAction<SequenceSubAddResponse> SequenceSubAdd([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> sequenceId, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<int[]> bodytags = null)
        {
            var apiCallPath = String.Format("/sequences/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(sequenceId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SequenceSubListResponse> SequenceSubList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> sequenceId, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<subscriberStateInput> subscriberState = null, [WorkflowExpression] Func<int> page = null)
        {
            var apiCallPath = String.Format("/sequences/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(sequenceId, 1));
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
        public IBodyWorkflowAction<TagAddResponse> TagAdd([WorkflowExpression] Func<string> bodytagname = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubResponse> TagSub([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tagId, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<int[]> bodytags = null)
        {
            var apiCallPath = String.Format("/tags/{0}/subscribe", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubRemoveResponse> TagSubRemove([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriberId, [WorkflowExpression] Func<string> tagId)
        {
            var apiCallPath = String.Format("/subscribers/{0}/tags/{1}", ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagSubRemoveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubRemoveEmailResponse> TagSubRemoveEmail([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tagId, [WorkflowExpression] Func<string> bodyemail)
        {
            var apiCallPath = String.Format("/tags/{0}/unsubscribe", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<TagSubListResponse> TagSubList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tagId, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<subscriberStateInput> subscriberState = null, [WorkflowExpression] Func<int> page = null)
        {
            var apiCallPath = String.Format("/tags/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberListResponse> SubscriberList([WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> updatedFrom = null, [WorkflowExpression] Func<string> updatedTo = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<string> emailAddress = null, [WorkflowExpression] Func<int> page = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberGetResponse> SubscriberGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriberId)
        {
            var apiCallPath = String.Format("/subscribers/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SubscriberGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberUpdateResponse> SubscriberUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriberId, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodyemailAddress = null)
        {
            var apiCallPath = String.Format("/subscribers/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberUnsubResponse> SubscriberUnsub([WorkflowExpression] Func<string> bodyemail)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<SubscriberTagsResponse> SubscriberTags([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> subscriberId)
        {
            var apiCallPath = String.Format("/subscribers/{0}/tags", ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SubscriberTagsResponse>(callPayload);
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
        public IBodyWorkflowAction<BroadcastAddResponse> BroadcastAdd([WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyemailLayoutTemplate = null, [WorkflowExpression] Func<bool> bodyPublic = null, [WorkflowExpression] Func<string> bodypublishedAt = null, [WorkflowExpression] Func<string> bodysendAt = null, [WorkflowExpression] Func<string> bodythumbnailAlt = null, [WorkflowExpression] Func<string> bodythumbnailUrl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastGetResponse> BroadcastGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> broadcastId)
        {
            var apiCallPath = String.Format("/broadcasts/{0}", ExpressionConverter.ConvertWithUrlEncoding(broadcastId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BroadcastGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastUpdateResponse> BroadcastUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> broadcastId, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyemailLayoutTemplate = null, [WorkflowExpression] Func<bool> bodyPublic = null, [WorkflowExpression] Func<string> bodypublishedAt = null, [WorkflowExpression] Func<string> bodysendAt = null, [WorkflowExpression] Func<string> bodythumbnailAlt = null, [WorkflowExpression] Func<string> bodythumbnailUrl = null)
        {
            var apiCallPath = String.Format("/broadcasts/{0}", ExpressionConverter.ConvertWithUrlEncoding(broadcastId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<string> BroadcastDelete([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> broadcastId)
        {
            var apiCallPath = String.Format("/broadcasts/{0}", ExpressionConverter.ConvertWithUrlEncoding(broadcastId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<BroadcastGetStatResponse> BroadcastGetStat([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> broadcastId)
        {
            var apiCallPath = String.Format("/broadcasts/{0}/stats", ExpressionConverter.ConvertWithUrlEncoding(broadcastId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BroadcastGetStatResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseListResponse> PurchaseList([WorkflowExpression] Func<int> page = null)
        {
            var apiCallPath = "/purchases";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<PurchaseListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseAddResponse> PurchaseAdd([WorkflowExpression] Func<string> bodypurchasetransactionId = null, [WorkflowExpression] Func<string> bodypurchaseemailAddress = null, [WorkflowExpression] Func<string> bodypurchasefirstName = null, [WorkflowExpression] Func<string> bodypurchasecurrency = null, [WorkflowExpression] Func<string> bodypurchasetransactionTime = null, [WorkflowExpression] Func<int> bodypurchasesubtotal = null, [WorkflowExpression] Func<int> bodypurchasetax = null, [WorkflowExpression] Func<int> bodypurchaseshipping = null, [WorkflowExpression] Func<int> bodypurchasediscount = null, [WorkflowExpression] Func<int> bodypurchasetotal = null, [WorkflowExpression] Func<string> bodypurchasestatus = null, [WorkflowExpression] Func<bodypurchaseproductsInputItem[]> bodypurchaseproducts = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "convertkitip")]
        public IBodyWorkflowAction<PurchaseGetResponse> PurchaseGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> purchaseId)
        {
            var apiCallPath = String.Format("/purchases/{0}", ExpressionConverter.ConvertWithUrlEncoding(purchaseId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PurchaseGetResponse>(callPayload);
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