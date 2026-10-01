//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Netvolution
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NetvolutionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IBodyWorkflowAction<GetEmailTemplatesResponse> GetEmailTemplates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cdp/mail/list-templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetEmailTemplatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IWorkflowAction GetOrder([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> since)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cdp/orders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IWorkflowAction GetContactIdFromSuppressionList([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> listName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cdp/suppression/check";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contactId"] = SourceExpressionConverter.ConvertO(contactId);
                callPayload.Queries["listName"] = SourceExpressionConverter.ConvertO(listName);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IWorkflowAction PutContactIdToSuppresionList([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> listName, [WorkflowExpression] Func<string> timeSpan)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cdp/suppression/add";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contactId"] = SourceExpressionConverter.ConvertO(contactId);
                callPayload.Queries["listName"] = SourceExpressionConverter.ConvertO(listName);
                callPayload.Queries["timeSpan"] = SourceExpressionConverter.ConvertO(timeSpan);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IWorkflowAction SendMail([WorkflowExpression] Func<string> cdpContactId = null, [WorkflowExpression] Func<string> languageId = null, [WorkflowExpression] Func<string> emailTemplate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cdp/mail/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cdpContactId != null)
                    callPayload.Queries["cdpContactId"] = SourceExpressionConverter.ConvertO(cdpContactId);
                if (languageId != null)
                    callPayload.Queries["languageId"] = SourceExpressionConverter.ConvertO(languageId);
                if (emailTemplate != null)
                    callPayload.Queries["emailTemplate"] = SourceExpressionConverter.ConvertO(emailTemplate);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IBodyWorkflowAction<CheckEventResponse> CheckEvent([WorkflowExpression] Func<eventNameInput> eventName = null, [WorkflowExpression] Func<string> contactId = null, [WorkflowExpression] Func<string> since = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cdp/events/checkevent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (eventName != null)
                    callPayload.Queries["eventName"] = SourceExpressionConverter.Convert(eventName);
                if (contactId != null)
                    callPayload.Queries["contactId"] = SourceExpressionConverter.ConvertO(contactId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                return callPayload;
            }

            return new ApiConnectionAction<CheckEventResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netvolution")]
        public IBodyWorkflowAction<GetWishListResponse> GetWishList([WorkflowExpression] Func<string> since)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cdp/wishlist/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(since, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWishListResponse>(BuildSourceInput);
        }
    }

    public class NetvolutionTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnNewEventResponse> OnNewEvent([WorkflowExpression] Func<eventNameInput> eventName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/cdp/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OnNewEventResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OnNewUserInSegmentResponse> OnNewUserInSegment([WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/cdp/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OnNewUserInSegmentResponse>(BuildSourceInput, triggerName, recurrence);
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