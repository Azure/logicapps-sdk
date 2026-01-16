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
            var apiCallPath = String.Format("/{0}/booths", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Booth>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<deletedFilterInput>> deletedFilter = null)
        {
            var apiCallPath = String.Format("/{0}/booths/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (deletedFilter != null)
                callPayload.Queries["deletedFilter"] = ExpressionConverter.Convert(deletedFilter);
            return new ApiConnectionAction<Booth[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllAvailableBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/all/available", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Booth[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllRentedBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/all/rented", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Booth[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> exhibitorId, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlan = null, Expression<Func<string>> status = null, Expression<Func<string>> comment = null)
        {
            var apiCallPath = String.Format("/{0}/booths/rent", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(exhibitorId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (ratePlan != null)
                callPayload.Queries["ratePlan"] = ExpressionConverter.Convert(ratePlan);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (comment != null)
                callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUnRentBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/unrent", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> exhibitorName = null, Expression<Func<string>> comment = null)
        {
            var apiCallPath = String.Format("/{0}/booths/hold", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (exhibitorId != null)
                callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(exhibitorId);
            if (exhibitorName != null)
                callPayload.Queries["exhibitorName"] = ExpressionConverter.Convert(exhibitorName);
            if (comment != null)
                callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUnHoldBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/unhold", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentToHold(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/rentToHold", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldToRent(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlan = null)
        {
            var apiCallPath = String.Format("/{0}/booths/holdToRent", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (ratePlan != null)
                callPayload.Queries["ratePlan"] = ExpressionConverter.Convert(ratePlan);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsCombineBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<int>> boundary, Expression<Func<string[]>> boothNumbers = null)
        {
            var apiCallPath = String.Format("/{0}/booths/combine", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            callPayload.Queries["boundary"] = ExpressionConverter.Convert(boundary);
            callPayload.Body = ExpressionConverter.ConvertO(boothNumbers);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUncombineBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/uncombine", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsDeleteBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string[]>> boothNumbers = null)
        {
            var apiCallPath = String.Format("/{0}/booths/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            callPayload.Body = ExpressionConverter.ConvertO(boothNumbers);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUndeleteBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string[]>> boothNumbers = null)
        {
            var apiCallPath = String.Format("/{0}/booths/undelete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            callPayload.Body = ExpressionConverter.ConvertO(boothNumbers);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsChangeBoothNumber(Expression<Func<string>> clientName, Expression<Func<string>> oldNumber, Expression<Func<string>> newNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/changenumber", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["oldNumber"] = ExpressionConverter.Convert(oldNumber);
            callPayload.Queries["newNumber"] = ExpressionConverter.Convert(newNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsSetBoothClass(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/classes/apply", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsClearBoothClass(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/classes/remove", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsSetBoothDisplayName(Expression<Func<string>> clientName, Expression<Func<string>> text, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/displayNameOverride/set", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsClearBoothDisplayName(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/displayNameOverride/reset", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsAddChildExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> childExhibitorId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/childExhibitor/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["childExhibitorId"] = ExpressionConverter.Convert(childExhibitorId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRemoveChildExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> childExhibitorId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/childExhibitor/remove", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["childExhibitorId"] = ExpressionConverter.Convert(childExhibitorId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesGet(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/classes", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<BoothClass>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass[]> ClassesGetAllBoothClasses(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/classes/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<BoothClass[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesCreate(Expression<Func<string>> clientName, Expression<Func<string>> boothClassId, Expression<Func<int>> boothClassKeepWhenCombined, Expression<Func<int>> boothClassCountAsInventory, Expression<Func<string>> databaseName, Expression<Func<string>> boothClassName = null, Expression<Func<string>> boothClassDescription = null, Expression<Func<string>> boothClassPrioritity = null, Expression<Func<int>> boothClassColor = null)
        {
            var apiCallPath = String.Format("/{0}/classes/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var boothClass = new JObject();
            var boothClasspropCount = 0;
            boothClasspropCount++;
            boothClass["Id"] = ExpressionConverter.ConvertO(boothClassId);
            if (boothClassName != null)
            {
                boothClass["Name"] = ExpressionConverter.ConvertO(boothClassName);
                boothClasspropCount++;
            }

            if (boothClassDescription != null)
            {
                boothClass["Description"] = ExpressionConverter.ConvertO(boothClassDescription);
                boothClasspropCount++;
            }

            boothClasspropCount++;
            boothClass["KeepWhenCombined"] = ExpressionConverter.ConvertO(boothClassKeepWhenCombined);
            boothClasspropCount++;
            boothClass["CountAsInventory"] = ExpressionConverter.ConvertO(boothClassCountAsInventory);
            if (boothClassPrioritity != null)
            {
                boothClass["Prioritity"] = ExpressionConverter.ConvertO(boothClassPrioritity);
                boothClasspropCount++;
            }

            if (boothClassColor != null)
            {
                boothClass["Color"] = ExpressionConverter.ConvertO(boothClassColor);
                boothClasspropCount++;
            }

            if (boothClasspropCount > 0)
            {
                callPayload.Body = boothClass;
            }

            return new ApiConnectionAction<BoothClass>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesUpdate(Expression<Func<string>> clientName, Expression<Func<string>> boothClassId, Expression<Func<int>> boothClassKeepWhenCombined, Expression<Func<int>> boothClassCountAsInventory, Expression<Func<string>> classId, Expression<Func<string>> databaseName, Expression<Func<string>> boothClassName = null, Expression<Func<string>> boothClassDescription = null, Expression<Func<string>> boothClassPrioritity = null, Expression<Func<int>> boothClassColor = null)
        {
            var apiCallPath = String.Format("/{0}/classes/update", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var boothClass = new JObject();
            var boothClasspropCount = 0;
            boothClasspropCount++;
            boothClass["Id"] = ExpressionConverter.ConvertO(boothClassId);
            if (boothClassName != null)
            {
                boothClass["Name"] = ExpressionConverter.ConvertO(boothClassName);
                boothClasspropCount++;
            }

            if (boothClassDescription != null)
            {
                boothClass["Description"] = ExpressionConverter.ConvertO(boothClassDescription);
                boothClasspropCount++;
            }

            boothClasspropCount++;
            boothClass["KeepWhenCombined"] = ExpressionConverter.ConvertO(boothClassKeepWhenCombined);
            boothClasspropCount++;
            boothClass["CountAsInventory"] = ExpressionConverter.ConvertO(boothClassCountAsInventory);
            if (boothClassPrioritity != null)
            {
                boothClass["Prioritity"] = ExpressionConverter.ConvertO(boothClassPrioritity);
                boothClasspropCount++;
            }

            if (boothClassColor != null)
            {
                boothClass["Color"] = ExpressionConverter.ConvertO(boothClassColor);
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
            var apiCallPath = String.Format("/{0}/classes/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpocadEvent[]> EventsGetAllEvents(Expression<Func<string>> clientName)
        {
            var apiCallPath = String.Format("/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExpocadEvent[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<EventStats> EventsGetEventStatistics(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/events/stats", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<EventStats>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpoEventInformation> EventsGetEventInformation(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/events/info", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<ExpoEventInformation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsGet(Expression<Func<string>> clientName, Expression<Func<string>> id, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/exhibitors", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Exhibitor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor[]> ExhibitorsGetAllExhibitors(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/exhibitors/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Exhibitor[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsAddExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> exhibitorExhibitorId, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorAddress1 = null, Expression<Func<string>> exhibitorAddress2 = null, Expression<Func<string>> exhibitorCity = null, Expression<Func<string>> exhibitorComments = null, Expression<Func<string>> exhibitorComments2 = null, Expression<Func<string>> exhibitorContact = null, Expression<Func<string>> exhibitorCountry = null, Expression<Func<string>> exhibitorCellPhone = null, Expression<Func<string>> exhibitorDisplayOnDrawing = null, Expression<Func<string>> exhibitorDoingBusinessAs = null, Expression<Func<string>> exhibitorDoingBusinessAsDisplayOnDrawing = null, Expression<Func<string>> exhibitorEmail = null, Expression<Func<string>> exhibitorExhibitorName = null, Expression<Func<string>> exhibitorExhibitorNameLine2 = null, Expression<Func<string>> exhibitorFax = null, Expression<Func<string>> exhibitorField1 = null, Expression<Func<string>> exhibitorField2 = null, Expression<Func<string>> exhibitorField3 = null, Expression<Func<string>> exhibitorField4 = null, Expression<Func<string>> exhibitorField5 = null, Expression<Func<string>> exhibitorField6 = null, Expression<Func<string>> exhibitorField7 = null, Expression<Func<string>> exhibitorField8 = null, Expression<Func<string>> exhibitorField9 = null, Expression<Func<string>> exhibitorNickName = null, Expression<Func<string>> exhibitorSalutation = null, Expression<Func<string>> exhibitorTitle = null, Expression<Func<string>> exhibitorPhone = null, Expression<Func<string>> exhibitorPostalCode = null, Expression<Func<string>> exhibitorPrimaryGroup = null, Expression<Func<string>> exhibitorPriorityPoints = null, Expression<Func<string>> exhibitorProductDescription = null, Expression<Func<string>> exhibitorState = null, Expression<Func<string>> exhibitorWebSite = null)
        {
            var apiCallPath = String.Format("/{0}/exhibitors/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var exhibitor = new JObject();
            var exhibitorpropCount = 0;
            if (exhibitorAddress1 != null)
            {
                exhibitor["Address1"] = ExpressionConverter.ConvertO(exhibitorAddress1);
                exhibitorpropCount++;
            }

            if (exhibitorAddress2 != null)
            {
                exhibitor["Address2"] = ExpressionConverter.ConvertO(exhibitorAddress2);
                exhibitorpropCount++;
            }

            if (exhibitorCity != null)
            {
                exhibitor["City"] = ExpressionConverter.ConvertO(exhibitorCity);
                exhibitorpropCount++;
            }

            if (exhibitorComments != null)
            {
                exhibitor["Comments"] = ExpressionConverter.ConvertO(exhibitorComments);
                exhibitorpropCount++;
            }

            if (exhibitorComments2 != null)
            {
                exhibitor["Comments2"] = ExpressionConverter.ConvertO(exhibitorComments2);
                exhibitorpropCount++;
            }

            if (exhibitorContact != null)
            {
                exhibitor["Contact"] = ExpressionConverter.ConvertO(exhibitorContact);
                exhibitorpropCount++;
            }

            if (exhibitorCountry != null)
            {
                exhibitor["Country"] = ExpressionConverter.ConvertO(exhibitorCountry);
                exhibitorpropCount++;
            }

            if (exhibitorCellPhone != null)
            {
                exhibitor["CellPhone"] = ExpressionConverter.ConvertO(exhibitorCellPhone);
                exhibitorpropCount++;
            }

            if (exhibitorDisplayOnDrawing != null)
            {
                exhibitor["DisplayOnDrawing"] = ExpressionConverter.ConvertO(exhibitorDisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitorDoingBusinessAs != null)
            {
                exhibitor["DoingBusinessAs"] = ExpressionConverter.ConvertO(exhibitorDoingBusinessAs);
                exhibitorpropCount++;
            }

            if (exhibitorDoingBusinessAsDisplayOnDrawing != null)
            {
                exhibitor["DoingBusinessAsDisplayOnDrawing"] = ExpressionConverter.ConvertO(exhibitorDoingBusinessAsDisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitorEmail != null)
            {
                exhibitor["Email"] = ExpressionConverter.ConvertO(exhibitorEmail);
                exhibitorpropCount++;
            }

            exhibitorpropCount++;
            exhibitor["ExhibitorId"] = ExpressionConverter.ConvertO(exhibitorExhibitorId);
            if (exhibitorExhibitorName != null)
            {
                exhibitor["ExhibitorName"] = ExpressionConverter.ConvertO(exhibitorExhibitorName);
                exhibitorpropCount++;
            }

            if (exhibitorExhibitorNameLine2 != null)
            {
                exhibitor["ExhibitorNameLine2"] = ExpressionConverter.ConvertO(exhibitorExhibitorNameLine2);
                exhibitorpropCount++;
            }

            if (exhibitorFax != null)
            {
                exhibitor["Fax"] = ExpressionConverter.ConvertO(exhibitorFax);
                exhibitorpropCount++;
            }

            if (exhibitorField1 != null)
            {
                exhibitor["Field1"] = ExpressionConverter.ConvertO(exhibitorField1);
                exhibitorpropCount++;
            }

            if (exhibitorField2 != null)
            {
                exhibitor["Field2"] = ExpressionConverter.ConvertO(exhibitorField2);
                exhibitorpropCount++;
            }

            if (exhibitorField3 != null)
            {
                exhibitor["Field3"] = ExpressionConverter.ConvertO(exhibitorField3);
                exhibitorpropCount++;
            }

            if (exhibitorField4 != null)
            {
                exhibitor["Field4"] = ExpressionConverter.ConvertO(exhibitorField4);
                exhibitorpropCount++;
            }

            if (exhibitorField5 != null)
            {
                exhibitor["Field5"] = ExpressionConverter.ConvertO(exhibitorField5);
                exhibitorpropCount++;
            }

            if (exhibitorField6 != null)
            {
                exhibitor["Field6"] = ExpressionConverter.ConvertO(exhibitorField6);
                exhibitorpropCount++;
            }

            if (exhibitorField7 != null)
            {
                exhibitor["Field7"] = ExpressionConverter.ConvertO(exhibitorField7);
                exhibitorpropCount++;
            }

            if (exhibitorField8 != null)
            {
                exhibitor["Field8"] = ExpressionConverter.ConvertO(exhibitorField8);
                exhibitorpropCount++;
            }

            if (exhibitorField9 != null)
            {
                exhibitor["Field9"] = ExpressionConverter.ConvertO(exhibitorField9);
                exhibitorpropCount++;
            }

            if (exhibitorNickName != null)
            {
                exhibitor["NickName"] = ExpressionConverter.ConvertO(exhibitorNickName);
                exhibitorpropCount++;
            }

            if (exhibitorSalutation != null)
            {
                exhibitor["Salutation"] = ExpressionConverter.ConvertO(exhibitorSalutation);
                exhibitorpropCount++;
            }

            if (exhibitorTitle != null)
            {
                exhibitor["Title"] = ExpressionConverter.ConvertO(exhibitorTitle);
                exhibitorpropCount++;
            }

            if (exhibitorPhone != null)
            {
                exhibitor["Phone"] = ExpressionConverter.ConvertO(exhibitorPhone);
                exhibitorpropCount++;
            }

            if (exhibitorPostalCode != null)
            {
                exhibitor["PostalCode"] = ExpressionConverter.ConvertO(exhibitorPostalCode);
                exhibitorpropCount++;
            }

            if (exhibitorPrimaryGroup != null)
            {
                exhibitor["PrimaryGroup"] = ExpressionConverter.ConvertO(exhibitorPrimaryGroup);
                exhibitorpropCount++;
            }

            if (exhibitorPriorityPoints != null)
            {
                exhibitor["PriorityPoints"] = ExpressionConverter.ConvertO(exhibitorPriorityPoints);
                exhibitorpropCount++;
            }

            if (exhibitorProductDescription != null)
            {
                exhibitor["ProductDescription"] = ExpressionConverter.ConvertO(exhibitorProductDescription);
                exhibitorpropCount++;
            }

            if (exhibitorState != null)
            {
                exhibitor["State"] = ExpressionConverter.ConvertO(exhibitorState);
                exhibitorpropCount++;
            }

            if (exhibitorWebSite != null)
            {
                exhibitor["WebSite"] = ExpressionConverter.ConvertO(exhibitorWebSite);
                exhibitorpropCount++;
            }

            if (exhibitorpropCount > 0)
            {
                callPayload.Body = exhibitor;
            }

            return new ApiConnectionAction<Exhibitor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsUpdateExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> exhibitorExhibitorId, Expression<Func<string>> id, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorAddress1 = null, Expression<Func<string>> exhibitorAddress2 = null, Expression<Func<string>> exhibitorCity = null, Expression<Func<string>> exhibitorComments = null, Expression<Func<string>> exhibitorComments2 = null, Expression<Func<string>> exhibitorContact = null, Expression<Func<string>> exhibitorCountry = null, Expression<Func<string>> exhibitorCellPhone = null, Expression<Func<string>> exhibitorDisplayOnDrawing = null, Expression<Func<string>> exhibitorDoingBusinessAs = null, Expression<Func<string>> exhibitorDoingBusinessAsDisplayOnDrawing = null, Expression<Func<string>> exhibitorEmail = null, Expression<Func<string>> exhibitorExhibitorName = null, Expression<Func<string>> exhibitorExhibitorNameLine2 = null, Expression<Func<string>> exhibitorFax = null, Expression<Func<string>> exhibitorField1 = null, Expression<Func<string>> exhibitorField2 = null, Expression<Func<string>> exhibitorField3 = null, Expression<Func<string>> exhibitorField4 = null, Expression<Func<string>> exhibitorField5 = null, Expression<Func<string>> exhibitorField6 = null, Expression<Func<string>> exhibitorField7 = null, Expression<Func<string>> exhibitorField8 = null, Expression<Func<string>> exhibitorField9 = null, Expression<Func<string>> exhibitorNickName = null, Expression<Func<string>> exhibitorSalutation = null, Expression<Func<string>> exhibitorTitle = null, Expression<Func<string>> exhibitorPhone = null, Expression<Func<string>> exhibitorPostalCode = null, Expression<Func<string>> exhibitorPrimaryGroup = null, Expression<Func<string>> exhibitorPriorityPoints = null, Expression<Func<string>> exhibitorProductDescription = null, Expression<Func<string>> exhibitorState = null, Expression<Func<string>> exhibitorWebSite = null)
        {
            var apiCallPath = String.Format("/{0}/exhibitors/update", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var exhibitor = new JObject();
            var exhibitorpropCount = 0;
            if (exhibitorAddress1 != null)
            {
                exhibitor["Address1"] = ExpressionConverter.ConvertO(exhibitorAddress1);
                exhibitorpropCount++;
            }

            if (exhibitorAddress2 != null)
            {
                exhibitor["Address2"] = ExpressionConverter.ConvertO(exhibitorAddress2);
                exhibitorpropCount++;
            }

            if (exhibitorCity != null)
            {
                exhibitor["City"] = ExpressionConverter.ConvertO(exhibitorCity);
                exhibitorpropCount++;
            }

            if (exhibitorComments != null)
            {
                exhibitor["Comments"] = ExpressionConverter.ConvertO(exhibitorComments);
                exhibitorpropCount++;
            }

            if (exhibitorComments2 != null)
            {
                exhibitor["Comments2"] = ExpressionConverter.ConvertO(exhibitorComments2);
                exhibitorpropCount++;
            }

            if (exhibitorContact != null)
            {
                exhibitor["Contact"] = ExpressionConverter.ConvertO(exhibitorContact);
                exhibitorpropCount++;
            }

            if (exhibitorCountry != null)
            {
                exhibitor["Country"] = ExpressionConverter.ConvertO(exhibitorCountry);
                exhibitorpropCount++;
            }

            if (exhibitorCellPhone != null)
            {
                exhibitor["CellPhone"] = ExpressionConverter.ConvertO(exhibitorCellPhone);
                exhibitorpropCount++;
            }

            if (exhibitorDisplayOnDrawing != null)
            {
                exhibitor["DisplayOnDrawing"] = ExpressionConverter.ConvertO(exhibitorDisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitorDoingBusinessAs != null)
            {
                exhibitor["DoingBusinessAs"] = ExpressionConverter.ConvertO(exhibitorDoingBusinessAs);
                exhibitorpropCount++;
            }

            if (exhibitorDoingBusinessAsDisplayOnDrawing != null)
            {
                exhibitor["DoingBusinessAsDisplayOnDrawing"] = ExpressionConverter.ConvertO(exhibitorDoingBusinessAsDisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitorEmail != null)
            {
                exhibitor["Email"] = ExpressionConverter.ConvertO(exhibitorEmail);
                exhibitorpropCount++;
            }

            exhibitorpropCount++;
            exhibitor["ExhibitorId"] = ExpressionConverter.ConvertO(exhibitorExhibitorId);
            if (exhibitorExhibitorName != null)
            {
                exhibitor["ExhibitorName"] = ExpressionConverter.ConvertO(exhibitorExhibitorName);
                exhibitorpropCount++;
            }

            if (exhibitorExhibitorNameLine2 != null)
            {
                exhibitor["ExhibitorNameLine2"] = ExpressionConverter.ConvertO(exhibitorExhibitorNameLine2);
                exhibitorpropCount++;
            }

            if (exhibitorFax != null)
            {
                exhibitor["Fax"] = ExpressionConverter.ConvertO(exhibitorFax);
                exhibitorpropCount++;
            }

            if (exhibitorField1 != null)
            {
                exhibitor["Field1"] = ExpressionConverter.ConvertO(exhibitorField1);
                exhibitorpropCount++;
            }

            if (exhibitorField2 != null)
            {
                exhibitor["Field2"] = ExpressionConverter.ConvertO(exhibitorField2);
                exhibitorpropCount++;
            }

            if (exhibitorField3 != null)
            {
                exhibitor["Field3"] = ExpressionConverter.ConvertO(exhibitorField3);
                exhibitorpropCount++;
            }

            if (exhibitorField4 != null)
            {
                exhibitor["Field4"] = ExpressionConverter.ConvertO(exhibitorField4);
                exhibitorpropCount++;
            }

            if (exhibitorField5 != null)
            {
                exhibitor["Field5"] = ExpressionConverter.ConvertO(exhibitorField5);
                exhibitorpropCount++;
            }

            if (exhibitorField6 != null)
            {
                exhibitor["Field6"] = ExpressionConverter.ConvertO(exhibitorField6);
                exhibitorpropCount++;
            }

            if (exhibitorField7 != null)
            {
                exhibitor["Field7"] = ExpressionConverter.ConvertO(exhibitorField7);
                exhibitorpropCount++;
            }

            if (exhibitorField8 != null)
            {
                exhibitor["Field8"] = ExpressionConverter.ConvertO(exhibitorField8);
                exhibitorpropCount++;
            }

            if (exhibitorField9 != null)
            {
                exhibitor["Field9"] = ExpressionConverter.ConvertO(exhibitorField9);
                exhibitorpropCount++;
            }

            if (exhibitorNickName != null)
            {
                exhibitor["NickName"] = ExpressionConverter.ConvertO(exhibitorNickName);
                exhibitorpropCount++;
            }

            if (exhibitorSalutation != null)
            {
                exhibitor["Salutation"] = ExpressionConverter.ConvertO(exhibitorSalutation);
                exhibitorpropCount++;
            }

            if (exhibitorTitle != null)
            {
                exhibitor["Title"] = ExpressionConverter.ConvertO(exhibitorTitle);
                exhibitorpropCount++;
            }

            if (exhibitorPhone != null)
            {
                exhibitor["Phone"] = ExpressionConverter.ConvertO(exhibitorPhone);
                exhibitorpropCount++;
            }

            if (exhibitorPostalCode != null)
            {
                exhibitor["PostalCode"] = ExpressionConverter.ConvertO(exhibitorPostalCode);
                exhibitorpropCount++;
            }

            if (exhibitorPrimaryGroup != null)
            {
                exhibitor["PrimaryGroup"] = ExpressionConverter.ConvertO(exhibitorPrimaryGroup);
                exhibitorpropCount++;
            }

            if (exhibitorPriorityPoints != null)
            {
                exhibitor["PriorityPoints"] = ExpressionConverter.ConvertO(exhibitorPriorityPoints);
                exhibitorpropCount++;
            }

            if (exhibitorProductDescription != null)
            {
                exhibitor["ProductDescription"] = ExpressionConverter.ConvertO(exhibitorProductDescription);
                exhibitorpropCount++;
            }

            if (exhibitorState != null)
            {
                exhibitor["State"] = ExpressionConverter.ConvertO(exhibitorState);
                exhibitorpropCount++;
            }

            if (exhibitorWebSite != null)
            {
                exhibitor["WebSite"] = ExpressionConverter.ConvertO(exhibitorWebSite);
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
            var apiCallPath = String.Format("/{0}/exhibitors/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Transaction[]> FinancialsGetAllTransactions(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> boothNumber = null, Expression<Func<string>> expocadUser = null, Expression<Func<string>> glCode = null, Expression<Func<reversedFilterInput>> reversedFilter = null)
        {
            var apiCallPath = String.Format("/{0}/financials/transactions", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (startDate != null)
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            if (exhibitorId != null)
                callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(exhibitorId);
            if (boothNumber != null)
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            if (expocadUser != null)
                callPayload.Queries["expocadUser"] = ExpressionConverter.Convert(expocadUser);
            if (glCode != null)
                callPayload.Queries["glCode"] = ExpressionConverter.Convert(glCode);
            if (reversedFilter != null)
                callPayload.Queries["reversedFilter"] = ExpressionConverter.Convert(reversedFilter);
            return new ApiConnectionAction<Transaction[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothFinancial> FinancialsGet(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/financials/booths", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<BoothFinancial>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice> FinancialsGetInvoice(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> invoiceNo = null, Expression<Func<string>> exhibitorId = null)
        {
            var apiCallPath = String.Format("/{0}/financials/invoices", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (invoiceNo != null)
                callPayload.Queries["invoiceNo"] = ExpressionConverter.Convert(invoiceNo);
            if (exhibitorId != null)
                callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(exhibitorId);
            return new ApiConnectionAction<Invoice>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice[]> FinancialsGetAllInvoices(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/financials/invoices/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Invoice[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<MasterRequestItem[]> FinancialsGetRequestItemList(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> glCode = null, Expression<Func<string>> transactionCode = null)
        {
            var apiCallPath = String.Format("/{0}/financials/requestitemlist", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (glCode != null)
                callPayload.Queries["glCode"] = ExpressionConverter.Convert(glCode);
            if (transactionCode != null)
                callPayload.Queries["transactionCode"] = ExpressionConverter.Convert(transactionCode);
            return new ApiConnectionAction<MasterRequestItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoiceRequestItem[]> FinancialsGetAssignedRequestItems(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> booth = null, Expression<Func<string>> glCode = null, Expression<Func<string>> transactionCode = null)
        {
            var apiCallPath = String.Format("/{0}/financials/requestitems", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (exhibitorId != null)
                callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(exhibitorId);
            if (invoiceNumber != null)
                callPayload.Queries["invoiceNumber"] = ExpressionConverter.Convert(invoiceNumber);
            if (startDate != null)
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
            if (booth != null)
                callPayload.Queries["booth"] = ExpressionConverter.Convert(booth);
            if (glCode != null)
                callPayload.Queries["glCode"] = ExpressionConverter.Convert(glCode);
            if (transactionCode != null)
                callPayload.Queries["transactionCode"] = ExpressionConverter.Convert(transactionCode);
            return new ApiConnectionAction<InvoiceRequestItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<PaymentTypeItem[]> FinancialsGetPaymentTypeList(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/financials/paymenttypelist", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<PaymentTypeItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoicePayment[]> FinancialsGetPayments(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> depositId = null, Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> paymentTypeCategory = null)
        {
            var apiCallPath = String.Format("/{0}/financials/payments", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            if (exhibitorId != null)
                callPayload.Queries["ExhibitorId"] = ExpressionConverter.Convert(exhibitorId);
            if (depositId != null)
                callPayload.Queries["DepositId"] = ExpressionConverter.Convert(depositId);
            if (invoiceNumber != null)
                callPayload.Queries["InvoiceNumber"] = ExpressionConverter.Convert(invoiceNumber);
            if (startDate != null)
                callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["EndDate"] = ExpressionConverter.Convert(endDate);
            if (paymentTypeCategory != null)
                callPayload.Queries["PaymentTypeCategory"] = ExpressionConverter.Convert(paymentTypeCategory);
            return new ApiConnectionAction<InvoicePayment[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Pavilion[]> PavilionsGetAllPavilions(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/pavilions/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Pavilion[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansGetDefaultRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/rateplans/default", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<RatePlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> RatePlansSetDefaultRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> name)
        {
            var apiCallPath = String.Format("/{0}/rateplans/default", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan[]> RatePlansGetAllRatePlans(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/rateplans/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<RatePlan[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansAddRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlanName, Expression<Func<string>> ratePlanShortCode, Expression<Func<double>> ratePlanGrossRate, Expression<Func<double>> ratePlanFixedDiscountRate, Expression<Func<double>> ratePlanPercentDiscountRate, Expression<Func<bool>> ratePlanIsFixed)
        {
            var apiCallPath = String.Format("/{0}/rateplans/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var ratePlan = new JObject();
            var ratePlanpropCount = 0;
            ratePlanpropCount++;
            ratePlan["Name"] = ExpressionConverter.ConvertO(ratePlanName);
            ratePlanpropCount++;
            ratePlan["ShortCode"] = ExpressionConverter.ConvertO(ratePlanShortCode);
            ratePlanpropCount++;
            ratePlan["GrossRate"] = ExpressionConverter.ConvertO(ratePlanGrossRate);
            ratePlanpropCount++;
            ratePlan["FixedDiscountRate"] = ExpressionConverter.ConvertO(ratePlanFixedDiscountRate);
            ratePlanpropCount++;
            ratePlan["PercentDiscountRate"] = ExpressionConverter.ConvertO(ratePlanPercentDiscountRate);
            ratePlanpropCount++;
            ratePlan["IsFixed"] = ExpressionConverter.ConvertO(ratePlanIsFixed);
            if (ratePlanpropCount > 0)
            {
                callPayload.Body = ratePlan;
            }

            return new ApiConnectionAction<RatePlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ShowInShow[]> ShowInShowsGetAllShowinShows(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var apiCallPath = String.Format("/{0}/showinshows/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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