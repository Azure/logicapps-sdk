//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kc
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KcActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientResult> GetClients([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> partnerId = null, [WorkflowExpression] Func<bool> isDebitClient = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<string> groupCode = null, [WorkflowExpression] Func<int> clientId = null, [WorkflowExpression] Func<bool> isCustomField = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(partnerId, nameof(partnerId), required: false);
            SourceExpression.Validate(isDebitClient, nameof(isDebitClient), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            SourceExpression.Validate(groupCode, nameof(groupCode), required: false);
            SourceExpression.Validate(clientId, nameof(clientId), required: false);
            SourceExpression.Validate(isCustomField, nameof(isCustomField), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (partnerId != null)
                    callPayload.Queries["partnerId"] = SourceExpressionConverter.ConvertO(partnerId);
                if (isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = SourceExpressionConverter.ConvertO(isDebitClient);
                if (modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = SourceExpressionConverter.ConvertO(modifiedSince);
                if (groupCode != null)
                    callPayload.Queries["groupCode"] = SourceExpressionConverter.ConvertO(groupCode);
                if (clientId != null)
                    callPayload.Queries["clientId"] = SourceExpressionConverter.ConvertO(clientId);
                if (isCustomField != null)
                    callPayload.Queries["isCustomField"] = SourceExpressionConverter.ConvertO(isCustomField);
                return callPayload;
            }

            return new ApiConnectionAction<ClientResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction CreateClients([WorkflowExpression] Func<string> bodyentityType, [WorkflowExpression] Func<string> bodyclientCode, [WorkflowExpression] Func<string> bodypartnerId, [WorkflowExpression] Func<int> bodydivisionId, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytrustName = null, [WorkflowExpression] Func<string> bodytrustType = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodytradingName = null, [WorkflowExpression] Func<string> bodypartnershipName = null, [WorkflowExpression] Func<string> bodysmsfName = null, [WorkflowExpression] Func<string> bodysoftwareType = null, [WorkflowExpression] Func<string> bodysoftwareName = null, [WorkflowExpression] Func<string> bodymanagerId = null, [WorkflowExpression] Func<bool> bodyprospect = null, [WorkflowExpression] Func<string> bodypreferredName = null, [WorkflowExpression] Func<string> bodydateofbirth = null, [WorkflowExpression] Func<string> bodyplaceOfBirth = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<EmailInfo[]> bodyemail = null, [WorkflowExpression] Func<Phone[]> bodyphone = null, [WorkflowExpression] Func<string> bodylinkedInProfileId = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodyannualReviewDate = null, [WorkflowExpression] Func<string> bodyformationDate = null, [WorkflowExpression] Func<Address[]> bodyaddresses = null, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodysalary = null, [WorkflowExpression] Func<string> bodyannualIncome = null, [WorkflowExpression] Func<bool> bodyisTaxClient = null, [WorkflowExpression] Func<bool> bodyisLodgeActivity = null, [WorkflowExpression] Func<int> bodytfn = null, [WorkflowExpression] Func<int> bodyabn = null, [WorkflowExpression] Func<int> bodyacn = null, [WorkflowExpression] Func<int> bodydin = null, [WorkflowExpression] Func<string> bodytaxAgent = null, [WorkflowExpression] Func<bool> bodygst = null, [WorkflowExpression] Func<bool> bodyresident = null, [WorkflowExpression] Func<string> bodybankName = null, [WorkflowExpression] Func<string> bodybankAccountName = null, [WorkflowExpression] Func<int> bodybankBSB = null, [WorkflowExpression] Func<int> bodybankAccountNumber = null, [WorkflowExpression] Func<ContactModel[]> bodycontactIds = null, [WorkflowExpression] Func<CustomField[]> bodycustomFields = null, [WorkflowExpression] Func<bodyenumEntityTypesInput> bodyenumEntityTypes = null, [WorkflowExpression] Func<bodyenumTrustTypesInput> bodyenumTrustTypes = null, [WorkflowExpression] Func<bodyenumGenderInput> bodyenumGender = null, [WorkflowExpression] Func<bodyenumEmailTypesInput> bodyenumEmailTypes = null, [WorkflowExpression] Func<bodyenumPhoneTypesInput> bodyenumPhoneTypes = null, [WorkflowExpression] Func<bodyenumContactTypesInput> bodyenumContactTypes = null, [WorkflowExpression] Func<bodyenumAddressTypesInput> bodyenumAddressTypes = null)
        {
            SourceExpression.Validate(bodyentityType, nameof(bodyentityType), required: true);
            SourceExpression.Validate(bodyclientCode, nameof(bodyclientCode), required: true);
            SourceExpression.Validate(bodypartnerId, nameof(bodypartnerId), required: true);
            SourceExpression.Validate(bodydivisionId, nameof(bodydivisionId), required: true);
            SourceExpression.Validate(bodysalutation, nameof(bodysalutation), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodytrustName, nameof(bodytrustName), required: false);
            SourceExpression.Validate(bodytrustType, nameof(bodytrustType), required: false);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodytradingName, nameof(bodytradingName), required: false);
            SourceExpression.Validate(bodypartnershipName, nameof(bodypartnershipName), required: false);
            SourceExpression.Validate(bodysmsfName, nameof(bodysmsfName), required: false);
            SourceExpression.Validate(bodysoftwareType, nameof(bodysoftwareType), required: false);
            SourceExpression.Validate(bodysoftwareName, nameof(bodysoftwareName), required: false);
            SourceExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            SourceExpression.Validate(bodyprospect, nameof(bodyprospect), required: false);
            SourceExpression.Validate(bodypreferredName, nameof(bodypreferredName), required: false);
            SourceExpression.Validate(bodydateofbirth, nameof(bodydateofbirth), required: false);
            SourceExpression.Validate(bodyplaceOfBirth, nameof(bodyplaceOfBirth), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodylinkedInProfileId, nameof(bodylinkedInProfileId), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            SourceExpression.Validate(bodyannualReviewDate, nameof(bodyannualReviewDate), required: false);
            SourceExpression.Validate(bodyformationDate, nameof(bodyformationDate), required: false);
            SourceExpression.Validate(bodyaddresses, nameof(bodyaddresses), required: false);
            SourceExpression.Validate(bodyindustry, nameof(bodyindustry), required: false);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodysalary, nameof(bodysalary), required: false);
            SourceExpression.Validate(bodyannualIncome, nameof(bodyannualIncome), required: false);
            SourceExpression.Validate(bodyisTaxClient, nameof(bodyisTaxClient), required: false);
            SourceExpression.Validate(bodyisLodgeActivity, nameof(bodyisLodgeActivity), required: false);
            SourceExpression.Validate(bodytfn, nameof(bodytfn), required: false);
            SourceExpression.Validate(bodyabn, nameof(bodyabn), required: false);
            SourceExpression.Validate(bodyacn, nameof(bodyacn), required: false);
            SourceExpression.Validate(bodydin, nameof(bodydin), required: false);
            SourceExpression.Validate(bodytaxAgent, nameof(bodytaxAgent), required: false);
            SourceExpression.Validate(bodygst, nameof(bodygst), required: false);
            SourceExpression.Validate(bodyresident, nameof(bodyresident), required: false);
            SourceExpression.Validate(bodybankName, nameof(bodybankName), required: false);
            SourceExpression.Validate(bodybankAccountName, nameof(bodybankAccountName), required: false);
            SourceExpression.Validate(bodybankBSB, nameof(bodybankBSB), required: false);
            SourceExpression.Validate(bodybankAccountNumber, nameof(bodybankAccountNumber), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodyenumEntityTypes, nameof(bodyenumEntityTypes), required: false);
            SourceExpression.Validate(bodyenumTrustTypes, nameof(bodyenumTrustTypes), required: false);
            SourceExpression.Validate(bodyenumGender, nameof(bodyenumGender), required: false);
            SourceExpression.Validate(bodyenumEmailTypes, nameof(bodyenumEmailTypes), required: false);
            SourceExpression.Validate(bodyenumPhoneTypes, nameof(bodyenumPhoneTypes), required: false);
            SourceExpression.Validate(bodyenumContactTypes, nameof(bodyenumContactTypes), required: false);
            SourceExpression.Validate(bodyenumAddressTypes, nameof(bodyenumAddressTypes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/clients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["entityType"] = SourceExpressionConverter.ConvertToken(bodyentityType);
                bodypropCount++;
                body["clientCode"] = SourceExpressionConverter.ConvertToken(bodyclientCode);
                if (bodysalutation != null)
                {
                    body["salutation"] = SourceExpressionConverter.ConvertToken(bodysalutation);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middleName"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodytrustName != null)
                {
                    body["trustName"] = SourceExpressionConverter.ConvertToken(bodytrustName);
                    bodypropCount++;
                }

                if (bodytrustType != null)
                {
                    body["trustType"] = SourceExpressionConverter.ConvertToken(bodytrustType);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["companyName"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodytradingName != null)
                {
                    body["tradingName"] = SourceExpressionConverter.ConvertToken(bodytradingName);
                    bodypropCount++;
                }

                if (bodypartnershipName != null)
                {
                    body["partnershipName"] = SourceExpressionConverter.ConvertToken(bodypartnershipName);
                    bodypropCount++;
                }

                if (bodysmsfName != null)
                {
                    body["smsfName"] = SourceExpressionConverter.ConvertToken(bodysmsfName);
                    bodypropCount++;
                }

                if (bodysoftwareType != null)
                {
                    body["softwareType"] = SourceExpressionConverter.ConvertToken(bodysoftwareType);
                    bodypropCount++;
                }

                if (bodysoftwareName != null)
                {
                    body["softwareName"] = SourceExpressionConverter.ConvertToken(bodysoftwareName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["partnerId"] = SourceExpressionConverter.ConvertToken(bodypartnerId);
                if (bodymanagerId != null)
                {
                    body["managerId"] = SourceExpressionConverter.ConvertToken(bodymanagerId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["divisionId"] = SourceExpressionConverter.ConvertToken(bodydivisionId);
                if (bodyprospect != null)
                {
                    body["prospect"] = SourceExpressionConverter.ConvertToken(bodyprospect);
                    bodypropCount++;
                }

                if (bodypreferredName != null)
                {
                    body["preferredName"] = SourceExpressionConverter.ConvertToken(bodypreferredName);
                    bodypropCount++;
                }

                if (bodydateofbirth != null)
                {
                    body["dateofbirth"] = SourceExpressionConverter.ConvertToken(bodydateofbirth);
                    bodypropCount++;
                }

                if (bodyplaceOfBirth != null)
                {
                    body["placeOfBirth"] = SourceExpressionConverter.ConvertToken(bodyplaceOfBirth);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodylinkedInProfileId != null)
                {
                    body["linkedInProfileId"] = SourceExpressionConverter.ConvertToken(bodylinkedInProfileId);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodyannualReviewDate != null)
                {
                    body["annualReviewDate"] = SourceExpressionConverter.ConvertToken(bodyannualReviewDate);
                    bodypropCount++;
                }

                if (bodyformationDate != null)
                {
                    body["formationDate"] = SourceExpressionConverter.ConvertToken(bodyformationDate);
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = SourceExpressionConverter.ConvertToken(bodyaddresses);
                    bodypropCount++;
                }

                if (bodyindustry != null)
                {
                    body["industry"] = SourceExpressionConverter.ConvertToken(bodyindustry);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodysalary != null)
                {
                    body["salary"] = SourceExpressionConverter.ConvertToken(bodysalary);
                    bodypropCount++;
                }

                if (bodyannualIncome != null)
                {
                    body["annualIncome"] = SourceExpressionConverter.ConvertToken(bodyannualIncome);
                    bodypropCount++;
                }

                if (bodyisTaxClient != null)
                {
                    body["isTaxClient"] = SourceExpressionConverter.ConvertToken(bodyisTaxClient);
                    bodypropCount++;
                }

                if (bodyisLodgeActivity != null)
                {
                    body["isLodgeActivity"] = SourceExpressionConverter.ConvertToken(bodyisLodgeActivity);
                    bodypropCount++;
                }

                if (bodytfn != null)
                {
                    body["tfn"] = SourceExpressionConverter.ConvertToken(bodytfn);
                    bodypropCount++;
                }

                if (bodyabn != null)
                {
                    body["abn"] = SourceExpressionConverter.ConvertToken(bodyabn);
                    bodypropCount++;
                }

                if (bodyacn != null)
                {
                    body["acn"] = SourceExpressionConverter.ConvertToken(bodyacn);
                    bodypropCount++;
                }

                if (bodydin != null)
                {
                    body["din"] = SourceExpressionConverter.ConvertToken(bodydin);
                    bodypropCount++;
                }

                if (bodytaxAgent != null)
                {
                    body["taxAgent"] = SourceExpressionConverter.ConvertToken(bodytaxAgent);
                    bodypropCount++;
                }

                if (bodygst != null)
                {
                    body["gst"] = SourceExpressionConverter.ConvertToken(bodygst);
                    bodypropCount++;
                }

                if (bodyresident != null)
                {
                    body["resident"] = SourceExpressionConverter.ConvertToken(bodyresident);
                    bodypropCount++;
                }

                if (bodybankName != null)
                {
                    body["bankName"] = SourceExpressionConverter.ConvertToken(bodybankName);
                    bodypropCount++;
                }

                if (bodybankAccountName != null)
                {
                    body["bankAccountName"] = SourceExpressionConverter.ConvertToken(bodybankAccountName);
                    bodypropCount++;
                }

                if (bodybankBSB != null)
                {
                    body["bankBSB"] = SourceExpressionConverter.ConvertToken(bodybankBSB);
                    bodypropCount++;
                }

                if (bodybankAccountNumber != null)
                {
                    body["bankAccountNumber"] = SourceExpressionConverter.ConvertToken(bodybankAccountNumber);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["customFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodyenumEntityTypes != null)
                {
                    body["enumEntityTypes"] = SourceExpressionConverter.Convert(bodyenumEntityTypes);
                    bodypropCount++;
                }

                if (bodyenumTrustTypes != null)
                {
                    body["enumTrustTypes"] = SourceExpressionConverter.Convert(bodyenumTrustTypes);
                    bodypropCount++;
                }

                if (bodyenumGender != null)
                {
                    body["enumGender"] = SourceExpressionConverter.Convert(bodyenumGender);
                    bodypropCount++;
                }

                if (bodyenumEmailTypes != null)
                {
                    body["enumEmailTypes"] = SourceExpressionConverter.Convert(bodyenumEmailTypes);
                    bodypropCount++;
                }

                if (bodyenumPhoneTypes != null)
                {
                    body["enumPhoneTypes"] = SourceExpressionConverter.Convert(bodyenumPhoneTypes);
                    bodypropCount++;
                }

                if (bodyenumContactTypes != null)
                {
                    body["enumContactTypes"] = SourceExpressionConverter.Convert(bodyenumContactTypes);
                    bodypropCount++;
                }

                if (bodyenumAddressTypes != null)
                {
                    body["enumAddressTypes"] = SourceExpressionConverter.Convert(bodyenumAddressTypes);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientDetailsResult> GetAClient([WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<bool> isCustomField = null)
        {
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            SourceExpression.Validate(isCustomField, nameof(isCustomField), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/clients/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(clientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (isCustomField != null)
                    callPayload.Queries["isCustomField"] = SourceExpressionConverter.ConvertO(isCustomField);
                return callPayload;
            }

            return new ApiConnectionAction<ClientDetailsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction UpdateAClient([WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<string> bodyentityType, [WorkflowExpression] Func<string> bodyclientCode, [WorkflowExpression] Func<string> bodypartnerId, [WorkflowExpression] Func<int> bodydivisionId, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytrustName = null, [WorkflowExpression] Func<string> bodytrustType = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodytradingName = null, [WorkflowExpression] Func<string> bodypartnershipName = null, [WorkflowExpression] Func<string> bodysmsfName = null, [WorkflowExpression] Func<string> bodysoftwareType = null, [WorkflowExpression] Func<string> bodysoftwareName = null, [WorkflowExpression] Func<string> bodymanagerId = null, [WorkflowExpression] Func<bool> bodyprospect = null, [WorkflowExpression] Func<string> bodypreferredName = null, [WorkflowExpression] Func<string> bodydateofbirth = null, [WorkflowExpression] Func<string> bodyplaceOfBirth = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<EmailInfo[]> bodyemail = null, [WorkflowExpression] Func<Phone[]> bodyphone = null, [WorkflowExpression] Func<string> bodylinkedInProfileId = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodyannualReviewDate = null, [WorkflowExpression] Func<string> bodyformationDate = null, [WorkflowExpression] Func<Address[]> bodyaddresses = null, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodysalary = null, [WorkflowExpression] Func<string> bodyannualIncome = null, [WorkflowExpression] Func<bool> bodyisTaxClient = null, [WorkflowExpression] Func<bool> bodyisLodgeActivity = null, [WorkflowExpression] Func<int> bodytfn = null, [WorkflowExpression] Func<int> bodyabn = null, [WorkflowExpression] Func<int> bodyacn = null, [WorkflowExpression] Func<int> bodydin = null, [WorkflowExpression] Func<string> bodytaxAgent = null, [WorkflowExpression] Func<bool> bodygst = null, [WorkflowExpression] Func<bool> bodyresident = null, [WorkflowExpression] Func<string> bodybankName = null, [WorkflowExpression] Func<string> bodybankAccountName = null, [WorkflowExpression] Func<int> bodybankBSB = null, [WorkflowExpression] Func<int> bodybankAccountNumber = null, [WorkflowExpression] Func<ContactModel[]> bodycontactIds = null, [WorkflowExpression] Func<CustomField[]> bodycustomFields = null, [WorkflowExpression] Func<bodyenumEntityTypesInput> bodyenumEntityTypes = null, [WorkflowExpression] Func<bodyenumTrustTypesInput> bodyenumTrustTypes = null, [WorkflowExpression] Func<bodyenumGenderInput> bodyenumGender = null, [WorkflowExpression] Func<bodyenumEmailTypesInput> bodyenumEmailTypes = null, [WorkflowExpression] Func<bodyenumPhoneTypesInput> bodyenumPhoneTypes = null, [WorkflowExpression] Func<bodyenumContactTypesInput> bodyenumContactTypes = null, [WorkflowExpression] Func<bodyenumAddressTypesInput> bodyenumAddressTypes = null)
        {
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            SourceExpression.Validate(bodyentityType, nameof(bodyentityType), required: true);
            SourceExpression.Validate(bodyclientCode, nameof(bodyclientCode), required: true);
            SourceExpression.Validate(bodypartnerId, nameof(bodypartnerId), required: true);
            SourceExpression.Validate(bodydivisionId, nameof(bodydivisionId), required: true);
            SourceExpression.Validate(bodysalutation, nameof(bodysalutation), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodytrustName, nameof(bodytrustName), required: false);
            SourceExpression.Validate(bodytrustType, nameof(bodytrustType), required: false);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodytradingName, nameof(bodytradingName), required: false);
            SourceExpression.Validate(bodypartnershipName, nameof(bodypartnershipName), required: false);
            SourceExpression.Validate(bodysmsfName, nameof(bodysmsfName), required: false);
            SourceExpression.Validate(bodysoftwareType, nameof(bodysoftwareType), required: false);
            SourceExpression.Validate(bodysoftwareName, nameof(bodysoftwareName), required: false);
            SourceExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            SourceExpression.Validate(bodyprospect, nameof(bodyprospect), required: false);
            SourceExpression.Validate(bodypreferredName, nameof(bodypreferredName), required: false);
            SourceExpression.Validate(bodydateofbirth, nameof(bodydateofbirth), required: false);
            SourceExpression.Validate(bodyplaceOfBirth, nameof(bodyplaceOfBirth), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodylinkedInProfileId, nameof(bodylinkedInProfileId), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            SourceExpression.Validate(bodyannualReviewDate, nameof(bodyannualReviewDate), required: false);
            SourceExpression.Validate(bodyformationDate, nameof(bodyformationDate), required: false);
            SourceExpression.Validate(bodyaddresses, nameof(bodyaddresses), required: false);
            SourceExpression.Validate(bodyindustry, nameof(bodyindustry), required: false);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodysalary, nameof(bodysalary), required: false);
            SourceExpression.Validate(bodyannualIncome, nameof(bodyannualIncome), required: false);
            SourceExpression.Validate(bodyisTaxClient, nameof(bodyisTaxClient), required: false);
            SourceExpression.Validate(bodyisLodgeActivity, nameof(bodyisLodgeActivity), required: false);
            SourceExpression.Validate(bodytfn, nameof(bodytfn), required: false);
            SourceExpression.Validate(bodyabn, nameof(bodyabn), required: false);
            SourceExpression.Validate(bodyacn, nameof(bodyacn), required: false);
            SourceExpression.Validate(bodydin, nameof(bodydin), required: false);
            SourceExpression.Validate(bodytaxAgent, nameof(bodytaxAgent), required: false);
            SourceExpression.Validate(bodygst, nameof(bodygst), required: false);
            SourceExpression.Validate(bodyresident, nameof(bodyresident), required: false);
            SourceExpression.Validate(bodybankName, nameof(bodybankName), required: false);
            SourceExpression.Validate(bodybankAccountName, nameof(bodybankAccountName), required: false);
            SourceExpression.Validate(bodybankBSB, nameof(bodybankBSB), required: false);
            SourceExpression.Validate(bodybankAccountNumber, nameof(bodybankAccountNumber), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodyenumEntityTypes, nameof(bodyenumEntityTypes), required: false);
            SourceExpression.Validate(bodyenumTrustTypes, nameof(bodyenumTrustTypes), required: false);
            SourceExpression.Validate(bodyenumGender, nameof(bodyenumGender), required: false);
            SourceExpression.Validate(bodyenumEmailTypes, nameof(bodyenumEmailTypes), required: false);
            SourceExpression.Validate(bodyenumPhoneTypes, nameof(bodyenumPhoneTypes), required: false);
            SourceExpression.Validate(bodyenumContactTypes, nameof(bodyenumContactTypes), required: false);
            SourceExpression.Validate(bodyenumAddressTypes, nameof(bodyenumAddressTypes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/clients/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(clientId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["entityType"] = SourceExpressionConverter.ConvertToken(bodyentityType);
                bodypropCount++;
                body["clientCode"] = SourceExpressionConverter.ConvertToken(bodyclientCode);
                if (bodysalutation != null)
                {
                    body["salutation"] = SourceExpressionConverter.ConvertToken(bodysalutation);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middleName"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodytrustName != null)
                {
                    body["trustName"] = SourceExpressionConverter.ConvertToken(bodytrustName);
                    bodypropCount++;
                }

                if (bodytrustType != null)
                {
                    body["trustType"] = SourceExpressionConverter.ConvertToken(bodytrustType);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["companyName"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodytradingName != null)
                {
                    body["tradingName"] = SourceExpressionConverter.ConvertToken(bodytradingName);
                    bodypropCount++;
                }

                if (bodypartnershipName != null)
                {
                    body["partnershipName"] = SourceExpressionConverter.ConvertToken(bodypartnershipName);
                    bodypropCount++;
                }

                if (bodysmsfName != null)
                {
                    body["smsfName"] = SourceExpressionConverter.ConvertToken(bodysmsfName);
                    bodypropCount++;
                }

                if (bodysoftwareType != null)
                {
                    body["softwareType"] = SourceExpressionConverter.ConvertToken(bodysoftwareType);
                    bodypropCount++;
                }

                if (bodysoftwareName != null)
                {
                    body["softwareName"] = SourceExpressionConverter.ConvertToken(bodysoftwareName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["partnerId"] = SourceExpressionConverter.ConvertToken(bodypartnerId);
                if (bodymanagerId != null)
                {
                    body["managerId"] = SourceExpressionConverter.ConvertToken(bodymanagerId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["divisionId"] = SourceExpressionConverter.ConvertToken(bodydivisionId);
                if (bodyprospect != null)
                {
                    body["prospect"] = SourceExpressionConverter.ConvertToken(bodyprospect);
                    bodypropCount++;
                }

                if (bodypreferredName != null)
                {
                    body["preferredName"] = SourceExpressionConverter.ConvertToken(bodypreferredName);
                    bodypropCount++;
                }

                if (bodydateofbirth != null)
                {
                    body["dateofbirth"] = SourceExpressionConverter.ConvertToken(bodydateofbirth);
                    bodypropCount++;
                }

                if (bodyplaceOfBirth != null)
                {
                    body["placeOfBirth"] = SourceExpressionConverter.ConvertToken(bodyplaceOfBirth);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodylinkedInProfileId != null)
                {
                    body["linkedInProfileId"] = SourceExpressionConverter.ConvertToken(bodylinkedInProfileId);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodyannualReviewDate != null)
                {
                    body["annualReviewDate"] = SourceExpressionConverter.ConvertToken(bodyannualReviewDate);
                    bodypropCount++;
                }

                if (bodyformationDate != null)
                {
                    body["formationDate"] = SourceExpressionConverter.ConvertToken(bodyformationDate);
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = SourceExpressionConverter.ConvertToken(bodyaddresses);
                    bodypropCount++;
                }

                if (bodyindustry != null)
                {
                    body["industry"] = SourceExpressionConverter.ConvertToken(bodyindustry);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodysalary != null)
                {
                    body["salary"] = SourceExpressionConverter.ConvertToken(bodysalary);
                    bodypropCount++;
                }

                if (bodyannualIncome != null)
                {
                    body["annualIncome"] = SourceExpressionConverter.ConvertToken(bodyannualIncome);
                    bodypropCount++;
                }

                if (bodyisTaxClient != null)
                {
                    body["isTaxClient"] = SourceExpressionConverter.ConvertToken(bodyisTaxClient);
                    bodypropCount++;
                }

                if (bodyisLodgeActivity != null)
                {
                    body["isLodgeActivity"] = SourceExpressionConverter.ConvertToken(bodyisLodgeActivity);
                    bodypropCount++;
                }

                if (bodytfn != null)
                {
                    body["tfn"] = SourceExpressionConverter.ConvertToken(bodytfn);
                    bodypropCount++;
                }

                if (bodyabn != null)
                {
                    body["abn"] = SourceExpressionConverter.ConvertToken(bodyabn);
                    bodypropCount++;
                }

                if (bodyacn != null)
                {
                    body["acn"] = SourceExpressionConverter.ConvertToken(bodyacn);
                    bodypropCount++;
                }

                if (bodydin != null)
                {
                    body["din"] = SourceExpressionConverter.ConvertToken(bodydin);
                    bodypropCount++;
                }

                if (bodytaxAgent != null)
                {
                    body["taxAgent"] = SourceExpressionConverter.ConvertToken(bodytaxAgent);
                    bodypropCount++;
                }

                if (bodygst != null)
                {
                    body["gst"] = SourceExpressionConverter.ConvertToken(bodygst);
                    bodypropCount++;
                }

                if (bodyresident != null)
                {
                    body["resident"] = SourceExpressionConverter.ConvertToken(bodyresident);
                    bodypropCount++;
                }

                if (bodybankName != null)
                {
                    body["bankName"] = SourceExpressionConverter.ConvertToken(bodybankName);
                    bodypropCount++;
                }

                if (bodybankAccountName != null)
                {
                    body["bankAccountName"] = SourceExpressionConverter.ConvertToken(bodybankAccountName);
                    bodypropCount++;
                }

                if (bodybankBSB != null)
                {
                    body["bankBSB"] = SourceExpressionConverter.ConvertToken(bodybankBSB);
                    bodypropCount++;
                }

                if (bodybankAccountNumber != null)
                {
                    body["bankAccountNumber"] = SourceExpressionConverter.ConvertToken(bodybankAccountNumber);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["customFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodyenumEntityTypes != null)
                {
                    body["enumEntityTypes"] = SourceExpressionConverter.Convert(bodyenumEntityTypes);
                    bodypropCount++;
                }

                if (bodyenumTrustTypes != null)
                {
                    body["enumTrustTypes"] = SourceExpressionConverter.Convert(bodyenumTrustTypes);
                    bodypropCount++;
                }

                if (bodyenumGender != null)
                {
                    body["enumGender"] = SourceExpressionConverter.Convert(bodyenumGender);
                    bodypropCount++;
                }

                if (bodyenumEmailTypes != null)
                {
                    body["enumEmailTypes"] = SourceExpressionConverter.Convert(bodyenumEmailTypes);
                    bodypropCount++;
                }

                if (bodyenumPhoneTypes != null)
                {
                    body["enumPhoneTypes"] = SourceExpressionConverter.Convert(bodyenumPhoneTypes);
                    bodypropCount++;
                }

                if (bodyenumContactTypes != null)
                {
                    body["enumContactTypes"] = SourceExpressionConverter.Convert(bodyenumContactTypes);
                    bodypropCount++;
                }

                if (bodyenumAddressTypes != null)
                {
                    body["enumAddressTypes"] = SourceExpressionConverter.Convert(bodyenumAddressTypes);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction GetClientsTags()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/clients/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction CreateClientGroup([WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodypartnerId = null, [WorkflowExpression] Func<int[]> bodytags = null, [WorkflowExpression] Func<GroupClient[]> bodygroupClients = null, [WorkflowExpression] Func<int> bodycontactId = null)
        {
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: false);
            SourceExpression.Validate(bodypartnerId, nameof(bodypartnerId), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodygroupClients, nameof(bodygroupClients), required: false);
            SourceExpression.Validate(bodycontactId, nameof(bodycontactId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/clients/clientgroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupName != null)
                {
                    body["groupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                    bodypropCount++;
                }

                if (bodypartnerId != null)
                {
                    body["partnerId"] = SourceExpressionConverter.ConvertToken(bodypartnerId);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodygroupClients != null)
                {
                    body["groupClients"] = SourceExpressionConverter.ConvertToken(bodygroupClients);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["contactId"] = SourceExpressionConverter.ConvertToken(bodycontactId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction UpdateClientGroup([WorkflowExpression] Func<string> groupCode, [WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodypartnerId = null, [WorkflowExpression] Func<int[]> bodytags = null, [WorkflowExpression] Func<GroupClient[]> bodygroupClients = null, [WorkflowExpression] Func<int> bodycontactId = null)
        {
            SourceExpression.Validate(groupCode, nameof(groupCode), required: true);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: false);
            SourceExpression.Validate(bodypartnerId, nameof(bodypartnerId), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodygroupClients, nameof(bodygroupClients), required: false);
            SourceExpression.Validate(bodycontactId, nameof(bodycontactId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/clients/clientgroup/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupCode, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupName != null)
                {
                    body["groupName"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                    bodypropCount++;
                }

                if (bodypartnerId != null)
                {
                    body["partnerId"] = SourceExpressionConverter.ConvertToken(bodypartnerId);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodygroupClients != null)
                {
                    body["groupClients"] = SourceExpressionConverter.ConvertToken(bodygroupClients);
                    bodypropCount++;
                }

                if (bodycontactId != null)
                {
                    body["contactId"] = SourceExpressionConverter.ConvertToken(bodycontactId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<RelationshipsResult> GetClientRelationships([WorkflowExpression] Func<int> clientId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/clients/{0}/relationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(clientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<RelationshipsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ClientDebtor> GetClientsDebtor([WorkflowExpression] Func<int> clientId)
        {
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/clients/{0}/DebtorClients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(clientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ClientDebtor>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<ContactResult> GetContacts([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<int> contactId = null, [WorkflowExpression] Func<bool> isClientId = null, [WorkflowExpression] Func<bool> isCustomField = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            SourceExpression.Validate(contactId, nameof(contactId), required: false);
            SourceExpression.Validate(isClientId, nameof(isClientId), required: false);
            SourceExpression.Validate(isCustomField, nameof(isCustomField), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = SourceExpressionConverter.ConvertO(modifiedSince);
                if (contactId != null)
                    callPayload.Queries["contactId"] = SourceExpressionConverter.ConvertO(contactId);
                if (isClientId != null)
                    callPayload.Queries["isClientId"] = SourceExpressionConverter.ConvertO(isClientId);
                if (isCustomField != null)
                    callPayload.Queries["isCustomField"] = SourceExpressionConverter.ConvertO(isCustomField);
                return callPayload;
            }

            return new ApiConnectionAction<ContactResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction UpdateAContact([WorkflowExpression] Func<int> contactId, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<Phone[]> bodyphone = null, [WorkflowExpression] Func<EmailInfo[]> bodyemail = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyplaceOfBirth = null, [WorkflowExpression] Func<string> bodylinkedInProfileId = null, [WorkflowExpression] Func<string> bodypreferredName = null, [WorkflowExpression] Func<string> bodydin = null, [WorkflowExpression] Func<string> bodydateOfBirth = null, [WorkflowExpression] Func<bool> bodyisImportent = null, [WorkflowExpression] Func<Address[]> bodyaddresses = null, [WorkflowExpression] Func<CustomField[]> bodycustomFields = null, [WorkflowExpression] Func<bodyenumAddressTypesInput> bodyenumAddressTypes = null)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(bodysalutation, nameof(bodysalutation), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodygender, nameof(bodygender), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodyplaceOfBirth, nameof(bodyplaceOfBirth), required: false);
            SourceExpression.Validate(bodylinkedInProfileId, nameof(bodylinkedInProfileId), required: false);
            SourceExpression.Validate(bodypreferredName, nameof(bodypreferredName), required: false);
            SourceExpression.Validate(bodydin, nameof(bodydin), required: false);
            SourceExpression.Validate(bodydateOfBirth, nameof(bodydateOfBirth), required: false);
            SourceExpression.Validate(bodyisImportent, nameof(bodyisImportent), required: false);
            SourceExpression.Validate(bodyaddresses, nameof(bodyaddresses), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodyenumAddressTypes, nameof(bodyenumAddressTypes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contactId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysalutation != null)
                {
                    body["salutation"] = SourceExpressionConverter.ConvertToken(bodysalutation);
                    bodypropCount++;
                }

                bodypropCount++;
                body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                if (bodymiddleName != null)
                {
                    body["middleName"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["companyName"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodyplaceOfBirth != null)
                {
                    body["placeOfBirth"] = SourceExpressionConverter.ConvertToken(bodyplaceOfBirth);
                    bodypropCount++;
                }

                if (bodylinkedInProfileId != null)
                {
                    body["linkedInProfileID"] = SourceExpressionConverter.ConvertToken(bodylinkedInProfileId);
                    bodypropCount++;
                }

                if (bodypreferredName != null)
                {
                    body["preferredName"] = SourceExpressionConverter.ConvertToken(bodypreferredName);
                    bodypropCount++;
                }

                if (bodydin != null)
                {
                    body["din"] = SourceExpressionConverter.ConvertToken(bodydin);
                    bodypropCount++;
                }

                if (bodydateOfBirth != null)
                {
                    body["dateOfBirth"] = SourceExpressionConverter.ConvertToken(bodydateOfBirth);
                    bodypropCount++;
                }

                if (bodyisImportent != null)
                {
                    body["isImportent"] = SourceExpressionConverter.ConvertToken(bodyisImportent);
                    bodypropCount++;
                }

                if (bodyaddresses != null)
                {
                    body["addresses"] = SourceExpressionConverter.ConvertToken(bodyaddresses);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["customFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodyenumAddressTypes != null)
                {
                    body["enumAddressTypes"] = SourceExpressionConverter.Convert(bodyenumAddressTypes);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<DivisionsResult> GetDivisions([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> modifiedSince = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/divisions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = SourceExpressionConverter.ConvertO(modifiedSince);
                return callPayload;
            }

            return new ApiConnectionAction<DivisionsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<InvoiceDetailResult> GetInvoices([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<bool> isDraftInvoice = null, [WorkflowExpression] Func<bool> includeInvoiceDetails = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<bool> isDebitClient = null, [WorkflowExpression] Func<string> clientname = null, [WorkflowExpression] Func<string> clientcode = null, [WorkflowExpression] Func<string> jobname = null, [WorkflowExpression] Func<string> jobcode = null, [WorkflowExpression] Func<string> billingEntityId = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(isDraftInvoice, nameof(isDraftInvoice), required: false);
            SourceExpression.Validate(includeInvoiceDetails, nameof(includeInvoiceDetails), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            SourceExpression.Validate(isDebitClient, nameof(isDebitClient), required: false);
            SourceExpression.Validate(clientname, nameof(clientname), required: false);
            SourceExpression.Validate(clientcode, nameof(clientcode), required: false);
            SourceExpression.Validate(jobname, nameof(jobname), required: false);
            SourceExpression.Validate(jobcode, nameof(jobcode), required: false);
            SourceExpression.Validate(billingEntityId, nameof(billingEntityId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (isDraftInvoice != null)
                    callPayload.Queries["isDraftInvoice"] = SourceExpressionConverter.ConvertO(isDraftInvoice);
                if (includeInvoiceDetails != null)
                    callPayload.Queries["includeInvoiceDetails"] = SourceExpressionConverter.ConvertO(includeInvoiceDetails);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = SourceExpressionConverter.ConvertO(modifiedSince);
                if (isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = SourceExpressionConverter.ConvertO(isDebitClient);
                if (clientname != null)
                    callPayload.Queries["clientname"] = SourceExpressionConverter.ConvertO(clientname);
                if (clientcode != null)
                    callPayload.Queries["clientcode"] = SourceExpressionConverter.ConvertO(clientcode);
                if (jobname != null)
                    callPayload.Queries["jobname"] = SourceExpressionConverter.ConvertO(jobname);
                if (jobcode != null)
                    callPayload.Queries["jobcode"] = SourceExpressionConverter.ConvertO(jobcode);
                if (billingEntityId != null)
                    callPayload.Queries["billingEntityId"] = SourceExpressionConverter.ConvertO(billingEntityId);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceDetailResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction GetFirmCustomfields([WorkflowExpression] Func<string> context)
        {
            SourceExpression.Validate(context, nameof(context), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/settings/custom-fields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(context, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction CreateTimesheet([WorkflowExpression] Func<bool> bodyisbillable = null, [WorkflowExpression] Func<int> bodyjobId = null, [WorkflowExpression] Func<int> bodytaskId = null, [WorkflowExpression] Func<int> bodynonbillableId = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<double> bodyunits = null, [WorkflowExpression] Func<string> bodystarttime = null, [WorkflowExpression] Func<double> bodyrate = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(bodyisbillable, nameof(bodyisbillable), required: false);
            SourceExpression.Validate(bodyjobId, nameof(bodyjobId), required: false);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: false);
            SourceExpression.Validate(bodynonbillableId, nameof(bodynonbillableId), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyunits, nameof(bodyunits), required: false);
            SourceExpression.Validate(bodystarttime, nameof(bodystarttime), required: false);
            SourceExpression.Validate(bodyrate, nameof(bodyrate), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/timesheet/logtime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisbillable != null)
                {
                    body["isbillable"] = SourceExpressionConverter.ConvertToken(bodyisbillable);
                    bodypropCount++;
                }

                if (bodyjobId != null)
                {
                    body["jobId"] = SourceExpressionConverter.ConvertToken(bodyjobId);
                    bodypropCount++;
                }

                if (bodytaskId != null)
                {
                    body["taskId"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                    bodypropCount++;
                }

                if (bodynonbillableId != null)
                {
                    body["nonbillableId"] = SourceExpressionConverter.ConvertToken(bodynonbillableId);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyunits != null)
                {
                    body["units"] = SourceExpressionConverter.ConvertToken(bodyunits);
                    bodypropCount++;
                }

                if (bodystarttime != null)
                {
                    body["starttime"] = SourceExpressionConverter.ConvertToken(bodystarttime);
                    bodypropCount++;
                }

                if (bodyrate != null)
                {
                    body["rate"] = SourceExpressionConverter.ConvertToken(bodyrate);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction GetNonBillableTimesheetTypes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/timesheet/non-billabletypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<UsersResult> GetUsers([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<string> rolename = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            SourceExpression.Validate(rolename, nameof(rolename), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = SourceExpressionConverter.ConvertO(modifiedSince);
                if (rolename != null)
                    callPayload.Queries["rolename"] = SourceExpressionConverter.ConvertO(rolename);
                return callPayload;
            }

            return new ApiConnectionAction<UsersResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<Teams> GetTeams()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/teams";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Teams>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobsResult> GetJobs([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> partnerId = null, [WorkflowExpression] Func<string> clientName = null, [WorkflowExpression] Func<string> clientcode = null, [WorkflowExpression] Func<string> modifiedSince = null, [WorkflowExpression] Func<bool> isDebitClient = null, [WorkflowExpression] Func<bool> isCustomField = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(partnerId, nameof(partnerId), required: false);
            SourceExpression.Validate(clientName, nameof(clientName), required: false);
            SourceExpression.Validate(clientcode, nameof(clientcode), required: false);
            SourceExpression.Validate(modifiedSince, nameof(modifiedSince), required: false);
            SourceExpression.Validate(isDebitClient, nameof(isDebitClient), required: false);
            SourceExpression.Validate(isCustomField, nameof(isCustomField), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/workflows/jobs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (partnerId != null)
                    callPayload.Queries["partnerId"] = SourceExpressionConverter.ConvertO(partnerId);
                if (clientName != null)
                    callPayload.Queries["clientName"] = SourceExpressionConverter.ConvertO(clientName);
                if (clientcode != null)
                    callPayload.Queries["clientcode"] = SourceExpressionConverter.ConvertO(clientcode);
                if (modifiedSince != null)
                    callPayload.Queries["modifiedSince"] = SourceExpressionConverter.ConvertO(modifiedSince);
                if (isDebitClient != null)
                    callPayload.Queries["isDebitClient"] = SourceExpressionConverter.ConvertO(isDebitClient);
                if (isCustomField != null)
                    callPayload.Queries["isCustomField"] = SourceExpressionConverter.ConvertO(isCustomField);
                return callPayload;
            }

            return new ApiConnectionAction<JobsResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction CreateJobs([WorkflowExpression] Func<int> bodyclientId = null, [WorkflowExpression] Func<int> bodydivisionId = null, [WorkflowExpression] Func<int> bodydebtorclientId = null, [WorkflowExpression] Func<int> bodyjobTypeId = null, [WorkflowExpression] Func<string> bodyjobCategory = null, [WorkflowExpression] Func<string> bodyjobName = null, [WorkflowExpression] Func<int> bodyfinancialYear = null, [WorkflowExpression] Func<int> bodytemplateId = null, [WorkflowExpression] Func<string> bodymanagerId = null, [WorkflowExpression] Func<string> bodypartnerId = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyestimateType = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodybillingMethod = null, [WorkflowExpression] Func<int> bodyteamId = null, [WorkflowExpression] Func<double> bodyquoteAmount = null, [WorkflowExpression] Func<int> bodystatusId = null, [WorkflowExpression] Func<CustomField[]> bodycustomFields = null, [WorkflowExpression] Func<bodyenumJobCategoryTypesInput> bodyenumJobCategoryTypes = null, [WorkflowExpression] Func<bodyenumEstimateTypesInput> bodyenumEstimateTypes = null, [WorkflowExpression] Func<bodyenumBillingMethodsInput> bodyenumBillingMethods = null, [WorkflowExpression] Func<bodyenumPriorityTypesInput> bodyenumPriorityTypes = null)
        {
            SourceExpression.Validate(bodyclientId, nameof(bodyclientId), required: false);
            SourceExpression.Validate(bodydivisionId, nameof(bodydivisionId), required: false);
            SourceExpression.Validate(bodydebtorclientId, nameof(bodydebtorclientId), required: false);
            SourceExpression.Validate(bodyjobTypeId, nameof(bodyjobTypeId), required: false);
            SourceExpression.Validate(bodyjobCategory, nameof(bodyjobCategory), required: false);
            SourceExpression.Validate(bodyjobName, nameof(bodyjobName), required: false);
            SourceExpression.Validate(bodyfinancialYear, nameof(bodyfinancialYear), required: false);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            SourceExpression.Validate(bodypartnerId, nameof(bodypartnerId), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodyestimateType, nameof(bodyestimateType), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodybillingMethod, nameof(bodybillingMethod), required: false);
            SourceExpression.Validate(bodyteamId, nameof(bodyteamId), required: false);
            SourceExpression.Validate(bodyquoteAmount, nameof(bodyquoteAmount), required: false);
            SourceExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodyenumJobCategoryTypes, nameof(bodyenumJobCategoryTypes), required: false);
            SourceExpression.Validate(bodyenumEstimateTypes, nameof(bodyenumEstimateTypes), required: false);
            SourceExpression.Validate(bodyenumBillingMethods, nameof(bodyenumBillingMethods), required: false);
            SourceExpression.Validate(bodyenumPriorityTypes, nameof(bodyenumPriorityTypes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/workflows/jobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyclientId != null)
                {
                    body["clientId"] = SourceExpressionConverter.ConvertToken(bodyclientId);
                    bodypropCount++;
                }

                if (bodydivisionId != null)
                {
                    body["divisionId"] = SourceExpressionConverter.ConvertToken(bodydivisionId);
                    bodypropCount++;
                }

                if (bodydebtorclientId != null)
                {
                    body["debtorclientId"] = SourceExpressionConverter.ConvertToken(bodydebtorclientId);
                    bodypropCount++;
                }

                if (bodyjobTypeId != null)
                {
                    body["jobTypeId"] = SourceExpressionConverter.ConvertToken(bodyjobTypeId);
                    bodypropCount++;
                }

                if (bodyjobCategory != null)
                {
                    body["jobCategory"] = SourceExpressionConverter.ConvertToken(bodyjobCategory);
                    bodypropCount++;
                }

                if (bodyjobName != null)
                {
                    body["jobName"] = SourceExpressionConverter.ConvertToken(bodyjobName);
                    bodypropCount++;
                }

                if (bodyfinancialYear != null)
                {
                    body["financialYear"] = SourceExpressionConverter.ConvertToken(bodyfinancialYear);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["managerId"] = SourceExpressionConverter.ConvertToken(bodymanagerId);
                    bodypropCount++;
                }

                if (bodypartnerId != null)
                {
                    body["partnerId"] = SourceExpressionConverter.ConvertToken(bodypartnerId);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodyestimateType != null)
                {
                    body["estimateType"] = SourceExpressionConverter.ConvertToken(bodyestimateType);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodybillingMethod != null)
                {
                    body["billingMethod"] = SourceExpressionConverter.ConvertToken(bodybillingMethod);
                    bodypropCount++;
                }

                if (bodyteamId != null)
                {
                    body["teamId"] = SourceExpressionConverter.ConvertToken(bodyteamId);
                    bodypropCount++;
                }

                if (bodyquoteAmount != null)
                {
                    body["quoteAmount"] = SourceExpressionConverter.ConvertToken(bodyquoteAmount);
                    bodypropCount++;
                }

                if (bodystatusId != null)
                {
                    body["statusId"] = SourceExpressionConverter.ConvertToken(bodystatusId);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["customFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodyenumJobCategoryTypes != null)
                {
                    body["enumJobCategoryTypes"] = SourceExpressionConverter.Convert(bodyenumJobCategoryTypes);
                    bodypropCount++;
                }

                if (bodyenumEstimateTypes != null)
                {
                    body["enumEstimateTypes"] = SourceExpressionConverter.Convert(bodyenumEstimateTypes);
                    bodypropCount++;
                }

                if (bodyenumBillingMethods != null)
                {
                    body["enumBillingMethods"] = SourceExpressionConverter.Convert(bodyenumBillingMethods);
                    bodypropCount++;
                }

                if (bodyenumPriorityTypes != null)
                {
                    body["enumPriorityTypes"] = SourceExpressionConverter.Convert(bodyenumPriorityTypes);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction UpdateJobStatuses([WorkflowExpression] Func<int> bodyjobId = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodystatusOwner = null)
        {
            SourceExpression.Validate(bodyjobId, nameof(bodyjobId), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodystatusOwner, nameof(bodystatusOwner), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/workflows/statuses";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobId != null)
                {
                    body["jobId"] = SourceExpressionConverter.ConvertToken(bodyjobId);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodystatusOwner != null)
                {
                    body["statusOwner"] = SourceExpressionConverter.ConvertToken(bodystatusOwner);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IWorkflowAction UpdateAJob([WorkflowExpression] Func<int> jobId, [WorkflowExpression] Func<int> bodyclientId = null, [WorkflowExpression] Func<int> bodydivisionId = null, [WorkflowExpression] Func<int> bodydebtorclientId = null, [WorkflowExpression] Func<int> bodyjobTypeId = null, [WorkflowExpression] Func<string> bodyjobCategory = null, [WorkflowExpression] Func<string> bodyjobName = null, [WorkflowExpression] Func<int> bodyfinancialYear = null, [WorkflowExpression] Func<int> bodytemplateId = null, [WorkflowExpression] Func<string> bodymanagerId = null, [WorkflowExpression] Func<string> bodypartnerId = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyestimateType = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodybillingMethod = null, [WorkflowExpression] Func<int> bodyteamId = null, [WorkflowExpression] Func<double> bodyquoteAmount = null, [WorkflowExpression] Func<int> bodystatusId = null, [WorkflowExpression] Func<CustomField[]> bodycustomFields = null, [WorkflowExpression] Func<bodyenumJobCategoryTypesInput> bodyenumJobCategoryTypes = null, [WorkflowExpression] Func<bodyenumEstimateTypesInput> bodyenumEstimateTypes = null, [WorkflowExpression] Func<bodyenumBillingMethodsInput> bodyenumBillingMethods = null, [WorkflowExpression] Func<bodyenumPriorityTypesInput> bodyenumPriorityTypes = null)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            SourceExpression.Validate(bodyclientId, nameof(bodyclientId), required: false);
            SourceExpression.Validate(bodydivisionId, nameof(bodydivisionId), required: false);
            SourceExpression.Validate(bodydebtorclientId, nameof(bodydebtorclientId), required: false);
            SourceExpression.Validate(bodyjobTypeId, nameof(bodyjobTypeId), required: false);
            SourceExpression.Validate(bodyjobCategory, nameof(bodyjobCategory), required: false);
            SourceExpression.Validate(bodyjobName, nameof(bodyjobName), required: false);
            SourceExpression.Validate(bodyfinancialYear, nameof(bodyfinancialYear), required: false);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodymanagerId, nameof(bodymanagerId), required: false);
            SourceExpression.Validate(bodypartnerId, nameof(bodypartnerId), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodyestimateType, nameof(bodyestimateType), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodybillingMethod, nameof(bodybillingMethod), required: false);
            SourceExpression.Validate(bodyteamId, nameof(bodyteamId), required: false);
            SourceExpression.Validate(bodyquoteAmount, nameof(bodyquoteAmount), required: false);
            SourceExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodyenumJobCategoryTypes, nameof(bodyenumJobCategoryTypes), required: false);
            SourceExpression.Validate(bodyenumEstimateTypes, nameof(bodyenumEstimateTypes), required: false);
            SourceExpression.Validate(bodyenumBillingMethods, nameof(bodyenumBillingMethods), required: false);
            SourceExpression.Validate(bodyenumPriorityTypes, nameof(bodyenumPriorityTypes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/workflows/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(jobId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyclientId != null)
                {
                    body["clientId"] = SourceExpressionConverter.ConvertToken(bodyclientId);
                    bodypropCount++;
                }

                if (bodydivisionId != null)
                {
                    body["divisionId"] = SourceExpressionConverter.ConvertToken(bodydivisionId);
                    bodypropCount++;
                }

                if (bodydebtorclientId != null)
                {
                    body["debtorclientId"] = SourceExpressionConverter.ConvertToken(bodydebtorclientId);
                    bodypropCount++;
                }

                if (bodyjobTypeId != null)
                {
                    body["jobTypeId"] = SourceExpressionConverter.ConvertToken(bodyjobTypeId);
                    bodypropCount++;
                }

                if (bodyjobCategory != null)
                {
                    body["jobCategory"] = SourceExpressionConverter.ConvertToken(bodyjobCategory);
                    bodypropCount++;
                }

                if (bodyjobName != null)
                {
                    body["jobName"] = SourceExpressionConverter.ConvertToken(bodyjobName);
                    bodypropCount++;
                }

                if (bodyfinancialYear != null)
                {
                    body["financialYear"] = SourceExpressionConverter.ConvertToken(bodyfinancialYear);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["managerId"] = SourceExpressionConverter.ConvertToken(bodymanagerId);
                    bodypropCount++;
                }

                if (bodypartnerId != null)
                {
                    body["partnerId"] = SourceExpressionConverter.ConvertToken(bodypartnerId);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodyestimateType != null)
                {
                    body["estimateType"] = SourceExpressionConverter.ConvertToken(bodyestimateType);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodybillingMethod != null)
                {
                    body["billingMethod"] = SourceExpressionConverter.ConvertToken(bodybillingMethod);
                    bodypropCount++;
                }

                if (bodyteamId != null)
                {
                    body["teamId"] = SourceExpressionConverter.ConvertToken(bodyteamId);
                    bodypropCount++;
                }

                if (bodyquoteAmount != null)
                {
                    body["quoteAmount"] = SourceExpressionConverter.ConvertToken(bodyquoteAmount);
                    bodypropCount++;
                }

                if (bodystatusId != null)
                {
                    body["statusId"] = SourceExpressionConverter.ConvertToken(bodystatusId);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["customFields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodyenumJobCategoryTypes != null)
                {
                    body["enumJobCategoryTypes"] = SourceExpressionConverter.Convert(bodyenumJobCategoryTypes);
                    bodypropCount++;
                }

                if (bodyenumEstimateTypes != null)
                {
                    body["enumEstimateTypes"] = SourceExpressionConverter.Convert(bodyenumEstimateTypes);
                    bodypropCount++;
                }

                if (bodyenumBillingMethods != null)
                {
                    body["enumBillingMethods"] = SourceExpressionConverter.Convert(bodyenumBillingMethods);
                    bodypropCount++;
                }

                if (bodyenumPriorityTypes != null)
                {
                    body["enumPriorityTypes"] = SourceExpressionConverter.Convert(bodyenumPriorityTypes);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobType> GetJobTypes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/workflows/types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JobType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobTemplate> GetJobTemplates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/workflows/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JobTemplate>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobPriorityValues> GetJobPriorities()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/workflows/priorities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JobPriorityValues>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<JobTypeStatus> GetJobTypeStatus()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/workflows/jobtypestatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JobTypeStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kc")]
        public IBodyWorkflowAction<GetClientGroupsResponse> GetClientGroups([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> groupCode = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(groupCode, nameof(groupCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/clients/clientgroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (groupCode != null)
                    callPayload.Queries["groupCode"] = SourceExpressionConverter.ConvertO(groupCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetClientGroupsResponse>(BuildSourceInput);
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

    public enum bodyenumTrustTypesInput
    {
        [EnumMember(Value = "discretionary")]
        Discretionary,
        [EnumMember(Value = "hybrid")]
        Hybrid,
        [EnumMember(Value = "unit")]
        Unit
    }

    public enum bodyenumGenderInput
    {
        [EnumMember(Value = "male")]
        Male,
        [EnumMember(Value = "female")]
        Female
    }

    public enum bodyenumEmailTypesInput
    {
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "work")]
        Work
    }

    public enum bodyenumPhoneTypesInput
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "mobile")]
        Mobile
    }

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
        public string LinkedInProfileID { get; set; }

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

    public enum bodyenumEstimateTypesInput
    {
        Job,
        [EnumMember(Value = "Task")]
        TaskObject
    }

    public enum bodyenumBillingMethodsInput
    {
        TimeCost,
        Fixed
    }

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