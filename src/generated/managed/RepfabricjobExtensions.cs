//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricjob
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RepfabricjobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "repfabricjob")]
        public IWorkflowAction RepfabricCreateJob(Expression<Func<string>> bodydomainName, Expression<Func<string>> bodyjobName, Expression<Func<string>> bodycompany, Expression<Func<string>> bodycontactFirstName, Expression<Func<string>> bodyjobNumber = null, Expression<Func<string>> bodyjobBidDate = null, Expression<Func<string>> bodyjobOrderDate = null, Expression<Func<string>> bodyjobTypeName = null, Expression<Func<string>> bodyjobStage = null, Expression<Func<string>> bodyjobValue = null, Expression<Func<string>> bodystreet1 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzip = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyjobUrl = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanySalesTeam = null, Expression<Func<int>> bodycompanySalesTeamId = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactFullName = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodycontactPhone = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactStreet1 = null, Expression<Func<string>> bodycontactCity = null, Expression<Func<string>> bodycontactState = null, Expression<Func<string>> bodycontactZip = null, Expression<Func<bool>> bodycontactPrimaryContact = null)
        {
            var __workflow_bodydomainName = WorkflowExpression.Compile(bodydomainName, nameof(bodydomainName), required: true);
            var __workflow_bodyjobName = WorkflowExpression.Compile(bodyjobName, nameof(bodyjobName), required: true);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: true);
            var __workflow_bodycontactFirstName = WorkflowExpression.Compile(bodycontactFirstName, nameof(bodycontactFirstName), required: true);
            var __workflow_bodyjobNumber = WorkflowExpression.Compile(bodyjobNumber, nameof(bodyjobNumber), required: false);
            var __workflow_bodyjobBidDate = WorkflowExpression.Compile(bodyjobBidDate, nameof(bodyjobBidDate), required: false);
            var __workflow_bodyjobOrderDate = WorkflowExpression.Compile(bodyjobOrderDate, nameof(bodyjobOrderDate), required: false);
            var __workflow_bodyjobTypeName = WorkflowExpression.Compile(bodyjobTypeName, nameof(bodyjobTypeName), required: false);
            var __workflow_bodyjobStage = WorkflowExpression.Compile(bodyjobStage, nameof(bodyjobStage), required: false);
            var __workflow_bodyjobValue = WorkflowExpression.Compile(bodyjobValue, nameof(bodyjobValue), required: false);
            var __workflow_bodystreet1 = WorkflowExpression.Compile(bodystreet1, nameof(bodystreet1), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyzip = WorkflowExpression.Compile(bodyzip, nameof(bodyzip), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyjobUrl = WorkflowExpression.Compile(bodyjobUrl, nameof(bodyjobUrl), required: false);
            var __workflow_bodycompanyPhone1 = WorkflowExpression.Compile(bodycompanyPhone1, nameof(bodycompanyPhone1), required: false);
            var __workflow_bodycompanyFax = WorkflowExpression.Compile(bodycompanyFax, nameof(bodycompanyFax), required: false);
            var __workflow_bodycompanyType = WorkflowExpression.Compile(bodycompanyType, nameof(bodycompanyType), required: false);
            var __workflow_bodycompanyWebsite = WorkflowExpression.Compile(bodycompanyWebsite, nameof(bodycompanyWebsite), required: false);
            var __workflow_bodycompanySalesTeam = WorkflowExpression.Compile(bodycompanySalesTeam, nameof(bodycompanySalesTeam), required: false);
            var __workflow_bodycompanySalesTeamId = WorkflowExpression.Compile(bodycompanySalesTeamId, nameof(bodycompanySalesTeamId), required: false);
            var __workflow_bodycontactLastName = WorkflowExpression.Compile(bodycontactLastName, nameof(bodycontactLastName), required: false);
            var __workflow_bodycontactFullName = WorkflowExpression.Compile(bodycontactFullName, nameof(bodycontactFullName), required: false);
            var __workflow_bodycontactTitle = WorkflowExpression.Compile(bodycontactTitle, nameof(bodycontactTitle), required: false);
            var __workflow_bodycontactEmail = WorkflowExpression.Compile(bodycontactEmail, nameof(bodycontactEmail), required: false);
            var __workflow_bodycontactPhone = WorkflowExpression.Compile(bodycontactPhone, nameof(bodycontactPhone), required: false);
            var __workflow_bodycontactFax = WorkflowExpression.Compile(bodycontactFax, nameof(bodycontactFax), required: false);
            var __workflow_bodycontactStreet1 = WorkflowExpression.Compile(bodycontactStreet1, nameof(bodycontactStreet1), required: false);
            var __workflow_bodycontactCity = WorkflowExpression.Compile(bodycontactCity, nameof(bodycontactCity), required: false);
            var __workflow_bodycontactState = WorkflowExpression.Compile(bodycontactState, nameof(bodycontactState), required: false);
            var __workflow_bodycontactZip = WorkflowExpression.Compile(bodycontactZip, nameof(bodycontactZip), required: false);
            var __workflow_bodycontactPrimaryContact = WorkflowExpression.Compile(bodycontactPrimaryContact, nameof(bodycontactPrimaryContact), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/default/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = ExpressionConverter.ConvertO(__workflow_bodydomainName);
                bodypropCount++;
                body["job-name"] = ExpressionConverter.ConvertO(__workflow_bodyjobName);
                if (__workflow_bodyjobNumber != null)
                {
                    body["job-number"] = ExpressionConverter.ConvertO(__workflow_bodyjobNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyjobBidDate != null)
                {
                    body["job-bid-date"] = ExpressionConverter.ConvertO(__workflow_bodyjobBidDate);
                    bodypropCount++;
                }

                if (__workflow_bodyjobOrderDate != null)
                {
                    body["job-order-date"] = ExpressionConverter.ConvertO(__workflow_bodyjobOrderDate);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTypeName != null)
                {
                    body["job-type-name"] = ExpressionConverter.ConvertO(__workflow_bodyjobTypeName);
                    bodypropCount++;
                }

                if (__workflow_bodyjobStage != null)
                {
                    body["job-stage"] = ExpressionConverter.ConvertO(__workflow_bodyjobStage);
                    bodypropCount++;
                }

                if (__workflow_bodyjobValue != null)
                {
                    body["job-value"] = ExpressionConverter.ConvertO(__workflow_bodyjobValue);
                    bodypropCount++;
                }

                if (__workflow_bodystreet1 != null)
                {
                    body["street-1"] = ExpressionConverter.ConvertO(__workflow_bodystreet1);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyzip != null)
                {
                    body["zip"] = ExpressionConverter.ConvertO(__workflow_bodyzip);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyjobUrl != null)
                {
                    body["job-url"] = ExpressionConverter.ConvertO(__workflow_bodyjobUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                if (__workflow_bodycompanyPhone1 != null)
                {
                    body["company-phone1"] = ExpressionConverter.ConvertO(__workflow_bodycompanyPhone1);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyFax != null)
                {
                    body["company-fax"] = ExpressionConverter.ConvertO(__workflow_bodycompanyFax);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyType != null)
                {
                    body["company-type"] = ExpressionConverter.ConvertO(__workflow_bodycompanyType);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyWebsite != null)
                {
                    body["company-website"] = ExpressionConverter.ConvertO(__workflow_bodycompanyWebsite);
                    bodypropCount++;
                }

                if (__workflow_bodycompanySalesTeam != null)
                {
                    body["company-sales-team"] = ExpressionConverter.ConvertO(__workflow_bodycompanySalesTeam);
                    bodypropCount++;
                }

                if (__workflow_bodycompanySalesTeamId != null)
                {
                    body["company-sales-team-id"] = ExpressionConverter.ConvertO(__workflow_bodycompanySalesTeamId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contact-first-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactFirstName);
                if (__workflow_bodycontactLastName != null)
                {
                    body["contact-last-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactLastName);
                    bodypropCount++;
                }

                if (__workflow_bodycontactFullName != null)
                {
                    body["contact-full-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactFullName);
                    bodypropCount++;
                }

                if (__workflow_bodycontactTitle != null)
                {
                    body["contact-title"] = ExpressionConverter.ConvertO(__workflow_bodycontactTitle);
                    bodypropCount++;
                }

                if (__workflow_bodycontactEmail != null)
                {
                    body["contact-email"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmail);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPhone != null)
                {
                    body["contact-phone"] = ExpressionConverter.ConvertO(__workflow_bodycontactPhone);
                    bodypropCount++;
                }

                if (__workflow_bodycontactFax != null)
                {
                    body["contact-fax"] = ExpressionConverter.ConvertO(__workflow_bodycontactFax);
                    bodypropCount++;
                }

                if (__workflow_bodycontactStreet1 != null)
                {
                    body["contact-street-1"] = ExpressionConverter.ConvertO(__workflow_bodycontactStreet1);
                    bodypropCount++;
                }

                if (__workflow_bodycontactCity != null)
                {
                    body["contact-city"] = ExpressionConverter.ConvertO(__workflow_bodycontactCity);
                    bodypropCount++;
                }

                if (__workflow_bodycontactState != null)
                {
                    body["contact-state"] = ExpressionConverter.ConvertO(__workflow_bodycontactState);
                    bodypropCount++;
                }

                if (__workflow_bodycontactZip != null)
                {
                    body["contact-zip"] = ExpressionConverter.ConvertO(__workflow_bodycontactZip);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPrimaryContact != null)
                {
                    body["contact-primary-contact"] = ExpressionConverter.ConvertO(__workflow_bodycontactPrimaryContact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class RepfabricjobTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricjob;

    public partial class WorkflowManagedActions
    {
        public RepfabricjobActions Repfabricjob(string connectionId) => new RepfabricjobActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RepfabricjobTriggers Repfabricjob(string connectionId) => new RepfabricjobTriggers(connectionId);
    }
}
