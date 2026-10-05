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
        [WorkflowExpressionFactory(nameof(__BuildRepfabricCreateJob))]
        public IWorkflowAction RepfabricCreateJob([WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<string> bodyjobName, [WorkflowExpression] Func<string> bodycompany, [WorkflowExpression] Func<string> bodycontactFirstName, [WorkflowExpression] Func<string> bodyjobNumber = null, [WorkflowExpression] Func<string> bodyjobBidDate = null, [WorkflowExpression] Func<string> bodyjobOrderDate = null, [WorkflowExpression] Func<string> bodyjobTypeName = null, [WorkflowExpression] Func<string> bodyjobStage = null, [WorkflowExpression] Func<string> bodyjobValue = null, [WorkflowExpression] Func<string> bodystreet1 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzip = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyjobUrl = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyFax = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycompanySalesTeam = null, [WorkflowExpression] Func<int> bodycompanySalesTeamId = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<string> bodycontactFullName = null, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodycontactEmail = null, [WorkflowExpression] Func<string> bodycontactPhone = null, [WorkflowExpression] Func<string> bodycontactFax = null, [WorkflowExpression] Func<string> bodycontactStreet1 = null, [WorkflowExpression] Func<string> bodycontactCity = null, [WorkflowExpression] Func<string> bodycontactState = null, [WorkflowExpression] Func<string> bodycontactZip = null, [WorkflowExpression] Func<bool> bodycontactPrimaryContact = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRepfabricCreateJob(WorkflowValue<string> bodydomainName, WorkflowValue<string> bodyjobName, WorkflowValue<string> bodycompany, WorkflowValue<string> bodycontactFirstName, WorkflowValue<string> bodyjobNumber = null, WorkflowValue<string> bodyjobBidDate = null, WorkflowValue<string> bodyjobOrderDate = null, WorkflowValue<string> bodyjobTypeName = null, WorkflowValue<string> bodyjobStage = null, WorkflowValue<string> bodyjobValue = null, WorkflowValue<string> bodystreet1 = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodyzip = null, WorkflowValue<string> bodycountry = null, WorkflowValue<string> bodyjobUrl = null, WorkflowValue<string> bodycompanyPhone1 = null, WorkflowValue<string> bodycompanyFax = null, WorkflowValue<string> bodycompanyType = null, WorkflowValue<string> bodycompanyWebsite = null, WorkflowValue<string> bodycompanySalesTeam = null, WorkflowValue<int> bodycompanySalesTeamId = null, WorkflowValue<string> bodycontactLastName = null, WorkflowValue<string> bodycontactFullName = null, WorkflowValue<string> bodycontactTitle = null, WorkflowValue<string> bodycontactEmail = null, WorkflowValue<string> bodycontactPhone = null, WorkflowValue<string> bodycontactFax = null, WorkflowValue<string> bodycontactStreet1 = null, WorkflowValue<string> bodycontactCity = null, WorkflowValue<string> bodycontactState = null, WorkflowValue<string> bodycontactZip = null, WorkflowValue<bool> bodycontactPrimaryContact = null)
        {
            WorkflowValue.Validate(bodydomainName, nameof(bodydomainName), required: true);
            WorkflowValue.Validate(bodyjobName, nameof(bodyjobName), required: true);
            WorkflowValue.Validate(bodycompany, nameof(bodycompany), required: true);
            WorkflowValue.Validate(bodycontactFirstName, nameof(bodycontactFirstName), required: true);
            WorkflowValue.Validate(bodyjobNumber, nameof(bodyjobNumber), required: false);
            WorkflowValue.Validate(bodyjobBidDate, nameof(bodyjobBidDate), required: false);
            WorkflowValue.Validate(bodyjobOrderDate, nameof(bodyjobOrderDate), required: false);
            WorkflowValue.Validate(bodyjobTypeName, nameof(bodyjobTypeName), required: false);
            WorkflowValue.Validate(bodyjobStage, nameof(bodyjobStage), required: false);
            WorkflowValue.Validate(bodyjobValue, nameof(bodyjobValue), required: false);
            WorkflowValue.Validate(bodystreet1, nameof(bodystreet1), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodyzip, nameof(bodyzip), required: false);
            WorkflowValue.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowValue.Validate(bodyjobUrl, nameof(bodyjobUrl), required: false);
            WorkflowValue.Validate(bodycompanyPhone1, nameof(bodycompanyPhone1), required: false);
            WorkflowValue.Validate(bodycompanyFax, nameof(bodycompanyFax), required: false);
            WorkflowValue.Validate(bodycompanyType, nameof(bodycompanyType), required: false);
            WorkflowValue.Validate(bodycompanyWebsite, nameof(bodycompanyWebsite), required: false);
            WorkflowValue.Validate(bodycompanySalesTeam, nameof(bodycompanySalesTeam), required: false);
            WorkflowValue.Validate(bodycompanySalesTeamId, nameof(bodycompanySalesTeamId), required: false);
            WorkflowValue.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowValue.Validate(bodycontactFullName, nameof(bodycontactFullName), required: false);
            WorkflowValue.Validate(bodycontactTitle, nameof(bodycontactTitle), required: false);
            WorkflowValue.Validate(bodycontactEmail, nameof(bodycontactEmail), required: false);
            WorkflowValue.Validate(bodycontactPhone, nameof(bodycontactPhone), required: false);
            WorkflowValue.Validate(bodycontactFax, nameof(bodycontactFax), required: false);
            WorkflowValue.Validate(bodycontactStreet1, nameof(bodycontactStreet1), required: false);
            WorkflowValue.Validate(bodycontactCity, nameof(bodycontactCity), required: false);
            WorkflowValue.Validate(bodycontactState, nameof(bodycontactState), required: false);
            WorkflowValue.Validate(bodycontactZip, nameof(bodycontactZip), required: false);
            WorkflowValue.Validate(bodycontactPrimaryContact, nameof(bodycontactPrimaryContact), required: false);
            return new DeferredWorkflowAction(() =>
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
