//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Capsulecrm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CapsulecrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListOpportunitiesResponse> ListOpportunities()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListOpportunitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateOpportunityResponse> CreateOpportunity([WorkflowExpression] Func<int> bodyopportunitypartypartyId, [WorkflowExpression] Func<int> bodyopportunitymilestoneid, [WorkflowExpression] Func<string> bodyopportunityname = null, [WorkflowExpression] Func<string> bodyopportunitydescription = null, [WorkflowExpression] Func<bodyopportunitydurationBasisInput> bodyopportunitydurationBasis = null, [WorkflowExpression] Func<string> bodyopportunityduration = null, [WorkflowExpression] Func<string> bodyopportunityexpectedCloseDate = null, [WorkflowExpression] Func<int> bodyopportunitywinningProbability = null, [WorkflowExpression] Func<int> bodyopportunityexpectedamount = null, [WorkflowExpression] Func<string> bodyopportunityexpectedcurrency = null)
        {
            SourceExpression.Validate(bodyopportunitypartypartyId, nameof(bodyopportunitypartypartyId), required: true);
            SourceExpression.Validate(bodyopportunitymilestoneid, nameof(bodyopportunitymilestoneid), required: true);
            SourceExpression.Validate(bodyopportunityname, nameof(bodyopportunityname), required: false);
            SourceExpression.Validate(bodyopportunitydescription, nameof(bodyopportunitydescription), required: false);
            SourceExpression.Validate(bodyopportunitydurationBasis, nameof(bodyopportunitydurationBasis), required: false);
            SourceExpression.Validate(bodyopportunityduration, nameof(bodyopportunityduration), required: false);
            SourceExpression.Validate(bodyopportunityexpectedCloseDate, nameof(bodyopportunityexpectedCloseDate), required: false);
            SourceExpression.Validate(bodyopportunitywinningProbability, nameof(bodyopportunitywinningProbability), required: false);
            SourceExpression.Validate(bodyopportunityexpectedamount, nameof(bodyopportunityexpectedamount), required: false);
            SourceExpression.Validate(bodyopportunityexpectedcurrency, nameof(bodyopportunityexpectedcurrency), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/opportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var opportunityObject = new JObject();
                var opportunityObjectpropCount = 0;
                if (bodyopportunityname != null)
                {
                    opportunityObject["name"] = SourceExpressionConverter.ConvertToken(bodyopportunityname);
                    opportunityObjectpropCount++;
                }

                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                partyObjectpropCount++;
                partyObject["id"] = SourceExpressionConverter.ConvertToken(bodyopportunitypartypartyId);
                if (partyObjectpropCount > 0)
                {
                    opportunityObject["party"] = partyObject;
                    opportunityObjectpropCount++;
                }

                var milestoneObject = new JObject();
                var milestoneObjectpropCount = 0;
                milestoneObjectpropCount++;
                milestoneObject["id"] = SourceExpressionConverter.ConvertToken(bodyopportunitymilestoneid);
                if (milestoneObjectpropCount > 0)
                {
                    opportunityObject["milestone"] = milestoneObject;
                    opportunityObjectpropCount++;
                }

                if (bodyopportunitydescription != null)
                {
                    opportunityObject["description"] = SourceExpressionConverter.ConvertToken(bodyopportunitydescription);
                    opportunityObjectpropCount++;
                }

                if (bodyopportunitydurationBasis != null)
                {
                    opportunityObject["durationBasis"] = SourceExpressionConverter.Convert(bodyopportunitydurationBasis);
                    opportunityObjectpropCount++;
                }

                if (bodyopportunityduration != null)
                {
                    opportunityObject["duration"] = SourceExpressionConverter.ConvertToken(bodyopportunityduration);
                    opportunityObjectpropCount++;
                }

                if (bodyopportunityexpectedCloseDate != null)
                {
                    opportunityObject["expectedCloseOn"] = SourceExpressionConverter.ConvertToken(bodyopportunityexpectedCloseDate);
                    opportunityObjectpropCount++;
                }

                if (bodyopportunitywinningProbability != null)
                {
                    opportunityObject["probability"] = SourceExpressionConverter.ConvertToken(bodyopportunitywinningProbability);
                    opportunityObjectpropCount++;
                }

                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (bodyopportunityexpectedamount != null)
                {
                    valueObject["amount"] = SourceExpressionConverter.ConvertToken(bodyopportunityexpectedamount);
                    valueObjectpropCount++;
                }

                if (bodyopportunityexpectedcurrency != null)
                {
                    valueObject["currency"] = SourceExpressionConverter.ConvertToken(bodyopportunityexpectedcurrency);
                    valueObjectpropCount++;
                }

                if (valueObjectpropCount > 0)
                {
                    opportunityObject["value"] = valueObject;
                    opportunityObjectpropCount++;
                }

                if (opportunityObjectpropCount > 0)
                {
                    body["opportunity"] = opportunityObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateOpportunityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<GetOpportunityResponse> GetOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetOpportunityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdateOpportunityResponse> UpdateOpportunity([WorkflowExpression] Func<string> opportunityId, [WorkflowExpression] Func<int> bodyopportunitypartypartyId, [WorkflowExpression] Func<int> bodyopportunitymilestonemilestoneId, [WorkflowExpression] Func<string> bodyopportunityname = null, [WorkflowExpression] Func<string> bodyopportunitydescription = null, [WorkflowExpression] Func<bodyopportunitydurationBasisInput> bodyopportunitydurationBasis = null, [WorkflowExpression] Func<string> bodyopportunityduration = null, [WorkflowExpression] Func<string> bodyopportunityexpectedCloseDate = null, [WorkflowExpression] Func<int> bodyopportunitywinningProbability = null, [WorkflowExpression] Func<int> bodyopportunityexpectedamount = null, [WorkflowExpression] Func<string> bodyopportunityexpectedcurrency = null)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            SourceExpression.Validate(bodyopportunitypartypartyId, nameof(bodyopportunitypartypartyId), required: true);
            SourceExpression.Validate(bodyopportunitymilestonemilestoneId, nameof(bodyopportunitymilestonemilestoneId), required: true);
            SourceExpression.Validate(bodyopportunityname, nameof(bodyopportunityname), required: false);
            SourceExpression.Validate(bodyopportunitydescription, nameof(bodyopportunitydescription), required: false);
            SourceExpression.Validate(bodyopportunitydurationBasis, nameof(bodyopportunitydurationBasis), required: false);
            SourceExpression.Validate(bodyopportunityduration, nameof(bodyopportunityduration), required: false);
            SourceExpression.Validate(bodyopportunityexpectedCloseDate, nameof(bodyopportunityexpectedCloseDate), required: false);
            SourceExpression.Validate(bodyopportunitywinningProbability, nameof(bodyopportunitywinningProbability), required: false);
            SourceExpression.Validate(bodyopportunityexpectedamount, nameof(bodyopportunityexpectedamount), required: false);
            SourceExpression.Validate(bodyopportunityexpectedcurrency, nameof(bodyopportunityexpectedcurrency), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var opportunityObject = new JObject();
                var opportunityObjectpropCount = 0;
                if (bodyopportunityname != null)
                {
                    opportunityObject["name"] = SourceExpressionConverter.ConvertToken(bodyopportunityname);
                    opportunityObjectpropCount++;
                }

                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                partyObjectpropCount++;
                partyObject["id"] = SourceExpressionConverter.ConvertToken(bodyopportunitypartypartyId);
                if (partyObjectpropCount > 0)
                {
                    opportunityObject["party"] = partyObject;
                    opportunityObjectpropCount++;
                }

                var milestoneObject = new JObject();
                var milestoneObjectpropCount = 0;
                milestoneObjectpropCount++;
                milestoneObject["id"] = SourceExpressionConverter.ConvertToken(bodyopportunitymilestonemilestoneId);
                if (milestoneObjectpropCount > 0)
                {
                    opportunityObject["milestone"] = milestoneObject;
                    opportunityObjectpropCount++;
                }

                if (bodyopportunitydescription != null)
                {
                    opportunityObject["description"] = SourceExpressionConverter.ConvertToken(bodyopportunitydescription);
                    opportunityObjectpropCount++;
                }

                if (bodyopportunitydurationBasis != null)
                {
                    opportunityObject["durationBasis"] = SourceExpressionConverter.Convert(bodyopportunitydurationBasis);
                    opportunityObjectpropCount++;
                }

                if (bodyopportunityduration != null)
                {
                    opportunityObject["duration"] = SourceExpressionConverter.ConvertToken(bodyopportunityduration);
                    opportunityObjectpropCount++;
                }

                if (bodyopportunityexpectedCloseDate != null)
                {
                    opportunityObject["expectedCloseOn"] = SourceExpressionConverter.ConvertToken(bodyopportunityexpectedCloseDate);
                    opportunityObjectpropCount++;
                }

                if (bodyopportunitywinningProbability != null)
                {
                    opportunityObject["probability"] = SourceExpressionConverter.ConvertToken(bodyopportunitywinningProbability);
                    opportunityObjectpropCount++;
                }

                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (bodyopportunityexpectedamount != null)
                {
                    valueObject["amount"] = SourceExpressionConverter.ConvertToken(bodyopportunityexpectedamount);
                    valueObjectpropCount++;
                }

                if (bodyopportunityexpectedcurrency != null)
                {
                    valueObject["currency"] = SourceExpressionConverter.ConvertToken(bodyopportunityexpectedcurrency);
                    valueObjectpropCount++;
                }

                if (valueObjectpropCount > 0)
                {
                    opportunityObject["value"] = valueObject;
                    opportunityObjectpropCount++;
                }

                if (opportunityObjectpropCount > 0)
                {
                    body["opportunity"] = opportunityObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateOpportunityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<string> DeleteOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            SourceExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson([WorkflowExpression] Func<string> bodypartylastName = null, [WorkflowExpression] Func<string> bodypartyfirstName = null, [WorkflowExpression] Func<bodypartytitleInput> bodypartytitle = null, [WorkflowExpression] Func<string> bodypartyjobTitle = null, [WorkflowExpression] Func<string> bodypartyabout = null, [WorkflowExpression] Func<string> bodypartyorganisationId = null, [WorkflowExpression] Func<string> bodypartyphoneNumbersphoneNumber = null, [WorkflowExpression] Func<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, [WorkflowExpression] Func<string> bodypartyemailAddressesemailAddress = null, [WorkflowExpression] Func<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, [WorkflowExpression] Func<string> bodypartywebsiteswebsiteAddress = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressStreet = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCity = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressState = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressZip = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCountry = null, [WorkflowExpression] Func<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, [WorkflowExpression] Func<string> bodypartytags = null)
        {
            SourceExpression.Validate(bodypartylastName, nameof(bodypartylastName), required: false);
            SourceExpression.Validate(bodypartyfirstName, nameof(bodypartyfirstName), required: false);
            SourceExpression.Validate(bodypartytitle, nameof(bodypartytitle), required: false);
            SourceExpression.Validate(bodypartyjobTitle, nameof(bodypartyjobTitle), required: false);
            SourceExpression.Validate(bodypartyabout, nameof(bodypartyabout), required: false);
            SourceExpression.Validate(bodypartyorganisationId, nameof(bodypartyorganisationId), required: false);
            SourceExpression.Validate(bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            SourceExpression.Validate(bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            SourceExpression.Validate(bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            SourceExpression.Validate(bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            SourceExpression.Validate(bodypartytags, nameof(bodypartytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/person/parties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (bodypartylastName != null)
                {
                    partyObject["lastName"] = SourceExpressionConverter.ConvertToken(bodypartylastName);
                    partyObjectpropCount++;
                }

                if (bodypartyfirstName != null)
                {
                    partyObject["firstName"] = SourceExpressionConverter.ConvertToken(bodypartyfirstName);
                    partyObjectpropCount++;
                }

                if (bodypartytitle != null)
                {
                    partyObject["title"] = SourceExpressionConverter.Convert(bodypartytitle);
                    partyObjectpropCount++;
                }

                if (bodypartyjobTitle != null)
                {
                    partyObject["jobTitle"] = SourceExpressionConverter.ConvertToken(bodypartyjobTitle);
                    partyObjectpropCount++;
                }

                if (bodypartyabout != null)
                {
                    partyObject["about"] = SourceExpressionConverter.ConvertToken(bodypartyabout);
                    partyObjectpropCount++;
                }

                if (bodypartyorganisationId != null)
                {
                    partyObject["organisation"] = SourceExpressionConverter.ConvertToken(bodypartyorganisationId);
                    partyObjectpropCount++;
                }

                var phoneNumbersObject = new JObject();
                var phoneNumbersObjectpropCount = 0;
                if (bodypartyphoneNumbersphoneNumber != null)
                {
                    phoneNumbersObject["number"] = SourceExpressionConverter.ConvertToken(bodypartyphoneNumbersphoneNumber);
                    phoneNumbersObjectpropCount++;
                }

                if (bodypartyphoneNumbersphoneType != null)
                {
                    phoneNumbersObject["type"] = SourceExpressionConverter.Convert(bodypartyphoneNumbersphoneType);
                    phoneNumbersObjectpropCount++;
                }

                if (phoneNumbersObjectpropCount > 0)
                {
                    partyObject["phoneNumbers"] = phoneNumbersObject;
                    partyObjectpropCount++;
                }

                var emailAddressesObject = new JObject();
                var emailAddressesObjectpropCount = 0;
                if (bodypartyemailAddressesemailAddress != null)
                {
                    emailAddressesObject["address"] = SourceExpressionConverter.ConvertToken(bodypartyemailAddressesemailAddress);
                    emailAddressesObjectpropCount++;
                }

                if (bodypartyemailAddressesemailType != null)
                {
                    emailAddressesObject["type"] = SourceExpressionConverter.Convert(bodypartyemailAddressesemailType);
                    emailAddressesObjectpropCount++;
                }

                if (emailAddressesObjectpropCount > 0)
                {
                    partyObject["emailAddresses"] = emailAddressesObject;
                    partyObjectpropCount++;
                }

                var websitesObject = new JObject();
                var websitesObjectpropCount = 0;
                if (bodypartywebsiteswebsiteAddress != null)
                {
                    websitesObject["address"] = SourceExpressionConverter.ConvertToken(bodypartywebsiteswebsiteAddress);
                    websitesObjectpropCount++;
                }

                if (bodypartywebsiteswebsiteService != null)
                {
                    websitesObject["service"] = SourceExpressionConverter.Convert(bodypartywebsiteswebsiteService);
                    websitesObjectpropCount++;
                }

                if (bodypartywebsiteswebsiteType != null)
                {
                    websitesObject["type"] = SourceExpressionConverter.Convert(bodypartywebsiteswebsiteType);
                    websitesObjectpropCount++;
                }

                if (websitesObjectpropCount > 0)
                {
                    partyObject["websites"] = websitesObject;
                    partyObjectpropCount++;
                }

                var addressesObject = new JObject();
                var addressesObjectpropCount = 0;
                if (bodypartyaddressesaddressStreet != null)
                {
                    addressesObject["street"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressStreet);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressCity != null)
                {
                    addressesObject["city"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressCity);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressState != null)
                {
                    addressesObject["state"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressState);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressZip != null)
                {
                    addressesObject["zip"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressZip);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressCountry != null)
                {
                    addressesObject["country"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressCountry);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressType != null)
                {
                    addressesObject["type"] = SourceExpressionConverter.Convert(bodypartyaddressesaddressType);
                    addressesObjectpropCount++;
                }

                if (addressesObjectpropCount > 0)
                {
                    partyObject["addresses"] = addressesObject;
                    partyObjectpropCount++;
                }

                if (bodypartytags != null)
                {
                    partyObject["tags"] = SourceExpressionConverter.ConvertToken(bodypartytags);
                    partyObjectpropCount++;
                }

                partyObject["type"] = "person";
                partyObjectpropCount++;
                if (partyObjectpropCount > 0)
                {
                    body["party"] = partyObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreatePersonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdatePersonResponse> UpdatePerson([WorkflowExpression] Func<string> personId, [WorkflowExpression] Func<string> bodypartylastName = null, [WorkflowExpression] Func<string> bodypartyfirstName = null, [WorkflowExpression] Func<bodypartytitleInput> bodypartytitle = null, [WorkflowExpression] Func<string> bodypartyjobTitle = null, [WorkflowExpression] Func<string> bodypartyabout = null, [WorkflowExpression] Func<string> bodypartyorganisationId = null, [WorkflowExpression] Func<string> bodypartyphoneNumbersphoneNumber = null, [WorkflowExpression] Func<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, [WorkflowExpression] Func<string> bodypartyemailAddressesemailAddress = null, [WorkflowExpression] Func<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, [WorkflowExpression] Func<string> bodypartywebsiteswebsiteAddress = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressStreet = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCity = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressState = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressZip = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCountry = null, [WorkflowExpression] Func<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, [WorkflowExpression] Func<string> bodypartytags = null)
        {
            SourceExpression.Validate(personId, nameof(personId), required: true);
            SourceExpression.Validate(bodypartylastName, nameof(bodypartylastName), required: false);
            SourceExpression.Validate(bodypartyfirstName, nameof(bodypartyfirstName), required: false);
            SourceExpression.Validate(bodypartytitle, nameof(bodypartytitle), required: false);
            SourceExpression.Validate(bodypartyjobTitle, nameof(bodypartyjobTitle), required: false);
            SourceExpression.Validate(bodypartyabout, nameof(bodypartyabout), required: false);
            SourceExpression.Validate(bodypartyorganisationId, nameof(bodypartyorganisationId), required: false);
            SourceExpression.Validate(bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            SourceExpression.Validate(bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            SourceExpression.Validate(bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            SourceExpression.Validate(bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            SourceExpression.Validate(bodypartytags, nameof(bodypartytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/person/parties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(personId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (bodypartylastName != null)
                {
                    partyObject["lastName"] = SourceExpressionConverter.ConvertToken(bodypartylastName);
                    partyObjectpropCount++;
                }

                if (bodypartyfirstName != null)
                {
                    partyObject["firstName"] = SourceExpressionConverter.ConvertToken(bodypartyfirstName);
                    partyObjectpropCount++;
                }

                if (bodypartytitle != null)
                {
                    partyObject["title"] = SourceExpressionConverter.Convert(bodypartytitle);
                    partyObjectpropCount++;
                }

                if (bodypartyjobTitle != null)
                {
                    partyObject["jobTitle"] = SourceExpressionConverter.ConvertToken(bodypartyjobTitle);
                    partyObjectpropCount++;
                }

                if (bodypartyabout != null)
                {
                    partyObject["about"] = SourceExpressionConverter.ConvertToken(bodypartyabout);
                    partyObjectpropCount++;
                }

                if (bodypartyorganisationId != null)
                {
                    partyObject["organisation"] = SourceExpressionConverter.ConvertToken(bodypartyorganisationId);
                    partyObjectpropCount++;
                }

                var phoneNumbersObject = new JObject();
                var phoneNumbersObjectpropCount = 0;
                if (bodypartyphoneNumbersphoneNumber != null)
                {
                    phoneNumbersObject["number"] = SourceExpressionConverter.ConvertToken(bodypartyphoneNumbersphoneNumber);
                    phoneNumbersObjectpropCount++;
                }

                if (bodypartyphoneNumbersphoneType != null)
                {
                    phoneNumbersObject["type"] = SourceExpressionConverter.Convert(bodypartyphoneNumbersphoneType);
                    phoneNumbersObjectpropCount++;
                }

                if (phoneNumbersObjectpropCount > 0)
                {
                    partyObject["phoneNumbers"] = phoneNumbersObject;
                    partyObjectpropCount++;
                }

                var emailAddressesObject = new JObject();
                var emailAddressesObjectpropCount = 0;
                if (bodypartyemailAddressesemailAddress != null)
                {
                    emailAddressesObject["address"] = SourceExpressionConverter.ConvertToken(bodypartyemailAddressesemailAddress);
                    emailAddressesObjectpropCount++;
                }

                if (bodypartyemailAddressesemailType != null)
                {
                    emailAddressesObject["type"] = SourceExpressionConverter.Convert(bodypartyemailAddressesemailType);
                    emailAddressesObjectpropCount++;
                }

                if (emailAddressesObjectpropCount > 0)
                {
                    partyObject["emailAddresses"] = emailAddressesObject;
                    partyObjectpropCount++;
                }

                var websitesObject = new JObject();
                var websitesObjectpropCount = 0;
                if (bodypartywebsiteswebsiteAddress != null)
                {
                    websitesObject["address"] = SourceExpressionConverter.ConvertToken(bodypartywebsiteswebsiteAddress);
                    websitesObjectpropCount++;
                }

                if (bodypartywebsiteswebsiteService != null)
                {
                    websitesObject["service"] = SourceExpressionConverter.Convert(bodypartywebsiteswebsiteService);
                    websitesObjectpropCount++;
                }

                if (bodypartywebsiteswebsiteType != null)
                {
                    websitesObject["type"] = SourceExpressionConverter.Convert(bodypartywebsiteswebsiteType);
                    websitesObjectpropCount++;
                }

                if (websitesObjectpropCount > 0)
                {
                    partyObject["websites"] = websitesObject;
                    partyObjectpropCount++;
                }

                var addressesObject = new JObject();
                var addressesObjectpropCount = 0;
                if (bodypartyaddressesaddressStreet != null)
                {
                    addressesObject["street"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressStreet);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressCity != null)
                {
                    addressesObject["city"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressCity);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressState != null)
                {
                    addressesObject["state"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressState);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressZip != null)
                {
                    addressesObject["zip"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressZip);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressCountry != null)
                {
                    addressesObject["country"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressCountry);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressType != null)
                {
                    addressesObject["type"] = SourceExpressionConverter.Convert(bodypartyaddressesaddressType);
                    addressesObjectpropCount++;
                }

                if (addressesObjectpropCount > 0)
                {
                    partyObject["addresses"] = addressesObject;
                    partyObjectpropCount++;
                }

                if (bodypartytags != null)
                {
                    partyObject["tags"] = SourceExpressionConverter.ConvertToken(bodypartytags);
                    partyObjectpropCount++;
                }

                partyObject["type"] = "person";
                partyObjectpropCount++;
                if (partyObjectpropCount > 0)
                {
                    body["party"] = partyObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdatePersonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateOrganisationResponse> CreateOrganisation([WorkflowExpression] Func<string> bodypartyname = null, [WorkflowExpression] Func<string> bodypartyabout = null, [WorkflowExpression] Func<string> bodypartyphoneNumbersphoneNumber = null, [WorkflowExpression] Func<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, [WorkflowExpression] Func<string> bodypartyemailAddressesemailAddress = null, [WorkflowExpression] Func<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, [WorkflowExpression] Func<string> bodypartywebsiteswebsiteAddress = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressStreet = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCity = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressState = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressZip = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCountry = null, [WorkflowExpression] Func<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, [WorkflowExpression] Func<string> bodypartytags = null)
        {
            SourceExpression.Validate(bodypartyname, nameof(bodypartyname), required: false);
            SourceExpression.Validate(bodypartyabout, nameof(bodypartyabout), required: false);
            SourceExpression.Validate(bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            SourceExpression.Validate(bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            SourceExpression.Validate(bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            SourceExpression.Validate(bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            SourceExpression.Validate(bodypartytags, nameof(bodypartytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/organisation/parties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (bodypartyname != null)
                {
                    partyObject["name"] = SourceExpressionConverter.ConvertToken(bodypartyname);
                    partyObjectpropCount++;
                }

                if (bodypartyabout != null)
                {
                    partyObject["about"] = SourceExpressionConverter.ConvertToken(bodypartyabout);
                    partyObjectpropCount++;
                }

                var phoneNumbersObject = new JObject();
                var phoneNumbersObjectpropCount = 0;
                if (bodypartyphoneNumbersphoneNumber != null)
                {
                    phoneNumbersObject["number"] = SourceExpressionConverter.ConvertToken(bodypartyphoneNumbersphoneNumber);
                    phoneNumbersObjectpropCount++;
                }

                if (bodypartyphoneNumbersphoneType != null)
                {
                    phoneNumbersObject["type"] = SourceExpressionConverter.Convert(bodypartyphoneNumbersphoneType);
                    phoneNumbersObjectpropCount++;
                }

                if (phoneNumbersObjectpropCount > 0)
                {
                    partyObject["phoneNumbers"] = phoneNumbersObject;
                    partyObjectpropCount++;
                }

                var emailAddressesObject = new JObject();
                var emailAddressesObjectpropCount = 0;
                if (bodypartyemailAddressesemailAddress != null)
                {
                    emailAddressesObject["address"] = SourceExpressionConverter.ConvertToken(bodypartyemailAddressesemailAddress);
                    emailAddressesObjectpropCount++;
                }

                if (bodypartyemailAddressesemailType != null)
                {
                    emailAddressesObject["type"] = SourceExpressionConverter.Convert(bodypartyemailAddressesemailType);
                    emailAddressesObjectpropCount++;
                }

                if (emailAddressesObjectpropCount > 0)
                {
                    partyObject["emailAddresses"] = emailAddressesObject;
                    partyObjectpropCount++;
                }

                var websitesObject = new JObject();
                var websitesObjectpropCount = 0;
                if (bodypartywebsiteswebsiteAddress != null)
                {
                    websitesObject["address"] = SourceExpressionConverter.ConvertToken(bodypartywebsiteswebsiteAddress);
                    websitesObjectpropCount++;
                }

                if (bodypartywebsiteswebsiteService != null)
                {
                    websitesObject["service"] = SourceExpressionConverter.Convert(bodypartywebsiteswebsiteService);
                    websitesObjectpropCount++;
                }

                if (bodypartywebsiteswebsiteType != null)
                {
                    websitesObject["type"] = SourceExpressionConverter.Convert(bodypartywebsiteswebsiteType);
                    websitesObjectpropCount++;
                }

                if (websitesObjectpropCount > 0)
                {
                    partyObject["websites"] = websitesObject;
                    partyObjectpropCount++;
                }

                var addressesObject = new JObject();
                var addressesObjectpropCount = 0;
                if (bodypartyaddressesaddressStreet != null)
                {
                    addressesObject["street"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressStreet);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressCity != null)
                {
                    addressesObject["city"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressCity);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressState != null)
                {
                    addressesObject["state"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressState);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressZip != null)
                {
                    addressesObject["zip"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressZip);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressCountry != null)
                {
                    addressesObject["country"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressCountry);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressType != null)
                {
                    addressesObject["type"] = SourceExpressionConverter.Convert(bodypartyaddressesaddressType);
                    addressesObjectpropCount++;
                }

                if (addressesObjectpropCount > 0)
                {
                    partyObject["addresses"] = addressesObject;
                    partyObjectpropCount++;
                }

                if (bodypartytags != null)
                {
                    partyObject["tags"] = SourceExpressionConverter.ConvertToken(bodypartytags);
                    partyObjectpropCount++;
                }

                partyObject["type"] = "organisation";
                partyObjectpropCount++;
                if (partyObjectpropCount > 0)
                {
                    body["party"] = partyObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateOrganisationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdateOrganisationResponse> UpdateOrganisation([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodypartyname = null, [WorkflowExpression] Func<string> bodypartyabout = null, [WorkflowExpression] Func<string> bodypartyphoneNumbersphoneNumber = null, [WorkflowExpression] Func<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, [WorkflowExpression] Func<string> bodypartyemailAddressesemailAddress = null, [WorkflowExpression] Func<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, [WorkflowExpression] Func<string> bodypartywebsiteswebsiteAddress = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressStreet = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCity = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressState = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressZip = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCountry = null, [WorkflowExpression] Func<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, [WorkflowExpression] Func<string> bodypartytags = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodypartyname, nameof(bodypartyname), required: false);
            SourceExpression.Validate(bodypartyabout, nameof(bodypartyabout), required: false);
            SourceExpression.Validate(bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            SourceExpression.Validate(bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            SourceExpression.Validate(bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            SourceExpression.Validate(bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            SourceExpression.Validate(bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            SourceExpression.Validate(bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            SourceExpression.Validate(bodypartytags, nameof(bodypartytags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organisation/parties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (bodypartyname != null)
                {
                    partyObject["name"] = SourceExpressionConverter.ConvertToken(bodypartyname);
                    partyObjectpropCount++;
                }

                if (bodypartyabout != null)
                {
                    partyObject["about"] = SourceExpressionConverter.ConvertToken(bodypartyabout);
                    partyObjectpropCount++;
                }

                var phoneNumbersObject = new JObject();
                var phoneNumbersObjectpropCount = 0;
                if (bodypartyphoneNumbersphoneNumber != null)
                {
                    phoneNumbersObject["number"] = SourceExpressionConverter.ConvertToken(bodypartyphoneNumbersphoneNumber);
                    phoneNumbersObjectpropCount++;
                }

                if (bodypartyphoneNumbersphoneType != null)
                {
                    phoneNumbersObject["type"] = SourceExpressionConverter.Convert(bodypartyphoneNumbersphoneType);
                    phoneNumbersObjectpropCount++;
                }

                if (phoneNumbersObjectpropCount > 0)
                {
                    partyObject["phoneNumbers"] = phoneNumbersObject;
                    partyObjectpropCount++;
                }

                var emailAddressesObject = new JObject();
                var emailAddressesObjectpropCount = 0;
                if (bodypartyemailAddressesemailAddress != null)
                {
                    emailAddressesObject["address"] = SourceExpressionConverter.ConvertToken(bodypartyemailAddressesemailAddress);
                    emailAddressesObjectpropCount++;
                }

                if (bodypartyemailAddressesemailType != null)
                {
                    emailAddressesObject["type"] = SourceExpressionConverter.Convert(bodypartyemailAddressesemailType);
                    emailAddressesObjectpropCount++;
                }

                if (emailAddressesObjectpropCount > 0)
                {
                    partyObject["emailAddresses"] = emailAddressesObject;
                    partyObjectpropCount++;
                }

                var websitesObject = new JObject();
                var websitesObjectpropCount = 0;
                if (bodypartywebsiteswebsiteAddress != null)
                {
                    websitesObject["address"] = SourceExpressionConverter.ConvertToken(bodypartywebsiteswebsiteAddress);
                    websitesObjectpropCount++;
                }

                if (bodypartywebsiteswebsiteService != null)
                {
                    websitesObject["service"] = SourceExpressionConverter.Convert(bodypartywebsiteswebsiteService);
                    websitesObjectpropCount++;
                }

                if (bodypartywebsiteswebsiteType != null)
                {
                    websitesObject["type"] = SourceExpressionConverter.Convert(bodypartywebsiteswebsiteType);
                    websitesObjectpropCount++;
                }

                if (websitesObjectpropCount > 0)
                {
                    partyObject["websites"] = websitesObject;
                    partyObjectpropCount++;
                }

                var addressesObject = new JObject();
                var addressesObjectpropCount = 0;
                if (bodypartyaddressesaddressStreet != null)
                {
                    addressesObject["street"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressStreet);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressCity != null)
                {
                    addressesObject["city"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressCity);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressState != null)
                {
                    addressesObject["state"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressState);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressZip != null)
                {
                    addressesObject["zip"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressZip);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressCountry != null)
                {
                    addressesObject["country"] = SourceExpressionConverter.ConvertToken(bodypartyaddressesaddressCountry);
                    addressesObjectpropCount++;
                }

                if (bodypartyaddressesaddressType != null)
                {
                    addressesObject["type"] = SourceExpressionConverter.Convert(bodypartyaddressesaddressType);
                    addressesObjectpropCount++;
                }

                if (addressesObjectpropCount > 0)
                {
                    partyObject["addresses"] = addressesObject;
                    partyObjectpropCount++;
                }

                if (bodypartytags != null)
                {
                    partyObject["tags"] = SourceExpressionConverter.ConvertToken(bodypartytags);
                    partyObjectpropCount++;
                }

                partyObject["type"] = "organisation";
                partyObjectpropCount++;
                if (partyObjectpropCount > 0)
                {
                    body["party"] = partyObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateOrganisationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponse> ListParties()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/parties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListpartiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponse> ListPeople()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/people/parties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListpartiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponse> ListOrganizations()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/organisations/parties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListpartiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<GetPartyResponse> GetParty([WorkflowExpression] Func<string> personId)
        {
            SourceExpression.Validate(personId, nameof(personId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/parties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(personId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPartyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<string> DeleteParty([WorkflowExpression] Func<string> personId)
        {
            SourceExpression.Validate(personId, nameof(personId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/parties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(personId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListTasksResponse> ListTasks()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> bodytaskdescription = null, [WorkflowExpression] Func<string> bodytaskdueDate = null, [WorkflowExpression] Func<string> bodytaskdueTime = null, [WorkflowExpression] Func<string> bodytaskdetails = null, [WorkflowExpression] Func<int> bodytaskpartyid = null)
        {
            SourceExpression.Validate(bodytaskdescription, nameof(bodytaskdescription), required: false);
            SourceExpression.Validate(bodytaskdueDate, nameof(bodytaskdueDate), required: false);
            SourceExpression.Validate(bodytaskdueTime, nameof(bodytaskdueTime), required: false);
            SourceExpression.Validate(bodytaskdetails, nameof(bodytaskdetails), required: false);
            SourceExpression.Validate(bodytaskpartyid, nameof(bodytaskpartyid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (bodytaskdescription != null)
                {
                    taskObject["description"] = SourceExpressionConverter.ConvertToken(bodytaskdescription);
                    taskObjectpropCount++;
                }

                if (bodytaskdueDate != null)
                {
                    taskObject["dueOn"] = SourceExpressionConverter.ConvertToken(bodytaskdueDate);
                    taskObjectpropCount++;
                }

                if (bodytaskdueTime != null)
                {
                    taskObject["dueTime"] = SourceExpressionConverter.ConvertToken(bodytaskdueTime);
                    taskObjectpropCount++;
                }

                if (bodytaskdetails != null)
                {
                    taskObject["detail"] = SourceExpressionConverter.ConvertToken(bodytaskdetails);
                    taskObjectpropCount++;
                }

                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (bodytaskpartyid != null)
                {
                    partyObject["id"] = SourceExpressionConverter.ConvertToken(bodytaskpartyid);
                    partyObjectpropCount++;
                }

                if (partyObjectpropCount > 0)
                {
                    taskObject["party"] = partyObject;
                    taskObjectpropCount++;
                }

                if (taskObjectpropCount > 0)
                {
                    body["task"] = taskObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CompleteTaskResponse> CompleteTask([WorkflowExpression] Func<string> taskId)
        {
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                taskObject["status"] = "completed";
                taskObjectpropCount++;
                if (taskObjectpropCount > 0)
                {
                    body["task"] = taskObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CompleteTaskResponse>(BuildSourceInput);
        }
    }

    public class CapsulecrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OpportunityResponse[]> OnNewOpportunity(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create_trigger/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OpportunityResponse[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OpportunityResponse[]> OnUpdateOpportunity(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/update_trigger/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<OpportunityResponse[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TaskResponse[]> OnNewTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TaskResponse[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PartyResponse[]> OnNewParty(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create_trigger/parties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<PartyResponse[]>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class ListOpportunitiesResponse
    {
        [JsonProperty("opportunities")]
        public OpportunityResponse[] Opportunities { get; set; }
    }

    public class OpportunityResponse
    {
        [JsonProperty("closedOn")]
        public string ClosedDate { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("durationBasis")]
        public string DurationBasis { get; set; }

        [JsonProperty("expectedCloseOn")]
        public string ExpectedCloseDate { get; set; }

        [JsonProperty("id")]
        public int OpportunityId { get; set; }

        [JsonProperty("milestone")]
        public OpportunityResponseMilestoneType Milestone { get; set; }

        [JsonProperty("name")]
        public string OpportunityName { get; set; }

        [JsonProperty("owner")]
        public OpportunityResponseOwnerType Owner { get; set; }

        [JsonProperty("party")]
        public OpportunityResponsePartyType Party { get; set; }

        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("value")]
        public OpportunityResponseValueType Value { get; set; }
    }

    public class OpportunityResponseMilestoneType
    {
        [JsonProperty("id")]
        public int MilestoneId { get; set; }

        [JsonProperty("name")]
        public string MilestoneName { get; set; }
    }

    public class OpportunityResponseOwnerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class OpportunityResponsePartyType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class OpportunityResponseValueType
    {
        [JsonProperty("amount")]
        public double AmountTheOpportunityIsWorth { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CreateOpportunityResponse
    {
        [JsonProperty("opportunity")]
        public OpportunityResponse Opportunity { get; set; }
    }

    public enum bodyopportunitydurationBasisInput
    {
        FIXED,
        HOUR,
        DAY,
        MONTH,
        YEAR,
        WEEK,
        QUARTER
    }

    public class GetOpportunityResponse
    {
        [JsonProperty("opportunity")]
        public OpportunityResponse Opportunity { get; set; }
    }

    public class UpdateOpportunityResponse
    {
        [JsonProperty("opportunity")]
        public OpportunityResponse Opportunity { get; set; }
    }

    public class CreatePersonResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class PartyResponse
    {
        [JsonProperty("name")]
        public string OrganisationName { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("addresses")]
        public PartyResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("emailAddresses")]
        public PartyResponseEmailAddressesTypeItem[] EmailAddresses { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int PartyId { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("lastContactedAt")]
        public string LastContactedAt { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("phoneNumbers")]
        public PartyResponsePhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("websites")]
        public PartyResponseWebsitesTypeItem[] Websites { get; set; }
    }

    public class PartyResponseAddressesTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class PartyResponseEmailAddressesTypeItem
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }
    }

    public class PartyResponsePhoneNumbersTypeItem
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public string PhoneNumberType { get; set; }
    }

    public class PartyResponseWebsitesTypeItem
    {
        [JsonProperty("address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("service")]
        public string WebsiteService { get; set; }

        [JsonProperty("type")]
        public string WebsiteType { get; set; }
    }

    public enum bodypartytitleInput
    {
        Mr,
        Master,
        Mrs,
        Miss,
        Ms,
        Dr,
        Prof
    }

    public enum bodypartyphoneNumbersphoneTypeInput
    {
        Home,
        Work,
        Mobile,
        Fax,
        Direct
    }

    public enum bodypartyemailAddressesemailTypeInput
    {
        Home,
        Work
    }

    public enum bodypartywebsiteswebsiteServiceInput
    {
        FEED,
        FACEBOOK,
        FLICKR,
        GITHUB,
        [EnumMember(Value = "GOOGLE_PLUS")]
        GOOGLEPLUS,
        INSTAGRAM,
        [EnumMember(Value = "LINKED_IN")]
        LINKEDIN,
        PINTEREST,
        SKYPE,
        TWITTER,
        URL,
        XING,
        YOUTUBE
    }

    public enum bodypartywebsiteswebsiteTypeInput
    {
        Home,
        Work
    }

    public enum bodypartyaddressesaddressTypeInput
    {
        Home,
        Postal,
        Office
    }

    public class UpdatePersonResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class CreateOrganisationResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class UpdateOrganisationResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class ListpartiesResponse
    {
        [JsonProperty("parties")]
        public ListpartiesResponsePartiesTypeItem[] Parties { get; set; }
    }

    public class ListpartiesResponsePartiesTypeItem
    {
        [JsonProperty("name")]
        public string OrganisationName { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int PartyId { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("lastContactedAt")]
        public string LastContactedDateTime { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }
    }

    public class GetPartyResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class ListTasksResponse
    {
        [JsonProperty("tasks")]
        public TaskResponse[] Tasks { get; set; }
    }

    public class TaskResponse
    {
        [JsonProperty("category")]
        public TaskResponseCategoryType Category { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("completedBy")]
        public string CompletedBy { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("dueOn")]
        public string DueDate { get; set; }

        [JsonProperty("dueTime")]
        public string DueTime { get; set; }

        [JsonProperty("id")]
        public int TaskId { get; set; }

        [JsonProperty("owner")]
        public TaskResponseOwnerType Owner { get; set; }

        [JsonProperty("party")]
        public TaskResponsePartyType Party { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }
    }

    public class TaskResponseCategoryType
    {
        [JsonProperty("colour")]
        public string Colour { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TaskResponseOwnerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class TaskResponsePartyType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("task")]
        public TaskResponse TaskObject { get; set; }
    }

    public class CompleteTaskResponse
    {
        [JsonProperty("task")]
        public TaskResponse TaskObject { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Capsulecrm;

    public partial class WorkflowManagedActions
    {
        public CapsulecrmActions Capsulecrm(string connectionId) => new CapsulecrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CapsulecrmTriggers Capsulecrm(string connectionId) => new CapsulecrmTriggers(connectionId);
    }
}