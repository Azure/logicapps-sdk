//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cpscrecallsretrievalip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CpscrecallsretrievalipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cpscrecallsretrievalip")]
        public IBodyWorkflowAction<RecallGetResponseItem[]> RecallGet(Expression<Func<string>> recallID = null, Expression<Func<string>> recallNumber = null, Expression<Func<string>> recallDateStart = null, Expression<Func<string>> recallDateEnd = null, Expression<Func<string>> lastPublishDateStart = null, Expression<Func<string>> lastPublishDateEnd = null, Expression<Func<string>> recallURL = null, Expression<Func<string>> recallTitle = null, Expression<Func<string>> consumerContact = null, Expression<Func<string>> recallDescription = null, Expression<Func<string>> productName = null, Expression<Func<string>> productDescription = null, Expression<Func<string>> productModel = null, Expression<Func<string>> productType = null, Expression<Func<string>> inconjunctionURL = null, Expression<Func<string>> imageURL = null, Expression<Func<string>> injury = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> retailer = null, Expression<Func<string>> importer = null, Expression<Func<string>> distributor = null, Expression<Func<string>> manufacturerCountry = null, Expression<Func<string>> uPC = null, Expression<Func<string>> hazard = null, Expression<Func<string>> remedy = null, Expression<Func<string>> remedyOption = null)
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
    using Microsoft.Azure.Workflows.Sdk.Cpscrecallsretrievalip;

    public partial class WorkflowManagedActions
    {
        public CpscrecallsretrievalipActions Cpscrecallsretrievalip(string connectionId) => new CpscrecallsretrievalipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CpscrecallsretrievalipTriggers Cpscrecallsretrievalip(string connectionId) => new CpscrecallsretrievalipTriggers(connectionId);
    }
}