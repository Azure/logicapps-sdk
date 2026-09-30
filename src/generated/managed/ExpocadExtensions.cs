//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expocad
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExpocadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth> BoothsGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Booth>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllBooths([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<deletedFilterInput> deletedFilter = null)
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
        public IBodyWorkflowAction<Booth[]> BoothsGetAllAvailableBooths([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/all/available", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Booth[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[]> BoothsGetAllRentedBooths([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/all/rented", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Booth[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentBooth([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> exhibitorId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlan = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> comment = null)
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
        public IBodyWorkflowAction<JToken> BoothsUnRentBooth([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/unrent", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldBooth([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> exhibitorName = null, [WorkflowExpression] Func<string> comment = null)
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
        public IBodyWorkflowAction<JToken> BoothsUnHoldBooth([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/unhold", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsRentToHold([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/rentToHold", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsHoldToRent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlan = null)
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
        public IBodyWorkflowAction<JToken> BoothsCombineBooths([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<int> boundary, [WorkflowExpression] Func<string[]> boothNumbers = null)
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
        public IBodyWorkflowAction<JToken> BoothsUncombineBooth([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/uncombine", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsDeleteBooths([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string[]> boothNumbers = null)
        {
            var apiCallPath = String.Format("/{0}/booths/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            callPayload.Body = ExpressionConverter.ConvertO(boothNumbers);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsUndeleteBooths([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string[]> boothNumbers = null)
        {
            var apiCallPath = String.Format("/{0}/booths/undelete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            callPayload.Body = ExpressionConverter.ConvertO(boothNumbers);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsChangeBoothNumber([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> oldNumber, [WorkflowExpression] Func<string> newNumber, [WorkflowExpression] Func<string> databaseName)
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
        public IBodyWorkflowAction<JToken> BoothsSetBoothClass([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
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
        public IBodyWorkflowAction<JToken> BoothsClearBoothClass([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
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
        public IBodyWorkflowAction<JToken> BoothsSetBoothDisplayName([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> text, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
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
        public IBodyWorkflowAction<JToken> BoothsClearBoothDisplayName([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/booths/displayNameOverride/reset", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> BoothsAddChildExhibitor([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> childExhibitorId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
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
        public IBodyWorkflowAction<JToken> BoothsRemoveChildExhibitor([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> childExhibitorId, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
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
        public IBodyWorkflowAction<BoothClass> ClassesGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/classes", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<BoothClass>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass[]> ClassesGetAllBoothClasses([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/classes/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<BoothClass[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesCreate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothClassid, [WorkflowExpression] Func<int> boothClasskeepWhenCombined, [WorkflowExpression] Func<int> boothClasscountAsInventory, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> boothClassname = null, [WorkflowExpression] Func<string> boothClassdescription = null, [WorkflowExpression] Func<string> boothClassprioritity = null, [WorkflowExpression] Func<int> boothClasscolor = null)
        {
            var apiCallPath = String.Format("/{0}/classes/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var boothClass = new JObject();
            var boothClasspropCount = 0;
            boothClasspropCount++;
            boothClass["Id"] = ExpressionConverter.ConvertO(boothClassid);
            if (boothClassname != null)
            {
                boothClass["Name"] = ExpressionConverter.ConvertO(boothClassname);
                boothClasspropCount++;
            }

            if (boothClassdescription != null)
            {
                boothClass["Description"] = ExpressionConverter.ConvertO(boothClassdescription);
                boothClasspropCount++;
            }

            boothClasspropCount++;
            boothClass["KeepWhenCombined"] = ExpressionConverter.ConvertO(boothClasskeepWhenCombined);
            boothClasspropCount++;
            boothClass["CountAsInventory"] = ExpressionConverter.ConvertO(boothClasscountAsInventory);
            if (boothClassprioritity != null)
            {
                boothClass["Prioritity"] = ExpressionConverter.ConvertO(boothClassprioritity);
                boothClasspropCount++;
            }

            if (boothClasscolor != null)
            {
                boothClass["Color"] = ExpressionConverter.ConvertO(boothClasscolor);
                boothClasspropCount++;
            }

            if (boothClasspropCount > 0)
            {
                callPayload.Body = boothClass;
            }

            return new ApiConnectionAction<BoothClass>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass> ClassesUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothClassid, [WorkflowExpression] Func<int> boothClasskeepWhenCombined, [WorkflowExpression] Func<int> boothClasscountAsInventory, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> boothClassname = null, [WorkflowExpression] Func<string> boothClassdescription = null, [WorkflowExpression] Func<string> boothClassprioritity = null, [WorkflowExpression] Func<int> boothClasscolor = null)
        {
            var apiCallPath = String.Format("/{0}/classes/update", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var boothClass = new JObject();
            var boothClasspropCount = 0;
            boothClasspropCount++;
            boothClass["Id"] = ExpressionConverter.ConvertO(boothClassid);
            if (boothClassname != null)
            {
                boothClass["Name"] = ExpressionConverter.ConvertO(boothClassname);
                boothClasspropCount++;
            }

            if (boothClassdescription != null)
            {
                boothClass["Description"] = ExpressionConverter.ConvertO(boothClassdescription);
                boothClasspropCount++;
            }

            boothClasspropCount++;
            boothClass["KeepWhenCombined"] = ExpressionConverter.ConvertO(boothClasskeepWhenCombined);
            boothClasspropCount++;
            boothClass["CountAsInventory"] = ExpressionConverter.ConvertO(boothClasscountAsInventory);
            if (boothClassprioritity != null)
            {
                boothClass["Prioritity"] = ExpressionConverter.ConvertO(boothClassprioritity);
                boothClasspropCount++;
            }

            if (boothClasscolor != null)
            {
                boothClass["Color"] = ExpressionConverter.ConvertO(boothClasscolor);
                boothClasspropCount++;
            }

            if (boothClasspropCount > 0)
            {
                callPayload.Body = boothClass;
            }

            return new ApiConnectionAction<BoothClass>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> ClassesDelete([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> classId, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/classes/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["classId"] = ExpressionConverter.Convert(classId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpocadEvent[]> EventsGetAllEvents([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName)
        {
            var apiCallPath = String.Format("/{0}/events", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExpocadEvent[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<EventStats> EventsGetEventStatistics([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/events/stats", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<EventStats>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpoEventInformation> EventsGetEventInformation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/events/info", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<ExpoEventInformation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/exhibitors", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Exhibitor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor[]> ExhibitorsGetAllExhibitors([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/exhibitors/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Exhibitor[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsAddExhibitor([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> exhibitorexhibitorId, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitoraddress1 = null, [WorkflowExpression] Func<string> exhibitoraddress2 = null, [WorkflowExpression] Func<string> exhibitorcity = null, [WorkflowExpression] Func<string> exhibitorcomments = null, [WorkflowExpression] Func<string> exhibitorcomments2 = null, [WorkflowExpression] Func<string> exhibitorcontact = null, [WorkflowExpression] Func<string> exhibitorcountry = null, [WorkflowExpression] Func<string> exhibitorcellPhone = null, [WorkflowExpression] Func<string> exhibitordisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAs = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAsDisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitoremail = null, [WorkflowExpression] Func<string> exhibitorexhibitorName = null, [WorkflowExpression] Func<string> exhibitorexhibitorNameLine2 = null, [WorkflowExpression] Func<string> exhibitorfax = null, [WorkflowExpression] Func<string> exhibitorfield1 = null, [WorkflowExpression] Func<string> exhibitorfield2 = null, [WorkflowExpression] Func<string> exhibitorfield3 = null, [WorkflowExpression] Func<string> exhibitorfield4 = null, [WorkflowExpression] Func<string> exhibitorfield5 = null, [WorkflowExpression] Func<string> exhibitorfield6 = null, [WorkflowExpression] Func<string> exhibitorfield7 = null, [WorkflowExpression] Func<string> exhibitorfield8 = null, [WorkflowExpression] Func<string> exhibitorfield9 = null, [WorkflowExpression] Func<string> exhibitornickName = null, [WorkflowExpression] Func<string> exhibitorsalutation = null, [WorkflowExpression] Func<string> exhibitortitle = null, [WorkflowExpression] Func<string> exhibitorphone = null, [WorkflowExpression] Func<string> exhibitorpostalCode = null, [WorkflowExpression] Func<string> exhibitorprimaryGroup = null, [WorkflowExpression] Func<string> exhibitorpriorityPoints = null, [WorkflowExpression] Func<string> exhibitorproductDescription = null, [WorkflowExpression] Func<string> exhibitorstate = null, [WorkflowExpression] Func<string> exhibitorwebSite = null)
        {
            var apiCallPath = String.Format("/{0}/exhibitors/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var exhibitor = new JObject();
            var exhibitorpropCount = 0;
            if (exhibitoraddress1 != null)
            {
                exhibitor["Address1"] = ExpressionConverter.ConvertO(exhibitoraddress1);
                exhibitorpropCount++;
            }

            if (exhibitoraddress2 != null)
            {
                exhibitor["Address2"] = ExpressionConverter.ConvertO(exhibitoraddress2);
                exhibitorpropCount++;
            }

            if (exhibitorcity != null)
            {
                exhibitor["City"] = ExpressionConverter.ConvertO(exhibitorcity);
                exhibitorpropCount++;
            }

            if (exhibitorcomments != null)
            {
                exhibitor["Comments"] = ExpressionConverter.ConvertO(exhibitorcomments);
                exhibitorpropCount++;
            }

            if (exhibitorcomments2 != null)
            {
                exhibitor["Comments2"] = ExpressionConverter.ConvertO(exhibitorcomments2);
                exhibitorpropCount++;
            }

            if (exhibitorcontact != null)
            {
                exhibitor["Contact"] = ExpressionConverter.ConvertO(exhibitorcontact);
                exhibitorpropCount++;
            }

            if (exhibitorcountry != null)
            {
                exhibitor["Country"] = ExpressionConverter.ConvertO(exhibitorcountry);
                exhibitorpropCount++;
            }

            if (exhibitorcellPhone != null)
            {
                exhibitor["CellPhone"] = ExpressionConverter.ConvertO(exhibitorcellPhone);
                exhibitorpropCount++;
            }

            if (exhibitordisplayOnDrawing != null)
            {
                exhibitor["DisplayOnDrawing"] = ExpressionConverter.ConvertO(exhibitordisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitordoingBusinessAs != null)
            {
                exhibitor["DoingBusinessAs"] = ExpressionConverter.ConvertO(exhibitordoingBusinessAs);
                exhibitorpropCount++;
            }

            if (exhibitordoingBusinessAsDisplayOnDrawing != null)
            {
                exhibitor["DoingBusinessAsDisplayOnDrawing"] = ExpressionConverter.ConvertO(exhibitordoingBusinessAsDisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitoremail != null)
            {
                exhibitor["Email"] = ExpressionConverter.ConvertO(exhibitoremail);
                exhibitorpropCount++;
            }

            exhibitorpropCount++;
            exhibitor["ExhibitorId"] = ExpressionConverter.ConvertO(exhibitorexhibitorId);
            if (exhibitorexhibitorName != null)
            {
                exhibitor["ExhibitorName"] = ExpressionConverter.ConvertO(exhibitorexhibitorName);
                exhibitorpropCount++;
            }

            if (exhibitorexhibitorNameLine2 != null)
            {
                exhibitor["ExhibitorNameLine2"] = ExpressionConverter.ConvertO(exhibitorexhibitorNameLine2);
                exhibitorpropCount++;
            }

            if (exhibitorfax != null)
            {
                exhibitor["Fax"] = ExpressionConverter.ConvertO(exhibitorfax);
                exhibitorpropCount++;
            }

            if (exhibitorfield1 != null)
            {
                exhibitor["Field1"] = ExpressionConverter.ConvertO(exhibitorfield1);
                exhibitorpropCount++;
            }

            if (exhibitorfield2 != null)
            {
                exhibitor["Field2"] = ExpressionConverter.ConvertO(exhibitorfield2);
                exhibitorpropCount++;
            }

            if (exhibitorfield3 != null)
            {
                exhibitor["Field3"] = ExpressionConverter.ConvertO(exhibitorfield3);
                exhibitorpropCount++;
            }

            if (exhibitorfield4 != null)
            {
                exhibitor["Field4"] = ExpressionConverter.ConvertO(exhibitorfield4);
                exhibitorpropCount++;
            }

            if (exhibitorfield5 != null)
            {
                exhibitor["Field5"] = ExpressionConverter.ConvertO(exhibitorfield5);
                exhibitorpropCount++;
            }

            if (exhibitorfield6 != null)
            {
                exhibitor["Field6"] = ExpressionConverter.ConvertO(exhibitorfield6);
                exhibitorpropCount++;
            }

            if (exhibitorfield7 != null)
            {
                exhibitor["Field7"] = ExpressionConverter.ConvertO(exhibitorfield7);
                exhibitorpropCount++;
            }

            if (exhibitorfield8 != null)
            {
                exhibitor["Field8"] = ExpressionConverter.ConvertO(exhibitorfield8);
                exhibitorpropCount++;
            }

            if (exhibitorfield9 != null)
            {
                exhibitor["Field9"] = ExpressionConverter.ConvertO(exhibitorfield9);
                exhibitorpropCount++;
            }

            if (exhibitornickName != null)
            {
                exhibitor["NickName"] = ExpressionConverter.ConvertO(exhibitornickName);
                exhibitorpropCount++;
            }

            if (exhibitorsalutation != null)
            {
                exhibitor["Salutation"] = ExpressionConverter.ConvertO(exhibitorsalutation);
                exhibitorpropCount++;
            }

            if (exhibitortitle != null)
            {
                exhibitor["Title"] = ExpressionConverter.ConvertO(exhibitortitle);
                exhibitorpropCount++;
            }

            if (exhibitorphone != null)
            {
                exhibitor["Phone"] = ExpressionConverter.ConvertO(exhibitorphone);
                exhibitorpropCount++;
            }

            if (exhibitorpostalCode != null)
            {
                exhibitor["PostalCode"] = ExpressionConverter.ConvertO(exhibitorpostalCode);
                exhibitorpropCount++;
            }

            if (exhibitorprimaryGroup != null)
            {
                exhibitor["PrimaryGroup"] = ExpressionConverter.ConvertO(exhibitorprimaryGroup);
                exhibitorpropCount++;
            }

            if (exhibitorpriorityPoints != null)
            {
                exhibitor["PriorityPoints"] = ExpressionConverter.ConvertO(exhibitorpriorityPoints);
                exhibitorpropCount++;
            }

            if (exhibitorproductDescription != null)
            {
                exhibitor["ProductDescription"] = ExpressionConverter.ConvertO(exhibitorproductDescription);
                exhibitorpropCount++;
            }

            if (exhibitorstate != null)
            {
                exhibitor["State"] = ExpressionConverter.ConvertO(exhibitorstate);
                exhibitorpropCount++;
            }

            if (exhibitorwebSite != null)
            {
                exhibitor["WebSite"] = ExpressionConverter.ConvertO(exhibitorwebSite);
                exhibitorpropCount++;
            }

            if (exhibitorpropCount > 0)
            {
                callPayload.Body = exhibitor;
            }

            return new ApiConnectionAction<Exhibitor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor> ExhibitorsUpdateExhibitor([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> exhibitorexhibitorId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitoraddress1 = null, [WorkflowExpression] Func<string> exhibitoraddress2 = null, [WorkflowExpression] Func<string> exhibitorcity = null, [WorkflowExpression] Func<string> exhibitorcomments = null, [WorkflowExpression] Func<string> exhibitorcomments2 = null, [WorkflowExpression] Func<string> exhibitorcontact = null, [WorkflowExpression] Func<string> exhibitorcountry = null, [WorkflowExpression] Func<string> exhibitorcellPhone = null, [WorkflowExpression] Func<string> exhibitordisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAs = null, [WorkflowExpression] Func<string> exhibitordoingBusinessAsDisplayOnDrawing = null, [WorkflowExpression] Func<string> exhibitoremail = null, [WorkflowExpression] Func<string> exhibitorexhibitorName = null, [WorkflowExpression] Func<string> exhibitorexhibitorNameLine2 = null, [WorkflowExpression] Func<string> exhibitorfax = null, [WorkflowExpression] Func<string> exhibitorfield1 = null, [WorkflowExpression] Func<string> exhibitorfield2 = null, [WorkflowExpression] Func<string> exhibitorfield3 = null, [WorkflowExpression] Func<string> exhibitorfield4 = null, [WorkflowExpression] Func<string> exhibitorfield5 = null, [WorkflowExpression] Func<string> exhibitorfield6 = null, [WorkflowExpression] Func<string> exhibitorfield7 = null, [WorkflowExpression] Func<string> exhibitorfield8 = null, [WorkflowExpression] Func<string> exhibitorfield9 = null, [WorkflowExpression] Func<string> exhibitornickName = null, [WorkflowExpression] Func<string> exhibitorsalutation = null, [WorkflowExpression] Func<string> exhibitortitle = null, [WorkflowExpression] Func<string> exhibitorphone = null, [WorkflowExpression] Func<string> exhibitorpostalCode = null, [WorkflowExpression] Func<string> exhibitorprimaryGroup = null, [WorkflowExpression] Func<string> exhibitorpriorityPoints = null, [WorkflowExpression] Func<string> exhibitorproductDescription = null, [WorkflowExpression] Func<string> exhibitorstate = null, [WorkflowExpression] Func<string> exhibitorwebSite = null)
        {
            var apiCallPath = String.Format("/{0}/exhibitors/update", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var exhibitor = new JObject();
            var exhibitorpropCount = 0;
            if (exhibitoraddress1 != null)
            {
                exhibitor["Address1"] = ExpressionConverter.ConvertO(exhibitoraddress1);
                exhibitorpropCount++;
            }

            if (exhibitoraddress2 != null)
            {
                exhibitor["Address2"] = ExpressionConverter.ConvertO(exhibitoraddress2);
                exhibitorpropCount++;
            }

            if (exhibitorcity != null)
            {
                exhibitor["City"] = ExpressionConverter.ConvertO(exhibitorcity);
                exhibitorpropCount++;
            }

            if (exhibitorcomments != null)
            {
                exhibitor["Comments"] = ExpressionConverter.ConvertO(exhibitorcomments);
                exhibitorpropCount++;
            }

            if (exhibitorcomments2 != null)
            {
                exhibitor["Comments2"] = ExpressionConverter.ConvertO(exhibitorcomments2);
                exhibitorpropCount++;
            }

            if (exhibitorcontact != null)
            {
                exhibitor["Contact"] = ExpressionConverter.ConvertO(exhibitorcontact);
                exhibitorpropCount++;
            }

            if (exhibitorcountry != null)
            {
                exhibitor["Country"] = ExpressionConverter.ConvertO(exhibitorcountry);
                exhibitorpropCount++;
            }

            if (exhibitorcellPhone != null)
            {
                exhibitor["CellPhone"] = ExpressionConverter.ConvertO(exhibitorcellPhone);
                exhibitorpropCount++;
            }

            if (exhibitordisplayOnDrawing != null)
            {
                exhibitor["DisplayOnDrawing"] = ExpressionConverter.ConvertO(exhibitordisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitordoingBusinessAs != null)
            {
                exhibitor["DoingBusinessAs"] = ExpressionConverter.ConvertO(exhibitordoingBusinessAs);
                exhibitorpropCount++;
            }

            if (exhibitordoingBusinessAsDisplayOnDrawing != null)
            {
                exhibitor["DoingBusinessAsDisplayOnDrawing"] = ExpressionConverter.ConvertO(exhibitordoingBusinessAsDisplayOnDrawing);
                exhibitorpropCount++;
            }

            if (exhibitoremail != null)
            {
                exhibitor["Email"] = ExpressionConverter.ConvertO(exhibitoremail);
                exhibitorpropCount++;
            }

            exhibitorpropCount++;
            exhibitor["ExhibitorId"] = ExpressionConverter.ConvertO(exhibitorexhibitorId);
            if (exhibitorexhibitorName != null)
            {
                exhibitor["ExhibitorName"] = ExpressionConverter.ConvertO(exhibitorexhibitorName);
                exhibitorpropCount++;
            }

            if (exhibitorexhibitorNameLine2 != null)
            {
                exhibitor["ExhibitorNameLine2"] = ExpressionConverter.ConvertO(exhibitorexhibitorNameLine2);
                exhibitorpropCount++;
            }

            if (exhibitorfax != null)
            {
                exhibitor["Fax"] = ExpressionConverter.ConvertO(exhibitorfax);
                exhibitorpropCount++;
            }

            if (exhibitorfield1 != null)
            {
                exhibitor["Field1"] = ExpressionConverter.ConvertO(exhibitorfield1);
                exhibitorpropCount++;
            }

            if (exhibitorfield2 != null)
            {
                exhibitor["Field2"] = ExpressionConverter.ConvertO(exhibitorfield2);
                exhibitorpropCount++;
            }

            if (exhibitorfield3 != null)
            {
                exhibitor["Field3"] = ExpressionConverter.ConvertO(exhibitorfield3);
                exhibitorpropCount++;
            }

            if (exhibitorfield4 != null)
            {
                exhibitor["Field4"] = ExpressionConverter.ConvertO(exhibitorfield4);
                exhibitorpropCount++;
            }

            if (exhibitorfield5 != null)
            {
                exhibitor["Field5"] = ExpressionConverter.ConvertO(exhibitorfield5);
                exhibitorpropCount++;
            }

            if (exhibitorfield6 != null)
            {
                exhibitor["Field6"] = ExpressionConverter.ConvertO(exhibitorfield6);
                exhibitorpropCount++;
            }

            if (exhibitorfield7 != null)
            {
                exhibitor["Field7"] = ExpressionConverter.ConvertO(exhibitorfield7);
                exhibitorpropCount++;
            }

            if (exhibitorfield8 != null)
            {
                exhibitor["Field8"] = ExpressionConverter.ConvertO(exhibitorfield8);
                exhibitorpropCount++;
            }

            if (exhibitorfield9 != null)
            {
                exhibitor["Field9"] = ExpressionConverter.ConvertO(exhibitorfield9);
                exhibitorpropCount++;
            }

            if (exhibitornickName != null)
            {
                exhibitor["NickName"] = ExpressionConverter.ConvertO(exhibitornickName);
                exhibitorpropCount++;
            }

            if (exhibitorsalutation != null)
            {
                exhibitor["Salutation"] = ExpressionConverter.ConvertO(exhibitorsalutation);
                exhibitorpropCount++;
            }

            if (exhibitortitle != null)
            {
                exhibitor["Title"] = ExpressionConverter.ConvertO(exhibitortitle);
                exhibitorpropCount++;
            }

            if (exhibitorphone != null)
            {
                exhibitor["Phone"] = ExpressionConverter.ConvertO(exhibitorphone);
                exhibitorpropCount++;
            }

            if (exhibitorpostalCode != null)
            {
                exhibitor["PostalCode"] = ExpressionConverter.ConvertO(exhibitorpostalCode);
                exhibitorpropCount++;
            }

            if (exhibitorprimaryGroup != null)
            {
                exhibitor["PrimaryGroup"] = ExpressionConverter.ConvertO(exhibitorprimaryGroup);
                exhibitorpropCount++;
            }

            if (exhibitorpriorityPoints != null)
            {
                exhibitor["PriorityPoints"] = ExpressionConverter.ConvertO(exhibitorpriorityPoints);
                exhibitorpropCount++;
            }

            if (exhibitorproductDescription != null)
            {
                exhibitor["ProductDescription"] = ExpressionConverter.ConvertO(exhibitorproductDescription);
                exhibitorpropCount++;
            }

            if (exhibitorstate != null)
            {
                exhibitor["State"] = ExpressionConverter.ConvertO(exhibitorstate);
                exhibitorpropCount++;
            }

            if (exhibitorwebSite != null)
            {
                exhibitor["WebSite"] = ExpressionConverter.ConvertO(exhibitorwebSite);
                exhibitorpropCount++;
            }

            if (exhibitorpropCount > 0)
            {
                callPayload.Body = exhibitor;
            }

            return new ApiConnectionAction<Exhibitor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> ExhibitorsDeleteExhibitor([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/exhibitors/delete", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Transaction[]> FinancialsGetAllTransactions([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> boothNumber = null, [WorkflowExpression] Func<string> expocadUser = null, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<reversedFilterInput> reversedFilter = null)
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
        public IBodyWorkflowAction<BoothFinancial> FinancialsGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> boothNumber, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/financials/booths", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(boothNumber);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<BoothFinancial>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice> FinancialsGetInvoice([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> invoiceNo = null, [WorkflowExpression] Func<string> exhibitorId = null)
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
        public IBodyWorkflowAction<Invoice[]> FinancialsGetAllInvoices([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/financials/invoices/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Invoice[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<MasterRequestItem[]> FinancialsGetRequestItemList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<string> transactionCode = null)
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
        public IBodyWorkflowAction<InvoiceRequestItem[]> FinancialsGetAssignedRequestItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> invoiceNumber = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> booth = null, [WorkflowExpression] Func<string> glCode = null, [WorkflowExpression] Func<string> transactionCode = null)
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
        public IBodyWorkflowAction<PaymentTypeItem[]> FinancialsGetPaymentTypeList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/financials/paymenttypelist", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<PaymentTypeItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoicePayment[]> FinancialsGetPayments([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> exhibitorId = null, [WorkflowExpression] Func<string> depositId = null, [WorkflowExpression] Func<string> invoiceNumber = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> paymentTypeCategory = null)
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
        public IBodyWorkflowAction<Pavilion[]> PavilionsGetAllPavilions([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/pavilions/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<Pavilion[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansGetDefaultRatePlan([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/rateplans/default", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<RatePlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken> RatePlansSetDefaultRatePlan([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> name)
        {
            var apiCallPath = String.Format("/{0}/rateplans/default", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan[]> RatePlansGetAllRatePlans([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
        {
            var apiCallPath = String.Format("/{0}/rateplans/all", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            return new ApiConnectionAction<RatePlan[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan> RatePlansAddRatePlan([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName, [WorkflowExpression] Func<string> ratePlanname, [WorkflowExpression] Func<string> ratePlanshortCode, [WorkflowExpression] Func<double> ratePlangrossRate, [WorkflowExpression] Func<double> ratePlanfixedDiscountRate, [WorkflowExpression] Func<double> ratePlanpercentDiscountRate, [WorkflowExpression] Func<bool> ratePlanisFixed)
        {
            var apiCallPath = String.Format("/{0}/rateplans/add", ExpressionConverter.ConvertWithUrlEncoding(clientName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["databaseName"] = ExpressionConverter.Convert(databaseName);
            var ratePlan = new JObject();
            var ratePlanpropCount = 0;
            ratePlanpropCount++;
            ratePlan["Name"] = ExpressionConverter.ConvertO(ratePlanname);
            ratePlanpropCount++;
            ratePlan["ShortCode"] = ExpressionConverter.ConvertO(ratePlanshortCode);
            ratePlanpropCount++;
            ratePlan["GrossRate"] = ExpressionConverter.ConvertO(ratePlangrossRate);
            ratePlanpropCount++;
            ratePlan["FixedDiscountRate"] = ExpressionConverter.ConvertO(ratePlanfixedDiscountRate);
            ratePlanpropCount++;
            ratePlan["PercentDiscountRate"] = ExpressionConverter.ConvertO(ratePlanpercentDiscountRate);
            ratePlanpropCount++;
            ratePlan["IsFixed"] = ExpressionConverter.ConvertO(ratePlanisFixed);
            if (ratePlanpropCount > 0)
            {
                callPayload.Body = ratePlan;
            }

            return new ApiConnectionAction<RatePlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ShowInShow[]> ShowInShowsGetAllShowinShows([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> clientName, [WorkflowExpression] Func<string> databaseName)
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