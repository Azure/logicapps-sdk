//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cqcdata
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CqcdataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Providers(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> constituency = null, Expression<Func<string>> region = null, Expression<Func<string>> localAuthority = null, Expression<Func<string>> inspectionDirectorate = null, Expression<Func<string>> nonPrimaryInspectionCategoryCode = null, Expression<Func<string>> nonPrimaryInspectionCategoryName = null, Expression<Func<string>> primaryInspectionCategoryCode = null, Expression<Func<string>> primaryInspectionCategoryName = null, Expression<Func<string>> overallRating = null, Expression<Func<string>> regulatedActivity = null, Expression<Func<string>> reportType = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_constituency = WorkflowExpression.Compile(constituency, nameof(constituency), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_localAuthority = WorkflowExpression.Compile(localAuthority, nameof(localAuthority), required: false);
            var __workflow_inspectionDirectorate = WorkflowExpression.Compile(inspectionDirectorate, nameof(inspectionDirectorate), required: false);
            var __workflow_nonPrimaryInspectionCategoryCode = WorkflowExpression.Compile(nonPrimaryInspectionCategoryCode, nameof(nonPrimaryInspectionCategoryCode), required: false);
            var __workflow_nonPrimaryInspectionCategoryName = WorkflowExpression.Compile(nonPrimaryInspectionCategoryName, nameof(nonPrimaryInspectionCategoryName), required: false);
            var __workflow_primaryInspectionCategoryCode = WorkflowExpression.Compile(primaryInspectionCategoryCode, nameof(primaryInspectionCategoryCode), required: false);
            var __workflow_primaryInspectionCategoryName = WorkflowExpression.Compile(primaryInspectionCategoryName, nameof(primaryInspectionCategoryName), required: false);
            var __workflow_overallRating = WorkflowExpression.Compile(overallRating, nameof(overallRating), required: false);
            var __workflow_regulatedActivity = WorkflowExpression.Compile(regulatedActivity, nameof(regulatedActivity), required: false);
            var __workflow_reportType = WorkflowExpression.Compile(reportType, nameof(reportType), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/providers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["perPage"] = Convert.ToString(1000);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                if (__workflow_constituency != null)
                    callPayload.Queries["constituency"] = ExpressionConverter.Convert(__workflow_constituency);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_localAuthority != null)
                    callPayload.Queries["localAuthority"] = ExpressionConverter.Convert(__workflow_localAuthority);
                if (__workflow_inspectionDirectorate != null)
                    callPayload.Queries["inspectionDirectorate"] = ExpressionConverter.Convert(__workflow_inspectionDirectorate);
                if (__workflow_nonPrimaryInspectionCategoryCode != null)
                    callPayload.Queries["nonPrimaryInspectionCategoryCode"] = ExpressionConverter.Convert(__workflow_nonPrimaryInspectionCategoryCode);
                if (__workflow_nonPrimaryInspectionCategoryName != null)
                    callPayload.Queries["nonPrimaryInspectionCategoryName"] = ExpressionConverter.Convert(__workflow_nonPrimaryInspectionCategoryName);
                if (__workflow_primaryInspectionCategoryCode != null)
                    callPayload.Queries["primaryInspectionCategoryCode"] = ExpressionConverter.Convert(__workflow_primaryInspectionCategoryCode);
                if (__workflow_primaryInspectionCategoryName != null)
                    callPayload.Queries["primaryInspectionCategoryName"] = ExpressionConverter.Convert(__workflow_primaryInspectionCategoryName);
                if (__workflow_overallRating != null)
                    callPayload.Queries["overallRating"] = ExpressionConverter.Convert(__workflow_overallRating);
                if (__workflow_regulatedActivity != null)
                    callPayload.Queries["regulatedActivity"] = ExpressionConverter.Convert(__workflow_regulatedActivity);
                if (__workflow_reportType != null)
                    callPayload.Queries["reportType"] = ExpressionConverter.Convert(__workflow_reportType);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Locations(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string[]>> reportType = null, Expression<Func<string[]>> regulatedActivity = null, Expression<Func<string>> region = null, Expression<Func<string>> overallRating = null, Expression<Func<string>> primaryInspectionCategoryName = null, Expression<Func<string>> primaryInspectionCategoryCode = null, Expression<Func<string>> nonPrimaryInspectionCategoryName = null, Expression<Func<string>> nonPrimaryInspectionCategoryCode = null, Expression<Func<string>> inspectionDirectorate = null, Expression<Func<string>> localAuthority = null, Expression<Func<string>> constituency = null, Expression<Func<string>> gacServiceTypeDescription = null, Expression<Func<string>> odsCcgName = null, Expression<Func<string[]>> odsCcgCode = null, Expression<Func<string>> onspdCcgName = null, Expression<Func<string>> onspdCcgCode = null, Expression<Func<string>> careHome = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_reportType = WorkflowExpression.Compile(reportType, nameof(reportType), required: false);
            var __workflow_regulatedActivity = WorkflowExpression.Compile(regulatedActivity, nameof(regulatedActivity), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_overallRating = WorkflowExpression.Compile(overallRating, nameof(overallRating), required: false);
            var __workflow_primaryInspectionCategoryName = WorkflowExpression.Compile(primaryInspectionCategoryName, nameof(primaryInspectionCategoryName), required: false);
            var __workflow_primaryInspectionCategoryCode = WorkflowExpression.Compile(primaryInspectionCategoryCode, nameof(primaryInspectionCategoryCode), required: false);
            var __workflow_nonPrimaryInspectionCategoryName = WorkflowExpression.Compile(nonPrimaryInspectionCategoryName, nameof(nonPrimaryInspectionCategoryName), required: false);
            var __workflow_nonPrimaryInspectionCategoryCode = WorkflowExpression.Compile(nonPrimaryInspectionCategoryCode, nameof(nonPrimaryInspectionCategoryCode), required: false);
            var __workflow_inspectionDirectorate = WorkflowExpression.Compile(inspectionDirectorate, nameof(inspectionDirectorate), required: false);
            var __workflow_localAuthority = WorkflowExpression.Compile(localAuthority, nameof(localAuthority), required: false);
            var __workflow_constituency = WorkflowExpression.Compile(constituency, nameof(constituency), required: false);
            var __workflow_gacServiceTypeDescription = WorkflowExpression.Compile(gacServiceTypeDescription, nameof(gacServiceTypeDescription), required: false);
            var __workflow_odsCcgName = WorkflowExpression.Compile(odsCcgName, nameof(odsCcgName), required: false);
            var __workflow_odsCcgCode = WorkflowExpression.Compile(odsCcgCode, nameof(odsCcgCode), required: false);
            var __workflow_onspdCcgName = WorkflowExpression.Compile(onspdCcgName, nameof(onspdCcgName), required: false);
            var __workflow_onspdCcgCode = WorkflowExpression.Compile(onspdCcgCode, nameof(onspdCcgCode), required: false);
            var __workflow_careHome = WorkflowExpression.Compile(careHome, nameof(careHome), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["perPage"] = Convert.ToString(1000);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                if (__workflow_reportType != null)
                    callPayload.Queries["reportType"] = ExpressionConverter.Convert(__workflow_reportType);
                if (__workflow_regulatedActivity != null)
                    callPayload.Queries["regulatedActivity"] = ExpressionConverter.Convert(__workflow_regulatedActivity);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_overallRating != null)
                    callPayload.Queries["overallRating"] = ExpressionConverter.Convert(__workflow_overallRating);
                if (__workflow_primaryInspectionCategoryName != null)
                    callPayload.Queries["primaryInspectionCategoryName"] = ExpressionConverter.Convert(__workflow_primaryInspectionCategoryName);
                if (__workflow_primaryInspectionCategoryCode != null)
                    callPayload.Queries["primaryInspectionCategoryCode"] = ExpressionConverter.Convert(__workflow_primaryInspectionCategoryCode);
                if (__workflow_nonPrimaryInspectionCategoryName != null)
                    callPayload.Queries["nonPrimaryInspectionCategoryName"] = ExpressionConverter.Convert(__workflow_nonPrimaryInspectionCategoryName);
                if (__workflow_nonPrimaryInspectionCategoryCode != null)
                    callPayload.Queries["nonPrimaryInspectionCategoryCode"] = ExpressionConverter.Convert(__workflow_nonPrimaryInspectionCategoryCode);
                if (__workflow_inspectionDirectorate != null)
                    callPayload.Queries["inspectionDirectorate"] = ExpressionConverter.Convert(__workflow_inspectionDirectorate);
                if (__workflow_localAuthority != null)
                    callPayload.Queries["localAuthority"] = ExpressionConverter.Convert(__workflow_localAuthority);
                if (__workflow_constituency != null)
                    callPayload.Queries["constituency"] = ExpressionConverter.Convert(__workflow_constituency);
                if (__workflow_gacServiceTypeDescription != null)
                    callPayload.Queries["gacServiceTypeDescription"] = ExpressionConverter.Convert(__workflow_gacServiceTypeDescription);
                if (__workflow_odsCcgName != null)
                    callPayload.Queries["odsCcgName"] = ExpressionConverter.Convert(__workflow_odsCcgName);
                if (__workflow_odsCcgCode != null)
                    callPayload.Queries["odsCcgCode"] = ExpressionConverter.Convert(__workflow_odsCcgCode);
                if (__workflow_onspdCcgName != null)
                    callPayload.Queries["onspdCcgName"] = ExpressionConverter.Convert(__workflow_onspdCcgName);
                if (__workflow_onspdCcgCode != null)
                    callPayload.Queries["onspdCcgCode"] = ExpressionConverter.Convert(__workflow_onspdCcgCode);
                if (__workflow_careHome != null)
                    callPayload.Queries["careHome"] = ExpressionConverter.Convert(__workflow_careHome);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProviderDetails(Expression<Func<string>> providerId)
        {
            var __workflow_providerId = WorkflowExpression.Compile(providerId, nameof(providerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/providers/{0}", __workflow_providerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LocationDetails(Expression<Func<string>> locationid)
        {
            var __workflow_locationid = WorkflowExpression.Compile(locationid, nameof(locationid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}", __workflow_locationid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LocationInspectionAreas(Expression<Func<string>> locationId)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}/inspection-areas", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LocationProviderInspectionArea(Expression<Func<string>> locationId)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}/provider-inspection-areas", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProviderLocations(Expression<Func<string>> providerId)
        {
            var __workflow_providerId = WorkflowExpression.Compile(providerId, nameof(providerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/providers/{0}/locations", __workflow_providerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("CustomConnector");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProviderInspectionAreas(Expression<Func<string>> providerId)
        {
            var __workflow_providerId = WorkflowExpression.Compile(providerId, nameof(providerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/providers/{0}/inspection-areas", __workflow_providerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Changes(Expression<Func<string>> organisationType, Expression<Func<string>> startTimestamp, Expression<Func<string>> endTimeStamp, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_organisationType = WorkflowExpression.Compile(organisationType, nameof(organisationType), required: true);
            var __workflow_startTimestamp = WorkflowExpression.Compile(startTimestamp, nameof(startTimestamp), required: true);
            var __workflow_endTimeStamp = WorkflowExpression.Compile(endTimeStamp, nameof(endTimeStamp), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/changes/{0}", __workflow_organisationType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["perPage"] = Convert.ToString(500);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                callPayload.Queries["startTimestamp"] = ExpressionConverter.Convert(__workflow_startTimestamp);
                callPayload.Queries["endTimeStamp"] = ExpressionConverter.Convert(__workflow_endTimeStamp);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> InspectionAreas()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/inspection-areas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("CustomConnector");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MainReport(Expression<Func<string>> inspectionReportLinkId)
        {
            var __workflow_inspectionReportLinkId = WorkflowExpression.Compile(inspectionReportLinkId, nameof(inspectionReportLinkId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reports/{0}", __workflow_inspectionReportLinkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cqcdata")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReportAndRelatedDoc(Expression<Func<string>> inspectionReportLinkId, Expression<Func<string>> relatedDocumentType)
        {
            var __workflow_inspectionReportLinkId = WorkflowExpression.Compile(inspectionReportLinkId, nameof(inspectionReportLinkId), required: true);
            var __workflow_relatedDocumentType = WorkflowExpression.Compile(relatedDocumentType, nameof(relatedDocumentType), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reports/{0}/{1}", __workflow_inspectionReportLinkId.WithUrlEncoding(1), __workflow_relatedDocumentType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["partnerCode"] = Convert.ToString("PowerAppsCustomConnector");
                return new ApiConnectionAction(callPayload);
            });
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