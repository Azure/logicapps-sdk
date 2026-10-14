//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cpscrecallsretrievalip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CpscrecallsretrievalipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cpscrecallsretrievalip")]
        public IBodyWorkflowAction<RecallGetResponseItem[]> RecallGet(Expression<Func<string>> recallID = null, Expression<Func<string>> recallNumber = null, Expression<Func<string>> recallDateStart = null, Expression<Func<string>> recallDateEnd = null, Expression<Func<string>> lastPublishDateStart = null, Expression<Func<string>> lastPublishDateEnd = null, Expression<Func<string>> recallURL = null, Expression<Func<string>> recallTitle = null, Expression<Func<string>> consumerContact = null, Expression<Func<string>> recallDescription = null, Expression<Func<string>> productName = null, Expression<Func<string>> productDescription = null, Expression<Func<string>> productModel = null, Expression<Func<string>> productType = null, Expression<Func<string>> inconjunctionURL = null, Expression<Func<string>> imageURL = null, Expression<Func<string>> injury = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> retailer = null, Expression<Func<string>> importer = null, Expression<Func<string>> distributor = null, Expression<Func<string>> manufacturerCountry = null, Expression<Func<string>> uPC = null, Expression<Func<string>> hazard = null, Expression<Func<string>> remedy = null, Expression<Func<string>> remedyOption = null)
        {
            var __workflow_recallID = recallID == null ? null : WorkflowExpression.Compile(recallID);
            WorkflowExpression.Validate(__workflow_recallID, nameof(recallID), required: false);
            var __workflow_recallNumber = recallNumber == null ? null : WorkflowExpression.Compile(recallNumber);
            WorkflowExpression.Validate(__workflow_recallNumber, nameof(recallNumber), required: false);
            var __workflow_recallDateStart = recallDateStart == null ? null : WorkflowExpression.Compile(recallDateStart);
            WorkflowExpression.Validate(__workflow_recallDateStart, nameof(recallDateStart), required: false);
            var __workflow_recallDateEnd = recallDateEnd == null ? null : WorkflowExpression.Compile(recallDateEnd);
            WorkflowExpression.Validate(__workflow_recallDateEnd, nameof(recallDateEnd), required: false);
            var __workflow_lastPublishDateStart = lastPublishDateStart == null ? null : WorkflowExpression.Compile(lastPublishDateStart);
            WorkflowExpression.Validate(__workflow_lastPublishDateStart, nameof(lastPublishDateStart), required: false);
            var __workflow_lastPublishDateEnd = lastPublishDateEnd == null ? null : WorkflowExpression.Compile(lastPublishDateEnd);
            WorkflowExpression.Validate(__workflow_lastPublishDateEnd, nameof(lastPublishDateEnd), required: false);
            var __workflow_recallURL = recallURL == null ? null : WorkflowExpression.Compile(recallURL);
            WorkflowExpression.Validate(__workflow_recallURL, nameof(recallURL), required: false);
            var __workflow_recallTitle = recallTitle == null ? null : WorkflowExpression.Compile(recallTitle);
            WorkflowExpression.Validate(__workflow_recallTitle, nameof(recallTitle), required: false);
            var __workflow_consumerContact = consumerContact == null ? null : WorkflowExpression.Compile(consumerContact);
            WorkflowExpression.Validate(__workflow_consumerContact, nameof(consumerContact), required: false);
            var __workflow_recallDescription = recallDescription == null ? null : WorkflowExpression.Compile(recallDescription);
            WorkflowExpression.Validate(__workflow_recallDescription, nameof(recallDescription), required: false);
            var __workflow_productName = productName == null ? null : WorkflowExpression.Compile(productName);
            WorkflowExpression.Validate(__workflow_productName, nameof(productName), required: false);
            var __workflow_productDescription = productDescription == null ? null : WorkflowExpression.Compile(productDescription);
            WorkflowExpression.Validate(__workflow_productDescription, nameof(productDescription), required: false);
            var __workflow_productModel = productModel == null ? null : WorkflowExpression.Compile(productModel);
            WorkflowExpression.Validate(__workflow_productModel, nameof(productModel), required: false);
            var __workflow_productType = productType == null ? null : WorkflowExpression.Compile(productType);
            WorkflowExpression.Validate(__workflow_productType, nameof(productType), required: false);
            var __workflow_inconjunctionURL = inconjunctionURL == null ? null : WorkflowExpression.Compile(inconjunctionURL);
            WorkflowExpression.Validate(__workflow_inconjunctionURL, nameof(inconjunctionURL), required: false);
            var __workflow_imageURL = imageURL == null ? null : WorkflowExpression.Compile(imageURL);
            WorkflowExpression.Validate(__workflow_imageURL, nameof(imageURL), required: false);
            var __workflow_injury = injury == null ? null : WorkflowExpression.Compile(injury);
            WorkflowExpression.Validate(__workflow_injury, nameof(injury), required: false);
            var __workflow_manufacturer = manufacturer == null ? null : WorkflowExpression.Compile(manufacturer);
            WorkflowExpression.Validate(__workflow_manufacturer, nameof(manufacturer), required: false);
            var __workflow_retailer = retailer == null ? null : WorkflowExpression.Compile(retailer);
            WorkflowExpression.Validate(__workflow_retailer, nameof(retailer), required: false);
            var __workflow_importer = importer == null ? null : WorkflowExpression.Compile(importer);
            WorkflowExpression.Validate(__workflow_importer, nameof(importer), required: false);
            var __workflow_distributor = distributor == null ? null : WorkflowExpression.Compile(distributor);
            WorkflowExpression.Validate(__workflow_distributor, nameof(distributor), required: false);
            var __workflow_manufacturerCountry = manufacturerCountry == null ? null : WorkflowExpression.Compile(manufacturerCountry);
            WorkflowExpression.Validate(__workflow_manufacturerCountry, nameof(manufacturerCountry), required: false);
            var __workflow_uPC = uPC == null ? null : WorkflowExpression.Compile(uPC);
            WorkflowExpression.Validate(__workflow_uPC, nameof(uPC), required: false);
            var __workflow_hazard = hazard == null ? null : WorkflowExpression.Compile(hazard);
            WorkflowExpression.Validate(__workflow_hazard, nameof(hazard), required: false);
            var __workflow_remedy = remedy == null ? null : WorkflowExpression.Compile(remedy);
            WorkflowExpression.Validate(__workflow_remedy, nameof(remedy), required: false);
            var __workflow_remedyOption = remedyOption == null ? null : WorkflowExpression.Compile(remedyOption);
            WorkflowExpression.Validate(__workflow_remedyOption, nameof(remedyOption), required: false);
            return new DeferredBodyAction<RecallGetResponseItem[]>(() =>
            {
                var apiCallPath = "/Recall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recallID != null)
                    callPayload.Queries["RecallID"] = ExpressionConverter.Convert(__workflow_recallID);
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
                if (__workflow_recallURL != null)
                    callPayload.Queries["RecallURL"] = ExpressionConverter.Convert(__workflow_recallURL);
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
                if (__workflow_inconjunctionURL != null)
                    callPayload.Queries["InconjunctionURL"] = ExpressionConverter.Convert(__workflow_inconjunctionURL);
                if (__workflow_imageURL != null)
                    callPayload.Queries["ImageURL"] = ExpressionConverter.Convert(__workflow_imageURL);
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
                if (__workflow_uPC != null)
                    callPayload.Queries["UPC"] = ExpressionConverter.Convert(__workflow_uPC);
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
        public int RecallID { get; set; }
        public string RecallNumber { get; set; }
        public string RecallDate { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
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
        public RecallGetResponseItemProductUPCsTypeItem[] ProductUPCs { get; set; }
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
        public string CategoryID { get; set; }
        public string NumberOfUnits { get; set; }
    }

    public class RecallGetResponseItemInconjunctionsTypeItem
    {
        public string Name { get; set; }
    }

    public class RecallGetResponseItemImagesTypeItem
    {
        public string URL { get; set; }
    }

    public class RecallGetResponseItemInjuriesTypeItem
    {
        public string Name { get; set; }
    }

    public class RecallGetResponseItemManufacturersTypeItem
    {
        public string Name { get; set; }
        public string CompanyID { get; set; }
    }

    public class RecallGetResponseItemRetailersTypeItem
    {
        public string Name { get; set; }
        public string CompanyID { get; set; }
    }

    public class RecallGetResponseItemImportersTypeItem
    {
        public string Name { get; set; }
        public string CompanyID { get; set; }
    }

    public class RecallGetResponseItemDistributorsTypeItem
    {
        public string Name { get; set; }
        public string CompanyID { get; set; }
    }

    public class RecallGetResponseItemManufacturerCountriesTypeItem
    {
        public string Country { get; set; }
    }

    public class RecallGetResponseItemProductUPCsTypeItem
    {
        public string UPC { get; set; }
    }

    public class RecallGetResponseItemHazardsTypeItem
    {
        public string Name { get; set; }
        public string HazardType { get; set; }
        public string HazardTypeID { get; set; }
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
