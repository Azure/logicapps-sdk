//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Starrezrestv1Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryResponseItem[], ApiConnectionActionConfiguration> SelectEntry(Expression<Func<SelectEntryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectEntryResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/entry.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectEntryResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryResponse, ApiConnectionActionConfiguration> CreateEntry(Expression<Func<CreateEntryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/entry.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryResponse, ApiConnectionActionConfiguration> UpdateEntry(Expression<Func<int>> entryId, Expression<Func<UpdateEntryInput>> body)
        {
            var __workflow_entryId = WorkflowExpression.Compile(entryId, nameof(entryId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entry.json/{0}", __workflow_entryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Delete(Expression<Func<tableNameInput>> tableName, Expression<Func<int>> rowId)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/delete/{0}.json/{1}", __workflow_tableName.WithUrlEncoding(1), __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryCustomFieldResponseItem[], ApiConnectionActionConfiguration> SelectEntryCustomField(Expression<Func<SelectEntryCustomFieldInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectEntryCustomFieldResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryCustomField.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectEntryCustomFieldResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryCustomFieldResponse, ApiConnectionActionConfiguration> UpdateEntryCustomField(Expression<Func<int>> entryCustomFieldId, Expression<Func<UpdateEntryCustomFieldInput>> body)
        {
            var __workflow_entryCustomFieldId = WorkflowExpression.Compile(entryCustomFieldId, nameof(entryCustomFieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateEntryCustomFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entryCustomField.json/{0}", __workflow_entryCustomFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateEntryCustomFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTermResponseItem[], ApiConnectionActionConfiguration> SelectTerm(Expression<Func<SelectTermInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectTermResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/Term.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectTermResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryAddressResponseItem[], ApiConnectionActionConfiguration> SelectEntryAddress(Expression<Func<SelectEntryAddressInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectEntryAddressResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryAddress.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectEntryAddressResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryAddressResponse, ApiConnectionActionConfiguration> UpdateEntryAddress(Expression<Func<int>> entryAddressId, Expression<Func<UpdateEntryAddressInput>> body)
        {
            var __workflow_entryAddressId = WorkflowExpression.Compile(entryAddressId, nameof(entryAddressId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateEntryAddressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entryAddress.json/{0}", __workflow_entryAddressId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateEntryAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryApplicationResponseItem[], ApiConnectionActionConfiguration> SelectEntryApplication(Expression<Func<SelectEntryApplicationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectEntryApplicationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryApplication.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectEntryApplicationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryApplicationResponse, ApiConnectionActionConfiguration> CreateEntryApplication(Expression<Func<CreateEntryApplicationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEntryApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/entryapplication.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEntryApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryApplicationResponse, ApiConnectionActionConfiguration> UpdateEntryApplication(Expression<Func<int>> entryApplicationId, Expression<Func<UpdateEntryApplicationInput>> body)
        {
            var __workflow_entryApplicationId = WorkflowExpression.Compile(entryApplicationId, nameof(entryApplicationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateEntryApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entryapplication.json/{0}", __workflow_entryApplicationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateEntryApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTermSessionResponseItem[], ApiConnectionActionConfiguration> SelectTermSession(Expression<Func<SelectTermSessionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectTermSessionResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/TermSession.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectTermSessionResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryDetailResponseItem[], ApiConnectionActionConfiguration> SelectEntryDetail(Expression<Func<SelectEntryDetailInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectEntryDetailResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryDetail.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectEntryDetailResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryDetailResponse, ApiConnectionActionConfiguration> UpdateEntryDetail(Expression<Func<int>> entryDetailId, Expression<Func<UpdateEntryDetailInput>> body)
        {
            var __workflow_entryDetailId = WorkflowExpression.Compile(entryDetailId, nameof(entryDetailId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateEntryDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entrydetail.json/{0}", __workflow_entryDetailId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateEntryDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectEntryEnrollmentResponseItem[], ApiConnectionActionConfiguration> SelectEntryEnrollment(Expression<Func<SelectEntryEnrollmentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectEntryEnrollmentResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/EntryEnrollment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectEntryEnrollmentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateEntryEnrollmentResponse, ApiConnectionActionConfiguration> CreateEntryEnrollment(Expression<Func<CreateEntryEnrollmentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEntryEnrollmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/entryenrollment.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEntryEnrollmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateEntryEnrollmentResponse, ApiConnectionActionConfiguration> UpdateEntryEnrollment(Expression<Func<int>> entryEnrollmentId, Expression<Func<UpdateEntryEnrollmentInput>> body)
        {
            var __workflow_entryEnrollmentId = WorkflowExpression.Compile(entryEnrollmentId, nameof(entryEnrollmentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateEntryEnrollmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/entryenrollment.json/{0}", __workflow_entryEnrollmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateEntryEnrollmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectBookingResponseItem[], ApiConnectionActionConfiguration> SelectBooking(Expression<Func<SelectBookingInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectBookingResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/Booking.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectBookingResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateBookingResponse, ApiConnectionActionConfiguration> CreateBooking(Expression<Func<CreateBookingInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateBookingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/booking.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateBookingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateBookingResponse, ApiConnectionActionConfiguration> UpdateBooking(Expression<Func<int>> bookingId, Expression<Func<UpdateBookingInput>> body)
        {
            var __workflow_bookingId = WorkflowExpression.Compile(bookingId, nameof(bookingId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateBookingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/booking.json/{0}", __workflow_bookingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateBookingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomSpaceResponseItem[], ApiConnectionActionConfiguration> SelectRoomSpace(Expression<Func<SelectRoomSpaceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectRoomSpaceResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/RoomSpace.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectRoomSpaceResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateRoomSpaceResponse, ApiConnectionActionConfiguration> CreateRoomSpace(Expression<Func<CreateRoomSpaceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateRoomSpaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/roomspace.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateRoomSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomLocationResponseItem[], ApiConnectionActionConfiguration> SelectRoomLocation(Expression<Func<SelectRoomLocationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectRoomLocationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/RoomLocation.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectRoomLocationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectTransactionResponseItem[], ApiConnectionActionConfiguration> SelectTransaction(Expression<Func<SelectTransactionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectTransactionResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/Transaction.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectTransactionResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateTransactionResponse, ApiConnectionActionConfiguration> CreateTransaction(Expression<Func<CreateTransactionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTransactionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/transaction.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTransactionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<SelectRoomSpaceMaintenanceResponseItem[], ApiConnectionActionConfiguration> SelectRoomSpaceMaintenance(Expression<Func<SelectRoomSpaceMaintenanceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SelectRoomSpaceMaintenanceResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/select/RoomSpaceMaintenance.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SelectRoomSpaceMaintenanceResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<CreateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration> CreateRoomSpaceMaintenance(Expression<Func<CreateRoomSpaceMaintenanceInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create/roomspacemaintenance.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateRoomSpaceMaintenanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "starrezrestv1")]
        public IBodyWorkflowAction<UpdateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration> UpdateRoomSpaceMaintenance(Expression<Func<int>> roomSpaceMaintenanceId, Expression<Func<UpdateRoomSpaceMaintenanceInput>> body = null)
        {
            var __workflow_roomSpaceMaintenanceId = WorkflowExpression.Compile(roomSpaceMaintenanceId, nameof(roomSpaceMaintenanceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/update/roomspacemaintenance.json/{0}", __workflow_roomSpaceMaintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateRoomSpaceMaintenanceResponse>(callPayload);
            });
        }
    }

    public class Starrezrestv1Triggers([ConnectionName] string connectionId)
    {
    }

    public class SelectEntryResponseItem
    {
        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int EventId { get; set; }
        public string GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int ID4 { get; set; }
        public int ID5 { get; set; }
        public string LastCheckInOutDate { get; set; }
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public int PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public string PreviousEntryStatusEnum { get; set; }
        public string TaxExemptionEnum { get; set; }
        public bool Testing { get; set; }
    }

    public class SelectEntryInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectEntryInputPageSizeType PageSize { get; set; } = SelectEntryInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }

        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public SelectEntryInputBirthGenderEnumType? BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int? BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int? ContactId { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int? CreatedBySecurityUserId { get; set; }
        public SelectEntryInputDateCreatedType DateCreated { get; set; }
        public SelectEntryInputDateModifiedType DateModified { get; set; }
        public bool? DirectoryFlagPrivacy { get; set; }
        public SelectEntryInputDOBType DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int? EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public SelectEntryInputEntryStatusEnumType? EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int? EventId { get; set; }
        public SelectEntryInputGenderEnumType? GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int? ID4 { get; set; }
        public int? ID5 { get; set; }
        public SelectEntryInputLastCheckInOutDateType LastCheckInOutDate { get; set; }
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public int? PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public SelectEntryInputPreviousEntryStatusEnumType? PreviousEntryStatusEnum { get; set; }
        public SelectEntryInputTaxExemptionEnumType? TaxExemptionEnum { get; set; }
        public bool? Testing { get; set; }
    }

    public enum SelectEntryInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputBirthGenderEnumType
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    public class SelectEntryInputDateCreatedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryInputDateCreatedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputDateCreatedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryInputDOBType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryInputDOBTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputDOBTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputGenderEnumType
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    public class SelectEntryInputLastCheckInOutDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryInputLastCheckInOutDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputLastCheckInOutDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputPreviousEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryInputTaxExemptionEnumType
    {
        FullExemption,
        None,
        Tax1Exempt,
        Tax2Exempt,
        Tax3Exempt
    }

    public class CreateEntryResponse
    {
        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int EventId { get; set; }
        public string GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int ID4 { get; set; }
        public int ID5 { get; set; }
        public string LastCheckInOutDate { get; set; }
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public string Password { get; set; }
        public int PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public string PreviousEntryStatusEnum { get; set; }
        public string TaxExemptionEnum { get; set; }
        public bool Testing { get; set; }
    }

    public class CreateEntryInput
    {
        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public CreateEntryInputBirthGenderEnumType? BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int? BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int? ContactId { get; set; }
        public bool? DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int? EntryApplicationId { get; set; }
        public CreateEntryInputEntryStatusEnumType? EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int? EventId { get; set; }
        public CreateEntryInputGenderEnumType? GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int? ID4 { get; set; }
        public int? ID5 { get; set; }
        public string LastCheckInOutDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public string Password { get; set; }
        public int? PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public CreateEntryInputPreviousEntryStatusEnumType? PreviousEntryStatusEnum { get; set; }
        public CreateEntryInputTaxExemptionEnumType? TaxExemptionEnum { get; set; }
        public bool? Testing { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEntryInputBirthGenderEnumType
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEntryInputEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEntryInputGenderEnumType
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEntryInputPreviousEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEntryInputTaxExemptionEnumType
    {
        FullExemption,
        None,
        Tax1Exempt,
        Tax2Exempt,
        Tax3Exempt
    }

    public class UpdateEntryResponse
    {
        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public string BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public bool DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int EventId { get; set; }
        public string GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int ID4 { get; set; }
        public int ID5 { get; set; }
        public string LastCheckInOutDate { get; set; }
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public string Password { get; set; }
        public int PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public string PreviousEntryStatusEnum { get; set; }
        public string TaxExemptionEnum { get; set; }
        public bool Testing { get; set; }
    }

    public class UpdateEntryInput
    {
        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public UpdateEntryInputBirthGenderEnumType? BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int? BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int? ContactId { get; set; }
        public bool? DirectoryFlagPrivacy { get; set; }
        public string DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int? EntryApplicationId { get; set; }
        public UpdateEntryInputEntryStatusEnumType? EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int? EventId { get; set; }
        public UpdateEntryInputGenderEnumType? GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int? ID4 { get; set; }
        public int? ID5 { get; set; }
        public string LastCheckInOutDate { get; set; }
        public string NameFirst { get; set; }
        public string NameInitials { get; set; }
        public string NameLast { get; set; }
        public string NameOther { get; set; }
        public string NamePreferred { get; set; }
        public string NameSharer { get; set; }
        public string NameTitle { get; set; }
        public string NameWeb { get; set; }
        public string Password { get; set; }
        public int? PinNumber { get; set; }

        [JsonProperty("PortalAuthProviderUserID")]
        public string PortalAuthProviderUserId { get; set; }
        public string PortalEmail { get; set; }
        public string Position { get; set; }

        [JsonProperty("Previous_EntryStatusEnum")]
        public UpdateEntryInputPreviousEntryStatusEnumType? PreviousEntryStatusEnum { get; set; }
        public UpdateEntryInputTaxExemptionEnumType? TaxExemptionEnum { get; set; }
        public bool? Testing { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryInputBirthGenderEnumType
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryInputEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryInputGenderEnumType
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryInputPreviousEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryInputTaxExemptionEnumType
    {
        FullExemption,
        None,
        Tax1Exempt,
        Tax2Exempt,
        Tax3Exempt
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum tableNameInput
    {
        Booking,
        Entry,
        EntryAddress,
        EntryApplication,
        EntryCustomField,
        EntryDetail,
        EntryEnrollment,
        RoomLocation,
        RoomSpace,
        RoomSpaceMaintenance,
        Term,
        TermSession,
        Transaction
    }

    public class SelectEntryCustomFieldResponseItem
    {
        [JsonProperty("CustomFieldDefinitionID")]
        public int CustomFieldDefinitionId { get; set; }
        public string DateModified { get; set; }

        [JsonProperty("EntryCustomFieldID")]
        public int EntryCustomFieldId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string FieldDataTypeEnum { get; set; }
        public bool ValueBoolean { get; set; }
        public string ValueDate { get; set; }
        public int ValueInteger { get; set; }
        public double ValueMoney { get; set; }
        public string ValueString { get; set; }
    }

    public class SelectEntryCustomFieldInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectEntryCustomFieldInputPageSizeType PageSize { get; set; } = SelectEntryCustomFieldInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }

        [JsonProperty("CustomFieldDefinitionID")]
        public int? CustomFieldDefinitionId { get; set; }
        public SelectEntryCustomFieldInputDateModifiedType DateModified { get; set; }

        [JsonProperty("EntryCustomFieldID")]
        public int? EntryCustomFieldId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public SelectEntryCustomFieldInputFieldDataTypeEnumType? FieldDataTypeEnum { get; set; }
        public bool? ValueBoolean { get; set; }
        public SelectEntryCustomFieldInputValueDateType ValueDate { get; set; }
        public int? ValueInteger { get; set; }
        public double? ValueMoney { get; set; }
        public string ValueString { get; set; }
    }

    public enum SelectEntryCustomFieldInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    public class SelectEntryCustomFieldInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryCustomFieldInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryCustomFieldInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryCustomFieldInputFieldDataTypeEnumType
    {
        Boolean,
        Date,
        DateTime,
        Integer,
        Money,
        String,
        StringLong
    }

    public class SelectEntryCustomFieldInputValueDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryCustomFieldInputValueDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryCustomFieldInputValueDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class UpdateEntryCustomFieldResponse
    {
        [JsonProperty("CustomFieldDefinitionID")]
        public int CustomFieldDefinitionId { get; set; }

        [JsonProperty("EntryCustomFieldID")]
        public int EntryCustomFieldId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string FieldDataTypeEnum { get; set; }
        public bool ValueBoolean { get; set; }
        public string ValueDate { get; set; }
        public int ValueInteger { get; set; }
        public double ValueMoney { get; set; }
        public string ValueString { get; set; }
    }

    public class UpdateEntryCustomFieldInput
    {
        [JsonProperty("CustomFieldDefinitionID")]
        public int? CustomFieldDefinitionId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public UpdateEntryCustomFieldInputFieldDataTypeEnumType? FieldDataTypeEnum { get; set; }
        public bool? ValueBoolean { get; set; }
        public string ValueDate { get; set; }
        public int? ValueInteger { get; set; }
        public double? ValueMoney { get; set; }
        public string ValueString { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryCustomFieldInputFieldDataTypeEnumType
    {
        Boolean,
        Date,
        DateTime,
        Integer,
        Money,
        String,
        StringLong
    }

    public class SelectTermResponseItem
    {
        public bool Active { get; set; }
        public string ActiveDateClose { get; set; }
        public string ActiveDateOpen { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string Comments { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string RecordTypeEnum { get; set; }
        public string TermCode { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }

        [JsonProperty("TermTypeID")]
        public int TermTypeId { get; set; }
        public string WebDescription { get; set; }
    }

    public class SelectTermInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectTermInputPageSizeType PageSize { get; set; } = SelectTermInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public bool? Active { get; set; }
        public SelectTermInputActiveDateCloseType ActiveDateClose { get; set; }
        public SelectTermInputActiveDateOpenType ActiveDateOpen { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryId { get; set; }
        public string Comments { get; set; }
        public SelectTermInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }
        public SelectTermInputRecordTypeEnumType? RecordTypeEnum { get; set; }
        public string TermCode { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }

        [JsonProperty("TermTypeID")]
        public int? TermTypeId { get; set; }
        public string WebDescription { get; set; }
    }

    public enum SelectTermInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    public class SelectTermInputActiveDateCloseType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermInputActiveDateCloseTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermInputActiveDateCloseTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTermInputActiveDateOpenType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermInputActiveDateOpenTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermInputActiveDateOpenTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTermInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermInputRecordTypeEnumType
    {
        Deleted,
        Normal,
        NotDeletableHidden,
        NotDeletableView,
        NotDeletableViewModify
    }

    public class SelectEntryAddressResponseItem
    {
        public string ActiveDateEnd { get; set; }
        public string ActiveDateStart { get; set; }

        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public string DateModified { get; set; }
        public string Email { get; set; }

        [JsonProperty("EntryAddressID")]
        public int EntryAddressId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Phone { get; set; }
        public string PhoneMobileCell { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneOther2 { get; set; }
        public string Reference { get; set; }
        public string Relationship { get; set; }
        public string Salutation { get; set; }
        public string StateProvince { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class SelectEntryAddressInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectEntryAddressInputPageSizeType PageSize { get; set; } = SelectEntryAddressInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public SelectEntryAddressInputActiveDateEndType ActiveDateEnd { get; set; }
        public SelectEntryAddressInputActiveDateStartType ActiveDateStart { get; set; }

        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }

        [JsonProperty("CountryID")]
        public int? CountryId { get; set; }
        public SelectEntryAddressInputDateModifiedType DateModified { get; set; }
        public string Email { get; set; }

        [JsonProperty("EntryAddressID")]
        public int? EntryAddressId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public string Phone { get; set; }
        public string PhoneMobileCell { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneOther2 { get; set; }
        public string Reference { get; set; }
        public string Relationship { get; set; }
        public string Salutation { get; set; }
        public string StateProvince { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string ZipPostcode { get; set; }
    }

    public enum SelectEntryAddressInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    public class SelectEntryAddressInputActiveDateEndType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryAddressInputActiveDateEndTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryAddressInputActiveDateEndTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryAddressInputActiveDateStartType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryAddressInputActiveDateStartTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryAddressInputActiveDateStartTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryAddressInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryAddressInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryAddressInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class UpdateEntryAddressResponse
    {
        public string ActiveDateEnd { get; set; }
        public string ActiveDateStart { get; set; }

        [JsonProperty("AddressTypeID")]
        public int AddressTypeId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public string Email { get; set; }

        [JsonProperty("EntryAddressID")]
        public int EntryAddressId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Phone { get; set; }
        public string PhoneMobileCell { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneOther2 { get; set; }
        public string Reference { get; set; }
        public string Relationship { get; set; }
        public string Salutation { get; set; }
        public string StateProvince { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class UpdateEntryAddressInput
    {
        public string ActiveDateEnd { get; set; }
        public string ActiveDateStart { get; set; }

        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }

        [JsonProperty("CountryID")]
        public int? CountryId { get; set; }
        public string Email { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public string Phone { get; set; }
        public string PhoneMobileCell { get; set; }
        public string PhoneOther { get; set; }
        public string PhoneOther2 { get; set; }
        public string Reference { get; set; }
        public string Relationship { get; set; }
        public string Salutation { get; set; }
        public string StateProvince { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class SelectEntryApplicationResponseItem
    {
        public string AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int ApplicationStatusId { get; set; }
        public string CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public string CompleteDate { get; set; }
        public string ContractSignedDate { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EnquiryDate { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public string ExpectedArrivalDateLatest { get; set; }
        public string ExpectedDepartureDate { get; set; }
        public string OfferedDate { get; set; }
        public string OfferReplyDate { get; set; }
        public string OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public string OfferSentDate { get; set; }
        public bool PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public string ReceivedDate { get; set; }
        public bool ReceivedDeposit { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int ReceivedDepositWebPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int ReceivedDepositPaymentId { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentId { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int RoommateGroupId { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public bool Web { get; set; }
    }

    public class SelectEntryApplicationInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectEntryApplicationInputPageSizeType PageSize { get; set; } = SelectEntryApplicationInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public SelectEntryApplicationInputAllocateOptionEnumType? AllocateOptionEnum { get; set; }
        public SelectEntryApplicationInputApplicationDateType ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int? ApplicationStatusId { get; set; }
        public SelectEntryApplicationInputCancelDateType CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int? ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public SelectEntryApplicationInputCompleteDateType CompleteDate { get; set; }
        public SelectEntryApplicationInputContractSignedDateType ContractSignedDate { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public bool? CustomBit3 { get; set; }
        public bool? CustomBit4 { get; set; }
        public SelectEntryApplicationInputCustomDate1Type CustomDate1 { get; set; }
        public SelectEntryApplicationInputCustomDate2Type CustomDate2 { get; set; }
        public SelectEntryApplicationInputCustomDate3Type CustomDate3 { get; set; }
        public SelectEntryApplicationInputCustomDate4Type CustomDate4 { get; set; }
        public SelectEntryApplicationInputDateCreatedType DateCreated { get; set; }
        public SelectEntryApplicationInputDateModifiedType DateModified { get; set; }
        public SelectEntryApplicationInputEnquiryDateType EnquiryDate { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int? EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public SelectEntryApplicationInputExpectedArrivalDateType ExpectedArrivalDate { get; set; }
        public SelectEntryApplicationInputExpectedArrivalDateLatestType ExpectedArrivalDateLatest { get; set; }
        public SelectEntryApplicationInputExpectedDepartureDateType ExpectedDepartureDate { get; set; }
        public SelectEntryApplicationInputOfferedDateType OfferedDate { get; set; }
        public SelectEntryApplicationInputOfferReplyDateType OfferReplyDate { get; set; }
        public SelectEntryApplicationInputOfferReplyEnumType? OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public SelectEntryApplicationInputOfferSentDateType OfferSentDate { get; set; }
        public bool? PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public SelectEntryApplicationInputReceivedDateType ReceivedDate { get; set; }
        public bool? ReceivedDeposit { get; set; }
        public bool? ReceivedDepositWaived { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int? ReceivedDepositPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int? ReceivedDepositWebPaymentId { get; set; }
        public double? ReceivedDepositAmount { get; set; }
        public SelectEntryApplicationInputReceivedDepositDateType ReceivedDepositDate { get; set; }
        public bool? ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int? ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int? ReceivedFeeWebPaymentId { get; set; }
        public double? ReceivedFeeAmount { get; set; }
        public SelectEntryApplicationInputReceivedFeeDateType ReceivedFeeDate { get; set; }
        public SelectEntryApplicationInputReceivedPhotoDateType ReceivedPhotoDate { get; set; }
        public bool? Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int? RoommateGroupId { get; set; }
        public int? RoomMateGroupSortOrder { get; set; }
        public bool? RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int? RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }
        public bool? Web { get; set; }
    }

    public enum SelectEntryApplicationInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputAllocateOptionEnumType
    {
        PreferRoomMates,
        PreferRoomPreferences
    }

    public class SelectEntryApplicationInputApplicationDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputApplicationDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputApplicationDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputCancelDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputCancelDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputCancelDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputCompleteDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputCompleteDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputCompleteDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputContractSignedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputContractSignedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputContractSignedDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputCustomDate1Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputCustomDate1TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputCustomDate1TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputCustomDate2Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputCustomDate2TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputCustomDate2TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputCustomDate3Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputCustomDate3TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputCustomDate3TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputCustomDate4Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputCustomDate4TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputCustomDate4TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputDateCreatedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputDateCreatedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputDateCreatedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputEnquiryDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputEnquiryDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputEnquiryDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputExpectedArrivalDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputExpectedArrivalDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputExpectedArrivalDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputExpectedArrivalDateLatestType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputExpectedArrivalDateLatestTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputExpectedArrivalDateLatestTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputExpectedDepartureDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputExpectedDepartureDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputExpectedDepartureDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputOfferedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputOfferedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputOfferedDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputOfferReplyDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputOfferReplyDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputOfferReplyDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputOfferReplyEnumType
    {
        Accepted,
        Declined,
        Deferred,
        NA
    }

    public class SelectEntryApplicationInputOfferSentDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputOfferSentDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputOfferSentDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputReceivedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputReceivedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputReceivedDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputReceivedDepositDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputReceivedDepositDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputReceivedDepositDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputReceivedFeeDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputReceivedFeeDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputReceivedFeeDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryApplicationInputReceivedPhotoDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryApplicationInputReceivedPhotoDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryApplicationInputReceivedPhotoDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class CreateEntryApplicationResponse
    {
        public string AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int ApplicationStatusId { get; set; }
        public string CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public string CompleteDate { get; set; }
        public string ContractSignedDate { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }
        public string EnquiryDate { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public string ExpectedArrivalDateLatest { get; set; }
        public string ExpectedDepartureDate { get; set; }
        public string OfferedDate { get; set; }
        public string OfferReplyDate { get; set; }
        public string OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public string OfferSentDate { get; set; }
        public bool PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public string ReceivedDate { get; set; }
        public bool ReceivedDeposit { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int ReceivedDepositPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int ReceivedDepositWebPaymentId { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentId { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int RoommateGroupId { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public bool Web { get; set; }
    }

    public class CreateEntryApplicationInput
    {
        public CreateEntryApplicationInputAllocateOptionEnumType? AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int? ApplicationStatusId { get; set; }
        public string CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int? ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public string CompleteDate { get; set; }
        public string ContractSignedDate { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public bool? CustomBit3 { get; set; }
        public bool? CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string EnquiryDate { get; set; }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EntryId { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public string ExpectedArrivalDateLatest { get; set; }
        public string ExpectedDepartureDate { get; set; }
        public string OfferedDate { get; set; }
        public string OfferReplyDate { get; set; }
        public CreateEntryApplicationInputOfferReplyEnumType? OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public string OfferSentDate { get; set; }
        public bool? PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public string ReceivedDate { get; set; }
        public bool? ReceivedDeposit { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int? ReceivedDepositPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int? ReceivedDepositWebPaymentId { get; set; }
        public double? ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool? ReceivedDepositWaived { get; set; }
        public bool? ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int? ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int? ReceivedFeeWebPaymentId { get; set; }
        public double? ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool? Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int? RoommateGroupId { get; set; }
        public int? RoomMateGroupSortOrder { get; set; }
        public bool? RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int? RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }
        public bool? Web { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEntryApplicationInputAllocateOptionEnumType
    {
        PreferRoomMates,
        PreferRoomPreferences
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEntryApplicationInputOfferReplyEnumType
    {
        Accepted,
        Declined,
        Deferred,
        NA
    }

    public class UpdateEntryApplicationResponse
    {
        public string AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int ApplicationStatusId { get; set; }
        public string CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public string CompleteDate { get; set; }
        public string ContractSignedDate { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string EnquiryDate { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public string ExpectedArrivalDateLatest { get; set; }
        public string ExpectedDepartureDate { get; set; }
        public string OfferedDate { get; set; }
        public string OfferReplyDate { get; set; }
        public string OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public string OfferSentDate { get; set; }
        public bool PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public string ReceivedDate { get; set; }
        public bool ReceivedDeposit { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int ReceivedDepositPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int ReceivedDepositWebPaymentId { get; set; }
        public double ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool ReceivedDepositWaived { get; set; }
        public bool ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int ReceivedFeeWebPaymentId { get; set; }
        public double ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int RoommateGroupId { get; set; }
        public int RoomMateGroupSortOrder { get; set; }
        public bool RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public bool Web { get; set; }
    }

    public class UpdateEntryApplicationInput
    {
        public UpdateEntryApplicationInputAllocateOptionEnumType? AllocateOptionEnum { get; set; }
        public string ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int? ApplicationStatusId { get; set; }
        public string CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int? ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public string CompleteDate { get; set; }
        public string ContractSignedDate { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public bool? CustomBit3 { get; set; }
        public bool? CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public string EnquiryDate { get; set; }
        public string ExpectedArrivalDate { get; set; }
        public string ExpectedArrivalDateLatest { get; set; }
        public string ExpectedDepartureDate { get; set; }
        public string OfferedDate { get; set; }
        public string OfferReplyDate { get; set; }
        public UpdateEntryApplicationInputOfferReplyEnumType? OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public string OfferSentDate { get; set; }
        public bool? PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public string ReceivedDate { get; set; }
        public bool? ReceivedDeposit { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int? ReceivedDepositPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int? ReceivedDepositWebPaymentId { get; set; }
        public double? ReceivedDepositAmount { get; set; }
        public string ReceivedDepositDate { get; set; }
        public bool? ReceivedDepositWaived { get; set; }
        public bool? ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int? ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int? ReceivedFeeWebPaymentId { get; set; }
        public double? ReceivedFeeAmount { get; set; }
        public string ReceivedFeeDate { get; set; }
        public string ReceivedPhotoDate { get; set; }
        public bool? Returning { get; set; }
        public string RoomMateDescription { get; set; }

        [JsonProperty("RoommateGroupID")]
        public int? RoommateGroupId { get; set; }
        public int? RoomMateGroupSortOrder { get; set; }
        public bool? RoomMateShowInSearch { get; set; }
        public string RoomPreferenceComments { get; set; }
        public int? RoomSelectionNumber { get; set; }
        public string RoomSelectionTimeslot { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }
        public bool? Web { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryApplicationInputAllocateOptionEnumType
    {
        PreferRoomMates,
        PreferRoomPreferences
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryApplicationInputOfferReplyEnumType
    {
        Accepted,
        Declined,
        Deferred,
        NA
    }

    public class SelectTermSessionResponseItem
    {
        [JsonProperty("BookingTypeID")]
        public int BookingTypeId { get; set; }

        [JsonProperty("CancelBookingDefaultEnd_BookingReasonID")]
        public int CancelBookingDefaultEndBookingReasonId { get; set; }

        [JsonProperty("CancelBookingUpdateEndBookingReason_BooleanAskEnum")]
        public string CancelBookingUpdateEndBookingReasonBooleanAskEnum { get; set; }
        public string CheckInDate { get; set; }

        [JsonProperty("CheckInDateActualDecrease_BooleanAskEnum")]
        public string CheckInDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDateActualIncrease_BooleanAskEnum")]
        public string CheckInDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDefaultStart_BookingReasonID")]
        public int CheckInDefaultStartBookingReasonId { get; set; }

        [JsonProperty("CheckInUpdateStartBookingReason_BooleanAskEnum")]
        public string CheckInUpdateStartBookingReasonBooleanAskEnum { get; set; }
        public string CheckOutDate { get; set; }

        [JsonProperty("CheckOutDateActualDecrease_BooleanAskEnum")]
        public string CheckOutDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDateActualIncrease_BooleanAskEnum")]
        public string CheckOutDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDefaultEnd_BookingReasonID")]
        public int CheckOutDefaultEndBookingReasonId { get; set; }

        [JsonProperty("CheckOutUpdateEndBookingReason_BooleanAskEnum")]
        public string CheckOutUpdateEndBookingReasonBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckInDecrease_BooleanAskEnum")]
        public string ContractDateCheckInDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckInIncrease_BooleanAskEnum")]
        public string ContractDateCheckInIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckOutDecrease_BooleanAskEnum")]
        public string ContractDateCheckOutDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckOutIncrease_BooleanAskEnum")]
        public string ContractDateCheckOutIncreaseBooleanAskEnum { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int EndBookingReasonId { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }

        [JsonProperty("HousekeepingID")]
        public int HousekeepingId { get; set; }
        public string RecordTypeEnum { get; set; }
        public bool RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public double RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int RoomTypeId { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonId { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public string TermSessionCode { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
        public bool UseActiveBookingAsTemplate { get; set; }
        public string WebDescription { get; set; }
    }

    public class SelectTermSessionInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectTermSessionInputPageSizeType PageSize { get; set; } = SelectTermSessionInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }

        [JsonProperty("BookingTypeID")]
        public int? BookingTypeId { get; set; }

        [JsonProperty("CancelBookingDefaultEnd_BookingReasonID")]
        public int? CancelBookingDefaultEndBookingReasonId { get; set; }

        [JsonProperty("CancelBookingUpdateEndBookingReason_BooleanAskEnum")]
        public SelectTermSessionInputCancelBookingUpdateEndBookingReasonBooleanAskEnumType? CancelBookingUpdateEndBookingReasonBooleanAskEnum { get; set; }
        public SelectTermSessionInputCheckInDateType CheckInDate { get; set; }

        [JsonProperty("CheckInDateActualDecrease_BooleanAskEnum")]
        public SelectTermSessionInputCheckInDateActualDecreaseBooleanAskEnumType? CheckInDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDateActualIncrease_BooleanAskEnum")]
        public SelectTermSessionInputCheckInDateActualIncreaseBooleanAskEnumType? CheckInDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDefaultStart_BookingReasonID")]
        public int? CheckInDefaultStartBookingReasonId { get; set; }

        [JsonProperty("CheckInUpdateStartBookingReason_BooleanAskEnum")]
        public SelectTermSessionInputCheckInUpdateStartBookingReasonBooleanAskEnumType? CheckInUpdateStartBookingReasonBooleanAskEnum { get; set; }
        public SelectTermSessionInputCheckOutDateType CheckOutDate { get; set; }

        [JsonProperty("CheckOutDateActualDecrease_BooleanAskEnum")]
        public SelectTermSessionInputCheckOutDateActualDecreaseBooleanAskEnumType? CheckOutDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDateActualIncrease_BooleanAskEnum")]
        public SelectTermSessionInputCheckOutDateActualIncreaseBooleanAskEnumType? CheckOutDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDefaultEnd_BookingReasonID")]
        public int? CheckOutDefaultEndBookingReasonId { get; set; }

        [JsonProperty("CheckOutUpdateEndBookingReason_BooleanAskEnum")]
        public SelectTermSessionInputCheckOutUpdateEndBookingReasonBooleanAskEnumType? CheckOutUpdateEndBookingReasonBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckInDecrease_BooleanAskEnum")]
        public SelectTermSessionInputContractDateCheckInDecreaseBooleanAskEnumType? ContractDateCheckInDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckInIncrease_BooleanAskEnum")]
        public SelectTermSessionInputContractDateCheckInIncreaseBooleanAskEnumType? ContractDateCheckInIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckOutDecrease_BooleanAskEnum")]
        public SelectTermSessionInputContractDateCheckOutDecreaseBooleanAskEnumType? ContractDateCheckOutDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckOutIncrease_BooleanAskEnum")]
        public SelectTermSessionInputContractDateCheckOutIncreaseBooleanAskEnumType? ContractDateCheckOutIncreaseBooleanAskEnum { get; set; }
        public SelectTermSessionInputContractDateEndType ContractDateEnd { get; set; }
        public SelectTermSessionInputContractDateStartType ContractDateStart { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public SelectTermSessionInputCustomDate1Type CustomDate1 { get; set; }
        public SelectTermSessionInputCustomDate2Type CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public SelectTermSessionInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int? EndBookingReasonId { get; set; }
        public SelectTermSessionInputEntryStatusEnumType? EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }

        [JsonProperty("HousekeepingID")]
        public int? HousekeepingId { get; set; }
        public SelectTermSessionInputRecordTypeEnumType? RecordTypeEnum { get; set; }
        public bool? RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int? RoomLocationId { get; set; }
        public double? RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int? RoomRateId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int? RoomTypeId { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int? StartBookingReasonId { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }
        public string TermSessionCode { get; set; }

        [JsonProperty("TermSessionID")]
        public int? TermSessionId { get; set; }
        public bool? UseActiveBookingAsTemplate { get; set; }
        public string WebDescription { get; set; }
    }

    public enum SelectTermSessionInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCancelBookingUpdateEndBookingReasonBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    public class SelectTermSessionInputCheckInDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermSessionInputCheckInDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCheckInDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCheckInDateActualDecreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCheckInDateActualIncreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCheckInUpdateStartBookingReasonBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    public class SelectTermSessionInputCheckOutDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermSessionInputCheckOutDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCheckOutDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCheckOutDateActualDecreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCheckOutDateActualIncreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCheckOutUpdateEndBookingReasonBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputContractDateCheckInDecreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputContractDateCheckInIncreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputContractDateCheckOutDecreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputContractDateCheckOutIncreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    public class SelectTermSessionInputContractDateEndType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermSessionInputContractDateEndTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputContractDateEndTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTermSessionInputContractDateStartType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermSessionInputContractDateStartTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputContractDateStartTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTermSessionInputCustomDate1Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermSessionInputCustomDate1TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCustomDate1TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTermSessionInputCustomDate2Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermSessionInputCustomDate2TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputCustomDate2TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTermSessionInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTermSessionInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTermSessionInputRecordTypeEnumType
    {
        Deleted,
        Normal,
        NotDeletableHidden,
        NotDeletableView,
        NotDeletableViewModify
    }

    public class SelectEntryDetailResponseItem
    {
        public bool AcademicHold { get; set; }

        [JsonProperty("Account_PaymentTypeID")]
        public int AccountPaymentTypeId { get; set; }
        public string AccountBankName { get; set; }
        public string AccountBankNumber { get; set; }
        public string AccountCode { get; set; }
        public string AccountComments { get; set; }
        public string AccountDetail1 { get; set; }
        public string AccountDetail2 { get; set; }
        public string AccountDetail3 { get; set; }
        public string AccountDetail4 { get; set; }
        public string AccountDueDate { get; set; }
        public bool AccountHold { get; set; }
        public bool Athlete { get; set; }
        public string AthleteTeam { get; set; }
        public string AttendeeStatusEnum { get; set; }
        public string Career { get; set; }
        public string CareerComments { get; set; }

        [JsonProperty("Citizenship_CountryID")]
        public int CitizenshipCountryId { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public bool ClassificationOverride { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryOfBirth_CountryID")]
        public int CountryOfBirthCountryId { get; set; }

        [JsonProperty("CountryOfResidence_CountryID")]
        public int CountryOfResidenceCountryId { get; set; }
        public double CumulativeGPA { get; set; }
        public double CumulativeHours { get; set; }
        public double CurrentGPA { get; set; }
        public double CurrentHours { get; set; }
        public string CurrentMajor { get; set; }
        public string CurrentMinor { get; set; }
        public string DateEntry { get; set; }
        public string DateExit { get; set; }
        public string DateModified { get; set; }
        public bool Deceased { get; set; }
        public string DeceasedDate { get; set; }
        public string Dietary { get; set; }
        public string Disability { get; set; }
        public string EmploymentDetails { get; set; }
        public string EnrollmentClass { get; set; }
        public string EnrollmentLevel { get; set; }
        public string EnrollmentStatus { get; set; }
        public string EnrollmentTerm { get; set; }
        public int EnrollmentYear { get; set; }

        [JsonProperty("EntryDetailID")]
        public int EntryDetailId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Ethnicity { get; set; }

        [JsonProperty("EventRegistrationFeeID")]
        public int EventRegistrationFeeId { get; set; }
        public string ExpectedGraduationDate { get; set; }
        public string FinancialComments { get; set; }

        [JsonProperty("FinancialSupportID")]
        public int FinancialSupportId { get; set; }
        public string HearAboutUs { get; set; }
        public bool HonorsIndicator { get; set; }
        public bool ImmunizationsHold { get; set; }
        public bool IncidentHold { get; set; }
        public string IncidentHoldComments { get; set; }
        public bool International { get; set; }
        public string InternationalDetails { get; set; }
        public bool LivingWithDependents { get; set; }
        public bool Married { get; set; }
        public string Medical { get; set; }

        [JsonProperty("NationalityID")]
        public int NationalityId { get; set; }
        public string Occupation { get; set; }
        public string PhotoPath { get; set; }
        public string PreviousMemberName { get; set; }
        public string PreviousMemberRelationship { get; set; }
        public string PreviousMembership { get; set; }
        public string PreviousMembershipYears { get; set; }
        public string PreviousMemberYears { get; set; }
        public string ProfileInterests { get; set; }

        [JsonProperty("RegionOfBirthID")]
        public int RegionOfBirthId { get; set; }
        public string Religion { get; set; }
        public string Residency { get; set; }
        public string ResidentStatus { get; set; }
        public int ResidentYear { get; set; }
        public string SituationResponseComments { get; set; }
        public string SituationResponseDetail { get; set; }
        public string SituationResponseEnum { get; set; }
        public string SituationResponseExpiryDate { get; set; }
        public string SituationResponseModifiedDate { get; set; }
        public string SituationResponseSituation { get; set; }
        public string SpecialNeeds { get; set; }

        [JsonProperty("StaffID")]
        public int StaffId { get; set; }
        public bool UsesScreenReader { get; set; }
        public string VehicleDetails { get; set; }
        public string VehiclePermit { get; set; }
        public string VehicleRegistration { get; set; }
        public string VeteranStatus { get; set; }
        public bool Visa { get; set; }
        public string VisaDetails { get; set; }
        public bool VisitorHold { get; set; }
    }

    public class SelectEntryDetailInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectEntryDetailInputPageSizeType PageSize { get; set; } = SelectEntryDetailInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public bool? AcademicHold { get; set; }

        [JsonProperty("Account_PaymentTypeID")]
        public int? AccountPaymentTypeId { get; set; }
        public bool? AccountHold { get; set; }
        public string AccountBankName { get; set; }
        public string AccountBankNumber { get; set; }
        public string AccountCode { get; set; }
        public string AccountComments { get; set; }
        public string AccountDetail1 { get; set; }
        public string AccountDetail2 { get; set; }
        public string AccountDetail3 { get; set; }
        public string AccountDetail4 { get; set; }
        public SelectEntryDetailInputAccountDueDateType AccountDueDate { get; set; }
        public bool? Athlete { get; set; }
        public string AthleteTeam { get; set; }
        public SelectEntryDetailInputAttendeeStatusEnumType? AttendeeStatusEnum { get; set; }
        public string Career { get; set; }
        public string CareerComments { get; set; }

        [JsonProperty("Citizenship_CountryID")]
        public int? CitizenshipCountryId { get; set; }

        [JsonProperty("ClassificationID")]
        public int? ClassificationId { get; set; }
        public bool? ClassificationOverride { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryOfBirth_CountryID")]
        public int? CountryOfBirthCountryId { get; set; }

        [JsonProperty("CountryOfResidence_CountryID")]
        public int? CountryOfResidenceCountryId { get; set; }
        public double? CumulativeGPA { get; set; }
        public double? CumulativeHours { get; set; }
        public double? CurrentGPA { get; set; }
        public double? CurrentHours { get; set; }
        public string CurrentMajor { get; set; }
        public string CurrentMinor { get; set; }
        public SelectEntryDetailInputDateEntryType DateEntry { get; set; }
        public SelectEntryDetailInputDateExitType DateExit { get; set; }
        public SelectEntryDetailInputDateModifiedType DateModified { get; set; }
        public bool? Deceased { get; set; }
        public SelectEntryDetailInputDeceasedDateType DeceasedDate { get; set; }
        public string Dietary { get; set; }
        public string Disability { get; set; }
        public string EmploymentDetails { get; set; }
        public string EnrollmentClass { get; set; }
        public string EnrollmentLevel { get; set; }
        public string EnrollmentStatus { get; set; }
        public string EnrollmentTerm { get; set; }
        public int? EnrollmentYear { get; set; }

        [JsonProperty("EntryDetailID")]
        public int? EntryDetailId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public string Ethnicity { get; set; }

        [JsonProperty("EventRegistrationFeeID")]
        public int? EventRegistrationFeeId { get; set; }
        public SelectEntryDetailInputExpectedGraduationDateType ExpectedGraduationDate { get; set; }
        public string FinancialComments { get; set; }

        [JsonProperty("FinancialSupportID")]
        public int? FinancialSupportId { get; set; }
        public string HearAboutUs { get; set; }
        public bool? HonorsIndicator { get; set; }
        public bool? ImmunizationsHold { get; set; }
        public bool? IncidentHold { get; set; }
        public string IncidentHoldComments { get; set; }
        public bool? International { get; set; }
        public string InternationalDetails { get; set; }
        public bool? LivingWithDependents { get; set; }
        public bool? Married { get; set; }
        public string Medical { get; set; }

        [JsonProperty("NationalityID")]
        public int? NationalityId { get; set; }
        public string Occupation { get; set; }
        public string PhotoPath { get; set; }
        public string PreviousMemberName { get; set; }
        public string PreviousMemberRelationship { get; set; }
        public string PreviousMembership { get; set; }
        public string PreviousMembershipYears { get; set; }
        public string PreviousMemberYears { get; set; }
        public string ProfileInterests { get; set; }

        [JsonProperty("RegionOfBirthID")]
        public int? RegionOfBirthId { get; set; }
        public string Religion { get; set; }
        public string Residency { get; set; }
        public string ResidentStatus { get; set; }
        public int? ResidentYear { get; set; }
        public string SituationResponseComments { get; set; }
        public string SituationResponseDetail { get; set; }
        public SelectEntryDetailInputSituationResponseEnumType? SituationResponseEnum { get; set; }
        public SelectEntryDetailInputSituationResponseExpiryDateType SituationResponseExpiryDate { get; set; }
        public SelectEntryDetailInputSituationResponseModifiedDateType SituationResponseModifiedDate { get; set; }
        public string SituationResponseSituation { get; set; }
        public string SpecialNeeds { get; set; }

        [JsonProperty("StaffID")]
        public int? StaffId { get; set; }
        public bool? UsesScreenReader { get; set; }
        public string VehicleDetails { get; set; }
        public string VehiclePermit { get; set; }
        public string VehicleRegistration { get; set; }
        public string VeteranStatus { get; set; }
        public bool? Visa { get; set; }
        public string VisaDetails { get; set; }
        public bool? VisitorHold { get; set; }
    }

    public enum SelectEntryDetailInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    public class SelectEntryDetailInputAccountDueDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryDetailInputAccountDueDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputAccountDueDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputAttendeeStatusEnumType
    {
        Arrived,
        Confirmed,
        Departed,
        NA,
        Other,
        Registered
    }

    public class SelectEntryDetailInputDateEntryType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryDetailInputDateEntryTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputDateEntryTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryDetailInputDateExitType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryDetailInputDateExitTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputDateExitTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryDetailInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryDetailInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryDetailInputDeceasedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryDetailInputDeceasedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputDeceasedDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryDetailInputExpectedGraduationDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryDetailInputExpectedGraduationDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputExpectedGraduationDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputSituationResponseEnumType
    {
        NoResponse,
        NotOkay,
        Okay
    }

    public class SelectEntryDetailInputSituationResponseExpiryDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryDetailInputSituationResponseExpiryDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputSituationResponseExpiryDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryDetailInputSituationResponseModifiedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryDetailInputSituationResponseModifiedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryDetailInputSituationResponseModifiedDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class UpdateEntryDetailResponse
    {
        public bool AcademicHold { get; set; }

        [JsonProperty("Account_PaymentTypeID")]
        public int AccountPaymentTypeId { get; set; }
        public string AccountBankName { get; set; }
        public string AccountBankNumber { get; set; }
        public string AccountCode { get; set; }
        public string AccountComments { get; set; }
        public string AccountDetail1 { get; set; }
        public string AccountDetail2 { get; set; }
        public string AccountDetail3 { get; set; }
        public string AccountDetail4 { get; set; }
        public string AccountDueDate { get; set; }
        public bool AccountHold { get; set; }
        public bool Athlete { get; set; }
        public string AthleteTeam { get; set; }
        public string AttendeeStatusEnum { get; set; }
        public string Career { get; set; }
        public string CareerComments { get; set; }

        [JsonProperty("Citizenship_CountryID")]
        public int CitizenshipCountryId { get; set; }

        [JsonProperty("ClassificationID")]
        public int ClassificationId { get; set; }
        public bool ClassificationOverride { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryOfBirth_CountryID")]
        public int CountryOfBirthCountryId { get; set; }

        [JsonProperty("CountryOfResidence_CountryID")]
        public int CountryOfResidenceCountryId { get; set; }
        public double CumulativeGPA { get; set; }
        public double CumulativeHours { get; set; }
        public double CurrentGPA { get; set; }
        public double CurrentHours { get; set; }
        public string CurrentMajor { get; set; }
        public string CurrentMinor { get; set; }
        public string DateEntry { get; set; }
        public string DateExit { get; set; }
        public bool Deceased { get; set; }
        public string DeceasedDate { get; set; }
        public string Dietary { get; set; }
        public string Disability { get; set; }
        public string EmploymentDetails { get; set; }
        public string EnrollmentClass { get; set; }
        public string EnrollmentLevel { get; set; }
        public string EnrollmentStatus { get; set; }
        public string EnrollmentTerm { get; set; }
        public int EnrollmentYear { get; set; }

        [JsonProperty("EntryDetailID")]
        public int EntryDetailId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Ethnicity { get; set; }

        [JsonProperty("EventRegistrationFeeID")]
        public int EventRegistrationFeeId { get; set; }
        public string ExpectedGraduationDate { get; set; }
        public string FinancialComments { get; set; }

        [JsonProperty("FinancialSupportID")]
        public int FinancialSupportId { get; set; }
        public string HearAboutUs { get; set; }
        public bool HonorsIndicator { get; set; }
        public bool ImmunizationsHold { get; set; }
        public bool IncidentHold { get; set; }
        public string IncidentHoldComments { get; set; }
        public bool International { get; set; }
        public string InternationalDetails { get; set; }
        public bool LivingWithDependents { get; set; }
        public bool Married { get; set; }
        public string Medical { get; set; }

        [JsonProperty("NationalityID")]
        public int NationalityId { get; set; }
        public string Occupation { get; set; }
        public string PhotoPath { get; set; }
        public string PreviousMemberName { get; set; }
        public string PreviousMemberRelationship { get; set; }
        public string PreviousMembership { get; set; }
        public string PreviousMembershipYears { get; set; }
        public string PreviousMemberYears { get; set; }
        public string ProfileInterests { get; set; }

        [JsonProperty("RegionOfBirthID")]
        public int RegionOfBirthId { get; set; }
        public string Religion { get; set; }
        public string Residency { get; set; }
        public string ResidentStatus { get; set; }
        public int ResidentYear { get; set; }
        public string SituationResponseComments { get; set; }
        public string SituationResponseDetail { get; set; }
        public string SituationResponseEnum { get; set; }
        public string SituationResponseExpiryDate { get; set; }
        public string SituationResponseModifiedDate { get; set; }
        public string SituationResponseSituation { get; set; }
        public string SpecialNeeds { get; set; }

        [JsonProperty("StaffID")]
        public int StaffId { get; set; }
        public bool UsesScreenReader { get; set; }
        public string VehicleDetails { get; set; }
        public string VehiclePermit { get; set; }
        public string VehicleRegistration { get; set; }
        public string VeteranStatus { get; set; }
        public bool Visa { get; set; }
        public string VisaDetails { get; set; }
        public bool VisitorHold { get; set; }
    }

    public class UpdateEntryDetailInput
    {
        public bool? AcademicHold { get; set; }

        [JsonProperty("Account_PaymentTypeID")]
        public int? AccountPaymentTypeId { get; set; }
        public string AccountBankName { get; set; }
        public string AccountBankNumber { get; set; }
        public string AccountCode { get; set; }
        public string AccountComments { get; set; }
        public string AccountDetail1 { get; set; }
        public string AccountDetail2 { get; set; }
        public string AccountDetail3 { get; set; }
        public string AccountDetail4 { get; set; }
        public string AccountDueDate { get; set; }
        public bool? AccountHold { get; set; }
        public bool? Athlete { get; set; }
        public string AthleteTeam { get; set; }
        public UpdateEntryDetailInputAttendeeStatusEnumType? AttendeeStatusEnum { get; set; }
        public string Career { get; set; }
        public string CareerComments { get; set; }

        [JsonProperty("Citizenship_CountryID")]
        public int? CitizenshipCountryId { get; set; }

        [JsonProperty("ClassificationID")]
        public int? ClassificationId { get; set; }
        public bool? ClassificationOverride { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryOfBirth_CountryID")]
        public int? CountryOfBirthCountryId { get; set; }

        [JsonProperty("CountryOfResidence_CountryID")]
        public int? CountryOfResidenceCountryId { get; set; }
        public double? CumulativeGPA { get; set; }
        public double? CumulativeHours { get; set; }
        public double? CurrentGPA { get; set; }
        public double? CurrentHours { get; set; }
        public string CurrentMajor { get; set; }
        public string CurrentMinor { get; set; }
        public string DateEntry { get; set; }
        public string DateExit { get; set; }
        public bool? Deceased { get; set; }
        public string DeceasedDate { get; set; }
        public string Dietary { get; set; }
        public string Disability { get; set; }
        public string EmploymentDetails { get; set; }
        public string EnrollmentClass { get; set; }
        public string EnrollmentLevel { get; set; }
        public string EnrollmentStatus { get; set; }
        public string EnrollmentTerm { get; set; }
        public int? EnrollmentYear { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public string Ethnicity { get; set; }

        [JsonProperty("EventRegistrationFeeID")]
        public int? EventRegistrationFeeId { get; set; }
        public string ExpectedGraduationDate { get; set; }
        public string FinancialComments { get; set; }

        [JsonProperty("FinancialSupportID")]
        public int? FinancialSupportId { get; set; }
        public string HearAboutUs { get; set; }
        public bool? HonorsIndicator { get; set; }
        public bool? ImmunizationsHold { get; set; }
        public bool? IncidentHold { get; set; }
        public string IncidentHoldComments { get; set; }
        public bool? International { get; set; }
        public string InternationalDetails { get; set; }
        public bool? LivingWithDependents { get; set; }
        public bool? Married { get; set; }
        public string Medical { get; set; }

        [JsonProperty("NationalityID")]
        public int? NationalityId { get; set; }
        public string Occupation { get; set; }
        public string PhotoPath { get; set; }
        public string PreviousMemberName { get; set; }
        public string PreviousMemberRelationship { get; set; }
        public string PreviousMembership { get; set; }
        public string PreviousMembershipYears { get; set; }
        public string PreviousMemberYears { get; set; }
        public string ProfileInterests { get; set; }

        [JsonProperty("RegionOfBirthID")]
        public int? RegionOfBirthId { get; set; }
        public string Religion { get; set; }
        public string Residency { get; set; }
        public string ResidentStatus { get; set; }
        public int? ResidentYear { get; set; }
        public string SituationResponseComments { get; set; }
        public string SituationResponseDetail { get; set; }
        public UpdateEntryDetailInputSituationResponseEnumType? SituationResponseEnum { get; set; }
        public string SituationResponseExpiryDate { get; set; }
        public string SituationResponseModifiedDate { get; set; }
        public string SituationResponseSituation { get; set; }
        public string SpecialNeeds { get; set; }

        [JsonProperty("StaffID")]
        public int? StaffId { get; set; }
        public bool? UsesScreenReader { get; set; }
        public string VehicleDetails { get; set; }
        public string VehiclePermit { get; set; }
        public string VehicleRegistration { get; set; }
        public string VeteranStatus { get; set; }
        public bool? Visa { get; set; }
        public string VisaDetails { get; set; }
        public bool? VisitorHold { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryDetailInputAttendeeStatusEnumType
    {
        Arrived,
        Confirmed,
        Departed,
        NA,
        Other,
        Registered
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryDetailInputSituationResponseEnumType
    {
        NoResponse,
        NotOkay,
        Okay
    }

    public class SelectEntryEnrollmentResponseItem
    {
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int CourseId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateEnd { get; set; }
        public string DateModified { get; set; }
        public string DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int EnrollmentOrder { get; set; }
        public string EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryEnrollmentID")]
        public int EntryEnrollmentId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Faculty { get; set; }
        public bool FullTime { get; set; }
        public string GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool PostGrad { get; set; }
        public int Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public string Years { get; set; }
    }

    public class SelectEntryEnrollmentInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectEntryEnrollmentInputPageSizeType PageSize { get; set; } = SelectEntryEnrollmentInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int? CourseId { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public SelectEntryEnrollmentInputCustomDate1Type CustomDate1 { get; set; }
        public SelectEntryEnrollmentInputCustomDate2Type CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public SelectEntryEnrollmentInputDateEndType DateEnd { get; set; }
        public SelectEntryEnrollmentInputDateModifiedType DateModified { get; set; }
        public SelectEntryEnrollmentInputDateStartType DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int? EnrollmentOrder { get; set; }
        public SelectEntryEnrollmentInputEnrollmentTypeEnumType? EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryEnrollmentID")]
        public int? EntryEnrollmentId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public string Faculty { get; set; }
        public bool? FullTime { get; set; }
        public SelectEntryEnrollmentInputGraduationDateType GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool? IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool? PostGrad { get; set; }
        public int? Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }
        public string Years { get; set; }
    }

    public enum SelectEntryEnrollmentInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    public class SelectEntryEnrollmentInputCustomDate1Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryEnrollmentInputCustomDate1TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryEnrollmentInputCustomDate1TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryEnrollmentInputCustomDate2Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryEnrollmentInputCustomDate2TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryEnrollmentInputCustomDate2TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryEnrollmentInputDateEndType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryEnrollmentInputDateEndTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryEnrollmentInputDateEndTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryEnrollmentInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryEnrollmentInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryEnrollmentInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectEntryEnrollmentInputDateStartType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryEnrollmentInputDateStartTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryEnrollmentInputDateStartTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryEnrollmentInputEnrollmentTypeEnumType
    {
        Current,
        Preferred,
        Previous
    }

    public class SelectEntryEnrollmentInputGraduationDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectEntryEnrollmentInputGraduationDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectEntryEnrollmentInputGraduationDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class CreateEntryEnrollmentResponse
    {
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int CourseId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateEnd { get; set; }
        public string DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int EnrollmentOrder { get; set; }
        public string EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryEnrollmentID")]
        public int EntryEnrollmentId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Faculty { get; set; }
        public bool FullTime { get; set; }
        public string GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool PostGrad { get; set; }
        public int Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public string Years { get; set; }
    }

    public class CreateEntryEnrollmentInput
    {
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int? CourseId { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateEnd { get; set; }
        public string DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int? EnrollmentOrder { get; set; }
        public CreateEntryEnrollmentInputEnrollmentTypeEnumType? EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EntryId { get; set; }
        public string Faculty { get; set; }
        public bool? FullTime { get; set; }
        public string GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool? IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool? PostGrad { get; set; }
        public int? Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }
        public string Years { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEntryEnrollmentInputEnrollmentTypeEnumType
    {
        Current,
        Preferred,
        Previous
    }

    public class UpdateEntryEnrollmentResponse
    {
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int CourseId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateEnd { get; set; }
        public string DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int EnrollmentOrder { get; set; }
        public string EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryEnrollmentID")]
        public int EntryEnrollmentId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public string Faculty { get; set; }
        public bool FullTime { get; set; }
        public string GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool PostGrad { get; set; }
        public int Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int TermId { get; set; }
        public string Years { get; set; }
    }

    public class UpdateEntryEnrollmentInput
    {
        public string Campus { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CourseID")]
        public int? CourseId { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateEnd { get; set; }
        public string DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int? EnrollmentOrder { get; set; }
        public UpdateEntryEnrollmentInputEnrollmentTypeEnumType? EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public string Faculty { get; set; }
        public bool? FullTime { get; set; }
        public string GraduationDate { get; set; }
        public string Institution { get; set; }
        public bool? IsEnrolled { get; set; }
        public string Major { get; set; }
        public string MajorCategory { get; set; }
        public string Minor { get; set; }
        public bool? PostGrad { get; set; }
        public int? Sequence { get; set; }
        public string Subjects { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }
        public string Years { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateEntryEnrollmentInputEnrollmentTypeEnumType
    {
        Current,
        Preferred,
        Previous
    }

    public class SelectBookingResponseItem
    {
        public int AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }
        public string BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int BookingTypeId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInDateActual { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public string DateBilled { get; set; }
        public string DateChargedTo { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string DateModifiedBilling { get; set; }
        public int EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int EntryInvitationId { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }

        [JsonProperty("GroupID")]
        public int GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int HousekeepingId { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public double RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
    }

    public class SelectBookingInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectBookingInputPageSizeType PageSize { get; set; } = SelectBookingInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public int? AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }

        [JsonProperty("BookingID")]
        public int? BookingId { get; set; }
        public SelectBookingInputBookingLinkTypeEnumType? BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int? BookingTypeId { get; set; }
        public SelectBookingInputCheckInDateType CheckInDate { get; set; }
        public SelectBookingInputCheckInDateActualType CheckInDateActual { get; set; }
        public SelectBookingInputCheckOutDateType CheckOutDate { get; set; }
        public SelectBookingInputCheckOutDateActualType CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public SelectBookingInputContractDateEndType ContractDateEnd { get; set; }
        public SelectBookingInputContractDateStartType ContractDateStart { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public bool? CustomBit3 { get; set; }
        public bool? CustomBit4 { get; set; }
        public SelectBookingInputCustomDate1Type CustomDate1 { get; set; }
        public SelectBookingInputCustomDate2Type CustomDate2 { get; set; }
        public SelectBookingInputCustomDate3Type CustomDate3 { get; set; }
        public SelectBookingInputCustomDate4Type CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public SelectBookingInputDateBilledType DateBilled { get; set; }
        public SelectBookingInputDateChargedToType DateChargedTo { get; set; }
        public SelectBookingInputDateCreatedType DateCreated { get; set; }
        public SelectBookingInputDateModifiedType DateModified { get; set; }
        public SelectBookingInputDateModifiedBillingType DateModifiedBilling { get; set; }
        public int? EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int? EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int? EntryInvitationId { get; set; }
        public SelectBookingInputEntryStatusEnumType? EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double? Excess { get; set; }

        [JsonProperty("GroupID")]
        public int? GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int? HousekeepingId { get; set; }
        public int? NumberOfChildren { get; set; }
        public int? NumberOfChildrenFree { get; set; }
        public int? NumberOfGuests { get; set; }
        public int? NumberOfGuestsFree { get; set; }
        public SelectBookingInputPaidToType PaidTo { get; set; }
        public int? PetCount { get; set; }
        public bool? ResvChargeToEntry { get; set; }
        public bool? RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int? RoomLocationId { get; set; }
        public double? RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int? RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int? RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int? RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public int? ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int? StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int? TermSessionId { get; set; }
    }

    public enum SelectBookingInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputBookingLinkTypeEnumType
    {
        None,
        Child,
        Parent,
        Reference
    }

    public class SelectBookingInputCheckInDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputCheckInDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputCheckInDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputCheckInDateActualType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputCheckInDateActualTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputCheckInDateActualTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputCheckOutDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputCheckOutDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputCheckOutDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputCheckOutDateActualType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputCheckOutDateActualTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputCheckOutDateActualTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputContractDateEndType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputContractDateEndTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputContractDateEndTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputContractDateStartType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputContractDateStartTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputContractDateStartTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputCustomDate1Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputCustomDate1TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputCustomDate1TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputCustomDate2Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputCustomDate2TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputCustomDate2TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputCustomDate3Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputCustomDate3TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputCustomDate3TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputCustomDate4Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputCustomDate4TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputCustomDate4TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputDateBilledType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputDateBilledTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputDateBilledTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputDateChargedToType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputDateChargedToTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputDateChargedToTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputDateCreatedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputDateCreatedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputDateCreatedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectBookingInputDateModifiedBillingType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputDateModifiedBillingTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputDateModifiedBillingTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    public class SelectBookingInputPaidToType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectBookingInputPaidToTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectBookingInputPaidToTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class CreateBookingResponse
    {
        public int AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }
        public string BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int BookingTypeId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInDateActual { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public string DateBilled { get; set; }
        public string DateChargedTo { get; set; }
        public string DateModifiedBilling { get; set; }
        public int EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int EntryInvitationId { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }

        [JsonProperty("GroupID")]
        public int GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int HousekeepingId { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public double RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
    }

    public class CreateBookingInput
    {
        public int? AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }
        public CreateBookingInputBookingLinkTypeEnumType? BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int? BookingTypeId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInDateActual { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public bool? CustomBit3 { get; set; }
        public bool? CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public string DateBilled { get; set; }
        public string DateChargedTo { get; set; }
        public int? EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int? EndBookingReasonId { get; set; }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int? EntryInvitationId { get; set; }
        public CreateBookingInputEntryStatusEnumType? EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double? Excess { get; set; }

        [JsonProperty("GroupID")]
        public int? GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int? HousekeepingId { get; set; }
        public int? NumberOfChildren { get; set; }
        public int? NumberOfChildrenFree { get; set; }
        public int? NumberOfGuests { get; set; }
        public int? NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int? PetCount { get; set; }
        public bool? ResvChargeToEntry { get; set; }
        public bool? RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int? RoomLocationId { get; set; }
        public double? RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int? RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int? RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int? RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public int? ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int? StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int? TermSessionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateBookingInputBookingLinkTypeEnumType
    {
        None,
        Child,
        Parent,
        Reference
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateBookingInputEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    public class UpdateBookingResponse
    {
        public int AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }

        [JsonProperty("BookingID")]
        public int BookingId { get; set; }
        public string BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int BookingTypeId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInDateActual { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public bool CustomBit3 { get; set; }
        public bool CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public string DateBilled { get; set; }
        public string DateChargedTo { get; set; }
        public string DateModifiedBilling { get; set; }
        public int EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int EntryInvitationId { get; set; }
        public string EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double Excess { get; set; }

        [JsonProperty("GroupID")]
        public int GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int HousekeepingId { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfChildrenFree { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int PetCount { get; set; }
        public bool ResvChargeToEntry { get; set; }
        public bool RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public double RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
    }

    public class UpdateBookingInput
    {
        public int? AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }
        public UpdateBookingInputBookingLinkTypeEnumType? BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int? BookingTypeId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckInDateActual { get; set; }
        public string CheckOutDate { get; set; }
        public string CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public string ContractDateEnd { get; set; }
        public string ContractDateStart { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public bool? CustomBit3 { get; set; }
        public bool? CustomBit4 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomDate3 { get; set; }
        public string CustomDate4 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string CustomString7 { get; set; }
        public string CustomString8 { get; set; }
        public string CustomString9 { get; set; }
        public string CustomString10 { get; set; }
        public string DateBilled { get; set; }
        public string DateChargedTo { get; set; }
        public int? EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int? EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int? EntryInvitationId { get; set; }
        public UpdateBookingInputEntryStatusEnumType? EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public double? Excess { get; set; }

        [JsonProperty("GroupID")]
        public int? GroupId { get; set; }

        [JsonProperty("HousekeepingID")]
        public int? HousekeepingId { get; set; }
        public int? NumberOfChildren { get; set; }
        public int? NumberOfChildrenFree { get; set; }
        public int? NumberOfGuests { get; set; }
        public int? NumberOfGuestsFree { get; set; }
        public string PaidTo { get; set; }
        public int? PetCount { get; set; }
        public bool? ResvChargeToEntry { get; set; }
        public bool? RoomLocationFixed { get; set; }

        [JsonProperty("RoomLocationID")]
        public int? RoomLocationId { get; set; }
        public double? RoomRateAmount { get; set; }

        [JsonProperty("RoomRateID")]
        public int? RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int? RoomSpaceId { get; set; }

        [JsonProperty("RoomTypeID")]
        public int? RoomTypeId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public int? ServiceAnimalCount { get; set; }
        public string SpecialRequirement { get; set; }

        [JsonProperty("Start_BookingReasonID")]
        public int? StartBookingReasonId { get; set; }

        [JsonProperty("TermSessionID")]
        public int? TermSessionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateBookingInputBookingLinkTypeEnumType
    {
        None,
        Child,
        Parent,
        Reference
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateBookingInputEntryStatusEnumType
    {
        Account,
        Admin,
        Alumni,
        Application,
        Attendee,
        AttendeeArrived,
        AttendeeDeparted,
        Cancelled,
        Contact,
        Erased,
        Held,
        History,
        Incident,
        InRoom,
        MasterAccount,
        Occupant,
        OccupantHistory,
        OccupantInRoom,
        Reserved,
        Tentative
    }

    public class SelectRoomSpaceResponseItem
    {
        public bool AllocateExclude { get; set; }
        public int AllocateSortOrder { get; set; }
        public int Bathrooms { get; set; }
        public int BedCapacity { get; set; }
        public string Comments { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }

        [JsonProperty("ExtensionID")]
        public int ExtensionId { get; set; }
        public bool Hold { get; set; }
        public bool Networked { get; set; }
        public string RecordTypeEnum { get; set; }

        [JsonProperty("RoomBaseID")]
        public int RoomBaseId { get; set; }

        [JsonProperty("RoomID")]
        public int RoomId { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }
        public string RoomSpaceTypeEnum { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class SelectRoomSpaceInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectRoomSpaceInputPageSizeType PageSize { get; set; } = SelectRoomSpaceInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public bool? AllocateExclude { get; set; }
        public int? AllocateSortOrder { get; set; }
        public int? Bathrooms { get; set; }
        public int? BedCapacity { get; set; }
        public string Comments { get; set; }
        public SelectRoomSpaceInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }

        [JsonProperty("ExtensionID")]
        public int? ExtensionId { get; set; }
        public bool? Hold { get; set; }
        public bool? Networked { get; set; }
        public SelectRoomSpaceInputRecordTypeEnumType? RecordTypeEnum { get; set; }

        [JsonProperty("RoomBaseID")]
        public int? RoomBaseId { get; set; }

        [JsonProperty("RoomID")]
        public int? RoomId { get; set; }

        [JsonProperty("RoomRateID")]
        public int? RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int? RoomSpaceId { get; set; }
        public SelectRoomSpaceInputRoomSpaceTypeEnumType? RoomSpaceTypeEnum { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public int? SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

    public enum SelectRoomSpaceInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    public class SelectRoomSpaceInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceInputRecordTypeEnumType
    {
        Deleted,
        Normal,
        NotDeletableHidden,
        NotDeletableView,
        NotDeletableViewModify
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceInputRoomSpaceTypeEnumType
    {
        Admin,
        Bed,
        BedClosed,
        Public,
        Shared
    }

    public class CreateRoomSpaceResponse
    {
        public bool AllocateExclude { get; set; }
        public int AllocateSortOrder { get; set; }
        public int Bathrooms { get; set; }
        public int BedCapacity { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }

        [JsonProperty("ExtensionID")]
        public int ExtensionId { get; set; }
        public bool Hold { get; set; }
        public bool Networked { get; set; }
        public string RecordTypeEnum { get; set; }

        [JsonProperty("RoomBaseID")]
        public int RoomBaseId { get; set; }

        [JsonProperty("RoomID")]
        public int RoomId { get; set; }

        [JsonProperty("RoomRateID")]
        public int RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }
        public string RoomSpaceTypeEnum { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public int SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class CreateRoomSpaceInput
    {
        public bool? AllocateExclude { get; set; }
        public int? AllocateSortOrder { get; set; }
        public int? Bathrooms { get; set; }
        public int? BedCapacity { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }

        [JsonProperty("ExtensionID")]
        public int? ExtensionId { get; set; }
        public bool? Hold { get; set; }
        public bool? Networked { get; set; }
        public CreateRoomSpaceInputRecordTypeEnumType? RecordTypeEnum { get; set; }

        [JsonProperty("RoomBaseID")]
        public int? RoomBaseId { get; set; }

        [JsonProperty("RoomID")]
        public int? RoomId { get; set; }

        [JsonProperty("RoomRateID")]
        public int? RoomRateId { get; set; }
        public CreateRoomSpaceInputRoomSpaceTypeEnumType? RoomSpaceTypeEnum { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public int? SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateRoomSpaceInputRecordTypeEnumType
    {
        Deleted,
        Normal,
        NotDeletableHidden,
        NotDeletableView,
        NotDeletableViewModify
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateRoomSpaceInputRoomSpaceTypeEnumType
    {
        Admin,
        Bed,
        BedClosed,
        Public,
        Shared
    }

    public class SelectRoomLocationResponseItem
    {
        public int AllocateSortOrder { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryID")]
        public int CountryId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string GenderTypeEnum { get; set; }
        public bool Lease { get; set; }
        public bool ManagedExternally { get; set; }
        public bool NonResidential { get; set; }
        public string RecordTypeEnum { get; set; }

        [JsonProperty("RoomLocationAreaID")]
        public int RoomLocationAreaId { get; set; }

        [JsonProperty("RoomLocationID")]
        public int RoomLocationId { get; set; }
        public string StateProvince { get; set; }
        public bool ViewOnWeb { get; set; }
        public string WebComments { get; set; }
        public string WebDescription { get; set; }
        public string WebImageAltText { get; set; }
        public string WebImageLocation { get; set; }
        public string ZipPostcode { get; set; }
    }

    public class SelectRoomLocationInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectRoomLocationInputPageSizeType PageSize { get; set; } = SelectRoomLocationInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public int? AllocateSortOrder { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CountryID")]
        public int? CountryId { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public SelectRoomLocationInputCustomDate1Type CustomDate1 { get; set; }
        public SelectRoomLocationInputCustomDate2Type CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public SelectRoomLocationInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }
        public SelectRoomLocationInputGenderTypeEnumType? GenderTypeEnum { get; set; }
        public bool? Lease { get; set; }
        public bool? ManagedExternally { get; set; }
        public bool? NonResidential { get; set; }
        public SelectRoomLocationInputRecordTypeEnumType? RecordTypeEnum { get; set; }

        [JsonProperty("RoomLocationAreaID")]
        public int? RoomLocationAreaId { get; set; }

        [JsonProperty("RoomLocationID")]
        public int? RoomLocationId { get; set; }
        public string StateProvince { get; set; }
        public bool? ViewOnWeb { get; set; }
        public string WebComments { get; set; }
        public string WebDescription { get; set; }
        public string WebImageAltText { get; set; }
        public string WebImageLocation { get; set; }
        public string ZipPostcode { get; set; }
    }

    public enum SelectRoomLocationInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    public class SelectRoomLocationInputCustomDate1Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomLocationInputCustomDate1TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomLocationInputCustomDate1TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomLocationInputCustomDate2Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomLocationInputCustomDate2TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomLocationInputCustomDate2TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomLocationInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomLocationInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomLocationInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomLocationInputGenderTypeEnumType
    {
        [EnumMember(Value = "CoEd")]
        CoEducation,
        DynamicGender,
        Female,
        Male,
        Neutral
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomLocationInputRecordTypeEnumType
    {
        Deleted,
        Normal,
        NotDeletableHidden,
        NotDeletableView,
        NotDeletableViewModify
    }

    public class SelectTransactionResponseItem
    {
        public double Amount { get; set; }
        public string CallTypeEnum { get; set; }

        [JsonProperty("ChargeGroupID")]
        public int ChargeGroupId { get; set; }

        [JsonProperty("ChargeItemID")]
        public int ChargeItemId { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public string DateModified { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int Duration { get; set; }

        [JsonProperty("EndOfSessionID")]
        public int EndOfSessionId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public double Excess { get; set; }
        public int Extension { get; set; }

        [JsonProperty("ExternalID")]
        public int ExternalId { get; set; }

        [JsonProperty("ExternalReceiptID")]
        public string ExternalReceiptId { get; set; }

        [JsonProperty("InvoiceID")]
        public int InvoiceId { get; set; }
        public string PaidFrom { get; set; }
        public string PaidTo { get; set; }

        [JsonProperty("PaymentID")]
        public int PaymentId { get; set; }
        public string ProcessedDate { get; set; }

        [JsonProperty("Reference_BookingID")]
        public int ReferenceBookingId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TableID")]
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string Tag { get; set; }
        public string TagFinance { get; set; }
        public double TaxAmount { get; set; }
        public double TaxAmount2 { get; set; }
        public double TaxAmount3 { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
        public string TransactionDate { get; set; }

        [JsonProperty("TransactionID")]
        public int TransactionId { get; set; }
        public string TransactionTypeEnum { get; set; }
    }

    public class SelectTransactionInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectTransactionInputPageSizeType PageSize { get; set; } = SelectTransactionInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public double? Amount { get; set; }
        public SelectTransactionInputCallTypeEnumType? CallTypeEnum { get; set; }

        [JsonProperty("ChargeGroupID")]
        public int? ChargeGroupId { get; set; }

        [JsonProperty("ChargeItemID")]
        public int? ChargeItemId { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int? CreatedBySecurityUserId { get; set; }
        public SelectTransactionInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }
        public SelectTransactionInputDueDateType DueDate { get; set; }
        public int? Duration { get; set; }

        [JsonProperty("EndOfSessionID")]
        public int? EndOfSessionId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public double? Excess { get; set; }
        public int? Extension { get; set; }

        [JsonProperty("ExternalID")]
        public int? ExternalId { get; set; }

        [JsonProperty("ExternalReceiptID")]
        public string ExternalReceiptId { get; set; }

        [JsonProperty("InvoiceID")]
        public int? InvoiceId { get; set; }
        public SelectTransactionInputPaidFromType PaidFrom { get; set; }
        public SelectTransactionInputPaidToType PaidTo { get; set; }

        [JsonProperty("PaymentID")]
        public int? PaymentId { get; set; }
        public SelectTransactionInputProcessedDateType ProcessedDate { get; set; }

        [JsonProperty("Reference_BookingID")]
        public int? ReferenceBookingId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }

        [JsonProperty("TableID")]
        public int? TableId { get; set; }
        public string TableName { get; set; }
        public string Tag { get; set; }
        public string TagFinance { get; set; }
        public double? TaxAmount { get; set; }
        public double? TaxAmount2 { get; set; }
        public double? TaxAmount3 { get; set; }

        [JsonProperty("TermSessionID")]
        public int? TermSessionId { get; set; }
        public SelectTransactionInputTransactionDateType TransactionDate { get; set; }

        [JsonProperty("TransactionID")]
        public int? TransactionId { get; set; }
        public SelectTransactionInputTransactionTypeEnumType? TransactionTypeEnum { get; set; }
    }

    public enum SelectTransactionInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionInputCallTypeEnumType
    {
        Fixed,
        Free,
        International,
        Local,
        LongDistance,
        Mobile,
        None,
        Other
    }

    public class SelectTransactionInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTransactionInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTransactionInputDueDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTransactionInputDueDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionInputDueDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTransactionInputPaidFromType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTransactionInputPaidFromTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionInputPaidFromTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTransactionInputPaidToType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTransactionInputPaidToTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionInputPaidToTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTransactionInputProcessedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTransactionInputProcessedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionInputProcessedDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectTransactionInputTransactionDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectTransactionInputTransactionDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionInputTransactionDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionInputTransactionTypeEnumType
    {
        Adjustment,
        Charge,
        Payment,
        Refund,
        Telephone,
        Transfer
    }

    public class CreateTransactionResponse
    {
        public double Amount { get; set; }
        public string CallTypeEnum { get; set; }

        [JsonProperty("ChargeGroupID")]
        public int ChargeGroupId { get; set; }

        [JsonProperty("ChargeItemID")]
        public int ChargeItemId { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int Duration { get; set; }

        [JsonProperty("EndOfSessionID")]
        public int EndOfSessionId { get; set; }

        [JsonProperty("EntryID")]
        public int EntryId { get; set; }
        public double Excess { get; set; }
        public int Extension { get; set; }

        [JsonProperty("ExternalID")]
        public int ExternalId { get; set; }

        [JsonProperty("ExternalReceiptID")]
        public string ExternalReceiptId { get; set; }

        [JsonProperty("InvoiceID")]
        public int InvoiceId { get; set; }
        public string PaidFrom { get; set; }
        public string PaidTo { get; set; }

        [JsonProperty("PaymentID")]
        public int PaymentId { get; set; }
        public string ProcessedDate { get; set; }

        [JsonProperty("Reference_BookingID")]
        public int ReferenceBookingId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }

        [JsonProperty("TableID")]
        public int TableId { get; set; }
        public string TableName { get; set; }
        public string Tag { get; set; }
        public string TagFinance { get; set; }
        public double TaxAmount { get; set; }
        public double TaxAmount2 { get; set; }
        public double TaxAmount3 { get; set; }

        [JsonProperty("TermSessionID")]
        public int TermSessionId { get; set; }
        public string TransactionDate { get; set; }

        [JsonProperty("TransactionID")]
        public int TransactionId { get; set; }
        public string TransactionTypeEnum { get; set; }
    }

    public class CreateTransactionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
        public CreateTransactionInputCallTypeEnumType? CallTypeEnum { get; set; }

        [JsonProperty("ChargeGroupID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ChargeGroupId { get; set; }

        [JsonProperty("ChargeItemID")]
        public int? ChargeItemId { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int? Duration { get; set; }

        [JsonProperty("EndOfSessionID")]
        public int? EndOfSessionId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public double? Excess { get; set; }
        public int? Extension { get; set; }

        [JsonProperty("ExternalID")]
        public int? ExternalId { get; set; }

        [JsonProperty("ExternalReceiptID")]
        public string ExternalReceiptId { get; set; }

        [JsonProperty("InvoiceID")]
        public int? InvoiceId { get; set; }
        public string PaidFrom { get; set; }
        public string PaidTo { get; set; }

        [JsonProperty("PaymentID")]
        public int? PaymentId { get; set; }
        public string ProcessedDate { get; set; }

        [JsonProperty("Reference_BookingID")]
        public int? ReferenceBookingId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }

        [JsonProperty("TableID")]
        public int? TableId { get; set; }
        public string TableName { get; set; }
        public string Tag { get; set; }
        public string TagFinance { get; set; }
        public double? TaxAmount { get; set; }
        public double? TaxAmount2 { get; set; }
        public double? TaxAmount3 { get; set; }

        [JsonProperty("TermSessionID")]
        public int? TermSessionId { get; set; }
        public string TransactionDate { get; set; }
        public CreateTransactionInputTransactionTypeEnumType? TransactionTypeEnum { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTransactionInputCallTypeEnumType
    {
        Fixed,
        Free,
        International,
        Local,
        LongDistance,
        Mobile,
        None,
        Other
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTransactionInputTransactionTypeEnumType
    {
        Adjustment,
        Charge,
        Payment,
        Refund,
        Telephone,
        Transfer
    }

    public class SelectRoomSpaceMaintenanceResponseItem
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int ChargeEntryId { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateCreated { get; set; }
        public string DateDue { get; set; }
        public string DateModified { get; set; }
        public string DateReported { get; set; }
        public string Description { get; set; }
        public bool JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceID")]
        public int RoomSpaceMaintenanceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool ViewOnWeb { get; set; }
    }

    public class SelectRoomSpaceMaintenanceInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public SelectRoomSpaceMaintenanceInputPageSizeType PageSize { get; set; } = SelectRoomSpaceMaintenanceInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool? Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int? ChargeEntryId { get; set; }
        public double? ChargeAmount { get; set; }
        public bool? ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public SelectRoomSpaceMaintenanceInputCompleteDateType CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int? ContactId { get; set; }
        public SelectRoomSpaceMaintenanceInputContractDateType ContractDate { get; set; }
        public double? ContractorCost { get; set; }
        public double? ContractorCostEstimate { get; set; }
        public SelectRoomSpaceMaintenanceInputContractorDateType ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int? CreatedBySecurityUserId { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public SelectRoomSpaceMaintenanceInputCustomDate1Type CustomDate1 { get; set; }
        public SelectRoomSpaceMaintenanceInputCustomDate2Type CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public SelectRoomSpaceMaintenanceInputDateCreatedType DateCreated { get; set; }
        public SelectRoomSpaceMaintenanceInputDateDueType DateDue { get; set; }
        public SelectRoomSpaceMaintenanceInputDateModifiedType DateModified { get; set; }
        public SelectRoomSpaceMaintenanceInputDateReportedType DateReported { get; set; }
        public string Description { get; set; }
        public bool? JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int? OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool? OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int? PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int? RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int? RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int? RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceID")]
        public int? RoomSpaceMaintenanceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int? RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public SelectRoomSpaceMaintenanceInputStartDateType StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool? ViewOnWeb { get; set; }
    }

    public enum SelectRoomSpaceMaintenanceInputPageSizeType
    {
        _1 = 1,
        _5 = 5,
        _10 = 10,
        _50 = 50,
        _100 = 100,
        _500 = 500,
        _1000 = 1000
    }

    public class SelectRoomSpaceMaintenanceInputCompleteDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputCompleteDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputCompleteDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputContractDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputContractDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputContractDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputContractorDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputContractorDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputContractorDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputCustomDate1Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputCustomDate1TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputCustomDate1TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputCustomDate2Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputCustomDate2TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputCustomDate2TypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputDateCreatedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputDateCreatedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputDateCreatedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputDateDueType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputDateDueTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputDateDueTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputDateModifiedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputDateReportedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputDateReportedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputDateReportedTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class SelectRoomSpaceMaintenanceInputStartDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public SelectRoomSpaceMaintenanceInputStartDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectRoomSpaceMaintenanceInputStartDateTypeOperatorType
    {
        [EnumMember(Value = "GREATERTHAN")]
        GreaterThan,
        [EnumMember(Value = "LESSTHAN")]
        LessThan,
        [EnumMember(Value = "GREATERTHANOREQUALTO")]
        GreaterThanOrEqual,
        [EnumMember(Value = "LESSTHANOREQUALTO")]
        LessThanOrEqual
    }

    public class CreateRoomSpaceMaintenanceResponse
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int ChargeEntryId { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateCreated { get; set; }
        public string DateDue { get; set; }
        public string DateModified { get; set; }
        public string DateReported { get; set; }
        public string Description { get; set; }
        public bool JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceID")]
        public int RoomSpaceMaintenanceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool ViewOnWeb { get; set; }
    }

    public class CreateRoomSpaceMaintenanceInput
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool? Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int? ChargeEntryId { get; set; }
        public double? ChargeAmount { get; set; }
        public bool? ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int? ContactId { get; set; }
        public string ContractDate { get; set; }
        public double? ContractorCost { get; set; }
        public double? ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateDue { get; set; }
        public string DateReported { get; set; }
        public string Description { get; set; }
        public bool? JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int? OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool? OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int? PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int? RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int? RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int? RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool? ViewOnWeb { get; set; }
    }

    public class UpdateRoomSpaceMaintenanceResponse
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int ChargeEntryId { get; set; }
        public double ChargeAmount { get; set; }
        public bool ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int ContactId { get; set; }
        public string ContractDate { get; set; }
        public double ContractorCost { get; set; }
        public double ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int CreatedBySecurityUserId { get; set; }
        public bool CustomBit1 { get; set; }
        public bool CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateCreated { get; set; }
        public string DateDue { get; set; }
        public string DateModified { get; set; }
        public string DateReported { get; set; }
        public string Description { get; set; }
        public bool JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceID")]
        public int RoomSpaceMaintenanceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int SecurityUserId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool ViewOnWeb { get; set; }
    }

    public class UpdateRoomSpaceMaintenanceInput
    {
        public string AccountCode { get; set; }
        public string Cause { get; set; }
        public bool? Charge { get; set; }

        [JsonProperty("Charge_EntryID")]
        public int? ChargeEntryId { get; set; }
        public double? ChargeAmount { get; set; }
        public bool? ChargeInvoiced { get; set; }
        public string ChargeInvoiceNumber { get; set; }
        public string ChargeType { get; set; }
        public string CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int? ContactId { get; set; }
        public string ContractDate { get; set; }
        public double? ContractorCost { get; set; }
        public double? ContractorCostEstimate { get; set; }
        public string ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public string CustomDate1 { get; set; }
        public string CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public string DateDue { get; set; }
        public string DateReported { get; set; }
        public string Description { get; set; }
        public bool? JobSent { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }

        [JsonProperty("Occupant_EntryID")]
        public int? OccupantEntryId { get; set; }
        public string OccupantEntryName { get; set; }
        public bool? OccupantPresent { get; set; }
        public string OccupantPresentReason { get; set; }
        public string OtherServiceNumber { get; set; }

        [JsonProperty("PriorityID")]
        public int? PriorityId { get; set; }
        public string RepairDescription { get; set; }
        public string ReportedByName { get; set; }
        public string ReportedByPhone { get; set; }

        [JsonProperty("RoomSpaceClosedID")]
        public int? RoomSpaceClosedId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int? RoomSpaceId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceCategoryID")]
        public int? RoomSpaceMaintenanceCategoryId { get; set; }

        [JsonProperty("RoomSpaceMaintenanceItemID")]
        public int? RoomSpaceMaintenanceItemId { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public string StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool? ViewOnWeb { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1;

    public partial class WorkflowManagedActions
    {
        public Starrezrestv1Actions Starrezrestv1(string connectionId) => new Starrezrestv1Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Starrezrestv1Triggers Starrezrestv1(string connectionId) => new Starrezrestv1Triggers(connectionId);
    }
}