//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cqcdata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CqcdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction Providers(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> constituency = null, Expression<Func<string>> region = null, Expression<Func<string>> localAuthority = null, Expression<Func<string>> inspectionDirectorate = null, Expression<Func<string>> nonPrimaryInspectionCategoryCode = null, Expression<Func<string>> nonPrimaryInspectionCategoryName = null, Expression<Func<string>> primaryInspectionCategoryCode = null, Expression<Func<string>> primaryInspectionCategoryName = null, Expression<Func<string>> overallRating = null, Expression<Func<string>> regulatedActivity = null, Expression<Func<string>> reportType = null)
        {
            var apiCallPath = "/providers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["perPage"] = Convert.ToString(1000);
            if (perPage != null)
                callPayload.Queries["perPage"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            if (constituency != null)
                callPayload.Queries["constituency"] = ExpressionConverter.Convert(constituency);
            if (region != null)
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
            if (localAuthority != null)
                callPayload.Queries["localAuthority"] = ExpressionConverter.Convert(localAuthority);
            if (inspectionDirectorate != null)
                callPayload.Queries["inspectionDirectorate"] = ExpressionConverter.Convert(inspectionDirectorate);
            if (nonPrimaryInspectionCategoryCode != null)
                callPayload.Queries["nonPrimaryInspectionCategoryCode"] = ExpressionConverter.Convert(nonPrimaryInspectionCategoryCode);
            if (nonPrimaryInspectionCategoryName != null)
                callPayload.Queries["nonPrimaryInspectionCategoryName"] = ExpressionConverter.Convert(nonPrimaryInspectionCategoryName);
            if (primaryInspectionCategoryCode != null)
                callPayload.Queries["primaryInspectionCategoryCode"] = ExpressionConverter.Convert(primaryInspectionCategoryCode);
            if (primaryInspectionCategoryName != null)
                callPayload.Queries["primaryInspectionCategoryName"] = ExpressionConverter.Convert(primaryInspectionCategoryName);
            if (overallRating != null)
                callPayload.Queries["overallRating"] = ExpressionConverter.Convert(overallRating);
            if (regulatedActivity != null)
                callPayload.Queries["regulatedActivity"] = ExpressionConverter.Convert(regulatedActivity);
            if (reportType != null)
                callPayload.Queries["reportType"] = ExpressionConverter.Convert(reportType);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction Locations(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string[]>> reportType = null, Expression<Func<string[]>> regulatedActivity = null, Expression<Func<string>> region = null, Expression<Func<string>> overallRating = null, Expression<Func<string>> primaryInspectionCategoryName = null, Expression<Func<string>> primaryInspectionCategoryCode = null, Expression<Func<string>> nonPrimaryInspectionCategoryName = null, Expression<Func<string>> nonPrimaryInspectionCategoryCode = null, Expression<Func<string>> inspectionDirectorate = null, Expression<Func<string>> localAuthority = null, Expression<Func<string>> constituency = null, Expression<Func<string>> gacServiceTypeDescription = null, Expression<Func<string>> odsCcgName = null, Expression<Func<string[]>> odsCcgCode = null, Expression<Func<string>> onspdCcgName = null, Expression<Func<string>> onspdCcgCode = null, Expression<Func<string>> careHome = null)
        {
            var apiCallPath = "/locations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["perPage"] = Convert.ToString(1000);
            if (perPage != null)
                callPayload.Queries["perPage"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            if (reportType != null)
                callPayload.Queries["reportType"] = ExpressionConverter.Convert(reportType);
            if (regulatedActivity != null)
                callPayload.Queries["regulatedActivity"] = ExpressionConverter.Convert(regulatedActivity);
            if (region != null)
                callPayload.Queries["region"] = ExpressionConverter.Convert(region);
            if (overallRating != null)
                callPayload.Queries["overallRating"] = ExpressionConverter.Convert(overallRating);
            if (primaryInspectionCategoryName != null)
                callPayload.Queries["primaryInspectionCategoryName"] = ExpressionConverter.Convert(primaryInspectionCategoryName);
            if (primaryInspectionCategoryCode != null)
                callPayload.Queries["primaryInspectionCategoryCode"] = ExpressionConverter.Convert(primaryInspectionCategoryCode);
            if (nonPrimaryInspectionCategoryName != null)
                callPayload.Queries["nonPrimaryInspectionCategoryName"] = ExpressionConverter.Convert(nonPrimaryInspectionCategoryName);
            if (nonPrimaryInspectionCategoryCode != null)
                callPayload.Queries["nonPrimaryInspectionCategoryCode"] = ExpressionConverter.Convert(nonPrimaryInspectionCategoryCode);
            if (inspectionDirectorate != null)
                callPayload.Queries["inspectionDirectorate"] = ExpressionConverter.Convert(inspectionDirectorate);
            if (localAuthority != null)
                callPayload.Queries["localAuthority"] = ExpressionConverter.Convert(localAuthority);
            if (constituency != null)
                callPayload.Queries["constituency"] = ExpressionConverter.Convert(constituency);
            if (gacServiceTypeDescription != null)
                callPayload.Queries["gacServiceTypeDescription"] = ExpressionConverter.Convert(gacServiceTypeDescription);
            if (odsCcgName != null)
                callPayload.Queries["odsCcgName"] = ExpressionConverter.Convert(odsCcgName);
            if (odsCcgCode != null)
                callPayload.Queries["odsCcgCode"] = ExpressionConverter.Convert(odsCcgCode);
            if (onspdCcgName != null)
                callPayload.Queries["onspdCcgName"] = ExpressionConverter.Convert(onspdCcgName);
            if (onspdCcgCode != null)
                callPayload.Queries["onspdCcgCode"] = ExpressionConverter.Convert(onspdCcgCode);
            if (careHome != null)
                callPayload.Queries["careHome"] = ExpressionConverter.Convert(careHome);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction ProviderDetails(Expression<Func<string>> providerId)
        {
            var apiCallPath = String.Format("/providers/{0}", ExpressionConverter.ConvertWithUrlEncoding(providerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction LocationDetails(Expression<Func<string>> locationid)
        {
            var apiCallPath = String.Format("/locations/{0}", ExpressionConverter.ConvertWithUrlEncoding(locationid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction LocationInspectionAreas(Expression<Func<string>> locationId)
        {
            var apiCallPath = String.Format("/locations/{0}/inspection-areas", ExpressionConverter.ConvertWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction LocationProviderInspectionArea(Expression<Func<string>> locationId)
        {
            var apiCallPath = String.Format("/locations/{0}/provider-inspection-areas", ExpressionConverter.ConvertWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction ProviderLocations(Expression<Func<string>> providerId)
        {
            var apiCallPath = String.Format("/providers/{0}/locations", ExpressionConverter.ConvertWithUrlEncoding(providerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("CustomConnector");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction ProviderInspectionAreas(Expression<Func<string>> providerId)
        {
            var apiCallPath = String.Format("/providers/{0}/inspection-areas", ExpressionConverter.ConvertWithUrlEncoding(providerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction Changes(Expression<Func<string>> organisationType, Expression<Func<string>> startTimestamp, Expression<Func<string>> endTimeStamp, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/changes/{0}", ExpressionConverter.ConvertWithUrlEncoding(organisationType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["perPage"] = Convert.ToString(500);
            if (perPage != null)
                callPayload.Queries["perPage"] = ExpressionConverter.Convert(perPage);
            callPayload.Queries["startTimestamp"] = ExpressionConverter.Convert(startTimestamp);
            callPayload.Queries["endTimeStamp"] = ExpressionConverter.Convert(endTimeStamp);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction InspectionAreas()
        {
            var apiCallPath = "/inspection-areas";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("CustomConnector");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction MainReport(Expression<Func<string>> inspectionReportLinkId)
        {
            var apiCallPath = String.Format("/reports/{0}", ExpressionConverter.ConvertWithUrlEncoding(inspectionReportLinkId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction ReportAndRelatedDoc(Expression<Func<string>> inspectionReportLinkId, Expression<Func<string>> relatedDocumentType)
        {
            var apiCallPath = String.Format("/reports/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(inspectionReportLinkId, 1), ExpressionConverter.ConvertWithUrlEncoding(relatedDocumentType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
            return new ApiConnectionAction(callPayload);
        }
    }

    public class CqcdataTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cqcdata;

    public partial class WorkflowManagedActions
    {
        public CqcdataActions Cqcdata(string connectionId) => new CqcdataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CqcdataTriggers Cqcdata(string connectionId) => new CqcdataTriggers(connectionId);
    }
}