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
        public IWorkflowAction RepfabricCreateJob([WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<string> bodyjobName, [WorkflowExpression] Func<string> bodycompany, [WorkflowExpression] Func<string> bodycontactFirstName, [WorkflowExpression] Func<string> bodyjobNumber = null, [WorkflowExpression] Func<string> bodyjobBidDate = null, [WorkflowExpression] Func<string> bodyjobOrderDate = null, [WorkflowExpression] Func<string> bodyjobTypeName = null, [WorkflowExpression] Func<string> bodyjobStage = null, [WorkflowExpression] Func<string> bodyjobValue = null, [WorkflowExpression] Func<string> bodystreet1 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzip = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyjobUrl = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyFax = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycompanySalesTeam = null, [WorkflowExpression] Func<int> bodycompanySalesTeamId = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<string> bodycontactFullName = null, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodycontactPhone = null, [WorkflowExpression] Func<string> bodycontactFax = null, [WorkflowExpression] Func<string> bodycontactStreet1 = null, [WorkflowExpression] Func<string> bodycontactCity = null, [WorkflowExpression] Func<string> bodycontactState = null, [WorkflowExpression] Func<string> bodycontactZip = null, [WorkflowExpression] Func<bool> bodycontactPrimaryContact = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/default/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = SourceExpressionConverter.ConvertToken(bodydomainName);
                bodypropCount++;
                body["job-name"] = SourceExpressionConverter.ConvertToken(bodyjobName);
                if (bodyjobNumber != null)
                {
                    body["job-number"] = SourceExpressionConverter.ConvertToken(bodyjobNumber);
                    bodypropCount++;
                }

                if (bodyjobBidDate != null)
                {
                    body["job-bid-date"] = SourceExpressionConverter.ConvertToken(bodyjobBidDate);
                    bodypropCount++;
                }

                if (bodyjobOrderDate != null)
                {
                    body["job-order-date"] = SourceExpressionConverter.ConvertToken(bodyjobOrderDate);
                    bodypropCount++;
                }

                if (bodyjobTypeName != null)
                {
                    body["job-type-name"] = SourceExpressionConverter.ConvertToken(bodyjobTypeName);
                    bodypropCount++;
                }

                if (bodyjobStage != null)
                {
                    body["job-stage"] = SourceExpressionConverter.ConvertToken(bodyjobStage);
                    bodypropCount++;
                }

                if (bodyjobValue != null)
                {
                    body["job-value"] = SourceExpressionConverter.ConvertToken(bodyjobValue);
                    bodypropCount++;
                }

                if (bodystreet1 != null)
                {
                    body["street-1"] = SourceExpressionConverter.ConvertToken(bodystreet1);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyzip != null)
                {
                    body["zip"] = SourceExpressionConverter.ConvertToken(bodyzip);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyjobUrl != null)
                {
                    body["job-url"] = SourceExpressionConverter.ConvertToken(bodyjobUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                if (bodycompanyPhone1 != null)
                {
                    body["company-phone1"] = SourceExpressionConverter.ConvertToken(bodycompanyPhone1);
                    bodypropCount++;
                }

                if (bodycompanyFax != null)
                {
                    body["company-fax"] = SourceExpressionConverter.ConvertToken(bodycompanyFax);
                    bodypropCount++;
                }

                if (bodycompanyType != null)
                {
                    body["company-type"] = SourceExpressionConverter.ConvertToken(bodycompanyType);
                    bodypropCount++;
                }

                if (bodycompanyWebsite != null)
                {
                    body["company-website"] = SourceExpressionConverter.ConvertToken(bodycompanyWebsite);
                    bodypropCount++;
                }

                if (bodycompanySalesTeam != null)
                {
                    body["company-sales-team"] = SourceExpressionConverter.ConvertToken(bodycompanySalesTeam);
                    bodypropCount++;
                }

                if (bodycompanySalesTeamId != null)
                {
                    body["company-sales-team-id"] = SourceExpressionConverter.ConvertToken(bodycompanySalesTeamId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contact-first-name"] = SourceExpressionConverter.ConvertToken(bodycontactFirstName);
                if (bodycontactLastName != null)
                {
                    body["contact-last-name"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
                    bodypropCount++;
                }

                if (bodycontactFullName != null)
                {
                    body["contact-full-name"] = SourceExpressionConverter.ConvertToken(bodycontactFullName);
                    bodypropCount++;
                }

                if (bodycontactTitle != null)
                {
                    body["contact-title"] = SourceExpressionConverter.ConvertToken(bodycontactTitle);
                    bodypropCount++;
                }

                if (bodycontactEmail != null)
                {
                    body["contact-email"] = SourceExpressionConverter.ConvertToken(bodycontactEmail);
                    bodypropCount++;
                }

                if (bodycontactPhone != null)
                {
                    body["contact-phone"] = SourceExpressionConverter.ConvertToken(bodycontactPhone);
                    bodypropCount++;
                }

                if (bodycontactFax != null)
                {
                    body["contact-fax"] = SourceExpressionConverter.ConvertToken(bodycontactFax);
                    bodypropCount++;
                }

                if (bodycontactStreet1 != null)
                {
                    body["contact-street-1"] = SourceExpressionConverter.ConvertToken(bodycontactStreet1);
                    bodypropCount++;
                }

                if (bodycontactCity != null)
                {
                    body["contact-city"] = SourceExpressionConverter.ConvertToken(bodycontactCity);
                    bodypropCount++;
                }

                if (bodycontactState != null)
                {
                    body["contact-state"] = SourceExpressionConverter.ConvertToken(bodycontactState);
                    bodypropCount++;
                }

                if (bodycontactZip != null)
                {
                    body["contact-zip"] = SourceExpressionConverter.ConvertToken(bodycontactZip);
                    bodypropCount++;
                }

                if (bodycontactPrimaryContact != null)
                {
                    body["contact-primary-contact"] = SourceExpressionConverter.ConvertToken(bodycontactPrimaryContact);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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