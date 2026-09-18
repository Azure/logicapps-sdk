//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricjob
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RepfabricjobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "repfabricjob")]
        public IWorkflowAction RepfabricCreateJob([WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<string> bodyjobName, [WorkflowExpression] Func<string> bodycompany, [WorkflowExpression] Func<string> bodycontactFirstName, [WorkflowExpression] Func<string> bodyjobNumber = null, [WorkflowExpression] Func<string> bodyjobBidDate = null, [WorkflowExpression] Func<string> bodyjobOrderDate = null, [WorkflowExpression] Func<string> bodyjobTypeName = null, [WorkflowExpression] Func<string> bodyjobStage = null, [WorkflowExpression] Func<string> bodyjobValue = null, [WorkflowExpression] Func<string> bodystreet1 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzip = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyjobUrl = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyFax = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycompanySalesTeam = null, [WorkflowExpression] Func<int> bodycompanySalesTeamId = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<string> bodycontactFullName = null, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodycontactPhone = null, [WorkflowExpression] Func<string> bodycontactFax = null, [WorkflowExpression] Func<string> bodycontactStreet1 = null, [WorkflowExpression] Func<string> bodycontactCity = null, [WorkflowExpression] Func<string> bodycontactState = null, [WorkflowExpression] Func<string> bodycontactZip = null, [WorkflowExpression] Func<bool> bodycontactPrimaryContact = null)
        {
            var apiCallPath = "/default/jobs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["domain-name"] = ExpressionConverter.ConvertO(bodydomainName);
            bodypropCount++;
            body["job-name"] = ExpressionConverter.ConvertO(bodyjobName);
            if (bodyjobNumber != null)
            {
                body["job-number"] = ExpressionConverter.ConvertO(bodyjobNumber);
                bodypropCount++;
            }

            if (bodyjobBidDate != null)
            {
                body["job-bid-date"] = ExpressionConverter.ConvertO(bodyjobBidDate);
                bodypropCount++;
            }

            if (bodyjobOrderDate != null)
            {
                body["job-order-date"] = ExpressionConverter.ConvertO(bodyjobOrderDate);
                bodypropCount++;
            }

            if (bodyjobTypeName != null)
            {
                body["job-type-name"] = ExpressionConverter.ConvertO(bodyjobTypeName);
                bodypropCount++;
            }

            if (bodyjobStage != null)
            {
                body["job-stage"] = ExpressionConverter.ConvertO(bodyjobStage);
                bodypropCount++;
            }

            if (bodyjobValue != null)
            {
                body["job-value"] = ExpressionConverter.ConvertO(bodyjobValue);
                bodypropCount++;
            }

            if (bodystreet1 != null)
            {
                body["street-1"] = ExpressionConverter.ConvertO(bodystreet1);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodyzip != null)
            {
                body["zip"] = ExpressionConverter.ConvertO(bodyzip);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyjobUrl != null)
            {
                body["job-url"] = ExpressionConverter.ConvertO(bodyjobUrl);
                bodypropCount++;
            }

            bodypropCount++;
            body["company"] = ExpressionConverter.ConvertO(bodycompany);
            if (bodycompanyPhone1 != null)
            {
                body["company-phone1"] = ExpressionConverter.ConvertO(bodycompanyPhone1);
                bodypropCount++;
            }

            if (bodycompanyFax != null)
            {
                body["company-fax"] = ExpressionConverter.ConvertO(bodycompanyFax);
                bodypropCount++;
            }

            if (bodycompanyType != null)
            {
                body["company-type"] = ExpressionConverter.ConvertO(bodycompanyType);
                bodypropCount++;
            }

            if (bodycompanyWebsite != null)
            {
                body["company-website"] = ExpressionConverter.ConvertO(bodycompanyWebsite);
                bodypropCount++;
            }

            if (bodycompanySalesTeam != null)
            {
                body["company-sales-team"] = ExpressionConverter.ConvertO(bodycompanySalesTeam);
                bodypropCount++;
            }

            if (bodycompanySalesTeamId != null)
            {
                body["company-sales-team-id"] = ExpressionConverter.ConvertO(bodycompanySalesTeamId);
                bodypropCount++;
            }

            bodypropCount++;
            body["contact-first-name"] = ExpressionConverter.ConvertO(bodycontactFirstName);
            if (bodycontactLastName != null)
            {
                body["contact-last-name"] = ExpressionConverter.ConvertO(bodycontactLastName);
                bodypropCount++;
            }

            if (bodycontactFullName != null)
            {
                body["contact-full-name"] = ExpressionConverter.ConvertO(bodycontactFullName);
                bodypropCount++;
            }

            if (bodycontactTitle != null)
            {
                body["contact-title"] = ExpressionConverter.ConvertO(bodycontactTitle);
                bodypropCount++;
            }

            if (bodycontactEmail != null)
            {
                body["contact-email"] = ExpressionConverter.ConvertO(bodycontactEmail);
                bodypropCount++;
            }

            if (bodycontactPhone != null)
            {
                body["contact-phone"] = ExpressionConverter.ConvertO(bodycontactPhone);
                bodypropCount++;
            }

            if (bodycontactFax != null)
            {
                body["contact-fax"] = ExpressionConverter.ConvertO(bodycontactFax);
                bodypropCount++;
            }

            if (bodycontactStreet1 != null)
            {
                body["contact-street-1"] = ExpressionConverter.ConvertO(bodycontactStreet1);
                bodypropCount++;
            }

            if (bodycontactCity != null)
            {
                body["contact-city"] = ExpressionConverter.ConvertO(bodycontactCity);
                bodypropCount++;
            }

            if (bodycontactState != null)
            {
                body["contact-state"] = ExpressionConverter.ConvertO(bodycontactState);
                bodypropCount++;
            }

            if (bodycontactZip != null)
            {
                body["contact-zip"] = ExpressionConverter.ConvertO(bodycontactZip);
                bodypropCount++;
            }

            if (bodycontactPrimaryContact != null)
            {
                body["contact-primary-contact"] = ExpressionConverter.ConvertO(bodycontactPrimaryContact);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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