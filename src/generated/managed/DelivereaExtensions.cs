//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deliverea
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DelivereaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction Shipments([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyfromname = null, [WorkflowExpression] Func<string> bodyfromaddress = null, [WorkflowExpression] Func<string> bodyfromcity = null, [WorkflowExpression] Func<string> bodyfromzipCode = null, [WorkflowExpression] Func<string> bodyfromcountryCode = null, [WorkflowExpression] Func<string> bodyfromidNumber = null, [WorkflowExpression] Func<string> bodyfromstateCode = null, [WorkflowExpression] Func<string> bodyfromphone = null, [WorkflowExpression] Func<string> bodyfromemail = null, [WorkflowExpression] Func<string> bodyfromdistributionCenterId = null, [WorkflowExpression] Func<string> bodytoname = null, [WorkflowExpression] Func<string> bodytoaddress = null, [WorkflowExpression] Func<string> bodytocity = null, [WorkflowExpression] Func<string> bodytozipCode = null, [WorkflowExpression] Func<string> bodytocountryCode = null, [WorkflowExpression] Func<string> bodytoidNumber = null, [WorkflowExpression] Func<string> bodytostateCode = null, [WorkflowExpression] Func<string> bodytoobservations = null, [WorkflowExpression] Func<string> bodytophone = null, [WorkflowExpression] Func<string> bodytoemail = null, [WorkflowExpression] Func<string> bodytodistributionCenterId = null, [WorkflowExpression] Func<string> bodycostCenterCode = null, [WorkflowExpression] Func<string> bodyclientAdditionalInfocategory = null, [WorkflowExpression] Func<string> bodyserviceAttributescashOnDelivery = null, [WorkflowExpression] Func<string> bodyserviceCode = null, [WorkflowExpression] Func<string> bodydistributionCenterId = null, [WorkflowExpression] Func<string> bodycarrierCode = null, [WorkflowExpression] Func<string> bodyclientReference = null, [WorkflowExpression] Func<string> bodyshippingDate = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytotalAmount = null, [WorkflowExpression] Func<string> bodycustomsinvoiceId = null, [WorkflowExpression] Func<string> bodybatchreference = null, [WorkflowExpression] Func<string> bodyestimatedDate = null, [WorkflowExpression] Func<bodyparcelsInputItem[]> bodyparcels = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            SourceExpression.Validate(bodyfromname, nameof(bodyfromname), required: false);
            SourceExpression.Validate(bodyfromaddress, nameof(bodyfromaddress), required: false);
            SourceExpression.Validate(bodyfromcity, nameof(bodyfromcity), required: false);
            SourceExpression.Validate(bodyfromzipCode, nameof(bodyfromzipCode), required: false);
            SourceExpression.Validate(bodyfromcountryCode, nameof(bodyfromcountryCode), required: false);
            SourceExpression.Validate(bodyfromidNumber, nameof(bodyfromidNumber), required: false);
            SourceExpression.Validate(bodyfromstateCode, nameof(bodyfromstateCode), required: false);
            SourceExpression.Validate(bodyfromphone, nameof(bodyfromphone), required: false);
            SourceExpression.Validate(bodyfromemail, nameof(bodyfromemail), required: false);
            SourceExpression.Validate(bodyfromdistributionCenterId, nameof(bodyfromdistributionCenterId), required: false);
            SourceExpression.Validate(bodytoname, nameof(bodytoname), required: false);
            SourceExpression.Validate(bodytoaddress, nameof(bodytoaddress), required: false);
            SourceExpression.Validate(bodytocity, nameof(bodytocity), required: false);
            SourceExpression.Validate(bodytozipCode, nameof(bodytozipCode), required: false);
            SourceExpression.Validate(bodytocountryCode, nameof(bodytocountryCode), required: false);
            SourceExpression.Validate(bodytoidNumber, nameof(bodytoidNumber), required: false);
            SourceExpression.Validate(bodytostateCode, nameof(bodytostateCode), required: false);
            SourceExpression.Validate(bodytoobservations, nameof(bodytoobservations), required: false);
            SourceExpression.Validate(bodytophone, nameof(bodytophone), required: false);
            SourceExpression.Validate(bodytoemail, nameof(bodytoemail), required: false);
            SourceExpression.Validate(bodytodistributionCenterId, nameof(bodytodistributionCenterId), required: false);
            SourceExpression.Validate(bodycostCenterCode, nameof(bodycostCenterCode), required: false);
            SourceExpression.Validate(bodyclientAdditionalInfocategory, nameof(bodyclientAdditionalInfocategory), required: false);
            SourceExpression.Validate(bodyserviceAttributescashOnDelivery, nameof(bodyserviceAttributescashOnDelivery), required: false);
            SourceExpression.Validate(bodyserviceCode, nameof(bodyserviceCode), required: false);
            SourceExpression.Validate(bodydistributionCenterId, nameof(bodydistributionCenterId), required: false);
            SourceExpression.Validate(bodycarrierCode, nameof(bodycarrierCode), required: false);
            SourceExpression.Validate(bodyclientReference, nameof(bodyclientReference), required: false);
            SourceExpression.Validate(bodyshippingDate, nameof(bodyshippingDate), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodytotalAmount, nameof(bodytotalAmount), required: false);
            SourceExpression.Validate(bodycustomsinvoiceId, nameof(bodycustomsinvoiceId), required: false);
            SourceExpression.Validate(bodybatchreference, nameof(bodybatchreference), required: false);
            SourceExpression.Validate(bodyestimatedDate, nameof(bodyestimatedDate), required: false);
            SourceExpression.Validate(bodyparcels, nameof(bodyparcels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/shipments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                var fromObject = new JObject();
                var fromObjectpropCount = 0;
                if (bodyfromname != null)
                {
                    fromObject["name"] = SourceExpressionConverter.ConvertToken(bodyfromname);
                    fromObjectpropCount++;
                }

                if (bodyfromaddress != null)
                {
                    fromObject["address"] = SourceExpressionConverter.ConvertToken(bodyfromaddress);
                    fromObjectpropCount++;
                }

                if (bodyfromcity != null)
                {
                    fromObject["city"] = SourceExpressionConverter.ConvertToken(bodyfromcity);
                    fromObjectpropCount++;
                }

                if (bodyfromzipCode != null)
                {
                    fromObject["zipCode"] = SourceExpressionConverter.ConvertToken(bodyfromzipCode);
                    fromObjectpropCount++;
                }

                if (bodyfromcountryCode != null)
                {
                    fromObject["countryCode"] = SourceExpressionConverter.ConvertToken(bodyfromcountryCode);
                    fromObjectpropCount++;
                }

                if (bodyfromidNumber != null)
                {
                    fromObject["idNumber"] = SourceExpressionConverter.ConvertToken(bodyfromidNumber);
                    fromObjectpropCount++;
                }

                if (bodyfromstateCode != null)
                {
                    fromObject["stateCode"] = SourceExpressionConverter.ConvertToken(bodyfromstateCode);
                    fromObjectpropCount++;
                }

                if (bodyfromphone != null)
                {
                    fromObject["phone"] = SourceExpressionConverter.ConvertToken(bodyfromphone);
                    fromObjectpropCount++;
                }

                if (bodyfromemail != null)
                {
                    fromObject["email"] = SourceExpressionConverter.ConvertToken(bodyfromemail);
                    fromObjectpropCount++;
                }

                if (bodyfromdistributionCenterId != null)
                {
                    fromObject["distributionCenterId"] = SourceExpressionConverter.ConvertToken(bodyfromdistributionCenterId);
                    fromObjectpropCount++;
                }

                if (fromObjectpropCount > 0)
                {
                    body["from"] = fromObject;
                    bodypropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (bodytoname != null)
                {
                    toObject["name"] = SourceExpressionConverter.ConvertToken(bodytoname);
                    toObjectpropCount++;
                }

                if (bodytoaddress != null)
                {
                    toObject["address"] = SourceExpressionConverter.ConvertToken(bodytoaddress);
                    toObjectpropCount++;
                }

                if (bodytocity != null)
                {
                    toObject["city"] = SourceExpressionConverter.ConvertToken(bodytocity);
                    toObjectpropCount++;
                }

                if (bodytozipCode != null)
                {
                    toObject["zipCode"] = SourceExpressionConverter.ConvertToken(bodytozipCode);
                    toObjectpropCount++;
                }

                if (bodytocountryCode != null)
                {
                    toObject["countryCode"] = SourceExpressionConverter.ConvertToken(bodytocountryCode);
                    toObjectpropCount++;
                }

                if (bodytoidNumber != null)
                {
                    toObject["idNumber"] = SourceExpressionConverter.ConvertToken(bodytoidNumber);
                    toObjectpropCount++;
                }

                if (bodytostateCode != null)
                {
                    toObject["stateCode"] = SourceExpressionConverter.ConvertToken(bodytostateCode);
                    toObjectpropCount++;
                }

                if (bodytoobservations != null)
                {
                    toObject["observations"] = SourceExpressionConverter.ConvertToken(bodytoobservations);
                    toObjectpropCount++;
                }

                if (bodytophone != null)
                {
                    toObject["phone"] = SourceExpressionConverter.ConvertToken(bodytophone);
                    toObjectpropCount++;
                }

                if (bodytoemail != null)
                {
                    toObject["email"] = SourceExpressionConverter.ConvertToken(bodytoemail);
                    toObjectpropCount++;
                }

                if (bodytodistributionCenterId != null)
                {
                    toObject["distributionCenterId"] = SourceExpressionConverter.ConvertToken(bodytodistributionCenterId);
                    toObjectpropCount++;
                }

                if (toObjectpropCount > 0)
                {
                    body["to"] = toObject;
                    bodypropCount++;
                }

                if (bodycostCenterCode != null)
                {
                    body["costCenterCode"] = SourceExpressionConverter.ConvertToken(bodycostCenterCode);
                    bodypropCount++;
                }

                var clientAdditionalInfoObject = new JObject();
                var clientAdditionalInfoObjectpropCount = 0;
                if (bodyclientAdditionalInfocategory != null)
                {
                    clientAdditionalInfoObject["category"] = SourceExpressionConverter.ConvertToken(bodyclientAdditionalInfocategory);
                    clientAdditionalInfoObjectpropCount++;
                }

                if (clientAdditionalInfoObjectpropCount > 0)
                {
                    body["clientAdditionalInfo"] = clientAdditionalInfoObject;
                    bodypropCount++;
                }

                var serviceAttributesObject = new JObject();
                var serviceAttributesObjectpropCount = 0;
                if (bodyserviceAttributescashOnDelivery != null)
                {
                    serviceAttributesObject["cashOnDelivery"] = SourceExpressionConverter.ConvertToken(bodyserviceAttributescashOnDelivery);
                    serviceAttributesObjectpropCount++;
                }

                if (serviceAttributesObjectpropCount > 0)
                {
                    body["serviceAttributes"] = serviceAttributesObject;
                    bodypropCount++;
                }

                if (bodyserviceCode != null)
                {
                    body["serviceCode"] = SourceExpressionConverter.ConvertToken(bodyserviceCode);
                    bodypropCount++;
                }

                if (bodydistributionCenterId != null)
                {
                    body["distributionCenterId"] = SourceExpressionConverter.ConvertToken(bodydistributionCenterId);
                    bodypropCount++;
                }

                if (bodycarrierCode != null)
                {
                    body["carrierCode"] = SourceExpressionConverter.ConvertToken(bodycarrierCode);
                    bodypropCount++;
                }

                if (bodyclientReference != null)
                {
                    body["clientReference"] = SourceExpressionConverter.ConvertToken(bodyclientReference);
                    bodypropCount++;
                }

                if (bodyshippingDate != null)
                {
                    body["shippingDate"] = SourceExpressionConverter.ConvertToken(bodyshippingDate);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodytotalAmount != null)
                {
                    body["totalAmount"] = SourceExpressionConverter.ConvertToken(bodytotalAmount);
                    bodypropCount++;
                }

                var customsObject = new JObject();
                var customsObjectpropCount = 0;
                if (bodycustomsinvoiceId != null)
                {
                    customsObject["invoiceId"] = SourceExpressionConverter.ConvertToken(bodycustomsinvoiceId);
                    customsObjectpropCount++;
                }

                if (customsObjectpropCount > 0)
                {
                    body["customs"] = customsObject;
                    bodypropCount++;
                }

                var batchObject = new JObject();
                var batchObjectpropCount = 0;
                if (bodybatchreference != null)
                {
                    batchObject["reference"] = SourceExpressionConverter.ConvertToken(bodybatchreference);
                    batchObjectpropCount++;
                }

                if (batchObjectpropCount > 0)
                {
                    body["batch"] = batchObject;
                    bodypropCount++;
                }

                if (bodyestimatedDate != null)
                {
                    body["estimatedDate"] = SourceExpressionConverter.ConvertToken(bodyestimatedDate);
                    bodypropCount++;
                }

                if (bodyparcels != null)
                {
                    body["parcels"] = SourceExpressionConverter.ConvertToken(bodyparcels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction Label([WorkflowExpression] Func<string> delivereaReference, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            SourceExpression.Validate(delivereaReference, nameof(delivereaReference), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/shipments/{0}/label", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(delivereaReference, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<DistributionCentersResponse> DistributionCenters([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/distribution-centers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<DistributionCentersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IBodyWorkflowAction<CarriersInDistributionCenterResponse> CarriersInDistributionCenter([WorkflowExpression] Func<string> distributionCenter, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            SourceExpression.Validate(distributionCenter, nameof(distributionCenter), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/distribution-centers/{0}/carriers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(distributionCenter, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<CarriersInDistributionCenterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deliverea")]
        public IWorkflowAction CancelShipment([WorkflowExpression] Func<string> delivereaReference, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept)
        {
            SourceExpression.Validate(delivereaReference, nameof(delivereaReference), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/shipments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(delivereaReference, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class DelivereaTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodyparcelsInputItem
    {
        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }
    }

    public class DistributionCentersResponse
    {
        [JsonProperty("data")]
        public DistributionCentersResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }

    public class DistributionCentersResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("worksAsDropPoint")]
        public bool WorksAsDropPoint { get; set; }
    }

    public class CarriersInDistributionCenterResponse
    {
        [JsonProperty("data")]
        public CarriersInDistributionCenterResponseDataTypeItem[] Data { get; set; }
    }

    public class CarriersInDistributionCenterResponseDataTypeItem
    {
        [JsonProperty("distributionCenterId")]
        public string DistributionCenterId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("costCenters")]
        public CarriersInDistributionCenterResponseDataTypeItemCostCentersTypeItem[] CostCenters { get; set; }
    }

    public class CarriersInDistributionCenterResponseDataTypeItemCostCentersTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("services")]
        public CarriersInDistributionCenterResponseDataTypeItemCostCentersTypeItemServicesTypeItem[] Services { get; set; }
    }

    public class CarriersInDistributionCenterResponseDataTypeItemCostCentersTypeItemServicesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Deliverea;

    public partial class WorkflowManagedActions
    {
        public DelivereaActions Deliverea(string connectionId) => new DelivereaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DelivereaTriggers Deliverea(string connectionId) => new DelivereaTriggers(connectionId);
    }
}