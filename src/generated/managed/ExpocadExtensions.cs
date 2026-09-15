//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expocad
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExpocadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth> BoothsGet(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<Booth>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<deletedFilterInput>> deletedFilter = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/all", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (deletedFilter != null)
                callPayload.Queries["deletedFilter"] = CSharpExpressionConverter.Convert(deletedFilter);
            return new ApiConnectionAction<Booth[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllAvailableBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/all/available", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<Booth[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllRentedBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/all/rented", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<Booth[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> exhibitorId, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlan = null, Expression<Func<string>> status = null, Expression<Func<string>> comment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/rent", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["exhibitorId"] = CSharpExpressionConverter.ConvertO(exhibitorId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (ratePlan != null)
                callPayload.Queries["ratePlan"] = CSharpExpressionConverter.ConvertO(ratePlan);
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.ConvertO(status);
            if (comment != null)
                callPayload.Queries["comment"] = CSharpExpressionConverter.ConvertO(comment);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUnRentBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/unrent", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> exhibitorName = null, Expression<Func<string>> comment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/hold", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (exhibitorId != null)
                callPayload.Queries["exhibitorId"] = CSharpExpressionConverter.ConvertO(exhibitorId);
            if (exhibitorName != null)
                callPayload.Queries["exhibitorName"] = CSharpExpressionConverter.ConvertO(exhibitorName);
            if (comment != null)
                callPayload.Queries["comment"] = CSharpExpressionConverter.ConvertO(comment);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUnHoldBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/unhold", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentToHold(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/rentToHold", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldToRent(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlan = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/holdToRent", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (ratePlan != null)
                callPayload.Queries["ratePlan"] = CSharpExpressionConverter.ConvertO(ratePlan);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsCombineBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<int>> boundary, Expression<Func<string[]>> boothNumbers = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/combine", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            callPayload.Queries["boundary"] = CSharpExpressionConverter.ConvertO(boundary);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(boothNumbers);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUncombineBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/uncombine", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsDeleteBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string[]>> boothNumbers = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/delete", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(boothNumbers);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUndeleteBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string[]>> boothNumbers = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/undelete", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(boothNumbers);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsChangeBoothNumber(Expression<Func<string>> clientName, Expression<Func<string>> oldNumber, Expression<Func<string>> newNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/changenumber", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["oldNumber"] = CSharpExpressionConverter.ConvertO(oldNumber);
            callPayload.Queries["newNumber"] = CSharpExpressionConverter.ConvertO(newNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsSetBoothClass(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/classes/apply", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = CSharpExpressionConverter.ConvertO(classId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsClearBoothClass(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/classes/remove", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = CSharpExpressionConverter.ConvertO(classId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsSetBoothDisplayName(Expression<Func<string>> clientName, Expression<Func<string>> text, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/displayNameOverride/set", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["text"] = CSharpExpressionConverter.ConvertO(text);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsClearBoothDisplayName(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/displayNameOverride/reset", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsAddChildExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> childExhibitorId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/childExhibitor/add", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["childExhibitorId"] = CSharpExpressionConverter.ConvertO(childExhibitorId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRemoveChildExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> childExhibitorId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/booths/childExhibitor/remove", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["childExhibitorId"] = CSharpExpressionConverter.ConvertO(childExhibitorId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesGet(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/classes", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = CSharpExpressionConverter.ConvertO(classId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<BoothClass>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass[]> ClassesGetAllBoothClasses(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/classes/all", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<BoothClass[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesCreate(Expression<Func<string>> clientName, Expression<Func<string>> boothClassid, Expression<Func<int>> boothClasskeepWhenCombined, Expression<Func<int>> boothClasscountAsInventory, Expression<Func<string>> databaseName, Expression<Func<string>> boothClassname = null, Expression<Func<string>> boothClassdescription = null, Expression<Func<string>> boothClassprioritity = null, Expression<Func<int>> boothClasscolor = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/classes/add", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            var boothClass = new JObject();
            var boothClasspropCount = 0;
            boothClasspropCount++;
            boothClass["Id"] = CSharpExpressionConverter.ConvertToken(boothClassid);
            if (boothClassname != null)
            {
                boothClass["Name"] = CSharpExpressionConverter.ConvertToken(boothClassname);
                boothClasspropCount++;
            }

            if (boothClassdescription != null)
            {
                boothClass["Description"] = CSharpExpressionConverter.ConvertToken(boothClassdescription);
                boothClasspropCount++;
            }

            boothClasspropCount++;
            boothClass["KeepWhenCombined"] = CSharpExpressionConverter.ConvertToken(boothClasskeepWhenCombined);
            boothClasspropCount++;
            boothClass["CountAsInventory"] = CSharpExpressionConverter.ConvertToken(boothClasscountAsInventory);
            if (boothClassprioritity != null)
            {
                boothClass["Prioritity"] = CSharpExpressionConverter.ConvertToken(boothClassprioritity);
                boothClasspropCount++;
            }

            if (boothClasscolor != null)
            {
                boothClass["Color"] = CSharpExpressionConverter.ConvertToken(boothClasscolor);
                boothClasspropCount++;
            }

            if (boothClasspropCount > 0)
            {
                callPayload.Body = boothClass;
            }

            return new ApiConnectionAction<BoothClass>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesUpdate(Expression<Func<string>> clientName, Expression<Func<string>> boothClassid, Expression<Func<int>> boothClasskeepWhenCombined, Expression<Func<int>> boothClasscountAsInventory, Expression<Func<string>> classId, Expression<Func<string>> databaseName, Expression<Func<string>> boothClassname = null, Expression<Func<string>> boothClassdescription = null, Expression<Func<string>> boothClassprioritity = null, Expression<Func<int>> boothClasscolor = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/classes/update", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = CSharpExpressionConverter.ConvertO(classId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            var boothClass = new JObject();
            var boothClasspropCount = 0;
            boothClasspropCount++;
            boothClass["Id"] = CSharpExpressionConverter.ConvertToken(boothClassid);
            if (boothClassname != null)
            {
                boothClass["Name"] = CSharpExpressionConverter.ConvertToken(boothClassname);
                boothClasspropCount++;
            }

            if (boothClassdescription != null)
            {
                boothClass["Description"] = CSharpExpressionConverter.ConvertToken(boothClassdescription);
                boothClasspropCount++;
            }

            boothClasspropCount++;
            boothClass["KeepWhenCombined"] = CSharpExpressionConverter.ConvertToken(boothClasskeepWhenCombined);
            boothClasspropCount++;
            boothClass["CountAsInventory"] = CSharpExpressionConverter.ConvertToken(boothClasscountAsInventory);
            if (boothClassprioritity != null)
            {
                boothClass["Prioritity"] = CSharpExpressionConverter.ConvertToken(boothClassprioritity);
                boothClasspropCount++;
            }

            if (boothClasscolor != null)
            {
                boothClass["Color"] = CSharpExpressionConverter.ConvertToken(boothClasscolor);
                boothClasspropCount++;
            }

            if (boothClasspropCount > 0)
            {
                callPayload.Body = boothClass;
            }

            return new ApiConnectionAction<BoothClass>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> ClassesDelete(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/classes/delete", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = CSharpExpressionConverter.ConvertO(classId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpocadEvent[]> EventsGetAllEvents(Expression<Func<string>> clientName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/events", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExpocadEvent[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<EventStats> EventsGetEventStatistics(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/events/stats", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<EventStats>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpoEventInformation> EventsGetEventInformation(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/events/info", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<ExpoEventInformation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsGet(Expression<Func<string>> clientName, Expression<Func<string>> id, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<Exhibitor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor[]> ExhibitorsGetAllExhibitors(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/all", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<Exhibitor[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsAddExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> exhibitorexhibitorId, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitoraddress1 = null, Expression<Func<string>> exhibitoraddress2 = null, Expression<Func<string>> exhibitorcity = null, Expression<Func<string>> exhibitorcomments = null, Expression<Func<string>> exhibitorcomments2 = null, Expression<Func<string>> exhibitorcontact = null, Expression<Func<string>> exhibitorcountry = null, Expression<Func<string>> exhibitorcellPhone = null, Expression<Func<string>> exhibitordisplayOnDrawing = null, Expression<Func<string>> exhibitordoingBusinessAs = null, Expression<Func<string>> exhibitordoingBusinessAsDisplayOnDrawing = null, Expression<Func<string>> exhibitoremail = null, Expression<Func<string>> exhibitorexhibitorName = null, Expression<Func<string>> exhibitorexhibitorNameLine2 = null, Expression<Func<string>> exhibitorfax = null, Expression<Func<string>> exhibitorfield1 = null, Expression<Func<string>> exhibitorfield2 = null, Expression<Func<string>> exhibitorfield3 = null, Expression<Func<string>> exhibitorfield4 = null, Expression<Func<string>> exhibitorfield5 = null, Expression<Func<string>> exhibitorfield6 = null, Expression<Func<string>> exhibitorfield7 = null, Expression<Func<string>> exhibitorfield8 = null, Expression<Func<string>> exhibitorfield9 = null, Expression<Func<string>> exhibitornickName = null, Expression<Func<string>> exhibitorsalutation = null, Expression<Func<string>> exhibitortitle = null, Expression<Func<string>> exhibitorphone = null, Expression<Func<string>> exhibitorpostalCode = null, Expression<Func<string>> exhibitorprimaryGroup = null, Expression<Func<string>> exhibitorpriorityPoints = null, Expression<Func<string>> exhibitorproductDescription = null, Expression<Func<string>> exhibitorstate = null, Expression<Func<string>> exhibitorwebSite = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/add", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            var exhibitor = new JObject();
            var exhibitorpropCount = 0;
            if (exhibitoraddress1 != null)
            {
                exhibitor["Address1"] = CSharpExpressionConverter.ConvertToken(exhibitoraddress1);
                exhibitorpropCount++;
            }

            if (exhibitoraddress2 != null)
            {
                exhibitor["Address2"] = CSharpExpressionConverter.ConvertToken(exhibitoraddress2);
                exhibitorpropCount++;
            }

            if (exhibitorcity != null)
            {
                exhibitor["City"] = CSharpExpressionConverter.ConvertToken(exhibitorcity);
                exhibitorpropCount++;
            }

            if (exhibitorcomments != null)
            {
                exhibitor["Comments"] = CSharpExpressionConverter.ConvertToken(exhibitorcomments);
                exhibitorpropCount++;
            }

            if (exhibitorcomments2 != null)
            {
                exhibitor["Comments2"] = CSharpExpressionConverter.ConvertToken(exhibitorcomments2);
                exhibitorpropCount++;
            }

            if (exhibitorcontact != null)
            {
                exhibitor["Contact"] = CSharpExpressionConverter.ConvertToken(exhibitorcontact);
                exhibitorpropCount++;
            }

            if (exhibitorcountry != null)
            {
                exhibitor["Country"] = CSharpExpressionConverter.ConvertToken(exhibitorcountry);
                exhibitorpropCount++;
            }

            if (exhibitorcellPhone != null)
            {
                exhibitor["CellPhone"] = CSharpExpressionConverter.ConvertToken(exhibitorcellPhone);
                exhibitorpropCount++;
            }

            if (exhibitordisplayOnDrawing != null)
            {
                exhibitor["DisplayOnDrawing"] = CSharpExpressionConverter.ConvertToken(exhibitordisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitordoingBusinessAs != null)
            {
                exhibitor["DoingBusinessAs"] = CSharpExpressionConverter.ConvertToken(exhibitordoingBusinessAs);
                exhibitorpropCount++;
            }

            if (exhibitordoingBusinessAsDisplayOnDrawing != null)
            {
                exhibitor["DoingBusinessAsDisplayOnDrawing"] = CSharpExpressionConverter.ConvertToken(exhibitordoingBusinessAsDisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitoremail != null)
            {
                exhibitor["Email"] = CSharpExpressionConverter.ConvertToken(exhibitoremail);
                exhibitorpropCount++;
            }

            exhibitorpropCount++;
            exhibitor["ExhibitorId"] = CSharpExpressionConverter.ConvertToken(exhibitorexhibitorId);
            if (exhibitorexhibitorName != null)
            {
                exhibitor["ExhibitorName"] = CSharpExpressionConverter.ConvertToken(exhibitorexhibitorName);
                exhibitorpropCount++;
            }

            if (exhibitorexhibitorNameLine2 != null)
            {
                exhibitor["ExhibitorNameLine2"] = CSharpExpressionConverter.ConvertToken(exhibitorexhibitorNameLine2);
                exhibitorpropCount++;
            }

            if (exhibitorfax != null)
            {
                exhibitor["Fax"] = CSharpExpressionConverter.ConvertToken(exhibitorfax);
                exhibitorpropCount++;
            }

            if (exhibitorfield1 != null)
            {
                exhibitor["Field1"] = CSharpExpressionConverter.ConvertToken(exhibitorfield1);
                exhibitorpropCount++;
            }

            if (exhibitorfield2 != null)
            {
                exhibitor["Field2"] = CSharpExpressionConverter.ConvertToken(exhibitorfield2);
                exhibitorpropCount++;
            }

            if (exhibitorfield3 != null)
            {
                exhibitor["Field3"] = CSharpExpressionConverter.ConvertToken(exhibitorfield3);
                exhibitorpropCount++;
            }

            if (exhibitorfield4 != null)
            {
                exhibitor["Field4"] = CSharpExpressionConverter.ConvertToken(exhibitorfield4);
                exhibitorpropCount++;
            }

            if (exhibitorfield5 != null)
            {
                exhibitor["Field5"] = CSharpExpressionConverter.ConvertToken(exhibitorfield5);
                exhibitorpropCount++;
            }

            if (exhibitorfield6 != null)
            {
                exhibitor["Field6"] = CSharpExpressionConverter.ConvertToken(exhibitorfield6);
                exhibitorpropCount++;
            }

            if (exhibitorfield7 != null)
            {
                exhibitor["Field7"] = CSharpExpressionConverter.ConvertToken(exhibitorfield7);
                exhibitorpropCount++;
            }

            if (exhibitorfield8 != null)
            {
                exhibitor["Field8"] = CSharpExpressionConverter.ConvertToken(exhibitorfield8);
                exhibitorpropCount++;
            }

            if (exhibitorfield9 != null)
            {
                exhibitor["Field9"] = CSharpExpressionConverter.ConvertToken(exhibitorfield9);
                exhibitorpropCount++;
            }

            if (exhibitornickName != null)
            {
                exhibitor["NickName"] = CSharpExpressionConverter.ConvertToken(exhibitornickName);
                exhibitorpropCount++;
            }

            if (exhibitorsalutation != null)
            {
                exhibitor["Salutation"] = CSharpExpressionConverter.ConvertToken(exhibitorsalutation);
                exhibitorpropCount++;
            }

            if (exhibitortitle != null)
            {
                exhibitor["Title"] = CSharpExpressionConverter.ConvertToken(exhibitortitle);
                exhibitorpropCount++;
            }

            if (exhibitorphone != null)
            {
                exhibitor["Phone"] = CSharpExpressionConverter.ConvertToken(exhibitorphone);
                exhibitorpropCount++;
            }

            if (exhibitorpostalCode != null)
            {
                exhibitor["PostalCode"] = CSharpExpressionConverter.ConvertToken(exhibitorpostalCode);
                exhibitorpropCount++;
            }

            if (exhibitorprimaryGroup != null)
            {
                exhibitor["PrimaryGroup"] = CSharpExpressionConverter.ConvertToken(exhibitorprimaryGroup);
                exhibitorpropCount++;
            }

            if (exhibitorpriorityPoints != null)
            {
                exhibitor["PriorityPoints"] = CSharpExpressionConverter.ConvertToken(exhibitorpriorityPoints);
                exhibitorpropCount++;
            }

            if (exhibitorproductDescription != null)
            {
                exhibitor["ProductDescription"] = CSharpExpressionConverter.ConvertToken(exhibitorproductDescription);
                exhibitorpropCount++;
            }

            if (exhibitorstate != null)
            {
                exhibitor["State"] = CSharpExpressionConverter.ConvertToken(exhibitorstate);
                exhibitorpropCount++;
            }

            if (exhibitorwebSite != null)
            {
                exhibitor["WebSite"] = CSharpExpressionConverter.ConvertToken(exhibitorwebSite);
                exhibitorpropCount++;
            }

            if (exhibitorpropCount > 0)
            {
                callPayload.Body = exhibitor;
            }

            return new ApiConnectionAction<Exhibitor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsUpdateExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> exhibitorexhibitorId, Expression<Func<string>> id, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitoraddress1 = null, Expression<Func<string>> exhibitoraddress2 = null, Expression<Func<string>> exhibitorcity = null, Expression<Func<string>> exhibitorcomments = null, Expression<Func<string>> exhibitorcomments2 = null, Expression<Func<string>> exhibitorcontact = null, Expression<Func<string>> exhibitorcountry = null, Expression<Func<string>> exhibitorcellPhone = null, Expression<Func<string>> exhibitordisplayOnDrawing = null, Expression<Func<string>> exhibitordoingBusinessAs = null, Expression<Func<string>> exhibitordoingBusinessAsDisplayOnDrawing = null, Expression<Func<string>> exhibitoremail = null, Expression<Func<string>> exhibitorexhibitorName = null, Expression<Func<string>> exhibitorexhibitorNameLine2 = null, Expression<Func<string>> exhibitorfax = null, Expression<Func<string>> exhibitorfield1 = null, Expression<Func<string>> exhibitorfield2 = null, Expression<Func<string>> exhibitorfield3 = null, Expression<Func<string>> exhibitorfield4 = null, Expression<Func<string>> exhibitorfield5 = null, Expression<Func<string>> exhibitorfield6 = null, Expression<Func<string>> exhibitorfield7 = null, Expression<Func<string>> exhibitorfield8 = null, Expression<Func<string>> exhibitorfield9 = null, Expression<Func<string>> exhibitornickName = null, Expression<Func<string>> exhibitorsalutation = null, Expression<Func<string>> exhibitortitle = null, Expression<Func<string>> exhibitorphone = null, Expression<Func<string>> exhibitorpostalCode = null, Expression<Func<string>> exhibitorprimaryGroup = null, Expression<Func<string>> exhibitorpriorityPoints = null, Expression<Func<string>> exhibitorproductDescription = null, Expression<Func<string>> exhibitorstate = null, Expression<Func<string>> exhibitorwebSite = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/update", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            var exhibitor = new JObject();
            var exhibitorpropCount = 0;
            if (exhibitoraddress1 != null)
            {
                exhibitor["Address1"] = CSharpExpressionConverter.ConvertToken(exhibitoraddress1);
                exhibitorpropCount++;
            }

            if (exhibitoraddress2 != null)
            {
                exhibitor["Address2"] = CSharpExpressionConverter.ConvertToken(exhibitoraddress2);
                exhibitorpropCount++;
            }

            if (exhibitorcity != null)
            {
                exhibitor["City"] = CSharpExpressionConverter.ConvertToken(exhibitorcity);
                exhibitorpropCount++;
            }

            if (exhibitorcomments != null)
            {
                exhibitor["Comments"] = CSharpExpressionConverter.ConvertToken(exhibitorcomments);
                exhibitorpropCount++;
            }

            if (exhibitorcomments2 != null)
            {
                exhibitor["Comments2"] = CSharpExpressionConverter.ConvertToken(exhibitorcomments2);
                exhibitorpropCount++;
            }

            if (exhibitorcontact != null)
            {
                exhibitor["Contact"] = CSharpExpressionConverter.ConvertToken(exhibitorcontact);
                exhibitorpropCount++;
            }

            if (exhibitorcountry != null)
            {
                exhibitor["Country"] = CSharpExpressionConverter.ConvertToken(exhibitorcountry);
                exhibitorpropCount++;
            }

            if (exhibitorcellPhone != null)
            {
                exhibitor["CellPhone"] = CSharpExpressionConverter.ConvertToken(exhibitorcellPhone);
                exhibitorpropCount++;
            }

            if (exhibitordisplayOnDrawing != null)
            {
                exhibitor["DisplayOnDrawing"] = CSharpExpressionConverter.ConvertToken(exhibitordisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitordoingBusinessAs != null)
            {
                exhibitor["DoingBusinessAs"] = CSharpExpressionConverter.ConvertToken(exhibitordoingBusinessAs);
                exhibitorpropCount++;
            }

            if (exhibitordoingBusinessAsDisplayOnDrawing != null)
            {
                exhibitor["DoingBusinessAsDisplayOnDrawing"] = CSharpExpressionConverter.ConvertToken(exhibitordoingBusinessAsDisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitoremail != null)
            {
                exhibitor["Email"] = CSharpExpressionConverter.ConvertToken(exhibitoremail);
                exhibitorpropCount++;
            }

            exhibitorpropCount++;
            exhibitor["ExhibitorId"] = CSharpExpressionConverter.ConvertToken(exhibitorexhibitorId);
            if (exhibitorexhibitorName != null)
            {
                exhibitor["ExhibitorName"] = CSharpExpressionConverter.ConvertToken(exhibitorexhibitorName);
                exhibitorpropCount++;
            }

            if (exhibitorexhibitorNameLine2 != null)
            {
                exhibitor["ExhibitorNameLine2"] = CSharpExpressionConverter.ConvertToken(exhibitorexhibitorNameLine2);
                exhibitorpropCount++;
            }

            if (exhibitorfax != null)
            {
                exhibitor["Fax"] = CSharpExpressionConverter.ConvertToken(exhibitorfax);
                exhibitorpropCount++;
            }

            if (exhibitorfield1 != null)
            {
                exhibitor["Field1"] = CSharpExpressionConverter.ConvertToken(exhibitorfield1);
                exhibitorpropCount++;
            }

            if (exhibitorfield2 != null)
            {
                exhibitor["Field2"] = CSharpExpressionConverter.ConvertToken(exhibitorfield2);
                exhibitorpropCount++;
            }

            if (exhibitorfield3 != null)
            {
                exhibitor["Field3"] = CSharpExpressionConverter.ConvertToken(exhibitorfield3);
                exhibitorpropCount++;
            }

            if (exhibitorfield4 != null)
            {
                exhibitor["Field4"] = CSharpExpressionConverter.ConvertToken(exhibitorfield4);
                exhibitorpropCount++;
            }

            if (exhibitorfield5 != null)
            {
                exhibitor["Field5"] = CSharpExpressionConverter.ConvertToken(exhibitorfield5);
                exhibitorpropCount++;
            }

            if (exhibitorfield6 != null)
            {
                exhibitor["Field6"] = CSharpExpressionConverter.ConvertToken(exhibitorfield6);
                exhibitorpropCount++;
            }

            if (exhibitorfield7 != null)
            {
                exhibitor["Field7"] = CSharpExpressionConverter.ConvertToken(exhibitorfield7);
                exhibitorpropCount++;
            }

            if (exhibitorfield8 != null)
            {
                exhibitor["Field8"] = CSharpExpressionConverter.ConvertToken(exhibitorfield8);
                exhibitorpropCount++;
            }

            if (exhibitorfield9 != null)
            {
                exhibitor["Field9"] = CSharpExpressionConverter.ConvertToken(exhibitorfield9);
                exhibitorpropCount++;
            }

            if (exhibitornickName != null)
            {
                exhibitor["NickName"] = CSharpExpressionConverter.ConvertToken(exhibitornickName);
                exhibitorpropCount++;
            }

            if (exhibitorsalutation != null)
            {
                exhibitor["Salutation"] = CSharpExpressionConverter.ConvertToken(exhibitorsalutation);
                exhibitorpropCount++;
            }

            if (exhibitortitle != null)
            {
                exhibitor["Title"] = CSharpExpressionConverter.ConvertToken(exhibitortitle);
                exhibitorpropCount++;
            }

            if (exhibitorphone != null)
            {
                exhibitor["Phone"] = CSharpExpressionConverter.ConvertToken(exhibitorphone);
                exhibitorpropCount++;
            }

            if (exhibitorpostalCode != null)
            {
                exhibitor["PostalCode"] = CSharpExpressionConverter.ConvertToken(exhibitorpostalCode);
                exhibitorpropCount++;
            }

            if (exhibitorprimaryGroup != null)
            {
                exhibitor["PrimaryGroup"] = CSharpExpressionConverter.ConvertToken(exhibitorprimaryGroup);
                exhibitorpropCount++;
            }

            if (exhibitorpriorityPoints != null)
            {
                exhibitor["PriorityPoints"] = CSharpExpressionConverter.ConvertToken(exhibitorpriorityPoints);
                exhibitorpropCount++;
            }

            if (exhibitorproductDescription != null)
            {
                exhibitor["ProductDescription"] = CSharpExpressionConverter.ConvertToken(exhibitorproductDescription);
                exhibitorpropCount++;
            }

            if (exhibitorstate != null)
            {
                exhibitor["State"] = CSharpExpressionConverter.ConvertToken(exhibitorstate);
                exhibitorpropCount++;
            }

            if (exhibitorwebSite != null)
            {
                exhibitor["WebSite"] = CSharpExpressionConverter.ConvertToken(exhibitorwebSite);
                exhibitorpropCount++;
            }

            if (exhibitorpropCount > 0)
            {
                callPayload.Body = exhibitor;
            }

            return new ApiConnectionAction<Exhibitor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> ExhibitorsDeleteExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> id, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/exhibitors/delete", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Transaction[]> FinancialsGetAllTransactions(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> boothNumber = null, Expression<Func<string>> expocadUser = null, Expression<Func<string>> glCode = null, Expression<Func<reversedFilterInput>> reversedFilter = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/financials/transactions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (startDate != null)
                callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (exhibitorId != null)
                callPayload.Queries["exhibitorId"] = CSharpExpressionConverter.ConvertO(exhibitorId);
            if (boothNumber != null)
                callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            if (expocadUser != null)
                callPayload.Queries["expocadUser"] = CSharpExpressionConverter.ConvertO(expocadUser);
            if (glCode != null)
                callPayload.Queries["glCode"] = CSharpExpressionConverter.ConvertO(glCode);
            if (reversedFilter != null)
                callPayload.Queries["reversedFilter"] = CSharpExpressionConverter.Convert(reversedFilter);
            return new ApiConnectionAction<Transaction[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothFinancial> FinancialsGet(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/financials/booths", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = CSharpExpressionConverter.ConvertO(boothNumber);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<BoothFinancial>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice> FinancialsGetInvoice(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> invoiceNo = null, Expression<Func<string>> exhibitorId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/financials/invoices", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (invoiceNo != null)
                callPayload.Queries["invoiceNo"] = CSharpExpressionConverter.ConvertO(invoiceNo);
            if (exhibitorId != null)
                callPayload.Queries["exhibitorId"] = CSharpExpressionConverter.ConvertO(exhibitorId);
            return new ApiConnectionAction<Invoice>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice[]> FinancialsGetAllInvoices(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/financials/invoices/all", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<Invoice[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<MasterRequestItem[]> FinancialsGetRequestItemList(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> glCode = null, Expression<Func<string>> transactionCode = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/financials/requestitemlist", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (glCode != null)
                callPayload.Queries["glCode"] = CSharpExpressionConverter.ConvertO(glCode);
            if (transactionCode != null)
                callPayload.Queries["transactionCode"] = CSharpExpressionConverter.ConvertO(transactionCode);
            return new ApiConnectionAction<MasterRequestItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoiceRequestItem[]> FinancialsGetAssignedRequestItems(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> booth = null, Expression<Func<string>> glCode = null, Expression<Func<string>> transactionCode = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/financials/requestitems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (exhibitorId != null)
                callPayload.Queries["exhibitorId"] = CSharpExpressionConverter.ConvertO(exhibitorId);
            if (invoiceNumber != null)
                callPayload.Queries["invoiceNumber"] = CSharpExpressionConverter.ConvertO(invoiceNumber);
            if (startDate != null)
                callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (booth != null)
                callPayload.Queries["booth"] = CSharpExpressionConverter.ConvertO(booth);
            if (glCode != null)
                callPayload.Queries["glCode"] = CSharpExpressionConverter.ConvertO(glCode);
            if (transactionCode != null)
                callPayload.Queries["transactionCode"] = CSharpExpressionConverter.ConvertO(transactionCode);
            return new ApiConnectionAction<InvoiceRequestItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<PaymentTypeItem[]> FinancialsGetPaymentTypeList(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/financials/paymenttypelist", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<PaymentTypeItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoicePayment[]> FinancialsGetPayments(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> depositId = null, Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> paymentTypeCategory = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/financials/payments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            if (exhibitorId != null)
                callPayload.Queries["ExhibitorId"] = CSharpExpressionConverter.ConvertO(exhibitorId);
            if (depositId != null)
                callPayload.Queries["DepositId"] = CSharpExpressionConverter.ConvertO(depositId);
            if (invoiceNumber != null)
                callPayload.Queries["InvoiceNumber"] = CSharpExpressionConverter.ConvertO(invoiceNumber);
            if (startDate != null)
                callPayload.Queries["StartDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["EndDate"] = CSharpExpressionConverter.ConvertO(endDate);
            if (paymentTypeCategory != null)
                callPayload.Queries["PaymentTypeCategory"] = CSharpExpressionConverter.ConvertO(paymentTypeCategory);
            return new ApiConnectionAction<InvoicePayment[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Pavilion[]> PavilionsGetAllPavilions(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/pavilions/all", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<Pavilion[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansGetDefaultRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/default", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<RatePlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> RatePlansSetDefaultRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> name)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/default", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan[]> RatePlansGetAllRatePlans(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/all", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<RatePlan[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansAddRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlanname, Expression<Func<string>> ratePlanshortCode, Expression<Func<double>> ratePlangrossRate, Expression<Func<double>> ratePlanfixedDiscountRate, Expression<Func<double>> ratePlanpercentDiscountRate, Expression<Func<bool>> ratePlanisFixed)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/rateplans/add", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            var ratePlan = new JObject();
            var ratePlanpropCount = 0;
            ratePlanpropCount++;
            ratePlan["Name"] = CSharpExpressionConverter.ConvertToken(ratePlanname);
            ratePlanpropCount++;
            ratePlan["ShortCode"] = CSharpExpressionConverter.ConvertToken(ratePlanshortCode);
            ratePlanpropCount++;
            ratePlan["GrossRate"] = CSharpExpressionConverter.ConvertToken(ratePlangrossRate);
            ratePlanpropCount++;
            ratePlan["FixedDiscountRate"] = CSharpExpressionConverter.ConvertToken(ratePlanfixedDiscountRate);
            ratePlanpropCount++;
            ratePlan["PercentDiscountRate"] = CSharpExpressionConverter.ConvertToken(ratePlanpercentDiscountRate);
            ratePlanpropCount++;
            ratePlan["IsFixed"] = CSharpExpressionConverter.ConvertToken(ratePlanisFixed);
            if (ratePlanpropCount > 0)
            {
                callPayload.Body = ratePlan;
            }

            return new ApiConnectionAction<RatePlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ShowInShow[]> ShowInShowsGetAllShowinShows(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}/showinshows/all", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = CSharpExpressionConverter.ConvertO(databaseName);
            return new ApiConnectionAction<ShowInShow[]>(callPayload);
        }
    }

    public class ExpocadTriggers([ConnectionName] string connectionId)
    {
    }

    public class Booth
    {
        public string ExhibitorId { get; set; }
        public string BoothNumber { get; set; }
        public string Dimensions { get; set; }
        public string DisplayNameOverride { get; set; }
        public string XSize { get; set; }
        public string YSize { get; set; }
        public string Area { get; set; }
        public double NumericArea { get; set; }
        public string Status { get; set; }
        public string[] BoothClasses { get; set; }
        public string[] ChildExhibitors { get; set; }
        public string Pavilion { get; set; }
        public string ShowInShow { get; set; }
        public string BoothType { get; set; }
        public string UnitType { get; set; }
        public string HoldExhibitorId { get; set; }
        public string HoldExhibitorName { get; set; }
        public string HoldComment { get; set; }
        public int OpenCorners { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsOnHold { get; set; }
        public bool IsRented { get; set; }
    }

    public enum deletedFilterInput
    {
        IncludeAll,
        OnlyNonDeleted,
        OnlyDeleted
    }

    public class BoothClass
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int KeepWhenCombined { get; set; }
        public int CountAsInventory { get; set; }
        public string Prioritity { get; set; }
        public int Color { get; set; }
    }

    public class ExpocadEvent
    {
        public string EventName { get; set; }
        public string DatabaseName { get; set; }
    }

    public class EventStats
    {
        public string TotalBooths { get; set; }
        public string RentedBooths { get; set; }
        public string AvailableBooths { get; set; }
        public string HoldBooths { get; set; }
        public string NonInventoryBooths { get; set; }
        public string TotalExhibitors { get; set; }
        public string TotalBoothArea { get; set; }
        public string RentedBoothArea { get; set; }
        public string AvailableBoothArea { get; set; }
        public string HoldBoothArea { get; set; }
        public string NonInventoryBoothArea { get; set; }
        public string RentedBoothPercentage { get; set; }
        public string AvailableBoothPercentage { get; set; }
        public string HoldBoothPercentage { get; set; }
        public string NetValueSold { get; set; }
    }

    public class ExpoEventInformation
    {
        public string EventName { get; set; }
        public string DatabaseName { get; set; }
        public string EventExhibitorFile { get; set; }
        public string EventDescription { get; set; }
        public string ShowTitle { get; set; }
        public string ShowDates { get; set; }
        public string ContractorName { get; set; }
        public string ContractorPhone { get; set; }
        public string EventLocation { get; set; }
        public string EventLocation2 { get; set; }
    }

    public class Exhibitor
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string Comments2 { get; set; }
        public string Contact { get; set; }
        public string Country { get; set; }
        public string CellPhone { get; set; }
        public string DisplayOnDrawing { get; set; }
        public string DoingBusinessAs { get; set; }
        public string DoingBusinessAsDisplayOnDrawing { get; set; }
        public string Email { get; set; }
        public string ExhibitorId { get; set; }
        public string ExhibitorName { get; set; }
        public string ExhibitorNameLine2 { get; set; }
        public string Fax { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public string Field9 { get; set; }
        public string NickName { get; set; }
        public string Salutation { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string PrimaryGroup { get; set; }
        public string PriorityPoints { get; set; }
        public string ProductDescription { get; set; }
        public string State { get; set; }
        public string WebSite { get; set; }
    }

    public class Transaction
    {
        public string Amount { get; set; }
        public string BoothNumber { get; set; }
        public string Comment { get; set; }
        public string TransactionDateGenerated { get; set; }
        public string ExhibitorId { get; set; }
        public string ExpocadUser { get; set; }
        public string GlCode { get; set; }
        public string InvoiceNumber { get; set; }
        public bool IsReversed { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionType { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceTerms { get; set; }
        public string InvoiceDueDate { get; set; }
        public string InvoiceDateGenerated { get; set; }
        public string InvoiceTotalPaid { get; set; }
        public string InvoiceTotalDue { get; set; }
        public bool InvoiceModified { get; set; }
        public string DepositSlipId { get; set; }
        public string PaymentType { get; set; }
        public string PaymentTypeCategory { get; set; }
        public string PaymentCardNumber { get; set; }
        public string PaymentCardExpirationDate { get; set; }
        public string PaymentAprNumber { get; set; }
        public string PaymentNote { get; set; }
    }

    public enum reversedFilterInput
    {
        All,
        Reversed,
        NonReversed
    }

    public class BoothFinancial
    {
        public string BoothNumber { get; set; }
        public string ExhibitorId { get; set; }
        public string InvoiceNo { get; set; }
        public double BillableArea { get; set; }
        public double Discount { get; set; }
        public double DiscountValue { get; set; }
        public double GrossRate { get; set; }
        public double NetRate { get; set; }
        public double TotalExtras { get; set; }
        public double TotalDue { get; set; }
        public string CommitDate { get; set; }
        public string ReceivedDate { get; set; }
        public string DepositDate { get; set; }
        public string Comment { get; set; }
        public string RatePlan { get; set; }
        public string BoothStatus { get; set; }
    }

    public class Invoice
    {
        public string InvoiceNo { get; set; }
        public string CustomerId { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDue { get; set; }
        public string DueDate { get; set; }
        public double BalanceDue { get; set; }
        public double LastPaidAmount { get; set; }
        public string LastPaidDate { get; set; }
    }

    public class MasterRequestItem
    {
        public string GlCode { get; set; }
        public string TransactionCode { get; set; }
        public string Description { get; set; }
        public double UnitCost { get; set; }
        public int TotalNumberAvailable { get; set; }
        public string AddOnRent { get; set; }
        public string IsTaxable { get; set; }
        public string DebitCode { get; set; }
        public string CreditCode { get; set; }
        public string ItemType { get; set; }
    }

    public class InvoiceRequestItem
    {
        public string ExhibitorId { get; set; }
        public string InvoiceNumber { get; set; }
        public string BoothNumber { get; set; }
        public string GlCode { get; set; }
        public string TransactionCode { get; set; }
        public string Description { get; set; }
        public double UnitCost { get; set; }
        public int Quantity { get; set; }
        public double LineTotal { get; set; }
        public string Date { get; set; }
    }

    public class PaymentTypeItem
    {
        public string PaymentType { get; set; }
        public string PaymentTypeCategory { get; set; }
    }

    public class InvoicePayment
    {
        public string ExhibitorId { get; set; }
        public string DepositId { get; set; }
        public string InvoiceNumber { get; set; }
        public string PaymentType { get; set; }
        public string PaymentTypeCategory { get; set; }
        public double Amount { get; set; }
        public string PaymentDate { get; set; }
        public string User { get; set; }
        public string TransactionId { get; set; }
        public string CCLast4 { get; set; }
        public string CCExpDate { get; set; }
        public string CheckAprNo { get; set; }
        public int PayRecId { get; set; }
        public string Note { get; set; }
    }

    public class Pavilion
    {
        public string Name { get; set; }
    }

    public class RatePlan
    {
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public double GrossRate { get; set; }
        public double FixedDiscountRate { get; set; }
        public double PercentDiscountRate { get; set; }
        public bool IsFixed { get; set; }
    }

    public class ShowInShow
    {
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Expocad;

    public partial class WorkflowManagedActions
    {
        public ExpocadActions Expocad(string connectionId) => new ExpocadActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExpocadTriggers Expocad(string connectionId) => new ExpocadTriggers(connectionId);
    }
}