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
        public IBodyWorkflowAction<SelectEntryResponseItem[], ApiConnectionActionConfiguration> SelectEntry(Expression<Func<SelectEntryBodyInput>> body)
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
        public IBodyWorkflowAction<CreateEntryResponse, ApiConnectionActionConfiguration> CreateEntry(Expression<Func<CreateEntryBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateEntryResponse, ApiConnectionActionConfiguration> UpdateEntry(Expression<Func<int>> entryId, Expression<Func<UpdateEntryBodyInput>> body)
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Delete(Expression<Func<TableNameInput>> tableName, Expression<Func<int>> rowId)
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
        public IBodyWorkflowAction<SelectEntryCustomFieldResponseItem[], ApiConnectionActionConfiguration> SelectEntryCustomField(Expression<Func<SelectEntryCustomFieldBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateEntryCustomFieldResponse, ApiConnectionActionConfiguration> UpdateEntryCustomField(Expression<Func<int>> entryCustomFieldId, Expression<Func<UpdateEntryCustomFieldBodyInput>> body)
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
        public IBodyWorkflowAction<SelectTermResponseItem[], ApiConnectionActionConfiguration> SelectTerm(Expression<Func<SelectTermBodyInput>> body)
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
        public IBodyWorkflowAction<SelectEntryAddressResponseItem[], ApiConnectionActionConfiguration> SelectEntryAddress(Expression<Func<SelectEntryAddressBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateEntryAddressResponse, ApiConnectionActionConfiguration> UpdateEntryAddress(Expression<Func<int>> entryAddressId, Expression<Func<UpdateEntryAddressBodyInput>> body)
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
        public IBodyWorkflowAction<SelectEntryApplicationResponseItem[], ApiConnectionActionConfiguration> SelectEntryApplication(Expression<Func<SelectEntryApplicationBodyInput>> body)
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
        public IBodyWorkflowAction<CreateEntryApplicationResponse, ApiConnectionActionConfiguration> CreateEntryApplication(Expression<Func<CreateEntryApplicationBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateEntryApplicationResponse, ApiConnectionActionConfiguration> UpdateEntryApplication(Expression<Func<int>> entryApplicationId, Expression<Func<UpdateEntryApplicationBodyInput>> body)
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
        public IBodyWorkflowAction<SelectTermSessionResponseItem[], ApiConnectionActionConfiguration> SelectTermSession(Expression<Func<SelectTermSessionBodyInput>> body)
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
        public IBodyWorkflowAction<SelectEntryDetailResponseItem[], ApiConnectionActionConfiguration> SelectEntryDetail(Expression<Func<SelectEntryDetailBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateEntryDetailResponse, ApiConnectionActionConfiguration> UpdateEntryDetail(Expression<Func<int>> entryDetailId, Expression<Func<UpdateEntryDetailBodyInput>> body)
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
        public IBodyWorkflowAction<SelectEntryEnrollmentResponseItem[], ApiConnectionActionConfiguration> SelectEntryEnrollment(Expression<Func<SelectEntryEnrollmentBodyInput>> body)
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
        public IBodyWorkflowAction<CreateEntryEnrollmentResponse, ApiConnectionActionConfiguration> CreateEntryEnrollment(Expression<Func<CreateEntryEnrollmentBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateEntryEnrollmentResponse, ApiConnectionActionConfiguration> UpdateEntryEnrollment(Expression<Func<int>> entryEnrollmentId, Expression<Func<UpdateEntryEnrollmentBodyInput>> body)
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
        public IBodyWorkflowAction<SelectBookingResponseItem[], ApiConnectionActionConfiguration> SelectBooking(Expression<Func<SelectBookingBodyInput>> body)
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
        public IBodyWorkflowAction<CreateBookingResponse, ApiConnectionActionConfiguration> CreateBooking(Expression<Func<CreateBookingBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateBookingResponse, ApiConnectionActionConfiguration> UpdateBooking(Expression<Func<int>> bookingId, Expression<Func<UpdateBookingBodyInput>> body)
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
        public IBodyWorkflowAction<SelectRoomSpaceResponseItem[], ApiConnectionActionConfiguration> SelectRoomSpace(Expression<Func<SelectRoomSpaceBodyInput>> body)
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
        public IBodyWorkflowAction<CreateRoomSpaceResponse, ApiConnectionActionConfiguration> CreateRoomSpace(Expression<Func<CreateRoomSpaceBodyInput>> body)
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
        public IBodyWorkflowAction<SelectRoomLocationResponseItem[], ApiConnectionActionConfiguration> SelectRoomLocation(Expression<Func<SelectRoomLocationBodyInput>> body)
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
        public IBodyWorkflowAction<SelectTransactionResponseItem[], ApiConnectionActionConfiguration> SelectTransaction(Expression<Func<SelectTransactionBodyInput>> body)
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
        public IBodyWorkflowAction<CreateTransactionResponse, ApiConnectionActionConfiguration> CreateTransaction(Expression<Func<CreateTransactionBodyInput>> body)
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
        public IBodyWorkflowAction<SelectRoomSpaceMaintenanceResponseItem[], ApiConnectionActionConfiguration> SelectRoomSpaceMaintenance(Expression<Func<SelectRoomSpaceMaintenanceBodyInput>> body)
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
        public IBodyWorkflowAction<CreateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration> CreateRoomSpaceMaintenance(Expression<Func<CreateRoomSpaceMaintenanceBodyInput>> body)
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
        public IBodyWorkflowAction<UpdateRoomSpaceMaintenanceResponse, ApiConnectionActionConfiguration> UpdateRoomSpaceMaintenance(Expression<Func<int>> roomSpaceMaintenanceId, Expression<Func<UpdateRoomSpaceMaintenanceBodyInput>> body = null)
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

    public class SelectEntryBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }

        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public BodyInputBirthGenderEnumType? BirthGenderEnum { get; set; }

        [JsonProperty("BookingID")]
        public int? BookingId { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryId { get; set; }
        public string ConferenceEmail { get; set; }

        [JsonProperty("ContactID")]
        public int? ContactId { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int? CreatedBySecurityUserId { get; set; }
        public BodyInputDateCreatedType DateCreated { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public bool? DirectoryFlagPrivacy { get; set; }
        public BodyInputDOBType DOB { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int? EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public BodyInputEntryStatusEnumType? EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int? EventId { get; set; }
        public BodyInputGenderEnumType? GenderEnum { get; set; }
        public string ID1 { get; set; }
        public string ID2 { get; set; }
        public string ID3 { get; set; }
        public int? ID4 { get; set; }
        public int? ID5 { get; set; }
        public BodyInputLastCheckInOutDateType LastCheckInOutDate { get; set; }
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
        public BodyInputPreviousEntryStatusEnumType? PreviousEntryStatusEnum { get; set; }
        public BodyInputTaxExemptionEnumType? TaxExemptionEnum { get; set; }
        public bool? Testing { get; set; }
    }

    public enum BodyInputPageSizeType
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
    public enum BodyInputBirthGenderEnumType
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    public class BodyInputDateCreatedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateCreatedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateCreatedTypeOperatorType
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

    public class BodyInputDateModifiedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateModifiedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateModifiedTypeOperatorType
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

    public class BodyInputDOBType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDOBTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDOBTypeOperatorType
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
    public enum BodyInputEntryStatusEnumType
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
    public enum BodyInputGenderEnumType
    {
        Female,
        Male,
        Neutral,
        Other,
        Unknown
    }

    public class BodyInputLastCheckInOutDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputLastCheckInOutDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLastCheckInOutDateTypeOperatorType
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
    public enum BodyInputPreviousEntryStatusEnumType
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
    public enum BodyInputTaxExemptionEnumType
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

    public class CreateEntryBodyInput
    {
        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public BodyInputBirthGenderEnumType? BirthGenderEnum { get; set; }

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
        public BodyInputEntryStatusEnumType? EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int? EventId { get; set; }
        public BodyInputGenderEnumType? GenderEnum { get; set; }
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
        public BodyInputPreviousEntryStatusEnumType? PreviousEntryStatusEnum { get; set; }
        public BodyInputTaxExemptionEnumType? TaxExemptionEnum { get; set; }
        public bool? Testing { get; set; }
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

    public class UpdateEntryBodyInput
    {
        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }

        [JsonProperty("Birth_GenderEnum")]
        public BodyInputBirthGenderEnumType? BirthGenderEnum { get; set; }

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
        public BodyInputEntryStatusEnumType? EntryStatusEnum { get; set; }

        [JsonProperty("EventID")]
        public int? EventId { get; set; }
        public BodyInputGenderEnumType? GenderEnum { get; set; }
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
        public BodyInputPreviousEntryStatusEnumType? PreviousEntryStatusEnum { get; set; }
        public BodyInputTaxExemptionEnumType? TaxExemptionEnum { get; set; }
        public bool? Testing { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TableNameInput
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

    public class SelectEntryCustomFieldBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }

        [JsonProperty("CustomFieldDefinitionID")]
        public int? CustomFieldDefinitionId { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }

        [JsonProperty("EntryCustomFieldID")]
        public int? EntryCustomFieldId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public BodyInputFieldDataTypeEnumType? FieldDataTypeEnum { get; set; }
        public bool? ValueBoolean { get; set; }
        public BodyInputValueDateType ValueDate { get; set; }
        public int? ValueInteger { get; set; }
        public double? ValueMoney { get; set; }
        public string ValueString { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFieldDataTypeEnumType
    {
        Boolean,
        Date,
        DateTime,
        Integer,
        Money,
        String,
        StringLong
    }

    public class BodyInputValueDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputValueDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputValueDateTypeOperatorType
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

    public class UpdateEntryCustomFieldBodyInput
    {
        [JsonProperty("CustomFieldDefinitionID")]
        public int? CustomFieldDefinitionId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public BodyInputFieldDataTypeEnumType? FieldDataTypeEnum { get; set; }
        public bool? ValueBoolean { get; set; }
        public string ValueDate { get; set; }
        public int? ValueInteger { get; set; }
        public double? ValueMoney { get; set; }
        public string ValueString { get; set; }
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

    public class SelectTermBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public bool? Active { get; set; }
        public BodyInputActiveDateCloseType ActiveDateClose { get; set; }
        public BodyInputActiveDateOpenType ActiveDateOpen { get; set; }

        [JsonProperty("CategoryID")]
        public int? CategoryId { get; set; }
        public string Comments { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }
        public BodyInputRecordTypeEnumType? RecordTypeEnum { get; set; }
        public string TermCode { get; set; }

        [JsonProperty("TermID")]
        public int? TermId { get; set; }

        [JsonProperty("TermTypeID")]
        public int? TermTypeId { get; set; }
        public string WebDescription { get; set; }
    }

    public class BodyInputActiveDateCloseType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputActiveDateCloseTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputActiveDateCloseTypeOperatorType
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

    public class BodyInputActiveDateOpenType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputActiveDateOpenTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputActiveDateOpenTypeOperatorType
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
    public enum BodyInputRecordTypeEnumType
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

    public class SelectEntryAddressBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public BodyInputActiveDateEndType ActiveDateEnd { get; set; }
        public BodyInputActiveDateStartType ActiveDateStart { get; set; }

        [JsonProperty("AddressTypeID")]
        public int? AddressTypeId { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContactName { get; set; }
        public string ContactName2 { get; set; }

        [JsonProperty("CountryID")]
        public int? CountryId { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
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

    public class BodyInputActiveDateEndType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputActiveDateEndTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputActiveDateEndTypeOperatorType
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

    public class BodyInputActiveDateStartType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputActiveDateStartTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputActiveDateStartTypeOperatorType
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

    public class UpdateEntryAddressBodyInput
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

    public class SelectEntryApplicationBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public BodyInputAllocateOptionEnumType? AllocateOptionEnum { get; set; }
        public BodyInputApplicationDateType ApplicationDate { get; set; }

        [JsonProperty("ApplicationStatusID")]
        public int? ApplicationStatusId { get; set; }
        public BodyInputCancelDateType CancelDate { get; set; }

        [JsonProperty("ClassificationID")]
        public int? ClassificationId { get; set; }
        public string Comments { get; set; }
        public string CommentsInternal { get; set; }
        public BodyInputCompleteDateType CompleteDate { get; set; }
        public BodyInputContractSignedDateType ContractSignedDate { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public bool? CustomBit3 { get; set; }
        public bool? CustomBit4 { get; set; }
        public BodyInputCustomDate1Type CustomDate1 { get; set; }
        public BodyInputCustomDate2Type CustomDate2 { get; set; }
        public BodyInputCustomDate3Type CustomDate3 { get; set; }
        public BodyInputCustomDate4Type CustomDate4 { get; set; }
        public BodyInputDateCreatedType DateCreated { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public BodyInputEnquiryDateType EnquiryDate { get; set; }

        [JsonProperty("EntryApplicationID")]
        public int? EntryApplicationId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public BodyInputExpectedArrivalDateType ExpectedArrivalDate { get; set; }
        public BodyInputExpectedArrivalDateLatestType ExpectedArrivalDateLatest { get; set; }
        public BodyInputExpectedDepartureDateType ExpectedDepartureDate { get; set; }
        public BodyInputOfferedDateType OfferedDate { get; set; }
        public BodyInputOfferReplyDateType OfferReplyDate { get; set; }
        public BodyInputOfferReplyEnumType? OfferReplyEnum { get; set; }
        public string OfferReplyReason { get; set; }
        public BodyInputOfferSentDateType OfferSentDate { get; set; }
        public bool? PortalTrackingOnly { get; set; }
        public string PreferenceComments { get; set; }
        public string Rating { get; set; }
        public BodyInputReceivedDateType ReceivedDate { get; set; }
        public bool? ReceivedDeposit { get; set; }
        public bool? ReceivedDepositWaived { get; set; }

        [JsonProperty("ReceivedDeposit_PaymentID")]
        public int? ReceivedDepositPaymentId { get; set; }

        [JsonProperty("ReceivedDeposit_WebPaymentID")]
        public int? ReceivedDepositWebPaymentId { get; set; }
        public double? ReceivedDepositAmount { get; set; }
        public BodyInputReceivedDepositDateType ReceivedDepositDate { get; set; }
        public bool? ReceivedFee { get; set; }

        [JsonProperty("ReceivedFee_PaymentID")]
        public int? ReceivedFeePaymentId { get; set; }

        [JsonProperty("ReceivedFee_WebPaymentID")]
        public int? ReceivedFeeWebPaymentId { get; set; }
        public double? ReceivedFeeAmount { get; set; }
        public BodyInputReceivedFeeDateType ReceivedFeeDate { get; set; }
        public BodyInputReceivedPhotoDateType ReceivedPhotoDate { get; set; }
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
    public enum BodyInputAllocateOptionEnumType
    {
        PreferRoomMates,
        PreferRoomPreferences
    }

    public class BodyInputApplicationDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputApplicationDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputApplicationDateTypeOperatorType
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

    public class BodyInputCancelDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCancelDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCancelDateTypeOperatorType
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

    public class BodyInputCompleteDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCompleteDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCompleteDateTypeOperatorType
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

    public class BodyInputContractSignedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputContractSignedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractSignedDateTypeOperatorType
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

    public class BodyInputCustomDate1Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCustomDate1TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCustomDate1TypeOperatorType
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

    public class BodyInputCustomDate2Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCustomDate2TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCustomDate2TypeOperatorType
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

    public class BodyInputCustomDate3Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCustomDate3TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCustomDate3TypeOperatorType
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

    public class BodyInputCustomDate4Type
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCustomDate4TypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCustomDate4TypeOperatorType
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

    public class BodyInputEnquiryDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputEnquiryDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEnquiryDateTypeOperatorType
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

    public class BodyInputExpectedArrivalDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputExpectedArrivalDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputExpectedArrivalDateTypeOperatorType
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

    public class BodyInputExpectedArrivalDateLatestType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputExpectedArrivalDateLatestTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputExpectedArrivalDateLatestTypeOperatorType
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

    public class BodyInputExpectedDepartureDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputExpectedDepartureDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputExpectedDepartureDateTypeOperatorType
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

    public class BodyInputOfferedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputOfferedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOfferedDateTypeOperatorType
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

    public class BodyInputOfferReplyDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputOfferReplyDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOfferReplyDateTypeOperatorType
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
    public enum BodyInputOfferReplyEnumType
    {
        Accepted,
        Declined,
        Deferred,
        NA
    }

    public class BodyInputOfferSentDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputOfferSentDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOfferSentDateTypeOperatorType
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

    public class BodyInputReceivedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputReceivedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputReceivedDateTypeOperatorType
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

    public class BodyInputReceivedDepositDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputReceivedDepositDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputReceivedDepositDateTypeOperatorType
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

    public class BodyInputReceivedFeeDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputReceivedFeeDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputReceivedFeeDateTypeOperatorType
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

    public class BodyInputReceivedPhotoDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputReceivedPhotoDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputReceivedPhotoDateTypeOperatorType
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

    public class CreateEntryApplicationBodyInput
    {
        public BodyInputAllocateOptionEnumType? AllocateOptionEnum { get; set; }
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
        public BodyInputOfferReplyEnumType? OfferReplyEnum { get; set; }
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

    public class UpdateEntryApplicationBodyInput
    {
        public BodyInputAllocateOptionEnumType? AllocateOptionEnum { get; set; }
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
        public BodyInputOfferReplyEnumType? OfferReplyEnum { get; set; }
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

    public class SelectTermSessionBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }

        [JsonProperty("BookingTypeID")]
        public int? BookingTypeId { get; set; }

        [JsonProperty("CancelBookingDefaultEnd_BookingReasonID")]
        public int? CancelBookingDefaultEndBookingReasonId { get; set; }

        [JsonProperty("CancelBookingUpdateEndBookingReason_BooleanAskEnum")]
        public BodyInputCancelBookingUpdateEndBookingReasonBooleanAskEnumType? CancelBookingUpdateEndBookingReasonBooleanAskEnum { get; set; }
        public BodyInputCheckInDateType CheckInDate { get; set; }

        [JsonProperty("CheckInDateActualDecrease_BooleanAskEnum")]
        public BodyInputCheckInDateActualDecreaseBooleanAskEnumType? CheckInDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDateActualIncrease_BooleanAskEnum")]
        public BodyInputCheckInDateActualIncreaseBooleanAskEnumType? CheckInDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckInDefaultStart_BookingReasonID")]
        public int? CheckInDefaultStartBookingReasonId { get; set; }

        [JsonProperty("CheckInUpdateStartBookingReason_BooleanAskEnum")]
        public BodyInputCheckInUpdateStartBookingReasonBooleanAskEnumType? CheckInUpdateStartBookingReasonBooleanAskEnum { get; set; }
        public BodyInputCheckOutDateType CheckOutDate { get; set; }

        [JsonProperty("CheckOutDateActualDecrease_BooleanAskEnum")]
        public BodyInputCheckOutDateActualDecreaseBooleanAskEnumType? CheckOutDateActualDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDateActualIncrease_BooleanAskEnum")]
        public BodyInputCheckOutDateActualIncreaseBooleanAskEnumType? CheckOutDateActualIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("CheckOutDefaultEnd_BookingReasonID")]
        public int? CheckOutDefaultEndBookingReasonId { get; set; }

        [JsonProperty("CheckOutUpdateEndBookingReason_BooleanAskEnum")]
        public BodyInputCheckOutUpdateEndBookingReasonBooleanAskEnumType? CheckOutUpdateEndBookingReasonBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckInDecrease_BooleanAskEnum")]
        public BodyInputContractDateCheckInDecreaseBooleanAskEnumType? ContractDateCheckInDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckInIncrease_BooleanAskEnum")]
        public BodyInputContractDateCheckInIncreaseBooleanAskEnumType? ContractDateCheckInIncreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckOutDecrease_BooleanAskEnum")]
        public BodyInputContractDateCheckOutDecreaseBooleanAskEnumType? ContractDateCheckOutDecreaseBooleanAskEnum { get; set; }

        [JsonProperty("ContractDateCheckOutIncrease_BooleanAskEnum")]
        public BodyInputContractDateCheckOutIncreaseBooleanAskEnumType? ContractDateCheckOutIncreaseBooleanAskEnum { get; set; }
        public BodyInputContractDateEndType ContractDateEnd { get; set; }
        public BodyInputContractDateStartType ContractDateStart { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public BodyInputCustomDate1Type CustomDate1 { get; set; }
        public BodyInputCustomDate2Type CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int? EndBookingReasonId { get; set; }
        public BodyInputEntryStatusEnumType? EntryStatusEnum { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }

        [JsonProperty("HousekeepingID")]
        public int? HousekeepingId { get; set; }
        public BodyInputRecordTypeEnumType? RecordTypeEnum { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCancelBookingUpdateEndBookingReasonBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    public class BodyInputCheckInDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCheckInDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckInDateTypeOperatorType
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
    public enum BodyInputCheckInDateActualDecreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckInDateActualIncreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckInUpdateStartBookingReasonBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    public class BodyInputCheckOutDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCheckOutDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckOutDateTypeOperatorType
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
    public enum BodyInputCheckOutDateActualDecreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckOutDateActualIncreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckOutUpdateEndBookingReasonBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractDateCheckInDecreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractDateCheckInIncreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractDateCheckOutDecreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractDateCheckOutIncreaseBooleanAskEnumType
    {
        Ask,
        No,
        Yes
    }

    public class BodyInputContractDateEndType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputContractDateEndTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractDateEndTypeOperatorType
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

    public class BodyInputContractDateStartType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputContractDateStartTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractDateStartTypeOperatorType
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

    public class SelectEntryDetailBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

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
        public BodyInputAccountDueDateType AccountDueDate { get; set; }
        public bool? Athlete { get; set; }
        public string AthleteTeam { get; set; }
        public BodyInputAttendeeStatusEnumType? AttendeeStatusEnum { get; set; }
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
        public BodyInputDateEntryType DateEntry { get; set; }
        public BodyInputDateExitType DateExit { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public bool? Deceased { get; set; }
        public BodyInputDeceasedDateType DeceasedDate { get; set; }
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
        public BodyInputExpectedGraduationDateType ExpectedGraduationDate { get; set; }
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
        public BodyInputSituationResponseEnumType? SituationResponseEnum { get; set; }
        public BodyInputSituationResponseExpiryDateType SituationResponseExpiryDate { get; set; }
        public BodyInputSituationResponseModifiedDateType SituationResponseModifiedDate { get; set; }
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

    public class BodyInputAccountDueDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputAccountDueDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAccountDueDateTypeOperatorType
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
    public enum BodyInputAttendeeStatusEnumType
    {
        Arrived,
        Confirmed,
        Departed,
        NA,
        Other,
        Registered
    }

    public class BodyInputDateEntryType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateEntryTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateEntryTypeOperatorType
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

    public class BodyInputDateExitType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateExitTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateExitTypeOperatorType
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

    public class BodyInputDeceasedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDeceasedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDeceasedDateTypeOperatorType
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

    public class BodyInputExpectedGraduationDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputExpectedGraduationDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputExpectedGraduationDateTypeOperatorType
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
    public enum BodyInputSituationResponseEnumType
    {
        NoResponse,
        NotOkay,
        Okay
    }

    public class BodyInputSituationResponseExpiryDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputSituationResponseExpiryDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSituationResponseExpiryDateTypeOperatorType
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

    public class BodyInputSituationResponseModifiedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputSituationResponseModifiedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSituationResponseModifiedDateTypeOperatorType
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

    public class UpdateEntryDetailBodyInput
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
        public BodyInputAttendeeStatusEnumType? AttendeeStatusEnum { get; set; }
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
        public BodyInputSituationResponseEnumType? SituationResponseEnum { get; set; }
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

    public class SelectEntryEnrollmentBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

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
        public BodyInputCustomDate1Type CustomDate1 { get; set; }
        public BodyInputCustomDate2Type CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public BodyInputDateEndType DateEnd { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public BodyInputDateStartType DateStart { get; set; }
        public string Department { get; set; }
        public string EnrollmentField { get; set; }
        public int? EnrollmentOrder { get; set; }
        public BodyInputEnrollmentTypeEnumType? EnrollmentTypeEnum { get; set; }

        [JsonProperty("EntryEnrollmentID")]
        public int? EntryEnrollmentId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }
        public string Faculty { get; set; }
        public bool? FullTime { get; set; }
        public BodyInputGraduationDateType GraduationDate { get; set; }
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

    public class BodyInputDateEndType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateEndTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateEndTypeOperatorType
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

    public class BodyInputDateStartType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateStartTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateStartTypeOperatorType
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
    public enum BodyInputEnrollmentTypeEnumType
    {
        Current,
        Preferred,
        Previous
    }

    public class BodyInputGraduationDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputGraduationDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGraduationDateTypeOperatorType
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

    public class CreateEntryEnrollmentBodyInput
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
        public BodyInputEnrollmentTypeEnumType? EnrollmentTypeEnum { get; set; }

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

    public class UpdateEntryEnrollmentBodyInput
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
        public BodyInputEnrollmentTypeEnumType? EnrollmentTypeEnum { get; set; }

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

    public class SelectBookingBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public int? AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }

        [JsonProperty("BookingID")]
        public int? BookingId { get; set; }
        public BodyInputBookingLinkTypeEnumType? BookingLinkTypeEnum { get; set; }

        [JsonProperty("BookingTypeID")]
        public int? BookingTypeId { get; set; }
        public BodyInputCheckInDateType CheckInDate { get; set; }
        public BodyInputCheckInDateActualType CheckInDateActual { get; set; }
        public BodyInputCheckOutDateType CheckOutDate { get; set; }
        public BodyInputCheckOutDateActualType CheckOutDateActual { get; set; }
        public string Comments { get; set; }
        public BodyInputContractDateEndType ContractDateEnd { get; set; }
        public BodyInputContractDateStartType ContractDateStart { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public bool? CustomBit3 { get; set; }
        public bool? CustomBit4 { get; set; }
        public BodyInputCustomDate1Type CustomDate1 { get; set; }
        public BodyInputCustomDate2Type CustomDate2 { get; set; }
        public BodyInputCustomDate3Type CustomDate3 { get; set; }
        public BodyInputCustomDate4Type CustomDate4 { get; set; }
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
        public BodyInputDateBilledType DateBilled { get; set; }
        public BodyInputDateChargedToType DateChargedTo { get; set; }
        public BodyInputDateCreatedType DateCreated { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public BodyInputDateModifiedBillingType DateModifiedBilling { get; set; }
        public int? EmotionalSupportAnimalCount { get; set; }

        [JsonProperty("End_BookingReasonID")]
        public int? EndBookingReasonId { get; set; }

        [JsonProperty("EntryID")]
        public int? EntryId { get; set; }

        [JsonProperty("EntryInvitationID")]
        public int? EntryInvitationId { get; set; }
        public BodyInputEntryStatusEnumType? EntryStatusEnum { get; set; }
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
        public BodyInputPaidToType PaidTo { get; set; }
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
    public enum BodyInputBookingLinkTypeEnumType
    {
        None,
        Child,
        Parent,
        Reference
    }

    public class BodyInputCheckInDateActualType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCheckInDateActualTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckInDateActualTypeOperatorType
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

    public class BodyInputCheckOutDateActualType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputCheckOutDateActualTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckOutDateActualTypeOperatorType
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

    public class BodyInputDateBilledType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateBilledTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateBilledTypeOperatorType
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

    public class BodyInputDateChargedToType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateChargedToTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateChargedToTypeOperatorType
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

    public class BodyInputDateModifiedBillingType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateModifiedBillingTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateModifiedBillingTypeOperatorType
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

    public class BodyInputPaidToType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputPaidToTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPaidToTypeOperatorType
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

    public class CreateBookingBodyInput
    {
        public int? AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }
        public BodyInputBookingLinkTypeEnumType? BookingLinkTypeEnum { get; set; }

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
        public BodyInputEntryStatusEnumType? EntryStatusEnum { get; set; }
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

    public class UpdateBookingBodyInput
    {
        public int? AdditionalOccupantCount { get; set; }
        public string AutoAllocationDetail { get; set; }
        public BodyInputBookingLinkTypeEnumType? BookingLinkTypeEnum { get; set; }

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
        public BodyInputEntryStatusEnumType? EntryStatusEnum { get; set; }
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

    public class SelectRoomSpaceBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public bool? AllocateExclude { get; set; }
        public int? AllocateSortOrder { get; set; }
        public int? Bathrooms { get; set; }
        public int? BedCapacity { get; set; }
        public string Comments { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }

        [JsonProperty("ExtensionID")]
        public int? ExtensionId { get; set; }
        public bool? Hold { get; set; }
        public bool? Networked { get; set; }
        public BodyInputRecordTypeEnumType? RecordTypeEnum { get; set; }

        [JsonProperty("RoomBaseID")]
        public int? RoomBaseId { get; set; }

        [JsonProperty("RoomID")]
        public int? RoomId { get; set; }

        [JsonProperty("RoomRateID")]
        public int? RoomRateId { get; set; }

        [JsonProperty("RoomSpaceID")]
        public int? RoomSpaceId { get; set; }
        public BodyInputRoomSpaceTypeEnumType? RoomSpaceTypeEnum { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public int? SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRoomSpaceTypeEnumType
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

    public class CreateRoomSpaceBodyInput
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
        public BodyInputRecordTypeEnumType? RecordTypeEnum { get; set; }

        [JsonProperty("RoomBaseID")]
        public int? RoomBaseId { get; set; }

        [JsonProperty("RoomID")]
        public int? RoomId { get; set; }

        [JsonProperty("RoomRateID")]
        public int? RoomRateId { get; set; }
        public BodyInputRoomSpaceTypeEnumType? RoomSpaceTypeEnum { get; set; }

        [JsonProperty("SecurityUserID")]
        public int? SecurityUserId { get; set; }
        public int? SortOrder { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string WebDescription { get; set; }
        public string ZipPostcode { get; set; }
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

    public class SelectRoomLocationBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

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
        public BodyInputCustomDate1Type CustomDate1 { get; set; }
        public BodyInputCustomDate2Type CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }
        public BodyInputGenderTypeEnumType? GenderTypeEnum { get; set; }
        public bool? Lease { get; set; }
        public bool? ManagedExternally { get; set; }
        public bool? NonResidential { get; set; }
        public BodyInputRecordTypeEnumType? RecordTypeEnum { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGenderTypeEnumType
    {
        [EnumMember(Value = "CoEd")]
        CoEducation,
        DynamicGender,
        Female,
        Male,
        Neutral
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

    public class SelectTransactionBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

        [JsonProperty("_pageIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; } = 0;

        [JsonProperty("_orderby")]
        public string Orderby { get; set; }
        public double? Amount { get; set; }
        public SelectTransactionBodyInputCallTypeEnumType? CallTypeEnum { get; set; }

        [JsonProperty("ChargeGroupID")]
        public int? ChargeGroupId { get; set; }

        [JsonProperty("ChargeItemID")]
        public int? ChargeItemId { get; set; }
        public string Comments { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int? CreatedBySecurityUserId { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public string Description { get; set; }
        public BodyInputDueDateType DueDate { get; set; }
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
        public BodyInputPaidFromType PaidFrom { get; set; }
        public BodyInputPaidToType PaidTo { get; set; }

        [JsonProperty("PaymentID")]
        public int? PaymentId { get; set; }
        public BodyInputProcessedDateType ProcessedDate { get; set; }

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
        public BodyInputTransactionDateType TransactionDate { get; set; }

        [JsonProperty("TransactionID")]
        public int? TransactionId { get; set; }
        public BodyInputTransactionTypeEnumType? TransactionTypeEnum { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectTransactionBodyInputCallTypeEnumType
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

    public class BodyInputDueDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDueDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDueDateTypeOperatorType
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

    public class BodyInputPaidFromType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputPaidFromTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPaidFromTypeOperatorType
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

    public class BodyInputProcessedDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputProcessedDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputProcessedDateTypeOperatorType
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

    public class BodyInputTransactionDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputTransactionDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTransactionDateTypeOperatorType
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
    public enum BodyInputTransactionTypeEnumType
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

    public class CreateTransactionBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
        public CreateTransactionBodyInputCallTypeEnumType? CallTypeEnum { get; set; }

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
        public BodyInputTransactionTypeEnumType? TransactionTypeEnum { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTransactionBodyInputCallTypeEnumType
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

    public class SelectRoomSpaceMaintenanceBodyInput
    {
        [JsonProperty("_returnEmptyArrayOnNoResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnEmptyArrayOnNoResult { get; set; } = true;

        [JsonProperty("_pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Starrezrestv1.BodyInputPageSizeType._1000;

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
        public BodyInputCompleteDateType CompleteDate { get; set; }

        [JsonProperty("ContactID")]
        public int? ContactId { get; set; }
        public BodyInputContractDateType ContractDate { get; set; }
        public double? ContractorCost { get; set; }
        public double? ContractorCostEstimate { get; set; }
        public BodyInputContractorDateType ContractorDate { get; set; }
        public string ContractorETA { get; set; }
        public string ContractorOrderNumber { get; set; }

        [JsonProperty("CreatedBy_SecurityUserID")]
        public int? CreatedBySecurityUserId { get; set; }
        public bool? CustomBit1 { get; set; }
        public bool? CustomBit2 { get; set; }
        public BodyInputCustomDate1Type CustomDate1 { get; set; }
        public BodyInputCustomDate2Type CustomDate2 { get; set; }
        public string CustomString1 { get; set; }
        public string CustomString2 { get; set; }
        public string CustomString3 { get; set; }
        public string CustomString4 { get; set; }
        public string CustomString5 { get; set; }
        public string CustomString6 { get; set; }
        public BodyInputDateCreatedType DateCreated { get; set; }
        public BodyInputDateDueType DateDue { get; set; }
        public BodyInputDateModifiedType DateModified { get; set; }
        public BodyInputDateReportedType DateReported { get; set; }
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
        public BodyInputStartDateType StartDate { get; set; }
        public string Status { get; set; }
        public string Technician { get; set; }
        public bool? ViewOnWeb { get; set; }
    }

    public class BodyInputContractDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputContractDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractDateTypeOperatorType
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

    public class BodyInputContractorDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputContractorDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputContractorDateTypeOperatorType
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

    public class BodyInputDateDueType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateDueTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateDueTypeOperatorType
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

    public class BodyInputDateReportedType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputDateReportedTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDateReportedTypeOperatorType
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

    public class BodyInputStartDateType
    {
        public string Value { get; set; }

        [JsonProperty("_operator")]
        public BodyInputStartDateTypeOperatorType? Operator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStartDateTypeOperatorType
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

    public class CreateRoomSpaceMaintenanceBodyInput
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

    public class UpdateRoomSpaceMaintenanceBodyInput
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