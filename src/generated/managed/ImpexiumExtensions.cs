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
        public IBodyWorkflowAction<GetAbandonedCheckoutsResponse> GetAbandonedCheckouts(Expression<Func<int>> pageNumber, Expression<Func<string>> abandonedFrom, Expression<Func<string>> productCode = null, Expression<Func<string>> customerRecordNumber = null)
        {
            var apiCallPath = String.Format("/api/v1/Shopping/AbandonedCheckOuts/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["abandonedFrom"] = ExpressionConverter.Convert(abandonedFrom);
            if (productCode != null)
                callPayload.Queries["productCode"] = ExpressionConverter.Convert(productCode);
            if (customerRecordNumber != null)
                callPayload.Queries["customerRecordNumber"] = ExpressionConverter.Convert(customerRecordNumber);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAbandonedCheckoutsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllExhibitorsResponse> ListAllExhibitors(Expression<Func<string>> exhibitCode, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Exhibits/{0}/Exhibitors/{1}", ExpressionConverter.ConvertWithUrlEncoding(exhibitCode, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListAllExhibitorsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfExamsResponse> ListOfExams(Expression<Func<int>> pageNumber, Expression<Func<string>> code = null, Expression<Func<string>> categoryName = null, Expression<Func<bool>> isPublic = null, Expression<Func<string>> changedSince = null, Expression<Func<string>> tag = null, Expression<Func<bool>> includePrices = null)
        {
            var apiCallPath = String.Format("/api/v1/Products/Exams/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (code != null)
                callPayload.Queries["Code"] = ExpressionConverter.Convert(code);
            if (categoryName != null)
                callPayload.Queries["categoryName"] = ExpressionConverter.Convert(categoryName);
            if (isPublic != null)
                callPayload.Queries["isPublic"] = ExpressionConverter.Convert(isPublic);
            if (changedSince != null)
                callPayload.Queries["changedSince"] = ExpressionConverter.Convert(changedSince);
            if (tag != null)
                callPayload.Queries["Tag"] = ExpressionConverter.Convert(tag);
            if (includePrices != null)
                callPayload.Queries["includePrices"] = ExpressionConverter.Convert(includePrices);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListOfExamsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListRegistrantsResponse> ListRegistrants(Expression<Func<string>> eventCode, Expression<Func<int>> pageNumber, Expression<Func<string>> sessionCode = null, Expression<Func<bool>> includeDetails = null, Expression<Func<string>> registeredSince = null)
        {
            var apiCallPath = String.Format("/api/v1/Events/{0}/Registrations/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventCode, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sessionCode != null)
                callPayload.Queries["sessionCode"] = ExpressionConverter.Convert(sessionCode);
            if (includeDetails != null)
                callPayload.Queries["includeDetails"] = ExpressionConverter.Convert(includeDetails);
            if (registeredSince != null)
                callPayload.Queries["registeredSince"] = ExpressionConverter.Convert(registeredSince);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListRegistrantsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetCourseAttendeesResponse> GetCourseAttendees(Expression<Func<string>> code, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Courses/{0}/Attendees/{1}", ExpressionConverter.ConvertWithUrlEncoding(code, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetCourseAttendeesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ExamScoreResultData[]> AddExamScores(Expression<Func<string>> examCode, Expression<Func<ExamScoreData[]>> scores = null)
        {
            var apiCallPath = String.Format("/api/v1/Exams/{0}/Scores", ExpressionConverter.ConvertWithUrlEncoding(examCode, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(scores);
            return new ApiConnectionAction<ExamScoreResultData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersByNameResponse> FindMembersByName(Expression<Func<string>> name, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Customers/Members/FindByName/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(name, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<FindMembersByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetPurchasesForAnIndividualResponse> GetPurchasesForAnIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<int>> pageNumber, Expression<Func<string>> productCode = null, Expression<Func<string>> purchasedSince = null, Expression<Func<string>> productCategoryCode = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Purchases/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (productCode != null)
                callPayload.Queries["productCode"] = ExpressionConverter.Convert(productCode);
            if (purchasedSince != null)
                callPayload.Queries["purchasedSince"] = ExpressionConverter.Convert(purchasedSince);
            if (productCategoryCode != null)
                callPayload.Queries["productCategoryCode"] = ExpressionConverter.Convert(productCategoryCode);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetPurchasesForAnIndividualResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldResultData[]> AddOrUpdateAListOfCustomFieldsPerOrganization(Expression<Func<string>> iDOrRecordNumber, Expression<Func<CustomFieldValueData[]>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/CustomFieldsList", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CustomFieldResultData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddNominee(Expression<Func<string>> code, Expression<Func<string>> bodynomineeRecordNumber = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyrepresentingOrganizationRecordNumber = null, Expression<Func<string>> bodyrepresentingOrganizationRelationshipName = null, Expression<Func<string>> bodynominatedByCustomerRecordNumber = null, Expression<Func<int>> bodycommitteeTerm = null, Expression<Func<int>> bodyrank = null)
        {
            var apiCallPath = String.Format("/api/v1/Committees/{0}/Nominations", ExpressionConverter.ConvertWithUrlEncoding(code, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodynomineeRecordNumber != null)
            {
                body["nomineeRecordNumber"] = ExpressionConverter.ConvertO(bodynomineeRecordNumber);
                bodypropCount++;
            }

            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodypositionCode != null)
            {
                body["positionCode"] = ExpressionConverter.ConvertO(bodypositionCode);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyrepresentingOrganizationRecordNumber != null)
            {
                body["representingOrganizationRecordNumber"] = ExpressionConverter.ConvertO(bodyrepresentingOrganizationRecordNumber);
                bodypropCount++;
            }

            if (bodyrepresentingOrganizationRelationshipName != null)
            {
                body["representingOrganizationRelationshipName"] = ExpressionConverter.ConvertO(bodyrepresentingOrganizationRelationshipName);
                bodypropCount++;
            }

            if (bodynominatedByCustomerRecordNumber != null)
            {
                body["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(bodynominatedByCustomerRecordNumber);
                bodypropCount++;
            }

            if (bodycommitteeTerm != null)
            {
                body["committeeTerm"] = ExpressionConverter.ConvertO(bodycommitteeTerm);
                bodypropCount++;
            }

            if (bodyrank != null)
            {
                body["rank"] = ExpressionConverter.ConvertO(bodyrank);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldData[]> GetIndividualCustomFieldValues(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/CustomFields", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<CustomFieldData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction UpdateCustomFieldValue(Expression<Func<string>> iD, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycaption = null, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/CustomFields", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycaption != null)
            {
                body["caption"] = ExpressionConverter.ConvertO(bodycaption);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllEventCancellationsByEventResponse> ListAllEventCancellationsByEvent(Expression<Func<string>> eventCode, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeDetails = null, Expression<Func<string>> cancelledSince = null)
        {
            var apiCallPath = String.Format("/api/v1/Events/{0}/Cancellations/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventCode, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeDetails != null)
                callPayload.Queries["includeDetails"] = ExpressionConverter.Convert(includeDetails);
            if (cancelledSince != null)
                callPayload.Queries["cancelledSince"] = ExpressionConverter.Convert(cancelledSince);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListAllEventCancellationsByEventResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllOpenOrdersForAnIndividualResponse> GetAllOpenOrdersForAnIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeLineItems = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Orders/Open/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeLineItems != null)
                callPayload.Queries["includeLineItems"] = ExpressionConverter.Convert(includeLineItems);
            if (fromDate != null)
                callPayload.Queries["fromDate"] = ExpressionConverter.Convert(fromDate);
            if (toDate != null)
                callPayload.Queries["toDate"] = ExpressionConverter.Convert(toDate);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAllOpenOrdersForAnIndividualResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListCompletedUserTasksByUserIDOrEmailResponse> ListCompletedUserTasksByUserIDOrEmail(Expression<Func<string>> userIDOrEmail, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/tasks/Users/{0}/Completed/{1}", ExpressionConverter.ConvertWithUrlEncoding(userIDOrEmail, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListCompletedUserTasksByUserIDOrEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListPendingUserTasksByUserIDOrEmailResponse> ListPendingUserTasksByUserIDOrEmail(Expression<Func<string>> userIDOrEmail, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/tasks/Users/{0}/Pending/{1}", ExpressionConverter.ConvertWithUrlEncoding(userIDOrEmail, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListPendingUserTasksByUserIDOrEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddNoteToSalesOpportunity(Expression<Func<string>> iD, Expression<Func<string>> bodyContent = null, Expression<Func<string>> bodyCategory = null, Expression<Func<bool>> bodyisInternal = null)
        {
            var apiCallPath = String.Format("/api/v1/Sales/Opportunities/{0}/Notes", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyContent != null)
            {
                body["Content"] = ExpressionConverter.ConvertO(bodyContent);
                bodypropCount++;
            }

            if (bodyCategory != null)
            {
                body["Category"] = ExpressionConverter.ConvertO(bodyCategory);
                bodypropCount++;
            }

            if (bodyisInternal != null)
            {
                body["isInternal"] = ExpressionConverter.ConvertO(bodyisInternal);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddActivityToSalesOpportunity(Expression<Func<string>> iD, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyactivityDate = null)
        {
            var apiCallPath = String.Format("/api/v1/Sales/Opportunities/{0}/Activities", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodyactivityDate != null)
            {
                body["activityDate"] = ExpressionConverter.ConvertO(bodyactivityDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<TaskData> UpdateTaskByTaskNumber(Expression<Func<string>> taskNumber, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null)
        {
            var apiCallPath = String.Format("/api/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllCountriesResponse> ListAllCountries(Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Countries/All/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListAllCountriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllStatesByCountryResponse> GetAllStatesByCountry(Expression<Func<string>> countryID, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Countries/{0}/States/All/{1}", ExpressionConverter.ConvertWithUrlEncoding(countryID, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAllStatesByCountryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllExhibitsResponse> ListAllExhibits(Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Exhibits/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListAllExhibitsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteACategoryForAnOrganization(Expression<Func<string>> recordNumber, Expression<Func<string>> categoryCode)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Categories/{1}", ExpressionConverter.ConvertWithUrlEncoding(recordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(categoryCode, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddCustomerRequest(Expression<Func<string>> bodyrequestedByCustomerRecordNumber = null, Expression<Func<string>> bodyrequestType = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodysourceInput>> bodysource = null)
        {
            var apiCallPath = "/api/v1/Requests";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrequestedByCustomerRecordNumber != null)
            {
                body["requestedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(bodyrequestedByCustomerRecordNumber);
                bodypropCount++;
            }

            if (bodyrequestType != null)
            {
                body["requestType"] = ExpressionConverter.ConvertO(bodyrequestType);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<RequestUpdateData> UpdateCustomerRequest(Expression<Func<string>> bodyrequestNumber = null, Expression<Func<string>> bodyclosedDate = null)
        {
            var apiCallPath = "/api/v1/Requests";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrequestNumber != null)
            {
                body["requestNumber"] = ExpressionConverter.ConvertO(bodyrequestNumber);
                bodypropCount++;
            }

            if (bodyclosedDate != null)
            {
                body["closedDate"] = ExpressionConverter.ConvertO(bodyclosedDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RequestUpdateData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddCategoriesForAnOrganization(Expression<Func<string>> recordNumber, Expression<Func<SaveCategoryBasicData[]>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Categories", ExpressionConverter.ConvertWithUrlEncoding(recordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfCustomerRelationshipsResponse> ListOfCustomerRelationships(Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Customers/RelationshipTypes/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListOfCustomerRelationshipsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllOpenCustomerRequestResponse> ListAllOpenCustomerRequest(Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Requests/Open/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListAllOpenCustomerRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData> GetOrganizationInactiveMemberships(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Memberships/Inactive", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<MembershipData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteRecordFromCustomDataTable(Expression<Func<string>> tableName, Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/api/v1/CustomData/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(tableName, 1), ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<UserTaskData> UpdateUserTaskProgressOrMarkAsCompleted(Expression<Func<string>> userIDOrEmail, Expression<Func<string>> bodytaskNumber = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyassignedBy = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyprogress = null, Expression<Func<string>> bodycompletedDate = null)
        {
            var apiCallPath = String.Format("/api/v1/tasks/Users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userIDOrEmail, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytaskNumber != null)
            {
                body["taskNumber"] = ExpressionConverter.ConvertO(bodytaskNumber);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyassignedBy != null)
            {
                body["assignedBy"] = ExpressionConverter.ConvertO(bodyassignedBy);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodyprogress != null)
            {
                body["progress"] = ExpressionConverter.ConvertO(bodyprogress);
                bodypropCount++;
            }

            if (bodycompletedDate != null)
            {
                body["completedDate"] = ExpressionConverter.ConvertO(bodycompletedDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserTaskData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData> FindMembersOrIndividualsByFirstName(Expression<Func<string>> firstName, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeEmail = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/Members/FindByFirstName/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(firstName, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeEmail != null)
                callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(includeEmail);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<IndividualData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData> FindMembersOrIndividualsByLastName(Expression<Func<string>> lastName, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeEmail = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/Members/FindByLastName/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(lastName, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeEmail != null)
                callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(includeEmail);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<IndividualData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AssignTaskToAUser(Expression<Func<string>> userIDOrEmail, Expression<Func<string>> bodytaskNumber = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyassignedBy = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyprogress = null, Expression<Func<string>> bodycompletedDate = null)
        {
            var apiCallPath = String.Format("/api/v1/tasks/Users/{0}/Task", ExpressionConverter.ConvertWithUrlEncoding(userIDOrEmail, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytaskNumber != null)
            {
                body["taskNumber"] = ExpressionConverter.ConvertO(bodytaskNumber);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyassignedBy != null)
            {
                body["assignedBy"] = ExpressionConverter.ConvertO(bodyassignedBy);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodyprogress != null)
            {
                body["progress"] = ExpressionConverter.ConvertO(bodyprogress);
                bodypropCount++;
            }

            if (bodycompletedDate != null)
            {
                body["completedDate"] = ExpressionConverter.ConvertO(bodycompletedDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteACategoryForAnIndividual(Expression<Func<string>> recordNumber, Expression<Func<string>> categoryCode)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Categories/{1}", ExpressionConverter.ConvertWithUrlEncoding(recordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(categoryCode, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddNotificationToIndividual(Expression<Func<string>> iD, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodydate = null, Expression<Func<bool>> bodyisRead = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Notifications", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyisRead != null)
            {
                body["isRead"] = ExpressionConverter.ConvertO(bodyisRead);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddCategoriesForAnIndividual(Expression<Func<string>> recordNumber, Expression<Func<SaveCategoryBasicData[]>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Categories", ExpressionConverter.ConvertWithUrlEncoding(recordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<TaskData> AddANewTask(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodydueDate = null)
        {
            var apiCallPath = "/api/v1/tasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfAllOrganizationMembersResponse> ListOfAllOrganizationMembers(Expression<Func<int>> pageNumber, Expression<Func<string>> zipCode = null, Expression<Func<double>> radius = null, Expression<Func<string>> stateAbbreviation = null, Expression<Func<double>> congressionalDistrict = null, Expression<Func<string>> membershipTypeCode = null, Expression<Func<string>> membershipTypeCategory = null, Expression<Func<string>> city = null, Expression<Func<string>> name = null, Expression<Func<string>> tag = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<string>> domain = null, Expression<Func<bool>> includeMembership = null, Expression<Func<bool>> includeAddress = null, Expression<Func<bool>> includePhone = null, Expression<Func<bool>> includeEmail = null, Expression<Func<bool>> includeCustomFields = null, Expression<Func<string>> expiringFrom = null, Expression<Func<string>> expiringTo = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/Members/All/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (zipCode != null)
                callPayload.Queries["zipCode"] = ExpressionConverter.Convert(zipCode);
            callPayload.Queries["Radius"] = Convert.ToString(5);
            if (radius != null)
                callPayload.Queries["Radius"] = ExpressionConverter.Convert(radius);
            if (stateAbbreviation != null)
                callPayload.Queries["stateAbbreviation"] = ExpressionConverter.Convert(stateAbbreviation);
            callPayload.Queries["congressionalDistrict"] = Convert.ToString(-1);
            if (congressionalDistrict != null)
                callPayload.Queries["congressionalDistrict"] = ExpressionConverter.Convert(congressionalDistrict);
            if (membershipTypeCode != null)
                callPayload.Queries["membershipTypeCode"] = ExpressionConverter.Convert(membershipTypeCode);
            if (membershipTypeCategory != null)
                callPayload.Queries["membershipTypeCategory"] = ExpressionConverter.Convert(membershipTypeCategory);
            if (city != null)
                callPayload.Queries["City"] = ExpressionConverter.Convert(city);
            if (name != null)
                callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
            if (tag != null)
                callPayload.Queries["Tag"] = ExpressionConverter.Convert(tag);
            if (latitude != null)
                callPayload.Queries["Latitude"] = ExpressionConverter.Convert(latitude);
            if (longitude != null)
                callPayload.Queries["Longitude"] = ExpressionConverter.Convert(longitude);
            if (domain != null)
                callPayload.Queries["Domain"] = ExpressionConverter.Convert(domain);
            if (includeMembership != null)
                callPayload.Queries["includeMembership"] = ExpressionConverter.Convert(includeMembership);
            if (includeAddress != null)
                callPayload.Queries["includeAddress"] = ExpressionConverter.Convert(includeAddress);
            if (includePhone != null)
                callPayload.Queries["includePhone"] = ExpressionConverter.Convert(includePhone);
            if (includeEmail != null)
                callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(includeEmail);
            if (includeCustomFields != null)
                callPayload.Queries["includeCustomFields"] = ExpressionConverter.Convert(includeCustomFields);
            if (expiringFrom != null)
                callPayload.Queries["expiringFrom"] = ExpressionConverter.Convert(expiringFrom);
            if (expiringTo != null)
                callPayload.Queries["expiringTo"] = ExpressionConverter.Convert(expiringTo);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListOfAllOrganizationMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListOfAllIndividualMembersResponse> ListOfAllIndividualMembers(Expression<Func<int>> pageNumber, Expression<Func<string>> zipCode = null, Expression<Func<double>> radius = null, Expression<Func<string>> membershipTypeCode = null, Expression<Func<string>> membershipTypeCategory = null, Expression<Func<string>> tag = null, Expression<Func<bool>> includeMembership = null, Expression<Func<bool>> includeAddress = null, Expression<Func<bool>> includePhone = null, Expression<Func<bool>> includeEmail = null, Expression<Func<bool>> includeLink = null, Expression<Func<bool>> includeCustomFields = null, Expression<Func<bool>> includeCategories = null, Expression<Func<bool>> includeMembershipRenewalUrl = null, Expression<Func<string>> expiringFrom = null, Expression<Func<string>> expiringTo = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/Members/All/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (zipCode != null)
                callPayload.Queries["zipCode"] = ExpressionConverter.Convert(zipCode);
            callPayload.Queries["Radius"] = Convert.ToString(5);
            if (radius != null)
                callPayload.Queries["Radius"] = ExpressionConverter.Convert(radius);
            if (membershipTypeCode != null)
                callPayload.Queries["membershipTypeCode"] = ExpressionConverter.Convert(membershipTypeCode);
            if (membershipTypeCategory != null)
                callPayload.Queries["membershipTypeCategory"] = ExpressionConverter.Convert(membershipTypeCategory);
            if (tag != null)
                callPayload.Queries["Tag"] = ExpressionConverter.Convert(tag);
            if (includeMembership != null)
                callPayload.Queries["includeMembership"] = ExpressionConverter.Convert(includeMembership);
            if (includeAddress != null)
                callPayload.Queries["includeAddress"] = ExpressionConverter.Convert(includeAddress);
            if (includePhone != null)
                callPayload.Queries["includePhone"] = ExpressionConverter.Convert(includePhone);
            if (includeEmail != null)
                callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(includeEmail);
            if (includeLink != null)
                callPayload.Queries["includeLink"] = ExpressionConverter.Convert(includeLink);
            if (includeCustomFields != null)
                callPayload.Queries["includeCustomFields"] = ExpressionConverter.Convert(includeCustomFields);
            if (includeCategories != null)
                callPayload.Queries["includeCategories"] = ExpressionConverter.Convert(includeCategories);
            if (includeMembershipRenewalUrl != null)
                callPayload.Queries["includeMembershipRenewalUrl"] = ExpressionConverter.Convert(includeMembershipRenewalUrl);
            if (expiringFrom != null)
                callPayload.Queries["expiringFrom"] = ExpressionConverter.Convert(expiringFrom);
            if (expiringTo != null)
                callPayload.Queries["expiringTo"] = ExpressionConverter.Convert(expiringTo);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListOfAllIndividualMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetListOfActiveCertificationsForAnOrganizationResponse> GetListOfActiveCertificationsForAnOrganization(Expression<Func<string>> iDOrRecordNumber, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Certifications/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetListOfActiveCertificationsForAnOrganizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetListOfActiveCertificationsForAnIndividualResponse> GetListOfActiveCertificationsForAnIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Certifications/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetListOfActiveCertificationsForAnIndividualResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData> GetIndividualInactiveMemberships(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Memberships/Inactive", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<MembershipData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddActivityToOrganization(Expression<Func<string>> iD, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyactivityDate = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Activities", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodyactivityDate != null)
            {
                body["activityDate"] = ExpressionConverter.ConvertO(bodyactivityDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction RegisterAnIndividualForAFreeSession(Expression<Func<string>> eventCode, Expression<Func<string>> customerIDOrRecordNumber, Expression<Func<string>> registrationNumber = null, Expression<Func<SessionRegistrationData[]>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/Events/{0}/Sessions/Register/{1}", ExpressionConverter.ConvertWithUrlEncoding(eventCode, 1), ExpressionConverter.ConvertWithUrlEncoding(customerIDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (registrationNumber != null)
                callPayload.Queries["registrationNumber"] = ExpressionConverter.Convert(registrationNumber);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAListOfLicensesResponse> GetAListOfLicenses(Expression<Func<string>> iD, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Licenses/{1}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAListOfLicensesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllAwardsResponse> ListAllAwards(Expression<Func<int>> pageNumber, Expression<Func<int>> year = null)
        {
            var apiCallPath = String.Format("/api/v1/Awards/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (year != null)
                callPayload.Queries["Year"] = ExpressionConverter.Convert(year);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListAllAwardsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersOrIndividualsByNameResponse> FindMembersOrIndividualsByName(Expression<Func<string>> name, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeEmail = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/Members/FindByName/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(name, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeEmail != null)
                callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(includeEmail);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<FindMembersOrIndividualsByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAListOfAllServicesOfAnOrganizationResponse> GetAListOfAllServicesOfAnOrganization(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Services", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAListOfAllServicesOfAnOrganizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ServiceData> AddAServiceToAnOrganization(Expression<Func<string>> iD, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Services", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ServiceData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet> UpdatePhoneForAnIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<string>> iD, Expression<Func<string>> bodycountryName, Expression<Func<string>> bodynumber, Expression<Func<bodytypeNameInput>> bodytypeName, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodyextension = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Phones/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["countryName"] = ExpressionConverter.ConvertO(bodycountryName);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodyextension != null)
            {
                body["extension"] = ExpressionConverter.ConvertO(bodyextension);
                bodypropCount++;
            }

            bodypropCount++;
            body["typeName"] = ExpressionConverter.ConvertO(bodytypeName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PhoneDataSet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet> UpdatePhoneForAnOrganization(Expression<Func<string>> iDOrRecordNumber, Expression<Func<string>> iD, Expression<Func<string>> bodycountryName, Expression<Func<string>> bodynumber, Expression<Func<bodytypeNameInput>> bodytypeName, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodyextension = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Phones/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["countryName"] = ExpressionConverter.ConvertO(bodycountryName);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodyextension != null)
            {
                body["extension"] = ExpressionConverter.ConvertO(bodyextension);
                bodypropCount++;
            }

            bodypropCount++;
            body["typeName"] = ExpressionConverter.ConvertO(bodytypeName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PhoneDataSet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteAnIndividualWebLink(Expression<Func<string>> iDOrRecordNumber, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodyurl = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Links", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddWebLinkForIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodyurl = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Links", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet> AddPhoneToOrganization(Expression<Func<string>> iDOrRecordNumber, Expression<Func<string>> bodycountryName, Expression<Func<string>> bodynumber, Expression<Func<bodytypeNameInput>> bodytypeName, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodyextension = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Phones", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["countryName"] = ExpressionConverter.ConvertO(bodycountryName);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodyextension != null)
            {
                body["extension"] = ExpressionConverter.ConvertO(bodyextension);
                bodypropCount++;
            }

            bodypropCount++;
            body["typeName"] = ExpressionConverter.ConvertO(bodytypeName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PhoneDataSet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetNomineesByCommitteeResponse> GetNomineesByCommittee(Expression<Func<string>> code, Expression<Func<int>> pageNumber, Expression<Func<string>> term = null)
        {
            var apiCallPath = String.Format("/api/v1/Committees/{0}/Nominations/{1}", ExpressionConverter.ConvertWithUrlEncoding(code, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (term != null)
                callPayload.Queries["Term"] = ExpressionConverter.Convert(term);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetNomineesByCommitteeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetOrganizationsActiveSubscriptionsResponse> GetOrganizationsActiveSubscriptions(Expression<Func<string>> iD, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetOrganizationsActiveSubscriptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction DeleteAnOrganizationWebLink(Expression<Func<string>> iDOrRecordNumber, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyurl)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Links", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddWebLinkForOrganization(Expression<Func<string>> iDOrRecordNumber, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyurl)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Links", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddEmailToOrganization(Expression<Func<string>> iD, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Emails", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetOrganizationsRelationshipsResponse> GetOrganizationsRelationships(Expression<Func<string>> iD, Expression<Func<int>> pageNumber, Expression<Func<string>> relationshipName = null, Expression<Func<bool>> includesDetails = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (relationshipName != null)
                callPayload.Queries["relationshipName."] = ExpressionConverter.Convert(relationshipName);
            if (includesDetails != null)
                callPayload.Queries["includesDetails"] = ExpressionConverter.Convert(includesDetails);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetOrganizationsRelationshipsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddressSaveData> AddOrUpdateAddressToOrganization(Expression<Func<string>> iDOrRecordNumber, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyline1 = null, Expression<Func<string>> bodyline2 = null, Expression<Func<string>> bodyline3 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<bool>> bodyisPreferredShipping = null, Expression<Func<bool>> bodyisPreferredBilling = null, Expression<Func<bool>> bodyisBadAddress = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Addresses", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyline1 != null)
            {
                body["line1"] = ExpressionConverter.ConvertO(bodyline1);
                bodypropCount++;
            }

            if (bodyline2 != null)
            {
                body["line2"] = ExpressionConverter.ConvertO(bodyline2);
                bodypropCount++;
            }

            if (bodyline3 != null)
            {
                body["line3"] = ExpressionConverter.ConvertO(bodyline3);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodyzipcode != null)
            {
                body["zipcode"] = ExpressionConverter.ConvertO(bodyzipcode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            if (bodyisPreferredShipping != null)
            {
                body["isPreferredShipping"] = ExpressionConverter.ConvertO(bodyisPreferredShipping);
                bodypropCount++;
            }

            if (bodyisPreferredBilling != null)
            {
                body["isPreferredBilling"] = ExpressionConverter.ConvertO(bodyisPreferredBilling);
                bodypropCount++;
            }

            if (bodyisBadAddress != null)
            {
                body["isBadAddress"] = ExpressionConverter.ConvertO(bodyisBadAddress);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddressSaveData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldResultData[]> AddOrUpdateAListOfCustomFieldsPerIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/CustomFieldsList", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CustomFieldResultData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetUpcomingEventsResponse> GetUpcomingEvents(Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Events/Upcoming/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetUpcomingEventsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<PhoneDataSet> AddPhoneToIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<string>> bodycountryName, Expression<Func<string>> bodynumber, Expression<Func<bodytypeNameInput>> bodytypeName, Expression<Func<bool>> bodyprimary = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodyextension = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Phones", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["countryName"] = ExpressionConverter.ConvertO(bodycountryName);
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodyextension != null)
            {
                body["extension"] = ExpressionConverter.ConvertO(bodyextension);
                bodypropCount++;
            }

            bodypropCount++;
            body["typeName"] = ExpressionConverter.ConvertO(bodytypeName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PhoneDataSet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetCommitteeInformationForAnIndividualResponse> GetCommitteeInformationForAnIndividual(Expression<Func<string>> iD, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeInactive = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Committees/{1}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["includeInactive"] = ExpressionConverter.Convert(includeInactive);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetCommitteeInformationForAnIndividualResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<CustomFieldData[]> GetOrganizationCustomFieldValues(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/CustomFields", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<CustomFieldData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData[]> GetOrganizationActiveMemberships(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Memberships/Active", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<MembershipData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllEventsResponse> GetAllEvents(Expression<Func<int>> pageNumber, Expression<Func<string>> code = null, Expression<Func<string>> name = null, Expression<Func<string>> tag = null)
        {
            var apiCallPath = String.Format("/api/v1/Events/All/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (code != null)
                callPayload.Queries["Code"] = ExpressionConverter.Convert(code);
            if (name != null)
                callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
            if (tag != null)
                callPayload.Queries["Tag"] = ExpressionConverter.Convert(tag);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAllEventsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<MembershipData[]> GetIndividualActiveMemberships(Expression<Func<string>> iD)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Memberships/Active", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<MembershipData[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllEventRegistrationsInformationForAnIndividualResponse> GetAllEventRegistrationsInformationForAnIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<int>> pageNumber, Expression<Func<string>> eventCode = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Registrations/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (eventCode != null)
                callPayload.Queries["eventCode"] = ExpressionConverter.Convert(eventCode);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAllEventRegistrationsInformationForAnIndividualResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetIndividualsRelationshipsResponse> GetIndividualsRelationships(Expression<Func<string>> iD, Expression<Func<int>> pageNumber, Expression<Func<string>> relationshipName = null, Expression<Func<bool>> includeDetails = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (relationshipName != null)
                callPayload.Queries["relationshipName"] = ExpressionConverter.Convert(relationshipName);
            if (includeDetails != null)
                callPayload.Queries["includeDetails"] = ExpressionConverter.Convert(includeDetails);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetIndividualsRelationshipsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction UpdateAnIndividualEmail(Expression<Func<string>> iDOrRecordNumber, Expression<Func<string>> currentEmailAddress, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Emails/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(currentEmailAddress, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction SaveRelationshipForOrganization(Expression<Func<string>> iD, Expression<Func<string>> bodyrelationshipName, Expression<Func<string>> bodyrelatedToCustomerRecordNumber, Expression<Func<string>> bodyreciprocalRelationshipName, Expression<Func<bool>> bodyisPrimary = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyisReciprocalPrimary = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Relationships", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["relationshipName"] = ExpressionConverter.ConvertO(bodyrelationshipName);
            bodypropCount++;
            body["relatedToCustomerRecordNumber"] = ExpressionConverter.ConvertO(bodyrelatedToCustomerRecordNumber);
            bodypropCount++;
            body["reciprocalRelationshipName"] = ExpressionConverter.ConvertO(bodyreciprocalRelationshipName);
            if (bodyisPrimary != null)
            {
                body["isPrimary"] = ExpressionConverter.ConvertO(bodyisPrimary);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyisReciprocalPrimary != null)
            {
                body["isReciprocalPrimary"] = ExpressionConverter.ConvertO(bodyisReciprocalPrimary);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualData> AddIndividual(Expression<Func<string>> bodyfirstName, Expression<Func<string>> bodylastName, Expression<Func<bool>> createUser = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyrecordNumber = null)
        {
            var apiCallPath = "/api/v1/Individuals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createUser != null)
                callPayload.Queries["createUser"] = ExpressionConverter.Convert(createUser);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
            bodypropCount++;
            body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyrecordNumber != null)
            {
                body["recordNumber"] = ExpressionConverter.ConvertO(bodyrecordNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IndividualData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<EmailData> AddEmailToIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Emails", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EmailData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddressSaveData> AddOrUpdateAddressToIndividual(Expression<Func<string>> iDOrRecordNumber, Expression<Func<string>> bodyid = null, Expression<Func<bool>> bodyprimary = null, Expression<Func<string>> bodyline1 = null, Expression<Func<string>> bodyline2 = null, Expression<Func<string>> bodyline3 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzipcode = null, Expression<Func<string>> bodycountry = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<bool>> bodyisPreferredShipping = null, Expression<Func<bool>> bodyisPreferredBilling = null, Expression<Func<bool>> bodyisBadAddress = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Addresses", ExpressionConverter.ConvertWithUrlEncoding(iDOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyprimary != null)
            {
                body["primary"] = ExpressionConverter.ConvertO(bodyprimary);
                bodypropCount++;
            }

            if (bodyline1 != null)
            {
                body["line1"] = ExpressionConverter.ConvertO(bodyline1);
                bodypropCount++;
            }

            if (bodyline2 != null)
            {
                body["line2"] = ExpressionConverter.ConvertO(bodyline2);
                bodypropCount++;
            }

            if (bodyline3 != null)
            {
                body["line3"] = ExpressionConverter.ConvertO(bodyline3);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodyzipcode != null)
            {
                body["zipcode"] = ExpressionConverter.ConvertO(bodyzipcode);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            if (bodyisPreferredShipping != null)
            {
                body["isPreferredShipping"] = ExpressionConverter.ConvertO(bodyisPreferredShipping);
                bodypropCount++;
            }

            if (bodyisPreferredBilling != null)
            {
                body["isPreferredBilling"] = ExpressionConverter.ConvertO(bodyisPreferredBilling);
                bodypropCount++;
            }

            if (bodyisBadAddress != null)
            {
                body["isBadAddress"] = ExpressionConverter.ConvertO(bodyisBadAddress);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddressSaveData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindMembersOrIndividualsByFirstAndLastNameResponse> FindMembersOrIndividualsByFirstAndLastName(Expression<Func<string>> firstName, Expression<Func<string>> lastName, Expression<Func<int>> pageNumber, Expression<Func<bool>> includeEmail = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/Members/FindByName/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(firstName, 1), ExpressionConverter.ConvertWithUrlEncoding(lastName, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeEmail != null)
                callPayload.Queries["includeEmail"] = ExpressionConverter.Convert(includeEmail);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<FindMembersOrIndividualsByFirstAndLastNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction GetCommitteeMembersByCommitteeIDOrCode(Expression<Func<string>> iDOrCode, Expression<Func<int>> pageNumber, Expression<Func<int>> term = null, Expression<Func<string>> positionCodes = null)
        {
            var apiCallPath = String.Format("/api/v1/Committees/{0}/Members/{1}", ExpressionConverter.ConvertWithUrlEncoding(iDOrCode, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (term != null)
                callPayload.Queries["Term"] = ExpressionConverter.Convert(term);
            if (positionCodes != null)
                callPayload.Queries["positionCodes"] = ExpressionConverter.Convert(positionCodes);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddActivity(Expression<Func<string>> id, Expression<Func<string>> bodytext, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyactivityDate = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Activities", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["category"] = "Impexium";
            bodypropCount++;
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodyactivityDate != null)
            {
                body["activityDate"] = ExpressionConverter.ConvertO(bodyactivityDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindIndividualIDOrEmailResponse> FindIndividualIDOrEmail(Expression<Func<string>> idOrRecordNumberOrEmail)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/Profile/{0}/{1}/", ExpressionConverter.ConvertWithUrlEncoding(idOrRecordNumberOrEmail, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["IncludeDetails"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<FindIndividualIDOrEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AddRelationshipToIndividual(Expression<Func<string>> id, Expression<Func<string>> bodyrelationshipName, Expression<Func<string>> bodyrelatedToCustomerRecordNumber, Expression<Func<string>> bodyreciprocalRelationshipName, Expression<Func<bool>> bodyisPrimary = null, Expression<Func<bool>> bodyisReciprocalPrimary = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Relationships", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("Application/Json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["relationshipName"] = ExpressionConverter.ConvertO(bodyrelationshipName);
            bodypropCount++;
            body["relatedToCustomerRecordNumber"] = ExpressionConverter.ConvertO(bodyrelatedToCustomerRecordNumber);
            bodypropCount++;
            body["reciprocalRelationshipName"] = ExpressionConverter.ConvertO(bodyreciprocalRelationshipName);
            if (bodyisPrimary != null)
            {
                body["isPrimary"] = ExpressionConverter.ConvertO(bodyisPrimary);
                bodypropCount++;
            }

            if (bodyisReciprocalPrimary != null)
            {
                body["isReciprocalPrimary"] = ExpressionConverter.ConvertO(bodyisReciprocalPrimary);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction IndividualAddEducationCredit(Expression<Func<string>> idOrRecordNumber, Expression<Func<string>> bodytype, Expression<Func<string>> bodydescription, Expression<Func<double>> bodynumberOfCredits, Expression<Func<string>> bodydateEarned, Expression<Func<string>> bodyproviderName = null, Expression<Func<string>> bodystateName = null, Expression<Func<string>> bodyreference = null, Expression<Func<bool>> bodyisSelfReported = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/EducationCredits", ExpressionConverter.ConvertWithUrlEncoding(idOrRecordNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["numberOfCredits"] = ExpressionConverter.ConvertO(bodynumberOfCredits);
            bodypropCount++;
            body["dateEarned"] = ExpressionConverter.ConvertO(bodydateEarned);
            if (bodyproviderName != null)
            {
                body["providerName"] = ExpressionConverter.ConvertO(bodyproviderName);
                bodypropCount++;
            }

            if (bodystateName != null)
            {
                body["stateName"] = ExpressionConverter.ConvertO(bodystateName);
                bodypropCount++;
            }

            if (bodyreference != null)
            {
                body["reference"] = ExpressionConverter.ConvertO(bodyreference);
                bodypropCount++;
            }

            if (bodyisSelfReported != null)
            {
                body["isSelfReported"] = ExpressionConverter.ConvertO(bodyisSelfReported);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction IndividualAddNote(Expression<Func<string>> id, Expression<Func<string>> notecontent, Expression<Func<bool>> noteisAlert = null, Expression<Func<string>> notetitle = null, Expression<Func<string>> notefollowUpDate = null, Expression<Func<string>> notecategory = null, Expression<Func<bool>> noteisInternal = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Notes", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var note = new JObject();
            var notepropCount = 0;
            if (noteisAlert != null)
            {
                note["isAlert"] = ExpressionConverter.ConvertO(noteisAlert);
                notepropCount++;
            }

            if (notetitle != null)
            {
                note["title"] = ExpressionConverter.ConvertO(notetitle);
                notepropCount++;
            }

            if (notefollowUpDate != null)
            {
                note["followUpDate"] = ExpressionConverter.ConvertO(notefollowUpDate);
                notepropCount++;
            }

            notepropCount++;
            note["content"] = ExpressionConverter.ConvertO(notecontent);
            if (notecategory != null)
            {
                note["category"] = ExpressionConverter.ConvertO(notecategory);
                notepropCount++;
            }

            if (noteisInternal != null)
            {
                note["isInternal"] = ExpressionConverter.ConvertO(noteisInternal);
                notepropCount++;
            }

            if (notepropCount > 0)
            {
                callPayload.Body = note;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<IndividualsLookupByNameResponse> IndividualsLookupByName(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/Lookup/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["includeOrgAddresses"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<IndividualsLookupByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AddToCommitteeResponse> AddToCommittee(Expression<Func<string>> code, Expression<Func<string>> bodyrecordNumber, Expression<Func<string>> bodypositionCode, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyrepresentingOrganizationRecordNumber = null, Expression<Func<string>> bodyrepresentingOrganizationRelationshipName = null, Expression<Func<string>> bodynominatedByCustomerRecordNumber = null, Expression<Func<int>> bodycommitteeTerm = null, Expression<Func<int>> bodyrank = null)
        {
            var apiCallPath = String.Format("/api/v1/Committees/{0}/Members", ExpressionConverter.ConvertWithUrlEncoding(code, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["recordNumber"] = ExpressionConverter.ConvertO(bodyrecordNumber);
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            bodypropCount++;
            body["positionCode"] = ExpressionConverter.ConvertO(bodypositionCode);
            bodypropCount++;
            body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyrepresentingOrganizationRecordNumber != null)
            {
                body["representingOrganizationRecordNumber"] = ExpressionConverter.ConvertO(bodyrepresentingOrganizationRecordNumber);
                bodypropCount++;
            }

            if (bodyrepresentingOrganizationRelationshipName != null)
            {
                body["representingOrganizationRelationshipName"] = ExpressionConverter.ConvertO(bodyrepresentingOrganizationRelationshipName);
                bodypropCount++;
            }

            if (bodynominatedByCustomerRecordNumber != null)
            {
                body["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(bodynominatedByCustomerRecordNumber);
                bodypropCount++;
            }

            if (bodycommitteeTerm != null)
            {
                body["committeeTerm"] = ExpressionConverter.ConvertO(bodycommitteeTerm);
                bodypropCount++;
            }

            if (bodyrank != null)
            {
                body["rank"] = ExpressionConverter.ConvertO(bodyrank);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddToCommitteeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction UpdateCommitteeMember(Expression<Func<string>> code, Expression<Func<string>> memberRecordNumber, Expression<Func<string>> currentPositionCode, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodypositionCode = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyrepresentingOrganizationRecordNumber = null, Expression<Func<string>> bodyrepresentingOrganizationRelationshipName = null, Expression<Func<string>> bodynominatedByCustomerRecordNumber = null, Expression<Func<int>> bodycommitteeTerm = null, Expression<Func<int>> bodyrank = null)
        {
            var apiCallPath = String.Format("/api/v1/Committees/{0}/Members/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(code, 1), ExpressionConverter.ConvertWithUrlEncoding(memberRecordNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(currentPositionCode, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycode != null)
            {
                body["code"] = ExpressionConverter.ConvertO(bodycode);
                bodypropCount++;
            }

            if (bodypositionCode != null)
            {
                body["positionCode"] = ExpressionConverter.ConvertO(bodypositionCode);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyrepresentingOrganizationRecordNumber != null)
            {
                body["representingOrganizationRecordNumber"] = ExpressionConverter.ConvertO(bodyrepresentingOrganizationRecordNumber);
                bodypropCount++;
            }

            if (bodyrepresentingOrganizationRelationshipName != null)
            {
                body["representingOrganizationRelationshipName"] = ExpressionConverter.ConvertO(bodyrepresentingOrganizationRelationshipName);
                bodypropCount++;
            }

            if (bodynominatedByCustomerRecordNumber != null)
            {
                body["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(bodynominatedByCustomerRecordNumber);
                bodypropCount++;
            }

            if (bodycommitteeTerm != null)
            {
                body["committeeTerm"] = ExpressionConverter.ConvertO(bodycommitteeTerm);
                bodypropCount++;
            }

            if (bodyrank != null)
            {
                body["rank"] = ExpressionConverter.ConvertO(bodyrank);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData> AddOrganization(Expression<Func<string>> bodyname, Expression<Func<string>> bodybranchName = null, Expression<Func<string>> bodywebsite = null)
        {
            var apiCallPath = "/api/v1/Organizations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            body["showInDirectory"] = false;
            bodypropCount++;
            if (bodybranchName != null)
            {
                body["branchName"] = ExpressionConverter.ConvertO(bodybranchName);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OrganizationData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData> UpdateOrganization(Expression<Func<string>> id, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyshowInDirectory = null, Expression<Func<string>> bodybranchName = null, Expression<Func<string>> bodywebsite = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyshowInDirectory != null)
            {
                body["showInDirectory"] = ExpressionConverter.ConvertO(bodyshowInDirectory);
                bodypropCount++;
            }

            if (bodybranchName != null)
            {
                body["branchName"] = ExpressionConverter.ConvertO(bodybranchName);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OrganizationData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationData> OrganizationGetProfile(Expression<Func<string>> idOrRecordnumber)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/Profile/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(idOrRecordnumber, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeDescription"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<OrganizationData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction OrganizationAddNote(Expression<Func<string>> id, Expression<Func<string>> notecontent, Expression<Func<bool>> noteisAlert = null, Expression<Func<string>> notetitle = null, Expression<Func<string>> notefollowUpDate = null, Expression<Func<string>> notecategory = null, Expression<Func<bool>> noteisInternal = null)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/{0}/Notes", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var note = new JObject();
            var notepropCount = 0;
            if (noteisAlert != null)
            {
                note["isAlert"] = ExpressionConverter.ConvertO(noteisAlert);
                notepropCount++;
            }

            if (notetitle != null)
            {
                note["title"] = ExpressionConverter.ConvertO(notetitle);
                notepropCount++;
            }

            if (notefollowUpDate != null)
            {
                note["followUpDate"] = ExpressionConverter.ConvertO(notefollowUpDate);
                notepropCount++;
            }

            notepropCount++;
            note["content"] = ExpressionConverter.ConvertO(notecontent);
            if (notecategory != null)
            {
                note["category"] = ExpressionConverter.ConvertO(notecategory);
                notepropCount++;
            }

            if (noteisInternal != null)
            {
                note["isInternal"] = ExpressionConverter.ConvertO(noteisInternal);
                notepropCount++;
            }

            if (notepropCount > 0)
            {
                callPayload.Body = note;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<OrganizationLookupByNameResponse> OrganizationLookupByName(Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/api/v1/Organizations/Lookup/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["includeAddresses"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<OrganizationLookupByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetAllCommitteesResponse> GetAllCommittees(Expression<Func<int>> pageNumber, Expression<Func<string>> code = null, Expression<Func<string>> name = null, Expression<Func<int>> term = null, Expression<Func<bool>> activeOnly = null)
        {
            var apiCallPath = String.Format("/api/v1/Committees/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (code != null)
                callPayload.Queries["Code"] = ExpressionConverter.Convert(code);
            if (name != null)
                callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
            if (term != null)
                callPayload.Queries["Term"] = ExpressionConverter.Convert(term);
            if (activeOnly != null)
                callPayload.Queries["activeOnly"] = ExpressionConverter.Convert(activeOnly);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetAllCommitteesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetPositionsByCommitteeResponse> GetPositionsByCommittee(Expression<Func<string>> code)
        {
            var apiCallPath = String.Format("/api/v1/Committees/{0}/Positions", ExpressionConverter.ConvertWithUrlEncoding(code, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetPositionsByCommitteeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetSubCommitteesResponse> GetSubCommittees(Expression<Func<string>> code, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Committees/{0}/subcommittees/{1}", ExpressionConverter.ConvertWithUrlEncoding(code, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetSubCommitteesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<GetIndividualsActiveSubscriptionsResponse> GetIndividualsActiveSubscriptions(Expression<Func<string>> iD, Expression<Func<int>> pageNumber)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}/Subscriptions/All/{1}", ExpressionConverter.ConvertWithUrlEncoding(iD, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetIndividualsActiveSubscriptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<ListAllIndividualsResponse> ListAllIndividuals(Expression<Func<int>> pageNumber, Expression<Func<string>> name = null, Expression<Func<bool>> includeDetails = null, Expression<Func<string>> oldID = null)
        {
            var apiCallPath = String.Format("/api/v1/Individuals/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["includeDetails"] = Convert.ToString(true);
            if (includeDetails != null)
                callPayload.Queries["includeDetails"] = ExpressionConverter.Convert(includeDetails);
            if (oldID != null)
                callPayload.Queries["oldID"] = ExpressionConverter.Convert(oldID);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ListAllIndividualsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<FindCustomerPhoneResponse> FindCustomerPhone(Expression<Func<string>> phoneNumber)
        {
            var apiCallPath = String.Format("/api/v1/Customers/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["phoneNumber"] = ExpressionConverter.Convert(phoneNumber);
            callPayload.Queries["includeAddress"] = Convert.ToString(true);
            callPayload.Queries["includePhone"] = Convert.ToString(true);
            callPayload.Queries["includeEmail"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<FindCustomerPhoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction MarkRegistrantAttended(Expression<Func<string>> recordNumber, Expression<Func<bodyInputItem2[]>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/Events/Registrants/{0}/Attended", ExpressionConverter.ConvertWithUrlEncoding(recordNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AwardsAddAwardNomination(Expression<Func<string>> id, Expression<Func<string>> awardNominationDatanomineeRecordNumber, Expression<Func<string>> awardNominationDatanominatedByCustomerRecordNumber, Expression<Func<string>> awardNominationDatanominationDate, Expression<Func<string>> awardNominationDataawardedDate = null, Expression<Func<awardNominationDatastatusInput>> awardNominationDatastatus = null, Expression<Func<string>> awardNominationDatadescription = null)
        {
            var apiCallPath = String.Format("/api/v1/Awards/{0}/Nominations", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var awardNominationData = new JObject();
            var awardNominationDatapropCount = 0;
            awardNominationDatapropCount++;
            awardNominationData["nomineeRecordNumber"] = ExpressionConverter.ConvertO(awardNominationDatanomineeRecordNumber);
            awardNominationDatapropCount++;
            awardNominationData["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(awardNominationDatanominatedByCustomerRecordNumber);
            awardNominationDatapropCount++;
            awardNominationData["nominationDate"] = ExpressionConverter.ConvertO(awardNominationDatanominationDate);
            if (awardNominationDataawardedDate != null)
            {
                awardNominationData["awardedDate"] = ExpressionConverter.ConvertO(awardNominationDataawardedDate);
                awardNominationDatapropCount++;
            }

            if (awardNominationDatastatus != null)
            {
                awardNominationData["status"] = ExpressionConverter.ConvertO(awardNominationDatastatus);
                awardNominationDatapropCount++;
            }

            if (awardNominationDatadescription != null)
            {
                awardNominationData["description"] = ExpressionConverter.ConvertO(awardNominationDatadescription);
                awardNominationDatapropCount++;
            }

            if (awardNominationDatapropCount > 0)
            {
                callPayload.Body = awardNominationData;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IWorkflowAction AwardsUpdateAwardNomination(Expression<Func<string>> id, Expression<Func<string>> nomineeRecordNumber, Expression<Func<string>> awardNominationDatanominatedByCustomerRecordNumber, Expression<Func<string>> awardNominationDatanominationDate, Expression<Func<string>> awardNominationDataawardedDate = null, Expression<Func<awardNominationDatastatusInput>> awardNominationDatastatus = null, Expression<Func<string>> awardNominationDatadescription = null)
        {
            var apiCallPath = String.Format("/api/v1/Awards/{0}/Nominations/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(nomineeRecordNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var awardNominationData = new JObject();
            var awardNominationDatapropCount = 0;
            awardNominationDatapropCount++;
            awardNominationData["nominatedByCustomerRecordNumber"] = ExpressionConverter.ConvertO(awardNominationDatanominatedByCustomerRecordNumber);
            awardNominationDatapropCount++;
            awardNominationData["nominationDate"] = ExpressionConverter.ConvertO(awardNominationDatanominationDate);
            if (awardNominationDataawardedDate != null)
            {
                awardNominationData["awardedDate"] = ExpressionConverter.ConvertO(awardNominationDataawardedDate);
                awardNominationDatapropCount++;
            }

            if (awardNominationDatastatus != null)
            {
                awardNominationData["status"] = ExpressionConverter.ConvertO(awardNominationDatastatus);
                awardNominationDatapropCount++;
            }

            if (awardNominationDatadescription != null)
            {
                awardNominationData["description"] = ExpressionConverter.ConvertO(awardNominationDatadescription);
                awardNominationDatapropCount++;
            }

            if (awardNominationDatapropCount > 0)
            {
                callPayload.Body = awardNominationData;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AwardsGetIndividualAwardRecipientsResponse> AwardsGetIndividualAwardRecipients(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v1/Awards/{0}/Recipients/Individuals/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeDetails"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<AwardsGetIndividualAwardRecipientsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "impexium")]
        public IBodyWorkflowAction<AwardsGetOrganizationAwardRecipientsResponse> AwardsGetOrganizationAwardRecipients(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/v1/Awards/{0}/Recipients/Organizations/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(pageNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeDetails"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<AwardsGetOrganizationAwardRecipientsResponse>(callPayload);
        }
    }

    public class ImpexiumTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenIndividualCreated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenIndividualDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenIndividualRequestForgotten(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenProductPurchased(Expression<Func<string[]>> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
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
            body["filters"] = ExpressionConverter.ConvertO(bodyfilters);
            body["secret"] = "Impexium";
            bodypropCount++;
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCommitteeMemberUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenPurchaseCancelled(Expression<Func<string[]>> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
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
            body["filters"] = ExpressionConverter.ConvertO(bodyfilters);
            body["secret"] = "Impexium";
            bodypropCount++;
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenRequestUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenEmailUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerCustomFieldValueUpdated(Expression<Func<string[]>> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
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
            body["filters"] = ExpressionConverter.ConvertO(bodyfilters);
            body["secret"] = "Impexium";
            bodypropCount++;
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerIsMerged(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerRelationshipUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerPhoneUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenCustomerAddressUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenEventRegistrationSubstituted(Expression<Func<string[]>> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
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
            body["filters"] = ExpressionConverter.ConvertO(bodyfilters);
            body["secret"] = "Impexium";
            bodypropCount++;
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenPurchasePaid(Expression<Func<string[]>> bodyfilters, string triggerName = null, FlowRecurrence recurrence = null)
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
            body["filters"] = ExpressionConverter.ConvertO(bodyfilters);
            body["secret"] = "Impexium";
            bodypropCount++;
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenMembershipTerminated(string triggerName = null, FlowRecurrence recurrence = null)
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
            body["callBackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Added by Impexium Connector";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

    public class ListCompletedUserTasksByUserIDOrEmailResponse
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

    public class ListPendingUserTasksByUserIDOrEmailResponse
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

    public class FindIndividualIDOrEmailResponse
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