//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricjob
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class RepfabricjobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "repfabricjob")]
        public IWorkflowAction RepfabricCreateJob(Expression<Func<string>> bodydomainName, Expression<Func<string>> bodyjobName, Expression<Func<string>> bodycompany, Expression<Func<string>> bodycontactFirstName, Expression<Func<string>> bodyjobNumber = null, Expression<Func<string>> bodyjobBidDate = null, Expression<Func<string>> bodyjobOrderDate = null, Expression<Func<string>> bodyjobTypeName = null, Expression<Func<string>> bodyjobStage = null, Expression<Func<string>> bodyjobValue = null, Expression<Func<string>> bodystreet1 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzip = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyjobUrl = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanySalesTeam = null, Expression<Func<int>> bodycompanySalesTeamId = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactFullName = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodycontactPhone = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactStreet1 = null, Expression<Func<string>> bodycontactCity = null, Expression<Func<string>> bodycontactState = null, Expression<Func<string>> bodycontactZip = null, Expression<Func<bool>> bodycontactPrimaryContact = null)
        {
            var __workflow_bodydomainName = bodydomainName == null ? null : WorkflowExpression.Compile(bodydomainName);
            WorkflowExpression.Validate(__workflow_bodydomainName, nameof(bodydomainName), required: true);
            var __workflow_bodyjobName = bodyjobName == null ? null : WorkflowExpression.Compile(bodyjobName);
            WorkflowExpression.Validate(__workflow_bodyjobName, nameof(bodyjobName), required: true);
            var __workflow_bodycompany = bodycompany == null ? null : WorkflowExpression.Compile(bodycompany);
            WorkflowExpression.Validate(__workflow_bodycompany, nameof(bodycompany), required: true);
            var __workflow_bodycontactFirstName = bodycontactFirstName == null ? null : WorkflowExpression.Compile(bodycontactFirstName);
            WorkflowExpression.Validate(__workflow_bodycontactFirstName, nameof(bodycontactFirstName), required: true);
            var __workflow_bodyjobNumber = bodyjobNumber == null ? null : WorkflowExpression.Compile(bodyjobNumber);
            WorkflowExpression.Validate(__workflow_bodyjobNumber, nameof(bodyjobNumber), required: false);
            var __workflow_bodyjobBidDate = bodyjobBidDate == null ? null : WorkflowExpression.Compile(bodyjobBidDate);
            WorkflowExpression.Validate(__workflow_bodyjobBidDate, nameof(bodyjobBidDate), required: false);
            var __workflow_bodyjobOrderDate = bodyjobOrderDate == null ? null : WorkflowExpression.Compile(bodyjobOrderDate);
            WorkflowExpression.Validate(__workflow_bodyjobOrderDate, nameof(bodyjobOrderDate), required: false);
            var __workflow_bodyjobTypeName = bodyjobTypeName == null ? null : WorkflowExpression.Compile(bodyjobTypeName);
            WorkflowExpression.Validate(__workflow_bodyjobTypeName, nameof(bodyjobTypeName), required: false);
            var __workflow_bodyjobStage = bodyjobStage == null ? null : WorkflowExpression.Compile(bodyjobStage);
            WorkflowExpression.Validate(__workflow_bodyjobStage, nameof(bodyjobStage), required: false);
            var __workflow_bodyjobValue = bodyjobValue == null ? null : WorkflowExpression.Compile(bodyjobValue);
            WorkflowExpression.Validate(__workflow_bodyjobValue, nameof(bodyjobValue), required: false);
            var __workflow_bodystreet1 = bodystreet1 == null ? null : WorkflowExpression.Compile(bodystreet1);
            WorkflowExpression.Validate(__workflow_bodystreet1, nameof(bodystreet1), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = bodystate == null ? null : WorkflowExpression.Compile(bodystate);
            WorkflowExpression.Validate(__workflow_bodystate, nameof(bodystate), required: false);
            var __workflow_bodyzip = bodyzip == null ? null : WorkflowExpression.Compile(bodyzip);
            WorkflowExpression.Validate(__workflow_bodyzip, nameof(bodyzip), required: false);
            var __workflow_bodycountry = bodycountry == null ? null : WorkflowExpression.Compile(bodycountry);
            WorkflowExpression.Validate(__workflow_bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyjobUrl = bodyjobUrl == null ? null : WorkflowExpression.Compile(bodyjobUrl);
            WorkflowExpression.Validate(__workflow_bodyjobUrl, nameof(bodyjobUrl), required: false);
            var __workflow_bodycompanyPhone1 = bodycompanyPhone1 == null ? null : WorkflowExpression.Compile(bodycompanyPhone1);
            WorkflowExpression.Validate(__workflow_bodycompanyPhone1, nameof(bodycompanyPhone1), required: false);
            var __workflow_bodycompanyFax = bodycompanyFax == null ? null : WorkflowExpression.Compile(bodycompanyFax);
            WorkflowExpression.Validate(__workflow_bodycompanyFax, nameof(bodycompanyFax), required: false);
            var __workflow_bodycompanyType = bodycompanyType == null ? null : WorkflowExpression.Compile(bodycompanyType);
            WorkflowExpression.Validate(__workflow_bodycompanyType, nameof(bodycompanyType), required: false);
            var __workflow_bodycompanyWebsite = bodycompanyWebsite == null ? null : WorkflowExpression.Compile(bodycompanyWebsite);
            WorkflowExpression.Validate(__workflow_bodycompanyWebsite, nameof(bodycompanyWebsite), required: false);
            var __workflow_bodycompanySalesTeam = bodycompanySalesTeam == null ? null : WorkflowExpression.Compile(bodycompanySalesTeam);
            WorkflowExpression.Validate(__workflow_bodycompanySalesTeam, nameof(bodycompanySalesTeam), required: false);
            var __workflow_bodycompanySalesTeamId = bodycompanySalesTeamId == null ? null : WorkflowExpression.Compile(bodycompanySalesTeamId);
            WorkflowExpression.Validate(__workflow_bodycompanySalesTeamId, nameof(bodycompanySalesTeamId), required: false);
            var __workflow_bodycontactLastName = bodycontactLastName == null ? null : WorkflowExpression.Compile(bodycontactLastName);
            WorkflowExpression.Validate(__workflow_bodycontactLastName, nameof(bodycontactLastName), required: false);
            var __workflow_bodycontactFullName = bodycontactFullName == null ? null : WorkflowExpression.Compile(bodycontactFullName);
            WorkflowExpression.Validate(__workflow_bodycontactFullName, nameof(bodycontactFullName), required: false);
            var __workflow_bodycontactTitle = bodycontactTitle == null ? null : WorkflowExpression.Compile(bodycontactTitle);
            WorkflowExpression.Validate(__workflow_bodycontactTitle, nameof(bodycontactTitle), required: false);
            var __workflow_bodycontactEmail = bodycontactEmail == null ? null : WorkflowExpression.Compile(bodycontactEmail);
            WorkflowExpression.Validate(__workflow_bodycontactEmail, nameof(bodycontactEmail), required: false);
            var __workflow_bodycontactPhone = bodycontactPhone == null ? null : WorkflowExpression.Compile(bodycontactPhone);
            WorkflowExpression.Validate(__workflow_bodycontactPhone, nameof(bodycontactPhone), required: false);
            var __workflow_bodycontactFax = bodycontactFax == null ? null : WorkflowExpression.Compile(bodycontactFax);
            WorkflowExpression.Validate(__workflow_bodycontactFax, nameof(bodycontactFax), required: false);
            var __workflow_bodycontactStreet1 = bodycontactStreet1 == null ? null : WorkflowExpression.Compile(bodycontactStreet1);
            WorkflowExpression.Validate(__workflow_bodycontactStreet1, nameof(bodycontactStreet1), required: false);
            var __workflow_bodycontactCity = bodycontactCity == null ? null : WorkflowExpression.Compile(bodycontactCity);
            WorkflowExpression.Validate(__workflow_bodycontactCity, nameof(bodycontactCity), required: false);
            var __workflow_bodycontactState = bodycontactState == null ? null : WorkflowExpression.Compile(bodycontactState);
            WorkflowExpression.Validate(__workflow_bodycontactState, nameof(bodycontactState), required: false);
            var __workflow_bodycontactZip = bodycontactZip == null ? null : WorkflowExpression.Compile(bodycontactZip);
            WorkflowExpression.Validate(__workflow_bodycontactZip, nameof(bodycontactZip), required: false);
            var __workflow_bodycontactPrimaryContact = bodycontactPrimaryContact == null ? null : WorkflowExpression.Compile(bodycontactPrimaryContact);
            WorkflowExpression.Validate(__workflow_bodycontactPrimaryContact, nameof(bodycontactPrimaryContact), required: false);
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
            });
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
