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
        public IBodyWorkflowAction<RecallGetResponseItem[]> RecallGet(Expression<Func<string>> recallID = null, Expression<Func<string>> recallNumber = null, Expression<Func<string>> recallDateStart = null, Expression<Func<string>> recallDateEnd = null, Expression<Func<string>> lastPublishDateStart = null, Expression<Func<string>> lastPublishDateEnd = null, Expression<Func<string>> recallURL = null, Expression<Func<string>> recallTitle = null, Expression<Func<string>> consumerContact = null, Expression<Func<string>> recallDescription = null, Expression<Func<string>> productName = null, Expression<Func<string>> productDescription = null, Expression<Func<string>> productModel = null, Expression<Func<string>> productType = null, Expression<Func<string>> inconjunctionURL = null, Expression<Func<string>> imageURL = null, Expression<Func<string>> injury = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> retailer = null, Expression<Func<string>> importer = null, Expression<Func<string>> distributor = null, Expression<Func<string>> manufacturerCountry = null, Expression<Func<string>> uPC = null, Expression<Func<string>> hazard = null, Expression<Func<string>> remedy = null, Expression<Func<string>> remedyOption = null)
        {
            var apiCallPath = "/Recall";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recallID != null)
                callPayload.Queries["RecallID"] = CSharpExpressionConverter.ConvertO(recallID);
            if (recallNumber != null)
                callPayload.Queries["RecallNumber"] = CSharpExpressionConverter.ConvertO(recallNumber);
            if (recallDateStart != null)
                callPayload.Queries["RecallDateStart"] = CSharpExpressionConverter.ConvertO(recallDateStart);
            if (recallDateEnd != null)
                callPayload.Queries["RecallDateEnd"] = CSharpExpressionConverter.ConvertO(recallDateEnd);
            if (lastPublishDateStart != null)
                callPayload.Queries["LastPublishDateStart"] = CSharpExpressionConverter.ConvertO(lastPublishDateStart);
            if (lastPublishDateEnd != null)
                callPayload.Queries["LastPublishDateEnd"] = CSharpExpressionConverter.ConvertO(lastPublishDateEnd);
            if (recallURL != null)
                callPayload.Queries["RecallURL"] = CSharpExpressionConverter.ConvertO(recallURL);
            if (recallTitle != null)
                callPayload.Queries["RecallTitle"] = CSharpExpressionConverter.ConvertO(recallTitle);
            if (consumerContact != null)
                callPayload.Queries["ConsumerContact"] = CSharpExpressionConverter.ConvertO(consumerContact);
            if (recallDescription != null)
                callPayload.Queries["RecallDescription"] = CSharpExpressionConverter.ConvertO(recallDescription);
            if (productName != null)
                callPayload.Queries["ProductName"] = CSharpExpressionConverter.ConvertO(productName);
            if (productDescription != null)
                callPayload.Queries["ProductDescription"] = CSharpExpressionConverter.ConvertO(productDescription);
            if (productModel != null)
                callPayload.Queries["ProductModel"] = CSharpExpressionConverter.ConvertO(productModel);
            if (productType != null)
                callPayload.Queries["ProductType"] = CSharpExpressionConverter.ConvertO(productType);
            if (inconjunctionURL != null)
                callPayload.Queries["InconjunctionURL"] = CSharpExpressionConverter.ConvertO(inconjunctionURL);
            if (imageURL != null)
                callPayload.Queries["ImageURL"] = CSharpExpressionConverter.ConvertO(imageURL);
            if (injury != null)
                callPayload.Queries["Injury"] = CSharpExpressionConverter.ConvertO(injury);
            if (manufacturer != null)
                callPayload.Queries["Manufacturer"] = CSharpExpressionConverter.ConvertO(manufacturer);
            if (retailer != null)
                callPayload.Queries["Retailer"] = CSharpExpressionConverter.ConvertO(retailer);
            if (importer != null)
                callPayload.Queries["Importer"] = CSharpExpressionConverter.ConvertO(importer);
            if (distributor != null)
                callPayload.Queries["Distributor"] = CSharpExpressionConverter.ConvertO(distributor);
            if (manufacturerCountry != null)
                callPayload.Queries["ManufacturerCountry"] = CSharpExpressionConverter.ConvertO(manufacturerCountry);
            if (uPC != null)
                callPayload.Queries["UPC"] = CSharpExpressionConverter.ConvertO(uPC);
            if (hazard != null)
                callPayload.Queries["Hazard"] = CSharpExpressionConverter.ConvertO(hazard);
            if (remedy != null)
                callPayload.Queries["Remedy"] = CSharpExpressionConverter.ConvertO(remedy);
            if (remedyOption != null)
                callPayload.Queries["RemedyOption"] = CSharpExpressionConverter.ConvertO(remedyOption);
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