//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Netvolution
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NetvolutionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IBodyWorkflowAction<GetEmailTemplatesResponse> GetEmailTemplates()
        {
            var apiCallPath = "/cdp/mail/list-templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEmailTemplatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        [WorkflowExpressionFactory(nameof(__BuildGetOrder))]
        public IWorkflowAction GetOrder([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> since)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetOrder(WorkflowExpression<string> contactId, WorkflowExpression<string> since)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            WorkflowExpression.Validate(since, nameof(since), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cdp/orders/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        [WorkflowExpressionFactory(nameof(__BuildGetContactIDFromSuppressionList))]
        public IWorkflowAction GetContactIDFromSuppressionList([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> listName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetContactIDFromSuppressionList(WorkflowExpression<string> contactId, WorkflowExpression<string> listName)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            WorkflowExpression.Validate(listName, nameof(listName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/cdp/suppression/check";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contactId"] = ExpressionConverter.Convert(contactId);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        [WorkflowExpressionFactory(nameof(__BuildPutContactIDToSuppresionList))]
        public IWorkflowAction PutContactIDToSuppresionList([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> listName, [WorkflowExpression] Func<string> timeSpan)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutContactIDToSuppresionList(WorkflowExpression<string> contactId, WorkflowExpression<string> listName, WorkflowExpression<string> timeSpan)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            WorkflowExpression.Validate(listName, nameof(listName), required: true);
            WorkflowExpression.Validate(timeSpan, nameof(timeSpan), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/cdp/suppression/add";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contactId"] = ExpressionConverter.Convert(contactId);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
                callPayload.Queries["timeSpan"] = ExpressionConverter.Convert(timeSpan);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        [WorkflowExpressionFactory(nameof(__BuildSendMail))]
        public IWorkflowAction SendMail([WorkflowExpression] Func<string> cdpContactId = null, [WorkflowExpression] Func<string> languageId = null, [WorkflowExpression] Func<string> emailTemplate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendMail(WorkflowExpression<string> cdpContactId = null, WorkflowExpression<string> languageId = null, WorkflowExpression<string> emailTemplate = null)
        {
            WorkflowExpression.Validate(cdpContactId, nameof(cdpContactId), required: false);
            WorkflowExpression.Validate(languageId, nameof(languageId), required: false);
            WorkflowExpression.Validate(emailTemplate, nameof(emailTemplate), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/cdp/mail/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cdpContactId != null)
                    callPayload.Queries["cdpContactId"] = ExpressionConverter.Convert(cdpContactId);
                if (languageId != null)
                    callPayload.Queries["languageId"] = ExpressionConverter.Convert(languageId);
                if (emailTemplate != null)
                    callPayload.Queries["emailTemplate"] = ExpressionConverter.Convert(emailTemplate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        [WorkflowExpressionFactory(nameof(__BuildCheckEvent))]
        public IBodyWorkflowAction<CheckEventResponse> CheckEvent([WorkflowExpression] Func<eventNameInput> eventName = null, [WorkflowExpression] Func<string> contactId = null, [WorkflowExpression] Func<string> since = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckEventResponse> __BuildCheckEvent(WorkflowExpression<eventNameInput> eventName = null, WorkflowExpression<string> contactId = null, WorkflowExpression<string> since = null)
        {
            WorkflowExpression.Validate(eventName, nameof(eventName), required: false);
            WorkflowExpression.Validate(contactId, nameof(contactId), required: false);
            WorkflowExpression.Validate(since, nameof(since), required: false);
            return new DeferredBodyAction<CheckEventResponse>(() =>
            {
                var apiCallPath = "/cdp/events/checkevent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (eventName != null)
                    callPayload.Queries["eventName"] = ExpressionConverter.Convert(eventName);
                if (contactId != null)
                    callPayload.Queries["contactId"] = ExpressionConverter.Convert(contactId);
                if (since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(since);
                return new ApiConnectionAction<CheckEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        [WorkflowExpressionFactory(nameof(__BuildGetWishList))]
        public IBodyWorkflowAction<GetWishListResponse> GetWishList([WorkflowExpression] Func<string> since)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWishListResponse> __BuildGetWishList(WorkflowExpression<string> since)
        {
            WorkflowExpression.Validate(since, nameof(since), required: true);
            return new DeferredBodyAction<GetWishListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cdp/wishlist/{0}", ExpressionConverter.ConvertWithUrlEncoding(since, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWishListResponse>(callPayload);
            });
        }
    }

    public class NetvolutionTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewEvent))]
        public IBodyWorkflowTrigger<OnNewEventResponse> OnNewEvent([WorkflowExpression] Func<eventNameInput> eventName,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewEventResponse> __BuildOnNewEvent(WorkflowExpression<eventNameInput> eventName,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventName, nameof(eventName), required: true);
            return new DeferredBodyTrigger<OnNewEventResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/cdp/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(eventName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OnNewEventResponse>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewUserInSegment))]
        public IBodyWorkflowTrigger<OnNewUserInSegmentResponse> OnNewUserInSegment([WorkflowExpression] Func<string> id,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OnNewUserInSegmentResponse> __BuildOnNewUserInSegment(WorkflowExpression<string> id,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyTrigger<OnNewUserInSegmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/cdp/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OnNewUserInSegmentResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetEmailTemplatesResponse
    {
        public bool Message { get; set; }
        public int Results { get; set; }
    }

    public class CheckEventResponse
    {
        public bool Message { get; set; }
        public int Results { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum eventNameInput
    {
        [EnumMember(Value = "add_to_cart")]
        AddToCart,
        [EnumMember(Value = "view_page")]
        ViewPage,
        [EnumMember(Value = "vies_item")]
        ViesItem,
        [EnumMember(Value = "begin_checkout")]
        BeginCheckout
    }

    public class GetWishListResponse
    {
        public GetWishListResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetWishListResponseResultsTypeItem
    {
        public string CDPContactID { get; set; }
        public int UserID { get; set; }
        public int WishListID { get; set; }
        public string LastUpdated { get; set; }
        public int LanguageID { get; set; }
    }

    public class OnNewEventResponse
    {
        public string NextSince { get; set; }
        public OnNewEventResponseResultsTypeItem[] Results { get; set; }
    }

    public class OnNewEventResponseResultsTypeItem
    {
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }
        public string EventName { get; set; }
        public string Timestamp { get; set; }
        public string CDPContactID { get; set; }
        public OnNewEventResponseResultsTypeItemBrowserType Browser { get; set; }
        public OnNewEventResponseResultsTypeItemListType List { get; set; }
        public OnNewEventResponseResultsTypeItemProductType Product { get; set; }
    }

    public class OnNewEventResponseResultsTypeItemBrowserType
    {
        public OnNewEventResponseResultsTypeItemBrowserTypeOSType OS { get; set; }
        public OnNewEventResponseResultsTypeItemBrowserTypeDeviceType Device { get; set; }
        public OnNewEventResponseResultsTypeItemBrowserTypeUserAgentType UserAgent { get; set; }
    }

    public class OnNewEventResponseResultsTypeItemBrowserTypeOSType
    {
        public string Family { get; set; }
        public string Major { get; set; }
    }

    public class OnNewEventResponseResultsTypeItemBrowserTypeDeviceType
    {
        public bool IsSpider { get; set; }
        public string Family { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }

    public class OnNewEventResponseResultsTypeItemBrowserTypeUserAgentType
    {
        public string Family { get; set; }
        public string Major { get; set; }
        public string Minor { get; set; }
        public string Patch { get; set; }
    }

    public class OnNewEventResponseResultsTypeItemListType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OnNewEventResponseResultsTypeItemProductType
    {
        public string ItemParentId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
    }

    public class OnNewUserInSegmentResponse
    {
        public string NextSince { get; set; }
        public OnNewUserInSegmentResponseResultsTypeItem[] Results { get; set; }
    }

    public class OnNewUserInSegmentResponseResultsTypeItem
    {
        public string ID { get; set; }
        public string CreatedDate { get; set; }
        public string EmailAddress { get; set; }

        [JsonProperty("eStoreSessionId")]
        public string EStoreSessionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool Anonymized { get; set; }
        public OnNewUserInSegmentResponseResultsTypeItemMobilePhoneType MobilePhone { get; set; }
        public OnNewUserInSegmentResponseResultsTypeItemModifiedDateType ModifiedDate { get; set; }
        public OnNewUserInSegmentResponseResultsTypeItemLandlineType Landline { get; set; }
        public OnNewUserInSegmentResponseResultsTypeItemAddressType Address { get; set; }
        public string Location { get; set; }
        public OnNewUserInSegmentResponseResultsTypeItemSegmentsTypeItem[] Segments { get; set; }
    }

    public class OnNewUserInSegmentResponseResultsTypeItemMobilePhoneType
    {
        public string Code { get; set; }
        public string Number { get; set; }
        public string CountryCode { get; set; }
    }

    public class OnNewUserInSegmentResponseResultsTypeItemModifiedDateType
    {
        public string Value { get; set; }
        public bool IsAutocalculated { get; set; }
    }

    public class OnNewUserInSegmentResponseResultsTypeItemLandlineType
    {
        public string Code { get; set; }
        public string Number { get; set; }
        public string CountryCode { get; set; }
    }

    public class OnNewUserInSegmentResponseResultsTypeItemAddressType
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }

    public class OnNewUserInSegmentResponseResultsTypeItemSegmentsTypeItem
    {
        public int SegmentID { get; set; }
        public string MemberSince { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Netvolution;

    public partial class WorkflowManagedActions
    {
        public NetvolutionActions Netvolution(string connectionId) => new NetvolutionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NetvolutionTriggers Netvolution(string connectionId) => new NetvolutionTriggers(connectionId);
    }
}