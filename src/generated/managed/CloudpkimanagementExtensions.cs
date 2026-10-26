//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudpkimanagement
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudpkimanagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryCertificatesResponseItem[], ApiConnectionActionConfiguration> QueryCertificates(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<timevalidInput>> timevalid = null, Expression<Func<string>> important = null, Expression<Func<string>> renewalstatus = null, Expression<Func<int>> expiring = null, Expression<Func<string>> subject = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> serialnumber = null, Expression<Func<string>> ski = null, Expression<Func<string>> aki = null, Expression<Func<string>> keytype = null, Expression<Func<int>> keylength = null, Expression<Func<string>> owneremail = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_timevalid = WorkflowExpression.Compile(timevalid, nameof(timevalid), required: false);
            var __workflow_important = WorkflowExpression.Compile(important, nameof(important), required: false);
            var __workflow_renewalstatus = WorkflowExpression.Compile(renewalstatus, nameof(renewalstatus), required: false);
            var __workflow_expiring = WorkflowExpression.Compile(expiring, nameof(expiring), required: false);
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_serialnumber = WorkflowExpression.Compile(serialnumber, nameof(serialnumber), required: false);
            var __workflow_ski = WorkflowExpression.Compile(ski, nameof(ski), required: false);
            var __workflow_aki = WorkflowExpression.Compile(aki, nameof(aki), required: false);
            var __workflow_keytype = WorkflowExpression.Compile(keytype, nameof(keytype), required: false);
            var __workflow_keylength = WorkflowExpression.Compile(keylength, nameof(keylength), required: false);
            var __workflow_owneremail = WorkflowExpression.Compile(owneremail, nameof(owneremail), required: false);
            return new DeferredBodyAction<QueryCertificatesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/certificates", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timevalid != null)
                    callPayload.Queries["timevalid"] = ExpressionConverter.Convert(__workflow_timevalid);
                if (__workflow_important != null)
                    callPayload.Queries["important"] = ExpressionConverter.Convert(__workflow_important);
                if (__workflow_renewalstatus != null)
                    callPayload.Queries["renewalstatus"] = ExpressionConverter.Convert(__workflow_renewalstatus);
                if (__workflow_expiring != null)
                    callPayload.Queries["expiring"] = ExpressionConverter.Convert(__workflow_expiring);
                if (__workflow_subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(__workflow_subject);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_serialnumber != null)
                    callPayload.Queries["serialnumber"] = ExpressionConverter.Convert(__workflow_serialnumber);
                if (__workflow_ski != null)
                    callPayload.Queries["ski"] = ExpressionConverter.Convert(__workflow_ski);
                if (__workflow_aki != null)
                    callPayload.Queries["aki"] = ExpressionConverter.Convert(__workflow_aki);
                if (__workflow_keytype != null)
                    callPayload.Queries["keytype"] = ExpressionConverter.Convert(__workflow_keytype);
                if (__workflow_keylength != null)
                    callPayload.Queries["keylength"] = ExpressionConverter.Convert(__workflow_keylength);
                if (__workflow_owneremail != null)
                    callPayload.Queries["owneremail"] = ExpressionConverter.Convert(__workflow_owneremail);
                return new ApiConnectionAction<QueryCertificatesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetCertificateResponse, ApiConnectionActionConfiguration> GetCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> thumbprint)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_thumbprint = WorkflowExpression.Compile(thumbprint, nameof(thumbprint), required: true);
            return new DeferredBodyAction<GetCertificateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/certificates/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_thumbprint.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateCertificateResponse, ApiConnectionActionConfiguration> UpdateCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> thumbprint, Expression<Func<powerappsInput>> powerapps, Expression<Func<UpdateCertificateInput>> body = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_thumbprint = WorkflowExpression.Compile(thumbprint, nameof(thumbprint), required: true);
            var __workflow_powerapps = WorkflowExpression.Compile(powerapps, nameof(powerapps), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateCertificateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/certificates/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_thumbprint.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetTemplateResponse, ApiConnectionActionConfiguration> GetTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> templateid)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_templateid = WorkflowExpression.Compile(templateid, nameof(templateid), required: true);
            return new DeferredBodyAction<GetTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/templates/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_templateid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateTemplateResponse, ApiConnectionActionConfiguration> UpdateTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> templateid, Expression<Func<powerappsInput>> powerapps, Expression<Func<UpdateTemplateInput>> body = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_templateid = WorkflowExpression.Compile(templateid, nameof(templateid), required: true);
            var __workflow_powerapps = WorkflowExpression.Compile(powerapps, nameof(powerapps), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/templates/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_templateid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryTemplatesResponseItem[], ApiConnectionActionConfiguration> QueryTemplates(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<statusInput>> status = null, Expression<Func<typeInput>> type = null, Expression<Func<versionInput>> version = null, Expression<Func<string>> templateoid = null, Expression<Func<keytypeInput>> keytype = null, Expression<Func<int>> minMinkeylength = null, Expression<Func<int>> maxMinkeylength = null, Expression<Func<int>> minValidity = null, Expression<Func<int>> maxValidity = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: false);
            var __workflow_templateoid = WorkflowExpression.Compile(templateoid, nameof(templateoid), required: false);
            var __workflow_keytype = WorkflowExpression.Compile(keytype, nameof(keytype), required: false);
            var __workflow_minMinkeylength = WorkflowExpression.Compile(minMinkeylength, nameof(minMinkeylength), required: false);
            var __workflow_maxMinkeylength = WorkflowExpression.Compile(maxMinkeylength, nameof(maxMinkeylength), required: false);
            var __workflow_minValidity = WorkflowExpression.Compile(minValidity, nameof(minValidity), required: false);
            var __workflow_maxValidity = WorkflowExpression.Compile(maxValidity, nameof(maxValidity), required: false);
            return new DeferredBodyAction<QueryTemplatesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/templates", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                if (__workflow_templateoid != null)
                    callPayload.Queries["templateoid"] = ExpressionConverter.Convert(__workflow_templateoid);
                if (__workflow_keytype != null)
                    callPayload.Queries["keytype"] = ExpressionConverter.Convert(__workflow_keytype);
                if (__workflow_minMinkeylength != null)
                    callPayload.Queries["min-minkeylength"] = ExpressionConverter.Convert(__workflow_minMinkeylength);
                if (__workflow_maxMinkeylength != null)
                    callPayload.Queries["max-minkeylength"] = ExpressionConverter.Convert(__workflow_maxMinkeylength);
                if (__workflow_minValidity != null)
                    callPayload.Queries["min-validity"] = ExpressionConverter.Convert(__workflow_minValidity);
                if (__workflow_maxValidity != null)
                    callPayload.Queries["max-validity"] = ExpressionConverter.Convert(__workflow_maxValidity);
                return new ApiConnectionAction<QueryTemplatesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetCRLResponse, ApiConnectionActionConfiguration> GetCRL(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> crlid)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_crlid = WorkflowExpression.Compile(crlid, nameof(crlid), required: true);
            return new DeferredBodyAction<GetCRLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/crls/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_crlid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCRLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryCRLsResponseItem[], ApiConnectionActionConfiguration> QueryCRLs(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> crlid = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> issued = null, Expression<Func<int>> expiring = null, Expression<Func<string>> crlnumber = null, Expression<Func<string>> crlnumberdecimal = null, Expression<Func<string>> aki = null, Expression<Func<string>> serialnumber = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_crlid = WorkflowExpression.Compile(crlid, nameof(crlid), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_issued = WorkflowExpression.Compile(issued, nameof(issued), required: false);
            var __workflow_expiring = WorkflowExpression.Compile(expiring, nameof(expiring), required: false);
            var __workflow_crlnumber = WorkflowExpression.Compile(crlnumber, nameof(crlnumber), required: false);
            var __workflow_crlnumberdecimal = WorkflowExpression.Compile(crlnumberdecimal, nameof(crlnumberdecimal), required: false);
            var __workflow_aki = WorkflowExpression.Compile(aki, nameof(aki), required: false);
            var __workflow_serialnumber = WorkflowExpression.Compile(serialnumber, nameof(serialnumber), required: false);
            return new DeferredBodyAction<QueryCRLsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/crls", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_crlid != null)
                    callPayload.Queries["crlid"] = ExpressionConverter.Convert(__workflow_crlid);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_issued != null)
                    callPayload.Queries["issued"] = ExpressionConverter.Convert(__workflow_issued);
                if (__workflow_expiring != null)
                    callPayload.Queries["expiring"] = ExpressionConverter.Convert(__workflow_expiring);
                if (__workflow_crlnumber != null)
                    callPayload.Queries["crlnumber"] = ExpressionConverter.Convert(__workflow_crlnumber);
                if (__workflow_crlnumberdecimal != null)
                    callPayload.Queries["crlnumberdecimal"] = ExpressionConverter.Convert(__workflow_crlnumberdecimal);
                if (__workflow_aki != null)
                    callPayload.Queries["aki"] = ExpressionConverter.Convert(__workflow_aki);
                if (__workflow_serialnumber != null)
                    callPayload.Queries["serialnumber"] = ExpressionConverter.Convert(__workflow_serialnumber);
                return new ApiConnectionAction<QueryCRLsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryRequestsResponseItem[], ApiConnectionActionConfiguration> QueryRequests(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<statusInput>> status = null, Expression<Func<string>> source = null, Expression<Func<string>> approverid = null, Expression<Func<string>> approveremail = null, Expression<Func<string>> submitterid = null, Expression<Func<string>> submitteremail = null, Expression<Func<string>> owneremail = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_approverid = WorkflowExpression.Compile(approverid, nameof(approverid), required: false);
            var __workflow_approveremail = WorkflowExpression.Compile(approveremail, nameof(approveremail), required: false);
            var __workflow_submitterid = WorkflowExpression.Compile(submitterid, nameof(submitterid), required: false);
            var __workflow_submitteremail = WorkflowExpression.Compile(submitteremail, nameof(submitteremail), required: false);
            var __workflow_owneremail = WorkflowExpression.Compile(owneremail, nameof(owneremail), required: false);
            return new DeferredBodyAction<QueryRequestsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/requests", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_approverid != null)
                    callPayload.Queries["approverid"] = ExpressionConverter.Convert(__workflow_approverid);
                if (__workflow_approveremail != null)
                    callPayload.Queries["approveremail"] = ExpressionConverter.Convert(__workflow_approveremail);
                if (__workflow_submitterid != null)
                    callPayload.Queries["submitterid"] = ExpressionConverter.Convert(__workflow_submitterid);
                if (__workflow_submitteremail != null)
                    callPayload.Queries["submitteremail"] = ExpressionConverter.Convert(__workflow_submitteremail);
                if (__workflow_owneremail != null)
                    callPayload.Queries["owneremail"] = ExpressionConverter.Convert(__workflow_owneremail);
                return new ApiConnectionAction<QueryRequestsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<NewRequestResponse, ApiConnectionActionConfiguration> NewRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<powerappsInput>> powerapps, Expression<Func<NewRequestInput>> body = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_powerapps = WorkflowExpression.Compile(powerapps, nameof(powerapps), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<NewRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/requests", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NewRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetRequestResponse, ApiConnectionActionConfiguration> GetRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> requestid)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_requestid = WorkflowExpression.Compile(requestid, nameof(requestid), required: true);
            return new DeferredBodyAction<GetRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/requests/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_requestid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateRequestResponse, ApiConnectionActionConfiguration> UpdateRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> requestid, Expression<Func<powerappsInput>> powerapps, Expression<Func<UpdateRequestInput>> body = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_requestid = WorkflowExpression.Compile(requestid, nameof(requestid), required: true);
            var __workflow_powerapps = WorkflowExpression.Compile(powerapps, nameof(powerapps), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/requests/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_requestid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryHooksResponseItem[], ApiConnectionActionConfiguration> QueryHooks(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<statusInput>> status = null, Expression<Func<typeInput>> type = null, Expression<Func<@eventInput>> @event = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_event = WorkflowExpression.Compile(@event, nameof(@event), required: false);
            return new DeferredBodyAction<QueryHooksResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_event != null)
                    callPayload.Queries["event"] = ExpressionConverter.Convert(__workflow_event);
                return new ApiConnectionAction<QueryHooksResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<NewHookResponse, ApiConnectionActionConfiguration> NewHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<powerappsInput>> powerapps, Expression<Func<NewHookInput>> body = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_powerapps = WorkflowExpression.Compile(powerapps, nameof(powerapps), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<NewHookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NewHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetHookResponse, ApiConnectionActionConfiguration> GetHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> hookid)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_hookid = WorkflowExpression.Compile(hookid, nameof(hookid), required: true);
            return new DeferredBodyAction<GetHookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_hookid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> hookid)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_hookid = WorkflowExpression.Compile(hookid, nameof(hookid), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_hookid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetPublishedCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> thumbprint)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_thumbprint = WorkflowExpression.Compile(thumbprint, nameof(thumbprint), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/published/certificates/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_thumbprint.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetPublishedTemplatesResponseItem[], ApiConnectionActionConfiguration> GetPublishedTemplates(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyAction<GetPublishedTemplatesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/published/templates", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPublishedTemplatesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetConnectorActionResponse, ApiConnectionActionConfiguration> GetConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> connectoractionid)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_connectoractionid = WorkflowExpression.Compile(connectoractionid, nameof(connectoractionid), required: true);
            return new DeferredBodyAction<GetConnectorActionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/connectoractions/{2}", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1), __workflow_connectoractionid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetConnectorActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetActionsResponseItem[], ApiConnectionActionConfiguration> GetActions(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyAction<GetActionsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/actions", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetActionsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetAuthentication()
        {
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/.auth/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class CloudpkimanagementTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AddedHookResponse, ApiConnectionTriggerConfiguration> AddedHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<AddedHookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<AddedHookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/added-hook", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<AddedHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RemovedHookResponse, ApiConnectionTriggerConfiguration> RemovedHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<RemovedHookInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<RemovedHookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/removed-hook", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<RemovedHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IssuedCertificateResponse, ApiConnectionTriggerConfiguration> IssuedCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<IssuedCertificateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<IssuedCertificateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/issued-certificate", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<IssuedCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RevokedCertificateResponse, ApiConnectionTriggerConfiguration> RevokedCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<RevokedCertificateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<RevokedCertificateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/revoked-certificate", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<RevokedCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UpdatedCertificateResponse, ApiConnectionTriggerConfiguration> UpdatedCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<UpdatedCertificateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<UpdatedCertificateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/updated-certificate", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<UpdatedCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ExpiringCertificateResponse, ApiConnectionTriggerConfiguration> ExpiringCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<ExpiringCertificateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ExpiringCertificateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/expiring-certificate", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ExpiringCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ExpiredCertificateResponse, ApiConnectionTriggerConfiguration> ExpiredCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<ExpiredCertificateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ExpiredCertificateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/expired-certificate", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ExpiredCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RenewingCertificateResponse, ApiConnectionTriggerConfiguration> RenewingCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<RenewingCertificateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<RenewingCertificateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/renewing-certificate", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<RenewingCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PendingRequestResponse, ApiConnectionTriggerConfiguration> PendingRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<PendingRequestInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<PendingRequestResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/pending-request", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<PendingRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ApprovedRequestResponse, ApiConnectionTriggerConfiguration> ApprovedRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<ApprovedRequestInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ApprovedRequestResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/approved-request", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ApprovedRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<DeniedRequestResponse, ApiConnectionTriggerConfiguration> DeniedRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<DeniedRequestInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<DeniedRequestResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/denied-request", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<DeniedRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UpdatedRequestResponse, ApiConnectionTriggerConfiguration> UpdatedRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<UpdatedRequestInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<UpdatedRequestResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/updated-request", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<UpdatedRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FailedRequestResponse, ApiConnectionTriggerConfiguration> FailedRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<FailedRequestInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<FailedRequestResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/failed-request", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<FailedRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PublishedTemplateResponse, ApiConnectionTriggerConfiguration> PublishedTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<PublishedTemplateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<PublishedTemplateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/published-template", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<PublishedTemplateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UnpublishedTemplateResponse, ApiConnectionTriggerConfiguration> UnpublishedTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<UnpublishedTemplateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<UnpublishedTemplateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/unpublished-template", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<UnpublishedTemplateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UpdatedTemplateResponse, ApiConnectionTriggerConfiguration> UpdatedTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<UpdatedTemplateInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<UpdatedTemplateResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/updated-template", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<UpdatedTemplateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IssuedCRLResponse, ApiConnectionTriggerConfiguration> IssuedCRL(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<IssuedCRLInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<IssuedCRLResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/issued-crl", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<IssuedCRLResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewConnectorActionResponse, ApiConnectionTriggerConfiguration> NewConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<NewConnectorActionInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NewConnectorActionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/new-connectoraction", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<NewConnectorActionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CompletedConnectorActionResponse, ApiConnectionTriggerConfiguration> CompletedConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<CompletedConnectorActionInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CompletedConnectorActionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/completed-action", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<CompletedConnectorActionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FailedConnectorActionResponse, ApiConnectionTriggerConfiguration> FailedConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<FailedConnectorActionInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<FailedConnectorActionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/failed-connectoraction", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<FailedConnectorActionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<StalledConnectorActionResponse, ApiConnectionTriggerConfiguration> StalledConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<StalledConnectorActionInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = WorkflowExpression.Compile(regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = WorkflowExpression.Compile(deploymentid, nameof(deploymentid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<StalledConnectorActionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/deployments/{1}/hooks/stalled-connectoraction", __workflow_regionid.WithUrlEncoding(1), __workflow_deploymentid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<StalledConnectorActionResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class QueryCertificatesResponseItem
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("thumbprint")]
        public string Thumbprint { get; set; }

        [JsonProperty("serialnumber")]
        public string Serialnumber { get; set; }

        [JsonProperty("validfrom")]
        public string Validfrom { get; set; }

        [JsonProperty("validto")]
        public string Validto { get; set; }

        [JsonProperty("validfromepoch")]
        public int Validfromepoch { get; set; }

        [JsonProperty("validtoepoch")]
        public int Validtoepoch { get; set; }

        [JsonProperty("issuername")]
        public string Issuername { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("subjectalternativename")]
        public string[] Subjectalternativename { get; set; }

        [JsonProperty("displaysubject")]
        public string Displaysubject { get; set; }

        [JsonProperty("templatename")]
        public string Templatename { get; set; }

        [JsonProperty("cloudpki")]
        public QueryCertificatesResponseItemCloudpkiType Cloudpki { get; set; }
    }

    public class QueryCertificatesResponseItemCloudpkiType
    {
        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("owneremail")]
        public string[] Owneremail { get; set; }

        [JsonProperty("renewalstatus")]
        public string Renewalstatus { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("important")]
        public string Important { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum timevalidInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        Enabled,
        Disabled
    }

    public class GetCertificateResponse
    {
        [JsonProperty("thumbprint")]
        public string Thumbprint { get; set; }

        [JsonProperty("serialnumber")]
        public string Serialnumber { get; set; }

        [JsonProperty("validfrom")]
        public string Validfrom { get; set; }

        [JsonProperty("validto")]
        public string Validto { get; set; }

        [JsonProperty("validfromepoch")]
        public int Validfromepoch { get; set; }

        [JsonProperty("validtoepoch")]
        public int Validtoepoch { get; set; }

        [JsonProperty("signaturealgorithm")]
        public string Signaturealgorithm { get; set; }

        [JsonProperty("subjectkeyidentifier")]
        public string Subjectkeyidentifier { get; set; }

        [JsonProperty("authoritykeyidentifier")]
        public string Authoritykeyidentifier { get; set; }

        [JsonProperty("templateoid")]
        public string Templateoid { get; set; }

        [JsonProperty("templatename")]
        public string Templatename { get; set; }

        [JsonProperty("keytype")]
        public string Keytype { get; set; }

        [JsonProperty("keysize")]
        public int Keysize { get; set; }

        [JsonProperty("keyusage")]
        public string[] Keyusage { get; set; }

        [JsonProperty("enhancedkeyusage")]
        public string[] Enhancedkeyusage { get; set; }

        [JsonProperty("issuername")]
        public string Issuername { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("subjectalternativename")]
        public string[] Subjectalternativename { get; set; }

        [JsonProperty("displaysubject")]
        public string Displaysubject { get; set; }

        [JsonProperty("cdp")]
        public string[] Cdp { get; set; }

        [JsonProperty("aia")]
        public string[] Aia { get; set; }

        [JsonProperty("basicconstraints")]
        public string[] Basicconstraints { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("publickey")]
        public string Publickey { get; set; }

        [JsonProperty("cloudpki")]
        public GetCertificateResponseCloudpkiType Cloudpki { get; set; }

        [JsonProperty("requestdetails")]
        public GetCertificateResponseRequestdetailsType Requestdetails { get; set; }
    }

    public class GetCertificateResponseCloudpkiType
    {
        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("requestid")]
        public string Requestid { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("important")]
        public string Important { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("owneremail")]
        public string[] Owneremail { get; set; }

        [JsonProperty("owneremailstring")]
        public string Owneremailstring { get; set; }

        [JsonProperty("renewalstatus")]
        public string Renewalstatus { get; set; }

        [JsonProperty("renewallastmodified")]
        public string Renewallastmodified { get; set; }

        [JsonProperty("renewallastmodifiedepoch")]
        public int Renewallastmodifiedepoch { get; set; }

        [JsonProperty("renewallastmodifiedid")]
        public string Renewallastmodifiedid { get; set; }

        [JsonProperty("renewallastmodifiedemail")]
        public string Renewallastmodifiedemail { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }

        [JsonProperty("lastmodifiedepoch")]
        public int Lastmodifiedepoch { get; set; }

        [JsonProperty("lastmodifiedid")]
        public string Lastmodifiedid { get; set; }

        [JsonProperty("lastmodifiedemail")]
        public string Lastmodifiedemail { get; set; }

        [JsonProperty("lastmodifiedevent")]
        public string Lastmodifiedevent { get; set; }

        [JsonProperty("revocationstatus")]
        public string Revocationstatus { get; set; }

        [JsonProperty("revocationlastmodified")]
        public string Revocationlastmodified { get; set; }

        [JsonProperty("revocationlastmodifiedepoch")]
        public string Revocationlastmodifiedepoch { get; set; }

        [JsonProperty("revocationlastmodifiedid")]
        public string Revocationlastmodifiedid { get; set; }

        [JsonProperty("revocationlastmodifiedemail")]
        public string Revocationlastmodifiedemail { get; set; }
    }

    public class GetCertificateResponseRequestdetailsType
    {
        [JsonProperty("carequestid")]
        public int Carequestid { get; set; }

        [JsonProperty("statusmessage")]
        public string Statusmessage { get; set; }

        [JsonProperty("submittedwhen")]
        public string Submittedwhen { get; set; }

        [JsonProperty("resolvedwhen")]
        public string Resolvedwhen { get; set; }

        [JsonProperty("revokedwhen")]
        public string Revokedwhen { get; set; }

        [JsonProperty("revokedeffectivewhen")]
        public string Revokedeffectivewhen { get; set; }

        [JsonProperty("revokedreason")]
        public int Revokedreason { get; set; }

        [JsonProperty("requestername")]
        public string Requestername { get; set; }

        [JsonProperty("callername")]
        public string Callername { get; set; }

        [JsonProperty("requestosversion")]
        public string Requestosversion { get; set; }

        [JsonProperty("requestcspprovider")]
        public string Requestcspprovider { get; set; }
    }

    public class UpdateCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("connectoractionid")]
        public string Connectoractionid { get; set; }

        [JsonProperty("thumbprint")]
        public string Thumbprint { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum powerappsInput
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class UpdateCertificateInput
    {
        [JsonProperty("important")]
        public UpdateCertificateInputImportantType? Important { get; set; }

        [JsonProperty("status")]
        public UpdateCertificateInputStatusType? Status { get; set; }

        [JsonProperty("renewalstatus")]
        public UpdateCertificateInputRenewalstatusType? Renewalstatus { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("owneremail")]
        public string Owneremail { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateCertificateInputImportantType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateCertificateInputStatusType
    {
        Revoked,
        Unrevoked
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateCertificateInputRenewalstatusType
    {
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "denied")]
        Denied,
        [EnumMember(Value = "none")]
        None
    }

    public class GetTemplateResponse
    {
        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayname")]
        public string Displayname { get; set; }

        [JsonProperty("distinguishedname")]
        public string Distinguishedname { get; set; }

        [JsonProperty("objectguid")]
        public string Objectguid { get; set; }

        [JsonProperty("forestrootdn")]
        public string Forestrootdn { get; set; }

        [JsonProperty("forestrootfqdn")]
        public string Forestrootfqdn { get; set; }

        [JsonProperty("whencreated")]
        public string Whencreated { get; set; }

        [JsonProperty("whenchanged")]
        public string Whenchanged { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("publishedby")]
        public string[] Publishedby { get; set; }

        [JsonProperty("templateoid")]
        public string Templateoid { get; set; }

        [JsonProperty("templateversion")]
        public int Templateversion { get; set; }

        [JsonProperty("majorversion")]
        public int Majorversion { get; set; }

        [JsonProperty("minorversion")]
        public int Minorversion { get; set; }

        [JsonProperty("templatetype")]
        public string Templatetype { get; set; }

        [JsonProperty("validityperiod")]
        public int Validityperiod { get; set; }

        [JsonProperty("renewalperiod")]
        public int Renewalperiod { get; set; }

        [JsonProperty("defaultkeyspec")]
        public int Defaultkeyspec { get; set; }

        [JsonProperty("defaultkeyspecdecoded")]
        public string Defaultkeyspecdecoded { get; set; }

        [JsonProperty("basickeyusage")]
        public int Basickeyusage { get; set; }

        [JsonProperty("basickeyusagedecoded")]
        public GetTemplateResponseBasickeyusagedecodedType Basickeyusagedecoded { get; set; }

        [JsonProperty("enhancedkeyusage")]
        public string[] Enhancedkeyusage { get; set; }

        [JsonProperty("criticalextensions")]
        public string[] Criticalextensions { get; set; }

        [JsonProperty("minimumkeysize")]
        public int Minimumkeysize { get; set; }

        [JsonProperty("defaultcsps")]
        public string[] Defaultcsps { get; set; }

        [JsonProperty("maxdepth")]
        public int Maxdepth { get; set; }

        [JsonProperty("supersededtemplates")]
        public string[] Supersededtemplates { get; set; }

        [JsonProperty("issuancepolicy")]
        public string[] Issuancepolicy { get; set; }

        [JsonProperty("applicationpolicy")]
        public string[] Applicationpolicy { get; set; }

        [JsonProperty("rasignaturecount")]
        public int Rasignaturecount { get; set; }

        [JsonProperty("rasignatureissuancepolicies")]
        public string[] Rasignatureissuancepolicies { get; set; }

        [JsonProperty("templateflags")]
        public int Templateflags { get; set; }

        [JsonProperty("templateflagsdecoded")]
        public GetTemplateResponseTemplateflagsdecodedType Templateflagsdecoded { get; set; }

        [JsonProperty("enrollmentflags")]
        public int Enrollmentflags { get; set; }

        [JsonProperty("enrollmentflagsdecoded")]
        public GetTemplateResponseEnrollmentflagsdecodedType Enrollmentflagsdecoded { get; set; }

        [JsonProperty("certificatenameflags")]
        public int Certificatenameflags { get; set; }

        [JsonProperty("certificatenameflagsdecoded")]
        public GetTemplateResponseCertificatenameflagsdecodedType Certificatenameflagsdecoded { get; set; }

        [JsonProperty("privatekeyflags")]
        public int Privatekeyflags { get; set; }

        [JsonProperty("privatekeyflagsdecoded")]
        public GetTemplateResponsePrivatekeyflagsdecodedType Privatekeyflagsdecoded { get; set; }

        [JsonProperty("rasignatureapplicationpolicy")]
        public string Rasignatureapplicationpolicy { get; set; }

        [JsonProperty("keytype")]
        public string Keytype { get; set; }

        [JsonProperty("cloudpki")]
        public GetTemplateResponseCloudpkiType Cloudpki { get; set; }
    }

    public class GetTemplateResponseBasickeyusagedecodedType
    {
        public string KEYENCIPHERMENT { get; set; }
        public string NONREPUDIATION { get; set; }
        public string KEYAGREEMENT { get; set; }
        public string DIGITALSIGNATURE { get; set; }
        public string DATAENCIPHERMENT { get; set; }
        public string KEYCERTSIGN { get; set; }
        public string CRLSIGN { get; set; }
    }

    public class GetTemplateResponseTemplateflagsdecodedType
    {
        public string PRIVATEKEYEXPORTABLE { get; set; }
        public string ENABLEAUTOENROLLMENT { get; set; }
        public string ISCOMPUTERCERT { get; set; }
        public string ISCROSSCA { get; set; }
        public string ISCA { get; set; }
        public string PUBLISHTOREQUESTERUSEROBJECT { get; set; }
        public string ISEDITABLE { get; set; }
        public string DONOTPERSISTINDB { get; set; }
        public string ADDDETAILSTOCERT { get; set; }
        public string ADDEMAIL { get; set; }
        public string ISDEFAULT { get; set; }
    }

    public class GetTemplateResponseEnrollmentflagsdecodedType
    {
        public string ENABLEKEYREUSEONNTTOKENKEYSETSTORAGEFULL { get; set; }
        public string EXCLUDECRLDETAILSINCERT { get; set; }

        [JsonProperty("PREVIOUSAPPROVALVALIDATEREENROLLMENT")]
        public string PREVIOUSAPPROVALVALIdATEREENROLLMENT { get; set; }
        public string AUTOENROLLMENTCHECKUSERDSCERTIFICATE { get; set; }
        public string INCLUDEBASICCONSTRAINTSFOREECERTS { get; set; }

        [JsonProperty("REMOVEINVALIDCERTIFICATEFROMPERSONALSTORE")]
        public string REMOVEINVALIdCERTIFICATEFROMPERSONALSTORE { get; set; }
        public string EXCLUDEOCSPDETAILSINCERT { get; set; }
        public string ALLOWISSUANCEPOLICIESFROMREQUEST { get; set; }
        public string AUTOENROLLMENT { get; set; }
        public string PUBLISHTODS { get; set; }
        public string ALLOWENROLLONBEHALFOF { get; set; }
        public string ALLOWKEYBASEDRENEWAL { get; set; }
        public string PUBLISHTOKRACONTAINER { get; set; }
        public string USERINTERACTIONREQUIRED { get; set; }
        public string CERTMGRAPPROVALREQUIRED { get; set; }
        public string INCLUDESYMETRICALGORITHMS { get; set; }
    }

    public class GetTemplateResponseCertificatenameflagsdecodedType
    {
        public string SUBJECTREQUIREDNSASCN { get; set; }
        public string SUBJECTALTREQUIREEMAIL { get; set; }
        public string SUBJECTREQUIREEMAIL { get; set; }
        public string SUBJECTALTREQUIREDNS { get; set; }
        public string SUBJECTALTREQUIREDOMAINDNS { get; set; }
        public string ENROLEESUPLIESSUBJECTALTNAME { get; set; }
        public string OLDCERTSUPPLIESSUBJECTANDALTNAME { get; set; }
        public string SUBJECTALTREQUIREUPN { get; set; }
        public string SUBJECTALTREQUIREDIRECTORYGUID { get; set; }
        public string SUBJECTREQUIRECOMMONNAME { get; set; }
        public string SUBJECTALTREQUIRESPN { get; set; }
        public string ENROLEESUPLIESSUBJECT { get; set; }
        public string SUBJECTREQUIREDIRECTORYPATH { get; set; }
    }

    public class GetTemplateResponsePrivatekeyflagsdecodedType
    {
        public string REQUIREALTERNATESIGNATUREALGORITHM { get; set; }
        public string EXPORTABLEKEY { get; set; }
        public string REQUIRESAMEKEYRENEWAL { get; set; }

        [JsonProperty("EKVALIDATECERT")]
        public string EKVALIdATECERT { get; set; }

        [JsonProperty("EKVALIDATEKEY")]
        public string EKVALIdATEKEY { get; set; }
        public string STRONGKEYPROTECTIONREQUIRED { get; set; }
        public string ATTESTATIONWITHOUTPOLICY { get; set; }
        public string EKTRUSTONUSE { get; set; }
        public string ATTESTREQUIRED { get; set; }

        [JsonProperty("USELEGACYPROVIDER")]
        public string USELEGACYPROVIdER { get; set; }
        public string ATTESTPREFERRED { get; set; }
        public string REQUIREPRIVATEKEYARCHIVAL { get; set; }
        public string ATTESTNONE { get; set; }
    }

    public class GetTemplateResponseCloudpkiType
    {
        [JsonProperty("important")]
        public string Important { get; set; }

        [JsonProperty("owneremail")]
        public string[] Owneremail { get; set; }

        [JsonProperty("owneremailstring")]
        public string Owneremailstring { get; set; }

        [JsonProperty("autoapproveid")]
        public string[] Autoapproveid { get; set; }

        [JsonProperty("autoapproveidstring")]
        public string Autoapproveidstring { get; set; }

        [JsonProperty("hidden")]
        public string Hidden { get; set; }

        [JsonProperty("renewalstatus")]
        public string Renewalstatus { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }

        [JsonProperty("lastmodifiedepoch")]
        public int Lastmodifiedepoch { get; set; }

        [JsonProperty("lastmodifiedid")]
        public string Lastmodifiedid { get; set; }

        [JsonProperty("lastmodifiedemail")]
        public string Lastmodifiedemail { get; set; }

        [JsonProperty("lastmodifiedevent")]
        public string Lastmodifiedevent { get; set; }
    }

    public class UpdateTemplateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }
    }

    public class UpdateTemplateInput
    {
        [JsonProperty("important")]
        public UpdateTemplateInputImportantType? Important { get; set; }

        [JsonProperty("renewalstatus")]
        public UpdateTemplateInputRenewalstatusType? Renewalstatus { get; set; }

        [JsonProperty("hidden")]
        public UpdateTemplateInputHiddenType? Hidden { get; set; }

        [JsonProperty("owneremail")]
        public string Owneremail { get; set; }

        [JsonProperty("autoapproveid")]
        public string Autoapproveid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTemplateInputImportantType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTemplateInputRenewalstatusType
    {
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "denied")]
        Denied,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateTemplateInputHiddenType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class QueryTemplatesResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayname")]
        public string Displayname { get; set; }

        [JsonProperty("distinguishedname")]
        public string Distinguishedname { get; set; }

        [JsonProperty("objectguid")]
        public string Objectguid { get; set; }

        [JsonProperty("forestrootdn")]
        public string Forestrootdn { get; set; }

        [JsonProperty("forestrootfqdn")]
        public string Forestrootfqdn { get; set; }

        [JsonProperty("whencreated")]
        public string Whencreated { get; set; }

        [JsonProperty("whenchanged")]
        public string Whenchanged { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("publishedby")]
        public string[] Publishedby { get; set; }

        [JsonProperty("templateoid")]
        public string Templateoid { get; set; }

        [JsonProperty("templateversion")]
        public int Templateversion { get; set; }

        [JsonProperty("majorversion")]
        public int Majorversion { get; set; }

        [JsonProperty("minorversion")]
        public int Minorversion { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("templatetype")]
        public string Templatetype { get; set; }

        [JsonProperty("validityperiod")]
        public int Validityperiod { get; set; }

        [JsonProperty("renewalperiod")]
        public int Renewalperiod { get; set; }

        [JsonProperty("defaultkeyspec")]
        public int Defaultkeyspec { get; set; }

        [JsonProperty("basickeyusage")]
        public int Basickeyusage { get; set; }

        [JsonProperty("basickeyusagedecoded")]
        public QueryTemplatesResponseItemBasickeyusagedecodedType Basickeyusagedecoded { get; set; }

        [JsonProperty("enhancedkeyusage")]
        public string[] Enhancedkeyusage { get; set; }

        [JsonProperty("criticalextensions")]
        public string[] Criticalextensions { get; set; }

        [JsonProperty("minimumkeysize")]
        public int Minimumkeysize { get; set; }

        [JsonProperty("defaultcsps")]
        public string[] Defaultcsps { get; set; }

        [JsonProperty("maxdepth")]
        public int Maxdepth { get; set; }

        [JsonProperty("supersededtemplates")]
        public string[] Supersededtemplates { get; set; }

        [JsonProperty("issuancepolicy")]
        public string[] Issuancepolicy { get; set; }

        [JsonProperty("applicationpolicy")]
        public string[] Applicationpolicy { get; set; }

        [JsonProperty("rasignaturecount")]
        public int Rasignaturecount { get; set; }

        [JsonProperty("rasignatureissuancepolicies")]
        public string[] Rasignatureissuancepolicies { get; set; }

        [JsonProperty("templateflags")]
        public int Templateflags { get; set; }

        [JsonProperty("templateflagsdecoded")]
        public QueryTemplatesResponseItemTemplateflagsdecodedType Templateflagsdecoded { get; set; }

        [JsonProperty("enrollmentflags")]
        public int Enrollmentflags { get; set; }

        [JsonProperty("enrollmentflagsdecoded")]
        public QueryTemplatesResponseItemEnrollmentflagsdecodedType Enrollmentflagsdecoded { get; set; }

        [JsonProperty("certificatenameflags")]
        public int Certificatenameflags { get; set; }

        [JsonProperty("certificatenameflagsdecoded")]
        public QueryTemplatesResponseItemCertificatenameflagsdecodedType Certificatenameflagsdecoded { get; set; }

        [JsonProperty("privatekeyflags")]
        public int Privatekeyflags { get; set; }

        [JsonProperty("privatekeyflagsdecoded")]
        public QueryTemplatesResponseItemPrivatekeyflagsdecodedType Privatekeyflagsdecoded { get; set; }

        [JsonProperty("rasignatureapplicationpolicy")]
        public string Rasignatureapplicationpolicy { get; set; }

        [JsonProperty("keytype")]
        public string Keytype { get; set; }

        [JsonProperty("defaultkeyspecdecoded")]
        public string Defaultkeyspecdecoded { get; set; }

        [JsonProperty("privatekeyasymmetricalgorithm")]
        public string Privatekeyasymmetricalgorithm { get; set; }

        [JsonProperty("requesthashalgorithm")]
        public string Requesthashalgorithm { get; set; }

        [JsonProperty("privatekeysecuritydescriptor")]
        public string Privatekeysecuritydescriptor { get; set; }

        [JsonProperty("privatekeyusage")]
        public string Privatekeyusage { get; set; }

        [JsonProperty("privatekeyusagedecoded")]
        public QueryTemplatesResponseItemPrivatekeyusagedecodedType Privatekeyusagedecoded { get; set; }

        [JsonProperty("keyarchivalsymmetricalgorithm")]
        public string Keyarchivalsymmetricalgorithm { get; set; }

        [JsonProperty("keyarchivalsymmetrickeylength")]
        public string Keyarchivalsymmetrickeylength { get; set; }

        [JsonProperty("cloudpki")]
        public QueryTemplatesResponseItemCloudpkiType Cloudpki { get; set; }
    }

    public class QueryTemplatesResponseItemBasickeyusagedecodedType
    {
        public string KEYENCIPHERMENT { get; set; }
        public string NONREPUDIATION { get; set; }
        public string KEYAGREEMENT { get; set; }
        public string DIGITALSIGNATURE { get; set; }
        public string DATAENCIPHERMENT { get; set; }
        public string KEYCERTSIGN { get; set; }
        public string CRLSIGN { get; set; }
    }

    public class QueryTemplatesResponseItemTemplateflagsdecodedType
    {
        public string PRIVATEKEYEXPORTABLE { get; set; }
        public string ENABLEAUTOENROLLMENT { get; set; }
        public string ISCOMPUTERCERT { get; set; }
        public string ISCROSSCA { get; set; }
        public string ISCA { get; set; }
        public string PUBLISHTOREQUESTERUSEROBJECT { get; set; }
        public string ISEDITABLE { get; set; }
        public string DONOTPERSISTINDB { get; set; }
        public string ADDDETAILSTOCERT { get; set; }
        public string ADDEMAIL { get; set; }
        public string ISDEFAULT { get; set; }
    }

    public class QueryTemplatesResponseItemEnrollmentflagsdecodedType
    {
        public string ENABLEKEYREUSEONNTTOKENKEYSETSTORAGEFULL { get; set; }
        public string EXCLUDECRLDETAILSINCERT { get; set; }

        [JsonProperty("PREVIOUSAPPROVALVALIDATEREENROLLMENT")]
        public string PREVIOUSAPPROVALVALIdATEREENROLLMENT { get; set; }
        public string AUTOENROLLMENTCHECKUSERDSCERTIFICATE { get; set; }
        public string INCLUDEBASICCONSTRAINTSFOREECERTS { get; set; }

        [JsonProperty("REMOVEINVALIDCERTIFICATEFROMPERSONALSTORE")]
        public string REMOVEINVALIdCERTIFICATEFROMPERSONALSTORE { get; set; }
        public string EXCLUDEOCSPDETAILSINCERT { get; set; }
        public string ALLOWISSUANCEPOLICIESFROMREQUEST { get; set; }
        public string AUTOENROLLMENT { get; set; }
        public string PUBLISHTODS { get; set; }
        public string ALLOWENROLLONBEHALFOF { get; set; }
        public string ALLOWKEYBASEDRENEWAL { get; set; }
        public string PUBLISHTOKRACONTAINER { get; set; }
        public string USERINTERACTIONREQUIRED { get; set; }
        public string CERTMGRAPPROVALREQUIRED { get; set; }
        public string INCLUDESYMETRICALGORITHMS { get; set; }
    }

    public class QueryTemplatesResponseItemCertificatenameflagsdecodedType
    {
        public string SUBJECTREQUIREDNSASCN { get; set; }
        public string SUBJECTALTREQUIREEMAIL { get; set; }
        public string SUBJECTREQUIREEMAIL { get; set; }
        public string SUBJECTALTREQUIREDNS { get; set; }
        public string SUBJECTALTREQUIREDOMAINDNS { get; set; }
        public string ENROLEESUPLIESSUBJECTALTNAME { get; set; }
        public string OLDCERTSUPPLIESSUBJECTANDALTNAME { get; set; }
        public string SUBJECTALTREQUIREUPN { get; set; }
        public string SUBJECTALTREQUIREDIRECTORYGUID { get; set; }
        public string SUBJECTREQUIRECOMMONNAME { get; set; }
        public string SUBJECTALTREQUIRESPN { get; set; }
        public string ENROLEESUPLIESSUBJECT { get; set; }
        public string SUBJECTREQUIREDIRECTORYPATH { get; set; }
    }

    public class QueryTemplatesResponseItemPrivatekeyflagsdecodedType
    {
        public string REQUIREALTERNATESIGNATUREALGORITHM { get; set; }
        public string EXPORTABLEKEY { get; set; }
        public string REQUIRESAMEKEYRENEWAL { get; set; }

        [JsonProperty("EKVALIDATECERT")]
        public string EKVALIdATECERT { get; set; }

        [JsonProperty("EKVALIDATEKEY")]
        public string EKVALIdATEKEY { get; set; }
        public string STRONGKEYPROTECTIONREQUIRED { get; set; }
        public string ATTESTATIONWITHOUTPOLICY { get; set; }
        public string EKTRUSTONUSE { get; set; }
        public string ATTESTREQUIRED { get; set; }

        [JsonProperty("USELEGACYPROVIDER")]
        public string USELEGACYPROVIdER { get; set; }
        public string ATTESTPREFERRED { get; set; }
        public string REQUIREPRIVATEKEYARCHIVAL { get; set; }
        public string ATTESTNONE { get; set; }
    }

    public class QueryTemplatesResponseItemPrivatekeyusagedecodedType
    {
        public string KEYAGREEMENT { get; set; }
        public string SIGNING { get; set; }
        public string DECRYPTION { get; set; }
        public string ALLUSAGES { get; set; }
    }

    public class QueryTemplatesResponseItemCloudpkiType
    {
        [JsonProperty("important")]
        public string Important { get; set; }

        [JsonProperty("owneremail")]
        public string[] Owneremail { get; set; }

        [JsonProperty("owneremailstring")]
        public string Owneremailstring { get; set; }

        [JsonProperty("autoapproveid")]
        public string[] Autoapproveid { get; set; }

        [JsonProperty("autoapproveidstring")]
        public string Autoapproveidstring { get; set; }

        [JsonProperty("hidden")]
        public string Hidden { get; set; }

        [JsonProperty("renewalstatus")]
        public string Renewalstatus { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }

        [JsonProperty("lastmodifiedepoch")]
        public int Lastmodifiedepoch { get; set; }

        [JsonProperty("lastmodifiedid")]
        public string Lastmodifiedid { get; set; }

        [JsonProperty("lastmodifiedemail")]
        public string Lastmodifiedemail { get; set; }

        [JsonProperty("lastmodifiedevent")]
        public string Lastmodifiedevent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        Email,
        Web,
        PowerBI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum versionInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum keytypeInput
    {
        RSA,
        ECC
    }

    public class GetCRLResponse
    {
        [JsonProperty("validfrom")]
        public string Validfrom { get; set; }

        [JsonProperty("validto")]
        public string Validto { get; set; }

        [JsonProperty("validfromepoch")]
        public int Validfromepoch { get; set; }

        [JsonProperty("validtoepoch")]
        public int Validtoepoch { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("signaturealgorithm")]
        public string Signaturealgorithm { get; set; }

        [JsonProperty("signaturehashalgorithm")]
        public string Signaturehashalgorithm { get; set; }

        [JsonProperty("caversion")]
        public string Caversion { get; set; }

        [JsonProperty("aki")]
        public string Aki { get; set; }

        [JsonProperty("crlnumber")]
        public string Crlnumber { get; set; }

        [JsonProperty("crlnumberdecimal")]
        public int Crlnumberdecimal { get; set; }

        [JsonProperty("nextpublish")]
        public string Nextpublish { get; set; }

        [JsonProperty("nextpublishepoch")]
        public int Nextpublishepoch { get; set; }

        [JsonProperty("crlid")]
        public string Crlid { get; set; }

        [JsonProperty("crlentries")]
        public string[] Crlentries { get; set; }
    }

    public class QueryCRLsResponseItem
    {
        [JsonProperty("validfrom")]
        public string Validfrom { get; set; }

        [JsonProperty("validto")]
        public string Validto { get; set; }

        [JsonProperty("validfromepoch")]
        public int Validfromepoch { get; set; }

        [JsonProperty("validtoepoch")]
        public int Validtoepoch { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("signaturealgorithm")]
        public string Signaturealgorithm { get; set; }

        [JsonProperty("signaturehashalgorithm")]
        public string Signaturehashalgorithm { get; set; }

        [JsonProperty("caversion")]
        public string Caversion { get; set; }

        [JsonProperty("aki")]
        public string Aki { get; set; }

        [JsonProperty("crlnumber")]
        public string Crlnumber { get; set; }

        [JsonProperty("crlnumberdecimal")]
        public int Crlnumberdecimal { get; set; }

        [JsonProperty("nextpublish")]
        public string Nextpublish { get; set; }

        [JsonProperty("nextpublishepoch")]
        public int Nextpublishepoch { get; set; }

        [JsonProperty("crlid")]
        public string Crlid { get; set; }

        [JsonProperty("crlentries")]
        public string[] Crlentries { get; set; }
    }

    public class QueryRequestsResponseItem
    {
        [JsonProperty("requestid")]
        public string Requestid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("requestsource")]
        public string Requestsource { get; set; }

        [JsonProperty("displaysubject")]
        public string Displaysubject { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("templatename")]
        public string Templatename { get; set; }

        [JsonProperty("requestdetails")]
        public QueryRequestsResponseItemRequestdetailsType Requestdetails { get; set; }

        [JsonProperty("cloudpki")]
        public QueryRequestsResponseItemCloudpkiType Cloudpki { get; set; }

        [JsonProperty("subjectalternativename")]
        public string[] Subjectalternativename { get; set; }
    }

    public class QueryRequestsResponseItemRequestdetailsType
    {
        [JsonProperty("carequestid")]
        public int Carequestid { get; set; }

        [JsonProperty("requestername")]
        public string Requestername { get; set; }
    }

    public class QueryRequestsResponseItemCloudpkiType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("urgent")]
        public string Urgent { get; set; }

        [JsonProperty("important")]
        public string Important { get; set; }

        [JsonProperty("submitterid")]
        public string Submitterid { get; set; }

        [JsonProperty("submitteremail")]
        public string Submitteremail { get; set; }
    }

    public class NewRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("requestid")]
        public string Requestid { get; set; }

        [JsonProperty("objecturi")]
        public string Objecturi { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class NewRequestInput
    {
        [JsonProperty("csr", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Csr { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("owneremail")]
        public string Owneremail { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("urgent", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewRequestInputUrgentType? Urgent { get; set; } = NewRequestInputUrgentType.False;

        [JsonProperty("important", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewRequestInputImportantType? Important { get; set; } = NewRequestInputImportantType.False;

        [JsonProperty("renewal", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewRequestInputRenewalType? Renewal { get; set; } = NewRequestInputRenewalType.False;

        [JsonProperty("previouscertificate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Previouscertificate { get; set; } = "";

        [JsonProperty("renewalstatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewRequestInputRenewalstatusType? Renewalstatus { get; set; } = NewRequestInputRenewalstatusType.False;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewRequestInputUrgentType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewRequestInputImportantType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewRequestInputRenewalType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewRequestInputRenewalstatusType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class GetRequestResponse
    {
        [JsonProperty("requestsource")]
        public string Requestsource { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("publickey")]
        public string Publickey { get; set; }

        [JsonProperty("keytype")]
        public string Keytype { get; set; }

        [JsonProperty("keylength")]
        public int Keylength { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("subjectalternativename")]
        public string[] Subjectalternativename { get; set; }

        [JsonProperty("requesthash")]
        public string Requesthash { get; set; }

        [JsonProperty("signaturealgorithm")]
        public string Signaturealgorithm { get; set; }

        [JsonProperty("alternatesignaturealgorithm")]
        public bool Alternatesignaturealgorithm { get; set; }

        [JsonProperty("templateoid")]
        public string Templateoid { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("templatename")]
        public string Templatename { get; set; }

        [JsonProperty("criticalextensions")]
        public string[] Criticalextensions { get; set; }

        [JsonProperty("enhancedkeyusage")]
        public string[] Enhancedkeyusage { get; set; }

        [JsonProperty("keyusage")]
        public string[] Keyusage { get; set; }

        [JsonProperty("applicationpolicies")]
        public string[] Applicationpolicies { get; set; }

        [JsonProperty("subjectkeyidentifier")]
        public string Subjectkeyidentifier { get; set; }

        [JsonProperty("displaysubject")]
        public string Displaysubject { get; set; }

        [JsonProperty("requestid")]
        public string Requestid { get; set; }

        [JsonProperty("requestdetails")]
        public GetRequestResponseRequestdetailsType Requestdetails { get; set; }

        [JsonProperty("cloudpki")]
        public GetRequestResponseCloudpkiType Cloudpki { get; set; }
    }

    public class GetRequestResponseRequestdetailsType
    {
        [JsonProperty("carequestid")]
        public int Carequestid { get; set; }

        [JsonProperty("statusmessage")]
        public string Statusmessage { get; set; }

        [JsonProperty("submittedwhen")]
        public string Submittedwhen { get; set; }

        [JsonProperty("resolvedwhen")]
        public string Resolvedwhen { get; set; }

        [JsonProperty("revokedwhen")]
        public string Revokedwhen { get; set; }

        [JsonProperty("revokedeffectivewhen")]
        public string Revokedeffectivewhen { get; set; }

        [JsonProperty("revokedreason")]
        public string Revokedreason { get; set; }

        [JsonProperty("requestername")]
        public string Requestername { get; set; }

        [JsonProperty("callername")]
        public string Callername { get; set; }

        [JsonProperty("requestosversion")]
        public string Requestosversion { get; set; }

        [JsonProperty("requestcspprovider")]
        public string Requestcspprovider { get; set; }

        [JsonProperty("cdc")]
        public string Cdc { get; set; }

        [JsonProperty("rmd")]
        public string Rmd { get; set; }

        [JsonProperty("ccm")]
        public string Ccm { get; set; }
    }

    public class GetRequestResponseCloudpkiType
    {
        [JsonProperty("cloudpkirequestid")]
        public string Cloudpkirequestid { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("urgent")]
        public string Urgent { get; set; }

        [JsonProperty("important")]
        public string Important { get; set; }

        [JsonProperty("owneremail")]
        public string[] Owneremail { get; set; }

        [JsonProperty("owneremailstring")]
        public string Owneremailstring { get; set; }

        [JsonProperty("submittedcsr")]
        public string Submittedcsr { get; set; }

        [JsonProperty("submittedtemplateid")]
        public string Submittedtemplateid { get; set; }

        [JsonProperty("submittedreference")]
        public string Submittedreference { get; set; }

        [JsonProperty("submittedcomment")]
        public string Submittedcomment { get; set; }

        [JsonProperty("submittedurgent")]
        public string Submittedurgent { get; set; }

        [JsonProperty("submittedimportant")]
        public string Submittedimportant { get; set; }

        [JsonProperty("submittedowneremail")]
        public string[] Submittedowneremail { get; set; }

        [JsonProperty("submittedwhen")]
        public string Submittedwhen { get; set; }

        [JsonProperty("submittedwhenepoch")]
        public int Submittedwhenepoch { get; set; }

        [JsonProperty("submitterid")]
        public string Submitterid { get; set; }

        [JsonProperty("submitteremail")]
        public string Submitteremail { get; set; }

        [JsonProperty("approvedstatus")]
        public string Approvedstatus { get; set; }

        [JsonProperty("approvedcomment")]
        public string Approvedcomment { get; set; }

        [JsonProperty("approvedreference")]
        public string Approvedreference { get; set; }

        [JsonProperty("approvedimportant")]
        public string Approvedimportant { get; set; }

        [JsonProperty("approvedwhen")]
        public string Approvedwhen { get; set; }

        [JsonProperty("approvedwhenepoch")]
        public int Approvedwhenepoch { get; set; }

        [JsonProperty("approverid")]
        public string Approverid { get; set; }

        [JsonProperty("approveremail")]
        public string Approveremail { get; set; }
    }

    public class UpdateRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("requestid")]
        public string Requestid { get; set; }

        [JsonProperty("connectoractionid")]
        public string Connectoractionid { get; set; }
    }

    public class UpdateRequestInput
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateRequestInputStatusType Status { get; set; } = UpdateRequestInputStatusType.UpdateOnly;

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("urgent")]
        public UpdateRequestInputUrgentType? Urgent { get; set; }

        [JsonProperty("important")]
        public UpdateRequestInputImportantType? Important { get; set; }

        [JsonProperty("renewalstatus")]
        public UpdateRequestInputRenewalstatusType? Renewalstatus { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("owneremail")]
        public string Owneremail { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateRequestInputStatusType
    {
        Approved,
        Denied,
        UpdateOnly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateRequestInputUrgentType
    {
        True,
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateRequestInputImportantType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateRequestInputRenewalstatusType
    {
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "denied")]
        Denied,
        [EnumMember(Value = "none")]
        None
    }

    public class QueryHooksResponseItem
    {
        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("events")]
        public string Events { get; set; }

        [JsonProperty("callbackurl")]
        public string Callbackurl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("objecturi")]
        public string Objecturi { get; set; }

        [JsonProperty("creatorid")]
        public string Creatorid { get; set; }

        [JsonProperty("creatoremail")]
        public string Creatoremail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("whenchanged")]
        public string Whenchanged { get; set; }

        [JsonProperty("whenchangedepoch")]
        public int Whenchangedepoch { get; set; }

        [JsonProperty("useragent")]
        public string Useragent { get; set; }

        [JsonProperty("workflowdetails")]
        public QueryHooksResponseItemWorkflowdetailsType Workflowdetails { get; set; }
    }

    public class QueryHooksResponseItemWorkflowdetailsType
    {
        [JsonProperty("workflowname")]
        public string Workflowname { get; set; }

        [JsonProperty("workflowoperationname")]
        public string Workflowoperationname { get; set; }

        [JsonProperty("workflowid")]
        public string Workflowid { get; set; }

        [JsonProperty("workflowversion")]
        public string Workflowversion { get; set; }

        [JsonProperty("workflowsubscriptionid")]
        public string Workflowsubscriptionid { get; set; }

        [JsonProperty("workflowlocation")]
        public string Workflowlocation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum @eventInput
    {
        [EnumMember(Value = "issued-certificate")]
        IssuedCertificate,
        [EnumMember(Value = "revoked-certificate")]
        RevokedCertificate,
        [EnumMember(Value = "pending-request")]
        PendingRequest,
        [EnumMember(Value = "approved-request")]
        ApprovedRequest,
        [EnumMember(Value = "denied-request")]
        DeniedRequest,
        [EnumMember(Value = "failed-request")]
        FailedRequest,
        [EnumMember(Value = "updated-request")]
        UpdatedRequest,
        [EnumMember(Value = "issued-crl")]
        IssuedCrl,
        [EnumMember(Value = "published-template")]
        PublishedTemplate,
        [EnumMember(Value = "unpublished-template")]
        UnpublishedTemplate,
        [EnumMember(Value = "added-hook")]
        AddedHook,
        [EnumMember(Value = "removed-hook")]
        RemovedHook,
        [EnumMember(Value = "renewing-certificate")]
        RenewingCertificate,
        [EnumMember(Value = "expiring-certificate")]
        ExpiringCertificate,
        [EnumMember(Value = "expired-certificate")]
        ExpiredCertificate
    }

    public class NewHookResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("objecturi")]
        public string Objecturi { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }
    }

    public class NewHookInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("callbackurl")]
        public string Callbackurl { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewHookInputTypeType Type { get; set; }

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewHookInputEventsTypeItem[] Events { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewHookInputTypeType
    {
        Web,
        Email,
        PowerBI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewHookInputEventsTypeItem
    {
        [EnumMember(Value = "issued-certificate")]
        IssuedCertificate,
        [EnumMember(Value = "revoked-certificate")]
        RevokedCertificate,
        [EnumMember(Value = "pending-request")]
        PendingRequest,
        [EnumMember(Value = "approved-request")]
        ApprovedRequest,
        [EnumMember(Value = "denied-request")]
        DeniedRequest,
        [EnumMember(Value = "failed-request")]
        FailedRequest,
        [EnumMember(Value = "updated-request")]
        UpdatedRequest,
        [EnumMember(Value = "issued-crl")]
        IssuedCrl,
        [EnumMember(Value = "published-template")]
        PublishedTemplate,
        [EnumMember(Value = "unpublished-template")]
        UnpublishedTemplate,
        [EnumMember(Value = "added-hook")]
        AddedHook,
        [EnumMember(Value = "removed-hook")]
        RemovedHook,
        [EnumMember(Value = "renewing-certificate")]
        RenewingCertificate,
        [EnumMember(Value = "expiring-certificate")]
        ExpiringCertificate,
        [EnumMember(Value = "expired-certificate")]
        ExpiredCertificate
    }

    public class GetHookResponse
    {
        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("events")]
        public string Events { get; set; }

        [JsonProperty("callbackurl")]
        public string Callbackurl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("objecturi")]
        public string Objecturi { get; set; }

        [JsonProperty("creatorid")]
        public string Creatorid { get; set; }

        [JsonProperty("creatoremail")]
        public string Creatoremail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("whenchanged")]
        public string Whenchanged { get; set; }

        [JsonProperty("whenchangedepoch")]
        public int Whenchangedepoch { get; set; }

        [JsonProperty("useragent")]
        public string Useragent { get; set; }

        [JsonProperty("workflowdetails")]
        public GetHookResponseWorkflowdetailsType Workflowdetails { get; set; }
    }

    public class GetHookResponseWorkflowdetailsType
    {
        [JsonProperty("workflowname")]
        public string Workflowname { get; set; }

        [JsonProperty("workflowoperationname")]
        public string Workflowoperationname { get; set; }

        [JsonProperty("workflowid")]
        public string Workflowid { get; set; }

        [JsonProperty("workflowversion")]
        public string Workflowversion { get; set; }

        [JsonProperty("workflowsubscriptionid")]
        public string Workflowsubscriptionid { get; set; }

        [JsonProperty("workflowlocation")]
        public string Workflowlocation { get; set; }
    }

    public class GetPublishedTemplatesResponseItem
    {
        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("templatename")]
        public string Templatename { get; set; }

        [JsonProperty("templateoid")]
        public string Templateoid { get; set; }

        [JsonProperty("templateforestrootfqdn")]
        public string Templateforestrootfqdn { get; set; }

        [JsonProperty("templatedisplayname")]
        public string Templatedisplayname { get; set; }
    }

    public class GetConnectorActionResponse
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("assetid")]
        public string Assetid { get; set; }

        [JsonProperty("assettype")]
        public string Assettype { get; set; }

        [JsonProperty("createdwhen")]
        public string Createdwhen { get; set; }

        [JsonProperty("resolvedwhen")]
        public string Resolvedwhen { get; set; }

        [JsonProperty("submittedwhen")]
        public string Submittedwhen { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("connectoractionid")]
        public string Connectoractionid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetActionsResponseItem
    {
        [JsonProperty("thumbprint")]
        public string Thumbprint { get; set; }

        [JsonProperty("validto")]
        public string Validto { get; set; }

        [JsonProperty("validtoepoch")]
        public int Validtoepoch { get; set; }

        [JsonProperty("renewalstatus")]
        public string Renewalstatus { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }

        [JsonProperty("objecttype")]
        public string Objecttype { get; set; }

        [JsonProperty("objectstatus")]
        public string Objectstatus { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("requestid")]
        public string Requestid { get; set; }

        [JsonProperty("requestsource")]
        public string Requestsource { get; set; }

        [JsonProperty("submittedwhen")]
        public string Submittedwhen { get; set; }

        [JsonProperty("submittedwhenepoch")]
        public string Submittedwhenepoch { get; set; }

        [JsonProperty("submitteremail")]
        public string Submitteremail { get; set; }

        [JsonProperty("displaysubject")]
        public string Displaysubject { get; set; }
    }

    public class AddedHookResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class AddedHookInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "added-hook";
    }

    public class RemovedHookResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RemovedHookInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "removed-hook";
    }

    public class IssuedCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class IssuedCertificateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "issued-certificate";
    }

    public class RevokedCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RevokedCertificateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "revoked-certificate";
    }

    public class UpdatedCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdatedCertificateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "updated-certificate";
    }

    public class ExpiringCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ExpiringCertificateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "expiring-certificate";
    }

    public class ExpiredCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ExpiredCertificateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "expired-certificate";
    }

    public class RenewingCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RenewingCertificateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "renewing-certificate";
    }

    public class PendingRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class PendingRequestInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "pending-request";
    }

    public class ApprovedRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ApprovedRequestInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "approved-request";
    }

    public class DeniedRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class DeniedRequestInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "denied-request";
    }

    public class UpdatedRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdatedRequestInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "updated-request";
    }

    public class FailedRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class FailedRequestInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "failed-request";
    }

    public class PublishedTemplateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class PublishedTemplateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "published-template";
    }

    public class UnpublishedTemplateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UnpublishedTemplateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "unpublished-template";
    }

    public class UpdatedTemplateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdatedTemplateInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "updated-template";
    }

    public class IssuedCRLResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class IssuedCRLInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "issued-crl";
    }

    public class NewConnectorActionResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class NewConnectorActionInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "new-connectoraction";
    }

    public class CompletedConnectorActionResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CompletedConnectorActionInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "completed-connectoraction";
    }

    public class FailedConnectorActionResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class FailedConnectorActionInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "failed-connectoraction";
    }

    public class StalledConnectorActionResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class StalledConnectorActionInput
    {
        [JsonProperty("callbackurl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callbackurl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "web";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "stalled-connectoraction";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudpkimanagement;

    public partial class WorkflowManagedActions
    {
        public CloudpkimanagementActions Cloudpkimanagement(string connectionId) => new CloudpkimanagementActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudpkimanagementTriggers Cloudpkimanagement(string connectionId) => new CloudpkimanagementTriggers(connectionId);
    }
}