//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricjob
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RepfabricjobActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "repfabricjob")]
        public IWorkflowAction RepfabricCreateJob(Expression<Func<string>> bodydomainName, Expression<Func<string>> bodyjobName, Expression<Func<string>> bodycompany, Expression<Func<string>> bodycontactFirstName, Expression<Func<string>> bodyjobNumber = null, Expression<Func<string>> bodyjobBidDate = null, Expression<Func<string>> bodyjobOrderDate = null, Expression<Func<string>> bodyjobTypeName = null, Expression<Func<string>> bodyjobStage = null, Expression<Func<string>> bodyjobValue = null, Expression<Func<string>> bodystreet1 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzip = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyjobUrl = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanySalesTeam = null, Expression<Func<int>> bodycompanySalesTeamId = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactFullName = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactEmail = null, Expression<Func<string>> bodycontactPhone = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactStreet1 = null, Expression<Func<string>> bodycontactCity = null, Expression<Func<string>> bodycontactState = null, Expression<Func<string>> bodycontactZip = null, Expression<Func<bool>> bodycontactPrimaryContact = null)
        {
            var apiCallPath = "/default/jobs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["domain-name"] = CSharpExpressionConverter.ConvertToken(bodydomainName);
            bodypropCount++;
            body["job-name"] = CSharpExpressionConverter.ConvertToken(bodyjobName);
            if (bodyjobNumber != null)
            {
                body["job-number"] = CSharpExpressionConverter.ConvertToken(bodyjobNumber);
                bodypropCount++;
            }

            if (bodyjobBidDate != null)
            {
                body["job-bid-date"] = CSharpExpressionConverter.ConvertToken(bodyjobBidDate);
                bodypropCount++;
            }

            if (bodyjobOrderDate != null)
            {
                body["job-order-date"] = CSharpExpressionConverter.ConvertToken(bodyjobOrderDate);
                bodypropCount++;
            }

            if (bodyjobTypeName != null)
            {
                body["job-type-name"] = CSharpExpressionConverter.ConvertToken(bodyjobTypeName);
                bodypropCount++;
            }

            if (bodyjobStage != null)
            {
                body["job-stage"] = CSharpExpressionConverter.ConvertToken(bodyjobStage);
                bodypropCount++;
            }

            if (bodyjobValue != null)
            {
                body["job-value"] = CSharpExpressionConverter.ConvertToken(bodyjobValue);
                bodypropCount++;
            }

            if (bodystreet1 != null)
            {
                body["street-1"] = CSharpExpressionConverter.ConvertToken(bodystreet1);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodyzip != null)
            {
                body["zip"] = CSharpExpressionConverter.ConvertToken(bodyzip);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodyjobUrl != null)
            {
                body["job-url"] = CSharpExpressionConverter.ConvertToken(bodyjobUrl);
                bodypropCount++;
            }

            bodypropCount++;
            body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
            if (bodycompanyPhone1 != null)
            {
                body["company-phone1"] = CSharpExpressionConverter.ConvertToken(bodycompanyPhone1);
                bodypropCount++;
            }

            if (bodycompanyFax != null)
            {
                body["company-fax"] = CSharpExpressionConverter.ConvertToken(bodycompanyFax);
                bodypropCount++;
            }

            if (bodycompanyType != null)
            {
                body["company-type"] = CSharpExpressionConverter.ConvertToken(bodycompanyType);
                bodypropCount++;
            }

            if (bodycompanyWebsite != null)
            {
                body["company-website"] = CSharpExpressionConverter.ConvertToken(bodycompanyWebsite);
                bodypropCount++;
            }

            if (bodycompanySalesTeam != null)
            {
                body["company-sales-team"] = CSharpExpressionConverter.ConvertToken(bodycompanySalesTeam);
                bodypropCount++;
            }

            if (bodycompanySalesTeamId != null)
            {
                body["company-sales-team-id"] = CSharpExpressionConverter.ConvertToken(bodycompanySalesTeamId);
                bodypropCount++;
            }

            bodypropCount++;
            body["contact-first-name"] = CSharpExpressionConverter.ConvertToken(bodycontactFirstName);
            if (bodycontactLastName != null)
            {
                body["contact-last-name"] = CSharpExpressionConverter.ConvertToken(bodycontactLastName);
                bodypropCount++;
            }

            if (bodycontactFullName != null)
            {
                body["contact-full-name"] = CSharpExpressionConverter.ConvertToken(bodycontactFullName);
                bodypropCount++;
            }

            if (bodycontactTitle != null)
            {
                body["contact-title"] = CSharpExpressionConverter.ConvertToken(bodycontactTitle);
                bodypropCount++;
            }

            if (bodycontactEmail != null)
            {
                body["contact-email"] = CSharpExpressionConverter.ConvertToken(bodycontactEmail);
                bodypropCount++;
            }

            if (bodycontactPhone != null)
            {
                body["contact-phone"] = CSharpExpressionConverter.ConvertToken(bodycontactPhone);
                bodypropCount++;
            }

            if (bodycontactFax != null)
            {
                body["contact-fax"] = CSharpExpressionConverter.ConvertToken(bodycontactFax);
                bodypropCount++;
            }

            if (bodycontactStreet1 != null)
            {
                body["contact-street-1"] = CSharpExpressionConverter.ConvertToken(bodycontactStreet1);
                bodypropCount++;
            }

            if (bodycontactCity != null)
            {
                body["contact-city"] = CSharpExpressionConverter.ConvertToken(bodycontactCity);
                bodypropCount++;
            }

            if (bodycontactState != null)
            {
                body["contact-state"] = CSharpExpressionConverter.ConvertToken(bodycontactState);
                bodypropCount++;
            }

            if (bodycontactZip != null)
            {
                body["contact-zip"] = CSharpExpressionConverter.ConvertToken(bodycontactZip);
                bodypropCount++;
            }

            if (bodycontactPrimaryContact != null)
            {
                body["contact-primary-contact"] = CSharpExpressionConverter.ConvertToken(bodycontactPrimaryContact);
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