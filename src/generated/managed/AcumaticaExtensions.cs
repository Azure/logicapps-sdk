//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acumatica
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcumaticaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesCustomerUsingCustomeridResponse, ApiConnectionActionConfiguration> RetrievesCustomerUsingCustomerid(Expression<Func<string>> ids, Expression<Func<string>> accept)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<RetrievesCustomerUsingCustomeridResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/entity/Default/17.200.001/Customer/{0}", __workflow_ids.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<RetrievesCustomerUsingCustomeridResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeletesCustomerUsingCustomerid(Expression<Func<string>> ids)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/entity/Default/17.200.001/Customer/{0}", __workflow_ids.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesOpportunityUsingOpportunityidResponse, ApiConnectionActionConfiguration> RetrievesOpportunityUsingOpportunityid(Expression<Func<string>> ids, Expression<Func<string>> accept)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<RetrievesOpportunityUsingOpportunityidResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/entity/Default/17.200.001/Opportunity/{0}", __workflow_ids.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<RetrievesOpportunityUsingOpportunityidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeletesOpportunityUsingOpportunityid(Expression<Func<string>> ids)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/entity/Default/17.200.001/Opportunity/{0}", __workflow_ids.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesCaseUsingCaseidResponse, ApiConnectionActionConfiguration> RetrievesCaseUsingCaseid(Expression<Func<string>> ids, Expression<Func<string>> accept)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<RetrievesCaseUsingCaseidResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/entity/Default/17.200.001/Case/{0}", __workflow_ids.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<RetrievesCaseUsingCaseidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeletesCaseUsingCaseid(Expression<Func<string>> ids)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/entity/Default/17.200.001/Case/{0}", __workflow_ids.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItem[], ApiConnectionActionConfiguration> RetrievesListOfCustomersThatSatisfyTheSpecifiedConditions(Expression<Func<string>> filter, Expression<Func<string>> skip, Expression<Func<string>> top, Expression<Func<string>> accept)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            return new DeferredBodyAction<RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Customer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingCustomerResponse, ApiConnectionActionConfiguration> CreatesOrUpdatesAnExistingCustomer(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<CreatesOrUpdatesAnExistingCustomerBodyInput>> body)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatesOrUpdatesAnExistingCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Customer";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatesOrUpdatesAnExistingCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItem[], ApiConnectionActionConfiguration> RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditions(Expression<Func<string>> accept, Expression<Func<string>> filter = null, Expression<Func<string>> skip = null, Expression<Func<string>> top = null)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Opportunity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["skip"] = Convert.ToString("");
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["top"] = Convert.ToString("");
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingOpportunityResponse, ApiConnectionActionConfiguration> CreatesOrUpdatesAnExistingOpportunity(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<CreatesOrUpdatesAnExistingOpportunityBodyInput>> body)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatesOrUpdatesAnExistingOpportunityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Opportunity";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatesOrUpdatesAnExistingOpportunityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItem[], ApiConnectionActionConfiguration> RetrievesListOfCasesThatSatisfyTheSpecifiedConditions(Expression<Func<string>> accept, Expression<Func<string>> filter = null, Expression<Func<string>> skip = null, Expression<Func<string>> top = null)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Case";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["skip"] = Convert.ToString("");
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["top"] = Convert.ToString("");
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingCaseResponse, ApiConnectionActionConfiguration> CreatesOrUpdatesAnExistingCase(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<CreatesOrUpdatesAnExistingCaseBodyInput>> body)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatesOrUpdatesAnExistingCaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Case";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatesOrUpdatesAnExistingCaseResponse>(callPayload);
            });
        }
    }

    public class AcumaticaTriggers([ConnectionName] string connectionId)
    {
    }

    public class RetrievesCustomerUsingCustomeridResponse
    {
        [JsonProperty("CustomerID")]
        public RetrievesCustomerUsingCustomeridResponseCustomerIdType CustomerId { get; set; }
        public RetrievesCustomerUsingCustomeridResponseCustomerNameType CustomerName { get; set; }
        public RetrievesCustomerUsingCustomeridResponseStatusType Status { get; set; }
        public RetrievesCustomerUsingCustomeridResponseAccountRefType AccountRef { get; set; }

        [JsonProperty("CurrencyID")]
        public RetrievesCustomerUsingCustomeridResponseCurrencyIdType CurrencyId { get; set; }
        public RetrievesCustomerUsingCustomeridResponseCustomerClassType CustomerClass { get; set; }
        public RetrievesCustomerUsingCustomeridResponseTermsType Terms { get; set; }
    }

    public class RetrievesCustomerUsingCustomeridResponseCustomerIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCustomerUsingCustomeridResponseCustomerNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCustomerUsingCustomeridResponseStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCustomerUsingCustomeridResponseAccountRefType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCustomerUsingCustomeridResponseCurrencyIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCustomerUsingCustomeridResponseCustomerClassType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCustomerUsingCustomeridResponseTermsType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponse
    {
        [JsonProperty("OpportunityID")]
        public RetrievesOpportunityUsingOpportunityidResponseOpportunityIdType OpportunityId { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseSubjectType Subject { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseStatusType Status { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseStageType Stage { get; set; }

        [JsonProperty("CurrencyID")]
        public RetrievesOpportunityUsingOpportunityidResponseCurrencyIdType CurrencyId { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseBusinessAccountType BusinessAccount { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseContactDisplayNameType ContactDisplayName { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseAmountType Amount { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseDiscountType Discount { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseTotalType Total { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseSourceType Source { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseReasonType Reason { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseProjectType Project { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseOpportunityIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseStageType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseCurrencyIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseBusinessAccountType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseContactDisplayNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseDiscountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseTotalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseSourceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseReasonType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseProjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponse
    {
        [JsonProperty("CaseID")]
        public RetrievesCaseUsingCaseidResponseCaseIdType CaseId { get; set; }
        public RetrievesCaseUsingCaseidResponseSubjectType Subject { get; set; }
        public RetrievesCaseUsingCaseidResponseDateReportedType DateReported { get; set; }

        [JsonProperty("ClassID")]
        public RetrievesCaseUsingCaseidResponseClassIdType ClassId { get; set; }
        public RetrievesCaseUsingCaseidResponseBusinessAccountType BusinessAccount { get; set; }
        public RetrievesCaseUsingCaseidResponseDescriptionType Description { get; set; }
        public RetrievesCaseUsingCaseidResponseContactDisplayNameType ContactDisplayName { get; set; }
        public RetrievesCaseUsingCaseidResponseStatusType Status { get; set; }
        public RetrievesCaseUsingCaseidResponseReasonType Reason { get; set; }
        public RetrievesCaseUsingCaseidResponseSeverityType Severity { get; set; }
        public RetrievesCaseUsingCaseidResponsePriorityType Priority { get; set; }
        public RetrievesCaseUsingCaseidResponseLastActivityDateType LastActivityDate { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseCaseIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseDateReportedType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseClassIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseBusinessAccountType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseDescriptionType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseContactDisplayNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseReasonType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseSeverityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponsePriorityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseLastActivityDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItem
    {
        [JsonProperty("CustomerID")]
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerIdType CustomerId { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerNameType CustomerName { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemStatusType Status { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemAccountRefType AccountRef { get; set; }

        [JsonProperty("CurrencyID")]
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIdType CurrencyId { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerClassType CustomerClass { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemTermsType Terms { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemAccountRefType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerClassType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemTermsType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponse
    {
        [JsonProperty("CustomerID")]
        public CreatesOrUpdatesAnExistingCustomerResponseCustomerIdType CustomerId { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseCustomerNameType CustomerName { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseStatusType Status { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseAccountRefType AccountRef { get; set; }

        [JsonProperty("CurrencyID")]
        public CreatesOrUpdatesAnExistingCustomerResponseCurrencyIdType CurrencyId { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseCustomerClassType CustomerClass { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseTermsType Terms { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponseCustomerIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponseCustomerNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponseStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponseAccountRefType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponseCurrencyIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponseCustomerClassType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponseTermsType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerBodyInput
    {
        [JsonProperty("CustomerID")]
        public BodyInputCustomerIdType CustomerId { get; set; }
        public BodyInputCustomerNameType CustomerName { get; set; }
        public BodyInputStatusType Status { get; set; }
        public BodyInputAccountRefType AccountRef { get; set; }

        [JsonProperty("CurrencyID")]
        public BodyInputCurrencyIdType CurrencyId { get; set; }
        public BodyInputCustomerClassType CustomerClass { get; set; }
        public BodyInputTermsType Terms { get; set; }
    }

    public class BodyInputCustomerIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputCustomerNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputAccountRefType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputCurrencyIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputCustomerClassType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputTermsType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItem
    {
        [JsonProperty("OpportunityID")]
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemOpportunityIdType OpportunityId { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemSubjectType Subject { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemStatusType Status { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemStageType Stage { get; set; }

        [JsonProperty("CurrencyID")]
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIdType CurrencyId { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemBusinessAccountType BusinessAccount { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemContactDisplayNameType ContactDisplayName { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemAmountType Amount { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemDiscountType Discount { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemTotalType Total { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemSourceType Source { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemReasonType Reason { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemProjectType Project { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemOpportunityIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemStageType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemBusinessAccountType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemContactDisplayNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemDiscountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemTotalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemSourceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemReasonType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemProjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponse
    {
        [JsonProperty("OpportunityID")]
        public CreatesOrUpdatesAnExistingOpportunityResponseOpportunityIdType OpportunityId { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseSubjectType Subject { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseStatusType Status { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseStageType Stage { get; set; }

        [JsonProperty("CurrencyID")]
        public CreatesOrUpdatesAnExistingOpportunityResponseCurrencyIdType CurrencyId { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseBusinessAccountType BusinessAccount { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseContactDisplayNameType ContactDisplayName { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseAmountType Amount { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseDiscountType Discount { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseTotalType Total { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseSourceType Source { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseReasonType Reason { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseProjectType Project { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseOpportunityIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseStageType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseCurrencyIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseBusinessAccountType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseContactDisplayNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseDiscountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseTotalType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseSourceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseReasonType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseProjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityBodyInput
    {
        [JsonProperty("OpportunityID")]
        public BodyInputOpportunityIdType OpportunityId { get; set; }
        public BodyInputSubjectType Subject { get; set; }
        public BodyInputStatusType Status { get; set; }
        public BodyInputStageType Stage { get; set; }

        [JsonProperty("CurrencyID")]
        public BodyInputCurrencyIdType CurrencyId { get; set; }
        public BodyInputBusinessAccountType BusinessAccount { get; set; }
        public BodyInputContactDisplayNameType ContactDisplayName { get; set; }
        public BodyInputAmountType Amount { get; set; }
        public BodyInputDiscountType Discount { get; set; }
        public BodyInputTotalType Total { get; set; }
        public BodyInputSourceType Source { get; set; }
        public BodyInputReasonType Reason { get; set; }
        public BodyInputProjectType Project { get; set; }
    }

    public class BodyInputOpportunityIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputStageType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputBusinessAccountType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputContactDisplayNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputAmountType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }
    }

    public class BodyInputDiscountType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }
    }

    public class BodyInputTotalType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }
    }

    public class BodyInputSourceType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputReasonType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputProjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItem
    {
        [JsonProperty("CaseID")]
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemCaseIdType CaseId { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemSubjectType Subject { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemDateReportedType DateReported { get; set; }

        [JsonProperty("ClassID")]
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemClassIdType ClassId { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemBusinessAccountType BusinessAccount { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemDescriptionType Description { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemContactDisplayNameType ContactDisplayName { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemStatusType Status { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemReasonType Reason { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemSeverityType Severity { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemPriorityType Priority { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemLastActivityDateType LastActivityDate { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemCaseIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemDateReportedType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemClassIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemBusinessAccountType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemDescriptionType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemContactDisplayNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemReasonType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemSeverityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemPriorityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemLastActivityDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponse
    {
        [JsonProperty("CaseID")]
        public CreatesOrUpdatesAnExistingCaseResponseCaseIdType CaseId { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseSubjectType Subject { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseDateReportedType DateReported { get; set; }

        [JsonProperty("ClassID")]
        public CreatesOrUpdatesAnExistingCaseResponseClassIdType ClassId { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseBusinessAccountType BusinessAccount { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseDescriptionType Description { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseContactDisplayNameType ContactDisplayName { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseStatusType Status { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseReasonType Reason { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseSeverityType Severity { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponsePriorityType Priority { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseLastActivityDateType LastActivityDate { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseCaseIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseDateReportedType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseClassIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseBusinessAccountType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseDescriptionType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseContactDisplayNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseStatusType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseReasonType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseSeverityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponsePriorityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseLastActivityDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseBodyInput
    {
        [JsonProperty("CaseID")]
        public BodyInputCaseIdType CaseId { get; set; }
        public BodyInputSubjectType Subject { get; set; }

        [JsonProperty("ClassID")]
        public BodyInputClassIdType ClassId { get; set; }
        public BodyInputBusinessAccountType BusinessAccount { get; set; }
        public BodyInputDescriptionType Description { get; set; }
        public BodyInputContactDisplayNameType ContactDisplayName { get; set; }
        public BodyInputStatusType Status { get; set; }
        public BodyInputReasonType Reason { get; set; }
        public BodyInputSeverityType Severity { get; set; }
        public BodyInputPriorityType Priority { get; set; }
    }

    public class BodyInputCaseIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputClassIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputDescriptionType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputSeverityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputPriorityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acumatica;

    public partial class WorkflowManagedActions
    {
        public AcumaticaActions Acumatica(string connectionId) => new AcumaticaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcumaticaTriggers Acumatica(string connectionId) => new AcumaticaTriggers(connectionId);
    }
}