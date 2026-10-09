//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cpscrecallsretrievalip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CpscrecallsretrievalipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cpscrecallsretrievalip")]
        [WorkflowExpressionFactory(nameof(__BuildRecallGet))]
        public IBodyWorkflowAction<RecallGetResponseItem[]> RecallGet([WorkflowExpression] Func<string> recallID = null, [WorkflowExpression] Func<string> recallNumber = null, [WorkflowExpression] Func<string> recallDateStart = null, [WorkflowExpression] Func<string> recallDateEnd = null, [WorkflowExpression] Func<string> lastPublishDateStart = null, [WorkflowExpression] Func<string> lastPublishDateEnd = null, [WorkflowExpression] Func<string> recallURL = null, [WorkflowExpression] Func<string> recallTitle = null, [WorkflowExpression] Func<string> consumerContact = null, [WorkflowExpression] Func<string> recallDescription = null, [WorkflowExpression] Func<string> productName = null, [WorkflowExpression] Func<string> productDescription = null, [WorkflowExpression] Func<string> productModel = null, [WorkflowExpression] Func<string> productType = null, [WorkflowExpression] Func<string> inconjunctionURL = null, [WorkflowExpression] Func<string> imageURL = null, [WorkflowExpression] Func<string> injury = null, [WorkflowExpression] Func<string> manufacturer = null, [WorkflowExpression] Func<string> retailer = null, [WorkflowExpression] Func<string> importer = null, [WorkflowExpression] Func<string> distributor = null, [WorkflowExpression] Func<string> manufacturerCountry = null, [WorkflowExpression] Func<string> uPC = null, [WorkflowExpression] Func<string> hazard = null, [WorkflowExpression] Func<string> remedy = null, [WorkflowExpression] Func<string> remedyOption = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecallGetResponseItem[]> __BuildRecallGet(WorkflowExpression<string> recallID = null, WorkflowExpression<string> recallNumber = null, WorkflowExpression<string> recallDateStart = null, WorkflowExpression<string> recallDateEnd = null, WorkflowExpression<string> lastPublishDateStart = null, WorkflowExpression<string> lastPublishDateEnd = null, WorkflowExpression<string> recallURL = null, WorkflowExpression<string> recallTitle = null, WorkflowExpression<string> consumerContact = null, WorkflowExpression<string> recallDescription = null, WorkflowExpression<string> productName = null, WorkflowExpression<string> productDescription = null, WorkflowExpression<string> productModel = null, WorkflowExpression<string> productType = null, WorkflowExpression<string> inconjunctionURL = null, WorkflowExpression<string> imageURL = null, WorkflowExpression<string> injury = null, WorkflowExpression<string> manufacturer = null, WorkflowExpression<string> retailer = null, WorkflowExpression<string> importer = null, WorkflowExpression<string> distributor = null, WorkflowExpression<string> manufacturerCountry = null, WorkflowExpression<string> uPC = null, WorkflowExpression<string> hazard = null, WorkflowExpression<string> remedy = null, WorkflowExpression<string> remedyOption = null)
        {
            WorkflowExpression.Validate(recallID, nameof(recallID), required: false);
            WorkflowExpression.Validate(recallNumber, nameof(recallNumber), required: false);
            WorkflowExpression.Validate(recallDateStart, nameof(recallDateStart), required: false);
            WorkflowExpression.Validate(recallDateEnd, nameof(recallDateEnd), required: false);
            WorkflowExpression.Validate(lastPublishDateStart, nameof(lastPublishDateStart), required: false);
            WorkflowExpression.Validate(lastPublishDateEnd, nameof(lastPublishDateEnd), required: false);
            WorkflowExpression.Validate(recallURL, nameof(recallURL), required: false);
            WorkflowExpression.Validate(recallTitle, nameof(recallTitle), required: false);
            WorkflowExpression.Validate(consumerContact, nameof(consumerContact), required: false);
            WorkflowExpression.Validate(recallDescription, nameof(recallDescription), required: false);
            WorkflowExpression.Validate(productName, nameof(productName), required: false);
            WorkflowExpression.Validate(productDescription, nameof(productDescription), required: false);
            WorkflowExpression.Validate(productModel, nameof(productModel), required: false);
            WorkflowExpression.Validate(productType, nameof(productType), required: false);
            WorkflowExpression.Validate(inconjunctionURL, nameof(inconjunctionURL), required: false);
            WorkflowExpression.Validate(imageURL, nameof(imageURL), required: false);
            WorkflowExpression.Validate(injury, nameof(injury), required: false);
            WorkflowExpression.Validate(manufacturer, nameof(manufacturer), required: false);
            WorkflowExpression.Validate(retailer, nameof(retailer), required: false);
            WorkflowExpression.Validate(importer, nameof(importer), required: false);
            WorkflowExpression.Validate(distributor, nameof(distributor), required: false);
            WorkflowExpression.Validate(manufacturerCountry, nameof(manufacturerCountry), required: false);
            WorkflowExpression.Validate(uPC, nameof(uPC), required: false);
            WorkflowExpression.Validate(hazard, nameof(hazard), required: false);
            WorkflowExpression.Validate(remedy, nameof(remedy), required: false);
            WorkflowExpression.Validate(remedyOption, nameof(remedyOption), required: false);
            return new DeferredBodyAction<RecallGetResponseItem[]>(() =>
            {
                var apiCallPath = "/Recall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recallID != null)
                    callPayload.Queries["RecallID"] = ExpressionConverter.Convert(recallID);
                if (recallNumber != null)
                    callPayload.Queries["RecallNumber"] = ExpressionConverter.Convert(recallNumber);
                if (recallDateStart != null)
                    callPayload.Queries["RecallDateStart"] = ExpressionConverter.Convert(recallDateStart);
                if (recallDateEnd != null)
                    callPayload.Queries["RecallDateEnd"] = ExpressionConverter.Convert(recallDateEnd);
                if (lastPublishDateStart != null)
                    callPayload.Queries["LastPublishDateStart"] = ExpressionConverter.Convert(lastPublishDateStart);
                if (lastPublishDateEnd != null)
                    callPayload.Queries["LastPublishDateEnd"] = ExpressionConverter.Convert(lastPublishDateEnd);
                if (recallURL != null)
                    callPayload.Queries["RecallURL"] = ExpressionConverter.Convert(recallURL);
                if (recallTitle != null)
                    callPayload.Queries["RecallTitle"] = ExpressionConverter.Convert(recallTitle);
                if (consumerContact != null)
                    callPayload.Queries["ConsumerContact"] = ExpressionConverter.Convert(consumerContact);
                if (recallDescription != null)
                    callPayload.Queries["RecallDescription"] = ExpressionConverter.Convert(recallDescription);
                if (productName != null)
                    callPayload.Queries["ProductName"] = ExpressionConverter.Convert(productName);
                if (productDescription != null)
                    callPayload.Queries["ProductDescription"] = ExpressionConverter.Convert(productDescription);
                if (productModel != null)
                    callPayload.Queries["ProductModel"] = ExpressionConverter.Convert(productModel);
                if (productType != null)
                    callPayload.Queries["ProductType"] = ExpressionConverter.Convert(productType);
                if (inconjunctionURL != null)
                    callPayload.Queries["InconjunctionURL"] = ExpressionConverter.Convert(inconjunctionURL);
                if (imageURL != null)
                    callPayload.Queries["ImageURL"] = ExpressionConverter.Convert(imageURL);
                if (injury != null)
                    callPayload.Queries["Injury"] = ExpressionConverter.Convert(injury);
                if (manufacturer != null)
                    callPayload.Queries["Manufacturer"] = ExpressionConverter.Convert(manufacturer);
                if (retailer != null)
                    callPayload.Queries["Retailer"] = ExpressionConverter.Convert(retailer);
                if (importer != null)
                    callPayload.Queries["Importer"] = ExpressionConverter.Convert(importer);
                if (distributor != null)
                    callPayload.Queries["Distributor"] = ExpressionConverter.Convert(distributor);
                if (manufacturerCountry != null)
                    callPayload.Queries["ManufacturerCountry"] = ExpressionConverter.Convert(manufacturerCountry);
                if (uPC != null)
                    callPayload.Queries["UPC"] = ExpressionConverter.Convert(uPC);
                if (hazard != null)
                    callPayload.Queries["Hazard"] = ExpressionConverter.Convert(hazard);
                if (remedy != null)
                    callPayload.Queries["Remedy"] = ExpressionConverter.Convert(remedy);
                if (remedyOption != null)
                    callPayload.Queries["RemedyOption"] = ExpressionConverter.Convert(remedyOption);
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