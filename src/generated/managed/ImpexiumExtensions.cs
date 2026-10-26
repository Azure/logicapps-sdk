//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Impexium
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImpexiumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAbandonedCheckoutsResponse, ApiConnectionActionConfiguration> GetAbandonedCheckouts(Expression<Func<int>> pageNumber, Expression<Func<string>> abandonedFrom, Expression<Func<string>> productCode = null, Expression<Func<string>> customerRecordNumber = null)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_abandonedFrom = WorkflowExpression.Compile(abandonedFrom, nameof(abandonedFrom), required: true);
            var __workflow_productCode = WorkflowExpression.Compile(productCode, nameof(productCode), required: false);
            var __workflow_customerRecordNumber = WorkflowExpression.Compile(customerRecordNumber, nameof(customerRecordNumber), required: false);
            return new DeferredBodyAction<GetAbandonedCheckoutsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Shopping/AbandonedCheckOuts/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["abandonedFrom"] = ExpressionConverter.Convert(__workflow_abandonedFrom);
                if (__workflow_productCode != null)
                    callPayload.Queries["productCode"] = ExpressionConverter.Convert(__workflow_productCode);
                if (__workflow_customerRecordNumber != null)
                    callPayload.Queries["customerRecordNumber"] = ExpressionConverter.Convert(__workflow_customerRecordNumber);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetAbandonedCheckoutsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllExhibitorsResponse, ApiConnectionActionConfiguration> ListAllExhibitors(Expression<Func<string>> exhibitCode, Expression<Func<int>> pageNumber)
        {
            var __workflow_exhibitCode = WorkflowExpression.Compile(exhibitCode, nameof(exhibitCode), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<ListAllExhibitorsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Exhibits/{0}/Exhibitors/{1}", __workflow_exhibitCode.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListAllExhibitorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfExamsResponse, ApiConnectionActionConfiguration> ListOfExams(Expression<Func<int>> pageNumber, Expression<Func<string>> code = null, Expression<Func<string>> categoryName = null, Expression<Func<bool>> isPublic = null, Expression<Func<string>> changedSince = null, Expression<Func<string>> tag = null, Expression<Func<bool>> includePrices = null)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: false);
            var __workflow_categoryName = WorkflowExpression.Compile(categoryName, nameof(categoryName), required: false);
            var __workflow_isPublic = WorkflowExpression.Compile(isPublic, nameof(isPublic), required: false);
            var __workflow_changedSince = WorkflowExpression.Compile(changedSince, nameof(changedSince), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_includePrices = WorkflowExpression.Compile(includePrices, nameof(includePrices), required: false);
            return new DeferredBodyAction<ListOfExamsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Products/Exams/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_categoryName != null)
                    callPayload.Queries["categoryName"] = ExpressionConverter.Convert(__workflow_categoryName);
                if (__workflow_isPublic != null)
                    callPayload.Queries["isPublic"] = ExpressionConverter.Convert(__workflow_isPublic);
                if (__workflow_changedSince != null)
                    callPayload.Queries["changedSince"] = ExpressionConverter.Convert(__workflow_changedSince);
                if (__workflow_tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_includePrices != null)
                    callPayload.Queries["includePrices"] = ExpressionConverter.Convert(__workflow_includePrices);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListOfExamsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListRegistrantsResponse, ApiConnectionActionConfiguration> ListRegistrants(Expression<Func<string>> eventCode, Expression<Func<int>> pageNumber, Expression<Func<string>> sessionCode = null, Expression<Func<bool>> includeDetails = null, Expression<Func<string>> registeredSince = null)
        {
            var __workflow_eventCode = WorkflowExpression.Compile(eventCode, nameof(eventCode), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_sessionCode = WorkflowExpression.Compile(sessionCode, nameof(sessionCode), required: false);
            var __workflow_includeDetails = WorkflowExpression.Compile(includeDetails, nameof(includeDetails), required: false);
            var __workflow_registeredSince = WorkflowExpression.Compile(registeredSince, nameof(registeredSince), required: false);
            return new DeferredBodyAction<ListRegistrantsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Events/{0}/Registrations/{1}", __workflow_eventCode.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionCode != null)
                    callPayload.Queries["sessionCode"] = ExpressionConverter.Convert(__workflow_sessionCode);
                if (__workflow_includeDetails != null)
                    callPayload.Queries["includeDetails"] = ExpressionConverter.Convert(__workflow_includeDetails);
                if (__workflow_registeredSince != null)
                    callPayload.Queries["registeredSince"] = ExpressionConverter.Convert(__workflow_registeredSince);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListRegistrantsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetCourseAttendeesResponse, ApiConnectionActionConfiguration> GetCourseAttendees(Expression<Func<string>> code, Expression<Func<int>> pageNumber)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetCourseAttendeesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Courses/{0}/Attendees/{1}", __workflow_code.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCourseAttendeesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ExamScoreResultData[], ApiConnectionActionConfiguration> AddExamScores(Expression<Func<string>> examCode, Expression<Func<ExamScoreData[]>> scores = null)
        {
            var __workflow_examCode = WorkflowExpression.Compile(examCode, nameof(examCode), required: true);
            var __workflow_scores = WorkflowExpression.Compile(scores, nameof(scores), required: false);
            return new DeferredBodyAction<ExamScoreResultData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Exams/{0}/Scores", __workflow_examCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_scores);
                return new ApiConnectionAction<ExamScoreResultData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersByNameResponse, ApiConnectionActionConfiguration> FindMembersByName(Expression<Func<string>> name, Expression<Func<int>> pageNumber)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<FindMembersByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Customers/Members/FindByName/{0}/{1}", __workflow_name.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<FindMembersByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetPurchasesForAnIndividualResponse, ApiConnectionActionConfiguration> GetPurchasesForAnIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<int>> pageNumber, Expression<Func<string>> productCode = null, Expression<Func<string>> purchasedSince = null, Expression<Func<string>> productCategoryCode = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_productCode = WorkflowExpression.Compile(productCode, nameof(productCode), required: false);
            var __workflow_purchasedSince = WorkflowExpression.Compile(purchasedSince, nameof(purchasedSince), required: false);
            var __workflow_productCategoryCode = WorkflowExpression.Compile(productCategoryCode, nameof(productCategoryCode), required: false);
            return new DeferredBodyAction<GetPurchasesForAnIndividualResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Purchases/{1}", __workflow_idOrRecordNumber.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_productCode != null)
                    callPayload.Queries["productCode"] = ExpressionConverter.Convert(__workflow_productCode);
                if (__workflow_purchasedSince != null)
                    callPayload.Queries["purchasedSince"] = ExpressionConverter.Convert(__workflow_purchasedSince);
                if (__workflow_productCategoryCode != null)
                    callPayload.Queries["productCategoryCode"] = ExpressionConverter.Convert(__workflow_productCategoryCode);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetPurchasesForAnIndividualResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldResultData[], ApiConnectionActionConfiguration> AddOrUpdateAListOfCustomFieldsPerOrganization(Expression<Func<string>> idOrRecordNumber, Expression<Func<CustomFieldValueData[]>> body = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomFieldResultData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/CustomFieldsList", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomFieldResultData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddNominee(Expression<Func<string>> code, Expression<Func<string>> bodynomineeRecordNumber = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyrepresentingOrganizationRecordNumber = null, Expression<Func<string>> bodyrepresentingOrganizationRelationshipName = null, Expression<Func<string>> bodynominatedByCustomerRecordNumber = null, Expression<Func<int>> bodycommitteeTerm = null, Expression<Func<int>> bodyrank = null)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_bodynomineeRecordNumber = WorkflowExpression.Compile(bodynomineeRecordNumber, nameof(bodynomineeRecordNumber), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodypositionCode = WorkflowExpression.Compile(bodypositionCode, nameof(bodypositionCode), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyrepresentingOrganizationRecordNumber = WorkflowExpression.Compile(bodyrepresentingOrganizationRecordNumber, nameof(bodyrepresentingOrganizationRecordNumber), required: false);
            var __workflow_bodyrepresentingOrganizationRelationshipName = WorkflowExpression.Compile(bodyrepresentingOrganizationRelationshipName, nameof(bodyrepresentingOrganizationRelationshipName), required: false);
            var __workflow_bodynominatedByCustomerRecordNumber = WorkflowExpression.Compile(bodynominatedByCustomerRecordNumber, nameof(bodynominatedByCustomerRecordNumber), required: false);
            var __workflow_bodycommitteeTerm = WorkflowExpression.Compile(bodycommitteeTerm, nameof(bodycommitteeTerm), required: false);
            var __workflow_bodyrank = WorkflowExpression.Compile(bodyrank, nameof(bodyrank), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Committees/{0}/Nominations", __workflow_code.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodynomineeRecordNumber != null)
                {
                    body["nomineeRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodynomineeRecordNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodypositionCode != null)
                {
                    body["positionCode"] = ExpressionConverter.ConvertO(__workflow_bodypositionCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentingOrganizationRecordNumber != null)
                {
                    body["representingOrganizationRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentingOrganizationRecordNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentingOrganizationRelationshipName != null)
                {
                    body["representingOrganizationRelationshipName"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentingOrganizationRelationshipName);
                    bodypropCount++;
                }

                if (__workflow_bodynominatedByCustomerRecordNumber != null)
                {
                    body["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodynominatedByCustomerRecordNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycommitteeTerm != null)
                {
                    body["committeeTerm"] = ExpressionConverter.ConvertO(__workflow_bodycommitteeTerm);
                    bodypropCount++;
                }

                if (__workflow_bodyrank != null)
                {
                    body["rank"] = ExpressionConverter.ConvertO(__workflow_bodyrank);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldData[], ApiConnectionActionConfiguration> GetIndividualCustomFieldValues(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CustomFieldData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/CustomFields", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CustomFieldData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateCustomFieldValue(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycaption = null, Expression<Func<string>> bodyvalue = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycaption = WorkflowExpression.Compile(bodycaption, nameof(bodycaption), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/CustomFields", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycaption != null)
                {
                    body["caption"] = ExpressionConverter.ConvertO(__workflow_bodycaption);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllEventCancellationsByEventResponse, ApiConnectionActionConfiguration> ListAllEventCancellationsByEvent(Expression<Func<string>> eventCode, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeDetails = null, Expression<Func<string>> cancelledSince = null)
        {
            var __workflow_eventCode = WorkflowExpression.Compile(eventCode, nameof(eventCode), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_includeDetails = WorkflowExpression.Compile(includeDetails, nameof(includeDetails), required: false);
            var __workflow_cancelledSince = WorkflowExpression.Compile(cancelledSince, nameof(cancelledSince), required: false);
            return new DeferredBodyAction<ListAllEventCancellationsByEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Events/{0}/Cancellations/{1}", __workflow_eventCode.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeDetails != null)
                    callPayload.Queries["includeDetails"] = ExpressionConverter.Convert(__workflow_includeDetails);
                if (__workflow_cancelledSince != null)
                    callPayload.Queries["cancelledSince"] = ExpressionConverter.Convert(__workflow_cancelledSince);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListAllEventCancellationsByEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllOpenOrdersForAnIndividualResponse, ApiConnectionActionConfiguration> GetAllOpenOrdersForAnIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeLineItems = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_includeLineItems = WorkflowExpression.Compile(includeLineItems, nameof(includeLineItems), required: false);
            var __workflow_fromDate = WorkflowExpression.Compile(fromDate, nameof(fromDate), required: false);
            var __workflow_toDate = WorkflowExpression.Compile(toDate, nameof(toDate), required: false);
            return new DeferredBodyAction<GetAllOpenOrdersForAnIndividualResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Orders/Open/{1}", __workflow_idOrRecordNumber.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeLineItems != null)
                    callPayload.Queries["includeLineItems"] = ExpressionConverter.Convert(__workflow_includeLineItems);
                if (__workflow_fromDate != null)
                    callPayload.Queries["fromDate"] = ExpressionConverter.Convert(__workflow_fromDate);
                if (__workflow_toDate != null)
                    callPayload.Queries["toDate"] = ExpressionConverter.Convert(__workflow_toDate);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetAllOpenOrdersForAnIndividualResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListCompletedUserTasksByUserIdOrEmailResponse, ApiConnectionActionConfiguration> ListCompletedUserTasksByUserIdOrEmail(Expression<Func<string>> userIdOrEmail, Expression<Func<int>> pageNumber)
        {
            var __workflow_userIdOrEmail = WorkflowExpression.Compile(userIdOrEmail, nameof(userIdOrEmail), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<ListCompletedUserTasksByUserIdOrEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/tasks/Users/{0}/Completed/{1}", __workflow_userIdOrEmail.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListCompletedUserTasksByUserIdOrEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListPendingUserTasksByUserIdOrEmailResponse, ApiConnectionActionConfiguration> ListPendingUserTasksByUserIdOrEmail(Expression<Func<string>> userIdOrEmail, Expression<Func<int>> pageNumber)
        {
            var __workflow_userIdOrEmail = WorkflowExpression.Compile(userIdOrEmail, nameof(userIdOrEmail), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<ListPendingUserTasksByUserIdOrEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/tasks/Users/{0}/Pending/{1}", __workflow_userIdOrEmail.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListPendingUserTasksByUserIdOrEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddNoteToSalesOpportunity(Expression<Func<string>> id, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodycategory = null, Expression<Func<bool>> bodyisInternal = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyisInternal = WorkflowExpression.Compile(bodyisInternal, nameof(bodyisInternal), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Sales/Opportunities/{0}/Notes", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontent != null)
                {
                    body["Content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["Category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyisInternal != null)
                {
                    body["isInternal"] = ExpressionConverter.ConvertO(__workflow_bodyisInternal);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddActivityToSalesOpportunity(Expression<Func<string>> id, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyactivityDate = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodyactivityDate = WorkflowExpression.Compile(bodyactivityDate, nameof(bodyactivityDate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Sales/Opportunities/{0}/Activities", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (__workflow_bodyactivityDate != null)
                {
                    body["activityDate"] = ExpressionConverter.ConvertO(__workflow_bodyactivityDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<TaskData, ApiConnectionActionConfiguration> UpdateTaskByTaskNumber(Expression<Func<string>> taskNumber, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null)
        {
            var __workflow_taskNumber = WorkflowExpression.Compile(taskNumber, nameof(taskNumber), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            return new DeferredBodyAction<TaskData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/tasks/{0}", __workflow_taskNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TaskData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllCountriesResponse, ApiConnectionActionConfiguration> ListAllCountries(Expression<Func<int>> pageNumber)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<ListAllCountriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Countries/All/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListAllCountriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllStatesByCountryResponse, ApiConnectionActionConfiguration> GetAllStatesByCountry(Expression<Func<string>> countryId, Expression<Func<int>> pageNumber)
        {
            var __workflow_countryId = WorkflowExpression.Compile(countryId, nameof(countryId), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetAllStatesByCountryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Countries/{0}/States/All/{1}", __workflow_countryId.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetAllStatesByCountryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllExhibitsResponse, ApiConnectionActionConfiguration> ListAllExhibits(Expression<Func<int>> pageNumber)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<ListAllExhibitsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Exhibits/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListAllExhibitsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteACategoryForAnOrganization(Expression<Func<string>> recordNumber, Expression<Func<string>> categoryCode)
        {
            var __workflow_recordNumber = WorkflowExpression.Compile(recordNumber, nameof(recordNumber), required: true);
            var __workflow_categoryCode = WorkflowExpression.Compile(categoryCode, nameof(categoryCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Categories/{1}", __workflow_recordNumber.WithUrlEncoding(1), __workflow_categoryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddCustomerRequest(Expression<Func<string>> bodyrequestedByCustomerRecordNumber = null, Expression<Func<string>> bodyrequestType = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodysourceInput>> bodysource = null)
        {
            var __workflow_bodyrequestedByCustomerRecordNumber = WorkflowExpression.Compile(bodyrequestedByCustomerRecordNumber, nameof(bodyrequestedByCustomerRecordNumber), required: false);
            var __workflow_bodyrequestType = WorkflowExpression.Compile(bodyrequestType, nameof(bodyrequestType), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/Requests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrequestedByCustomerRecordNumber != null)
                {
                    body["requestedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrequestedByCustomerRecordNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestType != null)
                {
                    body["requestType"] = ExpressionConverter.ConvertO(__workflow_bodyrequestType);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<RequestUpdateData, ApiConnectionActionConfiguration> UpdateCustomerRequest(Expression<Func<string>> bodyrequestNumber = null, Expression<Func<string>> bodyclosedDate = null)
        {
            var __workflow_bodyrequestNumber = WorkflowExpression.Compile(bodyrequestNumber, nameof(bodyrequestNumber), required: false);
            var __workflow_bodyclosedDate = WorkflowExpression.Compile(bodyclosedDate, nameof(bodyclosedDate), required: false);
            return new DeferredBodyAction<RequestUpdateData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/Requests";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrequestNumber != null)
                {
                    body["requestNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrequestNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyclosedDate != null)
                {
                    body["closedDate"] = ExpressionConverter.ConvertO(__workflow_bodyclosedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RequestUpdateData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddCategoriesForAnOrganization(Expression<Func<string>> recordNumber, Expression<Func<SaveCategoryBasicData[]>> body = null)
        {
            var __workflow_recordNumber = WorkflowExpression.Compile(recordNumber, nameof(recordNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Categories", __workflow_recordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfCustomerRelationshipsResponse, ApiConnectionActionConfiguration> ListOfCustomerRelationships(Expression<Func<int>> pageNumber)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<ListOfCustomerRelationshipsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Customers/RelationshipTypes/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListOfCustomerRelationshipsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllOpenCustomerRequestResponse, ApiConnectionActionConfiguration> ListAllOpenCustomerRequest(Expression<Func<int>> pageNumber)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<ListAllOpenCustomerRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Requests/Open/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListAllOpenCustomerRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData, ApiConnectionActionConfiguration> GetOrganizationInactiveMemberships(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MembershipData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Memberships/Inactive", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<MembershipData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRecordFromCustomDataTable(Expression<Func<string>> tableName, Expression<Func<string>> id)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/CustomData/{0}/{1}", __workflow_tableName.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<UserTaskData, ApiConnectionActionConfiguration> UpdateUserTaskProgressOrMarkAsCompleted(Expression<Func<string>> userIdOrEmail, Expression<Func<string>> bodytaskNumber = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyassignedBy = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyprogress = null, Expression<Func<string>> bodycompletedDate = null)
        {
            var __workflow_userIdOrEmail = WorkflowExpression.Compile(userIdOrEmail, nameof(userIdOrEmail), required: true);
            var __workflow_bodytaskNumber = WorkflowExpression.Compile(bodytaskNumber, nameof(bodytaskNumber), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyassignedBy = WorkflowExpression.Compile(bodyassignedBy, nameof(bodyassignedBy), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyprogress = WorkflowExpression.Compile(bodyprogress, nameof(bodyprogress), required: false);
            var __workflow_bodycompletedDate = WorkflowExpression.Compile(bodycompletedDate, nameof(bodycompletedDate), required: false);
            return new DeferredBodyAction<UserTaskData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/tasks/Users/{0}", __workflow_userIdOrEmail.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskNumber != null)
                {
                    body["taskNumber"] = ExpressionConverter.ConvertO(__workflow_bodytaskNumber);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedBy != null)
                {
                    body["assignedBy"] = ExpressionConverter.ConvertO(__workflow_bodyassignedBy);
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

                if (__workflow_bodyprogress != null)
                {
                    body["progress"] = ExpressionConverter.ConvertO(__workflow_bodyprogress);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedDate != null)
                {
                    body["completedDate"] = ExpressionConverter.ConvertO(__workflow_bodycompletedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserTaskData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData, ApiConnectionActionConfiguration> FindMembersOrIndividualsByFirstName(Expression<Func<string>> firstName, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeEmail = null)
        {
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_includeEmail = WorkflowExpression.Compile(includeEmail, nameof(includeEmail), required: false);
            return new DeferredBodyAction<IndividualData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/Members/FindByFirstName/{0}/{1}", __workflow_firstName.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeEmail != null)
                    callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(__workflow_includeEmail);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<IndividualData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData, ApiConnectionActionConfiguration> FindMembersOrIndividualsByLastName(Expression<Func<string>> lastName, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeEmail = null)
        {
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_includeEmail = WorkflowExpression.Compile(includeEmail, nameof(includeEmail), required: false);
            return new DeferredBodyAction<IndividualData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/Members/FindByLastName/{0}/{1}", __workflow_lastName.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeEmail != null)
                    callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(__workflow_includeEmail);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<IndividualData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AssignTaskToAUser(Expression<Func<string>> userIdOrEmail, Expression<Func<string>> bodytaskNumber = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyassignedBy = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyprogress = null, Expression<Func<string>> bodycompletedDate = null)
        {
            var __workflow_userIdOrEmail = WorkflowExpression.Compile(userIdOrEmail, nameof(userIdOrEmail), required: true);
            var __workflow_bodytaskNumber = WorkflowExpression.Compile(bodytaskNumber, nameof(bodytaskNumber), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyassignedBy = WorkflowExpression.Compile(bodyassignedBy, nameof(bodyassignedBy), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyprogress = WorkflowExpression.Compile(bodyprogress, nameof(bodyprogress), required: false);
            var __workflow_bodycompletedDate = WorkflowExpression.Compile(bodycompletedDate, nameof(bodycompletedDate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/tasks/Users/{0}/Task", __workflow_userIdOrEmail.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskNumber != null)
                {
                    body["taskNumber"] = ExpressionConverter.ConvertO(__workflow_bodytaskNumber);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedBy != null)
                {
                    body["assignedBy"] = ExpressionConverter.ConvertO(__workflow_bodyassignedBy);
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

                if (__workflow_bodyprogress != null)
                {
                    body["progress"] = ExpressionConverter.ConvertO(__workflow_bodyprogress);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedDate != null)
                {
                    body["completedDate"] = ExpressionConverter.ConvertO(__workflow_bodycompletedDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteACategoryForAnIndividual(Expression<Func<string>> recordNumber, Expression<Func<string>> categoryCode)
        {
            var __workflow_recordNumber = WorkflowExpression.Compile(recordNumber, nameof(recordNumber), required: true);
            var __workflow_categoryCode = WorkflowExpression.Compile(categoryCode, nameof(categoryCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Categories/{1}", __workflow_recordNumber.WithUrlEncoding(1), __workflow_categoryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddNotificationToIndividual(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodydate = null, Expression<Func<bool>> bodyisRead = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyisRead = WorkflowExpression.Compile(bodyisRead, nameof(bodyisRead), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Notifications", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyisRead != null)
                {
                    body["isRead"] = ExpressionConverter.ConvertO(__workflow_bodyisRead);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddCategoriesForAnIndividual(Expression<Func<string>> recordNumber, Expression<Func<SaveCategoryBasicData[]>> body = null)
        {
            var __workflow_recordNumber = WorkflowExpression.Compile(recordNumber, nameof(recordNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Categories", __workflow_recordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<TaskData, ApiConnectionActionConfiguration> AddANewTask(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            return new DeferredBodyAction<TaskData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TaskData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfAllOrganizationMembersResponse, ApiConnectionActionConfiguration> ListOfAllOrganizationMembers(Expression<Func<int>> pageNumber, Expression<Func<string>> zipCode = null, Expression<Func<double>> radius = null, Expression<Func<string>> stateAbbreviation = null, Expression<Func<double>> congressionalDistrict = null, Expression<Func<string>> membershipTypeCode = null, Expression<Func<string>> membershipTypeCategory = null, Expression<Func<string>> city = null, Expression<Func<string>> name = null, Expression<Func<string>> tag = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<string>> domain = null, Expression<Func<bool>> includeMembership = null, Expression<Func<bool>> includeAddress = null, Expression<Func<bool>> includePhone = null, Expression<Func<bool>> includeEmail = null, Expression<Func<bool>> includeCustomFields = null, Expression<Func<string>> expiringFrom = null, Expression<Func<string>> expiringTo = null)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_zipCode = WorkflowExpression.Compile(zipCode, nameof(zipCode), required: false);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_stateAbbreviation = WorkflowExpression.Compile(stateAbbreviation, nameof(stateAbbreviation), required: false);
            var __workflow_congressionalDistrict = WorkflowExpression.Compile(congressionalDistrict, nameof(congressionalDistrict), required: false);
            var __workflow_membershipTypeCode = WorkflowExpression.Compile(membershipTypeCode, nameof(membershipTypeCode), required: false);
            var __workflow_membershipTypeCategory = WorkflowExpression.Compile(membershipTypeCategory, nameof(membershipTypeCategory), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: false);
            var __workflow_includeMembership = WorkflowExpression.Compile(includeMembership, nameof(includeMembership), required: false);
            var __workflow_includeAddress = WorkflowExpression.Compile(includeAddress, nameof(includeAddress), required: false);
            var __workflow_includePhone = WorkflowExpression.Compile(includePhone, nameof(includePhone), required: false);
            var __workflow_includeEmail = WorkflowExpression.Compile(includeEmail, nameof(includeEmail), required: false);
            var __workflow_includeCustomFields = WorkflowExpression.Compile(includeCustomFields, nameof(includeCustomFields), required: false);
            var __workflow_expiringFrom = WorkflowExpression.Compile(expiringFrom, nameof(expiringFrom), required: false);
            var __workflow_expiringTo = WorkflowExpression.Compile(expiringTo, nameof(expiringTo), required: false);
            return new DeferredBodyAction<ListOfAllOrganizationMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/Members/All/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_zipCode != null)
                    callPayload.Queries["zipCode"] = ExpressionConverter.Convert(__workflow_zipCode);
                callPayload.Queries["Radius"] = Convert.ToString(5);
                if (__workflow_radius != null)
                    callPayload.Queries["Radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_stateAbbreviation != null)
                    callPayload.Queries["stateAbbreviation"] = ExpressionConverter.Convert(__workflow_stateAbbreviation);
                callPayload.Queries["congressionalDistrict"] = Convert.ToString(-1);
                if (__workflow_congressionalDistrict != null)
                    callPayload.Queries["congressionalDistrict"] = ExpressionConverter.Convert(__workflow_congressionalDistrict);
                if (__workflow_membershipTypeCode != null)
                    callPayload.Queries["membershipTypeCode"] = ExpressionConverter.Convert(__workflow_membershipTypeCode);
                if (__workflow_membershipTypeCategory != null)
                    callPayload.Queries["membershipTypeCategory"] = ExpressionConverter.Convert(__workflow_membershipTypeCategory);
                if (__workflow_city != null)
                    callPayload.Queries["City"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_latitude != null)
                    callPayload.Queries["Latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["Longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_domain != null)
                    callPayload.Queries["Domain"] = ExpressionConverter.Convert(__workflow_domain);
                if (__workflow_includeMembership != null)
                    callPayload.Queries["includeMembership"] = ExpressionConverter.Convert(__workflow_includeMembership);
                if (__workflow_includeAddress != null)
                    callPayload.Queries["includeAddress"] = ExpressionConverter.Convert(__workflow_includeAddress);
                if (__workflow_includePhone != null)
                    callPayload.Queries["includePhone"] = ExpressionConverter.Convert(__workflow_includePhone);
                if (__workflow_includeEmail != null)
                    callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(__workflow_includeEmail);
                if (__workflow_includeCustomFields != null)
                    callPayload.Queries["includeCustomFields"] = ExpressionConverter.Convert(__workflow_includeCustomFields);
                if (__workflow_expiringFrom != null)
                    callPayload.Queries["expiringFrom"] = ExpressionConverter.Convert(__workflow_expiringFrom);
                if (__workflow_expiringTo != null)
                    callPayload.Queries["expiringTo"] = ExpressionConverter.Convert(__workflow_expiringTo);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListOfAllOrganizationMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfAllIndividualMembersResponse, ApiConnectionActionConfiguration> ListOfAllIndividualMembers(Expression<Func<int>> pageNumber, Expression<Func<string>> zipCode = null, Expression<Func<double>> radius = null, Expression<Func<string>> membershipTypeCode = null, Expression<Func<string>> membershipTypeCategory = null, Expression<Func<string>> tag = null, Expression<Func<bool>> includeMembership = null, Expression<Func<bool>> includeAddress = null, Expression<Func<bool>> includePhone = null, Expression<Func<bool>> includeEmail = null, Expression<Func<bool>> includeLink = null, Expression<Func<bool>> includeCustomFields = null, Expression<Func<bool>> includeCategories = null, Expression<Func<bool>> includeMembershipRenewalUrl = null, Expression<Func<string>> expiringFrom = null, Expression<Func<string>> expiringTo = null)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_zipCode = WorkflowExpression.Compile(zipCode, nameof(zipCode), required: false);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_membershipTypeCode = WorkflowExpression.Compile(membershipTypeCode, nameof(membershipTypeCode), required: false);
            var __workflow_membershipTypeCategory = WorkflowExpression.Compile(membershipTypeCategory, nameof(membershipTypeCategory), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_includeMembership = WorkflowExpression.Compile(includeMembership, nameof(includeMembership), required: false);
            var __workflow_includeAddress = WorkflowExpression.Compile(includeAddress, nameof(includeAddress), required: false);
            var __workflow_includePhone = WorkflowExpression.Compile(includePhone, nameof(includePhone), required: false);
            var __workflow_includeEmail = WorkflowExpression.Compile(includeEmail, nameof(includeEmail), required: false);
            var __workflow_includeLink = WorkflowExpression.Compile(includeLink, nameof(includeLink), required: false);
            var __workflow_includeCustomFields = WorkflowExpression.Compile(includeCustomFields, nameof(includeCustomFields), required: false);
            var __workflow_includeCategories = WorkflowExpression.Compile(includeCategories, nameof(includeCategories), required: false);
            var __workflow_includeMembershipRenewalUrl = WorkflowExpression.Compile(includeMembershipRenewalUrl, nameof(includeMembershipRenewalUrl), required: false);
            var __workflow_expiringFrom = WorkflowExpression.Compile(expiringFrom, nameof(expiringFrom), required: false);
            var __workflow_expiringTo = WorkflowExpression.Compile(expiringTo, nameof(expiringTo), required: false);
            return new DeferredBodyAction<ListOfAllIndividualMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/Members/All/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_zipCode != null)
                    callPayload.Queries["zipCode"] = ExpressionConverter.Convert(__workflow_zipCode);
                callPayload.Queries["Radius"] = Convert.ToString(5);
                if (__workflow_radius != null)
                    callPayload.Queries["Radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_membershipTypeCode != null)
                    callPayload.Queries["membershipTypeCode"] = ExpressionConverter.Convert(__workflow_membershipTypeCode);
                if (__workflow_membershipTypeCategory != null)
                    callPayload.Queries["membershipTypeCategory"] = ExpressionConverter.Convert(__workflow_membershipTypeCategory);
                if (__workflow_tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_includeMembership != null)
                    callPayload.Queries["includeMembership"] = ExpressionConverter.Convert(__workflow_includeMembership);
                if (__workflow_includeAddress != null)
                    callPayload.Queries["includeAddress"] = ExpressionConverter.Convert(__workflow_includeAddress);
                if (__workflow_includePhone != null)
                    callPayload.Queries["includePhone"] = ExpressionConverter.Convert(__workflow_includePhone);
                if (__workflow_includeEmail != null)
                    callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(__workflow_includeEmail);
                if (__workflow_includeLink != null)
                    callPayload.Queries["includeLink"] = ExpressionConverter.Convert(__workflow_includeLink);
                if (__workflow_includeCustomFields != null)
                    callPayload.Queries["includeCustomFields"] = ExpressionConverter.Convert(__workflow_includeCustomFields);
                if (__workflow_includeCategories != null)
                    callPayload.Queries["includeCategories"] = ExpressionConverter.Convert(__workflow_includeCategories);
                if (__workflow_includeMembershipRenewalUrl != null)
                    callPayload.Queries["includeMembershipRenewalUrl"] = ExpressionConverter.Convert(__workflow_includeMembershipRenewalUrl);
                if (__workflow_expiringFrom != null)
                    callPayload.Queries["expiringFrom"] = ExpressionConverter.Convert(__workflow_expiringFrom);
                if (__workflow_expiringTo != null)
                    callPayload.Queries["expiringTo"] = ExpressionConverter.Convert(__workflow_expiringTo);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListOfAllIndividualMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetListOfActiveCertificationsForAnOrganizationResponse, ApiConnectionActionConfiguration> GetListOfActiveCertificationsForAnOrganization(Expression<Func<string>> idOrRecordNumber, Expression<Func<int>> pageNumber)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetListOfActiveCertificationsForAnOrganizationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Certifications/{1}", __workflow_idOrRecordNumber.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetListOfActiveCertificationsForAnOrganizationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetListOfActiveCertificationsForAnIndividualResponse, ApiConnectionActionConfiguration> GetListOfActiveCertificationsForAnIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<int>> pageNumber)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetListOfActiveCertificationsForAnIndividualResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Certifications/{1}", __workflow_idOrRecordNumber.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetListOfActiveCertificationsForAnIndividualResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData, ApiConnectionActionConfiguration> GetIndividualInactiveMemberships(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MembershipData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Memberships/Inactive", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<MembershipData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddActivityToOrganization(Expression<Func<string>> id, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyactivityDate = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodyactivityDate = WorkflowExpression.Compile(bodyactivityDate, nameof(bodyactivityDate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Activities", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (__workflow_bodyactivityDate != null)
                {
                    body["activityDate"] = ExpressionConverter.ConvertO(__workflow_bodyactivityDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RegisterAnIndividualForAFreeSession(Expression<Func<string>> eventCode, Expression<Func<string>> customerIdOrRecordNumber, Expression<Func<string>> registrationNumber = null, Expression<Func<SessionRegistrationData[]>> body = null)
        {
            var __workflow_eventCode = WorkflowExpression.Compile(eventCode, nameof(eventCode), required: true);
            var __workflow_customerIdOrRecordNumber = WorkflowExpression.Compile(customerIdOrRecordNumber, nameof(customerIdOrRecordNumber), required: true);
            var __workflow_registrationNumber = WorkflowExpression.Compile(registrationNumber, nameof(registrationNumber), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Events/{0}/Sessions/Register/{1}", __workflow_eventCode.WithUrlEncoding(1), __workflow_customerIdOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_registrationNumber != null)
                    callPayload.Queries["registrationNumber"] = ExpressionConverter.Convert(__workflow_registrationNumber);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAListOfLicensesResponse, ApiConnectionActionConfiguration> GetAListOfLicenses(Expression<Func<string>> id, Expression<Func<int>> pageNumber)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetAListOfLicensesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Licenses/{1}", __workflow_id.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetAListOfLicensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllAwardsResponse, ApiConnectionActionConfiguration> ListAllAwards(Expression<Func<int>> pageNumber, Expression<Func<int>> year = null)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            return new DeferredBodyAction<ListAllAwardsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Awards/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_year != null)
                    callPayload.Queries["Year"] = ExpressionConverter.Convert(__workflow_year);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListAllAwardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersOrIndividualsByNameResponse, ApiConnectionActionConfiguration> FindMembersOrIndividualsByName(Expression<Func<string>> name, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeEmail = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_includeEmail = WorkflowExpression.Compile(includeEmail, nameof(includeEmail), required: false);
            return new DeferredBodyAction<FindMembersOrIndividualsByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/Members/FindByName/{0}/{1}", __workflow_name.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeEmail != null)
                    callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(__workflow_includeEmail);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<FindMembersOrIndividualsByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAListOfAllServicesOfAnOrganizationResponse, ApiConnectionActionConfiguration> GetAListOfAllServicesOfAnOrganization(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetAListOfAllServicesOfAnOrganizationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Services", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetAListOfAllServicesOfAnOrganizationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ServiceData, ApiConnectionActionConfiguration> AddAServiceToAnOrganization(Expression<Func<string>> id, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyname = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<ServiceData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Services", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ServiceData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet, ApiConnectionActionConfiguration> UpdatePhoneForAnIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> id, Expression<Func<string>> bodycountryName, Expression<Func<string>> bodynumber, Expression<Func<bodytypeNameInput>> bodytypeName, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodyextension = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycountryName = WorkflowExpression.Compile(bodycountryName, nameof(bodycountryName), required: true);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodytypeName = WorkflowExpression.Compile(bodytypeName, nameof(bodytypeName), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            return new DeferredBodyAction<PhoneDataSet, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Phones/{1}", __workflow_idOrRecordNumber.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["countryName"] = ExpressionConverter.ConvertO(__workflow_bodycountryName);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (__workflow_bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                bodypropCount++;
                body["typeName"] = ExpressionConverter.ConvertO(__workflow_bodytypeName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PhoneDataSet>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet, ApiConnectionActionConfiguration> UpdatePhoneForAnOrganization(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> id, Expression<Func<string>> bodycountryName, Expression<Func<string>> bodynumber, Expression<Func<bodytypeNameInput>> bodytypeName, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodyextension = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodycountryName = WorkflowExpression.Compile(bodycountryName, nameof(bodycountryName), required: true);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodytypeName = WorkflowExpression.Compile(bodytypeName, nameof(bodytypeName), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            return new DeferredBodyAction<PhoneDataSet, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Phones/{1}", __workflow_idOrRecordNumber.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["countryName"] = ExpressionConverter.ConvertO(__workflow_bodycountryName);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (__workflow_bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                bodypropCount++;
                body["typeName"] = ExpressionConverter.ConvertO(__workflow_bodytypeName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PhoneDataSet>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAnIndividualWebLink(Expression<Func<string>> idOrRecordNumber, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodyurl = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Links", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddWebLinkForIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodyurl = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Links", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet, ApiConnectionActionConfiguration> AddPhoneToOrganization(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> bodycountryName, Expression<Func<string>> bodynumber, Expression<Func<bodytypeNameInput>> bodytypeName, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodyextension = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodycountryName = WorkflowExpression.Compile(bodycountryName, nameof(bodycountryName), required: true);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodytypeName = WorkflowExpression.Compile(bodytypeName, nameof(bodytypeName), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            return new DeferredBodyAction<PhoneDataSet, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Phones", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["countryName"] = ExpressionConverter.ConvertO(__workflow_bodycountryName);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (__workflow_bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                bodypropCount++;
                body["typeName"] = ExpressionConverter.ConvertO(__workflow_bodytypeName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PhoneDataSet>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetNomineesByCommitteeResponse, ApiConnectionActionConfiguration> GetNomineesByCommittee(Expression<Func<string>> code, Expression<Func<int>> pageNumber, Expression<Func<string>> term = null)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: false);
            return new DeferredBodyAction<GetNomineesByCommitteeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Committees/{0}/Nominations/{1}", __workflow_code.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_term != null)
                    callPayload.Queries["Term"] = ExpressionConverter.Convert(__workflow_term);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetNomineesByCommitteeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetOrganizationsActiveSubscriptionsResponse, ApiConnectionActionConfiguration> GetOrganizationsActiveSubscriptions(Expression<Func<string>> id, Expression<Func<int>> pageNumber)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetOrganizationsActiveSubscriptionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Subscriptions/{1}", __workflow_id.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetOrganizationsActiveSubscriptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAnOrganizationWebLink(Expression<Func<string>> idOrRecordNumber, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyurl)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Links", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddWebLinkForOrganization(Expression<Func<string>> idOrRecordNumber, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyurl)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Links", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddEmailToOrganization(Expression<Func<string>> id, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Emails", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetOrganizationsRelationshipsResponse, ApiConnectionActionConfiguration> GetOrganizationsRelationships(Expression<Func<string>> id, Expression<Func<int>> pageNumber, Expression<Func<string>> relationshipName = null, Expression<Func<bool>> includesDetails = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_relationshipName = WorkflowExpression.Compile(relationshipName, nameof(relationshipName), required: false);
            var __workflow_includesDetails = WorkflowExpression.Compile(includesDetails, nameof(includesDetails), required: false);
            return new DeferredBodyAction<GetOrganizationsRelationshipsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Relationships/{1}", __workflow_id.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_relationshipName != null)
                    callPayload.Queries["relationshipName."] = ExpressionConverter.Convert(__workflow_relationshipName);
                if (__workflow_includesDetails != null)
                    callPayload.Queries["includesDetails"] = ExpressionConverter.Convert(__workflow_includesDetails);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetOrganizationsRelationshipsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddressSaveData, ApiConnectionActionConfiguration> AddOrUpdateAddressToOrganization(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyline1 = null, Expression<Func<string>> bodyline2 = null, Expression<Func<string>> bodyline3 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<bool>> bodyisPreferredShipping = null, Expression<Func<bool>> bodyisPreferredBilling = null, Expression<Func<bool>> bodyisBadAddress = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyline1 = WorkflowExpression.Compile(bodyline1, nameof(bodyline1), required: false);
            var __workflow_bodyline2 = WorkflowExpression.Compile(bodyline2, nameof(bodyline2), required: false);
            var __workflow_bodyline3 = WorkflowExpression.Compile(bodyline3, nameof(bodyline3), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyzipcode = WorkflowExpression.Compile(bodyzipcode, nameof(bodyzipcode), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            var __workflow_bodyisPreferredShipping = WorkflowExpression.Compile(bodyisPreferredShipping, nameof(bodyisPreferredShipping), required: false);
            var __workflow_bodyisPreferredBilling = WorkflowExpression.Compile(bodyisPreferredBilling, nameof(bodyisPreferredBilling), required: false);
            var __workflow_bodyisBadAddress = WorkflowExpression.Compile(bodyisBadAddress, nameof(bodyisBadAddress), required: false);
            return new DeferredBodyAction<AddressSaveData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Addresses", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyline1 != null)
                {
                    body["line1"] = ExpressionConverter.ConvertO(__workflow_bodyline1);
                    bodypropCount++;
                }

                if (__workflow_bodyline2 != null)
                {
                    body["line2"] = ExpressionConverter.ConvertO(__workflow_bodyline2);
                    bodypropCount++;
                }

                if (__workflow_bodyline3 != null)
                {
                    body["line3"] = ExpressionConverter.ConvertO(__workflow_bodyline3);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyzipcode != null)
                {
                    body["zipcode"] = ExpressionConverter.ConvertO(__workflow_bodyzipcode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                if (__workflow_bodyisPreferredShipping != null)
                {
                    body["isPreferredShipping"] = ExpressionConverter.ConvertO(__workflow_bodyisPreferredShipping);
                    bodypropCount++;
                }

                if (__workflow_bodyisPreferredBilling != null)
                {
                    body["isPreferredBilling"] = ExpressionConverter.ConvertO(__workflow_bodyisPreferredBilling);
                    bodypropCount++;
                }

                if (__workflow_bodyisBadAddress != null)
                {
                    body["isBadAddress"] = ExpressionConverter.ConvertO(__workflow_bodyisBadAddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddressSaveData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldResultData[], ApiConnectionActionConfiguration> AddOrUpdateAListOfCustomFieldsPerIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomFieldResultData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/CustomFieldsList", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomFieldResultData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetUpcomingEventsResponse, ApiConnectionActionConfiguration> GetUpcomingEvents(Expression<Func<int>> pageNumber)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetUpcomingEventsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Events/Upcoming/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetUpcomingEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet, ApiConnectionActionConfiguration> AddPhoneToIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> bodycountryName, Expression<Func<string>> bodynumber, Expression<Func<bodytypeNameInput>> bodytypeName, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodyextension = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodycountryName = WorkflowExpression.Compile(bodycountryName, nameof(bodycountryName), required: true);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            var __workflow_bodytypeName = WorkflowExpression.Compile(bodytypeName, nameof(bodytypeName), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            return new DeferredBodyAction<PhoneDataSet, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Phones", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["countryName"] = ExpressionConverter.ConvertO(__workflow_bodycountryName);
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (__workflow_bodyextension != null)
                {
                    body["extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                bodypropCount++;
                body["typeName"] = ExpressionConverter.ConvertO(__workflow_bodytypeName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PhoneDataSet>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetCommitteeInformationForAnIndividualResponse, ApiConnectionActionConfiguration> GetCommitteeInformationForAnIndividual(Expression<Func<string>> id, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeInactive = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            return new DeferredBodyAction<GetCommitteeInformationForAnIndividualResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Committees/{1}", __workflow_id.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["includeInactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCommitteeInformationForAnIndividualResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldData[], ApiConnectionActionConfiguration> GetOrganizationCustomFieldValues(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CustomFieldData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/CustomFields", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CustomFieldData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData[], ApiConnectionActionConfiguration> GetOrganizationActiveMemberships(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MembershipData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Memberships/Active", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<MembershipData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllEventsResponse, ApiConnectionActionConfiguration> GetAllEvents(Expression<Func<int>> pageNumber, Expression<Func<string>> code = null, Expression<Func<string>> name = null, Expression<Func<string>> tag = null)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            return new DeferredBodyAction<GetAllEventsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Events/All/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(__workflow_tag);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetAllEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData[], ApiConnectionActionConfiguration> GetIndividualActiveMemberships(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MembershipData[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Memberships/Active", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<MembershipData[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllEventRegistrationsInformationForAnIndividualResponse, ApiConnectionActionConfiguration> GetAllEventRegistrationsInformationForAnIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<int>> pageNumber, Expression<Func<string>> eventCode = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_eventCode = WorkflowExpression.Compile(eventCode, nameof(eventCode), required: false);
            return new DeferredBodyAction<GetAllEventRegistrationsInformationForAnIndividualResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Registrations/{1}", __workflow_idOrRecordNumber.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_eventCode != null)
                    callPayload.Queries["eventCode"] = ExpressionConverter.Convert(__workflow_eventCode);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetAllEventRegistrationsInformationForAnIndividualResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetIndividualsRelationshipsResponse, ApiConnectionActionConfiguration> GetIndividualsRelationships(Expression<Func<string>> id, Expression<Func<int>> pageNumber, Expression<Func<string>> relationshipName = null, Expression<Func<bool>> includeDetails = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_relationshipName = WorkflowExpression.Compile(relationshipName, nameof(relationshipName), required: false);
            var __workflow_includeDetails = WorkflowExpression.Compile(includeDetails, nameof(includeDetails), required: false);
            return new DeferredBodyAction<GetIndividualsRelationshipsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Relationships/{1}", __workflow_id.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_relationshipName != null)
                    callPayload.Queries["relationshipName"] = ExpressionConverter.Convert(__workflow_relationshipName);
                if (__workflow_includeDetails != null)
                    callPayload.Queries["includeDetails"] = ExpressionConverter.Convert(__workflow_includeDetails);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetIndividualsRelationshipsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAnIndividualEmail(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> currentEmailAddress, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_currentEmailAddress = WorkflowExpression.Compile(currentEmailAddress, nameof(currentEmailAddress), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Emails/{1}", __workflow_idOrRecordNumber.WithUrlEncoding(1), __workflow_currentEmailAddress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SaveRelationshipForOrganization(Expression<Func<string>> id, Expression<Func<string>> bodyrelationshipName, Expression<Func<string>> bodyrelatedToCustomerRecordNumber, Expression<Func<string>> bodyreciprocalRelationshipName, Expression<Func<bool>> bodyisPrimary = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyisReciprocalPrimary = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyrelationshipName = WorkflowExpression.Compile(bodyrelationshipName, nameof(bodyrelationshipName), required: true);
            var __workflow_bodyrelatedToCustomerRecordNumber = WorkflowExpression.Compile(bodyrelatedToCustomerRecordNumber, nameof(bodyrelatedToCustomerRecordNumber), required: true);
            var __workflow_bodyreciprocalRelationshipName = WorkflowExpression.Compile(bodyreciprocalRelationshipName, nameof(bodyreciprocalRelationshipName), required: true);
            var __workflow_bodyisPrimary = WorkflowExpression.Compile(bodyisPrimary, nameof(bodyisPrimary), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyisReciprocalPrimary = WorkflowExpression.Compile(bodyisReciprocalPrimary, nameof(bodyisReciprocalPrimary), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Relationships", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["relationshipName"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipName);
                bodypropCount++;
                body["relatedToCustomerRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToCustomerRecordNumber);
                bodypropCount++;
                body["reciprocalRelationshipName"] = ExpressionConverter.ConvertO(__workflow_bodyreciprocalRelationshipName);
                if (__workflow_bodyisPrimary != null)
                {
                    body["isPrimary"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimary);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyisReciprocalPrimary != null)
                {
                    body["isReciprocalPrimary"] = ExpressionConverter.ConvertO(__workflow_bodyisReciprocalPrimary);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData, ApiConnectionActionConfiguration> AddIndividual(Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<bool>> createUser = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyrecordNumber = null)
        {
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: true);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: true);
            var __workflow_createUser = WorkflowExpression.Compile(createUser, nameof(createUser), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyrecordNumber = WorkflowExpression.Compile(bodyrecordNumber, nameof(bodyrecordNumber), required: false);
            return new DeferredBodyAction<IndividualData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/Individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createUser != null)
                    callPayload.Queries["createUser"] = ExpressionConverter.Convert(__workflow_createUser);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                bodypropCount++;
                body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordNumber != null)
                {
                    body["recordNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrecordNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IndividualData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<EmailData, ApiConnectionActionConfiguration> AddEmailToIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            return new DeferredBodyAction<EmailData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Emails", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<EmailData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddressSaveData, ApiConnectionActionConfiguration> AddOrUpdateAddressToIndividual(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyline1 = null, Expression<Func<string>> bodyline2 = null, Expression<Func<string>> bodyline3 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<bool>> bodyisPreferredShipping = null, Expression<Func<bool>> bodyisPreferredBilling = null, Expression<Func<bool>> bodyisBadAddress = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyprimary = WorkflowExpression.Compile(bodyprimary, nameof(bodyprimary), required: false);
            var __workflow_bodyline1 = WorkflowExpression.Compile(bodyline1, nameof(bodyline1), required: false);
            var __workflow_bodyline2 = WorkflowExpression.Compile(bodyline2, nameof(bodyline2), required: false);
            var __workflow_bodyline3 = WorkflowExpression.Compile(bodyline3, nameof(bodyline3), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodyzipcode = WorkflowExpression.Compile(bodyzipcode, nameof(bodyzipcode), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            var __workflow_bodyisPreferredShipping = WorkflowExpression.Compile(bodyisPreferredShipping, nameof(bodyisPreferredShipping), required: false);
            var __workflow_bodyisPreferredBilling = WorkflowExpression.Compile(bodyisPreferredBilling, nameof(bodyisPreferredBilling), required: false);
            var __workflow_bodyisBadAddress = WorkflowExpression.Compile(bodyisBadAddress, nameof(bodyisBadAddress), required: false);
            return new DeferredBodyAction<AddressSaveData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Addresses", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyprimary != null)
                {
                    body["primary"] = ExpressionConverter.ConvertO(__workflow_bodyprimary);
                    bodypropCount++;
                }

                if (__workflow_bodyline1 != null)
                {
                    body["line1"] = ExpressionConverter.ConvertO(__workflow_bodyline1);
                    bodypropCount++;
                }

                if (__workflow_bodyline2 != null)
                {
                    body["line2"] = ExpressionConverter.ConvertO(__workflow_bodyline2);
                    bodypropCount++;
                }

                if (__workflow_bodyline3 != null)
                {
                    body["line3"] = ExpressionConverter.ConvertO(__workflow_bodyline3);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyzipcode != null)
                {
                    body["zipcode"] = ExpressionConverter.ConvertO(__workflow_bodyzipcode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                if (__workflow_bodyisPreferredShipping != null)
                {
                    body["isPreferredShipping"] = ExpressionConverter.ConvertO(__workflow_bodyisPreferredShipping);
                    bodypropCount++;
                }

                if (__workflow_bodyisPreferredBilling != null)
                {
                    body["isPreferredBilling"] = ExpressionConverter.ConvertO(__workflow_bodyisPreferredBilling);
                    bodypropCount++;
                }

                if (__workflow_bodyisBadAddress != null)
                {
                    body["isBadAddress"] = ExpressionConverter.ConvertO(__workflow_bodyisBadAddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddressSaveData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersOrIndividualsByFirstAndLastNameResponse, ApiConnectionActionConfiguration> FindMembersOrIndividualsByFirstAndLastName(Expression<Func<string>> firstName, Expression<Func<string>> lastName, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeEmail = null)
        {
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: true);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_includeEmail = WorkflowExpression.Compile(includeEmail, nameof(includeEmail), required: false);
            return new DeferredBodyAction<FindMembersOrIndividualsByFirstAndLastNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/Members/FindByName/{0}/{1}/{2}", __workflow_firstName.WithUrlEncoding(1), __workflow_lastName.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeEmail != null)
                    callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(__workflow_includeEmail);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<FindMembersOrIndividualsByFirstAndLastNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCommitteeMembersByCommitteeIdOrCode(Expression<Func<string>> idOrCode, Expression<Func<int>> pageNumber, Expression<Func<int>> term = null, Expression<Func<string>> positionCodes = null)
        {
            var __workflow_idOrCode = WorkflowExpression.Compile(idOrCode, nameof(idOrCode), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: false);
            var __workflow_positionCodes = WorkflowExpression.Compile(positionCodes, nameof(positionCodes), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Committees/{0}/Members/{1}", __workflow_idOrCode.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_term != null)
                    callPayload.Queries["Term"] = ExpressionConverter.Convert(__workflow_term);
                if (__workflow_positionCodes != null)
                    callPayload.Queries["positionCodes"] = ExpressionConverter.Convert(__workflow_positionCodes);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddActivity(Expression<Func<string>> id, Expression<Func<string>> bodytext, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyactivityDate = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodyactivityDate = WorkflowExpression.Compile(bodyactivityDate, nameof(bodyactivityDate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Activities", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["category"] = "Impexium";
                bodypropCount++;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (__workflow_bodyactivityDate != null)
                {
                    body["activityDate"] = ExpressionConverter.ConvertO(__workflow_bodyactivityDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindIndividualIdOrEmailResponse, ApiConnectionActionConfiguration> FindIndividualIdOrEmail(Expression<Func<string>> idOrRecordNumberOrEmail)
        {
            var __workflow_idOrRecordNumberOrEmail = WorkflowExpression.Compile(idOrRecordNumberOrEmail, nameof(idOrRecordNumberOrEmail), required: true);
            return new DeferredBodyAction<FindIndividualIdOrEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/Profile/{0}/{1}/", __workflow_idOrRecordNumberOrEmail.WithUrlEncoding(1), WorkflowExpression.Literal(1).WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["IncludeDetails"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<FindIndividualIdOrEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddRelationshipToIndividual(Expression<Func<string>> id, Expression<Func<string>> bodyrelationshipName, Expression<Func<string>> bodyrelatedToCustomerRecordNumber, Expression<Func<string>> bodyreciprocalRelationshipName, Expression<Func<bool>> bodyisPrimary = null, Expression<Func<bool>> bodyisReciprocalPrimary = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyrelationshipName = WorkflowExpression.Compile(bodyrelationshipName, nameof(bodyrelationshipName), required: true);
            var __workflow_bodyrelatedToCustomerRecordNumber = WorkflowExpression.Compile(bodyrelatedToCustomerRecordNumber, nameof(bodyrelatedToCustomerRecordNumber), required: true);
            var __workflow_bodyreciprocalRelationshipName = WorkflowExpression.Compile(bodyreciprocalRelationshipName, nameof(bodyreciprocalRelationshipName), required: true);
            var __workflow_bodyisPrimary = WorkflowExpression.Compile(bodyisPrimary, nameof(bodyisPrimary), required: false);
            var __workflow_bodyisReciprocalPrimary = WorkflowExpression.Compile(bodyisReciprocalPrimary, nameof(bodyisReciprocalPrimary), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Relationships", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("Application/Json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["relationshipName"] = ExpressionConverter.ConvertO(__workflow_bodyrelationshipName);
                bodypropCount++;
                body["relatedToCustomerRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToCustomerRecordNumber);
                bodypropCount++;
                body["reciprocalRelationshipName"] = ExpressionConverter.ConvertO(__workflow_bodyreciprocalRelationshipName);
                if (__workflow_bodyisPrimary != null)
                {
                    body["isPrimary"] = ExpressionConverter.ConvertO(__workflow_bodyisPrimary);
                    bodypropCount++;
                }

                if (__workflow_bodyisReciprocalPrimary != null)
                {
                    body["isReciprocalPrimary"] = ExpressionConverter.ConvertO(__workflow_bodyisReciprocalPrimary);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IndividualAddEducationCredit(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> bodytype, Expression<Func<string>> bodydescription, Expression<Func<double>> bodynumberOfCredits, Expression<Func<string>> bodydateEarned, Expression<Func<string>> bodyproviderName = null, Expression<Func<string>> bodystateName = null, Expression<Func<string>> bodyreference = null, Expression<Func<bool>> bodyisSelfReported = null)
        {
            var __workflow_idOrRecordNumber = WorkflowExpression.Compile(idOrRecordNumber, nameof(idOrRecordNumber), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodynumberOfCredits = WorkflowExpression.Compile(bodynumberOfCredits, nameof(bodynumberOfCredits), required: true);
            var __workflow_bodydateEarned = WorkflowExpression.Compile(bodydateEarned, nameof(bodydateEarned), required: true);
            var __workflow_bodyproviderName = WorkflowExpression.Compile(bodyproviderName, nameof(bodyproviderName), required: false);
            var __workflow_bodystateName = WorkflowExpression.Compile(bodystateName, nameof(bodystateName), required: false);
            var __workflow_bodyreference = WorkflowExpression.Compile(bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodyisSelfReported = WorkflowExpression.Compile(bodyisSelfReported, nameof(bodyisSelfReported), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/EducationCredits", __workflow_idOrRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["numberOfCredits"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfCredits);
                bodypropCount++;
                body["dateEarned"] = ExpressionConverter.ConvertO(__workflow_bodydateEarned);
                if (__workflow_bodyproviderName != null)
                {
                    body["providerName"] = ExpressionConverter.ConvertO(__workflow_bodyproviderName);
                    bodypropCount++;
                }

                if (__workflow_bodystateName != null)
                {
                    body["stateName"] = ExpressionConverter.ConvertO(__workflow_bodystateName);
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodyisSelfReported != null)
                {
                    body["isSelfReported"] = ExpressionConverter.ConvertO(__workflow_bodyisSelfReported);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IndividualAddNote(Expression<Func<string>> id, Expression<Func<string>> notecontent, Expression<Func<bool>> noteisAlert = null, Expression<Func<string>> notetitle = null, Expression<Func<string>> notefollowUpDate = null, Expression<Func<string>> notecategory = null, Expression<Func<bool>> noteisInternal = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_notecontent = WorkflowExpression.Compile(notecontent, nameof(notecontent), required: true);
            var __workflow_noteisAlert = WorkflowExpression.Compile(noteisAlert, nameof(noteisAlert), required: false);
            var __workflow_notetitle = WorkflowExpression.Compile(notetitle, nameof(notetitle), required: false);
            var __workflow_notefollowUpDate = WorkflowExpression.Compile(notefollowUpDate, nameof(notefollowUpDate), required: false);
            var __workflow_notecategory = WorkflowExpression.Compile(notecategory, nameof(notecategory), required: false);
            var __workflow_noteisInternal = WorkflowExpression.Compile(noteisInternal, nameof(noteisInternal), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Notes", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var note = new JObject();
                var notepropCount = 0;
                if (__workflow_noteisAlert != null)
                {
                    note["isAlert"] = ExpressionConverter.ConvertO(__workflow_noteisAlert);
                    notepropCount++;
                }

                if (__workflow_notetitle != null)
                {
                    note["title"] = ExpressionConverter.ConvertO(__workflow_notetitle);
                    notepropCount++;
                }

                if (__workflow_notefollowUpDate != null)
                {
                    note["followUpDate"] = ExpressionConverter.ConvertO(__workflow_notefollowUpDate);
                    notepropCount++;
                }

                notepropCount++;
                note["content"] = ExpressionConverter.ConvertO(__workflow_notecontent);
                if (__workflow_notecategory != null)
                {
                    note["category"] = ExpressionConverter.ConvertO(__workflow_notecategory);
                    notepropCount++;
                }

                if (__workflow_noteisInternal != null)
                {
                    note["isInternal"] = ExpressionConverter.ConvertO(__workflow_noteisInternal);
                    notepropCount++;
                }

                if (notepropCount > 0)
                {
                    callPayload.Body = note;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualsLookupByNameResponse, ApiConnectionActionConfiguration> IndividualsLookupByName(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<IndividualsLookupByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/Lookup/{0}", WorkflowExpression.Literal(1).WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["includeOrgAddresses"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<IndividualsLookupByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddToCommitteeResponse, ApiConnectionActionConfiguration> AddToCommittee(Expression<Func<string>> code, Expression<Func<string>> bodyrecordNumber, Expression<Func<string>> bodypositionCode, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyrepresentingOrganizationRecordNumber = null, Expression<Func<string>> bodyrepresentingOrganizationRelationshipName = null, Expression<Func<string>> bodynominatedByCustomerRecordNumber = null, Expression<Func<int>> bodycommitteeTerm = null, Expression<Func<int>> bodyrank = null)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_bodyrecordNumber = WorkflowExpression.Compile(bodyrecordNumber, nameof(bodyrecordNumber), required: true);
            var __workflow_bodypositionCode = WorkflowExpression.Compile(bodypositionCode, nameof(bodypositionCode), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyrepresentingOrganizationRecordNumber = WorkflowExpression.Compile(bodyrepresentingOrganizationRecordNumber, nameof(bodyrepresentingOrganizationRecordNumber), required: false);
            var __workflow_bodyrepresentingOrganizationRelationshipName = WorkflowExpression.Compile(bodyrepresentingOrganizationRelationshipName, nameof(bodyrepresentingOrganizationRelationshipName), required: false);
            var __workflow_bodynominatedByCustomerRecordNumber = WorkflowExpression.Compile(bodynominatedByCustomerRecordNumber, nameof(bodynominatedByCustomerRecordNumber), required: false);
            var __workflow_bodycommitteeTerm = WorkflowExpression.Compile(bodycommitteeTerm, nameof(bodycommitteeTerm), required: false);
            var __workflow_bodyrank = WorkflowExpression.Compile(bodyrank, nameof(bodyrank), required: false);
            return new DeferredBodyAction<AddToCommitteeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Committees/{0}/Members", __workflow_code.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recordNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrecordNumber);
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                bodypropCount++;
                body["positionCode"] = ExpressionConverter.ConvertO(__workflow_bodypositionCode);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentingOrganizationRecordNumber != null)
                {
                    body["representingOrganizationRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentingOrganizationRecordNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentingOrganizationRelationshipName != null)
                {
                    body["representingOrganizationRelationshipName"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentingOrganizationRelationshipName);
                    bodypropCount++;
                }

                if (__workflow_bodynominatedByCustomerRecordNumber != null)
                {
                    body["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodynominatedByCustomerRecordNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycommitteeTerm != null)
                {
                    body["committeeTerm"] = ExpressionConverter.ConvertO(__workflow_bodycommitteeTerm);
                    bodypropCount++;
                }

                if (__workflow_bodyrank != null)
                {
                    body["rank"] = ExpressionConverter.ConvertO(__workflow_bodyrank);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddToCommitteeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateCommitteeMember(Expression<Func<string>> code, Expression<Func<string>> memberRecordNumber, Expression<Func<string>> currentPositionCode, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyrepresentingOrganizationRecordNumber = null, Expression<Func<string>> bodyrepresentingOrganizationRelationshipName = null, Expression<Func<string>> bodynominatedByCustomerRecordNumber = null, Expression<Func<int>> bodycommitteeTerm = null, Expression<Func<int>> bodyrank = null)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_memberRecordNumber = WorkflowExpression.Compile(memberRecordNumber, nameof(memberRecordNumber), required: true);
            var __workflow_currentPositionCode = WorkflowExpression.Compile(currentPositionCode, nameof(currentPositionCode), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodypositionCode = WorkflowExpression.Compile(bodypositionCode, nameof(bodypositionCode), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyrepresentingOrganizationRecordNumber = WorkflowExpression.Compile(bodyrepresentingOrganizationRecordNumber, nameof(bodyrepresentingOrganizationRecordNumber), required: false);
            var __workflow_bodyrepresentingOrganizationRelationshipName = WorkflowExpression.Compile(bodyrepresentingOrganizationRelationshipName, nameof(bodyrepresentingOrganizationRelationshipName), required: false);
            var __workflow_bodynominatedByCustomerRecordNumber = WorkflowExpression.Compile(bodynominatedByCustomerRecordNumber, nameof(bodynominatedByCustomerRecordNumber), required: false);
            var __workflow_bodycommitteeTerm = WorkflowExpression.Compile(bodycommitteeTerm, nameof(bodycommitteeTerm), required: false);
            var __workflow_bodyrank = WorkflowExpression.Compile(bodyrank, nameof(bodyrank), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Committees/{0}/Members/{1}/{2}", __workflow_code.WithUrlEncoding(1), __workflow_memberRecordNumber.WithUrlEncoding(1), __workflow_currentPositionCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodypositionCode != null)
                {
                    body["positionCode"] = ExpressionConverter.ConvertO(__workflow_bodypositionCode);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentingOrganizationRecordNumber != null)
                {
                    body["representingOrganizationRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentingOrganizationRecordNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentingOrganizationRelationshipName != null)
                {
                    body["representingOrganizationRelationshipName"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentingOrganizationRelationshipName);
                    bodypropCount++;
                }

                if (__workflow_bodynominatedByCustomerRecordNumber != null)
                {
                    body["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(__workflow_bodynominatedByCustomerRecordNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycommitteeTerm != null)
                {
                    body["committeeTerm"] = ExpressionConverter.ConvertO(__workflow_bodycommitteeTerm);
                    bodypropCount++;
                }

                if (__workflow_bodyrank != null)
                {
                    body["rank"] = ExpressionConverter.ConvertO(__workflow_bodyrank);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData, ApiConnectionActionConfiguration> AddOrganization(Expression<Func<string>> bodyname, Expression<Func<string>> bodybranchName = null, Expression<Func<string>> bodywebsite = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodybranchName = WorkflowExpression.Compile(bodybranchName, nameof(bodybranchName), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            return new DeferredBodyAction<OrganizationData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/Organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["showInDirectory"] = false;
                bodypropCount++;
                if (__workflow_bodybranchName != null)
                {
                    body["branchName"] = ExpressionConverter.ConvertO(__workflow_bodybranchName);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OrganizationData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData, ApiConnectionActionConfiguration> UpdateOrganization(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodybranchName = null, Expression<Func<string>> bodywebsite = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyshowInDirectory = WorkflowExpression.Compile(bodyshowInDirectory, nameof(bodyshowInDirectory), required: false);
            var __workflow_bodybranchName = WorkflowExpression.Compile(bodybranchName, nameof(bodybranchName), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            return new DeferredBodyAction<OrganizationData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInDirectory != null)
                {
                    body["showInDirectory"] = ExpressionConverter.ConvertO(__workflow_bodyshowInDirectory);
                    bodypropCount++;
                }

                if (__workflow_bodybranchName != null)
                {
                    body["branchName"] = ExpressionConverter.ConvertO(__workflow_bodybranchName);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OrganizationData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData, ApiConnectionActionConfiguration> OrganizationGetProfile(Expression<Func<string>> idOrRecordnumber)
        {
            var __workflow_idOrRecordnumber = WorkflowExpression.Compile(idOrRecordnumber, nameof(idOrRecordnumber), required: true);
            return new DeferredBodyAction<OrganizationData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/Profile/{0}/{1}", __workflow_idOrRecordnumber.WithUrlEncoding(1), WorkflowExpression.Literal(1).WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDescription"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<OrganizationData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OrganizationAddNote(Expression<Func<string>> id, Expression<Func<string>> notecontent, Expression<Func<bool>> noteisAlert = null, Expression<Func<string>> notetitle = null, Expression<Func<string>> notefollowUpDate = null, Expression<Func<string>> notecategory = null, Expression<Func<bool>> noteisInternal = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_notecontent = WorkflowExpression.Compile(notecontent, nameof(notecontent), required: true);
            var __workflow_noteisAlert = WorkflowExpression.Compile(noteisAlert, nameof(noteisAlert), required: false);
            var __workflow_notetitle = WorkflowExpression.Compile(notetitle, nameof(notetitle), required: false);
            var __workflow_notefollowUpDate = WorkflowExpression.Compile(notefollowUpDate, nameof(notefollowUpDate), required: false);
            var __workflow_notecategory = WorkflowExpression.Compile(notecategory, nameof(notecategory), required: false);
            var __workflow_noteisInternal = WorkflowExpression.Compile(noteisInternal, nameof(noteisInternal), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/{0}/Notes", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var note = new JObject();
                var notepropCount = 0;
                if (__workflow_noteisAlert != null)
                {
                    note["isAlert"] = ExpressionConverter.ConvertO(__workflow_noteisAlert);
                    notepropCount++;
                }

                if (__workflow_notetitle != null)
                {
                    note["title"] = ExpressionConverter.ConvertO(__workflow_notetitle);
                    notepropCount++;
                }

                if (__workflow_notefollowUpDate != null)
                {
                    note["followUpDate"] = ExpressionConverter.ConvertO(__workflow_notefollowUpDate);
                    notepropCount++;
                }

                notepropCount++;
                note["content"] = ExpressionConverter.ConvertO(__workflow_notecontent);
                if (__workflow_notecategory != null)
                {
                    note["category"] = ExpressionConverter.ConvertO(__workflow_notecategory);
                    notepropCount++;
                }

                if (__workflow_noteisInternal != null)
                {
                    note["isInternal"] = ExpressionConverter.ConvertO(__workflow_noteisInternal);
                    notepropCount++;
                }

                if (notepropCount > 0)
                {
                    callPayload.Body = note;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationLookupByNameResponse, ApiConnectionActionConfiguration> OrganizationLookupByName(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<OrganizationLookupByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Organizations/Lookup/{0}", WorkflowExpression.Literal(1).WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["includeAddresses"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<OrganizationLookupByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllCommitteesResponse, ApiConnectionActionConfiguration> GetAllCommittees(Expression<Func<int>> pageNumber, Expression<Func<string>> code = null, Expression<Func<string>> name = null, Expression<Func<int>> term = null, Expression<Func<bool>> activeOnly = null)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: false);
            var __workflow_activeOnly = WorkflowExpression.Compile(activeOnly, nameof(activeOnly), required: false);
            return new DeferredBodyAction<GetAllCommitteesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Committees/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_term != null)
                    callPayload.Queries["Term"] = ExpressionConverter.Convert(__workflow_term);
                if (__workflow_activeOnly != null)
                    callPayload.Queries["activeOnly"] = ExpressionConverter.Convert(__workflow_activeOnly);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetAllCommitteesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetPositionsByCommitteeResponse, ApiConnectionActionConfiguration> GetPositionsByCommittee(Expression<Func<string>> code)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            return new DeferredBodyAction<GetPositionsByCommitteeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Committees/{0}/Positions", __workflow_code.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetPositionsByCommitteeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetSubCommitteesResponse, ApiConnectionActionConfiguration> GetSubCommittees(Expression<Func<string>> code, Expression<Func<int>> pageNumber)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetSubCommitteesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Committees/{0}/subcommittees/{1}", __workflow_code.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSubCommitteesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetIndividualsActiveSubscriptionsResponse, ApiConnectionActionConfiguration> GetIndividualsActiveSubscriptions(Expression<Func<string>> id, Expression<Func<int>> pageNumber)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            return new DeferredBodyAction<GetIndividualsActiveSubscriptionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}/Subscriptions/All/{1}", __workflow_id.WithUrlEncoding(1), __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetIndividualsActiveSubscriptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllIndividualsResponse, ApiConnectionActionConfiguration> ListAllIndividuals(Expression<Func<int>> pageNumber, Expression<Func<string>> name = null, Expression<Func<bool>> includeDetails = null, Expression<Func<string>> oldId = null)
        {
            var __workflow_pageNumber = WorkflowExpression.Compile(pageNumber, nameof(pageNumber), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_includeDetails = WorkflowExpression.Compile(includeDetails, nameof(includeDetails), required: false);
            var __workflow_oldId = WorkflowExpression.Compile(oldId, nameof(oldId), required: false);
            return new DeferredBodyAction<ListAllIndividualsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Individuals/{0}", __workflow_pageNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["includeDetails"] = Convert.ToString(true);
                if (__workflow_includeDetails != null)
                    callPayload.Queries["includeDetails"] = ExpressionConverter.Convert(__workflow_includeDetails);
                if (__workflow_oldId != null)
                    callPayload.Queries["oldID"] = ExpressionConverter.Convert(__workflow_oldId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ListAllIndividualsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindCustomerPhoneResponse, ApiConnectionActionConfiguration> FindCustomerPhone(Expression<Func<string>> phoneNumber)
        {
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: true);
            return new DeferredBodyAction<FindCustomerPhoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Customers/{0}", WorkflowExpression.Literal("1").WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["phoneNumber"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                callPayload.Queries["includeAddress"] = Convert.ToString(true);
                callPayload.Queries["includePhone"] = Convert.ToString(true);
                callPayload.Queries["includeEmail"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<FindCustomerPhoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarkRegistrantAttended(Expression<Func<string>> recordNumber, Expression<Func<bodyInputItem2[]>> body = null)
        {
            var __workflow_recordNumber = WorkflowExpression.Compile(recordNumber, nameof(recordNumber), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Events/Registrants/{0}/Attended", __workflow_recordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AwardsAddAwardNomination(Expression<Func<string>> id, Expression<Func<string>> awardNominationDatanomineeRecordNumber, Expression<Func<string>> awardNominationDatanominatedByCustomerRecordNumber, Expression<Func<string>> awardNominationDatanominationDate, Expression<Func<string>> awardNominationDataawardedDate = null, Expression<Func<awardNominationDatastatusInput>> awardNominationDatastatus = null, Expression<Func<string>> awardNominationDatadescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_awardNominationDatanomineeRecordNumber = WorkflowExpression.Compile(awardNominationDatanomineeRecordNumber, nameof(awardNominationDatanomineeRecordNumber), required: true);
            var __workflow_awardNominationDatanominatedByCustomerRecordNumber = WorkflowExpression.Compile(awardNominationDatanominatedByCustomerRecordNumber, nameof(awardNominationDatanominatedByCustomerRecordNumber), required: true);
            var __workflow_awardNominationDatanominationDate = WorkflowExpression.Compile(awardNominationDatanominationDate, nameof(awardNominationDatanominationDate), required: true);
            var __workflow_awardNominationDataawardedDate = WorkflowExpression.Compile(awardNominationDataawardedDate, nameof(awardNominationDataawardedDate), required: false);
            var __workflow_awardNominationDatastatus = WorkflowExpression.Compile(awardNominationDatastatus, nameof(awardNominationDatastatus), required: false);
            var __workflow_awardNominationDatadescription = WorkflowExpression.Compile(awardNominationDatadescription, nameof(awardNominationDatadescription), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Awards/{0}/Nominations", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var awardNominationData = new JObject();
                var awardNominationDatapropCount = 0;
                awardNominationDatapropCount++;
                awardNominationData["nomineeRecordNumber"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatanomineeRecordNumber);
                awardNominationDatapropCount++;
                awardNominationData["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatanominatedByCustomerRecordNumber);
                awardNominationDatapropCount++;
                awardNominationData["nominationDate"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatanominationDate);
                if (__workflow_awardNominationDataawardedDate != null)
                {
                    awardNominationData["awardedDate"] = ExpressionConverter.ConvertO(__workflow_awardNominationDataawardedDate);
                    awardNominationDatapropCount++;
                }

                if (__workflow_awardNominationDatastatus != null)
                {
                    awardNominationData["status"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatastatus);
                    awardNominationDatapropCount++;
                }

                if (__workflow_awardNominationDatadescription != null)
                {
                    awardNominationData["description"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatadescription);
                    awardNominationDatapropCount++;
                }

                if (awardNominationDatapropCount > 0)
                {
                    callPayload.Body = awardNominationData;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AwardsUpdateAwardNomination(Expression<Func<string>> id, Expression<Func<string>> nomineeRecordNumber, Expression<Func<string>> awardNominationDatanominatedByCustomerRecordNumber, Expression<Func<string>> awardNominationDatanominationDate, Expression<Func<string>> awardNominationDataawardedDate = null, Expression<Func<awardNominationDatastatusInput>> awardNominationDatastatus = null, Expression<Func<string>> awardNominationDatadescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_nomineeRecordNumber = WorkflowExpression.Compile(nomineeRecordNumber, nameof(nomineeRecordNumber), required: true);
            var __workflow_awardNominationDatanominatedByCustomerRecordNumber = WorkflowExpression.Compile(awardNominationDatanominatedByCustomerRecordNumber, nameof(awardNominationDatanominatedByCustomerRecordNumber), required: true);
            var __workflow_awardNominationDatanominationDate = WorkflowExpression.Compile(awardNominationDatanominationDate, nameof(awardNominationDatanominationDate), required: true);
            var __workflow_awardNominationDataawardedDate = WorkflowExpression.Compile(awardNominationDataawardedDate, nameof(awardNominationDataawardedDate), required: false);
            var __workflow_awardNominationDatastatus = WorkflowExpression.Compile(awardNominationDatastatus, nameof(awardNominationDatastatus), required: false);
            var __workflow_awardNominationDatadescription = WorkflowExpression.Compile(awardNominationDatadescription, nameof(awardNominationDatadescription), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Awards/{0}/Nominations/{1}", __workflow_id.WithUrlEncoding(1), __workflow_nomineeRecordNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var awardNominationData = new JObject();
                var awardNominationDatapropCount = 0;
                awardNominationDatapropCount++;
                awardNominationData["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatanominatedByCustomerRecordNumber);
                awardNominationDatapropCount++;
                awardNominationData["nominationDate"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatanominationDate);
                if (__workflow_awardNominationDataawardedDate != null)
                {
                    awardNominationData["awardedDate"] = ExpressionConverter.ConvertO(__workflow_awardNominationDataawardedDate);
                    awardNominationDatapropCount++;
                }

                if (__workflow_awardNominationDatastatus != null)
                {
                    awardNominationData["status"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatastatus);
                    awardNominationDatapropCount++;
                }

                if (__workflow_awardNominationDatadescription != null)
                {
                    awardNominationData["description"] = ExpressionConverter.ConvertO(__workflow_awardNominationDatadescription);
                    awardNominationDatapropCount++;
                }

                if (awardNominationDatapropCount > 0)
                {
                    callPayload.Body = awardNominationData;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AwardsGetIndividualAwardRecipientsResponse, ApiConnectionActionConfiguration> AwardsGetIndividualAwardRecipients(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AwardsGetIndividualAwardRecipientsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Awards/{0}/Recipients/Individuals/{1}", __workflow_id.WithUrlEncoding(1), WorkflowExpression.Literal(1).WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDetails"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<AwardsGetIndividualAwardRecipientsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AwardsGetOrganizationAwardRecipientsResponse, ApiConnectionActionConfiguration> AwardsGetOrganizationAwardRecipients(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AwardsGetOrganizationAwardRecipientsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/Awards/{0}/Recipients/Organizations/{1}", __workflow_id.WithUrlEncoding(1), WorkflowExpression.Literal(1).WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDetails"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<AwardsGetOrganizationAwardRecipientsResponse>(callPayload);
            });
        }
    }

    public class ImpexiumTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenIndividualCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenIndividualDeleted(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenIndividualRequestForgotten(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenProductPurchased(Expression<Func<string[]>> bodyfilters, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilters = WorkflowExpression.Compile(bodyfilters, nameof(bodyfilters), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                body["filters"] = ExpressionConverter.ConvertO(__workflow_bodyfilters);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenCommitteeMemberUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenPurchaseCancelled(Expression<Func<string[]>> bodyfilters, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilters = WorkflowExpression.Compile(bodyfilters, nameof(bodyfilters), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                body["filters"] = ExpressionConverter.ConvertO(__workflow_bodyfilters);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenRequestUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenEmailUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenCustomerCustomFieldValueUpdated(Expression<Func<string[]>> bodyfilters, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilters = WorkflowExpression.Compile(bodyfilters, nameof(bodyfilters), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                body["filters"] = ExpressionConverter.ConvertO(__workflow_bodyfilters);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenCustomerIsMerged(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenCustomerRelationshipUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenCustomerPhoneUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenCustomerAddressUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenEventRegistrationSubstituted(Expression<Func<string[]>> bodyfilters, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilters = WorkflowExpression.Compile(bodyfilters, nameof(bodyfilters), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                body["filters"] = ExpressionConverter.ConvertO(__workflow_bodyfilters);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenPurchasePaid(Expression<Func<string[]>> bodyfilters, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyfilters = WorkflowExpression.Compile(bodyfilters, nameof(bodyfilters), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                body["filters"] = ExpressionConverter.ConvertO(__workflow_bodyfilters);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenMembershipTerminated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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