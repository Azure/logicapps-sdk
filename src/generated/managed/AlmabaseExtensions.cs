//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Almabase
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlmabaseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<CreateFormEntryResponse, ApiConnectionActionConfiguration> CreateFormEntry(Expression<Func<int>> formId, Expression<Func<object>> body = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateFormEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/custom_forms/{0}/entries/", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateFormEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFormEntry(Expression<Func<int>> formId, Expression<Func<string>> entryId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_entryId = WorkflowExpression.Compile(entryId, nameof(entryId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/custom_forms/{0}/entries/{1}/", __workflow_formId.WithUrlEncoding(1), __workflow_entryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiFundRead[], ApiConnectionActionConfiguration> ListFunds(Expression<Func<string[]>> fields = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<V1GivingApiFundRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/givingx/funds/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<V1GivingApiFundRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiFundRead, ApiConnectionActionConfiguration> CreateFund(Expression<Func<CreateFundBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1GivingApiFundRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/givingx/funds/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1GivingApiFundRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiFundRead, ApiConnectionActionConfiguration> GetFund(Expression<Func<int>> id, Expression<Func<string[]>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<V1GivingApiFundRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/givingx/funds/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<V1GivingApiFundRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiFundRead, ApiConnectionActionConfiguration> UpdateFund(Expression<Func<int>> id, Expression<Func<CreateFundBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1GivingApiFundRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/givingx/funds/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1GivingApiFundRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<ListGiftsResponse, ApiConnectionActionConfiguration> ListGifts(Expression<Func<string>> status, Expression<Func<int>> campaign = null, Expression<Func<string>> groupId = null, Expression<Func<bool>> batchNumberIsnull = null, Expression<Func<bool>> externalDatabaseIdIsnull = null, Expression<Func<string>> externalDatabaseId = null, Expression<Func<string>> donorEmail = null, Expression<Func<string>> search = null, Expression<Func<string[]>> fields = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> page = null, Expression<Func<OrderingInput>> ordering = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            var __workflow_campaign = WorkflowExpression.Compile(campaign, nameof(campaign), required: false);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            var __workflow_batchNumberIsnull = WorkflowExpression.Compile(batchNumberIsnull, nameof(batchNumberIsnull), required: false);
            var __workflow_externalDatabaseIdIsnull = WorkflowExpression.Compile(externalDatabaseIdIsnull, nameof(externalDatabaseIdIsnull), required: false);
            var __workflow_externalDatabaseId = WorkflowExpression.Compile(externalDatabaseId, nameof(externalDatabaseId), required: false);
            var __workflow_donorEmail = WorkflowExpression.Compile(donorEmail, nameof(donorEmail), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<ListGiftsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/givingx/gifts/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_campaign != null)
                    callPayload.Queries["campaign"] = ExpressionConverter.Convert(__workflow_campaign);
                if (__workflow_groupId != null)
                    callPayload.Queries["group_id"] = ExpressionConverter.Convert(__workflow_groupId);
                if (__workflow_batchNumberIsnull != null)
                    callPayload.Queries["batch_number__isnull"] = ExpressionConverter.Convert(__workflow_batchNumberIsnull);
                if (__workflow_externalDatabaseIdIsnull != null)
                    callPayload.Queries["external_database_id__isnull"] = ExpressionConverter.Convert(__workflow_externalDatabaseIdIsnull);
                if (__workflow_externalDatabaseId != null)
                    callPayload.Queries["external_database_id"] = ExpressionConverter.Convert(__workflow_externalDatabaseId);
                if (__workflow_donorEmail != null)
                    callPayload.Queries["donor_email"] = ExpressionConverter.Convert(__workflow_donorEmail);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["page_size"] = Convert.ToString(10);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<ListGiftsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiGiftRead, ApiConnectionActionConfiguration> CreateGift(Expression<Func<CreateGiftBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1GivingApiGiftRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/givingx/gifts/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1GivingApiGiftRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiGiftRead, ApiConnectionActionConfiguration> GetGift(Expression<Func<int>> id, Expression<Func<string[]>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<V1GivingApiGiftRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/givingx/gifts/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<V1GivingApiGiftRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiGiftRead, ApiConnectionActionConfiguration> UpdateGift(Expression<Func<int>> id, Expression<Func<UpdateGiftBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1GivingApiGiftRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/givingx/gifts/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1GivingApiGiftRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiGivingPageRead[], ApiConnectionActionConfiguration> ListGivingPages(Expression<Func<string[]>> fields = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<V1GivingApiGivingPageRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/givingx/pages/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<V1GivingApiGivingPageRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1GivingApiGivingPageRead, ApiConnectionActionConfiguration> GetGivingPage(Expression<Func<int>> id, Expression<Func<string[]>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<V1GivingApiGivingPageRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/givingx/pages/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<V1GivingApiGivingPageRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1AlmasightsApiTouchpointCustomObjectAdd, ApiConnectionActionConfiguration> CreateTouchpointCustomObject(Expression<Func<int>> touchpointProgram, Expression<Func<CreateTouchpointCustomObjectBodyInput>> body)
        {
            var __workflow_touchpointProgram = WorkflowExpression.Compile(touchpointProgram, nameof(touchpointProgram), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1AlmasightsApiTouchpointCustomObjectAdd, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/almasights/customobjects/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["touchpoint_program"] = ExpressionConverter.Convert(__workflow_touchpointProgram);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1AlmasightsApiTouchpointCustomObjectAdd>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<ListRecordsResponse, ApiConnectionActionConfiguration> ListRecords(Expression<Func<string>> search = null, Expression<Func<string>> emailAddressesAddress = null, Expression<Func<string>> externalDatabaseId = null, Expression<Func<string[]>> fields = null, Expression<Func<string>> updatedAtGte = null, Expression<Func<string>> createdAtGte = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> page = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_emailAddressesAddress = WorkflowExpression.Compile(emailAddressesAddress, nameof(emailAddressesAddress), required: false);
            var __workflow_externalDatabaseId = WorkflowExpression.Compile(externalDatabaseId, nameof(externalDatabaseId), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_updatedAtGte = WorkflowExpression.Compile(updatedAtGte, nameof(updatedAtGte), required: false);
            var __workflow_createdAtGte = WorkflowExpression.Compile(createdAtGte, nameof(createdAtGte), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<ListRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_emailAddressesAddress != null)
                    callPayload.Queries["email_addresses__address"] = ExpressionConverter.Convert(__workflow_emailAddressesAddress);
                if (__workflow_externalDatabaseId != null)
                    callPayload.Queries["external_database_id"] = ExpressionConverter.Convert(__workflow_externalDatabaseId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_updatedAtGte != null)
                    callPayload.Queries["updated_at__gte"] = ExpressionConverter.Convert(__workflow_updatedAtGte);
                if (__workflow_createdAtGte != null)
                    callPayload.Queries["created_at__gte"] = ExpressionConverter.Convert(__workflow_createdAtGte);
                callPayload.Queries["page_size"] = Convert.ToString(50);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<ListRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1RecordApiRecordRead, ApiConnectionActionConfiguration> CreateRecord(Expression<Func<CreateRecordBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1RecordApiRecordRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/profiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1RecordApiRecordRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1RecordApiRecordRead, ApiConnectionActionConfiguration> GetRecord(Expression<Func<int>> id, Expression<Func<string[]>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<V1RecordApiRecordRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/profiles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<V1RecordApiRecordRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1RecordApiRecordRead, ApiConnectionActionConfiguration> UpdateRecord(Expression<Func<int>> id, Expression<Func<UpdateRecordBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1RecordApiRecordRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/profiles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1RecordApiRecordRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<ListRecordEmailAddressesResponse, ApiConnectionActionConfiguration> ListRecordEmailAddresses(Expression<Func<int>> recordId, Expression<Func<bool>> isPrimary = null, Expression<Func<string[]>> fields = null, Expression<Func<int>> pageSize = null, Expression<Func<int>> page = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_isPrimary = WorkflowExpression.Compile(isPrimary, nameof(isPrimary), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<ListRecordEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/profiles/{0}/email_addresses", __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_isPrimary != null)
                    callPayload.Queries["is_primary"] = ExpressionConverter.Convert(__workflow_isPrimary);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["page_size"] = Convert.ToString(50);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<ListRecordEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1RecordApiEmailAddressRead, ApiConnectionActionConfiguration> CreateRecordEmailAddress(Expression<Func<int>> recordId, Expression<Func<CreateRecordEmailAddressBodyInput>> body)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1RecordApiEmailAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/profiles/{0}/email_addresses", __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1RecordApiEmailAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRecordEmailAddress(Expression<Func<int>> recordId, Expression<Func<int>> emailId)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_emailId = WorkflowExpression.Compile(emailId, nameof(emailId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/profiles/{0}/email_addresses/{1}", __workflow_recordId.WithUrlEncoding(1), __workflow_emailId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1RecordApiEmailAddressRead, ApiConnectionActionConfiguration> GetRecordEmailAddress(Expression<Func<int>> recordId, Expression<Func<int>> emailId)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_emailId = WorkflowExpression.Compile(emailId, nameof(emailId), required: true);
            return new DeferredBodyAction<V1RecordApiEmailAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/profiles/{0}/email_addresses/{1}", __workflow_recordId.WithUrlEncoding(1), __workflow_emailId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V1RecordApiEmailAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1RecordApiEmailAddressRead, ApiConnectionActionConfiguration> UpdateRecordEmailAddress(Expression<Func<int>> recordId, Expression<Func<int>> emailId, Expression<Func<UpdateRecordEmailAddressBodyInput>> body)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_emailId = WorkflowExpression.Compile(emailId, nameof(emailId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1RecordApiEmailAddressRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/profiles/{0}/email_addresses/{1}", __workflow_recordId.WithUrlEncoding(1), __workflow_emailId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1RecordApiEmailAddressRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1EventApiEventRead[], ApiConnectionActionConfiguration> ListEvents(Expression<Func<string>> externalDatabaseId = null, Expression<Func<string[]>> fields = null)
        {
            var __workflow_externalDatabaseId = WorkflowExpression.Compile(externalDatabaseId, nameof(externalDatabaseId), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<V1EventApiEventRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/eventsx/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_externalDatabaseId != null)
                    callPayload.Queries["external_database_id"] = ExpressionConverter.Convert(__workflow_externalDatabaseId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<V1EventApiEventRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1EventApiEventRead, ApiConnectionActionConfiguration> CreateEvent(Expression<Func<CreateEventBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1EventApiEventRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/eventsx/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1EventApiEventRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1EventApiEventRead, ApiConnectionActionConfiguration> GetEvent(Expression<Func<int>> id, Expression<Func<string[]>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<V1EventApiEventRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/eventsx/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<V1EventApiEventRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1EventApiEventRead, ApiConnectionActionConfiguration> UpdateEvent(Expression<Func<int>> id, Expression<Func<UpdateEventBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1EventApiEventRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/eventsx/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1EventApiEventRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1EventApiContactPersonRead[], ApiConnectionActionConfiguration> ListEventContactPersons(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<V1EventApiContactPersonRead[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/eventsx/{0}/contact_persons/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V1EventApiContactPersonRead[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1EventApiContactPersonRead, ApiConnectionActionConfiguration> AddEventContactPerson(Expression<Func<int>> id, Expression<Func<AddEventContactPersonBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1EventApiContactPersonRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/eventsx/{0}/contact_persons/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1EventApiContactPersonRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almabase")]
        public IBodyWorkflowAction<V1EventApiContactPersonRead, ApiConnectionActionConfiguration> UpdateEventContactPerson(Expression<Func<int>> id, Expression<Func<int>> personId, Expression<Func<AddEventContactPersonBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_personId = WorkflowExpression.Compile(personId, nameof(personId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<V1EventApiContactPersonRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/eventsx/{0}/contact_persons/{1}/", __workflow_id.WithUrlEncoding(1), __workflow_personId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<V1EventApiContactPersonRead>(callPayload);
            });
        }
    }

    public class AlmabaseTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> FormEntryCreateOrUpdateWebhook(Expression<Func<FormEntryCreateOrUpdateWebhookBodyInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/virtual/webhooks/customforms.customformentry/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> GiftSucceededOrFailedWebhook(Expression<Func<GiftSucceededOrFailedWebhookBodyInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/virtual/webhooks/giving.gift/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> RecordChangedWebhook(Expression<Func<RecordChangedWebhookBodyInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/virtual/webhooks/crm.record/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> EmailChangedWebhook(Expression<Func<EmailChangedWebhookBodyInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/virtual/webhooks/profile.email/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateFormEntryResponse
    {
        [JsonProperty("id")]
        public int ResponseId { get; set; }
    }

    public class V1GivingApiFundRead
    {
        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefaultFund { get; set; }

        [JsonProperty("is_other_fund")]
        public bool IsOtherFund { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateFundBodyInput
    {
        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("is_default", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsDefaultFund { get; set; } = false;

        [JsonProperty("is_other_fund", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsOtherFund { get; set; } = false;

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FundName { get; set; }
    }

    public class ListGiftsResponse
    {
        [JsonProperty("nextlink")]
        public string NextResultsURL { get; set; }

        [JsonProperty("previouslink")]
        public string PreviousResultsURL { get; set; }

        [JsonProperty("total")]
        public int TotalGifts { get; set; }

        [JsonProperty("value")]
        public V1GivingApiGiftRead[] Gifts { get; set; }
    }

    public class V1GivingApiGiftRead
    {
        [JsonProperty("amount")]
        public string GiftAmount { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("completed_at")]
        public string GiftDate { get; set; }

        [JsonProperty("currency")]
        public int Currency { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("donor_address_line1")]
        public string DonorAddressLine1 { get; set; }

        [JsonProperty("donor_address_line2")]
        public string DonorAddressLine2 { get; set; }

        [JsonProperty("donor_city_place")]
        public V1GivingApiLocationRead DonorCityPlace { get; set; }

        [JsonProperty("donor_email")]
        public string DonorEmail { get; set; }

        [JsonProperty("donor_name")]
        public string DonorName { get; set; }

        [JsonProperty("donor_phone_number")]
        public string DonorPhoneNumber { get; set; }

        [JsonProperty("donor_zip_code")]
        public string DonorAddressZipCode { get; set; }

        [JsonProperty("exclude_from_leaderboard")]
        public bool IsHiddenFromLeaderboard { get; set; }

        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("honor_message")]
        public string TributeMessage { get; set; }

        [JsonProperty("honor_prefix")]
        public V1GivingApiGiftReadTributePrefixType TributePrefix { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("influencer")]
        public V1GivingApiInfluencerRead Influencer { get; set; }

        [JsonProperty("is_anonymous")]
        public bool IsAnonymous { get; set; }

        [JsonProperty("is_donor_covered_charges")]
        public bool HasDonorCoveredThePaymentGatewayCharges { get; set; }

        [JsonProperty("is_email_added_to_profile")]
        public bool IsEmailAddedToARecordOnAlmabase { get; set; }

        [JsonProperty("is_email_new")]
        public bool IsNewEmail { get; set; }

        [JsonProperty("is_profile_mapping_ignored")]
        public bool IsMappingToARecordOnAlmabaseIgnored { get; set; }

        [JsonProperty("mode")]
        public V1GivingApiGiftReadModeOfPaymentType ModeOfPayment { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("other_fund_name")]
        public string OtherFundName { get; set; }

        [JsonProperty("page")]
        public V1GivingApiGivingPageAssociatedWithGift Page { get; set; }

        [JsonProperty("post_payment_form_entry")]
        public V1GivingApiGiftReadPostPaymentFormType PostPaymentForm { get; set; }

        [JsonProperty("pre_payment_form_entry")]
        public V1GivingApiGiftReadPrePaymentFormType PrePaymentForm { get; set; }

        [JsonProperty("profile")]
        public V1GivingApiRecordRead Profile { get; set; }

        [JsonProperty("referrer_link")]
        public string ReferrerLink { get; set; }

        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        [JsonProperty("splits")]
        public V1GivingApiGiftSplitRead[] Splits { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transaction")]
        public V1GivingApiTransactionRead Transaction { get; set; }

        [JsonProperty("utm_campaign")]
        public string UTMCampaign { get; set; }

        [JsonProperty("utm_medium")]
        public string UTMMedium { get; set; }

        [JsonProperty("utm_source")]
        public string UTMSource { get; set; }
    }

    public class V1GivingApiLocationRead
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_short_name")]
        public string CityShortName { get; set; }

        [JsonProperty("coordinates")]
        public V1GivingApiLocationReadCoordinatesType Coordinates { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_short_name")]
        public string CountryShortName { get; set; }

        [JsonProperty("gpid")]
        public string GooglePlaceId { get; set; }

        [JsonProperty("name")]
        public string CityStateCountry { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state_short_name")]
        public string StateShortName { get; set; }
    }

    public class V1GivingApiLocationReadCoordinatesType
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1GivingApiGiftReadTributePrefixType
    {
        [EnumMember(Value = "in_honor_of")]
        InHonorOf,
        [EnumMember(Value = "in_memory_of")]
        InMemoryOf,
        [EnumMember(Value = "in_support_of")]
        InSupportOf
    }

    public class V1GivingApiInfluencerRead
    {
        [JsonProperty("dashboard_url")]
        public string PrivateInfluencerDashboardLink { get; set; }

        [JsonProperty("page_share_url")]
        public string PublicShareLink { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1GivingApiGiftReadModeOfPaymentType
    {
        [EnumMember(Value = "online")]
        Online,
        [EnumMember(Value = "offline")]
        Offline,
        [EnumMember(Value = "offline_cheque")]
        OfflineCheque,
        [EnumMember(Value = "offline_wire_transfer")]
        OfflineWireTransfer,
        [EnumMember(Value = "offline_cash")]
        OfflineCash,
        [EnumMember(Value = "offline_demand_draft")]
        OfflineDemandDraft
    }

    public class V1GivingApiGivingPageAssociatedWithGift
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class V1GivingApiGiftReadPostPaymentFormType
    {
        [JsonProperty("fields")]
        public V1GivingApiFormFieldRead[] Fields { get; set; }

        [JsonProperty("id")]
        public int ResponseId { get; set; }
    }

    public class V1GivingApiFormFieldRead
    {
        [JsonProperty("display_value")]
        public string Value { get; set; }

        [JsonProperty("label")]
        public string QuestionFormFieldName { get; set; }
    }

    public class V1GivingApiGiftReadPrePaymentFormType
    {
        [JsonProperty("fields")]
        public V1GivingApiFormFieldRead[] Fields { get; set; }

        [JsonProperty("id")]
        public int ResponseId { get; set; }
    }

    public class V1GivingApiRecordRead
    {
        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("formatted_name")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_registered")]
        public bool IsDonorRegisteredOnAlmabase { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("present_picture")]
        public string PictureURL { get; set; }

        [JsonProperty("profile_url")]
        public string Link { get; set; }
    }

    public class V1GivingApiGiftSplitRead
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("fund")]
        public V1GivingApiFundRead Fund { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class V1GivingApiTransactionRead
    {
        [JsonProperty("account")]
        public V1GivingApiPaymentAccountRead Account { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("failure_reason")]
        public string FailureReason { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public V1GivingApiTransactionReadStatusType Status { get; set; }

        [JsonProperty("transaction_id")]
        public string PaymentGatewayReferenceId { get; set; }
    }

    public class V1GivingApiPaymentAccountRead
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Gateway { get; set; }
    }

    public enum V1GivingApiTransactionReadStatusType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderingInput
    {
        [EnumMember(Value = "id")]
        Id2,
        [EnumMember(Value = "donor_name")]
        DonorName2,
        [EnumMember(Value = "-id")]
        Id,
        [EnumMember(Value = "-donor_name")]
        DonorName
    }

    public class CreateGiftBodyInput
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GiftAmount { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("completed_at", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GiftDate { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Currency { get; set; } = 1;

        [JsonProperty("donor_address_line1")]
        public string DonorAddressLine1 { get; set; }

        [JsonProperty("donor_address_line2")]
        public string DonorAddressLine2 { get; set; }

        [JsonProperty("donor_city_place")]
        public V1GivingApiLocationAdd DonorAddressLocation { get; set; }

        [JsonProperty("donor_email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DonorEmail { get; set; }

        [JsonProperty("donor_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DonorName { get; set; }

        [JsonProperty("donor_phone_number")]
        public string DonorPhoneNumber { get; set; }

        [JsonProperty("donor_zip_code")]
        public string DonorAddressZipCode { get; set; }

        [JsonProperty("exclude_from_leaderboard", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsHiddenFromLeaderboard { get; set; } = false;

        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("honor_message")]
        public string TributeMessage { get; set; }

        [JsonProperty("honor_prefix")]
        public string TributePrefix { get; set; }

        [JsonProperty("is_anonymous")]
        public bool? IsAnonymous { get; set; }

        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ModeOfPayment { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("other_fund_name")]
        public string OtherFundName { get; set; }

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageType Page { get; set; }

        [JsonProperty("profile")]
        public V1GivingApiRecordAddOrEdit MappedRecord { get; set; }

        [JsonProperty("splits", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1GivingApiGiftSplitAddOrEdit[] Splits { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Status { get; set; } = "completed";
    }

    public class V1GivingApiLocationAdd
    {
        [JsonProperty("name")]
        public string NameCityStateCountry { get; set; }
    }

    public class BodyInputPageType
    {
        [JsonProperty("id")]
        public int? GivingPage { get; set; }
    }

    public class V1GivingApiRecordAddOrEdit
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
    }

    public class V1GivingApiGiftSplitAddOrEdit
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Amount { get; set; }

        [JsonProperty("fund", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1GivingApiGiftSplitAddOrEditFundType Fund { get; set; }
    }

    public class V1GivingApiGiftSplitAddOrEditFundType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Fund { get; set; }
    }

    public class UpdateGiftBodyInput
    {
        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("donor_address_line1")]
        public string DonorAddressLine1 { get; set; }

        [JsonProperty("donor_address_line2")]
        public string DonorAddressLine2 { get; set; }

        [JsonProperty("donor_city_place")]
        public V1GivingApiLocationAdd DonorAddressLocation { get; set; }

        [JsonProperty("donor_name")]
        public string DonorName { get; set; }

        [JsonProperty("donor_phone_number")]
        public string DonorPhoneNumber { get; set; }

        [JsonProperty("donor_zip_code")]
        public string DonorAddressZipCode { get; set; }

        [JsonProperty("exclude_from_leaderboard")]
        public bool? IsHiddenFromLeaderboard { get; set; }

        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("honor_message")]
        public string TributeMessage { get; set; }

        [JsonProperty("honor_prefix")]
        public string TributePrefix { get; set; }

        [JsonProperty("is_anonymous")]
        public bool? IsAnonymous { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("other_fund_name")]
        public string OtherFundName { get; set; }

        [JsonProperty("page")]
        public BodyInputPageType Page { get; set; }

        [JsonProperty("profile")]
        public V1GivingApiRecordAddOrEdit MappedRecord { get; set; }

        [JsonProperty("splits")]
        public V1GivingApiGiftSplitAddOrEdit[] Splits { get; set; }
    }

    public class V1GivingApiGivingPageRead
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class V1AlmasightsApiTouchpointCustomObjectAdd
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mapped_profile")]
        public CreateTouchpointCustomObjectV1AlmasightsApiRecordAddOrEditResponse MappedProfile { get; set; }

        [JsonProperty("recorded_at")]
        public string RecordedAt { get; set; }

        [JsonProperty("touchpoint_type")]
        public V1AlmasightsApiTouchpointCustomObjectAddTouchpointTypeType TouchpointType { get; set; }

        [JsonProperty("trigger_type")]
        public V1AlmasightsApiTouchpointCustomObjectAddTriggerTypeType TriggerType { get; set; }
    }

    public class CreateTouchpointCustomObjectV1AlmasightsApiRecordAddOrEditResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class V1AlmasightsApiTouchpointCustomObjectAddTouchpointTypeType
    {
        [JsonProperty("id")]
        public int Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1AlmasightsApiTouchpointCustomObjectAddTriggerTypeType
    {
        [EnumMember(Value = "click")]
        Click,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "search")]
        Search
    }

    public class CreateTouchpointCustomObjectBodyInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mapped_profile")]
        public CreateTouchpointCustomObjectV1AlmasightsApiRecordAddOrEdit Record { get; set; }

        [JsonProperty("recorded_at", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecordedAt { get; set; }

        [JsonProperty("touchpoint_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTouchpointTypeType TouchpointType { get; set; }

        [JsonProperty("trigger_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputTriggerTypeType TriggerType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Almabase.BodyInputTriggerTypeType.Click;
    }

    public class CreateTouchpointCustomObjectV1AlmasightsApiRecordAddOrEdit
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
    }

    public class BodyInputTouchpointTypeType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTriggerTypeType
    {
        [EnumMember(Value = "click")]
        Click,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "search")]
        Search
    }

    public class ListRecordsResponse
    {
        [JsonProperty("nextlink")]
        public string NextResultsURL { get; set; }

        [JsonProperty("previouslink")]
        public string PreviousResultsURL { get; set; }

        [JsonProperty("total")]
        public int TotalRecords { get; set; }

        [JsonProperty("value")]
        public V1RecordApiRecordRead[] Records { get; set; }
    }

    public class V1RecordApiRecordRead
    {
        [JsonProperty("email_addresses")]
        public V1RecordApiEmailAddressRead[] EmailAddresses { get; set; }

        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("formatted_name")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_registered")]
        public bool IsRegisteredOnAlmabase { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("present_picture")]
        public string PictureURL { get; set; }

        [JsonProperty("record_url")]
        public string Link { get; set; }
    }

    public class V1RecordApiEmailAddressRead
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_engaged")]
        public bool IsEngaged { get; set; }

        [JsonProperty("is_login_email")]
        public bool UseForLogin { get; set; }

        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerifiedByUser { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        public V1RecordApiEmailAddressReadStatusType Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1RecordApiEmailAddressReadStatusType
    {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "hard_bounce")]
        HardBounce,
        [EnumMember(Value = "soft_bounce")]
        SoftBounce,
        [EnumMember(Value = "marked_spam")]
        MarkedSpam,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "contactable")]
        Contactable
    }

    public class CreateRecordBodyInput
    {
        [JsonProperty("addresses")]
        public V1RecordApiAddressAdd[] Addresses { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("deceased")]
        public bool? Deceased { get; set; }

        [JsonProperty("email_addresses")]
        public V1RecordApiEmailAddressAssociatedWithRecordAdd[] EmailAddresses { get; set; }

        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("external_database_lookup_id")]
        public string ExternalDatabaseLookupId { get; set; }

        [JsonProperty("first_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("phone_numbers")]
        public V1RecordApiPhoneNumberAdd[] PhoneNumbers { get; set; }
    }

    public class V1RecordApiAddressAdd
    {
        [JsonProperty("line1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("location")]
        public V1RecordApiAddressAddLocationType Location { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("zip_code")]
        public string Zipcode { get; set; }
    }

    public class V1RecordApiAddressAddLocationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class V1RecordApiEmailAddressAssociatedWithRecordAdd
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("is_login_email", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseForLogin { get; set; } = true;

        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public V1RecordApiEmailAddressAssociatedWithRecordAddStatusType? Status { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Almabase.V1RecordApiEmailAddressAssociatedWithRecordAddStatusType.Unknown;

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V1RecordApiEmailAddressAssociatedWithRecordAddStatusType
    {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "hard_bounce")]
        HardBounce,
        [EnumMember(Value = "soft_bounce")]
        SoftBounce,
        [EnumMember(Value = "marked_spam")]
        MarkedSpam,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "contactable")]
        Contactable
    }

    public class V1RecordApiPhoneNumberAdd
    {
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Number { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }
    }

    public class UpdateRecordBodyInput
    {
        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("external_database_lookup_id")]
        public string ExternalDatabaseLookupId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class ListRecordEmailAddressesResponse
    {
        [JsonProperty("nextlink")]
        public string NextResultsURL { get; set; }

        [JsonProperty("previouslink")]
        public string PreviousResultsURL { get; set; }

        [JsonProperty("total")]
        public int TotalEmailAddresses { get; set; }

        [JsonProperty("value")]
        public V1RecordApiEmailAddressRead[] EmailAddress { get; set; }
    }

    public class CreateRecordEmailAddressBodyInput
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("is_login_email", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseForLogin { get; set; } = true;

        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputStatusType? Status { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Almabase.BodyInputStatusType.Unknown;

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStatusType
    {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "hard_bounce")]
        HardBounce,
        [EnumMember(Value = "soft_bounce")]
        SoftBounce,
        [EnumMember(Value = "marked_spam")]
        MarkedSpam,
        [EnumMember(Value = "invalid")]
        Invalid,
        [EnumMember(Value = "contactable")]
        Contactable
    }

    public class UpdateRecordEmailAddressBodyInput
    {
        [JsonProperty("is_login_email")]
        public bool? UseForLogin { get; set; }

        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; }

        [JsonProperty("status")]
        public BodyInputStatusType? Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class V1EventApiEventRead
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_datetime")]
        public string EndTime { get; set; }

        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("external_registration_url")]
        public string ExternalRegistrationUrl { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_datetime")]
        public string StartTime { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class CreateEventBodyInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_datetime")]
        public string EndTime { get; set; }

        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("external_registration_url")]
        public string ExternalRegistrationUrl { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("start_datetime")]
        public string StartTime { get; set; }

        [JsonProperty("timezone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Timezone { get; set; } = "US/Central";

        [JsonProperty("venue")]
        public BodyInputLocationType Location { get; set; }
    }

    public class BodyInputLocationType
    {
        [JsonProperty("display_name")]
        public string Name { get; set; }
    }

    public class UpdateEventBodyInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end_datetime")]
        public string EndTime { get; set; }

        [JsonProperty("external_database_id")]
        public string ExternalDatabaseId { get; set; }

        [JsonProperty("external_registration_url")]
        public string ExternalRegistrationUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_datetime")]
        public string StartTime { get; set; }

        [JsonProperty("timezone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Timezone { get; set; } = "US/Central";

        [JsonProperty("venue")]
        public BodyInputLocationType Location { get; set; }
    }

    public class V1EventApiContactPersonRead
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class AddEventContactPersonBodyInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class FormEntryCreateOrUpdateWebhookBodyInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public string When { get; set; } = "com.almabase.customforms.customformentry.created";

        [JsonProperty("object_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Form { get; set; }
    }

    public class GiftSucceededOrFailedWebhookBodyInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public string When { get; set; } = "com.almabase.giving.gift.succeeded";

        [JsonProperty("object_id")]
        public int? GivingPage { get; set; }
    }

    public class RecordChangedWebhookBodyInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public string When { get; set; } = "com.almabase.crm.record.created";
    }

    public class EmailChangedWebhookBodyInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public string When { get; set; } = "com.almabase.crm.email.created";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Almabase;

    public partial class WorkflowManagedActions
    {
        public AlmabaseActions Almabase(string connectionId) => new AlmabaseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlmabaseTriggers Almabase(string connectionId) => new AlmabaseTriggers(connectionId);
    }
}