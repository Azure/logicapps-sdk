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
        public IWorkflowAction Providers([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> constituency = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> localAuthority = null, [WorkflowExpression] Func<string> inspectionDirectorate = null, [WorkflowExpression] Func<string> nonPrimaryInspectionCategoryCode = null, [WorkflowExpression] Func<string> nonPrimaryInspectionCategoryName = null, [WorkflowExpression] Func<string> primaryInspectionCategoryCode = null, [WorkflowExpression] Func<string> primaryInspectionCategoryName = null, [WorkflowExpression] Func<string> overallRating = null, [WorkflowExpression] Func<string> regulatedActivity = null, [WorkflowExpression] Func<string> reportType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/providers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["perPage"] = Convert.ToString(1000);
                if (perPage != null)
                    callPayload.Queries["perPage"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                if (constituency != null)
                    callPayload.Queries["constituency"] = SourceExpressionConverter.ConvertO(constituency);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (localAuthority != null)
                    callPayload.Queries["localAuthority"] = SourceExpressionConverter.ConvertO(localAuthority);
                if (inspectionDirectorate != null)
                    callPayload.Queries["inspectionDirectorate"] = SourceExpressionConverter.ConvertO(inspectionDirectorate);
                if (nonPrimaryInspectionCategoryCode != null)
                    callPayload.Queries["nonPrimaryInspectionCategoryCode"] = SourceExpressionConverter.ConvertO(nonPrimaryInspectionCategoryCode);
                if (nonPrimaryInspectionCategoryName != null)
                    callPayload.Queries["nonPrimaryInspectionCategoryName"] = SourceExpressionConverter.ConvertO(nonPrimaryInspectionCategoryName);
                if (primaryInspectionCategoryCode != null)
                    callPayload.Queries["primaryInspectionCategoryCode"] = SourceExpressionConverter.ConvertO(primaryInspectionCategoryCode);
                if (primaryInspectionCategoryName != null)
                    callPayload.Queries["primaryInspectionCategoryName"] = SourceExpressionConverter.ConvertO(primaryInspectionCategoryName);
                if (overallRating != null)
                    callPayload.Queries["overallRating"] = SourceExpressionConverter.ConvertO(overallRating);
                if (regulatedActivity != null)
                    callPayload.Queries["regulatedActivity"] = SourceExpressionConverter.ConvertO(regulatedActivity);
                if (reportType != null)
                    callPayload.Queries["reportType"] = SourceExpressionConverter.ConvertO(reportType);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction Locations([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string[]> reportType = null, [WorkflowExpression] Func<string[]> regulatedActivity = null, [WorkflowExpression] Func<string> region = null, [WorkflowExpression] Func<string> overallRating = null, [WorkflowExpression] Func<string> primaryInspectionCategoryName = null, [WorkflowExpression] Func<string> primaryInspectionCategoryCode = null, [WorkflowExpression] Func<string> nonPrimaryInspectionCategoryName = null, [WorkflowExpression] Func<string> nonPrimaryInspectionCategoryCode = null, [WorkflowExpression] Func<string> inspectionDirectorate = null, [WorkflowExpression] Func<string> localAuthority = null, [WorkflowExpression] Func<string> constituency = null, [WorkflowExpression] Func<string> gacServiceTypeDescription = null, [WorkflowExpression] Func<string> odsCcgName = null, [WorkflowExpression] Func<string[]> odsCcgCode = null, [WorkflowExpression] Func<string> onspdCcgName = null, [WorkflowExpression] Func<string> onspdCcgCode = null, [WorkflowExpression] Func<string> careHome = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["perPage"] = Convert.ToString(1000);
                if (perPage != null)
                    callPayload.Queries["perPage"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                if (reportType != null)
                    callPayload.Queries["reportType"] = SourceExpressionConverter.ConvertO(reportType);
                if (regulatedActivity != null)
                    callPayload.Queries["regulatedActivity"] = SourceExpressionConverter.ConvertO(regulatedActivity);
                if (region != null)
                    callPayload.Queries["region"] = SourceExpressionConverter.ConvertO(region);
                if (overallRating != null)
                    callPayload.Queries["overallRating"] = SourceExpressionConverter.ConvertO(overallRating);
                if (primaryInspectionCategoryName != null)
                    callPayload.Queries["primaryInspectionCategoryName"] = SourceExpressionConverter.ConvertO(primaryInspectionCategoryName);
                if (primaryInspectionCategoryCode != null)
                    callPayload.Queries["primaryInspectionCategoryCode"] = SourceExpressionConverter.ConvertO(primaryInspectionCategoryCode);
                if (nonPrimaryInspectionCategoryName != null)
                    callPayload.Queries["nonPrimaryInspectionCategoryName"] = SourceExpressionConverter.ConvertO(nonPrimaryInspectionCategoryName);
                if (nonPrimaryInspectionCategoryCode != null)
                    callPayload.Queries["nonPrimaryInspectionCategoryCode"] = SourceExpressionConverter.ConvertO(nonPrimaryInspectionCategoryCode);
                if (inspectionDirectorate != null)
                    callPayload.Queries["inspectionDirectorate"] = SourceExpressionConverter.ConvertO(inspectionDirectorate);
                if (localAuthority != null)
                    callPayload.Queries["localAuthority"] = SourceExpressionConverter.ConvertO(localAuthority);
                if (constituency != null)
                    callPayload.Queries["constituency"] = SourceExpressionConverter.ConvertO(constituency);
                if (gacServiceTypeDescription != null)
                    callPayload.Queries["gacServiceTypeDescription"] = SourceExpressionConverter.ConvertO(gacServiceTypeDescription);
                if (odsCcgName != null)
                    callPayload.Queries["odsCcgName"] = SourceExpressionConverter.ConvertO(odsCcgName);
                if (odsCcgCode != null)
                    callPayload.Queries["odsCcgCode"] = SourceExpressionConverter.ConvertO(odsCcgCode);
                if (onspdCcgName != null)
                    callPayload.Queries["onspdCcgName"] = SourceExpressionConverter.ConvertO(onspdCcgName);
                if (onspdCcgCode != null)
                    callPayload.Queries["onspdCcgCode"] = SourceExpressionConverter.ConvertO(onspdCcgCode);
                if (careHome != null)
                    callPayload.Queries["careHome"] = SourceExpressionConverter.ConvertO(careHome);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction ProviderDetails([WorkflowExpression] Func<string> providerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/providers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(providerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction LocationDetails([WorkflowExpression] Func<string> locationid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction LocationInspectionAreas([WorkflowExpression] Func<string> locationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/{0}/inspection-areas", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction LocationProviderInspectionArea([WorkflowExpression] Func<string> locationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/{0}/provider-inspection-areas", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction ProviderLocations([WorkflowExpression] Func<string> providerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/providers/{0}/locations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(providerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("CustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction ProviderInspectionAreas([WorkflowExpression] Func<string> providerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/providers/{0}/inspection-areas", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(providerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction Changes([WorkflowExpression] Func<string> organisationType, [WorkflowExpression] Func<string> startTimestamp, [WorkflowExpression] Func<string> endTimeStamp, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/changes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organisationType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["perPage"] = Convert.ToString(500);
                if (perPage != null)
                    callPayload.Queries["perPage"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["startTimestamp"] = SourceExpressionConverter.ConvertO(startTimestamp);
                callPayload.Queries["endTimeStamp"] = SourceExpressionConverter.ConvertO(endTimeStamp);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction InspectionAreas()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/inspection-areas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("CustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction MainReport([WorkflowExpression] Func<string> inspectionReportLinkId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reports/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inspectionReportLinkId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction ReportAndRelatedDoc([WorkflowExpression] Func<string> inspectionReportLinkId, [WorkflowExpression] Func<string> relatedDocumentType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reports/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inspectionReportLinkId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relatedDocumentType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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