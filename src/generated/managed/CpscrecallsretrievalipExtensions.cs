//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cpscrecallsretrievalip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CpscrecallsretrievalipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cpscrecallsretrievalip")]
        public IBodyWorkflowAction<RecallGetResponseItem[]> RecallGet([WorkflowExpression] Func<string> recallID = null, [WorkflowExpression] Func<string> recallNumber = null, [WorkflowExpression] Func<string> recallDateStart = null, [WorkflowExpression] Func<string> recallDateEnd = null, [WorkflowExpression] Func<string> lastPublishDateStart = null, [WorkflowExpression] Func<string> lastPublishDateEnd = null, [WorkflowExpression] Func<string> recallURL = null, [WorkflowExpression] Func<string> recallTitle = null, [WorkflowExpression] Func<string> consumerContact = null, [WorkflowExpression] Func<string> recallDescription = null, [WorkflowExpression] Func<string> productName = null, [WorkflowExpression] Func<string> productDescription = null, [WorkflowExpression] Func<string> productModel = null, [WorkflowExpression] Func<string> productType = null, [WorkflowExpression] Func<string> inconjunctionURL = null, [WorkflowExpression] Func<string> imageURL = null, [WorkflowExpression] Func<string> injury = null, [WorkflowExpression] Func<string> manufacturer = null, [WorkflowExpression] Func<string> retailer = null, [WorkflowExpression] Func<string> importer = null, [WorkflowExpression] Func<string> distributor = null, [WorkflowExpression] Func<string> manufacturerCountry = null, [WorkflowExpression] Func<string> uPC = null, [WorkflowExpression] Func<string> hazard = null, [WorkflowExpression] Func<string> remedy = null, [WorkflowExpression] Func<string> remedyOption = null)
        {
            SourceExpression.Validate(recallID, nameof(recallID), required: false);
            SourceExpression.Validate(recallNumber, nameof(recallNumber), required: false);
            SourceExpression.Validate(recallDateStart, nameof(recallDateStart), required: false);
            SourceExpression.Validate(recallDateEnd, nameof(recallDateEnd), required: false);
            SourceExpression.Validate(lastPublishDateStart, nameof(lastPublishDateStart), required: false);
            SourceExpression.Validate(lastPublishDateEnd, nameof(lastPublishDateEnd), required: false);
            SourceExpression.Validate(recallURL, nameof(recallURL), required: false);
            SourceExpression.Validate(recallTitle, nameof(recallTitle), required: false);
            SourceExpression.Validate(consumerContact, nameof(consumerContact), required: false);
            SourceExpression.Validate(recallDescription, nameof(recallDescription), required: false);
            SourceExpression.Validate(productName, nameof(productName), required: false);
            SourceExpression.Validate(productDescription, nameof(productDescription), required: false);
            SourceExpression.Validate(productModel, nameof(productModel), required: false);
            SourceExpression.Validate(productType, nameof(productType), required: false);
            SourceExpression.Validate(inconjunctionURL, nameof(inconjunctionURL), required: false);
            SourceExpression.Validate(imageURL, nameof(imageURL), required: false);
            SourceExpression.Validate(injury, nameof(injury), required: false);
            SourceExpression.Validate(manufacturer, nameof(manufacturer), required: false);
            SourceExpression.Validate(retailer, nameof(retailer), required: false);
            SourceExpression.Validate(importer, nameof(importer), required: false);
            SourceExpression.Validate(distributor, nameof(distributor), required: false);
            SourceExpression.Validate(manufacturerCountry, nameof(manufacturerCountry), required: false);
            SourceExpression.Validate(uPC, nameof(uPC), required: false);
            SourceExpression.Validate(hazard, nameof(hazard), required: false);
            SourceExpression.Validate(remedy, nameof(remedy), required: false);
            SourceExpression.Validate(remedyOption, nameof(remedyOption), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Recall";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recallID != null)
                    callPayload.Queries["RecallID"] = SourceExpressionConverter.ConvertO(recallID);
                if (recallNumber != null)
                    callPayload.Queries["RecallNumber"] = SourceExpressionConverter.ConvertO(recallNumber);
                if (recallDateStart != null)
                    callPayload.Queries["RecallDateStart"] = SourceExpressionConverter.ConvertO(recallDateStart);
                if (recallDateEnd != null)
                    callPayload.Queries["RecallDateEnd"] = SourceExpressionConverter.ConvertO(recallDateEnd);
                if (lastPublishDateStart != null)
                    callPayload.Queries["LastPublishDateStart"] = SourceExpressionConverter.ConvertO(lastPublishDateStart);
                if (lastPublishDateEnd != null)
                    callPayload.Queries["LastPublishDateEnd"] = SourceExpressionConverter.ConvertO(lastPublishDateEnd);
                if (recallURL != null)
                    callPayload.Queries["RecallURL"] = SourceExpressionConverter.ConvertO(recallURL);
                if (recallTitle != null)
                    callPayload.Queries["RecallTitle"] = SourceExpressionConverter.ConvertO(recallTitle);
                if (consumerContact != null)
                    callPayload.Queries["ConsumerContact"] = SourceExpressionConverter.ConvertO(consumerContact);
                if (recallDescription != null)
                    callPayload.Queries["RecallDescription"] = SourceExpressionConverter.ConvertO(recallDescription);
                if (productName != null)
                    callPayload.Queries["ProductName"] = SourceExpressionConverter.ConvertO(productName);
                if (productDescription != null)
                    callPayload.Queries["ProductDescription"] = SourceExpressionConverter.ConvertO(productDescription);
                if (productModel != null)
                    callPayload.Queries["ProductModel"] = SourceExpressionConverter.ConvertO(productModel);
                if (productType != null)
                    callPayload.Queries["ProductType"] = SourceExpressionConverter.ConvertO(productType);
                if (inconjunctionURL != null)
                    callPayload.Queries["InconjunctionURL"] = SourceExpressionConverter.ConvertO(inconjunctionURL);
                if (imageURL != null)
                    callPayload.Queries["ImageURL"] = SourceExpressionConverter.ConvertO(imageURL);
                if (injury != null)
                    callPayload.Queries["Injury"] = SourceExpressionConverter.ConvertO(injury);
                if (manufacturer != null)
                    callPayload.Queries["Manufacturer"] = SourceExpressionConverter.ConvertO(manufacturer);
                if (retailer != null)
                    callPayload.Queries["Retailer"] = SourceExpressionConverter.ConvertO(retailer);
                if (importer != null)
                    callPayload.Queries["Importer"] = SourceExpressionConverter.ConvertO(importer);
                if (distributor != null)
                    callPayload.Queries["Distributor"] = SourceExpressionConverter.ConvertO(distributor);
                if (manufacturerCountry != null)
                    callPayload.Queries["ManufacturerCountry"] = SourceExpressionConverter.ConvertO(manufacturerCountry);
                if (uPC != null)
                    callPayload.Queries["UPC"] = SourceExpressionConverter.ConvertO(uPC);
                if (hazard != null)
                    callPayload.Queries["Hazard"] = SourceExpressionConverter.ConvertO(hazard);
                if (remedy != null)
                    callPayload.Queries["Remedy"] = SourceExpressionConverter.ConvertO(remedy);
                if (remedyOption != null)
                    callPayload.Queries["RemedyOption"] = SourceExpressionConverter.ConvertO(remedyOption);
                return callPayload;
            }

            return new ApiConnectionAction<RecallGetResponseItem[]>(BuildSourceInput);
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