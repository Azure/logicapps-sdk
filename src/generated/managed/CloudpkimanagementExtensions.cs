//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudpkimanagement
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CloudpkimanagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryCertificatesResponseItem[]> QueryCertificates(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<timevalidInput>> timevalid = null, Expression<Func<string>> important = null, Expression<Func<string>> renewalstatus = null, Expression<Func<int>> expiring = null, Expression<Func<string>> subject = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> serialnumber = null, Expression<Func<string>> ski = null, Expression<Func<string>> aki = null, Expression<Func<string>> keytype = null, Expression<Func<int>> keylength = null, Expression<Func<string>> owneremail = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_timevalid = timevalid == null ? null : WorkflowExpression.Compile(timevalid);
            WorkflowExpression.Validate(__workflow_timevalid, nameof(timevalid), required: false);
            var __workflow_important = important == null ? null : WorkflowExpression.Compile(important);
            WorkflowExpression.Validate(__workflow_important, nameof(important), required: false);
            var __workflow_renewalstatus = renewalstatus == null ? null : WorkflowExpression.Compile(renewalstatus);
            WorkflowExpression.Validate(__workflow_renewalstatus, nameof(renewalstatus), required: false);
            var __workflow_expiring = expiring == null ? null : WorkflowExpression.Compile(expiring);
            WorkflowExpression.Validate(__workflow_expiring, nameof(expiring), required: false);
            var __workflow_subject = subject == null ? null : WorkflowExpression.Compile(subject);
            WorkflowExpression.Validate(__workflow_subject, nameof(subject), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_serialnumber = serialnumber == null ? null : WorkflowExpression.Compile(serialnumber);
            WorkflowExpression.Validate(__workflow_serialnumber, nameof(serialnumber), required: false);
            var __workflow_ski = ski == null ? null : WorkflowExpression.Compile(ski);
            WorkflowExpression.Validate(__workflow_ski, nameof(ski), required: false);
            var __workflow_aki = aki == null ? null : WorkflowExpression.Compile(aki);
            WorkflowExpression.Validate(__workflow_aki, nameof(aki), required: false);
            var __workflow_keytype = keytype == null ? null : WorkflowExpression.Compile(keytype);
            WorkflowExpression.Validate(__workflow_keytype, nameof(keytype), required: false);
            var __workflow_keylength = keylength == null ? null : WorkflowExpression.Compile(keylength);
            WorkflowExpression.Validate(__workflow_keylength, nameof(keylength), required: false);
            var __workflow_owneremail = owneremail == null ? null : WorkflowExpression.Compile(owneremail);
            WorkflowExpression.Validate(__workflow_owneremail, nameof(owneremail), required: false);
            return new DeferredBodyAction<QueryCertificatesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/certificates", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
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
        public IBodyWorkflowAction<GetCertificateResponse> GetCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> thumbprint)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_thumbprint = thumbprint == null ? null : WorkflowExpression.Compile(thumbprint);
            WorkflowExpression.Validate(__workflow_thumbprint, nameof(thumbprint), required: true);
            return new DeferredBodyAction<GetCertificateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/certificates/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_thumbprint, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateCertificateResponse> UpdateCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> thumbprint, Expression<Func<powerappsInput>> powerapps, Expression<Func<bodyimportantInput>> bodyimportant = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bodyrenewalstatusInput>> bodyrenewalstatus = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodyreference = null, Expression<Func<string>> bodyowneremail = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_thumbprint = thumbprint == null ? null : WorkflowExpression.Compile(thumbprint);
            WorkflowExpression.Validate(__workflow_thumbprint, nameof(thumbprint), required: true);
            var __workflow_powerapps = powerapps == null ? null : WorkflowExpression.Compile(powerapps);
            WorkflowExpression.Validate(__workflow_powerapps, nameof(powerapps), required: true);
            var __workflow_bodyimportant = bodyimportant == null ? null : WorkflowExpression.Compile(bodyimportant);
            WorkflowExpression.Validate(__workflow_bodyimportant, nameof(bodyimportant), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyrenewalstatus = bodyrenewalstatus == null ? null : WorkflowExpression.Compile(bodyrenewalstatus);
            WorkflowExpression.Validate(__workflow_bodyrenewalstatus, nameof(bodyrenewalstatus), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodyreference = bodyreference == null ? null : WorkflowExpression.Compile(bodyreference);
            WorkflowExpression.Validate(__workflow_bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodyowneremail = bodyowneremail == null ? null : WorkflowExpression.Compile(bodyowneremail);
            WorkflowExpression.Validate(__workflow_bodyowneremail, nameof(bodyowneremail), required: false);
            return new DeferredBodyAction<UpdateCertificateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/certificates/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_thumbprint, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyimportant != null)
                {
                    body["important"] = ExpressionConverter.ConvertO(__workflow_bodyimportant);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyrenewalstatus != null)
                {
                    body["renewalstatus"] = ExpressionConverter.ConvertO(__workflow_bodyrenewalstatus);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodyowneremail != null)
                {
                    body["owneremail"] = ExpressionConverter.ConvertO(__workflow_bodyowneremail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetTemplateResponse> GetTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> templateid)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_templateid = templateid == null ? null : WorkflowExpression.Compile(templateid);
            WorkflowExpression.Validate(__workflow_templateid, nameof(templateid), required: true);
            return new DeferredBodyAction<GetTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/templates/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateTemplateResponse> UpdateTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> templateid, Expression<Func<powerappsInput>> powerapps, Expression<Func<bodyimportantInput>> bodyimportant = null, Expression<Func<bodyrenewalstatusInput>> bodyrenewalstatus = null, Expression<Func<bodyhiddenInput>> bodyhidden = null, Expression<Func<string>> bodyowneremail = null, Expression<Func<string>> bodyautoapproveid = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_templateid = templateid == null ? null : WorkflowExpression.Compile(templateid);
            WorkflowExpression.Validate(__workflow_templateid, nameof(templateid), required: true);
            var __workflow_powerapps = powerapps == null ? null : WorkflowExpression.Compile(powerapps);
            WorkflowExpression.Validate(__workflow_powerapps, nameof(powerapps), required: true);
            var __workflow_bodyimportant = bodyimportant == null ? null : WorkflowExpression.Compile(bodyimportant);
            WorkflowExpression.Validate(__workflow_bodyimportant, nameof(bodyimportant), required: false);
            var __workflow_bodyrenewalstatus = bodyrenewalstatus == null ? null : WorkflowExpression.Compile(bodyrenewalstatus);
            WorkflowExpression.Validate(__workflow_bodyrenewalstatus, nameof(bodyrenewalstatus), required: false);
            var __workflow_bodyhidden = bodyhidden == null ? null : WorkflowExpression.Compile(bodyhidden);
            WorkflowExpression.Validate(__workflow_bodyhidden, nameof(bodyhidden), required: false);
            var __workflow_bodyowneremail = bodyowneremail == null ? null : WorkflowExpression.Compile(bodyowneremail);
            WorkflowExpression.Validate(__workflow_bodyowneremail, nameof(bodyowneremail), required: false);
            var __workflow_bodyautoapproveid = bodyautoapproveid == null ? null : WorkflowExpression.Compile(bodyautoapproveid);
            WorkflowExpression.Validate(__workflow_bodyautoapproveid, nameof(bodyautoapproveid), required: false);
            return new DeferredBodyAction<UpdateTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/templates/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateid, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyimportant != null)
                {
                    body["important"] = ExpressionConverter.ConvertO(__workflow_bodyimportant);
                    bodypropCount++;
                }

                if (__workflow_bodyrenewalstatus != null)
                {
                    body["renewalstatus"] = ExpressionConverter.ConvertO(__workflow_bodyrenewalstatus);
                    bodypropCount++;
                }

                if (__workflow_bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(__workflow_bodyhidden);
                    bodypropCount++;
                }

                if (__workflow_bodyowneremail != null)
                {
                    body["owneremail"] = ExpressionConverter.ConvertO(__workflow_bodyowneremail);
                    bodypropCount++;
                }

                if (__workflow_bodyautoapproveid != null)
                {
                    body["autoapproveid"] = ExpressionConverter.ConvertO(__workflow_bodyautoapproveid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryTemplatesResponseItem[]> QueryTemplates(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<statusInput>> status = null, Expression<Func<typeInput>> type = null, Expression<Func<versionInput>> version = null, Expression<Func<string>> templateoid = null, Expression<Func<keytypeInput>> keytype = null, Expression<Func<int>> minMinkeylength = null, Expression<Func<int>> maxMinkeylength = null, Expression<Func<int>> minValidity = null, Expression<Func<int>> maxValidity = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: false);
            var __workflow_templateoid = templateoid == null ? null : WorkflowExpression.Compile(templateoid);
            WorkflowExpression.Validate(__workflow_templateoid, nameof(templateoid), required: false);
            var __workflow_keytype = keytype == null ? null : WorkflowExpression.Compile(keytype);
            WorkflowExpression.Validate(__workflow_keytype, nameof(keytype), required: false);
            var __workflow_minMinkeylength = minMinkeylength == null ? null : WorkflowExpression.Compile(minMinkeylength);
            WorkflowExpression.Validate(__workflow_minMinkeylength, nameof(minMinkeylength), required: false);
            var __workflow_maxMinkeylength = maxMinkeylength == null ? null : WorkflowExpression.Compile(maxMinkeylength);
            WorkflowExpression.Validate(__workflow_maxMinkeylength, nameof(maxMinkeylength), required: false);
            var __workflow_minValidity = minValidity == null ? null : WorkflowExpression.Compile(minValidity);
            WorkflowExpression.Validate(__workflow_minValidity, nameof(minValidity), required: false);
            var __workflow_maxValidity = maxValidity == null ? null : WorkflowExpression.Compile(maxValidity);
            WorkflowExpression.Validate(__workflow_maxValidity, nameof(maxValidity), required: false);
            return new DeferredBodyAction<QueryTemplatesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/templates", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
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
        public IBodyWorkflowAction<GetCRLResponse> GetCRL(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> crlid)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_crlid = crlid == null ? null : WorkflowExpression.Compile(crlid);
            WorkflowExpression.Validate(__workflow_crlid, nameof(crlid), required: true);
            return new DeferredBodyAction<GetCRLResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/crls/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_crlid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCRLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryCRLsResponseItem[]> QueryCRLs(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> crlid = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> issued = null, Expression<Func<int>> expiring = null, Expression<Func<string>> crlnumber = null, Expression<Func<string>> crlnumberdecimal = null, Expression<Func<string>> aki = null, Expression<Func<string>> serialnumber = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_crlid = crlid == null ? null : WorkflowExpression.Compile(crlid);
            WorkflowExpression.Validate(__workflow_crlid, nameof(crlid), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_issued = issued == null ? null : WorkflowExpression.Compile(issued);
            WorkflowExpression.Validate(__workflow_issued, nameof(issued), required: false);
            var __workflow_expiring = expiring == null ? null : WorkflowExpression.Compile(expiring);
            WorkflowExpression.Validate(__workflow_expiring, nameof(expiring), required: false);
            var __workflow_crlnumber = crlnumber == null ? null : WorkflowExpression.Compile(crlnumber);
            WorkflowExpression.Validate(__workflow_crlnumber, nameof(crlnumber), required: false);
            var __workflow_crlnumberdecimal = crlnumberdecimal == null ? null : WorkflowExpression.Compile(crlnumberdecimal);
            WorkflowExpression.Validate(__workflow_crlnumberdecimal, nameof(crlnumberdecimal), required: false);
            var __workflow_aki = aki == null ? null : WorkflowExpression.Compile(aki);
            WorkflowExpression.Validate(__workflow_aki, nameof(aki), required: false);
            var __workflow_serialnumber = serialnumber == null ? null : WorkflowExpression.Compile(serialnumber);
            WorkflowExpression.Validate(__workflow_serialnumber, nameof(serialnumber), required: false);
            return new DeferredBodyAction<QueryCRLsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/crls", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
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
        public IBodyWorkflowAction<QueryRequestsResponseItem[]> QueryRequests(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<statusInput>> status = null, Expression<Func<string>> source = null, Expression<Func<string>> approverid = null, Expression<Func<string>> approveremail = null, Expression<Func<string>> submitterid = null, Expression<Func<string>> submitteremail = null, Expression<Func<string>> owneremail = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_source = source == null ? null : WorkflowExpression.Compile(source);
            WorkflowExpression.Validate(__workflow_source, nameof(source), required: false);
            var __workflow_approverid = approverid == null ? null : WorkflowExpression.Compile(approverid);
            WorkflowExpression.Validate(__workflow_approverid, nameof(approverid), required: false);
            var __workflow_approveremail = approveremail == null ? null : WorkflowExpression.Compile(approveremail);
            WorkflowExpression.Validate(__workflow_approveremail, nameof(approveremail), required: false);
            var __workflow_submitterid = submitterid == null ? null : WorkflowExpression.Compile(submitterid);
            WorkflowExpression.Validate(__workflow_submitterid, nameof(submitterid), required: false);
            var __workflow_submitteremail = submitteremail == null ? null : WorkflowExpression.Compile(submitteremail);
            WorkflowExpression.Validate(__workflow_submitteremail, nameof(submitteremail), required: false);
            var __workflow_owneremail = owneremail == null ? null : WorkflowExpression.Compile(owneremail);
            WorkflowExpression.Validate(__workflow_owneremail, nameof(owneremail), required: false);
            return new DeferredBodyAction<QueryRequestsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/requests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
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
        public IBodyWorkflowAction<NewRequestResponse> NewRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<powerappsInput>> powerapps, Expression<Func<string>> bodycsr, Expression<Func<string>> bodytemplateid = null, Expression<Func<string>> bodyowneremail = null, Expression<Func<string>> bodyreference = null, Expression<Func<string>> bodycomment = null, Expression<Func<bodyurgentInput>> bodyurgent = null, Expression<Func<bodyimportantInput>> bodyimportant = null, Expression<Func<bodyrenewalInput>> bodyrenewal = null, Expression<Func<string>> bodypreviouscertificate = null, Expression<Func<bodyrenewalstatusInput>> bodyrenewalstatus = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_powerapps = powerapps == null ? null : WorkflowExpression.Compile(powerapps);
            WorkflowExpression.Validate(__workflow_powerapps, nameof(powerapps), required: true);
            var __workflow_bodycsr = bodycsr == null ? null : WorkflowExpression.Compile(bodycsr);
            WorkflowExpression.Validate(__workflow_bodycsr, nameof(bodycsr), required: true);
            var __workflow_bodytemplateid = bodytemplateid == null ? null : WorkflowExpression.Compile(bodytemplateid);
            WorkflowExpression.Validate(__workflow_bodytemplateid, nameof(bodytemplateid), required: false);
            var __workflow_bodyowneremail = bodyowneremail == null ? null : WorkflowExpression.Compile(bodyowneremail);
            WorkflowExpression.Validate(__workflow_bodyowneremail, nameof(bodyowneremail), required: false);
            var __workflow_bodyreference = bodyreference == null ? null : WorkflowExpression.Compile(bodyreference);
            WorkflowExpression.Validate(__workflow_bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodyurgent = bodyurgent == null ? null : WorkflowExpression.Compile(bodyurgent);
            WorkflowExpression.Validate(__workflow_bodyurgent, nameof(bodyurgent), required: false);
            var __workflow_bodyimportant = bodyimportant == null ? null : WorkflowExpression.Compile(bodyimportant);
            WorkflowExpression.Validate(__workflow_bodyimportant, nameof(bodyimportant), required: false);
            var __workflow_bodyrenewal = bodyrenewal == null ? null : WorkflowExpression.Compile(bodyrenewal);
            WorkflowExpression.Validate(__workflow_bodyrenewal, nameof(bodyrenewal), required: false);
            var __workflow_bodypreviouscertificate = bodypreviouscertificate == null ? null : WorkflowExpression.Compile(bodypreviouscertificate);
            WorkflowExpression.Validate(__workflow_bodypreviouscertificate, nameof(bodypreviouscertificate), required: false);
            var __workflow_bodyrenewalstatus = bodyrenewalstatus == null ? null : WorkflowExpression.Compile(bodyrenewalstatus);
            WorkflowExpression.Validate(__workflow_bodyrenewalstatus, nameof(bodyrenewalstatus), required: false);
            return new DeferredBodyAction<NewRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/requests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["csr"] = ExpressionConverter.ConvertO(__workflow_bodycsr);
                if (__workflow_bodytemplateid != null)
                {
                    body["templateid"] = ExpressionConverter.ConvertO(__workflow_bodytemplateid);
                    bodypropCount++;
                }

                if (__workflow_bodyowneremail != null)
                {
                    body["owneremail"] = ExpressionConverter.ConvertO(__workflow_bodyowneremail);
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodyurgent != null)
                {
                    if (__workflow_bodyurgent != null)
                    {
                        body["urgent"] = ExpressionConverter.ConvertO(__workflow_bodyurgent);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["urgent"] = "false";
                    bodypropCount++;
                }

                if (__workflow_bodyimportant != null)
                {
                    if (__workflow_bodyimportant != null)
                    {
                        body["important"] = ExpressionConverter.ConvertO(__workflow_bodyimportant);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["important"] = "false";
                    bodypropCount++;
                }

                if (__workflow_bodyrenewal != null)
                {
                    if (__workflow_bodyrenewal != null)
                    {
                        body["renewal"] = ExpressionConverter.ConvertO(__workflow_bodyrenewal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["renewal"] = "false";
                    bodypropCount++;
                }

                if (__workflow_bodypreviouscertificate != null)
                {
                    if (__workflow_bodypreviouscertificate != null)
                    {
                        body["previouscertificate"] = ExpressionConverter.ConvertO(__workflow_bodypreviouscertificate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["previouscertificate"] = "";
                    bodypropCount++;
                }

                if (__workflow_bodyrenewalstatus != null)
                {
                    if (__workflow_bodyrenewalstatus != null)
                    {
                        body["renewalstatus"] = ExpressionConverter.ConvertO(__workflow_bodyrenewalstatus);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["renewalstatus"] = "false";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NewRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetRequestResponse> GetRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> requestid)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_requestid = requestid == null ? null : WorkflowExpression.Compile(requestid);
            WorkflowExpression.Validate(__workflow_requestid, nameof(requestid), required: true);
            return new DeferredBodyAction<GetRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/requests/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateRequestResponse> UpdateRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> requestid, Expression<Func<powerappsInput>> powerapps, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodyreference = null, Expression<Func<bodyurgentInput>> bodyurgent = null, Expression<Func<bodyimportantInput>> bodyimportant = null, Expression<Func<bodyrenewalstatusInput>> bodyrenewalstatus = null, Expression<Func<string>> bodytemplateid = null, Expression<Func<string>> bodyowneremail = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_requestid = requestid == null ? null : WorkflowExpression.Compile(requestid);
            WorkflowExpression.Validate(__workflow_requestid, nameof(requestid), required: true);
            var __workflow_powerapps = powerapps == null ? null : WorkflowExpression.Compile(powerapps);
            WorkflowExpression.Validate(__workflow_powerapps, nameof(powerapps), required: true);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: true);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodyreference = bodyreference == null ? null : WorkflowExpression.Compile(bodyreference);
            WorkflowExpression.Validate(__workflow_bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodyurgent = bodyurgent == null ? null : WorkflowExpression.Compile(bodyurgent);
            WorkflowExpression.Validate(__workflow_bodyurgent, nameof(bodyurgent), required: false);
            var __workflow_bodyimportant = bodyimportant == null ? null : WorkflowExpression.Compile(bodyimportant);
            WorkflowExpression.Validate(__workflow_bodyimportant, nameof(bodyimportant), required: false);
            var __workflow_bodyrenewalstatus = bodyrenewalstatus == null ? null : WorkflowExpression.Compile(bodyrenewalstatus);
            WorkflowExpression.Validate(__workflow_bodyrenewalstatus, nameof(bodyrenewalstatus), required: false);
            var __workflow_bodytemplateid = bodytemplateid == null ? null : WorkflowExpression.Compile(bodytemplateid);
            WorkflowExpression.Validate(__workflow_bodytemplateid, nameof(bodytemplateid), required: false);
            var __workflow_bodyowneremail = bodyowneremail == null ? null : WorkflowExpression.Compile(bodyowneremail);
            WorkflowExpression.Validate(__workflow_bodyowneremail, nameof(bodyowneremail), required: false);
            return new DeferredBodyAction<UpdateRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/requests/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestid, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodyurgent != null)
                {
                    body["urgent"] = ExpressionConverter.ConvertO(__workflow_bodyurgent);
                    bodypropCount++;
                }

                if (__workflow_bodyimportant != null)
                {
                    body["important"] = ExpressionConverter.ConvertO(__workflow_bodyimportant);
                    bodypropCount++;
                }

                if (__workflow_bodyrenewalstatus != null)
                {
                    body["renewalstatus"] = ExpressionConverter.ConvertO(__workflow_bodyrenewalstatus);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateid != null)
                {
                    body["templateid"] = ExpressionConverter.ConvertO(__workflow_bodytemplateid);
                    bodypropCount++;
                }

                if (__workflow_bodyowneremail != null)
                {
                    body["owneremail"] = ExpressionConverter.ConvertO(__workflow_bodyowneremail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryHooksResponseItem[]> QueryHooks(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<statusInput>> status = null, Expression<Func<typeInput>> type = null, Expression<Func<@eventInput>> @event = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_event = @event == null ? null : WorkflowExpression.Compile(@event);
            WorkflowExpression.Validate(__workflow_event, nameof(@event), required: false);
            return new DeferredBodyAction<QueryHooksResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
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
        public IBodyWorkflowAction<NewHookResponse> NewHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<powerappsInput>> powerapps, Expression<Func<bodytypeInput>> bodytype, Expression<Func<bodyeventsInputItem[]>> bodyevents, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodycallbackurl = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_powerapps = powerapps == null ? null : WorkflowExpression.Compile(powerapps);
            WorkflowExpression.Validate(__workflow_powerapps, nameof(powerapps), required: true);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: true);
            var __workflow_bodyevents = bodyevents == null ? null : WorkflowExpression.Compile(bodyevents);
            WorkflowExpression.Validate(__workflow_bodyevents, nameof(bodyevents), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodycallbackurl = bodycallbackurl == null ? null : WorkflowExpression.Compile(bodycallbackurl);
            WorkflowExpression.Validate(__workflow_bodycallbackurl, nameof(bodycallbackurl), required: false);
            return new DeferredBodyAction<NewHookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = ExpressionConverter.Convert(__workflow_powerapps);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodycallbackurl != null)
                {
                    body["callbackurl"] = ExpressionConverter.ConvertO(__workflow_bodycallbackurl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["events"] = ExpressionConverter.ConvertO(__workflow_bodyevents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NewHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetHookResponse> GetHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> hookid)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_hookid = hookid == null ? null : WorkflowExpression.Compile(hookid);
            WorkflowExpression.Validate(__workflow_hookid, nameof(hookid), required: true);
            return new DeferredBodyAction<GetHookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_hookid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string> DeleteHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> hookid)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_hookid = hookid == null ? null : WorkflowExpression.Compile(hookid);
            WorkflowExpression.Validate(__workflow_hookid, nameof(hookid), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_hookid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string> GetPublishedCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> thumbprint)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_thumbprint = thumbprint == null ? null : WorkflowExpression.Compile(thumbprint);
            WorkflowExpression.Validate(__workflow_thumbprint, nameof(thumbprint), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/published/certificates/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_thumbprint, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetPublishedTemplatesResponseItem[]> GetPublishedTemplates(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyAction<GetPublishedTemplatesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/published/templates", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPublishedTemplatesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetConnectorActionResponse> GetConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, Expression<Func<string>> connectoractionid)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            var __workflow_connectoractionid = connectoractionid == null ? null : WorkflowExpression.Compile(connectoractionid);
            WorkflowExpression.Validate(__workflow_connectoractionid, nameof(connectoractionid), required: true);
            return new DeferredBodyAction<GetConnectorActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/connectoractions/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_connectoractionid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetConnectorActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetActionsResponseItem[]> GetActions(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyAction<GetActionsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/actions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetActionsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string> GetAuthentication()
        {
            var apiCallPath = "/.auth/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class CloudpkimanagementTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AddedHookResponse> AddedHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<AddedHookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/added-hook", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "added-hook";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<AddedHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RemovedHookResponse> RemovedHook(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<RemovedHookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/removed-hook", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "removed-hook";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<RemovedHookResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IssuedCertificateResponse> IssuedCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<IssuedCertificateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/issued-certificate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "issued-certificate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<IssuedCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RevokedCertificateResponse> RevokedCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<RevokedCertificateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/revoked-certificate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "revoked-certificate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<RevokedCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UpdatedCertificateResponse> UpdatedCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<UpdatedCertificateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/updated-certificate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "updated-certificate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<UpdatedCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ExpiringCertificateResponse> ExpiringCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<ExpiringCertificateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/expiring-certificate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "expiring-certificate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<ExpiringCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ExpiredCertificateResponse> ExpiredCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<ExpiredCertificateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/expired-certificate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "expired-certificate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<ExpiredCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RenewingCertificateResponse> RenewingCertificate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<RenewingCertificateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/renewing-certificate", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "renewing-certificate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<RenewingCertificateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PendingRequestResponse> PendingRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<PendingRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/pending-request", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "pending-request";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<PendingRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ApprovedRequestResponse> ApprovedRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<ApprovedRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/approved-request", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "approved-request";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<ApprovedRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<DeniedRequestResponse> DeniedRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<DeniedRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/denied-request", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "denied-request";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<DeniedRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UpdatedRequestResponse> UpdatedRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<UpdatedRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/updated-request", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "updated-request";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<UpdatedRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FailedRequestResponse> FailedRequest(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<FailedRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/failed-request", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "failed-request";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<FailedRequestResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PublishedTemplateResponse> PublishedTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<PublishedTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/published-template", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "published-template";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<PublishedTemplateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UnpublishedTemplateResponse> UnpublishedTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<UnpublishedTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/unpublished-template", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "unpublished-template";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<UnpublishedTemplateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<UpdatedTemplateResponse> UpdatedTemplate(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<UpdatedTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/updated-template", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "updated-template";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<UpdatedTemplateResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<IssuedCRLResponse> IssuedCRL(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<IssuedCRLResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/issued-crl", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "issued-crl";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<IssuedCRLResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewConnectorActionResponse> NewConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<NewConnectorActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/new-connectoraction", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "new-connectoraction";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<NewConnectorActionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CompletedConnectorActionResponse> CompletedConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<CompletedConnectorActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/completed-action", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "completed-connectoraction";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CompletedConnectorActionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FailedConnectorActionResponse> FailedConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<FailedConnectorActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/failed-connectoraction", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "failed-connectoraction";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<FailedConnectorActionResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<StalledConnectorActionResponse> StalledConnectorAction(Expression<Func<string>> regionid, Expression<Func<string>> deploymentid, FlowRecurrence recurrence = null)
        {
            var __workflow_regionid = regionid == null ? null : WorkflowExpression.Compile(regionid);
            WorkflowExpression.Validate(__workflow_regionid, nameof(regionid), required: true);
            var __workflow_deploymentid = deploymentid == null ? null : WorkflowExpression.Compile(deploymentid);
            WorkflowExpression.Validate(__workflow_deploymentid, nameof(deploymentid), required: true);
            return new DeferredBodyTrigger<StalledConnectorActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/stalled-connectoraction", ExpressionConverter.ConvertWithUrlEncoding(__workflow_regionid, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackurl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["type"] = "web";
                bodypropCount++;
                body["events"] = "stalled-connectoraction";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyimportantInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        Approved,
        Denied,
        UpdateOnly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrenewalstatusInput
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
        public string PREVIOUSAPPROVALVALIDATEREENROLLMENT { get; set; }
        public string AUTOENROLLMENTCHECKUSERDSCERTIFICATE { get; set; }
        public string INCLUDEBASICCONSTRAINTSFOREECERTS { get; set; }
        public string REMOVEINVALIDCERTIFICATEFROMPERSONALSTORE { get; set; }
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
        public string EKVALIDATECERT { get; set; }
        public string EKVALIDATEKEY { get; set; }
        public string STRONGKEYPROTECTIONREQUIRED { get; set; }
        public string ATTESTATIONWITHOUTPOLICY { get; set; }
        public string EKTRUSTONUSE { get; set; }
        public string ATTESTREQUIRED { get; set; }
        public string USELEGACYPROVIDER { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyhiddenInput
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
        public string PREVIOUSAPPROVALVALIDATEREENROLLMENT { get; set; }
        public string AUTOENROLLMENTCHECKUSERDSCERTIFICATE { get; set; }
        public string INCLUDEBASICCONSTRAINTSFOREECERTS { get; set; }
        public string REMOVEINVALIDCERTIFICATEFROMPERSONALSTORE { get; set; }
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
        public string EKVALIDATECERT { get; set; }
        public string EKVALIDATEKEY { get; set; }
        public string STRONGKEYPROTECTIONREQUIRED { get; set; }
        public string ATTESTATIONWITHOUTPOLICY { get; set; }
        public string EKTRUSTONUSE { get; set; }
        public string ATTESTREQUIRED { get; set; }
        public string USELEGACYPROVIDER { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyurgentInput
    {
        True,
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrenewalInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        Web,
        Email,
        PowerBI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventsInputItem
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

    public class RemovedHookResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class RevokedCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class ExpiringCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class RenewingCertificateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class ApprovedRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class UpdatedRequestResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class PublishedTemplateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class UpdatedTemplateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class NewConnectorActionResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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

    public class FailedConnectorActionResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("hookid")]
        public string Hookid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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
