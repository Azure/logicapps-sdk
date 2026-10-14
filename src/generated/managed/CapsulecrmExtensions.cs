//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Capsulecrm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_bodyopportunitypartypartyId = bodyopportunitypartypartyId == null ? null : WorkflowExpression.Compile(bodyopportunitypartypartyId);
            WorkflowExpression.Validate(__workflow_bodyopportunitypartypartyId, nameof(bodyopportunitypartypartyId), required: true);
            var __workflow_bodyopportunitymilestoneid = bodyopportunitymilestoneid == null ? null : WorkflowExpression.Compile(bodyopportunitymilestoneid);
            WorkflowExpression.Validate(__workflow_bodyopportunitymilestoneid, nameof(bodyopportunitymilestoneid), required: true);
            var __workflow_bodyopportunityname = bodyopportunityname == null ? null : WorkflowExpression.Compile(bodyopportunityname);
            WorkflowExpression.Validate(__workflow_bodyopportunityname, nameof(bodyopportunityname), required: false);
            var __workflow_bodyopportunitydescription = bodyopportunitydescription == null ? null : WorkflowExpression.Compile(bodyopportunitydescription);
            WorkflowExpression.Validate(__workflow_bodyopportunitydescription, nameof(bodyopportunitydescription), required: false);
            var __workflow_bodyopportunitydurationBasis = bodyopportunitydurationBasis == null ? null : WorkflowExpression.Compile(bodyopportunitydurationBasis);
            WorkflowExpression.Validate(__workflow_bodyopportunitydurationBasis, nameof(bodyopportunitydurationBasis), required: false);
            var __workflow_bodyopportunityduration = bodyopportunityduration == null ? null : WorkflowExpression.Compile(bodyopportunityduration);
            WorkflowExpression.Validate(__workflow_bodyopportunityduration, nameof(bodyopportunityduration), required: false);
            var __workflow_bodyopportunityexpectedCloseDate = bodyopportunityexpectedCloseDate == null ? null : WorkflowExpression.Compile(bodyopportunityexpectedCloseDate);
            WorkflowExpression.Validate(__workflow_bodyopportunityexpectedCloseDate, nameof(bodyopportunityexpectedCloseDate), required: false);
            var __workflow_bodyopportunitywinningProbability = bodyopportunitywinningProbability == null ? null : WorkflowExpression.Compile(bodyopportunitywinningProbability);
            WorkflowExpression.Validate(__workflow_bodyopportunitywinningProbability, nameof(bodyopportunitywinningProbability), required: false);
            var __workflow_bodyopportunityexpectedamount = bodyopportunityexpectedamount == null ? null : WorkflowExpression.Compile(bodyopportunityexpectedamount);
            WorkflowExpression.Validate(__workflow_bodyopportunityexpectedamount, nameof(bodyopportunityexpectedamount), required: false);
            var __workflow_bodyopportunityexpectedcurrency = bodyopportunityexpectedcurrency == null ? null : WorkflowExpression.Compile(bodyopportunityexpectedcurrency);
            WorkflowExpression.Validate(__workflow_bodyopportunityexpectedcurrency, nameof(bodyopportunityexpectedcurrency), required: false);
            return new DeferredBodyAction<CreateOpportunityResponse>(() =>
            {
                var apiCallPath = "/opportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var opportunityObject = new JObject();
                var opportunityObjectpropCount = 0;
                if (__workflow_bodyopportunityname != null)
                {
                    opportunityObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityname);
                    opportunityObjectpropCount++;
                }

                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                partyObjectpropCount++;
                partyObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitypartypartyId);
                if (partyObjectpropCount > 0)
                {
                    opportunityObject["party"] = partyObject;
                    opportunityObjectpropCount++;
                }

                var milestoneObject = new JObject();
                var milestoneObjectpropCount = 0;
                milestoneObjectpropCount++;
                milestoneObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitymilestoneid);
                if (milestoneObjectpropCount > 0)
                {
                    opportunityObject["milestone"] = milestoneObject;
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunitydescription != null)
                {
                    opportunityObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitydescription);
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunitydurationBasis != null)
                {
                    opportunityObject["durationBasis"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitydurationBasis);
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunityduration != null)
                {
                    opportunityObject["duration"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityduration);
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunityexpectedCloseDate != null)
                {
                    opportunityObject["expectedCloseOn"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityexpectedCloseDate);
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunitywinningProbability != null)
                {
                    opportunityObject["probability"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitywinningProbability);
                    opportunityObjectpropCount++;
                }

                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (__workflow_bodyopportunityexpectedamount != null)
                {
                    valueObject["amount"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityexpectedamount);
                    valueObjectpropCount++;
                }

                if (__workflow_bodyopportunityexpectedcurrency != null)
                {
                    valueObject["currency"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityexpectedcurrency);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<GetOpportunityResponse> GetOpportunity(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = opportunityId == null ? null : WorkflowExpression.Compile(opportunityId);
            WorkflowExpression.Validate(__workflow_opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<GetOpportunityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOpportunityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdateOpportunityResponse> UpdateOpportunity(Expression<Func<string>> opportunityId, Expression<Func<int>> bodyopportunitypartypartyId, Expression<Func<int>> bodyopportunitymilestonemilestoneId, Expression<Func<string>> bodyopportunityname = null, Expression<Func<string>> bodyopportunitydescription = null, Expression<Func<bodyopportunitydurationBasisInput>> bodyopportunitydurationBasis = null, Expression<Func<string>> bodyopportunityduration = null, Expression<Func<string>> bodyopportunityexpectedCloseDate = null, Expression<Func<int>> bodyopportunitywinningProbability = null, Expression<Func<int>> bodyopportunityexpectedamount = null, Expression<Func<string>> bodyopportunityexpectedcurrency = null)
        {
            var __workflow_opportunityId = opportunityId == null ? null : WorkflowExpression.Compile(opportunityId);
            WorkflowExpression.Validate(__workflow_opportunityId, nameof(opportunityId), required: true);
            var __workflow_bodyopportunitypartypartyId = bodyopportunitypartypartyId == null ? null : WorkflowExpression.Compile(bodyopportunitypartypartyId);
            WorkflowExpression.Validate(__workflow_bodyopportunitypartypartyId, nameof(bodyopportunitypartypartyId), required: true);
            var __workflow_bodyopportunitymilestonemilestoneId = bodyopportunitymilestonemilestoneId == null ? null : WorkflowExpression.Compile(bodyopportunitymilestonemilestoneId);
            WorkflowExpression.Validate(__workflow_bodyopportunitymilestonemilestoneId, nameof(bodyopportunitymilestonemilestoneId), required: true);
            var __workflow_bodyopportunityname = bodyopportunityname == null ? null : WorkflowExpression.Compile(bodyopportunityname);
            WorkflowExpression.Validate(__workflow_bodyopportunityname, nameof(bodyopportunityname), required: false);
            var __workflow_bodyopportunitydescription = bodyopportunitydescription == null ? null : WorkflowExpression.Compile(bodyopportunitydescription);
            WorkflowExpression.Validate(__workflow_bodyopportunitydescription, nameof(bodyopportunitydescription), required: false);
            var __workflow_bodyopportunitydurationBasis = bodyopportunitydurationBasis == null ? null : WorkflowExpression.Compile(bodyopportunitydurationBasis);
            WorkflowExpression.Validate(__workflow_bodyopportunitydurationBasis, nameof(bodyopportunitydurationBasis), required: false);
            var __workflow_bodyopportunityduration = bodyopportunityduration == null ? null : WorkflowExpression.Compile(bodyopportunityduration);
            WorkflowExpression.Validate(__workflow_bodyopportunityduration, nameof(bodyopportunityduration), required: false);
            var __workflow_bodyopportunityexpectedCloseDate = bodyopportunityexpectedCloseDate == null ? null : WorkflowExpression.Compile(bodyopportunityexpectedCloseDate);
            WorkflowExpression.Validate(__workflow_bodyopportunityexpectedCloseDate, nameof(bodyopportunityexpectedCloseDate), required: false);
            var __workflow_bodyopportunitywinningProbability = bodyopportunitywinningProbability == null ? null : WorkflowExpression.Compile(bodyopportunitywinningProbability);
            WorkflowExpression.Validate(__workflow_bodyopportunitywinningProbability, nameof(bodyopportunitywinningProbability), required: false);
            var __workflow_bodyopportunityexpectedamount = bodyopportunityexpectedamount == null ? null : WorkflowExpression.Compile(bodyopportunityexpectedamount);
            WorkflowExpression.Validate(__workflow_bodyopportunityexpectedamount, nameof(bodyopportunityexpectedamount), required: false);
            var __workflow_bodyopportunityexpectedcurrency = bodyopportunityexpectedcurrency == null ? null : WorkflowExpression.Compile(bodyopportunityexpectedcurrency);
            WorkflowExpression.Validate(__workflow_bodyopportunityexpectedcurrency, nameof(bodyopportunityexpectedcurrency), required: false);
            return new DeferredBodyAction<UpdateOpportunityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_opportunityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var opportunityObject = new JObject();
                var opportunityObjectpropCount = 0;
                if (__workflow_bodyopportunityname != null)
                {
                    opportunityObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityname);
                    opportunityObjectpropCount++;
                }

                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                partyObjectpropCount++;
                partyObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitypartypartyId);
                if (partyObjectpropCount > 0)
                {
                    opportunityObject["party"] = partyObject;
                    opportunityObjectpropCount++;
                }

                var milestoneObject = new JObject();
                var milestoneObjectpropCount = 0;
                milestoneObjectpropCount++;
                milestoneObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitymilestonemilestoneId);
                if (milestoneObjectpropCount > 0)
                {
                    opportunityObject["milestone"] = milestoneObject;
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunitydescription != null)
                {
                    opportunityObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitydescription);
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunitydurationBasis != null)
                {
                    opportunityObject["durationBasis"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitydurationBasis);
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunityduration != null)
                {
                    opportunityObject["duration"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityduration);
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunityexpectedCloseDate != null)
                {
                    opportunityObject["expectedCloseOn"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityexpectedCloseDate);
                    opportunityObjectpropCount++;
                }

                if (__workflow_bodyopportunitywinningProbability != null)
                {
                    opportunityObject["probability"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitywinningProbability);
                    opportunityObjectpropCount++;
                }

                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (__workflow_bodyopportunityexpectedamount != null)
                {
                    valueObject["amount"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityexpectedamount);
                    valueObjectpropCount++;
                }

                if (__workflow_bodyopportunityexpectedcurrency != null)
                {
                    valueObject["currency"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityexpectedcurrency);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<string> DeleteOpportunity(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = opportunityId == null ? null : WorkflowExpression.Compile(opportunityId);
            WorkflowExpression.Validate(__workflow_opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_opportunityId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson(Expression<Func<string>> bodypartylastName = null, Expression<Func<string>> bodypartyfirstName = null, Expression<Func<bodypartytitleInput>> bodypartytitle = null, Expression<Func<string>> bodypartyjobTitle = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyorganisationId = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
        {
            var __workflow_bodypartylastName = bodypartylastName == null ? null : WorkflowExpression.Compile(bodypartylastName);
            WorkflowExpression.Validate(__workflow_bodypartylastName, nameof(bodypartylastName), required: false);
            var __workflow_bodypartyfirstName = bodypartyfirstName == null ? null : WorkflowExpression.Compile(bodypartyfirstName);
            WorkflowExpression.Validate(__workflow_bodypartyfirstName, nameof(bodypartyfirstName), required: false);
            var __workflow_bodypartytitle = bodypartytitle == null ? null : WorkflowExpression.Compile(bodypartytitle);
            WorkflowExpression.Validate(__workflow_bodypartytitle, nameof(bodypartytitle), required: false);
            var __workflow_bodypartyjobTitle = bodypartyjobTitle == null ? null : WorkflowExpression.Compile(bodypartyjobTitle);
            WorkflowExpression.Validate(__workflow_bodypartyjobTitle, nameof(bodypartyjobTitle), required: false);
            var __workflow_bodypartyabout = bodypartyabout == null ? null : WorkflowExpression.Compile(bodypartyabout);
            WorkflowExpression.Validate(__workflow_bodypartyabout, nameof(bodypartyabout), required: false);
            var __workflow_bodypartyorganisationId = bodypartyorganisationId == null ? null : WorkflowExpression.Compile(bodypartyorganisationId);
            WorkflowExpression.Validate(__workflow_bodypartyorganisationId, nameof(bodypartyorganisationId), required: false);
            var __workflow_bodypartyphoneNumbersphoneNumber = bodypartyphoneNumbersphoneNumber == null ? null : WorkflowExpression.Compile(bodypartyphoneNumbersphoneNumber);
            WorkflowExpression.Validate(__workflow_bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            var __workflow_bodypartyphoneNumbersphoneType = bodypartyphoneNumbersphoneType == null ? null : WorkflowExpression.Compile(bodypartyphoneNumbersphoneType);
            WorkflowExpression.Validate(__workflow_bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            var __workflow_bodypartyemailAddressesemailAddress = bodypartyemailAddressesemailAddress == null ? null : WorkflowExpression.Compile(bodypartyemailAddressesemailAddress);
            WorkflowExpression.Validate(__workflow_bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            var __workflow_bodypartyemailAddressesemailType = bodypartyemailAddressesemailType == null ? null : WorkflowExpression.Compile(bodypartyemailAddressesemailType);
            WorkflowExpression.Validate(__workflow_bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            var __workflow_bodypartywebsiteswebsiteAddress = bodypartywebsiteswebsiteAddress == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteAddress);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            var __workflow_bodypartywebsiteswebsiteService = bodypartywebsiteswebsiteService == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteService);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            var __workflow_bodypartywebsiteswebsiteType = bodypartywebsiteswebsiteType == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteType);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            var __workflow_bodypartyaddressesaddressStreet = bodypartyaddressesaddressStreet == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressStreet);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            var __workflow_bodypartyaddressesaddressCity = bodypartyaddressesaddressCity == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressCity);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            var __workflow_bodypartyaddressesaddressState = bodypartyaddressesaddressState == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressState);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            var __workflow_bodypartyaddressesaddressZip = bodypartyaddressesaddressZip == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressZip);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            var __workflow_bodypartyaddressesaddressCountry = bodypartyaddressesaddressCountry == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressCountry);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            var __workflow_bodypartyaddressesaddressType = bodypartyaddressesaddressType == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressType);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            var __workflow_bodypartytags = bodypartytags == null ? null : WorkflowExpression.Compile(bodypartytags);
            WorkflowExpression.Validate(__workflow_bodypartytags, nameof(bodypartytags), required: false);
            return new DeferredBodyAction<CreatePersonResponse>(() =>
            {
                var apiCallPath = "/person/parties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (__workflow_bodypartylastName != null)
                {
                    partyObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodypartylastName);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyfirstName != null)
                {
                    partyObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodypartyfirstName);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartytitle != null)
                {
                    partyObject["title"] = ExpressionConverter.ConvertO(__workflow_bodypartytitle);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyjobTitle != null)
                {
                    partyObject["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodypartyjobTitle);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyabout != null)
                {
                    partyObject["about"] = ExpressionConverter.ConvertO(__workflow_bodypartyabout);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyorganisationId != null)
                {
                    partyObject["organisation"] = ExpressionConverter.ConvertO(__workflow_bodypartyorganisationId);
                    partyObjectpropCount++;
                }

                var phoneNumbersObject = new JObject();
                var phoneNumbersObjectpropCount = 0;
                if (__workflow_bodypartyphoneNumbersphoneNumber != null)
                {
                    phoneNumbersObject["number"] = ExpressionConverter.ConvertO(__workflow_bodypartyphoneNumbersphoneNumber);
                    phoneNumbersObjectpropCount++;
                }

                if (__workflow_bodypartyphoneNumbersphoneType != null)
                {
                    phoneNumbersObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyphoneNumbersphoneType);
                    phoneNumbersObjectpropCount++;
                }

                if (phoneNumbersObjectpropCount > 0)
                {
                    partyObject["phoneNumbers"] = phoneNumbersObject;
                    partyObjectpropCount++;
                }

                var emailAddressesObject = new JObject();
                var emailAddressesObjectpropCount = 0;
                if (__workflow_bodypartyemailAddressesemailAddress != null)
                {
                    emailAddressesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypartyemailAddressesemailAddress);
                    emailAddressesObjectpropCount++;
                }

                if (__workflow_bodypartyemailAddressesemailType != null)
                {
                    emailAddressesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyemailAddressesemailType);
                    emailAddressesObjectpropCount++;
                }

                if (emailAddressesObjectpropCount > 0)
                {
                    partyObject["emailAddresses"] = emailAddressesObject;
                    partyObjectpropCount++;
                }

                var websitesObject = new JObject();
                var websitesObjectpropCount = 0;
                if (__workflow_bodypartywebsiteswebsiteAddress != null)
                {
                    websitesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteAddress);
                    websitesObjectpropCount++;
                }

                if (__workflow_bodypartywebsiteswebsiteService != null)
                {
                    websitesObject["service"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteService);
                    websitesObjectpropCount++;
                }

                if (__workflow_bodypartywebsiteswebsiteType != null)
                {
                    websitesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteType);
                    websitesObjectpropCount++;
                }

                if (websitesObjectpropCount > 0)
                {
                    partyObject["websites"] = websitesObject;
                    partyObjectpropCount++;
                }

                var addressesObject = new JObject();
                var addressesObjectpropCount = 0;
                if (__workflow_bodypartyaddressesaddressStreet != null)
                {
                    addressesObject["street"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressStreet);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressCity != null)
                {
                    addressesObject["city"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressCity);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressState != null)
                {
                    addressesObject["state"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressState);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressZip != null)
                {
                    addressesObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressZip);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressCountry != null)
                {
                    addressesObject["country"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressCountry);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressType != null)
                {
                    addressesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressType);
                    addressesObjectpropCount++;
                }

                if (addressesObjectpropCount > 0)
                {
                    partyObject["addresses"] = addressesObject;
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartytags != null)
                {
                    partyObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodypartytags);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdatePersonResponse> UpdatePerson(Expression<Func<string>> personId, Expression<Func<string>> bodypartylastName = null, Expression<Func<string>> bodypartyfirstName = null, Expression<Func<bodypartytitleInput>> bodypartytitle = null, Expression<Func<string>> bodypartyjobTitle = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyorganisationId = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
        {
            var __workflow_personId = personId == null ? null : WorkflowExpression.Compile(personId);
            WorkflowExpression.Validate(__workflow_personId, nameof(personId), required: true);
            var __workflow_bodypartylastName = bodypartylastName == null ? null : WorkflowExpression.Compile(bodypartylastName);
            WorkflowExpression.Validate(__workflow_bodypartylastName, nameof(bodypartylastName), required: false);
            var __workflow_bodypartyfirstName = bodypartyfirstName == null ? null : WorkflowExpression.Compile(bodypartyfirstName);
            WorkflowExpression.Validate(__workflow_bodypartyfirstName, nameof(bodypartyfirstName), required: false);
            var __workflow_bodypartytitle = bodypartytitle == null ? null : WorkflowExpression.Compile(bodypartytitle);
            WorkflowExpression.Validate(__workflow_bodypartytitle, nameof(bodypartytitle), required: false);
            var __workflow_bodypartyjobTitle = bodypartyjobTitle == null ? null : WorkflowExpression.Compile(bodypartyjobTitle);
            WorkflowExpression.Validate(__workflow_bodypartyjobTitle, nameof(bodypartyjobTitle), required: false);
            var __workflow_bodypartyabout = bodypartyabout == null ? null : WorkflowExpression.Compile(bodypartyabout);
            WorkflowExpression.Validate(__workflow_bodypartyabout, nameof(bodypartyabout), required: false);
            var __workflow_bodypartyorganisationId = bodypartyorganisationId == null ? null : WorkflowExpression.Compile(bodypartyorganisationId);
            WorkflowExpression.Validate(__workflow_bodypartyorganisationId, nameof(bodypartyorganisationId), required: false);
            var __workflow_bodypartyphoneNumbersphoneNumber = bodypartyphoneNumbersphoneNumber == null ? null : WorkflowExpression.Compile(bodypartyphoneNumbersphoneNumber);
            WorkflowExpression.Validate(__workflow_bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            var __workflow_bodypartyphoneNumbersphoneType = bodypartyphoneNumbersphoneType == null ? null : WorkflowExpression.Compile(bodypartyphoneNumbersphoneType);
            WorkflowExpression.Validate(__workflow_bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            var __workflow_bodypartyemailAddressesemailAddress = bodypartyemailAddressesemailAddress == null ? null : WorkflowExpression.Compile(bodypartyemailAddressesemailAddress);
            WorkflowExpression.Validate(__workflow_bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            var __workflow_bodypartyemailAddressesemailType = bodypartyemailAddressesemailType == null ? null : WorkflowExpression.Compile(bodypartyemailAddressesemailType);
            WorkflowExpression.Validate(__workflow_bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            var __workflow_bodypartywebsiteswebsiteAddress = bodypartywebsiteswebsiteAddress == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteAddress);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            var __workflow_bodypartywebsiteswebsiteService = bodypartywebsiteswebsiteService == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteService);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            var __workflow_bodypartywebsiteswebsiteType = bodypartywebsiteswebsiteType == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteType);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            var __workflow_bodypartyaddressesaddressStreet = bodypartyaddressesaddressStreet == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressStreet);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            var __workflow_bodypartyaddressesaddressCity = bodypartyaddressesaddressCity == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressCity);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            var __workflow_bodypartyaddressesaddressState = bodypartyaddressesaddressState == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressState);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            var __workflow_bodypartyaddressesaddressZip = bodypartyaddressesaddressZip == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressZip);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            var __workflow_bodypartyaddressesaddressCountry = bodypartyaddressesaddressCountry == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressCountry);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            var __workflow_bodypartyaddressesaddressType = bodypartyaddressesaddressType == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressType);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            var __workflow_bodypartytags = bodypartytags == null ? null : WorkflowExpression.Compile(bodypartytags);
            WorkflowExpression.Validate(__workflow_bodypartytags, nameof(bodypartytags), required: false);
            return new DeferredBodyAction<UpdatePersonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/person/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_personId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (__workflow_bodypartylastName != null)
                {
                    partyObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodypartylastName);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyfirstName != null)
                {
                    partyObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodypartyfirstName);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartytitle != null)
                {
                    partyObject["title"] = ExpressionConverter.ConvertO(__workflow_bodypartytitle);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyjobTitle != null)
                {
                    partyObject["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodypartyjobTitle);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyabout != null)
                {
                    partyObject["about"] = ExpressionConverter.ConvertO(__workflow_bodypartyabout);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyorganisationId != null)
                {
                    partyObject["organisation"] = ExpressionConverter.ConvertO(__workflow_bodypartyorganisationId);
                    partyObjectpropCount++;
                }

                var phoneNumbersObject = new JObject();
                var phoneNumbersObjectpropCount = 0;
                if (__workflow_bodypartyphoneNumbersphoneNumber != null)
                {
                    phoneNumbersObject["number"] = ExpressionConverter.ConvertO(__workflow_bodypartyphoneNumbersphoneNumber);
                    phoneNumbersObjectpropCount++;
                }

                if (__workflow_bodypartyphoneNumbersphoneType != null)
                {
                    phoneNumbersObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyphoneNumbersphoneType);
                    phoneNumbersObjectpropCount++;
                }

                if (phoneNumbersObjectpropCount > 0)
                {
                    partyObject["phoneNumbers"] = phoneNumbersObject;
                    partyObjectpropCount++;
                }

                var emailAddressesObject = new JObject();
                var emailAddressesObjectpropCount = 0;
                if (__workflow_bodypartyemailAddressesemailAddress != null)
                {
                    emailAddressesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypartyemailAddressesemailAddress);
                    emailAddressesObjectpropCount++;
                }

                if (__workflow_bodypartyemailAddressesemailType != null)
                {
                    emailAddressesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyemailAddressesemailType);
                    emailAddressesObjectpropCount++;
                }

                if (emailAddressesObjectpropCount > 0)
                {
                    partyObject["emailAddresses"] = emailAddressesObject;
                    partyObjectpropCount++;
                }

                var websitesObject = new JObject();
                var websitesObjectpropCount = 0;
                if (__workflow_bodypartywebsiteswebsiteAddress != null)
                {
                    websitesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteAddress);
                    websitesObjectpropCount++;
                }

                if (__workflow_bodypartywebsiteswebsiteService != null)
                {
                    websitesObject["service"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteService);
                    websitesObjectpropCount++;
                }

                if (__workflow_bodypartywebsiteswebsiteType != null)
                {
                    websitesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteType);
                    websitesObjectpropCount++;
                }

                if (websitesObjectpropCount > 0)
                {
                    partyObject["websites"] = websitesObject;
                    partyObjectpropCount++;
                }

                var addressesObject = new JObject();
                var addressesObjectpropCount = 0;
                if (__workflow_bodypartyaddressesaddressStreet != null)
                {
                    addressesObject["street"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressStreet);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressCity != null)
                {
                    addressesObject["city"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressCity);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressState != null)
                {
                    addressesObject["state"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressState);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressZip != null)
                {
                    addressesObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressZip);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressCountry != null)
                {
                    addressesObject["country"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressCountry);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressType != null)
                {
                    addressesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressType);
                    addressesObjectpropCount++;
                }

                if (addressesObjectpropCount > 0)
                {
                    partyObject["addresses"] = addressesObject;
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartytags != null)
                {
                    partyObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodypartytags);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateOrganisationResponse> CreateOrganisation(Expression<Func<string>> bodypartyname = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
        {
            var __workflow_bodypartyname = bodypartyname == null ? null : WorkflowExpression.Compile(bodypartyname);
            WorkflowExpression.Validate(__workflow_bodypartyname, nameof(bodypartyname), required: false);
            var __workflow_bodypartyabout = bodypartyabout == null ? null : WorkflowExpression.Compile(bodypartyabout);
            WorkflowExpression.Validate(__workflow_bodypartyabout, nameof(bodypartyabout), required: false);
            var __workflow_bodypartyphoneNumbersphoneNumber = bodypartyphoneNumbersphoneNumber == null ? null : WorkflowExpression.Compile(bodypartyphoneNumbersphoneNumber);
            WorkflowExpression.Validate(__workflow_bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            var __workflow_bodypartyphoneNumbersphoneType = bodypartyphoneNumbersphoneType == null ? null : WorkflowExpression.Compile(bodypartyphoneNumbersphoneType);
            WorkflowExpression.Validate(__workflow_bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            var __workflow_bodypartyemailAddressesemailAddress = bodypartyemailAddressesemailAddress == null ? null : WorkflowExpression.Compile(bodypartyemailAddressesemailAddress);
            WorkflowExpression.Validate(__workflow_bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            var __workflow_bodypartyemailAddressesemailType = bodypartyemailAddressesemailType == null ? null : WorkflowExpression.Compile(bodypartyemailAddressesemailType);
            WorkflowExpression.Validate(__workflow_bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            var __workflow_bodypartywebsiteswebsiteAddress = bodypartywebsiteswebsiteAddress == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteAddress);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            var __workflow_bodypartywebsiteswebsiteService = bodypartywebsiteswebsiteService == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteService);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            var __workflow_bodypartywebsiteswebsiteType = bodypartywebsiteswebsiteType == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteType);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            var __workflow_bodypartyaddressesaddressStreet = bodypartyaddressesaddressStreet == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressStreet);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            var __workflow_bodypartyaddressesaddressCity = bodypartyaddressesaddressCity == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressCity);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            var __workflow_bodypartyaddressesaddressState = bodypartyaddressesaddressState == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressState);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            var __workflow_bodypartyaddressesaddressZip = bodypartyaddressesaddressZip == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressZip);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            var __workflow_bodypartyaddressesaddressCountry = bodypartyaddressesaddressCountry == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressCountry);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            var __workflow_bodypartyaddressesaddressType = bodypartyaddressesaddressType == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressType);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            var __workflow_bodypartytags = bodypartytags == null ? null : WorkflowExpression.Compile(bodypartytags);
            WorkflowExpression.Validate(__workflow_bodypartytags, nameof(bodypartytags), required: false);
            return new DeferredBodyAction<CreateOrganisationResponse>(() =>
            {
                var apiCallPath = "/organisation/parties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (__workflow_bodypartyname != null)
                {
                    partyObject["name"] = ExpressionConverter.ConvertO(__workflow_bodypartyname);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyabout != null)
                {
                    partyObject["about"] = ExpressionConverter.ConvertO(__workflow_bodypartyabout);
                    partyObjectpropCount++;
                }

                var phoneNumbersObject = new JObject();
                var phoneNumbersObjectpropCount = 0;
                if (__workflow_bodypartyphoneNumbersphoneNumber != null)
                {
                    phoneNumbersObject["number"] = ExpressionConverter.ConvertO(__workflow_bodypartyphoneNumbersphoneNumber);
                    phoneNumbersObjectpropCount++;
                }

                if (__workflow_bodypartyphoneNumbersphoneType != null)
                {
                    phoneNumbersObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyphoneNumbersphoneType);
                    phoneNumbersObjectpropCount++;
                }

                if (phoneNumbersObjectpropCount > 0)
                {
                    partyObject["phoneNumbers"] = phoneNumbersObject;
                    partyObjectpropCount++;
                }

                var emailAddressesObject = new JObject();
                var emailAddressesObjectpropCount = 0;
                if (__workflow_bodypartyemailAddressesemailAddress != null)
                {
                    emailAddressesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypartyemailAddressesemailAddress);
                    emailAddressesObjectpropCount++;
                }

                if (__workflow_bodypartyemailAddressesemailType != null)
                {
                    emailAddressesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyemailAddressesemailType);
                    emailAddressesObjectpropCount++;
                }

                if (emailAddressesObjectpropCount > 0)
                {
                    partyObject["emailAddresses"] = emailAddressesObject;
                    partyObjectpropCount++;
                }

                var websitesObject = new JObject();
                var websitesObjectpropCount = 0;
                if (__workflow_bodypartywebsiteswebsiteAddress != null)
                {
                    websitesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteAddress);
                    websitesObjectpropCount++;
                }

                if (__workflow_bodypartywebsiteswebsiteService != null)
                {
                    websitesObject["service"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteService);
                    websitesObjectpropCount++;
                }

                if (__workflow_bodypartywebsiteswebsiteType != null)
                {
                    websitesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteType);
                    websitesObjectpropCount++;
                }

                if (websitesObjectpropCount > 0)
                {
                    partyObject["websites"] = websitesObject;
                    partyObjectpropCount++;
                }

                var addressesObject = new JObject();
                var addressesObjectpropCount = 0;
                if (__workflow_bodypartyaddressesaddressStreet != null)
                {
                    addressesObject["street"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressStreet);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressCity != null)
                {
                    addressesObject["city"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressCity);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressState != null)
                {
                    addressesObject["state"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressState);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressZip != null)
                {
                    addressesObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressZip);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressCountry != null)
                {
                    addressesObject["country"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressCountry);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressType != null)
                {
                    addressesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressType);
                    addressesObjectpropCount++;
                }

                if (addressesObjectpropCount > 0)
                {
                    partyObject["addresses"] = addressesObject;
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartytags != null)
                {
                    partyObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodypartytags);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdateOrganisationResponse> UpdateOrganisation(Expression<Func<string>> id, Expression<Func<string>> bodypartyname = null, Expression<Func<string>> bodypartyabout = null, Expression<Func<string>> bodypartyphoneNumbersphoneNumber = null, Expression<Func<bodypartyphoneNumbersphoneTypeInput>> bodypartyphoneNumbersphoneType = null, Expression<Func<string>> bodypartyemailAddressesemailAddress = null, Expression<Func<bodypartyemailAddressesemailTypeInput>> bodypartyemailAddressesemailType = null, Expression<Func<string>> bodypartywebsiteswebsiteAddress = null, Expression<Func<bodypartywebsiteswebsiteServiceInput>> bodypartywebsiteswebsiteService = null, Expression<Func<bodypartywebsiteswebsiteTypeInput>> bodypartywebsiteswebsiteType = null, Expression<Func<string>> bodypartyaddressesaddressStreet = null, Expression<Func<string>> bodypartyaddressesaddressCity = null, Expression<Func<string>> bodypartyaddressesaddressState = null, Expression<Func<string>> bodypartyaddressesaddressZip = null, Expression<Func<string>> bodypartyaddressesaddressCountry = null, Expression<Func<bodypartyaddressesaddressTypeInput>> bodypartyaddressesaddressType = null, Expression<Func<string>> bodypartytags = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodypartyname = bodypartyname == null ? null : WorkflowExpression.Compile(bodypartyname);
            WorkflowExpression.Validate(__workflow_bodypartyname, nameof(bodypartyname), required: false);
            var __workflow_bodypartyabout = bodypartyabout == null ? null : WorkflowExpression.Compile(bodypartyabout);
            WorkflowExpression.Validate(__workflow_bodypartyabout, nameof(bodypartyabout), required: false);
            var __workflow_bodypartyphoneNumbersphoneNumber = bodypartyphoneNumbersphoneNumber == null ? null : WorkflowExpression.Compile(bodypartyphoneNumbersphoneNumber);
            WorkflowExpression.Validate(__workflow_bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            var __workflow_bodypartyphoneNumbersphoneType = bodypartyphoneNumbersphoneType == null ? null : WorkflowExpression.Compile(bodypartyphoneNumbersphoneType);
            WorkflowExpression.Validate(__workflow_bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            var __workflow_bodypartyemailAddressesemailAddress = bodypartyemailAddressesemailAddress == null ? null : WorkflowExpression.Compile(bodypartyemailAddressesemailAddress);
            WorkflowExpression.Validate(__workflow_bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            var __workflow_bodypartyemailAddressesemailType = bodypartyemailAddressesemailType == null ? null : WorkflowExpression.Compile(bodypartyemailAddressesemailType);
            WorkflowExpression.Validate(__workflow_bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            var __workflow_bodypartywebsiteswebsiteAddress = bodypartywebsiteswebsiteAddress == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteAddress);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            var __workflow_bodypartywebsiteswebsiteService = bodypartywebsiteswebsiteService == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteService);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            var __workflow_bodypartywebsiteswebsiteType = bodypartywebsiteswebsiteType == null ? null : WorkflowExpression.Compile(bodypartywebsiteswebsiteType);
            WorkflowExpression.Validate(__workflow_bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            var __workflow_bodypartyaddressesaddressStreet = bodypartyaddressesaddressStreet == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressStreet);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            var __workflow_bodypartyaddressesaddressCity = bodypartyaddressesaddressCity == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressCity);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            var __workflow_bodypartyaddressesaddressState = bodypartyaddressesaddressState == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressState);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            var __workflow_bodypartyaddressesaddressZip = bodypartyaddressesaddressZip == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressZip);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            var __workflow_bodypartyaddressesaddressCountry = bodypartyaddressesaddressCountry == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressCountry);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            var __workflow_bodypartyaddressesaddressType = bodypartyaddressesaddressType == null ? null : WorkflowExpression.Compile(bodypartyaddressesaddressType);
            WorkflowExpression.Validate(__workflow_bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            var __workflow_bodypartytags = bodypartytags == null ? null : WorkflowExpression.Compile(bodypartytags);
            WorkflowExpression.Validate(__workflow_bodypartytags, nameof(bodypartytags), required: false);
            return new DeferredBodyAction<UpdateOrganisationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/organisation/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (__workflow_bodypartyname != null)
                {
                    partyObject["name"] = ExpressionConverter.ConvertO(__workflow_bodypartyname);
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartyabout != null)
                {
                    partyObject["about"] = ExpressionConverter.ConvertO(__workflow_bodypartyabout);
                    partyObjectpropCount++;
                }

                var phoneNumbersObject = new JObject();
                var phoneNumbersObjectpropCount = 0;
                if (__workflow_bodypartyphoneNumbersphoneNumber != null)
                {
                    phoneNumbersObject["number"] = ExpressionConverter.ConvertO(__workflow_bodypartyphoneNumbersphoneNumber);
                    phoneNumbersObjectpropCount++;
                }

                if (__workflow_bodypartyphoneNumbersphoneType != null)
                {
                    phoneNumbersObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyphoneNumbersphoneType);
                    phoneNumbersObjectpropCount++;
                }

                if (phoneNumbersObjectpropCount > 0)
                {
                    partyObject["phoneNumbers"] = phoneNumbersObject;
                    partyObjectpropCount++;
                }

                var emailAddressesObject = new JObject();
                var emailAddressesObjectpropCount = 0;
                if (__workflow_bodypartyemailAddressesemailAddress != null)
                {
                    emailAddressesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypartyemailAddressesemailAddress);
                    emailAddressesObjectpropCount++;
                }

                if (__workflow_bodypartyemailAddressesemailType != null)
                {
                    emailAddressesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyemailAddressesemailType);
                    emailAddressesObjectpropCount++;
                }

                if (emailAddressesObjectpropCount > 0)
                {
                    partyObject["emailAddresses"] = emailAddressesObject;
                    partyObjectpropCount++;
                }

                var websitesObject = new JObject();
                var websitesObjectpropCount = 0;
                if (__workflow_bodypartywebsiteswebsiteAddress != null)
                {
                    websitesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteAddress);
                    websitesObjectpropCount++;
                }

                if (__workflow_bodypartywebsiteswebsiteService != null)
                {
                    websitesObject["service"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteService);
                    websitesObjectpropCount++;
                }

                if (__workflow_bodypartywebsiteswebsiteType != null)
                {
                    websitesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartywebsiteswebsiteType);
                    websitesObjectpropCount++;
                }

                if (websitesObjectpropCount > 0)
                {
                    partyObject["websites"] = websitesObject;
                    partyObjectpropCount++;
                }

                var addressesObject = new JObject();
                var addressesObjectpropCount = 0;
                if (__workflow_bodypartyaddressesaddressStreet != null)
                {
                    addressesObject["street"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressStreet);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressCity != null)
                {
                    addressesObject["city"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressCity);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressState != null)
                {
                    addressesObject["state"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressState);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressZip != null)
                {
                    addressesObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressZip);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressCountry != null)
                {
                    addressesObject["country"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressCountry);
                    addressesObjectpropCount++;
                }

                if (__workflow_bodypartyaddressesaddressType != null)
                {
                    addressesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypartyaddressesaddressType);
                    addressesObjectpropCount++;
                }

                if (addressesObjectpropCount > 0)
                {
                    partyObject["addresses"] = addressesObject;
                    partyObjectpropCount++;
                }

                if (__workflow_bodypartytags != null)
                {
                    partyObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodypartytags);
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
            });
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
        public IBodyWorkflowAction<ListpartiesResponse> ListPeople()
        {
            var apiCallPath = "/people/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListpartiesResponse>(callPayload);
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
            var __workflow_personId = personId == null ? null : WorkflowExpression.Compile(personId);
            WorkflowExpression.Validate(__workflow_personId, nameof(personId), required: true);
            return new DeferredBodyAction<GetPartyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_personId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPartyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<string> DeleteParty(Expression<Func<string>> personId)
        {
            var __workflow_personId = personId == null ? null : WorkflowExpression.Compile(personId);
            WorkflowExpression.Validate(__workflow_personId, nameof(personId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_personId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
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
            var __workflow_bodytaskdescription = bodytaskdescription == null ? null : WorkflowExpression.Compile(bodytaskdescription);
            WorkflowExpression.Validate(__workflow_bodytaskdescription, nameof(bodytaskdescription), required: false);
            var __workflow_bodytaskdueDate = bodytaskdueDate == null ? null : WorkflowExpression.Compile(bodytaskdueDate);
            WorkflowExpression.Validate(__workflow_bodytaskdueDate, nameof(bodytaskdueDate), required: false);
            var __workflow_bodytaskdueTime = bodytaskdueTime == null ? null : WorkflowExpression.Compile(bodytaskdueTime);
            WorkflowExpression.Validate(__workflow_bodytaskdueTime, nameof(bodytaskdueTime), required: false);
            var __workflow_bodytaskdetails = bodytaskdetails == null ? null : WorkflowExpression.Compile(bodytaskdetails);
            WorkflowExpression.Validate(__workflow_bodytaskdetails, nameof(bodytaskdetails), required: false);
            var __workflow_bodytaskpartyid = bodytaskpartyid == null ? null : WorkflowExpression.Compile(bodytaskpartyid);
            WorkflowExpression.Validate(__workflow_bodytaskpartyid, nameof(bodytaskpartyid), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var taskObject = new JObject();
                var taskObjectpropCount = 0;
                if (__workflow_bodytaskdescription != null)
                {
                    taskObject["description"] = ExpressionConverter.ConvertO(__workflow_bodytaskdescription);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskdueDate != null)
                {
                    taskObject["dueOn"] = ExpressionConverter.ConvertO(__workflow_bodytaskdueDate);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskdueTime != null)
                {
                    taskObject["dueTime"] = ExpressionConverter.ConvertO(__workflow_bodytaskdueTime);
                    taskObjectpropCount++;
                }

                if (__workflow_bodytaskdetails != null)
                {
                    taskObject["detail"] = ExpressionConverter.ConvertO(__workflow_bodytaskdetails);
                    taskObjectpropCount++;
                }

                var partyObject = new JObject();
                var partyObjectpropCount = 0;
                if (__workflow_bodytaskpartyid != null)
                {
                    partyObject["id"] = ExpressionConverter.ConvertO(__workflow_bodytaskpartyid);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CompleteTaskResponse> CompleteTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = taskId == null ? null : WorkflowExpression.Compile(taskId);
            WorkflowExpression.Validate(__workflow_taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<CompleteTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
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
            });
        }
    }

    public class CapsulecrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OpportunityResponse[]> OnNewOpportunity(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_trigger/opportunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OpportunityResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<OpportunityResponse[]> OnUpdateOpportunity(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/update_trigger/opportunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<OpportunityResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<TaskResponse[]> OnNewTask(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_trigger/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<PartyResponse[]> OnNewParty(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_trigger/parties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PartyResponse[]>(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypartyphoneNumbersphoneTypeInput
    {
        Home,
        Work,
        Mobile,
        Fax,
        Direct
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypartyemailAddressesemailTypeInput
    {
        Home,
        Work
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypartywebsiteswebsiteTypeInput
    {
        Home,
        Work
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
