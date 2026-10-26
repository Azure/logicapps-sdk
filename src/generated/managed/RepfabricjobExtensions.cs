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
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateJob(Expression<Func<RepfabricCreateJobInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/default/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class RepfabricjobTriggers([ConnectionName] string connectionId)
    {
    }

    public class RepfabricCreateJobInput
    {
        [JsonProperty("domain-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DomainName { get; set; }

        [JsonProperty("job-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JobName { get; set; }

        [JsonProperty("job-number")]
        public string JobNumber { get; set; }

        [JsonProperty("job-bid-date")]
        public string JobBidDate { get; set; }

        [JsonProperty("job-order-date")]
        public string JobOrderDate { get; set; }

        [JsonProperty("job-type-name")]
        public string JobTypeName { get; set; }

        [JsonProperty("job-stage")]
        public string JobStage { get; set; }

        [JsonProperty("job-value")]
        public string JobValue { get; set; }

        [JsonProperty("street-1")]
        public string Street1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("job-url")]
        public string JobUrl { get; set; }

        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Company { get; set; }

        [JsonProperty("company-phone1")]
        public string CompanyPhone1 { get; set; }

        [JsonProperty("company-fax")]
        public string CompanyFax { get; set; }

        [JsonProperty("company-type")]
        public string CompanyType { get; set; }

        [JsonProperty("company-website")]
        public string CompanyWebsite { get; set; }

        [JsonProperty("company-sales-team")]
        public string CompanySalesTeam { get; set; }

        [JsonProperty("company-sales-team-id")]
        public int? CompanySalesTeamId { get; set; }

        [JsonProperty("contact-first-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactFirstName { get; set; }

        [JsonProperty("contact-last-name")]
        public string ContactLastName { get; set; }

        [JsonProperty("contact-full-name")]
        public string ContactFullName { get; set; }

        [JsonProperty("contact-title")]
        public string ContactTitle { get; set; }

        [JsonProperty("contact-email")]
        public string ContactEmail { get; set; }

        [JsonProperty("contact-phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact-fax")]
        public string ContactFax { get; set; }

        [JsonProperty("contact-street-1")]
        public string ContactStreet1 { get; set; }

        [JsonProperty("contact-city")]
        public string ContactCity { get; set; }

        [JsonProperty("contact-state")]
        public string ContactState { get; set; }

        [JsonProperty("contact-zip")]
        public string ContactZip { get; set; }

        [JsonProperty("contact-primary-contact")]
        public bool? ContactPrimaryContact { get; set; }
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