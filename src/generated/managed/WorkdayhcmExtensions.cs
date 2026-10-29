//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkdayhcmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateAddressInformation(Expression<Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIdTypeInput>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIdType, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerId, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate, Expression<Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryIdInput>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryId = null, Expression<Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineDataInputItem[]>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData = null, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality = null, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionId = null, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode = null, Expression<Func<bool>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = null)
        {
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIdType = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIdType, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIdType), required: true);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerId = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerId, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerId), required: true);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate), required: true);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryId = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryId, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryId), required: false);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData), required: false);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality), required: false);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionId = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionId, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionId), required: false);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode), required: false);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic), required: false);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary), required: false);
            var __workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = WorkflowExpression.Compile(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Address_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addOrUpdateAddressInformationForPersonEventRequest = new JObject();
                var addOrUpdateAddressInformationForPersonEventRequestpropCount = 0;
                var addOrUpdateAddressInformationForPersonEventRequestObject = new JObject();
                var addOrUpdateAddressInformationForPersonEventRequestObjectpropCount = 0;
                var addOrUpdateAddressInformationDataObject = new JObject();
                var addOrUpdateAddressInformationDataObjectpropCount = 0;
                var workerReferenceObject = new JObject();
                var workerReferenceObjectpropCount = 0;
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIdType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerId);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdateAddressInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdateAddressInformationDataObjectpropCount++;
                }

                addOrUpdateAddressInformationDataObjectpropCount++;
                addOrUpdateAddressInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate);
                var addressInformationDataObject = new JObject();
                var addressInformationDataObjectpropCount = 0;
                var countryReferenceObject = new JObject();
                var countryReferenceObjectpropCount = 0;
                countryReferenceObject["CountryIDType"] = "ISO 3166-1 Alpha-3 Code";
                countryReferenceObjectpropCount++;
                if (__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryId != null)
                {
                    countryReferenceObject["CountryID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryId);
                    countryReferenceObjectpropCount++;
                }

                if (countryReferenceObjectpropCount > 0)
                {
                    addressInformationDataObject["country_Reference"] = countryReferenceObject;
                    addressInformationDataObjectpropCount++;
                }

                if (__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData != null)
                {
                    addressInformationDataObject["address_Line_Data"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData);
                    addressInformationDataObjectpropCount++;
                }

                if (__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality != null)
                {
                    addressInformationDataObject["municipality"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality);
                    addressInformationDataObjectpropCount++;
                }

                var countryRegionReferenceObject = new JObject();
                var countryRegionReferenceObjectpropCount = 0;
                countryRegionReferenceObject["CountryRegionIDType"] = "ISO 3166-2 Code";
                countryRegionReferenceObjectpropCount++;
                if (__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionId != null)
                {
                    countryRegionReferenceObject["CountryRegionID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionId);
                    countryRegionReferenceObjectpropCount++;
                }

                if (countryRegionReferenceObjectpropCount > 0)
                {
                    addressInformationDataObject["country_Region_Reference"] = countryRegionReferenceObject;
                    addressInformationDataObjectpropCount++;
                }

                if (__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode != null)
                {
                    addressInformationDataObject["postal_Code"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode);
                    addressInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId);
                    typeReferenceObjectpropCount++;
                }

                if (typeReferenceObjectpropCount > 0)
                {
                    typeDataObject["type_Reference"] = typeReferenceObject;
                    typeDataObjectpropCount++;
                }

                if (typeDataObjectpropCount > 0)
                {
                    usageDataObject["type_Data"] = typeDataObject;
                    usageDataObjectpropCount++;
                }

                if (usageDataObjectpropCount > 0)
                {
                    addressInformationDataObject["usage_Data"] = usageDataObject;
                    addressInformationDataObjectpropCount++;
                }

                if (addressInformationDataObjectpropCount > 0)
                {
                    addOrUpdateAddressInformationDataObject["address_Information_Data"] = addressInformationDataObject;
                    addOrUpdateAddressInformationDataObjectpropCount++;
                }

                if (addOrUpdateAddressInformationDataObjectpropCount > 0)
                {
                    addOrUpdateAddressInformationForPersonEventRequestObject["add_or_Update_Address_Information_Data"] = addOrUpdateAddressInformationDataObject;
                    addOrUpdateAddressInformationForPersonEventRequestObjectpropCount++;
                }

                if (addOrUpdateAddressInformationForPersonEventRequestObjectpropCount > 0)
                {
                    addOrUpdateAddressInformationForPersonEventRequest["add_or_Update_Address_Information_for_Person_Event_Request"] = addOrUpdateAddressInformationForPersonEventRequestObject;
                    addOrUpdateAddressInformationForPersonEventRequestpropCount++;
                }

                if (addOrUpdateAddressInformationForPersonEventRequestpropCount > 0)
                {
                    callPayload.Body = addOrUpdateAddressInformationForPersonEventRequest;
                }

                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdatePhoneInformation(Expression<Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIdTypeInput>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIdType, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerId, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate, Expression<Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCodeInput>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode = null, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode = null, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber = null, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension = null, Expression<Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeIdInput>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeId = null, Expression<Func<bool>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = null)
        {
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIdType = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIdType, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIdType), required: true);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerId = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerId, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerId), required: true);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate), required: true);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode), required: false);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode), required: false);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber), required: false);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension), required: false);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeId = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeId, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeId), required: false);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic), required: false);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary), required: false);
            var __workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = WorkflowExpression.Compile(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Phone_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addOrUpdatePhoneInformationForPersonEventRequest = new JObject();
                var addOrUpdatePhoneInformationForPersonEventRequestpropCount = 0;
                var addOrUpdatePhoneInformationForPersonEventRequestObject = new JObject();
                var addOrUpdatePhoneInformationForPersonEventRequestObjectpropCount = 0;
                var addOrUpdatePhoneInformationDataObject = new JObject();
                var addOrUpdatePhoneInformationDataObjectpropCount = 0;
                var workerReferenceObject = new JObject();
                var workerReferenceObjectpropCount = 0;
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIdType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerId);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdatePhoneInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdatePhoneInformationDataObjectpropCount++;
                }

                addOrUpdatePhoneInformationDataObjectpropCount++;
                addOrUpdatePhoneInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate);
                var phoneInformationDataObject = new JObject();
                var phoneInformationDataObjectpropCount = 0;
                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode != null)
                {
                    phoneInformationDataObject["country_ISO_Code"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode);
                    phoneInformationDataObjectpropCount++;
                }

                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode != null)
                {
                    phoneInformationDataObject["area_Code"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode);
                    phoneInformationDataObjectpropCount++;
                }

                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber != null)
                {
                    phoneInformationDataObject["phone_Number"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber);
                    phoneInformationDataObjectpropCount++;
                }

                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension != null)
                {
                    phoneInformationDataObject["phone_Extension"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension);
                    phoneInformationDataObjectpropCount++;
                }

                var phoneDeviceTypeReferenceObject = new JObject();
                var phoneDeviceTypeReferenceObjectpropCount = 0;
                phoneDeviceTypeReferenceObject["PhoneDeviceTypeIDType"] = "Phone_Device_Type_ID";
                phoneDeviceTypeReferenceObjectpropCount++;
                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeId != null)
                {
                    phoneDeviceTypeReferenceObject["PhoneDeviceTypeID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeId);
                    phoneDeviceTypeReferenceObjectpropCount++;
                }

                if (phoneDeviceTypeReferenceObjectpropCount > 0)
                {
                    phoneInformationDataObject["phone_Device_Type_Reference"] = phoneDeviceTypeReferenceObject;
                    phoneInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId);
                    typeReferenceObjectpropCount++;
                }

                if (typeReferenceObjectpropCount > 0)
                {
                    typeDataObject["type_Reference"] = typeReferenceObject;
                    typeDataObjectpropCount++;
                }

                if (typeDataObjectpropCount > 0)
                {
                    usageDataObject["type_Data"] = typeDataObject;
                    usageDataObjectpropCount++;
                }

                if (usageDataObjectpropCount > 0)
                {
                    phoneInformationDataObject["usage_Data"] = usageDataObject;
                    phoneInformationDataObjectpropCount++;
                }

                if (phoneInformationDataObjectpropCount > 0)
                {
                    addOrUpdatePhoneInformationDataObject["phone_Information_Data"] = phoneInformationDataObject;
                    addOrUpdatePhoneInformationDataObjectpropCount++;
                }

                if (addOrUpdatePhoneInformationDataObjectpropCount > 0)
                {
                    addOrUpdatePhoneInformationForPersonEventRequestObject["add_or_Update_Phone_Information_Data"] = addOrUpdatePhoneInformationDataObject;
                    addOrUpdatePhoneInformationForPersonEventRequestObjectpropCount++;
                }

                if (addOrUpdatePhoneInformationForPersonEventRequestObjectpropCount > 0)
                {
                    addOrUpdatePhoneInformationForPersonEventRequest["add_or_Update_Phone_Information_for_Person_Event_Request"] = addOrUpdatePhoneInformationForPersonEventRequestObject;
                    addOrUpdatePhoneInformationForPersonEventRequestpropCount++;
                }

                if (addOrUpdatePhoneInformationForPersonEventRequestpropCount > 0)
                {
                    callPayload.Body = addOrUpdatePhoneInformationForPersonEventRequest;
                }

                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateEmailAddressInformation(Expression<Func<addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIdTypeInput>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIdType, Expression<Func<string>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerId, Expression<Func<string>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate, Expression<Func<string>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress = null, Expression<Func<bool>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = null)
        {
            var __workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIdType = WorkflowExpression.Compile(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIdType, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIdType), required: true);
            var __workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerId = WorkflowExpression.Compile(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerId, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerId), required: true);
            var __workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate = WorkflowExpression.Compile(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate), required: true);
            var __workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress = WorkflowExpression.Compile(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress), required: false);
            var __workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic = WorkflowExpression.Compile(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic), required: false);
            var __workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary = WorkflowExpression.Compile(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary), required: false);
            var __workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = WorkflowExpression.Compile(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Email_Address_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addOrUpdateEmailAddressInformationForPersonEventRequest = new JObject();
                var addOrUpdateEmailAddressInformationForPersonEventRequestpropCount = 0;
                var addOrUpdateEmailAddressInformationForPersonEventRequestObject = new JObject();
                var addOrUpdateEmailAddressInformationForPersonEventRequestObjectpropCount = 0;
                var addOrUpdateEmailAddressInformationDataObject = new JObject();
                var addOrUpdateEmailAddressInformationDataObjectpropCount = 0;
                var workerReferenceObject = new JObject();
                var workerReferenceObjectpropCount = 0;
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIdType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerId);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdateEmailAddressInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdateEmailAddressInformationDataObjectpropCount++;
                }

                addOrUpdateEmailAddressInformationDataObjectpropCount++;
                addOrUpdateEmailAddressInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate);
                var emailAddressInformationDataObject = new JObject();
                var emailAddressInformationDataObjectpropCount = 0;
                if (__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress != null)
                {
                    emailAddressInformationDataObject["email_Address"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress);
                    emailAddressInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId);
                    typeReferenceObjectpropCount++;
                }

                if (typeReferenceObjectpropCount > 0)
                {
                    typeDataObject["type_Reference"] = typeReferenceObject;
                    typeDataObjectpropCount++;
                }

                if (typeDataObjectpropCount > 0)
                {
                    usageDataObject["type_Data"] = typeDataObject;
                    usageDataObjectpropCount++;
                }

                if (usageDataObjectpropCount > 0)
                {
                    emailAddressInformationDataObject["usage_Data"] = usageDataObject;
                    emailAddressInformationDataObjectpropCount++;
                }

                if (emailAddressInformationDataObjectpropCount > 0)
                {
                    addOrUpdateEmailAddressInformationDataObject["email_Address_Information_Data"] = emailAddressInformationDataObject;
                    addOrUpdateEmailAddressInformationDataObjectpropCount++;
                }

                if (addOrUpdateEmailAddressInformationDataObjectpropCount > 0)
                {
                    addOrUpdateEmailAddressInformationForPersonEventRequestObject["add_or_Update_Email_Address_Information_Data"] = addOrUpdateEmailAddressInformationDataObject;
                    addOrUpdateEmailAddressInformationForPersonEventRequestObjectpropCount++;
                }

                if (addOrUpdateEmailAddressInformationForPersonEventRequestObjectpropCount > 0)
                {
                    addOrUpdateEmailAddressInformationForPersonEventRequest["add_or_Update_Email_Address_Information_for_Person_Event_Request"] = addOrUpdateEmailAddressInformationForPersonEventRequestObject;
                    addOrUpdateEmailAddressInformationForPersonEventRequestpropCount++;
                }

                if (addOrUpdateEmailAddressInformationForPersonEventRequestpropCount > 0)
                {
                    callPayload.Body = addOrUpdateEmailAddressInformationForPersonEventRequest;
                }

                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateInstantMessengerInformation(Expression<Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIdTypeInput>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIdType, Expression<Func<string>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerId, Expression<Func<string>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate, Expression<Func<string>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress = null, Expression<Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeIdInput>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeId = null, Expression<Func<bool>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = null)
        {
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIdType = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIdType, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIdType), required: true);
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerId = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerId, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerId), required: true);
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate), required: true);
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress), required: false);
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeId = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeId, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeId), required: false);
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic), required: false);
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary), required: false);
            var __workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = WorkflowExpression.Compile(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Instant_Messenger_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addOrUpdateInstantMessengerInformationForPersonEventRequest = new JObject();
                var addOrUpdateInstantMessengerInformationForPersonEventRequestpropCount = 0;
                var addOrUpdateInstantMessengerInformationForPersonEventRequestObject = new JObject();
                var addOrUpdateInstantMessengerInformationForPersonEventRequestObjectpropCount = 0;
                var addOrUpdateInstantMessengerInformationDataObject = new JObject();
                var addOrUpdateInstantMessengerInformationDataObjectpropCount = 0;
                var workerReferenceObject = new JObject();
                var workerReferenceObjectpropCount = 0;
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIdType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerId);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdateInstantMessengerInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdateInstantMessengerInformationDataObjectpropCount++;
                }

                addOrUpdateInstantMessengerInformationDataObjectpropCount++;
                addOrUpdateInstantMessengerInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate);
                var instantMessengerInformationDataObject = new JObject();
                var instantMessengerInformationDataObjectpropCount = 0;
                if (__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress != null)
                {
                    instantMessengerInformationDataObject["instant_Messenger_Address"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress);
                    instantMessengerInformationDataObjectpropCount++;
                }

                var instantMessengerTypeReferenceObject = new JObject();
                var instantMessengerTypeReferenceObjectpropCount = 0;
                instantMessengerTypeReferenceObject["InstantMessengerTypeIDType"] = "Instant_Messenger_Type_ID";
                instantMessengerTypeReferenceObjectpropCount++;
                if (__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeId != null)
                {
                    instantMessengerTypeReferenceObject["InstantMessengerTypeID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeId);
                    instantMessengerTypeReferenceObjectpropCount++;
                }

                if (instantMessengerTypeReferenceObjectpropCount > 0)
                {
                    instantMessengerInformationDataObject["instant_Messenger_Type_Reference"] = instantMessengerTypeReferenceObject;
                    instantMessengerInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId);
                    typeReferenceObjectpropCount++;
                }

                if (typeReferenceObjectpropCount > 0)
                {
                    typeDataObject["type_Reference"] = typeReferenceObject;
                    typeDataObjectpropCount++;
                }

                if (typeDataObjectpropCount > 0)
                {
                    usageDataObject["type_Data"] = typeDataObject;
                    usageDataObjectpropCount++;
                }

                if (usageDataObjectpropCount > 0)
                {
                    instantMessengerInformationDataObject["usage_Data"] = usageDataObject;
                    instantMessengerInformationDataObjectpropCount++;
                }

                if (instantMessengerInformationDataObjectpropCount > 0)
                {
                    addOrUpdateInstantMessengerInformationDataObject["instant_Messenger_Information_Data"] = instantMessengerInformationDataObject;
                    addOrUpdateInstantMessengerInformationDataObjectpropCount++;
                }

                if (addOrUpdateInstantMessengerInformationDataObjectpropCount > 0)
                {
                    addOrUpdateInstantMessengerInformationForPersonEventRequestObject["add_or_Update_Instant_Messenger_Information_Data"] = addOrUpdateInstantMessengerInformationDataObject;
                    addOrUpdateInstantMessengerInformationForPersonEventRequestObjectpropCount++;
                }

                if (addOrUpdateInstantMessengerInformationForPersonEventRequestObjectpropCount > 0)
                {
                    addOrUpdateInstantMessengerInformationForPersonEventRequest["add_or_Update_Instant_Messenger_Information_for_Person_Event_Request"] = addOrUpdateInstantMessengerInformationForPersonEventRequestObject;
                    addOrUpdateInstantMessengerInformationForPersonEventRequestpropCount++;
                }

                if (addOrUpdateInstantMessengerInformationForPersonEventRequestpropCount > 0)
                {
                    callPayload.Body = addOrUpdateInstantMessengerInformationForPersonEventRequest;
                }

                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration> AddOrUpdateWebAddressInformation(Expression<Func<addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIdTypeInput>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIdType, Expression<Func<string>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerId, Expression<Func<string>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate, Expression<Func<string>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress = null, Expression<Func<bool>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = null)
        {
            var __workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIdType = WorkflowExpression.Compile(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIdType, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIdType), required: true);
            var __workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerId = WorkflowExpression.Compile(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerId, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerId), required: true);
            var __workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate = WorkflowExpression.Compile(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate), required: true);
            var __workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress = WorkflowExpression.Compile(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress), required: false);
            var __workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic = WorkflowExpression.Compile(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic), required: false);
            var __workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary = WorkflowExpression.Compile(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary), required: false);
            var __workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId = WorkflowExpression.Compile(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Add_or_Update_Web_Address_Information";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var addOrUpdateWebAddressInformationForPersonEventRequest = new JObject();
                var addOrUpdateWebAddressInformationForPersonEventRequestpropCount = 0;
                var addOrUpdateWebAddressInformationForPersonEventRequestObject = new JObject();
                var addOrUpdateWebAddressInformationForPersonEventRequestObjectpropCount = 0;
                var addOrUpdateWebAddressInformationDataObject = new JObject();
                var addOrUpdateWebAddressInformationDataObjectpropCount = 0;
                var workerReferenceObject = new JObject();
                var workerReferenceObjectpropCount = 0;
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIdType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerId);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdateWebAddressInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdateWebAddressInformationDataObjectpropCount++;
                }

                addOrUpdateWebAddressInformationDataObjectpropCount++;
                addOrUpdateWebAddressInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate);
                var webAddressInformationDataObject = new JObject();
                var webAddressInformationDataObjectpropCount = 0;
                if (__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress != null)
                {
                    webAddressInformationDataObject["web_Address"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress);
                    webAddressInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(__workflow_addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeId);
                    typeReferenceObjectpropCount++;
                }

                if (typeReferenceObjectpropCount > 0)
                {
                    typeDataObject["type_Reference"] = typeReferenceObject;
                    typeDataObjectpropCount++;
                }

                if (typeDataObjectpropCount > 0)
                {
                    usageDataObject["type_Data"] = typeDataObject;
                    usageDataObjectpropCount++;
                }

                if (usageDataObjectpropCount > 0)
                {
                    webAddressInformationDataObject["usage_Data"] = usageDataObject;
                    webAddressInformationDataObjectpropCount++;
                }

                if (webAddressInformationDataObjectpropCount > 0)
                {
                    addOrUpdateWebAddressInformationDataObject["web_Address_Information_Data"] = webAddressInformationDataObject;
                    addOrUpdateWebAddressInformationDataObjectpropCount++;
                }

                if (addOrUpdateWebAddressInformationDataObjectpropCount > 0)
                {
                    addOrUpdateWebAddressInformationForPersonEventRequestObject["add_or_Update_Web_Address_Information_Data"] = addOrUpdateWebAddressInformationDataObject;
                    addOrUpdateWebAddressInformationForPersonEventRequestObjectpropCount++;
                }

                if (addOrUpdateWebAddressInformationForPersonEventRequestObjectpropCount > 0)
                {
                    addOrUpdateWebAddressInformationForPersonEventRequest["add_or_Update_Web_Address_Information_for_Person_Event_Request"] = addOrUpdateWebAddressInformationForPersonEventRequestObject;
                    addOrUpdateWebAddressInformationForPersonEventRequestpropCount++;
                }

                if (addOrUpdateWebAddressInformationForPersonEventRequestpropCount > 0)
                {
                    callPayload.Body = addOrUpdateWebAddressInformationForPersonEventRequest;
                }

                return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeePersonalInfoInfo, ApiConnectionActionConfiguration> GetEmployeePersonalInfo(Expression<Func<systemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
        {
            var __workflow_systemIdType = WorkflowExpression.Compile(systemIdType, nameof(systemIdType), required: true);
            var __workflow_systemId = WorkflowExpression.Compile(systemId, nameof(systemId), required: true);
            return new DeferredBodyAction<EmployeePersonalInfoInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Get_Employee_Personal_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(__workflow_systemIdType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(__workflow_systemId);
                return new ApiConnectionAction<EmployeePersonalInfoInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeIdentityInfo, ApiConnectionActionConfiguration> GetEmployeeIdentityInfo(Expression<Func<systemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
        {
            var __workflow_systemIdType = WorkflowExpression.Compile(systemIdType, nameof(systemIdType), required: true);
            var __workflow_systemId = WorkflowExpression.Compile(systemId, nameof(systemId), required: true);
            return new DeferredBodyAction<EmployeeIdentityInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Get_Employee_Identity_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(__workflow_systemIdType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(__workflow_systemId);
                return new ApiConnectionAction<EmployeeIdentityInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeQualificationInfo, ApiConnectionActionConfiguration> GetEmployeeQualificationInfo(Expression<Func<systemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
        {
            var __workflow_systemIdType = WorkflowExpression.Compile(systemIdType, nameof(systemIdType), required: true);
            var __workflow_systemId = WorkflowExpression.Compile(systemId, nameof(systemId), required: true);
            return new DeferredBodyAction<EmployeeQualificationInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Get_Employee_Qualification_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(__workflow_systemIdType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(__workflow_systemId);
                return new ApiConnectionAction<EmployeeQualificationInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeEmploymentInfoInfo, ApiConnectionActionConfiguration> GetEmployeeEmploymentInfo(Expression<Func<systemIdTypeInput>> systemIdType, Expression<Func<string>> systemId)
        {
            var __workflow_systemIdType = WorkflowExpression.Compile(systemIdType, nameof(systemIdType), required: true);
            var __workflow_systemId = WorkflowExpression.Compile(systemId, nameof(systemId), required: true);
            return new DeferredBodyAction<EmployeeEmploymentInfoInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Get_Employee_Employment_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(__workflow_systemIdType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(__workflow_systemId);
                return new ApiConnectionAction<EmployeeEmploymentInfoInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SOAPOperation(Expression<Func<string>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SOAP_Operation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class WorkdayhcmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EmployeeInfo, ApiConnectionTriggerConfiguration> WhenAnEmployeeIsAddedOrUpdated(Expression<Func<dateCriteriaInput>> dateCriteria, Expression<Func<businessProcessTypeInput>> businessProcessType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dateCriteria = WorkflowExpression.Compile(dateCriteria, nameof(dateCriteria), required: true);
            var __workflow_businessProcessType = WorkflowExpression.Compile(businessProcessType, nameof(businessProcessType), required: false);
            return new DeferredBodyTrigger<EmployeeInfo, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/When_an_Employee_is_Added_or_Updated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["dateCriteria"] = ExpressionConverter.Convert(__workflow_dateCriteria);
                if (__workflow_businessProcessType != null)
                    callPayload.Queries["businessProcessType"] = ExpressionConverter.Convert(__workflow_businessProcessType);
                return new ApiConnectionTrigger<EmployeeInfo>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddOrUpdateContactInformationForPersonEventResponseInfo
    {
        [JsonProperty("add_or_Update_Contact_Information_for_Person_Event_Response")]
        public AddOrUpdateContactInformationForPersonEventResponseAddOrUpdateContactInformationForPersonEventResponseType AddOrUpdateContactInformationForPersonEventResponse { get; set; }
    }

    public class AddOrUpdateContactInformationForPersonEventResponseAddOrUpdateContactInformationForPersonEventResponseType
    {
        [JsonProperty("Contact_Information_for_Person_Event_Reference")]
        public AddOrUpdateContactInformationForPersonEventResponseAddOrUpdateContactInformationForPersonEventResponseTypeContactInformationForPersonEventReferenceType ContactInformationForPersonEventReference { get; set; }
    }

    public class AddOrUpdateContactInformationForPersonEventResponseAddOrUpdateContactInformationForPersonEventResponseTypeContactInformationForPersonEventReferenceType
    {
        [JsonProperty("PersonIDType")]
        public string PersonIdType { get; set; }

        [JsonProperty("PersonID")]
        public string PersonId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIdTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeId,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerId,
        [EnumMember(Value = "Workday ID")]
        WorkdayId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryIdInput
    {
        USA,
        GBR,
        CAN,
        CHN,
        IND,
        MEX,
        JPN
    }

    public class addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineDataInputItem
    {
        public addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineDataInputItemAddessLineTypeType AddessLineType { get; set; }
        public string AddressLine { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineDataInputItemAddessLineTypeType
    {
        [EnumMember(Value = "ADDRESS LINE 1")]
        ADDRESSLINE1,
        [EnumMember(Value = "ADDRESS LINE 2")]
        ADDRESSLINE2,
        [EnumMember(Value = "ADDRESS LINE 3")]
        ADDRESSLINE3
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput
    {
        Home,
        Business
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIdTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeId,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerId,
        [EnumMember(Value = "Workday ID")]
        WorkdayId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCodeInput
    {
        USA,
        GBR,
        CAN,
        CHN,
        IND,
        MEX,
        JPN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeIdInput
    {
        Mobile,
        Telephone,
        Fax,
        Pager
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput
    {
        Home,
        Business
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIdTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeId,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerId,
        [EnumMember(Value = "Workday ID")]
        WorkdayId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput
    {
        Home,
        Business
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIdTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeId,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerId,
        [EnumMember(Value = "Workday ID")]
        WorkdayId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeIdInput
    {
        AIM,
        [EnumMember(Value = "Google Talk")]
        GoogleTalk,
        Lync,
        Meebo,
        MSN,
        Skype,
        Yahoo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput
    {
        Home,
        Business
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIdTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeId,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerId,
        [EnumMember(Value = "Workday ID")]
        WorkdayId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIdInput
    {
        Home,
        Business
    }

    public class EmployeePersonalInfoInfo
    {
        [JsonProperty("employee_Personal_Info")]
        public EmployeePersonalInfoEmployeePersonalInfoType EmployeePersonalInfo { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoType
    {
        [JsonProperty("employee_Personal_Info_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType EmployeePersonalInfoData { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType
    {
        [JsonProperty("personal_Info_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType PersonalInfoData { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType
    {
        [JsonProperty("business_Title")]
        public string BusinessTitle { get; set; }

        [JsonProperty("person_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataType PersonData { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataType
    {
        [JsonProperty("name_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeNameDataTypeItem[] NameData { get; set; }

        [JsonProperty("contact_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataType ContactData { get; set; }

        [JsonProperty("demographic_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataType DemographicData { get; set; }

        [JsonProperty("biographic_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataType BiographicData { get; set; }

        [JsonProperty("personal_Preferences_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePersonalPreferencesDataType PersonalPreferencesData { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeNameDataTypeItem
    {
        [JsonProperty("country_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeNameDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("first_Name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_Name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_Name")]
        public string LastName { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeNameDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataType
    {
        [JsonProperty("internet_Email_Address_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInternetEmailAddressDataTypeItem[] InternetEmailAddressData { get; set; }

        [JsonProperty("phone_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypePhoneDataTypeItem[] PhoneData { get; set; }

        [JsonProperty("address_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeAddressDataTypeItem[] AddressData { get; set; }

        [JsonProperty("instant_Messenger_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInstantMessengerDataTypeItem[] InstantMessengerData { get; set; }

        [JsonProperty("web_Address_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeWebAddressDataTypeItem[] WebAddressData { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInternetEmailAddressDataTypeItem
    {
        [JsonProperty("email_Address")]
        public string EmailAddress { get; set; }

        [JsonProperty("usage_Data")]
        public CommunicationMethodUsageInformationData UsageData { get; set; }
    }

    public class CommunicationMethodUsageInformationData
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public CommunicationMethodUsageInformationDataTypeDataType TypeData { get; set; }
    }

    public class CommunicationMethodUsageInformationDataTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType TypeReference { get; set; }
    }

    public class CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypePhoneDataTypeItem
    {
        [JsonProperty("phone_Information_Data")]
        public PhoneInformationData PhoneInformationData { get; set; }
    }

    public class PhoneInformationData
    {
        [JsonProperty("country_ISO_Code")]
        public PhoneInformationDataCountryISOCodeType CountryISOCode { get; set; }

        [JsonProperty("area_Code")]
        public string AreaCode { get; set; }

        [JsonProperty("phone_Number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("phone_Extension")]
        public string PhoneExtension { get; set; }

        [JsonProperty("phone_Device_Type_Reference")]
        public PhoneInformationDataPhoneDeviceTypeReferenceType PhoneDeviceTypeReference { get; set; }

        [JsonProperty("usage_Data")]
        public PhoneInformationDataUsageDataType UsageData { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataCountryISOCodeType
    {
        USA,
        GBR,
        CAN,
        CHN,
        IND,
        MEX,
        JPN
    }

    public class PhoneInformationDataPhoneDeviceTypeReferenceType
    {
        [JsonProperty("PhoneDeviceTypeIDType")]
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType PhoneDeviceTypeIdType { get; set; }

        [JsonProperty("PhoneDeviceTypeID")]
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdType PhoneDeviceTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdTypeType
    {
        [EnumMember(Value = "Phone_Device_Type_ID")]
        PhoneDeviceTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIdType
    {
        Mobile,
        Telephone,
        Fax,
        Pager
    }

    public class PhoneInformationDataUsageDataType
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public PhoneInformationDataUsageDataTypeTypeDataType TypeData { get; set; }
    }

    public class PhoneInformationDataUsageDataTypeTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType TypeReference { get; set; }
    }

    public class PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeAddressDataTypeItem
    {
        [JsonProperty("address_Information_Data")]
        public AddressInformationData AddressInformationData { get; set; }
    }

    public class AddressInformationData
    {
        [JsonProperty("country_Reference")]
        public AddressInformationDataCountryReferenceType CountryReference { get; set; }

        [JsonProperty("address_Line_Data")]
        public AddressInformationDataAddressLineDataTypeItem[] AddressLineData { get; set; }

        [JsonProperty("municipality")]
        public string Municipality { get; set; }

        [JsonProperty("country_Region_Reference")]
        public AddressInformationDataCountryRegionReferenceType CountryRegionReference { get; set; }

        [JsonProperty("postal_Code")]
        public string PostalCode { get; set; }

        [JsonProperty("usage_Data")]
        public AddressInformationDataUsageDataType UsageData { get; set; }
    }

    public class AddressInformationDataCountryReferenceType
    {
        [JsonProperty("CountryIDType")]
        public AddressInformationDataCountryReferenceTypeCountryIdTypeType CountryIdType { get; set; }

        [JsonProperty("CountryID")]
        public AddressInformationDataCountryReferenceTypeCountryIdType CountryId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataCountryReferenceTypeCountryIdTypeType
    {
        [EnumMember(Value = "ISO 3166-1 Alpha-2 Code")]
        ISO31661Alpha2Code,
        [EnumMember(Value = "ISO 3166-1 Alpha-3 Code")]
        ISO31661Alpha3Code,
        [EnumMember(Value = "ISO 3166-1 Numeric-3 Code")]
        ISO31661Numeric3Code
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataCountryReferenceTypeCountryIdType
    {
        USA,
        GBR,
        CAN,
        CHN,
        IND,
        MEX,
        JPN
    }

    public class AddressInformationDataAddressLineDataTypeItem
    {
        public AddressInformationDataAddressLineDataTypeItemAddessLineTypeType AddessLineType { get; set; }
        public string AddressLine { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataAddressLineDataTypeItemAddessLineTypeType
    {
        [EnumMember(Value = "ADDRESS LINE 1")]
        ADDRESSLINE1,
        [EnumMember(Value = "ADDRESS LINE 2")]
        ADDRESSLINE2,
        [EnumMember(Value = "ADDRESS LINE 3")]
        ADDRESSLINE3
    }

    public class AddressInformationDataCountryRegionReferenceType
    {
        [JsonProperty("CountryRegionIDType")]
        public AddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType CountryRegionIdType { get; set; }

        [JsonProperty("CountryRegionID")]
        public string CountryRegionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataCountryRegionReferenceTypeCountryRegionIdTypeType
    {
        [EnumMember(Value = "Country Region ID")]
        CountryRegionId,
        [EnumMember(Value = "ISO 3166-2 Code")]
        ISO31662Code
    }

    public class AddressInformationDataUsageDataType
    {
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("type_Data")]
        public AddressInformationDataUsageDataTypeTypeDataType TypeData { get; set; }
    }

    public class AddressInformationDataUsageDataTypeTypeDataType
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("type_Reference")]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType TypeReference { get; set; }
    }

    public class AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceType
    {
        [JsonProperty("communicationUsageTypeIDType")]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType CommunicationUsageTypeIdType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType CommunicationUsageTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIdType
    {
        Home,
        Business
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeInstantMessengerDataTypeItem
    {
        [JsonProperty("instant_Messenger_Information_Data")]
        public InstantMessengerInformationData InstantMessengerInformationData { get; set; }
    }

    public class InstantMessengerInformationData
    {
        [JsonProperty("instant_Messenger_Address")]
        public string InstantMessengerAddress { get; set; }

        [JsonProperty("instant_Messenger_Type_Reference")]
        public InstantMessengerInformationDataInstantMessengerTypeReferenceType InstantMessengerTypeReference { get; set; }

        [JsonProperty("usage_Data")]
        public CommunicationMethodUsageInformationData UsageData { get; set; }
    }

    public class InstantMessengerInformationDataInstantMessengerTypeReferenceType
    {
        [JsonProperty("InstantMessengerTypeIDType")]
        public InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType InstantMessengerTypeIdType { get; set; }

        [JsonProperty("InstantMessengerTypeID")]
        public InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdType InstantMessengerTypeId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdTypeType
    {
        [EnumMember(Value = "Instant_Messenger_Type_ID")]
        InstantMessengerTypeId,
        [EnumMember(Value = "WID")]
        WId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIdType
    {
        AIM,
        [EnumMember(Value = "Google Talk")]
        GoogleTalk,
        Lync,
        Meebo,
        MSN,
        Skype,
        Yahoo
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeContactDataTypeWebAddressDataTypeItem
    {
        [JsonProperty("web_Address_Information_Data")]
        public WebAddressInformationData WebAddressInformationData { get; set; }
    }

    public class WebAddressInformationData
    {
        [JsonProperty("web_Address")]
        public string WebAddress { get; set; }

        [JsonProperty("usage_Data")]
        public CommunicationMethodUsageInformationData UsageData { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataType
    {
        [JsonProperty("marital_Status_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMaritalStatusReferenceType MaritalStatusReference { get; set; }

        [JsonProperty("hispanic_or_Latino")]
        public bool HispanicOrLatino { get; set; }

        [JsonProperty("ethnicity_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeEthnicityReferenceTypeItem[] EthnicityReference { get; set; }

        [JsonProperty("citizenship_Status_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeCitizenshipStatusReferenceTypeItem[] CitizenshipStatusReference { get; set; }

        [JsonProperty("nationality_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeNationalityReferenceTypeItem[] NationalityReference { get; set; }

        [JsonProperty("personnel_File_Agency")]
        public string PersonnelFileAgency { get; set; }

        [JsonProperty("military_Service_Data")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItem[] MilitaryServiceData { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMaritalStatusReferenceType
    {
        [JsonProperty("marital_Status_Description")]
        public string MaritalStatusDescription { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeEthnicityReferenceTypeItem
    {
        [JsonProperty("ethnicity_Name")]
        public string EthnicityName { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeCitizenshipStatusReferenceTypeItem
    {
        [JsonProperty("citizenship_Status_Description")]
        public string CitizenshipStatusDescription { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeCitizenshipStatusReferenceTypeItemCountryReferenceType CountryReference { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeCitizenshipStatusReferenceTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeNationalityReferenceTypeItem
    {
        [JsonProperty("CountryIDType")]
        public string CountryIdType { get; set; }

        [JsonProperty("CountryID")]
        public string CountryId { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItem
    {
        [JsonProperty("military_Status_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItemMilitaryStatusReferenceType MilitaryStatusReference { get; set; }

        [JsonProperty("military_Discharge_Date")]
        public string MilitaryDischargeDate { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItemMilitaryStatusReferenceType
    {
        [JsonProperty("military_Status_Name")]
        public string MilitaryStatusName { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItemMilitaryStatusReferenceTypeCountryReferenceType CountryReference { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeDemographicDataTypeMilitaryServiceDataTypeItemMilitaryStatusReferenceTypeCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataType
    {
        [JsonProperty("country_Of_Birth_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeCountryOfBirthReferenceType CountryOfBirthReference { get; set; }

        [JsonProperty("place_Of_Birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("date_Of_Birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("gender_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeGenderReferenceType GenderReference { get; set; }

        [JsonProperty("disability_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeDisabilityReferenceTypeItem[] DisabilityReference { get; set; }

        [JsonProperty("uses_Tobacco")]
        public bool UsesTobacco { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeCountryOfBirthReferenceType
    {
        [JsonProperty("country_Reference")]
        public EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeCountryOfBirthReferenceTypeCountryReferenceType CountryReference { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeCountryOfBirthReferenceTypeCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeGenderReferenceType
    {
        [JsonProperty("gender_Description")]
        public string GenderDescription { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeBiographicDataTypeDisabilityReferenceTypeItem
    {
        [JsonProperty("disability_Name")]
        public string DisabilityName { get; set; }
    }

    public class EmployeePersonalInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePersonalPreferencesDataType
    {
        [JsonProperty("receive_Email_Notifications")]
        public bool ReceiveEmailNotifications { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum systemIdTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeId,
        [EnumMember(Value = "Workday ID")]
        WorkdayId
    }

    public class EmployeeIdentityInfo
    {
        [JsonProperty("employee_Personal_Info")]
        public EmployeeIdentityInfoEmployeePersonalInfoType EmployeePersonalInfo { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoType
    {
        [JsonProperty("employee_Personal_Info_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType EmployeePersonalInfoData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType
    {
        [JsonProperty("personal_Info_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType PersonalInfoData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType
    {
        [JsonProperty("person_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataType PersonData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataType
    {
        [JsonProperty("visa_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItem[] VisaIdData { get; set; }

        [JsonProperty("custom_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIdDataTypeItem[] CustomIdData { get; set; }

        [JsonProperty("government_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItem[] GovernmentIdData { get; set; }

        [JsonProperty("license_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIdDataTypeItem[] LicenseIdData { get; set; }

        [JsonProperty("passport_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItem[] PassportIdData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItem
    {
        [JsonProperty("visa_ID")]
        public string VisaId { get; set; }

        [JsonProperty("visa_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItemVisaTypeReferenceType VisaTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItemVisaTypeReferenceType
    {
        [JsonProperty("visa_Type_Name")]
        public string VisaTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIdDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIdDataTypeItem
    {
        [JsonProperty("custom_ID")]
        public string CustomId { get; set; }

        [JsonProperty("custom_ID_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIdDataTypeItemCustomIdTypeReferenceType CustomIdTypeReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIdDataTypeItemCustomIdTypeReferenceType
    {
        [JsonProperty("custom_ID_Type_Name")]
        public string CustomIdTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItem
    {
        [JsonProperty("government_ID")]
        public string GovernmentId { get; set; }

        [JsonProperty("government_ID_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItemGovernmentIdTypeReferenceType GovernmentIdTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItemGovernmentIdTypeReferenceType
    {
        [JsonProperty("government_ID_Type_Name")]
        public string GovernmentIdTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIdDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIdDataTypeItem
    {
        [JsonProperty("license_ID")]
        public string LicenseId { get; set; }

        [JsonProperty("license_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIdDataTypeItemLicenseTypeReferenceType LicenseTypeReference { get; set; }

        [JsonProperty("license_Class")]
        public string LicenseClass { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIdDataTypeItemLicenseTypeReferenceType
    {
        [JsonProperty("license_Type_Name")]
        public string LicenseTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItem
    {
        [JsonProperty("passport_Number")]
        public string PassportNumber { get; set; }

        [JsonProperty("passport_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItemPassportTypeReferenceType PassportTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItemPassportTypeReferenceType
    {
        [JsonProperty("passport_Type_Name")]
        public string PassportTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIdDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeeQualificationInfo
    {
        [JsonProperty("employee_Personal_Info")]
        public EmployeeQualificationInfoEmployeePersonalInfoType EmployeePersonalInfo { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoType
    {
        [JsonProperty("employee_Personal_Info_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType EmployeePersonalInfoData { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataType
    {
        [JsonProperty("personal_Info_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType PersonalInfoData { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataType
    {
        [JsonProperty("qualification_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataType QualificationData { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataType
    {
        [JsonProperty("education_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItem[] EducationData { get; set; }

        [JsonProperty("professional_Experience_Data")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeProfessionalExperienceDataTypeItem[] ProfessionalExperienceData { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItem
    {
        [JsonProperty("education_Institution")]
        public string EducationInstitution { get; set; }

        [JsonProperty("educational_Institution_Type_Reference")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemEducationalInstitutionTypeReferenceType EducationalInstitutionTypeReference { get; set; }

        [JsonProperty("degree_Reference")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemDegreeReferenceType DegreeReference { get; set; }

        [JsonProperty("field_Of_Study_Reference")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemFieldOfStudyReferenceType FieldOfStudyReference { get; set; }

        [JsonProperty("education_Institution_Location")]
        public string EducationInstitutionLocation { get; set; }

        [JsonProperty("education_Grade_Average")]
        public string EducationGradeAverage { get; set; }

        [JsonProperty("first_Year_Attended")]
        public string FirstYearAttended { get; set; }

        [JsonProperty("last_Year_Attended")]
        public string LastYearAttended { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemEducationalInstitutionTypeReferenceType
    {
        [JsonProperty("institution_Type_Name")]
        public string InstitutionTypeName { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemDegreeReferenceType
    {
        [JsonProperty("degree_Name")]
        public string DegreeName { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeEducationDataTypeItemFieldOfStudyReferenceType
    {
        [JsonProperty("field_Of_Study_Name")]
        public string FieldOfStudyName { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeProfessionalExperienceDataTypeItem
    {
        [JsonProperty("professional_Experience")]
        public string ProfessionalExperience { get; set; }

        [JsonProperty("professional_Experience_Rating_Reference")]
        public EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeProfessionalExperienceDataTypeItemProfessionalExperienceRatingReferenceType ProfessionalExperienceRatingReference { get; set; }
    }

    public class EmployeeQualificationInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypeQualificationDataTypeProfessionalExperienceDataTypeItemProfessionalExperienceRatingReferenceType
    {
        [JsonProperty("rating_Description")]
        public string RatingDescription { get; set; }
    }

    public class EmployeeEmploymentInfoInfo
    {
        [JsonProperty("employee_Employment_Info")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoType EmployeeEmploymentInfo { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoType
    {
        [JsonProperty("employee_Employment_Info_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataType EmployeeEmploymentInfoData { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataType
    {
        [JsonProperty("worker_Status_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataType WorkerStatusData { get; set; }

        [JsonProperty("worker_Position_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataType WorkerPositionData { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("hire_Date")]
        public string HireDate { get; set; }

        [JsonProperty("original_Hire_Date")]
        public string OriginalHireDate { get; set; }

        [JsonProperty("end_Employment_Date")]
        public string EndEmploymentDate { get; set; }

        [JsonProperty("hire_Reason")]
        public string HireReason { get; set; }

        [JsonProperty("continuous_Service_Date")]
        public string ContinuousServiceDate { get; set; }

        [JsonProperty("first_Day_of_Work")]
        public string FirstDayOfWork { get; set; }

        [JsonProperty("expected_Retirement_Date")]
        public string ExpectedRetirementDate { get; set; }

        [JsonProperty("retirement_Eligibility_Date")]
        public string RetirementEligibilityDate { get; set; }

        [JsonProperty("retired")]
        public bool Retired { get; set; }

        [JsonProperty("retirement_Date")]
        public string RetirementDate { get; set; }

        [JsonProperty("seniority_Date")]
        public string SeniorityDate { get; set; }

        [JsonProperty("severance_Date")]
        public string SeveranceDate { get; set; }

        [JsonProperty("benefits_Service_Date")]
        public string BenefitsServiceDate { get; set; }

        [JsonProperty("company_Service_Date")]
        public string CompanyServiceDate { get; set; }

        [JsonProperty("time_Off_Service_Date")]
        public string TimeOffServiceDate { get; set; }

        [JsonProperty("vesting_Date")]
        public string VestingDate { get; set; }

        [JsonProperty("date_Entered_Workforce")]
        public string DateEnteredWorkforce { get; set; }

        [JsonProperty("days_Unemployed")]
        public double DaysUnemployed { get; set; }

        [JsonProperty("months_Continuous_Prior_Employment")]
        public double MonthsContinuousPriorEmployment { get; set; }

        [JsonProperty("leave_Status_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeLeaveStatusDataTypeItem[] LeaveStatusData { get; set; }

        [JsonProperty("termination_Status_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeTerminationStatusDataTypeItem[] TerminationStatusData { get; set; }

        [JsonProperty("probation_Status_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeProbationStatusDataTypeItem[] ProbationStatusData { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeLeaveStatusDataTypeItem
    {
        [JsonProperty("on_Leave")]
        public bool OnLeave { get; set; }

        [JsonProperty("leave_Start_Date")]
        public string LeaveStartDate { get; set; }

        [JsonProperty("estimated_Leave_End_Date")]
        public string EstimatedLeaveEndDate { get; set; }

        [JsonProperty("leave_End_Date")]
        public string LeaveEndDate { get; set; }

        [JsonProperty("first_Day_Of_Work")]
        public string FirstDayOfWork { get; set; }

        [JsonProperty("leave_of_Absence_Type_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeLeaveStatusDataTypeItemLeaveOfAbsenceTypeReferenceType LeaveOfAbsenceTypeReference { get; set; }

        [JsonProperty("benefits_Effect")]
        public bool BenefitsEffect { get; set; }

        [JsonProperty("payroll_Effect")]
        public bool PayrollEffect { get; set; }

        [JsonProperty("paid_Time_Off_Accrual_Effect")]
        public bool PaidTimeOffAccrualEffect { get; set; }

        [JsonProperty("continuous_Service_Accrual_Effect")]
        public bool ContinuousServiceAccrualEffect { get; set; }

        [JsonProperty("stock_Vesting_Effect")]
        public bool StockVestingEffect { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeLeaveStatusDataTypeItemLeaveOfAbsenceTypeReferenceType
    {
        [JsonProperty("leave_Type_Name")]
        public string LeaveTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeTerminationStatusDataTypeItem
    {
        [JsonProperty("terminated")]
        public bool Terminated { get; set; }

        [JsonProperty("termination_Date")]
        public string TerminationDate { get; set; }

        [JsonProperty("termination_Category")]
        public string TerminationCategory { get; set; }

        [JsonProperty("termination_Reason")]
        public string TerminationReason { get; set; }

        [JsonProperty("involuntary_Termination")]
        public bool InvoluntaryTermination { get; set; }

        [JsonProperty("not_Eligible_For_Hire")]
        public bool NotEligibleForHire { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerStatusDataTypeProbationStatusDataTypeItem
    {
        [JsonProperty("probation_Start_Date")]
        public string ProbationStartDate { get; set; }

        [JsonProperty("probation_End_Date")]
        public string ProbationEndDate { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataType
    {
        [JsonProperty("position_ID")]
        public string PositionId { get; set; }

        [JsonProperty("position_Title")]
        public string PositionTitle { get; set; }

        [JsonProperty("business_Title")]
        public string BusinessTitle { get; set; }

        [JsonProperty("employee_Type_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeEmployeeTypeReferenceTypeItem[] EmployeeTypeReference { get; set; }

        [JsonProperty("position_Time_Type_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePositionTimeTypeReferenceTypeItem[] PositionTimeTypeReference { get; set; }

        [JsonProperty("job_Exempt")]
        public bool JobExempt { get; set; }

        [JsonProperty("scheduled_Weekly_Hours")]
        public double ScheduledWeeklyHours { get; set; }

        [JsonProperty("default_Weekly_Hours")]
        public double DefaultWeeklyHours { get; set; }

        [JsonProperty("full_Time_Equivalent_Percentage")]
        public double FullTimeEquivalentPercentage { get; set; }

        [JsonProperty("pay_Rate_Type_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayRateTypeReferenceTypeItem[] PayRateTypeReference { get; set; }

        [JsonProperty("job_Classification_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobClassificationReferenceTypeItem[] JobClassificationReference { get; set; }

        [JsonProperty("company_Insider_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeCompanyInsiderReferenceTypeItem[] CompanyInsiderReference { get; set; }

        [JsonProperty("job_Profile_Summary_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItem[] JobProfileSummaryData { get; set; }

        [JsonProperty("organization_Content_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItem[] OrganizationContentData { get; set; }

        [JsonProperty("business_Site_Content_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItem[] BusinessSiteContentData { get; set; }

        [JsonProperty("payroll_Processing_Data")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItem[] PayrollProcessingData { get; set; }

        [JsonProperty("supervisor_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceType SupervisorReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeEmployeeTypeReferenceTypeItem
    {
        [JsonProperty("employee_Type_Description")]
        public string EmployeeTypeDescription { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePositionTimeTypeReferenceTypeItem
    {
        [JsonProperty("time_Type_Description")]
        public string TimeTypeDescription { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayRateTypeReferenceTypeItem
    {
        [JsonProperty("pay_Type_Name")]
        public string PayTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobClassificationReferenceTypeItem
    {
        [JsonProperty("job_Classification_Group_Name")]
        public string JobClassificationGroupName { get; set; }

        [JsonProperty("job_Classification_Name")]
        public string JobClassificationName { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeCompanyInsiderReferenceTypeItem
    {
        [JsonProperty("company_Insider_Type_Name")]
        public string CompanyInsiderTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItem
    {
        [JsonProperty("job_Profile_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobProfileReferenceType JobProfileReference { get; set; }

        [JsonProperty("job_Exempt")]
        public bool JobExempt { get; set; }

        [JsonProperty("management_Level_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemManagementLevelReferenceType ManagementLevelReference { get; set; }

        [JsonProperty("job_Category_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobCategoryReferenceType JobCategoryReference { get; set; }

        [JsonProperty("job_Profile_Name")]
        public string JobProfileName { get; set; }

        [JsonProperty("work_Shift_Required")]
        public bool WorkShiftRequired { get; set; }

        [JsonProperty("critical_Job")]
        public bool CriticalJob { get; set; }

        [JsonProperty("difficulty_to_Fill_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemDifficultyToFillReferenceType DifficultyToFillReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobProfileReferenceType
    {
        [JsonProperty("JobProfileIDType")]
        public string JobProfileIdType { get; set; }

        [JsonProperty("JobProfileID")]
        public string JobProfileId { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemManagementLevelReferenceType
    {
        [JsonProperty("ManagementLevelIDType")]
        public string ManagementLevelIdType { get; set; }

        [JsonProperty("ManagementLevelID")]
        public string ManagementLevelId { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobCategoryReferenceType
    {
        [JsonProperty("JobCategoryIDType")]
        public string JobCategoryIdType { get; set; }

        [JsonProperty("JobCategoryID")]
        public string JobCategoryId { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemDifficultyToFillReferenceType
    {
        [JsonProperty("DifficultyToFillIDType")]
        public string DifficultyToFillIdType { get; set; }

        [JsonProperty("DifficultyToFillID")]
        public string DifficultyToFillId { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItem
    {
        [JsonProperty("organization_ID")]
        public string OrganizationId { get; set; }

        [JsonProperty("organization_Name")]
        public string OrganizationName { get; set; }

        [JsonProperty("organization_Type_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItemOrganizationTypeReferenceTypeItem[] OrganizationTypeReference { get; set; }

        [JsonProperty("organization_Subtype_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItemOrganizationSubtypeReferenceTypeItem[] OrganizationSubtypeReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItemOrganizationTypeReferenceTypeItem
    {
        [JsonProperty("organization_Type_Name")]
        public string OrganizationTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItemOrganizationSubtypeReferenceTypeItem
    {
        [JsonProperty("organization_Subtype_Name")]
        public string OrganizationSubtypeName { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItem
    {
        [JsonProperty("location_Name")]
        public string LocationName { get; set; }

        [JsonProperty("location_Type_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItemLocationTypeReferenceTypeItem[] LocationTypeReference { get; set; }

        [JsonProperty("time_Profile_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItemTimeProfileReferenceTypeItem[] TimeProfileReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItemLocationTypeReferenceTypeItem
    {
        [JsonProperty("location_Type_Description")]
        public string LocationTypeDescription { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeBusinessSiteContentDataTypeItemTimeProfileReferenceTypeItem
    {
        [JsonProperty("time_Profile_Description")]
        public string TimeProfileDescription { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItem
    {
        [JsonProperty("pay_Rate_Type_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayRateTypeReferenceType PayRateTypeReference { get; set; }

        [JsonProperty("frequency_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemFrequencyReferenceType FrequencyReference { get; set; }

        [JsonProperty("pay_Group_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayGroupReferenceType PayGroupReference { get; set; }

        [JsonProperty("payroll_Entity_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayrollEntityReferenceTypeItem[] PayrollEntityReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayRateTypeReferenceType
    {
        [JsonProperty("pay_Type_Name")]
        public string PayTypeName { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemFrequencyReferenceType
    {
        [JsonProperty("frequency_Name")]
        public string FrequencyName { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayGroupReferenceType
    {
        [JsonProperty("pay_Group_ID")]
        public string PayGroupId { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayrollEntityReferenceTypeItem
    {
        [JsonProperty("payroll_Entity_ID")]
        public string PayrollEntityId { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceType
    {
        [JsonProperty("employee_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceType EmployeeReference { get; set; }

        [JsonProperty("contingent_Worker_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceType ContingentWorkerReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceType
    {
        [JsonProperty("integration_ID_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceTypeIntegrationIdReferenceType IntegrationIdReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceTypeIntegrationIdReferenceType
    {
        [JsonProperty("IntegrationID")]
        public string IntegrationId { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceType
    {
        [JsonProperty("integration_ID_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceTypeIntegrationIdReferenceType IntegrationIdReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceTypeIntegrationIdReferenceType
    {
        [JsonProperty("IntegrationID")]
        public string IntegrationId { get; set; }
    }

    public class EmployeeInfo
    {
        public EmployeeInfoWorkersTypeItem[] Workers { get; set; }
    }

    public class EmployeeInfoWorkersTypeItem
    {
        [JsonProperty("Worker_Data")]
        public EmployeeInfoWorkersTypeItemWorkerDataType WorkerData { get; set; }
    }

    public class EmployeeInfoWorkersTypeItemWorkerDataType
    {
        [JsonProperty("Worker_ID")]
        public int WorkerId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dateCriteriaInput
    {
        [EnumMember(Value = "Effective Date")]
        EffectiveDate,
        [EnumMember(Value = "Updated Date")]
        UpdatedDate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum businessProcessTypeInput
    {
        [EnumMember(Value = "Hire Employee")]
        HireEmployee,
        [EnumMember(Value = "Terminate Employee")]
        TerminateEmployee
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm;

    public partial class WorkflowManagedActions
    {
        public WorkdayhcmActions Workdayhcm(string connectionId) => new WorkdayhcmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkdayhcmTriggers Workdayhcm(string connectionId) => new WorkdayhcmTriggers(connectionId);
    }
}