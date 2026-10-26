//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Moosendip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MoosendipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListActiveResponse, ApiConnectionActionConfiguration> ListActive(Expression<Func<int>> page, Expression<Func<int>> pageSize, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortMethod = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortMethod = WorkflowExpression.Compile(sortMethod, nameof(sortMethod), required: false);
            return new DeferredBodyAction<ListActiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/{1}.json", __workflow_page.WithUrlEncoding(1), __workflow_pageSize.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sortBy != null)
                    callPayload.Queries["SortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_sortMethod != null)
                    callPayload.Queries["SortMethod"] = ExpressionConverter.Convert(__workflow_sortMethod);
                return new ApiConnectionAction<ListActiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListDetailsResponse, ApiConnectionActionConfiguration> ListDetails(Expression<Func<string>> mailingListId, Expression<Func<bool>> withStatistics = null)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_withStatistics = WorkflowExpression.Compile(withStatistics, nameof(withStatistics), required: false);
            return new DeferredBodyAction<ListDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/details.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_withStatistics != null)
                    callPayload.Queries["WithStatistics"] = ExpressionConverter.Convert(__workflow_withStatistics);
                return new ApiConnectionAction<ListDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListCreateResponse, ApiConnectionActionConfiguration> ListCreate(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyconfirmationPage = null, Expression<Func<string>> bodyredirectAfterUnsubscribePage = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyconfirmationPage = WorkflowExpression.Compile(bodyconfirmationPage, nameof(bodyconfirmationPage), required: false);
            var __workflow_bodyredirectAfterUnsubscribePage = WorkflowExpression.Compile(bodyredirectAfterUnsubscribePage, nameof(bodyredirectAfterUnsubscribePage), required: false);
            return new DeferredBodyAction<ListCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationPage != null)
                {
                    body["ConfirmationPage"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationPage);
                    bodypropCount++;
                }

                if (__workflow_bodyredirectAfterUnsubscribePage != null)
                {
                    body["RedirectAfterUnsubscribePage"] = ExpressionConverter.ConvertO(__workflow_bodyredirectAfterUnsubscribePage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ListCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListUpdateResponse, ApiConnectionActionConfiguration> ListUpdate(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyconfirmationPage = null, Expression<Func<string>> bodyredirectAfterUnsubscribePage = null)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyconfirmationPage = WorkflowExpression.Compile(bodyconfirmationPage, nameof(bodyconfirmationPage), required: false);
            var __workflow_bodyredirectAfterUnsubscribePage = WorkflowExpression.Compile(bodyredirectAfterUnsubscribePage, nameof(bodyredirectAfterUnsubscribePage), required: false);
            return new DeferredBodyAction<ListUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/update.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationPage != null)
                {
                    body["ConfirmationPage"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationPage);
                    bodypropCount++;
                }

                if (__workflow_bodyredirectAfterUnsubscribePage != null)
                {
                    body["RedirectAfterUnsubscribePage"] = ExpressionConverter.ConvertO(__workflow_bodyredirectAfterUnsubscribePage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ListUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListDeleteResponse, ApiConnectionActionConfiguration> ListDelete(Expression<Func<string>> mailingListId)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            return new DeferredBodyAction<ListDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/delete.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldCreateResponse, ApiConnectionActionConfiguration> FieldCreate(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycustomFieldType = null, Expression<Func<string>> bodyoptions = null)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycustomFieldType = WorkflowExpression.Compile(bodycustomFieldType, nameof(bodycustomFieldType), required: false);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            return new DeferredBodyAction<FieldCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/customfields/create.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldType != null)
                {
                    body["CustomFieldType"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldType);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["Options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FieldCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldUpdateResponse, ApiConnectionActionConfiguration> FieldUpdate(Expression<Func<string>> mailingListId, Expression<Func<string>> customFieldId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycustomFieldType = null, Expression<Func<string>> bodyoptions = null)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycustomFieldType = WorkflowExpression.Compile(bodycustomFieldType, nameof(bodycustomFieldType), required: false);
            var __workflow_bodyoptions = WorkflowExpression.Compile(bodyoptions, nameof(bodyoptions), required: false);
            return new DeferredBodyAction<FieldUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/customfields/{1}/update.json", __workflow_mailingListId.WithUrlEncoding(1), __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldType != null)
                {
                    body["CustomFieldType"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldType);
                    bodypropCount++;
                }

                if (__workflow_bodyoptions != null)
                {
                    body["Options"] = ExpressionConverter.ConvertO(__workflow_bodyoptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FieldUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldDeleteResponse, ApiConnectionActionConfiguration> FieldDelete(Expression<Func<string>> mailingListId, Expression<Func<string>> customFieldId)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            return new DeferredBodyAction<FieldDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/customfields/{1}/delete.json", __workflow_mailingListId.WithUrlEncoding(1), __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FieldDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberListResponse, ApiConnectionActionConfiguration> SubscriberList(Expression<Func<string>> mailingListId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<SubscriberListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/subscribers/Subscribed.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<SubscriberListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberGetEmailResponse, ApiConnectionActionConfiguration> SubscriberGetEmail(Expression<Func<string>> mailingListId, Expression<Func<string>> email)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<SubscriberGetEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/view.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<SubscriberGetEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberGetIdResponse, ApiConnectionActionConfiguration> SubscriberGetId(Expression<Func<string>> mailingListId, Expression<Func<string>> subscriberId)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<SubscriberGetIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/find/{1}.json", __workflow_mailingListId.WithUrlEncoding(1), __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriberGetIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberAddResponse, ApiConnectionActionConfiguration> SubscriberAdd(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyemail = null, Expression<Func<bool>> bodyhasExternalDoubleOptIn = null, Expression<Func<string[]>> bodycustomFields = null)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyhasExternalDoubleOptIn = WorkflowExpression.Compile(bodyhasExternalDoubleOptIn, nameof(bodyhasExternalDoubleOptIn), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            return new DeferredBodyAction<SubscriberAddResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/subscribe.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyhasExternalDoubleOptIn != null)
                {
                    body["HasExternalDoubleOptIn"] = ExpressionConverter.ConvertO(__workflow_bodyhasExternalDoubleOptIn);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["CustomFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SubscriberAddResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberAddBulkResponse, ApiConnectionActionConfiguration> SubscriberAddBulk(Expression<Func<string>> mailingListId, Expression<Func<bool>> bodyhasExternalDoubleOptIn = null, Expression<Func<bodysubscribersInputItem[]>> bodysubscribers = null)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_bodyhasExternalDoubleOptIn = WorkflowExpression.Compile(bodyhasExternalDoubleOptIn, nameof(bodyhasExternalDoubleOptIn), required: false);
            var __workflow_bodysubscribers = WorkflowExpression.Compile(bodysubscribers, nameof(bodysubscribers), required: false);
            return new DeferredBodyAction<SubscriberAddBulkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/subscribe_many.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyhasExternalDoubleOptIn != null)
                {
                    body["HasExternalDoubleOptIn"] = ExpressionConverter.ConvertO(__workflow_bodyhasExternalDoubleOptIn);
                    bodypropCount++;
                }

                if (__workflow_bodysubscribers != null)
                {
                    body["Subscribers"] = ExpressionConverter.ConvertO(__workflow_bodysubscribers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SubscriberAddBulkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberUpdateResponse, ApiConnectionActionConfiguration> SubscriberUpdate(Expression<Func<string>> mailingListId, Expression<Func<string>> subscriberId, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyhasExternalDoubleOptIn = null, Expression<Func<string>> bodyemail = null, Expression<Func<string[]>> bodycustomFields = null)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyhasExternalDoubleOptIn = WorkflowExpression.Compile(bodyhasExternalDoubleOptIn, nameof(bodyhasExternalDoubleOptIn), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            return new DeferredBodyAction<SubscriberUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/update/{1}.json", __workflow_mailingListId.WithUrlEncoding(1), __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyhasExternalDoubleOptIn != null)
                {
                    body["HasExternalDoubleOptIn"] = ExpressionConverter.ConvertO(__workflow_bodyhasExternalDoubleOptIn);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["CustomFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SubscriberUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeAccountResponse, ApiConnectionActionConfiguration> UnsubscribeAccount(Expression<Func<string>> bodyemail)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<UnsubscribeAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscribers/unsubscribe.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UnsubscribeAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeListResponse, ApiConnectionActionConfiguration> UnsubscribeList(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyemail)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<UnsubscribeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/unsubscribe.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UnsubscribeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeRemoveResponse, ApiConnectionActionConfiguration> UnsubscribeRemove(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyemail)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<UnsubscribeRemoveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/remove.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UnsubscribeRemoveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeRemoveBulkResponse, ApiConnectionActionConfiguration> UnsubscribeRemoveBulk(Expression<Func<string>> mailingListId, Expression<Func<string>> bodyemails)
        {
            var __workflow_mailingListId = WorkflowExpression.Compile(mailingListId, nameof(mailingListId), required: true);
            var __workflow_bodyemails = WorkflowExpression.Compile(bodyemails, nameof(bodyemails), required: true);
            return new DeferredBodyAction<UnsubscribeRemoveBulkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscribers/{0}/remove_many.json", __workflow_mailingListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Emails"] = ExpressionConverter.ConvertO(__workflow_bodyemails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UnsubscribeRemoveBulkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignGetResponse, ApiConnectionActionConfiguration> CampaignGet(Expression<Func<string>> page, Expression<Func<string>> pageSize, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortMethod = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortMethod = WorkflowExpression.Compile(sortMethod, nameof(sortMethod), required: false);
            return new DeferredBodyAction<CampaignGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/{1}.json", __workflow_page.WithUrlEncoding(1), __workflow_pageSize.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sortBy != null)
                    callPayload.Queries["SortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_sortMethod != null)
                    callPayload.Queries["SortMethod"] = ExpressionConverter.Convert(__workflow_sortMethod);
                return new ApiConnectionAction<CampaignGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignGetDetailsResponse, ApiConnectionActionConfiguration> CampaignGetDetails(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignGetDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/view.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignGetDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SenderGetResponse, ApiConnectionActionConfiguration> SenderGet()
        {
            return new DeferredBodyAction<SenderGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/senders/find_all.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SenderGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SenderGetEmailResponse, ApiConnectionActionConfiguration> SenderGetEmail(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<SenderGetEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/senders/find_one.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction<SenderGetEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignCloneResponse, ApiConnectionActionConfiguration> CampaignClone(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignCloneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/clone.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignCloneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignCreateResponse, ApiConnectionActionConfiguration> CampaignCreate(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodysenderEmail = null, Expression<Func<string>> bodyreplyToEmail = null, Expression<Func<string>> bodyconfirmationToEmail = null, Expression<Func<string>> bodywebLocation = null, Expression<Func<bodymailingListsInputItem[]>> bodymailingLists = null, Expression<Func<string>> bodyisAB = null, Expression<Func<string>> bodyaBCampaignType = null, Expression<Func<string>> bodywebLocationB = null, Expression<Func<string>> bodyhoursToTest = null, Expression<Func<string>> bodylistPercentage = null, Expression<Func<string>> bodyaBWinnerSelectionType = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodysenderEmail = WorkflowExpression.Compile(bodysenderEmail, nameof(bodysenderEmail), required: false);
            var __workflow_bodyreplyToEmail = WorkflowExpression.Compile(bodyreplyToEmail, nameof(bodyreplyToEmail), required: false);
            var __workflow_bodyconfirmationToEmail = WorkflowExpression.Compile(bodyconfirmationToEmail, nameof(bodyconfirmationToEmail), required: false);
            var __workflow_bodywebLocation = WorkflowExpression.Compile(bodywebLocation, nameof(bodywebLocation), required: false);
            var __workflow_bodymailingLists = WorkflowExpression.Compile(bodymailingLists, nameof(bodymailingLists), required: false);
            var __workflow_bodyisAB = WorkflowExpression.Compile(bodyisAB, nameof(bodyisAB), required: false);
            var __workflow_bodyaBCampaignType = WorkflowExpression.Compile(bodyaBCampaignType, nameof(bodyaBCampaignType), required: false);
            var __workflow_bodywebLocationB = WorkflowExpression.Compile(bodywebLocationB, nameof(bodywebLocationB), required: false);
            var __workflow_bodyhoursToTest = WorkflowExpression.Compile(bodyhoursToTest, nameof(bodyhoursToTest), required: false);
            var __workflow_bodylistPercentage = WorkflowExpression.Compile(bodylistPercentage, nameof(bodylistPercentage), required: false);
            var __workflow_bodyaBWinnerSelectionType = WorkflowExpression.Compile(bodyaBWinnerSelectionType, nameof(bodyaBWinnerSelectionType), required: false);
            return new DeferredBodyAction<CampaignCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/campaigns/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["Subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodysenderEmail != null)
                {
                    body["SenderEmail"] = ExpressionConverter.ConvertO(__workflow_bodysenderEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyreplyToEmail != null)
                {
                    body["ReplyToEmail"] = ExpressionConverter.ConvertO(__workflow_bodyreplyToEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationToEmail != null)
                {
                    body["ConfirmationToEmail"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationToEmail);
                    bodypropCount++;
                }

                if (__workflow_bodywebLocation != null)
                {
                    body["WebLocation"] = ExpressionConverter.ConvertO(__workflow_bodywebLocation);
                    bodypropCount++;
                }

                if (__workflow_bodymailingLists != null)
                {
                    body["MailingLists"] = ExpressionConverter.ConvertO(__workflow_bodymailingLists);
                    bodypropCount++;
                }

                if (__workflow_bodyisAB != null)
                {
                    body["IsAB"] = ExpressionConverter.ConvertO(__workflow_bodyisAB);
                    bodypropCount++;
                }

                if (__workflow_bodyaBCampaignType != null)
                {
                    body["ABCampaignType"] = ExpressionConverter.ConvertO(__workflow_bodyaBCampaignType);
                    bodypropCount++;
                }

                if (__workflow_bodywebLocationB != null)
                {
                    body["WebLocationB"] = ExpressionConverter.ConvertO(__workflow_bodywebLocationB);
                    bodypropCount++;
                }

                if (__workflow_bodyhoursToTest != null)
                {
                    body["HoursToTest"] = ExpressionConverter.ConvertO(__workflow_bodyhoursToTest);
                    bodypropCount++;
                }

                if (__workflow_bodylistPercentage != null)
                {
                    body["ListPercentage"] = ExpressionConverter.ConvertO(__workflow_bodylistPercentage);
                    bodypropCount++;
                }

                if (__workflow_bodyaBWinnerSelectionType != null)
                {
                    body["ABWinnerSelectionType"] = ExpressionConverter.ConvertO(__workflow_bodyaBWinnerSelectionType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CampaignCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignUpdateResponse, ApiConnectionActionConfiguration> CampaignUpdate(Expression<Func<string>> campaignId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodysenderEmail = null, Expression<Func<string>> bodyreplyToEmail = null, Expression<Func<string>> bodyconfirmationToEmail = null, Expression<Func<string>> bodywebLocation = null, Expression<Func<bodymailingListsInputItem[]>> bodymailingLists = null, Expression<Func<string>> bodyisAB = null, Expression<Func<string>> bodyaBCampaignType = null, Expression<Func<string>> bodywebLocationB = null, Expression<Func<string>> bodyhoursToTest = null, Expression<Func<string>> bodylistPercentage = null, Expression<Func<string>> bodyaBWinnerSelectionType = null)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodysenderEmail = WorkflowExpression.Compile(bodysenderEmail, nameof(bodysenderEmail), required: false);
            var __workflow_bodyreplyToEmail = WorkflowExpression.Compile(bodyreplyToEmail, nameof(bodyreplyToEmail), required: false);
            var __workflow_bodyconfirmationToEmail = WorkflowExpression.Compile(bodyconfirmationToEmail, nameof(bodyconfirmationToEmail), required: false);
            var __workflow_bodywebLocation = WorkflowExpression.Compile(bodywebLocation, nameof(bodywebLocation), required: false);
            var __workflow_bodymailingLists = WorkflowExpression.Compile(bodymailingLists, nameof(bodymailingLists), required: false);
            var __workflow_bodyisAB = WorkflowExpression.Compile(bodyisAB, nameof(bodyisAB), required: false);
            var __workflow_bodyaBCampaignType = WorkflowExpression.Compile(bodyaBCampaignType, nameof(bodyaBCampaignType), required: false);
            var __workflow_bodywebLocationB = WorkflowExpression.Compile(bodywebLocationB, nameof(bodywebLocationB), required: false);
            var __workflow_bodyhoursToTest = WorkflowExpression.Compile(bodyhoursToTest, nameof(bodyhoursToTest), required: false);
            var __workflow_bodylistPercentage = WorkflowExpression.Compile(bodylistPercentage, nameof(bodylistPercentage), required: false);
            var __workflow_bodyaBWinnerSelectionType = WorkflowExpression.Compile(bodyaBWinnerSelectionType, nameof(bodyaBWinnerSelectionType), required: false);
            return new DeferredBodyAction<CampaignUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/update.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["Subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodysenderEmail != null)
                {
                    body["SenderEmail"] = ExpressionConverter.ConvertO(__workflow_bodysenderEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyreplyToEmail != null)
                {
                    body["ReplyToEmail"] = ExpressionConverter.ConvertO(__workflow_bodyreplyToEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationToEmail != null)
                {
                    body["ConfirmationToEmail"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationToEmail);
                    bodypropCount++;
                }

                if (__workflow_bodywebLocation != null)
                {
                    body["WebLocation"] = ExpressionConverter.ConvertO(__workflow_bodywebLocation);
                    bodypropCount++;
                }

                if (__workflow_bodymailingLists != null)
                {
                    body["MailingLists"] = ExpressionConverter.ConvertO(__workflow_bodymailingLists);
                    bodypropCount++;
                }

                if (__workflow_bodyisAB != null)
                {
                    body["IsAB"] = ExpressionConverter.ConvertO(__workflow_bodyisAB);
                    bodypropCount++;
                }

                if (__workflow_bodyaBCampaignType != null)
                {
                    body["ABCampaignType"] = ExpressionConverter.ConvertO(__workflow_bodyaBCampaignType);
                    bodypropCount++;
                }

                if (__workflow_bodywebLocationB != null)
                {
                    body["WebLocationB"] = ExpressionConverter.ConvertO(__workflow_bodywebLocationB);
                    bodypropCount++;
                }

                if (__workflow_bodyhoursToTest != null)
                {
                    body["HoursToTest"] = ExpressionConverter.ConvertO(__workflow_bodyhoursToTest);
                    bodypropCount++;
                }

                if (__workflow_bodylistPercentage != null)
                {
                    body["ListPercentage"] = ExpressionConverter.ConvertO(__workflow_bodylistPercentage);
                    bodypropCount++;
                }

                if (__workflow_bodyaBWinnerSelectionType != null)
                {
                    body["ABWinnerSelectionType"] = ExpressionConverter.ConvertO(__workflow_bodyaBWinnerSelectionType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CampaignUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignDeleteResponse, ApiConnectionActionConfiguration> CampaignDelete(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/delete.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignTestResponse, ApiConnectionActionConfiguration> CampaignTest(Expression<Func<string>> campaignId, Expression<Func<string[]>> bodytestEmails)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            var __workflow_bodytestEmails = WorkflowExpression.Compile(bodytestEmails, nameof(bodytestEmails), required: true);
            return new DeferredBodyAction<CampaignTestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/send_test.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["TestEmails"] = ExpressionConverter.ConvertO(__workflow_bodytestEmails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CampaignTestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignSendResponse, ApiConnectionActionConfiguration> CampaignSend(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignSendResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/send.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignSendResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignStatsResponse, ApiConnectionActionConfiguration> CampaignStats(Expression<Func<string>> campaignId, Expression<Func<typeInput>> type, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredBodyAction<CampaignStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/stats/{1}.json", __workflow_campaignId.WithUrlEncoding(1), __workflow_type.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_from != null)
                    callPayload.Queries["From"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["To"] = ExpressionConverter.Convert(__workflow_to);
                return new ApiConnectionAction<CampaignStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignSummaryResponse, ApiConnectionActionConfiguration> CampaignSummary(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/view_summary.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignSummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignActivityLocationResponse, ApiConnectionActionConfiguration> CampaignActivityLocation(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignActivityLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/stats/countries.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignActivityLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignActivityLinkResponse, ApiConnectionActionConfiguration> CampaignActivityLink(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignActivityLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/stats/links.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignActivityLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignScheduleResponse, ApiConnectionActionConfiguration> CampaignSchedule(Expression<Func<string>> campaignId, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodytimezone = null)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            var __workflow_bodydateTime = WorkflowExpression.Compile(bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            return new DeferredBodyAction<CampaignScheduleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/schedule.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["DateTime"] = ExpressionConverter.ConvertO(__workflow_bodydateTime);
                if (__workflow_bodytimezone != null)
                {
                    body["Timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CampaignScheduleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignUnscheduleResponse, ApiConnectionActionConfiguration> CampaignUnschedule(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignUnscheduleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/unschedule.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignUnscheduleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignABSummaryResponse, ApiConnectionActionConfiguration> CampaignABSummary(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredBodyAction<CampaignABSummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/view_ab_summary.json", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CampaignABSummaryResponse>(callPayload);
            });
        }
    }

    public class MoosendipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListActiveResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public ListActiveResponseContextType Context { get; set; }
    }

    public class ListActiveResponseContextType
    {
        public ListActiveResponseContextTypePagingType Paging { get; set; }
        public ListActiveResponseContextTypeMailingListsTypeItem[] MailingLists { get; set; }
    }

    public class ListActiveResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class ListActiveResponseContextTypeMailingListsTypeItem
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public ListActiveResponseContextTypeMailingListsTypeItemCustomFieldsDefinitionTypeItem[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public ListActiveResponseContextTypeMailingListsTypeItemImportOperationType ImportOperation { get; set; }
    }

    public class ListActiveResponseContextTypeMailingListsTypeItemCustomFieldsDefinitionTypeItem
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public bool IsRequired { get; set; }
        public int Type { get; set; }
    }

    public class ListActiveResponseContextTypeMailingListsTypeItemImportOperationType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string DataHash { get; set; }
        public string Mappings { get; set; }
        public string EmailNotify { get; set; }
        public string CreatedOn { get; set; }
        public string StartedOn { get; set; }
        public string CompletedOn { get; set; }
        public int TotalInserted { get; set; }
        public int TotalUpdated { get; set; }
        public int TotalUnsubscribed { get; set; }
        public int TotalInvalid { get; set; }
        public int TotalDuplicate { get; set; }
        public int TotalMembers { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }

    public class ListDetailsResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public ListDetailsResponseContextType Context { get; set; }
    }

    public class ListDetailsResponseContextType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public ListDetailsResponseContextTypeCustomFieldsDefinitionTypeItem[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public ListDetailsResponseContextTypeImportOperationType ImportOperation { get; set; }
    }

    public class ListDetailsResponseContextTypeCustomFieldsDefinitionTypeItem
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public bool IsRequired { get; set; }
        public int Type { get; set; }
    }

    public class ListDetailsResponseContextTypeImportOperationType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string DataHash { get; set; }
        public string Mappings { get; set; }
        public string EmailNotify { get; set; }
        public string CreatedOn { get; set; }
        public string StartedOn { get; set; }
        public string CompletedOn { get; set; }
        public int TotalInserted { get; set; }
        public int TotalUpdated { get; set; }
        public int TotalUnsubscribed { get; set; }
        public int TotalInvalid { get; set; }
        public int TotalIgnored { get; set; }
        public int TotalDuplicate { get; set; }
        public int TotalMembers { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public bool SkipNewMembers { get; set; }
    }

    public class ListCreateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class ListUpdateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class ListDeleteResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class FieldCreateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class FieldUpdateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class FieldDeleteResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class SubscriberListResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberListResponseContextType Context { get; set; }
    }

    public class SubscriberListResponseContextType
    {
        public SubscriberListResponseContextTypePagingType Paging { get; set; }
        public SubscriberListResponseContextTypeSubscribersTypeItem[] Subscribers { get; set; }
    }

    public class SubscriberListResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class SubscriberListResponseContextTypeSubscribersTypeItem
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }

        [JsonProperty("UnsubscribedFromID")]
        public string UnsubscribedFromId { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberListResponseContextTypeSubscribersTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberListResponseContextTypeSubscribersTypeItemCustomFieldsTypeItem
    {
        [JsonProperty("CustomFieldID")]
        public string CustomFieldId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SubscriberGetEmailResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberGetEmailResponseContextType Context { get; set; }
    }

    public class SubscriberGetEmailResponseContextType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }

        [JsonProperty("UnsubscribedFromID")]
        public string UnsubscribedFromId { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberGetEmailResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberGetEmailResponseContextTypeCustomFieldsTypeItem
    {
        [JsonProperty("CustomFieldID")]
        public string CustomFieldId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SubscriberGetIdResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberGetIdResponseContextType Context { get; set; }
    }

    public class SubscriberGetIdResponseContextType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }

        [JsonProperty("UnsubscribedFromID")]
        public string UnsubscribedFromId { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public JToken[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberAddResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberAddResponseContextType Context { get; set; }
    }

    public class SubscriberAddResponseContextType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }

        [JsonProperty("UnsubscribedFromID")]
        public string UnsubscribedFromId { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberAddResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberAddResponseContextTypeCustomFieldsTypeItem
    {
        [JsonProperty("CustomFieldID")]
        public string CustomFieldId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SubscriberAddBulkResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberAddBulkResponseContextTypeItem[] Context { get; set; }
    }

    public class SubscriberAddBulkResponseContextTypeItem
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }

        [JsonProperty("UnsubscribedFromID")]
        public string UnsubscribedFromId { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberAddBulkResponseContextTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberAddBulkResponseContextTypeItemCustomFieldsTypeItem
    {
        [JsonProperty("CustomFieldID")]
        public string CustomFieldId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class bodysubscribersInputItem
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string[] CustomFields { get; set; }
    }

    public class SubscriberUpdateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SubscriberUpdateResponseContextType Context { get; set; }
    }

    public class SubscriberUpdateResponseContextType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }

        [JsonProperty("UnsubscribedFromID")]
        public string UnsubscribedFromId { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberUpdateResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberUpdateResponseContextTypeCustomFieldsTypeItem
    {
        [JsonProperty("CustomFieldID")]
        public string CustomFieldId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class UnsubscribeAccountResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class UnsubscribeListResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class UnsubscribeRemoveResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class UnsubscribeRemoveBulkResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public UnsubscribeRemoveBulkResponseContextType Context { get; set; }
    }

    public class UnsubscribeRemoveBulkResponseContextType
    {
        public int EmailsIgnored { get; set; }
        public int EmailsProcessed { get; set; }
    }

    public class CampaignGetResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignGetResponseContextType Context { get; set; }
    }

    public class CampaignGetResponseContextType
    {
        public CampaignGetResponseContextTypePagingType Paging { get; set; }
        public CampaignGetResponseContextTypeCampaignsTypeItem[] Campaigns { get; set; }
    }

    public class CampaignGetResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class CampaignGetResponseContextTypeCampaignsTypeItem
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string SiteName { get; set; }
        public string ConfirmationTo { get; set; }
        public string CreatedOn { get; set; }
        public string ABHoursToTest { get; set; }
        public string ABCampaignType { get; set; }
        public string ABWinner { get; set; }
        public string ABWinnerSelectionType { get; set; }
        public int Status { get; set; }
        public string DeliveredOn { get; set; }
        public string ScheduledFor { get; set; }
        public string ScheduledForTimezone { get; set; }
        public CampaignGetResponseContextTypeCampaignsTypeItemMailingListsTypeItem[] MailingLists { get; set; }
        public int TotalSent { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalBounces { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalLinkClicks { get; set; }
        public int UniqueLinkClicks { get; set; }
        public int RecipientsCount { get; set; }
        public bool IsTransactional { get; set; }
        public int TotalComplaints { get; set; }
        public int TotalUnsubscribes { get; set; }
    }

    public class CampaignGetResponseContextTypeCampaignsTypeItemMailingListsTypeItem
    {
        public string Campaign { get; set; }
        public CampaignGetResponseContextTypeCampaignsTypeItemMailingListsTypeItemMailingListType MailingList { get; set; }
        public string Segment { get; set; }
    }

    public class CampaignGetResponseContextTypeCampaignsTypeItemMailingListsTypeItemMailingListType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public JToken[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string ImportOperation { get; set; }
    }

    public class CampaignGetDetailsResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignGetDetailsResponseContextType Context { get; set; }
    }

    public class CampaignGetDetailsResponseContextType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string WebLocation { get; set; }
        public string HTMLContent { get; set; }
        public string PlainContent { get; set; }
        public CampaignGetDetailsResponseContextTypeSenderType Sender { get; set; }
        public string DeliveredOn { get; set; }
        public CampaignGetDetailsResponseContextTypeReplyToEmailType ReplyToEmail { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string ScheduledFor { get; set; }
        public string Timezone { get; set; }
        public int FormatType { get; set; }
        public string ABCampaignData { get; set; }
        public CampaignGetDetailsResponseContextTypeMailingListsTypeItem[] MailingLists { get; set; }
        public string ConfirmationTo { get; set; }
        public int Status { get; set; }
        public bool IsTransactional { get; set; }
    }

    public class CampaignGetDetailsResponseContextTypeSenderType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignGetDetailsResponseContextTypeReplyToEmailType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignGetDetailsResponseContextTypeMailingListsTypeItem
    {
        [JsonProperty("MailingListID")]
        public string MailingListId { get; set; }

        [JsonProperty("SegmentID")]
        public int SegmentId { get; set; }
    }

    public class SenderGetResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SenderGetResponseContextTypeItem[] Context { get; set; }
    }

    public class SenderGetResponseContextTypeItem
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class SenderGetEmailResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SenderGetEmailResponseContextType Context { get; set; }
    }

    public class SenderGetEmailResponseContextType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignCloneResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignCloneResponseContextType Context { get; set; }
    }

    public class CampaignCloneResponseContextType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string WebLocation { get; set; }
        public string HTMLContent { get; set; }
        public string PlainContent { get; set; }
        public CampaignCloneResponseContextTypeSenderType Sender { get; set; }
        public string DeliveredOn { get; set; }
        public CampaignCloneResponseContextTypeReplyToEmailType ReplyToEmail { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string ScheduledFor { get; set; }
        public string Timezone { get; set; }
        public int FormatType { get; set; }
        public CampaignCloneResponseContextTypeABCampaignDataType ABCampaignData { get; set; }
        public CampaignCloneResponseContextTypeMailingListsTypeItem[] MailingLists { get; set; }
        public string ConfirmationTo { get; set; }
        public int Status { get; set; }
        public bool IsTransactional { get; set; }
    }

    public class CampaignCloneResponseContextTypeSenderType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignCloneResponseContextTypeReplyToEmailType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public bool IsEnabled { get; set; }
        public bool SpfVerified { get; set; }
        public bool DkimVerified { get; set; }
        public string DkimPublic { get; set; }
    }

    public class CampaignCloneResponseContextTypeABCampaignDataType
    {
        [JsonProperty("ID")]
        public int Id { get; set; }
        public string SubjectB { get; set; }
        public string PlainContentB { get; set; }
        public string HTMLContentB { get; set; }
        public string WebLocationB { get; set; }
        public string SenderB { get; set; }
        public int HoursToTest { get; set; }
        public int ListPercentage { get; set; }
        public int ABCampaignType { get; set; }
        public int ABWinnerSelectionType { get; set; }
        public string DeliveredOnA { get; set; }
        public string DeliveredOnB { get; set; }
    }

    public class CampaignCloneResponseContextTypeMailingListsTypeItem
    {
        [JsonProperty("MailingListID")]
        public string MailingListId { get; set; }

        [JsonProperty("SegmentID")]
        public int SegmentId { get; set; }
    }

    public class CampaignCreateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class bodymailingListsInputItem
    {
        [JsonProperty("MailingListID")]
        public string MailingListId { get; set; }

        [JsonProperty("SegmentID")]
        public string SegmentId { get; set; }
    }

    public class CampaignUpdateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignDeleteResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignTestResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignSendResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignStatsResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignStatsResponseContextType Context { get; set; }
    }

    public class CampaignStatsResponseContextType
    {
        public CampaignStatsResponseContextTypePagingType Paging { get; set; }
        public CampaignStatsResponseContextTypeAnalyticsTypeItem[] Analytics { get; set; }
    }

    public class CampaignStatsResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class CampaignStatsResponseContextTypeAnalyticsTypeItem
    {
        public string Context { get; set; }
        public string ContextName { get; set; }
        public int TotalCount { get; set; }
        public int UniqueCount { get; set; }
        public string ContextDescription { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        Sent,
        Opened,
        LinkClicked,
        Forward,
        Unsubscribed,
        Bounced,
        Complained
    }

    public class CampaignSummaryResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignSummaryResponseContextType Context { get; set; }
    }

    public class CampaignSummaryResponseContextType
    {
        [JsonProperty("CampaignID")]
        public string CampaignId { get; set; }
        public string ABVersion { get; set; }
        public string CampaignName { get; set; }
        public string CampaignSubject { get; set; }
        public CampaignSummaryResponseContextTypeMailingListsTypeItem[] MailingLists { get; set; }
        public string CampaignDeliveredOn { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalBounces { get; set; }
        public int TotalComplaints { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalUnsubscribes { get; set; }
        public int TotalLinkClicks { get; set; }
        public int UniqueLinkClicks { get; set; }
        public int Sent { get; set; }
        public bool CampaignIsArchived { get; set; }
    }

    public class CampaignSummaryResponseContextTypeMailingListsTypeItem
    {
        [JsonProperty("MailingListID")]
        public string MailingListId { get; set; }

        [JsonProperty("SegmentID")]
        public int SegmentId { get; set; }
    }

    public class CampaignActivityLocationResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignActivityLocationResponseContextType Context { get; set; }
    }

    public class CampaignActivityLocationResponseContextType
    {
        public CampaignActivityLocationResponseContextTypePagingType Paging { get; set; }
        public CampaignActivityLocationResponseContextTypeAnalyticsTypeItem[] Analytics { get; set; }
    }

    public class CampaignActivityLocationResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class CampaignActivityLocationResponseContextTypeAnalyticsTypeItem
    {
        public string Context { get; set; }
        public string ContextName { get; set; }
        public int TotalCount { get; set; }
        public int UniqueCount { get; set; }
        public string ContextDescription { get; set; }
    }

    public class CampaignActivityLinkResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignActivityLinkResponseContextType Context { get; set; }
    }

    public class CampaignActivityLinkResponseContextType
    {
        public CampaignActivityLinkResponseContextTypePagingType Paging { get; set; }
        public CampaignActivityLinkResponseContextTypeAnalyticsTypeItem[] Analytics { get; set; }
    }

    public class CampaignActivityLinkResponseContextTypePagingType
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int TotalPageCount { get; set; }
        public string SortExpression { get; set; }
        public bool SortIsAscending { get; set; }
    }

    public class CampaignActivityLinkResponseContextTypeAnalyticsTypeItem
    {
        public string Context { get; set; }
        public string ContextName { get; set; }
        public int TotalCount { get; set; }
        public int UniqueCount { get; set; }
        public string ContextDescription { get; set; }
    }

    public class CampaignScheduleResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignUnscheduleResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class CampaignABSummaryResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public CampaignABSummaryResponseContextType Context { get; set; }
    }

    public class CampaignABSummaryResponseContextType
    {
        [JsonProperty("CampaignID")]
        public string CampaignId { get; set; }
        public CampaignABSummaryResponseContextTypeAType A { get; set; }
        public CampaignABSummaryResponseContextTypeBType B { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeAType
    {
        [JsonProperty("CampaignID")]
        public string CampaignId { get; set; }
        public int ABVersion { get; set; }
        public string CampaignName { get; set; }
        public string CampaignSubject { get; set; }
        public CampaignABSummaryResponseContextTypeATypeMailingListsTypeItem[] MailingLists { get; set; }
        public string CampaignDeliveredOn { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalBounces { get; set; }
        public int TotalComplaints { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalUnsubscribes { get; set; }
        public int TotalLinkClicks { get; set; }
        public int UniqueLinkClicks { get; set; }
        public int Sent { get; set; }
        public bool CampaignIsArchived { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeATypeMailingListsTypeItem
    {
        public string Campaign { get; set; }
        public CampaignABSummaryResponseContextTypeATypeMailingListsTypeItemMailingListType MailingList { get; set; }
        public string Segment { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeATypeMailingListsTypeItemMailingListType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public JToken[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string ImportOperation { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeBType
    {
        [JsonProperty("CampaignID")]
        public string CampaignId { get; set; }
        public int ABVersion { get; set; }
        public string CampaignName { get; set; }
        public string CampaignSubject { get; set; }
        public CampaignABSummaryResponseContextTypeBTypeMailingListsTypeItem[] MailingLists { get; set; }
        public string CampaignDeliveredOn { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int TotalOpens { get; set; }
        public int UniqueOpens { get; set; }
        public int TotalBounces { get; set; }
        public int TotalComplaints { get; set; }
        public int TotalForwards { get; set; }
        public int UniqueForwards { get; set; }
        public int TotalUnsubscribes { get; set; }
        public int TotalLinkClicks { get; set; }
        public int UniqueLinkClicks { get; set; }
        public int Sent { get; set; }
        public bool CampaignIsArchived { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeBTypeMailingListsTypeItem
    {
        public string Campaign { get; set; }
        public CampaignABSummaryResponseContextTypeBTypeMailingListsTypeItemMailingListType MailingList { get; set; }
        public string Segment { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeBTypeMailingListsTypeItemMailingListType
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public int ActiveMemberCount { get; set; }
        public int BouncedMemberCount { get; set; }
        public int RemovedMemberCount { get; set; }
        public int UnsubscribedMemberCount { get; set; }
        public int Status { get; set; }
        public JToken[] CustomFieldsDefinition { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string ImportOperation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Moosendip;

    public partial class WorkflowManagedActions
    {
        public MoosendipActions Moosendip(string connectionId) => new MoosendipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MoosendipTriggers Moosendip(string connectionId) => new MoosendipTriggers(connectionId);
    }
}