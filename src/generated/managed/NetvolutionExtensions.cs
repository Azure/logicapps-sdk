//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Netvolution
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NetvolutionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IBodyWorkflowAction<GetEmailTemplatesResponse, ApiConnectionActionConfiguration> GetEmailTemplates()
        {
            var apiCallPath = "/cdp/mail/list-templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEmailTemplatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetOrder(Expression<Func<string>> contactId, Expression<Func<string>> since)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cdp/orders/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetContactIDFromSuppressionList(Expression<Func<string>> contactId, Expression<Func<string>> listName)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_listName = WorkflowExpression.Compile(listName, nameof(listName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cdp/suppression/check";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contactId"] = ExpressionConverter.Convert(__workflow_contactId);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(__workflow_listName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutContactIDToSuppresionList(Expression<Func<string>> contactId, Expression<Func<string>> listName, Expression<Func<string>> timeSpan)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_listName = WorkflowExpression.Compile(listName, nameof(listName), required: true);
            var __workflow_timeSpan = WorkflowExpression.Compile(timeSpan, nameof(timeSpan), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cdp/suppression/add";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contactId"] = ExpressionConverter.Convert(__workflow_contactId);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(__workflow_listName);
                callPayload.Queries["timeSpan"] = ExpressionConverter.Convert(__workflow_timeSpan);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendMail(Expression<Func<string>> cdpContactId = null, Expression<Func<string>> languageId = null, Expression<Func<string>> emailTemplate = null)
        {
            var __workflow_cdpContactId = WorkflowExpression.Compile(cdpContactId, nameof(cdpContactId), required: false);
            var __workflow_languageId = WorkflowExpression.Compile(languageId, nameof(languageId), required: false);
            var __workflow_emailTemplate = WorkflowExpression.Compile(emailTemplate, nameof(emailTemplate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cdp/mail/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cdpContactId != null)
                    callPayload.Queries["cdpContactId"] = ExpressionConverter.Convert(__workflow_cdpContactId);
                if (__workflow_languageId != null)
                    callPayload.Queries["languageId"] = ExpressionConverter.Convert(__workflow_languageId);
                if (__workflow_emailTemplate != null)
                    callPayload.Queries["emailTemplate"] = ExpressionConverter.Convert(__workflow_emailTemplate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IBodyWorkflowAction<CheckEventResponse, ApiConnectionActionConfiguration> CheckEvent(Expression<Func<eventNameInput>> eventName = null, Expression<Func<string>> contactId = null, Expression<Func<string>> since = null)
        {
            var __workflow_eventName = WorkflowExpression.Compile(eventName, nameof(eventName), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            return new DeferredBodyAction<CheckEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cdp/events/checkevent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_eventName != null)
                    callPayload.Queries["eventName"] = ExpressionConverter.Convert(__workflow_eventName);
                if (__workflow_contactId != null)
                    callPayload.Queries["contactId"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                return new ApiConnectionAction<CheckEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IBodyWorkflowAction<GetWishListResponse, ApiConnectionActionConfiguration> GetWishList(Expression<Func<string>> since)
        {
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: true);
            return new DeferredBodyAction<GetWishListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cdp/wishlist/{0}", __workflow_since.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWishListResponse>(callPayload);
            });
        }
    }

    public class NetvolutionTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewEventResponse, ApiConnectionTriggerConfiguration> OnNewEvent(Expression<Func<eventNameInput>> eventName, FlowRecurrence recurrence = null)
        {
            var __workflow_eventName = WorkflowExpression.Compile(eventName, nameof(eventName), required: true);
            return new DeferredBodyTrigger<OnNewEventResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/cdp/events/{0}", __workflow_eventName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OnNewEventResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OnNewUserInSegmentResponse, ApiConnectionTriggerConfiguration> OnNewUserInSegment(Expression<Func<string>> id, FlowRecurrence recurrence = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyTrigger<OnNewUserInSegmentResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/cdp/contacts/{0}", __workflow_id.WithUrlEncoding(1)));
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
