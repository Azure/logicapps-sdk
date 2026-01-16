//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkdayhcmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdateAddressInformation(Expression<Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceWorkerIDTypeInput>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceWorkerIDType, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceWorkerID, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate, Expression<Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferenceCountryIDInput>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferenceCountryID = null, Expression<Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineDataInputItem[]>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData = null, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality = null, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferenceCountryRegionID = null, Expression<Func<string>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode = null, Expression<Func<bool>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput>> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            var apiCallPath = "/Add_or_Update_Address_Information";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addOrUpdateAddressInformationForPersonEventRequest = new JObject();
            var addOrUpdateAddressInformationForPersonEventRequestpropCount = 0;
            var add_or_Update_Address_Information_for_Person_Event_RequestObject = new JObject();
            var add_or_Update_Address_Information_for_Person_Event_RequestObjectpropCount = 0;
            var add_or_Update_Address_Information_DataObject = new JObject();
            var add_or_Update_Address_Information_DataObjectpropCount = 0;
            var worker_ReferenceObject = new JObject();
            var worker_ReferenceObjectpropCount = 0;
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceWorkerIDType);
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceWorkerID);
            if (worker_ReferenceObjectpropCount > 0)
            {
                add_or_Update_Address_Information_DataObject["worker_Reference"] = worker_ReferenceObject;
                add_or_Update_Address_Information_DataObjectpropCount++;
            }

            add_or_Update_Address_Information_DataObjectpropCount++;
            add_or_Update_Address_Information_DataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate);
            var address_Information_DataObject = new JObject();
            var address_Information_DataObjectpropCount = 0;
            var country_ReferenceObject = new JObject();
            var country_ReferenceObjectpropCount = 0;
            country_ReferenceObject["CountryIDType"] = "ISO 3166-1 Alpha-3 Code";
            country_ReferenceObjectpropCount++;
            if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferenceCountryID != null)
            {
                country_ReferenceObject["CountryID"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferenceCountryID);
                country_ReferenceObjectpropCount++;
            }

            if (country_ReferenceObjectpropCount > 0)
            {
                address_Information_DataObject["country_Reference"] = country_ReferenceObject;
                address_Information_DataObjectpropCount++;
            }

            if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData != null)
            {
                address_Information_DataObject["address_Line_Data"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData);
                address_Information_DataObjectpropCount++;
            }

            if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality != null)
            {
                address_Information_DataObject["municipality"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality);
                address_Information_DataObjectpropCount++;
            }

            var country_Region_ReferenceObject = new JObject();
            var country_Region_ReferenceObjectpropCount = 0;
            country_Region_ReferenceObject["CountryRegionIDType"] = "ISO 3166-2 Code";
            country_Region_ReferenceObjectpropCount++;
            if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferenceCountryRegionID != null)
            {
                country_Region_ReferenceObject["CountryRegionID"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferenceCountryRegionID);
                country_Region_ReferenceObjectpropCount++;
            }

            if (country_Region_ReferenceObjectpropCount > 0)
            {
                address_Information_DataObject["country_Region_Reference"] = country_Region_ReferenceObject;
                address_Information_DataObjectpropCount++;
            }

            if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode != null)
            {
                address_Information_DataObject["postal_Code"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode);
                address_Information_DataObjectpropCount++;
            }

            var usage_DataObject = new JObject();
            var usage_DataObjectpropCount = 0;
            if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic != null)
            {
                usage_DataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic);
                usage_DataObjectpropCount++;
            }

            var type_DataObject = new JObject();
            var type_DataObjectpropCount = 0;
            if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary != null)
            {
                type_DataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary);
                type_DataObjectpropCount++;
            }

            var type_ReferenceObject = new JObject();
            var type_ReferenceObjectpropCount = 0;
            type_ReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
            type_ReferenceObjectpropCount++;
            if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
            {
                type_ReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
                type_ReferenceObjectpropCount++;
            }

            if (type_ReferenceObjectpropCount > 0)
            {
                type_DataObject["type_Reference"] = type_ReferenceObject;
                type_DataObjectpropCount++;
            }

            if (type_DataObjectpropCount > 0)
            {
                usage_DataObject["type_Data"] = type_DataObject;
                usage_DataObjectpropCount++;
            }

            if (usage_DataObjectpropCount > 0)
            {
                address_Information_DataObject["usage_Data"] = usage_DataObject;
                address_Information_DataObjectpropCount++;
            }

            if (address_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Address_Information_DataObject["address_Information_Data"] = address_Information_DataObject;
                add_or_Update_Address_Information_DataObjectpropCount++;
            }

            if (add_or_Update_Address_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Address_Information_for_Person_Event_RequestObject["add_or_Update_Address_Information_Data"] = add_or_Update_Address_Information_DataObject;
                add_or_Update_Address_Information_for_Person_Event_RequestObjectpropCount++;
            }

            if (add_or_Update_Address_Information_for_Person_Event_RequestObjectpropCount > 0)
            {
                addOrUpdateAddressInformationForPersonEventRequest["add_or_Update_Address_Information_for_Person_Event_Request"] = add_or_Update_Address_Information_for_Person_Event_RequestObject;
                addOrUpdateAddressInformationForPersonEventRequestpropCount++;
            }

            if (addOrUpdateAddressInformationForPersonEventRequestpropCount > 0)
            {
                callPayload.Body = addOrUpdateAddressInformationForPersonEventRequest;
            }

            return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdatePhoneInformation(Expression<Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceWorkerIDTypeInput>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceWorkerIDType, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceWorkerID, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate, Expression<Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCodeInput>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode = null, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode = null, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber = null, Expression<Func<string>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension = null, Expression<Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencePhoneDeviceTypeIDInput>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencePhoneDeviceTypeID = null, Expression<Func<bool>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput>> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            var apiCallPath = "/Add_or_Update_Phone_Information";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addOrUpdatePhoneInformationForPersonEventRequest = new JObject();
            var addOrUpdatePhoneInformationForPersonEventRequestpropCount = 0;
            var add_or_Update_Phone_Information_for_Person_Event_RequestObject = new JObject();
            var add_or_Update_Phone_Information_for_Person_Event_RequestObjectpropCount = 0;
            var add_or_Update_Phone_Information_DataObject = new JObject();
            var add_or_Update_Phone_Information_DataObjectpropCount = 0;
            var worker_ReferenceObject = new JObject();
            var worker_ReferenceObjectpropCount = 0;
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceWorkerIDType);
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceWorkerID);
            if (worker_ReferenceObjectpropCount > 0)
            {
                add_or_Update_Phone_Information_DataObject["worker_Reference"] = worker_ReferenceObject;
                add_or_Update_Phone_Information_DataObjectpropCount++;
            }

            add_or_Update_Phone_Information_DataObjectpropCount++;
            add_or_Update_Phone_Information_DataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate);
            var phone_Information_DataObject = new JObject();
            var phone_Information_DataObjectpropCount = 0;
            if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode != null)
            {
                phone_Information_DataObject["country_ISO_Code"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode);
                phone_Information_DataObjectpropCount++;
            }

            if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode != null)
            {
                phone_Information_DataObject["area_Code"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode);
                phone_Information_DataObjectpropCount++;
            }

            if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber != null)
            {
                phone_Information_DataObject["phone_Number"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber);
                phone_Information_DataObjectpropCount++;
            }

            if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension != null)
            {
                phone_Information_DataObject["phone_Extension"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension);
                phone_Information_DataObjectpropCount++;
            }

            var phone_Device_Type_ReferenceObject = new JObject();
            var phone_Device_Type_ReferenceObjectpropCount = 0;
            phone_Device_Type_ReferenceObject["PhoneDeviceTypeIDType"] = "Phone_Device_Type_ID";
            phone_Device_Type_ReferenceObjectpropCount++;
            if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencePhoneDeviceTypeID != null)
            {
                phone_Device_Type_ReferenceObject["PhoneDeviceTypeID"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencePhoneDeviceTypeID);
                phone_Device_Type_ReferenceObjectpropCount++;
            }

            if (phone_Device_Type_ReferenceObjectpropCount > 0)
            {
                phone_Information_DataObject["phone_Device_Type_Reference"] = phone_Device_Type_ReferenceObject;
                phone_Information_DataObjectpropCount++;
            }

            var usage_DataObject = new JObject();
            var usage_DataObjectpropCount = 0;
            if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic != null)
            {
                usage_DataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic);
                usage_DataObjectpropCount++;
            }

            var type_DataObject = new JObject();
            var type_DataObjectpropCount = 0;
            if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary != null)
            {
                type_DataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary);
                type_DataObjectpropCount++;
            }

            var type_ReferenceObject = new JObject();
            var type_ReferenceObjectpropCount = 0;
            type_ReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
            type_ReferenceObjectpropCount++;
            if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
            {
                type_ReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
                type_ReferenceObjectpropCount++;
            }

            if (type_ReferenceObjectpropCount > 0)
            {
                type_DataObject["type_Reference"] = type_ReferenceObject;
                type_DataObjectpropCount++;
            }

            if (type_DataObjectpropCount > 0)
            {
                usage_DataObject["type_Data"] = type_DataObject;
                usage_DataObjectpropCount++;
            }

            if (usage_DataObjectpropCount > 0)
            {
                phone_Information_DataObject["usage_Data"] = usage_DataObject;
                phone_Information_DataObjectpropCount++;
            }

            if (phone_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Phone_Information_DataObject["phone_Information_Data"] = phone_Information_DataObject;
                add_or_Update_Phone_Information_DataObjectpropCount++;
            }

            if (add_or_Update_Phone_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Phone_Information_for_Person_Event_RequestObject["add_or_Update_Phone_Information_Data"] = add_or_Update_Phone_Information_DataObject;
                add_or_Update_Phone_Information_for_Person_Event_RequestObjectpropCount++;
            }

            if (add_or_Update_Phone_Information_for_Person_Event_RequestObjectpropCount > 0)
            {
                addOrUpdatePhoneInformationForPersonEventRequest["add_or_Update_Phone_Information_for_Person_Event_Request"] = add_or_Update_Phone_Information_for_Person_Event_RequestObject;
                addOrUpdatePhoneInformationForPersonEventRequestpropCount++;
            }

            if (addOrUpdatePhoneInformationForPersonEventRequestpropCount > 0)
            {
                callPayload.Body = addOrUpdatePhoneInformationForPersonEventRequest;
            }

            return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdateEmailAddressInformation(Expression<Func<addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceWorkerIDTypeInput>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceWorkerIDType, Expression<Func<string>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceWorkerID, Expression<Func<string>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate, Expression<Func<string>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress = null, Expression<Func<bool>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput>> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            var apiCallPath = "/Add_or_Update_Email_Address_Information";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addOrUpdateEmailAddressInformationForPersonEventRequest = new JObject();
            var addOrUpdateEmailAddressInformationForPersonEventRequestpropCount = 0;
            var add_or_Update_Email_Address_Information_for_Person_Event_RequestObject = new JObject();
            var add_or_Update_Email_Address_Information_for_Person_Event_RequestObjectpropCount = 0;
            var add_or_Update_Email_Address_Information_DataObject = new JObject();
            var add_or_Update_Email_Address_Information_DataObjectpropCount = 0;
            var worker_ReferenceObject = new JObject();
            var worker_ReferenceObjectpropCount = 0;
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceWorkerIDType);
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceWorkerID);
            if (worker_ReferenceObjectpropCount > 0)
            {
                add_or_Update_Email_Address_Information_DataObject["worker_Reference"] = worker_ReferenceObject;
                add_or_Update_Email_Address_Information_DataObjectpropCount++;
            }

            add_or_Update_Email_Address_Information_DataObjectpropCount++;
            add_or_Update_Email_Address_Information_DataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate);
            var email_Address_Information_DataObject = new JObject();
            var email_Address_Information_DataObjectpropCount = 0;
            if (addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress != null)
            {
                email_Address_Information_DataObject["email_Address"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress);
                email_Address_Information_DataObjectpropCount++;
            }

            var usage_DataObject = new JObject();
            var usage_DataObjectpropCount = 0;
            if (addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic != null)
            {
                usage_DataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic);
                usage_DataObjectpropCount++;
            }

            var type_DataObject = new JObject();
            var type_DataObjectpropCount = 0;
            if (addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary != null)
            {
                type_DataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary);
                type_DataObjectpropCount++;
            }

            var type_ReferenceObject = new JObject();
            var type_ReferenceObjectpropCount = 0;
            type_ReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
            type_ReferenceObjectpropCount++;
            if (addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
            {
                type_ReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
                type_ReferenceObjectpropCount++;
            }

            if (type_ReferenceObjectpropCount > 0)
            {
                type_DataObject["type_Reference"] = type_ReferenceObject;
                type_DataObjectpropCount++;
            }

            if (type_DataObjectpropCount > 0)
            {
                usage_DataObject["type_Data"] = type_DataObject;
                usage_DataObjectpropCount++;
            }

            if (usage_DataObjectpropCount > 0)
            {
                email_Address_Information_DataObject["usage_Data"] = usage_DataObject;
                email_Address_Information_DataObjectpropCount++;
            }

            if (email_Address_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Email_Address_Information_DataObject["email_Address_Information_Data"] = email_Address_Information_DataObject;
                add_or_Update_Email_Address_Information_DataObjectpropCount++;
            }

            if (add_or_Update_Email_Address_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Email_Address_Information_for_Person_Event_RequestObject["add_or_Update_Email_Address_Information_Data"] = add_or_Update_Email_Address_Information_DataObject;
                add_or_Update_Email_Address_Information_for_Person_Event_RequestObjectpropCount++;
            }

            if (add_or_Update_Email_Address_Information_for_Person_Event_RequestObjectpropCount > 0)
            {
                addOrUpdateEmailAddressInformationForPersonEventRequest["add_or_Update_Email_Address_Information_for_Person_Event_Request"] = add_or_Update_Email_Address_Information_for_Person_Event_RequestObject;
                addOrUpdateEmailAddressInformationForPersonEventRequestpropCount++;
            }

            if (addOrUpdateEmailAddressInformationForPersonEventRequestpropCount > 0)
            {
                callPayload.Body = addOrUpdateEmailAddressInformationForPersonEventRequest;
            }

            return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdateInstantMessengerInformation(Expression<Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceWorkerIDTypeInput>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceWorkerIDType, Expression<Func<string>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceWorkerID, Expression<Func<string>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate, Expression<Func<string>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress = null, Expression<Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceInstantMessengerTypeIDInput>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceInstantMessengerTypeID = null, Expression<Func<bool>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput>> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            var apiCallPath = "/Add_or_Update_Instant_Messenger_Information";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addOrUpdateInstantMessengerInformationForPersonEventRequest = new JObject();
            var addOrUpdateInstantMessengerInformationForPersonEventRequestpropCount = 0;
            var add_or_Update_Instant_Messenger_Information_for_Person_Event_RequestObject = new JObject();
            var add_or_Update_Instant_Messenger_Information_for_Person_Event_RequestObjectpropCount = 0;
            var add_or_Update_Instant_Messenger_Information_DataObject = new JObject();
            var add_or_Update_Instant_Messenger_Information_DataObjectpropCount = 0;
            var worker_ReferenceObject = new JObject();
            var worker_ReferenceObjectpropCount = 0;
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceWorkerIDType);
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceWorkerID);
            if (worker_ReferenceObjectpropCount > 0)
            {
                add_or_Update_Instant_Messenger_Information_DataObject["worker_Reference"] = worker_ReferenceObject;
                add_or_Update_Instant_Messenger_Information_DataObjectpropCount++;
            }

            add_or_Update_Instant_Messenger_Information_DataObjectpropCount++;
            add_or_Update_Instant_Messenger_Information_DataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate);
            var instant_Messenger_Information_DataObject = new JObject();
            var instant_Messenger_Information_DataObjectpropCount = 0;
            if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress != null)
            {
                instant_Messenger_Information_DataObject["instant_Messenger_Address"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress);
                instant_Messenger_Information_DataObjectpropCount++;
            }

            var instant_Messenger_Type_ReferenceObject = new JObject();
            var instant_Messenger_Type_ReferenceObjectpropCount = 0;
            instant_Messenger_Type_ReferenceObject["InstantMessengerTypeIDType"] = "Instant_Messenger_Type_ID";
            instant_Messenger_Type_ReferenceObjectpropCount++;
            if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceInstantMessengerTypeID != null)
            {
                instant_Messenger_Type_ReferenceObject["InstantMessengerTypeID"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceInstantMessengerTypeID);
                instant_Messenger_Type_ReferenceObjectpropCount++;
            }

            if (instant_Messenger_Type_ReferenceObjectpropCount > 0)
            {
                instant_Messenger_Information_DataObject["instant_Messenger_Type_Reference"] = instant_Messenger_Type_ReferenceObject;
                instant_Messenger_Information_DataObjectpropCount++;
            }

            var usage_DataObject = new JObject();
            var usage_DataObjectpropCount = 0;
            if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic != null)
            {
                usage_DataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic);
                usage_DataObjectpropCount++;
            }

            var type_DataObject = new JObject();
            var type_DataObjectpropCount = 0;
            if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary != null)
            {
                type_DataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary);
                type_DataObjectpropCount++;
            }

            var type_ReferenceObject = new JObject();
            var type_ReferenceObjectpropCount = 0;
            type_ReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
            type_ReferenceObjectpropCount++;
            if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
            {
                type_ReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
                type_ReferenceObjectpropCount++;
            }

            if (type_ReferenceObjectpropCount > 0)
            {
                type_DataObject["type_Reference"] = type_ReferenceObject;
                type_DataObjectpropCount++;
            }

            if (type_DataObjectpropCount > 0)
            {
                usage_DataObject["type_Data"] = type_DataObject;
                usage_DataObjectpropCount++;
            }

            if (usage_DataObjectpropCount > 0)
            {
                instant_Messenger_Information_DataObject["usage_Data"] = usage_DataObject;
                instant_Messenger_Information_DataObjectpropCount++;
            }

            if (instant_Messenger_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Instant_Messenger_Information_DataObject["instant_Messenger_Information_Data"] = instant_Messenger_Information_DataObject;
                add_or_Update_Instant_Messenger_Information_DataObjectpropCount++;
            }

            if (add_or_Update_Instant_Messenger_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Instant_Messenger_Information_for_Person_Event_RequestObject["add_or_Update_Instant_Messenger_Information_Data"] = add_or_Update_Instant_Messenger_Information_DataObject;
                add_or_Update_Instant_Messenger_Information_for_Person_Event_RequestObjectpropCount++;
            }

            if (add_or_Update_Instant_Messenger_Information_for_Person_Event_RequestObjectpropCount > 0)
            {
                addOrUpdateInstantMessengerInformationForPersonEventRequest["add_or_Update_Instant_Messenger_Information_for_Person_Event_Request"] = add_or_Update_Instant_Messenger_Information_for_Person_Event_RequestObject;
                addOrUpdateInstantMessengerInformationForPersonEventRequestpropCount++;
            }

            if (addOrUpdateInstantMessengerInformationForPersonEventRequestpropCount > 0)
            {
                callPayload.Body = addOrUpdateInstantMessengerInformationForPersonEventRequest;
            }

            return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdateWebAddressInformation(Expression<Func<addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceWorkerIDTypeInput>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceWorkerIDType, Expression<Func<string>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceWorkerID, Expression<Func<string>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate, Expression<Func<string>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress = null, Expression<Func<bool>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic = null, Expression<Func<bool>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary = null, Expression<Func<addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput>> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            var apiCallPath = "/Add_or_Update_Web_Address_Information";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addOrUpdateWebAddressInformationForPersonEventRequest = new JObject();
            var addOrUpdateWebAddressInformationForPersonEventRequestpropCount = 0;
            var add_or_Update_Web_Address_Information_for_Person_Event_RequestObject = new JObject();
            var add_or_Update_Web_Address_Information_for_Person_Event_RequestObjectpropCount = 0;
            var add_or_Update_Web_Address_Information_DataObject = new JObject();
            var add_or_Update_Web_Address_Information_DataObjectpropCount = 0;
            var worker_ReferenceObject = new JObject();
            var worker_ReferenceObjectpropCount = 0;
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceWorkerIDType);
            worker_ReferenceObjectpropCount++;
            worker_ReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceWorkerID);
            if (worker_ReferenceObjectpropCount > 0)
            {
                add_or_Update_Web_Address_Information_DataObject["worker_Reference"] = worker_ReferenceObject;
                add_or_Update_Web_Address_Information_DataObjectpropCount++;
            }

            add_or_Update_Web_Address_Information_DataObjectpropCount++;
            add_or_Update_Web_Address_Information_DataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate);
            var web_Address_Information_DataObject = new JObject();
            var web_Address_Information_DataObjectpropCount = 0;
            if (addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress != null)
            {
                web_Address_Information_DataObject["web_Address"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress);
                web_Address_Information_DataObjectpropCount++;
            }

            var usage_DataObject = new JObject();
            var usage_DataObjectpropCount = 0;
            if (addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic != null)
            {
                usage_DataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic);
                usage_DataObjectpropCount++;
            }

            var type_DataObject = new JObject();
            var type_DataObjectpropCount = 0;
            if (addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary != null)
            {
                type_DataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary);
                type_DataObjectpropCount++;
            }

            var type_ReferenceObject = new JObject();
            var type_ReferenceObjectpropCount = 0;
            type_ReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
            type_ReferenceObjectpropCount++;
            if (addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
            {
                type_ReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
                type_ReferenceObjectpropCount++;
            }

            if (type_ReferenceObjectpropCount > 0)
            {
                type_DataObject["type_Reference"] = type_ReferenceObject;
                type_DataObjectpropCount++;
            }

            if (type_DataObjectpropCount > 0)
            {
                usage_DataObject["type_Data"] = type_DataObject;
                usage_DataObjectpropCount++;
            }

            if (usage_DataObjectpropCount > 0)
            {
                web_Address_Information_DataObject["usage_Data"] = usage_DataObject;
                web_Address_Information_DataObjectpropCount++;
            }

            if (web_Address_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Web_Address_Information_DataObject["web_Address_Information_Data"] = web_Address_Information_DataObject;
                add_or_Update_Web_Address_Information_DataObjectpropCount++;
            }

            if (add_or_Update_Web_Address_Information_DataObjectpropCount > 0)
            {
                add_or_Update_Web_Address_Information_for_Person_Event_RequestObject["add_or_Update_Web_Address_Information_Data"] = add_or_Update_Web_Address_Information_DataObject;
                add_or_Update_Web_Address_Information_for_Person_Event_RequestObjectpropCount++;
            }

            if (add_or_Update_Web_Address_Information_for_Person_Event_RequestObjectpropCount > 0)
            {
                addOrUpdateWebAddressInformationForPersonEventRequest["add_or_Update_Web_Address_Information_for_Person_Event_Request"] = add_or_Update_Web_Address_Information_for_Person_Event_RequestObject;
                addOrUpdateWebAddressInformationForPersonEventRequestpropCount++;
            }

            if (addOrUpdateWebAddressInformationForPersonEventRequestpropCount > 0)
            {
                callPayload.Body = addOrUpdateWebAddressInformationForPersonEventRequest;
            }

            return new ApiConnectionAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeePersonalInfoInfo> GetEmployeePersonalInfo(Expression<Func<systemIDTypeInput>> systemIDType, Expression<Func<string>> systemID)
        {
            var apiCallPath = "/Get_Employee_Personal_Info";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(systemIDType);
            callPayload.Queries["SystemID"] = ExpressionConverter.Convert(systemID);
            return new ApiConnectionAction<EmployeePersonalInfoInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeIdentityInfo> GetEmployeeIdentityInfo(Expression<Func<systemIDTypeInput>> systemIDType, Expression<Func<string>> systemID)
        {
            var apiCallPath = "/Get_Employee_Identity_Info";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(systemIDType);
            callPayload.Queries["SystemID"] = ExpressionConverter.Convert(systemID);
            return new ApiConnectionAction<EmployeeIdentityInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeQualificationInfo> GetEmployeeQualificationInfo(Expression<Func<systemIDTypeInput>> systemIDType, Expression<Func<string>> systemID)
        {
            var apiCallPath = "/Get_Employee_Qualification_Info";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(systemIDType);
            callPayload.Queries["SystemID"] = ExpressionConverter.Convert(systemID);
            return new ApiConnectionAction<EmployeeQualificationInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<EmployeeEmploymentInfoInfo> GetEmployeeEmploymentInfo(Expression<Func<systemIDTypeInput>> systemIDType, Expression<Func<string>> systemID)
        {
            var apiCallPath = "/Get_Employee_Employment_Info";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(systemIDType);
            callPayload.Queries["SystemID"] = ExpressionConverter.Convert(systemID);
            return new ApiConnectionAction<EmployeeEmploymentInfoInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        public IBodyWorkflowAction<string> SOAPOperation(Expression<Func<string>> body = null)
        {
            var apiCallPath = "/SOAP_Operation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class WorkdayhcmTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<EmployeeInfo> WhenAnEmployeeIsAddedOrUpdated(Expression<Func<dateCriteriaInput>> dateCriteria, Expression<Func<businessProcessTypeInput>> businessProcessType = null, string triggerName = null)
        {
            var apiCallPath = "/When_an_Employee_is_Added_or_Updated";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["dateCriteria"] = ExpressionConverter.Convert(dateCriteria);
            if (businessProcessType != null)
                callPayload.Queries["businessProcessType"] = ExpressionConverter.Convert(businessProcessType);
            return new ApiConnectionTrigger<EmployeeInfo>(callPayload);
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
        public string PersonIDType { get; set; }
        public string PersonID { get; set; }
    }

    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceWorkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferenceCountryIDInput
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

    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineDataInputItemAddessLineTypeType
    {
        [EnumMember(Value = "ADDRESS LINE 1")]
        ADDRESSLINE1,
        [EnumMember(Value = "ADDRESS LINE 2")]
        ADDRESSLINE2,
        [EnumMember(Value = "ADDRESS LINE 3")]
        ADDRESSLINE3
    }

    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
    {
        Home,
        Business
    }

    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceWorkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

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

    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencePhoneDeviceTypeIDInput
    {
        Mobile,
        Telephone,
        Fax,
        Pager
    }

    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
    {
        Home,
        Business
    }

    public enum addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceWorkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

    public enum addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
    {
        Home,
        Business
    }

    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceWorkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceInstantMessengerTypeIDInput
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

    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
    {
        Home,
        Business
    }

    public enum addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceWorkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

    public enum addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
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
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType CommunicationUsageTypeIDType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDType CommunicationUsageTypeID { get; set; }
    }

    public enum CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeID,
        WID
    }

    public enum CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDType
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
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIDTypeType PhoneDeviceTypeIDType { get; set; }
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIDType PhoneDeviceTypeID { get; set; }
    }

    public enum PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIDTypeType
    {
        [EnumMember(Value = "Phone_Device_Type_ID")]
        PhoneDeviceTypeID,
        WID
    }

    public enum PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIDType
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
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType CommunicationUsageTypeIDType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDType CommunicationUsageTypeID { get; set; }
    }

    public enum PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeID,
        WID
    }

    public enum PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDType
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
        public AddressInformationDataCountryReferenceTypeCountryIDTypeType CountryIDType { get; set; }
        public AddressInformationDataCountryReferenceTypeCountryIDType CountryID { get; set; }
    }

    public enum AddressInformationDataCountryReferenceTypeCountryIDTypeType
    {
        [EnumMember(Value = "ISO 3166-1 Alpha-2 Code")]
        ISO31661Alpha2Code,
        [EnumMember(Value = "ISO 3166-1 Alpha-3 Code")]
        ISO31661Alpha3Code,
        [EnumMember(Value = "ISO 3166-1 Numeric-3 Code")]
        ISO31661Numeric3Code
    }

    public enum AddressInformationDataCountryReferenceTypeCountryIDType
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
        public AddressInformationDataCountryRegionReferenceTypeCountryRegionIDTypeType CountryRegionIDType { get; set; }
        public string CountryRegionID { get; set; }
    }

    public enum AddressInformationDataCountryRegionReferenceTypeCountryRegionIDTypeType
    {
        [EnumMember(Value = "Country Region ID")]
        CountryRegionID,
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
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType CommunicationUsageTypeIDType { get; set; }

        [JsonProperty("communicationUsageTypeID")]
        public AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDType CommunicationUsageTypeID { get; set; }
    }

    public enum AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeID,
        WID
    }

    public enum AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDType
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
        public InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIDTypeType InstantMessengerTypeIDType { get; set; }
        public InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIDType InstantMessengerTypeID { get; set; }
    }

    public enum InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIDTypeType
    {
        [EnumMember(Value = "Instant_Messenger_Type_ID")]
        InstantMessengerTypeID,
        WID
    }

    public enum InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIDType
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
        public string CountryIDType { get; set; }
        public string CountryID { get; set; }
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

    public enum systemIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
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
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIDDataTypeItem[] VisaIDData { get; set; }

        [JsonProperty("custom_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIDDataTypeItem[] CustomIDData { get; set; }

        [JsonProperty("government_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIDDataTypeItem[] GovernmentIDData { get; set; }

        [JsonProperty("license_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIDDataTypeItem[] LicenseIDData { get; set; }

        [JsonProperty("passport_ID_Data")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIDDataTypeItem[] PassportIDData { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIDDataTypeItem
    {
        [JsonProperty("visa_ID")]
        public string VisaID { get; set; }

        [JsonProperty("visa_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIDDataTypeItemVisaTypeReferenceType VisaTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIDDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIDDataTypeItemVisaTypeReferenceType
    {
        [JsonProperty("visa_Type_Name")]
        public string VisaTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeVisaIDDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIDDataTypeItem
    {
        [JsonProperty("custom_ID")]
        public string CustomID { get; set; }

        [JsonProperty("custom_ID_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIDDataTypeItemCustomIDTypeReferenceType CustomIDTypeReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeCustomIDDataTypeItemCustomIDTypeReferenceType
    {
        [JsonProperty("custom_ID_Type_Name")]
        public string CustomIDTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIDDataTypeItem
    {
        [JsonProperty("government_ID")]
        public string GovernmentID { get; set; }

        [JsonProperty("government_ID_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIDDataTypeItemGovernmentIDTypeReferenceType GovernmentIDTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIDDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIDDataTypeItemGovernmentIDTypeReferenceType
    {
        [JsonProperty("government_ID_Type_Name")]
        public string GovernmentIDTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeGovernmentIDDataTypeItemCountryReferenceType
    {
        [JsonProperty("country_ISO_Code")]
        public string CountryISOCode { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIDDataTypeItem
    {
        [JsonProperty("license_ID")]
        public string LicenseID { get; set; }

        [JsonProperty("license_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIDDataTypeItemLicenseTypeReferenceType LicenseTypeReference { get; set; }

        [JsonProperty("license_Class")]
        public string LicenseClass { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypeLicenseIDDataTypeItemLicenseTypeReferenceType
    {
        [JsonProperty("license_Type_Name")]
        public string LicenseTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIDDataTypeItem
    {
        [JsonProperty("passport_Number")]
        public string PassportNumber { get; set; }

        [JsonProperty("passport_Type_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIDDataTypeItemPassportTypeReferenceType PassportTypeReference { get; set; }

        [JsonProperty("country_Reference")]
        public EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIDDataTypeItemCountryReferenceType CountryReference { get; set; }

        [JsonProperty("issued_Date")]
        public string IssuedDate { get; set; }

        [JsonProperty("expiration_Date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("verification_Date")]
        public string VerificationDate { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIDDataTypeItemPassportTypeReferenceType
    {
        [JsonProperty("passport_Type_Name")]
        public string PassportTypeName { get; set; }
    }

    public class EmployeeIdentityInfoEmployeePersonalInfoTypeEmployeePersonalInfoDataTypePersonalInfoDataTypePersonDataTypePassportIDDataTypeItemCountryReferenceType
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
        public string PositionID { get; set; }

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
        public string JobProfileIDType { get; set; }
        public string JobProfileID { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemManagementLevelReferenceType
    {
        public string ManagementLevelIDType { get; set; }
        public string ManagementLevelID { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemJobCategoryReferenceType
    {
        public string JobCategoryIDType { get; set; }
        public string JobCategoryID { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeJobProfileSummaryDataTypeItemDifficultyToFillReferenceType
    {
        public string DifficultyToFillIDType { get; set; }
        public string DifficultyToFillID { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeOrganizationContentDataTypeItem
    {
        [JsonProperty("organization_ID")]
        public string OrganizationID { get; set; }

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
        public string PayGroupID { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypePayrollProcessingDataTypeItemPayrollEntityReferenceTypeItem
    {
        [JsonProperty("payroll_Entity_ID")]
        public string PayrollEntityID { get; set; }
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
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceTypeIntegrationIDReferenceType IntegrationIDReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeEmployeeReferenceTypeIntegrationIDReferenceType
    {
        public string IntegrationID { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceType
    {
        [JsonProperty("integration_ID_Reference")]
        public EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceTypeIntegrationIDReferenceType IntegrationIDReference { get; set; }
    }

    public class EmployeeEmploymentInfoEmployeeEmploymentInfoTypeEmployeeEmploymentInfoDataTypeWorkerPositionDataTypeSupervisorReferenceTypeContingentWorkerReferenceTypeIntegrationIDReferenceType
    {
        public string IntegrationID { get; set; }
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
        public int WorkerID { get; set; }
    }

    public enum dateCriteriaInput
    {
        [EnumMember(Value = "Effective Date")]
        EffectiveDate,
        [EnumMember(Value = "Updated Date")]
        UpdatedDate
    }

    public enum businessProcessTypeInput
    {
        [EnumMember(Value = "Hire Employee")]
        HireEmployee,
        [EnumMember(Value = "Terminate Employee")]
        TerminateEmployee
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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