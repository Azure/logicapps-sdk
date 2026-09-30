//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Impexium
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImpexiumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAbandonedCheckoutsResponse> GetAbandonedCheckouts([WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> abandonedFrom, [WorkflowExpression] Func<string> productCode = null, [WorkflowExpression] Func<string> customerRecordNumber = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(abandonedFrom, nameof(abandonedFrom), required: true);
            SourceExpression.Validate(productCode, nameof(productCode), required: false);
            SourceExpression.Validate(customerRecordNumber, nameof(customerRecordNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Shopping/AbandonedCheckOuts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["abandonedFrom"] = SourceExpressionConverter.ConvertO(abandonedFrom);
                if (productCode != null)
                    callPayload.Queries["productCode"] = SourceExpressionConverter.ConvertO(productCode);
                if (customerRecordNumber != null)
                    callPayload.Queries["customerRecordNumber"] = SourceExpressionConverter.ConvertO(customerRecordNumber);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetAbandonedCheckoutsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllExhibitorsResponse> ListAllExhibitors([WorkflowExpression] Func<string> exhibitCode, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(exhibitCode, nameof(exhibitCode), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Exhibits/{0}/Exhibitors/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(exhibitCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListAllExhibitorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfExamsResponse> ListOfExams([WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> categoryName = null, [WorkflowExpression] Func<bool> isPublic = null, [WorkflowExpression] Func<string> changedSince = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<bool> includePrices = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(code, nameof(code), required: false);
            SourceExpression.Validate(categoryName, nameof(categoryName), required: false);
            SourceExpression.Validate(isPublic, nameof(isPublic), required: false);
            SourceExpression.Validate(changedSince, nameof(changedSince), required: false);
            SourceExpression.Validate(tag, nameof(tag), required: false);
            SourceExpression.Validate(includePrices, nameof(includePrices), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Products/Exams/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (code != null)
                    callPayload.Queries["Code"] = SourceExpressionConverter.ConvertO(code);
                if (categoryName != null)
                    callPayload.Queries["categoryName"] = SourceExpressionConverter.ConvertO(categoryName);
                if (isPublic != null)
                    callPayload.Queries["isPublic"] = SourceExpressionConverter.ConvertO(isPublic);
                if (changedSince != null)
                    callPayload.Queries["changedSince"] = SourceExpressionConverter.ConvertO(changedSince);
                if (tag != null)
                    callPayload.Queries["Tag"] = SourceExpressionConverter.ConvertO(tag);
                if (includePrices != null)
                    callPayload.Queries["includePrices"] = SourceExpressionConverter.ConvertO(includePrices);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListOfExamsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListRegistrantsResponse> ListRegistrants([WorkflowExpression] Func<string> eventCode, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> sessionCode = null, [WorkflowExpression] Func<bool> includeDetails = null, [WorkflowExpression] Func<string> registeredSince = null)
        {
            SourceExpression.Validate(eventCode, nameof(eventCode), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(sessionCode, nameof(sessionCode), required: false);
            SourceExpression.Validate(includeDetails, nameof(includeDetails), required: false);
            SourceExpression.Validate(registeredSince, nameof(registeredSince), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Events/{0}/Registrations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionCode != null)
                    callPayload.Queries["sessionCode"] = SourceExpressionConverter.ConvertO(sessionCode);
                if (includeDetails != null)
                    callPayload.Queries["includeDetails"] = SourceExpressionConverter.ConvertO(includeDetails);
                if (registeredSince != null)
                    callPayload.Queries["registeredSince"] = SourceExpressionConverter.ConvertO(registeredSince);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListRegistrantsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetCourseAttendeesResponse> GetCourseAttendees([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Courses/{0}/Attendees/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(code, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCourseAttendeesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ExamScoreResultData[]> AddExamScores([WorkflowExpression] Func<string> examCode, [WorkflowExpression] Func<ExamScoreData[]> scores = null)
        {
            SourceExpression.Validate(examCode, nameof(examCode), required: true);
            SourceExpression.Validate(scores, nameof(scores), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Exams/{0}/Scores", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(examCode, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(scores);
                return callPayload;
            }

            return new ApiConnectionAction<ExamScoreResultData[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersByNameResponse> FindMembersByName([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Customers/Members/FindByName/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<FindMembersByNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetPurchasesForAnIndividualResponse> GetPurchasesForAnIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> productCode = null, [WorkflowExpression] Func<string> purchasedSince = null, [WorkflowExpression] Func<string> productCategoryCode = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(productCode, nameof(productCode), required: false);
            SourceExpression.Validate(purchasedSince, nameof(purchasedSince), required: false);
            SourceExpression.Validate(productCategoryCode, nameof(productCategoryCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Purchases/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (productCode != null)
                    callPayload.Queries["productCode"] = SourceExpressionConverter.ConvertO(productCode);
                if (purchasedSince != null)
                    callPayload.Queries["purchasedSince"] = SourceExpressionConverter.ConvertO(purchasedSince);
                if (productCategoryCode != null)
                    callPayload.Queries["productCategoryCode"] = SourceExpressionConverter.ConvertO(productCategoryCode);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetPurchasesForAnIndividualResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldResultData[]> AddOrUpdateAListOfCustomFieldsPerOrganization([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<CustomFieldValueData[]> body = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/CustomFieldsList", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<CustomFieldResultData[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddNominee([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<string> bodynomineeRecordNumber = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodypositionCode = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyrepresentingOrganizationRecordNumber = null, [WorkflowExpression] Func<string> bodyrepresentingOrganizationRelationshipName = null, [WorkflowExpression] Func<string> bodynominatedByCustomerRecordNumber = null, [WorkflowExpression] Func<int> bodycommitteeTerm = null, [WorkflowExpression] Func<int> bodyrank = null)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            SourceExpression.Validate(bodynomineeRecordNumber, nameof(bodynomineeRecordNumber), required: false);
            SourceExpression.Validate(bodycode, nameof(bodycode), required: false);
            SourceExpression.Validate(bodypositionCode, nameof(bodypositionCode), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyrepresentingOrganizationRecordNumber, nameof(bodyrepresentingOrganizationRecordNumber), required: false);
            SourceExpression.Validate(bodyrepresentingOrganizationRelationshipName, nameof(bodyrepresentingOrganizationRelationshipName), required: false);
            SourceExpression.Validate(bodynominatedByCustomerRecordNumber, nameof(bodynominatedByCustomerRecordNumber), required: false);
            SourceExpression.Validate(bodycommitteeTerm, nameof(bodycommitteeTerm), required: false);
            SourceExpression.Validate(bodyrank, nameof(bodyrank), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Committees/{0}/Nominations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(code, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodynomineeRecordNumber != null)
                {
                    body["nomineeRecordNumber"] = SourceExpressionConverter.ConvertToken(bodynomineeRecordNumber);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodypositionCode != null)
                {
                    body["positionCode"] = SourceExpressionConverter.ConvertToken(bodypositionCode);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyrepresentingOrganizationRecordNumber != null)
                {
                    body["representingOrganizationRecordNumber"] = SourceExpressionConverter.ConvertToken(bodyrepresentingOrganizationRecordNumber);
                    bodypropCount++;
                }

                if (bodyrepresentingOrganizationRelationshipName != null)
                {
                    body["representingOrganizationRelationshipName"] = SourceExpressionConverter.ConvertToken(bodyrepresentingOrganizationRelationshipName);
                    bodypropCount++;
                }

                if (bodynominatedByCustomerRecordNumber != null)
                {
                    body["nominatedByCustomerRecordNumber"] = SourceExpressionConverter.ConvertToken(bodynominatedByCustomerRecordNumber);
                    bodypropCount++;
                }

                if (bodycommitteeTerm != null)
                {
                    body["committeeTerm"] = SourceExpressionConverter.ConvertToken(bodycommitteeTerm);
                    bodypropCount++;
                }

                if (bodyrank != null)
                {
                    body["rank"] = SourceExpressionConverter.ConvertToken(bodyrank);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldData[]> GetIndividualCustomFieldValues([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/CustomFields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CustomFieldData[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction UpdateCustomFieldValue([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycaption = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycaption, nameof(bodycaption), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/CustomFields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycaption != null)
                {
                    body["caption"] = SourceExpressionConverter.ConvertToken(bodycaption);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllEventCancellationsByEventResponse> ListAllEventCancellationsByEvent([WorkflowExpression] Func<string> eventCode, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<bool> includeDetails = null, [WorkflowExpression] Func<string> cancelledSince = null)
        {
            SourceExpression.Validate(eventCode, nameof(eventCode), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(includeDetails, nameof(includeDetails), required: false);
            SourceExpression.Validate(cancelledSince, nameof(cancelledSince), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Events/{0}/Cancellations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeDetails != null)
                    callPayload.Queries["includeDetails"] = SourceExpressionConverter.ConvertO(includeDetails);
                if (cancelledSince != null)
                    callPayload.Queries["cancelledSince"] = SourceExpressionConverter.ConvertO(cancelledSince);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListAllEventCancellationsByEventResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllOpenOrdersForAnIndividualResponse> GetAllOpenOrdersForAnIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<bool> includeLineItems = null, [WorkflowExpression] Func<string> fromDate = null, [WorkflowExpression] Func<string> toDate = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(includeLineItems, nameof(includeLineItems), required: false);
            SourceExpression.Validate(fromDate, nameof(fromDate), required: false);
            SourceExpression.Validate(toDate, nameof(toDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Orders/Open/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeLineItems != null)
                    callPayload.Queries["includeLineItems"] = SourceExpressionConverter.ConvertO(includeLineItems);
                if (fromDate != null)
                    callPayload.Queries["fromDate"] = SourceExpressionConverter.ConvertO(fromDate);
                if (toDate != null)
                    callPayload.Queries["toDate"] = SourceExpressionConverter.ConvertO(toDate);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetAllOpenOrdersForAnIndividualResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListCompletedUserTasksByUserIdOrEmailResponse> ListCompletedUserTasksByUserIdOrEmail([WorkflowExpression] Func<string> userIdOrEmail, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(userIdOrEmail, nameof(userIdOrEmail), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/tasks/Users/{0}/Completed/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userIdOrEmail, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListCompletedUserTasksByUserIdOrEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListPendingUserTasksByUserIdOrEmailResponse> ListPendingUserTasksByUserIdOrEmail([WorkflowExpression] Func<string> userIdOrEmail, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(userIdOrEmail, nameof(userIdOrEmail), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/tasks/Users/{0}/Pending/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userIdOrEmail, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListPendingUserTasksByUserIdOrEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddNoteToSalesOpportunity([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<bool> bodyisInternal = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodyisInternal, nameof(bodyisInternal), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Sales/Opportunities/{0}/Notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["Content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["Category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyisInternal != null)
                {
                    body["isInternal"] = SourceExpressionConverter.ConvertToken(bodyisInternal);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddActivityToSalesOpportunity([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodyactivityDate = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            SourceExpression.Validate(bodyactivityDate, nameof(bodyactivityDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Sales/Opportunities/{0}/Activities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodyactivityDate != null)
                {
                    body["activityDate"] = SourceExpressionConverter.ConvertToken(bodyactivityDate);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<TaskData> UpdateTaskByTaskNumber([WorkflowExpression] Func<string> taskNumber, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null)
        {
            SourceExpression.Validate(taskNumber, nameof(taskNumber), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllCountriesResponse> ListAllCountries([WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Countries/All/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListAllCountriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllStatesByCountryResponse> GetAllStatesByCountry([WorkflowExpression] Func<string> countryId, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(countryId, nameof(countryId), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Countries/{0}/States/All/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(countryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetAllStatesByCountryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllExhibitsResponse> ListAllExhibits([WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Exhibits/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListAllExhibitsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteACategoryForAnOrganization([WorkflowExpression] Func<string> recordNumber, [WorkflowExpression] Func<string> categoryCode)
        {
            SourceExpression.Validate(recordNumber, nameof(recordNumber), required: true);
            SourceExpression.Validate(categoryCode, nameof(categoryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Categories/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(categoryCode, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddCustomerRequest([WorkflowExpression] Func<string> bodyrequestedByCustomerRecordNumber = null, [WorkflowExpression] Func<string> bodyrequestType = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodysourceInput> bodysource = null)
        {
            SourceExpression.Validate(bodyrequestedByCustomerRecordNumber, nameof(bodyrequestedByCustomerRecordNumber), required: false);
            SourceExpression.Validate(bodyrequestType, nameof(bodyrequestType), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Requests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequestedByCustomerRecordNumber != null)
                {
                    body["requestedByCustomerRecordNumber"] = SourceExpressionConverter.ConvertToken(bodyrequestedByCustomerRecordNumber);
                    bodypropCount++;
                }

                if (bodyrequestType != null)
                {
                    body["requestType"] = SourceExpressionConverter.ConvertToken(bodyrequestType);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.Convert(bodysource);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<RequestUpdateData> UpdateCustomerRequest([WorkflowExpression] Func<string> bodyrequestNumber = null, [WorkflowExpression] Func<string> bodyclosedDate = null)
        {
            SourceExpression.Validate(bodyrequestNumber, nameof(bodyrequestNumber), required: false);
            SourceExpression.Validate(bodyclosedDate, nameof(bodyclosedDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Requests";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequestNumber != null)
                {
                    body["requestNumber"] = SourceExpressionConverter.ConvertToken(bodyrequestNumber);
                    bodypropCount++;
                }

                if (bodyclosedDate != null)
                {
                    body["closedDate"] = SourceExpressionConverter.ConvertToken(bodyclosedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RequestUpdateData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddCategoriesForAnOrganization([WorkflowExpression] Func<string> recordNumber, [WorkflowExpression] Func<SaveCategoryBasicData[]> body = null)
        {
            SourceExpression.Validate(recordNumber, nameof(recordNumber), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Categories", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfCustomerRelationshipsResponse> ListOfCustomerRelationships([WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Customers/RelationshipTypes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListOfCustomerRelationshipsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllOpenCustomerRequestResponse> ListAllOpenCustomerRequest([WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Requests/Open/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListAllOpenCustomerRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData> GetOrganizationInactiveMemberships([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Memberships/Inactive", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<MembershipData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteRecordFromCustomDataTable([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/CustomData/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<UserTaskData> UpdateUserTaskProgressOrMarkAsCompleted([WorkflowExpression] Func<string> userIdOrEmail, [WorkflowExpression] Func<string> bodytaskNumber = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyassignedBy = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyprogress = null, [WorkflowExpression] Func<string> bodycompletedDate = null)
        {
            SourceExpression.Validate(userIdOrEmail, nameof(userIdOrEmail), required: true);
            SourceExpression.Validate(bodytaskNumber, nameof(bodytaskNumber), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyassignedBy, nameof(bodyassignedBy), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodyprogress, nameof(bodyprogress), required: false);
            SourceExpression.Validate(bodycompletedDate, nameof(bodycompletedDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/tasks/Users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userIdOrEmail, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskNumber != null)
                {
                    body["taskNumber"] = SourceExpressionConverter.ConvertToken(bodytaskNumber);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyassignedBy != null)
                {
                    body["assignedBy"] = SourceExpressionConverter.ConvertToken(bodyassignedBy);
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

                if (bodyprogress != null)
                {
                    body["progress"] = SourceExpressionConverter.ConvertToken(bodyprogress);
                    bodypropCount++;
                }

                if (bodycompletedDate != null)
                {
                    body["completedDate"] = SourceExpressionConverter.ConvertToken(bodycompletedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserTaskData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData> FindMembersOrIndividualsByFirstName([WorkflowExpression] Func<string> firstName, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<bool> includeEmail = null)
        {
            SourceExpression.Validate(firstName, nameof(firstName), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(includeEmail, nameof(includeEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/Members/FindByFirstName/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(firstName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeEmail != null)
                    callPayload.Queries["includeEmail"] = SourceExpressionConverter.ConvertO(includeEmail);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<IndividualData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData> FindMembersOrIndividualsByLastName([WorkflowExpression] Func<string> lastName, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<bool> includeEmail = null)
        {
            SourceExpression.Validate(lastName, nameof(lastName), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(includeEmail, nameof(includeEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/Members/FindByLastName/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lastName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeEmail != null)
                    callPayload.Queries["includeEmail"] = SourceExpressionConverter.ConvertO(includeEmail);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<IndividualData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AssignTaskToAUser([WorkflowExpression] Func<string> userIdOrEmail, [WorkflowExpression] Func<string> bodytaskNumber = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyassignedBy = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyprogress = null, [WorkflowExpression] Func<string> bodycompletedDate = null)
        {
            SourceExpression.Validate(userIdOrEmail, nameof(userIdOrEmail), required: true);
            SourceExpression.Validate(bodytaskNumber, nameof(bodytaskNumber), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyassignedBy, nameof(bodyassignedBy), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodyprogress, nameof(bodyprogress), required: false);
            SourceExpression.Validate(bodycompletedDate, nameof(bodycompletedDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/tasks/Users/{0}/Task", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userIdOrEmail, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskNumber != null)
                {
                    body["taskNumber"] = SourceExpressionConverter.ConvertToken(bodytaskNumber);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyassignedBy != null)
                {
                    body["assignedBy"] = SourceExpressionConverter.ConvertToken(bodyassignedBy);
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

                if (bodyprogress != null)
                {
                    body["progress"] = SourceExpressionConverter.ConvertToken(bodyprogress);
                    bodypropCount++;
                }

                if (bodycompletedDate != null)
                {
                    body["completedDate"] = SourceExpressionConverter.ConvertToken(bodycompletedDate);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteACategoryForAnIndividual([WorkflowExpression] Func<string> recordNumber, [WorkflowExpression] Func<string> categoryCode)
        {
            SourceExpression.Validate(recordNumber, nameof(recordNumber), required: true);
            SourceExpression.Validate(categoryCode, nameof(categoryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Categories/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(categoryCode, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddNotificationToIndividual([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bool> bodyisRead = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodyisRead, nameof(bodyisRead), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Notifications", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyisRead != null)
                {
                    body["isRead"] = SourceExpressionConverter.ConvertToken(bodyisRead);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddCategoriesForAnIndividual([WorkflowExpression] Func<string> recordNumber, [WorkflowExpression] Func<SaveCategoryBasicData[]> body = null)
        {
            SourceExpression.Validate(recordNumber, nameof(recordNumber), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Categories", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<TaskData> AddANewTask([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodydueDate = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfAllOrganizationMembersResponse> ListOfAllOrganizationMembers([WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> zipCode = null, [WorkflowExpression] Func<double> radius = null, [WorkflowExpression] Func<string> stateAbbreviation = null, [WorkflowExpression] Func<double> congressionalDistrict = null, [WorkflowExpression] Func<string> membershipTypeCode = null, [WorkflowExpression] Func<string> membershipTypeCategory = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<double> latitude = null, [WorkflowExpression] Func<double> longitude = null, [WorkflowExpression] Func<string> domain = null, [WorkflowExpression] Func<bool> includeMembership = null, [WorkflowExpression] Func<bool> includeAddress = null, [WorkflowExpression] Func<bool> includePhone = null, [WorkflowExpression] Func<bool> includeEmail = null, [WorkflowExpression] Func<bool> includeCustomFields = null, [WorkflowExpression] Func<string> expiringFrom = null, [WorkflowExpression] Func<string> expiringTo = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(zipCode, nameof(zipCode), required: false);
            SourceExpression.Validate(radius, nameof(radius), required: false);
            SourceExpression.Validate(stateAbbreviation, nameof(stateAbbreviation), required: false);
            SourceExpression.Validate(congressionalDistrict, nameof(congressionalDistrict), required: false);
            SourceExpression.Validate(membershipTypeCode, nameof(membershipTypeCode), required: false);
            SourceExpression.Validate(membershipTypeCategory, nameof(membershipTypeCategory), required: false);
            SourceExpression.Validate(city, nameof(city), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(tag, nameof(tag), required: false);
            SourceExpression.Validate(latitude, nameof(latitude), required: false);
            SourceExpression.Validate(longitude, nameof(longitude), required: false);
            SourceExpression.Validate(domain, nameof(domain), required: false);
            SourceExpression.Validate(includeMembership, nameof(includeMembership), required: false);
            SourceExpression.Validate(includeAddress, nameof(includeAddress), required: false);
            SourceExpression.Validate(includePhone, nameof(includePhone), required: false);
            SourceExpression.Validate(includeEmail, nameof(includeEmail), required: false);
            SourceExpression.Validate(includeCustomFields, nameof(includeCustomFields), required: false);
            SourceExpression.Validate(expiringFrom, nameof(expiringFrom), required: false);
            SourceExpression.Validate(expiringTo, nameof(expiringTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/Members/All/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zipCode != null)
                    callPayload.Queries["zipCode"] = SourceExpressionConverter.ConvertO(zipCode);
                callPayload.Queries["Radius"] = Convert.ToString(5);
                if (radius != null)
                    callPayload.Queries["Radius"] = SourceExpressionConverter.ConvertO(radius);
                if (stateAbbreviation != null)
                    callPayload.Queries["stateAbbreviation"] = SourceExpressionConverter.ConvertO(stateAbbreviation);
                callPayload.Queries["congressionalDistrict"] = Convert.ToString(-1);
                if (congressionalDistrict != null)
                    callPayload.Queries["congressionalDistrict"] = SourceExpressionConverter.ConvertO(congressionalDistrict);
                if (membershipTypeCode != null)
                    callPayload.Queries["membershipTypeCode"] = SourceExpressionConverter.ConvertO(membershipTypeCode);
                if (membershipTypeCategory != null)
                    callPayload.Queries["membershipTypeCategory"] = SourceExpressionConverter.ConvertO(membershipTypeCategory);
                if (city != null)
                    callPayload.Queries["City"] = SourceExpressionConverter.ConvertO(city);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (tag != null)
                    callPayload.Queries["Tag"] = SourceExpressionConverter.ConvertO(tag);
                if (latitude != null)
                    callPayload.Queries["Latitude"] = SourceExpressionConverter.ConvertO(latitude);
                if (longitude != null)
                    callPayload.Queries["Longitude"] = SourceExpressionConverter.ConvertO(longitude);
                if (domain != null)
                    callPayload.Queries["Domain"] = SourceExpressionConverter.ConvertO(domain);
                if (includeMembership != null)
                    callPayload.Queries["includeMembership"] = SourceExpressionConverter.ConvertO(includeMembership);
                if (includeAddress != null)
                    callPayload.Queries["includeAddress"] = SourceExpressionConverter.ConvertO(includeAddress);
                if (includePhone != null)
                    callPayload.Queries["includePhone"] = SourceExpressionConverter.ConvertO(includePhone);
                if (includeEmail != null)
                    callPayload.Queries["includeEmail"] = SourceExpressionConverter.ConvertO(includeEmail);
                if (includeCustomFields != null)
                    callPayload.Queries["includeCustomFields"] = SourceExpressionConverter.ConvertO(includeCustomFields);
                if (expiringFrom != null)
                    callPayload.Queries["expiringFrom"] = SourceExpressionConverter.ConvertO(expiringFrom);
                if (expiringTo != null)
                    callPayload.Queries["expiringTo"] = SourceExpressionConverter.ConvertO(expiringTo);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListOfAllOrganizationMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfAllIndividualMembersResponse> ListOfAllIndividualMembers([WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> zipCode = null, [WorkflowExpression] Func<double> radius = null, [WorkflowExpression] Func<string> membershipTypeCode = null, [WorkflowExpression] Func<string> membershipTypeCategory = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<bool> includeMembership = null, [WorkflowExpression] Func<bool> includeAddress = null, [WorkflowExpression] Func<bool> includePhone = null, [WorkflowExpression] Func<bool> includeEmail = null, [WorkflowExpression] Func<bool> includeLink = null, [WorkflowExpression] Func<bool> includeCustomFields = null, [WorkflowExpression] Func<bool> includeCategories = null, [WorkflowExpression] Func<bool> includeMembershipRenewalUrl = null, [WorkflowExpression] Func<string> expiringFrom = null, [WorkflowExpression] Func<string> expiringTo = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(zipCode, nameof(zipCode), required: false);
            SourceExpression.Validate(radius, nameof(radius), required: false);
            SourceExpression.Validate(membershipTypeCode, nameof(membershipTypeCode), required: false);
            SourceExpression.Validate(membershipTypeCategory, nameof(membershipTypeCategory), required: false);
            SourceExpression.Validate(tag, nameof(tag), required: false);
            SourceExpression.Validate(includeMembership, nameof(includeMembership), required: false);
            SourceExpression.Validate(includeAddress, nameof(includeAddress), required: false);
            SourceExpression.Validate(includePhone, nameof(includePhone), required: false);
            SourceExpression.Validate(includeEmail, nameof(includeEmail), required: false);
            SourceExpression.Validate(includeLink, nameof(includeLink), required: false);
            SourceExpression.Validate(includeCustomFields, nameof(includeCustomFields), required: false);
            SourceExpression.Validate(includeCategories, nameof(includeCategories), required: false);
            SourceExpression.Validate(includeMembershipRenewalUrl, nameof(includeMembershipRenewalUrl), required: false);
            SourceExpression.Validate(expiringFrom, nameof(expiringFrom), required: false);
            SourceExpression.Validate(expiringTo, nameof(expiringTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/Members/All/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zipCode != null)
                    callPayload.Queries["zipCode"] = SourceExpressionConverter.ConvertO(zipCode);
                callPayload.Queries["Radius"] = Convert.ToString(5);
                if (radius != null)
                    callPayload.Queries["Radius"] = SourceExpressionConverter.ConvertO(radius);
                if (membershipTypeCode != null)
                    callPayload.Queries["membershipTypeCode"] = SourceExpressionConverter.ConvertO(membershipTypeCode);
                if (membershipTypeCategory != null)
                    callPayload.Queries["membershipTypeCategory"] = SourceExpressionConverter.ConvertO(membershipTypeCategory);
                if (tag != null)
                    callPayload.Queries["Tag"] = SourceExpressionConverter.ConvertO(tag);
                if (includeMembership != null)
                    callPayload.Queries["includeMembership"] = SourceExpressionConverter.ConvertO(includeMembership);
                if (includeAddress != null)
                    callPayload.Queries["includeAddress"] = SourceExpressionConverter.ConvertO(includeAddress);
                if (includePhone != null)
                    callPayload.Queries["includePhone"] = SourceExpressionConverter.ConvertO(includePhone);
                if (includeEmail != null)
                    callPayload.Queries["includeEmail"] = SourceExpressionConverter.ConvertO(includeEmail);
                if (includeLink != null)
                    callPayload.Queries["includeLink"] = SourceExpressionConverter.ConvertO(includeLink);
                if (includeCustomFields != null)
                    callPayload.Queries["includeCustomFields"] = SourceExpressionConverter.ConvertO(includeCustomFields);
                if (includeCategories != null)
                    callPayload.Queries["includeCategories"] = SourceExpressionConverter.ConvertO(includeCategories);
                if (includeMembershipRenewalUrl != null)
                    callPayload.Queries["includeMembershipRenewalUrl"] = SourceExpressionConverter.ConvertO(includeMembershipRenewalUrl);
                if (expiringFrom != null)
                    callPayload.Queries["expiringFrom"] = SourceExpressionConverter.ConvertO(expiringFrom);
                if (expiringTo != null)
                    callPayload.Queries["expiringTo"] = SourceExpressionConverter.ConvertO(expiringTo);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListOfAllIndividualMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetListOfActiveCertificationsForAnOrganizationResponse> GetListOfActiveCertificationsForAnOrganization([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Certifications/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetListOfActiveCertificationsForAnOrganizationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetListOfActiveCertificationsForAnIndividualResponse> GetListOfActiveCertificationsForAnIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Certifications/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetListOfActiveCertificationsForAnIndividualResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData> GetIndividualInactiveMemberships([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Memberships/Inactive", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<MembershipData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddActivityToOrganization([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodyactivityDate = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            SourceExpression.Validate(bodyactivityDate, nameof(bodyactivityDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Activities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodyactivityDate != null)
                {
                    body["activityDate"] = SourceExpressionConverter.ConvertToken(bodyactivityDate);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction RegisterAnIndividualForAFreeSession([WorkflowExpression] Func<string> eventCode, [WorkflowExpression] Func<string> customerIdOrRecordNumber, [WorkflowExpression] Func<string> registrationNumber = null, [WorkflowExpression] Func<SessionRegistrationData[]> body = null)
        {
            SourceExpression.Validate(eventCode, nameof(eventCode), required: true);
            SourceExpression.Validate(customerIdOrRecordNumber, nameof(customerIdOrRecordNumber), required: true);
            SourceExpression.Validate(registrationNumber, nameof(registrationNumber), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Events/{0}/Sessions/Register/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(eventCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerIdOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (registrationNumber != null)
                    callPayload.Queries["registrationNumber"] = SourceExpressionConverter.ConvertO(registrationNumber);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAListOfLicensesResponse> GetAListOfLicenses([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Licenses/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetAListOfLicensesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllAwardsResponse> ListAllAwards([WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<int> year = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(year, nameof(year), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Awards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (year != null)
                    callPayload.Queries["Year"] = SourceExpressionConverter.ConvertO(year);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListAllAwardsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersOrIndividualsByNameResponse> FindMembersOrIndividualsByName([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<bool> includeEmail = null)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(includeEmail, nameof(includeEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/Members/FindByName/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(name, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeEmail != null)
                    callPayload.Queries["includeEmail"] = SourceExpressionConverter.ConvertO(includeEmail);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<FindMembersOrIndividualsByNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAListOfAllServicesOfAnOrganizationResponse> GetAListOfAllServicesOfAnOrganization([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Services", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetAListOfAllServicesOfAnOrganizationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ServiceData> AddAServiceToAnOrganization([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycode, nameof(bodycode), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Services", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ServiceData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet> UpdatePhoneForAnIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycountryName, [WorkflowExpression] Func<string> bodynumber, [WorkflowExpression] Func<bodytypeNameInput> bodytypeName, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null, [WorkflowExpression] Func<string> bodyextension = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycountryName, nameof(bodycountryName), required: true);
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            SourceExpression.Validate(bodytypeName, nameof(bodytypeName), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            SourceExpression.Validate(bodyextension, nameof(bodyextension), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Phones/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["countryName"] = SourceExpressionConverter.ConvertToken(bodycountryName);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodyextension != null)
                {
                    body["extension"] = SourceExpressionConverter.ConvertToken(bodyextension);
                    bodypropCount++;
                }

                bodypropCount++;
                body["typeName"] = SourceExpressionConverter.Convert(bodytypeName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PhoneDataSet>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet> UpdatePhoneForAnOrganization([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodycountryName, [WorkflowExpression] Func<string> bodynumber, [WorkflowExpression] Func<bodytypeNameInput> bodytypeName, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null, [WorkflowExpression] Func<string> bodyextension = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodycountryName, nameof(bodycountryName), required: true);
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            SourceExpression.Validate(bodytypeName, nameof(bodytypeName), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            SourceExpression.Validate(bodyextension, nameof(bodyextension), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Phones/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["countryName"] = SourceExpressionConverter.ConvertToken(bodycountryName);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodyextension != null)
                {
                    body["extension"] = SourceExpressionConverter.ConvertToken(bodyextension);
                    bodypropCount++;
                }

                bodypropCount++;
                body["typeName"] = SourceExpressionConverter.Convert(bodytypeName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PhoneDataSet>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteAnIndividualWebLink([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodyurl = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddWebLinkForIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodyurl = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet> AddPhoneToOrganization([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<string> bodycountryName, [WorkflowExpression] Func<string> bodynumber, [WorkflowExpression] Func<bodytypeNameInput> bodytypeName, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null, [WorkflowExpression] Func<string> bodyextension = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodycountryName, nameof(bodycountryName), required: true);
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            SourceExpression.Validate(bodytypeName, nameof(bodytypeName), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            SourceExpression.Validate(bodyextension, nameof(bodyextension), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Phones", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["countryName"] = SourceExpressionConverter.ConvertToken(bodycountryName);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodyextension != null)
                {
                    body["extension"] = SourceExpressionConverter.ConvertToken(bodyextension);
                    bodypropCount++;
                }

                bodypropCount++;
                body["typeName"] = SourceExpressionConverter.Convert(bodytypeName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PhoneDataSet>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetNomineesByCommitteeResponse> GetNomineesByCommittee([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> term = null)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(term, nameof(term), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Committees/{0}/Nominations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(code, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (term != null)
                    callPayload.Queries["Term"] = SourceExpressionConverter.ConvertO(term);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetNomineesByCommitteeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetOrganizationsActiveSubscriptionsResponse> GetOrganizationsActiveSubscriptions([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Subscriptions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetOrganizationsActiveSubscriptionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteAnOrganizationWebLink([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyurl)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddWebLinkForOrganization([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyurl)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddEmailToOrganization([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Emails", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetOrganizationsRelationshipsResponse> GetOrganizationsRelationships([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> relationshipName = null, [WorkflowExpression] Func<bool> includesDetails = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(relationshipName, nameof(relationshipName), required: false);
            SourceExpression.Validate(includesDetails, nameof(includesDetails), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Relationships/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (relationshipName != null)
                    callPayload.Queries["relationshipName."] = SourceExpressionConverter.ConvertO(relationshipName);
                if (includesDetails != null)
                    callPayload.Queries["includesDetails"] = SourceExpressionConverter.ConvertO(includesDetails);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetOrganizationsRelationshipsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddressSaveData> AddOrUpdateAddressToOrganization([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyline1 = null, [WorkflowExpression] Func<string> bodyline2 = null, [WorkflowExpression] Func<string> bodyline3 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzipcode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null, [WorkflowExpression] Func<bool> bodyisPreferredShipping = null, [WorkflowExpression] Func<bool> bodyisPreferredBilling = null, [WorkflowExpression] Func<bool> bodyisBadAddress = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyline1, nameof(bodyline1), required: false);
            SourceExpression.Validate(bodyline2, nameof(bodyline2), required: false);
            SourceExpression.Validate(bodyline3, nameof(bodyline3), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyzipcode, nameof(bodyzipcode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            SourceExpression.Validate(bodyisPreferredShipping, nameof(bodyisPreferredShipping), required: false);
            SourceExpression.Validate(bodyisPreferredBilling, nameof(bodyisPreferredBilling), required: false);
            SourceExpression.Validate(bodyisBadAddress, nameof(bodyisBadAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Addresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyline1 != null)
                {
                    body["line1"] = SourceExpressionConverter.ConvertToken(bodyline1);
                    bodypropCount++;
                }

                if (bodyline2 != null)
                {
                    body["line2"] = SourceExpressionConverter.ConvertToken(bodyline2);
                    bodypropCount++;
                }

                if (bodyline3 != null)
                {
                    body["line3"] = SourceExpressionConverter.ConvertToken(bodyline3);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyzipcode != null)
                {
                    body["zipcode"] = SourceExpressionConverter.ConvertToken(bodyzipcode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
                    bodypropCount++;
                }

                if (bodyisPreferredShipping != null)
                {
                    body["isPreferredShipping"] = SourceExpressionConverter.ConvertToken(bodyisPreferredShipping);
                    bodypropCount++;
                }

                if (bodyisPreferredBilling != null)
                {
                    body["isPreferredBilling"] = SourceExpressionConverter.ConvertToken(bodyisPreferredBilling);
                    bodypropCount++;
                }

                if (bodyisBadAddress != null)
                {
                    body["isBadAddress"] = SourceExpressionConverter.ConvertToken(bodyisBadAddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddressSaveData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldResultData[]> AddOrUpdateAListOfCustomFieldsPerIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/CustomFieldsList", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<CustomFieldResultData[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetUpcomingEventsResponse> GetUpcomingEvents([WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Events/Upcoming/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetUpcomingEventsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet> AddPhoneToIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<string> bodycountryName, [WorkflowExpression] Func<string> bodynumber, [WorkflowExpression] Func<bodytypeNameInput> bodytypeName, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null, [WorkflowExpression] Func<string> bodyextension = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodycountryName, nameof(bodycountryName), required: true);
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            SourceExpression.Validate(bodytypeName, nameof(bodytypeName), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            SourceExpression.Validate(bodyextension, nameof(bodyextension), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Phones", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["countryName"] = SourceExpressionConverter.ConvertToken(bodycountryName);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodyextension != null)
                {
                    body["extension"] = SourceExpressionConverter.ConvertToken(bodyextension);
                    bodypropCount++;
                }

                bodypropCount++;
                body["typeName"] = SourceExpressionConverter.Convert(bodytypeName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PhoneDataSet>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetCommitteeInformationForAnIndividualResponse> GetCommitteeInformationForAnIndividual([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(includeInactive, nameof(includeInactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Committees/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["includeInactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCommitteeInformationForAnIndividualResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldData[]> GetOrganizationCustomFieldValues([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/CustomFields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CustomFieldData[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData[]> GetOrganizationActiveMemberships([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Memberships/Active", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<MembershipData[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllEventsResponse> GetAllEvents([WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> tag = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(code, nameof(code), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(tag, nameof(tag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Events/All/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (code != null)
                    callPayload.Queries["Code"] = SourceExpressionConverter.ConvertO(code);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (tag != null)
                    callPayload.Queries["Tag"] = SourceExpressionConverter.ConvertO(tag);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetAllEventsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData[]> GetIndividualActiveMemberships([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Memberships/Active", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<MembershipData[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllEventRegistrationsInformationForAnIndividualResponse> GetAllEventRegistrationsInformationForAnIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> eventCode = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(eventCode, nameof(eventCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Registrations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (eventCode != null)
                    callPayload.Queries["eventCode"] = SourceExpressionConverter.ConvertO(eventCode);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetAllEventRegistrationsInformationForAnIndividualResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetIndividualsRelationshipsResponse> GetIndividualsRelationships([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> relationshipName = null, [WorkflowExpression] Func<bool> includeDetails = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(relationshipName, nameof(relationshipName), required: false);
            SourceExpression.Validate(includeDetails, nameof(includeDetails), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Relationships/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (relationshipName != null)
                    callPayload.Queries["relationshipName"] = SourceExpressionConverter.ConvertO(relationshipName);
                if (includeDetails != null)
                    callPayload.Queries["includeDetails"] = SourceExpressionConverter.ConvertO(includeDetails);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetIndividualsRelationshipsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction UpdateAnIndividualEmail([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<string> currentEmailAddress, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(currentEmailAddress, nameof(currentEmailAddress), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Emails/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(currentEmailAddress, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction SaveRelationshipForOrganization([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyrelationshipName, [WorkflowExpression] Func<string> bodyrelatedToCustomerRecordNumber, [WorkflowExpression] Func<string> bodyreciprocalRelationshipName, [WorkflowExpression] Func<bool> bodyisPrimary = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyisReciprocalPrimary = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyrelationshipName, nameof(bodyrelationshipName), required: true);
            SourceExpression.Validate(bodyrelatedToCustomerRecordNumber, nameof(bodyrelatedToCustomerRecordNumber), required: true);
            SourceExpression.Validate(bodyreciprocalRelationshipName, nameof(bodyreciprocalRelationshipName), required: true);
            SourceExpression.Validate(bodyisPrimary, nameof(bodyisPrimary), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyisReciprocalPrimary, nameof(bodyisReciprocalPrimary), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Relationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["relationshipName"] = SourceExpressionConverter.ConvertToken(bodyrelationshipName);
                bodypropCount++;
                body["relatedToCustomerRecordNumber"] = SourceExpressionConverter.ConvertToken(bodyrelatedToCustomerRecordNumber);
                bodypropCount++;
                body["reciprocalRelationshipName"] = SourceExpressionConverter.ConvertToken(bodyreciprocalRelationshipName);
                if (bodyisPrimary != null)
                {
                    body["isPrimary"] = SourceExpressionConverter.ConvertToken(bodyisPrimary);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyisReciprocalPrimary != null)
                {
                    body["isReciprocalPrimary"] = SourceExpressionConverter.ConvertToken(bodyisReciprocalPrimary);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData> AddIndividual([WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<bool> createUser = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyrecordNumber = null)
        {
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyrecordNumber, nameof(bodyrecordNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createUser != null)
                    callPayload.Queries["createUser"] = SourceExpressionConverter.ConvertO(createUser);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
                body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyrecordNumber != null)
                {
                    body["recordNumber"] = SourceExpressionConverter.ConvertToken(bodyrecordNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IndividualData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<EmailData> AddEmailToIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Emails", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmailData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddressSaveData> AddOrUpdateAddressToIndividual([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string> bodyline1 = null, [WorkflowExpression] Func<string> bodyline2 = null, [WorkflowExpression] Func<string> bodyline3 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzipcode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null, [WorkflowExpression] Func<bool> bodyisPreferredShipping = null, [WorkflowExpression] Func<bool> bodyisPreferredBilling = null, [WorkflowExpression] Func<bool> bodyisBadAddress = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyprimary, nameof(bodyprimary), required: false);
            SourceExpression.Validate(bodyline1, nameof(bodyline1), required: false);
            SourceExpression.Validate(bodyline2, nameof(bodyline2), required: false);
            SourceExpression.Validate(bodyline3, nameof(bodyline3), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyzipcode, nameof(bodyzipcode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            SourceExpression.Validate(bodyisPreferredShipping, nameof(bodyisPreferredShipping), required: false);
            SourceExpression.Validate(bodyisPreferredBilling, nameof(bodyisPreferredBilling), required: false);
            SourceExpression.Validate(bodyisBadAddress, nameof(bodyisBadAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Addresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyline1 != null)
                {
                    body["line1"] = SourceExpressionConverter.ConvertToken(bodyline1);
                    bodypropCount++;
                }

                if (bodyline2 != null)
                {
                    body["line2"] = SourceExpressionConverter.ConvertToken(bodyline2);
                    bodypropCount++;
                }

                if (bodyline3 != null)
                {
                    body["line3"] = SourceExpressionConverter.ConvertToken(bodyline3);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyzipcode != null)
                {
                    body["zipcode"] = SourceExpressionConverter.ConvertToken(bodyzipcode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
                    bodypropCount++;
                }

                if (bodyisPreferredShipping != null)
                {
                    body["isPreferredShipping"] = SourceExpressionConverter.ConvertToken(bodyisPreferredShipping);
                    bodypropCount++;
                }

                if (bodyisPreferredBilling != null)
                {
                    body["isPreferredBilling"] = SourceExpressionConverter.ConvertToken(bodyisPreferredBilling);
                    bodypropCount++;
                }

                if (bodyisBadAddress != null)
                {
                    body["isBadAddress"] = SourceExpressionConverter.ConvertToken(bodyisBadAddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddressSaveData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersOrIndividualsByFirstAndLastNameResponse> FindMembersOrIndividualsByFirstAndLastName([WorkflowExpression] Func<string> firstName, [WorkflowExpression] Func<string> lastName, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<bool> includeEmail = null)
        {
            SourceExpression.Validate(firstName, nameof(firstName), required: true);
            SourceExpression.Validate(lastName, nameof(lastName), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(includeEmail, nameof(includeEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/Members/FindByName/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(firstName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lastName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeEmail != null)
                    callPayload.Queries["includeEmail"] = SourceExpressionConverter.ConvertO(includeEmail);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<FindMembersOrIndividualsByFirstAndLastNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction GetCommitteeMembersByCommitteeIdOrCode([WorkflowExpression] Func<string> idOrCode, [WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<int> term = null, [WorkflowExpression] Func<string> positionCodes = null)
        {
            SourceExpression.Validate(idOrCode, nameof(idOrCode), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(term, nameof(term), required: false);
            SourceExpression.Validate(positionCodes, nameof(positionCodes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Committees/{0}/Members/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (term != null)
                    callPayload.Queries["Term"] = SourceExpressionConverter.ConvertO(term);
                if (positionCodes != null)
                    callPayload.Queries["positionCodes"] = SourceExpressionConverter.ConvertO(positionCodes);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddActivity([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodyactivityDate = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            SourceExpression.Validate(bodyactivityDate, nameof(bodyactivityDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Activities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["category"] = "Impexium";
                bodypropCount++;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodyactivityDate != null)
                {
                    body["activityDate"] = SourceExpressionConverter.ConvertToken(bodyactivityDate);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindIndividualIdOrEmailResponse> FindIndividualIdOrEmail([WorkflowExpression] Func<string> idOrRecordNumberOrEmail)
        {
            SourceExpression.Validate(idOrRecordNumberOrEmail, nameof(idOrRecordNumberOrEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/Profile/{0}/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumberOrEmail, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(SourceExpression.Literal(1, 1), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["IncludeDetails"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<FindIndividualIdOrEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddRelationshipToIndividual([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyrelationshipName, [WorkflowExpression] Func<string> bodyrelatedToCustomerRecordNumber, [WorkflowExpression] Func<string> bodyreciprocalRelationshipName, [WorkflowExpression] Func<bool> bodyisPrimary = null, [WorkflowExpression] Func<bool> bodyisReciprocalPrimary = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyrelationshipName, nameof(bodyrelationshipName), required: true);
            SourceExpression.Validate(bodyrelatedToCustomerRecordNumber, nameof(bodyrelatedToCustomerRecordNumber), required: true);
            SourceExpression.Validate(bodyreciprocalRelationshipName, nameof(bodyreciprocalRelationshipName), required: true);
            SourceExpression.Validate(bodyisPrimary, nameof(bodyisPrimary), required: false);
            SourceExpression.Validate(bodyisReciprocalPrimary, nameof(bodyisReciprocalPrimary), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Relationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("Application/Json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["relationshipName"] = SourceExpressionConverter.ConvertToken(bodyrelationshipName);
                bodypropCount++;
                body["relatedToCustomerRecordNumber"] = SourceExpressionConverter.ConvertToken(bodyrelatedToCustomerRecordNumber);
                bodypropCount++;
                body["reciprocalRelationshipName"] = SourceExpressionConverter.ConvertToken(bodyreciprocalRelationshipName);
                if (bodyisPrimary != null)
                {
                    body["isPrimary"] = SourceExpressionConverter.ConvertToken(bodyisPrimary);
                    bodypropCount++;
                }

                if (bodyisReciprocalPrimary != null)
                {
                    body["isReciprocalPrimary"] = SourceExpressionConverter.ConvertToken(bodyisReciprocalPrimary);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction IndividualAddEducationCredit([WorkflowExpression] Func<string> idOrRecordNumber, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<double> bodynumberOfCredits, [WorkflowExpression] Func<string> bodydateEarned, [WorkflowExpression] Func<string> bodyproviderName = null, [WorkflowExpression] Func<string> bodystateName = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<bool> bodyisSelfReported = null)
        {
            SourceExpression.Validate(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            SourceExpression.Validate(bodynumberOfCredits, nameof(bodynumberOfCredits), required: true);
            SourceExpression.Validate(bodydateEarned, nameof(bodydateEarned), required: true);
            SourceExpression.Validate(bodyproviderName, nameof(bodyproviderName), required: false);
            SourceExpression.Validate(bodystateName, nameof(bodystateName), required: false);
            SourceExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            SourceExpression.Validate(bodyisSelfReported, nameof(bodyisSelfReported), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/EducationCredits", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["numberOfCredits"] = SourceExpressionConverter.ConvertToken(bodynumberOfCredits);
                bodypropCount++;
                body["dateEarned"] = SourceExpressionConverter.ConvertToken(bodydateEarned);
                if (bodyproviderName != null)
                {
                    body["providerName"] = SourceExpressionConverter.ConvertToken(bodyproviderName);
                    bodypropCount++;
                }

                if (bodystateName != null)
                {
                    body["stateName"] = SourceExpressionConverter.ConvertToken(bodystateName);
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["reference"] = SourceExpressionConverter.ConvertToken(bodyreference);
                    bodypropCount++;
                }

                if (bodyisSelfReported != null)
                {
                    body["isSelfReported"] = SourceExpressionConverter.ConvertToken(bodyisSelfReported);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction IndividualAddNote([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> notecontent, [WorkflowExpression] Func<bool> noteisAlert = null, [WorkflowExpression] Func<string> notetitle = null, [WorkflowExpression] Func<string> notefollowUpDate = null, [WorkflowExpression] Func<string> notecategory = null, [WorkflowExpression] Func<bool> noteisInternal = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(notecontent, nameof(notecontent), required: true);
            SourceExpression.Validate(noteisAlert, nameof(noteisAlert), required: false);
            SourceExpression.Validate(notetitle, nameof(notetitle), required: false);
            SourceExpression.Validate(notefollowUpDate, nameof(notefollowUpDate), required: false);
            SourceExpression.Validate(notecategory, nameof(notecategory), required: false);
            SourceExpression.Validate(noteisInternal, nameof(noteisInternal), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var note = new JObject();
                var notepropCount = 0;
                if (noteisAlert != null)
                {
                    note["isAlert"] = SourceExpressionConverter.ConvertToken(noteisAlert);
                    notepropCount++;
                }

                if (notetitle != null)
                {
                    note["title"] = SourceExpressionConverter.ConvertToken(notetitle);
                    notepropCount++;
                }

                if (notefollowUpDate != null)
                {
                    note["followUpDate"] = SourceExpressionConverter.ConvertToken(notefollowUpDate);
                    notepropCount++;
                }

                notepropCount++;
                note["content"] = SourceExpressionConverter.ConvertToken(notecontent);
                if (notecategory != null)
                {
                    note["category"] = SourceExpressionConverter.ConvertToken(notecategory);
                    notepropCount++;
                }

                if (noteisInternal != null)
                {
                    note["isInternal"] = SourceExpressionConverter.ConvertToken(noteisInternal);
                    notepropCount++;
                }

                if (notepropCount > 0)
                {
                    callPayload.Body = note;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualsLookupByNameResponse> IndividualsLookupByName([WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/Lookup/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(SourceExpression.Literal(1, 1), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["includeOrgAddresses"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<IndividualsLookupByNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddToCommitteeResponse> AddToCommittee([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<string> bodyrecordNumber, [WorkflowExpression] Func<string> bodypositionCode, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyrepresentingOrganizationRecordNumber = null, [WorkflowExpression] Func<string> bodyrepresentingOrganizationRelationshipName = null, [WorkflowExpression] Func<string> bodynominatedByCustomerRecordNumber = null, [WorkflowExpression] Func<int> bodycommitteeTerm = null, [WorkflowExpression] Func<int> bodyrank = null)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            SourceExpression.Validate(bodyrecordNumber, nameof(bodyrecordNumber), required: true);
            SourceExpression.Validate(bodypositionCode, nameof(bodypositionCode), required: true);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: true);
            SourceExpression.Validate(bodycode, nameof(bodycode), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyrepresentingOrganizationRecordNumber, nameof(bodyrepresentingOrganizationRecordNumber), required: false);
            SourceExpression.Validate(bodyrepresentingOrganizationRelationshipName, nameof(bodyrepresentingOrganizationRelationshipName), required: false);
            SourceExpression.Validate(bodynominatedByCustomerRecordNumber, nameof(bodynominatedByCustomerRecordNumber), required: false);
            SourceExpression.Validate(bodycommitteeTerm, nameof(bodycommitteeTerm), required: false);
            SourceExpression.Validate(bodyrank, nameof(bodyrank), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Committees/{0}/Members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(code, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recordNumber"] = SourceExpressionConverter.ConvertToken(bodyrecordNumber);
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["positionCode"] = SourceExpressionConverter.ConvertToken(bodypositionCode);
                bodypropCount++;
                body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyrepresentingOrganizationRecordNumber != null)
                {
                    body["representingOrganizationRecordNumber"] = SourceExpressionConverter.ConvertToken(bodyrepresentingOrganizationRecordNumber);
                    bodypropCount++;
                }

                if (bodyrepresentingOrganizationRelationshipName != null)
                {
                    body["representingOrganizationRelationshipName"] = SourceExpressionConverter.ConvertToken(bodyrepresentingOrganizationRelationshipName);
                    bodypropCount++;
                }

                if (bodynominatedByCustomerRecordNumber != null)
                {
                    body["nominatedByCustomerRecordNumber"] = SourceExpressionConverter.ConvertToken(bodynominatedByCustomerRecordNumber);
                    bodypropCount++;
                }

                if (bodycommitteeTerm != null)
                {
                    body["committeeTerm"] = SourceExpressionConverter.ConvertToken(bodycommitteeTerm);
                    bodypropCount++;
                }

                if (bodyrank != null)
                {
                    body["rank"] = SourceExpressionConverter.ConvertToken(bodyrank);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddToCommitteeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction UpdateCommitteeMember([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<string> memberRecordNumber, [WorkflowExpression] Func<string> currentPositionCode, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodypositionCode = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyrepresentingOrganizationRecordNumber = null, [WorkflowExpression] Func<string> bodyrepresentingOrganizationRelationshipName = null, [WorkflowExpression] Func<string> bodynominatedByCustomerRecordNumber = null, [WorkflowExpression] Func<int> bodycommitteeTerm = null, [WorkflowExpression] Func<int> bodyrank = null)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            SourceExpression.Validate(memberRecordNumber, nameof(memberRecordNumber), required: true);
            SourceExpression.Validate(currentPositionCode, nameof(currentPositionCode), required: true);
            SourceExpression.Validate(bodycode, nameof(bodycode), required: false);
            SourceExpression.Validate(bodypositionCode, nameof(bodypositionCode), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyrepresentingOrganizationRecordNumber, nameof(bodyrepresentingOrganizationRecordNumber), required: false);
            SourceExpression.Validate(bodyrepresentingOrganizationRelationshipName, nameof(bodyrepresentingOrganizationRelationshipName), required: false);
            SourceExpression.Validate(bodynominatedByCustomerRecordNumber, nameof(bodynominatedByCustomerRecordNumber), required: false);
            SourceExpression.Validate(bodycommitteeTerm, nameof(bodycommitteeTerm), required: false);
            SourceExpression.Validate(bodyrank, nameof(bodyrank), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Committees/{0}/Members/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(code, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberRecordNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(currentPositionCode, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodypositionCode != null)
                {
                    body["positionCode"] = SourceExpressionConverter.ConvertToken(bodypositionCode);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyrepresentingOrganizationRecordNumber != null)
                {
                    body["representingOrganizationRecordNumber"] = SourceExpressionConverter.ConvertToken(bodyrepresentingOrganizationRecordNumber);
                    bodypropCount++;
                }

                if (bodyrepresentingOrganizationRelationshipName != null)
                {
                    body["representingOrganizationRelationshipName"] = SourceExpressionConverter.ConvertToken(bodyrepresentingOrganizationRelationshipName);
                    bodypropCount++;
                }

                if (bodynominatedByCustomerRecordNumber != null)
                {
                    body["nominatedByCustomerRecordNumber"] = SourceExpressionConverter.ConvertToken(bodynominatedByCustomerRecordNumber);
                    bodypropCount++;
                }

                if (bodycommitteeTerm != null)
                {
                    body["committeeTerm"] = SourceExpressionConverter.ConvertToken(bodycommitteeTerm);
                    bodypropCount++;
                }

                if (bodyrank != null)
                {
                    body["rank"] = SourceExpressionConverter.ConvertToken(bodyrank);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData> AddOrganization([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodybranchName = null, [WorkflowExpression] Func<string> bodywebsite = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodybranchName, nameof(bodybranchName), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                body["showInDirectory"] = false;
                bodypropCount++;
                if (bodybranchName != null)
                {
                    body["branchName"] = SourceExpressionConverter.ConvertToken(bodybranchName);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData> UpdateOrganization([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyshowInDirectory = null, [WorkflowExpression] Func<string> bodybranchName = null, [WorkflowExpression] Func<string> bodywebsite = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            SourceExpression.Validate(bodybranchName, nameof(bodybranchName), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = SourceExpressionConverter.ConvertToken(bodyshowInDirectory);
                    bodypropCount++;
                }

                if (bodybranchName != null)
                {
                    body["branchName"] = SourceExpressionConverter.ConvertToken(bodybranchName);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData> OrganizationGetProfile([WorkflowExpression] Func<string> idOrRecordnumber)
        {
            SourceExpression.Validate(idOrRecordnumber, nameof(idOrRecordnumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/Profile/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(idOrRecordnumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(SourceExpression.Literal(1, 1), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDescription"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction OrganizationAddNote([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> notecontent, [WorkflowExpression] Func<bool> noteisAlert = null, [WorkflowExpression] Func<string> notetitle = null, [WorkflowExpression] Func<string> notefollowUpDate = null, [WorkflowExpression] Func<string> notecategory = null, [WorkflowExpression] Func<bool> noteisInternal = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(notecontent, nameof(notecontent), required: true);
            SourceExpression.Validate(noteisAlert, nameof(noteisAlert), required: false);
            SourceExpression.Validate(notetitle, nameof(notetitle), required: false);
            SourceExpression.Validate(notefollowUpDate, nameof(notefollowUpDate), required: false);
            SourceExpression.Validate(notecategory, nameof(notecategory), required: false);
            SourceExpression.Validate(noteisInternal, nameof(noteisInternal), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/{0}/Notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var note = new JObject();
                var notepropCount = 0;
                if (noteisAlert != null)
                {
                    note["isAlert"] = SourceExpressionConverter.ConvertToken(noteisAlert);
                    notepropCount++;
                }

                if (notetitle != null)
                {
                    note["title"] = SourceExpressionConverter.ConvertToken(notetitle);
                    notepropCount++;
                }

                if (notefollowUpDate != null)
                {
                    note["followUpDate"] = SourceExpressionConverter.ConvertToken(notefollowUpDate);
                    notepropCount++;
                }

                notepropCount++;
                note["content"] = SourceExpressionConverter.ConvertToken(notecontent);
                if (notecategory != null)
                {
                    note["category"] = SourceExpressionConverter.ConvertToken(notecategory);
                    notepropCount++;
                }

                if (noteisInternal != null)
                {
                    note["isInternal"] = SourceExpressionConverter.ConvertToken(noteisInternal);
                    notepropCount++;
                }

                if (notepropCount > 0)
                {
                    callPayload.Body = note;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationLookupByNameResponse> OrganizationLookupByName([WorkflowExpression] Func<string> name)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Organizations/Lookup/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(SourceExpression.Literal(1, 1), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["includeAddresses"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<OrganizationLookupByNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllCommitteesResponse> GetAllCommittees([WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> term = null, [WorkflowExpression] Func<bool> activeOnly = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(code, nameof(code), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(term, nameof(term), required: false);
            SourceExpression.Validate(activeOnly, nameof(activeOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Committees/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (code != null)
                    callPayload.Queries["Code"] = SourceExpressionConverter.ConvertO(code);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (term != null)
                    callPayload.Queries["Term"] = SourceExpressionConverter.ConvertO(term);
                if (activeOnly != null)
                    callPayload.Queries["activeOnly"] = SourceExpressionConverter.ConvertO(activeOnly);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetAllCommitteesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetPositionsByCommitteeResponse> GetPositionsByCommittee([WorkflowExpression] Func<string> code)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Committees/{0}/Positions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(code, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetPositionsByCommitteeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetSubCommitteesResponse> GetSubCommittees([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(code, nameof(code), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Committees/{0}/subcommittees/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(code, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSubCommitteesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetIndividualsActiveSubscriptionsResponse> GetIndividualsActiveSubscriptions([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> pageNumber)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}/Subscriptions/All/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetIndividualsActiveSubscriptionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllIndividualsResponse> ListAllIndividuals([WorkflowExpression] Func<int> pageNumber, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<bool> includeDetails = null, [WorkflowExpression] Func<string> oldId = null)
        {
            SourceExpression.Validate(pageNumber, nameof(pageNumber), required: true);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(includeDetails, nameof(includeDetails), required: false);
            SourceExpression.Validate(oldId, nameof(oldId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Individuals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["includeDetails"] = Convert.ToString(true);
                if (includeDetails != null)
                    callPayload.Queries["includeDetails"] = SourceExpressionConverter.ConvertO(includeDetails);
                if (oldId != null)
                    callPayload.Queries["oldID"] = SourceExpressionConverter.ConvertO(oldId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ListAllIndividualsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindCustomerPhoneResponse> FindCustomerPhone([WorkflowExpression] Func<string> phoneNumber)
        {
            SourceExpression.Validate(phoneNumber, nameof(phoneNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Customers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "1"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["phoneNumber"] = SourceExpressionConverter.ConvertO(phoneNumber);
                callPayload.Queries["includeAddress"] = Convert.ToString(true);
                callPayload.Queries["includePhone"] = Convert.ToString(true);
                callPayload.Queries["includeEmail"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<FindCustomerPhoneResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction MarkRegistrantAttended([WorkflowExpression] Func<string> recordNumber, [WorkflowExpression] Func<bodyInputItem2[]> body = null)
        {
            SourceExpression.Validate(recordNumber, nameof(recordNumber), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Events/Registrants/{0}/Attended", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AwardsAddAwardNomination([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> awardNominationDatanomineeRecordNumber, [WorkflowExpression] Func<string> awardNominationDatanominatedByCustomerRecordNumber, [WorkflowExpression] Func<string> awardNominationDatanominationDate, [WorkflowExpression] Func<string> awardNominationDataawardedDate = null, [WorkflowExpression] Func<awardNominationDatastatusInput> awardNominationDatastatus = null, [WorkflowExpression] Func<string> awardNominationDatadescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(awardNominationDatanomineeRecordNumber, nameof(awardNominationDatanomineeRecordNumber), required: true);
            SourceExpression.Validate(awardNominationDatanominatedByCustomerRecordNumber, nameof(awardNominationDatanominatedByCustomerRecordNumber), required: true);
            SourceExpression.Validate(awardNominationDatanominationDate, nameof(awardNominationDatanominationDate), required: true);
            SourceExpression.Validate(awardNominationDataawardedDate, nameof(awardNominationDataawardedDate), required: false);
            SourceExpression.Validate(awardNominationDatastatus, nameof(awardNominationDatastatus), required: false);
            SourceExpression.Validate(awardNominationDatadescription, nameof(awardNominationDatadescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Awards/{0}/Nominations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var awardNominationData = new JObject();
                var awardNominationDatapropCount = 0;
                awardNominationDatapropCount++;
                awardNominationData["nomineeRecordNumber"] = SourceExpressionConverter.ConvertToken(awardNominationDatanomineeRecordNumber);
                awardNominationDatapropCount++;
                awardNominationData["nominatedByCustomerRecordNumber"] = SourceExpressionConverter.ConvertToken(awardNominationDatanominatedByCustomerRecordNumber);
                awardNominationDatapropCount++;
                awardNominationData["nominationDate"] = SourceExpressionConverter.ConvertToken(awardNominationDatanominationDate);
                if (awardNominationDataawardedDate != null)
                {
                    awardNominationData["awardedDate"] = SourceExpressionConverter.ConvertToken(awardNominationDataawardedDate);
                    awardNominationDatapropCount++;
                }

                if (awardNominationDatastatus != null)
                {
                    awardNominationData["status"] = SourceExpressionConverter.Convert(awardNominationDatastatus);
                    awardNominationDatapropCount++;
                }

                if (awardNominationDatadescription != null)
                {
                    awardNominationData["description"] = SourceExpressionConverter.ConvertToken(awardNominationDatadescription);
                    awardNominationDatapropCount++;
                }

                if (awardNominationDatapropCount > 0)
                {
                    callPayload.Body = awardNominationData;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AwardsUpdateAwardNomination([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> nomineeRecordNumber, [WorkflowExpression] Func<string> awardNominationDatanominatedByCustomerRecordNumber, [WorkflowExpression] Func<string> awardNominationDatanominationDate, [WorkflowExpression] Func<string> awardNominationDataawardedDate = null, [WorkflowExpression] Func<awardNominationDatastatusInput> awardNominationDatastatus = null, [WorkflowExpression] Func<string> awardNominationDatadescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(nomineeRecordNumber, nameof(nomineeRecordNumber), required: true);
            SourceExpression.Validate(awardNominationDatanominatedByCustomerRecordNumber, nameof(awardNominationDatanominatedByCustomerRecordNumber), required: true);
            SourceExpression.Validate(awardNominationDatanominationDate, nameof(awardNominationDatanominationDate), required: true);
            SourceExpression.Validate(awardNominationDataawardedDate, nameof(awardNominationDataawardedDate), required: false);
            SourceExpression.Validate(awardNominationDatastatus, nameof(awardNominationDatastatus), required: false);
            SourceExpression.Validate(awardNominationDatadescription, nameof(awardNominationDatadescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Awards/{0}/Nominations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nomineeRecordNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var awardNominationData = new JObject();
                var awardNominationDatapropCount = 0;
                awardNominationDatapropCount++;
                awardNominationData["nominatedByCustomerRecordNumber"] = SourceExpressionConverter.ConvertToken(awardNominationDatanominatedByCustomerRecordNumber);
                awardNominationDatapropCount++;
                awardNominationData["nominationDate"] = SourceExpressionConverter.ConvertToken(awardNominationDatanominationDate);
                if (awardNominationDataawardedDate != null)
                {
                    awardNominationData["awardedDate"] = SourceExpressionConverter.ConvertToken(awardNominationDataawardedDate);
                    awardNominationDatapropCount++;
                }

                if (awardNominationDatastatus != null)
                {
                    awardNominationData["status"] = SourceExpressionConverter.Convert(awardNominationDatastatus);
                    awardNominationDatapropCount++;
                }

                if (awardNominationDatadescription != null)
                {
                    awardNominationData["description"] = SourceExpressionConverter.ConvertToken(awardNominationDatadescription);
                    awardNominationDatapropCount++;
                }

                if (awardNominationDatapropCount > 0)
                {
                    callPayload.Body = awardNominationData;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AwardsGetIndividualAwardRecipientsResponse> AwardsGetIndividualAwardRecipients([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Awards/{0}/Recipients/Individuals/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(SourceExpression.Literal(1, 1), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDetails"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<AwardsGetIndividualAwardRecipientsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AwardsGetOrganizationAwardRecipientsResponse> AwardsGetOrganizationAwardRecipients([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/Awards/{0}/Recipients/Organizations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(SourceExpression.Literal(1, 1), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDetails"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<AwardsGetOrganizationAwardRecipientsResponse>(BuildSourceInput);
        }
    }

    public class ImpexiumTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenIndividualCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/IndividualCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Individual.Created";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenIndividualDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Individual.Deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Individual.Deleted";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenIndividualRequestForgotten(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Individual.RequestToBeForgotten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Individual.RequestToBeForgotten";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenProductPurchased([WorkflowExpression] Func<string[]> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilters, nameof(bodyfilters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/ProductPurchased";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Product.Purchased";
                bodypropCount++;
                bodypropCount++;
                body["filters"] = SourceExpressionConverter.ConvertToken(bodyfilters);
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCommitteeMemberUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/CommitteeMemberUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Individual.CommitteeUpdated";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenPurchaseCancelled([WorkflowExpression] Func<string[]> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilters, nameof(bodyfilters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/PurchaseCancelled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Purchase.Cancelled";
                bodypropCount++;
                bodypropCount++;
                body["filters"] = SourceExpressionConverter.ConvertToken(bodyfilters);
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenRequestUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/RequestUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Customer.RequestUpdated";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenEmailUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/EmailUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Customer.EmailUpdated";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerCustomFieldValueUpdated([WorkflowExpression] Func<string[]> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilters, nameof(bodyfilters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Customer.CustomFieldValueUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Customer.CustomFieldValueUpdated";
                bodypropCount++;
                bodypropCount++;
                body["filters"] = SourceExpressionConverter.ConvertToken(bodyfilters);
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerIsMerged(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Customer.Merged";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Customer.Merged";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerRelationshipUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Customer.RelationshipUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Customer.RelationshipUpdated";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerPhoneUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Customer.PhoneUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Customer.PhoneUpdated";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerAddressUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Customer.AddressUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Customer.AddressUpdated";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenEventRegistrationSubstituted([WorkflowExpression] Func<string[]> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilters, nameof(bodyfilters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Event.Registration.Substituted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Event.Registration.Substituted";
                bodypropCount++;
                bodypropCount++;
                body["filters"] = SourceExpressionConverter.ConvertToken(bodyfilters);
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenPurchasePaid([WorkflowExpression] Func<string[]> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyfilters, nameof(bodyfilters), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Purchase.Paid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Purchase.Paid";
                bodypropCount++;
                bodypropCount++;
                body["filters"] = SourceExpressionConverter.ConvertToken(bodyfilters);
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenMembershipTerminated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/Webhooks/Membership.Terminated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["typeName"] = "Membership.Terminated";
                bodypropCount++;
                body["secret"] = "Impexium";
                bodypropCount++;
                body["callBackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Added by Impexium Connector";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class GetAbandonedCheckoutsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public AbandonedCheckoutData[] DataList { get; set; }
    }

    public class AbandonedCheckoutData
    {
        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdByEmailAddress")]
        public string CreatedByEmailAddress { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public AbandonedCheckoutDataCustomerType Customer { get; set; }

        [JsonProperty("lineItems")]
        public AbandonedCheckoutDataLineItemsTypeItem[] LineItems { get; set; }
    }

    public class AbandonedCheckoutDataCustomerType
    {
        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primaryEmailAddress")]
        public string PrimaryEmailAddress { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItem
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("linePrice")]
        public double LinePrice { get; set; }

        [JsonProperty("lineSubTotal")]
        public double LineSubTotal { get; set; }

        [JsonProperty("priceCode")]
        public string PriceCode { get; set; }

        [JsonProperty("amountOverride")]
        public bool AmountOverride { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("productPurchaseUrl")]
        public string ProductPurchaseUrl { get; set; }

        [JsonProperty("registrationInfo")]
        public AbandonedCheckoutDataLineItemsTypeItemRegistrationInfoType RegistrationInfo { get; set; }

        [JsonProperty("discounts")]
        public AbandonedCheckoutDataLineItemsTypeItemDiscountsTypeItem[] Discounts { get; set; }

        [JsonProperty("relatedProducts")]
        public AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItem[] RelatedProducts { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRegistrationInfoType
    {
        [JsonProperty("badgeName")]
        public string BadgeName { get; set; }

        [JsonProperty("badgeOrganization")]
        public string BadgeOrganization { get; set; }

        [JsonProperty("badgeTitle")]
        public string BadgeTitle { get; set; }

        [JsonProperty("badgeCity")]
        public string BadgeCity { get; set; }

        [JsonProperty("badgeState")]
        public string BadgeState { get; set; }

        [JsonProperty("isGroupRegistration")]
        public bool IsGroupRegistration { get; set; }

        [JsonProperty("isWaitlisted")]
        public bool IsWaitlisted { get; set; }

        [JsonProperty("guestInfo")]
        public AbandonedCheckoutDataLineItemsTypeItemRegistrationInfoTypeGuestInfoType GuestInfo { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRegistrationInfoTypeGuestInfoType
    {
        [JsonProperty("guestFirstName")]
        public string GuestFirstName { get; set; }

        [JsonProperty("guestLastName")]
        public string GuestLastName { get; set; }

        [JsonProperty("guestEmailAddress")]
        public string GuestEmailAddress { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemDiscountsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItem
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("linePrice")]
        public double LinePrice { get; set; }

        [JsonProperty("lineSubTotal")]
        public double LineSubTotal { get; set; }

        [JsonProperty("priceCode")]
        public string PriceCode { get; set; }

        [JsonProperty("amountOverride")]
        public bool AmountOverride { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("productPurchaseUrl")]
        public string ProductPurchaseUrl { get; set; }

        [JsonProperty("registrationInfo")]
        public AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRegistrationInfoType RegistrationInfo { get; set; }

        [JsonProperty("discounts")]
        public AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemDiscountsTypeItem[] Discounts { get; set; }

        [JsonProperty("relatedProducts")]
        public AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRelatedProductsTypeItem[] RelatedProducts { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRegistrationInfoType
    {
        [JsonProperty("badgeName")]
        public string BadgeName { get; set; }

        [JsonProperty("badgeOrganization")]
        public string BadgeOrganization { get; set; }

        [JsonProperty("badgeTitle")]
        public string BadgeTitle { get; set; }

        [JsonProperty("badgeCity")]
        public string BadgeCity { get; set; }

        [JsonProperty("badgeState")]
        public string BadgeState { get; set; }

        [JsonProperty("isGroupRegistration")]
        public bool IsGroupRegistration { get; set; }

        [JsonProperty("isWaitlisted")]
        public bool IsWaitlisted { get; set; }

        [JsonProperty("guestInfo")]
        public AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRegistrationInfoTypeGuestInfoType GuestInfo { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRegistrationInfoTypeGuestInfoType
    {
        [JsonProperty("guestFirstName")]
        public string GuestFirstName { get; set; }

        [JsonProperty("guestLastName")]
        public string GuestLastName { get; set; }

        [JsonProperty("guestEmailAddress")]
        public string GuestEmailAddress { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemDiscountsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRelatedProductsTypeItem
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("linePrice")]
        public double LinePrice { get; set; }

        [JsonProperty("lineSubTotal")]
        public double LineSubTotal { get; set; }

        [JsonProperty("priceCode")]
        public string PriceCode { get; set; }

        [JsonProperty("amountOverride")]
        public bool AmountOverride { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("productPurchaseUrl")]
        public string ProductPurchaseUrl { get; set; }

        [JsonProperty("registrationInfo")]
        public AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRelatedProductsTypeItemRegistrationInfoType RegistrationInfo { get; set; }

        [JsonProperty("discounts")]
        public AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRelatedProductsTypeItemDiscountsTypeItem[] Discounts { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRelatedProductsTypeItemRegistrationInfoType
    {
        [JsonProperty("badgeName")]
        public string BadgeName { get; set; }

        [JsonProperty("badgeOrganization")]
        public string BadgeOrganization { get; set; }

        [JsonProperty("badgeTitle")]
        public string BadgeTitle { get; set; }

        [JsonProperty("badgeCity")]
        public string BadgeCity { get; set; }

        [JsonProperty("badgeState")]
        public string BadgeState { get; set; }

        [JsonProperty("isGroupRegistration")]
        public bool IsGroupRegistration { get; set; }

        [JsonProperty("isWaitlisted")]
        public bool IsWaitlisted { get; set; }

        [JsonProperty("guestInfo")]
        public AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRelatedProductsTypeItemRegistrationInfoTypeGuestInfoType GuestInfo { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRelatedProductsTypeItemRegistrationInfoTypeGuestInfoType
    {
        [JsonProperty("guestFirstName")]
        public string GuestFirstName { get; set; }

        [JsonProperty("guestLastName")]
        public string GuestLastName { get; set; }

        [JsonProperty("guestEmailAddress")]
        public string GuestEmailAddress { get; set; }
    }

    public class AbandonedCheckoutDataLineItemsTypeItemRelatedProductsTypeItemRelatedProductsTypeItemDiscountsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ListAllExhibitorsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public ExhibitorData[] DataList { get; set; }
    }

    public class ExhibitorData
    {
        [JsonProperty("organization")]
        public ExhibitorDataOrganizationType Organization { get; set; }

        [JsonProperty("booths")]
        public ExhibitorDataBoothsTypeItem[] Booths { get; set; }
    }

    public class ExhibitorDataOrganizationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("annualSales")]
        public double AnnualSales { get; set; }

        [JsonProperty("employeeRangeId")]
        public string EmployeeRangeId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("addresses")]
        public ExhibitorDataOrganizationTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("emails")]
        public ExhibitorDataOrganizationTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public ExhibitorDataOrganizationTypePhonesTypeItem[] Phones { get; set; }
    }

    public class ExhibitorDataOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public ExhibitorDataOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class ExhibitorDataOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class ExhibitorDataOrganizationTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class ExhibitorDataOrganizationTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public ExhibitorDataOrganizationTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class ExhibitorDataOrganizationTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class ExhibitorDataBoothsTypeItem
    {
        [JsonProperty("organizationDisplayName")]
        public string OrganizationDisplayName { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hall")]
        public ExhibitorDataBoothsTypeItemHallType Hall { get; set; }
    }

    public class ExhibitorDataBoothsTypeItemHallType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ListOfExamsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public ExamData[] DataList { get; set; }
    }

    public class ExamData
    {
        [JsonProperty("examStartDate")]
        public string ExamStartDate { get; set; }

        [JsonProperty("examEndDate")]
        public string ExamEndDate { get; set; }

        [JsonProperty("examNumber")]
        public string ExamNumber { get; set; }

        [JsonProperty("educationCredits")]
        public ExamDataEducationCreditsTypeItem[] EducationCredits { get; set; }

        [JsonProperty("categories")]
        public ExamDataCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("activePrices")]
        public ExamDataActivePricesTypeItem[] ActivePrices { get; set; }

        [JsonProperty("relatedProducts")]
        public ExamDataRelatedProductsTypeItem[] RelatedProducts { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("imageUrl")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("availableFrom")]
        public string AvailableFrom { get; set; }

        [JsonProperty("availableUntil")]
        public string AvailableUntil { get; set; }
    }

    public class ExamDataEducationCreditsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("credits")]
        public double Credits { get; set; }
    }

    public class ExamDataCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public ExamDataCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ExamDataCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public string SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ExamDataActivePricesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("hasFormula")]
        public bool HasFormula { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }
    }

    public class ExamDataRelatedProductsTypeItem
    {
        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("imageUrl")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("availableFrom")]
        public string AvailableFrom { get; set; }

        [JsonProperty("availableUntil")]
        public string AvailableUntil { get; set; }
    }

    public class ListRegistrantsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public RegistrantData[] DataList { get; set; }
    }

    public class RegistrantData
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("badgeName")]
        public string BadgeName { get; set; }

        [JsonProperty("badgeOrganization")]
        public string BadgeOrganization { get; set; }

        [JsonProperty("badgeCity")]
        public string BadgeCity { get; set; }

        [JsonProperty("badgeState")]
        public string BadgeState { get; set; }

        [JsonProperty("attendedDate")]
        public string AttendedDate { get; set; }

        [JsonProperty("sessions")]
        public RegistrantDataSessionsTypeItem[] Sessions { get; set; }

        [JsonProperty("itemizedCustomFields")]
        public RegistrantDataItemizedCustomFieldsTypeItem[] ItemizedCustomFields { get; set; }

        [JsonProperty("guestOfRecordNumber")]
        public string GuestOfRecordNumber { get; set; }

        [JsonProperty("registrantTypeCode")]
        public string RegistrantTypeCode { get; set; }

        [JsonProperty("registrantTypeName")]
        public string RegistrantTypeName { get; set; }

        [JsonProperty("registrationNumber")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("boughtTogetherWith")]
        public RegistrantDataBoughtTogetherWithTypeItem[] BoughtTogetherWith { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("preferredFirstName")]
        public string PreferredFirstName { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("primaryOrganization")]
        public RegistrantDataPrimaryOrganizationType PrimaryOrganization { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("addresses")]
        public RegistrantDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("phones")]
        public RegistrantDataPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("emails")]
        public RegistrantDataEmailsTypeItem[] Emails { get; set; }
    }

    public class RegistrantDataSessionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        public bool IsPublic { get; set; }
        public string Room { get; set; }

        [JsonProperty("externalCode")]
        public string ExternalCode { get; set; }

        [JsonProperty("categories")]
        public RegistrantDataSessionsTypeItemCategoriesTypeItem[] Categories { get; set; }
    }

    public class RegistrantDataSessionsTypeItemCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public string IsPrimary { get; set; }

        [JsonProperty("subCategories")]
        public RegistrantDataSessionsTypeItemCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }
    }

    public class RegistrantDataSessionsTypeItemCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public string IsPrimary { get; set; }
    }

    public class RegistrantDataItemizedCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RegistrantDataBoughtTogetherWithTypeItem
    {
        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productType")]
        public string ProductType { get; set; }

        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("itemizedCustomFields")]
        public RegistrantDataBoughtTogetherWithTypeItemItemizedCustomFieldsTypeItem[] ItemizedCustomFields { get; set; }

        [JsonProperty("productCategories")]
        public RegistrantDataBoughtTogetherWithTypeItemProductCategoriesTypeItem[] ProductCategories { get; set; }
    }

    public class RegistrantDataBoughtTogetherWithTypeItemItemizedCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RegistrantDataBoughtTogetherWithTypeItemProductCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public bool IsPrimary { get; set; }

        [JsonProperty("subCategories")]
        public RegistrantDataBoughtTogetherWithTypeItemProductCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }
    }

    public class RegistrantDataBoughtTogetherWithTypeItemProductCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public string SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public RegistrantDataPrimaryOrganizationTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public RegistrantDataPrimaryOrganizationTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public RegistrantDataPrimaryOrganizationTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public RegistrantDataPrimaryOrganizationTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public RegistrantDataPrimaryOrganizationTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public RegistrantDataPrimaryOrganizationTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public RegistrantDataPrimaryOrganizationTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public RegistrantDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public RegistrantDataPrimaryOrganizationTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public RegistrantDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RegistrantDataPrimaryOrganizationTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class RegistrantDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public RegistrantDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class RegistrantDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RegistrantDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public RegistrantDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class RegistrantDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RegistrantDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class GetCourseAttendeesResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CourseAttendeeData[] DataList { get; set; }
    }

    public class CourseAttendeeData
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("registeredDate")]
        public string RegisteredDate { get; set; }

        [JsonProperty("attendedDate")]
        public string AttendedDate { get; set; }

        [JsonProperty("itemizedCustomFields")]
        public CourseAttendeeDataItemizedCustomFieldsTypeItem[] ItemizedCustomFields { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("preferredFirstName")]
        public string PreferredFirstName { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("primaryOrganization")]
        public CourseAttendeeDataPrimaryOrganizationType PrimaryOrganization { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("addresses")]
        public CourseAttendeeDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("emails")]
        public CourseAttendeeDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public CourseAttendeeDataPhonesTypeItem[] Phones { get; set; }
    }

    public class CourseAttendeeDataItemizedCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public CourseAttendeeDataPrimaryOrganizationTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public CourseAttendeeDataPrimaryOrganizationTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public CourseAttendeeDataPrimaryOrganizationTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public CourseAttendeeDataPrimaryOrganizationTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public CourseAttendeeDataPrimaryOrganizationTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public CourseAttendeeDataPrimaryOrganizationTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public CourseAttendeeDataPrimaryOrganizationTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public CourseAttendeeDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public CourseAttendeeDataPrimaryOrganizationTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public CourseAttendeeDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CourseAttendeeDataPrimaryOrganizationTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CourseAttendeeDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public CourseAttendeeDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class CourseAttendeeDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CourseAttendeeDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class CourseAttendeeDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public CourseAttendeeDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class CourseAttendeeDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class ExamScoreResultData
    {
        [JsonProperty("individualRecordNumber")]
        public string IndividualRecordNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ExamScoreData
    {
        [JsonProperty("individualRecordNumber")]
        public string IndividualRecordNumber { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class FindMembersByNameResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public ContactData[] DataList { get; set; }
    }

    public class ContactData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public ContactDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public ContactDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public ContactDataPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public ContactDataMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public ContactDataCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public ContactDataCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public ContactDataLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class ContactDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public ContactDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class ContactDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class ContactDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class ContactDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public ContactDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class ContactDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class ContactDataMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("membershipUniqueId")]
        public string MembershipUniqueId { get; set; }

        [JsonProperty("termsList")]
        public ContactDataMembershipsTypeItemTermsListTypeItem[] TermsList { get; set; }
    }

    public class ContactDataMembershipsTypeItemTermsListTypeItem
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class ContactDataCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public ContactDataCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ContactDataCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public string SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ContactDataCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }
    }

    public class ContactDataLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPurchasesForAnIndividualResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public PurchasedItemData[] DataList { get; set; }
    }

    public class PurchasedItemData
    {
        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productType")]
        public string ProductType { get; set; }

        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("itemizedCustomFields")]
        public PurchasedItemDataItemizedCustomFieldsTypeItem[] ItemizedCustomFields { get; set; }

        [JsonProperty("productCategories")]
        public PurchasedItemDataProductCategoriesTypeItem[] ProductCategories { get; set; }
    }

    public class PurchasedItemDataItemizedCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PurchasedItemDataProductCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public PurchasedItemDataProductCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class PurchasedItemDataProductCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public string SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class CustomFieldResultData
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("customFieldName")]
        public string CustomFieldName { get; set; }
    }

    public class CustomFieldValueData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CustomFieldData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ListAllEventCancellationsByEventResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public RegistrantCancellationData[] DataList { get; set; }
    }

    public class RegistrantCancellationData
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("registrationNumber")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("eventCancellationDate")]
        public string EventCancellationDate { get; set; }

        [JsonProperty("guestOfRecordNumber")]
        public string GuestOfRecordNumber { get; set; }

        [JsonProperty("cancelledSessions")]
        public RegistrantCancellationDataCancelledSessionsTypeItem[] CancelledSessions { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("preferredFirstName")]
        public string PreferredFirstName { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("primaryOrganization")]
        public RegistrantCancellationDataPrimaryOrganizationType PrimaryOrganization { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("addresses")]
        public RegistrantCancellationDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("emails")]
        public RegistrantCancellationDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public RegistrantCancellationDataPhonesTypeItem[] Phones { get; set; }
    }

    public class RegistrantCancellationDataCancelledSessionsTypeItem
    {
        [JsonProperty("sessionCode")]
        public string SessionCode { get; set; }

        [JsonProperty("cancellationDate")]
        public string CancellationDate { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public RegistrantCancellationDataPrimaryOrganizationTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public RegistrantCancellationDataPrimaryOrganizationTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public RegistrantCancellationDataPrimaryOrganizationTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public RegistrantCancellationDataPrimaryOrganizationTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public RegistrantCancellationDataPrimaryOrganizationTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public RegistrantCancellationDataPrimaryOrganizationTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public RegistrantCancellationDataPrimaryOrganizationTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public RegistrantCancellationDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public RegistrantCancellationDataPrimaryOrganizationTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public RegistrantCancellationDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RegistrantCancellationDataPrimaryOrganizationTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class RegistrantCancellationDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public RegistrantCancellationDataAddressesTypeItemCountryDataType CountryData { get; set; }

        [JsonProperty("isPreferredShipping")]
        public bool IsPreferredShipping { get; set; }

        [JsonProperty("isPreferredBilling")]
        public bool IsPreferredBilling { get; set; }

        [JsonProperty("isBadAddress")]
        public bool IsBadAddress { get; set; }
    }

    public class RegistrantCancellationDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RegistrantCancellationDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("shownInDirectory")]
        public bool ShownInDirectory { get; set; }
    }

    public class RegistrantCancellationDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public RegistrantCancellationDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class RegistrantCancellationDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetAllOpenOrdersForAnIndividualResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public PayableOrderData[] DataList { get; set; }
    }

    public class PayableOrderData
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("lineItems")]
        public PayableOrderDataLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("totalAmount")]
        public double TotalAmount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class PayableOrderDataLineItemsTypeItem
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }
        public double ItemDiscountTotal { get; set; }
        public double ItemShippingTotal { get; set; }
        public double ItemTaxTotal { get; set; }
        public double ItemTotal { get; set; }
        public double AdditionalInfo { get; set; }
    }

    public class ListCompletedUserTasksByUserIdOrEmailResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public UserTaskData[] DataList { get; set; }
    }

    public class UserTaskData
    {
        [JsonProperty("taskNumber")]
        public string TaskNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignedBy")]
        public string AssignedBy { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }
    }

    public class ListPendingUserTasksByUserIdOrEmailResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public UserTaskData[] DataList { get; set; }
    }

    public class TaskData
    {
        [JsonProperty("taskNumber")]
        public string TaskNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }
    }

    public class ListAllCountriesResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CountryData[] DataList { get; set; }
    }

    public class CountryData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetAllStatesByCountryResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public StateProvinceData[] DataList { get; set; }
    }

    public class StateProvinceData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }
    }

    public class ListAllExhibitsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public ExhibitData[] DataList { get; set; }
    }

    public class ExhibitData
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("categories")]
        public ExhibitDataCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("featuredListing")]
        public ExhibitDataFeaturedListingType FeaturedListing { get; set; }
    }

    public class ExhibitDataCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public ExhibitDataCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ExhibitDataCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public string SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ExhibitDataFeaturedListingType
    {
        [JsonProperty("featuredStartDate")]
        public string FeaturedStartDate { get; set; }

        [JsonProperty("featuredEndDate")]
        public string FeaturedEndDate { get; set; }
    }

    public enum bodysourceInput
    {
        Unknown,
        Email,
        Fax,
        Mail,
        Online,
        Phone
    }

    public class RequestUpdateData
    {
        [JsonProperty("requestNumber")]
        public string RequestNumber { get; set; }

        [JsonProperty("closedDate")]
        public string ClosedDate { get; set; }
    }

    public class SaveCategoryBasicData
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class ListOfCustomerRelationshipsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public RelationshipTypeData[] DataList { get; set; }
    }

    public class RelationshipTypeData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reciprocalRelationshipName")]
        public string ReciprocalRelationshipName { get; set; }

        [JsonProperty("relationshipType")]
        public string RelationshipType { get; set; }

        [JsonProperty("allowPrimary")]
        public bool AllowPrimary { get; set; }

        [JsonProperty("canPurchaseForOrganization")]
        public bool CanPurchaseForOrganization { get; set; }

        [JsonProperty("canManagePAC")]
        public bool CanManagePAC { get; set; }

        [JsonProperty("canManageOrganization")]
        public bool CanManageOrganization { get; set; }
    }

    public class ListAllOpenCustomerRequestResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public RequestData[] DataList { get; set; }
    }

    public class RequestData
    {
        [JsonProperty("requestNumber")]
        public string RequestNumber { get; set; }

        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        [JsonProperty("requestedByCustomerRecordNumber")]
        public string RequestedByCustomerRecordNumber { get; set; }

        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("closedDate")]
        public string ClosedDate { get; set; }
    }

    public class MembershipData
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("membershipUniqueId")]
        public string MembershipUniqueId { get; set; }

        [JsonProperty("termsList")]
        public MembershipDataTermsListTypeItem[] TermsList { get; set; }
    }

    public class MembershipDataTermsListTypeItem
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class IndividualData
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("preferredFirstName")]
        public string PreferredFirstName { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("primaryOrganization")]
        public IndividualDataPrimaryOrganizationType PrimaryOrganization { get; set; }

        [JsonProperty("committees")]
        public IndividualDataCommitteesTypeItem[] Committees { get; set; }

        [JsonProperty("securityRoles")]
        public IndividualDataSecurityRolesTypeItem[] SecurityRoles { get; set; }

        [JsonProperty("user")]
        public IndividualDataUserType User { get; set; }

        [JsonProperty("designationData")]
        public IndividualDataDesignationDataTypeItem[] DesignationData { get; set; }

        [JsonProperty("relationships")]
        public IndividualDataRelationshipsTypeItem[] Relationships { get; set; }

        [JsonProperty("jobRoles")]
        public IndividualDataJobRolesTypeItem[] JobRoles { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public IndividualDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public IndividualDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public IndividualDataPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public IndividualDataMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public IndividualDataCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public IndividualDataCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public IndividualDataLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }

        [JsonProperty("isDeceased")]
        public bool IsDeceased { get; set; }
    }

    public class IndividualDataPrimaryOrganizationType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public IndividualDataPrimaryOrganizationTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public IndividualDataPrimaryOrganizationTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public IndividualDataPrimaryOrganizationTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public IndividualDataPrimaryOrganizationTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public IndividualDataPrimaryOrganizationTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public IndividualDataPrimaryOrganizationTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public IndividualDataPrimaryOrganizationTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public IndividualDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public IndividualDataPrimaryOrganizationTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public IndividualDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class IndividualDataPrimaryOrganizationTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class IndividualDataCommitteesTypeItem
    {
        [JsonProperty("committee")]
        public IndividualDataCommitteesTypeItemCommitteeType Committee { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class IndividualDataCommitteesTypeItemCommitteeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentCommitteeId")]
        public string ParentCommitteeId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("term")]
        public IndividualDataCommitteesTypeItemCommitteeTypeTermType Term { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class IndividualDataCommitteesTypeItemCommitteeTypeTermType
    {
        [JsonProperty("term")]
        public int Term { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class IndividualDataSecurityRolesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataUserType
    {
        [JsonProperty("loginEmail")]
        public string LoginEmail { get; set; }

        [JsonProperty("mustChangePassword")]
        public bool MustChangePassword { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }
    }

    public class IndividualDataDesignationDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataRelationshipsTypeItem
    {
        [JsonProperty("relationshipName")]
        public string RelationshipName { get; set; }

        [JsonProperty("relatedToCustomer")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerType RelatedToCustomer { get; set; }

        [JsonProperty("reciprocalRelationshipName")]
        public string ReciprocalRelationshipName { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public IndividualDataRelationshipsTypeItemRelatedToCustomerTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class IndividualDataRelationshipsTypeItemRelatedToCustomerTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class IndividualDataJobRolesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public IndividualDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class IndividualDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class IndividualDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class IndividualDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public IndividualDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class IndividualDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class IndividualDataMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class IndividualDataCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public IndividualDataCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IndividualDataCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class IndividualDataLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ListOfAllOrganizationMembersResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public OrganizationData[] DataList { get; set; }
    }

    public class OrganizationData
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public OrganizationDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public OrganizationDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public OrganizationDataPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public OrganizationDataMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public OrganizationDataCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public OrganizationDataCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public OrganizationDataLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class OrganizationDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public OrganizationDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class OrganizationDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class OrganizationDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class OrganizationDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public OrganizationDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class OrganizationDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class OrganizationDataMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class OrganizationDataCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public OrganizationDataCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OrganizationDataCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OrganizationDataCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class OrganizationDataLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ListOfAllIndividualMembersResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public IndividualData[] DataList { get; set; }
    }

    public class GetListOfActiveCertificationsForAnOrganizationResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CertificationData[] DataList { get; set; }
    }

    public class CertificationData
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }
    }

    public class GetListOfActiveCertificationsForAnIndividualResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CertificationData[] DataList { get; set; }
    }

    public class SessionRegistrationData
    {
        [JsonProperty("sessionCode")]
        public string SessionCode { get; set; }
    }

    public class GetAListOfLicensesResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public LicenseData[] DataList { get; set; }
    }

    public class LicenseData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("licenseType")]
        public string LicenseType { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class ListAllAwardsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public AwardData[] DataList { get; set; }
    }

    public class AwardData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("allowPublicNomination")]
        public bool AllowPublicNomination { get; set; }

        [JsonProperty("nominationStartDate")]
        public string NominationStartDate { get; set; }

        [JsonProperty("nominationEndDate")]
        public string NominationEndDate { get; set; }
    }

    public class FindMembersOrIndividualsByNameResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public IndividualData[] DataList { get; set; }
    }

    public class GetAListOfAllServicesOfAnOrganizationResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public ServiceData[] DataList { get; set; }
    }

    public class ServiceData
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PhoneDataSet
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public PhoneDataSetCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class PhoneDataSetCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public enum bodytypeNameInput
    {
        Home,
        Work,
        Mobile,
        Fax,
        TollFree,
        Other,
        Main
    }

    public enum bodytypeInput
    {
        Home,
        Work,
        Other
    }

    public class GetNomineesByCommitteeResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CommitteeNomineeData[] DataList { get; set; }
    }

    public class CommitteeNomineeData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("primaryOrganization")]
        public CommitteeNomineeDataPrimaryOrganizationType PrimaryOrganization { get; set; }

        [JsonProperty("organizationRepresenting")]
        public CommitteeNomineeDataOrganizationRepresentingType OrganizationRepresenting { get; set; }

        [JsonProperty("nominatedByCustomer")]
        public CommitteeNomineeDataNominatedByCustomerType NominatedByCustomer { get; set; }

        [JsonProperty("addresses")]
        public CommitteeNomineeDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("phones")]
        public CommitteeNomineeDataPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("emails")]
        public CommitteeNomineeDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public CommitteeNomineeDataPrimaryOrganizationTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public CommitteeNomineeDataPrimaryOrganizationTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public CommitteeNomineeDataPrimaryOrganizationTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public CommitteeNomineeDataPrimaryOrganizationTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public CommitteeNomineeDataPrimaryOrganizationTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public CommitteeNomineeDataPrimaryOrganizationTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public CommitteeNomineeDataPrimaryOrganizationTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public CommitteeNomineeDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public CommitteeNomineeDataPrimaryOrganizationTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public CommitteeNomineeDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CommitteeNomineeDataPrimaryOrganizationTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public CommitteeNomineeDataOrganizationRepresentingTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public CommitteeNomineeDataOrganizationRepresentingTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public CommitteeNomineeDataOrganizationRepresentingTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public CommitteeNomineeDataOrganizationRepresentingTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public CommitteeNomineeDataOrganizationRepresentingTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public CommitteeNomineeDataOrganizationRepresentingTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public CommitteeNomineeDataOrganizationRepresentingTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public CommitteeNomineeDataOrganizationRepresentingTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public CommitteeNomineeDataOrganizationRepresentingTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public CommitteeNomineeDataOrganizationRepresentingTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CommitteeNomineeDataOrganizationRepresentingTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public CommitteeNomineeDataNominatedByCustomerTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public CommitteeNomineeDataNominatedByCustomerTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public CommitteeNomineeDataNominatedByCustomerTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public CommitteeNomineeDataNominatedByCustomerTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public CommitteeNomineeDataNominatedByCustomerTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public CommitteeNomineeDataNominatedByCustomerTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public CommitteeNomineeDataNominatedByCustomerTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public CommitteeNomineeDataNominatedByCustomerTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public CommitteeNomineeDataNominatedByCustomerTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public CommitteeNomineeDataNominatedByCustomerTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CommitteeNomineeDataNominatedByCustomerTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CommitteeNomineeDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public CommitteeNomineeDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class CommitteeNomineeDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CommitteeNomineeDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public CommitteeNomineeDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class CommitteeNomineeDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class CommitteeNomineeDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class GetOrganizationsActiveSubscriptionsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public SubscriptionData[] DataList { get; set; }
    }

    public class SubscriptionData
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class GetOrganizationsRelationshipsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public RelationshipData[] DataList { get; set; }
    }

    public class RelationshipData
    {
        [JsonProperty("relationshipName")]
        public string RelationshipName { get; set; }

        [JsonProperty("relatedToCustomer")]
        public RelationshipDataRelatedToCustomerType RelatedToCustomer { get; set; }

        [JsonProperty("reciprocalRelationshipName")]
        public string ReciprocalRelationshipName { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class RelationshipDataRelatedToCustomerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public RelationshipDataRelatedToCustomerTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("emails")]
        public RelationshipDataRelatedToCustomerTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public RelationshipDataRelatedToCustomerTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public RelationshipDataRelatedToCustomerTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public RelationshipDataRelatedToCustomerTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public RelationshipDataRelatedToCustomerTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public RelationshipDataRelatedToCustomerTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public RelationshipDataRelatedToCustomerTypeAddressesTypeItemCountryDataType CountryData { get; set; }

        [JsonProperty("isPreferredShipping")]
        public bool IsPreferredShipping { get; set; }

        [JsonProperty("isPreferredBilling")]
        public bool IsPreferredBilling { get; set; }

        [JsonProperty("isBadAddress")]
        public bool IsBadAddress { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("membershipUniqueId")]
        public string MembershipUniqueId { get; set; }

        [JsonProperty("termsList")]
        public RelationshipDataRelatedToCustomerTypeMembershipsTypeItemTermsListTypeItem[] TermsList { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeMembershipsTypeItemTermsListTypeItem
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public RelationshipDataRelatedToCustomerTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public string SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RelationshipDataRelatedToCustomerTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AddressSaveData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public AddressSaveDataTypeType Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("isPreferredShipping")]
        public bool IsPreferredShipping { get; set; }

        [JsonProperty("isPreferredBilling")]
        public bool IsPreferredBilling { get; set; }

        [JsonProperty("isBadAddress")]
        public bool IsBadAddress { get; set; }
    }

    public enum AddressSaveDataTypeType
    {
        Home,
        Work,
        Other
    }

    public class bodyInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetUpcomingEventsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public EventData[] DataList { get; set; }
    }

    public class EventData
    {
        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("eventCode")]
        public string EventCode { get; set; }

        [JsonProperty("eventName")]
        public string EventName { get; set; }

        [JsonProperty("eventStartDate")]
        public string EventStartDate { get; set; }

        [JsonProperty("eventStartTime")]
        public string EventStartTime { get; set; }

        [JsonProperty("eventEndDate")]
        public string EventEndDate { get; set; }

        [JsonProperty("eventEndTime")]
        public string EventEndTime { get; set; }

        [JsonProperty("eventTimezone")]
        public string EventTimezone { get; set; }

        [JsonProperty("eventDescription")]
        public string EventDescription { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("publicEvent")]
        public bool PublicEvent { get; set; }

        [JsonProperty("imageUrl")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("externalUrl")]
        public string ExternalUrl { get; set; }

        [JsonProperty("externalCode")]
        public string ExternalCode { get; set; }

        [JsonProperty("eventLocations")]
        public EventDataEventLocationsTypeItem[] EventLocations { get; set; }

        [JsonProperty("categories")]
        public EventDataCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("educationCredits")]
        public EventDataEducationCreditsTypeItem[] EducationCredits { get; set; }

        [JsonProperty("uploadsData")]
        public EventDataUploadsDataTypeItem[] UploadsData { get; set; }

        [JsonProperty("relatedProducts")]
        public EventDataRelatedProductsTypeItem[] RelatedProducts { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class EventDataEventLocationsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("addresses")]
        public EventDataEventLocationsTypeItemAddressesTypeItem[] Addresses { get; set; }
    }

    public class EventDataEventLocationsTypeItemAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public EventDataEventLocationsTypeItemAddressesTypeItemCountryDataType CountryData { get; set; }

        [JsonProperty("isPreferredShipping")]
        public bool IsPreferredShipping { get; set; }

        [JsonProperty("isPreferredBilling")]
        public bool IsPreferredBilling { get; set; }

        [JsonProperty("isBadAddress")]
        public bool IsBadAddress { get; set; }
    }

    public class EventDataEventLocationsTypeItemAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class EventDataCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public EventDataCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class EventDataCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public string SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class EventDataEducationCreditsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("credits")]
        public double Credits { get; set; }
    }

    public class EventDataUploadsDataTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class EventDataRelatedProductsTypeItem
    {
        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("imageUrl")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("availableFrom")]
        public string AvailableFrom { get; set; }

        [JsonProperty("availableUntil")]
        public string AvailableUntil { get; set; }
    }

    public class GetCommitteeInformationForAnIndividualResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CommitteeMemberData[] DataList { get; set; }
    }

    public class CommitteeMemberData
    {
        [JsonProperty("committee")]
        public CommitteeMemberDataCommitteeType Committee { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class CommitteeMemberDataCommitteeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentCommitteeId")]
        public string ParentCommitteeId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("term")]
        public CommitteeMemberDataCommitteeTypeTermType Term { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class CommitteeMemberDataCommitteeTypeTermType
    {
        [JsonProperty("term")]
        public int Term { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class GetAllEventsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public EventData[] DataList { get; set; }
    }

    public class GetAllEventRegistrationsInformationForAnIndividualResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public RegistrationData[] DataList { get; set; }
    }

    public class RegistrationData
    {
        [JsonProperty("individualId")]
        public string IndividualId { get; set; }

        [JsonProperty("event")]
        public RegistrationDataEventType Event { get; set; }

        [JsonProperty("sessions")]
        public RegistrationDataSessionsTypeItem[] Sessions { get; set; }

        [JsonProperty("badgeName")]
        public string BadgeName { get; set; }

        [JsonProperty("badgeOrganization")]
        public string BadgeOrganization { get; set; }

        [JsonProperty("badgeCity")]
        public string BadgeCity { get; set; }

        [JsonProperty("badgeState")]
        public string BadgeState { get; set; }

        [JsonProperty("boughtTogetherWith")]
        public RegistrationDataBoughtTogetherWithTypeItem[] BoughtTogetherWith { get; set; }

        [JsonProperty("registrantTypeCode")]
        public string RegistrantTypeCode { get; set; }

        [JsonProperty("registrantTypeName")]
        public string RegistrantTypeName { get; set; }

        [JsonProperty("registrationNumber")]
        public string RegistrationNumber { get; set; }
    }

    public class RegistrationDataEventType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("publicEvent")]
        public bool PublicEvent { get; set; }

        [JsonProperty("freeEvent")]
        public bool FreeEvent { get; set; }

        [JsonProperty("attendedDate")]
        public string AttendedDate { get; set; }

        [JsonProperty("locations")]
        public RegistrationDataEventTypeLocationsTypeItem[] Locations { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("customFields")]
        public RegistrationDataEventTypeCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class RegistrationDataEventTypeLocationsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("addresses")]
        public RegistrationDataEventTypeLocationsTypeItemAddressesTypeItem[] Addresses { get; set; }
    }

    public class RegistrationDataEventTypeLocationsTypeItemAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public RegistrationDataEventTypeLocationsTypeItemAddressesTypeItemCountryDataType CountryData { get; set; }

        [JsonProperty("isPreferredShipping")]
        public bool IsPreferredShipping { get; set; }

        [JsonProperty("isPreferredBilling")]
        public bool IsPreferredBilling { get; set; }

        [JsonProperty("isBadAddress")]
        public bool IsBadAddress { get; set; }
    }

    public class RegistrationDataEventTypeLocationsTypeItemAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class RegistrationDataEventTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RegistrationDataSessionsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("freeSession")]
        public bool FreeSession { get; set; }

        [JsonProperty("attendedDate")]
        public string AttendedDate { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("externalCode")]
        public string ExternalCode { get; set; }

        [JsonProperty("customFields")]
        public RegistrationDataSessionsTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class RegistrationDataSessionsTypeItemCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RegistrationDataBoughtTogetherWithTypeItem
    {
        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productType")]
        public string ProductType { get; set; }

        [JsonProperty("purchaseDate")]
        public string PurchaseDate { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("itemizedCustomFields")]
        public RegistrationDataBoughtTogetherWithTypeItemItemizedCustomFieldsTypeItem[] ItemizedCustomFields { get; set; }

        [JsonProperty("productCategories")]
        public RegistrationDataBoughtTogetherWithTypeItemProductCategoriesTypeItem[] ProductCategories { get; set; }
    }

    public class RegistrationDataBoughtTogetherWithTypeItemItemizedCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RegistrationDataBoughtTogetherWithTypeItemProductCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        public bool IsPrimary { get; set; }

        [JsonProperty("subCategories")]
        public RegistrationDataBoughtTogetherWithTypeItemProductCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }
    }

    public class RegistrationDataBoughtTogetherWithTypeItemProductCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public string SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public class GetIndividualsRelationshipsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public RelationshipData[] DataList { get; set; }
    }

    public class EmailData
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class FindMembersOrIndividualsByFirstAndLastNameResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public IndividualData[] DataList { get; set; }
    }

    public class FindIndividualIdOrEmailResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public IndividualData[] DataList { get; set; }
    }

    public class IndividualsLookupByNameResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public IndividualLookupBasicData[] DataList { get; set; }
    }

    public class IndividualLookupBasicData
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("preferredFirstName")]
        public string PreferredFirstName { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("primaryOrganization")]
        public IndividualLookupBasicDataPrimaryOrganizationType PrimaryOrganization { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }
    }

    public class IndividualLookupBasicDataPrimaryOrganizationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("employeeRangeId")]
        public string EmployeeRangeId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("addresses")]
        public IndividualLookupBasicDataPrimaryOrganizationTypeAddressesTypeItem[] Addresses { get; set; }
    }

    public class IndividualLookupBasicDataPrimaryOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public IndividualLookupBasicDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class IndividualLookupBasicDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("primaryOrganization")]
        public AddToCommitteeResponsePrimaryOrganizationType PrimaryOrganization { get; set; }

        [JsonProperty("organizationRepresenting")]
        public AddToCommitteeResponseOrganizationRepresentingType OrganizationRepresenting { get; set; }

        [JsonProperty("nominatedByCustomer")]
        public AddToCommitteeResponseNominatedByCustomerType NominatedByCustomer { get; set; }

        [JsonProperty("addresses")]
        public AddToCommitteeResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("phones")]
        public AddToCommitteeResponsePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("emails")]
        public AddToCommitteeResponseEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public AddToCommitteeResponsePrimaryOrganizationTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public AddToCommitteeResponsePrimaryOrganizationTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public AddToCommitteeResponsePrimaryOrganizationTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public AddToCommitteeResponsePrimaryOrganizationTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public AddToCommitteeResponsePrimaryOrganizationTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public AddToCommitteeResponsePrimaryOrganizationTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public AddToCommitteeResponsePrimaryOrganizationTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public AddToCommitteeResponsePrimaryOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public AddToCommitteeResponsePrimaryOrganizationTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public AddToCommitteeResponsePrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AddToCommitteeResponsePrimaryOrganizationTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public AddToCommitteeResponseOrganizationRepresentingTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public AddToCommitteeResponseOrganizationRepresentingTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public AddToCommitteeResponseOrganizationRepresentingTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public AddToCommitteeResponseOrganizationRepresentingTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public AddToCommitteeResponseOrganizationRepresentingTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public AddToCommitteeResponseOrganizationRepresentingTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public AddToCommitteeResponseOrganizationRepresentingTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public AddToCommitteeResponseOrganizationRepresentingTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public AddToCommitteeResponseOrganizationRepresentingTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public AddToCommitteeResponseOrganizationRepresentingTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AddToCommitteeResponseOrganizationRepresentingTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public AddToCommitteeResponseNominatedByCustomerTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public AddToCommitteeResponseNominatedByCustomerTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public AddToCommitteeResponseNominatedByCustomerTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public AddToCommitteeResponseNominatedByCustomerTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public AddToCommitteeResponseNominatedByCustomerTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public AddToCommitteeResponseNominatedByCustomerTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public AddToCommitteeResponseNominatedByCustomerTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public AddToCommitteeResponseNominatedByCustomerTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public AddToCommitteeResponseNominatedByCustomerTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public AddToCommitteeResponseNominatedByCustomerTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AddToCommitteeResponseNominatedByCustomerTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AddToCommitteeResponseAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public AddToCommitteeResponseAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class AddToCommitteeResponseAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponsePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public AddToCommitteeResponsePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class AddToCommitteeResponsePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AddToCommitteeResponseEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class OrganizationLookupByNameResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public OrganizationLookupBasicData[] DataList { get; set; }
    }

    public class OrganizationLookupBasicData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("employeeRangeId")]
        public string EmployeeRangeId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("addresses")]
        public OrganizationLookupBasicDataAddressesTypeItem[] Addresses { get; set; }
    }

    public class OrganizationLookupBasicDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public OrganizationLookupBasicDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class OrganizationLookupBasicDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class GetAllCommitteesResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CommitteeData[] DataList { get; set; }
    }

    public class CommitteeData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentCommitteeId")]
        public string ParentCommitteeId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("term")]
        public CommitteeDataTermType Term { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class CommitteeDataTermType
    {
        [JsonProperty("term")]
        public int Term { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class GetPositionsByCommitteeResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CommitteePositionData[] DataList { get; set; }
    }

    public class CommitteePositionData
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("term")]
        public int Term { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }
    }

    public class GetSubCommitteesResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public CommitteeData[] DataList { get; set; }
    }

    public class GetIndividualsActiveSubscriptionsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public SubscriptionData[] DataList { get; set; }
    }

    public class ListAllIndividualsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public IndividualData[] DataList { get; set; }
    }

    public class FindCustomerPhoneResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public FindCustomerPhoneResponseDataListTypeItem[] DataList { get; set; }
    }

    public class FindCustomerPhoneResponseDataListTypeItem
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("addresses")]
        public FindCustomerPhoneResponseDataListTypeItemAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("emails")]
        public FindCustomerPhoneResponseDataListTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public FindCustomerPhoneResponseDataListTypeItemPhonesTypeItem[] Phones { get; set; }
    }

    public class FindCustomerPhoneResponseDataListTypeItemAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public FindCustomerPhoneResponseDataListTypeItemAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class FindCustomerPhoneResponseDataListTypeItemAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class FindCustomerPhoneResponseDataListTypeItemEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class FindCustomerPhoneResponseDataListTypeItemPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public FindCustomerPhoneResponseDataListTypeItemPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class FindCustomerPhoneResponseDataListTypeItemPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class bodyInputItem2
    {
        [JsonProperty("eventOrSessionCode")]
        public string EventOrSessionCode { get; set; }
    }

    public enum awardNominationDatastatusInput
    {
        [EnumMember(Value = "")]
        None,
        Pending,
        Rejected,
        Awarded
    }

    public class AwardsGetIndividualAwardRecipientsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public AwardRecipientIndividualData[] DataList { get; set; }
    }

    public class AwardRecipientIndividualData
    {
        [JsonProperty("awardedDate")]
        public string AwardedDate { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("preferredFirstName")]
        public string PreferredFirstName { get; set; }

        [JsonProperty("secondLastName")]
        public string SecondLastName { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("primaryOrganization")]
        public AwardRecipientIndividualDataPrimaryOrganizationType PrimaryOrganization { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("addresses")]
        public AwardRecipientIndividualDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("emails")]
        public AwardRecipientIndividualDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public AwardRecipientIndividualDataPhonesTypeItem[] Phones { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationType
    {
        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("parentCompanyId")]
        public string ParentCompanyId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("addresses")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("imageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }

        [JsonProperty("emails")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypePhonesTypeItem[] Phones { get; set; }

        [JsonProperty("webSite")]
        public string WebSite { get; set; }

        [JsonProperty("memberships")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypeMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categories")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("customFields")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("links")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("oldId")]
        public string OldId { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypeAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypeAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypeEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypePhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypePhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypePhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypeMembershipsTypeItem
    {
        [JsonProperty("membershipType")]
        public string MembershipType { get; set; }

        [JsonProperty("membershipTypeId")]
        public string MembershipTypeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("expireDate")]
        public string ExpireDate { get; set; }

        [JsonProperty("graceExpireDate")]
        public string GraceExpireDate { get; set; }

        [JsonProperty("inheritedMembershipBenefits")]
        public bool InheritedMembershipBenefits { get; set; }

        [JsonProperty("renewalUrl")]
        public string RenewalUrl { get; set; }

        [JsonProperty("joinDate")]
        public string JoinDate { get; set; }

        [JsonProperty("terminateDate")]
        public string TerminateDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypeCategoriesTypeItem
    {
        [JsonProperty("subCategories")]
        public AwardRecipientIndividualDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypeCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypeCustomFieldsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AwardRecipientIndividualDataPrimaryOrganizationTypeLinksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class AwardRecipientIndividualDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public AwardRecipientIndividualDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class AwardRecipientIndividualDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AwardRecipientIndividualDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class AwardRecipientIndividualDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public AwardRecipientIndividualDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class AwardRecipientIndividualDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AwardsGetOrganizationAwardRecipientsResponse
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("dataList")]
        public AwardRecipientOrganizationData[] DataList { get; set; }
    }

    public class AwardRecipientOrganizationData
    {
        [JsonProperty("awardedDate")]
        public string AwardedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("branchName")]
        public string BranchName { get; set; }

        [JsonProperty("annualSales")]
        public double AnnualSales { get; set; }

        [JsonProperty("employeeRangeId")]
        public string EmployeeRangeId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("recordNumber")]
        public string RecordNumber { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("addresses")]
        public AwardRecipientOrganizationDataAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("emails")]
        public AwardRecipientOrganizationDataEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("phones")]
        public AwardRecipientOrganizationDataPhonesTypeItem[] Phones { get; set; }
    }

    public class AwardRecipientOrganizationDataAddressesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("stateAbbreviation")]
        public string StateAbbreviation { get; set; }

        [JsonProperty("stateISOCode")]
        public string StateISOCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("congressionalDistrict")]
        public string CongressionalDistrict { get; set; }

        [JsonProperty("countryData")]
        public AwardRecipientOrganizationDataAddressesTypeItemCountryDataType CountryData { get; set; }
    }

    public class AwardRecipientOrganizationDataAddressesTypeItemCountryDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class AwardRecipientOrganizationDataEmailsTypeItem
    {
        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }
    }

    public class AwardRecipientOrganizationDataPhonesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("country")]
        public AwardRecipientOrganizationDataPhonesTypeItemCountryType Country { get; set; }

        [JsonProperty("showInDirectory")]
        public bool ShowInDirectory { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }
    }

    public class AwardRecipientOrganizationDataPhonesTypeItemCountryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("twoLetterIsoCode")]
        public string TwoLetterIsoCode { get; set; }

        [JsonProperty("threeLetterIsoCode")]
        public string ThreeLetterIsoCode { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Impexium;

    public partial class WorkflowManagedActions
    {
        public ImpexiumActions Impexium(string connectionId) => new ImpexiumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImpexiumTriggers Impexium(string connectionId) => new ImpexiumTriggers(connectionId);
    }
}