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
            var apiCallPath = "/opportunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListOpportunitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateOpportunityResponse> CreateOpportunity(Expression<Func<int>> bodyopportunitypartypartyId, Expression<Func<int>> bodyopportunitymilestoneid, Expression<Func<string>> bodyopportunityname = null, Expression<Func<string>> bodyopportunitydescription = null, Expression<Func<bodyopportunitydurationBasisInput>> bodyopportunitydurationBasis = null, Expression<Func<string>> bodyopportunityduration = null, Expression<Func<string>> bodyopportunityexpectedCloseDate = null, Expression<Func<int>> bodyopportunitywinningProbability = null, Expression<Func<int>> bodyopportunityexpectedamount = null, Expression<Func<string>> bodyopportunityexpectedcurrency = null)
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
                opportunityObject["name"] = ExpressionConverter.ConvertO(bodyopportunityname);
                opportunityObjectpropCount++;
            }

            var partyObject = new JObject();
            var partyObjectpropCount = 0;
            partyObjectpropCount++;
            partyObject["id"] = ExpressionConverter.ConvertO(bodyopportunitypartypartyId);
            if (partyObjectpropCount > 0)
            {
                opportunityObject["party"] = partyObject;
                opportunityObjectpropCount++;
            }

            var milestoneObject = new JObject();
            var milestoneObjectpropCount = 0;
            milestoneObjectpropCount++;
            milestoneObject["id"] = ExpressionConverter.ConvertO(bodyopportunitymilestoneid);
            if (milestoneObjectpropCount > 0)
            {
                opportunityObject["milestone"] = milestoneObject;
                opportunityObjectpropCount++;
            }

            if (bodyopportunitydescription != null)
            {
                opportunityObject["description"] = ExpressionConverter.ConvertO(bodyopportunitydescription);
                opportunityObjectpropCount++;
            }

            if (bodyopportunitydurationBasis != null)
            {
                opportunityObject["durationBasis"] = ExpressionConverter.ConvertO(bodyopportunitydurationBasis);
                opportunityObjectpropCount++;
            }

            if (bodyopportunityduration != null)
            {
                opportunityObject["duration"] = ExpressionConverter.ConvertO(bodyopportunityduration);
                opportunityObjectpropCount++;
            }

            if (bodyopportunityexpectedCloseDate != null)
            {
                opportunityObject["expectedCloseOn"] = ExpressionConverter.ConvertO(bodyopportunityexpectedCloseDate);
                opportunityObjectpropCount++;
            }

            if (bodyopportunitywinningProbability != null)
            {
                opportunityObject["probability"] = ExpressionConverter.ConvertO(bodyopportunitywinningProbability);
                opportunityObjectpropCount++;
            }

            var valueObject = new JObject();
            var valueObjectpropCount = 0;
            if (bodyopportunityexpectedamount != null)
            {
                valueObject["amount"] = ExpressionConverter.ConvertO(bodyopportunityexpectedamount);
                valueObjectpropCount++;
            }

            if (bodyopportunityexpectedcurrency != null)
            {
                valueObject["currency"] = ExpressionConverter.ConvertO(bodyopportunityexpectedcurrency);
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

            return new ApiConnectionAction<CreateOpportunityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<GetOpportunityResponse> GetOpportunity(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = String.Format("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetOpportunityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdateOpportunityResponse> UpdateOpportunity(Expression<Func<string>> opportunityId, Expression<Func<int>> bodyopportunitypartypartyId, Expression<Func<int>> bodyopportunitymilestonemilestoneId, Expression<Func<string>> bodyopportunityname = null, Expression<Func<string>> bodyopportunitydescription = null, Expression<Func<bodyopportunitydurationBasisInput>> bodyopportunitydurationBasis = null, Expression<Func<string>> bodyopportunityduration = null, Expression<Func<string>> bodyopportunityexpectedCloseDate = null, Expression<Func<int>> bodyopportunitywinningProbability = null, Expression<Func<int>> bodyopportunityexpectedamount = null, Expression<Func<string>> bodyopportunityexpectedcurrency = null)
        {
            var apiCallPath = String.Format("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var opportunityObject = new JObject();
            var opportunityObjectpropCount = 0;
            if (bodyopportunityname != null)
            {
                opportunityObject["name"] = ExpressionConverter.ConvertO(bodyopportunityname);
                opportunityObjectpropCount++;
            }

            var partyObject = new JObject();
            var partyObjectpropCount = 0;
            partyObjectpropCount++;
            partyObject["id"] = ExpressionConverter.ConvertO(bodyopportunitypartypartyId);
            if (partyObjectpropCount > 0)
            {
                opportunityObject["party"] = partyObject;
                opportunityObjectpropCount++;
            }

            var milestoneObject = new JObject();
            var milestoneObjectpropCount = 0;
            milestoneObjectpropCount++;
            milestoneObject["id"] = ExpressionConverter.ConvertO(bodyopportunitymilestonemilestoneId);
            if (milestoneObjectpropCount > 0)
            {
                opportunityObject["milestone"] = milestoneObject;
                opportunityObjectpropCount++;
            }

            if (bodyopportunitydescription != null)
            {
                opportunityObject["description"] = ExpressionConverter.ConvertO(bodyopportunitydescription);
                opportunityObjectpropCount++;
            }

            if (bodyopportunitydurationBasis != null)
            {
                opportunityObject["durationBasis"] = ExpressionConverter.ConvertO(bodyopportunitydurationBasis);
                opportunityObjectpropCount++;
            }

            if (bodyopportunityduration != null)
            {
                opportunityObject["duration"] = ExpressionConverter.ConvertO(bodyopportunityduration);
                opportunityObjectpropCount++;
            }

            if (bodyopportunityexpectedCloseDate != null)
            {
                opportunityObject["expectedCloseOn"] = ExpressionConverter.ConvertO(bodyopportunityexpectedCloseDate);
                opportunityObjectpropCount++;
            }

            if (bodyopportunitywinningProbability != null)
            {
                opportunityObject["probability"] = ExpressionConverter.ConvertO(bodyopportunitywinningProbability);
                opportunityObjectpropCount++;
            }

            var valueObject = new JObject();
            var valueObjectpropCount = 0;
            if (bodyopportunityexpectedamount != null)
            {
                valueObject["amount"] = ExpressionConverter.ConvertO(bodyopportunityexpectedamount);
                valueObjectpropCount++;
            }

            if (bodyopportunityexpectedcurrency != null)
            {
                valueObject["currency"] = ExpressionConverter.ConvertO(bodyopportunityexpectedcurrency);
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

            return new ApiConnectionAction<UpdateOpportunityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<string> DeleteOpportunity(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = String.Format("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson(Expression<Func<string>> bodypartylastName = null, Expression<Func<string>> bodypartyfirstName = null, Expression<Func<bodypartytitleInput>> bodypartytitle = null, Expression<Func<string>> bodypartyjobTitle = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyorganisationId = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
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
                partyObject["lastName"] = ExpressionConverter.ConvertO(bodypartylastName);
                partyObjectpropCount++;
            }

            if (bodypartyfirstName != null)
            {
                partyObject["firstName"] = ExpressionConverter.ConvertO(bodypartyfirstName);
                partyObjectpropCount++;
            }

            if (bodypartytitle != null)
            {
                partyObject["title"] = ExpressionConverter.ConvertO(bodypartytitle);
                partyObjectpropCount++;
            }

            if (bodypartyjobTitle != null)
            {
                partyObject["jobTitle"] = ExpressionConverter.ConvertO(bodypartyjobTitle);
                partyObjectpropCount++;
            }

            if (bodypartyabout != null)
            {
                partyObject["about"] = ExpressionConverter.ConvertO(bodypartyabout);
                partyObjectpropCount++;
            }

            if (bodypartyorganisationId != null)
            {
                partyObject["organisation"] = ExpressionConverter.ConvertO(bodypartyorganisationId);
                partyObjectpropCount++;
            }

            var phoneNumbersObject = new JObject();
            var phoneNumbersObjectpropCount = 0;
            if (bodypartyphoneNumbersphoneNumber != null)
            {
                phoneNumbersObject["number"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneNumber);
                phoneNumbersObjectpropCount++;
            }

            if (bodypartyphoneNumbersphoneType != null)
            {
                phoneNumbersObject["type"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneType);
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
                emailAddressesObject["address"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailAddress);
                emailAddressesObjectpropCount++;
            }

            if (bodypartyemailAddressesemailType != null)
            {
                emailAddressesObject["type"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailType);
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
                websitesObject["address"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteAddress);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteService != null)
            {
                websitesObject["service"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteService);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteType != null)
            {
                websitesObject["type"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteType);
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
                addressesObject["street"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressStreet);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCity != null)
            {
                addressesObject["city"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCity);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressState != null)
            {
                addressesObject["state"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressState);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressZip != null)
            {
                addressesObject["zip"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressZip);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCountry != null)
            {
                addressesObject["country"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCountry);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressType != null)
            {
                addressesObject["type"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressType);
                addressesObjectpropCount++;
            }

            if (addressesObjectpropCount > 0)
            {
                partyObject["addresses"] = addressesObject;
                partyObjectpropCount++;
            }

            if (bodypartytags != null)
            {
                partyObject["tags"] = ExpressionConverter.ConvertO(bodypartytags);
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

            return new ApiConnectionAction<CreatePersonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreatePersonV2Response> CreatePersonV2(Expression<Func<int>> bodypartyorganisationid, Expression<Func<string>> bodypartylastName = null, Expression<Func<string>> bodypartyfirstName = null, Expression<Func<bodypartytitleInput>> bodypartytitle = null, Expression<Func<string>> bodypartyjobTitle = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
        {
            var apiCallPath = "/v2/person/parties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var partyObject = new JObject();
            var partyObjectpropCount = 0;
            if (bodypartylastName != null)
            {
                partyObject["lastName"] = ExpressionConverter.ConvertO(bodypartylastName);
                partyObjectpropCount++;
            }

            if (bodypartyfirstName != null)
            {
                partyObject["firstName"] = ExpressionConverter.ConvertO(bodypartyfirstName);
                partyObjectpropCount++;
            }

            if (bodypartytitle != null)
            {
                partyObject["title"] = ExpressionConverter.ConvertO(bodypartytitle);
                partyObjectpropCount++;
            }

            if (bodypartyjobTitle != null)
            {
                partyObject["jobTitle"] = ExpressionConverter.ConvertO(bodypartyjobTitle);
                partyObjectpropCount++;
            }

            if (bodypartyabout != null)
            {
                partyObject["about"] = ExpressionConverter.ConvertO(bodypartyabout);
                partyObjectpropCount++;
            }

            var organisationObject = new JObject();
            var organisationObjectpropCount = 0;
            organisationObjectpropCount++;
            organisationObject["id"] = ExpressionConverter.ConvertO(bodypartyorganisationid);
            if (organisationObjectpropCount > 0)
            {
                partyObject["organisation"] = organisationObject;
                partyObjectpropCount++;
            }

            var phoneNumbersObject = new JObject();
            var phoneNumbersObjectpropCount = 0;
            if (bodypartyphoneNumbersphoneNumber != null)
            {
                phoneNumbersObject["number"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneNumber);
                phoneNumbersObjectpropCount++;
            }

            if (bodypartyphoneNumbersphoneType != null)
            {
                phoneNumbersObject["type"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneType);
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
                emailAddressesObject["address"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailAddress);
                emailAddressesObjectpropCount++;
            }

            if (bodypartyemailAddressesemailType != null)
            {
                emailAddressesObject["type"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailType);
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
                websitesObject["address"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteAddress);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteService != null)
            {
                websitesObject["service"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteService);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteType != null)
            {
                websitesObject["type"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteType);
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
                addressesObject["street"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressStreet);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCity != null)
            {
                addressesObject["city"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCity);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressState != null)
            {
                addressesObject["state"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressState);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressZip != null)
            {
                addressesObject["zip"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressZip);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCountry != null)
            {
                addressesObject["country"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCountry);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressType != null)
            {
                addressesObject["type"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressType);
                addressesObjectpropCount++;
            }

            if (addressesObjectpropCount > 0)
            {
                partyObject["addresses"] = addressesObject;
                partyObjectpropCount++;
            }

            if (bodypartytags != null)
            {
                partyObject["tags"] = ExpressionConverter.ConvertO(bodypartytags);
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

            return new ApiConnectionAction<CreatePersonV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdatePersonResponse> UpdatePerson(Expression<Func<string>> personId, Expression<Func<string>> bodypartylastName = null, Expression<Func<string>> bodypartyfirstName = null, Expression<Func<bodypartytitleInput>> bodypartytitle = null, Expression<Func<string>> bodypartyjobTitle = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyorganisationId = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
        {
            var apiCallPath = String.Format("/person/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var partyObject = new JObject();
            var partyObjectpropCount = 0;
            if (bodypartylastName != null)
            {
                partyObject["lastName"] = ExpressionConverter.ConvertO(bodypartylastName);
                partyObjectpropCount++;
            }

            if (bodypartyfirstName != null)
            {
                partyObject["firstName"] = ExpressionConverter.ConvertO(bodypartyfirstName);
                partyObjectpropCount++;
            }

            if (bodypartytitle != null)
            {
                partyObject["title"] = ExpressionConverter.ConvertO(bodypartytitle);
                partyObjectpropCount++;
            }

            if (bodypartyjobTitle != null)
            {
                partyObject["jobTitle"] = ExpressionConverter.ConvertO(bodypartyjobTitle);
                partyObjectpropCount++;
            }

            if (bodypartyabout != null)
            {
                partyObject["about"] = ExpressionConverter.ConvertO(bodypartyabout);
                partyObjectpropCount++;
            }

            if (bodypartyorganisationId != null)
            {
                partyObject["organisation"] = ExpressionConverter.ConvertO(bodypartyorganisationId);
                partyObjectpropCount++;
            }

            var phoneNumbersObject = new JObject();
            var phoneNumbersObjectpropCount = 0;
            if (bodypartyphoneNumbersphoneNumber != null)
            {
                phoneNumbersObject["number"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneNumber);
                phoneNumbersObjectpropCount++;
            }

            if (bodypartyphoneNumbersphoneType != null)
            {
                phoneNumbersObject["type"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneType);
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
                emailAddressesObject["address"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailAddress);
                emailAddressesObjectpropCount++;
            }

            if (bodypartyemailAddressesemailType != null)
            {
                emailAddressesObject["type"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailType);
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
                websitesObject["address"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteAddress);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteService != null)
            {
                websitesObject["service"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteService);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteType != null)
            {
                websitesObject["type"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteType);
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
                addressesObject["street"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressStreet);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCity != null)
            {
                addressesObject["city"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCity);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressState != null)
            {
                addressesObject["state"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressState);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressZip != null)
            {
                addressesObject["zip"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressZip);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCountry != null)
            {
                addressesObject["country"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCountry);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressType != null)
            {
                addressesObject["type"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressType);
                addressesObjectpropCount++;
            }

            if (addressesObjectpropCount > 0)
            {
                partyObject["addresses"] = addressesObject;
                partyObjectpropCount++;
            }

            if (bodypartytags != null)
            {
                partyObject["tags"] = ExpressionConverter.ConvertO(bodypartytags);
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

            return new ApiConnectionAction<UpdatePersonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdatePersonV2Response> UpdatePersonV2(Expression<Func<string>> personId, Expression<Func<int>> bodypartyorganisationid, Expression<Func<string>> bodypartylastName = null, Expression<Func<string>> bodypartyfirstName = null, Expression<Func<bodypartytitleInput>> bodypartytitle = null, Expression<Func<string>> bodypartyjobTitle = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
        {
            var apiCallPath = String.Format("/v2/person/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var partyObject = new JObject();
            var partyObjectpropCount = 0;
            if (bodypartylastName != null)
            {
                partyObject["lastName"] = ExpressionConverter.ConvertO(bodypartylastName);
                partyObjectpropCount++;
            }

            if (bodypartyfirstName != null)
            {
                partyObject["firstName"] = ExpressionConverter.ConvertO(bodypartyfirstName);
                partyObjectpropCount++;
            }

            if (bodypartytitle != null)
            {
                partyObject["title"] = ExpressionConverter.ConvertO(bodypartytitle);
                partyObjectpropCount++;
            }

            if (bodypartyjobTitle != null)
            {
                partyObject["jobTitle"] = ExpressionConverter.ConvertO(bodypartyjobTitle);
                partyObjectpropCount++;
            }

            if (bodypartyabout != null)
            {
                partyObject["about"] = ExpressionConverter.ConvertO(bodypartyabout);
                partyObjectpropCount++;
            }

            var organisationObject = new JObject();
            var organisationObjectpropCount = 0;
            organisationObjectpropCount++;
            organisationObject["id"] = ExpressionConverter.ConvertO(bodypartyorganisationid);
            if (organisationObjectpropCount > 0)
            {
                partyObject["organisation"] = organisationObject;
                partyObjectpropCount++;
            }

            var phoneNumbersObject = new JObject();
            var phoneNumbersObjectpropCount = 0;
            if (bodypartyphoneNumbersphoneNumber != null)
            {
                phoneNumbersObject["number"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneNumber);
                phoneNumbersObjectpropCount++;
            }

            if (bodypartyphoneNumbersphoneType != null)
            {
                phoneNumbersObject["type"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneType);
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
                emailAddressesObject["address"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailAddress);
                emailAddressesObjectpropCount++;
            }

            if (bodypartyemailAddressesemailType != null)
            {
                emailAddressesObject["type"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailType);
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
                websitesObject["address"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteAddress);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteService != null)
            {
                websitesObject["service"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteService);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteType != null)
            {
                websitesObject["type"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteType);
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
                addressesObject["street"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressStreet);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCity != null)
            {
                addressesObject["city"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCity);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressState != null)
            {
                addressesObject["state"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressState);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressZip != null)
            {
                addressesObject["zip"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressZip);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCountry != null)
            {
                addressesObject["country"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCountry);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressType != null)
            {
                addressesObject["type"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressType);
                addressesObjectpropCount++;
            }

            if (addressesObjectpropCount > 0)
            {
                partyObject["addresses"] = addressesObject;
                partyObjectpropCount++;
            }

            if (bodypartytags != null)
            {
                partyObject["tags"] = ExpressionConverter.ConvertO(bodypartytags);
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

            return new ApiConnectionAction<UpdatePersonV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateOrganisationResponse> CreateOrganisation(Expression<Func<string>> bodypartyname = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
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
                partyObject["name"] = ExpressionConverter.ConvertO(bodypartyname);
                partyObjectpropCount++;
            }

            if (bodypartyabout != null)
            {
                partyObject["about"] = ExpressionConverter.ConvertO(bodypartyabout);
                partyObjectpropCount++;
            }

            var phoneNumbersObject = new JObject();
            var phoneNumbersObjectpropCount = 0;
            if (bodypartyphoneNumbersphoneNumber != null)
            {
                phoneNumbersObject["number"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneNumber);
                phoneNumbersObjectpropCount++;
            }

            if (bodypartyphoneNumbersphoneType != null)
            {
                phoneNumbersObject["type"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneType);
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
                emailAddressesObject["address"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailAddress);
                emailAddressesObjectpropCount++;
            }

            if (bodypartyemailAddressesemailType != null)
            {
                emailAddressesObject["type"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailType);
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
                websitesObject["address"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteAddress);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteService != null)
            {
                websitesObject["service"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteService);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteType != null)
            {
                websitesObject["type"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteType);
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
                addressesObject["street"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressStreet);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCity != null)
            {
                addressesObject["city"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCity);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressState != null)
            {
                addressesObject["state"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressState);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressZip != null)
            {
                addressesObject["zip"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressZip);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCountry != null)
            {
                addressesObject["country"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCountry);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressType != null)
            {
                addressesObject["type"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressType);
                addressesObjectpropCount++;
            }

            if (addressesObjectpropCount > 0)
            {
                partyObject["addresses"] = addressesObject;
                partyObjectpropCount++;
            }

            if (bodypartytags != null)
            {
                partyObject["tags"] = ExpressionConverter.ConvertO(bodypartytags);
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

            return new ApiConnectionAction<CreateOrganisationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdateOrganisationResponse> UpdateOrganisation(Expression<Func<string>> id, Expression<Func<string>> bodypartyname = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
        {
            var apiCallPath = String.Format("/organisation/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var partyObject = new JObject();
            var partyObjectpropCount = 0;
            if (bodypartyname != null)
            {
                partyObject["name"] = ExpressionConverter.ConvertO(bodypartyname);
                partyObjectpropCount++;
            }

            if (bodypartyabout != null)
            {
                partyObject["about"] = ExpressionConverter.ConvertO(bodypartyabout);
                partyObjectpropCount++;
            }

            var phoneNumbersObject = new JObject();
            var phoneNumbersObjectpropCount = 0;
            if (bodypartyphoneNumbersphoneNumber != null)
            {
                phoneNumbersObject["number"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneNumber);
                phoneNumbersObjectpropCount++;
            }

            if (bodypartyphoneNumbersphoneType != null)
            {
                phoneNumbersObject["type"] = ExpressionConverter.ConvertO(bodypartyphoneNumbersphoneType);
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
                emailAddressesObject["address"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailAddress);
                emailAddressesObjectpropCount++;
            }

            if (bodypartyemailAddressesemailType != null)
            {
                emailAddressesObject["type"] = ExpressionConverter.ConvertO(bodypartyemailAddressesemailType);
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
                websitesObject["address"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteAddress);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteService != null)
            {
                websitesObject["service"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteService);
                websitesObjectpropCount++;
            }

            if (bodypartywebsiteswebsiteType != null)
            {
                websitesObject["type"] = ExpressionConverter.ConvertO(bodypartywebsiteswebsiteType);
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
                addressesObject["street"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressStreet);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCity != null)
            {
                addressesObject["city"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCity);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressState != null)
            {
                addressesObject["state"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressState);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressZip != null)
            {
                addressesObject["zip"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressZip);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressCountry != null)
            {
                addressesObject["country"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressCountry);
                addressesObjectpropCount++;
            }

            if (bodypartyaddressesaddressType != null)
            {
                addressesObject["type"] = ExpressionConverter.ConvertO(bodypartyaddressesaddressType);
                addressesObjectpropCount++;
            }

            if (addressesObjectpropCount > 0)
            {
                partyObject["addresses"] = addressesObject;
                partyObjectpropCount++;
            }

            if (bodypartytags != null)
            {
                partyObject["tags"] = ExpressionConverter.ConvertO(bodypartytags);
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

            return new ApiConnectionAction<UpdateOrganisationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponse> ListParties()
        {
            var apiCallPath = "/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListpartiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponseV2> ListPartiesV2()
        {
            var apiCallPath = "/v2/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListpartiesResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponse> ListPeople()
        {
            var apiCallPath = "/people/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListpartiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponseV2> ListPeopleV2()
        {
            var apiCallPath = "/v2/people/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListpartiesResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponse> ListOrganizations()
        {
            var apiCallPath = "/organisations/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListpartiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<GetPartyResponse> GetParty(Expression<Func<string>> personId)
        {
            var apiCallPath = String.Format("/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPartyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<string> DeleteParty(Expression<Func<string>> personId)
        {
            var apiCallPath = String.Format("/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<GetPartyV2Response> GetPartyV2(Expression<Func<string>> personId)
        {
            var apiCallPath = String.Format("/v2/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetPartyV2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListTasksResponse> ListTasks()
        {
            var apiCallPath = "/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodytaskdescription = null, Expression<Func<string>> bodytaskdueDate = null, Expression<Func<string>> bodytaskdueTime = null, Expression<Func<string>> bodytaskdetails = null, Expression<Func<int>> bodytaskpartyid = null)
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
                taskObject["description"] = ExpressionConverter.ConvertO(bodytaskdescription);
                taskObjectpropCount++;
            }

            if (bodytaskdueDate != null)
            {
                taskObject["dueOn"] = ExpressionConverter.ConvertO(bodytaskdueDate);
                taskObjectpropCount++;
            }

            if (bodytaskdueTime != null)
            {
                taskObject["dueTime"] = ExpressionConverter.ConvertO(bodytaskdueTime);
                taskObjectpropCount++;
            }

            if (bodytaskdetails != null)
            {
                taskObject["detail"] = ExpressionConverter.ConvertO(bodytaskdetails);
                taskObjectpropCount++;
            }

            var partyObject = new JObject();
            var partyObjectpropCount = 0;
            if (bodytaskpartyid != null)
            {
                partyObject["id"] = ExpressionConverter.ConvertO(bodytaskpartyid);
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

            return new ApiConnectionAction<CreateTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CompleteTaskResponse> CompleteTask(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
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

            return new ApiConnectionAction<CompleteTaskResponse>(callPayload);
        }
    }

    public class CapsulecrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OpportunityResponse[]> OnNewOpportunity(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_trigger/opportunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OpportunityResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<OpportunityResponse[]> OnUpdateOpportunity(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/update_trigger/opportunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OpportunityResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TaskResponse[]> OnNewTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_trigger/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PartyResponse[]> OnNewParty(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_trigger/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PartyResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PartyResponseV2[]> OnNewPartyV2(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/create_trigger/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PartyResponseV2[]>(callPayload, triggerName, recurrence);
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

    public class CreatePersonV2Response
    {
        [JsonProperty("party")]
        public PartyResponseV2 Party { get; set; }
    }

    public class PartyResponseV2
    {
        [JsonProperty("name")]
        public string OrganisationName { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("addresses")]
        public PartyResponseV2AddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("emailAddresses")]
        public PartyResponseV2EmailAddressesTypeItem[] EmailAddresses { get; set; }

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
        public PartyResponseV2NestedOrganisationType NestedOrganisation { get; set; }

        [JsonProperty("phoneNumbers")]
        public PartyResponseV2PhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("websites")]
        public PartyResponseV2WebsitesTypeItem[] Websites { get; set; }
    }

    public class PartyResponseV2AddressesTypeItem
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

    public class PartyResponseV2EmailAddressesTypeItem
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }
    }

    public class PartyResponseV2NestedOrganisationType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }
    }

    public class PartyResponseV2PhoneNumbersTypeItem
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public string PhoneNumberType { get; set; }
    }

    public class PartyResponseV2WebsitesTypeItem
    {
        [JsonProperty("address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("service")]
        public string WebsiteService { get; set; }

        [JsonProperty("type")]
        public string WebsiteType { get; set; }
    }

    public class UpdatePersonResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class UpdatePersonV2Response
    {
        [JsonProperty("party")]
        public PartyResponseV2 Party { get; set; }
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

    public class ListpartiesResponseV2
    {
        [JsonProperty("parties")]
        public ListpartiesResponseV2PartiesTypeItem[] Parties { get; set; }
    }

    public class ListpartiesResponseV2PartiesTypeItem
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
        public ListpartiesResponseV2PartiesTypeItemNestedOrganisationType NestedOrganisation { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }
    }

    public class ListpartiesResponseV2PartiesTypeItemNestedOrganisationType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }
    }

    public class GetPartyResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class GetPartyV2Response
    {
        [JsonProperty("party")]
        public PartyResponseV2 Party { get; set; }
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