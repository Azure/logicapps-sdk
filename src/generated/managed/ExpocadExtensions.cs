//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Expocad
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExpocadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth, ApiConnectionActionConfiguration> BoothsGet(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Booth>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[], ApiConnectionActionConfiguration> BoothsGetAllBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<deletedFilterInput>> deletedFilter = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_deletedFilter = WorkflowExpression.Compile(deletedFilter, nameof(deletedFilter), required: false);
            return new DeferredBodyAction<Booth[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_deletedFilter != null)
                    callPayload.Queries["deletedFilter"] = ExpressionConverter.Convert(__workflow_deletedFilter);
                return new ApiConnectionAction<Booth[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[], ApiConnectionActionConfiguration> BoothsGetAllAvailableBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/all/available", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Booth[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Booth[], ApiConnectionActionConfiguration> BoothsGetAllRentedBooths(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Booth[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/all/rented", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Booth[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsRentBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> exhibitorId, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlan = null, Expression<Func<string>> status = null, Expression<Func<string>> comment = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_ratePlan = WorkflowExpression.Compile(ratePlan, nameof(ratePlan), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/rent", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(__workflow_exhibitorId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_ratePlan != null)
                    callPayload.Queries["ratePlan"] = ExpressionConverter.Convert(__workflow_ratePlan);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsUnRentBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/unrent", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsHoldBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> exhibitorName = null, Expression<Func<string>> comment = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: false);
            var __workflow_exhibitorName = WorkflowExpression.Compile(exhibitorName, nameof(exhibitorName), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/hold", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(__workflow_exhibitorId);
                if (__workflow_exhibitorName != null)
                    callPayload.Queries["exhibitorName"] = ExpressionConverter.Convert(__workflow_exhibitorName);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsUnHoldBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/unhold", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsRentToHold(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/rentToHold", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsHoldToRent(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName, Expression<Func<string>> ratePlan = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_ratePlan = WorkflowExpression.Compile(ratePlan, nameof(ratePlan), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/holdToRent", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_ratePlan != null)
                    callPayload.Queries["ratePlan"] = ExpressionConverter.Convert(__workflow_ratePlan);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsCombineBooths(Expression<Func<string>> clientName, Expression<Func<string[]>> boothNumbers, Expression<Func<string>> databaseName, Expression<Func<int>> boundary)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumbers = WorkflowExpression.Compile(boothNumbers, nameof(boothNumbers), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_boundary = WorkflowExpression.Compile(boundary, nameof(boundary), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/combine", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Queries["boundary"] = ExpressionConverter.Convert(__workflow_boundary);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsUncombineBooth(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/uncombine", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsDeleteBooths(Expression<Func<string>> clientName, Expression<Func<string[]>> boothNumbers, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumbers = WorkflowExpression.Compile(boothNumbers, nameof(boothNumbers), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/delete", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsUndeleteBooths(Expression<Func<string>> clientName, Expression<Func<string[]>> boothNumbers, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumbers = WorkflowExpression.Compile(boothNumbers, nameof(boothNumbers), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/undelete", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_boothNumbers);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsChangeBoothNumber(Expression<Func<string>> clientName, Expression<Func<string>> oldNumber, Expression<Func<string>> newNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_oldNumber = WorkflowExpression.Compile(oldNumber, nameof(oldNumber), required: true);
            var __workflow_newNumber = WorkflowExpression.Compile(newNumber, nameof(newNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/changenumber", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["oldNumber"] = ExpressionConverter.Convert(__workflow_oldNumber);
                callPayload.Queries["newNumber"] = ExpressionConverter.Convert(__workflow_newNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsSetBoothClass(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/classes/apply", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsClearBoothClass(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/classes/remove", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsSetBoothDisplayName(Expression<Func<string>> clientName, Expression<Func<string>> text, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/displayNameOverride/set", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsClearBoothDisplayName(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/displayNameOverride/reset", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsAddChildExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> childExhibitorId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_childExhibitorId = WorkflowExpression.Compile(childExhibitorId, nameof(childExhibitorId), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/childExhibitor/add", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childExhibitorId"] = ExpressionConverter.Convert(__workflow_childExhibitorId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BoothsRemoveChildExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> childExhibitorId, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_childExhibitorId = WorkflowExpression.Compile(childExhibitorId, nameof(childExhibitorId), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/booths/childExhibitor/remove", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["childExhibitorId"] = ExpressionConverter.Convert(__workflow_childExhibitorId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass, ApiConnectionActionConfiguration> ClassesGet(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothClass, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<BoothClass>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass[], ApiConnectionActionConfiguration> ClassesGetAllBoothClasses(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothClass[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<BoothClass[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass, ApiConnectionActionConfiguration> ClassesCreate(Expression<Func<string>> clientName, Expression<Func<ClassesCreateInput>> boothClass, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothClass = WorkflowExpression.Compile(boothClass, nameof(boothClass), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothClass, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes/add", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_boothClass);
                return new ApiConnectionAction<BoothClass>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothClass, ApiConnectionActionConfiguration> ClassesUpdate(Expression<Func<string>> clientName, Expression<Func<ClassesUpdateInput>> boothClass, Expression<Func<string>> classId, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothClass = WorkflowExpression.Compile(boothClass, nameof(boothClass), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothClass, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes/update", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_boothClass);
                return new ApiConnectionAction<BoothClass>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ClassesDelete(Expression<Func<string>> clientName, Expression<Func<string>> classId, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_classId = WorkflowExpression.Compile(classId, nameof(classId), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/classes/delete", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["classId"] = ExpressionConverter.Convert(__workflow_classId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpocadEvent[], ApiConnectionActionConfiguration> EventsGetAllEvents(Expression<Func<string>> clientName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            return new DeferredBodyAction<ExpocadEvent[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExpocadEvent[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<EventStats, ApiConnectionActionConfiguration> EventsGetEventStatistics(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<EventStats, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events/stats", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<EventStats>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ExpoEventInformation, ApiConnectionActionConfiguration> EventsGetEventInformation(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<ExpoEventInformation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/events/info", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<ExpoEventInformation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor, ApiConnectionActionConfiguration> ExhibitorsGet(Expression<Func<string>> clientName, Expression<Func<string>> id, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Exhibitor, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Exhibitor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor[], ApiConnectionActionConfiguration> ExhibitorsGetAllExhibitors(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Exhibitor[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Exhibitor[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor, ApiConnectionActionConfiguration> ExhibitorsAddExhibitor(Expression<Func<string>> clientName, Expression<Func<ExhibitorsAddExhibitorInput>> exhibitor, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_exhibitor = WorkflowExpression.Compile(exhibitor, nameof(exhibitor), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Exhibitor, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors/add", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exhibitor);
                return new ApiConnectionAction<Exhibitor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Exhibitor, ApiConnectionActionConfiguration> ExhibitorsUpdateExhibitor(Expression<Func<string>> clientName, Expression<Func<ExhibitorsUpdateExhibitorInput>> exhibitor, Expression<Func<string>> id, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_exhibitor = WorkflowExpression.Compile(exhibitor, nameof(exhibitor), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Exhibitor, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors/update", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exhibitor);
                return new ApiConnectionAction<Exhibitor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ExhibitorsDeleteExhibitor(Expression<Func<string>> clientName, Expression<Func<string>> id, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/exhibitors/delete", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Transaction[], ApiConnectionActionConfiguration> FinancialsGetAllTransactions(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> boothNumber = null, Expression<Func<string>> expocadUser = null, Expression<Func<string>> glCode = null, Expression<Func<reversedFilterInput>> reversedFilter = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: false);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: false);
            var __workflow_expocadUser = WorkflowExpression.Compile(expocadUser, nameof(expocadUser), required: false);
            var __workflow_glCode = WorkflowExpression.Compile(glCode, nameof(glCode), required: false);
            var __workflow_reversedFilter = WorkflowExpression.Compile(reversedFilter, nameof(reversedFilter), required: false);
            return new DeferredBodyAction<Transaction[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/transactions", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(__workflow_exhibitorId);
                if (__workflow_boothNumber != null)
                    callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                if (__workflow_expocadUser != null)
                    callPayload.Queries["expocadUser"] = ExpressionConverter.Convert(__workflow_expocadUser);
                if (__workflow_glCode != null)
                    callPayload.Queries["glCode"] = ExpressionConverter.Convert(__workflow_glCode);
                if (__workflow_reversedFilter != null)
                    callPayload.Queries["reversedFilter"] = ExpressionConverter.Convert(__workflow_reversedFilter);
                return new ApiConnectionAction<Transaction[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<BoothFinancial, ApiConnectionActionConfiguration> FinancialsGet(Expression<Func<string>> clientName, Expression<Func<string>> boothNumber, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_boothNumber = WorkflowExpression.Compile(boothNumber, nameof(boothNumber), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<BoothFinancial, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/booths", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["boothNumber"] = ExpressionConverter.Convert(__workflow_boothNumber);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<BoothFinancial>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice, ApiConnectionActionConfiguration> FinancialsGetInvoice(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> invoiceNo = null, Expression<Func<string>> exhibitorId = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_invoiceNo = WorkflowExpression.Compile(invoiceNo, nameof(invoiceNo), required: false);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: false);
            return new DeferredBodyAction<Invoice, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/invoices", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_invoiceNo != null)
                    callPayload.Queries["invoiceNo"] = ExpressionConverter.Convert(__workflow_invoiceNo);
                if (__workflow_exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(__workflow_exhibitorId);
                return new ApiConnectionAction<Invoice>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Invoice[], ApiConnectionActionConfiguration> FinancialsGetAllInvoices(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Invoice[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/invoices/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Invoice[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<MasterRequestItem[], ApiConnectionActionConfiguration> FinancialsGetRequestItemList(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> glCode = null, Expression<Func<string>> transactionCode = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_glCode = WorkflowExpression.Compile(glCode, nameof(glCode), required: false);
            var __workflow_transactionCode = WorkflowExpression.Compile(transactionCode, nameof(transactionCode), required: false);
            return new DeferredBodyAction<MasterRequestItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/requestitemlist", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_glCode != null)
                    callPayload.Queries["glCode"] = ExpressionConverter.Convert(__workflow_glCode);
                if (__workflow_transactionCode != null)
                    callPayload.Queries["transactionCode"] = ExpressionConverter.Convert(__workflow_transactionCode);
                return new ApiConnectionAction<MasterRequestItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoiceRequestItem[], ApiConnectionActionConfiguration> FinancialsGetAssignedRequestItems(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> booth = null, Expression<Func<string>> glCode = null, Expression<Func<string>> transactionCode = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: false);
            var __workflow_invoiceNumber = WorkflowExpression.Compile(invoiceNumber, nameof(invoiceNumber), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_booth = WorkflowExpression.Compile(booth, nameof(booth), required: false);
            var __workflow_glCode = WorkflowExpression.Compile(glCode, nameof(glCode), required: false);
            var __workflow_transactionCode = WorkflowExpression.Compile(transactionCode, nameof(transactionCode), required: false);
            return new DeferredBodyAction<InvoiceRequestItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/requestitems", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_exhibitorId != null)
                    callPayload.Queries["exhibitorId"] = ExpressionConverter.Convert(__workflow_exhibitorId);
                if (__workflow_invoiceNumber != null)
                    callPayload.Queries["invoiceNumber"] = ExpressionConverter.Convert(__workflow_invoiceNumber);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_booth != null)
                    callPayload.Queries["booth"] = ExpressionConverter.Convert(__workflow_booth);
                if (__workflow_glCode != null)
                    callPayload.Queries["glCode"] = ExpressionConverter.Convert(__workflow_glCode);
                if (__workflow_transactionCode != null)
                    callPayload.Queries["transactionCode"] = ExpressionConverter.Convert(__workflow_transactionCode);
                return new ApiConnectionAction<InvoiceRequestItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<PaymentTypeItem[], ApiConnectionActionConfiguration> FinancialsGetPaymentTypeList(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<PaymentTypeItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/paymenttypelist", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<PaymentTypeItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<InvoicePayment[], ApiConnectionActionConfiguration> FinancialsGetPayments(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> exhibitorId = null, Expression<Func<string>> depositId = null, Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> paymentTypeCategory = null)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_exhibitorId = WorkflowExpression.Compile(exhibitorId, nameof(exhibitorId), required: false);
            var __workflow_depositId = WorkflowExpression.Compile(depositId, nameof(depositId), required: false);
            var __workflow_invoiceNumber = WorkflowExpression.Compile(invoiceNumber, nameof(invoiceNumber), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_paymentTypeCategory = WorkflowExpression.Compile(paymentTypeCategory, nameof(paymentTypeCategory), required: false);
            return new DeferredBodyAction<InvoicePayment[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/financials/payments", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                if (__workflow_exhibitorId != null)
                    callPayload.Queries["ExhibitorId"] = ExpressionConverter.Convert(__workflow_exhibitorId);
                if (__workflow_depositId != null)
                    callPayload.Queries["DepositId"] = ExpressionConverter.Convert(__workflow_depositId);
                if (__workflow_invoiceNumber != null)
                    callPayload.Queries["InvoiceNumber"] = ExpressionConverter.Convert(__workflow_invoiceNumber);
                if (__workflow_startDate != null)
                    callPayload.Queries["StartDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_paymentTypeCategory != null)
                    callPayload.Queries["PaymentTypeCategory"] = ExpressionConverter.Convert(__workflow_paymentTypeCategory);
                return new ApiConnectionAction<InvoicePayment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<Pavilion[], ApiConnectionActionConfiguration> PavilionsGetAllPavilions(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<Pavilion[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/pavilions/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<Pavilion[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan, ApiConnectionActionConfiguration> RatePlansGetDefaultRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<RatePlan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/rateplans/default", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<RatePlan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> RatePlansSetDefaultRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<string>> name)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/rateplans/default", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan[], ApiConnectionActionConfiguration> RatePlansGetAllRatePlans(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<RatePlan[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/rateplans/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<RatePlan[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<RatePlan, ApiConnectionActionConfiguration> RatePlansAddRatePlan(Expression<Func<string>> clientName, Expression<Func<string>> databaseName, Expression<Func<RatePlansAddRatePlanInput>> ratePlan)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            var __workflow_ratePlan = WorkflowExpression.Compile(ratePlan, nameof(ratePlan), required: true);
            return new DeferredBodyAction<RatePlan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/rateplans/add", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_ratePlan);
                return new ApiConnectionAction<RatePlan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "expocad")]
        public IBodyWorkflowAction<ShowInShow[], ApiConnectionActionConfiguration> ShowInShowsGetAllShowinShows(Expression<Func<string>> clientName, Expression<Func<string>> databaseName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            var __workflow_databaseName = WorkflowExpression.Compile(databaseName, nameof(databaseName), required: true);
            return new DeferredBodyAction<ShowInShow[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/showinshows/all", __workflow_clientName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["databaseName"] = ExpressionConverter.Convert(__workflow_databaseName);
                return new ApiConnectionAction<ShowInShow[]>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class ClassesCreateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int KeepWhenCombined { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CountAsInventory { get; set; }
        public string Prioritity { get; set; }
        public int? Color { get; set; }
    }

    public class ClassesUpdateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int KeepWhenCombined { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CountAsInventory { get; set; }
        public string Prioritity { get; set; }
        public int? Color { get; set; }
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

    public class ExhibitorsAddExhibitorInput
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

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class ExhibitorsUpdateExhibitorInput
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

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class RatePlansAddRatePlanInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ShortCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double GrossRate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double FixedDiscountRate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double PercentDiscountRate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
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