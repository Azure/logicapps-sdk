//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workdayhcm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkdayhcmActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [WorkflowExpressionFactory(nameof(__BuildAddOrUpdateAddressInformation))]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdateAddressInformation([WorkflowExpression] Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIDTypeInput> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIDType, [WorkflowExpression] Func<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerID, [WorkflowExpression] Func<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate, [WorkflowExpression] Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryIDInput> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryID = null, [WorkflowExpression] Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineDataInputItem[]> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData = null, [WorkflowExpression] Func<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality = null, [WorkflowExpression] Func<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionID = null, [WorkflowExpression] Func<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode = null, [WorkflowExpression] Func<bool> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic = null, [WorkflowExpression] Func<bool> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary = null, [WorkflowExpression] Func<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> __BuildAddOrUpdateAddressInformation(WorkflowExpression<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIDTypeInput> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIDType, WorkflowExpression<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerID, WorkflowExpression<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate, WorkflowExpression<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryIDInput> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryID = null, WorkflowExpression<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineDataInputItem[]> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData = null, WorkflowExpression<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality = null, WorkflowExpression<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionID = null, WorkflowExpression<string> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode = null, WorkflowExpression<bool> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic = null, WorkflowExpression<bool> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary = null, WorkflowExpression<addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIDType, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIDType), required: true);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerID, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerID), required: true);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate), required: true);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryID, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryID), required: false);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData), required: false);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality), required: false);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionID, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionID), required: false);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode), required: false);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic), required: false);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary), required: false);
            WorkflowExpression.Validate(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID, nameof(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(() =>
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
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIDType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerID);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdateAddressInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdateAddressInformationDataObjectpropCount++;
                }

                addOrUpdateAddressInformationDataObjectpropCount++;
                addOrUpdateAddressInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataeffectiveDate);
                var addressInformationDataObject = new JObject();
                var addressInformationDataObjectpropCount = 0;
                var countryReferenceObject = new JObject();
                var countryReferenceObjectpropCount = 0;
                countryReferenceObject["CountryIDType"] = "ISO 3166-1 Alpha-3 Code";
                countryReferenceObjectpropCount++;
                if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryID != null)
                {
                    countryReferenceObject["CountryID"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryID);
                    countryReferenceObjectpropCount++;
                }

                if (countryReferenceObjectpropCount > 0)
                {
                    addressInformationDataObject["country_Reference"] = countryReferenceObject;
                    addressInformationDataObjectpropCount++;
                }

                if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData != null)
                {
                    addressInformationDataObject["address_Line_Data"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDataaddressLineData);
                    addressInformationDataObjectpropCount++;
                }

                if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality != null)
                {
                    addressInformationDataObject["municipality"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatamunicipality);
                    addressInformationDataObjectpropCount++;
                }

                var countryRegionReferenceObject = new JObject();
                var countryRegionReferenceObjectpropCount = 0;
                countryRegionReferenceObject["CountryRegionIDType"] = "ISO 3166-2 Code";
                countryRegionReferenceObjectpropCount++;
                if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionID != null)
                {
                    countryRegionReferenceObject["CountryRegionID"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryRegionReferencecountryRegionID);
                    countryRegionReferenceObjectpropCount++;
                }

                if (countryRegionReferenceObjectpropCount > 0)
                {
                    addressInformationDataObject["country_Region_Reference"] = countryRegionReferenceObject;
                    addressInformationDataObjectpropCount++;
                }

                if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode != null)
                {
                    addressInformationDataObject["postal_Code"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatapostalCode);
                    addressInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
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
        [WorkflowExpressionFactory(nameof(__BuildAddOrUpdatePhoneInformation))]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdatePhoneInformation([WorkflowExpression] Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIDTypeInput> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIDType, [WorkflowExpression] Func<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerID, [WorkflowExpression] Func<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate, [WorkflowExpression] Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCodeInput> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode = null, [WorkflowExpression] Func<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode = null, [WorkflowExpression] Func<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber = null, [WorkflowExpression] Func<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension = null, [WorkflowExpression] Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeIDInput> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeID = null, [WorkflowExpression] Func<bool> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic = null, [WorkflowExpression] Func<bool> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary = null, [WorkflowExpression] Func<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> __BuildAddOrUpdatePhoneInformation(WorkflowExpression<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIDTypeInput> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIDType, WorkflowExpression<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerID, WorkflowExpression<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate, WorkflowExpression<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCodeInput> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode = null, WorkflowExpression<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode = null, WorkflowExpression<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber = null, WorkflowExpression<string> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension = null, WorkflowExpression<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeIDInput> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeID = null, WorkflowExpression<bool> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic = null, WorkflowExpression<bool> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary = null, WorkflowExpression<addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIDType, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIDType), required: true);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerID, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerID), required: true);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate), required: true);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode), required: false);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode), required: false);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber), required: false);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension), required: false);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeID, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeID), required: false);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic), required: false);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary), required: false);
            WorkflowExpression.Validate(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID, nameof(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(() =>
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
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIDType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerID);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdatePhoneInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdatePhoneInformationDataObjectpropCount++;
                }

                addOrUpdatePhoneInformationDataObjectpropCount++;
                addOrUpdatePhoneInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataeffectiveDate);
                var phoneInformationDataObject = new JObject();
                var phoneInformationDataObjectpropCount = 0;
                if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode != null)
                {
                    phoneInformationDataObject["country_ISO_Code"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatacountryISOCode);
                    phoneInformationDataObjectpropCount++;
                }

                if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode != null)
                {
                    phoneInformationDataObject["area_Code"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataareaCode);
                    phoneInformationDataObjectpropCount++;
                }

                if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber != null)
                {
                    phoneInformationDataObject["phone_Number"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneNumber);
                    phoneInformationDataObjectpropCount++;
                }

                if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension != null)
                {
                    phoneInformationDataObject["phone_Extension"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneExtension);
                    phoneInformationDataObjectpropCount++;
                }

                var phoneDeviceTypeReferenceObject = new JObject();
                var phoneDeviceTypeReferenceObjectpropCount = 0;
                phoneDeviceTypeReferenceObject["PhoneDeviceTypeIDType"] = "Phone_Device_Type_ID";
                phoneDeviceTypeReferenceObjectpropCount++;
                if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeID != null)
                {
                    phoneDeviceTypeReferenceObject["PhoneDeviceTypeID"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeID);
                    phoneDeviceTypeReferenceObjectpropCount++;
                }

                if (phoneDeviceTypeReferenceObjectpropCount > 0)
                {
                    phoneInformationDataObject["phone_Device_Type_Reference"] = phoneDeviceTypeReferenceObject;
                    phoneInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
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
        [WorkflowExpressionFactory(nameof(__BuildAddOrUpdateEmailAddressInformation))]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdateEmailAddressInformation([WorkflowExpression] Func<addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIDTypeInput> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIDType, [WorkflowExpression] Func<string> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerID, [WorkflowExpression] Func<string> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate, [WorkflowExpression] Func<string> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress = null, [WorkflowExpression] Func<bool> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic = null, [WorkflowExpression] Func<bool> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary = null, [WorkflowExpression] Func<addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> __BuildAddOrUpdateEmailAddressInformation(WorkflowExpression<addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIDTypeInput> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIDType, WorkflowExpression<string> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerID, WorkflowExpression<string> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate, WorkflowExpression<string> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress = null, WorkflowExpression<bool> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic = null, WorkflowExpression<bool> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary = null, WorkflowExpression<addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            WorkflowExpression.Validate(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIDType, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIDType), required: true);
            WorkflowExpression.Validate(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerID, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerID), required: true);
            WorkflowExpression.Validate(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate), required: true);
            WorkflowExpression.Validate(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress), required: false);
            WorkflowExpression.Validate(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic), required: false);
            WorkflowExpression.Validate(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary), required: false);
            WorkflowExpression.Validate(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID, nameof(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(() =>
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
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIDType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerID);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdateEmailAddressInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdateEmailAddressInformationDataObjectpropCount++;
                }

                addOrUpdateEmailAddressInformationDataObjectpropCount++;
                addOrUpdateEmailAddressInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataeffectiveDate);
                var emailAddressInformationDataObject = new JObject();
                var emailAddressInformationDataObjectpropCount = 0;
                if (addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress != null)
                {
                    emailAddressInformationDataObject["email_Address"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDataemailAddress);
                    emailAddressInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
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
        [WorkflowExpressionFactory(nameof(__BuildAddOrUpdateInstantMessengerInformation))]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdateInstantMessengerInformation([WorkflowExpression] Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIDTypeInput> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIDType, [WorkflowExpression] Func<string> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerID, [WorkflowExpression] Func<string> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate, [WorkflowExpression] Func<string> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress = null, [WorkflowExpression] Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeIDInput> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeID = null, [WorkflowExpression] Func<bool> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic = null, [WorkflowExpression] Func<bool> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary = null, [WorkflowExpression] Func<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> __BuildAddOrUpdateInstantMessengerInformation(WorkflowExpression<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIDTypeInput> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIDType, WorkflowExpression<string> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerID, WorkflowExpression<string> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate, WorkflowExpression<string> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress = null, WorkflowExpression<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeIDInput> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeID = null, WorkflowExpression<bool> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic = null, WorkflowExpression<bool> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary = null, WorkflowExpression<addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            WorkflowExpression.Validate(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIDType, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIDType), required: true);
            WorkflowExpression.Validate(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerID, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerID), required: true);
            WorkflowExpression.Validate(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate), required: true);
            WorkflowExpression.Validate(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress), required: false);
            WorkflowExpression.Validate(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeID, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeID), required: false);
            WorkflowExpression.Validate(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic), required: false);
            WorkflowExpression.Validate(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary), required: false);
            WorkflowExpression.Validate(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID, nameof(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(() =>
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
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIDType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerID);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdateInstantMessengerInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdateInstantMessengerInformationDataObjectpropCount++;
                }

                addOrUpdateInstantMessengerInformationDataObjectpropCount++;
                addOrUpdateInstantMessengerInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataeffectiveDate);
                var instantMessengerInformationDataObject = new JObject();
                var instantMessengerInformationDataObjectpropCount = 0;
                if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress != null)
                {
                    instantMessengerInformationDataObject["instant_Messenger_Address"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerAddress);
                    instantMessengerInformationDataObjectpropCount++;
                }

                var instantMessengerTypeReferenceObject = new JObject();
                var instantMessengerTypeReferenceObjectpropCount = 0;
                instantMessengerTypeReferenceObject["InstantMessengerTypeIDType"] = "Instant_Messenger_Type_ID";
                instantMessengerTypeReferenceObjectpropCount++;
                if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeID != null)
                {
                    instantMessengerTypeReferenceObject["InstantMessengerTypeID"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeID);
                    instantMessengerTypeReferenceObjectpropCount++;
                }

                if (instantMessengerTypeReferenceObjectpropCount > 0)
                {
                    instantMessengerInformationDataObject["instant_Messenger_Type_Reference"] = instantMessengerTypeReferenceObject;
                    instantMessengerInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
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
        [WorkflowExpressionFactory(nameof(__BuildAddOrUpdateWebAddressInformation))]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> AddOrUpdateWebAddressInformation([WorkflowExpression] Func<addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIDTypeInput> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIDType, [WorkflowExpression] Func<string> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerID, [WorkflowExpression] Func<string> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate, [WorkflowExpression] Func<string> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress = null, [WorkflowExpression] Func<bool> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic = null, [WorkflowExpression] Func<bool> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary = null, [WorkflowExpression] Func<addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddOrUpdateContactInformationForPersonEventResponseInfo> __BuildAddOrUpdateWebAddressInformation(WorkflowExpression<addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIDTypeInput> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIDType, WorkflowExpression<string> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerID, WorkflowExpression<string> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate, WorkflowExpression<string> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress = null, WorkflowExpression<bool> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic = null, WorkflowExpression<bool> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary = null, WorkflowExpression<addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput> addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID = null)
        {
            WorkflowExpression.Validate(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIDType, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIDType), required: true);
            WorkflowExpression.Validate(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerID, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerID), required: true);
            WorkflowExpression.Validate(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate), required: true);
            WorkflowExpression.Validate(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress), required: false);
            WorkflowExpression.Validate(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic), required: false);
            WorkflowExpression.Validate(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary), required: false);
            WorkflowExpression.Validate(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID, nameof(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID), required: false);
            return new DeferredBodyAction<AddOrUpdateContactInformationForPersonEventResponseInfo>(() =>
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
                workerReferenceObject["WorkerIDType"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIDType);
                workerReferenceObjectpropCount++;
                workerReferenceObject["WorkerID"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerID);
                if (workerReferenceObjectpropCount > 0)
                {
                    addOrUpdateWebAddressInformationDataObject["worker_Reference"] = workerReferenceObject;
                    addOrUpdateWebAddressInformationDataObjectpropCount++;
                }

                addOrUpdateWebAddressInformationDataObjectpropCount++;
                addOrUpdateWebAddressInformationDataObject["effective_Date"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataeffectiveDate);
                var webAddressInformationDataObject = new JObject();
                var webAddressInformationDataObjectpropCount = 0;
                if (addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress != null)
                {
                    webAddressInformationDataObject["web_Address"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatawebAddress);
                    webAddressInformationDataObjectpropCount++;
                }

                var usageDataObject = new JObject();
                var usageDataObjectpropCount = 0;
                if (addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic != null)
                {
                    usageDataObject["isPublic"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDataisPublic);
                    usageDataObjectpropCount++;
                }

                var typeDataObject = new JObject();
                var typeDataObjectpropCount = 0;
                if (addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary != null)
                {
                    typeDataObject["isPrimary"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDataisPrimary);
                    typeDataObjectpropCount++;
                }

                var typeReferenceObject = new JObject();
                var typeReferenceObjectpropCount = 0;
                typeReferenceObject["communicationUsageTypeIDType"] = "Communication_Usage_Type_ID";
                typeReferenceObjectpropCount++;
                if (addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID != null)
                {
                    typeReferenceObject["communicationUsageTypeID"] = ExpressionConverter.ConvertO(addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDatawebAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeID);
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
        [WorkflowExpressionFactory(nameof(__BuildGetEmployeePersonalInfo))]
        public IBodyWorkflowAction<EmployeePersonalInfoInfo> GetEmployeePersonalInfo([WorkflowExpression] Func<systemIDTypeInput> systemIDType, [WorkflowExpression] Func<string> systemID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmployeePersonalInfoInfo> __BuildGetEmployeePersonalInfo(WorkflowExpression<systemIDTypeInput> systemIDType, WorkflowExpression<string> systemID)
        {
            WorkflowExpression.Validate(systemIDType, nameof(systemIDType), required: true);
            WorkflowExpression.Validate(systemID, nameof(systemID), required: true);
            return new DeferredBodyAction<EmployeePersonalInfoInfo>(() =>
            {
                var apiCallPath = "/Get_Employee_Personal_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(systemIDType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(systemID);
                return new ApiConnectionAction<EmployeePersonalInfoInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmployeeIdentityInfo))]
        public IBodyWorkflowAction<EmployeeIdentityInfo> GetEmployeeIdentityInfo([WorkflowExpression] Func<systemIDTypeInput> systemIDType, [WorkflowExpression] Func<string> systemID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmployeeIdentityInfo> __BuildGetEmployeeIdentityInfo(WorkflowExpression<systemIDTypeInput> systemIDType, WorkflowExpression<string> systemID)
        {
            WorkflowExpression.Validate(systemIDType, nameof(systemIDType), required: true);
            WorkflowExpression.Validate(systemID, nameof(systemID), required: true);
            return new DeferredBodyAction<EmployeeIdentityInfo>(() =>
            {
                var apiCallPath = "/Get_Employee_Identity_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(systemIDType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(systemID);
                return new ApiConnectionAction<EmployeeIdentityInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmployeeQualificationInfo))]
        public IBodyWorkflowAction<EmployeeQualificationInfo> GetEmployeeQualificationInfo([WorkflowExpression] Func<systemIDTypeInput> systemIDType, [WorkflowExpression] Func<string> systemID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmployeeQualificationInfo> __BuildGetEmployeeQualificationInfo(WorkflowExpression<systemIDTypeInput> systemIDType, WorkflowExpression<string> systemID)
        {
            WorkflowExpression.Validate(systemIDType, nameof(systemIDType), required: true);
            WorkflowExpression.Validate(systemID, nameof(systemID), required: true);
            return new DeferredBodyAction<EmployeeQualificationInfo>(() =>
            {
                var apiCallPath = "/Get_Employee_Qualification_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(systemIDType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(systemID);
                return new ApiConnectionAction<EmployeeQualificationInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmployeeEmploymentInfo))]
        public IBodyWorkflowAction<EmployeeEmploymentInfoInfo> GetEmployeeEmploymentInfo([WorkflowExpression] Func<systemIDTypeInput> systemIDType, [WorkflowExpression] Func<string> systemID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EmployeeEmploymentInfoInfo> __BuildGetEmployeeEmploymentInfo(WorkflowExpression<systemIDTypeInput> systemIDType, WorkflowExpression<string> systemID)
        {
            WorkflowExpression.Validate(systemIDType, nameof(systemIDType), required: true);
            WorkflowExpression.Validate(systemID, nameof(systemID), required: true);
            return new DeferredBodyAction<EmployeeEmploymentInfoInfo>(() =>
            {
                var apiCallPath = "/Get_Employee_Employment_Info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SystemIDType"] = ExpressionConverter.Convert(systemIDType);
                callPayload.Queries["SystemID"] = ExpressionConverter.Convert(systemID);
                return new ApiConnectionAction<EmployeeEmploymentInfoInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [WorkflowExpressionFactory(nameof(__BuildSOAPOperation))]
        public IBodyWorkflowAction<string> SOAPOperation([WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workdayhcm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSOAPOperation(WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/SOAP_Operation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class WorkdayhcmTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWhenAnEmployeeIsAddedOrUpdated))]
        public IBodyWorkflowTrigger<EmployeeInfo> WhenAnEmployeeIsAddedOrUpdated([WorkflowExpression] Func<dateCriteriaInput> dateCriteria,[WorkflowExpression] Func<businessProcessTypeInput> businessProcessType = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EmployeeInfo> __BuildWhenAnEmployeeIsAddedOrUpdated(WorkflowExpression<dateCriteriaInput> dateCriteria,WorkflowExpression<businessProcessTypeInput> businessProcessType = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(dateCriteria, nameof(dateCriteria), required: true);
            WorkflowExpression.Validate(businessProcessType, nameof(businessProcessType), required: false);
            return new DeferredBodyTrigger<EmployeeInfo>(() =>
            {
                var apiCallPath = "/When_an_Employee_is_Added_or_Updated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["dateCriteria"] = ExpressionConverter.Convert(dateCriteria);
                if (businessProcessType != null)
                    callPayload.Queries["businessProcessType"] = ExpressionConverter.Convert(businessProcessType);
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
        public string PersonIDType { get; set; }
        public string PersonID { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataworkerReferenceworkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatacountryReferencecountryIDInput
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
    public enum addOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationForPersonEventRequestaddOrUpdateAddressInformationDataaddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
    {
        Home,
        Business
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataworkerReferenceworkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
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
    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDataphoneDeviceTypeReferencephoneDeviceTypeIDInput
    {
        Mobile,
        Telephone,
        Fax,
        Pager
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationForPersonEventRequestaddOrUpdatePhoneInformationDataphoneInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
    {
        Home,
        Business
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataworkerReferenceworkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationForPersonEventRequestaddOrUpdateEmailAddressInformationDataemailAddressInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
    {
        Home,
        Business
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDataworkerReferenceworkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatainstantMessengerTypeReferenceinstantMessengerTypeIDInput
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
    public enum addOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationForPersonEventRequestaddOrUpdateInstantMessengerInformationDatainstantMessengerInformationDatausageDatatypeDatatypeReferencecommunicationUsageTypeIDInput
    {
        Home,
        Business
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum addOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationForPersonEventRequestaddOrUpdateWebAddressInformationDataworkerReferenceworkerIDTypeInput
    {
        [EnumMember(Value = "Employee ID")]
        EmployeeID,
        [EnumMember(Value = "Contingent Worker ID")]
        ContingentWorkerID,
        [EnumMember(Value = "Workday ID")]
        WorkdayID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommunicationMethodUsageInformationDataTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeID,
        WID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIDTypeType PhoneDeviceTypeIDType { get; set; }
        public PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIDType PhoneDeviceTypeID { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataPhoneDeviceTypeReferenceTypePhoneDeviceTypeIDTypeType
    {
        [EnumMember(Value = "Phone_Device_Type_ID")]
        PhoneDeviceTypeID,
        WID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeID,
        WID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataCountryReferenceTypeCountryIDTypeType
    {
        [EnumMember(Value = "ISO 3166-1 Alpha-2 Code")]
        ISO31661Alpha2Code,
        [EnumMember(Value = "ISO 3166-1 Alpha-3 Code")]
        ISO31661Alpha3Code,
        [EnumMember(Value = "ISO 3166-1 Numeric-3 Code")]
        ISO31661Numeric3Code
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public AddressInformationDataCountryRegionReferenceTypeCountryRegionIDTypeType CountryRegionIDType { get; set; }
        public string CountryRegionID { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddressInformationDataUsageDataTypeTypeDataTypeTypeReferenceTypeCommunicationUsageTypeIDTypeType
    {
        [EnumMember(Value = "Communication_Usage_Type_ID")]
        CommunicationUsageTypeID,
        WID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InstantMessengerInformationDataInstantMessengerTypeReferenceTypeInstantMessengerTypeIDTypeType
    {
        [EnumMember(Value = "Instant_Messenger_Type_ID")]
        InstantMessengerTypeID,
        WID
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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