//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientResult, ApiConnectionActionConfiguration> GetClients(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> partnerId = null, Expression<Func<bool>> isDebitClient = null, Expression<Func<string>> modifiedSince = null, Expression<Func<string>> groupCode = null, Expression<Func<int>> clientId = null, Expression<Func<bool>> isCustomField = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: false);
            var __workflow_isDebitClient = WorkflowExpression.Compile(isDebitClient, nameof(isDebitClient), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_groupCode = WorkflowExpression.Compile(groupCode, nameof(groupCode), required: false);
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: false);
            var __workflow_isCustomField = WorkflowExpression.Compile(isCustomField, nameof(isCustomField), required: false);
            return new DeferredBodyAction<ClientResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_partnerId != null)
                    callPayload.Queries["partnerId"] = ExpressionConverter.Convert(__workflow_partnerId);
                if (__workflow_isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = ExpressionConverter.Convert(__workflow_isDebitClient);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_groupCode != null)
                    callPayload.Queries["groupCode"] = ExpressionConverter.Convert(__workflow_groupCode);
                if (__workflow_clientId != null)
                    callPayload.Queries["clientId"] = ExpressionConverter.Convert(__workflow_clientId);
                if (__workflow_isCustomField != null)
                    callPayload.Queries["isCustomField"] = ExpressionConverter.Convert(__workflow_isCustomField);
                return new ApiConnectionAction<ClientResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateClients(Expression<Func<string>> bodyentityType, Expression<Func<string>> bodyclientCode, Expression<Func<string>> bodypartnerId, Expression<Func<int>> bodydivisionId, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytrustName = null, Expression<Func<string>> bodytrustType = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodytradingName = null, Expression<Func<string>> bodypartnershipName = null, Expression<Func<string>> bodysmsfName = null, Expression<Func<string>> bodysoftwareType = null, Expression<Func<string>> bodysoftwareName = null, Expression<Func<string>> bodymanagerId = null, Expression<Func<bool>> bodyprospect = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodydateofbirth = null, Expression<Func<string>> bodyplaceOfBirth = null, Expression<Func<string>> bodygender = null, Expression<Func<EmailInfo[]>> bodyemail = null, Expression<Func<Phone[]>> bodyphone = null, Expression<Func<string>> bodylinkedInProfileId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodyannualReviewDate = null, Expression<Func<string>> bodyformationDate = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<string>> bodyindustry = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodysalary = null, Expression<Func<string>> bodyannualIncome = null, Expression<Func<bool>> bodyisTaxClient = null, Expression<Func<bool>> bodyisLodgeActivity = null, Expression<Func<int>> bodytfn = null, Expression<Func<int>> bodyabn = null, Expression<Func<int>> bodyacn = null, Expression<Func<int>> bodydin = null, Expression<Func<string>> bodytaxAgent = null, Expression<Func<bool>> bodygst = null, Expression<Func<bool>> bodyresident = null, Expression<Func<string>> bodybankName = null, Expression<Func<string>> bodybankAccountName = null, Expression<Func<int>> bodybankBSB = null, Expression<Func<int>> bodybankAccountNumber = null, Expression<Func<ContactModel[]>> bodycontactIds = null, Expression<Func<CustomField[]>> bodycustomFields = null, Expression<Func<bodyenumEntityTypesInput>> bodyenumEntityTypes = null, Expression<Func<bodyenumTrustTypesInput>> bodyenumTrustTypes = null, Expression<Func<bodyenumGenderInput>> bodyenumGender = null, Expression<Func<bodyenumEmailTypesInput>> bodyenumEmailTypes = null, Expression<Func<bodyenumPhoneTypesInput>> bodyenumPhoneTypes = null, Expression<Func<bodyenumContactTypesInput>> bodyenumContactTypes = null, Expression<Func<bodyenumAddressTypesInput>> bodyenumAddressTypes = null)
        {
            var __workflow_bodyentityType = WorkflowExpression.Compile(bodyentityType, nameof(bodyentityType), required: true);
            var __workflow_bodyclientCode = WorkflowExpression.Compile(bodyclientCode, nameof(bodyclientCode), required: true);
            var __workflow_bodypartnerId = WorkflowExpression.Compile(bodypartnerId, nameof(bodypartnerId), required: true);
            var __workflow_bodydivisionId = WorkflowExpression.Compile(bodydivisionId, nameof(bodydivisionId), required: true);
            var __workflow_bodysalutation = WorkflowExpression.Compile(bodysalutation, nameof(bodysalutation), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodytrustName = WorkflowExpression.Compile(bodytrustName, nameof(bodytrustName), required: false);
            var __workflow_bodytrustType = WorkflowExpression.Compile(bodytrustType, nameof(bodytrustType), required: false);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodytradingName = WorkflowExpression.Compile(bodytradingName, nameof(bodytradingName), required: false);
            var __workflow_bodypartnershipName = WorkflowExpression.Compile(bodypartnershipName, nameof(bodypartnershipName), required: false);
            var __workflow_bodysmsfName = WorkflowExpression.Compile(bodysmsfName, nameof(bodysmsfName), required: false);
            var __workflow_bodysoftwareType = WorkflowExpression.Compile(bodysoftwareType, nameof(bodysoftwareType), required: false);
            var __workflow_bodysoftwareName = WorkflowExpression.Compile(bodysoftwareName, nameof(bodysoftwareName), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodyprospect = WorkflowExpression.Compile(bodyprospect, nameof(bodyprospect), required: false);
            var __workflow_bodypreferredName = WorkflowExpression.Compile(bodypreferredName, nameof(bodypreferredName), required: false);
            var __workflow_bodydateofbirth = WorkflowExpression.Compile(bodydateofbirth, nameof(bodydateofbirth), required: false);
            var __workflow_bodyplaceOfBirth = WorkflowExpression.Compile(bodyplaceOfBirth, nameof(bodyplaceOfBirth), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodylinkedInProfileId = WorkflowExpression.Compile(bodylinkedInProfileId, nameof(bodylinkedInProfileId), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodyannualReviewDate = WorkflowExpression.Compile(bodyannualReviewDate, nameof(bodyannualReviewDate), required: false);
            var __workflow_bodyformationDate = WorkflowExpression.Compile(bodyformationDate, nameof(bodyformationDate), required: false);
            var __workflow_bodyaddresses = WorkflowExpression.Compile(bodyaddresses, nameof(bodyaddresses), required: false);
            var __workflow_bodyindustry = WorkflowExpression.Compile(bodyindustry, nameof(bodyindustry), required: false);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodysalary = WorkflowExpression.Compile(bodysalary, nameof(bodysalary), required: false);
            var __workflow_bodyannualIncome = WorkflowExpression.Compile(bodyannualIncome, nameof(bodyannualIncome), required: false);
            var __workflow_bodyisTaxClient = WorkflowExpression.Compile(bodyisTaxClient, nameof(bodyisTaxClient), required: false);
            var __workflow_bodyisLodgeActivity = WorkflowExpression.Compile(bodyisLodgeActivity, nameof(bodyisLodgeActivity), required: false);
            var __workflow_bodytfn = WorkflowExpression.Compile(bodytfn, nameof(bodytfn), required: false);
            var __workflow_bodyabn = WorkflowExpression.Compile(bodyabn, nameof(bodyabn), required: false);
            var __workflow_bodyacn = WorkflowExpression.Compile(bodyacn, nameof(bodyacn), required: false);
            var __workflow_bodydin = WorkflowExpression.Compile(bodydin, nameof(bodydin), required: false);
            var __workflow_bodytaxAgent = WorkflowExpression.Compile(bodytaxAgent, nameof(bodytaxAgent), required: false);
            var __workflow_bodygst = WorkflowExpression.Compile(bodygst, nameof(bodygst), required: false);
            var __workflow_bodyresident = WorkflowExpression.Compile(bodyresident, nameof(bodyresident), required: false);
            var __workflow_bodybankName = WorkflowExpression.Compile(bodybankName, nameof(bodybankName), required: false);
            var __workflow_bodybankAccountName = WorkflowExpression.Compile(bodybankAccountName, nameof(bodybankAccountName), required: false);
            var __workflow_bodybankBSB = WorkflowExpression.Compile(bodybankBSB, nameof(bodybankBSB), required: false);
            var __workflow_bodybankAccountNumber = WorkflowExpression.Compile(bodybankAccountNumber, nameof(bodybankAccountNumber), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyenumEntityTypes = WorkflowExpression.Compile(bodyenumEntityTypes, nameof(bodyenumEntityTypes), required: false);
            var __workflow_bodyenumTrustTypes = WorkflowExpression.Compile(bodyenumTrustTypes, nameof(bodyenumTrustTypes), required: false);
            var __workflow_bodyenumGender = WorkflowExpression.Compile(bodyenumGender, nameof(bodyenumGender), required: false);
            var __workflow_bodyenumEmailTypes = WorkflowExpression.Compile(bodyenumEmailTypes, nameof(bodyenumEmailTypes), required: false);
            var __workflow_bodyenumPhoneTypes = WorkflowExpression.Compile(bodyenumPhoneTypes, nameof(bodyenumPhoneTypes), required: false);
            var __workflow_bodyenumContactTypes = WorkflowExpression.Compile(bodyenumContactTypes, nameof(bodyenumContactTypes), required: false);
            var __workflow_bodyenumAddressTypes = WorkflowExpression.Compile(bodyenumAddressTypes, nameof(bodyenumAddressTypes), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["entityType"] = ExpressionConverter.ConvertO(__workflow_bodyentityType);
                bodypropCount++;
                body["clientCode"] = ExpressionConverter.ConvertO(__workflow_bodyclientCode);
                if (__workflow_bodysalutation != null)
                {
                    body["salutation"] = ExpressionConverter.ConvertO(__workflow_bodysalutation);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodytrustName != null)
                {
                    body["trustName"] = ExpressionConverter.ConvertO(__workflow_bodytrustName);
                    bodypropCount++;
                }

                if (__workflow_bodytrustType != null)
                {
                    body["trustType"] = ExpressionConverter.ConvertO(__workflow_bodytrustType);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["companyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodytradingName != null)
                {
                    body["tradingName"] = ExpressionConverter.ConvertO(__workflow_bodytradingName);
                    bodypropCount++;
                }

                if (__workflow_bodypartnershipName != null)
                {
                    body["partnershipName"] = ExpressionConverter.ConvertO(__workflow_bodypartnershipName);
                    bodypropCount++;
                }

                if (__workflow_bodysmsfName != null)
                {
                    body["smsfName"] = ExpressionConverter.ConvertO(__workflow_bodysmsfName);
                    bodypropCount++;
                }

                if (__workflow_bodysoftwareType != null)
                {
                    body["softwareType"] = ExpressionConverter.ConvertO(__workflow_bodysoftwareType);
                    bodypropCount++;
                }

                if (__workflow_bodysoftwareName != null)
                {
                    body["softwareName"] = ExpressionConverter.ConvertO(__workflow_bodysoftwareName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["partnerId"] = ExpressionConverter.ConvertO(__workflow_bodypartnerId);
                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["divisionId"] = ExpressionConverter.ConvertO(__workflow_bodydivisionId);
                if (__workflow_bodyprospect != null)
                {
                    body["prospect"] = ExpressionConverter.ConvertO(__workflow_bodyprospect);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredName != null)
                {
                    body["preferredName"] = ExpressionConverter.ConvertO(__workflow_bodypreferredName);
                    bodypropCount++;
                }

                if (__workflow_bodydateofbirth != null)
                {
                    body["dateofbirth"] = ExpressionConverter.ConvertO(__workflow_bodydateofbirth);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceOfBirth != null)
                {
                    body["placeOfBirth"] = ExpressionConverter.ConvertO(__workflow_bodyplaceOfBirth);
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodylinkedInProfileId != null)
                {
                    body["linkedInProfileId"] = ExpressionConverter.ConvertO(__workflow_bodylinkedInProfileId);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodyannualReviewDate != null)
                {
                    body["annualReviewDate"] = ExpressionConverter.ConvertO(__workflow_bodyannualReviewDate);
                    bodypropCount++;
                }

                if (__workflow_bodyformationDate != null)
                {
                    body["formationDate"] = ExpressionConverter.ConvertO(__workflow_bodyformationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(__workflow_bodyaddresses);
                    bodypropCount++;
                }

                if (__workflow_bodyindustry != null)
                {
                    body["industry"] = ExpressionConverter.ConvertO(__workflow_bodyindustry);
                    bodypropCount++;
                }

                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodysalary != null)
                {
                    body["salary"] = ExpressionConverter.ConvertO(__workflow_bodysalary);
                    bodypropCount++;
                }

                if (__workflow_bodyannualIncome != null)
                {
                    body["annualIncome"] = ExpressionConverter.ConvertO(__workflow_bodyannualIncome);
                    bodypropCount++;
                }

                if (__workflow_bodyisTaxClient != null)
                {
                    body["isTaxClient"] = ExpressionConverter.ConvertO(__workflow_bodyisTaxClient);
                    bodypropCount++;
                }

                if (__workflow_bodyisLodgeActivity != null)
                {
                    body["isLodgeActivity"] = ExpressionConverter.ConvertO(__workflow_bodyisLodgeActivity);
                    bodypropCount++;
                }

                if (__workflow_bodytfn != null)
                {
                    body["tfn"] = ExpressionConverter.ConvertO(__workflow_bodytfn);
                    bodypropCount++;
                }

                if (__workflow_bodyabn != null)
                {
                    body["abn"] = ExpressionConverter.ConvertO(__workflow_bodyabn);
                    bodypropCount++;
                }

                if (__workflow_bodyacn != null)
                {
                    body["acn"] = ExpressionConverter.ConvertO(__workflow_bodyacn);
                    bodypropCount++;
                }

                if (__workflow_bodydin != null)
                {
                    body["din"] = ExpressionConverter.ConvertO(__workflow_bodydin);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAgent != null)
                {
                    body["taxAgent"] = ExpressionConverter.ConvertO(__workflow_bodytaxAgent);
                    bodypropCount++;
                }

                if (__workflow_bodygst != null)
                {
                    body["gst"] = ExpressionConverter.ConvertO(__workflow_bodygst);
                    bodypropCount++;
                }

                if (__workflow_bodyresident != null)
                {
                    body["resident"] = ExpressionConverter.ConvertO(__workflow_bodyresident);
                    bodypropCount++;
                }

                if (__workflow_bodybankName != null)
                {
                    body["bankName"] = ExpressionConverter.ConvertO(__workflow_bodybankName);
                    bodypropCount++;
                }

                if (__workflow_bodybankAccountName != null)
                {
                    body["bankAccountName"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountName);
                    bodypropCount++;
                }

                if (__workflow_bodybankBSB != null)
                {
                    body["bankBSB"] = ExpressionConverter.ConvertO(__workflow_bodybankBSB);
                    bodypropCount++;
                }

                if (__workflow_bodybankAccountNumber != null)
                {
                    body["bankAccountNumber"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["customFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (__workflow_bodyenumEntityTypes != null)
                {
                    body["enumEntityTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumEntityTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumTrustTypes != null)
                {
                    body["enumTrustTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumTrustTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumGender != null)
                {
                    body["enumGender"] = ExpressionConverter.ConvertO(__workflow_bodyenumGender);
                    bodypropCount++;
                }

                if (__workflow_bodyenumEmailTypes != null)
                {
                    body["enumEmailTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumEmailTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumPhoneTypes != null)
                {
                    body["enumPhoneTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumPhoneTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumContactTypes != null)
                {
                    body["enumContactTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumContactTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumAddressTypes != null)
                {
                    body["enumAddressTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumAddressTypes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientDetailsResult, ApiConnectionActionConfiguration> GetAClient(Expression<Func<int>> clientId, Expression<Func<bool>> isCustomField = null)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_isCustomField = WorkflowExpression.Compile(isCustomField, nameof(isCustomField), required: false);
            return new DeferredBodyAction<ClientDetailsResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_isCustomField != null)
                    callPayload.Queries["isCustomField"] = ExpressionConverter.Convert(__workflow_isCustomField);
                return new ApiConnectionAction<ClientDetailsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAClient(Expression<Func<int>> clientId, Expression<Func<string>> bodyentityType, Expression<Func<string>> bodyclientCode, Expression<Func<string>> bodypartnerId, Expression<Func<int>> bodydivisionId, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytrustName = null, Expression<Func<string>> bodytrustType = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodytradingName = null, Expression<Func<string>> bodypartnershipName = null, Expression<Func<string>> bodysmsfName = null, Expression<Func<string>> bodysoftwareType = null, Expression<Func<string>> bodysoftwareName = null, Expression<Func<string>> bodymanagerId = null, Expression<Func<bool>> bodyprospect = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodydateofbirth = null, Expression<Func<string>> bodyplaceOfBirth = null, Expression<Func<string>> bodygender = null, Expression<Func<EmailInfo[]>> bodyemail = null, Expression<Func<Phone[]>> bodyphone = null, Expression<Func<string>> bodylinkedInProfileId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodyannualReviewDate = null, Expression<Func<string>> bodyformationDate = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<string>> bodyindustry = null, Expression<Func<string>> bodyrole = null, Expression<Func<string>> bodysalary = null, Expression<Func<string>> bodyannualIncome = null, Expression<Func<bool>> bodyisTaxClient = null, Expression<Func<bool>> bodyisLodgeActivity = null, Expression<Func<int>> bodytfn = null, Expression<Func<int>> bodyabn = null, Expression<Func<int>> bodyacn = null, Expression<Func<int>> bodydin = null, Expression<Func<string>> bodytaxAgent = null, Expression<Func<bool>> bodygst = null, Expression<Func<bool>> bodyresident = null, Expression<Func<string>> bodybankName = null, Expression<Func<string>> bodybankAccountName = null, Expression<Func<int>> bodybankBSB = null, Expression<Func<int>> bodybankAccountNumber = null, Expression<Func<ContactModel[]>> bodycontactIds = null, Expression<Func<CustomField[]>> bodycustomFields = null, Expression<Func<bodyenumEntityTypesInput>> bodyenumEntityTypes = null, Expression<Func<bodyenumTrustTypesInput>> bodyenumTrustTypes = null, Expression<Func<bodyenumGenderInput>> bodyenumGender = null, Expression<Func<bodyenumEmailTypesInput>> bodyenumEmailTypes = null, Expression<Func<bodyenumPhoneTypesInput>> bodyenumPhoneTypes = null, Expression<Func<bodyenumContactTypesInput>> bodyenumContactTypes = null, Expression<Func<bodyenumAddressTypesInput>> bodyenumAddressTypes = null)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_bodyentityType = WorkflowExpression.Compile(bodyentityType, nameof(bodyentityType), required: true);
            var __workflow_bodyclientCode = WorkflowExpression.Compile(bodyclientCode, nameof(bodyclientCode), required: true);
            var __workflow_bodypartnerId = WorkflowExpression.Compile(bodypartnerId, nameof(bodypartnerId), required: true);
            var __workflow_bodydivisionId = WorkflowExpression.Compile(bodydivisionId, nameof(bodydivisionId), required: true);
            var __workflow_bodysalutation = WorkflowExpression.Compile(bodysalutation, nameof(bodysalutation), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodytrustName = WorkflowExpression.Compile(bodytrustName, nameof(bodytrustName), required: false);
            var __workflow_bodytrustType = WorkflowExpression.Compile(bodytrustType, nameof(bodytrustType), required: false);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodytradingName = WorkflowExpression.Compile(bodytradingName, nameof(bodytradingName), required: false);
            var __workflow_bodypartnershipName = WorkflowExpression.Compile(bodypartnershipName, nameof(bodypartnershipName), required: false);
            var __workflow_bodysmsfName = WorkflowExpression.Compile(bodysmsfName, nameof(bodysmsfName), required: false);
            var __workflow_bodysoftwareType = WorkflowExpression.Compile(bodysoftwareType, nameof(bodysoftwareType), required: false);
            var __workflow_bodysoftwareName = WorkflowExpression.Compile(bodysoftwareName, nameof(bodysoftwareName), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodyprospect = WorkflowExpression.Compile(bodyprospect, nameof(bodyprospect), required: false);
            var __workflow_bodypreferredName = WorkflowExpression.Compile(bodypreferredName, nameof(bodypreferredName), required: false);
            var __workflow_bodydateofbirth = WorkflowExpression.Compile(bodydateofbirth, nameof(bodydateofbirth), required: false);
            var __workflow_bodyplaceOfBirth = WorkflowExpression.Compile(bodyplaceOfBirth, nameof(bodyplaceOfBirth), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodylinkedInProfileId = WorkflowExpression.Compile(bodylinkedInProfileId, nameof(bodylinkedInProfileId), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodyannualReviewDate = WorkflowExpression.Compile(bodyannualReviewDate, nameof(bodyannualReviewDate), required: false);
            var __workflow_bodyformationDate = WorkflowExpression.Compile(bodyformationDate, nameof(bodyformationDate), required: false);
            var __workflow_bodyaddresses = WorkflowExpression.Compile(bodyaddresses, nameof(bodyaddresses), required: false);
            var __workflow_bodyindustry = WorkflowExpression.Compile(bodyindustry, nameof(bodyindustry), required: false);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodysalary = WorkflowExpression.Compile(bodysalary, nameof(bodysalary), required: false);
            var __workflow_bodyannualIncome = WorkflowExpression.Compile(bodyannualIncome, nameof(bodyannualIncome), required: false);
            var __workflow_bodyisTaxClient = WorkflowExpression.Compile(bodyisTaxClient, nameof(bodyisTaxClient), required: false);
            var __workflow_bodyisLodgeActivity = WorkflowExpression.Compile(bodyisLodgeActivity, nameof(bodyisLodgeActivity), required: false);
            var __workflow_bodytfn = WorkflowExpression.Compile(bodytfn, nameof(bodytfn), required: false);
            var __workflow_bodyabn = WorkflowExpression.Compile(bodyabn, nameof(bodyabn), required: false);
            var __workflow_bodyacn = WorkflowExpression.Compile(bodyacn, nameof(bodyacn), required: false);
            var __workflow_bodydin = WorkflowExpression.Compile(bodydin, nameof(bodydin), required: false);
            var __workflow_bodytaxAgent = WorkflowExpression.Compile(bodytaxAgent, nameof(bodytaxAgent), required: false);
            var __workflow_bodygst = WorkflowExpression.Compile(bodygst, nameof(bodygst), required: false);
            var __workflow_bodyresident = WorkflowExpression.Compile(bodyresident, nameof(bodyresident), required: false);
            var __workflow_bodybankName = WorkflowExpression.Compile(bodybankName, nameof(bodybankName), required: false);
            var __workflow_bodybankAccountName = WorkflowExpression.Compile(bodybankAccountName, nameof(bodybankAccountName), required: false);
            var __workflow_bodybankBSB = WorkflowExpression.Compile(bodybankBSB, nameof(bodybankBSB), required: false);
            var __workflow_bodybankAccountNumber = WorkflowExpression.Compile(bodybankAccountNumber, nameof(bodybankAccountNumber), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyenumEntityTypes = WorkflowExpression.Compile(bodyenumEntityTypes, nameof(bodyenumEntityTypes), required: false);
            var __workflow_bodyenumTrustTypes = WorkflowExpression.Compile(bodyenumTrustTypes, nameof(bodyenumTrustTypes), required: false);
            var __workflow_bodyenumGender = WorkflowExpression.Compile(bodyenumGender, nameof(bodyenumGender), required: false);
            var __workflow_bodyenumEmailTypes = WorkflowExpression.Compile(bodyenumEmailTypes, nameof(bodyenumEmailTypes), required: false);
            var __workflow_bodyenumPhoneTypes = WorkflowExpression.Compile(bodyenumPhoneTypes, nameof(bodyenumPhoneTypes), required: false);
            var __workflow_bodyenumContactTypes = WorkflowExpression.Compile(bodyenumContactTypes, nameof(bodyenumContactTypes), required: false);
            var __workflow_bodyenumAddressTypes = WorkflowExpression.Compile(bodyenumAddressTypes, nameof(bodyenumAddressTypes), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["entityType"] = ExpressionConverter.ConvertO(__workflow_bodyentityType);
                bodypropCount++;
                body["clientCode"] = ExpressionConverter.ConvertO(__workflow_bodyclientCode);
                if (__workflow_bodysalutation != null)
                {
                    body["salutation"] = ExpressionConverter.ConvertO(__workflow_bodysalutation);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["middleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodytrustName != null)
                {
                    body["trustName"] = ExpressionConverter.ConvertO(__workflow_bodytrustName);
                    bodypropCount++;
                }

                if (__workflow_bodytrustType != null)
                {
                    body["trustType"] = ExpressionConverter.ConvertO(__workflow_bodytrustType);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["companyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodytradingName != null)
                {
                    body["tradingName"] = ExpressionConverter.ConvertO(__workflow_bodytradingName);
                    bodypropCount++;
                }

                if (__workflow_bodypartnershipName != null)
                {
                    body["partnershipName"] = ExpressionConverter.ConvertO(__workflow_bodypartnershipName);
                    bodypropCount++;
                }

                if (__workflow_bodysmsfName != null)
                {
                    body["smsfName"] = ExpressionConverter.ConvertO(__workflow_bodysmsfName);
                    bodypropCount++;
                }

                if (__workflow_bodysoftwareType != null)
                {
                    body["softwareType"] = ExpressionConverter.ConvertO(__workflow_bodysoftwareType);
                    bodypropCount++;
                }

                if (__workflow_bodysoftwareName != null)
                {
                    body["softwareName"] = ExpressionConverter.ConvertO(__workflow_bodysoftwareName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["partnerId"] = ExpressionConverter.ConvertO(__workflow_bodypartnerId);
                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["divisionId"] = ExpressionConverter.ConvertO(__workflow_bodydivisionId);
                if (__workflow_bodyprospect != null)
                {
                    body["prospect"] = ExpressionConverter.ConvertO(__workflow_bodyprospect);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredName != null)
                {
                    body["preferredName"] = ExpressionConverter.ConvertO(__workflow_bodypreferredName);
                    bodypropCount++;
                }

                if (__workflow_bodydateofbirth != null)
                {
                    body["dateofbirth"] = ExpressionConverter.ConvertO(__workflow_bodydateofbirth);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceOfBirth != null)
                {
                    body["placeOfBirth"] = ExpressionConverter.ConvertO(__workflow_bodyplaceOfBirth);
                    bodypropCount++;
                }

                if (__workflow_bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodylinkedInProfileId != null)
                {
                    body["linkedInProfileId"] = ExpressionConverter.ConvertO(__workflow_bodylinkedInProfileId);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodyannualReviewDate != null)
                {
                    body["annualReviewDate"] = ExpressionConverter.ConvertO(__workflow_bodyannualReviewDate);
                    bodypropCount++;
                }

                if (__workflow_bodyformationDate != null)
                {
                    body["formationDate"] = ExpressionConverter.ConvertO(__workflow_bodyformationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(__workflow_bodyaddresses);
                    bodypropCount++;
                }

                if (__workflow_bodyindustry != null)
                {
                    body["industry"] = ExpressionConverter.ConvertO(__workflow_bodyindustry);
                    bodypropCount++;
                }

                if (__workflow_bodyrole != null)
                {
                    body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodysalary != null)
                {
                    body["salary"] = ExpressionConverter.ConvertO(__workflow_bodysalary);
                    bodypropCount++;
                }

                if (__workflow_bodyannualIncome != null)
                {
                    body["annualIncome"] = ExpressionConverter.ConvertO(__workflow_bodyannualIncome);
                    bodypropCount++;
                }

                if (__workflow_bodyisTaxClient != null)
                {
                    body["isTaxClient"] = ExpressionConverter.ConvertO(__workflow_bodyisTaxClient);
                    bodypropCount++;
                }

                if (__workflow_bodyisLodgeActivity != null)
                {
                    body["isLodgeActivity"] = ExpressionConverter.ConvertO(__workflow_bodyisLodgeActivity);
                    bodypropCount++;
                }

                if (__workflow_bodytfn != null)
                {
                    body["tfn"] = ExpressionConverter.ConvertO(__workflow_bodytfn);
                    bodypropCount++;
                }

                if (__workflow_bodyabn != null)
                {
                    body["abn"] = ExpressionConverter.ConvertO(__workflow_bodyabn);
                    bodypropCount++;
                }

                if (__workflow_bodyacn != null)
                {
                    body["acn"] = ExpressionConverter.ConvertO(__workflow_bodyacn);
                    bodypropCount++;
                }

                if (__workflow_bodydin != null)
                {
                    body["din"] = ExpressionConverter.ConvertO(__workflow_bodydin);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAgent != null)
                {
                    body["taxAgent"] = ExpressionConverter.ConvertO(__workflow_bodytaxAgent);
                    bodypropCount++;
                }

                if (__workflow_bodygst != null)
                {
                    body["gst"] = ExpressionConverter.ConvertO(__workflow_bodygst);
                    bodypropCount++;
                }

                if (__workflow_bodyresident != null)
                {
                    body["resident"] = ExpressionConverter.ConvertO(__workflow_bodyresident);
                    bodypropCount++;
                }

                if (__workflow_bodybankName != null)
                {
                    body["bankName"] = ExpressionConverter.ConvertO(__workflow_bodybankName);
                    bodypropCount++;
                }

                if (__workflow_bodybankAccountName != null)
                {
                    body["bankAccountName"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountName);
                    bodypropCount++;
                }

                if (__workflow_bodybankBSB != null)
                {
                    body["bankBSB"] = ExpressionConverter.ConvertO(__workflow_bodybankBSB);
                    bodypropCount++;
                }

                if (__workflow_bodybankAccountNumber != null)
                {
                    body["bankAccountNumber"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["customFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (__workflow_bodyenumEntityTypes != null)
                {
                    body["enumEntityTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumEntityTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumTrustTypes != null)
                {
                    body["enumTrustTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumTrustTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumGender != null)
                {
                    body["enumGender"] = ExpressionConverter.ConvertO(__workflow_bodyenumGender);
                    bodypropCount++;
                }

                if (__workflow_bodyenumEmailTypes != null)
                {
                    body["enumEmailTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumEmailTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumPhoneTypes != null)
                {
                    body["enumPhoneTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumPhoneTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumContactTypes != null)
                {
                    body["enumContactTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumContactTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumAddressTypes != null)
                {
                    body["enumAddressTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumAddressTypes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetClientsTags()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateClientGroup(Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodypartnerId = null, Expression<Func<int[]>> bodytags = null, Expression<Func<GroupClient[]>> bodygroupClients = null, Expression<Func<int>> bodycontactId = null)
        {
            var __workflow_bodygroupName = WorkflowExpression.Compile(bodygroupName, nameof(bodygroupName), required: false);
            var __workflow_bodypartnerId = WorkflowExpression.Compile(bodypartnerId, nameof(bodypartnerId), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodygroupClients = WorkflowExpression.Compile(bodygroupClients, nameof(bodygroupClients), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/clientgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygroupName != null)
                {
                    body["groupName"] = ExpressionConverter.ConvertO(__workflow_bodygroupName);
                    bodypropCount++;
                }

                if (__workflow_bodypartnerId != null)
                {
                    body["partnerId"] = ExpressionConverter.ConvertO(__workflow_bodypartnerId);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodygroupClients != null)
                {
                    body["groupClients"] = ExpressionConverter.ConvertO(__workflow_bodygroupClients);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["contactId"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateClientGroup(Expression<Func<string>> groupCode, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodypartnerId = null, Expression<Func<int[]>> bodytags = null, Expression<Func<GroupClient[]>> bodygroupClients = null, Expression<Func<int>> bodycontactId = null)
        {
            var __workflow_groupCode = WorkflowExpression.Compile(groupCode, nameof(groupCode), required: true);
            var __workflow_bodygroupName = WorkflowExpression.Compile(bodygroupName, nameof(bodygroupName), required: false);
            var __workflow_bodypartnerId = WorkflowExpression.Compile(bodypartnerId, nameof(bodypartnerId), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodygroupClients = WorkflowExpression.Compile(bodygroupClients, nameof(bodygroupClients), required: false);
            var __workflow_bodycontactId = WorkflowExpression.Compile(bodycontactId, nameof(bodycontactId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/clientgroup/{0}", __workflow_groupCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygroupName != null)
                {
                    body["groupName"] = ExpressionConverter.ConvertO(__workflow_bodygroupName);
                    bodypropCount++;
                }

                if (__workflow_bodypartnerId != null)
                {
                    body["partnerId"] = ExpressionConverter.ConvertO(__workflow_bodypartnerId);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodygroupClients != null)
                {
                    body["groupClients"] = ExpressionConverter.ConvertO(__workflow_bodygroupClients);
                    bodypropCount++;
                }

                if (__workflow_bodycontactId != null)
                {
                    body["contactId"] = ExpressionConverter.ConvertO(__workflow_bodycontactId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<RelationshipsResult, ApiConnectionActionConfiguration> GetClientRelationships(Expression<Func<int>> clientId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<RelationshipsResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}/relationships", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<RelationshipsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientDebtor, ApiConnectionActionConfiguration> GetClientsDebtor(Expression<Func<int>> clientId)
        {
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            return new DeferredBodyAction<ClientDebtor, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/clients/{0}/DebtorClients", __workflow_clientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClientDebtor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ContactResult, ApiConnectionActionConfiguration> GetContacts(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> modifiedSince = null, Expression<Func<int>> contactId = null, Expression<Func<bool>> isClientId = null, Expression<Func<bool>> isCustomField = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_isClientId = WorkflowExpression.Compile(isClientId, nameof(isClientId), required: false);
            var __workflow_isCustomField = WorkflowExpression.Compile(isCustomField, nameof(isCustomField), required: false);
            return new DeferredBodyAction<ContactResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_contactId != null)
                    callPayload.Queries["contactId"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_isClientId != null)
                    callPayload.Queries["isClientId"] = ExpressionConverter.Convert(__workflow_isClientId);
                if (__workflow_isCustomField != null)
                    callPayload.Queries["isCustomField"] = ExpressionConverter.Convert(__workflow_isCustomField);
                return new ApiConnectionAction<ContactResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAContact(Expression<Func<int>> contactId, Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodygender = null, Expression<Func<Phone[]>> bodyphone = null, Expression<Func<EmailInfo[]>> bodyemail = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyplaceOfBirth = null, Expression<Func<string>> bodylinkedInProfileId = null, Expression<Func<string>> bodypreferredName = null, Expression<Func<string>> bodydin = null, Expression<Func<string>> bodydateOfBirth = null, Expression<Func<bool>> bodyisImportent = null, Expression<Func<Address[]>> bodyaddresses = null, Expression<Func<CustomField[]>> bodycustomFields = null, Expression<Func<bodyenumAddressTypesInput>> bodyenumAddressTypes = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_bodysalutation = WorkflowExpression.Compile(bodysalutation, nameof(bodysalutation), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodygender = WorkflowExpression.Compile(bodygender, nameof(bodygender), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodyplaceOfBirth = WorkflowExpression.Compile(bodyplaceOfBirth, nameof(bodyplaceOfBirth), required: false);
            var __workflow_bodylinkedInProfileId = WorkflowExpression.Compile(bodylinkedInProfileId, nameof(bodylinkedInProfileId), required: false);
            var __workflow_bodypreferredName = WorkflowExpression.Compile(bodypreferredName, nameof(bodypreferredName), required: false);
            var __workflow_bodydin = WorkflowExpression.Compile(bodydin, nameof(bodydin), required: false);
            var __workflow_bodydateOfBirth = WorkflowExpression.Compile(bodydateOfBirth, nameof(bodydateOfBirth), required: false);
            var __workflow_bodyisImportent = WorkflowExpression.Compile(bodyisImportent, nameof(bodyisImportent), required: false);
            var __workflow_bodyaddresses = WorkflowExpression.Compile(bodyaddresses, nameof(bodyaddresses), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyenumAddressTypes = WorkflowExpression.Compile(bodyenumAddressTypes, nameof(bodyenumAddressTypes), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysalutation != null)
                {
                    body["salutation"] = ExpressionConverter.ConvertO(__workflow_bodysalutation);
                    bodypropCount++;
                }

                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                if (__workflow_bodymiddleName != null)
                {
                    body["middleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                if (__workflow_bodygender != null)
                {
                    body["gender"] = ExpressionConverter.ConvertO(__workflow_bodygender);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["companyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceOfBirth != null)
                {
                    body["placeOfBirth"] = ExpressionConverter.ConvertO(__workflow_bodyplaceOfBirth);
                    bodypropCount++;
                }

                if (__workflow_bodylinkedInProfileId != null)
                {
                    body["linkedInProfileID"] = ExpressionConverter.ConvertO(__workflow_bodylinkedInProfileId);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredName != null)
                {
                    body["preferredName"] = ExpressionConverter.ConvertO(__workflow_bodypreferredName);
                    bodypropCount++;
                }

                if (__workflow_bodydin != null)
                {
                    body["din"] = ExpressionConverter.ConvertO(__workflow_bodydin);
                    bodypropCount++;
                }

                if (__workflow_bodydateOfBirth != null)
                {
                    body["dateOfBirth"] = ExpressionConverter.ConvertO(__workflow_bodydateOfBirth);
                    bodypropCount++;
                }

                if (__workflow_bodyisImportent != null)
                {
                    body["isImportent"] = ExpressionConverter.ConvertO(__workflow_bodyisImportent);
                    bodypropCount++;
                }

                if (__workflow_bodyaddresses != null)
                {
                    body["addresses"] = ExpressionConverter.ConvertO(__workflow_bodyaddresses);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["customFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (__workflow_bodyenumAddressTypes != null)
                {
                    body["enumAddressTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumAddressTypes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<DivisionsResult, ApiConnectionActionConfiguration> GetDivisions(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> modifiedSince = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            return new DeferredBodyAction<DivisionsResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/divisions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                return new ApiConnectionAction<DivisionsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<InvoiceDetailResult, ApiConnectionActionConfiguration> GetInvoices(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<bool>> isDraftInvoice = null, Expression<Func<bool>> includeInvoiceDetails = null, Expression<Func<string>> status = null, Expression<Func<string>> modifiedSince = null, Expression<Func<bool>> isDebitClient = null, Expression<Func<string>> clientname = null, Expression<Func<string>> clientcode = null, Expression<Func<string>> jobname = null, Expression<Func<string>> jobcode = null, Expression<Func<string>> billingEntityId = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_isDraftInvoice = WorkflowExpression.Compile(isDraftInvoice, nameof(isDraftInvoice), required: false);
            var __workflow_includeInvoiceDetails = WorkflowExpression.Compile(includeInvoiceDetails, nameof(includeInvoiceDetails), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_isDebitClient = WorkflowExpression.Compile(isDebitClient, nameof(isDebitClient), required: false);
            var __workflow_clientname = WorkflowExpression.Compile(clientname, nameof(clientname), required: false);
            var __workflow_clientcode = WorkflowExpression.Compile(clientcode, nameof(clientcode), required: false);
            var __workflow_jobname = WorkflowExpression.Compile(jobname, nameof(jobname), required: false);
            var __workflow_jobcode = WorkflowExpression.Compile(jobcode, nameof(jobcode), required: false);
            var __workflow_billingEntityId = WorkflowExpression.Compile(billingEntityId, nameof(billingEntityId), required: false);
            return new DeferredBodyAction<InvoiceDetailResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_isDraftInvoice != null)
                    callPayload.Queries["isDraftInvoice"] = ExpressionConverter.Convert(__workflow_isDraftInvoice);
                if (__workflow_includeInvoiceDetails != null)
                    callPayload.Queries["includeInvoiceDetails"] = ExpressionConverter.Convert(__workflow_includeInvoiceDetails);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = ExpressionConverter.Convert(__workflow_isDebitClient);
                if (__workflow_clientname != null)
                    callPayload.Queries["clientname"] = ExpressionConverter.Convert(__workflow_clientname);
                if (__workflow_clientcode != null)
                    callPayload.Queries["clientcode"] = ExpressionConverter.Convert(__workflow_clientcode);
                if (__workflow_jobname != null)
                    callPayload.Queries["jobname"] = ExpressionConverter.Convert(__workflow_jobname);
                if (__workflow_jobcode != null)
                    callPayload.Queries["jobcode"] = ExpressionConverter.Convert(__workflow_jobcode);
                if (__workflow_billingEntityId != null)
                    callPayload.Queries["billingEntityId"] = ExpressionConverter.Convert(__workflow_billingEntityId);
                return new ApiConnectionAction<InvoiceDetailResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFirmCustomfields(Expression<Func<string>> context)
        {
            var __workflow_context = WorkflowExpression.Compile(context, nameof(context), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/custom-fields/{0}", __workflow_context.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateTimesheet(Expression<Func<bool>> bodyisbillable = null, Expression<Func<int>> bodyjobId = null, Expression<Func<int>> bodytaskId = null, Expression<Func<int>> bodynonbillableId = null, Expression<Func<string>> bodydate = null, Expression<Func<double>> bodyunits = null, Expression<Func<string>> bodystarttime = null, Expression<Func<double>> bodyrate = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodyisbillable = WorkflowExpression.Compile(bodyisbillable, nameof(bodyisbillable), required: false);
            var __workflow_bodyjobId = WorkflowExpression.Compile(bodyjobId, nameof(bodyjobId), required: false);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: false);
            var __workflow_bodynonbillableId = WorkflowExpression.Compile(bodynonbillableId, nameof(bodynonbillableId), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyunits = WorkflowExpression.Compile(bodyunits, nameof(bodyunits), required: false);
            var __workflow_bodystarttime = WorkflowExpression.Compile(bodystarttime, nameof(bodystarttime), required: false);
            var __workflow_bodyrate = WorkflowExpression.Compile(bodyrate, nameof(bodyrate), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/timesheet/logtime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisbillable != null)
                {
                    body["isbillable"] = ExpressionConverter.ConvertO(__workflow_bodyisbillable);
                    bodypropCount++;
                }

                if (__workflow_bodyjobId != null)
                {
                    body["jobId"] = ExpressionConverter.ConvertO(__workflow_bodyjobId);
                    bodypropCount++;
                }

                if (__workflow_bodytaskId != null)
                {
                    body["taskId"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                    bodypropCount++;
                }

                if (__workflow_bodynonbillableId != null)
                {
                    body["nonbillableId"] = ExpressionConverter.ConvertO(__workflow_bodynonbillableId);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyunits != null)
                {
                    body["units"] = ExpressionConverter.ConvertO(__workflow_bodyunits);
                    bodypropCount++;
                }

                if (__workflow_bodystarttime != null)
                {
                    body["starttime"] = ExpressionConverter.ConvertO(__workflow_bodystarttime);
                    bodypropCount++;
                }

                if (__workflow_bodyrate != null)
                {
                    body["rate"] = ExpressionConverter.ConvertO(__workflow_bodyrate);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetNonBillableTimesheetTypes()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/timesheet/non-billabletypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<UsersResult, ApiConnectionActionConfiguration> GetUsers(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> modifiedSince = null, Expression<Func<string>> rolename = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_rolename = WorkflowExpression.Compile(rolename, nameof(rolename), required: false);
            return new DeferredBodyAction<UsersResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_rolename != null)
                    callPayload.Queries["rolename"] = ExpressionConverter.Convert(__workflow_rolename);
                return new ApiConnectionAction<UsersResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<Teams, ApiConnectionActionConfiguration> GetTeams()
        {
            return new DeferredBodyAction<Teams, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Teams>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobsResult, ApiConnectionActionConfiguration> GetJobs(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> partnerId = null, Expression<Func<string>> clientName = null, Expression<Func<string>> clientcode = null, Expression<Func<string>> modifiedSince = null, Expression<Func<bool>> isDebitClient = null, Expression<Func<bool>> isCustomField = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: false);
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: false);
            var __workflow_clientcode = WorkflowExpression.Compile(clientcode, nameof(clientcode), required: false);
            var __workflow_modifiedSince = WorkflowExpression.Compile(modifiedSince, nameof(modifiedSince), required: false);
            var __workflow_isDebitClient = WorkflowExpression.Compile(isDebitClient, nameof(isDebitClient), required: false);
            var __workflow_isCustomField = WorkflowExpression.Compile(isCustomField, nameof(isCustomField), required: false);
            return new DeferredBodyAction<JobsResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_partnerId != null)
                    callPayload.Queries["partnerId"] = ExpressionConverter.Convert(__workflow_partnerId);
                if (__workflow_clientName != null)
                    callPayload.Queries["clientName"] = ExpressionConverter.Convert(__workflow_clientName);
                if (__workflow_clientcode != null)
                    callPayload.Queries["clientcode"] = ExpressionConverter.Convert(__workflow_clientcode);
                if (__workflow_modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = ExpressionConverter.Convert(__workflow_modifiedSince);
                if (__workflow_isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = ExpressionConverter.Convert(__workflow_isDebitClient);
                if (__workflow_isCustomField != null)
                    callPayload.Queries["isCustomField"] = ExpressionConverter.Convert(__workflow_isCustomField);
                return new ApiConnectionAction<JobsResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateJobs(Expression<Func<int>> bodyclientId = null, Expression<Func<int>> bodydivisionId = null, Expression<Func<int>> bodydebtorclientId = null, Expression<Func<int>> bodyjobTypeId = null, Expression<Func<string>> bodyjobCategory = null, Expression<Func<string>> bodyjobName = null, Expression<Func<int>> bodyfinancialYear = null, Expression<Func<int>> bodytemplateId = null, Expression<Func<string>> bodymanagerId = null, Expression<Func<string>> bodypartnerId = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyestimateType = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodybillingMethod = null, Expression<Func<int>> bodyteamId = null, Expression<Func<double>> bodyquoteAmount = null, Expression<Func<int>> bodystatusId = null, Expression<Func<CustomField[]>> bodycustomFields = null, Expression<Func<bodyenumJobCategoryTypesInput>> bodyenumJobCategoryTypes = null, Expression<Func<bodyenumEstimateTypesInput>> bodyenumEstimateTypes = null, Expression<Func<bodyenumBillingMethodsInput>> bodyenumBillingMethods = null, Expression<Func<bodyenumPriorityTypesInput>> bodyenumPriorityTypes = null)
        {
            var __workflow_bodyclientId = WorkflowExpression.Compile(bodyclientId, nameof(bodyclientId), required: false);
            var __workflow_bodydivisionId = WorkflowExpression.Compile(bodydivisionId, nameof(bodydivisionId), required: false);
            var __workflow_bodydebtorclientId = WorkflowExpression.Compile(bodydebtorclientId, nameof(bodydebtorclientId), required: false);
            var __workflow_bodyjobTypeId = WorkflowExpression.Compile(bodyjobTypeId, nameof(bodyjobTypeId), required: false);
            var __workflow_bodyjobCategory = WorkflowExpression.Compile(bodyjobCategory, nameof(bodyjobCategory), required: false);
            var __workflow_bodyjobName = WorkflowExpression.Compile(bodyjobName, nameof(bodyjobName), required: false);
            var __workflow_bodyfinancialYear = WorkflowExpression.Compile(bodyfinancialYear, nameof(bodyfinancialYear), required: false);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodypartnerId = WorkflowExpression.Compile(bodypartnerId, nameof(bodypartnerId), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyestimateType = WorkflowExpression.Compile(bodyestimateType, nameof(bodyestimateType), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodybillingMethod = WorkflowExpression.Compile(bodybillingMethod, nameof(bodybillingMethod), required: false);
            var __workflow_bodyteamId = WorkflowExpression.Compile(bodyteamId, nameof(bodyteamId), required: false);
            var __workflow_bodyquoteAmount = WorkflowExpression.Compile(bodyquoteAmount, nameof(bodyquoteAmount), required: false);
            var __workflow_bodystatusId = WorkflowExpression.Compile(bodystatusId, nameof(bodystatusId), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyenumJobCategoryTypes = WorkflowExpression.Compile(bodyenumJobCategoryTypes, nameof(bodyenumJobCategoryTypes), required: false);
            var __workflow_bodyenumEstimateTypes = WorkflowExpression.Compile(bodyenumEstimateTypes, nameof(bodyenumEstimateTypes), required: false);
            var __workflow_bodyenumBillingMethods = WorkflowExpression.Compile(bodyenumBillingMethods, nameof(bodyenumBillingMethods), required: false);
            var __workflow_bodyenumPriorityTypes = WorkflowExpression.Compile(bodyenumPriorityTypes, nameof(bodyenumPriorityTypes), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyclientId != null)
                {
                    body["clientId"] = ExpressionConverter.ConvertO(__workflow_bodyclientId);
                    bodypropCount++;
                }

                if (__workflow_bodydivisionId != null)
                {
                    body["divisionId"] = ExpressionConverter.ConvertO(__workflow_bodydivisionId);
                    bodypropCount++;
                }

                if (__workflow_bodydebtorclientId != null)
                {
                    body["debtorclientId"] = ExpressionConverter.ConvertO(__workflow_bodydebtorclientId);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTypeId != null)
                {
                    body["jobTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyjobTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyjobCategory != null)
                {
                    body["jobCategory"] = ExpressionConverter.ConvertO(__workflow_bodyjobCategory);
                    bodypropCount++;
                }

                if (__workflow_bodyjobName != null)
                {
                    body["jobName"] = ExpressionConverter.ConvertO(__workflow_bodyjobName);
                    bodypropCount++;
                }

                if (__workflow_bodyfinancialYear != null)
                {
                    body["financialYear"] = ExpressionConverter.ConvertO(__workflow_bodyfinancialYear);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateId != null)
                {
                    body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodypartnerId != null)
                {
                    body["partnerId"] = ExpressionConverter.ConvertO(__workflow_bodypartnerId);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyestimateType != null)
                {
                    body["estimateType"] = ExpressionConverter.ConvertO(__workflow_bodyestimateType);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodybillingMethod != null)
                {
                    body["billingMethod"] = ExpressionConverter.ConvertO(__workflow_bodybillingMethod);
                    bodypropCount++;
                }

                if (__workflow_bodyteamId != null)
                {
                    body["teamId"] = ExpressionConverter.ConvertO(__workflow_bodyteamId);
                    bodypropCount++;
                }

                if (__workflow_bodyquoteAmount != null)
                {
                    body["quoteAmount"] = ExpressionConverter.ConvertO(__workflow_bodyquoteAmount);
                    bodypropCount++;
                }

                if (__workflow_bodystatusId != null)
                {
                    body["statusId"] = ExpressionConverter.ConvertO(__workflow_bodystatusId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["customFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (__workflow_bodyenumJobCategoryTypes != null)
                {
                    body["enumJobCategoryTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumJobCategoryTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumEstimateTypes != null)
                {
                    body["enumEstimateTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumEstimateTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumBillingMethods != null)
                {
                    body["enumBillingMethods"] = ExpressionConverter.ConvertO(__workflow_bodyenumBillingMethods);
                    bodypropCount++;
                }

                if (__workflow_bodyenumPriorityTypes != null)
                {
                    body["enumPriorityTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumPriorityTypes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateJobStatuses(Expression<Func<int>> bodyjobId = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodystatusOwner = null)
        {
            var __workflow_bodyjobId = WorkflowExpression.Compile(bodyjobId, nameof(bodyjobId), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodystatusOwner = WorkflowExpression.Compile(bodystatusOwner, nameof(bodystatusOwner), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/statuses";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyjobId != null)
                {
                    body["jobId"] = ExpressionConverter.ConvertO(__workflow_bodyjobId);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodystatusOwner != null)
                {
                    body["statusOwner"] = ExpressionConverter.ConvertO(__workflow_bodystatusOwner);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAJob(Expression<Func<int>> jobId, Expression<Func<int>> bodyclientId = null, Expression<Func<int>> bodydivisionId = null, Expression<Func<int>> bodydebtorclientId = null, Expression<Func<int>> bodyjobTypeId = null, Expression<Func<string>> bodyjobCategory = null, Expression<Func<string>> bodyjobName = null, Expression<Func<int>> bodyfinancialYear = null, Expression<Func<int>> bodytemplateId = null, Expression<Func<string>> bodymanagerId = null, Expression<Func<string>> bodypartnerId = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyestimateType = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodybillingMethod = null, Expression<Func<int>> bodyteamId = null, Expression<Func<double>> bodyquoteAmount = null, Expression<Func<int>> bodystatusId = null, Expression<Func<CustomField[]>> bodycustomFields = null, Expression<Func<bodyenumJobCategoryTypesInput>> bodyenumJobCategoryTypes = null, Expression<Func<bodyenumEstimateTypesInput>> bodyenumEstimateTypes = null, Expression<Func<bodyenumBillingMethodsInput>> bodyenumBillingMethods = null, Expression<Func<bodyenumPriorityTypesInput>> bodyenumPriorityTypes = null)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_bodyclientId = WorkflowExpression.Compile(bodyclientId, nameof(bodyclientId), required: false);
            var __workflow_bodydivisionId = WorkflowExpression.Compile(bodydivisionId, nameof(bodydivisionId), required: false);
            var __workflow_bodydebtorclientId = WorkflowExpression.Compile(bodydebtorclientId, nameof(bodydebtorclientId), required: false);
            var __workflow_bodyjobTypeId = WorkflowExpression.Compile(bodyjobTypeId, nameof(bodyjobTypeId), required: false);
            var __workflow_bodyjobCategory = WorkflowExpression.Compile(bodyjobCategory, nameof(bodyjobCategory), required: false);
            var __workflow_bodyjobName = WorkflowExpression.Compile(bodyjobName, nameof(bodyjobName), required: false);
            var __workflow_bodyfinancialYear = WorkflowExpression.Compile(bodyfinancialYear, nameof(bodyfinancialYear), required: false);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodypartnerId = WorkflowExpression.Compile(bodypartnerId, nameof(bodypartnerId), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyestimateType = WorkflowExpression.Compile(bodyestimateType, nameof(bodyestimateType), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodybillingMethod = WorkflowExpression.Compile(bodybillingMethod, nameof(bodybillingMethod), required: false);
            var __workflow_bodyteamId = WorkflowExpression.Compile(bodyteamId, nameof(bodyteamId), required: false);
            var __workflow_bodyquoteAmount = WorkflowExpression.Compile(bodyquoteAmount, nameof(bodyquoteAmount), required: false);
            var __workflow_bodystatusId = WorkflowExpression.Compile(bodystatusId, nameof(bodystatusId), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyenumJobCategoryTypes = WorkflowExpression.Compile(bodyenumJobCategoryTypes, nameof(bodyenumJobCategoryTypes), required: false);
            var __workflow_bodyenumEstimateTypes = WorkflowExpression.Compile(bodyenumEstimateTypes, nameof(bodyenumEstimateTypes), required: false);
            var __workflow_bodyenumBillingMethods = WorkflowExpression.Compile(bodyenumBillingMethods, nameof(bodyenumBillingMethods), required: false);
            var __workflow_bodyenumPriorityTypes = WorkflowExpression.Compile(bodyenumPriorityTypes, nameof(bodyenumPriorityTypes), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workflows/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyclientId != null)
                {
                    body["clientId"] = ExpressionConverter.ConvertO(__workflow_bodyclientId);
                    bodypropCount++;
                }

                if (__workflow_bodydivisionId != null)
                {
                    body["divisionId"] = ExpressionConverter.ConvertO(__workflow_bodydivisionId);
                    bodypropCount++;
                }

                if (__workflow_bodydebtorclientId != null)
                {
                    body["debtorclientId"] = ExpressionConverter.ConvertO(__workflow_bodydebtorclientId);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTypeId != null)
                {
                    body["jobTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyjobTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyjobCategory != null)
                {
                    body["jobCategory"] = ExpressionConverter.ConvertO(__workflow_bodyjobCategory);
                    bodypropCount++;
                }

                if (__workflow_bodyjobName != null)
                {
                    body["jobName"] = ExpressionConverter.ConvertO(__workflow_bodyjobName);
                    bodypropCount++;
                }

                if (__workflow_bodyfinancialYear != null)
                {
                    body["financialYear"] = ExpressionConverter.ConvertO(__workflow_bodyfinancialYear);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateId != null)
                {
                    body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["managerId"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodypartnerId != null)
                {
                    body["partnerId"] = ExpressionConverter.ConvertO(__workflow_bodypartnerId);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyestimateType != null)
                {
                    body["estimateType"] = ExpressionConverter.ConvertO(__workflow_bodyestimateType);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodybillingMethod != null)
                {
                    body["billingMethod"] = ExpressionConverter.ConvertO(__workflow_bodybillingMethod);
                    bodypropCount++;
                }

                if (__workflow_bodyteamId != null)
                {
                    body["teamId"] = ExpressionConverter.ConvertO(__workflow_bodyteamId);
                    bodypropCount++;
                }

                if (__workflow_bodyquoteAmount != null)
                {
                    body["quoteAmount"] = ExpressionConverter.ConvertO(__workflow_bodyquoteAmount);
                    bodypropCount++;
                }

                if (__workflow_bodystatusId != null)
                {
                    body["statusId"] = ExpressionConverter.ConvertO(__workflow_bodystatusId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["customFields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (__workflow_bodyenumJobCategoryTypes != null)
                {
                    body["enumJobCategoryTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumJobCategoryTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumEstimateTypes != null)
                {
                    body["enumEstimateTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumEstimateTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyenumBillingMethods != null)
                {
                    body["enumBillingMethods"] = ExpressionConverter.ConvertO(__workflow_bodyenumBillingMethods);
                    bodypropCount++;
                }

                if (__workflow_bodyenumPriorityTypes != null)
                {
                    body["enumPriorityTypes"] = ExpressionConverter.ConvertO(__workflow_bodyenumPriorityTypes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobType, ApiConnectionActionConfiguration> GetJobTypes()
        {
            return new DeferredBodyAction<JobType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobTemplate, ApiConnectionActionConfiguration> GetJobTemplates()
        {
            return new DeferredBodyAction<JobTemplate, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobTemplate>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobPriorityValues, ApiConnectionActionConfiguration> GetJobPriorities()
        {
            return new DeferredBodyAction<JobPriorityValues, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/priorities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobPriorityValues>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobTypeStatus, ApiConnectionActionConfiguration> GetJobTypeStatus()
        {
            return new DeferredBodyAction<JobTypeStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workflows/jobtypestatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JobTypeStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<GetClientGroupsResponse, ApiConnectionActionConfiguration> GetClientGroups(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> groupCode = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_groupCode = WorkflowExpression.Compile(groupCode, nameof(groupCode), required: false);
            return new DeferredBodyAction<GetClientGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/clients/clientgroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_groupCode != null)
                    callPayload.Queries["groupCode"] = ExpressionConverter.Convert(__workflow_groupCode);
                return new ApiConnectionAction<GetClientGroupsResponse>(callPayload);
            });
        }
    }

    public class KcTriggers([ConnectionName] string connectionId)
    {
    }

    public class ClientResult
    {
        [JsonProperty("clients")]
        public Client[] Clients { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Client
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("division")]
        public Division Division { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("acn")]
        public string Acn { get; set; }

        [JsonProperty("abn")]
        public string Abn { get; set; }

        [JsonProperty("tfn")]
        public string Tfn { get; set; }

        [JsonProperty("gstRegistered")]
        public bool GstRegistered { get; set; }

        [JsonProperty("taxClient")]
        public bool TaxClient { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("wip")]
        public string Wip { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("debtorClient")]
        public string DebtorClient { get; set; }

        [JsonProperty("clientBrefcode")]
        public string ClientBrefcode { get; set; }

        [JsonProperty("billercode")]
        public string Billercode { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }
    }

    public class EmailInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }

        [JsonProperty("feeSynergy")]
        public bool FeeSynergy { get; set; }
    }

    public class Phone
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("favourite")]
        public bool Favourite { get; set; }

        [JsonProperty("feeSynergy")]
        public bool FeeSynergy { get; set; }
    }

    public class Division
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Staff
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Contact
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }
    }

    public class Address
    {
        [JsonProperty("addressType")]
        public string AddressType { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("careOf")]
        public string CareOf { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }
    }

    public class Group
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("page_Size")]
        public int PageSize { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("next_pageurl")]
        public string NextPageurl { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("prev_pageurl")]
        public string PrevPageurl { get; set; }
    }

    public class ContactModel
    {
        [JsonProperty("contactId")]
        public int ContactId { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumEntityTypesInput
    {
        [EnumMember(Value = "individual")]
        Individual,
        [EnumMember(Value = "company")]
        Company,
        [EnumMember(Value = "trust")]
        Trust,
        [EnumMember(Value = "partnership")]
        Partnership,
        [EnumMember(Value = "smsf")]
        Smsf
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumTrustTypesInput
    {
        [EnumMember(Value = "discretionary")]
        Discretionary,
        [EnumMember(Value = "hybrid")]
        Hybrid,
        [EnumMember(Value = "unit")]
        Unit
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumGenderInput
    {
        [EnumMember(Value = "male")]
        Male,
        [EnumMember(Value = "female")]
        Female
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumEmailTypesInput
    {
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "work")]
        Work
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumPhoneTypesInput
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumContactTypesInput
    {
        [EnumMember(Value = "adviser")]
        Adviser,
        [EnumMember(Value = "accountant")]
        Accountant,
        [EnumMember(Value = "auditor")]
        Auditor,
        [EnumMember(Value = "bookkeeper")]
        Bookkeeper,
        [EnumMember(Value = "lawyer")]
        Lawyer,
        [EnumMember(Value = "real_estate_agent")]
        RealEstateAgent,
        [EnumMember(Value = "stockbroker")]
        Stockbroker,
        [EnumMember(Value = "tax_agent")]
        TaxAgent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumAddressTypesInput
    {
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "postal")]
        Postal
    }

    public class ClientDetailsResult
    {
        [JsonProperty("client")]
        public ClientDetails[] Client { get; set; }
    }

    public class ClientDetails
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("division")]
        public Division Division { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("acn")]
        public string Acn { get; set; }

        [JsonProperty("abn")]
        public string Abn { get; set; }

        [JsonProperty("gstRegistered")]
        public bool GstRegistered { get; set; }

        [JsonProperty("taxClient")]
        public bool TaxClient { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("wip")]
        public string Wip { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("debtorClient")]
        public string DebtorClient { get; set; }

        [JsonProperty("clientBrefcode")]
        public string ClientBrefcode { get; set; }

        [JsonProperty("billercode")]
        public string Billercode { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }

        [JsonProperty("din")]
        public string Din { get; set; }

        [JsonProperty("tfn")]
        public string Tfn { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bankAccountName")]
        public string BankAccountName { get; set; }

        [JsonProperty("bankBSB")]
        public string BankBSB { get; set; }

        [JsonProperty("bankAccountNumber")]
        public string BankAccountNumber { get; set; }
    }

    public class GroupClient
    {
        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("isDebitorClient")]
        public bool IsDebitorClient { get; set; }

        [JsonProperty("relationIds")]
        public int[] RelationIds { get; set; }
    }

    public class RelationshipsResult
    {
        [JsonProperty("relationships")]
        public Relationship[] Relationships { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Relationship
    {
        [JsonProperty("relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("units")]
        public int Units { get; set; }
    }

    public class ClientDebtor
    {
        [JsonProperty("debtorid")]
        public int Debtorid { get; set; }

        [JsonProperty("debtorname")]
        public string Debtorname { get; set; }

        [JsonProperty("groupCode")]
        public string GroupCode { get; set; }

        [JsonProperty("clientid")]
        public int Clientid { get; set; }

        [JsonProperty("clientType")]
        public string ClientType { get; set; }

        [JsonProperty("isSeflDebtor")]
        public bool IsSeflDebtor { get; set; }
    }

    public class ContactResult
    {
        [JsonProperty("contacts")]
        public ContactEntity[] Contacts { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class ContactEntity
    {
        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("phone")]
        public Phone[] Phone { get; set; }

        [JsonProperty("email")]
        public EmailInfo[] Email { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("linkedInProfileID")]
        public string LinkedInProfileId { get; set; }

        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("din")]
        public string Din { get; set; }

        [JsonProperty("contactId")]
        public int ContactId { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }
    }

    public class DivisionsResult
    {
        [JsonProperty("divisions")]
        public Divisionext[] Divisions { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Divisionext
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("billingEntityName")]
        public string BillingEntityName { get; set; }

        [JsonProperty("billingEntityId")]
        public string BillingEntityId { get; set; }

        [JsonProperty("lastModifiedAt")]
        public string LastModifiedAt { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class InvoiceDetailResult
    {
        [JsonProperty("invoices")]
        public InvoiceDetails[] Invoices { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class InvoiceDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("refNo")]
        public string RefNo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("due")]
        public string Due { get; set; }

        [JsonProperty("totalPayable")]
        public double TotalPayable { get; set; }

        [JsonProperty("gst")]
        public double Gst { get; set; }

        [JsonProperty("payment")]
        public double Payment { get; set; }

        [JsonProperty("creditNote")]
        public double CreditNote { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("debtorClientId")]
        public int DebtorClientId { get; set; }

        [JsonProperty("debtorClientCode")]
        public string DebtorClientCode { get; set; }

        [JsonProperty("debtorClientName")]
        public string DebtorClientName { get; set; }

        [JsonProperty("debtorBrefcode")]
        public string DebtorBrefcode { get; set; }

        [JsonProperty("billercode")]
        public string Billercode { get; set; }

        [JsonProperty("invoiceLines")]
        public InvoiceLines[] InvoiceLines { get; set; }

        [JsonProperty("invoiceJobs")]
        public JobInvoice[] InvoiceJobs { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class InvoiceLines
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; }

        [JsonProperty("lineDescription")]
        public string LineDescription { get; set; }

        [JsonProperty("lineTotal")]
        public double LineTotal { get; set; }
    }

    public class JobInvoice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("jobcode")]
        public string Jobcode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("wip")]
        public double Wip { get; set; }

        [JsonProperty("client")]
        public ClientSummary Client { get; set; }

        [JsonProperty("financialYear")]
        public string FinancialYear { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("division")]
        public DivisionWithDetails Division { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("debtorClient")]
        public string DebtorClient { get; set; }

        [JsonProperty("invoiceid")]
        public int Invoiceid { get; set; }
    }

    public class ClientSummary
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DivisionWithDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("billingEntityName")]
        public string BillingEntityName { get; set; }

        [JsonProperty("billingEntityId")]
        public string BillingEntityId { get; set; }

        [JsonProperty("lastModifiedAt")]
        public string LastModifiedAt { get; set; }
    }

    public class UsersResult
    {
        [JsonProperty("users")]
        public UsersWithDetails[] Users { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class UsersWithDetails
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("email")]
        public EmailInfo Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public Phone Phone { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class Teams
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("groupMembers")]
        public GroupMember[] GroupMembers { get; set; }
    }

    public class GroupMember
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("memberId")]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }

    public class JobsResult
    {
        [JsonProperty("jobs")]
        public Jobdetail[] Jobs { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Jobdetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("jobCode")]
        public string JobCode { get; set; }

        [JsonProperty("jobType")]
        public string JobType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("estimatedTime")]
        public double EstimatedTime { get; set; }

        [JsonProperty("wip")]
        public double Wip { get; set; }

        [JsonProperty("client")]
        public ClientSummary Client { get; set; }

        [JsonProperty("financialYear")]
        public string FinancialYear { get; set; }

        [JsonProperty("partner")]
        public Staff Partner { get; set; }

        [JsonProperty("manager")]
        public Staff Manager { get; set; }

        [JsonProperty("division")]
        public DivisionWithDetails Division { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }

        [JsonProperty("debtorClient")]
        public DebtorClient DebtorClient { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCategory")]
        public string StatusCategory { get; set; }

        [JsonProperty("statusOwner")]
        public UserDetail StatusOwner { get; set; }

        [JsonProperty("completedTask")]
        public int CompletedTask { get; set; }

        [JsonProperty("totalTask")]
        public int TotalTask { get; set; }

        [JsonProperty("tasks")]
        public TaskDetail[] Tasks { get; set; }

        [JsonProperty("assignees")]
        public UserDetail[] Assignees { get; set; }

        [JsonProperty("team")]
        public TaskDetail Team { get; set; }

        [JsonProperty("customFields")]
        public CustomField[] CustomFields { get; set; }
    }

    public class DebtorClient
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UserDetail
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TaskDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumJobCategoryTypesInput
    {
        Workflow,
        Timesheet,
        WorkflowTimesheet,
        Disbursement,
        WorkflowDisbursement,
        TimesheetDisbursement,
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumEstimateTypesInput
    {
        Job,
        [EnumMember(Value = "Task")]
        TaskObject
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumBillingMethodsInput
    {
        TimeCost,
        Fixed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyenumPriorityTypesInput
    {
        Critical,
        High,
        Medium,
        Low
    }

    public class JobType
    {
        [JsonProperty("jobTypeId")]
        public int JobTypeId { get; set; }

        [JsonProperty("jobTypeName")]
        public string JobTypeName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("divisionId")]
        public int DivisionId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class JobTemplate
    {
        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("estimateType")]
        public string EstimateType { get; set; }

        [JsonProperty("turnaround")]
        public int Turnaround { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastModified")]
        public string LastModified { get; set; }
    }

    public class JobPriorityValues
    {
        [JsonProperty("jobPriorityId")]
        public int JobPriorityId { get; set; }

        [JsonProperty("jobPriorityName")]
        public string JobPriorityName { get; set; }
    }

    public class JobTypeStatus
    {
        [JsonProperty("jobTypeId")]
        public int JobTypeId { get; set; }

        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("statusName")]
        public string StatusName { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }

    public class GetClientGroupsResponse
    {
        [JsonProperty("clientGroups")]
        public GetClientGroupsResponseClientGroupsTypeItem[] ClientGroups { get; set; }

        [JsonProperty("pagination")]
        public GetClientGroupsResponsePaginationType Pagination { get; set; }
    }

    public class GetClientGroupsResponseClientGroupsTypeItem
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupCode")]
        public string GroupCode { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("clients")]
        public GetClientGroupsResponseClientGroupsTypeItemClientsTypeItem[] Clients { get; set; }

        [JsonProperty("createdBY")]
        public string CreatedBY { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }
    }

    public class GetClientGroupsResponseClientGroupsTypeItemClientsTypeItem
    {
        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("clientname")]
        public string Clientname { get; set; }

        [JsonProperty("isDebtorClient")]
        public bool IsDebtorClient { get; set; }

        [JsonProperty("debtorClientId")]
        public int DebtorClientId { get; set; }
    }

    public class GetClientGroupsResponsePaginationType
    {
        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("page_Size")]
        public int PageSize { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("next_page")]
        public int NextPage { get; set; }

        [JsonProperty("next_pageurl")]
        public string NextPageurl { get; set; }

        [JsonProperty("prev_page")]
        public int PrevPage { get; set; }

        [JsonProperty("prev_pageurl")]
        public string PrevPageurl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kc;

    public partial class WorkflowManagedActions
    {
        public KcActions Kc(string connectionId) => new KcActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KcTriggers Kc(string connectionId) => new KcTriggers(connectionId);
    }
}