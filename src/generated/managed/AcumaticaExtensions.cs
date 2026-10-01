//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acumatica
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcumaticaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesCustomerUsingCustomeridResponse> RetrievesCustomerUsingCustomerid([WorkflowExpression] Func<string> ids, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/entity/Default/17.200.001/Customer/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ids, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<RetrievesCustomerUsingCustomeridResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string> DeletesCustomerUsingCustomerid([WorkflowExpression] Func<string> ids)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/entity/Default/17.200.001/Customer/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ids, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesOpportunityUsingOpportunityidResponse> RetrievesOpportunityUsingOpportunityid([WorkflowExpression] Func<string> ids, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/entity/Default/17.200.001/Opportunity/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ids, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<RetrievesOpportunityUsingOpportunityidResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string> DeletesOpportunityUsingOpportunityid([WorkflowExpression] Func<string> ids)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/entity/Default/17.200.001/Opportunity/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ids, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesCaseUsingCaseidResponse> RetrievesCaseUsingCaseid([WorkflowExpression] Func<string> ids, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/entity/Default/17.200.001/Case/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ids, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<RetrievesCaseUsingCaseidResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string> DeletesCaseUsingCaseid([WorkflowExpression] Func<string> ids)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/entity/Default/17.200.001/Case/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ids, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItem[]> RetrievesListOfCustomersThatSatisfyTheSpecifiedConditions([WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<string> skip, [WorkflowExpression] Func<string> top, [WorkflowExpression] Func<string> accept)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/entity/Default/17.200.001/Customer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingCustomerResponse> CreatesOrUpdatesAnExistingCustomer([WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodycustomerIdvalue = null, [WorkflowExpression] Func<string> bodycustomerNamevalue = null, [WorkflowExpression] Func<string> bodystatusvalue = null, [WorkflowExpression] Func<string> bodyaccountRefvalue = null, [WorkflowExpression] Func<string> bodycurrencyIdvalue = null, [WorkflowExpression] Func<string> bodycustomerClassvalue = null, [WorkflowExpression] Func<string> bodytermsvalue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/entity/Default/17.200.001/Customer";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var customerIdObject = new JObject();
                var customerIdObjectpropCount = 0;
                if (bodycustomerIdvalue != null)
                {
                    customerIdObject["value"] = SourceExpressionConverter.ConvertToken(bodycustomerIdvalue);
                    customerIdObjectpropCount++;
                }

                if (customerIdObjectpropCount > 0)
                {
                    body["CustomerID"] = customerIdObject;
                    bodypropCount++;
                }

                var customerNameObject = new JObject();
                var customerNameObjectpropCount = 0;
                if (bodycustomerNamevalue != null)
                {
                    customerNameObject["value"] = SourceExpressionConverter.ConvertToken(bodycustomerNamevalue);
                    customerNameObjectpropCount++;
                }

                if (customerNameObjectpropCount > 0)
                {
                    body["CustomerName"] = customerNameObject;
                    bodypropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (bodystatusvalue != null)
                {
                    statusObject["value"] = SourceExpressionConverter.ConvertToken(bodystatusvalue);
                    statusObjectpropCount++;
                }

                if (statusObjectpropCount > 0)
                {
                    body["Status"] = statusObject;
                    bodypropCount++;
                }

                var accountRefObject = new JObject();
                var accountRefObjectpropCount = 0;
                if (bodyaccountRefvalue != null)
                {
                    accountRefObject["value"] = SourceExpressionConverter.ConvertToken(bodyaccountRefvalue);
                    accountRefObjectpropCount++;
                }

                if (accountRefObjectpropCount > 0)
                {
                    body["AccountRef"] = accountRefObject;
                    bodypropCount++;
                }

                var currencyIdObject = new JObject();
                var currencyIdObjectpropCount = 0;
                if (bodycurrencyIdvalue != null)
                {
                    currencyIdObject["value"] = SourceExpressionConverter.ConvertToken(bodycurrencyIdvalue);
                    currencyIdObjectpropCount++;
                }

                if (currencyIdObjectpropCount > 0)
                {
                    body["CurrencyID"] = currencyIdObject;
                    bodypropCount++;
                }

                var customerClassObject = new JObject();
                var customerClassObjectpropCount = 0;
                if (bodycustomerClassvalue != null)
                {
                    customerClassObject["value"] = SourceExpressionConverter.ConvertToken(bodycustomerClassvalue);
                    customerClassObjectpropCount++;
                }

                if (customerClassObjectpropCount > 0)
                {
                    body["CustomerClass"] = customerClassObject;
                    bodypropCount++;
                }

                var termsObject = new JObject();
                var termsObjectpropCount = 0;
                if (bodytermsvalue != null)
                {
                    termsObject["value"] = SourceExpressionConverter.ConvertToken(bodytermsvalue);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreatesOrUpdatesAnExistingCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItem[]> RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditions([WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> skip = null, [WorkflowExpression] Func<string> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/entity/Default/17.200.001/Opportunity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("");
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["skip"] = Convert.ToString("");
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["top"] = Convert.ToString("");
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingOpportunityResponse> CreatesOrUpdatesAnExistingOpportunity([WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyopportunityIdvalue = null, [WorkflowExpression] Func<string> bodysubjectvalue = null, [WorkflowExpression] Func<string> bodystatusvalue = null, [WorkflowExpression] Func<string> bodystagevalue = null, [WorkflowExpression] Func<string> bodycurrencyIdvalue = null, [WorkflowExpression] Func<string> bodybusinessAccountvalue = null, [WorkflowExpression] Func<string> bodycontactDisplayNamevalue = null, [WorkflowExpression] Func<double> bodyamountvalue = null, [WorkflowExpression] Func<double> bodydiscountvalue = null, [WorkflowExpression] Func<double> bodytotalvalue = null, [WorkflowExpression] Func<string> bodysourcevalue = null, [WorkflowExpression] Func<string> bodyreasonvalue = null, [WorkflowExpression] Func<string> bodyprojectvalue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/entity/Default/17.200.001/Opportunity";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var opportunityIdObject = new JObject();
                var opportunityIdObjectpropCount = 0;
                if (bodyopportunityIdvalue != null)
                {
                    opportunityIdObject["value"] = SourceExpressionConverter.ConvertToken(bodyopportunityIdvalue);
                    opportunityIdObjectpropCount++;
                }

                if (opportunityIdObjectpropCount > 0)
                {
                    body["OpportunityID"] = opportunityIdObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectvalue != null)
                {
                    subjectObject["value"] = SourceExpressionConverter.ConvertToken(bodysubjectvalue);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["Subject"] = subjectObject;
                    bodypropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (bodystatusvalue != null)
                {
                    statusObject["value"] = SourceExpressionConverter.ConvertToken(bodystatusvalue);
                    statusObjectpropCount++;
                }

                if (statusObjectpropCount > 0)
                {
                    body["Status"] = statusObject;
                    bodypropCount++;
                }

                var stageObject = new JObject();
                var stageObjectpropCount = 0;
                if (bodystagevalue != null)
                {
                    stageObject["value"] = SourceExpressionConverter.ConvertToken(bodystagevalue);
                    stageObjectpropCount++;
                }

                if (stageObjectpropCount > 0)
                {
                    body["Stage"] = stageObject;
                    bodypropCount++;
                }

                var currencyIdObject = new JObject();
                var currencyIdObjectpropCount = 0;
                if (bodycurrencyIdvalue != null)
                {
                    currencyIdObject["value"] = SourceExpressionConverter.ConvertToken(bodycurrencyIdvalue);
                    currencyIdObjectpropCount++;
                }

                if (currencyIdObjectpropCount > 0)
                {
                    body["CurrencyID"] = currencyIdObject;
                    bodypropCount++;
                }

                var businessAccountObject = new JObject();
                var businessAccountObjectpropCount = 0;
                if (bodybusinessAccountvalue != null)
                {
                    businessAccountObject["value"] = SourceExpressionConverter.ConvertToken(bodybusinessAccountvalue);
                    businessAccountObjectpropCount++;
                }

                if (businessAccountObjectpropCount > 0)
                {
                    body["BusinessAccount"] = businessAccountObject;
                    bodypropCount++;
                }

                var contactDisplayNameObject = new JObject();
                var contactDisplayNameObjectpropCount = 0;
                if (bodycontactDisplayNamevalue != null)
                {
                    contactDisplayNameObject["value"] = SourceExpressionConverter.ConvertToken(bodycontactDisplayNamevalue);
                    contactDisplayNameObjectpropCount++;
                }

                if (contactDisplayNameObjectpropCount > 0)
                {
                    body["ContactDisplayName"] = contactDisplayNameObject;
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (bodyamountvalue != null)
                {
                    amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountvalue);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["Amount"] = amountObject;
                    bodypropCount++;
                }

                var discountObject = new JObject();
                var discountObjectpropCount = 0;
                if (bodydiscountvalue != null)
                {
                    discountObject["value"] = SourceExpressionConverter.ConvertToken(bodydiscountvalue);
                    discountObjectpropCount++;
                }

                if (discountObjectpropCount > 0)
                {
                    body["Discount"] = discountObject;
                    bodypropCount++;
                }

                var totalObject = new JObject();
                var totalObjectpropCount = 0;
                if (bodytotalvalue != null)
                {
                    totalObject["value"] = SourceExpressionConverter.ConvertToken(bodytotalvalue);
                    totalObjectpropCount++;
                }

                if (totalObjectpropCount > 0)
                {
                    body["Total"] = totalObject;
                    bodypropCount++;
                }

                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                if (bodysourcevalue != null)
                {
                    sourceObject["value"] = SourceExpressionConverter.ConvertToken(bodysourcevalue);
                    sourceObjectpropCount++;
                }

                if (sourceObjectpropCount > 0)
                {
                    body["Source"] = sourceObject;
                    bodypropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (bodyreasonvalue != null)
                {
                    reasonObject["value"] = SourceExpressionConverter.ConvertToken(bodyreasonvalue);
                    reasonObjectpropCount++;
                }

                if (reasonObjectpropCount > 0)
                {
                    body["Reason"] = reasonObject;
                    bodypropCount++;
                }

                var projectObject = new JObject();
                var projectObjectpropCount = 0;
                if (bodyprojectvalue != null)
                {
                    projectObject["value"] = SourceExpressionConverter.ConvertToken(bodyprojectvalue);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreatesOrUpdatesAnExistingOpportunityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItem[]> RetrievesListOfCasesThatSatisfyTheSpecifiedConditions([WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> skip = null, [WorkflowExpression] Func<string> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/entity/Default/17.200.001/Case";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("");
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["skip"] = Convert.ToString("");
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["top"] = Convert.ToString("");
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingCaseResponse> CreatesOrUpdatesAnExistingCase([WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodycaseIdvalue = null, [WorkflowExpression] Func<string> bodysubjectvalue = null, [WorkflowExpression] Func<string> bodyclassIdvalue = null, [WorkflowExpression] Func<string> bodybusinessAccountvalue = null, [WorkflowExpression] Func<string> bodydescriptionvalue = null, [WorkflowExpression] Func<string> bodycontactDisplayNamevalue = null, [WorkflowExpression] Func<string> bodystatusvalue = null, [WorkflowExpression] Func<string> bodyreasonvalue = null, [WorkflowExpression] Func<string> bodyseverityvalue = null, [WorkflowExpression] Func<string> bodypriorityvalue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/entity/Default/17.200.001/Case";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                var caseIdObject = new JObject();
                var caseIdObjectpropCount = 0;
                if (bodycaseIdvalue != null)
                {
                    caseIdObject["value"] = SourceExpressionConverter.ConvertToken(bodycaseIdvalue);
                    caseIdObjectpropCount++;
                }

                if (caseIdObjectpropCount > 0)
                {
                    body["CaseID"] = caseIdObject;
                    bodypropCount++;
                }

                var subjectObject = new JObject();
                var subjectObjectpropCount = 0;
                if (bodysubjectvalue != null)
                {
                    subjectObject["value"] = SourceExpressionConverter.ConvertToken(bodysubjectvalue);
                    subjectObjectpropCount++;
                }

                if (subjectObjectpropCount > 0)
                {
                    body["Subject"] = subjectObject;
                    bodypropCount++;
                }

                var classIdObject = new JObject();
                var classIdObjectpropCount = 0;
                if (bodyclassIdvalue != null)
                {
                    classIdObject["value"] = SourceExpressionConverter.ConvertToken(bodyclassIdvalue);
                    classIdObjectpropCount++;
                }

                if (classIdObjectpropCount > 0)
                {
                    body["ClassID"] = classIdObject;
                    bodypropCount++;
                }

                var businessAccountObject = new JObject();
                var businessAccountObjectpropCount = 0;
                if (bodybusinessAccountvalue != null)
                {
                    businessAccountObject["value"] = SourceExpressionConverter.ConvertToken(bodybusinessAccountvalue);
                    businessAccountObjectpropCount++;
                }

                if (businessAccountObjectpropCount > 0)
                {
                    body["BusinessAccount"] = businessAccountObject;
                    bodypropCount++;
                }

                var descriptionObject = new JObject();
                var descriptionObjectpropCount = 0;
                if (bodydescriptionvalue != null)
                {
                    descriptionObject["value"] = SourceExpressionConverter.ConvertToken(bodydescriptionvalue);
                    descriptionObjectpropCount++;
                }

                if (descriptionObjectpropCount > 0)
                {
                    body["Description"] = descriptionObject;
                    bodypropCount++;
                }

                var contactDisplayNameObject = new JObject();
                var contactDisplayNameObjectpropCount = 0;
                if (bodycontactDisplayNamevalue != null)
                {
                    contactDisplayNameObject["value"] = SourceExpressionConverter.ConvertToken(bodycontactDisplayNamevalue);
                    contactDisplayNameObjectpropCount++;
                }

                if (contactDisplayNameObjectpropCount > 0)
                {
                    body["ContactDisplayName"] = contactDisplayNameObject;
                    bodypropCount++;
                }

                var statusObject = new JObject();
                var statusObjectpropCount = 0;
                if (bodystatusvalue != null)
                {
                    statusObject["value"] = SourceExpressionConverter.ConvertToken(bodystatusvalue);
                    statusObjectpropCount++;
                }

                if (statusObjectpropCount > 0)
                {
                    body["Status"] = statusObject;
                    bodypropCount++;
                }

                var reasonObject = new JObject();
                var reasonObjectpropCount = 0;
                if (bodyreasonvalue != null)
                {
                    reasonObject["value"] = SourceExpressionConverter.ConvertToken(bodyreasonvalue);
                    reasonObjectpropCount++;
                }

                if (reasonObjectpropCount > 0)
                {
                    body["Reason"] = reasonObject;
                    bodypropCount++;
                }

                var severityObject = new JObject();
                var severityObjectpropCount = 0;
                if (bodyseverityvalue != null)
                {
                    severityObject["value"] = SourceExpressionConverter.ConvertToken(bodyseverityvalue);
                    severityObjectpropCount++;
                }

                if (severityObjectpropCount > 0)
                {
                    body["Severity"] = severityObject;
                    bodypropCount++;
                }

                var priorityObject = new JObject();
                var priorityObjectpropCount = 0;
                if (bodypriorityvalue != null)
                {
                    priorityObject["value"] = SourceExpressionConverter.ConvertToken(bodypriorityvalue);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreatesOrUpdatesAnExistingCaseResponse>(BuildSourceInput);
        }
    }

    public class AcumaticaTriggers([ConnectionName] string connectionId)
    {
    }

    public class RetrievesCustomerUsingCustomeridResponse
    {
        public RetrievesCustomerUsingCustomeridResponseCustomerIdType CustomerID { get; set; }
        public RetrievesCustomerUsingCustomeridResponseCustomerNameType CustomerName { get; set; }
        public RetrievesCustomerUsingCustomeridResponseStatusType Status { get; set; }
        public RetrievesCustomerUsingCustomeridResponseAccountRefType AccountRef { get; set; }
        public RetrievesCustomerUsingCustomeridResponseCurrencyIdType CurrencyID { get; set; }
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
        public RetrievesOpportunityUsingOpportunityidResponseOpportunityIdType OpportunityID { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseSubjectType Subject { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseStatusType Status { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseStageType Stage { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseCurrencyIdType CurrencyID { get; set; }
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
        public RetrievesCaseUsingCaseidResponseCaseIdType CaseID { get; set; }
        public RetrievesCaseUsingCaseidResponseSubjectType Subject { get; set; }
        public RetrievesCaseUsingCaseidResponseDateReportedType DateReported { get; set; }
        public RetrievesCaseUsingCaseidResponseClassIdType ClassID { get; set; }
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
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerIdType CustomerID { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerNameType CustomerName { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemStatusType Status { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemAccountRefType AccountRef { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIdType CurrencyID { get; set; }
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
        public CreatesOrUpdatesAnExistingCustomerResponseCustomerIdType CustomerID { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseCustomerNameType CustomerName { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseStatusType Status { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseAccountRefType AccountRef { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseCurrencyIdType CurrencyID { get; set; }
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
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemOpportunityIdType OpportunityID { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemSubjectType Subject { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemStatusType Status { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemStageType Stage { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIdType CurrencyID { get; set; }
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
        public CreatesOrUpdatesAnExistingOpportunityResponseOpportunityIdType OpportunityID { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseSubjectType Subject { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseStatusType Status { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseStageType Stage { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseCurrencyIdType CurrencyID { get; set; }
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
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemCaseIdType CaseID { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemSubjectType Subject { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemDateReportedType DateReported { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemClassIdType ClassID { get; set; }
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
        public CreatesOrUpdatesAnExistingCaseResponseCaseIdType CaseID { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseSubjectType Subject { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseDateReportedType DateReported { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseClassIdType ClassID { get; set; }
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