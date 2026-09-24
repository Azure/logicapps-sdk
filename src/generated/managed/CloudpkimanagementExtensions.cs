//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudpkimanagement
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudpkimanagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryCertificatesResponseItem[]> QueryCertificates([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<timevalidInput> timevalid = null, [WorkflowExpression] Func<string> important = null, [WorkflowExpression] Func<string> renewalstatus = null, [WorkflowExpression] Func<int> expiring = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> serialnumber = null, [WorkflowExpression] Func<string> ski = null, [WorkflowExpression] Func<string> aki = null, [WorkflowExpression] Func<string> keytype = null, [WorkflowExpression] Func<int> keylength = null, [WorkflowExpression] Func<string> owneremail = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(timevalid, nameof(timevalid), required: false);
            SourceExpression.Validate(important, nameof(important), required: false);
            SourceExpression.Validate(renewalstatus, nameof(renewalstatus), required: false);
            SourceExpression.Validate(expiring, nameof(expiring), required: false);
            SourceExpression.Validate(subject, nameof(subject), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(serialnumber, nameof(serialnumber), required: false);
            SourceExpression.Validate(ski, nameof(ski), required: false);
            SourceExpression.Validate(aki, nameof(aki), required: false);
            SourceExpression.Validate(keytype, nameof(keytype), required: false);
            SourceExpression.Validate(keylength, nameof(keylength), required: false);
            SourceExpression.Validate(owneremail, nameof(owneremail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/certificates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timevalid != null)
                    callPayload.Queries["timevalid"] = SourceExpressionConverter.Convert(timevalid);
                if (important != null)
                    callPayload.Queries["important"] = SourceExpressionConverter.ConvertO(important);
                if (renewalstatus != null)
                    callPayload.Queries["renewalstatus"] = SourceExpressionConverter.ConvertO(renewalstatus);
                if (expiring != null)
                    callPayload.Queries["expiring"] = SourceExpressionConverter.ConvertO(expiring);
                if (subject != null)
                    callPayload.Queries["subject"] = SourceExpressionConverter.ConvertO(subject);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (serialnumber != null)
                    callPayload.Queries["serialnumber"] = SourceExpressionConverter.ConvertO(serialnumber);
                if (ski != null)
                    callPayload.Queries["ski"] = SourceExpressionConverter.ConvertO(ski);
                if (aki != null)
                    callPayload.Queries["aki"] = SourceExpressionConverter.ConvertO(aki);
                if (keytype != null)
                    callPayload.Queries["keytype"] = SourceExpressionConverter.ConvertO(keytype);
                if (keylength != null)
                    callPayload.Queries["keylength"] = SourceExpressionConverter.ConvertO(keylength);
                if (owneremail != null)
                    callPayload.Queries["owneremail"] = SourceExpressionConverter.ConvertO(owneremail);
                return callPayload;
            }

            return new ApiConnectionAction<QueryCertificatesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetCertificateResponse> GetCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> thumbprint)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(thumbprint, nameof(thumbprint), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/certificates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(thumbprint, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCertificateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateCertificateResponse> UpdateCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> thumbprint, [WorkflowExpression] Func<powerappsInput> powerapps, [WorkflowExpression] Func<bodyimportantInput> bodyimportant = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<bodyrenewalstatusInput> bodyrenewalstatus = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<string> bodyowneremail = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(thumbprint, nameof(thumbprint), required: true);
            SourceExpression.Validate(powerapps, nameof(powerapps), required: true);
            SourceExpression.Validate(bodyimportant, nameof(bodyimportant), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyrenewalstatus, nameof(bodyrenewalstatus), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            SourceExpression.Validate(bodyowneremail, nameof(bodyowneremail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/certificates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(thumbprint, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = SourceExpressionConverter.Convert(powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyimportant != null)
                {
                    body["important"] = SourceExpressionConverter.Convert(bodyimportant);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyrenewalstatus != null)
                {
                    body["renewalstatus"] = SourceExpressionConverter.Convert(bodyrenewalstatus);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["reference"] = SourceExpressionConverter.ConvertToken(bodyreference);
                    bodypropCount++;
                }

                if (bodyowneremail != null)
                {
                    body["owneremail"] = SourceExpressionConverter.ConvertToken(bodyowneremail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateCertificateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetTemplateResponse> GetTemplate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> templateid)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(templateid, nameof(templateid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/templates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateTemplateResponse> UpdateTemplate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> templateid, [WorkflowExpression] Func<powerappsInput> powerapps, [WorkflowExpression] Func<bodyimportantInput> bodyimportant = null, [WorkflowExpression] Func<bodyrenewalstatusInput> bodyrenewalstatus = null, [WorkflowExpression] Func<bodyhiddenInput> bodyhidden = null, [WorkflowExpression] Func<string> bodyowneremail = null, [WorkflowExpression] Func<string> bodyautoapproveid = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(templateid, nameof(templateid), required: true);
            SourceExpression.Validate(powerapps, nameof(powerapps), required: true);
            SourceExpression.Validate(bodyimportant, nameof(bodyimportant), required: false);
            SourceExpression.Validate(bodyrenewalstatus, nameof(bodyrenewalstatus), required: false);
            SourceExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            SourceExpression.Validate(bodyowneremail, nameof(bodyowneremail), required: false);
            SourceExpression.Validate(bodyautoapproveid, nameof(bodyautoapproveid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/templates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateid, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = SourceExpressionConverter.Convert(powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyimportant != null)
                {
                    body["important"] = SourceExpressionConverter.Convert(bodyimportant);
                    bodypropCount++;
                }

                if (bodyrenewalstatus != null)
                {
                    body["renewalstatus"] = SourceExpressionConverter.Convert(bodyrenewalstatus);
                    bodypropCount++;
                }

                if (bodyhidden != null)
                {
                    body["hidden"] = SourceExpressionConverter.Convert(bodyhidden);
                    bodypropCount++;
                }

                if (bodyowneremail != null)
                {
                    body["owneremail"] = SourceExpressionConverter.ConvertToken(bodyowneremail);
                    bodypropCount++;
                }

                if (bodyautoapproveid != null)
                {
                    body["autoapproveid"] = SourceExpressionConverter.ConvertToken(bodyautoapproveid);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryTemplatesResponseItem[]> QueryTemplates([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<versionInput> version = null, [WorkflowExpression] Func<string> templateoid = null, [WorkflowExpression] Func<keytypeInput> keytype = null, [WorkflowExpression] Func<int> minMinkeylength = null, [WorkflowExpression] Func<int> maxMinkeylength = null, [WorkflowExpression] Func<int> minValidity = null, [WorkflowExpression] Func<int> maxValidity = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(version, nameof(version), required: false);
            SourceExpression.Validate(templateoid, nameof(templateoid), required: false);
            SourceExpression.Validate(keytype, nameof(keytype), required: false);
            SourceExpression.Validate(minMinkeylength, nameof(minMinkeylength), required: false);
            SourceExpression.Validate(maxMinkeylength, nameof(maxMinkeylength), required: false);
            SourceExpression.Validate(minValidity, nameof(minValidity), required: false);
            SourceExpression.Validate(maxValidity, nameof(maxValidity), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/templates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                if (version != null)
                    callPayload.Queries["version"] = SourceExpressionConverter.Convert(version);
                if (templateoid != null)
                    callPayload.Queries["templateoid"] = SourceExpressionConverter.ConvertO(templateoid);
                if (keytype != null)
                    callPayload.Queries["keytype"] = SourceExpressionConverter.Convert(keytype);
                if (minMinkeylength != null)
                    callPayload.Queries["min-minkeylength"] = SourceExpressionConverter.ConvertO(minMinkeylength);
                if (maxMinkeylength != null)
                    callPayload.Queries["max-minkeylength"] = SourceExpressionConverter.ConvertO(maxMinkeylength);
                if (minValidity != null)
                    callPayload.Queries["min-validity"] = SourceExpressionConverter.ConvertO(minValidity);
                if (maxValidity != null)
                    callPayload.Queries["max-validity"] = SourceExpressionConverter.ConvertO(maxValidity);
                return callPayload;
            }

            return new ApiConnectionAction<QueryTemplatesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetCRLResponse> GetCRL([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> crlid)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(crlid, nameof(crlid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/crls/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(crlid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCRLResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryCRLsResponseItem[]> QueryCRLs([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> crlid = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> issued = null, [WorkflowExpression] Func<int> expiring = null, [WorkflowExpression] Func<string> crlnumber = null, [WorkflowExpression] Func<string> crlnumberdecimal = null, [WorkflowExpression] Func<string> aki = null, [WorkflowExpression] Func<string> serialnumber = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(crlid, nameof(crlid), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(issued, nameof(issued), required: false);
            SourceExpression.Validate(expiring, nameof(expiring), required: false);
            SourceExpression.Validate(crlnumber, nameof(crlnumber), required: false);
            SourceExpression.Validate(crlnumberdecimal, nameof(crlnumberdecimal), required: false);
            SourceExpression.Validate(aki, nameof(aki), required: false);
            SourceExpression.Validate(serialnumber, nameof(serialnumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/crls", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (crlid != null)
                    callPayload.Queries["crlid"] = SourceExpressionConverter.ConvertO(crlid);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (issued != null)
                    callPayload.Queries["issued"] = SourceExpressionConverter.ConvertO(issued);
                if (expiring != null)
                    callPayload.Queries["expiring"] = SourceExpressionConverter.ConvertO(expiring);
                if (crlnumber != null)
                    callPayload.Queries["crlnumber"] = SourceExpressionConverter.ConvertO(crlnumber);
                if (crlnumberdecimal != null)
                    callPayload.Queries["crlnumberdecimal"] = SourceExpressionConverter.ConvertO(crlnumberdecimal);
                if (aki != null)
                    callPayload.Queries["aki"] = SourceExpressionConverter.ConvertO(aki);
                if (serialnumber != null)
                    callPayload.Queries["serialnumber"] = SourceExpressionConverter.ConvertO(serialnumber);
                return callPayload;
            }

            return new ApiConnectionAction<QueryCRLsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryRequestsResponseItem[]> QueryRequests([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> source = null, [WorkflowExpression] Func<string> approverid = null, [WorkflowExpression] Func<string> approveremail = null, [WorkflowExpression] Func<string> submitterid = null, [WorkflowExpression] Func<string> submitteremail = null, [WorkflowExpression] Func<string> owneremail = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(approverid, nameof(approverid), required: false);
            SourceExpression.Validate(approveremail, nameof(approveremail), required: false);
            SourceExpression.Validate(submitterid, nameof(submitterid), required: false);
            SourceExpression.Validate(submitteremail, nameof(submitteremail), required: false);
            SourceExpression.Validate(owneremail, nameof(owneremail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (approverid != null)
                    callPayload.Queries["approverid"] = SourceExpressionConverter.ConvertO(approverid);
                if (approveremail != null)
                    callPayload.Queries["approveremail"] = SourceExpressionConverter.ConvertO(approveremail);
                if (submitterid != null)
                    callPayload.Queries["submitterid"] = SourceExpressionConverter.ConvertO(submitterid);
                if (submitteremail != null)
                    callPayload.Queries["submitteremail"] = SourceExpressionConverter.ConvertO(submitteremail);
                if (owneremail != null)
                    callPayload.Queries["owneremail"] = SourceExpressionConverter.ConvertO(owneremail);
                return callPayload;
            }

            return new ApiConnectionAction<QueryRequestsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<NewRequestResponse> NewRequest([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<powerappsInput> powerapps, [WorkflowExpression] Func<string> bodycsr, [WorkflowExpression] Func<string> bodytemplateid = null, [WorkflowExpression] Func<string> bodyowneremail = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<bodyurgentInput> bodyurgent = null, [WorkflowExpression] Func<bodyimportantInput> bodyimportant = null, [WorkflowExpression] Func<bodyrenewalInput> bodyrenewal = null, [WorkflowExpression] Func<string> bodypreviouscertificate = null, [WorkflowExpression] Func<bodyrenewalstatusInput> bodyrenewalstatus = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(powerapps, nameof(powerapps), required: true);
            SourceExpression.Validate(bodycsr, nameof(bodycsr), required: true);
            SourceExpression.Validate(bodytemplateid, nameof(bodytemplateid), required: false);
            SourceExpression.Validate(bodyowneremail, nameof(bodyowneremail), required: false);
            SourceExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodyurgent, nameof(bodyurgent), required: false);
            SourceExpression.Validate(bodyimportant, nameof(bodyimportant), required: false);
            SourceExpression.Validate(bodyrenewal, nameof(bodyrenewal), required: false);
            SourceExpression.Validate(bodypreviouscertificate, nameof(bodypreviouscertificate), required: false);
            SourceExpression.Validate(bodyrenewalstatus, nameof(bodyrenewalstatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = SourceExpressionConverter.Convert(powerapps);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["csr"] = SourceExpressionConverter.ConvertToken(bodycsr);
                if (bodytemplateid != null)
                {
                    body["templateid"] = SourceExpressionConverter.ConvertToken(bodytemplateid);
                    bodypropCount++;
                }

                if (bodyowneremail != null)
                {
                    body["owneremail"] = SourceExpressionConverter.ConvertToken(bodyowneremail);
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["reference"] = SourceExpressionConverter.ConvertToken(bodyreference);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyurgent != null)
                {
                    if (bodyurgent != null)
                    {
                        body["urgent"] = SourceExpressionConverter.Convert(bodyurgent);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["urgent"] = "false";
                    bodypropCount++;
                }

                if (bodyimportant != null)
                {
                    if (bodyimportant != null)
                    {
                        body["important"] = SourceExpressionConverter.Convert(bodyimportant);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["important"] = "false";
                    bodypropCount++;
                }

                if (bodyrenewal != null)
                {
                    if (bodyrenewal != null)
                    {
                        body["renewal"] = SourceExpressionConverter.Convert(bodyrenewal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["renewal"] = "false";
                    bodypropCount++;
                }

                if (bodypreviouscertificate != null)
                {
                    if (bodypreviouscertificate != null)
                    {
                        body["previouscertificate"] = SourceExpressionConverter.ConvertToken(bodypreviouscertificate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["previouscertificate"] = "";
                    bodypropCount++;
                }

                if (bodyrenewalstatus != null)
                {
                    if (bodyrenewalstatus != null)
                    {
                        body["renewalstatus"] = SourceExpressionConverter.Convert(bodyrenewalstatus);
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
                return callPayload;
            }

            return new ApiConnectionAction<NewRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetRequestResponse> GetRequest([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> requestid)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(requestid, nameof(requestid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/requests/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<UpdateRequestResponse> UpdateRequest([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> requestid, [WorkflowExpression] Func<powerappsInput> powerapps, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<bodyurgentInput> bodyurgent = null, [WorkflowExpression] Func<bodyimportantInput> bodyimportant = null, [WorkflowExpression] Func<bodyrenewalstatusInput> bodyrenewalstatus = null, [WorkflowExpression] Func<string> bodytemplateid = null, [WorkflowExpression] Func<string> bodyowneremail = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(requestid, nameof(requestid), required: true);
            SourceExpression.Validate(powerapps, nameof(powerapps), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            SourceExpression.Validate(bodyurgent, nameof(bodyurgent), required: false);
            SourceExpression.Validate(bodyimportant, nameof(bodyimportant), required: false);
            SourceExpression.Validate(bodyrenewalstatus, nameof(bodyrenewalstatus), required: false);
            SourceExpression.Validate(bodytemplateid, nameof(bodytemplateid), required: false);
            SourceExpression.Validate(bodyowneremail, nameof(bodyowneremail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/requests/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestid, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = SourceExpressionConverter.Convert(powerapps);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/merge-patch+json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["reference"] = SourceExpressionConverter.ConvertToken(bodyreference);
                    bodypropCount++;
                }

                if (bodyurgent != null)
                {
                    body["urgent"] = SourceExpressionConverter.Convert(bodyurgent);
                    bodypropCount++;
                }

                if (bodyimportant != null)
                {
                    body["important"] = SourceExpressionConverter.Convert(bodyimportant);
                    bodypropCount++;
                }

                if (bodyrenewalstatus != null)
                {
                    body["renewalstatus"] = SourceExpressionConverter.Convert(bodyrenewalstatus);
                    bodypropCount++;
                }

                if (bodytemplateid != null)
                {
                    body["templateid"] = SourceExpressionConverter.ConvertToken(bodytemplateid);
                    bodypropCount++;
                }

                if (bodyowneremail != null)
                {
                    body["owneremail"] = SourceExpressionConverter.ConvertToken(bodyowneremail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<QueryHooksResponseItem[]> QueryHooks([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<@eventInput> @event = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(@event, nameof(@event), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                if (@event != null)
                    callPayload.Queries["event"] = SourceExpressionConverter.Convert(@event);
                return callPayload;
            }

            return new ApiConnectionAction<QueryHooksResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<NewHookResponse> NewHook([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<powerappsInput> powerapps, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<bodyeventsInputItem[]> bodyevents, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodycallbackurl = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(powerapps, nameof(powerapps), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyevents, nameof(bodyevents), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodycallbackurl, nameof(bodycallbackurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["powerapps"] = SourceExpressionConverter.Convert(powerapps);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodycallbackurl != null)
                {
                    body["callbackurl"] = SourceExpressionConverter.ConvertToken(bodycallbackurl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["events"] = SourceExpressionConverter.ConvertToken(bodyevents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NewHookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetHookResponse> GetHook([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> hookid)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(hookid, nameof(hookid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hookid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetHookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string> DeleteHook([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> hookid)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(hookid, nameof(hookid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(hookid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string> GetPublishedCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> thumbprint)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(thumbprint, nameof(thumbprint), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/published/certificates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(thumbprint, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetPublishedTemplatesResponseItem[]> GetPublishedTemplates([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/published/templates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPublishedTemplatesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetConnectorActionResponse> GetConnectorAction([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, [WorkflowExpression] Func<string> connectoractionid)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            SourceExpression.Validate(connectoractionid, nameof(connectoractionid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/connectoractions/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(connectoractionid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetConnectorActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<GetActionsResponseItem[]> GetActions([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetActionsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudpkimanagement")]
        public IBodyWorkflowAction<string> GetAuthentication()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/.auth/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class CloudpkimanagementTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AddedHookResponse> AddedHook([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/added-hook", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<AddedHookResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RemovedHookResponse> RemovedHook([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/removed-hook", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<RemovedHookResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IssuedCertificateResponse> IssuedCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/issued-certificate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<IssuedCertificateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RevokedCertificateResponse> RevokedCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/revoked-certificate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<RevokedCertificateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UpdatedCertificateResponse> UpdatedCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/updated-certificate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<UpdatedCertificateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ExpiringCertificateResponse> ExpiringCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/expiring-certificate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ExpiringCertificateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ExpiredCertificateResponse> ExpiredCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/expired-certificate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ExpiredCertificateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RenewingCertificateResponse> RenewingCertificate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/renewing-certificate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<RenewingCertificateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PendingRequestResponse> PendingRequest([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/pending-request", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<PendingRequestResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ApprovedRequestResponse> ApprovedRequest([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/approved-request", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<ApprovedRequestResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DeniedRequestResponse> DeniedRequest([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/denied-request", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<DeniedRequestResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UpdatedRequestResponse> UpdatedRequest([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/updated-request", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<UpdatedRequestResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FailedRequestResponse> FailedRequest([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/failed-request", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<FailedRequestResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PublishedTemplateResponse> PublishedTemplate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/published-template", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<PublishedTemplateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UnpublishedTemplateResponse> UnpublishedTemplate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/unpublished-template", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<UnpublishedTemplateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<UpdatedTemplateResponse> UpdatedTemplate([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/updated-template", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<UpdatedTemplateResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<IssuedCRLResponse> IssuedCRL([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/issued-crl", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<IssuedCRLResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<NewConnectorActionResponse> NewConnectorAction([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/new-connectoraction", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<NewConnectorActionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CompletedConnectorActionResponse> CompletedConnectorAction([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/completed-action", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<CompletedConnectorActionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FailedConnectorActionResponse> FailedConnectorAction([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/failed-connectoraction", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<FailedConnectorActionResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<StalledConnectorActionResponse> StalledConnectorAction([WorkflowExpression] Func<string> regionid, [WorkflowExpression] Func<string> deploymentid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(regionid, nameof(regionid), required: true);
            SourceExpression.Validate(deploymentid, nameof(deploymentid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/deployments/{1}/hooks/stalled-connectoraction", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(regionid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deploymentid, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<StalledConnectorActionResponse>(BuildSourceInput, triggerName, recurrence);
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

    public enum timevalidInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

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

    public enum powerappsInput
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public enum bodyimportantInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum bodystatusInput
    {
        Approved,
        Denied,
        UpdateOnly
    }

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

    public enum typeInput
    {
        Email,
        Web,
        PowerBI
    }

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

    public enum bodyurgentInput
    {
        True,
        False
    }

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

    public enum bodytypeInput
    {
        Web,
        Email,
        PowerBI
    }

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