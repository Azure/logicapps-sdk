//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Capsulecrm
{
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
        [WorkflowExpressionFactory(nameof(__BuildCreateOpportunity))]
        public IBodyWorkflowAction<CreateOpportunityResponse> CreateOpportunity([WorkflowExpression] Func<int> bodyopportunitypartypartyId, [WorkflowExpression] Func<int> bodyopportunitymilestoneid, [WorkflowExpression] Func<string> bodyopportunityname = null, [WorkflowExpression] Func<string> bodyopportunitydescription = null, [WorkflowExpression] Func<bodyopportunitydurationBasisInput> bodyopportunitydurationBasis = null, [WorkflowExpression] Func<string> bodyopportunityduration = null, [WorkflowExpression] Func<string> bodyopportunityexpectedCloseDate = null, [WorkflowExpression] Func<int> bodyopportunitywinningProbability = null, [WorkflowExpression] Func<int> bodyopportunityexpectedamount = null, [WorkflowExpression] Func<string> bodyopportunityexpectedcurrency = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateOpportunityResponse> __BuildCreateOpportunity(WorkflowExpression<int> bodyopportunitypartypartyId, WorkflowExpression<int> bodyopportunitymilestoneid, WorkflowExpression<string> bodyopportunityname = null, WorkflowExpression<string> bodyopportunitydescription = null, WorkflowExpression<bodyopportunitydurationBasisInput> bodyopportunitydurationBasis = null, WorkflowExpression<string> bodyopportunityduration = null, WorkflowExpression<string> bodyopportunityexpectedCloseDate = null, WorkflowExpression<int> bodyopportunitywinningProbability = null, WorkflowExpression<int> bodyopportunityexpectedamount = null, WorkflowExpression<string> bodyopportunityexpectedcurrency = null)
        {
            WorkflowExpression.Validate(bodyopportunitypartypartyId, nameof(bodyopportunitypartypartyId), required: true);
            WorkflowExpression.Validate(bodyopportunitymilestoneid, nameof(bodyopportunitymilestoneid), required: true);
            WorkflowExpression.Validate(bodyopportunityname, nameof(bodyopportunityname), required: false);
            WorkflowExpression.Validate(bodyopportunitydescription, nameof(bodyopportunitydescription), required: false);
            WorkflowExpression.Validate(bodyopportunitydurationBasis, nameof(bodyopportunitydurationBasis), required: false);
            WorkflowExpression.Validate(bodyopportunityduration, nameof(bodyopportunityduration), required: false);
            WorkflowExpression.Validate(bodyopportunityexpectedCloseDate, nameof(bodyopportunityexpectedCloseDate), required: false);
            WorkflowExpression.Validate(bodyopportunitywinningProbability, nameof(bodyopportunitywinningProbability), required: false);
            WorkflowExpression.Validate(bodyopportunityexpectedamount, nameof(bodyopportunityexpectedamount), required: false);
            WorkflowExpression.Validate(bodyopportunityexpectedcurrency, nameof(bodyopportunityexpectedcurrency), required: false);
            return new DeferredBodyAction<CreateOpportunityResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildGetOpportunity))]
        public IBodyWorkflowAction<GetOpportunityResponse> GetOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOpportunityResponse> __BuildGetOpportunity(WorkflowExpression<string> opportunityId)
        {
            WorkflowExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<GetOpportunityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOpportunityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateOpportunity))]
        public IBodyWorkflowAction<UpdateOpportunityResponse> UpdateOpportunity([WorkflowExpression] Func<string> opportunityId, [WorkflowExpression] Func<int> bodyopportunitypartypartyId, [WorkflowExpression] Func<int> bodyopportunitymilestonemilestoneId, [WorkflowExpression] Func<string> bodyopportunityname = null, [WorkflowExpression] Func<string> bodyopportunitydescription = null, [WorkflowExpression] Func<bodyopportunitydurationBasisInput> bodyopportunitydurationBasis = null, [WorkflowExpression] Func<string> bodyopportunityduration = null, [WorkflowExpression] Func<string> bodyopportunityexpectedCloseDate = null, [WorkflowExpression] Func<int> bodyopportunitywinningProbability = null, [WorkflowExpression] Func<int> bodyopportunityexpectedamount = null, [WorkflowExpression] Func<string> bodyopportunityexpectedcurrency = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateOpportunityResponse> __BuildUpdateOpportunity(WorkflowExpression<string> opportunityId, WorkflowExpression<int> bodyopportunitypartypartyId, WorkflowExpression<int> bodyopportunitymilestonemilestoneId, WorkflowExpression<string> bodyopportunityname = null, WorkflowExpression<string> bodyopportunitydescription = null, WorkflowExpression<bodyopportunitydurationBasisInput> bodyopportunitydurationBasis = null, WorkflowExpression<string> bodyopportunityduration = null, WorkflowExpression<string> bodyopportunityexpectedCloseDate = null, WorkflowExpression<int> bodyopportunitywinningProbability = null, WorkflowExpression<int> bodyopportunityexpectedamount = null, WorkflowExpression<string> bodyopportunityexpectedcurrency = null)
        {
            WorkflowExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            WorkflowExpression.Validate(bodyopportunitypartypartyId, nameof(bodyopportunitypartypartyId), required: true);
            WorkflowExpression.Validate(bodyopportunitymilestonemilestoneId, nameof(bodyopportunitymilestonemilestoneId), required: true);
            WorkflowExpression.Validate(bodyopportunityname, nameof(bodyopportunityname), required: false);
            WorkflowExpression.Validate(bodyopportunitydescription, nameof(bodyopportunitydescription), required: false);
            WorkflowExpression.Validate(bodyopportunitydurationBasis, nameof(bodyopportunitydurationBasis), required: false);
            WorkflowExpression.Validate(bodyopportunityduration, nameof(bodyopportunityduration), required: false);
            WorkflowExpression.Validate(bodyopportunityexpectedCloseDate, nameof(bodyopportunityexpectedCloseDate), required: false);
            WorkflowExpression.Validate(bodyopportunitywinningProbability, nameof(bodyopportunitywinningProbability), required: false);
            WorkflowExpression.Validate(bodyopportunityexpectedamount, nameof(bodyopportunityexpectedamount), required: false);
            WorkflowExpression.Validate(bodyopportunityexpectedcurrency, nameof(bodyopportunityexpectedcurrency), required: false);
            return new DeferredBodyAction<UpdateOpportunityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteOpportunity))]
        public IBodyWorkflowAction<string> DeleteOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteOpportunity(WorkflowExpression<string> opportunityId)
        {
            WorkflowExpression.Validate(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/opportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePerson))]
        public IBodyWorkflowAction<CreatePersonResponse> CreatePerson([WorkflowExpression] Func<string> bodypartylastName = null, [WorkflowExpression] Func<string> bodypartyfirstName = null, [WorkflowExpression] Func<bodypartytitleInput> bodypartytitle = null, [WorkflowExpression] Func<string> bodypartyjobTitle = null, [WorkflowExpression] Func<string> bodypartyabout = null, [WorkflowExpression] Func<string> bodypartyorganisationId = null, [WorkflowExpression] Func<string> bodypartyphoneNumbersphoneNumber = null, [WorkflowExpression] Func<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, [WorkflowExpression] Func<string> bodypartyemailAddressesemailAddress = null, [WorkflowExpression] Func<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, [WorkflowExpression] Func<string> bodypartywebsiteswebsiteAddress = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressStreet = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCity = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressState = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressZip = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCountry = null, [WorkflowExpression] Func<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, [WorkflowExpression] Func<string> bodypartytags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePersonResponse> __BuildCreatePerson(WorkflowExpression<string> bodypartylastName = null, WorkflowExpression<string> bodypartyfirstName = null, WorkflowExpression<bodypartytitleInput> bodypartytitle = null, WorkflowExpression<string> bodypartyjobTitle = null, WorkflowExpression<string> bodypartyabout = null, WorkflowExpression<string> bodypartyorganisationId = null, WorkflowExpression<string> bodypartyphoneNumbersphoneNumber = null, WorkflowExpression<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, WorkflowExpression<string> bodypartyemailAddressesemailAddress = null, WorkflowExpression<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, WorkflowExpression<string> bodypartywebsiteswebsiteAddress = null, WorkflowExpression<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, WorkflowExpression<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, WorkflowExpression<string> bodypartyaddressesaddressStreet = null, WorkflowExpression<string> bodypartyaddressesaddressCity = null, WorkflowExpression<string> bodypartyaddressesaddressState = null, WorkflowExpression<string> bodypartyaddressesaddressZip = null, WorkflowExpression<string> bodypartyaddressesaddressCountry = null, WorkflowExpression<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, WorkflowExpression<string> bodypartytags = null)
        {
            WorkflowExpression.Validate(bodypartylastName, nameof(bodypartylastName), required: false);
            WorkflowExpression.Validate(bodypartyfirstName, nameof(bodypartyfirstName), required: false);
            WorkflowExpression.Validate(bodypartytitle, nameof(bodypartytitle), required: false);
            WorkflowExpression.Validate(bodypartyjobTitle, nameof(bodypartyjobTitle), required: false);
            WorkflowExpression.Validate(bodypartyabout, nameof(bodypartyabout), required: false);
            WorkflowExpression.Validate(bodypartyorganisationId, nameof(bodypartyorganisationId), required: false);
            WorkflowExpression.Validate(bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            WorkflowExpression.Validate(bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            WorkflowExpression.Validate(bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            WorkflowExpression.Validate(bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            WorkflowExpression.Validate(bodypartytags, nameof(bodypartytags), required: false);
            return new DeferredBodyAction<CreatePersonResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatePerson))]
        public IBodyWorkflowAction<UpdatePersonResponse> UpdatePerson([WorkflowExpression] Func<string> personId, [WorkflowExpression] Func<string> bodypartylastName = null, [WorkflowExpression] Func<string> bodypartyfirstName = null, [WorkflowExpression] Func<bodypartytitleInput> bodypartytitle = null, [WorkflowExpression] Func<string> bodypartyjobTitle = null, [WorkflowExpression] Func<string> bodypartyabout = null, [WorkflowExpression] Func<string> bodypartyorganisationId = null, [WorkflowExpression] Func<string> bodypartyphoneNumbersphoneNumber = null, [WorkflowExpression] Func<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, [WorkflowExpression] Func<string> bodypartyemailAddressesemailAddress = null, [WorkflowExpression] Func<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, [WorkflowExpression] Func<string> bodypartywebsiteswebsiteAddress = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressStreet = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCity = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressState = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressZip = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCountry = null, [WorkflowExpression] Func<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, [WorkflowExpression] Func<string> bodypartytags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdatePersonResponse> __BuildUpdatePerson(WorkflowExpression<string> personId, WorkflowExpression<string> bodypartylastName = null, WorkflowExpression<string> bodypartyfirstName = null, WorkflowExpression<bodypartytitleInput> bodypartytitle = null, WorkflowExpression<string> bodypartyjobTitle = null, WorkflowExpression<string> bodypartyabout = null, WorkflowExpression<string> bodypartyorganisationId = null, WorkflowExpression<string> bodypartyphoneNumbersphoneNumber = null, WorkflowExpression<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, WorkflowExpression<string> bodypartyemailAddressesemailAddress = null, WorkflowExpression<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, WorkflowExpression<string> bodypartywebsiteswebsiteAddress = null, WorkflowExpression<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, WorkflowExpression<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, WorkflowExpression<string> bodypartyaddressesaddressStreet = null, WorkflowExpression<string> bodypartyaddressesaddressCity = null, WorkflowExpression<string> bodypartyaddressesaddressState = null, WorkflowExpression<string> bodypartyaddressesaddressZip = null, WorkflowExpression<string> bodypartyaddressesaddressCountry = null, WorkflowExpression<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, WorkflowExpression<string> bodypartytags = null)
        {
            WorkflowExpression.Validate(personId, nameof(personId), required: true);
            WorkflowExpression.Validate(bodypartylastName, nameof(bodypartylastName), required: false);
            WorkflowExpression.Validate(bodypartyfirstName, nameof(bodypartyfirstName), required: false);
            WorkflowExpression.Validate(bodypartytitle, nameof(bodypartytitle), required: false);
            WorkflowExpression.Validate(bodypartyjobTitle, nameof(bodypartyjobTitle), required: false);
            WorkflowExpression.Validate(bodypartyabout, nameof(bodypartyabout), required: false);
            WorkflowExpression.Validate(bodypartyorganisationId, nameof(bodypartyorganisationId), required: false);
            WorkflowExpression.Validate(bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            WorkflowExpression.Validate(bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            WorkflowExpression.Validate(bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            WorkflowExpression.Validate(bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            WorkflowExpression.Validate(bodypartytags, nameof(bodypartytags), required: false);
            return new DeferredBodyAction<UpdatePersonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/person/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOrganisation))]
        public IBodyWorkflowAction<CreateOrganisationResponse> CreateOrganisation([WorkflowExpression] Func<string> bodypartyname = null, [WorkflowExpression] Func<string> bodypartyabout = null, [WorkflowExpression] Func<string> bodypartyphoneNumbersphoneNumber = null, [WorkflowExpression] Func<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, [WorkflowExpression] Func<string> bodypartyemailAddressesemailAddress = null, [WorkflowExpression] Func<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, [WorkflowExpression] Func<string> bodypartywebsiteswebsiteAddress = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressStreet = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCity = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressState = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressZip = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCountry = null, [WorkflowExpression] Func<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, [WorkflowExpression] Func<string> bodypartytags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateOrganisationResponse> __BuildCreateOrganisation(WorkflowExpression<string> bodypartyname = null, WorkflowExpression<string> bodypartyabout = null, WorkflowExpression<string> bodypartyphoneNumbersphoneNumber = null, WorkflowExpression<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, WorkflowExpression<string> bodypartyemailAddressesemailAddress = null, WorkflowExpression<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, WorkflowExpression<string> bodypartywebsiteswebsiteAddress = null, WorkflowExpression<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, WorkflowExpression<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, WorkflowExpression<string> bodypartyaddressesaddressStreet = null, WorkflowExpression<string> bodypartyaddressesaddressCity = null, WorkflowExpression<string> bodypartyaddressesaddressState = null, WorkflowExpression<string> bodypartyaddressesaddressZip = null, WorkflowExpression<string> bodypartyaddressesaddressCountry = null, WorkflowExpression<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, WorkflowExpression<string> bodypartytags = null)
        {
            WorkflowExpression.Validate(bodypartyname, nameof(bodypartyname), required: false);
            WorkflowExpression.Validate(bodypartyabout, nameof(bodypartyabout), required: false);
            WorkflowExpression.Validate(bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            WorkflowExpression.Validate(bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            WorkflowExpression.Validate(bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            WorkflowExpression.Validate(bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            WorkflowExpression.Validate(bodypartytags, nameof(bodypartytags), required: false);
            return new DeferredBodyAction<CreateOrganisationResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateOrganisation))]
        public IBodyWorkflowAction<UpdateOrganisationResponse> UpdateOrganisation([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodypartyname = null, [WorkflowExpression] Func<string> bodypartyabout = null, [WorkflowExpression] Func<string> bodypartyphoneNumbersphoneNumber = null, [WorkflowExpression] Func<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, [WorkflowExpression] Func<string> bodypartyemailAddressesemailAddress = null, [WorkflowExpression] Func<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, [WorkflowExpression] Func<string> bodypartywebsiteswebsiteAddress = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, [WorkflowExpression] Func<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressStreet = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCity = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressState = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressZip = null, [WorkflowExpression] Func<string> bodypartyaddressesaddressCountry = null, [WorkflowExpression] Func<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, [WorkflowExpression] Func<string> bodypartytags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateOrganisationResponse> __BuildUpdateOrganisation(WorkflowExpression<string> id, WorkflowExpression<string> bodypartyname = null, WorkflowExpression<string> bodypartyabout = null, WorkflowExpression<string> bodypartyphoneNumbersphoneNumber = null, WorkflowExpression<bodypartyphoneNumbersphoneTypeInput> bodypartyphoneNumbersphoneType = null, WorkflowExpression<string> bodypartyemailAddressesemailAddress = null, WorkflowExpression<bodypartyemailAddressesemailTypeInput> bodypartyemailAddressesemailType = null, WorkflowExpression<string> bodypartywebsiteswebsiteAddress = null, WorkflowExpression<bodypartywebsiteswebsiteServiceInput> bodypartywebsiteswebsiteService = null, WorkflowExpression<bodypartywebsiteswebsiteTypeInput> bodypartywebsiteswebsiteType = null, WorkflowExpression<string> bodypartyaddressesaddressStreet = null, WorkflowExpression<string> bodypartyaddressesaddressCity = null, WorkflowExpression<string> bodypartyaddressesaddressState = null, WorkflowExpression<string> bodypartyaddressesaddressZip = null, WorkflowExpression<string> bodypartyaddressesaddressCountry = null, WorkflowExpression<bodypartyaddressesaddressTypeInput> bodypartyaddressesaddressType = null, WorkflowExpression<string> bodypartytags = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodypartyname, nameof(bodypartyname), required: false);
            WorkflowExpression.Validate(bodypartyabout, nameof(bodypartyabout), required: false);
            WorkflowExpression.Validate(bodypartyphoneNumbersphoneNumber, nameof(bodypartyphoneNumbersphoneNumber), required: false);
            WorkflowExpression.Validate(bodypartyphoneNumbersphoneType, nameof(bodypartyphoneNumbersphoneType), required: false);
            WorkflowExpression.Validate(bodypartyemailAddressesemailAddress, nameof(bodypartyemailAddressesemailAddress), required: false);
            WorkflowExpression.Validate(bodypartyemailAddressesemailType, nameof(bodypartyemailAddressesemailType), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteAddress, nameof(bodypartywebsiteswebsiteAddress), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteService, nameof(bodypartywebsiteswebsiteService), required: false);
            WorkflowExpression.Validate(bodypartywebsiteswebsiteType, nameof(bodypartywebsiteswebsiteType), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressStreet, nameof(bodypartyaddressesaddressStreet), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressCity, nameof(bodypartyaddressesaddressCity), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressState, nameof(bodypartyaddressesaddressState), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressZip, nameof(bodypartyaddressesaddressZip), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressCountry, nameof(bodypartyaddressesaddressCountry), required: false);
            WorkflowExpression.Validate(bodypartyaddressesaddressType, nameof(bodypartyaddressesaddressType), required: false);
            WorkflowExpression.Validate(bodypartytags, nameof(bodypartytags), required: false);
            return new DeferredBodyAction<UpdateOrganisationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/organisation/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildGetParty))]
        public IBodyWorkflowAction<GetPartyResponse> GetParty([WorkflowExpression] Func<string> personId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPartyResponse> __BuildGetParty(WorkflowExpression<string> personId)
        {
            WorkflowExpression.Validate(personId, nameof(personId), required: true);
            return new DeferredBodyAction<GetPartyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPartyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteParty))]
        public IBodyWorkflowAction<string> DeleteParty([WorkflowExpression] Func<string> personId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteParty(WorkflowExpression<string> personId)
        {
            WorkflowExpression.Validate(personId, nameof(personId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parties/{0}", ExpressionConverter.ConvertWithUrlEncoding(personId, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> bodytaskdescription = null, [WorkflowExpression] Func<string> bodytaskdueDate = null, [WorkflowExpression] Func<string> bodytaskdueTime = null, [WorkflowExpression] Func<string> bodytaskdetails = null, [WorkflowExpression] Func<int> bodytaskpartyid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskResponse> __BuildCreateTask(WorkflowExpression<string> bodytaskdescription = null, WorkflowExpression<string> bodytaskdueDate = null, WorkflowExpression<string> bodytaskdueTime = null, WorkflowExpression<string> bodytaskdetails = null, WorkflowExpression<int> bodytaskpartyid = null)
        {
            WorkflowExpression.Validate(bodytaskdescription, nameof(bodytaskdescription), required: false);
            WorkflowExpression.Validate(bodytaskdueDate, nameof(bodytaskdueDate), required: false);
            WorkflowExpression.Validate(bodytaskdueTime, nameof(bodytaskdueTime), required: false);
            WorkflowExpression.Validate(bodytaskdetails, nameof(bodytaskdetails), required: false);
            WorkflowExpression.Validate(bodytaskpartyid, nameof(bodytaskpartyid), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteTask))]
        public IBodyWorkflowAction<CompleteTaskResponse> CompleteTask([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompleteTaskResponse> __BuildCompleteTask(WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<CompleteTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
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