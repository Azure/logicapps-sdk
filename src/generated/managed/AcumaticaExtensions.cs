//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Acumatica
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcumaticaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesCustomerUsingCustomeridResponse> RetrievesCustomerUsingCustomerid(Expression<Func<string>> ids, Expression<Func<string>> accept)
        {
            var apiCallPath = String.Format("/entity/Default/17.200.001/Customer/{0}", ExpressionConverter.ConvertWithUrlEncoding(ids, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<RetrievesCustomerUsingCustomeridResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string> DeletesCustomerUsingCustomerid(Expression<Func<string>> ids)
        {
            var apiCallPath = String.Format("/entity/Default/17.200.001/Customer/{0}", ExpressionConverter.ConvertWithUrlEncoding(ids, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesOpportunityUsingOpportunityidResponse> RetrievesOpportunityUsingOpportunityid(Expression<Func<string>> ids, Expression<Func<string>> accept)
        {
            var apiCallPath = String.Format("/entity/Default/17.200.001/Opportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(ids, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<RetrievesOpportunityUsingOpportunityidResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string> DeletesOpportunityUsingOpportunityid(Expression<Func<string>> ids)
        {
            var apiCallPath = String.Format("/entity/Default/17.200.001/Opportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(ids, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesCaseUsingCaseidResponse> RetrievesCaseUsingCaseid(Expression<Func<string>> ids, Expression<Func<string>> accept)
        {
            var apiCallPath = String.Format("/entity/Default/17.200.001/Case/{0}", ExpressionConverter.ConvertWithUrlEncoding(ids, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<RetrievesCaseUsingCaseidResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<string> DeletesCaseUsingCaseid(Expression<Func<string>> ids)
        {
            var apiCallPath = String.Format("/entity/Default/17.200.001/Case/{0}", ExpressionConverter.ConvertWithUrlEncoding(ids, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItem[]> RetrievesListOfCustomersThatSatisfyTheSpecifiedConditions(Expression<Func<string>> filter, Expression<Func<string>> skip, Expression<Func<string>> top, Expression<Func<string>> accept)
        {
            var apiCallPath = "/entity/Default/17.200.001/Customer";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingCustomerResponse> CreatesOrUpdatesAnExistingCustomer(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodycustomerIDvalue = null, Expression<Func<string>> bodycustomerNamevalue = null, Expression<Func<string>> bodystatusvalue = null, Expression<Func<string>> bodyaccountRefvalue = null, Expression<Func<string>> bodycurrencyIDvalue = null, Expression<Func<string>> bodycustomerClassvalue = null, Expression<Func<string>> bodytermsvalue = null)
        {
            var apiCallPath = "/entity/Default/17.200.001/Customer";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            var CustomerIDObject = new JObject();
            var CustomerIDObjectpropCount = 0;
            if (bodycustomerIDvalue != null)
            {
                CustomerIDObject["value"] = ExpressionConverter.ConvertO(bodycustomerIDvalue);
                CustomerIDObjectpropCount++;
            }

            if (CustomerIDObjectpropCount > 0)
            {
                body["CustomerID"] = CustomerIDObject;
                bodypropCount++;
            }

            var CustomerNameObject = new JObject();
            var CustomerNameObjectpropCount = 0;
            if (bodycustomerNamevalue != null)
            {
                CustomerNameObject["value"] = ExpressionConverter.ConvertO(bodycustomerNamevalue);
                CustomerNameObjectpropCount++;
            }

            if (CustomerNameObjectpropCount > 0)
            {
                body["CustomerName"] = CustomerNameObject;
                bodypropCount++;
            }

            var StatusObject = new JObject();
            var StatusObjectpropCount = 0;
            if (bodystatusvalue != null)
            {
                StatusObject["value"] = ExpressionConverter.ConvertO(bodystatusvalue);
                StatusObjectpropCount++;
            }

            if (StatusObjectpropCount > 0)
            {
                body["Status"] = StatusObject;
                bodypropCount++;
            }

            var AccountRefObject = new JObject();
            var AccountRefObjectpropCount = 0;
            if (bodyaccountRefvalue != null)
            {
                AccountRefObject["value"] = ExpressionConverter.ConvertO(bodyaccountRefvalue);
                AccountRefObjectpropCount++;
            }

            if (AccountRefObjectpropCount > 0)
            {
                body["AccountRef"] = AccountRefObject;
                bodypropCount++;
            }

            var CurrencyIDObject = new JObject();
            var CurrencyIDObjectpropCount = 0;
            if (bodycurrencyIDvalue != null)
            {
                CurrencyIDObject["value"] = ExpressionConverter.ConvertO(bodycurrencyIDvalue);
                CurrencyIDObjectpropCount++;
            }

            if (CurrencyIDObjectpropCount > 0)
            {
                body["CurrencyID"] = CurrencyIDObject;
                bodypropCount++;
            }

            var CustomerClassObject = new JObject();
            var CustomerClassObjectpropCount = 0;
            if (bodycustomerClassvalue != null)
            {
                CustomerClassObject["value"] = ExpressionConverter.ConvertO(bodycustomerClassvalue);
                CustomerClassObjectpropCount++;
            }

            if (CustomerClassObjectpropCount > 0)
            {
                body["CustomerClass"] = CustomerClassObject;
                bodypropCount++;
            }

            var TermsObject = new JObject();
            var TermsObjectpropCount = 0;
            if (bodytermsvalue != null)
            {
                TermsObject["value"] = ExpressionConverter.ConvertO(bodytermsvalue);
                TermsObjectpropCount++;
            }

            if (TermsObjectpropCount > 0)
            {
                body["Terms"] = TermsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatesOrUpdatesAnExistingCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItem[]> RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditions(Expression<Func<string>> accept, Expression<Func<string>> filter = null, Expression<Func<string>> skip = null, Expression<Func<string>> top = null)
        {
            var apiCallPath = "/entity/Default/17.200.001/Opportunity";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["skip"] = Convert.ToString("");
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["top"] = Convert.ToString("");
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingOpportunityResponse> CreatesOrUpdatesAnExistingOpportunity(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodyopportunityIDvalue = null, Expression<Func<string>> bodysubjectvalue = null, Expression<Func<string>> bodystatusvalue = null, Expression<Func<string>> bodystagevalue = null, Expression<Func<string>> bodycurrencyIDvalue = null, Expression<Func<string>> bodybusinessAccountvalue = null, Expression<Func<string>> bodycontactDisplayNamevalue = null, Expression<Func<double>> bodyamountvalue = null, Expression<Func<double>> bodydiscountvalue = null, Expression<Func<double>> bodytotalvalue = null, Expression<Func<string>> bodysourcevalue = null, Expression<Func<string>> bodyreasonvalue = null, Expression<Func<string>> bodyprojectvalue = null)
        {
            var apiCallPath = "/entity/Default/17.200.001/Opportunity";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            var OpportunityIDObject = new JObject();
            var OpportunityIDObjectpropCount = 0;
            if (bodyopportunityIDvalue != null)
            {
                OpportunityIDObject["value"] = ExpressionConverter.ConvertO(bodyopportunityIDvalue);
                OpportunityIDObjectpropCount++;
            }

            if (OpportunityIDObjectpropCount > 0)
            {
                body["OpportunityID"] = OpportunityIDObject;
                bodypropCount++;
            }

            var SubjectObject = new JObject();
            var SubjectObjectpropCount = 0;
            if (bodysubjectvalue != null)
            {
                SubjectObject["value"] = ExpressionConverter.ConvertO(bodysubjectvalue);
                SubjectObjectpropCount++;
            }

            if (SubjectObjectpropCount > 0)
            {
                body["Subject"] = SubjectObject;
                bodypropCount++;
            }

            var StatusObject = new JObject();
            var StatusObjectpropCount = 0;
            if (bodystatusvalue != null)
            {
                StatusObject["value"] = ExpressionConverter.ConvertO(bodystatusvalue);
                StatusObjectpropCount++;
            }

            if (StatusObjectpropCount > 0)
            {
                body["Status"] = StatusObject;
                bodypropCount++;
            }

            var StageObject = new JObject();
            var StageObjectpropCount = 0;
            if (bodystagevalue != null)
            {
                StageObject["value"] = ExpressionConverter.ConvertO(bodystagevalue);
                StageObjectpropCount++;
            }

            if (StageObjectpropCount > 0)
            {
                body["Stage"] = StageObject;
                bodypropCount++;
            }

            var CurrencyIDObject = new JObject();
            var CurrencyIDObjectpropCount = 0;
            if (bodycurrencyIDvalue != null)
            {
                CurrencyIDObject["value"] = ExpressionConverter.ConvertO(bodycurrencyIDvalue);
                CurrencyIDObjectpropCount++;
            }

            if (CurrencyIDObjectpropCount > 0)
            {
                body["CurrencyID"] = CurrencyIDObject;
                bodypropCount++;
            }

            var BusinessAccountObject = new JObject();
            var BusinessAccountObjectpropCount = 0;
            if (bodybusinessAccountvalue != null)
            {
                BusinessAccountObject["value"] = ExpressionConverter.ConvertO(bodybusinessAccountvalue);
                BusinessAccountObjectpropCount++;
            }

            if (BusinessAccountObjectpropCount > 0)
            {
                body["BusinessAccount"] = BusinessAccountObject;
                bodypropCount++;
            }

            var ContactDisplayNameObject = new JObject();
            var ContactDisplayNameObjectpropCount = 0;
            if (bodycontactDisplayNamevalue != null)
            {
                ContactDisplayNameObject["value"] = ExpressionConverter.ConvertO(bodycontactDisplayNamevalue);
                ContactDisplayNameObjectpropCount++;
            }

            if (ContactDisplayNameObjectpropCount > 0)
            {
                body["ContactDisplayName"] = ContactDisplayNameObject;
                bodypropCount++;
            }

            var AmountObject = new JObject();
            var AmountObjectpropCount = 0;
            if (bodyamountvalue != null)
            {
                AmountObject["value"] = ExpressionConverter.ConvertO(bodyamountvalue);
                AmountObjectpropCount++;
            }

            if (AmountObjectpropCount > 0)
            {
                body["Amount"] = AmountObject;
                bodypropCount++;
            }

            var DiscountObject = new JObject();
            var DiscountObjectpropCount = 0;
            if (bodydiscountvalue != null)
            {
                DiscountObject["value"] = ExpressionConverter.ConvertO(bodydiscountvalue);
                DiscountObjectpropCount++;
            }

            if (DiscountObjectpropCount > 0)
            {
                body["Discount"] = DiscountObject;
                bodypropCount++;
            }

            var TotalObject = new JObject();
            var TotalObjectpropCount = 0;
            if (bodytotalvalue != null)
            {
                TotalObject["value"] = ExpressionConverter.ConvertO(bodytotalvalue);
                TotalObjectpropCount++;
            }

            if (TotalObjectpropCount > 0)
            {
                body["Total"] = TotalObject;
                bodypropCount++;
            }

            var SourceObject = new JObject();
            var SourceObjectpropCount = 0;
            if (bodysourcevalue != null)
            {
                SourceObject["value"] = ExpressionConverter.ConvertO(bodysourcevalue);
                SourceObjectpropCount++;
            }

            if (SourceObjectpropCount > 0)
            {
                body["Source"] = SourceObject;
                bodypropCount++;
            }

            var ReasonObject = new JObject();
            var ReasonObjectpropCount = 0;
            if (bodyreasonvalue != null)
            {
                ReasonObject["value"] = ExpressionConverter.ConvertO(bodyreasonvalue);
                ReasonObjectpropCount++;
            }

            if (ReasonObjectpropCount > 0)
            {
                body["Reason"] = ReasonObject;
                bodypropCount++;
            }

            var ProjectObject = new JObject();
            var ProjectObjectpropCount = 0;
            if (bodyprojectvalue != null)
            {
                ProjectObject["value"] = ExpressionConverter.ConvertO(bodyprojectvalue);
                ProjectObjectpropCount++;
            }

            if (ProjectObjectpropCount > 0)
            {
                body["Project"] = ProjectObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatesOrUpdatesAnExistingOpportunityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItem[]> RetrievesListOfCasesThatSatisfyTheSpecifiedConditions(Expression<Func<string>> accept, Expression<Func<string>> filter = null, Expression<Func<string>> skip = null, Expression<Func<string>> top = null)
        {
            var apiCallPath = "/entity/Default/17.200.001/Case";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["skip"] = Convert.ToString("");
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["top"] = Convert.ToString("");
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acumatica")]
        public IBodyWorkflowAction<CreatesOrUpdatesAnExistingCaseResponse> CreatesOrUpdatesAnExistingCase(Expression<Func<string>> accept, Expression<Func<string>> contentType, Expression<Func<string>> bodycaseIDvalue = null, Expression<Func<string>> bodysubjectvalue = null, Expression<Func<string>> bodyclassIDvalue = null, Expression<Func<string>> bodybusinessAccountvalue = null, Expression<Func<string>> bodydescriptionvalue = null, Expression<Func<string>> bodycontactDisplayNamevalue = null, Expression<Func<string>> bodystatusvalue = null, Expression<Func<string>> bodyreasonvalue = null, Expression<Func<string>> bodyseverityvalue = null, Expression<Func<string>> bodypriorityvalue = null)
        {
            var apiCallPath = "/entity/Default/17.200.001/Case";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            var CaseIDObject = new JObject();
            var CaseIDObjectpropCount = 0;
            if (bodycaseIDvalue != null)
            {
                CaseIDObject["value"] = ExpressionConverter.ConvertO(bodycaseIDvalue);
                CaseIDObjectpropCount++;
            }

            if (CaseIDObjectpropCount > 0)
            {
                body["CaseID"] = CaseIDObject;
                bodypropCount++;
            }

            var SubjectObject = new JObject();
            var SubjectObjectpropCount = 0;
            if (bodysubjectvalue != null)
            {
                SubjectObject["value"] = ExpressionConverter.ConvertO(bodysubjectvalue);
                SubjectObjectpropCount++;
            }

            if (SubjectObjectpropCount > 0)
            {
                body["Subject"] = SubjectObject;
                bodypropCount++;
            }

            var ClassIDObject = new JObject();
            var ClassIDObjectpropCount = 0;
            if (bodyclassIDvalue != null)
            {
                ClassIDObject["value"] = ExpressionConverter.ConvertO(bodyclassIDvalue);
                ClassIDObjectpropCount++;
            }

            if (ClassIDObjectpropCount > 0)
            {
                body["ClassID"] = ClassIDObject;
                bodypropCount++;
            }

            var BusinessAccountObject = new JObject();
            var BusinessAccountObjectpropCount = 0;
            if (bodybusinessAccountvalue != null)
            {
                BusinessAccountObject["value"] = ExpressionConverter.ConvertO(bodybusinessAccountvalue);
                BusinessAccountObjectpropCount++;
            }

            if (BusinessAccountObjectpropCount > 0)
            {
                body["BusinessAccount"] = BusinessAccountObject;
                bodypropCount++;
            }

            var DescriptionObject = new JObject();
            var DescriptionObjectpropCount = 0;
            if (bodydescriptionvalue != null)
            {
                DescriptionObject["value"] = ExpressionConverter.ConvertO(bodydescriptionvalue);
                DescriptionObjectpropCount++;
            }

            if (DescriptionObjectpropCount > 0)
            {
                body["Description"] = DescriptionObject;
                bodypropCount++;
            }

            var ContactDisplayNameObject = new JObject();
            var ContactDisplayNameObjectpropCount = 0;
            if (bodycontactDisplayNamevalue != null)
            {
                ContactDisplayNameObject["value"] = ExpressionConverter.ConvertO(bodycontactDisplayNamevalue);
                ContactDisplayNameObjectpropCount++;
            }

            if (ContactDisplayNameObjectpropCount > 0)
            {
                body["ContactDisplayName"] = ContactDisplayNameObject;
                bodypropCount++;
            }

            var StatusObject = new JObject();
            var StatusObjectpropCount = 0;
            if (bodystatusvalue != null)
            {
                StatusObject["value"] = ExpressionConverter.ConvertO(bodystatusvalue);
                StatusObjectpropCount++;
            }

            if (StatusObjectpropCount > 0)
            {
                body["Status"] = StatusObject;
                bodypropCount++;
            }

            var ReasonObject = new JObject();
            var ReasonObjectpropCount = 0;
            if (bodyreasonvalue != null)
            {
                ReasonObject["value"] = ExpressionConverter.ConvertO(bodyreasonvalue);
                ReasonObjectpropCount++;
            }

            if (ReasonObjectpropCount > 0)
            {
                body["Reason"] = ReasonObject;
                bodypropCount++;
            }

            var SeverityObject = new JObject();
            var SeverityObjectpropCount = 0;
            if (bodyseverityvalue != null)
            {
                SeverityObject["value"] = ExpressionConverter.ConvertO(bodyseverityvalue);
                SeverityObjectpropCount++;
            }

            if (SeverityObjectpropCount > 0)
            {
                body["Severity"] = SeverityObject;
                bodypropCount++;
            }

            var PriorityObject = new JObject();
            var PriorityObjectpropCount = 0;
            if (bodypriorityvalue != null)
            {
                PriorityObject["value"] = ExpressionConverter.ConvertO(bodypriorityvalue);
                PriorityObjectpropCount++;
            }

            if (PriorityObjectpropCount > 0)
            {
                body["Priority"] = PriorityObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatesOrUpdatesAnExistingCaseResponse>(callPayload);
        }
    }

    public class AcumaticaTriggers([ConnectionName] string connectionId)
    {
    }

    public class RetrievesCustomerUsingCustomeridResponse
    {
        public RetrievesCustomerUsingCustomeridResponseCustomerIDType CustomerID { get; set; }
        public RetrievesCustomerUsingCustomeridResponseCustomerNameType CustomerName { get; set; }
        public RetrievesCustomerUsingCustomeridResponseStatusType Status { get; set; }
        public RetrievesCustomerUsingCustomeridResponseAccountRefType AccountRef { get; set; }
        public RetrievesCustomerUsingCustomeridResponseCurrencyIDType CurrencyID { get; set; }
        public RetrievesCustomerUsingCustomeridResponseCustomerClassType CustomerClass { get; set; }
        public RetrievesCustomerUsingCustomeridResponseTermsType Terms { get; set; }
    }

    public class RetrievesCustomerUsingCustomeridResponseCustomerIDType
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

    public class RetrievesCustomerUsingCustomeridResponseCurrencyIDType
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
        public RetrievesOpportunityUsingOpportunityidResponseOpportunityIDType OpportunityID { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseSubjectType Subject { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseStatusType Status { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseStageType Stage { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseCurrencyIDType CurrencyID { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseBusinessAccountType BusinessAccount { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseContactDisplayNameType ContactDisplayName { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseAmountType Amount { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseDiscountType Discount { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseTotalType Total { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseSourceType Source { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseReasonType Reason { get; set; }
        public RetrievesOpportunityUsingOpportunityidResponseProjectType Project { get; set; }
    }

    public class RetrievesOpportunityUsingOpportunityidResponseOpportunityIDType
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

    public class RetrievesOpportunityUsingOpportunityidResponseCurrencyIDType
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
        public RetrievesCaseUsingCaseidResponseCaseIDType CaseID { get; set; }
        public RetrievesCaseUsingCaseidResponseSubjectType Subject { get; set; }
        public RetrievesCaseUsingCaseidResponseDateReportedType DateReported { get; set; }
        public RetrievesCaseUsingCaseidResponseClassIDType ClassID { get; set; }
        public RetrievesCaseUsingCaseidResponseBusinessAccountType BusinessAccount { get; set; }
        public RetrievesCaseUsingCaseidResponseDescriptionType Description { get; set; }
        public RetrievesCaseUsingCaseidResponseContactDisplayNameType ContactDisplayName { get; set; }
        public RetrievesCaseUsingCaseidResponseStatusType Status { get; set; }
        public RetrievesCaseUsingCaseidResponseReasonType Reason { get; set; }
        public RetrievesCaseUsingCaseidResponseSeverityType Severity { get; set; }
        public RetrievesCaseUsingCaseidResponsePriorityType Priority { get; set; }
        public RetrievesCaseUsingCaseidResponseLastActivityDateType LastActivityDate { get; set; }
    }

    public class RetrievesCaseUsingCaseidResponseCaseIDType
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

    public class RetrievesCaseUsingCaseidResponseClassIDType
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
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerIDType CustomerID { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerNameType CustomerName { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemStatusType Status { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemAccountRefType AccountRef { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIDType CurrencyID { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerClassType CustomerClass { get; set; }
        public RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemTermsType Terms { get; set; }
    }

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCustomerIDType
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

    public class RetrievesListOfCustomersThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIDType
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
        public CreatesOrUpdatesAnExistingCustomerResponseCustomerIDType CustomerID { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseCustomerNameType CustomerName { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseStatusType Status { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseAccountRefType AccountRef { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseCurrencyIDType CurrencyID { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseCustomerClassType CustomerClass { get; set; }
        public CreatesOrUpdatesAnExistingCustomerResponseTermsType Terms { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCustomerResponseCustomerIDType
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

    public class CreatesOrUpdatesAnExistingCustomerResponseCurrencyIDType
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
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemOpportunityIDType OpportunityID { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemSubjectType Subject { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemStatusType Status { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemStageType Stage { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIDType CurrencyID { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemBusinessAccountType BusinessAccount { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemContactDisplayNameType ContactDisplayName { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemAmountType Amount { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemDiscountType Discount { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemTotalType Total { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemSourceType Source { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemReasonType Reason { get; set; }
        public RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemProjectType Project { get; set; }
    }

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemOpportunityIDType
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

    public class RetrievesListOfOpportunitiesThatSatisfyTheSpecifiedConditionsResponseItemCurrencyIDType
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
        public CreatesOrUpdatesAnExistingOpportunityResponseOpportunityIDType OpportunityID { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseSubjectType Subject { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseStatusType Status { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseStageType Stage { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseCurrencyIDType CurrencyID { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseBusinessAccountType BusinessAccount { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseContactDisplayNameType ContactDisplayName { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseAmountType Amount { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseDiscountType Discount { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseTotalType Total { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseSourceType Source { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseReasonType Reason { get; set; }
        public CreatesOrUpdatesAnExistingOpportunityResponseProjectType Project { get; set; }
    }

    public class CreatesOrUpdatesAnExistingOpportunityResponseOpportunityIDType
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

    public class CreatesOrUpdatesAnExistingOpportunityResponseCurrencyIDType
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
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemCaseIDType CaseID { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemSubjectType Subject { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemDateReportedType DateReported { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemClassIDType ClassID { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemBusinessAccountType BusinessAccount { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemDescriptionType Description { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemContactDisplayNameType ContactDisplayName { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemStatusType Status { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemReasonType Reason { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemSeverityType Severity { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemPriorityType Priority { get; set; }
        public RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemLastActivityDateType LastActivityDate { get; set; }
    }

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemCaseIDType
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

    public class RetrievesListOfCasesThatSatisfyTheSpecifiedConditionsResponseItemClassIDType
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
        public CreatesOrUpdatesAnExistingCaseResponseCaseIDType CaseID { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseSubjectType Subject { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseDateReportedType DateReported { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseClassIDType ClassID { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseBusinessAccountType BusinessAccount { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseDescriptionType Description { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseContactDisplayNameType ContactDisplayName { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseStatusType Status { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseReasonType Reason { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseSeverityType Severity { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponsePriorityType Priority { get; set; }
        public CreatesOrUpdatesAnExistingCaseResponseLastActivityDateType LastActivityDate { get; set; }
    }

    public class CreatesOrUpdatesAnExistingCaseResponseCaseIDType
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

    public class CreatesOrUpdatesAnExistingCaseResponseClassIDType
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
    using Microsoft.Azure.Workflows.Sdk.Acumatica;

    public partial class WorkflowManagedActions
    {
        public AcumaticaActions Acumatica(string connectionId) => new AcumaticaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcumaticaTriggers Acumatica(string connectionId) => new AcumaticaTriggers(connectionId);
    }
}