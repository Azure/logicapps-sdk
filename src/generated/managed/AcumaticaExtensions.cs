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
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingCustomerResponse, ApiConnectionActionConfiguration> CreatesOrUpdatesAnExistingCustomer(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodycustomerIdvalue = null, Expression<Func<string>> bodycustomerNamevalue = null, Expression<Func<string>> bodystatusvalue = null, Expression<Func<string>> bodyaccountRefvalue = null, Expression<Func<string>> bodycurrencyIdvalue = null, Expression<Func<string>> bodycustomerClassvalue = null, Expression<Func<string>> bodytermsvalue = null)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodycustomerIdvalue = WorkflowExpression.Compile(bodycustomerIdvalue, nameof(bodycustomerIdvalue), required: false);
            var __workflow_bodycustomerNamevalue = WorkflowExpression.Compile(bodycustomerNamevalue, nameof(bodycustomerNamevalue), required: false);
            var __workflow_bodystatusvalue = WorkflowExpression.Compile(bodystatusvalue, nameof(bodystatusvalue), required: false);
            var __workflow_bodyaccountRefvalue = WorkflowExpression.Compile(bodyaccountRefvalue, nameof(bodyaccountRefvalue), required: false);
            var __workflow_bodycurrencyIdvalue = WorkflowExpression.Compile(bodycurrencyIdvalue, nameof(bodycurrencyIdvalue), required: false);
            var __workflow_bodycustomerClassvalue = WorkflowExpression.Compile(bodycustomerClassvalue, nameof(bodycustomerClassvalue), required: false);
            var __workflow_bodytermsvalue = WorkflowExpression.Compile(bodytermsvalue, nameof(bodytermsvalue), required: false);
            return new DeferredBodyAction<CreatesOrUpdatesAnExistingCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Customer";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var customerIdObject = new JObject();
                var customerIdObjectpropCount = 0;
                if (__workflow_bodycustomerIdvalue != null)
                {
                    customerIdObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycustomerIdvalue);
                    customerIdObjectpropCount++;
                }

                if (customerIdObjectpropCount > 0)
                {
                    body["CustomerID"] = customerIdObject;
                    bodypropCount++;
                }

                var customerNameObject = new JObject();
                var customerNameObjectpropCount = 0;
                if (__workflow_bodycustomerNamevalue != null)
                {
                    customerNameObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycustomerNamevalue);
                    customerNameObjectpropCount++;
                }

                if (customerNameObjectpropCount > 0)
                {
                    body["CustomerName"] = customerNameObject;
                    bodypropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (__workflow_bodystatusvalue != null)
                {
                    statusObject["value"] = ExpressionConverter.ConvertO(__workflow_bodystatusvalue);
                    statusObjectpropCount++;
                }

                if (statusObjectpropCount > 0)
                {
                    body["Status"] = statusObject;
                    bodypropCount++;
                }

                var accountRefObject = new JObject();
                var accountRefObjectpropCount = 0;
                if (__workflow_bodyaccountRefvalue != null)
                {
                    accountRefObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyaccountRefvalue);
                    accountRefObjectpropCount++;
                }

                if (accountRefObjectpropCount > 0)
                {
                    body["AccountRef"] = accountRefObject;
                    bodypropCount++;
                }

                var currencyIdObject = new JObject();
                var currencyIdObjectpropCount = 0;
                if (__workflow_bodycurrencyIdvalue != null)
                {
                    currencyIdObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyIdvalue);
                    currencyIdObjectpropCount++;
                }

                if (currencyIdObjectpropCount > 0)
                {
                    body["CurrencyID"] = currencyIdObject;
                    bodypropCount++;
                }

                var customerClassObject = new JObject();
                var customerClassObjectpropCount = 0;
                if (__workflow_bodycustomerClassvalue != null)
                {
                    customerClassObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycustomerClassvalue);
                    customerClassObjectpropCount++;
                }

                if (customerClassObjectpropCount > 0)
                {
                    body["CustomerClass"] = customerClassObject;
                    bodypropCount++;
                }

                var termsObject = new JObject();
                var termsObjectpropCount = 0;
                if (__workflow_bodytermsvalue != null)
                {
                    termsObject["value"] = ExpressionConverter.ConvertO(__workflow_bodytermsvalue);
                    termsObjectpropCount++;
                }

                if (termsObjectpropCount > 0)
                {
                    body["Terms"] = termsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingOpportunityResponse, ApiConnectionActionConfiguration> CreatesOrUpdatesAnExistingOpportunity(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyopportunityIdvalue = null, Expression<Func<string>> bodysubjectvalue = null, Expression<Func<string>> bodystatusvalue = null, Expression<Func<string>> bodystagevalue = null, Expression<Func<string>> bodycurrencyIdvalue = null, Expression<Func<string>> bodybusinessAccountvalue = null, Expression<Func<string>> bodycontactDisplayNamevalue = null, Expression<Func<double>> bodyamountvalue = null, Expression<Func<double>> bodydiscountvalue = null, Expression<Func<double>> bodytotalvalue = null, Expression<Func<string>> bodysourcevalue = null, Expression<Func<string>> bodyreasonvalue = null, Expression<Func<string>> bodyprojectvalue = null)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodyopportunityIdvalue = WorkflowExpression.Compile(bodyopportunityIdvalue, nameof(bodyopportunityIdvalue), required: false);
            var __workflow_bodysubjectvalue = WorkflowExpression.Compile(bodysubjectvalue, nameof(bodysubjectvalue), required: false);
            var __workflow_bodystatusvalue = WorkflowExpression.Compile(bodystatusvalue, nameof(bodystatusvalue), required: false);
            var __workflow_bodystagevalue = WorkflowExpression.Compile(bodystagevalue, nameof(bodystagevalue), required: false);
            var __workflow_bodycurrencyIdvalue = WorkflowExpression.Compile(bodycurrencyIdvalue, nameof(bodycurrencyIdvalue), required: false);
            var __workflow_bodybusinessAccountvalue = WorkflowExpression.Compile(bodybusinessAccountvalue, nameof(bodybusinessAccountvalue), required: false);
            var __workflow_bodycontactDisplayNamevalue = WorkflowExpression.Compile(bodycontactDisplayNamevalue, nameof(bodycontactDisplayNamevalue), required: false);
            var __workflow_bodyamountvalue = WorkflowExpression.Compile(bodyamountvalue, nameof(bodyamountvalue), required: false);
            var __workflow_bodydiscountvalue = WorkflowExpression.Compile(bodydiscountvalue, nameof(bodydiscountvalue), required: false);
            var __workflow_bodytotalvalue = WorkflowExpression.Compile(bodytotalvalue, nameof(bodytotalvalue), required: false);
            var __workflow_bodysourcevalue = WorkflowExpression.Compile(bodysourcevalue, nameof(bodysourcevalue), required: false);
            var __workflow_bodyreasonvalue = WorkflowExpression.Compile(bodyreasonvalue, nameof(bodyreasonvalue), required: false);
            var __workflow_bodyprojectvalue = WorkflowExpression.Compile(bodyprojectvalue, nameof(bodyprojectvalue), required: false);
            return new DeferredBodyAction<CreatesOrUpdatesAnExistingOpportunityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Opportunity";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var opportunityIdObject = new JObject();
                var opportunityIdObjectpropCount = 0;
                if (__workflow_bodyopportunityIdvalue != null)
                {
                    opportunityIdObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityIdvalue);
                    opportunityIdObjectpropCount++;
                }

                if (opportunityIdObjectpropCount > 0)
                {
                    body["OpportunityID"] = opportunityIdObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectvalue != null)
                {
                    subjectObject["value"] = ExpressionConverter.ConvertO(__workflow_bodysubjectvalue);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["Subject"] = subjectObject;
                    bodypropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (__workflow_bodystatusvalue != null)
                {
                    statusObject["value"] = ExpressionConverter.ConvertO(__workflow_bodystatusvalue);
                    statusObjectpropCount++;
                }

                if (statusObjectpropCount > 0)
                {
                    body["Status"] = statusObject;
                    bodypropCount++;
                }

                var stageObject = new JObject();
                var stageObjectpropCount = 0;
                if (__workflow_bodystagevalue != null)
                {
                    stageObject["value"] = ExpressionConverter.ConvertO(__workflow_bodystagevalue);
                    stageObjectpropCount++;
                }

                if (stageObjectpropCount > 0)
                {
                    body["Stage"] = stageObject;
                    bodypropCount++;
                }

                var currencyIdObject = new JObject();
                var currencyIdObjectpropCount = 0;
                if (__workflow_bodycurrencyIdvalue != null)
                {
                    currencyIdObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyIdvalue);
                    currencyIdObjectpropCount++;
                }

                if (currencyIdObjectpropCount > 0)
                {
                    body["CurrencyID"] = currencyIdObject;
                    bodypropCount++;
                }

                var businessAccountObject = new JObject();
                var businessAccountObjectpropCount = 0;
                if (__workflow_bodybusinessAccountvalue != null)
                {
                    businessAccountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodybusinessAccountvalue);
                    businessAccountObjectpropCount++;
                }

                if (businessAccountObjectpropCount > 0)
                {
                    body["BusinessAccount"] = businessAccountObject;
                    bodypropCount++;
                }

                var contactDisplayNameObject = new JObject();
                var contactDisplayNameObjectpropCount = 0;
                if (__workflow_bodycontactDisplayNamevalue != null)
                {
                    contactDisplayNameObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycontactDisplayNamevalue);
                    contactDisplayNameObjectpropCount++;
                }

                if (contactDisplayNameObjectpropCount > 0)
                {
                    body["ContactDisplayName"] = contactDisplayNameObject;
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (__workflow_bodyamountvalue != null)
                {
                    amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountvalue);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["Amount"] = amountObject;
                    bodypropCount++;
                }

                var discountObject = new JObject();
                var discountObjectpropCount = 0;
                if (__workflow_bodydiscountvalue != null)
                {
                    discountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydiscountvalue);
                    discountObjectpropCount++;
                }

                if (discountObjectpropCount > 0)
                {
                    body["Discount"] = discountObject;
                    bodypropCount++;
                }

                var totalObject = new JObject();
                var totalObjectpropCount = 0;
                if (__workflow_bodytotalvalue != null)
                {
                    totalObject["value"] = ExpressionConverter.ConvertO(__workflow_bodytotalvalue);
                    totalObjectpropCount++;
                }

                if (totalObjectpropCount > 0)
                {
                    body["Total"] = totalObject;
                    bodypropCount++;
                }

                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                if (__workflow_bodysourcevalue != null)
                {
                    sourceObject["value"] = ExpressionConverter.ConvertO(__workflow_bodysourcevalue);
                    sourceObjectpropCount++;
                }

                if (sourceObjectpropCount > 0)
                {
                    body["Source"] = sourceObject;
                    bodypropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (__workflow_bodyreasonvalue != null)
                {
                    reasonObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyreasonvalue);
                    reasonObjectpropCount++;
                }

                if (reasonObjectpropCount > 0)
                {
                    body["Reason"] = reasonObject;
                    bodypropCount++;
                }

                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (__workflow_bodyprojectvalue != null)
                {
                    projectObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyprojectvalue);
                    projectObjectpropCount++;
                }

                if (projectObjectpropCount > 0)
                {
                    body["Project"] = projectObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingCaseResponse, ApiConnectionActionConfiguration> CreatesOrUpdatesAnExistingCase(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodycaseIdvalue = null, Expression<Func<string>> bodysubjectvalue = null, Expression<Func<string>> bodyclassIdvalue = null, Expression<Func<string>> bodybusinessAccountvalue = null, Expression<Func<string>> bodydescriptionvalue = null, Expression<Func<string>> bodycontactDisplayNamevalue = null, Expression<Func<string>> bodystatusvalue = null, Expression<Func<string>> bodyreasonvalue = null, Expression<Func<string>> bodyseverityvalue = null, Expression<Func<string>> bodypriorityvalue = null)
        {
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodycaseIdvalue = WorkflowExpression.Compile(bodycaseIdvalue, nameof(bodycaseIdvalue), required: false);
            var __workflow_bodysubjectvalue = WorkflowExpression.Compile(bodysubjectvalue, nameof(bodysubjectvalue), required: false);
            var __workflow_bodyclassIdvalue = WorkflowExpression.Compile(bodyclassIdvalue, nameof(bodyclassIdvalue), required: false);
            var __workflow_bodybusinessAccountvalue = WorkflowExpression.Compile(bodybusinessAccountvalue, nameof(bodybusinessAccountvalue), required: false);
            var __workflow_bodydescriptionvalue = WorkflowExpression.Compile(bodydescriptionvalue, nameof(bodydescriptionvalue), required: false);
            var __workflow_bodycontactDisplayNamevalue = WorkflowExpression.Compile(bodycontactDisplayNamevalue, nameof(bodycontactDisplayNamevalue), required: false);
            var __workflow_bodystatusvalue = WorkflowExpression.Compile(bodystatusvalue, nameof(bodystatusvalue), required: false);
            var __workflow_bodyreasonvalue = WorkflowExpression.Compile(bodyreasonvalue, nameof(bodyreasonvalue), required: false);
            var __workflow_bodyseverityvalue = WorkflowExpression.Compile(bodyseverityvalue, nameof(bodyseverityvalue), required: false);
            var __workflow_bodypriorityvalue = WorkflowExpression.Compile(bodypriorityvalue, nameof(bodypriorityvalue), required: false);
            return new DeferredBodyAction<CreatesOrUpdatesAnExistingCaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/entity/Default/17.200.001/Case";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var caseIdObject = new JObject();
                var caseIdObjectpropCount = 0;
                if (__workflow_bodycaseIdvalue != null)
                {
                    caseIdObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycaseIdvalue);
                    caseIdObjectpropCount++;
                }

                if (caseIdObjectpropCount > 0)
                {
                    body["CaseID"] = caseIdObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (__workflow_bodysubjectvalue != null)
                {
                    subjectObject["value"] = ExpressionConverter.ConvertO(__workflow_bodysubjectvalue);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["Subject"] = subjectObject;
                    bodypropCount++;
                }

                var classIdObject = new JObject();
                var classIdObjectpropCount = 0;
                if (__workflow_bodyclassIdvalue != null)
                {
                    classIdObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyclassIdvalue);
                    classIdObjectpropCount++;
                }

                if (classIdObjectpropCount > 0)
                {
                    body["ClassID"] = classIdObject;
                    bodypropCount++;
                }

                var businessAccountObject = new JObject();
                var businessAccountObjectpropCount = 0;
                if (__workflow_bodybusinessAccountvalue != null)
                {
                    businessAccountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodybusinessAccountvalue);
                    businessAccountObjectpropCount++;
                }

                if (businessAccountObjectpropCount > 0)
                {
                    body["BusinessAccount"] = businessAccountObject;
                    bodypropCount++;
                }

                var descriptionObject = new JObject();
                var descriptionObjectpropCount = 0;
                if (__workflow_bodydescriptionvalue != null)
                {
                    descriptionObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionvalue);
                    descriptionObjectpropCount++;
                }

                if (descriptionObjectpropCount > 0)
                {
                    body["Description"] = descriptionObject;
                    bodypropCount++;
                }

                var contactDisplayNameObject = new JObject();
                var contactDisplayNameObjectpropCount = 0;
                if (__workflow_bodycontactDisplayNamevalue != null)
                {
                    contactDisplayNameObject["value"] = ExpressionConverter.ConvertO(__workflow_bodycontactDisplayNamevalue);
                    contactDisplayNameObjectpropCount++;
                }

                if (contactDisplayNameObjectpropCount > 0)
                {
                    body["ContactDisplayName"] = contactDisplayNameObject;
                    bodypropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (__workflow_bodystatusvalue != null)
                {
                    statusObject["value"] = ExpressionConverter.ConvertO(__workflow_bodystatusvalue);
                    statusObjectpropCount++;
                }

                if (statusObjectpropCount > 0)
                {
                    body["Status"] = statusObject;
                    bodypropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (__workflow_bodyreasonvalue != null)
                {
                    reasonObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyreasonvalue);
                    reasonObjectpropCount++;
                }

                if (reasonObjectpropCount > 0)
                {
                    body["Reason"] = reasonObject;
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (__workflow_bodyseverityvalue != null)
                {
                    severityObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyseverityvalue);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["Severity"] = severityObject;
                    bodypropCount++;
                }

                var priorityObject = new JObject();
                var priorityObjectpropCount = 0;
                if (__workflow_bodypriorityvalue != null)
                {
                    priorityObject["value"] = ExpressionConverter.ConvertO(__workflow_bodypriorityvalue);
                    priorityObjectpropCount++;
                }

                if (priorityObjectpropCount > 0)
                {
                    body["Priority"] = priorityObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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