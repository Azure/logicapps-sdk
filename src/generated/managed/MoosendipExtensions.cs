//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Moosendip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MoosendipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListActiveResponse> ListActive([WorkflowExpression] Func<int> page, [WorkflowExpression] Func<int> pageSize, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortMethod = null)
        {
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            SourceExpression.Validate(sortBy, nameof(sortBy), required: false);
            SourceExpression.Validate(sortMethod, nameof(sortMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(page, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageSize, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sortBy != null)
                    callPayload.Queries["SortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (sortMethod != null)
                    callPayload.Queries["SortMethod"] = SourceExpressionConverter.ConvertO(sortMethod);
                return callPayload;
            }

            return new ApiConnectionAction<ListActiveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListDetailsResponse> ListDetails([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<bool> withStatistics = null)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(withStatistics, nameof(withStatistics), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/details.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (withStatistics != null)
                    callPayload.Queries["WithStatistics"] = SourceExpressionConverter.ConvertO(withStatistics);
                return callPayload;
            }

            return new ApiConnectionAction<ListDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListCreateResponse> ListCreate([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyconfirmationPage = null, [WorkflowExpression] Func<string> bodyredirectAfterUnsubscribePage = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyconfirmationPage, nameof(bodyconfirmationPage), required: false);
            SourceExpression.Validate(bodyredirectAfterUnsubscribePage, nameof(bodyredirectAfterUnsubscribePage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyconfirmationPage != null)
                {
                    body["ConfirmationPage"] = SourceExpressionConverter.ConvertToken(bodyconfirmationPage);
                    bodypropCount++;
                }

                if (bodyredirectAfterUnsubscribePage != null)
                {
                    body["RedirectAfterUnsubscribePage"] = SourceExpressionConverter.ConvertToken(bodyredirectAfterUnsubscribePage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListUpdateResponse> ListUpdate([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyconfirmationPage = null, [WorkflowExpression] Func<string> bodyredirectAfterUnsubscribePage = null)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyconfirmationPage, nameof(bodyconfirmationPage), required: false);
            SourceExpression.Validate(bodyredirectAfterUnsubscribePage, nameof(bodyredirectAfterUnsubscribePage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/update.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyconfirmationPage != null)
                {
                    body["ConfirmationPage"] = SourceExpressionConverter.ConvertToken(bodyconfirmationPage);
                    bodypropCount++;
                }

                if (bodyredirectAfterUnsubscribePage != null)
                {
                    body["RedirectAfterUnsubscribePage"] = SourceExpressionConverter.ConvertToken(bodyredirectAfterUnsubscribePage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<ListDeleteResponse> ListDelete([WorkflowExpression] Func<string> mailingListId)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/delete.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldCreateResponse> FieldCreate([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycustomFieldType = null, [WorkflowExpression] Func<string> bodyoptions = null)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycustomFieldType, nameof(bodycustomFieldType), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/customfields/create.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycustomFieldType != null)
                {
                    body["CustomFieldType"] = SourceExpressionConverter.ConvertToken(bodycustomFieldType);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["Options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FieldCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldUpdateResponse> FieldUpdate([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycustomFieldType = null, [WorkflowExpression] Func<string> bodyoptions = null)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycustomFieldType, nameof(bodycustomFieldType), required: false);
            SourceExpression.Validate(bodyoptions, nameof(bodyoptions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/customfields/{1}/update.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycustomFieldType != null)
                {
                    body["CustomFieldType"] = SourceExpressionConverter.ConvertToken(bodycustomFieldType);
                    bodypropCount++;
                }

                if (bodyoptions != null)
                {
                    body["Options"] = SourceExpressionConverter.ConvertToken(bodyoptions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FieldUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<FieldDeleteResponse> FieldDelete([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> customFieldId)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(customFieldId, nameof(customFieldId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/customfields/{1}/delete.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FieldDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberListResponse> SubscriberList([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscribers/Subscribed.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberGetEmailResponse> SubscriberGetEmail([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/view.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberGetEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberGetIdResponse> SubscriberGetId([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> subscriberId)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(subscriberId, nameof(subscriberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/find/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberGetIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberAddResponse> SubscriberAdd([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<bool> bodyhasExternalDoubleOptIn = null, [WorkflowExpression] Func<string[]> bodycustomFields = null)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyhasExternalDoubleOptIn, nameof(bodyhasExternalDoubleOptIn), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/subscribe.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyhasExternalDoubleOptIn != null)
                {
                    body["HasExternalDoubleOptIn"] = SourceExpressionConverter.ConvertToken(bodyhasExternalDoubleOptIn);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["CustomFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberAddResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberAddBulkResponse> SubscriberAddBulk([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<bool> bodyhasExternalDoubleOptIn = null, [WorkflowExpression] Func<bodysubscribersInputItem[]> bodysubscribers = null)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(bodyhasExternalDoubleOptIn, nameof(bodyhasExternalDoubleOptIn), required: false);
            SourceExpression.Validate(bodysubscribers, nameof(bodysubscribers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/subscribe_many.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyhasExternalDoubleOptIn != null)
                {
                    body["HasExternalDoubleOptIn"] = SourceExpressionConverter.ConvertToken(bodyhasExternalDoubleOptIn);
                    bodypropCount++;
                }

                if (bodysubscribers != null)
                {
                    body["Subscribers"] = SourceExpressionConverter.ConvertToken(bodysubscribers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberAddBulkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SubscriberUpdateResponse> SubscriberUpdate([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> subscriberId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodyhasExternalDoubleOptIn = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string[]> bodycustomFields = null)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(subscriberId, nameof(subscriberId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyhasExternalDoubleOptIn, nameof(bodyhasExternalDoubleOptIn), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/update/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriberId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyhasExternalDoubleOptIn != null)
                {
                    body["HasExternalDoubleOptIn"] = SourceExpressionConverter.ConvertToken(bodyhasExternalDoubleOptIn);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["CustomFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeAccountResponse> UnsubscribeAccount([WorkflowExpression] Func<string> bodyemail)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribers/unsubscribe.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UnsubscribeAccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeListResponse> UnsubscribeList([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> bodyemail)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/unsubscribe.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UnsubscribeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeRemoveResponse> UnsubscribeRemove([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> bodyemail)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/remove.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UnsubscribeRemoveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<UnsubscribeRemoveBulkResponse> UnsubscribeRemoveBulk([WorkflowExpression] Func<string> mailingListId, [WorkflowExpression] Func<string> bodyemails)
        {
            SourceExpression.Validate(mailingListId, nameof(mailingListId), required: true);
            SourceExpression.Validate(bodyemails, nameof(bodyemails), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscribers/{0}/remove_many.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailingListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Emails"] = SourceExpressionConverter.ConvertToken(bodyemails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UnsubscribeRemoveBulkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignGetResponse> CampaignGet([WorkflowExpression] Func<string> page, [WorkflowExpression] Func<string> pageSize, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortMethod = null)
        {
            SourceExpression.Validate(page, nameof(page), required: true);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: true);
            SourceExpression.Validate(sortBy, nameof(sortBy), required: false);
            SourceExpression.Validate(sortMethod, nameof(sortMethod), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(page, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageSize, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sortBy != null)
                    callPayload.Queries["SortBy"] = SourceExpressionConverter.ConvertO(sortBy);
                if (sortMethod != null)
                    callPayload.Queries["SortMethod"] = SourceExpressionConverter.ConvertO(sortMethod);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignGetDetailsResponse> CampaignGetDetails([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/view.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignGetDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SenderGetResponse> SenderGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/senders/find_all.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SenderGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<SenderGetEmailResponse> SenderGetEmail([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/senders/find_one.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction<SenderGetEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignCloneResponse> CampaignClone([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/clone.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignCloneResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignCreateResponse> CampaignCreate([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodysenderEmail = null, [WorkflowExpression] Func<string> bodyreplyToEmail = null, [WorkflowExpression] Func<string> bodyconfirmationToEmail = null, [WorkflowExpression] Func<string> bodywebLocation = null, [WorkflowExpression] Func<bodymailingListsInputItem[]> bodymailingLists = null, [WorkflowExpression] Func<string> bodyisAB = null, [WorkflowExpression] Func<string> bodyaBCampaignType = null, [WorkflowExpression] Func<string> bodywebLocationB = null, [WorkflowExpression] Func<string> bodyhoursToTest = null, [WorkflowExpression] Func<string> bodylistPercentage = null, [WorkflowExpression] Func<string> bodyaBWinnerSelectionType = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodysenderEmail, nameof(bodysenderEmail), required: false);
            SourceExpression.Validate(bodyreplyToEmail, nameof(bodyreplyToEmail), required: false);
            SourceExpression.Validate(bodyconfirmationToEmail, nameof(bodyconfirmationToEmail), required: false);
            SourceExpression.Validate(bodywebLocation, nameof(bodywebLocation), required: false);
            SourceExpression.Validate(bodymailingLists, nameof(bodymailingLists), required: false);
            SourceExpression.Validate(bodyisAB, nameof(bodyisAB), required: false);
            SourceExpression.Validate(bodyaBCampaignType, nameof(bodyaBCampaignType), required: false);
            SourceExpression.Validate(bodywebLocationB, nameof(bodywebLocationB), required: false);
            SourceExpression.Validate(bodyhoursToTest, nameof(bodyhoursToTest), required: false);
            SourceExpression.Validate(bodylistPercentage, nameof(bodylistPercentage), required: false);
            SourceExpression.Validate(bodyaBWinnerSelectionType, nameof(bodyaBWinnerSelectionType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/campaigns/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["Subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodysenderEmail != null)
                {
                    body["SenderEmail"] = SourceExpressionConverter.ConvertToken(bodysenderEmail);
                    bodypropCount++;
                }

                if (bodyreplyToEmail != null)
                {
                    body["ReplyToEmail"] = SourceExpressionConverter.ConvertToken(bodyreplyToEmail);
                    bodypropCount++;
                }

                if (bodyconfirmationToEmail != null)
                {
                    body["ConfirmationToEmail"] = SourceExpressionConverter.ConvertToken(bodyconfirmationToEmail);
                    bodypropCount++;
                }

                if (bodywebLocation != null)
                {
                    body["WebLocation"] = SourceExpressionConverter.ConvertToken(bodywebLocation);
                    bodypropCount++;
                }

                if (bodymailingLists != null)
                {
                    body["MailingLists"] = SourceExpressionConverter.ConvertToken(bodymailingLists);
                    bodypropCount++;
                }

                if (bodyisAB != null)
                {
                    body["IsAB"] = SourceExpressionConverter.ConvertToken(bodyisAB);
                    bodypropCount++;
                }

                if (bodyaBCampaignType != null)
                {
                    body["ABCampaignType"] = SourceExpressionConverter.ConvertToken(bodyaBCampaignType);
                    bodypropCount++;
                }

                if (bodywebLocationB != null)
                {
                    body["WebLocationB"] = SourceExpressionConverter.ConvertToken(bodywebLocationB);
                    bodypropCount++;
                }

                if (bodyhoursToTest != null)
                {
                    body["HoursToTest"] = SourceExpressionConverter.ConvertToken(bodyhoursToTest);
                    bodypropCount++;
                }

                if (bodylistPercentage != null)
                {
                    body["ListPercentage"] = SourceExpressionConverter.ConvertToken(bodylistPercentage);
                    bodypropCount++;
                }

                if (bodyaBWinnerSelectionType != null)
                {
                    body["ABWinnerSelectionType"] = SourceExpressionConverter.ConvertToken(bodyaBWinnerSelectionType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CampaignCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignUpdateResponse> CampaignUpdate([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodysenderEmail = null, [WorkflowExpression] Func<string> bodyreplyToEmail = null, [WorkflowExpression] Func<string> bodyconfirmationToEmail = null, [WorkflowExpression] Func<string> bodywebLocation = null, [WorkflowExpression] Func<bodymailingListsInputItem[]> bodymailingLists = null, [WorkflowExpression] Func<string> bodyisAB = null, [WorkflowExpression] Func<string> bodyaBCampaignType = null, [WorkflowExpression] Func<string> bodywebLocationB = null, [WorkflowExpression] Func<string> bodyhoursToTest = null, [WorkflowExpression] Func<string> bodylistPercentage = null, [WorkflowExpression] Func<string> bodyaBWinnerSelectionType = null)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodysenderEmail, nameof(bodysenderEmail), required: false);
            SourceExpression.Validate(bodyreplyToEmail, nameof(bodyreplyToEmail), required: false);
            SourceExpression.Validate(bodyconfirmationToEmail, nameof(bodyconfirmationToEmail), required: false);
            SourceExpression.Validate(bodywebLocation, nameof(bodywebLocation), required: false);
            SourceExpression.Validate(bodymailingLists, nameof(bodymailingLists), required: false);
            SourceExpression.Validate(bodyisAB, nameof(bodyisAB), required: false);
            SourceExpression.Validate(bodyaBCampaignType, nameof(bodyaBCampaignType), required: false);
            SourceExpression.Validate(bodywebLocationB, nameof(bodywebLocationB), required: false);
            SourceExpression.Validate(bodyhoursToTest, nameof(bodyhoursToTest), required: false);
            SourceExpression.Validate(bodylistPercentage, nameof(bodylistPercentage), required: false);
            SourceExpression.Validate(bodyaBWinnerSelectionType, nameof(bodyaBWinnerSelectionType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/update.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["Subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodysenderEmail != null)
                {
                    body["SenderEmail"] = SourceExpressionConverter.ConvertToken(bodysenderEmail);
                    bodypropCount++;
                }

                if (bodyreplyToEmail != null)
                {
                    body["ReplyToEmail"] = SourceExpressionConverter.ConvertToken(bodyreplyToEmail);
                    bodypropCount++;
                }

                if (bodyconfirmationToEmail != null)
                {
                    body["ConfirmationToEmail"] = SourceExpressionConverter.ConvertToken(bodyconfirmationToEmail);
                    bodypropCount++;
                }

                if (bodywebLocation != null)
                {
                    body["WebLocation"] = SourceExpressionConverter.ConvertToken(bodywebLocation);
                    bodypropCount++;
                }

                if (bodymailingLists != null)
                {
                    body["MailingLists"] = SourceExpressionConverter.ConvertToken(bodymailingLists);
                    bodypropCount++;
                }

                if (bodyisAB != null)
                {
                    body["IsAB"] = SourceExpressionConverter.ConvertToken(bodyisAB);
                    bodypropCount++;
                }

                if (bodyaBCampaignType != null)
                {
                    body["ABCampaignType"] = SourceExpressionConverter.ConvertToken(bodyaBCampaignType);
                    bodypropCount++;
                }

                if (bodywebLocationB != null)
                {
                    body["WebLocationB"] = SourceExpressionConverter.ConvertToken(bodywebLocationB);
                    bodypropCount++;
                }

                if (bodyhoursToTest != null)
                {
                    body["HoursToTest"] = SourceExpressionConverter.ConvertToken(bodyhoursToTest);
                    bodypropCount++;
                }

                if (bodylistPercentage != null)
                {
                    body["ListPercentage"] = SourceExpressionConverter.ConvertToken(bodylistPercentage);
                    bodypropCount++;
                }

                if (bodyaBWinnerSelectionType != null)
                {
                    body["ABWinnerSelectionType"] = SourceExpressionConverter.ConvertToken(bodyaBWinnerSelectionType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CampaignUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignDeleteResponse> CampaignDelete([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/delete.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignTestResponse> CampaignTest([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<string[]> bodytestEmails)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            SourceExpression.Validate(bodytestEmails, nameof(bodytestEmails), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/send_test.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["TestEmails"] = SourceExpressionConverter.ConvertToken(bodytestEmails);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CampaignTestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignSendResponse> CampaignSend([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/send.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignSendResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignStatsResponse> CampaignStats([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> to = null)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/stats/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (from != null)
                    callPayload.Queries["From"] = SourceExpressionConverter.ConvertO(from);
                if (to != null)
                    callPayload.Queries["To"] = SourceExpressionConverter.ConvertO(to);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignStatsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignSummaryResponse> CampaignSummary([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/view_summary.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignActivityLocationResponse> CampaignActivityLocation([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/stats/countries.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignActivityLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignActivityLinkResponse> CampaignActivityLink([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/stats/links.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignActivityLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignScheduleResponse> CampaignSchedule([WorkflowExpression] Func<string> campaignId, [WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            SourceExpression.Validate(bodydateTime, nameof(bodydateTime), required: true);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/schedule.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["DateTime"] = SourceExpressionConverter.ConvertToken(bodydateTime);
                if (bodytimezone != null)
                {
                    body["Timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CampaignScheduleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignUnscheduleResponse> CampaignUnschedule([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/unschedule.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignUnscheduleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moosendip")]
        public IBodyWorkflowAction<CampaignABSummaryResponse> CampaignABSummary([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/view_ab_summary.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CampaignABSummaryResponse>(BuildSourceInput);
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
        public string ID { get; set; }
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public bool IsRequired { get; set; }
        public int Type { get; set; }
    }

    public class ListActiveResponseContextTypeMailingListsTypeItemImportOperationType
    {
        public int ID { get; set; }
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
        public string ID { get; set; }
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string Context { get; set; }
        public bool IsRequired { get; set; }
        public int Type { get; set; }
    }

    public class ListDetailsResponseContextTypeImportOperationType
    {
        public int ID { get; set; }
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberListResponseContextTypeSubscribersTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberListResponseContextTypeSubscribersTypeItemCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberGetEmailResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberGetEmailResponseContextTypeCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberAddResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberAddResponseContextTypeCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberAddBulkResponseContextTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberAddBulkResponseContextTypeItemCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string UnsubscribedOn { get; set; }
        public string UnsubscribedFromID { get; set; }
        public int SubscribeType { get; set; }
        public int SubscribeMethod { get; set; }
        public SubscriberUpdateResponseContextTypeCustomFieldsTypeItem[] CustomFields { get; set; }
        public string RemovedOn { get; set; }
    }

    public class SubscriberUpdateResponseContextTypeCustomFieldsTypeItem
    {
        public string CustomFieldID { get; set; }
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
        public string ID { get; set; }
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
        public string ID { get; set; }
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
        public string ID { get; set; }
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
        public string ID { get; set; }
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
        public string ID { get; set; }
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
        public string MailingListID { get; set; }
        public int SegmentID { get; set; }
    }

    public class SenderGetResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public SenderGetResponseContextTypeItem[] Context { get; set; }
    }

    public class SenderGetResponseContextTypeItem
    {
        public string ID { get; set; }
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
        public string ID { get; set; }
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
        public string ID { get; set; }
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
        public string ID { get; set; }
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
        public string ID { get; set; }
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
        public int ID { get; set; }
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
        public string MailingListID { get; set; }
        public int SegmentID { get; set; }
    }

    public class CampaignCreateResponse
    {
        public int Code { get; set; }
        public string Error { get; set; }
        public string Context { get; set; }
    }

    public class bodymailingListsInputItem
    {
        public string MailingListID { get; set; }
        public string SegmentID { get; set; }
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
        public string CampaignID { get; set; }
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
        public string MailingListID { get; set; }
        public int SegmentID { get; set; }
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
        public string CampaignID { get; set; }
        public CampaignABSummaryResponseContextTypeAType A { get; set; }
        public CampaignABSummaryResponseContextTypeBType B { get; set; }
    }

    public class CampaignABSummaryResponseContextTypeAType
    {
        public string CampaignID { get; set; }
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
        public string ID { get; set; }
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
        public string CampaignID { get; set; }
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
        public string ID { get; set; }
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