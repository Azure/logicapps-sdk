//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cpscrecallsretrievalip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CpscrecallsretrievalipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cpscrecallsretrievalip")]
        public IBodyWorkflowAction<RecallGetResponseItem[], ApiConnectionActionConfiguration> RecallGet(Expression<Func<string>> recallId = null, Expression<Func<string>> recallNumber = null, Expression<Func<string>> recallDateStart = null, Expression<Func<string>> recallDateEnd = null, Expression<Func<string>> lastPublishDateStart = null, Expression<Func<string>> lastPublishDateEnd = null, Expression<Func<string>> recallUrl = null, Expression<Func<string>> recallTitle = null, Expression<Func<string>> consumerContact = null, Expression<Func<string>> recallDescription = null, Expression<Func<string>> productName = null, Expression<Func<string>> productDescription = null, Expression<Func<string>> productModel = null, Expression<Func<string>> productType = null, Expression<Func<string>> inconjunctionUrl = null, Expression<Func<string>> imageUrl = null, Expression<Func<string>> injury = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> retailer = null, Expression<Func<string>> importer = null, Expression<Func<string>> distributor = null, Expression<Func<string>> manufacturerCountry = null, Expression<Func<string>> upc = null, Expression<Func<string>> hazard = null, Expression<Func<string>> remedy = null, Expression<Func<string>> remedyOption = null)
        {
            var __workflow_recallId = WorkflowExpression.Compile(recallId, nameof(recallId), required: false);
            var __workflow_recallNumber = WorkflowExpression.Compile(recallNumber, nameof(recallNumber), required: false);
            var __workflow_recallDateStart = WorkflowExpression.Compile(recallDateStart, nameof(recallDateStart), required: false);
            var __workflow_recallDateEnd = WorkflowExpression.Compile(recallDateEnd, nameof(recallDateEnd), required: false);
            var __workflow_lastPublishDateStart = WorkflowExpression.Compile(lastPublishDateStart, nameof(lastPublishDateStart), required: false);
            var __workflow_lastPublishDateEnd = WorkflowExpression.Compile(lastPublishDateEnd, nameof(lastPublishDateEnd), required: false);
            var __workflow_recallUrl = WorkflowExpression.Compile(recallUrl, nameof(recallUrl), required: false);
            var __workflow_recallTitle = WorkflowExpression.Compile(recallTitle, nameof(recallTitle), required: false);
            var __workflow_consumerContact = WorkflowExpression.Compile(consumerContact, nameof(consumerContact), required: false);
            var __workflow_recallDescription = WorkflowExpression.Compile(recallDescription, nameof(recallDescription), required: false);
            var __workflow_productName = WorkflowExpression.Compile(productName, nameof(productName), required: false);
            var __workflow_productDescription = WorkflowExpression.Compile(productDescription, nameof(productDescription), required: false);
            var __workflow_productModel = WorkflowExpression.Compile(productModel, nameof(productModel), required: false);
            var __workflow_productType = WorkflowExpression.Compile(productType, nameof(productType), required: false);
            var __workflow_inconjunctionUrl = WorkflowExpression.Compile(inconjunctionUrl, nameof(inconjunctionUrl), required: false);
            var __workflow_imageUrl = WorkflowExpression.Compile(imageUrl, nameof(imageUrl), required: false);
            var __workflow_injury = WorkflowExpression.Compile(injury, nameof(injury), required: false);
            var __workflow_manufacturer = WorkflowExpression.Compile(manufacturer, nameof(manufacturer), required: false);
            var __workflow_retailer = WorkflowExpression.Compile(retailer, nameof(retailer), required: false);
            var __workflow_importer = WorkflowExpression.Compile(importer, nameof(importer), required: false);
            var __workflow_distributor = WorkflowExpression.Compile(distributor, nameof(distributor), required: false);
            var __workflow_manufacturerCountry = WorkflowExpression.Compile(manufacturerCountry, nameof(manufacturerCountry), required: false);
            var __workflow_upc = WorkflowExpression.Compile(upc, nameof(upc), required: false);
            var __workflow_hazard = WorkflowExpression.Compile(hazard, nameof(hazard), required: false);
            var __workflow_remedy = WorkflowExpression.Compile(remedy, nameof(remedy), required: false);
            var __workflow_remedyOption = WorkflowExpression.Compile(remedyOption, nameof(remedyOption), required: false);
            return new DeferredBodyAction<RecallGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Recall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recallId != null)
                    callPayload.Queries["RecallID"] = ExpressionConverter.Convert(__workflow_recallId);
                if (__workflow_recallNumber != null)
                    callPayload.Queries["RecallNumber"] = ExpressionConverter.Convert(__workflow_recallNumber);
                if (__workflow_recallDateStart != null)
                    callPayload.Queries["RecallDateStart"] = ExpressionConverter.Convert(__workflow_recallDateStart);
                if (__workflow_recallDateEnd != null)
                    callPayload.Queries["RecallDateEnd"] = ExpressionConverter.Convert(__workflow_recallDateEnd);
                if (__workflow_lastPublishDateStart != null)
                    callPayload.Queries["LastPublishDateStart"] = ExpressionConverter.Convert(__workflow_lastPublishDateStart);
                if (__workflow_lastPublishDateEnd != null)
                    callPayload.Queries["LastPublishDateEnd"] = ExpressionConverter.Convert(__workflow_lastPublishDateEnd);
                if (__workflow_recallUrl != null)
                    callPayload.Queries["RecallURL"] = ExpressionConverter.Convert(__workflow_recallUrl);
                if (__workflow_recallTitle != null)
                    callPayload.Queries["RecallTitle"] = ExpressionConverter.Convert(__workflow_recallTitle);
                if (__workflow_consumerContact != null)
                    callPayload.Queries["ConsumerContact"] = ExpressionConverter.Convert(__workflow_consumerContact);
                if (__workflow_recallDescription != null)
                    callPayload.Queries["RecallDescription"] = ExpressionConverter.Convert(__workflow_recallDescription);
                if (__workflow_productName != null)
                    callPayload.Queries["ProductName"] = ExpressionConverter.Convert(__workflow_productName);
                if (__workflow_productDescription != null)
                    callPayload.Queries["ProductDescription"] = ExpressionConverter.Convert(__workflow_productDescription);
                if (__workflow_productModel != null)
                    callPayload.Queries["ProductModel"] = ExpressionConverter.Convert(__workflow_productModel);
                if (__workflow_productType != null)
                    callPayload.Queries["ProductType"] = ExpressionConverter.Convert(__workflow_productType);
                if (__workflow_inconjunctionUrl != null)
                    callPayload.Queries["InconjunctionURL"] = ExpressionConverter.Convert(__workflow_inconjunctionUrl);
                if (__workflow_imageUrl != null)
                    callPayload.Queries["ImageURL"] = ExpressionConverter.Convert(__workflow_imageUrl);
                if (__workflow_injury != null)
                    callPayload.Queries["Injury"] = ExpressionConverter.Convert(__workflow_injury);
                if (__workflow_manufacturer != null)
                    callPayload.Queries["Manufacturer"] = ExpressionConverter.Convert(__workflow_manufacturer);
                if (__workflow_retailer != null)
                    callPayload.Queries["Retailer"] = ExpressionConverter.Convert(__workflow_retailer);
                if (__workflow_importer != null)
                    callPayload.Queries["Importer"] = ExpressionConverter.Convert(__workflow_importer);
                if (__workflow_distributor != null)
                    callPayload.Queries["Distributor"] = ExpressionConverter.Convert(__workflow_distributor);
                if (__workflow_manufacturerCountry != null)
                    callPayload.Queries["ManufacturerCountry"] = ExpressionConverter.Convert(__workflow_manufacturerCountry);
                if (__workflow_upc != null)
                    callPayload.Queries["UPC"] = ExpressionConverter.Convert(__workflow_upc);
                if (__workflow_hazard != null)
                    callPayload.Queries["Hazard"] = ExpressionConverter.Convert(__workflow_hazard);
                if (__workflow_remedy != null)
                    callPayload.Queries["Remedy"] = ExpressionConverter.Convert(__workflow_remedy);
                if (__workflow_remedyOption != null)
                    callPayload.Queries["RemedyOption"] = ExpressionConverter.Convert(__workflow_remedyOption);
                return new ApiConnectionAction<RecallGetResponseItem[]>(callPayload);
            });
        }
    }

    public class CpscrecallsretrievalipTriggers([ConnectionName] string connectionId)
    {
    }

    public class RecallGetResponseItem
    {
        [JsonProperty("RecallID")]
        public int RecallId { get; set; }
        public string RecallNumber { get; set; }
        public string RecallDate { get; set; }
        public string Description { get; set; }

        [JsonProperty("URL")]
        public string Url { get; set; }
        public string Title { get; set; }
        public string ConsumerContact { get; set; }
        public string LastPublishDate { get; set; }
        public RecallGetResponseItemProductsTypeItem[] Products { get; set; }
        public RecallGetResponseItemInconjunctionsTypeItem[] Inconjunctions { get; set; }
        public RecallGetResponseItemImagesTypeItem[] Images { get; set; }
        public RecallGetResponseItemInjuriesTypeItem[] Injuries { get; set; }
        public RecallGetResponseItemManufacturersTypeItem[] Manufacturers { get; set; }
        public RecallGetResponseItemRetailersTypeItem[] Retailers { get; set; }
        public RecallGetResponseItemImportersTypeItem[] Importers { get; set; }
        public RecallGetResponseItemDistributorsTypeItem[] Distributors { get; set; }
        public string SoldAtLabel { get; set; }
        public RecallGetResponseItemManufacturerCountriesTypeItem[] ManufacturerCountries { get; set; }

        [JsonProperty("ProductUPCs")]
        public RecallGetResponseItemProductUpcsTypeItem[] ProductUpcs { get; set; }
        public RecallGetResponseItemHazardsTypeItem[] Hazards { get; set; }
        public RecallGetResponseItemRemediesTypeItem[] Remedies { get; set; }
        public RecallGetResponseItemRemedyOptionsTypeItem[] RemedyOptions { get; set; }
    }

    public class RecallGetResponseItemProductsTypeItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        [JsonProperty("CategoryID")]
        public string CategoryId { get; set; }
        public string NumberOfUnits { get; set; }
    }

    public class RecallGetResponseItemInconjunctionsTypeItem
    {
        public string Name { get; set; }
    }

    public class RecallGetResponseItemImagesTypeItem
    {
        [JsonProperty("URL")]
        public string Url { get; set; }
    }

    public class RecallGetResponseItemInjuriesTypeItem
    {
        public string Name { get; set; }
    }

    public class RecallGetResponseItemManufacturersTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("CompanyID")]
        public string CompanyId { get; set; }
    }

    public class RecallGetResponseItemRetailersTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("CompanyID")]
        public string CompanyId { get; set; }
    }

    public class RecallGetResponseItemImportersTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("CompanyID")]
        public string CompanyId { get; set; }
    }

    public class RecallGetResponseItemDistributorsTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("CompanyID")]
        public string CompanyId { get; set; }
    }

    public class RecallGetResponseItemManufacturerCountriesTypeItem
    {
        public string Country { get; set; }
    }

    public class RecallGetResponseItemProductUpcsTypeItem
    {
        [JsonProperty("UPC")]
        public string Upc { get; set; }
    }

    public class RecallGetResponseItemHazardsTypeItem
    {
        public string Name { get; set; }
        public string HazardType { get; set; }

        [JsonProperty("HazardTypeID")]
        public string HazardTypeId { get; set; }
    }

    public class RecallGetResponseItemRemediesTypeItem
    {
        public string Name { get; set; }
    }

    public class RecallGetResponseItemRemedyOptionsTypeItem
    {
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cpscrecallsretrievalip;

    public partial class WorkflowManagedActions
    {
        public CpscrecallsretrievalipActions Cpscrecallsretrievalip(string connectionId) => new CpscrecallsretrievalipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CpscrecallsretrievalipTriggers Cpscrecallsretrievalip(string connectionId) => new CpscrecallsretrievalipTriggers(connectionId);
    }
}